--First select what extreme you want to queue into. I suggest Bowl Of Embers (Extreme)
--Then find a rotation that works put it where the rotation goes.
--Plug in your current light value.

--Pray your rotation is consistent and the code works well enough. 

light = 0

CharacterCondition = {
    dead=2,
    mounted=4,
    inCombat=26,
    casting=27,
    occupied31=31,
    occupied=33,
    boundByDuty34=34,
    betweenAreas=45,
    jumping48=48,
    jumping61=61,
    mounting57=57,
    mounting64=64,
    beingmoved70=70,
    beingmoved75=75,
    flying=77
}

function main()
    repeat 
        yield("/dutyfinder")
        yield("/wait 2")
    until IsAddonVisible("ContentsFinder")
        yield("/pcall ContentsFinder True 12 0")
    repeat
        yield("/wait 0.1")
    until IsAddonVisible("ContentsFinderConfirm")
        yield("/pcall ContentsFinderConfirm True 8")
    yield("/wait 10")
    while GetCharacterCondition(CharacterCondition.betweenAreas) do
        LogInfo("[FATE] Teleporting...")
        yield("/wait 1")
    end
    yield("/vnav moveto -0.7 0 0")
    yield('/ac "Presence of Mind"')
    repeat
        yield("/wait 0.1")
    until not PathIsRunning()

    --ROTATION GOES HERE
    yield('/ac "Glare IV"')
    yield('/wait 2')
    yield('/ac "Glare IV"')
    yield('/wait 1')
    yield('/ac "Assize"')
    yield('/wait 1')
    yield('/ac "Glare IV"')

    --ROTATION ENDS HERE
    repeat
        yield("/wait 0.1")
    until not GetCharacterCondition(CharacterCondition.inCombat)
    yield("/rotation off")
    yield("/pdfleave")
    repeat
        yield("/wait 0.1")
    until IsInZone(GetFlagZone())
    yield("/wait 2")
end


while light <= 2000 do
    main()
    light = light + 32
    yield("/echo Light Count: " .. light .. "/2000")
end