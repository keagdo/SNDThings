import os
import re
import subprocess
import time

# Path to the folder containing the .cs files
main_path = "D:/SomethingNeedDoing Source/"
pull_path = main_path + "SND Source/"
LuaFunctions_path = pull_path+"SomethingNeedDoing/Macros/LuaFunctions"

# Path to the output Lua file
output_file = main_path+"SND Lua Library/plugin_stubs.lua"
output_matches = main_path+"SND Lua Library/plugin_stubs_matches.cs"

# Path to the PowerShell script to update the repository
powershell_script = ""

# Regular expression to match function declarations (including nullable types and arrow functions)
function_pattern = re.compile(r"(?:public)\s+(?:unsafe|static|)?\s*((?!class)(?:[a-zA-Z0-9\[\],<>]+\??)|(?:\(.*\)\??)|(?:[a-zA-z0-9]+[<(]*[a-zA-z0-9, <(]+[)>]+\??))\s*(\w+)\s*\(([^)]*)\)")

# Regular expression to match parameter types and names, including complex types like Vector3 and List<>
param_pattern = re.compile(r"([a-zA-Z0-9_<>?]+(?:<[^>]+>)?)\s+([a-zA-Z0-9_]+)\s*(?:=\s*[^,)]*)?")

# Regular expression to check for tuple types in return type
tuple_pattern = re.compile(r"\(([^)]+)\)")

# Regular expression to detect `params` keyword
params_pattern = re.compile(r"params\s+[a-zA-Z0-9_<>?]+\[\]")

def convert_function_to_lua(func_name, params, return_type, has_params):
    # Create the parameter annotations in the correct order
    param_str = ""
    for param in params:
        param_type, param_name, is_optional = param
        param_annotation = f"---@param {param_name}{'?' if is_optional else ''} {convert_type(param_type)}\n"
        param_str += param_annotation
    
    # Only add the return annotation if the function has a return type (not void/nil)
    lua_stub = ""
    if return_type != "nil":  # Skip return annotation if return type is void or nil
        lua_stub += f"---@return {return_type}\n"
    
    # Handle the function parameters for variable args (params)
    if has_params:
        lua_stub += f"function {func_name}(...)\n"
    else:
        lua_stub += f"function {func_name}({', '.join([param[1] for param in params])})\n"
    
    # Add the function body placeholder
    lua_stub += "end\n\n"
    
    return param_str + lua_stub

def convert_type(cs_type):
    if cs_type.endswith('?'):
        base_type = cs_type[:-1]
        return f"{convert_type(base_type)}|nil"
    if cs_type == "void":
        return "nil"
    # Combine all collection types and tuples into a single "table" return
    collection_types = ["List", "HashSet", "Dictionary", "Vector"]
    if any(cs_type.startswith(type) for type in collection_types) or tuple_pattern.search(cs_type):
        return "userdata"
    elif cs_type == "bool":
        return "boolean"
    # Handle number types (int, uint, etc.)
    number_types = ["int", "float", "long", "byte", "short"]
    u_number_types = [f"u{type}" for type in number_types]
    all_number_types = number_types + u_number_types
    if cs_type in all_number_types:
        return "number"
    elif cs_type == "string":
        return "string"
    else:
        return "unknown"

def process_cs_file(file_path):
    matched_lines = ""
    lua_stubs = ""
    
    with open(file_path, 'r', encoding='utf-8') as file:
        lines = file.readlines()
    
    for line in lines:
        # Check if the line contains a function definition using regex
        match = function_pattern.search(line)
        if match:
            return_type = match.group(1)  # The first captured group is the return type
            func_name = match.group(2)
            params_str = match.group(3)
            
            # Check if the function uses params (variable arguments)
            has_params = bool(params_pattern.search(line))
            
            # Extract parameters from the function signature
            params = []
            if params_str:
                for param in params_str.split(","):
                    param = param.strip()
                    param_match = param_pattern.match(param)
                    if param_match:
                        param_type = param_match.group(1)
                        param_name = param_match.group(2)
                        # Check if the parameter has a default value
                        is_optional = '=' in param
                        params.append((param_type, param_name, is_optional))
            
            # Convert function to Lua and add it to the output
            lua_stubs += convert_function_to_lua(func_name, params, convert_type(return_type), has_params)
            matched_lines += line
    
    return lua_stubs, matched_lines


def git_pull(directory):
    try:
        # Navigate to the given directory and run 'git pull'
        command = f"cd '{directory}'; git pull"
        result = subprocess.run(["powershell", "-Command", command],check=True,capture_output=True,text=True)
        print("Git pull completed successfully.")
        print(result.stdout)
        return result
    except subprocess.CalledProcessError as e:
        print(f"Error running git pull: {e}")
        print(e.stderr)
        return None

def main():
    # Step 1: Run the PowerShell script to update the repository
    print(f"Running git pull")
    result = git_pull(pull_path)
    if result is None:
        print("Error: PowerShell script did not complete successfully. Exiting.")
        return
    
    lua_stubs = "---@diagnostic disable: missing-return, undefined-doc-param\n"
    matched_lines = ""

    # Step 2: Loop through all files in the folder and process .cs files
    for root, dirs, files in os.walk(LuaFunctions_path):
        for file in files:
            if file.endswith(".cs"):
                file_path = os.path.join(root, file)
                # print(f"Processing file: {file_path}")
                result = process_cs_file(file_path)
                lua_stubs += result[0]
                matched_lines += result[1]
    
    # Step 3: Count the functions in the final Lua stubs
    function_count = lua_stubs.count("function")
    
    # Step 4: Append the specified function to the end of the file
    lua_stubs += "---@param text string\nfunction yield(text) end\n"

    # Step 5: Write the Lua stubs to the output file
    with open(output_file, 'w', encoding='utf-8') as output:
        output.write(lua_stubs)
    with open(output_matches, 'w', encoding='utf-8') as output:
        output.write(matched_lines)

    print(f"\n{function_count + 1} functions processed.")
    print("Please add " + output_file + " as a Lua Library for the workspace")

if __name__ == "__main__":
    start_time = time.time()
    main()
    end_time = time.time()
    elapsed_time = end_time - start_time
    print(f"Script executed in {elapsed_time:.4f} seconds")