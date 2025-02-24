    public List<string> ListAllFunctions()
    public void LeaveDuty() => abandonDuty(false);
    public unsafe void TeleportToGCTown(bool useTickets = false)
    public unsafe float GetRecastTimeElapsed(uint actionId) => ActionManager.Instance()->GetRecastTimeElapsed(ActionType.Action, GetSpellActionId(actionId));
    public unsafe float GetRealRecastTimeElapsed(uint actionId) => ActionManager.Instance()->GetRecastTimeElapsed(ActionType.Action, actionId);
    public unsafe float GetRecastTime(uint actionId) => ActionManager.Instance()->GetRecastTime(ActionType.Action, GetSpellActionId(actionId));
    public unsafe float GetRealRecastTime(uint actionId) => ActionManager.Instance()->GetRecastTime(ActionType.Action, actionId);
    public float GetSpellCooldown(uint actionId) => Math.Abs(GetRecastTime(GetSpellActionId(actionId)) - GetRecastTimeElapsed(GetSpellActionId(actionId)));
    public float GetRealSpellCooldown(uint actionId) => Math.Abs(GetRealRecastTime(actionId) - GetRealRecastTimeElapsed(actionId));
    public int GetSpellCooldownInt(uint actionId)
    public int GetActionStackCount(int maxStacks, uint actionId)
    public unsafe void ExecuteAction(uint actionID) => ActionManager.Instance()->UseAction(ActionType.Action, actionID);
    public unsafe void ExecuteGeneralAction(uint actionID) => ActionManager.Instance()->UseAction(ActionType.GeneralAction, actionID);
    public List<string> ListAllFunctions()
    public unsafe void OpenRouletteDuty(byte contentRouletteID) => AgentContentsFinder.Instance()->OpenRouletteDuty(contentRouletteID);
    public unsafe void OpenRegularDuty(uint cfcID) => AgentContentsFinder.Instance()->OpenRegularDuty(cfcID);
    public unsafe void SelectDuty(uint dutyCode)
    public void SetDFLanguageJ(bool state) => Svc.GameConfig.UiConfig.Set("ContentsFinderUseLangTypeJA", state);
    public void SetDFLanguageE(bool state) => Svc.GameConfig.UiConfig.Set("ContentsFinderUseLangTypeEN", state);
    public void SetDFLanguageD(bool state) => Svc.GameConfig.UiConfig.Set("ContentsFinderUseLangTypeDE", state);
    public void SetDFLanguageF(bool state) => Svc.GameConfig.UiConfig.Set("ContentsFinderUseLangTypeFR", state);
    public void SetDFJoinInProgress(bool state) => Svc.GameConfig.UiConfig.Set("ContentsFinderSupplyEnable", state);
    public unsafe void SetDFUnrestricted(bool state) => ContentsFinder.Instance()->IsUnrestrictedParty = state;
    public unsafe void SetDFLevelSync(bool state) => ContentsFinder.Instance()->IsLevelSync = state;
    public unsafe void SetDFMinILvl(bool state) => ContentsFinder.Instance()->IsMinimalIL = state;
    public unsafe void SetDFSilenceEcho(bool state) => ContentsFinder.Instance()->IsSilenceEcho = state;
    public unsafe void SetDFExplorerMode(bool state) => ContentsFinder.Instance()->IsExplorerMode = state;
    public unsafe void SetDFLimitedLeveling(bool state) => ContentsFinder.Instance()->IsLimitedLevelingRoulette = state;
    public unsafe int GetDiademAetherGaugeBarCount() => TryGetAddonByName<AtkUnitBase>("HWDAetherGauge", out var addon) ? addon->AtkValues[1].Int / 200 : 0;
    public unsafe int GetDDPassageProgress()
    public unsafe bool IsAddonVisible(string addonName) => TryGetAddonByName<AtkUnitBase>(addonName, out var addon) && addon->IsVisible;
    public unsafe bool IsAddonReady(string addonName) => TryGetAddonByName<AtkUnitBase>(addonName, out var addon) && GenericHelpers.IsAddonReady(addon);
    public unsafe bool IsNodeVisible(string addonName, params int[] ids)
    public void GetClicks()
    public unsafe string GetToastNodeText(int index, params int[] nodeNumbers)
    public unsafe string GetNodeText(string addonName, params int[] nodeNumbers)
    public unsafe void SetNodeText(string addonName, string text, params int[] ids)
    public unsafe string GetSelectStringText(int index)
    public unsafe string GetSelectIconStringText(int index)
    public unsafe int GetNodeListCount(string addonName) => TryGetAddonByName<AtkUnitBase>(addonName, out var addon) ? addon->UldManager.NodeListCount : 0;
    public List<string> ListAllFunctions()
    public bool IsPlayerAvailable() => Player.Interactable && !IsOccupied();
    public unsafe bool HasStatus(string statusName)
    public unsafe bool HasStatusId(params uint[] statusIDs)
    public uint GetStatusStackCount(uint statusID) => Svc.ClientState.LocalPlayer?.StatusList.FirstOrDefault(x => x.StatusId == statusID)?.StackCount ?? 0;
    public float GetStatusTimeRemaining(uint statusID) => Svc.ClientState.LocalPlayer?.StatusList.FirstOrDefault(x => x.StatusId == statusID)?.RemainingTime ?? 0;
    public uint GetStatusSourceID(uint statusID) => Svc.ClientState.LocalPlayer?.StatusList.FirstOrDefault(x => x.StatusId == statusID)?.SourceId ?? 0;
    public bool GetCharacterCondition(int flagID, bool hasCondition = true) => hasCondition ? Svc.Condition[flagID] : !Svc.Condition[flagID];
    public string GetCharacterName(bool includeWorld = false)
    public bool IsInZone(int zoneID) => Svc.ClientState.TerritoryType == zoneID;
    public bool IsLocalPlayerNull() => Svc.ClientState.LocalPlayer == null;
    public bool IsPlayerDead() => Svc.ClientState.LocalPlayer!.IsDead;
    public bool IsPlayerCasting() => Svc.ClientState.LocalPlayer!.IsCasting;
    public unsafe bool IsLevelSynced() => UIState.Instance()->PlayerState.IsLevelSynced == 1;
    public unsafe bool IsMoving() => AgentMap.Instance()->IsPlayerMoving == 1;
    public bool IsPlayerOccupied() => IsOccupied();
    public unsafe uint GetGil() => InventoryManager.Instance()->GetGil();
    public uint GetClassJobId() => Svc.ClientState.LocalPlayer!.ClassJob.RowId;
    public uint GetHP() => Svc.ClientState.LocalPlayer?.CurrentHp ?? 0;
    public uint GetMaxHP() => Svc.ClientState.LocalPlayer?.MaxHp ?? 0;
    public uint GetShieldPercentage() => Svc.ClientState.LocalPlayer?.ShieldPercentage ?? 0;
    public uint GetMP() => Svc.ClientState.LocalPlayer?.CurrentMp ?? 0;
    public uint GetMaxMP() => Svc.ClientState.LocalPlayer?.MaxMp ?? 0;
    public uint GetCurrentWorld() => Svc.ClientState.LocalPlayer?.CurrentWorld.RowId ?? 0;
    public uint GetHomeWorld() => Svc.ClientState.LocalPlayer?.HomeWorld.RowId ?? 0;
    public float GetPlayerRawXPos(string character = "")
    public float GetPlayerRawYPos(string character = "")
    public float GetPlayerRawZPos(string character = "")
    public unsafe int GetLevel(int expArrayIndex = -1)
    public unsafe byte GetPlayerGC() => UIState.Instance()->PlayerState.GrandCompany;
    public unsafe int GetFCRank() => ((InfoProxyFreeCompany*)Framework.Instance()->UIModule->GetInfoModule()->GetInfoProxyById(InfoProxyId.FreeCompany))->Rank;
    public unsafe string GetFCGrandCompany() => ((InfoProxyFreeCompany*)Framework.Instance()->UIModule->GetInfoModule()->GetInfoProxyById(InfoProxyId.FreeCompany))->GrandCompany.ToString();
    public unsafe int GetFCOnlineMembers() => ((InfoProxyFreeCompany*)Framework.Instance()->UIModule->GetInfoModule()->GetInfoProxyById(InfoProxyId.FreeCompany))->OnlineMembers;
    public unsafe int GetFCTotalMembers() => ((InfoProxyFreeCompany*)Framework.Instance()->UIModule->GetInfoModule()->GetInfoProxyById(InfoProxyId.FreeCompany))->TotalMembers;
    public unsafe void RequestAchievementProgress(uint id) => FFXIVClientStructs.FFXIV.Client.Game.UI.Achievement.Instance()->RequestAchievementProgress(id);
    public unsafe uint GetRequestedAchievementProgress() => FFXIVClientStructs.FFXIV.Client.Game.UI.Achievement.Instance()->ProgressCurrent;
    public unsafe bool IsAchievementComplete(int id) => FFXIVClientStructs.FFXIV.Client.Game.UI.Achievement.Instance()->IsComplete(id); // requires the achievement menu to be loaded
    public unsafe uint GetCurrentBait() => PlayerState.Instance()->FishingBait;
    public unsafe ushort GetLimitBreakCurrentValue() => UIState.Instance()->LimitBreakController.CurrentUnits;
    public unsafe uint GetLimitBreakBarValue() => UIState.Instance()->LimitBreakController.BarUnits;
    public unsafe byte GetLimitBreakBarCount() => UIState.Instance()->LimitBreakController.BarCount;
    public unsafe uint GetPenaltyRemainingInMinutes() => UIState.Instance()->InstanceContent.GetPenaltyRemainingInMinutes(0);
    public unsafe byte GetMaelstromGCRank() => PlayerState.Instance()->GCRankMaelstrom;
    public unsafe byte GetFlamesGCRank() => PlayerState.Instance()->GCRankImmortalFlames;
    public unsafe byte GetAddersGCRank() => PlayerState.Instance()->GCRankTwinAdders;
    public unsafe void SetMaelstromGCRank(byte rank) => PlayerState.Instance()->GCRankMaelstrom = rank;
    public unsafe void SetFlamesGCRank(byte rank) => PlayerState.Instance()->GCRankImmortalFlames = rank;
    public unsafe void SetAddersGCRank(byte rank) => PlayerState.Instance()->GCRankTwinAdders = rank;
    public unsafe bool HasFlightUnlocked(uint territory = 0) => PlayerState.Instance()->IsAetherCurrentZoneComplete(Svc.Data.GetExcelSheet<TerritoryType>()?.GetRow(territory != 0 ? territory : Svc.ClientState.TerritoryType).Unknown4 ?? 0);
    public unsafe bool TerritorySupportsMounting() => Svc.Data.GetExcelSheet<TerritoryType>()?.GetRow(Player.Territory).Unknown4 != 0;
    public unsafe bool InSanctuary() => TerritoryInfo.Instance()->InSanctuary;
    public unsafe bool HasWeeklyBingoJournal() => PlayerState.Instance()->HasWeeklyBingoJournal;
    public unsafe bool IsWeeklyBingoExpired() => PlayerState.Instance()->IsWeeklyBingoExpired();
    public unsafe uint WeeklyBingoNumSecondChancePoints() => PlayerState.Instance()->WeeklyBingoNumSecondChancePoints;
    public unsafe int WeeklyBingoNumPlacedStickers() => PlayerState.Instance()->WeeklyBingoNumPlacedStickers;
    public unsafe int GetWeeklyBingoTaskStatus(int wonderousTailsIndex) => (int)PlayerState.Instance()->GetWeeklyBingoTaskStatus(wonderousTailsIndex);
    public unsafe uint GetWeeklyBingoOrderDataKey(int wonderousTailsIndex) => PlayerState.Instance()->WeeklyBingoOrderData[wonderousTailsIndex];
    public unsafe uint GetWeeklyBingoOrderDataType(uint wonderousTailsKey) => (Svc.Data.GetExcelSheet<WeeklyBingoOrderData>()?.GetRow(wonderousTailsKey).Type).GetValueOrDefault();
    public unsafe uint GetWeeklyBingoOrderDataData(uint wonderousTailsKey) => (Svc.Data.GetExcelSheet<WeeklyBingoOrderData>()?.GetRow(wonderousTailsKey).Data).GetValueOrDefault().RowId;
    public unsafe string GetWeeklyBingoOrderDataText(uint wonderousTailsKey) => Svc.Data.GetExcelSheet<WeeklyBingoOrderData>()?.GetRow(wonderousTailsKey).Text.Value.Description.ToString() ?? string.Empty;
    public bool IsAetheryteUnlocked(uint id) => Svc.AetheryteList.Any(x => x.AetheryteId == id);
    public List<uint> GetAetheryteList() => Svc.AetheryteList.Select(x => x.AetheryteId).ToList();
    public List<uint> GetAetherytesInZone(uint zoneID) => Svc.AetheryteList.Where(x => x.TerritoryId == zoneID).Select(x => x.AetheryteId).ToList();
    public string GetAetheryteName(uint aetheryteID) => Svc.AetheryteList.FirstOrDefault(x => x.AetheryteId == aetheryteID)?.AetheryteData.Value.PlaceName.Value.Name.ExtractText() ?? string.Empty;
    public unsafe bool IsFriendOnline(byte* name, ushort worldId) => InfoProxyFriendList.Instance()->GetEntryByName(name, worldId)->State != InfoProxyCommonList.CharacterData.OnlineStatus.Offline;
    public unsafe float GetJobExp(uint classjob) => PlayerState.Instance()->ClassJobExperience[GetRow<ClassJob>(classjob)?.ExpArrayIndex ?? 0];
    public ulong GetPlayerContentId() => Svc.ClientState.LocalContentId;
    public unsafe ulong GetPlayerAccountId() => Player.Character->AccountId;
    public List<string> ListAllFunctions()
    public bool IsCrafting() => Svc.Condition[ConditionFlag.Crafting] && !Svc.Condition[ConditionFlag.PreparingToCraft];
    public bool IsNotCrafting() => !IsCrafting();
    public unsafe bool IsCollectable()
    public unsafe string GetCondition(bool lower = true)
    public bool HasCondition(string condition, bool lower = true) => condition == GetCondition(lower);
    public unsafe int GetProgress()
    public unsafe int GetMaxProgress()
    public bool HasMaxProgress()
    public unsafe int GetQuality()
    public unsafe int GetMaxQuality()
    public bool HasMaxQuality()
    public unsafe int GetDurability()
    public unsafe int GetMaxDurability()
    public int GetCp()
    public int GetMaxCp()
    public int GetGp()
    public int GetMaxGp()
    public unsafe int GetStep()
    public unsafe int GetPercentHQ()
    public unsafe bool NeedsRepair(float below = 0)
    public unsafe bool CanExtractMateria(float within = 100)
    public unsafe bool HasStats(uint craftsmanship, uint control, uint cp)
    public unsafe uint GetProgressIncrease(uint actionID) => GetActionResult(actionID).Progress;
    public unsafe uint GetQualityIncrease(uint actionID) => GetActionResult(actionID).Quality;
    public List<string> ListAllFunctions()
    public float GetDistanceToPoint(float x, float y, float z) => Vector3.Distance(Svc.ClientState.LocalPlayer?.Position ?? Vector3.Zero, new Vector3(x, y, z));
    public string GetTargetName() => Svc.Targets.Target?.Name.TextValue ?? "";
    public unsafe uint GetTargetWorldId() => (Svc.Targets.Target as IPlayerCharacter)?.CurrentWorld.Value.RowId ?? 0;
    public unsafe string GetTargetWorldName() => (Svc.Targets.Target as IPlayerCharacter)?.CurrentWorld.Value.Name.ExtractText() ?? "";
    public float GetTargetRawXPos() => Svc.Targets.Target?.Position.X ?? 0;
    public float GetTargetRawYPos() => Svc.Targets.Target?.Position.Y ?? 0;
    public float GetTargetRawZPos() => Svc.Targets.Target?.Position.Z ?? 0;
    public unsafe bool IsTargetCasting() => ((Character*)Svc.Targets.Target?.Address!)->IsCasting;
    public unsafe uint GetTargetActionID() => ((Character*)Svc.Targets.Target?.Address!)->GetCastInfo()->ActionId;
    public float GetTargetHP() => (Svc.Targets.Target as Dalamud.Game.ClientState.Objects.Types.ICharacter)?.CurrentHp ?? 0;
    public float GetTargetMaxHP() => (Svc.Targets.Target as Dalamud.Game.ClientState.Objects.Types.ICharacter)?.MaxHp ?? 0;
    public float GetTargetHPP() => GetTargetHP() / GetTargetMaxHP() * 100;
    public float GetTargetRotation() => (float)(Svc.Targets.Target?.Rotation * (180 / Math.PI) ?? 0);
    public byte? GetTargetObjectKind() => (byte?)Svc.Targets.Target?.ObjectKind;
    public byte? GetTargetSubKind() => Svc.Targets.Target?.SubKind;
    public unsafe void TargetClosestEnemy(float distance = 0) => Svc.Targets.Target = Svc.Objects.OrderBy(DistanceToObject).FirstOrDefault(o => o.IsTargetable && o.IsHostile() && !o.IsDead && (distance == 0 || DistanceToObject(o) <= distance));
    public unsafe void TargetClosestFateEnemy(float distance = 0) => Svc.Targets.Target = Svc.Objects.OrderBy(DistanceToObject).FirstOrDefault(o => o.IsTargetable && o.IsHostile() && !o.IsDead && (distance == 0 || DistanceToObject(o) <= distance) && o.Struct()->FateId > 0);
    public void ClearTarget() => Svc.Targets.Target = null;
    public float GetDistanceToTarget() => Vector3.Distance(Svc.ClientState.LocalPlayer?.Position ?? Vector3.Zero, Svc.Targets.Target?.Position ?? Svc.ClientState.LocalPlayer?.Position ?? Vector3.Zero);
    public unsafe bool TargetHasStatus(uint statusID) => ((Character*)Svc.Targets.Target?.Address!)->GetStatusManager()->HasStatus(statusID);
    public unsafe uint GetTargetFateID() => Svc.Targets.Target != null ? Svc.Targets.Target.Struct()->FateId : 0u;
    public unsafe bool IsTargetMounted()
    public unsafe bool IsTargetInCombat() => ((Character*)Svc.Targets.Target?.Address!)->InCombat;
    public byte GetTargetHuntRank() => (byte)(Svc.Targets.Target != null ? FindRow<NotoriousMonster>(x => x.BNpcBase.Value!.RowId == Svc.Targets.Target.DataId)!.Value.Rank : 0);
    public float GetTargetHitboxRadius() => Svc.Targets.Target?.HitboxRadius ?? 0;
    public bool HasTarget() => Svc.Targets.Target != null;
    public string GetFocusTargetName() => Svc.Targets.FocusTarget?.Name.TextValue ?? "";
    public float GetFocusTargetRawXPos() => Svc.Targets.FocusTarget?.Position.X ?? 0;
    public float GetFocusTargetRawYPos() => Svc.Targets.FocusTarget?.Position.Y ?? 0;
    public float GetFocusTargetRawZPos() => Svc.Targets.FocusTarget?.Position.Z ?? 0;
    public unsafe bool IsFocusTargetCasting() => ((Character*)Svc.Targets.FocusTarget?.Address!)->IsCasting;
    public unsafe uint GetFocusTargetActionID() => ((Character*)Svc.Targets.FocusTarget?.Address!)->GetCastInfo()->ActionId;
    public float GetFocusTargetHP() => (Svc.Targets.FocusTarget as Dalamud.Game.ClientState.Objects.Types.ICharacter)?.CurrentHp ?? 0;
    public float GetFocusTargetMaxHP() => (Svc.Targets.FocusTarget as Dalamud.Game.ClientState.Objects.Types.ICharacter)?.MaxHp ?? 0;
    public float GetFocusTargetHPP() => GetFocusTargetHP() / GetFocusTargetMaxHP() * 100;
    public float GetFocusTargetRotation() => (float)(Svc.Targets.FocusTarget?.Rotation * (180 / Math.PI) ?? 0);
    public void ClearFocusTarget() => Svc.Targets.FocusTarget = null;
    public float GetDistanceToFocusTarget() => Vector3.Distance(Svc.ClientState.LocalPlayer?.Position ?? Vector3.Zero, Svc.Targets.FocusTarget?.Position ?? Svc.ClientState.LocalPlayer?.Position ?? Vector3.Zero);
    public unsafe bool FocusTargetHasStatus(uint statusID) => ((Character*)Svc.Targets.FocusTarget?.Address!)->GetStatusManager()->HasStatus(statusID);
    public unsafe uint GetFocusTargetFateID() => Svc.Targets.FocusTarget != null ? Svc.Targets.FocusTarget.Struct()->FateId : 0u;
    public float GetObjectRawXPos(string name) => GetGameObjectFromName(name)?.Position.X ?? 0;
    public float GetObjectRawYPos(string name) => GetGameObjectFromName(name)?.Position.Y ?? 0;
    public float GetObjectRawZPos(string name) => GetGameObjectFromName(name)?.Position.Z ?? 0;
    public float GetDistanceToObject(string name) => Vector3.Distance(Svc.ClientState.LocalPlayer?.Position ?? Vector3.Zero, Svc.Objects.OrderBy(DistanceToObject).FirstOrDefault(x => x.Name.TextValue.Equals(name, StringComparison.InvariantCultureIgnoreCase))?.Position ?? Vector3.Zero);
    public unsafe bool IsObjectCasting(string name) => ((Character*)GetGameObjectFromName(name)?.Address!)->IsCasting;
    public unsafe uint GetObjectActionID(string name) => ((Character*)GetGameObjectFromName(name)?.Address!)->GetCastInfo()->ActionId;
    public float GetObjectHP(string name) => (GetGameObjectFromName(name) as Dalamud.Game.ClientState.Objects.Types.ICharacter)?.CurrentHp ?? 0;
    public float GetObjectMaxHP(string name) => (GetGameObjectFromName(name) as Dalamud.Game.ClientState.Objects.Types.ICharacter)?.MaxHp ?? 0;
    public float GetObjectHPP(string name) => GetObjectHP(name) / GetObjectMaxHP(name) * 100;
    public float GetObjectRotation(string name) => (float)(GetGameObjectFromName(name)?.Rotation * (180 / Math.PI) ?? 0);
    public unsafe bool ObjectHasStatus(string name, uint statusID) => ((Character*)GetGameObjectFromName(name)?.Address!)->GetStatusManager()->HasStatus(statusID);
    public unsafe uint GetObjectFateID(string name) => GetGameObjectFromName(name) != null ? GetGameObjectFromName(name).Struct()->FateId : 0u;
    public bool DoesObjectExist(string name) => GetGameObjectFromName(name) != null;
    public unsafe bool IsObjectMounted(string name)
    public uint GetObjectDataID(string name) => GetGameObjectFromName(name)?.DataId ?? 0;
    public unsafe bool IsObjectInCombat(string name) => ((Character*)GetGameObjectFromName(name)?.Address!)->InCombat;
    public byte GetObjectHuntRank(string name) => Svc.Data.GetExcelSheet<NotoriousMonster>()?.FirstOrDefault(x => x.BNpcBase.Value!.RowId == GetObjectDataID(name)).Rank ?? 0;
    public float GetObjectHitboxRadius(string name) => GetGameObjectFromName(name)?.HitboxRadius ?? 0;
    public string GetPartyMemberName(int index) => Svc.Party[index]?.Name.TextValue ?? "";
    public unsafe uint GetPartyMemberWorldId(int index) => Svc.Party[index]?.World.RowId ?? 0;
    public unsafe string GetPartyMemberWorldName(int index) => Svc.Party[index]?.World.Value.Name.ExtractText() ?? "";
    public float GetPartyMemberRawXPos(int index) => Svc.Party[index]?.Position.X ?? 0;
    public float GetPartyMemberRawYPos(int index) => Svc.Party[index]?.Position.Y ?? 0;
    public float GetPartyMemberRawZPos(int index) => Svc.Party[index]?.Position.Z ?? 0;
    public float GetDistanceToPartyMember(int index) => Vector3.Distance(Svc.ClientState.LocalPlayer?.Position ?? Vector3.Zero, Svc.Party[index]?.Position ?? Vector3.Zero);
    public unsafe bool IsPartyMemberCasting(int index) => ((Character*)Svc.Party[index]?.Address!)->IsCasting;
    public unsafe uint GetPartyMemberActionID(int index) => ((Character*)Svc.Party[index]?.Address!)->GetCastInfo()->ActionId;
    public float GetPartyMemberHP(int index) => Svc.Party[index]?.CurrentHP ?? 0;
    public float GetPartyMemberMaxHP(int index) => Svc.Party[index]?.MaxHP ?? 0;
    public float GetPartyMemberHPP(int index) => GetPartyMemberHP(index) / GetPartyMemberMaxHP(index) * 100;
    public float GetPartyMemberRotation(int index) => (float)(Svc.Party[index]?.GameObject?.Rotation * (180 / Math.PI) ?? 0);
    public unsafe bool PartyMemberHasStatus(int index, uint statusID) => Svc.Party[index]?.Statuses.Any(s => s.StatusId == statusID) ?? false;
    public unsafe bool IsPartyMemberMounted(int index)
    public unsafe bool IsPartyMemberInCombat(int index) => ((Character*)Svc.Party[index]?.Address!)->InCombat;
    public uint GetPartyLeadIndex() => Svc.Party.PartyLeaderIndex;
    public unsafe float GetBuddyTimeRemaining() => UIState.Instance()->Buddy.CompanionInfo.TimeLeft;
    public List<string> ListAllFunctions()
    public string? InternalGetMacroText(string name)
    public void SetSNDProperty(string key, string value) => C.SetProperty(key, value);
    public object? GetSNDProperty(string key) => C.GetProperty(key);
    public bool IsPauseLoopSet() => Service.MacroManager.PauseAtLoop;
    public bool IsStopLoopSet() => Service.MacroManager.StopAtLoop;
    public string GetActiveMacroName() => Service.MacroManager.ActiveMacroName;
    public bool IsMacroRunningOrQueued(string name) => Service.MacroManager.MacroStatus.Any(m => m.Name == name);
    public List<string> ListAllFunctions()
    public unsafe int GetItemCount(int itemID, bool includeHQ = true)
    public unsafe int GetItemCountInContainer(uint itemID, uint container) => GetItemInInventory(itemID, (InventoryType)container)->Quantity;
    public unsafe int GetInventoryFreeSlotCount()
    public unsafe uint GetItemIdInSlot(uint container, uint slot)
    public unsafe int GetItemCountInSlot(uint container, uint slot)
    public unsafe List<uint> GetItemIdsInContainer(uint container)
    public unsafe int GetFreeSlotsInContainer(uint container)
    public unsafe void MoveItemToContainer(uint itemID, uint srcContainer, uint dstContainer)
    public List<uint> GetTradeableWhiteItemIDs() => Svc.Data.GetExcelSheet<Item>()!.Where(x => !x.IsUntradable && x.Rarity == (byte)ItemRarity.White).Select(x => x.RowId).ToList();
    public List<string> ListAllFunctions()
    public bool? PandoraGetFeatureEnabled(string feature) => PandorasBoxIPC.GetFeatureEnabled?.InvokeFunc(feature);
    public bool? PandoraGetFeatureConfigEnabled(string feature, string config) => PandorasBoxIPC.GetConfigEnabled?.InvokeFunc(feature, config);
    public void PandoraSetFeatureState(string feature, bool state) => PandorasBoxIPC.SetFeatureEnabled?.InvokeAction(feature, state);
    public void PandoraSetFeatureConfigState(string feature, string config, bool state) => PandorasBoxIPC.SetConfigEnabled?.InvokeAction(feature, config, state);
    public void PandoraPauseFeature(string feature, int ms) => PandorasBoxIPC.PauseFeature?.InvokeAction(feature, ms);
    public unsafe void SetAutoHookState(bool state) => AutoHookIPC.SetPluginState(state);
    public unsafe void SetAutoHookAutoGigState(bool state) => AutoHookIPC.SetAutoGigState(state);
    public unsafe void SetAutoHookAutoGigSize(int size) => AutoHookIPC.SetAutoGigSize(size);
    public unsafe void SetAutoHookAutoGigSpeed(int speed) => AutoHookIPC.SetAutoGigSpeed(speed);
    public unsafe void SetAutoHookPreset(string preset) => AutoHookIPC.SetPreset(preset);
    public unsafe void UseAutoHookAnonymousPreset(string preset) => AutoHookIPC.CreateAndSelectAnonymousPreset(preset);
    public unsafe void DeletedSelectedAutoHookPreset() => AutoHookIPC.DeleteSelectedPreset();
    public unsafe void DeleteAllAutoHookAnonymousPresets() => AutoHookIPC.DeleteAllAnonymousPresets();
    public bool DeliverooIsTurnInRunning() => DeliverooIPC.IsTurnInRunning!.InvokeFunc();
    public bool QuestionableIsRunning() => _questionable.IsRunning();
    public string QuestionableGetCurrentQuestId() => _questionable.GetCurrentQuestId();
    public bool IsVislandRouteRunning() => _visland.IsRouteRunning();
    public bool VislandIsRoutePaused() => _visland.IsRoutePaused();
    public void VislandSetRoutePaused(bool state) => _visland.SetRoutePaused(state);
    public void VislandStopRoute() => _visland.StopRoute();
    public void VislandStartRoute(string route, bool once) => _visland.StartRoute(route, once);
    public bool NavIsReady() => NavmeshIPC.NavIsReady();
    public float NavBuildProgress() => NavmeshIPC.NavBuildProgress();
    public void NavReload() => NavmeshIPC.NavReload();
    public void NavRebuild() => NavmeshIPC.NavRebuild();
    public void NavPathfind(float x, float y, float z, bool fly = false) => NavmeshIPC.NavPathfind(Svc.ClientState.LocalPlayer!.Position, new Vector3(x, y, z), fly);
    public bool NavIsAutoLoad() => NavmeshIPC.NavIsAutoLoad();
    public void NavSetAutoLoad(bool state) => NavmeshIPC.NavSetAutoLoad(state);
    public float? QueryMeshNearestPointX(float x, float y, float z, float halfExtentXZ, float halfExtentY) => NavmeshIPC.QueryMeshNearestPoint(new Vector3(x, y, z), halfExtentXZ, halfExtentY)?.X;
    public float? QueryMeshNearestPointY(float x, float y, float z, float halfExtentXZ, float halfExtentY) => NavmeshIPC.QueryMeshNearestPoint(new Vector3(x, y, z), halfExtentXZ, halfExtentY)?.Y;
    public float? QueryMeshNearestPointZ(float x, float y, float z, float halfExtentXZ, float halfExtentY) => NavmeshIPC.QueryMeshNearestPoint(new Vector3(x, y, z), halfExtentXZ, halfExtentY)?.Z;
    public float? QueryMeshPointOnFloorX(float x, float y, float z, bool allowUnlandable, float halfExtentXZ) => NavmeshIPC.QueryMeshPointOnFloor(new Vector3(x, y, z), allowUnlandable, halfExtentXZ)?.X;
    public float? QueryMeshPointOnFloorY(float x, float y, float z, bool allowUnlandable, float halfExtentXZ) => NavmeshIPC.QueryMeshPointOnFloor(new Vector3(x, y, z), allowUnlandable, halfExtentXZ)?.Y;
    public float? QueryMeshPointOnFloorZ(float x, float y, float z, bool allowUnlandable, float halfExtentXZ) => NavmeshIPC.QueryMeshPointOnFloor(new Vector3(x, y, z), allowUnlandable, halfExtentXZ)?.Z;
    public void PathMoveTo(float x, float y, float z, bool fly = false) => NavmeshIPC.PathMoveTo([new Vector3(x, y, z)], fly);
    public void PathStop() => NavmeshIPC.PathStop();
    public bool PathIsRunning() => NavmeshIPC.PathIsRunning();
    public int PathNumWaypoints() => NavmeshIPC.PathNumWaypoints();
    public bool PathGetMovementAllowed() => NavmeshIPC.PathGetMovementAllowed();
    public void PathSetMovementAllowed(bool state) => NavmeshIPC.PathSetMovementAllowed(state);
    public bool PathGetAlignCamera() => NavmeshIPC.PathGetAlignCamera();
    public void PathSetAlignCamera(bool state) => NavmeshIPC.PathSetAlignCamera(state);
    public float PathGetTolerance() => NavmeshIPC.PathGetTolerance();
    public void PathSetTolerance(float t) => NavmeshIPC.PathSetTolerance(t);
    public void PathfindAndMoveTo(float x, float y, float z, bool fly = false) => NavmeshIPC.PathfindAndMoveTo(new Vector3(x, y, z), fly);
    public bool PathfindInProgress() => NavmeshIPC.PathfindInProgress();
    public unsafe void ARSetSuppressed(bool state) => _autoRetainerApi.Suppressed = state;
    public unsafe List<string> ARGetRegisteredCharacters()
    public unsafe List<string> ARGetRegisteredEnabledCharacters()
    public unsafe List<string> ARGetRegisteredRetainers()
    public unsafe List<string> ARGetRegisteredEnabledRetainers()
    public unsafe bool ARAnyWaitingToBeProcessed(bool allCharacters = false) => ARRetainersWaitingToBeProcessed(allCharacters) || ARSubsWaitingToBeProcessed(allCharacters);
    public unsafe bool ARRetainersWaitingToBeProcessed(bool allCharacters = false)
    public unsafe bool ARSubsWaitingToBeProcessed(bool allCharacters = false)
    public void ARFinishCharacterPostProcess() => _autoRetainerApi.FinishCharacterPostProcess();
    public List<ulong> ARGetCharacterCIDs() => _autoRetainerApi.GetRegisteredCharacters();
    public bool ARGetMultiModeEnabled() => _autoretainer.GetMultiModeEnabled();
    public void ARSetMultiModeEnabled(bool value) => _autoretainer.SetMultiModeEnabled(value);
    public bool ARIsBusy() => _autoretainer.IsBusy();
    public int ARGetInventoryFreeSlotCount() => _autoretainer.GetInventoryFreeSlotCount();
    public Dictionary<ulong, HashSet<string>> ARGetEnabledRetainers() => _autoretainer.GetEnabledRetainers();
    public bool ARAreAnyRetainersAvailableForCurrentChara() => _autoretainer.AreAnyRetainersAvailableForCurrentChara();
    public void ARAbortAllTasks() => _autoretainer.AbortAllTasks();
    public void ARDisableAllFunctions() => _autoretainer.DisableAllFunctions();
    public void AREnableMultiMode() => _autoretainer.EnableMultiMode();
    public void AREnqueueHET() => _autoretainer.EnqueueHET(() => { });
    public bool ARCanAutoLogin() => _autoretainer.CanAutoLogin();
    public bool ARRelog(string charaNameWithWorld) => _autoretainer.Relog(charaNameWithWorld);
    public bool ARGetOptionRetainerSense() => _autoretainer.GetOptionRetainerSense();
    public void ARSetOptionRetainerSense(bool value) => _autoretainer.SetOptionRetainerSense(value);
    public int ARGetOptionRetainerSenseThreshold() => _autoretainer.GetOptionRetainerSenseThreshold();
    public void ARSetOptionRetainerSenseThreshold(int value) => _autoretainer.SetOptionRetainerSenseThreshold(value);
    public long? ARGetClosestRetainerVentureSecondsRemaining(ulong cid) => _autoretainer.GetClosestRetainerVentureSecondsRemaining(cid);
    public void AREnqueueInitiation() => _autoretainer.EnqueueInitiation();
    public (uint ShopDataID, uint ExchangeDataID, Vector3 Position)? ARGetGCInfo() => _autoretainer.GetGCInfo();
    public void PauseYesAlready()
    public void RestoreYesAlready()
    public void DropboxStart() => _dropbox.BeginTradingQueue();
    public void DropboxStop() => _dropbox.Stop();
    public bool DropboxIsBusy() => _dropbox.IsBusy();
    public int DropboxGetItemQuantity(uint id, bool hq) => _dropbox.GetItemQuantity(id, hq);
    public void DropboxSetItemQuantity(uint id, bool hq, int quantity) => _dropbox.SetItemQuantity(id, hq, quantity);
    public bool LifestreamAethernetTeleport(string aethernetName) => _lifestream.AethernetTeleport(aethernetName);
    public bool LifestreamTeleport(uint destination, byte subIndex) => _lifestream.Teleport(destination, subIndex);
    public bool LifestreamTeleportToHome() => _lifestream.TeleportToHome();
    public bool LifestreamTeleportToFC() => _lifestream.TeleportToFC();
    public bool LifestreamTeleportToApartment() => _lifestream.TeleportToApartment();
    public bool LifestreamIsBusy() => _lifestream.IsBusy();
    public void LifestreamExecuteCommand(string command) => _lifestream.ExecuteCommand(command);
    public void LifestreamAbort() => _lifestream.Abort();
    public void RSRAddPriorityNameID(uint nameId) => _rsr.AddPriorityNameID(nameId);
    public void RSRRemovePriorityNameID(uint nameId) => _rsr.RemovePriorityNameID(nameId);
    public void RSRAddBlacklistNameID(uint nameId) => _rsr.AddBlacklistNameID(nameId);
    public void RSRRemoveBlacklistNameID(uint nameId) => _rsr.RemoveBlacklistNameID(nameId);
    public void RSRChangeOperatingMode(byte stateCommand) => _rsr.ChangeOperatingMode((RSR.StateCommandType)stateCommand);
    public void RSRTriggerSpecialState(byte specialCommand) => _rsr.TriggerSpecialState((RSR.SpecialCommandType)specialCommand);
    public bool ArtisanGetEnduranceStatus() => _artisan.GetEnduranceStatus();
    public void ArtisanSetEnduranceStatus(bool state) => _artisan.SetEnduranceStatus(state);
    public bool ArtisanIsListRunning() => _artisan.IsListRunning();
    public bool ArtisanIsListPaused() => _artisan.IsListPaused();
    public void ArtisanSetListPause(bool state) => _artisan.SetListPause(state);
    public bool ArtisanGetStopRequest() => _artisan.GetStopRequest();
    public void ArtisanSetStopRequest(bool state) => _artisan.SetStopRequest(state);
    public void ArtisanCraftItem(ushort recipeID, int amount) => _artisan.CraftItem(recipeID, amount);
    public List<uint> ARDiscardGetItemsToDiscard() => [.. _ardiscard.GetItemsToDiscard()];
    public void ADListConfig() => AutoDutyIPC.ListConfig?.InvokeAction();
    public string? ADGetConfig(string config) => AutoDutyIPC.GetConfig?.InvokeFunc(config);
    public void ADSetConfig(string config, string setting) => AutoDutyIPC.SetConfig?.InvokeAction(config, setting);
    public void ADRun(uint territoryType, int loops = 0, bool bareMode = false) => AutoDutyIPC.Run?.InvokeAction(territoryType, loops, bareMode);
    public void ADStart(bool startFromZero = true) => AutoDutyIPC.Start?.InvokeAction(startFromZero);
    public void ADStop() => AutoDutyIPC.Stop?.InvokeAction();
    public bool? ADIsNavigating() => AutoDutyIPC.IsNavigating?.InvokeFunc();
    public bool? ADIsLooping() => AutoDutyIPC.IsLooping?.InvokeFunc();
    public bool? ADIsStopped() => AutoDutyIPC.IsStopped?.InvokeFunc();
    public bool? ADContentHasPath(uint territoryType) => AutoDutyIPC.ContentHasPath?.InvokeFunc(territoryType);
    public uint ATInventoryCountByType(uint inventoryType, ulong? characterId) => _aTools.InventoryCountByType(inventoryType, characterId);
    public uint ATInventoryCountByTypes(uint[] inventoryTypes, ulong? characterId) => _aTools.InventoryCountByTypes(inventoryTypes, characterId);
    public uint ATItemCount(uint itemId, ulong characterId, int inventoryType) => _aTools.ItemCount(itemId, characterId, inventoryType);
    public uint ATItemCountHQ(uint itemId, ulong characterId, int inventoryType) => _aTools.ItemCountHQ(itemId, characterId, inventoryType);
    public uint ATItemCountOwned(uint itemId, bool currentCharacterOnly, uint[] inventoryTypes) => _aTools.ItemCountOwned(itemId, currentCharacterOnly, inventoryTypes);
    public bool ATEnableUiFilter(string filterKey) => _aTools.EnableUiFilter(filterKey);
    public bool ATDisableUiFilter() => _aTools.DisableUiFilter();
    public bool ATToggleUiFilter(string filterKey) => _aTools.ToggleUiFilter(filterKey);
    public bool ATEnableBackgroundFilter(string filterKey) => _aTools.EnableBackgroundFilter(filterKey);
    public bool ATDisableBackgroundFilter() => _aTools.DisableBackgroundFilter();
    public bool ATToggleBackgroundFilter(string filterKey) => _aTools.ToggleBackgroundFilter(filterKey);
    public bool ATEnableCraftList(string filterKey) => _aTools.EnableCraftList(filterKey);
    public bool ATDisableCraftList() => _aTools.DisableCraftList();
    public bool ATToggleCraftList(string filterKey) => _aTools.ToggleCraftList(filterKey);
    public bool ATAddItemToCraftList(string filterKey, uint itemId, uint quantity) => _aTools.AddItemToCraftList(filterKey, itemId, quantity);
    public bool ATRemoveItemFromCraftList(string filterKey, uint itemId, uint quantity) => _aTools.RemoveItemFromCraftList(filterKey, itemId, quantity);
    public Dictionary<uint, uint> ATGetFilterItems(string filterKey) => _aTools.GetFilterItems(filterKey);
    public Dictionary<uint, uint> ATGetCraftItems(string filterKey) => _aTools.GetCraftItems(filterKey);
    public Dictionary<uint, uint> ATGetRetrievalItems() => _aTools.GetRetrievalItems();
    public HashSet<ulong[]> ATGetCharacterItems(ulong characterId) => _aTools.GetCharacterItems(characterId);
    public HashSet<ulong> ATGetCharactersOwnedByActive(bool includeOwner) => _aTools.GetCharactersOwnedByActive(includeOwner);
    public HashSet<ulong[]> ATGetCharacterItemsByType(ulong characterId, uint inventoryType) => _aTools.GetCharacterItemsByType(characterId, inventoryType);
    public Dictionary<string, string> ATGetCraftLists() => _aTools.GetCraftLists();
    public Dictionary<string, string> ATGetSearchFilters() => _aTools.GetSearchFilters();
    public string ATAddNewCraftList(string craftListName, Dictionary<uint, uint> items) => _aTools.AddNewCraftList(craftListName, items);
    public ulong? ATCurrentCharacter() => _aTools.CurrentCharacter();
    public bool ATIsInitialized() => _aTools.IsInitialized();
    public string? BMGet(string name) => _bossmod.Get(name);
    public bool BMCreate(string presetSerialized, bool overwrite) => _bossmod.Create(presetSerialized, overwrite);
    public bool BMDelete(string name) => _bossmod.Delete(name);
    public string BMGetActive() => _bossmod.GetActive();
    public bool BMSetActive(string name) => _bossmod.SetActive(name);
    public bool BMClearActive() => _bossmod.ClearActive();
    public bool BMGetForceDisabled() => _bossmod.GetForceDisabled();
    public bool BMSetForceDisabled() => _bossmod.SetForceDisabled();
    public bool BMAddTransientStrategy(string presetName, string moduleTypeName, string trackName, string value) => _bossmod.AddTransientStrategy(presetName, moduleTypeName, trackName, value);
    public bool BMAddTransientStrategyTargetEnemyOID(string presetName, string moduleTypeName, string trackName, string value, int oid) => _bossmod.AddTransientStrategyTargetEnemyOID(presetName, moduleTypeName, trackName, value, oid);
    public List<string> ListAllFunctions()
    public static string GetQuestNameByID(ushort id)
    public unsafe bool IsQuestAccepted(ushort id) => QuestManager.Instance()->IsQuestAccepted(id);
    public unsafe List<uint> GetAcceptedQuests() => Svc.Data.GetExcelSheet<Quest>(Svc.ClientState.ClientLanguage)!.Where(x => IsQuestAccepted((ushort)x.RowId)).Select(x => x.RowId).ToList();
    public unsafe bool IsQuestComplete(ushort id) => QuestManager.IsQuestComplete(id);
    public unsafe byte GetQuestSequence(ushort id) => QuestManager.GetQuestSequence(id);
    public uint? GetQuestIDByName(string name)
    public string GetQuestAlliedSociety(uint id) => Svc.Data.GetExcelSheet<Quest>(Svc.ClientState.ClientLanguage).FirstOrDefault(x => x.RowId == id).BeastTribe.Value.Name.ToString();
    public unsafe bool IsLeveAccepted(ushort id) => QuestManager.Instance()->LeveQuests.ToArray().Any(q => q.LeveId == id);
    public unsafe MonsterNoteRankInfo GetMonsterNoteRankInfo(int index) => MonsterNoteManager.Instance()->RankData[index];
    public List<string> ListAllFunctions()
    public string GetClipboard() => ImGui.GetClipboardText();
    public void SetClipboard(string text) => ImGui.SetClipboardText(text);
    public unsafe void CrashTheGame() => Framework.Instance()->UIModule = (UIModule*)0;
    public void LogInfo(object text) => Svc.Log.Info($"{text}");
    public void LogDebug(object text) => Svc.Log.Debug($"{text}");
    public void LogVerbose(object text) => Svc.Log.Verbose($"{text}");
    public bool HasPlugin(string name) => DalamudReflector.TryGetDalamudPlugin(name, out _, false, true);
    public List<string> ListAllFunctions()
    public int GetZoneID() => Svc.ClientState.TerritoryType;
    public string GetZoneName(uint zoneID) => GetRow<TerritoryType>(zoneID)!.Value.PlaceName.Value.ToString() ?? "";
    public unsafe float GetFlagXCoord() => AgentMap.Instance()->FlagMapMarker.XFloat;
    public unsafe float GetFlagYCoord() => AgentMap.Instance()->FlagMapMarker.YFloat;
    public unsafe float GetFlagZone() => AgentMap.Instance()->FlagMapMarker.TerritoryId;
    public unsafe void SetMapFlag(uint territory, float worldX, float worldY, float worldZ) => AgentMap.Instance()->SetFlagMapMarker(territory, GetRow<TerritoryType>(territory)!.Value.Map.Value!.RowId, new Vector3(worldX, worldY, worldZ));
    public unsafe byte GetActiveWeatherID() => EnvManager.Instance()->ActiveWeather;
    public unsafe long GetCurrentEorzeaTimestamp() => Framework.Instance()->ClientTime.EorzeaTime;
    public unsafe int GetCurrentEorzeaSecond() => DateTimeOffset.FromUnixTimeSeconds(Framework.Instance()->ClientTime.EorzeaTime).Second;
    public unsafe int GetCurrentEorzeaMinute() => DateTimeOffset.FromUnixTimeSeconds(Framework.Instance()->ClientTime.EorzeaTime).Minute;
    public unsafe int GetCurrentEorzeaHour() => DateTimeOffset.FromUnixTimeSeconds(Framework.Instance()->ClientTime.EorzeaTime).Hour;
    public unsafe List<ushort> GetActiveFates()
    public unsafe ushort GetNearestFate() => FateManager.Instance()->Fates.AsSpan().ToArray()
    public unsafe bool IsInFate() => FateManager.Instance()->CurrentFate is not null;
    public unsafe string GetFateState(ushort fateID) => FateManager.Instance()->GetFateById(fateID)->State.ToString();
    public unsafe int GetFateStartTimeEpoch(ushort fateID) => FateManager.Instance()->GetFateById(fateID)->StartTimeEpoch;
    public unsafe float GetFateDuration(ushort fateID) => FateManager.Instance()->GetFateById(fateID)->Duration;
    public unsafe string GetFateName(ushort fateID) => FateManager.Instance()->GetFateById(fateID)->Name.ToString();
    public unsafe float GetFateHandInCount(ushort fateID) => FateManager.Instance()->GetFateById(fateID)->HandInCount;
    public unsafe float GetFateLocationX(ushort fateID) => FateManager.Instance()->GetFateById(fateID)->Location.X;
    public unsafe float GetFateLocationY(ushort fateID) => FateManager.Instance()->GetFateById(fateID)->Location.Y;
    public unsafe float GetFateLocationZ(ushort fateID) => FateManager.Instance()->GetFateById(fateID)->Location.Z;
    public unsafe float GetFateProgress(ushort fateID) => FateManager.Instance()->GetFateById(fateID)->Progress;
    public unsafe bool GetFateIsBonus(ushort fateID) => FateManager.Instance()->GetFateById(fateID)->IsBonus;
    public unsafe float GetFateRadius(ushort fateID) => FateManager.Instance()->GetFateById(fateID)->Radius;
    public unsafe uint GetFateIconId(ushort fateID) => FateManager.Instance()->GetFateById(fateID)->IconId;
    public unsafe int GetFateLevel(ushort fateID) => FateManager.Instance()->GetFateById(fateID)->Level;
    public unsafe int GetFateMaxLevel(ushort fateID) => FateManager.Instance()->GetFateById(fateID)->MaxLevel;
    public unsafe ushort GetFateChain(ushort fateID) => FateManager.Instance()->GetFateById(fateID)->FATEChain;
    public unsafe uint GetFateEventItem(ushort fateID) => FateManager.Instance()->GetFateById(fateID)->EventItem;
    public float DistanceBetween(float x1, float y1, float z1, float x2, float y2, float z2) => Vector3.Distance(new Vector3(x1, y1, z1), new Vector3(x2, y2, z2));
    public unsafe float GetContentTimeLeft() => EventFramework.Instance()->GetInstanceContentDirector()->ContentDirector.ContentTimeLeft;
    public unsafe uint GetZoneInstance() => UIState.Instance()->PublicInstance.InstanceId;
    public unsafe uint GetCurrentOceanFishingRoute() => EventFramework.Instance()->GetInstanceContentOceanFishing()->CurrentRoute;
    public byte GetCurrentOceanFishingTimeOfDay() => Svc.Data.GetExcelSheet<IKDRoute>()?.GetRow(GetCurrentOceanFishingRoute()).Time[GetCurrentOceanFishingZone()].Value.Unknown0 ?? 0;
    public unsafe int GetCurrentOceanFishingStatus() => (int)EventFramework.Instance()->GetInstanceContentOceanFishing()->Status;
    public unsafe int GetCurrentOceanFishingZone() => (int)EventFramework.Instance()->GetInstanceContentOceanFishing()->CurrentZone;
    public float GetCurrentOceanFishingZoneTimeLeft() => GetContentTimeLeft() - GetCurrentOceanFishingTimeOffset();
    public unsafe uint GetCurrentOceanFishingTimeOffset() => EventFramework.Instance()->GetInstanceContentOceanFishing()->TimeOffset;
    public unsafe uint GetCurrentOceanFishingWeatherID() => EventFramework.Instance()->GetInstanceContentOceanFishing()->WeatherId;
    public unsafe bool OceanFishingIsSpectralActive() => EventFramework.Instance()->GetInstanceContentOceanFishing()->SpectralCurrentActive;
    public unsafe uint GetCurrentOceanFishingMission1Type() => EventFramework.Instance()->GetInstanceContentOceanFishing()->Mission1Type;
    public unsafe uint GetCurrentOceanFishingMission2Type() => EventFramework.Instance()->GetInstanceContentOceanFishing()->Mission2Type;
    public unsafe uint GetCurrentOceanFishingMission3Type() => EventFramework.Instance()->GetInstanceContentOceanFishing()->Mission3Type;
    public unsafe byte GetCurrentOceanFishingMission1Goal() => GetRow<IKDPlayerMissionCondition>(GetCurrentOceanFishingMission1Type())!.Value.Unknown1;
    public unsafe byte GetCurrentOceanFishingMission2Goal() => GetRow<IKDPlayerMissionCondition>(GetCurrentOceanFishingMission2Type())!.Value.Unknown1;
    public unsafe byte GetCurrentOceanFishingMission3Goal() => GetRow<IKDPlayerMissionCondition>(GetCurrentOceanFishingMission3Type())!.Value.Unknown1;
    public unsafe string GetCurrentOceanFishingMission1Name() => GetRow<IKDPlayerMissionCondition>(GetCurrentOceanFishingMission1Type())!.Value.Unknown0.ToString() ?? "";
    public unsafe string GetCurrentOceanFishingMission2Name() => GetRow<IKDPlayerMissionCondition>(GetCurrentOceanFishingMission2Type())!.Value.Unknown0.ToString() ?? "";
    public unsafe string GetCurrentOceanFishingMission3Name() => GetRow<IKDPlayerMissionCondition>(GetCurrentOceanFishingMission3Type())!.Value.Unknown0.ToString() ?? "";
    public unsafe uint GetCurrentOceanFishingMission1Progress() => EventFramework.Instance()->GetInstanceContentOceanFishing()->Mission1Progress;
    public unsafe uint GetCurrentOceanFishingMission2Progress() => EventFramework.Instance()->GetInstanceContentOceanFishing()->Mission2Progress;
    public unsafe uint GetCurrentOceanFishingMission3Progress() => EventFramework.Instance()->GetInstanceContentOceanFishing()->Mission3Progress;
    public unsafe uint GetCurrentOceanFishingPoints() => AgentModule.Instance()->GetAgentIKDFishingLog()->Points;
    public unsafe uint GetCurrentOceanFishingScore() => AgentModule.Instance()->GetAgentIKDResult()->Data->Score;
    public unsafe uint GetCurrentOceanFishingTotalScore() => AgentModule.Instance()->GetAgentIKDResult()->Data->TotalScore;
    public float GetAccursedHoardRawX() => Svc.Objects.FirstOrDefault(x => x.DataId == DeepDungeonDataIDs.AccursedHoard)?.Position.X ?? 0;
    public float GetAccursedHoardRawY() => Svc.Objects.FirstOrDefault(x => x.DataId == DeepDungeonDataIDs.AccursedHoard)?.Position.Y ?? 0;
    public float GetAccursedHoardRawZ() => Svc.Objects.FirstOrDefault(x => x.DataId == DeepDungeonDataIDs.AccursedHoard)?.Position.Z ?? 0;
    public List<(float, float, float)> GetBronzeChestLocations() => Svc.Objects.OrderBy(DistanceToObject).Where(x => DeepDungeonDataIDs.BronzeChestIDs.Contains(x.DataId)).Select(x => (x.Position.X, x.Position.Y, x.Position.Z)).ToList();
    public List<(float, float, float)> GetSilverChestLocations() => Svc.Objects.OrderBy(DistanceToObject).Where(x => x.DataId == DeepDungeonDataIDs.SilverChest).Select(x => (x.Position.X, x.Position.Y, x.Position.Z)).ToList();
    public List<(float, float, float)> GetGoldChestLocations() => Svc.Objects.OrderBy(DistanceToObject).Where(x => x.DataId == DeepDungeonDataIDs.GoldChest).Select(x => (x.Position.X, x.Position.Y, x.Position.Z)).ToList();
    public List<(float, float, float)> GetMimicChestLocations() => Svc.Objects.OrderBy(DistanceToObject).Where(x => x.DataId == DeepDungeonDataIDs.MimicChest || DeepDungeonDataIDs.MimicIDs.Contains(x.DataId)).Select(x => (x.Position.X, x.Position.Y, x.Position.Z)).ToList();
    public (float, float, float) GetPassageLocation() => Svc.Objects.OrderBy(DistanceToObject).Where(x => DeepDungeonDataIDs.PassageIDs.Contains(x.DataId)).Select(x => (x.Position.X, x.Position.Y, x.Position.Z)).FirstOrDefault();
    public List<(float, float, float)> GetTrapLocations() => Svc.Objects.OrderBy(DistanceToObject).Where(x => DeepDungeonDataIDs.TrapIDs.ContainsKey(x.DataId)).Select(x => (x.Position.X, x.Position.Y, x.Position.Z)).ToList();
    public List<string> GetNearbyObjectNames(float distance = 0, byte objectKind = 0)
    public unsafe Vector2? GetActiveMiniMapGatheringMarker(int level = 0)
    public (float, float) GetAetheryteRawPos(uint aetheryteID)
