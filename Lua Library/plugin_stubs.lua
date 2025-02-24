---@diagnostic disable: missing-return, undefined-doc-param
---@return userdata
function ListAllFunctions()
end

function LeaveDuty()
end

---@param useTickets? boolean
function TeleportToGCTown(useTickets)
end

---@param actionId number
---@return number
function GetRecastTimeElapsed(actionId)
end

---@param actionId number
---@return number
function GetRealRecastTimeElapsed(actionId)
end

---@param actionId number
---@return number
function GetRecastTime(actionId)
end

---@param actionId number
---@return number
function GetRealRecastTime(actionId)
end

---@param actionId number
---@return number
function GetSpellCooldown(actionId)
end

---@param actionId number
---@return number
function GetRealSpellCooldown(actionId)
end

---@param actionId number
---@return number
function GetSpellCooldownInt(actionId)
end

---@param maxStacks number
---@param actionId number
---@return number
function GetActionStackCount(maxStacks, actionId)
end

---@param actionID number
function ExecuteAction(actionID)
end

---@param actionID number
function ExecuteGeneralAction(actionID)
end

---@return userdata
function ListAllFunctions()
end

---@param contentRouletteID number
function OpenRouletteDuty(contentRouletteID)
end

---@param cfcID number
function OpenRegularDuty(cfcID)
end

---@param dutyCode number
function SelectDuty(dutyCode)
end

---@param state boolean
function SetDFLanguageJ(state)
end

---@param state boolean
function SetDFLanguageE(state)
end

---@param state boolean
function SetDFLanguageD(state)
end

---@param state boolean
function SetDFLanguageF(state)
end

---@param state boolean
function SetDFJoinInProgress(state)
end

---@param state boolean
function SetDFUnrestricted(state)
end

---@param state boolean
function SetDFLevelSync(state)
end

---@param state boolean
function SetDFMinILvl(state)
end

---@param state boolean
function SetDFSilenceEcho(state)
end

---@param state boolean
function SetDFExplorerMode(state)
end

---@param state boolean
function SetDFLimitedLeveling(state)
end

---@return number
function GetDiademAetherGaugeBarCount()
end

---@return number
function GetDDPassageProgress()
end

---@param addonName string
---@return boolean
function IsAddonVisible(addonName)
end

---@param addonName string
---@return boolean
function IsAddonReady(addonName)
end

---@param addonName string
---@param int unknown
---@return boolean
function IsNodeVisible(...)
end

function GetClicks()
end

---@param index number
---@param int unknown
---@return string
function GetToastNodeText(...)
end

---@param addonName string
---@param int unknown
---@return string
function GetNodeText(...)
end

---@param addonName string
---@param text string
---@param int unknown
function SetNodeText(...)
end

---@param index number
---@return string
function GetSelectStringText(index)
end

---@param index number
---@return string
function GetSelectIconStringText(index)
end

---@param addonName string
---@return number
function GetNodeListCount(addonName)
end

---@return userdata
function ListAllFunctions()
end

---@return boolean
function IsPlayerAvailable()
end

---@param statusName string
---@return boolean
function HasStatus(statusName)
end

---@param uint unknown
---@return boolean
function HasStatusId(...)
end

---@param statusID number
---@return number
function GetStatusStackCount(statusID)
end

---@param statusID number
---@return number
function GetStatusTimeRemaining(statusID)
end

---@param statusID number
---@return number
function GetStatusSourceID(statusID)
end

---@param flagID number
---@param hasCondition? boolean
---@return boolean
function GetCharacterCondition(flagID, hasCondition)
end

---@param includeWorld? boolean
---@return string
function GetCharacterName(includeWorld)
end

---@param zoneID number
---@return boolean
function IsInZone(zoneID)
end

---@return boolean
function IsLocalPlayerNull()
end

---@return boolean
function IsPlayerDead()
end

---@return boolean
function IsPlayerCasting()
end

---@return boolean
function IsLevelSynced()
end

---@return boolean
function IsMoving()
end

---@return boolean
function IsPlayerOccupied()
end

---@return number
function GetGil()
end

---@return number
function GetClassJobId()
end

---@return number
function GetHP()
end

---@return number
function GetMaxHP()
end

---@return number
function GetShieldPercentage()
end

---@return number
function GetMP()
end

---@return number
function GetMaxMP()
end

---@return number
function GetCurrentWorld()
end

---@return number
function GetHomeWorld()
end

---@param character? string
---@return number
function GetPlayerRawXPos(character)
end

---@param character? string
---@return number
function GetPlayerRawYPos(character)
end

---@param character? string
---@return number
function GetPlayerRawZPos(character)
end

---@param expArrayIndex? number
---@return number
function GetLevel(expArrayIndex)
end

---@return number
function GetPlayerGC()
end

---@return number
function GetFCRank()
end

---@return string
function GetFCGrandCompany()
end

---@return number
function GetFCOnlineMembers()
end

---@return number
function GetFCTotalMembers()
end

---@param id number
function RequestAchievementProgress(id)
end

---@return number
function GetRequestedAchievementProgress()
end

---@param id number
---@return boolean
function IsAchievementComplete(id)
end

---@return number
function GetCurrentBait()
end

---@return number
function GetLimitBreakCurrentValue()
end

---@return number
function GetLimitBreakBarValue()
end

---@return number
function GetLimitBreakBarCount()
end

---@return number
function GetPenaltyRemainingInMinutes()
end

---@return number
function GetMaelstromGCRank()
end

---@return number
function GetFlamesGCRank()
end

---@return number
function GetAddersGCRank()
end

---@param rank number
function SetMaelstromGCRank(rank)
end

---@param rank number
function SetFlamesGCRank(rank)
end

---@param rank number
function SetAddersGCRank(rank)
end

---@param territory? number
---@return boolean
function HasFlightUnlocked(territory)
end

---@return boolean
function TerritorySupportsMounting()
end

---@return boolean
function InSanctuary()
end

---@return boolean
function HasWeeklyBingoJournal()
end

---@return boolean
function IsWeeklyBingoExpired()
end

---@return number
function WeeklyBingoNumSecondChancePoints()
end

---@return number
function WeeklyBingoNumPlacedStickers()
end

---@param wonderousTailsIndex number
---@return number
function GetWeeklyBingoTaskStatus(wonderousTailsIndex)
end

---@param wonderousTailsIndex number
---@return number
function GetWeeklyBingoOrderDataKey(wonderousTailsIndex)
end

---@param wonderousTailsKey number
---@return number
function GetWeeklyBingoOrderDataType(wonderousTailsKey)
end

---@param wonderousTailsKey number
---@return number
function GetWeeklyBingoOrderDataData(wonderousTailsKey)
end

---@param wonderousTailsKey number
---@return string
function GetWeeklyBingoOrderDataText(wonderousTailsKey)
end

---@param id number
---@return boolean
function IsAetheryteUnlocked(id)
end

---@return userdata
function GetAetheryteList()
end

---@param zoneID number
---@return userdata
function GetAetherytesInZone(zoneID)
end

---@param aetheryteID number
---@return string
function GetAetheryteName(aetheryteID)
end

---@param worldId number
---@return boolean
function IsFriendOnline(worldId)
end

---@param classjob number
---@return number
function GetJobExp(classjob)
end

---@return number
function GetPlayerContentId()
end

---@return number
function GetPlayerAccountId()
end

---@return userdata
function ListAllFunctions()
end

---@return boolean
function IsCrafting()
end

---@return boolean
function IsNotCrafting()
end

---@return boolean
function IsCollectable()
end

---@param lower? boolean
---@return string
function GetCondition(lower)
end

---@param condition string
---@param lower? boolean
---@return boolean
function HasCondition(condition, lower)
end

---@return number
function GetProgress()
end

---@return number
function GetMaxProgress()
end

---@return boolean
function HasMaxProgress()
end

---@return number
function GetQuality()
end

---@return number
function GetMaxQuality()
end

---@return boolean
function HasMaxQuality()
end

---@return number
function GetDurability()
end

---@return number
function GetMaxDurability()
end

---@return number
function GetCp()
end

---@return number
function GetMaxCp()
end

---@return number
function GetGp()
end

---@return number
function GetMaxGp()
end

---@return number
function GetStep()
end

---@return number
function GetPercentHQ()
end

---@param below? number
---@return boolean
function NeedsRepair(below)
end

---@param within? number
---@return boolean
function CanExtractMateria(within)
end

---@param craftsmanship number
---@param control number
---@param cp number
---@return boolean
function HasStats(craftsmanship, control, cp)
end

---@param actionID number
---@return number
function GetProgressIncrease(actionID)
end

---@param actionID number
---@return number
function GetQualityIncrease(actionID)
end

---@return userdata
function ListAllFunctions()
end

---@param x number
---@param y number
---@param z number
---@return number
function GetDistanceToPoint(x, y, z)
end

---@return string
function GetTargetName()
end

---@return number
function GetTargetWorldId()
end

---@return string
function GetTargetWorldName()
end

---@return number
function GetTargetRawXPos()
end

---@return number
function GetTargetRawYPos()
end

---@return number
function GetTargetRawZPos()
end

---@return boolean
function IsTargetCasting()
end

---@return number
function GetTargetActionID()
end

---@return number
function GetTargetHP()
end

---@return number
function GetTargetMaxHP()
end

---@return number
function GetTargetHPP()
end

---@return number
function GetTargetRotation()
end

---@return number|nil
function GetTargetObjectKind()
end

---@return number|nil
function GetTargetSubKind()
end

---@param distance? number
function TargetClosestEnemy(distance)
end

---@param distance? number
function TargetClosestFateEnemy(distance)
end

function ClearTarget()
end

---@return number
function GetDistanceToTarget()
end

---@param statusID number
---@return boolean
function TargetHasStatus(statusID)
end

---@return number
function GetTargetFateID()
end

---@return boolean
function IsTargetMounted()
end

---@return boolean
function IsTargetInCombat()
end

---@return number
function GetTargetHuntRank()
end

---@return number
function GetTargetHitboxRadius()
end

---@return boolean
function HasTarget()
end

---@return string
function GetFocusTargetName()
end

---@return number
function GetFocusTargetRawXPos()
end

---@return number
function GetFocusTargetRawYPos()
end

---@return number
function GetFocusTargetRawZPos()
end

---@return boolean
function IsFocusTargetCasting()
end

---@return number
function GetFocusTargetActionID()
end

---@return number
function GetFocusTargetHP()
end

---@return number
function GetFocusTargetMaxHP()
end

---@return number
function GetFocusTargetHPP()
end

---@return number
function GetFocusTargetRotation()
end

function ClearFocusTarget()
end

---@return number
function GetDistanceToFocusTarget()
end

---@param statusID number
---@return boolean
function FocusTargetHasStatus(statusID)
end

---@return number
function GetFocusTargetFateID()
end

---@param name string
---@return number
function GetObjectRawXPos(name)
end

---@param name string
---@return number
function GetObjectRawYPos(name)
end

---@param name string
---@return number
function GetObjectRawZPos(name)
end

---@param name string
---@return number
function GetDistanceToObject(name)
end

---@param name string
---@return boolean
function IsObjectCasting(name)
end

---@param name string
---@return number
function GetObjectActionID(name)
end

---@param name string
---@return number
function GetObjectHP(name)
end

---@param name string
---@return number
function GetObjectMaxHP(name)
end

---@param name string
---@return number
function GetObjectHPP(name)
end

---@param name string
---@return number
function GetObjectRotation(name)
end

---@param name string
---@param statusID number
---@return boolean
function ObjectHasStatus(name, statusID)
end

---@param name string
---@return number
function GetObjectFateID(name)
end

---@param name string
---@return boolean
function DoesObjectExist(name)
end

---@param name string
---@return boolean
function IsObjectMounted(name)
end

---@param name string
---@return number
function GetObjectDataID(name)
end

---@param name string
---@return boolean
function IsObjectInCombat(name)
end

---@param name string
---@return number
function GetObjectHuntRank(name)
end

---@param name string
---@return number
function GetObjectHitboxRadius(name)
end

---@param index number
---@return string
function GetPartyMemberName(index)
end

---@param index number
---@return number
function GetPartyMemberWorldId(index)
end

---@param index number
---@return string
function GetPartyMemberWorldName(index)
end

---@param index number
---@return number
function GetPartyMemberRawXPos(index)
end

---@param index number
---@return number
function GetPartyMemberRawYPos(index)
end

---@param index number
---@return number
function GetPartyMemberRawZPos(index)
end

---@param index number
---@return number
function GetDistanceToPartyMember(index)
end

---@param index number
---@return boolean
function IsPartyMemberCasting(index)
end

---@param index number
---@return number
function GetPartyMemberActionID(index)
end

---@param index number
---@return number
function GetPartyMemberHP(index)
end

---@param index number
---@return number
function GetPartyMemberMaxHP(index)
end

---@param index number
---@return number
function GetPartyMemberHPP(index)
end

---@param index number
---@return number
function GetPartyMemberRotation(index)
end

---@param index number
---@param statusID number
---@return boolean
function PartyMemberHasStatus(index, statusID)
end

---@param index number
---@return boolean
function IsPartyMemberMounted(index)
end

---@param index number
---@return boolean
function IsPartyMemberInCombat(index)
end

---@return number
function GetPartyLeadIndex()
end

---@return number
function GetBuddyTimeRemaining()
end

---@return userdata
function ListAllFunctions()
end

---@param name string
---@return string|nil
function InternalGetMacroText(name)
end

---@param key string
---@param value string
function SetSNDProperty(key, value)
end

---@param key string
---@return unknown|nil
function GetSNDProperty(key)
end

---@return boolean
function IsPauseLoopSet()
end

---@return boolean
function IsStopLoopSet()
end

---@return string
function GetActiveMacroName()
end

---@param name string
---@return boolean
function IsMacroRunningOrQueued(name)
end

---@return userdata
function ListAllFunctions()
end

---@param itemID number
---@param includeHQ? boolean
---@return number
function GetItemCount(itemID, includeHQ)
end

---@param itemID number
---@param container number
---@return number
function GetItemCountInContainer(itemID, container)
end

---@return number
function GetInventoryFreeSlotCount()
end

---@param container number
---@param slot number
---@return number
function GetItemIdInSlot(container, slot)
end

---@param container number
---@param slot number
---@return number
function GetItemCountInSlot(container, slot)
end

---@param container number
---@return userdata
function GetItemIdsInContainer(container)
end

---@param container number
---@return number
function GetFreeSlotsInContainer(container)
end

---@param itemID number
---@param srcContainer number
---@param dstContainer number
function MoveItemToContainer(itemID, srcContainer, dstContainer)
end

---@return userdata
function GetTradeableWhiteItemIDs()
end

---@return userdata
function ListAllFunctions()
end

---@param feature string
---@return boolean|nil
function PandoraGetFeatureEnabled(feature)
end

---@param feature string
---@param config string
---@return boolean|nil
function PandoraGetFeatureConfigEnabled(feature, config)
end

---@param feature string
---@param state boolean
function PandoraSetFeatureState(feature, state)
end

---@param feature string
---@param config string
---@param state boolean
function PandoraSetFeatureConfigState(feature, config, state)
end

---@param feature string
---@param ms number
function PandoraPauseFeature(feature, ms)
end

---@param state boolean
function SetAutoHookState(state)
end

---@param state boolean
function SetAutoHookAutoGigState(state)
end

---@param size number
function SetAutoHookAutoGigSize(size)
end

---@param speed number
function SetAutoHookAutoGigSpeed(speed)
end

---@param preset string
function SetAutoHookPreset(preset)
end

---@param preset string
function UseAutoHookAnonymousPreset(preset)
end

function DeletedSelectedAutoHookPreset()
end

function DeleteAllAutoHookAnonymousPresets()
end

---@return boolean
function DeliverooIsTurnInRunning()
end

---@return boolean
function QuestionableIsRunning()
end

---@return string
function QuestionableGetCurrentQuestId()
end

---@return boolean
function IsVislandRouteRunning()
end

---@return boolean
function VislandIsRoutePaused()
end

---@param state boolean
function VislandSetRoutePaused(state)
end

function VislandStopRoute()
end

---@param route string
---@param once boolean
function VislandStartRoute(route, once)
end

---@return boolean
function NavIsReady()
end

---@return number
function NavBuildProgress()
end

function NavReload()
end

function NavRebuild()
end

---@param x number
---@param y number
---@param z number
---@param fly? boolean
function NavPathfind(x, y, z, fly)
end

---@return boolean
function NavIsAutoLoad()
end

---@param state boolean
function NavSetAutoLoad(state)
end

---@param x number
---@param y number
---@param z number
---@param halfExtentXZ number
---@param halfExtentY number
---@return number|nil
function QueryMeshNearestPointX(x, y, z, halfExtentXZ, halfExtentY)
end

---@param x number
---@param y number
---@param z number
---@param halfExtentXZ number
---@param halfExtentY number
---@return number|nil
function QueryMeshNearestPointY(x, y, z, halfExtentXZ, halfExtentY)
end

---@param x number
---@param y number
---@param z number
---@param halfExtentXZ number
---@param halfExtentY number
---@return number|nil
function QueryMeshNearestPointZ(x, y, z, halfExtentXZ, halfExtentY)
end

---@param x number
---@param y number
---@param z number
---@param allowUnlandable boolean
---@param halfExtentXZ number
---@return number|nil
function QueryMeshPointOnFloorX(x, y, z, allowUnlandable, halfExtentXZ)
end

---@param x number
---@param y number
---@param z number
---@param allowUnlandable boolean
---@param halfExtentXZ number
---@return number|nil
function QueryMeshPointOnFloorY(x, y, z, allowUnlandable, halfExtentXZ)
end

---@param x number
---@param y number
---@param z number
---@param allowUnlandable boolean
---@param halfExtentXZ number
---@return number|nil
function QueryMeshPointOnFloorZ(x, y, z, allowUnlandable, halfExtentXZ)
end

---@param x number
---@param y number
---@param z number
---@param fly? boolean
function PathMoveTo(x, y, z, fly)
end

function PathStop()
end

---@return boolean
function PathIsRunning()
end

---@return number
function PathNumWaypoints()
end

---@return boolean
function PathGetMovementAllowed()
end

---@param state boolean
function PathSetMovementAllowed(state)
end

---@return boolean
function PathGetAlignCamera()
end

---@param state boolean
function PathSetAlignCamera(state)
end

---@return number
function PathGetTolerance()
end

---@param t number
function PathSetTolerance(t)
end

---@param x number
---@param y number
---@param z number
---@param fly? boolean
function PathfindAndMoveTo(x, y, z, fly)
end

---@return boolean
function PathfindInProgress()
end

---@param state boolean
function ARSetSuppressed(state)
end

---@return userdata
function ARGetRegisteredCharacters()
end

---@return userdata
function ARGetRegisteredEnabledCharacters()
end

---@return userdata
function ARGetRegisteredRetainers()
end

---@return userdata
function ARGetRegisteredEnabledRetainers()
end

---@param allCharacters? boolean
---@return boolean
function ARAnyWaitingToBeProcessed(allCharacters)
end

---@param allCharacters? boolean
---@return boolean
function ARRetainersWaitingToBeProcessed(allCharacters)
end

---@param allCharacters? boolean
---@return boolean
function ARSubsWaitingToBeProcessed(allCharacters)
end

function ARFinishCharacterPostProcess()
end

---@return userdata
function ARGetCharacterCIDs()
end

---@return boolean
function ARGetMultiModeEnabled()
end

---@param value boolean
function ARSetMultiModeEnabled(value)
end

---@return boolean
function ARIsBusy()
end

---@return number
function ARGetInventoryFreeSlotCount()
end

---@return userdata
function ARGetEnabledRetainers()
end

---@return boolean
function ARAreAnyRetainersAvailableForCurrentChara()
end

function ARAbortAllTasks()
end

function ARDisableAllFunctions()
end

function AREnableMultiMode()
end

function AREnqueueHET()
end

---@return boolean
function ARCanAutoLogin()
end

---@param charaNameWithWorld string
---@return boolean
function ARRelog(charaNameWithWorld)
end

---@return boolean
function ARGetOptionRetainerSense()
end

---@param value boolean
function ARSetOptionRetainerSense(value)
end

---@return number
function ARGetOptionRetainerSenseThreshold()
end

---@param value number
function ARSetOptionRetainerSenseThreshold(value)
end

---@param cid number
---@return number|nil
function ARGetClosestRetainerVentureSecondsRemaining(cid)
end

function AREnqueueInitiation()
end

---@return userdata|nil
function ARGetGCInfo()
end

function PauseYesAlready()
end

function RestoreYesAlready()
end

function DropboxStart()
end

function DropboxStop()
end

---@return boolean
function DropboxIsBusy()
end

---@param id number
---@param hq boolean
---@return number
function DropboxGetItemQuantity(id, hq)
end

---@param id number
---@param hq boolean
---@param quantity number
function DropboxSetItemQuantity(id, hq, quantity)
end

---@param aethernetName string
---@return boolean
function LifestreamAethernetTeleport(aethernetName)
end

---@param destination number
---@param subIndex number
---@return boolean
function LifestreamTeleport(destination, subIndex)
end

---@return boolean
function LifestreamTeleportToHome()
end

---@return boolean
function LifestreamTeleportToFC()
end

---@return boolean
function LifestreamTeleportToApartment()
end

---@return boolean
function LifestreamIsBusy()
end

---@param command string
function LifestreamExecuteCommand(command)
end

function LifestreamAbort()
end

---@param nameId number
function RSRAddPriorityNameID(nameId)
end

---@param nameId number
function RSRRemovePriorityNameID(nameId)
end

---@param nameId number
function RSRAddBlacklistNameID(nameId)
end

---@param nameId number
function RSRRemoveBlacklistNameID(nameId)
end

---@param stateCommand number
function RSRChangeOperatingMode(stateCommand)
end

---@param specialCommand number
function RSRTriggerSpecialState(specialCommand)
end

---@return boolean
function ArtisanGetEnduranceStatus()
end

---@param state boolean
function ArtisanSetEnduranceStatus(state)
end

---@return boolean
function ArtisanIsListRunning()
end

---@return boolean
function ArtisanIsListPaused()
end

---@param state boolean
function ArtisanSetListPause(state)
end

---@return boolean
function ArtisanGetStopRequest()
end

---@param state boolean
function ArtisanSetStopRequest(state)
end

---@param recipeID number
---@param amount number
function ArtisanCraftItem(recipeID, amount)
end

---@return userdata
function ARDiscardGetItemsToDiscard()
end

function ADListConfig()
end

---@param config string
---@return string|nil
function ADGetConfig(config)
end

---@param config string
---@param setting string
function ADSetConfig(config, setting)
end

---@param territoryType number
---@param loops? number
---@param bareMode? boolean
function ADRun(territoryType, loops, bareMode)
end

---@param startFromZero? boolean
function ADStart(startFromZero)
end

function ADStop()
end

---@return boolean|nil
function ADIsNavigating()
end

---@return boolean|nil
function ADIsLooping()
end

---@return boolean|nil
function ADIsStopped()
end

---@param territoryType number
---@return boolean|nil
function ADContentHasPath(territoryType)
end

---@param inventoryType number
---@param characterId number|nil
---@return number
function ATInventoryCountByType(inventoryType, characterId)
end

---@param characterId number|nil
---@return number
function ATInventoryCountByTypes(characterId)
end

---@param itemId number
---@param characterId number
---@param inventoryType number
---@return number
function ATItemCount(itemId, characterId, inventoryType)
end

---@param itemId number
---@param characterId number
---@param inventoryType number
---@return number
function ATItemCountHQ(itemId, characterId, inventoryType)
end

---@param itemId number
---@param currentCharacterOnly boolean
---@return number
function ATItemCountOwned(itemId, currentCharacterOnly)
end

---@param filterKey string
---@return boolean
function ATEnableUiFilter(filterKey)
end

---@return boolean
function ATDisableUiFilter()
end

---@param filterKey string
---@return boolean
function ATToggleUiFilter(filterKey)
end

---@param filterKey string
---@return boolean
function ATEnableBackgroundFilter(filterKey)
end

---@return boolean
function ATDisableBackgroundFilter()
end

---@param filterKey string
---@return boolean
function ATToggleBackgroundFilter(filterKey)
end

---@param filterKey string
---@return boolean
function ATEnableCraftList(filterKey)
end

---@return boolean
function ATDisableCraftList()
end

---@param filterKey string
---@return boolean
function ATToggleCraftList(filterKey)
end

---@param filterKey string
---@param itemId number
---@param quantity number
---@return boolean
function ATAddItemToCraftList(filterKey, itemId, quantity)
end

---@param filterKey string
---@param itemId number
---@param quantity number
---@return boolean
function ATRemoveItemFromCraftList(filterKey, itemId, quantity)
end

---@param filterKey string
---@return userdata
function ATGetFilterItems(filterKey)
end

---@param filterKey string
---@return userdata
function ATGetCraftItems(filterKey)
end

---@return userdata
function ATGetRetrievalItems()
end

---@param characterId number
---@return userdata
function ATGetCharacterItems(characterId)
end

---@param includeOwner boolean
---@return userdata
function ATGetCharactersOwnedByActive(includeOwner)
end

---@param characterId number
---@param inventoryType number
---@return userdata
function ATGetCharacterItemsByType(characterId, inventoryType)
end

---@return userdata
function ATGetCraftLists()
end

---@return userdata
function ATGetSearchFilters()
end

---@param craftListName string
---@param items unknown
---@return string
function ATAddNewCraftList(craftListName, items)
end

---@return number|nil
function ATCurrentCharacter()
end

---@return boolean
function ATIsInitialized()
end

---@param name string
---@return string|nil
function BMGet(name)
end

---@param presetSerialized string
---@param overwrite boolean
---@return boolean
function BMCreate(presetSerialized, overwrite)
end

---@param name string
---@return boolean
function BMDelete(name)
end

---@return string
function BMGetActive()
end

---@param name string
---@return boolean
function BMSetActive(name)
end

---@return boolean
function BMClearActive()
end

---@return boolean
function BMGetForceDisabled()
end

---@return boolean
function BMSetForceDisabled()
end

---@param presetName string
---@param moduleTypeName string
---@param trackName string
---@param value string
---@return boolean
function BMAddTransientStrategy(presetName, moduleTypeName, trackName, value)
end

---@param presetName string
---@param moduleTypeName string
---@param trackName string
---@param value string
---@param oid number
---@return boolean
function BMAddTransientStrategyTargetEnemyOID(presetName, moduleTypeName, trackName, value, oid)
end

---@return userdata
function ListAllFunctions()
end

---@param id number
---@return string
function GetQuestNameByID(id)
end

---@param id number
---@return boolean
function IsQuestAccepted(id)
end

---@return userdata
function GetAcceptedQuests()
end

---@param id number
---@return boolean
function IsQuestComplete(id)
end

---@param id number
---@return number
function GetQuestSequence(id)
end

---@param name string
---@return number|nil
function GetQuestIDByName(name)
end

---@param id number
---@return string
function GetQuestAlliedSociety(id)
end

---@param id number
---@return boolean
function IsLeveAccepted(id)
end

---@param index number
---@return unknown
function GetMonsterNoteRankInfo(index)
end

---@return userdata
function ListAllFunctions()
end

---@return string
function GetClipboard()
end

---@param text string
function SetClipboard(text)
end

function CrashTheGame()
end

---@param text unknown
function LogInfo(text)
end

---@param text unknown
function LogDebug(text)
end

---@param text unknown
function LogVerbose(text)
end

---@param name string
---@return boolean
function HasPlugin(name)
end

---@return userdata
function ListAllFunctions()
end

---@return number
function GetZoneID()
end

---@param zoneID number
---@return string
function GetZoneName(zoneID)
end

---@return number
function GetFlagXCoord()
end

---@return number
function GetFlagYCoord()
end

---@return number
function GetFlagZone()
end

---@param territory number
---@param worldX number
---@param worldY number
---@param worldZ number
function SetMapFlag(territory, worldX, worldY, worldZ)
end

---@return number
function GetActiveWeatherID()
end

---@return number
function GetCurrentEorzeaTimestamp()
end

---@return number
function GetCurrentEorzeaSecond()
end

---@return number
function GetCurrentEorzeaMinute()
end

---@return number
function GetCurrentEorzeaHour()
end

---@return userdata
function GetActiveFates()
end

---@return number
function GetNearestFate()
end

---@return boolean
function IsInFate()
end

---@param fateID number
---@return string
function GetFateState(fateID)
end

---@param fateID number
---@return number
function GetFateStartTimeEpoch(fateID)
end

---@param fateID number
---@return number
function GetFateDuration(fateID)
end

---@param fateID number
---@return string
function GetFateName(fateID)
end

---@param fateID number
---@return number
function GetFateHandInCount(fateID)
end

---@param fateID number
---@return number
function GetFateLocationX(fateID)
end

---@param fateID number
---@return number
function GetFateLocationY(fateID)
end

---@param fateID number
---@return number
function GetFateLocationZ(fateID)
end

---@param fateID number
---@return number
function GetFateProgress(fateID)
end

---@param fateID number
---@return boolean
function GetFateIsBonus(fateID)
end

---@param fateID number
---@return number
function GetFateRadius(fateID)
end

---@param fateID number
---@return number
function GetFateIconId(fateID)
end

---@param fateID number
---@return number
function GetFateLevel(fateID)
end

---@param fateID number
---@return number
function GetFateMaxLevel(fateID)
end

---@param fateID number
---@return number
function GetFateChain(fateID)
end

---@param fateID number
---@return number
function GetFateEventItem(fateID)
end

---@param x1 number
---@param y1 number
---@param z1 number
---@param x2 number
---@param y2 number
---@param z2 number
---@return number
function DistanceBetween(x1, y1, z1, x2, y2, z2)
end

---@return number
function GetContentTimeLeft()
end

---@return number
function GetZoneInstance()
end

---@return number
function GetCurrentOceanFishingRoute()
end

---@return number
function GetCurrentOceanFishingTimeOfDay()
end

---@return number
function GetCurrentOceanFishingStatus()
end

---@return number
function GetCurrentOceanFishingZone()
end

---@return number
function GetCurrentOceanFishingZoneTimeLeft()
end

---@return number
function GetCurrentOceanFishingTimeOffset()
end

---@return number
function GetCurrentOceanFishingWeatherID()
end

---@return boolean
function OceanFishingIsSpectralActive()
end

---@return number
function GetCurrentOceanFishingMission1Type()
end

---@return number
function GetCurrentOceanFishingMission2Type()
end

---@return number
function GetCurrentOceanFishingMission3Type()
end

---@return number
function GetCurrentOceanFishingMission1Goal()
end

---@return number
function GetCurrentOceanFishingMission2Goal()
end

---@return number
function GetCurrentOceanFishingMission3Goal()
end

---@return string
function GetCurrentOceanFishingMission1Name()
end

---@return string
function GetCurrentOceanFishingMission2Name()
end

---@return string
function GetCurrentOceanFishingMission3Name()
end

---@return number
function GetCurrentOceanFishingMission1Progress()
end

---@return number
function GetCurrentOceanFishingMission2Progress()
end

---@return number
function GetCurrentOceanFishingMission3Progress()
end

---@return number
function GetCurrentOceanFishingPoints()
end

---@return number
function GetCurrentOceanFishingScore()
end

---@return number
function GetCurrentOceanFishingTotalScore()
end

---@return number
function GetAccursedHoardRawX()
end

---@return number
function GetAccursedHoardRawY()
end

---@return number
function GetAccursedHoardRawZ()
end

---@return userdata
function GetBronzeChestLocations()
end

---@return userdata
function GetSilverChestLocations()
end

---@return userdata
function GetGoldChestLocations()
end

---@return userdata
function GetMimicChestLocations()
end

---@return userdata
function GetPassageLocation()
end

---@return userdata
function GetTrapLocations()
end

---@param distance? number
---@param objectKind? number
---@return userdata
function GetNearbyObjectNames(distance, objectKind)
end

---@param level? number
---@return userdata|nil
function GetActiveMiniMapGatheringMarker(level)
end

---@param aetheryteID number
---@return userdata
function GetAetheryteRawPos(aetheryteID)
end

---@param text string
function yield(text) end
