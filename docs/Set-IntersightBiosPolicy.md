---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Set-IntersightBiosPolicy

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Set-IntersightBiosPolicy [-AcsControlGpu1state< BiosPolicy.AcsControlGpu1stateEnum>][-AcsControlGpu2state< BiosPolicy.AcsControlGpu2stateEnum>][-AcsControlGpu3state< BiosPolicy.AcsControlGpu3stateEnum>][-AcsControlGpu4state< BiosPolicy.AcsControlGpu4stateEnum>][-AcsControlGpu5state< BiosPolicy.AcsControlGpu5stateEnum>][-AcsControlGpu6state< BiosPolicy.AcsControlGpu6stateEnum>][-AcsControlGpu7state< BiosPolicy.AcsControlGpu7stateEnum>][-AcsControlGpu8state< BiosPolicy.AcsControlGpu8stateEnum>][-AcsControlSlot11state< BiosPolicy.AcsControlSlot11stateEnum>][-AcsControlSlot12state< BiosPolicy.AcsControlSlot12stateEnum>][-AcsControlSlot13state< BiosPolicy.AcsControlSlot13stateEnum>][-AcsControlSlot14state< BiosPolicy.AcsControlSlot14stateEnum>][-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-AdjacentCacheLinePrefetch< BiosPolicy.AdjacentCacheLinePrefetchEnum>][-AdvancedMemTest< BiosPolicy.AdvancedMemTestEnum>][-AllUsbDevices< BiosPolicy.AllUsbDevicesEnum>][-Altitude< BiosPolicy.AltitudeEnum>][-AspmSupport< BiosPolicy.AspmSupportEnum>][-AssertNmiOnPerr< BiosPolicy.AssertNmiOnPerrEnum>][-AssertNmiOnSerr< BiosPolicy.AssertNmiOnSerrEnum>][-AutoCcState< BiosPolicy.AutoCcStateEnum>][-AutonumousCstateEnable< BiosPolicy.AutonumousCstateEnableEnum>][-BaudRate< BiosPolicy.BaudRateEnum>][-BmeDmaMitigation< BiosPolicy.BmeDmaMitigationEnum>][-BootOptionNumRetry< BiosPolicy.BootOptionNumRetryEnum>][-BootOptionReCoolDown< BiosPolicy.BootOptionReCoolDownEnum>][-BootOptionRetry< BiosPolicy.BootOptionRetryEnum>][-BootPerformanceMode< BiosPolicy.BootPerformanceModeEnum>][-BurstAndPostponedRefresh< BiosPolicy.BurstAndPostponedRefreshEnum>][-C1autoDemotion< BiosPolicy.C1autoDemotionEnum>][-C1autoUnDemotion< BiosPolicy.C1autoUnDemotionEnum>][-CbsCmnApbdis< BiosPolicy.CbsCmnApbdisEnum>][-CbsCmnCpuCpb< BiosPolicy.CbsCmnCpuCpbEnum>][-CbsCmnCpuGenDowncoreCtrl< BiosPolicy.CbsCmnCpuGenDowncoreCtrlEnum>][-CbsCmnCpuGlobalCstateCtrl< BiosPolicy.CbsCmnCpuGlobalCstateCtrlEnum>][-CbsCmnCpuL1streamHwPrefetcher< BiosPolicy.CbsCmnCpuL1streamHwPrefetcherEnum>][-CbsCmnCpuL2streamHwPrefetcher< BiosPolicy.CbsCmnCpuL2streamHwPrefetcherEnum>][-CbsCmnCpuSmee< BiosPolicy.CbsCmnCpuSmeeEnum>][-CbsCmnCpuStreamingStoresCtrl< BiosPolicy.CbsCmnCpuStreamingStoresCtrlEnum>][-CbsCmnDeterminismSlider< BiosPolicy.CbsCmnDeterminismSliderEnum>][-CbsCmnEfficiencyModeEn< BiosPolicy.CbsCmnEfficiencyModeEnEnum>][-CbsCmnFixedSocPstate< BiosPolicy.CbsCmnFixedSocPstateEnum>][-CbsCmnGnbNbIommu< BiosPolicy.CbsCmnGnbNbIommuEnum>][-CbsCmnGnbSmuDfCstates< BiosPolicy.CbsCmnGnbSmuDfCstatesEnum>][-CbsCmnGnbSmucppc< BiosPolicy.CbsCmnGnbSmucppcEnum>][-CbsCmnMemCtrlBankGroupSwapDdr4< BiosPolicy.CbsCmnMemCtrlBankGroupSwapDdr4Enum>][-CbsCmnMemMapBankInterleaveDdr4< BiosPolicy.CbsCmnMemMapBankInterleaveDdr4Enum>][-CbsCmncTdpCtl< BiosPolicy.CbsCmncTdpCtlEnum>][-CbsCpuCcdCtrlSsp< BiosPolicy.CbsCpuCcdCtrlSspEnum>][-CbsCpuCoreCtrl< BiosPolicy.CbsCpuCoreCtrlEnum>][-CbsCpuSmtCtrl< BiosPolicy.CbsCpuSmtCtrlEnum>][-CbsDbgCpuSnpMemCover< BiosPolicy.CbsDbgCpuSnpMemCoverEnum>][-CbsDbgCpuSnpMemSizeCover< string>][-CbsDfCmnAcpiSratL3numa< BiosPolicy.CbsDfCmnAcpiSratL3numaEnum>][-CbsDfCmnDramNps< BiosPolicy.CbsDfCmnDramNpsEnum>][-CbsDfCmnMemIntlv< BiosPolicy.CbsDfCmnMemIntlvEnum>][-CbsDfCmnMemIntlvSize< BiosPolicy.CbsDfCmnMemIntlvSizeEnum>][-CbsSevSnpSupport< BiosPolicy.CbsSevSnpSupportEnum>][-CdnEnable< BiosPolicy.CdnEnableEnum>][-CdnSupport< BiosPolicy.CdnSupportEnum>][-ChannelInterLeave< BiosPolicy.ChannelInterLeaveEnum>][-CiscoAdaptiveMemTraining< BiosPolicy.CiscoAdaptiveMemTrainingEnum>][-CiscoDebugLevel< BiosPolicy.CiscoDebugLevelEnum>][-CiscoOpromLaunchOptimization< BiosPolicy.CiscoOpromLaunchOptimizationEnum>][-CiscoXgmiMaxSpeed< BiosPolicy.CiscoXgmiMaxSpeedEnum>][-CkeLowPolicy< BiosPolicy.CkeLowPolicyEnum>][-ClosedLoopThermThrotl< BiosPolicy.ClosedLoopThermThrotlEnum>][-CmciEnable< BiosPolicy.CmciEnableEnum>][-ConfigTdp< BiosPolicy.ConfigTdpEnum>][-ConfigTdpLevel< BiosPolicy.ConfigTdpLevelEnum>][-ConsoleRedirection< BiosPolicy.ConsoleRedirectionEnum>][-CoreMultiProcessing< BiosPolicy.CoreMultiProcessingEnum>][-CpuEnergyPerformance< BiosPolicy.CpuEnergyPerformanceEnum>][-CpuFrequencyFloor< BiosPolicy.CpuFrequencyFloorEnum>][-CpuPerfEnhancement< BiosPolicy.CpuPerfEnhancementEnum>][-CpuPerformance< BiosPolicy.CpuPerformanceEnum>][-CpuPowerManagement< BiosPolicy.CpuPowerManagementEnum>][-CrQos< BiosPolicy.CrQosEnum>][-CrfastgoConfig< BiosPolicy.CrfastgoConfigEnum>][-DcpmmFirmwareDowngrade< BiosPolicy.DcpmmFirmwareDowngradeEnum>][-DemandScrub< BiosPolicy.DemandScrubEnum>][-Description< string>][-DirectCacheAccess< BiosPolicy.DirectCacheAccessEnum>][-DramClockThrottling< BiosPolicy.DramClockThrottlingEnum>][-DramRefreshRate< BiosPolicy.DramRefreshRateEnum>][-DramSwThermalThrottling< BiosPolicy.DramSwThermalThrottlingEnum>][-EadrSupport< BiosPolicy.EadrSupportEnum>][-EdpcEn< BiosPolicy.EdpcEnEnum>][-EnableClockSpreadSpec< BiosPolicy.EnableClockSpreadSpecEnum>][-EnableMktme< BiosPolicy.EnableMktmeEnum>][-EnableSgx< BiosPolicy.EnableSgxEnum>][-EnableTme< BiosPolicy.EnableTmeEnum>][-EnergyEfficientTurbo< BiosPolicy.EnergyEfficientTurboEnum>][-EngPerfTuning< BiosPolicy.EngPerfTuningEnum>][-EnhancedIntelSpeedStepTech< BiosPolicy.EnhancedIntelSpeedStepTechEnum>][-EpochUpdate< BiosPolicy.EpochUpdateEnum>][-EppEnable< BiosPolicy.EppEnableEnum>][-EppProfile< BiosPolicy.EppProfileEnum>][-ExecuteDisableBit< BiosPolicy.ExecuteDisableBitEnum>][-ExtendedApic< BiosPolicy.ExtendedApicEnum>][-FlowControl< BiosPolicy.FlowControlEnum>][-Frb2enable< BiosPolicy.Frb2enableEnum>][-HardwarePrefetch< BiosPolicy.HardwarePrefetchEnum>][-HwpmEnable< BiosPolicy.HwpmEnableEnum>][-ImcInterleave< BiosPolicy.ImcInterleaveEnum>][-IntelDynamicSpeedSelect< BiosPolicy.IntelDynamicSpeedSelectEnum>][-IntelHyperThreadingTech< BiosPolicy.IntelHyperThreadingTechEnum>][-IntelSpeedSelect< BiosPolicy.IntelSpeedSelectEnum>][-IntelTurboBoostTech< BiosPolicy.IntelTurboBoostTechEnum>][-IntelVirtualizationTechnology< BiosPolicy.IntelVirtualizationTechnologyEnum>][-IntelVtForDirectedIo< BiosPolicy.IntelVtForDirectedIoEnum>][-IntelVtdCoherencySupport< BiosPolicy.IntelVtdCoherencySupportEnum>][-IntelVtdInterruptRemapping< BiosPolicy.IntelVtdInterruptRemappingEnum>][-IntelVtdPassThroughDmaSupport< BiosPolicy.IntelVtdPassThroughDmaSupportEnum>][-IntelVtdatsSupport< BiosPolicy.IntelVtdatsSupportEnum>][-IohErrorEnable< BiosPolicy.IohErrorEnableEnum>][-IohResource< BiosPolicy.IohResourceEnum>][-IpPrefetch< BiosPolicy.IpPrefetchEnum>][-Ipv4http< BiosPolicy.Ipv4httpEnum>][-Ipv4pxe< BiosPolicy.Ipv4pxeEnum>][-Ipv6http< BiosPolicy.Ipv6httpEnum>][-Ipv6pxe< BiosPolicy.Ipv6pxeEnum>][-KtiPrefetch< BiosPolicy.KtiPrefetchEnum>][-LegacyOsRedirection< BiosPolicy.LegacyOsRedirectionEnum>][-LegacyUsbSupport< BiosPolicy.LegacyUsbSupportEnum>][-LlcAlloc< BiosPolicy.LlcAllocEnum>][-LlcPrefetch< BiosPolicy.LlcPrefetchEnum>][-LomPort0state< BiosPolicy.LomPort0stateEnum>][-LomPort1state< BiosPolicy.LomPort1stateEnum>][-LomPort2state< BiosPolicy.LomPort2stateEnum>][-LomPort3state< BiosPolicy.LomPort3stateEnum>][-LomPortsAllState< BiosPolicy.LomPortsAllStateEnum>][-LvDdrMode< BiosPolicy.LvDdrModeEnum>][-MakeDeviceNonBootable< BiosPolicy.MakeDeviceNonBootableEnum>][-MemoryBandwidthBoost< BiosPolicy.MemoryBandwidthBoostEnum>][-MemoryInterLeave< BiosPolicy.MemoryInterLeaveEnum>][-MemoryMappedIoAbove4gb< BiosPolicy.MemoryMappedIoAbove4gbEnum>][-MemoryRefreshRate< BiosPolicy.MemoryRefreshRateEnum>][-MemorySizeLimit< string>][-MemoryThermalThrottling< BiosPolicy.MemoryThermalThrottlingEnum>][-MirroringMode< BiosPolicy.MirroringModeEnum>][-MmcfgBase< BiosPolicy.MmcfgBaseEnum>][[-Moid]< string>][-Name< string>][-NetworkStack< BiosPolicy.NetworkStackEnum>][-NumaOptimized< BiosPolicy.NumaOptimizedEnum>][-NvmdimmPerformConfig< BiosPolicy.NvmdimmPerformConfigEnum>][-Onboard10gbitLom< BiosPolicy.Onboard10gbitLomEnum>][-OnboardGbitLom< BiosPolicy.OnboardGbitLomEnum>][-OnboardScuStorageSupport< BiosPolicy.OnboardScuStorageSupportEnum>][-OnboardScuStorageSwStack< BiosPolicy.OnboardScuStorageSwStackEnum>][-OperationMode< BiosPolicy.OperationModeEnum>][-Organization< OrganizationOrganizationRelationship>][-OsBootWatchdogTimer< BiosPolicy.OsBootWatchdogTimerEnum>][-OsBootWatchdogTimerPolicy< BiosPolicy.OsBootWatchdogTimerPolicyEnum>][-OsBootWatchdogTimerTimeout< BiosPolicy.OsBootWatchdogTimerTimeoutEnum>][-OutOfBandMgmtPort< BiosPolicy.OutOfBandMgmtPortEnum>][-PackageCstateLimit< BiosPolicy.PackageCstateLimitEnum>][-PanicHighWatermark< BiosPolicy.PanicHighWatermarkEnum>][-PartialCacheLineSparing< BiosPolicy.PartialCacheLineSparingEnum>][-PartialMirrorModeConfig< BiosPolicy.PartialMirrorModeConfigEnum>][-PartialMirrorPercent< string>][-PartialMirrorValue1< string>][-PartialMirrorValue2< string>][-PartialMirrorValue3< string>][-PartialMirrorValue4< string>][-PatrolScrub< BiosPolicy.PatrolScrubEnum>][-PatrolScrubDuration< string>][-PcIeRasSupport< BiosPolicy.PcIeRasSupportEnum>][-PcIeSsdHotPlugSupport< BiosPolicy.PcIeSsdHotPlugSupportEnum>][-PchUsb30mode< BiosPolicy.PchUsb30modeEnum>][-PciOptionRoMs< BiosPolicy.PciOptionRoMsEnum>][-PciRomClp< BiosPolicy.PciRomClpEnum>][-PcieAriSupport< BiosPolicy.PcieAriSupportEnum>][-PciePllSsc< BiosPolicy.PciePllSscEnum>][-PcieSlotMraid1linkSpeed< BiosPolicy.PcieSlotMraid1linkSpeedEnum>][-PcieSlotMraid1optionRom< BiosPolicy.PcieSlotMraid1optionRomEnum>][-PcieSlotMraid2linkSpeed< BiosPolicy.PcieSlotMraid2linkSpeedEnum>][-PcieSlotMraid2optionRom< BiosPolicy.PcieSlotMraid2optionRomEnum>][-PcieSlotMstorraidLinkSpeed< BiosPolicy.PcieSlotMstorraidLinkSpeedEnum>][-PcieSlotMstorraidOptionRom< BiosPolicy.PcieSlotMstorraidOptionRomEnum>][-PcieSlotNvme1linkSpeed< BiosPolicy.PcieSlotNvme1linkSpeedEnum>][-PcieSlotNvme1optionRom< BiosPolicy.PcieSlotNvme1optionRomEnum>][-PcieSlotNvme2linkSpeed< BiosPolicy.PcieSlotNvme2linkSpeedEnum>][-PcieSlotNvme2optionRom< BiosPolicy.PcieSlotNvme2optionRomEnum>][-PcieSlotNvme3linkSpeed< BiosPolicy.PcieSlotNvme3linkSpeedEnum>][-PcieSlotNvme3optionRom< BiosPolicy.PcieSlotNvme3optionRomEnum>][-PcieSlotNvme4linkSpeed< BiosPolicy.PcieSlotNvme4linkSpeedEnum>][-PcieSlotNvme4optionRom< BiosPolicy.PcieSlotNvme4optionRomEnum>][-PcieSlotNvme5linkSpeed< BiosPolicy.PcieSlotNvme5linkSpeedEnum>][-PcieSlotNvme5optionRom< BiosPolicy.PcieSlotNvme5optionRomEnum>][-PcieSlotNvme6linkSpeed< BiosPolicy.PcieSlotNvme6linkSpeedEnum>][-PcieSlotNvme6optionRom< BiosPolicy.PcieSlotNvme6optionRomEnum>][-PcieSlotsCdnEnable< BiosPolicy.PcieSlotsCdnEnableEnum>][-PopSupport< BiosPolicy.PopSupportEnum>][-PostErrorPause< BiosPolicy.PostErrorPauseEnum>][-PostPackageRepair< BiosPolicy.PostPackageRepairEnum>][-ProcessorC1e< BiosPolicy.ProcessorC1eEnum>][-ProcessorC3report< BiosPolicy.ProcessorC3reportEnum>][-ProcessorC6report< BiosPolicy.ProcessorC6reportEnum>][-ProcessorCstate< BiosPolicy.ProcessorCstateEnum>][-Profiles< System.Collections.Generic.List`1[PolicyAbstractConfigProfileRelationship]>][-Psata< BiosPolicy.PsataEnum>][-PstateCoordType< BiosPolicy.PstateCoordTypeEnum>][-PuttyKeyPad< BiosPolicy.PuttyKeyPadEnum>][-PwrPerfTuning< BiosPolicy.PwrPerfTuningEnum>][-QpiLinkFrequency< BiosPolicy.QpiLinkFrequencyEnum>][-QpiLinkSpeed< BiosPolicy.QpiLinkSpeedEnum>][-QpiSnoopMode< BiosPolicy.QpiSnoopModeEnum>][-RankInterLeave< BiosPolicy.RankInterLeaveEnum>][-RedirectionAfterPost< BiosPolicy.RedirectionAfterPostEnum>][-SataModeSelect< BiosPolicy.SataModeSelectEnum>][-SelectMemoryRasConfiguration< BiosPolicy.SelectMemoryRasConfigurationEnum>][-SelectPprType< BiosPolicy.SelectPprTypeEnum>][-SerialPortAenable< BiosPolicy.SerialPortAenableEnum>][-Sev< BiosPolicy.SevEnum>][-SgxAutoRegistrationAgent< BiosPolicy.SgxAutoRegistrationAgentEnum>][-SgxEpoch0< string>][-SgxEpoch1< string>][-SgxFactoryReset< BiosPolicy.SgxFactoryResetEnum>][-SgxLePubKeyHash0< string>][-SgxLePubKeyHash1< string>][-SgxLePubKeyHash2< string>][-SgxLePubKeyHash3< string>][-SgxLeWr< BiosPolicy.SgxLeWrEnum>][-SgxPackageInfoInBandAccess< BiosPolicy.SgxPackageInfoInBandAccessEnum>][-SgxQos< BiosPolicy.SgxQosEnum>][-Sha1pcrBank< BiosPolicy.Sha1pcrBankEnum>][-Sha256pcrBank< BiosPolicy.Sha256pcrBankEnum>][-SinglePctlEnable< BiosPolicy.SinglePctlEnableEnum>][-Slot10linkSpeed< BiosPolicy.Slot10linkSpeedEnum>][-Slot10state< BiosPolicy.Slot10stateEnum>][-Slot11linkSpeed< BiosPolicy.Slot11linkSpeedEnum>][-Slot11state< BiosPolicy.Slot11stateEnum>][-Slot12linkSpeed< BiosPolicy.Slot12linkSpeedEnum>][-Slot12state< BiosPolicy.Slot12stateEnum>][-Slot13state< BiosPolicy.Slot13stateEnum>][-Slot14state< BiosPolicy.Slot14stateEnum>][-Slot1linkSpeed< BiosPolicy.Slot1linkSpeedEnum>][-Slot1state< BiosPolicy.Slot1stateEnum>][-Slot2linkSpeed< BiosPolicy.Slot2linkSpeedEnum>][-Slot2state< BiosPolicy.Slot2stateEnum>][-Slot3linkSpeed< BiosPolicy.Slot3linkSpeedEnum>][-Slot3state< BiosPolicy.Slot3stateEnum>][-Slot4linkSpeed< BiosPolicy.Slot4linkSpeedEnum>][-Slot4state< BiosPolicy.Slot4stateEnum>][-Slot5linkSpeed< BiosPolicy.Slot5linkSpeedEnum>][-Slot5state< BiosPolicy.Slot5stateEnum>][-Slot6linkSpeed< BiosPolicy.Slot6linkSpeedEnum>][-Slot6state< BiosPolicy.Slot6stateEnum>][-Slot7linkSpeed< BiosPolicy.Slot7linkSpeedEnum>][-Slot7state< BiosPolicy.Slot7stateEnum>][-Slot8linkSpeed< BiosPolicy.Slot8linkSpeedEnum>][-Slot8state< BiosPolicy.Slot8stateEnum>][-Slot9linkSpeed< BiosPolicy.Slot9linkSpeedEnum>][-Slot9state< BiosPolicy.Slot9stateEnum>][-SlotFlomLinkSpeed< BiosPolicy.SlotFlomLinkSpeedEnum>][-SlotFrontNvme10linkSpeed< BiosPolicy.SlotFrontNvme10linkSpeedEnum>][-SlotFrontNvme10optionRom< BiosPolicy.SlotFrontNvme10optionRomEnum>][-SlotFrontNvme11linkSpeed< BiosPolicy.SlotFrontNvme11linkSpeedEnum>][-SlotFrontNvme11optionRom< BiosPolicy.SlotFrontNvme11optionRomEnum>][-SlotFrontNvme12linkSpeed< BiosPolicy.SlotFrontNvme12linkSpeedEnum>][-SlotFrontNvme12optionRom< BiosPolicy.SlotFrontNvme12optionRomEnum>][-SlotFrontNvme13optionRom< BiosPolicy.SlotFrontNvme13optionRomEnum>][-SlotFrontNvme14optionRom< BiosPolicy.SlotFrontNvme14optionRomEnum>][-SlotFrontNvme15optionRom< BiosPolicy.SlotFrontNvme15optionRomEnum>][-SlotFrontNvme16optionRom< BiosPolicy.SlotFrontNvme16optionRomEnum>][-SlotFrontNvme17optionRom< BiosPolicy.SlotFrontNvme17optionRomEnum>][-SlotFrontNvme18optionRom< BiosPolicy.SlotFrontNvme18optionRomEnum>][-SlotFrontNvme19optionRom< BiosPolicy.SlotFrontNvme19optionRomEnum>][-SlotFrontNvme1linkSpeed< BiosPolicy.SlotFrontNvme1linkSpeedEnum>][-SlotFrontNvme1optionRom< BiosPolicy.SlotFrontNvme1optionRomEnum>][-SlotFrontNvme20optionRom< BiosPolicy.SlotFrontNvme20optionRomEnum>][-SlotFrontNvme21optionRom< BiosPolicy.SlotFrontNvme21optionRomEnum>][-SlotFrontNvme22optionRom< BiosPolicy.SlotFrontNvme22optionRomEnum>][-SlotFrontNvme23optionRom< BiosPolicy.SlotFrontNvme23optionRomEnum>][-SlotFrontNvme24optionRom< BiosPolicy.SlotFrontNvme24optionRomEnum>][-SlotFrontNvme2linkSpeed< BiosPolicy.SlotFrontNvme2linkSpeedEnum>][-SlotFrontNvme2optionRom< BiosPolicy.SlotFrontNvme2optionRomEnum>][-SlotFrontNvme3linkSpeed< BiosPolicy.SlotFrontNvme3linkSpeedEnum>][-SlotFrontNvme3optionRom< BiosPolicy.SlotFrontNvme3optionRomEnum>][-SlotFrontNvme4linkSpeed< BiosPolicy.SlotFrontNvme4linkSpeedEnum>][-SlotFrontNvme4optionRom< BiosPolicy.SlotFrontNvme4optionRomEnum>][-SlotFrontNvme5linkSpeed< BiosPolicy.SlotFrontNvme5linkSpeedEnum>][-SlotFrontNvme5optionRom< BiosPolicy.SlotFrontNvme5optionRomEnum>][-SlotFrontNvme6linkSpeed< BiosPolicy.SlotFrontNvme6linkSpeedEnum>][-SlotFrontNvme6optionRom< BiosPolicy.SlotFrontNvme6optionRomEnum>][-SlotFrontNvme7linkSpeed< BiosPolicy.SlotFrontNvme7linkSpeedEnum>][-SlotFrontNvme7optionRom< BiosPolicy.SlotFrontNvme7optionRomEnum>][-SlotFrontNvme8linkSpeed< BiosPolicy.SlotFrontNvme8linkSpeedEnum>][-SlotFrontNvme8optionRom< BiosPolicy.SlotFrontNvme8optionRomEnum>][-SlotFrontNvme9linkSpeed< BiosPolicy.SlotFrontNvme9linkSpeedEnum>][-SlotFrontNvme9optionRom< BiosPolicy.SlotFrontNvme9optionRomEnum>][-SlotFrontSlot5linkSpeed< BiosPolicy.SlotFrontSlot5linkSpeedEnum>][-SlotFrontSlot6linkSpeed< BiosPolicy.SlotFrontSlot6linkSpeedEnum>][-SlotGpu1state< BiosPolicy.SlotGpu1stateEnum>][-SlotGpu2state< BiosPolicy.SlotGpu2stateEnum>][-SlotGpu3state< BiosPolicy.SlotGpu3stateEnum>][-SlotGpu4state< BiosPolicy.SlotGpu4stateEnum>][-SlotGpu5state< BiosPolicy.SlotGpu5stateEnum>][-SlotGpu6state< BiosPolicy.SlotGpu6stateEnum>][-SlotGpu7state< BiosPolicy.SlotGpu7stateEnum>][-SlotGpu8state< BiosPolicy.SlotGpu8stateEnum>][-SlotHbaLinkSpeed< BiosPolicy.SlotHbaLinkSpeedEnum>][-SlotHbaState< BiosPolicy.SlotHbaStateEnum>][-SlotLom1link< BiosPolicy.SlotLom1linkEnum>][-SlotLom2link< BiosPolicy.SlotLom2linkEnum>][-SlotMezzState< BiosPolicy.SlotMezzStateEnum>][-SlotMlomLinkSpeed< BiosPolicy.SlotMlomLinkSpeedEnum>][-SlotMlomState< BiosPolicy.SlotMlomStateEnum>][-SlotMraidLinkSpeed< BiosPolicy.SlotMraidLinkSpeedEnum>][-SlotMraidState< BiosPolicy.SlotMraidStateEnum>][-SlotN10state< BiosPolicy.SlotN10stateEnum>][-SlotN11state< BiosPolicy.SlotN11stateEnum>][-SlotN12state< BiosPolicy.SlotN12stateEnum>][-SlotN13state< BiosPolicy.SlotN13stateEnum>][-SlotN14state< BiosPolicy.SlotN14stateEnum>][-SlotN15state< BiosPolicy.SlotN15stateEnum>][-SlotN16state< BiosPolicy.SlotN16stateEnum>][-SlotN17state< BiosPolicy.SlotN17stateEnum>][-SlotN18state< BiosPolicy.SlotN18stateEnum>][-SlotN19state< BiosPolicy.SlotN19stateEnum>][-SlotN1state< BiosPolicy.SlotN1stateEnum>][-SlotN20state< BiosPolicy.SlotN20stateEnum>][-SlotN21state< BiosPolicy.SlotN21stateEnum>][-SlotN22state< BiosPolicy.SlotN22stateEnum>][-SlotN23state< BiosPolicy.SlotN23stateEnum>][-SlotN24state< BiosPolicy.SlotN24stateEnum>][-SlotN2state< BiosPolicy.SlotN2stateEnum>][-SlotN3state< BiosPolicy.SlotN3stateEnum>][-SlotN4state< BiosPolicy.SlotN4stateEnum>][-SlotN5state< BiosPolicy.SlotN5stateEnum>][-SlotN6state< BiosPolicy.SlotN6stateEnum>][-SlotN7state< BiosPolicy.SlotN7stateEnum>][-SlotN8state< BiosPolicy.SlotN8stateEnum>][-SlotN9state< BiosPolicy.SlotN9stateEnum>][-SlotRaidLinkSpeed< BiosPolicy.SlotRaidLinkSpeedEnum>][-SlotRaidState< BiosPolicy.SlotRaidStateEnum>][-SlotRearNvme1linkSpeed< BiosPolicy.SlotRearNvme1linkSpeedEnum>][-SlotRearNvme1state< BiosPolicy.SlotRearNvme1stateEnum>][-SlotRearNvme2linkSpeed< BiosPolicy.SlotRearNvme2linkSpeedEnum>][-SlotRearNvme2state< BiosPolicy.SlotRearNvme2stateEnum>][-SlotRearNvme3linkSpeed< BiosPolicy.SlotRearNvme3linkSpeedEnum>][-SlotRearNvme3state< BiosPolicy.SlotRearNvme3stateEnum>][-SlotRearNvme4linkSpeed< BiosPolicy.SlotRearNvme4linkSpeedEnum>][-SlotRearNvme4state< BiosPolicy.SlotRearNvme4stateEnum>][-SlotRearNvme5state< BiosPolicy.SlotRearNvme5stateEnum>][-SlotRearNvme6state< BiosPolicy.SlotRearNvme6stateEnum>][-SlotRearNvme7state< BiosPolicy.SlotRearNvme7stateEnum>][-SlotRearNvme8state< BiosPolicy.SlotRearNvme8stateEnum>][-SlotRiser1linkSpeed< BiosPolicy.SlotRiser1linkSpeedEnum>][-SlotRiser1slot1linkSpeed< BiosPolicy.SlotRiser1slot1linkSpeedEnum>][-SlotRiser1slot2linkSpeed< BiosPolicy.SlotRiser1slot2linkSpeedEnum>][-SlotRiser1slot3linkSpeed< BiosPolicy.SlotRiser1slot3linkSpeedEnum>][-SlotRiser2linkSpeed< BiosPolicy.SlotRiser2linkSpeedEnum>][-SlotRiser2slot4linkSpeed< BiosPolicy.SlotRiser2slot4linkSpeedEnum>][-SlotRiser2slot5linkSpeed< BiosPolicy.SlotRiser2slot5linkSpeedEnum>][-SlotRiser2slot6linkSpeed< BiosPolicy.SlotRiser2slot6linkSpeedEnum>][-SlotSasState< BiosPolicy.SlotSasStateEnum>][-SlotSsdSlot1linkSpeed< BiosPolicy.SlotSsdSlot1linkSpeedEnum>][-SlotSsdSlot2linkSpeed< BiosPolicy.SlotSsdSlot2linkSpeedEnum>][-Smee< BiosPolicy.SmeeEnum>][-SmtMode< BiosPolicy.SmtModeEnum>][-Snc< BiosPolicy.SncEnum>][-SnoopyModeFor2lm< BiosPolicy.SnoopyModeFor2lmEnum>][-SnoopyModeForAd< BiosPolicy.SnoopyModeForAdEnum>][-SparingMode< BiosPolicy.SparingModeEnum>][-SrIov< BiosPolicy.SrIovEnum>][-StreamerPrefetch< BiosPolicy.StreamerPrefetchEnum>][-SvmMode< BiosPolicy.SvmModeEnum>][-Tags< System.Collections.Generic.List`1[MoTag]>][-TerminalType< BiosPolicy.TerminalTypeEnum>][-TpmControl< BiosPolicy.TpmControlEnum>][-TpmPendingOperation< BiosPolicy.TpmPendingOperationEnum>][-TpmSupport< BiosPolicy.TpmSupportEnum>][-Tsme< BiosPolicy.TsmeEnum>][-TxtSupport< BiosPolicy.TxtSupportEnum>][-UcsmBootOrderRule< BiosPolicy.UcsmBootOrderRuleEnum>][-UfsDisable< BiosPolicy.UfsDisableEnum>][-UmaBasedClustering< BiosPolicy.UmaBasedClusteringEnum>][-UpiLinkEnablement< BiosPolicy.UpiLinkEnablementEnum>][-UpiPowerManagement< BiosPolicy.UpiPowerManagementEnum>][-UsbEmul6064< BiosPolicy.UsbEmul6064Enum>][-UsbPortFront< BiosPolicy.UsbPortFrontEnum>][-UsbPortInternal< BiosPolicy.UsbPortInternalEnum>][-UsbPortKvm< BiosPolicy.UsbPortKvmEnum>][-UsbPortRear< BiosPolicy.UsbPortRearEnum>][-UsbPortSdCard< BiosPolicy.UsbPortSdCardEnum>][-UsbPortVmedia< BiosPolicy.UsbPortVmediaEnum>][-UsbXhciSupport< BiosPolicy.UsbXhciSupportEnum>][-VgaPriority< BiosPolicy.VgaPriorityEnum>][-VirtualNuma< BiosPolicy.VirtualNumaEnum>][-VmdEnable< BiosPolicy.VmdEnableEnum>][-VolMemoryMode< BiosPolicy.VolMemoryModeEnum>][-WorkLoadConfig< BiosPolicy.WorkLoadConfigEnum>][-XptPrefetch< BiosPolicy.XptPrefetchEnum>][-XptRemotePrefetch< BiosPolicy.XptRemotePrefetchEnum>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Update a &apos;BiosPolicy&apos; resource.

## PARAMETERS

### -AcsControlGpu1state
BIOS Token for setting ACS Control GPU 1 configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.AcsControlGpu1stateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -AcsControlGpu2state
BIOS Token for setting ACS Control GPU 2 configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.AcsControlGpu2stateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -AcsControlGpu3state
BIOS Token for setting ACS Control GPU 3 configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.AcsControlGpu3stateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -AcsControlGpu4state
BIOS Token for setting ACS Control GPU 4 configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.AcsControlGpu4stateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -AcsControlGpu5state
BIOS Token for setting ACS Control GPU 5 configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.AcsControlGpu5stateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -AcsControlGpu6state
BIOS Token for setting ACS Control GPU 6 configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.AcsControlGpu6stateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -AcsControlGpu7state
BIOS Token for setting ACS Control GPU 7 configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.AcsControlGpu7stateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -AcsControlGpu8state
BIOS Token for setting ACS Control GPU 8 configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.AcsControlGpu8stateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -AcsControlSlot11state
BIOS Token for setting ACS Control Slot 11 configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.AcsControlSlot11stateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -AcsControlSlot12state
BIOS Token for setting ACS Control Slot 12 configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.AcsControlSlot12stateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -AcsControlSlot13state
BIOS Token for setting ACS Control Slot 13 configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.AcsControlSlot13stateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -AcsControlSlot14state
BIOS Token for setting ACS Control Slot 14 configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.AcsControlSlot14stateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -AdditionalProperties


```yaml
Type: System.Collections.Generic.Dictionary`2[string,object]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -AdjacentCacheLinePrefetch
BIOS Token for setting Adjacent Cache Line Prefetcher configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.AdjacentCacheLinePrefetchEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -AdvancedMemTest
BIOS Token for setting Enhanced Memory Test configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring AdvancedMemTest token.\n* `disabled` - Value - disabled for configuring AdvancedMemTest token.\n* `enabled` - Value - enabled for configuring AdvancedMemTest token.

```yaml
Type: BiosPolicy.AdvancedMemTestEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -AllUsbDevices
BIOS Token for setting All USB Devices configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.AllUsbDevicesEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Altitude
BIOS Token for setting Altitude configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `300-m` - Value - 300-m for configuring Altitude token.\n* `900-m` - Value - 900-m for configuring Altitude token.\n* `1500-m` - Value - 1500-m for configuring Altitude token.\n* `3000-m` - Value - 3000-m for configuring Altitude token.\n* `auto` - Value - auto for configuring Altitude token.

```yaml
Type: BiosPolicy.AltitudeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -AspmSupport
BIOS Token for setting ASPM Support configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring AspmSupport token.\n* `Disabled` - Value - Disabled for configuring AspmSupport token.\n* `Force L0s` - Value - Force L0s for configuring AspmSupport token.\n* `L1 Only` - Value - L1 Only for configuring AspmSupport token.

```yaml
Type: BiosPolicy.AspmSupportEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -AssertNmiOnPerr
BIOS Token for setting Assert NMI on PERR configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.AssertNmiOnPerrEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -AssertNmiOnSerr
BIOS Token for setting Assert NMI on SERR configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.AssertNmiOnSerrEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -AutoCcState
BIOS Token for setting Autonomous Core C State configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.AutoCcStateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -AutonumousCstateEnable
BIOS Token for setting CPU Autonomous C State configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.AutonumousCstateEnableEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -BaudRate
BIOS Token for setting Baud Rate configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `9600` - Value - 9600 for configuring BaudRate token.\n* `19200` - Value - 19200 for configuring BaudRate token.\n* `38400` - Value - 38400 for configuring BaudRate token.\n* `57600` - Value - 57600 for configuring BaudRate token.\n* `115200` - Value - 115200 for configuring BaudRate token.

```yaml
Type: BiosPolicy.BaudRateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -BmeDmaMitigation
BIOS Token for setting BME DMA Mitigation configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.BmeDmaMitigationEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -BootOptionNumRetry
BIOS Token for setting Number of Retries configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `5` - Value - 5 for configuring BootOptionNumRetry token.\n* `13` - Value - 13 for configuring BootOptionNumRetry token.\n* `Infinite` - Value - Infinite for configuring BootOptionNumRetry token.

```yaml
Type: BiosPolicy.BootOptionNumRetryEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -BootOptionReCoolDown
BIOS Token for setting Cool Down Time  (sec) configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `15` - Value - 15 for configuring BootOptionReCoolDown token.\n* `45` - Value - 45 for configuring BootOptionReCoolDown token.\n* `90` - Value - 90 for configuring BootOptionReCoolDown token.

```yaml
Type: BiosPolicy.BootOptionReCoolDownEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -BootOptionRetry
BIOS Token for setting Boot Option Retry configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.BootOptionRetryEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -BootPerformanceMode
BIOS Token for setting Boot Performance Mode configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Max Efficient` - Value - Max Efficient for configuring BootPerformanceMode token.\n* `Max Performance` - Value - Max Performance for configuring BootPerformanceMode token.\n* `Set by Intel NM` - Value - Set by Intel NM for configuring BootPerformanceMode token.

```yaml
Type: BiosPolicy.BootPerformanceModeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -BurstAndPostponedRefresh
BIOS Token for setting Burst and Postponed Refresh configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.BurstAndPostponedRefreshEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -C1autoDemotion
BIOS Token for setting C1 Auto Demotion configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.C1autoDemotionEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -C1autoUnDemotion
BIOS Token for setting C1 Auto UnDemotion configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.C1autoUnDemotionEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -CbsCmnApbdis
BIOS Token for setting APBDIS configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `0` - Value - 0 for configuring CbsCmnApbdis token.\n* `1` - Value - 1 for configuring CbsCmnApbdis token.\n* `Auto` - Value - Auto for configuring CbsCmnApbdis token.

```yaml
Type: BiosPolicy.CbsCmnApbdisEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -CbsCmnCpuCpb
BIOS Token for setting Core Performance Boost configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring CbsCmnCpuCpb token.\n* `disabled` - Value - disabled for configuring CbsCmnCpuCpb token.

```yaml
Type: BiosPolicy.CbsCmnCpuCpbEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -CbsCmnCpuGenDowncoreCtrl
BIOS Token for setting Downcore Control configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring CbsCmnCpuGenDowncoreCtrl token.\n* `FOUR (2 + 2)` - Value - FOUR (2 + 2) for configuring CbsCmnCpuGenDowncoreCtrl token.\n* `FOUR (4 + 0)` - Value - FOUR (4 + 0) for configuring CbsCmnCpuGenDowncoreCtrl token.\n* `SIX (3 + 3)` - Value - SIX (3 + 3) for configuring CbsCmnCpuGenDowncoreCtrl token.\n* `THREE (3 + 0)` - Value - THREE (3 + 0) for configuring CbsCmnCpuGenDowncoreCtrl token.\n* `TWO (1 + 1)` - Value - TWO (1 + 1) for configuring CbsCmnCpuGenDowncoreCtrl token.\n* `TWO (2 + 0)` - Value - TWO (2 + 0) for configuring CbsCmnCpuGenDowncoreCtrl token.

```yaml
Type: BiosPolicy.CbsCmnCpuGenDowncoreCtrlEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -CbsCmnCpuGlobalCstateCtrl
BIOS Token for setting Global C State Control configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring CbsCmnCpuGlobalCstateCtrl token.\n* `disabled` - Value - disabled for configuring CbsCmnCpuGlobalCstateCtrl token.\n* `enabled` - Value - enabled for configuring CbsCmnCpuGlobalCstateCtrl token.

```yaml
Type: BiosPolicy.CbsCmnCpuGlobalCstateCtrlEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -CbsCmnCpuL1streamHwPrefetcher
BIOS Token for setting L1 Stream HW Prefetcher configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring CbsCmnCpuL1streamHwPrefetcher token.\n* `disabled` - Value - disabled for configuring CbsCmnCpuL1streamHwPrefetcher token.\n* `enabled` - Value - enabled for configuring CbsCmnCpuL1streamHwPrefetcher token.

```yaml
Type: BiosPolicy.CbsCmnCpuL1streamHwPrefetcherEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -CbsCmnCpuL2streamHwPrefetcher
BIOS Token for setting L2 Stream HW Prefetcher configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring CbsCmnCpuL2streamHwPrefetcher token.\n* `disabled` - Value - disabled for configuring CbsCmnCpuL2streamHwPrefetcher token.\n* `enabled` - Value - enabled for configuring CbsCmnCpuL2streamHwPrefetcher token.

```yaml
Type: BiosPolicy.CbsCmnCpuL2streamHwPrefetcherEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -CbsCmnCpuSmee
BIOS Token for setting CPU SMEE configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring CbsCmnCpuSmee token.\n* `disabled` - Value - disabled for configuring CbsCmnCpuSmee token.\n* `enabled` - Value - enabled for configuring CbsCmnCpuSmee token.

```yaml
Type: BiosPolicy.CbsCmnCpuSmeeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -CbsCmnCpuStreamingStoresCtrl
BIOS Token for setting Streaming Stores Control configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring CbsCmnCpuStreamingStoresCtrl token.\n* `disabled` - Value - disabled for configuring CbsCmnCpuStreamingStoresCtrl token.\n* `enabled` - Value - enabled for configuring CbsCmnCpuStreamingStoresCtrl token.

```yaml
Type: BiosPolicy.CbsCmnCpuStreamingStoresCtrlEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -CbsCmnDeterminismSlider
BIOS Token for setting Determinism Slider configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring CbsCmnDeterminismSlider token.\n* `Performance` - Value - Performance for configuring CbsCmnDeterminismSlider token.\n* `Power` - Value - Power for configuring CbsCmnDeterminismSlider token.

```yaml
Type: BiosPolicy.CbsCmnDeterminismSliderEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -CbsCmnEfficiencyModeEn
BIOS Token for setting Efficiency Mode Enable configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring CbsCmnEfficiencyModeEn token.\n* `Enabled` - Value - Enabled for configuring CbsCmnEfficiencyModeEn token.

```yaml
Type: BiosPolicy.CbsCmnEfficiencyModeEnEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -CbsCmnFixedSocPstate
BIOS Token for setting Fixed SOC P-State configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring CbsCmnFixedSocPstate token.\n* `P0` - Value - P0 for configuring CbsCmnFixedSocPstate token.\n* `P1` - Value - P1 for configuring CbsCmnFixedSocPstate token.\n* `P2` - Value - P2 for configuring CbsCmnFixedSocPstate token.\n* `P3` - Value - P3 for configuring CbsCmnFixedSocPstate token.

```yaml
Type: BiosPolicy.CbsCmnFixedSocPstateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -CbsCmnGnbNbIommu
BIOS Token for setting IOMMU configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring CbsCmnGnbNbIommu token.\n* `disabled` - Value - disabled for configuring CbsCmnGnbNbIommu token.\n* `enabled` - Value - enabled for configuring CbsCmnGnbNbIommu token.

```yaml
Type: BiosPolicy.CbsCmnGnbNbIommuEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -CbsCmnGnbSmuDfCstates
BIOS Token for setting DF C-States configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring CbsCmnGnbSmuDfCstates token.\n* `disabled` - Value - disabled for configuring CbsCmnGnbSmuDfCstates token.\n* `enabled` - Value - enabled for configuring CbsCmnGnbSmuDfCstates token.

```yaml
Type: BiosPolicy.CbsCmnGnbSmuDfCstatesEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -CbsCmnGnbSmucppc
BIOS Token for setting CPPC configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring CbsCmnGnbSmucppc token.\n* `disabled` - Value - disabled for configuring CbsCmnGnbSmucppc token.\n* `enabled` - Value - enabled for configuring CbsCmnGnbSmucppc token.

```yaml
Type: BiosPolicy.CbsCmnGnbSmucppcEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -CbsCmnMemCtrlBankGroupSwapDdr4
BIOS Token for setting Bank Group Swap configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring CbsCmnMemCtrlBankGroupSwapDdr4 token.\n* `disabled` - Value - disabled for configuring CbsCmnMemCtrlBankGroupSwapDdr4 token.\n* `enabled` - Value - enabled for configuring CbsCmnMemCtrlBankGroupSwapDdr4 token.

```yaml
Type: BiosPolicy.CbsCmnMemCtrlBankGroupSwapDdr4Enum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -CbsCmnMemMapBankInterleaveDdr4
BIOS Token for setting Chipset Interleave configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring CbsCmnMemMapBankInterleaveDdr4 token.\n* `disabled` - Value - disabled for configuring CbsCmnMemMapBankInterleaveDdr4 token.

```yaml
Type: BiosPolicy.CbsCmnMemMapBankInterleaveDdr4Enum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -CbsCmncTdpCtl
BIOS Token for setting cTDP Control configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring CbsCmncTdpCtl token.\n* `Manual` - Value - Manual for configuring CbsCmncTdpCtl token.

```yaml
Type: BiosPolicy.CbsCmncTdpCtlEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -CbsCpuCcdCtrlSsp
BIOS Token for setting CCD Control configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `2 CCDs` - Value - 2 CCDs for configuring CbsCpuCcdCtrlSsp token.\n* `3 CCDs` - Value - 3 CCDs for configuring CbsCpuCcdCtrlSsp token.\n* `4 CCDs` - Value - 4 CCDs for configuring CbsCpuCcdCtrlSsp token.\n* `6 CCDs` - Value - 6 CCDs for configuring CbsCpuCcdCtrlSsp token.\n* `Auto` - Value - Auto for configuring CbsCpuCcdCtrlSsp token.

```yaml
Type: BiosPolicy.CbsCpuCcdCtrlSspEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -CbsCpuCoreCtrl
BIOS Token for setting CPU Downcore control configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring CbsCpuCoreCtrl token.\n* `FIVE (5 + 0)` - Value - FIVE (5 + 0) for configuring CbsCpuCoreCtrl token.\n* `FOUR (4 + 0)` - Value - FOUR (4 + 0) for configuring CbsCpuCoreCtrl token.\n* `ONE (1 + 0)` - Value - ONE (1 + 0) for configuring CbsCpuCoreCtrl token.\n* `SEVEN (7 + 0)` - Value - SEVEN (7 + 0) for configuring CbsCpuCoreCtrl token.\n* `SIX (6 + 0)` - Value - SIX (6 + 0) for configuring CbsCpuCoreCtrl token.\n* `THREE (3 + 0)` - Value - THREE (3 + 0) for configuring CbsCpuCoreCtrl token.\n* `TWO (2 + 0)` - Value - TWO (2 + 0) for configuring CbsCpuCoreCtrl token.

```yaml
Type: BiosPolicy.CbsCpuCoreCtrlEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -CbsCpuSmtCtrl
BIOS Token for setting CPU SMT Mode configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring CbsCpuSmtCtrl token.\n* `disabled` - Value - disabled for configuring CbsCpuSmtCtrl token.\n* `enabled` - Value - enabled for configuring CbsCpuSmtCtrl token.

```yaml
Type: BiosPolicy.CbsCpuSmtCtrlEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -CbsDbgCpuSnpMemCover
BIOS Token for setting SNP Memory Coverage configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring CbsDbgCpuSnpMemCover token.\n* `Custom` - Value - Custom for configuring CbsDbgCpuSnpMemCover token.\n* `disabled` - Value - disabled for configuring CbsDbgCpuSnpMemCover token.\n* `enabled` - Value - enabled for configuring CbsDbgCpuSnpMemCover token.

```yaml
Type: BiosPolicy.CbsDbgCpuSnpMemCoverEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -CbsDbgCpuSnpMemSizeCover
BIOS Token for setting SNP Memory Size to Cover in MiB configuration (0 - 1048576 MiB).

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -CbsDfCmnAcpiSratL3numa
BIOS Token for setting ACPI SRAT L3 Cache As NUMA Domain configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring CbsDfCmnAcpiSratL3numa token.\n* `disabled` - Value - disabled for configuring CbsDfCmnAcpiSratL3numa token.\n* `enabled` - Value - enabled for configuring CbsDfCmnAcpiSratL3numa token.

```yaml
Type: BiosPolicy.CbsDfCmnAcpiSratL3numaEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -CbsDfCmnDramNps
BIOS Token for setting NUMA Nodes per Socket configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring CbsDfCmnDramNps token.\n* `NPS0` - Value - NPS0 for configuring CbsDfCmnDramNps token.\n* `NPS1` - Value - NPS1 for configuring CbsDfCmnDramNps token.\n* `NPS2` - Value - NPS2 for configuring CbsDfCmnDramNps token.\n* `NPS4` - Value - NPS4 for configuring CbsDfCmnDramNps token.

```yaml
Type: BiosPolicy.CbsDfCmnDramNpsEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -CbsDfCmnMemIntlv
BIOS Token for setting AMD Memory Interleaving configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring CbsDfCmnMemIntlv token.\n* `Channel` - Value - Channel for configuring CbsDfCmnMemIntlv token.\n* `Die` - Value - Die for configuring CbsDfCmnMemIntlv token.\n* `None` - Value - None for configuring CbsDfCmnMemIntlv token.\n* `Socket` - Value - Socket for configuring CbsDfCmnMemIntlv token.

```yaml
Type: BiosPolicy.CbsDfCmnMemIntlvEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -CbsDfCmnMemIntlvSize
BIOS Token for setting AMD Memory Interleaving Size configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `256 Bytes` - Value - 256 Bytes for configuring CbsDfCmnMemIntlvSize token.\n* `512 Bytes` - Value - 512 Bytes for configuring CbsDfCmnMemIntlvSize token.\n* `1 KB` - Value - 1 KiB for configuring CbsDfCmnMemIntlvSize token.\n* `2 KB` - Value - 2 KiB for configuring CbsDfCmnMemIntlvSize token.\n* `4 KB` - Value - 4 KiB for configuring CbsDfCmnMemIntlvSize token.\n* `Auto` - Value - Auto for configuring CbsDfCmnMemIntlvSize token.

```yaml
Type: BiosPolicy.CbsDfCmnMemIntlvSizeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -CbsSevSnpSupport
BIOS Token for setting SEV-SNP Support configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.CbsSevSnpSupportEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -CdnEnable
BIOS Token for setting Consistent Device Naming configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.CdnEnableEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -CdnSupport
BIOS Token for setting CDN Support for LOM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `disabled` - Value - disabled for configuring CdnSupport token.\n* `enabled` - Value - enabled for configuring CdnSupport token.\n* `LOMs Only` - Value - LOMs Only for configuring CdnSupport token.

```yaml
Type: BiosPolicy.CdnSupportEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ChannelInterLeave
BIOS Token for setting Channel Interleaving configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `1-way` - Value - 1-way for configuring ChannelInterLeave token.\n* `2-way` - Value - 2-way for configuring ChannelInterLeave token.\n* `3-way` - Value - 3-way for configuring ChannelInterLeave token.\n* `4-way` - Value - 4-way for configuring ChannelInterLeave token.\n* `auto` - Value - auto for configuring ChannelInterLeave token.

```yaml
Type: BiosPolicy.ChannelInterLeaveEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -CiscoAdaptiveMemTraining
BIOS Token for setting Adaptive Memory Training configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.CiscoAdaptiveMemTrainingEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -CiscoDebugLevel
BIOS Token for setting BIOS Techlog Level configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Maximum` - Value - Maximum for configuring CiscoDebugLevel token.\n* `Minimum` - Value - Minimum for configuring CiscoDebugLevel token.\n* `Normal` - Value - Normal for configuring CiscoDebugLevel token.

```yaml
Type: BiosPolicy.CiscoDebugLevelEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -CiscoOpromLaunchOptimization
BIOS Token for setting OptionROM Launch Optimization configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.CiscoOpromLaunchOptimizationEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -CiscoXgmiMaxSpeed
BIOS Token for setting Cisco xGMI Max Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.CiscoXgmiMaxSpeedEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -CkeLowPolicy
BIOS Token for setting CKE Low Policy configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `auto` - Value - auto for configuring CkeLowPolicy token.\n* `disabled` - Value - disabled for configuring CkeLowPolicy token.\n* `fast` - Value - fast for configuring CkeLowPolicy token.\n* `slow` - Value - slow for configuring CkeLowPolicy token.

```yaml
Type: BiosPolicy.CkeLowPolicyEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ClosedLoopThermThrotl
BIOS Token for setting Closed Loop Thermal Throttling configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.ClosedLoopThermThrotlEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -CmciEnable
BIOS Token for setting Processor CMCI configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.CmciEnableEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ConfigTdp
BIOS Token for setting Config TDP configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.ConfigTdpEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ConfigTdpLevel
BIOS Token for setting Configurable TDP Level configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Level 1` - Value - Level 1 for configuring ConfigTdpLevel token.\n* `Level 2` - Value - Level 2 for configuring ConfigTdpLevel token.\n* `Normal` - Value - Normal for configuring ConfigTdpLevel token.

```yaml
Type: BiosPolicy.ConfigTdpLevelEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ConsoleRedirection
BIOS Token for setting Console Redirection configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `com-0` - Value - com-0 for configuring ConsoleRedirection token.\n* `com-1` - Value - com-1 for configuring ConsoleRedirection token.\n* `disabled` - Value - disabled for configuring ConsoleRedirection token.\n* `enabled` - Value - enabled for configuring ConsoleRedirection token.\n* `serial-port-a` - Value - serial-port-a for configuring ConsoleRedirection token.

```yaml
Type: BiosPolicy.ConsoleRedirectionEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -CoreMultiProcessing
BIOS Token for setting Core Multi Processing configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `1` - Value - 1 for configuring CoreMultiProcessing token.\n* `2` - Value - 2 for configuring CoreMultiProcessing token.\n* `3` - Value - 3 for configuring CoreMultiProcessing token.\n* `4` - Value - 4 for configuring CoreMultiProcessing token.\n* `5` - Value - 5 for configuring CoreMultiProcessing token.\n* `6` - Value - 6 for configuring CoreMultiProcessing token.\n* `7` - Value - 7 for configuring CoreMultiProcessing token.\n* `8` - Value - 8 for configuring CoreMultiProcessing token.\n* `9` - Value - 9 for configuring CoreMultiProcessing token.\n* `10` - Value - 10 for configuring CoreMultiProcessing token.\n* `11` - Value - 11 for configuring CoreMultiProcessing token.\n* `12` - Value - 12 for configuring CoreMultiProcessing token.\n* `13` - Value - 13 for configuring CoreMultiProcessing token.\n* `14` - Value - 14 for configuring CoreMultiProcessing token.\n* `15` - Value - 15 for configuring CoreMultiProcessing token.\n* `16` - Value - 16 for configuring CoreMultiProcessing token.\n* `17` - Value - 17 for configuring CoreMultiProcessing token.\n* `18` - Value - 18 for configuring CoreMultiProcessing token.\n* `19` - Value - 19 for configuring CoreMultiProcessing token.\n* `20` - Value - 20 for configuring CoreMultiProcessing token.\n* `21` - Value - 21 for configuring CoreMultiProcessing token.\n* `22` - Value - 22 for configuring CoreMultiProcessing token.\n* `23` - Value - 23 for configuring CoreMultiProcessing token.\n* `24` - Value - 24 for configuring CoreMultiProcessing token.\n* `25` - Value - 25 for configuring CoreMultiProcessing token.\n* `26` - Value - 26 for configuring CoreMultiProcessing token.\n* `27` - Value - 27 for configuring CoreMultiProcessing token.\n* `28` - Value - 28 for configuring CoreMultiProcessing token.\n* `29` - Value - 29 for configuring CoreMultiProcessing token.\n* `30` - Value - 30 for configuring CoreMultiProcessing token.\n* `31` - Value - 31 for configuring CoreMultiProcessing token.\n* `32` - Value - 32 for configuring CoreMultiProcessing token.\n* `33` - Value - 33 for configuring CoreMultiProcessing token.\n* `34` - Value - 34 for configuring CoreMultiProcessing token.\n* `35` - Value - 35 for configuring CoreMultiProcessing token.\n* `36` - Value - 36 for configuring CoreMultiProcessing token.\n* `37` - Value - 37 for configuring CoreMultiProcessing token.\n* `38` - Value - 38 for configuring CoreMultiProcessing token.\n* `39` - Value - 39 for configuring CoreMultiProcessing token.\n* `40` - Value - 40 for configuring CoreMultiProcessing token.\n* `41` - Value - 41 for configuring CoreMultiProcessing token.\n* `42` - Value - 42 for configuring CoreMultiProcessing token.\n* `43` - Value - 43 for configuring CoreMultiProcessing token.\n* `44` - Value - 44 for configuring CoreMultiProcessing token.\n* `45` - Value - 45 for configuring CoreMultiProcessing token.\n* `46` - Value - 46 for configuring CoreMultiProcessing token.\n* `47` - Value - 47 for configuring CoreMultiProcessing token.\n* `48` - Value - 48 for configuring CoreMultiProcessing token.\n* `all` - Value - all for configuring CoreMultiProcessing token.

```yaml
Type: BiosPolicy.CoreMultiProcessingEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -CpuEnergyPerformance
BIOS Token for setting Energy Performance configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `balanced-energy` - Value - balanced-energy for configuring CpuEnergyPerformance token.\n* `balanced-performance` - Value - balanced-performance for configuring CpuEnergyPerformance token.\n* `balanced-power` - Value - balanced-power for configuring CpuEnergyPerformance token.\n* `energy-efficient` - Value - energy-efficient for configuring CpuEnergyPerformance token.\n* `performance` - Value - performance for configuring CpuEnergyPerformance token.\n* `power` - Value - power for configuring CpuEnergyPerformance token.

```yaml
Type: BiosPolicy.CpuEnergyPerformanceEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -CpuFrequencyFloor
BIOS Token for setting Frequency Floor Override configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.CpuFrequencyFloorEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -CpuPerfEnhancement
BIOS Token for setting Enhanced CPU Performance configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring CpuPerfEnhancement token.\n* `Disabled` - Value - Disabled for configuring CpuPerfEnhancement token.

```yaml
Type: BiosPolicy.CpuPerfEnhancementEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -CpuPerformance
BIOS Token for setting CPU Performance configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `custom` - Value - custom for configuring CpuPerformance token.\n* `enterprise` - Value - enterprise for configuring CpuPerformance token.\n* `high-throughput` - Value - high-throughput for configuring CpuPerformance token.\n* `hpc` - Value - hpc for configuring CpuPerformance token.

```yaml
Type: BiosPolicy.CpuPerformanceEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -CpuPowerManagement
BIOS Token for setting Power Technology configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `custom` - Value - custom for configuring CpuPowerManagement token.\n* `disabled` - Value - disabled for configuring CpuPowerManagement token.\n* `energy-efficient` - Value - energy-efficient for configuring CpuPowerManagement token.\n* `performance` - Value - performance for configuring CpuPowerManagement token.

```yaml
Type: BiosPolicy.CpuPowerManagementEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -CrQos
BIOS Token for setting CR QoS configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Disabled` - Value - Disabled for configuring CrQos token.\n* `Mode 0 - Disable the PMem QoS Feature` - Value - Mode 0 - Disable the PMem QoS Feature for configuring CrQos token.\n* `Mode 1 - M2M QoS Enable and CHA QoS Disable` - Value - Mode 1 - M2M QoS Enable and CHA QoS Disable for configuring CrQos token.\n* `Mode 2 - M2M QoS Enable and CHA QoS Enable` - Value - Mode 2 - M2M QoS Enable and CHA QoS Enable for configuring CrQos token.\n* `Recipe 1` - Value - Recipe 1 for configuring CrQos token.\n* `Recipe 2` - Value - Recipe 2 for configuring CrQos token.\n* `Recipe 3` - Value - Recipe 3 for configuring CrQos token.

```yaml
Type: BiosPolicy.CrQosEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -CrfastgoConfig
BIOS Token for setting CR FastGo Config configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring CrfastgoConfig token.\n* `Default` - Value - Default for configuring CrfastgoConfig token.\n* `Disable optimization` - Value - Disable optimization for configuring CrfastgoConfig token.\n* `Enable optimization` - Value - Enable optimization for configuring CrfastgoConfig token.\n* `Option 1` - Value - Option 1 for configuring CrfastgoConfig token.\n* `Option 2` - Value - Option 2 for configuring CrfastgoConfig token.\n* `Option 3` - Value - Option 3 for configuring CrfastgoConfig token.\n* `Option 4` - Value - Option 4 for configuring CrfastgoConfig token.\n* `Option 5` - Value - Option 5 for configuring CrfastgoConfig token.

```yaml
Type: BiosPolicy.CrfastgoConfigEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -DcpmmFirmwareDowngrade
BIOS Token for setting DCPMM Firmware Downgrade configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.DcpmmFirmwareDowngradeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -DemandScrub
BIOS Token for setting Demand Scrub configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.DemandScrubEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Description
Description of the policy.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -DirectCacheAccess
BIOS Token for setting Direct Cache Access Support configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `auto` - Value - auto for configuring DirectCacheAccess token.\n* `disabled` - Value - disabled for configuring DirectCacheAccess token.\n* `enabled` - Value - enabled for configuring DirectCacheAccess token.

```yaml
Type: BiosPolicy.DirectCacheAccessEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -DramClockThrottling
BIOS Token for setting DRAM Clock Throttling configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring DramClockThrottling token.\n* `Balanced` - Value - Balanced for configuring DramClockThrottling token.\n* `Energy Efficient` - Value - Energy Efficient for configuring DramClockThrottling token.\n* `Performance` - Value - Performance for configuring DramClockThrottling token.

```yaml
Type: BiosPolicy.DramClockThrottlingEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -DramRefreshRate
BIOS Token for setting DRAM Refresh Rate configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `1x` - Value - 1x for configuring DramRefreshRate token.\n* `2x` - Value - 2x for configuring DramRefreshRate token.\n* `3x` - Value - 3x for configuring DramRefreshRate token.\n* `4x` - Value - 4x for configuring DramRefreshRate token.\n* `Auto` - Value - Auto for configuring DramRefreshRate token.

```yaml
Type: BiosPolicy.DramRefreshRateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -DramSwThermalThrottling
BIOS Token for setting DRAM SW Thermal Throttling configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.DramSwThermalThrottlingEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -EadrSupport
BIOS Token for setting eADR Support configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring EadrSupport token.\n* `disabled` - Value - disabled for configuring EadrSupport token.\n* `enabled` - Value - enabled for configuring EadrSupport token.

```yaml
Type: BiosPolicy.EadrSupportEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -EdpcEn
BIOS Token for setting IIO eDPC Support configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Disabled` - Value - Disabled for configuring EdpcEn token.\n* `On Fatal Error` - Value - On Fatal Error for configuring EdpcEn token.\n* `On Fatal and Non-Fatal Errors` - Value - On Fatal and Non-Fatal Errors for configuring EdpcEn token.

```yaml
Type: BiosPolicy.EdpcEnEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -EnableClockSpreadSpec
BIOS Token for setting External SSC Enable configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.EnableClockSpreadSpecEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -EnableMktme
BIOS Token for setting Multikey Total Memory Encryption  (MK-TME) configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.EnableMktmeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -EnableSgx
BIOS Token for setting Software Guard Extensions  (SGX) configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.EnableSgxEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -EnableTme
BIOS Token for setting Total Memory Encryption  (TME) configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.EnableTmeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -EnergyEfficientTurbo
BIOS Token for setting Energy Efficient Turbo configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.EnergyEfficientTurboEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -EngPerfTuning
BIOS Token for setting Energy Performance Tuning configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `BIOS` - Value - BIOS for configuring EngPerfTuning token.\n* `OS` - Value - OS for configuring EngPerfTuning token.

```yaml
Type: BiosPolicy.EngPerfTuningEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -EnhancedIntelSpeedStepTech
BIOS Token for setting Enhanced Intel Speedstep (R) Technology configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.EnhancedIntelSpeedStepTechEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -EpochUpdate
BIOS Token for setting Select Owner EPOCH Input Type configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Change to New Random Owner EPOCHs` - Value - Change to New Random Owner EPOCHs for configuring EpochUpdate token.\n* `Manual User Defined Owner EPOCHs` - Value - Manual User Defined Owner EPOCHs for configuring EpochUpdate token.\n* `SGX Owner EPOCH activated` - Value - SGX Owner EPOCH activated for configuring EpochUpdate token.

```yaml
Type: BiosPolicy.EpochUpdateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -EppEnable
BIOS Token for setting Processor EPP Enable configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.EppEnableEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -EppProfile
BIOS Token for setting EPP Profile configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Balanced Performance` - Value - Balanced Performance for configuring EppProfile token.\n* `Balanced Power` - Value - Balanced Power for configuring EppProfile token.\n* `Performance` - Value - Performance for configuring EppProfile token.\n* `Power` - Value - Power for configuring EppProfile token.

```yaml
Type: BiosPolicy.EppProfileEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ExecuteDisableBit
BIOS Token for setting Execute Disable Bit configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.ExecuteDisableBitEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ExtendedApic
BIOS Token for setting Local X2 Apic configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `disabled` - Value - disabled for configuring ExtendedApic token.\n* `enabled` - Value - enabled for configuring ExtendedApic token.\n* `X2APIC` - Value - X2APIC for configuring ExtendedApic token.\n* `XAPIC` - Value - XAPIC for configuring ExtendedApic token.

```yaml
Type: BiosPolicy.ExtendedApicEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -FlowControl
BIOS Token for setting Flow Control configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `none` - Value - none for configuring FlowControl token.\n* `rts-cts` - Value - rts-cts for configuring FlowControl token.

```yaml
Type: BiosPolicy.FlowControlEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Frb2enable
BIOS Token for setting FRB-2 Timer configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.Frb2enableEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -HardwarePrefetch
BIOS Token for setting Hardware Prefetcher configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.HardwarePrefetchEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -HwpmEnable
BIOS Token for setting CPU Hardware Power Management configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Disabled` - Value - Disabled for configuring HwpmEnable token.\n* `HWPM Native Mode` - Value - HWPM Native Mode for configuring HwpmEnable token.\n* `HWPM OOB Mode` - Value - HWPM OOB Mode for configuring HwpmEnable token.\n* `NATIVE MODE` - Value - NATIVE MODE for configuring HwpmEnable token.\n* `Native Mode with no Legacy` - Value - Native Mode with no Legacy for configuring HwpmEnable token.\n* `OOB MODE` - Value - OOB MODE for configuring HwpmEnable token.

```yaml
Type: BiosPolicy.HwpmEnableEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ImcInterleave
BIOS Token for setting IMC Interleaving configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `1-way Interleave` - Value - 1-way Interleave for configuring ImcInterleave token.\n* `2-way Interleave` - Value - 2-way Interleave for configuring ImcInterleave token.\n* `Auto` - Value - Auto for configuring ImcInterleave token.

```yaml
Type: BiosPolicy.ImcInterleaveEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -IntelDynamicSpeedSelect
BIOS Token for setting Intel Dynamic Speed Select configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.IntelDynamicSpeedSelectEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -IntelHyperThreadingTech
BIOS Token for setting Intel HyperThreading Tech configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.IntelHyperThreadingTechEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -IntelSpeedSelect
BIOS Token for setting Intel Speed Select configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Base` - Value - Base for configuring IntelSpeedSelect token.\n* `Config 1` - Value - Config 1 for configuring IntelSpeedSelect token.\n* `Config 2` - Value - Config 2 for configuring IntelSpeedSelect token.\n* `Config 3` - Value - Config 3 for configuring IntelSpeedSelect token.\n* `Config 4` - Value - Config 4 for configuring IntelSpeedSelect token.

```yaml
Type: BiosPolicy.IntelSpeedSelectEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -IntelTurboBoostTech
BIOS Token for setting Intel Turbo Boost Tech configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.IntelTurboBoostTechEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -IntelVirtualizationTechnology
BIOS Token for setting Intel (R) VT configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.IntelVirtualizationTechnologyEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -IntelVtForDirectedIo
BIOS Token for setting Intel VT for Directed IO configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.IntelVtForDirectedIoEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -IntelVtdCoherencySupport
BIOS Token for setting Intel (R) VT-d Coherency Support configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.IntelVtdCoherencySupportEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -IntelVtdInterruptRemapping
BIOS Token for setting Intel (R) VT-d Interrupt Remapping configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.IntelVtdInterruptRemappingEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -IntelVtdPassThroughDmaSupport
BIOS Token for setting Intel (R) VT-d PassThrough DMA Support configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.IntelVtdPassThroughDmaSupportEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -IntelVtdatsSupport
BIOS Token for setting Intel VTD ATS Support configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.IntelVtdatsSupportEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -IohErrorEnable
BIOS Token for setting IIO Error Enable configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `No` - Value - No for configuring IohErrorEnable token.\n* `Yes` - Value - Yes for configuring IohErrorEnable token.

```yaml
Type: BiosPolicy.IohErrorEnableEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -IohResource
BIOS Token for setting IOH Resource Allocation configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `IOH0 24k IOH1 40k` - Value - IOH0 24k IOH1 40k for configuring IohResource token.\n* `IOH0 32k IOH1 32k` - Value - IOH0 32k IOH1 32k for configuring IohResource token.\n* `IOH0 40k IOH1 24k` - Value - IOH0 40k IOH1 24k for configuring IohResource token.\n* `IOH0 48k IOH1 16k` - Value - IOH0 48k IOH1 16k for configuring IohResource token.\n* `IOH0 56k IOH1 8k` - Value - IOH0 56k IOH1 8k for configuring IohResource token.

```yaml
Type: BiosPolicy.IohResourceEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -IpPrefetch
BIOS Token for setting DCU IP Prefetcher configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.IpPrefetchEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Ipv4http
BIOS Token for setting IPV4 HTTP Support configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.Ipv4httpEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Ipv4pxe
BIOS Token for setting IPv4 PXE Support configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.Ipv4pxeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Ipv6http
BIOS Token for setting IPV6 HTTP Support configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.Ipv6httpEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Ipv6pxe
BIOS Token for setting IPV6 PXE Support configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.Ipv6pxeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -KtiPrefetch
BIOS Token for setting KTI Prefetch configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring KtiPrefetch token.\n* `disabled` - Value - disabled for configuring KtiPrefetch token.\n* `enabled` - Value - enabled for configuring KtiPrefetch token.

```yaml
Type: BiosPolicy.KtiPrefetchEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -LegacyOsRedirection
BIOS Token for setting Legacy OS Redirection configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.LegacyOsRedirectionEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -LegacyUsbSupport
BIOS Token for setting Legacy USB Support configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `auto` - Value - auto for configuring LegacyUsbSupport token.\n* `disabled` - Value - disabled for configuring LegacyUsbSupport token.\n* `enabled` - Value - enabled for configuring LegacyUsbSupport token.

```yaml
Type: BiosPolicy.LegacyUsbSupportEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -LlcAlloc
BIOS Token for setting LLC Dead Line configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring LlcAlloc token.\n* `disabled` - Value - disabled for configuring LlcAlloc token.\n* `enabled` - Value - enabled for configuring LlcAlloc token.

```yaml
Type: BiosPolicy.LlcAllocEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -LlcPrefetch
BIOS Token for setting LLC Prefetch configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.LlcPrefetchEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -LomPort0state
BIOS Token for setting LOM Port 0 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `disabled` - Value - disabled for configuring LomPort0state token.\n* `enabled` - Value - enabled for configuring LomPort0state token.\n* `Legacy Only` - Value - Legacy Only for configuring LomPort0state token.\n* `UEFI Only` - Value - UEFI Only for configuring LomPort0state token.

```yaml
Type: BiosPolicy.LomPort0stateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -LomPort1state
BIOS Token for setting LOM Port 1 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `disabled` - Value - disabled for configuring LomPort1state token.\n* `enabled` - Value - enabled for configuring LomPort1state token.\n* `Legacy Only` - Value - Legacy Only for configuring LomPort1state token.\n* `UEFI Only` - Value - UEFI Only for configuring LomPort1state token.

```yaml
Type: BiosPolicy.LomPort1stateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -LomPort2state
BIOS Token for setting LOM Port 2 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `disabled` - Value - disabled for configuring LomPort2state token.\n* `enabled` - Value - enabled for configuring LomPort2state token.\n* `Legacy Only` - Value - Legacy Only for configuring LomPort2state token.\n* `UEFI Only` - Value - UEFI Only for configuring LomPort2state token.

```yaml
Type: BiosPolicy.LomPort2stateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -LomPort3state
BIOS Token for setting LOM Port 3 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `disabled` - Value - disabled for configuring LomPort3state token.\n* `enabled` - Value - enabled for configuring LomPort3state token.\n* `Legacy Only` - Value - Legacy Only for configuring LomPort3state token.\n* `UEFI Only` - Value - UEFI Only for configuring LomPort3state token.

```yaml
Type: BiosPolicy.LomPort3stateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -LomPortsAllState
BIOS Token for setting All Onboard LOM Ports configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.LomPortsAllStateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -LvDdrMode
BIOS Token for setting Low Voltage DDR Mode configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `auto` - Value - auto for configuring LvDdrMode token.\n* `performance-mode` - Value - performance-mode for configuring LvDdrMode token.\n* `power-saving-mode` - Value - power-saving-mode for configuring LvDdrMode token.

```yaml
Type: BiosPolicy.LvDdrModeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -MakeDeviceNonBootable
BIOS Token for setting Make Device Non Bootable configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.MakeDeviceNonBootableEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -MemoryBandwidthBoost
BIOS Token for setting Memory Bandwidth Boost configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.MemoryBandwidthBoostEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -MemoryInterLeave
BIOS Token for setting Intel Memory Interleaving configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `1 Way Node Interleave` - Value - 1 Way Node Interleave for configuring MemoryInterLeave token.\n* `2 Way Node Interleave` - Value - 2 Way Node Interleave for configuring MemoryInterLeave token.\n* `4 Way Node Interleave` - Value - 4 Way Node Interleave for configuring MemoryInterLeave token.\n* `8 Way Node Interleave` - Value - 8 Way Node Interleave for configuring MemoryInterLeave token.\n* `disabled` - Value - disabled for configuring MemoryInterLeave token.\n* `enabled` - Value - enabled for configuring MemoryInterLeave token.

```yaml
Type: BiosPolicy.MemoryInterLeaveEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -MemoryMappedIoAbove4gb
BIOS Token for setting Memory Mapped IO above 4GiB configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.MemoryMappedIoAbove4gbEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -MemoryRefreshRate
BIOS Token for setting Memory Refresh Rate configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `1x Refresh` - Value - 1x Refresh for configuring MemoryRefreshRate token.\n* `2x Refresh` - Value - 2x Refresh for configuring MemoryRefreshRate token.

```yaml
Type: BiosPolicy.MemoryRefreshRateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -MemorySizeLimit
BIOS Token for setting Memory Size Limit in GiB configuration (0 - 65535 GiB).

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -MemoryThermalThrottling
BIOS Token for setting Memory Thermal Throttling Mode configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `CLTT with PECI` - Value - CLTT with PECI for configuring MemoryThermalThrottling token.\n* `Disabled` - Value - Disabled for configuring MemoryThermalThrottling token.

```yaml
Type: BiosPolicy.MemoryThermalThrottlingEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -MirroringMode
BIOS Token for setting Mirroring Mode configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `inter-socket` - Value - inter-socket for configuring MirroringMode token.\n* `intra-socket` - Value - intra-socket for configuring MirroringMode token.

```yaml
Type: BiosPolicy.MirroringModeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -MmcfgBase
BIOS Token for setting MMCFG BASE configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `1 GB` - Value - 1 GiB for configuring MmcfgBase token.\n* `2 GB` - Value - 2 GiB for configuring MmcfgBase token.\n* `2.5 GB` - Value - 2.5 GiB for configuring MmcfgBase token.\n* `3 GB` - Value - 3 GiB for configuring MmcfgBase token.\n* `Auto` - Value - Auto for configuring MmcfgBase token.

```yaml
Type: BiosPolicy.MmcfgBaseEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Moid
The unique identifier of this Managed Object instance.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: true
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Name
Name of the concrete policy.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -NetworkStack
BIOS Token for setting Network Stack configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.NetworkStackEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -NumaOptimized
BIOS Token for setting NUMA Optimized configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.NumaOptimizedEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -NvmdimmPerformConfig
BIOS Token for setting NVM Performance Setting configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `BW Optimized` - Value - BW Optimized for configuring NvmdimmPerformConfig token.\n* `Balanced Profile` - Value - Balanced Profile for configuring NvmdimmPerformConfig token.\n* `Latency Optimized` - Value - Latency Optimized for configuring NvmdimmPerformConfig token.

```yaml
Type: BiosPolicy.NvmdimmPerformConfigEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Onboard10gbitLom
BIOS Token for setting Onboard 10Gbit LOM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.Onboard10gbitLomEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -OnboardGbitLom
BIOS Token for setting Onboard Gbit LOM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.OnboardGbitLomEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -OnboardScuStorageSupport
BIOS Token for setting Onboard SCU Storage Support configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.OnboardScuStorageSupportEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -OnboardScuStorageSwStack
BIOS Token for setting Onboard SCU Storage SW Stack configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Intel RSTe` - Value - Intel RSTe for configuring OnboardScuStorageSwStack token.\n* `LSI SW RAID` - Value - LSI SW RAID for configuring OnboardScuStorageSwStack token.

```yaml
Type: BiosPolicy.OnboardScuStorageSwStackEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -OperationMode
BIOS Token for setting Operation Mode configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Test Only` - Value - Test Only for configuring OperationMode token.\n* `Test and Repair` - Value - Test and Repair for configuring OperationMode token.

```yaml
Type: BiosPolicy.OperationModeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Organization
A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: OrganizationOrganizationRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -OsBootWatchdogTimer
BIOS Token for setting OS Boot Watchdog Timer configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.OsBootWatchdogTimerEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -OsBootWatchdogTimerPolicy
BIOS Token for setting OS Boot Watchdog Timer Policy configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `do-nothing` - Value - do-nothing for configuring OsBootWatchdogTimerPolicy token.\n* `power-off` - Value - power-off for configuring OsBootWatchdogTimerPolicy token.\n* `reset` - Value - reset for configuring OsBootWatchdogTimerPolicy token.

```yaml
Type: BiosPolicy.OsBootWatchdogTimerPolicyEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -OsBootWatchdogTimerTimeout
BIOS Token for setting OS Boot Watchdog Timer Timeout configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `5-minutes` - Value - 5-minutes for configuring OsBootWatchdogTimerTimeout token.\n* `10-minutes` - Value - 10-minutes for configuring OsBootWatchdogTimerTimeout token.\n* `15-minutes` - Value - 15-minutes for configuring OsBootWatchdogTimerTimeout token.\n* `20-minutes` - Value - 20-minutes for configuring OsBootWatchdogTimerTimeout token.

```yaml
Type: BiosPolicy.OsBootWatchdogTimerTimeoutEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -OutOfBandMgmtPort
BIOS Token for setting Out-of-Band Mgmt Port configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.OutOfBandMgmtPortEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PackageCstateLimit
BIOS Token for setting Package C State Limit configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring PackageCstateLimit token.\n* `C0 C1 State` - Value - C0 C1 State for configuring PackageCstateLimit token.\n* `C0/C1` - Value - C0/C1 for configuring PackageCstateLimit token.\n* `C2` - Value - C2 for configuring PackageCstateLimit token.\n* `C6 Non Retention` - Value - C6 Non Retention for configuring PackageCstateLimit token.\n* `C6 Retention` - Value - C6 Retention for configuring PackageCstateLimit token.\n* `No Limit` - Value - No Limit for configuring PackageCstateLimit token.

```yaml
Type: BiosPolicy.PackageCstateLimitEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PanicHighWatermark
BIOS Token for setting Panic and High Watermark configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `High` - Value - High for configuring PanicHighWatermark token.\n* `Low` - Value - Low for configuring PanicHighWatermark token.

```yaml
Type: BiosPolicy.PanicHighWatermarkEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PartialCacheLineSparing
BIOS Token for setting Partial Cache Line Sparing configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.PartialCacheLineSparingEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PartialMirrorModeConfig
BIOS Token for setting Partial Memory Mirror Mode configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `disabled` - Value - disabled for configuring PartialMirrorModeConfig token.\n* `Percentage` - Value - Percentage for configuring PartialMirrorModeConfig token.\n* `Value in GB` - Value - Value in GiB for configuring PartialMirrorModeConfig token.

```yaml
Type: BiosPolicy.PartialMirrorModeConfigEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PartialMirrorPercent
BIOS Token for setting Partial Mirror Percentage configuration (0.00 - 50.00 Percentage).

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PartialMirrorValue1
BIOS Token for setting Partial Mirror1 Size in GiB configuration (0 - 65535 GiB).

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PartialMirrorValue2
BIOS Token for setting Partial Mirror2 Size in GiB configuration (0 - 65535 GiB).

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PartialMirrorValue3
BIOS Token for setting Partial Mirror3 Size in GiB configuration (0 - 65535 GiB).

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PartialMirrorValue4
BIOS Token for setting Partial Mirror4 Size in GiB configuration (0 - 65535 GiB).

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PatrolScrub
BIOS Token for setting Patrol Scrub configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `disabled` - Value - disabled for configuring PatrolScrub token.\n* `Enable at End of POST` - Value - Enable at End of POST for configuring PatrolScrub token.\n* `enabled` - Value - enabled for configuring PatrolScrub token.

```yaml
Type: BiosPolicy.PatrolScrubEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PatrolScrubDuration
BIOS Token for setting Patrol Scrub Interval configuration (5 - 23 Hour).

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PcIeRasSupport
BIOS Token for setting PCIe RAS Support configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.PcIeRasSupportEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PcIeSsdHotPlugSupport
BIOS Token for setting NVMe SSD Hot-Plug Support configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.PcIeSsdHotPlugSupportEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PchUsb30mode
BIOS Token for setting xHCI Mode configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.PchUsb30modeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PciOptionRoMs
BIOS Token for setting All PCIe Slots OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `disabled` - Value - disabled for configuring PciOptionRoMs token.\n* `enabled` - Value - enabled for configuring PciOptionRoMs token.\n* `Legacy Only` - Value - Legacy Only for configuring PciOptionRoMs token.\n* `UEFI Only` - Value - UEFI Only for configuring PciOptionRoMs token.

```yaml
Type: BiosPolicy.PciOptionRoMsEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PciRomClp
BIOS Token for setting PCI ROM CLP configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.PciRomClpEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PcieAriSupport
BIOS Token for setting PCIe ARI Support configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring PcieAriSupport token.\n* `disabled` - Value - disabled for configuring PcieAriSupport token.\n* `enabled` - Value - enabled for configuring PcieAriSupport token.

```yaml
Type: BiosPolicy.PcieAriSupportEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PciePllSsc
BIOS Token for setting PCIe PLL SSC configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring PciePllSsc token.\n* `Disabled` - Value - Disabled for configuring PciePllSsc token.\n* `ZeroPointFive` - Value - ZeroPointFive for configuring PciePllSsc token.

```yaml
Type: BiosPolicy.PciePllSscEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PcieSlotMraid1linkSpeed
BIOS Token for setting MRAID1 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring PcieSlotMraid1linkSpeed token.\n* `Disabled` - Value - Disabled for configuring PcieSlotMraid1linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring PcieSlotMraid1linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring PcieSlotMraid1linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring PcieSlotMraid1linkSpeed token.\n* `GEN4` - Value - GEN4 for configuring PcieSlotMraid1linkSpeed token.

```yaml
Type: BiosPolicy.PcieSlotMraid1linkSpeedEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PcieSlotMraid1optionRom
BIOS Token for setting MRAID1 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.PcieSlotMraid1optionRomEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PcieSlotMraid2linkSpeed
BIOS Token for setting MRAID2 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring PcieSlotMraid2linkSpeed token.\n* `Disabled` - Value - Disabled for configuring PcieSlotMraid2linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring PcieSlotMraid2linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring PcieSlotMraid2linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring PcieSlotMraid2linkSpeed token.\n* `GEN4` - Value - GEN4 for configuring PcieSlotMraid2linkSpeed token.

```yaml
Type: BiosPolicy.PcieSlotMraid2linkSpeedEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PcieSlotMraid2optionRom
BIOS Token for setting MRAID2 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.PcieSlotMraid2optionRomEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PcieSlotMstorraidLinkSpeed
BIOS Token for setting PCIe Slot MSTOR Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring PcieSlotMstorraidLinkSpeed token.\n* `Disabled` - Value - Disabled for configuring PcieSlotMstorraidLinkSpeed token.\n* `GEN1` - Value - GEN1 for configuring PcieSlotMstorraidLinkSpeed token.\n* `GEN2` - Value - GEN2 for configuring PcieSlotMstorraidLinkSpeed token.\n* `GEN3` - Value - GEN3 for configuring PcieSlotMstorraidLinkSpeed token.\n* `GEN4` - Value - GEN4 for configuring PcieSlotMstorraidLinkSpeed token.

```yaml
Type: BiosPolicy.PcieSlotMstorraidLinkSpeedEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PcieSlotMstorraidOptionRom
BIOS Token for setting PCIe Slot MSTOR RAID OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.PcieSlotMstorraidOptionRomEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PcieSlotNvme1linkSpeed
BIOS Token for setting NVME 1 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring PcieSlotNvme1linkSpeed token.\n* `Disabled` - Value - Disabled for configuring PcieSlotNvme1linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring PcieSlotNvme1linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring PcieSlotNvme1linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring PcieSlotNvme1linkSpeed token.

```yaml
Type: BiosPolicy.PcieSlotNvme1linkSpeedEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PcieSlotNvme1optionRom
BIOS Token for setting NVME 1 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.PcieSlotNvme1optionRomEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PcieSlotNvme2linkSpeed
BIOS Token for setting NVME 2 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring PcieSlotNvme2linkSpeed token.\n* `Disabled` - Value - Disabled for configuring PcieSlotNvme2linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring PcieSlotNvme2linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring PcieSlotNvme2linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring PcieSlotNvme2linkSpeed token.

```yaml
Type: BiosPolicy.PcieSlotNvme2linkSpeedEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PcieSlotNvme2optionRom
BIOS Token for setting NVME 2 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.PcieSlotNvme2optionRomEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PcieSlotNvme3linkSpeed
BIOS Token for setting NVME 3 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring PcieSlotNvme3linkSpeed token.\n* `Disabled` - Value - Disabled for configuring PcieSlotNvme3linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring PcieSlotNvme3linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring PcieSlotNvme3linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring PcieSlotNvme3linkSpeed token.

```yaml
Type: BiosPolicy.PcieSlotNvme3linkSpeedEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PcieSlotNvme3optionRom
BIOS Token for setting NVME 3 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.PcieSlotNvme3optionRomEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PcieSlotNvme4linkSpeed
BIOS Token for setting NVME 4 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring PcieSlotNvme4linkSpeed token.\n* `Disabled` - Value - Disabled for configuring PcieSlotNvme4linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring PcieSlotNvme4linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring PcieSlotNvme4linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring PcieSlotNvme4linkSpeed token.

```yaml
Type: BiosPolicy.PcieSlotNvme4linkSpeedEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PcieSlotNvme4optionRom
BIOS Token for setting NVME 4 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.PcieSlotNvme4optionRomEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PcieSlotNvme5linkSpeed
BIOS Token for setting NVME 5 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring PcieSlotNvme5linkSpeed token.\n* `Disabled` - Value - Disabled for configuring PcieSlotNvme5linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring PcieSlotNvme5linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring PcieSlotNvme5linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring PcieSlotNvme5linkSpeed token.

```yaml
Type: BiosPolicy.PcieSlotNvme5linkSpeedEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PcieSlotNvme5optionRom
BIOS Token for setting NVME 5 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.PcieSlotNvme5optionRomEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PcieSlotNvme6linkSpeed
BIOS Token for setting NVME 6 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring PcieSlotNvme6linkSpeed token.\n* `Disabled` - Value - Disabled for configuring PcieSlotNvme6linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring PcieSlotNvme6linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring PcieSlotNvme6linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring PcieSlotNvme6linkSpeed token.

```yaml
Type: BiosPolicy.PcieSlotNvme6linkSpeedEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PcieSlotNvme6optionRom
BIOS Token for setting NVME 6 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.PcieSlotNvme6optionRomEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PcieSlotsCdnEnable
BIOS Token for setting PCIe Slots CDN Control configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.PcieSlotsCdnEnableEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PopSupport
BIOS Token for setting Power ON Password configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.PopSupportEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PostErrorPause
BIOS Token for setting POST Error Pause configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.PostErrorPauseEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PostPackageRepair
BIOS Token for setting Post Package Repair configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Disabled` - Value - Disabled for configuring PostPackageRepair token.\n* `Hard PPR` - Value - Hard PPR for configuring PostPackageRepair token.

```yaml
Type: BiosPolicy.PostPackageRepairEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ProcessorC1e
BIOS Token for setting Processor C1E configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.ProcessorC1eEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ProcessorC3report
BIOS Token for setting Processor C3 Report configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.ProcessorC3reportEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ProcessorC6report
BIOS Token for setting Processor C6 Report configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.ProcessorC6reportEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ProcessorCstate
BIOS Token for setting CPU C State configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.ProcessorCstateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Profiles
An array of relationships to policyAbstractConfigProfile resources.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: System.Collections.Generic.List`1[PolicyAbstractConfigProfileRelationship]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Psata
BIOS Token for setting P-SATA Mode configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `AHCI` - Value - AHCI for configuring Psata token.\n* `Disabled` - Value - Disabled for configuring Psata token.\n* `LSI SW RAID` - Value - LSI SW RAID for configuring Psata token.

```yaml
Type: BiosPolicy.PsataEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PstateCoordType
BIOS Token for setting P-STATE Coordination configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `HW ALL` - Value - HW ALL for configuring PstateCoordType token.\n* `SW ALL` - Value - SW ALL for configuring PstateCoordType token.\n* `SW ANY` - Value - SW ANY for configuring PstateCoordType token.

```yaml
Type: BiosPolicy.PstateCoordTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PuttyKeyPad
BIOS Token for setting Putty KeyPad configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `ESCN` - Value - ESCN for configuring PuttyKeyPad token.\n* `LINUX` - Value - LINUX for configuring PuttyKeyPad token.\n* `SCO` - Value - SCO for configuring PuttyKeyPad token.\n* `VT100` - Value - VT100 for configuring PuttyKeyPad token.\n* `VT400` - Value - VT400 for configuring PuttyKeyPad token.\n* `XTERMR6` - Value - XTERMR6 for configuring PuttyKeyPad token.

```yaml
Type: BiosPolicy.PuttyKeyPadEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PwrPerfTuning
BIOS Token for setting Power Performance Tuning configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `bios` - Value - BIOS for configuring PwrPerfTuning token.\n* `os` - Value - os for configuring PwrPerfTuning token.\n* `peci` - Value - peci for configuring PwrPerfTuning token.

```yaml
Type: BiosPolicy.PwrPerfTuningEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -QpiLinkFrequency
BIOS Token for setting QPI Link Frequency Select configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `6.4-gt/s` - Value - 6.4-gt/s for configuring QpiLinkFrequency token.\n* `7.2-gt/s` - Value - 7.2-gt/s for configuring QpiLinkFrequency token.\n* `8.0-gt/s` - Value - 8.0-gt/s for configuring QpiLinkFrequency token.\n* `9.6-gt/s` - Value - 9.6-gt/s for configuring QpiLinkFrequency token.\n* `auto` - Value - auto for configuring QpiLinkFrequency token.

```yaml
Type: BiosPolicy.QpiLinkFrequencyEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -QpiLinkSpeed
BIOS Token for setting UPI Link Frequency Select configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `10.4GT/s` - Value - 10.4GT/s for configuring QpiLinkSpeed token.\n* `11.2GT/s` - Value - 11.2GT/s for configuring QpiLinkSpeed token.\n* `9.6GT/s` - Value - 9.6GT/s for configuring QpiLinkSpeed token.\n* `Auto` - Value - Auto for configuring QpiLinkSpeed token.

```yaml
Type: BiosPolicy.QpiLinkSpeedEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -QpiSnoopMode
BIOS Token for setting QPI Snoop Mode configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `auto` - Value - auto for configuring QpiSnoopMode token.\n* `cluster-on-die` - Value - cluster-on-die for configuring QpiSnoopMode token.\n* `early-snoop` - Value - early-snoop for configuring QpiSnoopMode token.\n* `home-directory-snoop` - Value - home-directory-snoop for configuring QpiSnoopMode token.\n* `home-directory-snoop-with-osb` - Value - home-directory-snoop-with-osb for configuring QpiSnoopMode token.\n* `home-snoop` - Value - home-snoop for configuring QpiSnoopMode token.

```yaml
Type: BiosPolicy.QpiSnoopModeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -RankInterLeave
BIOS Token for setting Rank Interleaving configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `1-way` - Value - 1-way for configuring RankInterLeave token.\n* `2-way` - Value - 2-way for configuring RankInterLeave token.\n* `4-way` - Value - 4-way for configuring RankInterLeave token.\n* `8-way` - Value - 8-way for configuring RankInterLeave token.\n* `auto` - Value - auto for configuring RankInterLeave token.

```yaml
Type: BiosPolicy.RankInterLeaveEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -RedirectionAfterPost
BIOS Token for setting Redirection After BIOS POST configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Always Enable` - Value - Always Enable for configuring RedirectionAfterPost token.\n* `Bootloader` - Value - Bootloader for configuring RedirectionAfterPost token.

```yaml
Type: BiosPolicy.RedirectionAfterPostEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SataModeSelect
BIOS Token for setting SATA Mode configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `AHCI` - Value - AHCI for configuring SataModeSelect token.\n* `Disabled` - Value - Disabled for configuring SataModeSelect token.\n* `LSI SW RAID` - Value - LSI SW RAID for configuring SataModeSelect token.

```yaml
Type: BiosPolicy.SataModeSelectEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SelectMemoryRasConfiguration
BIOS Token for setting Memory RAS Configuration configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `adddc-sparing` - Value - adddc-sparing for configuring SelectMemoryRasConfiguration token.\n* `lockstep` - Value - lockstep for configuring SelectMemoryRasConfiguration token.\n* `maximum-performance` - Value - maximum-performance for configuring SelectMemoryRasConfiguration token.\n* `mirror-mode-1lm` - Value - mirror-mode-1lm for configuring SelectMemoryRasConfiguration token.\n* `mirroring` - Value - mirroring for configuring SelectMemoryRasConfiguration token.\n* `partial-mirror-mode-1lm` - Value - partial-mirror-mode-1lm for configuring SelectMemoryRasConfiguration token.\n* `sparing` - Value - sparing for configuring SelectMemoryRasConfiguration token.

```yaml
Type: BiosPolicy.SelectMemoryRasConfigurationEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SelectPprType
BIOS Token for setting PPR Type configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `disabled` - Value - disabled for configuring SelectPprType token.\n* `Hard PPR` - Value - Hard PPR for configuring SelectPprType token.\n* `Soft PPR` - Value - Soft PPR for configuring SelectPprType token.

```yaml
Type: BiosPolicy.SelectPprTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SerialPortAenable
BIOS Token for setting Serial A Enable configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SerialPortAenableEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Sev
BIOS Token for setting Secured Encrypted Virtualization configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `253 ASIDs` - Value - 253 ASIDs for configuring Sev token.\n* `509 ASIDs` - Value - 509 ASIDs for configuring Sev token.\n* `Auto` - Value - Auto for configuring Sev token.

```yaml
Type: BiosPolicy.SevEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SgxAutoRegistrationAgent
BIOS Token for setting SGX Auto MP Registration Agent configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SgxAutoRegistrationAgentEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SgxEpoch0
BIOS Token for setting SGX Epoch 0 configuration (0 - ffffffffffffffff Hash byte 7-0).

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SgxEpoch1
BIOS Token for setting SGX Epoch 1 configuration (0 - ffffffffffffffff Hash byte 7-0).

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SgxFactoryReset
BIOS Token for setting SGX Factory Reset configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SgxFactoryResetEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SgxLePubKeyHash0
BIOS Token for setting SGX PubKey Hash0 configuration (0 - ffffffffffffffff Hash byte 7-0).

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SgxLePubKeyHash1
BIOS Token for setting SGX PubKey Hash1 configuration (0 - ffffffffffffffff Hash byte 15-8).

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SgxLePubKeyHash2
BIOS Token for setting SGX PubKey Hash2 configuration (0 - ffffffffffffffff Hash byte 23-16).

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SgxLePubKeyHash3
BIOS Token for setting SGX PubKey Hash3 configuration (0 - ffffffffffffffff Hash byte 31-24).

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SgxLeWr
BIOS Token for setting SGX Write Enable configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SgxLeWrEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SgxPackageInfoInBandAccess
BIOS Token for setting SGX Package Information In-Band Access configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SgxPackageInfoInBandAccessEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SgxQos
BIOS Token for setting SGX QoS configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SgxQosEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Sha1pcrBank
BIOS Token for setting SHA-1 PCR Bank configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.Sha1pcrBankEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Sha256pcrBank
BIOS Token for setting SHA256 PCR Bank configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.Sha256pcrBankEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SinglePctlEnable
BIOS Token for setting Single PCTL configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `No` - Value - No for configuring SinglePctlEnable token.\n* `Yes` - Value - Yes for configuring SinglePctlEnable token.

```yaml
Type: BiosPolicy.SinglePctlEnableEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Slot10linkSpeed
BIOS Token for setting PCIe Slot:10 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring Slot10linkSpeed token.\n* `Disabled` - Value - Disabled for configuring Slot10linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring Slot10linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring Slot10linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring Slot10linkSpeed token.

```yaml
Type: BiosPolicy.Slot10linkSpeedEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Slot10state
BIOS Token for setting Slot 10 State configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `disabled` - Value - disabled for configuring Slot10state token.\n* `enabled` - Value - enabled for configuring Slot10state token.\n* `Legacy Only` - Value - Legacy Only for configuring Slot10state token.\n* `UEFI Only` - Value - UEFI Only for configuring Slot10state token.

```yaml
Type: BiosPolicy.Slot10stateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Slot11linkSpeed
BIOS Token for setting PCIe Slot:11 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring Slot11linkSpeed token.\n* `Disabled` - Value - Disabled for configuring Slot11linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring Slot11linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring Slot11linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring Slot11linkSpeed token.

```yaml
Type: BiosPolicy.Slot11linkSpeedEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Slot11state
BIOS Token for setting Slot 11 State configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.Slot11stateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Slot12linkSpeed
BIOS Token for setting PCIe Slot:12 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring Slot12linkSpeed token.\n* `Disabled` - Value - Disabled for configuring Slot12linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring Slot12linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring Slot12linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring Slot12linkSpeed token.

```yaml
Type: BiosPolicy.Slot12linkSpeedEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Slot12state
BIOS Token for setting Slot 12 State configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.Slot12stateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Slot13state
BIOS Token for setting Slot 13 State configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.Slot13stateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Slot14state
BIOS Token for setting Slot 14 State configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.Slot14stateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Slot1linkSpeed
BIOS Token for setting PCIe Slot: 1 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring Slot1linkSpeed token.\n* `Disabled` - Value - Disabled for configuring Slot1linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring Slot1linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring Slot1linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring Slot1linkSpeed token.\n* `GEN4` - Value - GEN4 for configuring Slot1linkSpeed token.

```yaml
Type: BiosPolicy.Slot1linkSpeedEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Slot1state
BIOS Token for setting Slot 1 State configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `disabled` - Value - disabled for configuring Slot1state token.\n* `enabled` - Value - enabled for configuring Slot1state token.\n* `Legacy Only` - Value - Legacy Only for configuring Slot1state token.\n* `UEFI Only` - Value - UEFI Only for configuring Slot1state token.

```yaml
Type: BiosPolicy.Slot1stateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Slot2linkSpeed
BIOS Token for setting PCIe Slot: 2 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring Slot2linkSpeed token.\n* `Disabled` - Value - Disabled for configuring Slot2linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring Slot2linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring Slot2linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring Slot2linkSpeed token.\n* `GEN4` - Value - GEN4 for configuring Slot2linkSpeed token.

```yaml
Type: BiosPolicy.Slot2linkSpeedEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Slot2state
BIOS Token for setting Slot 2 State configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `disabled` - Value - disabled for configuring Slot2state token.\n* `enabled` - Value - enabled for configuring Slot2state token.\n* `Legacy Only` - Value - Legacy Only for configuring Slot2state token.\n* `UEFI Only` - Value - UEFI Only for configuring Slot2state token.

```yaml
Type: BiosPolicy.Slot2stateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Slot3linkSpeed
BIOS Token for setting PCIe Slot: 3 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring Slot3linkSpeed token.\n* `Disabled` - Value - Disabled for configuring Slot3linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring Slot3linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring Slot3linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring Slot3linkSpeed token.\n* `GEN4` - Value - GEN4 for configuring Slot3linkSpeed token.

```yaml
Type: BiosPolicy.Slot3linkSpeedEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Slot3state
BIOS Token for setting Slot 3 State configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `disabled` - Value - disabled for configuring Slot3state token.\n* `enabled` - Value - enabled for configuring Slot3state token.\n* `Legacy Only` - Value - Legacy Only for configuring Slot3state token.\n* `UEFI Only` - Value - UEFI Only for configuring Slot3state token.

```yaml
Type: BiosPolicy.Slot3stateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Slot4linkSpeed
BIOS Token for setting PCIe Slot: 4 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring Slot4linkSpeed token.\n* `Disabled` - Value - Disabled for configuring Slot4linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring Slot4linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring Slot4linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring Slot4linkSpeed token.\n* `GEN4` - Value - GEN4 for configuring Slot4linkSpeed token.

```yaml
Type: BiosPolicy.Slot4linkSpeedEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Slot4state
BIOS Token for setting Slot 4 State configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `disabled` - Value - disabled for configuring Slot4state token.\n* `enabled` - Value - enabled for configuring Slot4state token.\n* `Legacy Only` - Value - Legacy Only for configuring Slot4state token.\n* `UEFI Only` - Value - UEFI Only for configuring Slot4state token.

```yaml
Type: BiosPolicy.Slot4stateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Slot5linkSpeed
BIOS Token for setting PCIe Slot: 5 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring Slot5linkSpeed token.\n* `Disabled` - Value - Disabled for configuring Slot5linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring Slot5linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring Slot5linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring Slot5linkSpeed token.\n* `GEN4` - Value - GEN4 for configuring Slot5linkSpeed token.

```yaml
Type: BiosPolicy.Slot5linkSpeedEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Slot5state
BIOS Token for setting Slot 5 State configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `disabled` - Value - disabled for configuring Slot5state token.\n* `enabled` - Value - enabled for configuring Slot5state token.\n* `Legacy Only` - Value - Legacy Only for configuring Slot5state token.\n* `UEFI Only` - Value - UEFI Only for configuring Slot5state token.

```yaml
Type: BiosPolicy.Slot5stateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Slot6linkSpeed
BIOS Token for setting PCIe Slot: 6 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring Slot6linkSpeed token.\n* `Disabled` - Value - Disabled for configuring Slot6linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring Slot6linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring Slot6linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring Slot6linkSpeed token.\n* `GEN4` - Value - GEN4 for configuring Slot6linkSpeed token.

```yaml
Type: BiosPolicy.Slot6linkSpeedEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Slot6state
BIOS Token for setting Slot 6 State configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `disabled` - Value - disabled for configuring Slot6state token.\n* `enabled` - Value - enabled for configuring Slot6state token.\n* `Legacy Only` - Value - Legacy Only for configuring Slot6state token.\n* `UEFI Only` - Value - UEFI Only for configuring Slot6state token.

```yaml
Type: BiosPolicy.Slot6stateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Slot7linkSpeed
BIOS Token for setting PCIe Slot: 7 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring Slot7linkSpeed token.\n* `Disabled` - Value - Disabled for configuring Slot7linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring Slot7linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring Slot7linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring Slot7linkSpeed token.\n* `GEN4` - Value - GEN4 for configuring Slot7linkSpeed token.

```yaml
Type: BiosPolicy.Slot7linkSpeedEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Slot7state
BIOS Token for setting Slot 7 State configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `disabled` - Value - disabled for configuring Slot7state token.\n* `enabled` - Value - enabled for configuring Slot7state token.\n* `Legacy Only` - Value - Legacy Only for configuring Slot7state token.\n* `UEFI Only` - Value - UEFI Only for configuring Slot7state token.

```yaml
Type: BiosPolicy.Slot7stateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Slot8linkSpeed
BIOS Token for setting PCIe Slot: 8 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring Slot8linkSpeed token.\n* `Disabled` - Value - Disabled for configuring Slot8linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring Slot8linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring Slot8linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring Slot8linkSpeed token.\n* `GEN4` - Value - GEN4 for configuring Slot8linkSpeed token.

```yaml
Type: BiosPolicy.Slot8linkSpeedEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Slot8state
BIOS Token for setting Slot 8 State configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `disabled` - Value - disabled for configuring Slot8state token.\n* `enabled` - Value - enabled for configuring Slot8state token.\n* `Legacy Only` - Value - Legacy Only for configuring Slot8state token.\n* `UEFI Only` - Value - UEFI Only for configuring Slot8state token.

```yaml
Type: BiosPolicy.Slot8stateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Slot9linkSpeed
BIOS Token for setting PCIe Slot: 9 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring Slot9linkSpeed token.\n* `Disabled` - Value - Disabled for configuring Slot9linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring Slot9linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring Slot9linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring Slot9linkSpeed token.\n* `GEN4` - Value - GEN4 for configuring Slot9linkSpeed token.

```yaml
Type: BiosPolicy.Slot9linkSpeedEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Slot9state
BIOS Token for setting Slot 9 State configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `disabled` - Value - disabled for configuring Slot9state token.\n* `enabled` - Value - enabled for configuring Slot9state token.\n* `Legacy Only` - Value - Legacy Only for configuring Slot9state token.\n* `UEFI Only` - Value - UEFI Only for configuring Slot9state token.

```yaml
Type: BiosPolicy.Slot9stateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotFlomLinkSpeed
BIOS Token for setting PCIe Slot:FLOM Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring SlotFlomLinkSpeed token.\n* `Disabled` - Value - Disabled for configuring SlotFlomLinkSpeed token.\n* `GEN1` - Value - GEN1 for configuring SlotFlomLinkSpeed token.\n* `GEN2` - Value - GEN2 for configuring SlotFlomLinkSpeed token.\n* `GEN3` - Value - GEN3 for configuring SlotFlomLinkSpeed token.

```yaml
Type: BiosPolicy.SlotFlomLinkSpeedEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotFrontNvme10linkSpeed
BIOS Token for setting Front NVME 10 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring SlotFrontNvme10linkSpeed token.\n* `Disabled` - Value - Disabled for configuring SlotFrontNvme10linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring SlotFrontNvme10linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring SlotFrontNvme10linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring SlotFrontNvme10linkSpeed token.\n* `GEN4` - Value - GEN4 for configuring SlotFrontNvme10linkSpeed token.

```yaml
Type: BiosPolicy.SlotFrontNvme10linkSpeedEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotFrontNvme10optionRom
BIOS Token for setting Front NVME 10 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SlotFrontNvme10optionRomEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotFrontNvme11linkSpeed
BIOS Token for setting Front NVME 11 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring SlotFrontNvme11linkSpeed token.\n* `Disabled` - Value - Disabled for configuring SlotFrontNvme11linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring SlotFrontNvme11linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring SlotFrontNvme11linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring SlotFrontNvme11linkSpeed token.\n* `GEN4` - Value - GEN4 for configuring SlotFrontNvme11linkSpeed token.

```yaml
Type: BiosPolicy.SlotFrontNvme11linkSpeedEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotFrontNvme11optionRom
BIOS Token for setting Front NVME 11 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SlotFrontNvme11optionRomEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotFrontNvme12linkSpeed
BIOS Token for setting Front NVME 12 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring SlotFrontNvme12linkSpeed token.\n* `Disabled` - Value - Disabled for configuring SlotFrontNvme12linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring SlotFrontNvme12linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring SlotFrontNvme12linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring SlotFrontNvme12linkSpeed token.\n* `GEN4` - Value - GEN4 for configuring SlotFrontNvme12linkSpeed token.

```yaml
Type: BiosPolicy.SlotFrontNvme12linkSpeedEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotFrontNvme12optionRom
BIOS Token for setting Front NVME 12 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SlotFrontNvme12optionRomEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotFrontNvme13optionRom
BIOS Token for setting Front NVME 13 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SlotFrontNvme13optionRomEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotFrontNvme14optionRom
BIOS Token for setting Front NVME 14 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SlotFrontNvme14optionRomEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotFrontNvme15optionRom
BIOS Token for setting Front NVME 15 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SlotFrontNvme15optionRomEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotFrontNvme16optionRom
BIOS Token for setting Front NVME 16 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SlotFrontNvme16optionRomEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotFrontNvme17optionRom
BIOS Token for setting Front NVME 17 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SlotFrontNvme17optionRomEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotFrontNvme18optionRom
BIOS Token for setting Front NVME 18 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SlotFrontNvme18optionRomEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotFrontNvme19optionRom
BIOS Token for setting Front NVME 19 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SlotFrontNvme19optionRomEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotFrontNvme1linkSpeed
BIOS Token for setting PCIe Slot:Front NVME 1 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring SlotFrontNvme1linkSpeed token.\n* `Disabled` - Value - Disabled for configuring SlotFrontNvme1linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring SlotFrontNvme1linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring SlotFrontNvme1linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring SlotFrontNvme1linkSpeed token.\n* `GEN4` - Value - GEN4 for configuring SlotFrontNvme1linkSpeed token.

```yaml
Type: BiosPolicy.SlotFrontNvme1linkSpeedEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotFrontNvme1optionRom
BIOS Token for setting Front NVME 1 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SlotFrontNvme1optionRomEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotFrontNvme20optionRom
BIOS Token for setting Front NVME 20 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SlotFrontNvme20optionRomEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotFrontNvme21optionRom
BIOS Token for setting Front NVME 21 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SlotFrontNvme21optionRomEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotFrontNvme22optionRom
BIOS Token for setting Front NVME 22 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SlotFrontNvme22optionRomEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotFrontNvme23optionRom
BIOS Token for setting Front NVME 23 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SlotFrontNvme23optionRomEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotFrontNvme24optionRom
BIOS Token for setting Front NVME 24 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SlotFrontNvme24optionRomEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotFrontNvme2linkSpeed
BIOS Token for setting PCIe Slot:Front NVME 2 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring SlotFrontNvme2linkSpeed token.\n* `Disabled` - Value - Disabled for configuring SlotFrontNvme2linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring SlotFrontNvme2linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring SlotFrontNvme2linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring SlotFrontNvme2linkSpeed token.\n* `GEN4` - Value - GEN4 for configuring SlotFrontNvme2linkSpeed token.

```yaml
Type: BiosPolicy.SlotFrontNvme2linkSpeedEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotFrontNvme2optionRom
BIOS Token for setting Front NVME 2 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SlotFrontNvme2optionRomEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotFrontNvme3linkSpeed
BIOS Token for setting Front NVME 3 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring SlotFrontNvme3linkSpeed token.\n* `Disabled` - Value - Disabled for configuring SlotFrontNvme3linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring SlotFrontNvme3linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring SlotFrontNvme3linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring SlotFrontNvme3linkSpeed token.\n* `GEN4` - Value - GEN4 for configuring SlotFrontNvme3linkSpeed token.

```yaml
Type: BiosPolicy.SlotFrontNvme3linkSpeedEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotFrontNvme3optionRom
BIOS Token for setting Front NVME 3 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SlotFrontNvme3optionRomEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotFrontNvme4linkSpeed
BIOS Token for setting Front NVME 4 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring SlotFrontNvme4linkSpeed token.\n* `Disabled` - Value - Disabled for configuring SlotFrontNvme4linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring SlotFrontNvme4linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring SlotFrontNvme4linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring SlotFrontNvme4linkSpeed token.\n* `GEN4` - Value - GEN4 for configuring SlotFrontNvme4linkSpeed token.

```yaml
Type: BiosPolicy.SlotFrontNvme4linkSpeedEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotFrontNvme4optionRom
BIOS Token for setting Front NVME 4 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SlotFrontNvme4optionRomEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotFrontNvme5linkSpeed
BIOS Token for setting Front NVME 5 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring SlotFrontNvme5linkSpeed token.\n* `Disabled` - Value - Disabled for configuring SlotFrontNvme5linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring SlotFrontNvme5linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring SlotFrontNvme5linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring SlotFrontNvme5linkSpeed token.\n* `GEN4` - Value - GEN4 for configuring SlotFrontNvme5linkSpeed token.

```yaml
Type: BiosPolicy.SlotFrontNvme5linkSpeedEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotFrontNvme5optionRom
BIOS Token for setting Front NVME 5 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SlotFrontNvme5optionRomEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotFrontNvme6linkSpeed
BIOS Token for setting Front NVME 6 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring SlotFrontNvme6linkSpeed token.\n* `Disabled` - Value - Disabled for configuring SlotFrontNvme6linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring SlotFrontNvme6linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring SlotFrontNvme6linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring SlotFrontNvme6linkSpeed token.\n* `GEN4` - Value - GEN4 for configuring SlotFrontNvme6linkSpeed token.

```yaml
Type: BiosPolicy.SlotFrontNvme6linkSpeedEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotFrontNvme6optionRom
BIOS Token for setting Front NVME 6 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SlotFrontNvme6optionRomEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotFrontNvme7linkSpeed
BIOS Token for setting Front NVME 7 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring SlotFrontNvme7linkSpeed token.\n* `Disabled` - Value - Disabled for configuring SlotFrontNvme7linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring SlotFrontNvme7linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring SlotFrontNvme7linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring SlotFrontNvme7linkSpeed token.\n* `GEN4` - Value - GEN4 for configuring SlotFrontNvme7linkSpeed token.

```yaml
Type: BiosPolicy.SlotFrontNvme7linkSpeedEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotFrontNvme7optionRom
BIOS Token for setting Front NVME 7 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SlotFrontNvme7optionRomEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotFrontNvme8linkSpeed
BIOS Token for setting Front NVME 8 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring SlotFrontNvme8linkSpeed token.\n* `Disabled` - Value - Disabled for configuring SlotFrontNvme8linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring SlotFrontNvme8linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring SlotFrontNvme8linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring SlotFrontNvme8linkSpeed token.\n* `GEN4` - Value - GEN4 for configuring SlotFrontNvme8linkSpeed token.

```yaml
Type: BiosPolicy.SlotFrontNvme8linkSpeedEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotFrontNvme8optionRom
BIOS Token for setting Front NVME 8 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SlotFrontNvme8optionRomEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotFrontNvme9linkSpeed
BIOS Token for setting Front NVME 9 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring SlotFrontNvme9linkSpeed token.\n* `Disabled` - Value - Disabled for configuring SlotFrontNvme9linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring SlotFrontNvme9linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring SlotFrontNvme9linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring SlotFrontNvme9linkSpeed token.\n* `GEN4` - Value - GEN4 for configuring SlotFrontNvme9linkSpeed token.

```yaml
Type: BiosPolicy.SlotFrontNvme9linkSpeedEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotFrontNvme9optionRom
BIOS Token for setting Front NVME 9 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SlotFrontNvme9optionRomEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotFrontSlot5linkSpeed
BIOS Token for setting PCIe Slot:Front1 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring SlotFrontSlot5linkSpeed token.\n* `Disabled` - Value - Disabled for configuring SlotFrontSlot5linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring SlotFrontSlot5linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring SlotFrontSlot5linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring SlotFrontSlot5linkSpeed token.

```yaml
Type: BiosPolicy.SlotFrontSlot5linkSpeedEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotFrontSlot6linkSpeed
BIOS Token for setting PCIe Slot:Front2 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring SlotFrontSlot6linkSpeed token.\n* `Disabled` - Value - Disabled for configuring SlotFrontSlot6linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring SlotFrontSlot6linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring SlotFrontSlot6linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring SlotFrontSlot6linkSpeed token.

```yaml
Type: BiosPolicy.SlotFrontSlot6linkSpeedEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotGpu1state
BIOS Token for setting GPU 1 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SlotGpu1stateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotGpu2state
BIOS Token for setting GPU 2 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SlotGpu2stateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotGpu3state
BIOS Token for setting GPU 3 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SlotGpu3stateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotGpu4state
BIOS Token for setting GPU 4 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SlotGpu4stateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotGpu5state
BIOS Token for setting GPU 5 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SlotGpu5stateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotGpu6state
BIOS Token for setting GPU 6 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SlotGpu6stateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotGpu7state
BIOS Token for setting GPU 7 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SlotGpu7stateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotGpu8state
BIOS Token for setting GPU 8 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SlotGpu8stateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotHbaLinkSpeed
BIOS Token for setting PCIe Slot:HBA Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring SlotHbaLinkSpeed token.\n* `Disabled` - Value - Disabled for configuring SlotHbaLinkSpeed token.\n* `GEN1` - Value - GEN1 for configuring SlotHbaLinkSpeed token.\n* `GEN2` - Value - GEN2 for configuring SlotHbaLinkSpeed token.\n* `GEN3` - Value - GEN3 for configuring SlotHbaLinkSpeed token.

```yaml
Type: BiosPolicy.SlotHbaLinkSpeedEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotHbaState
BIOS Token for setting PCIe Slot:HBA OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `disabled` - Value - disabled for configuring SlotHbaState token.\n* `enabled` - Value - enabled for configuring SlotHbaState token.\n* `Legacy Only` - Value - Legacy Only for configuring SlotHbaState token.\n* `UEFI Only` - Value - UEFI Only for configuring SlotHbaState token.

```yaml
Type: BiosPolicy.SlotHbaStateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotLom1link
BIOS Token for setting PCIe LOM:1 Link configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SlotLom1linkEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotLom2link
BIOS Token for setting PCIe LOM:2 Link configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SlotLom2linkEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotMezzState
BIOS Token for setting Slot Mezz State configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `disabled` - Value - disabled for configuring SlotMezzState token.\n* `enabled` - Value - enabled for configuring SlotMezzState token.\n* `Legacy Only` - Value - Legacy Only for configuring SlotMezzState token.\n* `UEFI Only` - Value - UEFI Only for configuring SlotMezzState token.

```yaml
Type: BiosPolicy.SlotMezzStateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotMlomLinkSpeed
BIOS Token for setting PCIe Slot:MLOM Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring SlotMlomLinkSpeed token.\n* `Disabled` - Value - Disabled for configuring SlotMlomLinkSpeed token.\n* `GEN1` - Value - GEN1 for configuring SlotMlomLinkSpeed token.\n* `GEN2` - Value - GEN2 for configuring SlotMlomLinkSpeed token.\n* `GEN3` - Value - GEN3 for configuring SlotMlomLinkSpeed token.\n* `GEN4` - Value - GEN4 for configuring SlotMlomLinkSpeed token.

```yaml
Type: BiosPolicy.SlotMlomLinkSpeedEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotMlomState
BIOS Token for setting PCIe Slot MLOM OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `disabled` - Value - disabled for configuring SlotMlomState token.\n* `enabled` - Value - enabled for configuring SlotMlomState token.\n* `Legacy Only` - Value - Legacy Only for configuring SlotMlomState token.\n* `UEFI Only` - Value - UEFI Only for configuring SlotMlomState token.

```yaml
Type: BiosPolicy.SlotMlomStateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotMraidLinkSpeed
BIOS Token for setting MRAID Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring SlotMraidLinkSpeed token.\n* `Disabled` - Value - Disabled for configuring SlotMraidLinkSpeed token.\n* `GEN1` - Value - GEN1 for configuring SlotMraidLinkSpeed token.\n* `GEN2` - Value - GEN2 for configuring SlotMraidLinkSpeed token.\n* `GEN3` - Value - GEN3 for configuring SlotMraidLinkSpeed token.\n* `GEN4` - Value - GEN4 for configuring SlotMraidLinkSpeed token.

```yaml
Type: BiosPolicy.SlotMraidLinkSpeedEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotMraidState
BIOS Token for setting PCIe Slot MRAID OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SlotMraidStateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotN10state
BIOS Token for setting PCIe Slot N10 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SlotN10stateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotN11state
BIOS Token for setting PCIe Slot N11 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SlotN11stateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotN12state
BIOS Token for setting PCIe Slot N12 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SlotN12stateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotN13state
BIOS Token for setting PCIe Slot N13 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SlotN13stateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotN14state
BIOS Token for setting PCIe Slot N14 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SlotN14stateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotN15state
BIOS Token for setting PCIe Slot N15 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SlotN15stateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotN16state
BIOS Token for setting PCIe Slot N16 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SlotN16stateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotN17state
BIOS Token for setting PCIe Slot N17 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SlotN17stateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotN18state
BIOS Token for setting PCIe Slot N18 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SlotN18stateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotN19state
BIOS Token for setting PCIe Slot N19 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SlotN19stateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotN1state
BIOS Token for setting PCIe Slot N1 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `disabled` - Value - disabled for configuring SlotN1state token.\n* `enabled` - Value - enabled for configuring SlotN1state token.\n* `Legacy Only` - Value - Legacy Only for configuring SlotN1state token.\n* `UEFI Only` - Value - UEFI Only for configuring SlotN1state token.

```yaml
Type: BiosPolicy.SlotN1stateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotN20state
BIOS Token for setting PCIe Slot N20 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SlotN20stateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotN21state
BIOS Token for setting PCIe Slot N21 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SlotN21stateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotN22state
BIOS Token for setting PCIe Slot N22 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SlotN22stateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotN23state
BIOS Token for setting PCIe Slot N23 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SlotN23stateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotN24state
BIOS Token for setting PCIe Slot N24 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SlotN24stateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotN2state
BIOS Token for setting PCIe Slot N2 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `disabled` - Value - disabled for configuring SlotN2state token.\n* `enabled` - Value - enabled for configuring SlotN2state token.\n* `Legacy Only` - Value - Legacy Only for configuring SlotN2state token.\n* `UEFI Only` - Value - UEFI Only for configuring SlotN2state token.

```yaml
Type: BiosPolicy.SlotN2stateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotN3state
BIOS Token for setting PCIe Slot N3 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SlotN3stateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotN4state
BIOS Token for setting PCIe Slot N4 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SlotN4stateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotN5state
BIOS Token for setting PCIe Slot N5 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SlotN5stateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotN6state
BIOS Token for setting PCIe Slot N6 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SlotN6stateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotN7state
BIOS Token for setting PCIe Slot N7 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SlotN7stateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotN8state
BIOS Token for setting PCIe Slot N8 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SlotN8stateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotN9state
BIOS Token for setting PCIe Slot N9 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SlotN9stateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotRaidLinkSpeed
BIOS Token for setting RAID Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring SlotRaidLinkSpeed token.\n* `Disabled` - Value - Disabled for configuring SlotRaidLinkSpeed token.\n* `GEN1` - Value - GEN1 for configuring SlotRaidLinkSpeed token.\n* `GEN2` - Value - GEN2 for configuring SlotRaidLinkSpeed token.\n* `GEN3` - Value - GEN3 for configuring SlotRaidLinkSpeed token.

```yaml
Type: BiosPolicy.SlotRaidLinkSpeedEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotRaidState
BIOS Token for setting PCIe Slot RAID OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SlotRaidStateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotRearNvme1linkSpeed
BIOS Token for setting PCIe Slot:Rear NVME 1 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring SlotRearNvme1linkSpeed token.\n* `Disabled` - Value - Disabled for configuring SlotRearNvme1linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring SlotRearNvme1linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring SlotRearNvme1linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring SlotRearNvme1linkSpeed token.\n* `GEN4` - Value - GEN4 for configuring SlotRearNvme1linkSpeed token.

```yaml
Type: BiosPolicy.SlotRearNvme1linkSpeedEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotRearNvme1state
BIOS Token for setting PCIe Slot:Rear NVME 1 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SlotRearNvme1stateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotRearNvme2linkSpeed
BIOS Token for setting PCIe Slot:Rear NVME 2 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring SlotRearNvme2linkSpeed token.\n* `Disabled` - Value - Disabled for configuring SlotRearNvme2linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring SlotRearNvme2linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring SlotRearNvme2linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring SlotRearNvme2linkSpeed token.\n* `GEN4` - Value - GEN4 for configuring SlotRearNvme2linkSpeed token.

```yaml
Type: BiosPolicy.SlotRearNvme2linkSpeedEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotRearNvme2state
BIOS Token for setting PCIe Slot:Rear NVME 2 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SlotRearNvme2stateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotRearNvme3linkSpeed
BIOS Token for setting Rear NVME 3 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring SlotRearNvme3linkSpeed token.\n* `Disabled` - Value - Disabled for configuring SlotRearNvme3linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring SlotRearNvme3linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring SlotRearNvme3linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring SlotRearNvme3linkSpeed token.\n* `GEN4` - Value - GEN4 for configuring SlotRearNvme3linkSpeed token.

```yaml
Type: BiosPolicy.SlotRearNvme3linkSpeedEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotRearNvme3state
BIOS Token for setting PCIe Slot:Rear NVME 3 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SlotRearNvme3stateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotRearNvme4linkSpeed
BIOS Token for setting Rear NVME 4 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring SlotRearNvme4linkSpeed token.\n* `Disabled` - Value - Disabled for configuring SlotRearNvme4linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring SlotRearNvme4linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring SlotRearNvme4linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring SlotRearNvme4linkSpeed token.\n* `GEN4` - Value - GEN4 for configuring SlotRearNvme4linkSpeed token.

```yaml
Type: BiosPolicy.SlotRearNvme4linkSpeedEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotRearNvme4state
BIOS Token for setting PCIe Slot:Rear NVME 4 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SlotRearNvme4stateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotRearNvme5state
BIOS Token for setting PCIe Slot:Rear NVME 5 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SlotRearNvme5stateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotRearNvme6state
BIOS Token for setting PCIe Slot:Rear NVME 6 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SlotRearNvme6stateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotRearNvme7state
BIOS Token for setting PCIe Slot:Rear NVME 7 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SlotRearNvme7stateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotRearNvme8state
BIOS Token for setting PCIe Slot:Rear NVME 8 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SlotRearNvme8stateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotRiser1linkSpeed
BIOS Token for setting PCIe Slot:Riser1 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring SlotRiser1linkSpeed token.\n* `Disabled` - Value - Disabled for configuring SlotRiser1linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring SlotRiser1linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring SlotRiser1linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring SlotRiser1linkSpeed token.

```yaml
Type: BiosPolicy.SlotRiser1linkSpeedEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotRiser1slot1linkSpeed
BIOS Token for setting PCIe Slot:Riser1 Slot1 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring SlotRiser1slot1linkSpeed token.\n* `Disabled` - Value - Disabled for configuring SlotRiser1slot1linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring SlotRiser1slot1linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring SlotRiser1slot1linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring SlotRiser1slot1linkSpeed token.

```yaml
Type: BiosPolicy.SlotRiser1slot1linkSpeedEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotRiser1slot2linkSpeed
BIOS Token for setting PCIe Slot:Riser1 Slot2 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring SlotRiser1slot2linkSpeed token.\n* `Disabled` - Value - Disabled for configuring SlotRiser1slot2linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring SlotRiser1slot2linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring SlotRiser1slot2linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring SlotRiser1slot2linkSpeed token.

```yaml
Type: BiosPolicy.SlotRiser1slot2linkSpeedEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotRiser1slot3linkSpeed
BIOS Token for setting PCIe Slot:Riser1 Slot3 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring SlotRiser1slot3linkSpeed token.\n* `Disabled` - Value - Disabled for configuring SlotRiser1slot3linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring SlotRiser1slot3linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring SlotRiser1slot3linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring SlotRiser1slot3linkSpeed token.

```yaml
Type: BiosPolicy.SlotRiser1slot3linkSpeedEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotRiser2linkSpeed
BIOS Token for setting PCIe Slot:Riser2 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring SlotRiser2linkSpeed token.\n* `Disabled` - Value - Disabled for configuring SlotRiser2linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring SlotRiser2linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring SlotRiser2linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring SlotRiser2linkSpeed token.

```yaml
Type: BiosPolicy.SlotRiser2linkSpeedEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotRiser2slot4linkSpeed
BIOS Token for setting PCIe Slot:Riser2 Slot4 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring SlotRiser2slot4linkSpeed token.\n* `Disabled` - Value - Disabled for configuring SlotRiser2slot4linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring SlotRiser2slot4linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring SlotRiser2slot4linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring SlotRiser2slot4linkSpeed token.

```yaml
Type: BiosPolicy.SlotRiser2slot4linkSpeedEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotRiser2slot5linkSpeed
BIOS Token for setting PCIe Slot:Riser2 Slot5 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring SlotRiser2slot5linkSpeed token.\n* `Disabled` - Value - Disabled for configuring SlotRiser2slot5linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring SlotRiser2slot5linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring SlotRiser2slot5linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring SlotRiser2slot5linkSpeed token.

```yaml
Type: BiosPolicy.SlotRiser2slot5linkSpeedEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotRiser2slot6linkSpeed
BIOS Token for setting PCIe Slot:Riser2 Slot6 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring SlotRiser2slot6linkSpeed token.\n* `Disabled` - Value - Disabled for configuring SlotRiser2slot6linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring SlotRiser2slot6linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring SlotRiser2slot6linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring SlotRiser2slot6linkSpeed token.

```yaml
Type: BiosPolicy.SlotRiser2slot6linkSpeedEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotSasState
BIOS Token for setting PCIe Slot:SAS OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `disabled` - Value - disabled for configuring SlotSasState token.\n* `enabled` - Value - enabled for configuring SlotSasState token.\n* `Legacy Only` - Value - Legacy Only for configuring SlotSasState token.\n* `UEFI Only` - Value - UEFI Only for configuring SlotSasState token.

```yaml
Type: BiosPolicy.SlotSasStateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotSsdSlot1linkSpeed
BIOS Token for setting PCIe Slot:FrontSSD1 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring SlotSsdSlot1linkSpeed token.\n* `Disabled` - Value - Disabled for configuring SlotSsdSlot1linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring SlotSsdSlot1linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring SlotSsdSlot1linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring SlotSsdSlot1linkSpeed token.

```yaml
Type: BiosPolicy.SlotSsdSlot1linkSpeedEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotSsdSlot2linkSpeed
BIOS Token for setting PCIe Slot:FrontSSD2 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring SlotSsdSlot2linkSpeed token.\n* `Disabled` - Value - Disabled for configuring SlotSsdSlot2linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring SlotSsdSlot2linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring SlotSsdSlot2linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring SlotSsdSlot2linkSpeed token.

```yaml
Type: BiosPolicy.SlotSsdSlot2linkSpeedEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Smee
BIOS Token for setting SMEE configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SmeeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SmtMode
BIOS Token for setting SMT Mode configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring SmtMode token.\n* `Off` - Value - Off for configuring SmtMode token.

```yaml
Type: BiosPolicy.SmtModeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Snc
BIOS Token for setting Sub Numa Clustering configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring Snc token.\n* `disabled` - Value - disabled for configuring Snc token.\n* `enabled` - Value - enabled for configuring Snc token.

```yaml
Type: BiosPolicy.SncEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SnoopyModeFor2lm
BIOS Token for setting Snoopy Mode for 2LM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SnoopyModeFor2lmEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SnoopyModeForAd
BIOS Token for setting Snoopy Mode for AD configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SnoopyModeForAdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SparingMode
BIOS Token for setting Sparing Mode configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `dimm-sparing` - Value - dimm-sparing for configuring SparingMode token.\n* `rank-sparing` - Value - rank-sparing for configuring SparingMode token.

```yaml
Type: BiosPolicy.SparingModeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SrIov
BIOS Token for setting SR-IOV Support configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SrIovEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -StreamerPrefetch
BIOS Token for setting DCU Streamer Prefetch configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.StreamerPrefetchEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SvmMode
BIOS Token for setting SVM Mode configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.SvmModeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Tags


Note :- Use Initialize-IntersightMoTag to create the object of complex type MoTag

```yaml
Type: System.Collections.Generic.List`1[MoTag]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -TerminalType
BIOS Token for setting Terminal Type configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `pc-ansi` - Value - pc-ansi for configuring TerminalType token.\n* `vt100` - Value - vt100 for configuring TerminalType token.\n* `vt100-plus` - Value - vt100-plus for configuring TerminalType token.\n* `vt-utf8` - Value - vt-utf8 for configuring TerminalType token.

```yaml
Type: BiosPolicy.TerminalTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -TpmControl
BIOS Token for setting Trusted Platform Module State configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.TpmControlEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -TpmPendingOperation
BIOS Token for setting TPM Pending Operation configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `None` - Value - None for configuring TpmPendingOperation token.\n* `TpmClear` - Value - TpmClear for configuring TpmPendingOperation token.

```yaml
Type: BiosPolicy.TpmPendingOperationEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -TpmSupport
BIOS Token for setting TPM Support configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.TpmSupportEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Tsme
BIOS Token for setting Transparent Secure Memory Encryption configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring Tsme token.\n* `disabled` - Value - disabled for configuring Tsme token.\n* `enabled` - Value - enabled for configuring Tsme token.

```yaml
Type: BiosPolicy.TsmeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -TxtSupport
BIOS Token for setting Intel Trusted Execution Technology Support configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.TxtSupportEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -UcsmBootOrderRule
BIOS Token for setting Boot Order Rules configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Loose` - Value - Loose for configuring UcsmBootOrderRule token.\n* `Strict` - Value - Strict for configuring UcsmBootOrderRule token.

```yaml
Type: BiosPolicy.UcsmBootOrderRuleEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -UfsDisable
BIOS Token for setting Uncore Frequency Scaling configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.UfsDisableEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -UmaBasedClustering
BIOS Token for setting UMA Based Clustering configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Disable (All2All)` - Value - Disable (All2All) for configuring UmaBasedClustering token.\n* `Hemisphere (2-clusters)` - Value - Hemisphere (2-clusters) for configuring UmaBasedClustering token.

```yaml
Type: BiosPolicy.UmaBasedClusteringEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -UpiLinkEnablement
BIOS Token for setting UPI Link Enablement configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `1` - Value - 1 for configuring UpiLinkEnablement token.\n* `2` - Value - 2 for configuring UpiLinkEnablement token.\n* `Auto` - Value - Auto for configuring UpiLinkEnablement token.

```yaml
Type: BiosPolicy.UpiLinkEnablementEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -UpiPowerManagement
BIOS Token for setting UPI Power Manangement configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.UpiPowerManagementEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -UsbEmul6064
BIOS Token for setting Port 60/64 Emulation configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.UsbEmul6064Enum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -UsbPortFront
BIOS Token for setting USB Port Front configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.UsbPortFrontEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -UsbPortInternal
BIOS Token for setting USB Port Internal configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.UsbPortInternalEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -UsbPortKvm
BIOS Token for setting USB Port KVM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.UsbPortKvmEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -UsbPortRear
BIOS Token for setting USB Port Rear configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.UsbPortRearEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -UsbPortSdCard
BIOS Token for setting USB Port SD Card configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.UsbPortSdCardEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -UsbPortVmedia
BIOS Token for setting USB Port VMedia configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.UsbPortVmediaEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -UsbXhciSupport
BIOS Token for setting XHCI Legacy Support configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.UsbXhciSupportEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -VgaPriority
BIOS Token for setting VGA Priority configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Offboard` - Value - Offboard for configuring VgaPriority token.\n* `Onboard` - Value - Onboard for configuring VgaPriority token.\n* `Onboard VGA Disabled` - Value - Onboard VGA Disabled for configuring VgaPriority token.

```yaml
Type: BiosPolicy.VgaPriorityEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -VirtualNuma
BIOS Token for setting Virtual NUMA configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.VirtualNumaEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -VmdEnable
BIOS Token for setting VMD Enablement configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting.

```yaml
Type: BiosPolicy.VmdEnableEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -VolMemoryMode
BIOS Token for setting Volatile Memory Mode configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `1LM` - Value - 1LM for configuring VolMemoryMode token.\n* `2LM` - Value - 2LM for configuring VolMemoryMode token.

```yaml
Type: BiosPolicy.VolMemoryModeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -WorkLoadConfig
BIOS Token for setting Workload Configuration configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Balanced` - Value - Balanced for configuring WorkLoadConfig token.\n* `I/O Sensitive` - Value - I/O Sensitive for configuring WorkLoadConfig token.\n* `NUMA` - Value - NUMA for configuring WorkLoadConfig token.\n* `UMA` - Value - UMA for configuring WorkLoadConfig token.

```yaml
Type: BiosPolicy.WorkLoadConfigEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -XptPrefetch
BIOS Token for setting XPT Prefetch configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring XptPrefetch token.\n* `disabled` - Value - disabled for configuring XptPrefetch token.\n* `enabled` - Value - enabled for configuring XptPrefetch token.

```yaml
Type: BiosPolicy.XptPrefetchEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -XptRemotePrefetch
BIOS Token for setting XPT Remote Prefetch configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring XptRemotePrefetch token.\n* `disabled` - Value - disabled for configuring XptRemotePrefetch token.\n* `enabled` - Value - enabled for configuring XptRemotePrefetch token.

```yaml
Type: BiosPolicy.XptRemotePrefetchEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Json
Returns the json payload received in response.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True False
Accept wildcard characters: False
```

### -WithHttpInfo
Returns the HTTP response with headers and content.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True False
Accept wildcard characters: False
```


### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## EXAMPLES

### Example 1
```powershell
PS C:\> Set-IntersightBiosPolicy
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightBiosPolicy](./Get-IntersightBiosPolicy.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)

[New-IntersightBiosPolicy](./New-IntersightBiosPolicy.md)

[Remove-IntersightBiosPolicy](./Remove-IntersightBiosPolicy.md)
