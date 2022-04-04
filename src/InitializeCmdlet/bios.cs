using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize BiosBootDevice.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightBiosBootDevice")]
    public class InitializeIntersightBiosBootDevice : PSCmdlet
    {
        public InitializeIntersightBiosBootDevice()
        {
            ClassId = BiosBootDevice.ClassIdEnum.BiosBootDevice;
            ObjectType = BiosBootDevice.ObjectTypeEnum.BiosBootDevice;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosBootDevice.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosBootDevice.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.BiosBootDevice initObject = new Intersight.Model.BiosBootDevice();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize BiosBootMode.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightBiosBootMode")]
    public class InitializeIntersightBiosBootMode : PSCmdlet
    {
        public InitializeIntersightBiosBootMode()
        {
            ClassId = BiosBootMode.ClassIdEnum.BiosBootMode;
            ObjectType = BiosBootMode.ObjectTypeEnum.BiosBootMode;

        }
        // <summary>
        /// <para type="description">"The actual BIOS boot mode as reported by the platform BIOS."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ActualBootMode
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosBootMode.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a computeBlade resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.ComputeBladeRelationship ComputeBlade
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a computeRackUnit resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.ComputeRackUnitRelationship ComputeRackUnit
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosBootMode.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.BiosBootMode initObject = new Intersight.Model.BiosBootMode();
            if (this.MyInvocation.BoundParameters.ContainsKey("ActualBootMode"))
            {
                initObject.ActualBootMode = this.ActualBootMode;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ComputeBlade"))
            {
                initObject.ComputeBlade = this.ComputeBlade;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ComputeRackUnit"))
            {
                initObject.ComputeRackUnit = this.ComputeRackUnit;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize BiosPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightBiosPolicy")]
    public class InitializeIntersightBiosPolicy : PSCmdlet
    {
        public InitializeIntersightBiosPolicy()
        {
            AcsControlGpu1state = BiosPolicy.AcsControlGpu1stateEnum.PlatformDefault;
            AcsControlGpu2state = BiosPolicy.AcsControlGpu2stateEnum.PlatformDefault;
            AcsControlGpu3state = BiosPolicy.AcsControlGpu3stateEnum.PlatformDefault;
            AcsControlGpu4state = BiosPolicy.AcsControlGpu4stateEnum.PlatformDefault;
            AcsControlGpu5state = BiosPolicy.AcsControlGpu5stateEnum.PlatformDefault;
            AcsControlGpu6state = BiosPolicy.AcsControlGpu6stateEnum.PlatformDefault;
            AcsControlGpu7state = BiosPolicy.AcsControlGpu7stateEnum.PlatformDefault;
            AcsControlGpu8state = BiosPolicy.AcsControlGpu8stateEnum.PlatformDefault;
            AcsControlSlot11state = BiosPolicy.AcsControlSlot11stateEnum.PlatformDefault;
            AcsControlSlot12state = BiosPolicy.AcsControlSlot12stateEnum.PlatformDefault;
            AcsControlSlot13state = BiosPolicy.AcsControlSlot13stateEnum.PlatformDefault;
            AcsControlSlot14state = BiosPolicy.AcsControlSlot14stateEnum.PlatformDefault;
            AdjacentCacheLinePrefetch = BiosPolicy.AdjacentCacheLinePrefetchEnum.PlatformDefault;
            AdvancedMemTest = BiosPolicy.AdvancedMemTestEnum.PlatformDefault;
            AllUsbDevices = BiosPolicy.AllUsbDevicesEnum.PlatformDefault;
            Altitude = BiosPolicy.AltitudeEnum.PlatformDefault;
            AspmSupport = BiosPolicy.AspmSupportEnum.PlatformDefault;
            AssertNmiOnPerr = BiosPolicy.AssertNmiOnPerrEnum.PlatformDefault;
            AssertNmiOnSerr = BiosPolicy.AssertNmiOnSerrEnum.PlatformDefault;
            AutoCcState = BiosPolicy.AutoCcStateEnum.PlatformDefault;
            AutonumousCstateEnable = BiosPolicy.AutonumousCstateEnableEnum.PlatformDefault;
            BaudRate = BiosPolicy.BaudRateEnum.PlatformDefault;
            BmeDmaMitigation = BiosPolicy.BmeDmaMitigationEnum.PlatformDefault;
            BootOptionNumRetry = BiosPolicy.BootOptionNumRetryEnum.PlatformDefault;
            BootOptionReCoolDown = BiosPolicy.BootOptionReCoolDownEnum.PlatformDefault;
            BootOptionRetry = BiosPolicy.BootOptionRetryEnum.PlatformDefault;
            BootPerformanceMode = BiosPolicy.BootPerformanceModeEnum.PlatformDefault;
            BurstAndPostponedRefresh = BiosPolicy.BurstAndPostponedRefreshEnum.PlatformDefault;
            C1autoDemotion = BiosPolicy.C1autoDemotionEnum.PlatformDefault;
            C1autoUnDemotion = BiosPolicy.C1autoUnDemotionEnum.PlatformDefault;
            CbsCmnApbdis = BiosPolicy.CbsCmnApbdisEnum.PlatformDefault;
            CbsCmnCpuCpb = BiosPolicy.CbsCmnCpuCpbEnum.PlatformDefault;
            CbsCmnCpuGenDowncoreCtrl = BiosPolicy.CbsCmnCpuGenDowncoreCtrlEnum.PlatformDefault;
            CbsCmnCpuGlobalCstateCtrl = BiosPolicy.CbsCmnCpuGlobalCstateCtrlEnum.PlatformDefault;
            CbsCmnCpuL1streamHwPrefetcher = BiosPolicy.CbsCmnCpuL1streamHwPrefetcherEnum.PlatformDefault;
            CbsCmnCpuL2streamHwPrefetcher = BiosPolicy.CbsCmnCpuL2streamHwPrefetcherEnum.PlatformDefault;
            CbsCmnCpuSmee = BiosPolicy.CbsCmnCpuSmeeEnum.PlatformDefault;
            CbsCmnCpuStreamingStoresCtrl = BiosPolicy.CbsCmnCpuStreamingStoresCtrlEnum.PlatformDefault;
            CbsCmnDeterminismSlider = BiosPolicy.CbsCmnDeterminismSliderEnum.PlatformDefault;
            CbsCmnEfficiencyModeEn = BiosPolicy.CbsCmnEfficiencyModeEnEnum.PlatformDefault;
            CbsCmnFixedSocPstate = BiosPolicy.CbsCmnFixedSocPstateEnum.PlatformDefault;
            CbsCmnGnbNbIommu = BiosPolicy.CbsCmnGnbNbIommuEnum.PlatformDefault;
            CbsCmnGnbSmuDfCstates = BiosPolicy.CbsCmnGnbSmuDfCstatesEnum.PlatformDefault;
            CbsCmnGnbSmucppc = BiosPolicy.CbsCmnGnbSmucppcEnum.PlatformDefault;
            CbsCmnMemCtrlBankGroupSwapDdr4 = BiosPolicy.CbsCmnMemCtrlBankGroupSwapDdr4Enum.PlatformDefault;
            CbsCmnMemMapBankInterleaveDdr4 = BiosPolicy.CbsCmnMemMapBankInterleaveDdr4Enum.PlatformDefault;
            CbsCmncTdpCtl = BiosPolicy.CbsCmncTdpCtlEnum.PlatformDefault;
            CbsCpuCcdCtrlSsp = BiosPolicy.CbsCpuCcdCtrlSspEnum.PlatformDefault;
            CbsCpuCoreCtrl = BiosPolicy.CbsCpuCoreCtrlEnum.PlatformDefault;
            CbsCpuSmtCtrl = BiosPolicy.CbsCpuSmtCtrlEnum.PlatformDefault;
            CbsDbgCpuSnpMemCover = BiosPolicy.CbsDbgCpuSnpMemCoverEnum.PlatformDefault;
            CbsDfCmnAcpiSratL3numa = BiosPolicy.CbsDfCmnAcpiSratL3numaEnum.PlatformDefault;
            CbsDfCmnDramNps = BiosPolicy.CbsDfCmnDramNpsEnum.PlatformDefault;
            CbsDfCmnMemIntlv = BiosPolicy.CbsDfCmnMemIntlvEnum.PlatformDefault;
            CbsDfCmnMemIntlvSize = BiosPolicy.CbsDfCmnMemIntlvSizeEnum.PlatformDefault;
            CbsSevSnpSupport = BiosPolicy.CbsSevSnpSupportEnum.PlatformDefault;
            CdnEnable = BiosPolicy.CdnEnableEnum.PlatformDefault;
            CdnSupport = BiosPolicy.CdnSupportEnum.PlatformDefault;
            ChannelInterLeave = BiosPolicy.ChannelInterLeaveEnum.PlatformDefault;
            CiscoAdaptiveMemTraining = BiosPolicy.CiscoAdaptiveMemTrainingEnum.PlatformDefault;
            CiscoDebugLevel = BiosPolicy.CiscoDebugLevelEnum.PlatformDefault;
            CiscoOpromLaunchOptimization = BiosPolicy.CiscoOpromLaunchOptimizationEnum.PlatformDefault;
            CiscoXgmiMaxSpeed = BiosPolicy.CiscoXgmiMaxSpeedEnum.PlatformDefault;
            CkeLowPolicy = BiosPolicy.CkeLowPolicyEnum.PlatformDefault;
            ClassId = BiosPolicy.ClassIdEnum.BiosPolicy;
            ClosedLoopThermThrotl = BiosPolicy.ClosedLoopThermThrotlEnum.PlatformDefault;
            CmciEnable = BiosPolicy.CmciEnableEnum.PlatformDefault;
            ConfigTdp = BiosPolicy.ConfigTdpEnum.PlatformDefault;
            ConfigTdpLevel = BiosPolicy.ConfigTdpLevelEnum.PlatformDefault;
            ConsoleRedirection = BiosPolicy.ConsoleRedirectionEnum.PlatformDefault;
            CoreMultiProcessing = BiosPolicy.CoreMultiProcessingEnum.PlatformDefault;
            CpuEnergyPerformance = BiosPolicy.CpuEnergyPerformanceEnum.PlatformDefault;
            CpuFrequencyFloor = BiosPolicy.CpuFrequencyFloorEnum.PlatformDefault;
            CpuPerfEnhancement = BiosPolicy.CpuPerfEnhancementEnum.PlatformDefault;
            CpuPerformance = BiosPolicy.CpuPerformanceEnum.PlatformDefault;
            CpuPowerManagement = BiosPolicy.CpuPowerManagementEnum.PlatformDefault;
            CrQos = BiosPolicy.CrQosEnum.PlatformDefault;
            CrfastgoConfig = BiosPolicy.CrfastgoConfigEnum.PlatformDefault;
            DcpmmFirmwareDowngrade = BiosPolicy.DcpmmFirmwareDowngradeEnum.PlatformDefault;
            DemandScrub = BiosPolicy.DemandScrubEnum.PlatformDefault;
            DirectCacheAccess = BiosPolicy.DirectCacheAccessEnum.PlatformDefault;
            DramClockThrottling = BiosPolicy.DramClockThrottlingEnum.PlatformDefault;
            DramRefreshRate = BiosPolicy.DramRefreshRateEnum.PlatformDefault;
            DramSwThermalThrottling = BiosPolicy.DramSwThermalThrottlingEnum.PlatformDefault;
            EadrSupport = BiosPolicy.EadrSupportEnum.PlatformDefault;
            EdpcEn = BiosPolicy.EdpcEnEnum.PlatformDefault;
            EnableClockSpreadSpec = BiosPolicy.EnableClockSpreadSpecEnum.PlatformDefault;
            EnableMktme = BiosPolicy.EnableMktmeEnum.PlatformDefault;
            EnableSgx = BiosPolicy.EnableSgxEnum.PlatformDefault;
            EnableTme = BiosPolicy.EnableTmeEnum.PlatformDefault;
            EnergyEfficientTurbo = BiosPolicy.EnergyEfficientTurboEnum.PlatformDefault;
            EngPerfTuning = BiosPolicy.EngPerfTuningEnum.PlatformDefault;
            EnhancedIntelSpeedStepTech = BiosPolicy.EnhancedIntelSpeedStepTechEnum.PlatformDefault;
            EpochUpdate = BiosPolicy.EpochUpdateEnum.PlatformDefault;
            EppEnable = BiosPolicy.EppEnableEnum.PlatformDefault;
            EppProfile = BiosPolicy.EppProfileEnum.PlatformDefault;
            ExecuteDisableBit = BiosPolicy.ExecuteDisableBitEnum.PlatformDefault;
            ExtendedApic = BiosPolicy.ExtendedApicEnum.PlatformDefault;
            FlowControl = BiosPolicy.FlowControlEnum.PlatformDefault;
            Frb2enable = BiosPolicy.Frb2enableEnum.PlatformDefault;
            HardwarePrefetch = BiosPolicy.HardwarePrefetchEnum.PlatformDefault;
            HwpmEnable = BiosPolicy.HwpmEnableEnum.PlatformDefault;
            ImcInterleave = BiosPolicy.ImcInterleaveEnum.PlatformDefault;
            IntelDynamicSpeedSelect = BiosPolicy.IntelDynamicSpeedSelectEnum.PlatformDefault;
            IntelHyperThreadingTech = BiosPolicy.IntelHyperThreadingTechEnum.PlatformDefault;
            IntelSpeedSelect = BiosPolicy.IntelSpeedSelectEnum.PlatformDefault;
            IntelTurboBoostTech = BiosPolicy.IntelTurboBoostTechEnum.PlatformDefault;
            IntelVirtualizationTechnology = BiosPolicy.IntelVirtualizationTechnologyEnum.PlatformDefault;
            IntelVtForDirectedIo = BiosPolicy.IntelVtForDirectedIoEnum.PlatformDefault;
            IntelVtdCoherencySupport = BiosPolicy.IntelVtdCoherencySupportEnum.PlatformDefault;
            IntelVtdInterruptRemapping = BiosPolicy.IntelVtdInterruptRemappingEnum.PlatformDefault;
            IntelVtdPassThroughDmaSupport = BiosPolicy.IntelVtdPassThroughDmaSupportEnum.PlatformDefault;
            IntelVtdatsSupport = BiosPolicy.IntelVtdatsSupportEnum.PlatformDefault;
            IohErrorEnable = BiosPolicy.IohErrorEnableEnum.PlatformDefault;
            IohResource = BiosPolicy.IohResourceEnum.PlatformDefault;
            IpPrefetch = BiosPolicy.IpPrefetchEnum.PlatformDefault;
            Ipv4http = BiosPolicy.Ipv4httpEnum.PlatformDefault;
            Ipv4pxe = BiosPolicy.Ipv4pxeEnum.PlatformDefault;
            Ipv6http = BiosPolicy.Ipv6httpEnum.PlatformDefault;
            Ipv6pxe = BiosPolicy.Ipv6pxeEnum.PlatformDefault;
            KtiPrefetch = BiosPolicy.KtiPrefetchEnum.PlatformDefault;
            LegacyOsRedirection = BiosPolicy.LegacyOsRedirectionEnum.PlatformDefault;
            LegacyUsbSupport = BiosPolicy.LegacyUsbSupportEnum.PlatformDefault;
            LlcAlloc = BiosPolicy.LlcAllocEnum.PlatformDefault;
            LlcPrefetch = BiosPolicy.LlcPrefetchEnum.PlatformDefault;
            LomPort0state = BiosPolicy.LomPort0stateEnum.PlatformDefault;
            LomPort1state = BiosPolicy.LomPort1stateEnum.PlatformDefault;
            LomPort2state = BiosPolicy.LomPort2stateEnum.PlatformDefault;
            LomPort3state = BiosPolicy.LomPort3stateEnum.PlatformDefault;
            LomPortsAllState = BiosPolicy.LomPortsAllStateEnum.PlatformDefault;
            LvDdrMode = BiosPolicy.LvDdrModeEnum.PlatformDefault;
            MakeDeviceNonBootable = BiosPolicy.MakeDeviceNonBootableEnum.PlatformDefault;
            MemoryBandwidthBoost = BiosPolicy.MemoryBandwidthBoostEnum.PlatformDefault;
            MemoryInterLeave = BiosPolicy.MemoryInterLeaveEnum.PlatformDefault;
            MemoryMappedIoAbove4gb = BiosPolicy.MemoryMappedIoAbove4gbEnum.PlatformDefault;
            MemoryRefreshRate = BiosPolicy.MemoryRefreshRateEnum.PlatformDefault;
            MemoryThermalThrottling = BiosPolicy.MemoryThermalThrottlingEnum.PlatformDefault;
            MirroringMode = BiosPolicy.MirroringModeEnum.PlatformDefault;
            MmcfgBase = BiosPolicy.MmcfgBaseEnum.PlatformDefault;
            NetworkStack = BiosPolicy.NetworkStackEnum.PlatformDefault;
            NumaOptimized = BiosPolicy.NumaOptimizedEnum.PlatformDefault;
            NvmdimmPerformConfig = BiosPolicy.NvmdimmPerformConfigEnum.PlatformDefault;
            ObjectType = BiosPolicy.ObjectTypeEnum.BiosPolicy;
            Onboard10gbitLom = BiosPolicy.Onboard10gbitLomEnum.PlatformDefault;
            OnboardGbitLom = BiosPolicy.OnboardGbitLomEnum.PlatformDefault;
            OnboardScuStorageSupport = BiosPolicy.OnboardScuStorageSupportEnum.PlatformDefault;
            OnboardScuStorageSwStack = BiosPolicy.OnboardScuStorageSwStackEnum.PlatformDefault;
            OperationMode = BiosPolicy.OperationModeEnum.PlatformDefault;
            OsBootWatchdogTimer = BiosPolicy.OsBootWatchdogTimerEnum.PlatformDefault;
            OsBootWatchdogTimerPolicy = BiosPolicy.OsBootWatchdogTimerPolicyEnum.PlatformDefault;
            OsBootWatchdogTimerTimeout = BiosPolicy.OsBootWatchdogTimerTimeoutEnum.PlatformDefault;
            OutOfBandMgmtPort = BiosPolicy.OutOfBandMgmtPortEnum.PlatformDefault;
            PackageCstateLimit = BiosPolicy.PackageCstateLimitEnum.PlatformDefault;
            PanicHighWatermark = BiosPolicy.PanicHighWatermarkEnum.PlatformDefault;
            PartialCacheLineSparing = BiosPolicy.PartialCacheLineSparingEnum.PlatformDefault;
            PartialMirrorModeConfig = BiosPolicy.PartialMirrorModeConfigEnum.PlatformDefault;
            PatrolScrub = BiosPolicy.PatrolScrubEnum.PlatformDefault;
            PcIeRasSupport = BiosPolicy.PcIeRasSupportEnum.PlatformDefault;
            PcIeSsdHotPlugSupport = BiosPolicy.PcIeSsdHotPlugSupportEnum.PlatformDefault;
            PchUsb30mode = BiosPolicy.PchUsb30modeEnum.PlatformDefault;
            PciOptionRoMs = BiosPolicy.PciOptionRoMsEnum.PlatformDefault;
            PciRomClp = BiosPolicy.PciRomClpEnum.PlatformDefault;
            PcieAriSupport = BiosPolicy.PcieAriSupportEnum.PlatformDefault;
            PciePllSsc = BiosPolicy.PciePllSscEnum.PlatformDefault;
            PcieSlotMraid1linkSpeed = BiosPolicy.PcieSlotMraid1linkSpeedEnum.PlatformDefault;
            PcieSlotMraid1optionRom = BiosPolicy.PcieSlotMraid1optionRomEnum.PlatformDefault;
            PcieSlotMraid2linkSpeed = BiosPolicy.PcieSlotMraid2linkSpeedEnum.PlatformDefault;
            PcieSlotMraid2optionRom = BiosPolicy.PcieSlotMraid2optionRomEnum.PlatformDefault;
            PcieSlotMstorraidLinkSpeed = BiosPolicy.PcieSlotMstorraidLinkSpeedEnum.PlatformDefault;
            PcieSlotMstorraidOptionRom = BiosPolicy.PcieSlotMstorraidOptionRomEnum.PlatformDefault;
            PcieSlotNvme1linkSpeed = BiosPolicy.PcieSlotNvme1linkSpeedEnum.PlatformDefault;
            PcieSlotNvme1optionRom = BiosPolicy.PcieSlotNvme1optionRomEnum.PlatformDefault;
            PcieSlotNvme2linkSpeed = BiosPolicy.PcieSlotNvme2linkSpeedEnum.PlatformDefault;
            PcieSlotNvme2optionRom = BiosPolicy.PcieSlotNvme2optionRomEnum.PlatformDefault;
            PcieSlotNvme3linkSpeed = BiosPolicy.PcieSlotNvme3linkSpeedEnum.PlatformDefault;
            PcieSlotNvme3optionRom = BiosPolicy.PcieSlotNvme3optionRomEnum.PlatformDefault;
            PcieSlotNvme4linkSpeed = BiosPolicy.PcieSlotNvme4linkSpeedEnum.PlatformDefault;
            PcieSlotNvme4optionRom = BiosPolicy.PcieSlotNvme4optionRomEnum.PlatformDefault;
            PcieSlotNvme5linkSpeed = BiosPolicy.PcieSlotNvme5linkSpeedEnum.PlatformDefault;
            PcieSlotNvme5optionRom = BiosPolicy.PcieSlotNvme5optionRomEnum.PlatformDefault;
            PcieSlotNvme6linkSpeed = BiosPolicy.PcieSlotNvme6linkSpeedEnum.PlatformDefault;
            PcieSlotNvme6optionRom = BiosPolicy.PcieSlotNvme6optionRomEnum.PlatformDefault;
            PcieSlotsCdnEnable = BiosPolicy.PcieSlotsCdnEnableEnum.PlatformDefault;
            PopSupport = BiosPolicy.PopSupportEnum.PlatformDefault;
            PostErrorPause = BiosPolicy.PostErrorPauseEnum.PlatformDefault;
            PostPackageRepair = BiosPolicy.PostPackageRepairEnum.PlatformDefault;
            ProcessorC1e = BiosPolicy.ProcessorC1eEnum.PlatformDefault;
            ProcessorC3report = BiosPolicy.ProcessorC3reportEnum.PlatformDefault;
            ProcessorC6report = BiosPolicy.ProcessorC6reportEnum.PlatformDefault;
            ProcessorCstate = BiosPolicy.ProcessorCstateEnum.PlatformDefault;
            Psata = BiosPolicy.PsataEnum.PlatformDefault;
            PstateCoordType = BiosPolicy.PstateCoordTypeEnum.PlatformDefault;
            PuttyKeyPad = BiosPolicy.PuttyKeyPadEnum.PlatformDefault;
            PwrPerfTuning = BiosPolicy.PwrPerfTuningEnum.PlatformDefault;
            QpiLinkFrequency = BiosPolicy.QpiLinkFrequencyEnum.PlatformDefault;
            QpiLinkSpeed = BiosPolicy.QpiLinkSpeedEnum.PlatformDefault;
            QpiSnoopMode = BiosPolicy.QpiSnoopModeEnum.PlatformDefault;
            RankInterLeave = BiosPolicy.RankInterLeaveEnum.PlatformDefault;
            RedirectionAfterPost = BiosPolicy.RedirectionAfterPostEnum.PlatformDefault;
            SataModeSelect = BiosPolicy.SataModeSelectEnum.PlatformDefault;
            SelectMemoryRasConfiguration = BiosPolicy.SelectMemoryRasConfigurationEnum.PlatformDefault;
            SelectPprType = BiosPolicy.SelectPprTypeEnum.PlatformDefault;
            SerialPortAenable = BiosPolicy.SerialPortAenableEnum.PlatformDefault;
            Sev = BiosPolicy.SevEnum.PlatformDefault;
            SgxAutoRegistrationAgent = BiosPolicy.SgxAutoRegistrationAgentEnum.PlatformDefault;
            SgxFactoryReset = BiosPolicy.SgxFactoryResetEnum.PlatformDefault;
            SgxLeWr = BiosPolicy.SgxLeWrEnum.PlatformDefault;
            SgxPackageInfoInBandAccess = BiosPolicy.SgxPackageInfoInBandAccessEnum.PlatformDefault;
            SgxQos = BiosPolicy.SgxQosEnum.PlatformDefault;
            Sha1pcrBank = BiosPolicy.Sha1pcrBankEnum.PlatformDefault;
            Sha256pcrBank = BiosPolicy.Sha256pcrBankEnum.PlatformDefault;
            SinglePctlEnable = BiosPolicy.SinglePctlEnableEnum.PlatformDefault;
            Slot10linkSpeed = BiosPolicy.Slot10linkSpeedEnum.PlatformDefault;
            Slot10state = BiosPolicy.Slot10stateEnum.PlatformDefault;
            Slot11linkSpeed = BiosPolicy.Slot11linkSpeedEnum.PlatformDefault;
            Slot11state = BiosPolicy.Slot11stateEnum.PlatformDefault;
            Slot12linkSpeed = BiosPolicy.Slot12linkSpeedEnum.PlatformDefault;
            Slot12state = BiosPolicy.Slot12stateEnum.PlatformDefault;
            Slot13state = BiosPolicy.Slot13stateEnum.PlatformDefault;
            Slot14state = BiosPolicy.Slot14stateEnum.PlatformDefault;
            Slot1linkSpeed = BiosPolicy.Slot1linkSpeedEnum.PlatformDefault;
            Slot1state = BiosPolicy.Slot1stateEnum.PlatformDefault;
            Slot2linkSpeed = BiosPolicy.Slot2linkSpeedEnum.PlatformDefault;
            Slot2state = BiosPolicy.Slot2stateEnum.PlatformDefault;
            Slot3linkSpeed = BiosPolicy.Slot3linkSpeedEnum.PlatformDefault;
            Slot3state = BiosPolicy.Slot3stateEnum.PlatformDefault;
            Slot4linkSpeed = BiosPolicy.Slot4linkSpeedEnum.PlatformDefault;
            Slot4state = BiosPolicy.Slot4stateEnum.PlatformDefault;
            Slot5linkSpeed = BiosPolicy.Slot5linkSpeedEnum.PlatformDefault;
            Slot5state = BiosPolicy.Slot5stateEnum.PlatformDefault;
            Slot6linkSpeed = BiosPolicy.Slot6linkSpeedEnum.PlatformDefault;
            Slot6state = BiosPolicy.Slot6stateEnum.PlatformDefault;
            Slot7linkSpeed = BiosPolicy.Slot7linkSpeedEnum.PlatformDefault;
            Slot7state = BiosPolicy.Slot7stateEnum.PlatformDefault;
            Slot8linkSpeed = BiosPolicy.Slot8linkSpeedEnum.PlatformDefault;
            Slot8state = BiosPolicy.Slot8stateEnum.PlatformDefault;
            Slot9linkSpeed = BiosPolicy.Slot9linkSpeedEnum.PlatformDefault;
            Slot9state = BiosPolicy.Slot9stateEnum.PlatformDefault;
            SlotFlomLinkSpeed = BiosPolicy.SlotFlomLinkSpeedEnum.PlatformDefault;
            SlotFrontNvme10linkSpeed = BiosPolicy.SlotFrontNvme10linkSpeedEnum.PlatformDefault;
            SlotFrontNvme10optionRom = BiosPolicy.SlotFrontNvme10optionRomEnum.PlatformDefault;
            SlotFrontNvme11linkSpeed = BiosPolicy.SlotFrontNvme11linkSpeedEnum.PlatformDefault;
            SlotFrontNvme11optionRom = BiosPolicy.SlotFrontNvme11optionRomEnum.PlatformDefault;
            SlotFrontNvme12linkSpeed = BiosPolicy.SlotFrontNvme12linkSpeedEnum.PlatformDefault;
            SlotFrontNvme12optionRom = BiosPolicy.SlotFrontNvme12optionRomEnum.PlatformDefault;
            SlotFrontNvme13optionRom = BiosPolicy.SlotFrontNvme13optionRomEnum.PlatformDefault;
            SlotFrontNvme14optionRom = BiosPolicy.SlotFrontNvme14optionRomEnum.PlatformDefault;
            SlotFrontNvme15optionRom = BiosPolicy.SlotFrontNvme15optionRomEnum.PlatformDefault;
            SlotFrontNvme16optionRom = BiosPolicy.SlotFrontNvme16optionRomEnum.PlatformDefault;
            SlotFrontNvme17optionRom = BiosPolicy.SlotFrontNvme17optionRomEnum.PlatformDefault;
            SlotFrontNvme18optionRom = BiosPolicy.SlotFrontNvme18optionRomEnum.PlatformDefault;
            SlotFrontNvme19optionRom = BiosPolicy.SlotFrontNvme19optionRomEnum.PlatformDefault;
            SlotFrontNvme1linkSpeed = BiosPolicy.SlotFrontNvme1linkSpeedEnum.PlatformDefault;
            SlotFrontNvme1optionRom = BiosPolicy.SlotFrontNvme1optionRomEnum.PlatformDefault;
            SlotFrontNvme20optionRom = BiosPolicy.SlotFrontNvme20optionRomEnum.PlatformDefault;
            SlotFrontNvme21optionRom = BiosPolicy.SlotFrontNvme21optionRomEnum.PlatformDefault;
            SlotFrontNvme22optionRom = BiosPolicy.SlotFrontNvme22optionRomEnum.PlatformDefault;
            SlotFrontNvme23optionRom = BiosPolicy.SlotFrontNvme23optionRomEnum.PlatformDefault;
            SlotFrontNvme24optionRom = BiosPolicy.SlotFrontNvme24optionRomEnum.PlatformDefault;
            SlotFrontNvme2linkSpeed = BiosPolicy.SlotFrontNvme2linkSpeedEnum.PlatformDefault;
            SlotFrontNvme2optionRom = BiosPolicy.SlotFrontNvme2optionRomEnum.PlatformDefault;
            SlotFrontNvme3linkSpeed = BiosPolicy.SlotFrontNvme3linkSpeedEnum.PlatformDefault;
            SlotFrontNvme3optionRom = BiosPolicy.SlotFrontNvme3optionRomEnum.PlatformDefault;
            SlotFrontNvme4linkSpeed = BiosPolicy.SlotFrontNvme4linkSpeedEnum.PlatformDefault;
            SlotFrontNvme4optionRom = BiosPolicy.SlotFrontNvme4optionRomEnum.PlatformDefault;
            SlotFrontNvme5linkSpeed = BiosPolicy.SlotFrontNvme5linkSpeedEnum.PlatformDefault;
            SlotFrontNvme5optionRom = BiosPolicy.SlotFrontNvme5optionRomEnum.PlatformDefault;
            SlotFrontNvme6linkSpeed = BiosPolicy.SlotFrontNvme6linkSpeedEnum.PlatformDefault;
            SlotFrontNvme6optionRom = BiosPolicy.SlotFrontNvme6optionRomEnum.PlatformDefault;
            SlotFrontNvme7linkSpeed = BiosPolicy.SlotFrontNvme7linkSpeedEnum.PlatformDefault;
            SlotFrontNvme7optionRom = BiosPolicy.SlotFrontNvme7optionRomEnum.PlatformDefault;
            SlotFrontNvme8linkSpeed = BiosPolicy.SlotFrontNvme8linkSpeedEnum.PlatformDefault;
            SlotFrontNvme8optionRom = BiosPolicy.SlotFrontNvme8optionRomEnum.PlatformDefault;
            SlotFrontNvme9linkSpeed = BiosPolicy.SlotFrontNvme9linkSpeedEnum.PlatformDefault;
            SlotFrontNvme9optionRom = BiosPolicy.SlotFrontNvme9optionRomEnum.PlatformDefault;
            SlotFrontSlot5linkSpeed = BiosPolicy.SlotFrontSlot5linkSpeedEnum.PlatformDefault;
            SlotFrontSlot6linkSpeed = BiosPolicy.SlotFrontSlot6linkSpeedEnum.PlatformDefault;
            SlotGpu1state = BiosPolicy.SlotGpu1stateEnum.PlatformDefault;
            SlotGpu2state = BiosPolicy.SlotGpu2stateEnum.PlatformDefault;
            SlotGpu3state = BiosPolicy.SlotGpu3stateEnum.PlatformDefault;
            SlotGpu4state = BiosPolicy.SlotGpu4stateEnum.PlatformDefault;
            SlotGpu5state = BiosPolicy.SlotGpu5stateEnum.PlatformDefault;
            SlotGpu6state = BiosPolicy.SlotGpu6stateEnum.PlatformDefault;
            SlotGpu7state = BiosPolicy.SlotGpu7stateEnum.PlatformDefault;
            SlotGpu8state = BiosPolicy.SlotGpu8stateEnum.PlatformDefault;
            SlotHbaLinkSpeed = BiosPolicy.SlotHbaLinkSpeedEnum.PlatformDefault;
            SlotHbaState = BiosPolicy.SlotHbaStateEnum.PlatformDefault;
            SlotLom1link = BiosPolicy.SlotLom1linkEnum.PlatformDefault;
            SlotLom2link = BiosPolicy.SlotLom2linkEnum.PlatformDefault;
            SlotMezzState = BiosPolicy.SlotMezzStateEnum.PlatformDefault;
            SlotMlomLinkSpeed = BiosPolicy.SlotMlomLinkSpeedEnum.PlatformDefault;
            SlotMlomState = BiosPolicy.SlotMlomStateEnum.PlatformDefault;
            SlotMraidLinkSpeed = BiosPolicy.SlotMraidLinkSpeedEnum.PlatformDefault;
            SlotMraidState = BiosPolicy.SlotMraidStateEnum.PlatformDefault;
            SlotN10state = BiosPolicy.SlotN10stateEnum.PlatformDefault;
            SlotN11state = BiosPolicy.SlotN11stateEnum.PlatformDefault;
            SlotN12state = BiosPolicy.SlotN12stateEnum.PlatformDefault;
            SlotN13state = BiosPolicy.SlotN13stateEnum.PlatformDefault;
            SlotN14state = BiosPolicy.SlotN14stateEnum.PlatformDefault;
            SlotN15state = BiosPolicy.SlotN15stateEnum.PlatformDefault;
            SlotN16state = BiosPolicy.SlotN16stateEnum.PlatformDefault;
            SlotN17state = BiosPolicy.SlotN17stateEnum.PlatformDefault;
            SlotN18state = BiosPolicy.SlotN18stateEnum.PlatformDefault;
            SlotN19state = BiosPolicy.SlotN19stateEnum.PlatformDefault;
            SlotN1state = BiosPolicy.SlotN1stateEnum.PlatformDefault;
            SlotN20state = BiosPolicy.SlotN20stateEnum.PlatformDefault;
            SlotN21state = BiosPolicy.SlotN21stateEnum.PlatformDefault;
            SlotN22state = BiosPolicy.SlotN22stateEnum.PlatformDefault;
            SlotN23state = BiosPolicy.SlotN23stateEnum.PlatformDefault;
            SlotN24state = BiosPolicy.SlotN24stateEnum.PlatformDefault;
            SlotN2state = BiosPolicy.SlotN2stateEnum.PlatformDefault;
            SlotN3state = BiosPolicy.SlotN3stateEnum.PlatformDefault;
            SlotN4state = BiosPolicy.SlotN4stateEnum.PlatformDefault;
            SlotN5state = BiosPolicy.SlotN5stateEnum.PlatformDefault;
            SlotN6state = BiosPolicy.SlotN6stateEnum.PlatformDefault;
            SlotN7state = BiosPolicy.SlotN7stateEnum.PlatformDefault;
            SlotN8state = BiosPolicy.SlotN8stateEnum.PlatformDefault;
            SlotN9state = BiosPolicy.SlotN9stateEnum.PlatformDefault;
            SlotRaidLinkSpeed = BiosPolicy.SlotRaidLinkSpeedEnum.PlatformDefault;
            SlotRaidState = BiosPolicy.SlotRaidStateEnum.PlatformDefault;
            SlotRearNvme1linkSpeed = BiosPolicy.SlotRearNvme1linkSpeedEnum.PlatformDefault;
            SlotRearNvme1state = BiosPolicy.SlotRearNvme1stateEnum.PlatformDefault;
            SlotRearNvme2linkSpeed = BiosPolicy.SlotRearNvme2linkSpeedEnum.PlatformDefault;
            SlotRearNvme2state = BiosPolicy.SlotRearNvme2stateEnum.PlatformDefault;
            SlotRearNvme3linkSpeed = BiosPolicy.SlotRearNvme3linkSpeedEnum.PlatformDefault;
            SlotRearNvme3state = BiosPolicy.SlotRearNvme3stateEnum.PlatformDefault;
            SlotRearNvme4linkSpeed = BiosPolicy.SlotRearNvme4linkSpeedEnum.PlatformDefault;
            SlotRearNvme4state = BiosPolicy.SlotRearNvme4stateEnum.PlatformDefault;
            SlotRearNvme5state = BiosPolicy.SlotRearNvme5stateEnum.PlatformDefault;
            SlotRearNvme6state = BiosPolicy.SlotRearNvme6stateEnum.PlatformDefault;
            SlotRearNvme7state = BiosPolicy.SlotRearNvme7stateEnum.PlatformDefault;
            SlotRearNvme8state = BiosPolicy.SlotRearNvme8stateEnum.PlatformDefault;
            SlotRiser1linkSpeed = BiosPolicy.SlotRiser1linkSpeedEnum.PlatformDefault;
            SlotRiser1slot1linkSpeed = BiosPolicy.SlotRiser1slot1linkSpeedEnum.PlatformDefault;
            SlotRiser1slot2linkSpeed = BiosPolicy.SlotRiser1slot2linkSpeedEnum.PlatformDefault;
            SlotRiser1slot3linkSpeed = BiosPolicy.SlotRiser1slot3linkSpeedEnum.PlatformDefault;
            SlotRiser2linkSpeed = BiosPolicy.SlotRiser2linkSpeedEnum.PlatformDefault;
            SlotRiser2slot4linkSpeed = BiosPolicy.SlotRiser2slot4linkSpeedEnum.PlatformDefault;
            SlotRiser2slot5linkSpeed = BiosPolicy.SlotRiser2slot5linkSpeedEnum.PlatformDefault;
            SlotRiser2slot6linkSpeed = BiosPolicy.SlotRiser2slot6linkSpeedEnum.PlatformDefault;
            SlotSasState = BiosPolicy.SlotSasStateEnum.PlatformDefault;
            SlotSsdSlot1linkSpeed = BiosPolicy.SlotSsdSlot1linkSpeedEnum.PlatformDefault;
            SlotSsdSlot2linkSpeed = BiosPolicy.SlotSsdSlot2linkSpeedEnum.PlatformDefault;
            Smee = BiosPolicy.SmeeEnum.PlatformDefault;
            SmtMode = BiosPolicy.SmtModeEnum.PlatformDefault;
            Snc = BiosPolicy.SncEnum.PlatformDefault;
            SnoopyModeFor2lm = BiosPolicy.SnoopyModeFor2lmEnum.PlatformDefault;
            SnoopyModeForAd = BiosPolicy.SnoopyModeForAdEnum.PlatformDefault;
            SparingMode = BiosPolicy.SparingModeEnum.PlatformDefault;
            SrIov = BiosPolicy.SrIovEnum.PlatformDefault;
            StreamerPrefetch = BiosPolicy.StreamerPrefetchEnum.PlatformDefault;
            SvmMode = BiosPolicy.SvmModeEnum.PlatformDefault;
            TerminalType = BiosPolicy.TerminalTypeEnum.PlatformDefault;
            TpmControl = BiosPolicy.TpmControlEnum.PlatformDefault;
            TpmPendingOperation = BiosPolicy.TpmPendingOperationEnum.PlatformDefault;
            TpmSupport = BiosPolicy.TpmSupportEnum.PlatformDefault;
            Tsme = BiosPolicy.TsmeEnum.PlatformDefault;
            TxtSupport = BiosPolicy.TxtSupportEnum.PlatformDefault;
            UcsmBootOrderRule = BiosPolicy.UcsmBootOrderRuleEnum.PlatformDefault;
            UfsDisable = BiosPolicy.UfsDisableEnum.PlatformDefault;
            UmaBasedClustering = BiosPolicy.UmaBasedClusteringEnum.PlatformDefault;
            UpiLinkEnablement = BiosPolicy.UpiLinkEnablementEnum.PlatformDefault;
            UpiPowerManagement = BiosPolicy.UpiPowerManagementEnum.PlatformDefault;
            UsbEmul6064 = BiosPolicy.UsbEmul6064Enum.PlatformDefault;
            UsbPortFront = BiosPolicy.UsbPortFrontEnum.PlatformDefault;
            UsbPortInternal = BiosPolicy.UsbPortInternalEnum.PlatformDefault;
            UsbPortKvm = BiosPolicy.UsbPortKvmEnum.PlatformDefault;
            UsbPortRear = BiosPolicy.UsbPortRearEnum.PlatformDefault;
            UsbPortSdCard = BiosPolicy.UsbPortSdCardEnum.PlatformDefault;
            UsbPortVmedia = BiosPolicy.UsbPortVmediaEnum.PlatformDefault;
            UsbXhciSupport = BiosPolicy.UsbXhciSupportEnum.PlatformDefault;
            VgaPriority = BiosPolicy.VgaPriorityEnum.PlatformDefault;
            VirtualNuma = BiosPolicy.VirtualNumaEnum.PlatformDefault;
            VmdEnable = BiosPolicy.VmdEnableEnum.PlatformDefault;
            VolMemoryMode = BiosPolicy.VolMemoryModeEnum.PlatformDefault;
            WorkLoadConfig = BiosPolicy.WorkLoadConfigEnum.PlatformDefault;
            XptPrefetch = BiosPolicy.XptPrefetchEnum.PlatformDefault;
            XptRemotePrefetch = BiosPolicy.XptRemotePrefetchEnum.PlatformDefault;

        }
        // <summary>
        /// <para type="description">"BIOS Token for setting ACS Control GPU 1 configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.AcsControlGpu1stateEnum AcsControlGpu1state
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting ACS Control GPU 2 configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.AcsControlGpu2stateEnum AcsControlGpu2state
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting ACS Control GPU 3 configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.AcsControlGpu3stateEnum AcsControlGpu3state
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting ACS Control GPU 4 configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.AcsControlGpu4stateEnum AcsControlGpu4state
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting ACS Control GPU 5 configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.AcsControlGpu5stateEnum AcsControlGpu5state
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting ACS Control GPU 6 configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.AcsControlGpu6stateEnum AcsControlGpu6state
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting ACS Control GPU 7 configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.AcsControlGpu7stateEnum AcsControlGpu7state
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting ACS Control GPU 8 configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.AcsControlGpu8stateEnum AcsControlGpu8state
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting ACS Control Slot 11 configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.AcsControlSlot11stateEnum AcsControlSlot11state
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting ACS Control Slot 12 configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.AcsControlSlot12stateEnum AcsControlSlot12state
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting ACS Control Slot 13 configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.AcsControlSlot13stateEnum AcsControlSlot13state
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting ACS Control Slot 14 configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.AcsControlSlot14stateEnum AcsControlSlot14state
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Adjacent Cache Line Prefetcher configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.AdjacentCacheLinePrefetchEnum AdjacentCacheLinePrefetch
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Enhanced Memory Test configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring AdvancedMemTest token.\n* `disabled` - Value - disabled for configuring AdvancedMemTest token.\n* `enabled` - Value - enabled for configuring AdvancedMemTest token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.AdvancedMemTestEnum AdvancedMemTest
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting All USB Devices configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.AllUsbDevicesEnum AllUsbDevices
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Altitude configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `300-m` - Value - 300-m for configuring Altitude token.\n* `900-m` - Value - 900-m for configuring Altitude token.\n* `1500-m` - Value - 1500-m for configuring Altitude token.\n* `3000-m` - Value - 3000-m for configuring Altitude token.\n* `auto` - Value - auto for configuring Altitude token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.AltitudeEnum Altitude
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting ASPM Support configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring AspmSupport token.\n* `Disabled` - Value - Disabled for configuring AspmSupport token.\n* `Force L0s` - Value - Force L0s for configuring AspmSupport token.\n* `L1 Only` - Value - L1 Only for configuring AspmSupport token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.AspmSupportEnum AspmSupport
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Assert NMI on PERR configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.AssertNmiOnPerrEnum AssertNmiOnPerr
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Assert NMI on SERR configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.AssertNmiOnSerrEnum AssertNmiOnSerr
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Autonomous Core C State configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.AutoCcStateEnum AutoCcState
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting CPU Autonomous C State configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.AutonumousCstateEnableEnum AutonumousCstateEnable
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Baud Rate configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `9600` - Value - 9600 for configuring BaudRate token.\n* `19200` - Value - 19200 for configuring BaudRate token.\n* `38400` - Value - 38400 for configuring BaudRate token.\n* `57600` - Value - 57600 for configuring BaudRate token.\n* `115200` - Value - 115200 for configuring BaudRate token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.BaudRateEnum BaudRate
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting BME DMA Mitigation configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.BmeDmaMitigationEnum BmeDmaMitigation
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Number of Retries configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `5` - Value - 5 for configuring BootOptionNumRetry token.\n* `13` - Value - 13 for configuring BootOptionNumRetry token.\n* `Infinite` - Value - Infinite for configuring BootOptionNumRetry token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.BootOptionNumRetryEnum BootOptionNumRetry
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Cool Down Time  (sec) configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `15` - Value - 15 for configuring BootOptionReCoolDown token.\n* `45` - Value - 45 for configuring BootOptionReCoolDown token.\n* `90` - Value - 90 for configuring BootOptionReCoolDown token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.BootOptionReCoolDownEnum BootOptionReCoolDown
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Boot Option Retry configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.BootOptionRetryEnum BootOptionRetry
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Boot Performance Mode configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Max Efficient` - Value - Max Efficient for configuring BootPerformanceMode token.\n* `Max Performance` - Value - Max Performance for configuring BootPerformanceMode token.\n* `Set by Intel NM` - Value - Set by Intel NM for configuring BootPerformanceMode token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.BootPerformanceModeEnum BootPerformanceMode
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Burst and Postponed Refresh configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.BurstAndPostponedRefreshEnum BurstAndPostponedRefresh
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting C1 Auto Demotion configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.C1autoDemotionEnum C1autoDemotion
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting C1 Auto UnDemotion configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.C1autoUnDemotionEnum C1autoUnDemotion
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting APBDIS configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `0` - Value - 0 for configuring CbsCmnApbdis token.\n* `1` - Value - 1 for configuring CbsCmnApbdis token.\n* `Auto` - Value - Auto for configuring CbsCmnApbdis token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.CbsCmnApbdisEnum CbsCmnApbdis
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Core Performance Boost configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring CbsCmnCpuCpb token.\n* `disabled` - Value - disabled for configuring CbsCmnCpuCpb token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.CbsCmnCpuCpbEnum CbsCmnCpuCpb
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Downcore Control configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring CbsCmnCpuGenDowncoreCtrl token.\n* `FOUR (2 + 2)` - Value - FOUR (2 + 2) for configuring CbsCmnCpuGenDowncoreCtrl token.\n* `FOUR (4 + 0)` - Value - FOUR (4 + 0) for configuring CbsCmnCpuGenDowncoreCtrl token.\n* `SIX (3 + 3)` - Value - SIX (3 + 3) for configuring CbsCmnCpuGenDowncoreCtrl token.\n* `THREE (3 + 0)` - Value - THREE (3 + 0) for configuring CbsCmnCpuGenDowncoreCtrl token.\n* `TWO (1 + 1)` - Value - TWO (1 + 1) for configuring CbsCmnCpuGenDowncoreCtrl token.\n* `TWO (2 + 0)` - Value - TWO (2 + 0) for configuring CbsCmnCpuGenDowncoreCtrl token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.CbsCmnCpuGenDowncoreCtrlEnum CbsCmnCpuGenDowncoreCtrl
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Global C State Control configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring CbsCmnCpuGlobalCstateCtrl token.\n* `disabled` - Value - disabled for configuring CbsCmnCpuGlobalCstateCtrl token.\n* `enabled` - Value - enabled for configuring CbsCmnCpuGlobalCstateCtrl token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.CbsCmnCpuGlobalCstateCtrlEnum CbsCmnCpuGlobalCstateCtrl
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting L1 Stream HW Prefetcher configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring CbsCmnCpuL1streamHwPrefetcher token.\n* `disabled` - Value - disabled for configuring CbsCmnCpuL1streamHwPrefetcher token.\n* `enabled` - Value - enabled for configuring CbsCmnCpuL1streamHwPrefetcher token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.CbsCmnCpuL1streamHwPrefetcherEnum CbsCmnCpuL1streamHwPrefetcher
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting L2 Stream HW Prefetcher configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring CbsCmnCpuL2streamHwPrefetcher token.\n* `disabled` - Value - disabled for configuring CbsCmnCpuL2streamHwPrefetcher token.\n* `enabled` - Value - enabled for configuring CbsCmnCpuL2streamHwPrefetcher token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.CbsCmnCpuL2streamHwPrefetcherEnum CbsCmnCpuL2streamHwPrefetcher
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting CPU SMEE configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring CbsCmnCpuSmee token.\n* `disabled` - Value - disabled for configuring CbsCmnCpuSmee token.\n* `enabled` - Value - enabled for configuring CbsCmnCpuSmee token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.CbsCmnCpuSmeeEnum CbsCmnCpuSmee
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Streaming Stores Control configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring CbsCmnCpuStreamingStoresCtrl token.\n* `disabled` - Value - disabled for configuring CbsCmnCpuStreamingStoresCtrl token.\n* `enabled` - Value - enabled for configuring CbsCmnCpuStreamingStoresCtrl token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.CbsCmnCpuStreamingStoresCtrlEnum CbsCmnCpuStreamingStoresCtrl
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Determinism Slider configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring CbsCmnDeterminismSlider token.\n* `Performance` - Value - Performance for configuring CbsCmnDeterminismSlider token.\n* `Power` - Value - Power for configuring CbsCmnDeterminismSlider token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.CbsCmnDeterminismSliderEnum CbsCmnDeterminismSlider
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Efficiency Mode Enable configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring CbsCmnEfficiencyModeEn token.\n* `Enabled` - Value - Enabled for configuring CbsCmnEfficiencyModeEn token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.CbsCmnEfficiencyModeEnEnum CbsCmnEfficiencyModeEn
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Fixed SOC P-State configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring CbsCmnFixedSocPstate token.\n* `P0` - Value - P0 for configuring CbsCmnFixedSocPstate token.\n* `P1` - Value - P1 for configuring CbsCmnFixedSocPstate token.\n* `P2` - Value - P2 for configuring CbsCmnFixedSocPstate token.\n* `P3` - Value - P3 for configuring CbsCmnFixedSocPstate token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.CbsCmnFixedSocPstateEnum CbsCmnFixedSocPstate
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting IOMMU configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring CbsCmnGnbNbIommu token.\n* `disabled` - Value - disabled for configuring CbsCmnGnbNbIommu token.\n* `enabled` - Value - enabled for configuring CbsCmnGnbNbIommu token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.CbsCmnGnbNbIommuEnum CbsCmnGnbNbIommu
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting DF C-States configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring CbsCmnGnbSmuDfCstates token.\n* `disabled` - Value - disabled for configuring CbsCmnGnbSmuDfCstates token.\n* `enabled` - Value - enabled for configuring CbsCmnGnbSmuDfCstates token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.CbsCmnGnbSmuDfCstatesEnum CbsCmnGnbSmuDfCstates
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting CPPC configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring CbsCmnGnbSmucppc token.\n* `disabled` - Value - disabled for configuring CbsCmnGnbSmucppc token.\n* `enabled` - Value - enabled for configuring CbsCmnGnbSmucppc token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.CbsCmnGnbSmucppcEnum CbsCmnGnbSmucppc
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Bank Group Swap configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring CbsCmnMemCtrlBankGroupSwapDdr4 token.\n* `disabled` - Value - disabled for configuring CbsCmnMemCtrlBankGroupSwapDdr4 token.\n* `enabled` - Value - enabled for configuring CbsCmnMemCtrlBankGroupSwapDdr4 token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.CbsCmnMemCtrlBankGroupSwapDdr4Enum CbsCmnMemCtrlBankGroupSwapDdr4
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Chipset Interleave configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring CbsCmnMemMapBankInterleaveDdr4 token.\n* `disabled` - Value - disabled for configuring CbsCmnMemMapBankInterleaveDdr4 token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.CbsCmnMemMapBankInterleaveDdr4Enum CbsCmnMemMapBankInterleaveDdr4
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting cTDP Control configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring CbsCmncTdpCtl token.\n* `Manual` - Value - Manual for configuring CbsCmncTdpCtl token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.CbsCmncTdpCtlEnum CbsCmncTdpCtl
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting CCD Control configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `2 CCDs` - Value - 2 CCDs for configuring CbsCpuCcdCtrlSsp token.\n* `3 CCDs` - Value - 3 CCDs for configuring CbsCpuCcdCtrlSsp token.\n* `4 CCDs` - Value - 4 CCDs for configuring CbsCpuCcdCtrlSsp token.\n* `6 CCDs` - Value - 6 CCDs for configuring CbsCpuCcdCtrlSsp token.\n* `Auto` - Value - Auto for configuring CbsCpuCcdCtrlSsp token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.CbsCpuCcdCtrlSspEnum CbsCpuCcdCtrlSsp
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting CPU Downcore control configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring CbsCpuCoreCtrl token.\n* `FIVE (5 + 0)` - Value - FIVE (5 + 0) for configuring CbsCpuCoreCtrl token.\n* `FOUR (4 + 0)` - Value - FOUR (4 + 0) for configuring CbsCpuCoreCtrl token.\n* `ONE (1 + 0)` - Value - ONE (1 + 0) for configuring CbsCpuCoreCtrl token.\n* `SEVEN (7 + 0)` - Value - SEVEN (7 + 0) for configuring CbsCpuCoreCtrl token.\n* `SIX (6 + 0)` - Value - SIX (6 + 0) for configuring CbsCpuCoreCtrl token.\n* `THREE (3 + 0)` - Value - THREE (3 + 0) for configuring CbsCpuCoreCtrl token.\n* `TWO (2 + 0)` - Value - TWO (2 + 0) for configuring CbsCpuCoreCtrl token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.CbsCpuCoreCtrlEnum CbsCpuCoreCtrl
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting CPU SMT Mode configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring CbsCpuSmtCtrl token.\n* `disabled` - Value - disabled for configuring CbsCpuSmtCtrl token.\n* `enabled` - Value - enabled for configuring CbsCpuSmtCtrl token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.CbsCpuSmtCtrlEnum CbsCpuSmtCtrl
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting SNP Memory Coverage configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring CbsDbgCpuSnpMemCover token.\n* `Custom` - Value - Custom for configuring CbsDbgCpuSnpMemCover token.\n* `disabled` - Value - disabled for configuring CbsDbgCpuSnpMemCover token.\n* `enabled` - Value - enabled for configuring CbsDbgCpuSnpMemCover token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.CbsDbgCpuSnpMemCoverEnum CbsDbgCpuSnpMemCover
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting SNP Memory Size to Cover in MiB configuration (0 - 1048576 MiB)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^(\\d|[1-9]\\d|[1-9]\\d{2}|[1-9]\\d{3}|[1-9]\\d{4}|[1-9]\\d{5}|10[0-3]\\d{4}|104[0-7]\\d{3}|1048[0-4]\\d{2}|10485[0-6]\\d|104857[0-6])$|^(platform-default)$")]
        public string CbsDbgCpuSnpMemSizeCover
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting ACPI SRAT L3 Cache As NUMA Domain configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring CbsDfCmnAcpiSratL3numa token.\n* `disabled` - Value - disabled for configuring CbsDfCmnAcpiSratL3numa token.\n* `enabled` - Value - enabled for configuring CbsDfCmnAcpiSratL3numa token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.CbsDfCmnAcpiSratL3numaEnum CbsDfCmnAcpiSratL3numa
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting NUMA Nodes per Socket configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring CbsDfCmnDramNps token.\n* `NPS0` - Value - NPS0 for configuring CbsDfCmnDramNps token.\n* `NPS1` - Value - NPS1 for configuring CbsDfCmnDramNps token.\n* `NPS2` - Value - NPS2 for configuring CbsDfCmnDramNps token.\n* `NPS4` - Value - NPS4 for configuring CbsDfCmnDramNps token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.CbsDfCmnDramNpsEnum CbsDfCmnDramNps
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting AMD Memory Interleaving configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring CbsDfCmnMemIntlv token.\n* `Channel` - Value - Channel for configuring CbsDfCmnMemIntlv token.\n* `Die` - Value - Die for configuring CbsDfCmnMemIntlv token.\n* `None` - Value - None for configuring CbsDfCmnMemIntlv token.\n* `Socket` - Value - Socket for configuring CbsDfCmnMemIntlv token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.CbsDfCmnMemIntlvEnum CbsDfCmnMemIntlv
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting AMD Memory Interleaving Size configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `256 Bytes` - Value - 256 Bytes for configuring CbsDfCmnMemIntlvSize token.\n* `512 Bytes` - Value - 512 Bytes for configuring CbsDfCmnMemIntlvSize token.\n* `1 KB` - Value - 1 KiB for configuring CbsDfCmnMemIntlvSize token.\n* `2 KB` - Value - 2 KiB for configuring CbsDfCmnMemIntlvSize token.\n* `4 KB` - Value - 4 KiB for configuring CbsDfCmnMemIntlvSize token.\n* `Auto` - Value - Auto for configuring CbsDfCmnMemIntlvSize token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.CbsDfCmnMemIntlvSizeEnum CbsDfCmnMemIntlvSize
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting SEV-SNP Support configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.CbsSevSnpSupportEnum CbsSevSnpSupport
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Consistent Device Naming configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.CdnEnableEnum CdnEnable
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting CDN Support for LOM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `disabled` - Value - disabled for configuring CdnSupport token.\n* `enabled` - Value - enabled for configuring CdnSupport token.\n* `LOMs Only` - Value - LOMs Only for configuring CdnSupport token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.CdnSupportEnum CdnSupport
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Channel Interleaving configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `1-way` - Value - 1-way for configuring ChannelInterLeave token.\n* `2-way` - Value - 2-way for configuring ChannelInterLeave token.\n* `3-way` - Value - 3-way for configuring ChannelInterLeave token.\n* `4-way` - Value - 4-way for configuring ChannelInterLeave token.\n* `auto` - Value - auto for configuring ChannelInterLeave token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.ChannelInterLeaveEnum ChannelInterLeave
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Adaptive Memory Training configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.CiscoAdaptiveMemTrainingEnum CiscoAdaptiveMemTraining
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting BIOS Techlog Level configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Maximum` - Value - Maximum for configuring CiscoDebugLevel token.\n* `Minimum` - Value - Minimum for configuring CiscoDebugLevel token.\n* `Normal` - Value - Normal for configuring CiscoDebugLevel token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.CiscoDebugLevelEnum CiscoDebugLevel
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting OptionROM Launch Optimization configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.CiscoOpromLaunchOptimizationEnum CiscoOpromLaunchOptimization
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Cisco xGMI Max Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.CiscoXgmiMaxSpeedEnum CiscoXgmiMaxSpeed
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting CKE Low Policy configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `auto` - Value - auto for configuring CkeLowPolicy token.\n* `disabled` - Value - disabled for configuring CkeLowPolicy token.\n* `fast` - Value - fast for configuring CkeLowPolicy token.\n* `slow` - Value - slow for configuring CkeLowPolicy token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.CkeLowPolicyEnum CkeLowPolicy
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Closed Loop Thermal Throttling configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.ClosedLoopThermThrotlEnum ClosedLoopThermThrotl
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Processor CMCI configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.CmciEnableEnum CmciEnable
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Config TDP configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.ConfigTdpEnum ConfigTdp
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Configurable TDP Level configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Level 1` - Value - Level 1 for configuring ConfigTdpLevel token.\n* `Level 2` - Value - Level 2 for configuring ConfigTdpLevel token.\n* `Normal` - Value - Normal for configuring ConfigTdpLevel token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.ConfigTdpLevelEnum ConfigTdpLevel
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Console Redirection configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `com-0` - Value - com-0 for configuring ConsoleRedirection token.\n* `com-1` - Value - com-1 for configuring ConsoleRedirection token.\n* `disabled` - Value - disabled for configuring ConsoleRedirection token.\n* `enabled` - Value - enabled for configuring ConsoleRedirection token.\n* `serial-port-a` - Value - serial-port-a for configuring ConsoleRedirection token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.ConsoleRedirectionEnum ConsoleRedirection
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Core Multi Processing configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `1` - Value - 1 for configuring CoreMultiProcessing token.\n* `2` - Value - 2 for configuring CoreMultiProcessing token.\n* `3` - Value - 3 for configuring CoreMultiProcessing token.\n* `4` - Value - 4 for configuring CoreMultiProcessing token.\n* `5` - Value - 5 for configuring CoreMultiProcessing token.\n* `6` - Value - 6 for configuring CoreMultiProcessing token.\n* `7` - Value - 7 for configuring CoreMultiProcessing token.\n* `8` - Value - 8 for configuring CoreMultiProcessing token.\n* `9` - Value - 9 for configuring CoreMultiProcessing token.\n* `10` - Value - 10 for configuring CoreMultiProcessing token.\n* `11` - Value - 11 for configuring CoreMultiProcessing token.\n* `12` - Value - 12 for configuring CoreMultiProcessing token.\n* `13` - Value - 13 for configuring CoreMultiProcessing token.\n* `14` - Value - 14 for configuring CoreMultiProcessing token.\n* `15` - Value - 15 for configuring CoreMultiProcessing token.\n* `16` - Value - 16 for configuring CoreMultiProcessing token.\n* `17` - Value - 17 for configuring CoreMultiProcessing token.\n* `18` - Value - 18 for configuring CoreMultiProcessing token.\n* `19` - Value - 19 for configuring CoreMultiProcessing token.\n* `20` - Value - 20 for configuring CoreMultiProcessing token.\n* `21` - Value - 21 for configuring CoreMultiProcessing token.\n* `22` - Value - 22 for configuring CoreMultiProcessing token.\n* `23` - Value - 23 for configuring CoreMultiProcessing token.\n* `24` - Value - 24 for configuring CoreMultiProcessing token.\n* `25` - Value - 25 for configuring CoreMultiProcessing token.\n* `26` - Value - 26 for configuring CoreMultiProcessing token.\n* `27` - Value - 27 for configuring CoreMultiProcessing token.\n* `28` - Value - 28 for configuring CoreMultiProcessing token.\n* `29` - Value - 29 for configuring CoreMultiProcessing token.\n* `30` - Value - 30 for configuring CoreMultiProcessing token.\n* `31` - Value - 31 for configuring CoreMultiProcessing token.\n* `32` - Value - 32 for configuring CoreMultiProcessing token.\n* `33` - Value - 33 for configuring CoreMultiProcessing token.\n* `34` - Value - 34 for configuring CoreMultiProcessing token.\n* `35` - Value - 35 for configuring CoreMultiProcessing token.\n* `36` - Value - 36 for configuring CoreMultiProcessing token.\n* `37` - Value - 37 for configuring CoreMultiProcessing token.\n* `38` - Value - 38 for configuring CoreMultiProcessing token.\n* `39` - Value - 39 for configuring CoreMultiProcessing token.\n* `40` - Value - 40 for configuring CoreMultiProcessing token.\n* `41` - Value - 41 for configuring CoreMultiProcessing token.\n* `42` - Value - 42 for configuring CoreMultiProcessing token.\n* `43` - Value - 43 for configuring CoreMultiProcessing token.\n* `44` - Value - 44 for configuring CoreMultiProcessing token.\n* `45` - Value - 45 for configuring CoreMultiProcessing token.\n* `46` - Value - 46 for configuring CoreMultiProcessing token.\n* `47` - Value - 47 for configuring CoreMultiProcessing token.\n* `48` - Value - 48 for configuring CoreMultiProcessing token.\n* `all` - Value - all for configuring CoreMultiProcessing token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.CoreMultiProcessingEnum CoreMultiProcessing
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Energy Performance configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `balanced-energy` - Value - balanced-energy for configuring CpuEnergyPerformance token.\n* `balanced-performance` - Value - balanced-performance for configuring CpuEnergyPerformance token.\n* `balanced-power` - Value - balanced-power for configuring CpuEnergyPerformance token.\n* `energy-efficient` - Value - energy-efficient for configuring CpuEnergyPerformance token.\n* `performance` - Value - performance for configuring CpuEnergyPerformance token.\n* `power` - Value - power for configuring CpuEnergyPerformance token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.CpuEnergyPerformanceEnum CpuEnergyPerformance
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Frequency Floor Override configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.CpuFrequencyFloorEnum CpuFrequencyFloor
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Enhanced CPU Performance configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring CpuPerfEnhancement token.\n* `Disabled` - Value - Disabled for configuring CpuPerfEnhancement token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.CpuPerfEnhancementEnum CpuPerfEnhancement
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting CPU Performance configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `custom` - Value - custom for configuring CpuPerformance token.\n* `enterprise` - Value - enterprise for configuring CpuPerformance token.\n* `high-throughput` - Value - high-throughput for configuring CpuPerformance token.\n* `hpc` - Value - hpc for configuring CpuPerformance token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.CpuPerformanceEnum CpuPerformance
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Power Technology configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `custom` - Value - custom for configuring CpuPowerManagement token.\n* `disabled` - Value - disabled for configuring CpuPowerManagement token.\n* `energy-efficient` - Value - energy-efficient for configuring CpuPowerManagement token.\n* `performance` - Value - performance for configuring CpuPowerManagement token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.CpuPowerManagementEnum CpuPowerManagement
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting CR QoS configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Disabled` - Value - Disabled for configuring CrQos token.\n* `Mode 0 - Disable the PMem QoS Feature` - Value - Mode 0 - Disable the PMem QoS Feature for configuring CrQos token.\n* `Mode 1 - M2M QoS Enable and CHA QoS Disable` - Value - Mode 1 - M2M QoS Enable and CHA QoS Disable for configuring CrQos token.\n* `Mode 2 - M2M QoS Enable and CHA QoS Enable` - Value - Mode 2 - M2M QoS Enable and CHA QoS Enable for configuring CrQos token.\n* `Recipe 1` - Value - Recipe 1 for configuring CrQos token.\n* `Recipe 2` - Value - Recipe 2 for configuring CrQos token.\n* `Recipe 3` - Value - Recipe 3 for configuring CrQos token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.CrQosEnum CrQos
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting CR FastGo Config configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring CrfastgoConfig token.\n* `Default` - Value - Default for configuring CrfastgoConfig token.\n* `Disable optimization` - Value - Disable optimization for configuring CrfastgoConfig token.\n* `Enable optimization` - Value - Enable optimization for configuring CrfastgoConfig token.\n* `Option 1` - Value - Option 1 for configuring CrfastgoConfig token.\n* `Option 2` - Value - Option 2 for configuring CrfastgoConfig token.\n* `Option 3` - Value - Option 3 for configuring CrfastgoConfig token.\n* `Option 4` - Value - Option 4 for configuring CrfastgoConfig token.\n* `Option 5` - Value - Option 5 for configuring CrfastgoConfig token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.CrfastgoConfigEnum CrfastgoConfig
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting DCPMM Firmware Downgrade configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.DcpmmFirmwareDowngradeEnum DcpmmFirmwareDowngrade
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Demand Scrub configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.DemandScrubEnum DemandScrub
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Direct Cache Access Support configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `auto` - Value - auto for configuring DirectCacheAccess token.\n* `disabled` - Value - disabled for configuring DirectCacheAccess token.\n* `enabled` - Value - enabled for configuring DirectCacheAccess token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.DirectCacheAccessEnum DirectCacheAccess
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting DRAM Clock Throttling configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring DramClockThrottling token.\n* `Balanced` - Value - Balanced for configuring DramClockThrottling token.\n* `Energy Efficient` - Value - Energy Efficient for configuring DramClockThrottling token.\n* `Performance` - Value - Performance for configuring DramClockThrottling token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.DramClockThrottlingEnum DramClockThrottling
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting DRAM Refresh Rate configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `1x` - Value - 1x for configuring DramRefreshRate token.\n* `2x` - Value - 2x for configuring DramRefreshRate token.\n* `3x` - Value - 3x for configuring DramRefreshRate token.\n* `4x` - Value - 4x for configuring DramRefreshRate token.\n* `Auto` - Value - Auto for configuring DramRefreshRate token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.DramRefreshRateEnum DramRefreshRate
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting DRAM SW Thermal Throttling configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.DramSwThermalThrottlingEnum DramSwThermalThrottling
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting eADR Support configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring EadrSupport token.\n* `disabled` - Value - disabled for configuring EadrSupport token.\n* `enabled` - Value - enabled for configuring EadrSupport token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.EadrSupportEnum EadrSupport
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting IIO eDPC Support configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Disabled` - Value - Disabled for configuring EdpcEn token.\n* `On Fatal Error` - Value - On Fatal Error for configuring EdpcEn token.\n* `On Fatal and Non-Fatal Errors` - Value - On Fatal and Non-Fatal Errors for configuring EdpcEn token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.EdpcEnEnum EdpcEn
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting External SSC Enable configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.EnableClockSpreadSpecEnum EnableClockSpreadSpec
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Multikey Total Memory Encryption  (MK-TME) configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.EnableMktmeEnum EnableMktme
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Software Guard Extensions  (SGX) configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.EnableSgxEnum EnableSgx
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Total Memory Encryption  (TME) configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.EnableTmeEnum EnableTme
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Energy Efficient Turbo configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.EnergyEfficientTurboEnum EnergyEfficientTurbo
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Energy Performance Tuning configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `BIOS` - Value - BIOS for configuring EngPerfTuning token.\n* `OS` - Value - OS for configuring EngPerfTuning token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.EngPerfTuningEnum EngPerfTuning
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Enhanced Intel Speedstep (R) Technology configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.EnhancedIntelSpeedStepTechEnum EnhancedIntelSpeedStepTech
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Select Owner EPOCH Input Type configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Change to New Random Owner EPOCHs` - Value - Change to New Random Owner EPOCHs for configuring EpochUpdate token.\n* `Manual User Defined Owner EPOCHs` - Value - Manual User Defined Owner EPOCHs for configuring EpochUpdate token.\n* `SGX Owner EPOCH activated` - Value - SGX Owner EPOCH activated for configuring EpochUpdate token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.EpochUpdateEnum EpochUpdate
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Processor EPP Enable configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.EppEnableEnum EppEnable
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting EPP Profile configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Balanced Performance` - Value - Balanced Performance for configuring EppProfile token.\n* `Balanced Power` - Value - Balanced Power for configuring EppProfile token.\n* `Performance` - Value - Performance for configuring EppProfile token.\n* `Power` - Value - Power for configuring EppProfile token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.EppProfileEnum EppProfile
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Execute Disable Bit configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.ExecuteDisableBitEnum ExecuteDisableBit
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Local X2 Apic configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `disabled` - Value - disabled for configuring ExtendedApic token.\n* `enabled` - Value - enabled for configuring ExtendedApic token.\n* `X2APIC` - Value - X2APIC for configuring ExtendedApic token.\n* `XAPIC` - Value - XAPIC for configuring ExtendedApic token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.ExtendedApicEnum ExtendedApic
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Flow Control configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `none` - Value - none for configuring FlowControl token.\n* `rts-cts` - Value - rts-cts for configuring FlowControl token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.FlowControlEnum FlowControl
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting FRB-2 Timer configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.Frb2enableEnum Frb2enable
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Hardware Prefetcher configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.HardwarePrefetchEnum HardwarePrefetch
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting CPU Hardware Power Management configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Disabled` - Value - Disabled for configuring HwpmEnable token.\n* `HWPM Native Mode` - Value - HWPM Native Mode for configuring HwpmEnable token.\n* `HWPM OOB Mode` - Value - HWPM OOB Mode for configuring HwpmEnable token.\n* `NATIVE MODE` - Value - NATIVE MODE for configuring HwpmEnable token.\n* `Native Mode with no Legacy` - Value - Native Mode with no Legacy for configuring HwpmEnable token.\n* `OOB MODE` - Value - OOB MODE for configuring HwpmEnable token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.HwpmEnableEnum HwpmEnable
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting IMC Interleaving configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `1-way Interleave` - Value - 1-way Interleave for configuring ImcInterleave token.\n* `2-way Interleave` - Value - 2-way Interleave for configuring ImcInterleave token.\n* `Auto` - Value - Auto for configuring ImcInterleave token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.ImcInterleaveEnum ImcInterleave
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Intel Dynamic Speed Select configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.IntelDynamicSpeedSelectEnum IntelDynamicSpeedSelect
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Intel HyperThreading Tech configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.IntelHyperThreadingTechEnum IntelHyperThreadingTech
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Intel Speed Select configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Base` - Value - Base for configuring IntelSpeedSelect token.\n* `Config 1` - Value - Config 1 for configuring IntelSpeedSelect token.\n* `Config 2` - Value - Config 2 for configuring IntelSpeedSelect token.\n* `Config 3` - Value - Config 3 for configuring IntelSpeedSelect token.\n* `Config 4` - Value - Config 4 for configuring IntelSpeedSelect token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.IntelSpeedSelectEnum IntelSpeedSelect
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Intel Turbo Boost Tech configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.IntelTurboBoostTechEnum IntelTurboBoostTech
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Intel (R) VT configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.IntelVirtualizationTechnologyEnum IntelVirtualizationTechnology
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Intel VT for Directed IO configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.IntelVtForDirectedIoEnum IntelVtForDirectedIo
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Intel (R) VT-d Coherency Support configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.IntelVtdCoherencySupportEnum IntelVtdCoherencySupport
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Intel (R) VT-d Interrupt Remapping configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.IntelVtdInterruptRemappingEnum IntelVtdInterruptRemapping
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Intel (R) VT-d PassThrough DMA Support configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.IntelVtdPassThroughDmaSupportEnum IntelVtdPassThroughDmaSupport
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Intel VTD ATS Support configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.IntelVtdatsSupportEnum IntelVtdatsSupport
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting IIO Error Enable configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `No` - Value - No for configuring IohErrorEnable token.\n* `Yes` - Value - Yes for configuring IohErrorEnable token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.IohErrorEnableEnum IohErrorEnable
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting IOH Resource Allocation configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `IOH0 24k IOH1 40k` - Value - IOH0 24k IOH1 40k for configuring IohResource token.\n* `IOH0 32k IOH1 32k` - Value - IOH0 32k IOH1 32k for configuring IohResource token.\n* `IOH0 40k IOH1 24k` - Value - IOH0 40k IOH1 24k for configuring IohResource token.\n* `IOH0 48k IOH1 16k` - Value - IOH0 48k IOH1 16k for configuring IohResource token.\n* `IOH0 56k IOH1 8k` - Value - IOH0 56k IOH1 8k for configuring IohResource token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.IohResourceEnum IohResource
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting DCU IP Prefetcher configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.IpPrefetchEnum IpPrefetch
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting IPV4 HTTP Support configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.Ipv4httpEnum Ipv4http
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting IPv4 PXE Support configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.Ipv4pxeEnum Ipv4pxe
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting IPV6 HTTP Support configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.Ipv6httpEnum Ipv6http
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting IPV6 PXE Support configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.Ipv6pxeEnum Ipv6pxe
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting KTI Prefetch configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring KtiPrefetch token.\n* `disabled` - Value - disabled for configuring KtiPrefetch token.\n* `enabled` - Value - enabled for configuring KtiPrefetch token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.KtiPrefetchEnum KtiPrefetch
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Legacy OS Redirection configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.LegacyOsRedirectionEnum LegacyOsRedirection
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Legacy USB Support configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `auto` - Value - auto for configuring LegacyUsbSupport token.\n* `disabled` - Value - disabled for configuring LegacyUsbSupport token.\n* `enabled` - Value - enabled for configuring LegacyUsbSupport token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.LegacyUsbSupportEnum LegacyUsbSupport
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting LLC Dead Line configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring LlcAlloc token.\n* `disabled` - Value - disabled for configuring LlcAlloc token.\n* `enabled` - Value - enabled for configuring LlcAlloc token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.LlcAllocEnum LlcAlloc
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting LLC Prefetch configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.LlcPrefetchEnum LlcPrefetch
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting LOM Port 0 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `disabled` - Value - disabled for configuring LomPort0state token.\n* `enabled` - Value - enabled for configuring LomPort0state token.\n* `Legacy Only` - Value - Legacy Only for configuring LomPort0state token.\n* `UEFI Only` - Value - UEFI Only for configuring LomPort0state token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.LomPort0stateEnum LomPort0state
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting LOM Port 1 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `disabled` - Value - disabled for configuring LomPort1state token.\n* `enabled` - Value - enabled for configuring LomPort1state token.\n* `Legacy Only` - Value - Legacy Only for configuring LomPort1state token.\n* `UEFI Only` - Value - UEFI Only for configuring LomPort1state token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.LomPort1stateEnum LomPort1state
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting LOM Port 2 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `disabled` - Value - disabled for configuring LomPort2state token.\n* `enabled` - Value - enabled for configuring LomPort2state token.\n* `Legacy Only` - Value - Legacy Only for configuring LomPort2state token.\n* `UEFI Only` - Value - UEFI Only for configuring LomPort2state token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.LomPort2stateEnum LomPort2state
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting LOM Port 3 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `disabled` - Value - disabled for configuring LomPort3state token.\n* `enabled` - Value - enabled for configuring LomPort3state token.\n* `Legacy Only` - Value - Legacy Only for configuring LomPort3state token.\n* `UEFI Only` - Value - UEFI Only for configuring LomPort3state token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.LomPort3stateEnum LomPort3state
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting All Onboard LOM Ports configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.LomPortsAllStateEnum LomPortsAllState
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Low Voltage DDR Mode configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `auto` - Value - auto for configuring LvDdrMode token.\n* `performance-mode` - Value - performance-mode for configuring LvDdrMode token.\n* `power-saving-mode` - Value - power-saving-mode for configuring LvDdrMode token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.LvDdrModeEnum LvDdrMode
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Make Device Non Bootable configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.MakeDeviceNonBootableEnum MakeDeviceNonBootable
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Memory Bandwidth Boost configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.MemoryBandwidthBoostEnum MemoryBandwidthBoost
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Intel Memory Interleaving configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `1 Way Node Interleave` - Value - 1 Way Node Interleave for configuring MemoryInterLeave token.\n* `2 Way Node Interleave` - Value - 2 Way Node Interleave for configuring MemoryInterLeave token.\n* `4 Way Node Interleave` - Value - 4 Way Node Interleave for configuring MemoryInterLeave token.\n* `8 Way Node Interleave` - Value - 8 Way Node Interleave for configuring MemoryInterLeave token.\n* `disabled` - Value - disabled for configuring MemoryInterLeave token.\n* `enabled` - Value - enabled for configuring MemoryInterLeave token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.MemoryInterLeaveEnum MemoryInterLeave
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Memory Mapped IO above 4GiB configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.MemoryMappedIoAbove4gbEnum MemoryMappedIoAbove4gb
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Memory Refresh Rate configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `1x Refresh` - Value - 1x Refresh for configuring MemoryRefreshRate token.\n* `2x Refresh` - Value - 2x Refresh for configuring MemoryRefreshRate token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.MemoryRefreshRateEnum MemoryRefreshRate
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Memory Size Limit in GiB configuration (0 - 65535 GiB)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^(\\d|[1-9]\\d|[1-9]\\d{2}|[1-9]\\d{3}|[1-5]\\d{4}|6[0-4]\\d{3}|65[0-4]\\d{2}|655[0-2]\\d|6553[0-5])$|^(platform-default)$")]
        public string MemorySizeLimit
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Memory Thermal Throttling Mode configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `CLTT with PECI` - Value - CLTT with PECI for configuring MemoryThermalThrottling token.\n* `Disabled` - Value - Disabled for configuring MemoryThermalThrottling token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.MemoryThermalThrottlingEnum MemoryThermalThrottling
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Mirroring Mode configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `inter-socket` - Value - inter-socket for configuring MirroringMode token.\n* `intra-socket` - Value - intra-socket for configuring MirroringMode token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.MirroringModeEnum MirroringMode
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting MMCFG BASE configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `1 GB` - Value - 1 GiB for configuring MmcfgBase token.\n* `2 GB` - Value - 2 GiB for configuring MmcfgBase token.\n* `2.5 GB` - Value - 2.5 GiB for configuring MmcfgBase token.\n* `3 GB` - Value - 3 GiB for configuring MmcfgBase token.\n* `Auto` - Value - Auto for configuring MmcfgBase token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.MmcfgBaseEnum MmcfgBase
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Network Stack configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.NetworkStackEnum NetworkStack
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting NUMA Optimized configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.NumaOptimizedEnum NumaOptimized
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting NVM Performance Setting configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `BW Optimized` - Value - BW Optimized for configuring NvmdimmPerformConfig token.\n* `Balanced Profile` - Value - Balanced Profile for configuring NvmdimmPerformConfig token.\n* `Latency Optimized` - Value - Latency Optimized for configuring NvmdimmPerformConfig token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.NvmdimmPerformConfigEnum NvmdimmPerformConfig
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Onboard 10Gbit LOM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.Onboard10gbitLomEnum Onboard10gbitLom
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Onboard Gbit LOM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.OnboardGbitLomEnum OnboardGbitLom
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Onboard SCU Storage Support configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.OnboardScuStorageSupportEnum OnboardScuStorageSupport
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Onboard SCU Storage SW Stack configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Intel RSTe` - Value - Intel RSTe for configuring OnboardScuStorageSwStack token.\n* `LSI SW RAID` - Value - LSI SW RAID for configuring OnboardScuStorageSwStack token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.OnboardScuStorageSwStackEnum OnboardScuStorageSwStack
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Operation Mode configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Test Only` - Value - Test Only for configuring OperationMode token.\n* `Test and Repair` - Value - Test and Repair for configuring OperationMode token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.OperationModeEnum OperationMode
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.OrganizationOrganizationRelationship Organization
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting OS Boot Watchdog Timer configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.OsBootWatchdogTimerEnum OsBootWatchdogTimer
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting OS Boot Watchdog Timer Policy configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `do-nothing` - Value - do-nothing for configuring OsBootWatchdogTimerPolicy token.\n* `power-off` - Value - power-off for configuring OsBootWatchdogTimerPolicy token.\n* `reset` - Value - reset for configuring OsBootWatchdogTimerPolicy token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.OsBootWatchdogTimerPolicyEnum OsBootWatchdogTimerPolicy
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting OS Boot Watchdog Timer Timeout configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `5-minutes` - Value - 5-minutes for configuring OsBootWatchdogTimerTimeout token.\n* `10-minutes` - Value - 10-minutes for configuring OsBootWatchdogTimerTimeout token.\n* `15-minutes` - Value - 15-minutes for configuring OsBootWatchdogTimerTimeout token.\n* `20-minutes` - Value - 20-minutes for configuring OsBootWatchdogTimerTimeout token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.OsBootWatchdogTimerTimeoutEnum OsBootWatchdogTimerTimeout
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Out-of-Band Mgmt Port configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.OutOfBandMgmtPortEnum OutOfBandMgmtPort
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Package C State Limit configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring PackageCstateLimit token.\n* `C0 C1 State` - Value - C0 C1 State for configuring PackageCstateLimit token.\n* `C0/C1` - Value - C0/C1 for configuring PackageCstateLimit token.\n* `C2` - Value - C2 for configuring PackageCstateLimit token.\n* `C6 Non Retention` - Value - C6 Non Retention for configuring PackageCstateLimit token.\n* `C6 Retention` - Value - C6 Retention for configuring PackageCstateLimit token.\n* `No Limit` - Value - No Limit for configuring PackageCstateLimit token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.PackageCstateLimitEnum PackageCstateLimit
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Panic and High Watermark configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `High` - Value - High for configuring PanicHighWatermark token.\n* `Low` - Value - Low for configuring PanicHighWatermark token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.PanicHighWatermarkEnum PanicHighWatermark
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Partial Cache Line Sparing configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.PartialCacheLineSparingEnum PartialCacheLineSparing
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Partial Memory Mirror Mode configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `disabled` - Value - disabled for configuring PartialMirrorModeConfig token.\n* `Percentage` - Value - Percentage for configuring PartialMirrorModeConfig token.\n* `Value in GB` - Value - Value in GiB for configuring PartialMirrorModeConfig token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.PartialMirrorModeConfigEnum PartialMirrorModeConfig
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Partial Mirror Percentage configuration (0.00 - 50.00 Percentage)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^(\\d\\.\\d{1,2}|[1-4]\\d\\.\\d{1,2}|50\\.[0]{1,2})$|^(platform-default)$")]
        public string PartialMirrorPercent
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Partial Mirror1 Size in GiB configuration (0 - 65535 GiB)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^(\\d|[1-9]\\d|[1-9]\\d{2}|[1-9]\\d{3}|[1-5]\\d{4}|6[0-4]\\d{3}|65[0-4]\\d{2}|655[0-2]\\d|6553[0-5])$|^(platform-default)$")]
        public string PartialMirrorValue1
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Partial Mirror2 Size in GiB configuration (0 - 65535 GiB)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^(\\d|[1-9]\\d|[1-9]\\d{2}|[1-9]\\d{3}|[1-5]\\d{4}|6[0-4]\\d{3}|65[0-4]\\d{2}|655[0-2]\\d|6553[0-5])$|^(platform-default)$")]
        public string PartialMirrorValue2
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Partial Mirror3 Size in GiB configuration (0 - 65535 GiB)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^(\\d|[1-9]\\d|[1-9]\\d{2}|[1-9]\\d{3}|[1-5]\\d{4}|6[0-4]\\d{3}|65[0-4]\\d{2}|655[0-2]\\d|6553[0-5])$|^(platform-default)$")]
        public string PartialMirrorValue3
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Partial Mirror4 Size in GiB configuration (0 - 65535 GiB)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^(\\d|[1-9]\\d|[1-9]\\d{2}|[1-9]\\d{3}|[1-5]\\d{4}|6[0-4]\\d{3}|65[0-4]\\d{2}|655[0-2]\\d|6553[0-5])$|^(platform-default)$")]
        public string PartialMirrorValue4
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Patrol Scrub configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `disabled` - Value - disabled for configuring PatrolScrub token.\n* `Enable at End of POST` - Value - Enable at End of POST for configuring PatrolScrub token.\n* `enabled` - Value - enabled for configuring PatrolScrub token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.PatrolScrubEnum PatrolScrub
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Patrol Scrub Interval configuration (5 - 23 Hour)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^([5-9]|1\\d|2[0-3])$|^(platform-default)$")]
        public string PatrolScrubDuration
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe RAS Support configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.PcIeRasSupportEnum PcIeRasSupport
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting NVMe SSD Hot-Plug Support configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.PcIeSsdHotPlugSupportEnum PcIeSsdHotPlugSupport
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting xHCI Mode configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.PchUsb30modeEnum PchUsb30mode
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting All PCIe Slots OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `disabled` - Value - disabled for configuring PciOptionRoMs token.\n* `enabled` - Value - enabled for configuring PciOptionRoMs token.\n* `Legacy Only` - Value - Legacy Only for configuring PciOptionRoMs token.\n* `UEFI Only` - Value - UEFI Only for configuring PciOptionRoMs token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.PciOptionRoMsEnum PciOptionRoMs
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCI ROM CLP configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.PciRomClpEnum PciRomClp
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe ARI Support configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring PcieAriSupport token.\n* `disabled` - Value - disabled for configuring PcieAriSupport token.\n* `enabled` - Value - enabled for configuring PcieAriSupport token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.PcieAriSupportEnum PcieAriSupport
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe PLL SSC configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring PciePllSsc token.\n* `Disabled` - Value - Disabled for configuring PciePllSsc token.\n* `ZeroPointFive` - Value - ZeroPointFive for configuring PciePllSsc token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.PciePllSscEnum PciePllSsc
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting MRAID1 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring PcieSlotMraid1linkSpeed token.\n* `Disabled` - Value - Disabled for configuring PcieSlotMraid1linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring PcieSlotMraid1linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring PcieSlotMraid1linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring PcieSlotMraid1linkSpeed token.\n* `GEN4` - Value - GEN4 for configuring PcieSlotMraid1linkSpeed token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.PcieSlotMraid1linkSpeedEnum PcieSlotMraid1linkSpeed
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting MRAID1 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.PcieSlotMraid1optionRomEnum PcieSlotMraid1optionRom
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting MRAID2 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring PcieSlotMraid2linkSpeed token.\n* `Disabled` - Value - Disabled for configuring PcieSlotMraid2linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring PcieSlotMraid2linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring PcieSlotMraid2linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring PcieSlotMraid2linkSpeed token.\n* `GEN4` - Value - GEN4 for configuring PcieSlotMraid2linkSpeed token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.PcieSlotMraid2linkSpeedEnum PcieSlotMraid2linkSpeed
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting MRAID2 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.PcieSlotMraid2optionRomEnum PcieSlotMraid2optionRom
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe Slot MSTOR Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring PcieSlotMstorraidLinkSpeed token.\n* `Disabled` - Value - Disabled for configuring PcieSlotMstorraidLinkSpeed token.\n* `GEN1` - Value - GEN1 for configuring PcieSlotMstorraidLinkSpeed token.\n* `GEN2` - Value - GEN2 for configuring PcieSlotMstorraidLinkSpeed token.\n* `GEN3` - Value - GEN3 for configuring PcieSlotMstorraidLinkSpeed token.\n* `GEN4` - Value - GEN4 for configuring PcieSlotMstorraidLinkSpeed token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.PcieSlotMstorraidLinkSpeedEnum PcieSlotMstorraidLinkSpeed
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe Slot MSTOR RAID OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.PcieSlotMstorraidOptionRomEnum PcieSlotMstorraidOptionRom
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting NVME 1 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring PcieSlotNvme1linkSpeed token.\n* `Disabled` - Value - Disabled for configuring PcieSlotNvme1linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring PcieSlotNvme1linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring PcieSlotNvme1linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring PcieSlotNvme1linkSpeed token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.PcieSlotNvme1linkSpeedEnum PcieSlotNvme1linkSpeed
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting NVME 1 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.PcieSlotNvme1optionRomEnum PcieSlotNvme1optionRom
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting NVME 2 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring PcieSlotNvme2linkSpeed token.\n* `Disabled` - Value - Disabled for configuring PcieSlotNvme2linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring PcieSlotNvme2linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring PcieSlotNvme2linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring PcieSlotNvme2linkSpeed token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.PcieSlotNvme2linkSpeedEnum PcieSlotNvme2linkSpeed
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting NVME 2 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.PcieSlotNvme2optionRomEnum PcieSlotNvme2optionRom
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting NVME 3 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring PcieSlotNvme3linkSpeed token.\n* `Disabled` - Value - Disabled for configuring PcieSlotNvme3linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring PcieSlotNvme3linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring PcieSlotNvme3linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring PcieSlotNvme3linkSpeed token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.PcieSlotNvme3linkSpeedEnum PcieSlotNvme3linkSpeed
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting NVME 3 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.PcieSlotNvme3optionRomEnum PcieSlotNvme3optionRom
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting NVME 4 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring PcieSlotNvme4linkSpeed token.\n* `Disabled` - Value - Disabled for configuring PcieSlotNvme4linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring PcieSlotNvme4linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring PcieSlotNvme4linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring PcieSlotNvme4linkSpeed token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.PcieSlotNvme4linkSpeedEnum PcieSlotNvme4linkSpeed
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting NVME 4 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.PcieSlotNvme4optionRomEnum PcieSlotNvme4optionRom
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting NVME 5 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring PcieSlotNvme5linkSpeed token.\n* `Disabled` - Value - Disabled for configuring PcieSlotNvme5linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring PcieSlotNvme5linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring PcieSlotNvme5linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring PcieSlotNvme5linkSpeed token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.PcieSlotNvme5linkSpeedEnum PcieSlotNvme5linkSpeed
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting NVME 5 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.PcieSlotNvme5optionRomEnum PcieSlotNvme5optionRom
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting NVME 6 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring PcieSlotNvme6linkSpeed token.\n* `Disabled` - Value - Disabled for configuring PcieSlotNvme6linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring PcieSlotNvme6linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring PcieSlotNvme6linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring PcieSlotNvme6linkSpeed token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.PcieSlotNvme6linkSpeedEnum PcieSlotNvme6linkSpeed
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting NVME 6 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.PcieSlotNvme6optionRomEnum PcieSlotNvme6optionRom
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe Slots CDN Control configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.PcieSlotsCdnEnableEnum PcieSlotsCdnEnable
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Power ON Password configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.PopSupportEnum PopSupport
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting POST Error Pause configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.PostErrorPauseEnum PostErrorPause
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Post Package Repair configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Disabled` - Value - Disabled for configuring PostPackageRepair token.\n* `Hard PPR` - Value - Hard PPR for configuring PostPackageRepair token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.PostPackageRepairEnum PostPackageRepair
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Processor C1E configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.ProcessorC1eEnum ProcessorC1e
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Processor C3 Report configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.ProcessorC3reportEnum ProcessorC3report
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Processor C6 Report configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.ProcessorC6reportEnum ProcessorC6report
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting CPU C State configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.ProcessorCstateEnum ProcessorCstate
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to policyAbstractConfigProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.PolicyAbstractConfigProfileRelationship> Profiles
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting P-SATA Mode configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `AHCI` - Value - AHCI for configuring Psata token.\n* `Disabled` - Value - Disabled for configuring Psata token.\n* `LSI SW RAID` - Value - LSI SW RAID for configuring Psata token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.PsataEnum Psata
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting P-STATE Coordination configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `HW ALL` - Value - HW ALL for configuring PstateCoordType token.\n* `SW ALL` - Value - SW ALL for configuring PstateCoordType token.\n* `SW ANY` - Value - SW ANY for configuring PstateCoordType token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.PstateCoordTypeEnum PstateCoordType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Putty KeyPad configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `ESCN` - Value - ESCN for configuring PuttyKeyPad token.\n* `LINUX` - Value - LINUX for configuring PuttyKeyPad token.\n* `SCO` - Value - SCO for configuring PuttyKeyPad token.\n* `VT100` - Value - VT100 for configuring PuttyKeyPad token.\n* `VT400` - Value - VT400 for configuring PuttyKeyPad token.\n* `XTERMR6` - Value - XTERMR6 for configuring PuttyKeyPad token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.PuttyKeyPadEnum PuttyKeyPad
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Power Performance Tuning configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `bios` - Value - BIOS for configuring PwrPerfTuning token.\n* `os` - Value - os for configuring PwrPerfTuning token.\n* `peci` - Value - peci for configuring PwrPerfTuning token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.PwrPerfTuningEnum PwrPerfTuning
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting QPI Link Frequency Select configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `6.4-gt/s` - Value - 6.4-gt/s for configuring QpiLinkFrequency token.\n* `7.2-gt/s` - Value - 7.2-gt/s for configuring QpiLinkFrequency token.\n* `8.0-gt/s` - Value - 8.0-gt/s for configuring QpiLinkFrequency token.\n* `9.6-gt/s` - Value - 9.6-gt/s for configuring QpiLinkFrequency token.\n* `auto` - Value - auto for configuring QpiLinkFrequency token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.QpiLinkFrequencyEnum QpiLinkFrequency
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting UPI Link Frequency Select configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `10.4GT/s` - Value - 10.4GT/s for configuring QpiLinkSpeed token.\n* `11.2GT/s` - Value - 11.2GT/s for configuring QpiLinkSpeed token.\n* `9.6GT/s` - Value - 9.6GT/s for configuring QpiLinkSpeed token.\n* `Auto` - Value - Auto for configuring QpiLinkSpeed token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.QpiLinkSpeedEnum QpiLinkSpeed
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting QPI Snoop Mode configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `auto` - Value - auto for configuring QpiSnoopMode token.\n* `cluster-on-die` - Value - cluster-on-die for configuring QpiSnoopMode token.\n* `early-snoop` - Value - early-snoop for configuring QpiSnoopMode token.\n* `home-directory-snoop` - Value - home-directory-snoop for configuring QpiSnoopMode token.\n* `home-directory-snoop-with-osb` - Value - home-directory-snoop-with-osb for configuring QpiSnoopMode token.\n* `home-snoop` - Value - home-snoop for configuring QpiSnoopMode token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.QpiSnoopModeEnum QpiSnoopMode
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Rank Interleaving configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `1-way` - Value - 1-way for configuring RankInterLeave token.\n* `2-way` - Value - 2-way for configuring RankInterLeave token.\n* `4-way` - Value - 4-way for configuring RankInterLeave token.\n* `8-way` - Value - 8-way for configuring RankInterLeave token.\n* `auto` - Value - auto for configuring RankInterLeave token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.RankInterLeaveEnum RankInterLeave
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Redirection After BIOS POST configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Always Enable` - Value - Always Enable for configuring RedirectionAfterPost token.\n* `Bootloader` - Value - Bootloader for configuring RedirectionAfterPost token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.RedirectionAfterPostEnum RedirectionAfterPost
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting SATA Mode configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `AHCI` - Value - AHCI for configuring SataModeSelect token.\n* `Disabled` - Value - Disabled for configuring SataModeSelect token.\n* `LSI SW RAID` - Value - LSI SW RAID for configuring SataModeSelect token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SataModeSelectEnum SataModeSelect
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Memory RAS Configuration configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `adddc-sparing` - Value - adddc-sparing for configuring SelectMemoryRasConfiguration token.\n* `lockstep` - Value - lockstep for configuring SelectMemoryRasConfiguration token.\n* `maximum-performance` - Value - maximum-performance for configuring SelectMemoryRasConfiguration token.\n* `mirror-mode-1lm` - Value - mirror-mode-1lm for configuring SelectMemoryRasConfiguration token.\n* `mirroring` - Value - mirroring for configuring SelectMemoryRasConfiguration token.\n* `partial-mirror-mode-1lm` - Value - partial-mirror-mode-1lm for configuring SelectMemoryRasConfiguration token.\n* `sparing` - Value - sparing for configuring SelectMemoryRasConfiguration token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SelectMemoryRasConfigurationEnum SelectMemoryRasConfiguration
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PPR Type configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `disabled` - Value - disabled for configuring SelectPprType token.\n* `Hard PPR` - Value - Hard PPR for configuring SelectPprType token.\n* `Soft PPR` - Value - Soft PPR for configuring SelectPprType token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SelectPprTypeEnum SelectPprType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Serial A Enable configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SerialPortAenableEnum SerialPortAenable
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Secured Encrypted Virtualization configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `253 ASIDs` - Value - 253 ASIDs for configuring Sev token.\n* `509 ASIDs` - Value - 509 ASIDs for configuring Sev token.\n* `Auto` - Value - Auto for configuring Sev token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SevEnum Sev
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting SGX Auto MP Registration Agent configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SgxAutoRegistrationAgentEnum SgxAutoRegistrationAgent
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting SGX Epoch 0 configuration (0 - ffffffffffffffff Hash byte 7-0)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^([0-9a-fA-F]{1,16})$|^(platform-default)$")]
        public string SgxEpoch0
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting SGX Epoch 1 configuration (0 - ffffffffffffffff Hash byte 7-0)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^([0-9a-fA-F]{1,16})$|^(platform-default)$")]
        public string SgxEpoch1
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting SGX Factory Reset configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SgxFactoryResetEnum SgxFactoryReset
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting SGX PubKey Hash0 configuration (0 - ffffffffffffffff Hash byte 7-0)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^([0-9a-fA-F]{1,16})$|^(platform-default)$")]
        public string SgxLePubKeyHash0
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting SGX PubKey Hash1 configuration (0 - ffffffffffffffff Hash byte 15-8)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^([0-9a-fA-F]{1,16})$|^(platform-default)$")]
        public string SgxLePubKeyHash1
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting SGX PubKey Hash2 configuration (0 - ffffffffffffffff Hash byte 23-16)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^([0-9a-fA-F]{1,16})$|^(platform-default)$")]
        public string SgxLePubKeyHash2
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting SGX PubKey Hash3 configuration (0 - ffffffffffffffff Hash byte 31-24)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^([0-9a-fA-F]{1,16})$|^(platform-default)$")]
        public string SgxLePubKeyHash3
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting SGX Write Enable configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SgxLeWrEnum SgxLeWr
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting SGX Package Information In-Band Access configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SgxPackageInfoInBandAccessEnum SgxPackageInfoInBandAccess
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting SGX QoS configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SgxQosEnum SgxQos
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting SHA-1 PCR Bank configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.Sha1pcrBankEnum Sha1pcrBank
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting SHA256 PCR Bank configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.Sha256pcrBankEnum Sha256pcrBank
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Single PCTL configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `No` - Value - No for configuring SinglePctlEnable token.\n* `Yes` - Value - Yes for configuring SinglePctlEnable token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SinglePctlEnableEnum SinglePctlEnable
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe Slot:10 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring Slot10linkSpeed token.\n* `Disabled` - Value - Disabled for configuring Slot10linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring Slot10linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring Slot10linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring Slot10linkSpeed token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.Slot10linkSpeedEnum Slot10linkSpeed
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Slot 10 State configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `disabled` - Value - disabled for configuring Slot10state token.\n* `enabled` - Value - enabled for configuring Slot10state token.\n* `Legacy Only` - Value - Legacy Only for configuring Slot10state token.\n* `UEFI Only` - Value - UEFI Only for configuring Slot10state token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.Slot10stateEnum Slot10state
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe Slot:11 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring Slot11linkSpeed token.\n* `Disabled` - Value - Disabled for configuring Slot11linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring Slot11linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring Slot11linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring Slot11linkSpeed token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.Slot11linkSpeedEnum Slot11linkSpeed
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Slot 11 State configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.Slot11stateEnum Slot11state
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe Slot:12 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring Slot12linkSpeed token.\n* `Disabled` - Value - Disabled for configuring Slot12linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring Slot12linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring Slot12linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring Slot12linkSpeed token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.Slot12linkSpeedEnum Slot12linkSpeed
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Slot 12 State configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.Slot12stateEnum Slot12state
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Slot 13 State configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.Slot13stateEnum Slot13state
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Slot 14 State configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.Slot14stateEnum Slot14state
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe Slot: 1 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring Slot1linkSpeed token.\n* `Disabled` - Value - Disabled for configuring Slot1linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring Slot1linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring Slot1linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring Slot1linkSpeed token.\n* `GEN4` - Value - GEN4 for configuring Slot1linkSpeed token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.Slot1linkSpeedEnum Slot1linkSpeed
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Slot 1 State configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `disabled` - Value - disabled for configuring Slot1state token.\n* `enabled` - Value - enabled for configuring Slot1state token.\n* `Legacy Only` - Value - Legacy Only for configuring Slot1state token.\n* `UEFI Only` - Value - UEFI Only for configuring Slot1state token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.Slot1stateEnum Slot1state
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe Slot: 2 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring Slot2linkSpeed token.\n* `Disabled` - Value - Disabled for configuring Slot2linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring Slot2linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring Slot2linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring Slot2linkSpeed token.\n* `GEN4` - Value - GEN4 for configuring Slot2linkSpeed token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.Slot2linkSpeedEnum Slot2linkSpeed
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Slot 2 State configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `disabled` - Value - disabled for configuring Slot2state token.\n* `enabled` - Value - enabled for configuring Slot2state token.\n* `Legacy Only` - Value - Legacy Only for configuring Slot2state token.\n* `UEFI Only` - Value - UEFI Only for configuring Slot2state token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.Slot2stateEnum Slot2state
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe Slot: 3 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring Slot3linkSpeed token.\n* `Disabled` - Value - Disabled for configuring Slot3linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring Slot3linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring Slot3linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring Slot3linkSpeed token.\n* `GEN4` - Value - GEN4 for configuring Slot3linkSpeed token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.Slot3linkSpeedEnum Slot3linkSpeed
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Slot 3 State configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `disabled` - Value - disabled for configuring Slot3state token.\n* `enabled` - Value - enabled for configuring Slot3state token.\n* `Legacy Only` - Value - Legacy Only for configuring Slot3state token.\n* `UEFI Only` - Value - UEFI Only for configuring Slot3state token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.Slot3stateEnum Slot3state
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe Slot: 4 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring Slot4linkSpeed token.\n* `Disabled` - Value - Disabled for configuring Slot4linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring Slot4linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring Slot4linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring Slot4linkSpeed token.\n* `GEN4` - Value - GEN4 for configuring Slot4linkSpeed token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.Slot4linkSpeedEnum Slot4linkSpeed
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Slot 4 State configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `disabled` - Value - disabled for configuring Slot4state token.\n* `enabled` - Value - enabled for configuring Slot4state token.\n* `Legacy Only` - Value - Legacy Only for configuring Slot4state token.\n* `UEFI Only` - Value - UEFI Only for configuring Slot4state token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.Slot4stateEnum Slot4state
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe Slot: 5 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring Slot5linkSpeed token.\n* `Disabled` - Value - Disabled for configuring Slot5linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring Slot5linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring Slot5linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring Slot5linkSpeed token.\n* `GEN4` - Value - GEN4 for configuring Slot5linkSpeed token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.Slot5linkSpeedEnum Slot5linkSpeed
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Slot 5 State configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `disabled` - Value - disabled for configuring Slot5state token.\n* `enabled` - Value - enabled for configuring Slot5state token.\n* `Legacy Only` - Value - Legacy Only for configuring Slot5state token.\n* `UEFI Only` - Value - UEFI Only for configuring Slot5state token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.Slot5stateEnum Slot5state
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe Slot: 6 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring Slot6linkSpeed token.\n* `Disabled` - Value - Disabled for configuring Slot6linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring Slot6linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring Slot6linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring Slot6linkSpeed token.\n* `GEN4` - Value - GEN4 for configuring Slot6linkSpeed token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.Slot6linkSpeedEnum Slot6linkSpeed
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Slot 6 State configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `disabled` - Value - disabled for configuring Slot6state token.\n* `enabled` - Value - enabled for configuring Slot6state token.\n* `Legacy Only` - Value - Legacy Only for configuring Slot6state token.\n* `UEFI Only` - Value - UEFI Only for configuring Slot6state token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.Slot6stateEnum Slot6state
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe Slot: 7 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring Slot7linkSpeed token.\n* `Disabled` - Value - Disabled for configuring Slot7linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring Slot7linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring Slot7linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring Slot7linkSpeed token.\n* `GEN4` - Value - GEN4 for configuring Slot7linkSpeed token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.Slot7linkSpeedEnum Slot7linkSpeed
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Slot 7 State configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `disabled` - Value - disabled for configuring Slot7state token.\n* `enabled` - Value - enabled for configuring Slot7state token.\n* `Legacy Only` - Value - Legacy Only for configuring Slot7state token.\n* `UEFI Only` - Value - UEFI Only for configuring Slot7state token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.Slot7stateEnum Slot7state
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe Slot: 8 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring Slot8linkSpeed token.\n* `Disabled` - Value - Disabled for configuring Slot8linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring Slot8linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring Slot8linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring Slot8linkSpeed token.\n* `GEN4` - Value - GEN4 for configuring Slot8linkSpeed token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.Slot8linkSpeedEnum Slot8linkSpeed
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Slot 8 State configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `disabled` - Value - disabled for configuring Slot8state token.\n* `enabled` - Value - enabled for configuring Slot8state token.\n* `Legacy Only` - Value - Legacy Only for configuring Slot8state token.\n* `UEFI Only` - Value - UEFI Only for configuring Slot8state token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.Slot8stateEnum Slot8state
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe Slot: 9 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring Slot9linkSpeed token.\n* `Disabled` - Value - Disabled for configuring Slot9linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring Slot9linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring Slot9linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring Slot9linkSpeed token.\n* `GEN4` - Value - GEN4 for configuring Slot9linkSpeed token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.Slot9linkSpeedEnum Slot9linkSpeed
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Slot 9 State configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `disabled` - Value - disabled for configuring Slot9state token.\n* `enabled` - Value - enabled for configuring Slot9state token.\n* `Legacy Only` - Value - Legacy Only for configuring Slot9state token.\n* `UEFI Only` - Value - UEFI Only for configuring Slot9state token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.Slot9stateEnum Slot9state
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe Slot:FLOM Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring SlotFlomLinkSpeed token.\n* `Disabled` - Value - Disabled for configuring SlotFlomLinkSpeed token.\n* `GEN1` - Value - GEN1 for configuring SlotFlomLinkSpeed token.\n* `GEN2` - Value - GEN2 for configuring SlotFlomLinkSpeed token.\n* `GEN3` - Value - GEN3 for configuring SlotFlomLinkSpeed token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotFlomLinkSpeedEnum SlotFlomLinkSpeed
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Front NVME 10 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring SlotFrontNvme10linkSpeed token.\n* `Disabled` - Value - Disabled for configuring SlotFrontNvme10linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring SlotFrontNvme10linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring SlotFrontNvme10linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring SlotFrontNvme10linkSpeed token.\n* `GEN4` - Value - GEN4 for configuring SlotFrontNvme10linkSpeed token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotFrontNvme10linkSpeedEnum SlotFrontNvme10linkSpeed
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Front NVME 10 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotFrontNvme10optionRomEnum SlotFrontNvme10optionRom
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Front NVME 11 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring SlotFrontNvme11linkSpeed token.\n* `Disabled` - Value - Disabled for configuring SlotFrontNvme11linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring SlotFrontNvme11linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring SlotFrontNvme11linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring SlotFrontNvme11linkSpeed token.\n* `GEN4` - Value - GEN4 for configuring SlotFrontNvme11linkSpeed token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotFrontNvme11linkSpeedEnum SlotFrontNvme11linkSpeed
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Front NVME 11 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotFrontNvme11optionRomEnum SlotFrontNvme11optionRom
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Front NVME 12 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring SlotFrontNvme12linkSpeed token.\n* `Disabled` - Value - Disabled for configuring SlotFrontNvme12linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring SlotFrontNvme12linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring SlotFrontNvme12linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring SlotFrontNvme12linkSpeed token.\n* `GEN4` - Value - GEN4 for configuring SlotFrontNvme12linkSpeed token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotFrontNvme12linkSpeedEnum SlotFrontNvme12linkSpeed
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Front NVME 12 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotFrontNvme12optionRomEnum SlotFrontNvme12optionRom
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Front NVME 13 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotFrontNvme13optionRomEnum SlotFrontNvme13optionRom
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Front NVME 14 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotFrontNvme14optionRomEnum SlotFrontNvme14optionRom
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Front NVME 15 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotFrontNvme15optionRomEnum SlotFrontNvme15optionRom
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Front NVME 16 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotFrontNvme16optionRomEnum SlotFrontNvme16optionRom
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Front NVME 17 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotFrontNvme17optionRomEnum SlotFrontNvme17optionRom
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Front NVME 18 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotFrontNvme18optionRomEnum SlotFrontNvme18optionRom
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Front NVME 19 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotFrontNvme19optionRomEnum SlotFrontNvme19optionRom
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe Slot:Front NVME 1 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring SlotFrontNvme1linkSpeed token.\n* `Disabled` - Value - Disabled for configuring SlotFrontNvme1linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring SlotFrontNvme1linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring SlotFrontNvme1linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring SlotFrontNvme1linkSpeed token.\n* `GEN4` - Value - GEN4 for configuring SlotFrontNvme1linkSpeed token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotFrontNvme1linkSpeedEnum SlotFrontNvme1linkSpeed
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Front NVME 1 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotFrontNvme1optionRomEnum SlotFrontNvme1optionRom
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Front NVME 20 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotFrontNvme20optionRomEnum SlotFrontNvme20optionRom
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Front NVME 21 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotFrontNvme21optionRomEnum SlotFrontNvme21optionRom
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Front NVME 22 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotFrontNvme22optionRomEnum SlotFrontNvme22optionRom
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Front NVME 23 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotFrontNvme23optionRomEnum SlotFrontNvme23optionRom
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Front NVME 24 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotFrontNvme24optionRomEnum SlotFrontNvme24optionRom
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe Slot:Front NVME 2 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring SlotFrontNvme2linkSpeed token.\n* `Disabled` - Value - Disabled for configuring SlotFrontNvme2linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring SlotFrontNvme2linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring SlotFrontNvme2linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring SlotFrontNvme2linkSpeed token.\n* `GEN4` - Value - GEN4 for configuring SlotFrontNvme2linkSpeed token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotFrontNvme2linkSpeedEnum SlotFrontNvme2linkSpeed
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Front NVME 2 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotFrontNvme2optionRomEnum SlotFrontNvme2optionRom
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Front NVME 3 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring SlotFrontNvme3linkSpeed token.\n* `Disabled` - Value - Disabled for configuring SlotFrontNvme3linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring SlotFrontNvme3linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring SlotFrontNvme3linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring SlotFrontNvme3linkSpeed token.\n* `GEN4` - Value - GEN4 for configuring SlotFrontNvme3linkSpeed token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotFrontNvme3linkSpeedEnum SlotFrontNvme3linkSpeed
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Front NVME 3 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotFrontNvme3optionRomEnum SlotFrontNvme3optionRom
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Front NVME 4 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring SlotFrontNvme4linkSpeed token.\n* `Disabled` - Value - Disabled for configuring SlotFrontNvme4linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring SlotFrontNvme4linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring SlotFrontNvme4linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring SlotFrontNvme4linkSpeed token.\n* `GEN4` - Value - GEN4 for configuring SlotFrontNvme4linkSpeed token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotFrontNvme4linkSpeedEnum SlotFrontNvme4linkSpeed
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Front NVME 4 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotFrontNvme4optionRomEnum SlotFrontNvme4optionRom
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Front NVME 5 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring SlotFrontNvme5linkSpeed token.\n* `Disabled` - Value - Disabled for configuring SlotFrontNvme5linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring SlotFrontNvme5linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring SlotFrontNvme5linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring SlotFrontNvme5linkSpeed token.\n* `GEN4` - Value - GEN4 for configuring SlotFrontNvme5linkSpeed token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotFrontNvme5linkSpeedEnum SlotFrontNvme5linkSpeed
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Front NVME 5 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotFrontNvme5optionRomEnum SlotFrontNvme5optionRom
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Front NVME 6 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring SlotFrontNvme6linkSpeed token.\n* `Disabled` - Value - Disabled for configuring SlotFrontNvme6linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring SlotFrontNvme6linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring SlotFrontNvme6linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring SlotFrontNvme6linkSpeed token.\n* `GEN4` - Value - GEN4 for configuring SlotFrontNvme6linkSpeed token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotFrontNvme6linkSpeedEnum SlotFrontNvme6linkSpeed
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Front NVME 6 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotFrontNvme6optionRomEnum SlotFrontNvme6optionRom
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Front NVME 7 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring SlotFrontNvme7linkSpeed token.\n* `Disabled` - Value - Disabled for configuring SlotFrontNvme7linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring SlotFrontNvme7linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring SlotFrontNvme7linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring SlotFrontNvme7linkSpeed token.\n* `GEN4` - Value - GEN4 for configuring SlotFrontNvme7linkSpeed token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotFrontNvme7linkSpeedEnum SlotFrontNvme7linkSpeed
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Front NVME 7 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotFrontNvme7optionRomEnum SlotFrontNvme7optionRom
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Front NVME 8 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring SlotFrontNvme8linkSpeed token.\n* `Disabled` - Value - Disabled for configuring SlotFrontNvme8linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring SlotFrontNvme8linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring SlotFrontNvme8linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring SlotFrontNvme8linkSpeed token.\n* `GEN4` - Value - GEN4 for configuring SlotFrontNvme8linkSpeed token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotFrontNvme8linkSpeedEnum SlotFrontNvme8linkSpeed
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Front NVME 8 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotFrontNvme8optionRomEnum SlotFrontNvme8optionRom
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Front NVME 9 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring SlotFrontNvme9linkSpeed token.\n* `Disabled` - Value - Disabled for configuring SlotFrontNvme9linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring SlotFrontNvme9linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring SlotFrontNvme9linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring SlotFrontNvme9linkSpeed token.\n* `GEN4` - Value - GEN4 for configuring SlotFrontNvme9linkSpeed token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotFrontNvme9linkSpeedEnum SlotFrontNvme9linkSpeed
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Front NVME 9 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotFrontNvme9optionRomEnum SlotFrontNvme9optionRom
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe Slot:Front1 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring SlotFrontSlot5linkSpeed token.\n* `Disabled` - Value - Disabled for configuring SlotFrontSlot5linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring SlotFrontSlot5linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring SlotFrontSlot5linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring SlotFrontSlot5linkSpeed token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotFrontSlot5linkSpeedEnum SlotFrontSlot5linkSpeed
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe Slot:Front2 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring SlotFrontSlot6linkSpeed token.\n* `Disabled` - Value - Disabled for configuring SlotFrontSlot6linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring SlotFrontSlot6linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring SlotFrontSlot6linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring SlotFrontSlot6linkSpeed token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotFrontSlot6linkSpeedEnum SlotFrontSlot6linkSpeed
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting GPU 1 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotGpu1stateEnum SlotGpu1state
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting GPU 2 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotGpu2stateEnum SlotGpu2state
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting GPU 3 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotGpu3stateEnum SlotGpu3state
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting GPU 4 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotGpu4stateEnum SlotGpu4state
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting GPU 5 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotGpu5stateEnum SlotGpu5state
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting GPU 6 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotGpu6stateEnum SlotGpu6state
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting GPU 7 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotGpu7stateEnum SlotGpu7state
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting GPU 8 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotGpu8stateEnum SlotGpu8state
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe Slot:HBA Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring SlotHbaLinkSpeed token.\n* `Disabled` - Value - Disabled for configuring SlotHbaLinkSpeed token.\n* `GEN1` - Value - GEN1 for configuring SlotHbaLinkSpeed token.\n* `GEN2` - Value - GEN2 for configuring SlotHbaLinkSpeed token.\n* `GEN3` - Value - GEN3 for configuring SlotHbaLinkSpeed token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotHbaLinkSpeedEnum SlotHbaLinkSpeed
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe Slot:HBA OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `disabled` - Value - disabled for configuring SlotHbaState token.\n* `enabled` - Value - enabled for configuring SlotHbaState token.\n* `Legacy Only` - Value - Legacy Only for configuring SlotHbaState token.\n* `UEFI Only` - Value - UEFI Only for configuring SlotHbaState token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotHbaStateEnum SlotHbaState
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe LOM:1 Link configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotLom1linkEnum SlotLom1link
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe LOM:2 Link configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotLom2linkEnum SlotLom2link
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Slot Mezz State configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `disabled` - Value - disabled for configuring SlotMezzState token.\n* `enabled` - Value - enabled for configuring SlotMezzState token.\n* `Legacy Only` - Value - Legacy Only for configuring SlotMezzState token.\n* `UEFI Only` - Value - UEFI Only for configuring SlotMezzState token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotMezzStateEnum SlotMezzState
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe Slot:MLOM Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring SlotMlomLinkSpeed token.\n* `Disabled` - Value - Disabled for configuring SlotMlomLinkSpeed token.\n* `GEN1` - Value - GEN1 for configuring SlotMlomLinkSpeed token.\n* `GEN2` - Value - GEN2 for configuring SlotMlomLinkSpeed token.\n* `GEN3` - Value - GEN3 for configuring SlotMlomLinkSpeed token.\n* `GEN4` - Value - GEN4 for configuring SlotMlomLinkSpeed token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotMlomLinkSpeedEnum SlotMlomLinkSpeed
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe Slot MLOM OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `disabled` - Value - disabled for configuring SlotMlomState token.\n* `enabled` - Value - enabled for configuring SlotMlomState token.\n* `Legacy Only` - Value - Legacy Only for configuring SlotMlomState token.\n* `UEFI Only` - Value - UEFI Only for configuring SlotMlomState token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotMlomStateEnum SlotMlomState
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting MRAID Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring SlotMraidLinkSpeed token.\n* `Disabled` - Value - Disabled for configuring SlotMraidLinkSpeed token.\n* `GEN1` - Value - GEN1 for configuring SlotMraidLinkSpeed token.\n* `GEN2` - Value - GEN2 for configuring SlotMraidLinkSpeed token.\n* `GEN3` - Value - GEN3 for configuring SlotMraidLinkSpeed token.\n* `GEN4` - Value - GEN4 for configuring SlotMraidLinkSpeed token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotMraidLinkSpeedEnum SlotMraidLinkSpeed
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe Slot MRAID OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotMraidStateEnum SlotMraidState
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe Slot N10 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotN10stateEnum SlotN10state
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe Slot N11 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotN11stateEnum SlotN11state
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe Slot N12 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotN12stateEnum SlotN12state
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe Slot N13 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotN13stateEnum SlotN13state
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe Slot N14 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotN14stateEnum SlotN14state
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe Slot N15 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotN15stateEnum SlotN15state
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe Slot N16 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotN16stateEnum SlotN16state
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe Slot N17 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotN17stateEnum SlotN17state
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe Slot N18 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotN18stateEnum SlotN18state
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe Slot N19 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotN19stateEnum SlotN19state
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe Slot N1 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `disabled` - Value - disabled for configuring SlotN1state token.\n* `enabled` - Value - enabled for configuring SlotN1state token.\n* `Legacy Only` - Value - Legacy Only for configuring SlotN1state token.\n* `UEFI Only` - Value - UEFI Only for configuring SlotN1state token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotN1stateEnum SlotN1state
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe Slot N20 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotN20stateEnum SlotN20state
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe Slot N21 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotN21stateEnum SlotN21state
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe Slot N22 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotN22stateEnum SlotN22state
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe Slot N23 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotN23stateEnum SlotN23state
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe Slot N24 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotN24stateEnum SlotN24state
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe Slot N2 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `disabled` - Value - disabled for configuring SlotN2state token.\n* `enabled` - Value - enabled for configuring SlotN2state token.\n* `Legacy Only` - Value - Legacy Only for configuring SlotN2state token.\n* `UEFI Only` - Value - UEFI Only for configuring SlotN2state token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotN2stateEnum SlotN2state
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe Slot N3 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotN3stateEnum SlotN3state
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe Slot N4 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotN4stateEnum SlotN4state
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe Slot N5 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotN5stateEnum SlotN5state
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe Slot N6 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotN6stateEnum SlotN6state
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe Slot N7 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotN7stateEnum SlotN7state
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe Slot N8 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotN8stateEnum SlotN8state
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe Slot N9 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotN9stateEnum SlotN9state
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting RAID Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring SlotRaidLinkSpeed token.\n* `Disabled` - Value - Disabled for configuring SlotRaidLinkSpeed token.\n* `GEN1` - Value - GEN1 for configuring SlotRaidLinkSpeed token.\n* `GEN2` - Value - GEN2 for configuring SlotRaidLinkSpeed token.\n* `GEN3` - Value - GEN3 for configuring SlotRaidLinkSpeed token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotRaidLinkSpeedEnum SlotRaidLinkSpeed
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe Slot RAID OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotRaidStateEnum SlotRaidState
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe Slot:Rear NVME 1 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring SlotRearNvme1linkSpeed token.\n* `Disabled` - Value - Disabled for configuring SlotRearNvme1linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring SlotRearNvme1linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring SlotRearNvme1linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring SlotRearNvme1linkSpeed token.\n* `GEN4` - Value - GEN4 for configuring SlotRearNvme1linkSpeed token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotRearNvme1linkSpeedEnum SlotRearNvme1linkSpeed
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe Slot:Rear NVME 1 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotRearNvme1stateEnum SlotRearNvme1state
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe Slot:Rear NVME 2 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring SlotRearNvme2linkSpeed token.\n* `Disabled` - Value - Disabled for configuring SlotRearNvme2linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring SlotRearNvme2linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring SlotRearNvme2linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring SlotRearNvme2linkSpeed token.\n* `GEN4` - Value - GEN4 for configuring SlotRearNvme2linkSpeed token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotRearNvme2linkSpeedEnum SlotRearNvme2linkSpeed
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe Slot:Rear NVME 2 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotRearNvme2stateEnum SlotRearNvme2state
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Rear NVME 3 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring SlotRearNvme3linkSpeed token.\n* `Disabled` - Value - Disabled for configuring SlotRearNvme3linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring SlotRearNvme3linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring SlotRearNvme3linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring SlotRearNvme3linkSpeed token.\n* `GEN4` - Value - GEN4 for configuring SlotRearNvme3linkSpeed token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotRearNvme3linkSpeedEnum SlotRearNvme3linkSpeed
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe Slot:Rear NVME 3 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotRearNvme3stateEnum SlotRearNvme3state
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Rear NVME 4 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring SlotRearNvme4linkSpeed token.\n* `Disabled` - Value - Disabled for configuring SlotRearNvme4linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring SlotRearNvme4linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring SlotRearNvme4linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring SlotRearNvme4linkSpeed token.\n* `GEN4` - Value - GEN4 for configuring SlotRearNvme4linkSpeed token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotRearNvme4linkSpeedEnum SlotRearNvme4linkSpeed
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe Slot:Rear NVME 4 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotRearNvme4stateEnum SlotRearNvme4state
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe Slot:Rear NVME 5 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotRearNvme5stateEnum SlotRearNvme5state
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe Slot:Rear NVME 6 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotRearNvme6stateEnum SlotRearNvme6state
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe Slot:Rear NVME 7 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotRearNvme7stateEnum SlotRearNvme7state
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe Slot:Rear NVME 8 OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotRearNvme8stateEnum SlotRearNvme8state
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe Slot:Riser1 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring SlotRiser1linkSpeed token.\n* `Disabled` - Value - Disabled for configuring SlotRiser1linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring SlotRiser1linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring SlotRiser1linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring SlotRiser1linkSpeed token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotRiser1linkSpeedEnum SlotRiser1linkSpeed
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe Slot:Riser1 Slot1 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring SlotRiser1slot1linkSpeed token.\n* `Disabled` - Value - Disabled for configuring SlotRiser1slot1linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring SlotRiser1slot1linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring SlotRiser1slot1linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring SlotRiser1slot1linkSpeed token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotRiser1slot1linkSpeedEnum SlotRiser1slot1linkSpeed
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe Slot:Riser1 Slot2 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring SlotRiser1slot2linkSpeed token.\n* `Disabled` - Value - Disabled for configuring SlotRiser1slot2linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring SlotRiser1slot2linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring SlotRiser1slot2linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring SlotRiser1slot2linkSpeed token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotRiser1slot2linkSpeedEnum SlotRiser1slot2linkSpeed
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe Slot:Riser1 Slot3 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring SlotRiser1slot3linkSpeed token.\n* `Disabled` - Value - Disabled for configuring SlotRiser1slot3linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring SlotRiser1slot3linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring SlotRiser1slot3linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring SlotRiser1slot3linkSpeed token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotRiser1slot3linkSpeedEnum SlotRiser1slot3linkSpeed
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe Slot:Riser2 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring SlotRiser2linkSpeed token.\n* `Disabled` - Value - Disabled for configuring SlotRiser2linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring SlotRiser2linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring SlotRiser2linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring SlotRiser2linkSpeed token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotRiser2linkSpeedEnum SlotRiser2linkSpeed
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe Slot:Riser2 Slot4 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring SlotRiser2slot4linkSpeed token.\n* `Disabled` - Value - Disabled for configuring SlotRiser2slot4linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring SlotRiser2slot4linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring SlotRiser2slot4linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring SlotRiser2slot4linkSpeed token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotRiser2slot4linkSpeedEnum SlotRiser2slot4linkSpeed
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe Slot:Riser2 Slot5 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring SlotRiser2slot5linkSpeed token.\n* `Disabled` - Value - Disabled for configuring SlotRiser2slot5linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring SlotRiser2slot5linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring SlotRiser2slot5linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring SlotRiser2slot5linkSpeed token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotRiser2slot5linkSpeedEnum SlotRiser2slot5linkSpeed
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe Slot:Riser2 Slot6 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring SlotRiser2slot6linkSpeed token.\n* `Disabled` - Value - Disabled for configuring SlotRiser2slot6linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring SlotRiser2slot6linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring SlotRiser2slot6linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring SlotRiser2slot6linkSpeed token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotRiser2slot6linkSpeedEnum SlotRiser2slot6linkSpeed
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe Slot:SAS OptionROM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `disabled` - Value - disabled for configuring SlotSasState token.\n* `enabled` - Value - enabled for configuring SlotSasState token.\n* `Legacy Only` - Value - Legacy Only for configuring SlotSasState token.\n* `UEFI Only` - Value - UEFI Only for configuring SlotSasState token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotSasStateEnum SlotSasState
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe Slot:FrontSSD1 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring SlotSsdSlot1linkSpeed token.\n* `Disabled` - Value - Disabled for configuring SlotSsdSlot1linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring SlotSsdSlot1linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring SlotSsdSlot1linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring SlotSsdSlot1linkSpeed token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotSsdSlot1linkSpeedEnum SlotSsdSlot1linkSpeed
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting PCIe Slot:FrontSSD2 Link Speed configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring SlotSsdSlot2linkSpeed token.\n* `Disabled` - Value - Disabled for configuring SlotSsdSlot2linkSpeed token.\n* `GEN1` - Value - GEN1 for configuring SlotSsdSlot2linkSpeed token.\n* `GEN2` - Value - GEN2 for configuring SlotSsdSlot2linkSpeed token.\n* `GEN3` - Value - GEN3 for configuring SlotSsdSlot2linkSpeed token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SlotSsdSlot2linkSpeedEnum SlotSsdSlot2linkSpeed
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting SMEE configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SmeeEnum Smee
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting SMT Mode configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring SmtMode token.\n* `Off` - Value - Off for configuring SmtMode token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SmtModeEnum SmtMode
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Sub Numa Clustering configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring Snc token.\n* `disabled` - Value - disabled for configuring Snc token.\n* `enabled` - Value - enabled for configuring Snc token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SncEnum Snc
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Snoopy Mode for 2LM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SnoopyModeFor2lmEnum SnoopyModeFor2lm
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Snoopy Mode for AD configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SnoopyModeForAdEnum SnoopyModeForAd
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Sparing Mode configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `dimm-sparing` - Value - dimm-sparing for configuring SparingMode token.\n* `rank-sparing` - Value - rank-sparing for configuring SparingMode token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SparingModeEnum SparingMode
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting SR-IOV Support configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SrIovEnum SrIov
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting DCU Streamer Prefetch configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.StreamerPrefetchEnum StreamerPrefetch
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting SVM Mode configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.SvmModeEnum SvmMode
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Terminal Type configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `pc-ansi` - Value - pc-ansi for configuring TerminalType token.\n* `vt100` - Value - vt100 for configuring TerminalType token.\n* `vt100-plus` - Value - vt100-plus for configuring TerminalType token.\n* `vt-utf8` - Value - vt-utf8 for configuring TerminalType token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.TerminalTypeEnum TerminalType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Trusted Platform Module State configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.TpmControlEnum TpmControl
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting TPM Pending Operation configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `None` - Value - None for configuring TpmPendingOperation token.\n* `TpmClear` - Value - TpmClear for configuring TpmPendingOperation token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.TpmPendingOperationEnum TpmPendingOperation
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting TPM Support configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.TpmSupportEnum TpmSupport
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Transparent Secure Memory Encryption configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring Tsme token.\n* `disabled` - Value - disabled for configuring Tsme token.\n* `enabled` - Value - enabled for configuring Tsme token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.TsmeEnum Tsme
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Intel Trusted Execution Technology Support configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.TxtSupportEnum TxtSupport
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Boot Order Rules configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Loose` - Value - Loose for configuring UcsmBootOrderRule token.\n* `Strict` - Value - Strict for configuring UcsmBootOrderRule token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.UcsmBootOrderRuleEnum UcsmBootOrderRule
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Uncore Frequency Scaling configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.UfsDisableEnum UfsDisable
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting UMA Based Clustering configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Disable (All2All)` - Value - Disable (All2All) for configuring UmaBasedClustering token.\n* `Hemisphere (2-clusters)` - Value - Hemisphere (2-clusters) for configuring UmaBasedClustering token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.UmaBasedClusteringEnum UmaBasedClustering
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting UPI Link Enablement configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `1` - Value - 1 for configuring UpiLinkEnablement token.\n* `2` - Value - 2 for configuring UpiLinkEnablement token.\n* `Auto` - Value - Auto for configuring UpiLinkEnablement token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.UpiLinkEnablementEnum UpiLinkEnablement
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting UPI Power Manangement configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.UpiPowerManagementEnum UpiPowerManagement
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Port 60/64 Emulation configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.UsbEmul6064Enum UsbEmul6064
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting USB Port Front configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.UsbPortFrontEnum UsbPortFront
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting USB Port Internal configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.UsbPortInternalEnum UsbPortInternal
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting USB Port KVM configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.UsbPortKvmEnum UsbPortKvm
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting USB Port Rear configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.UsbPortRearEnum UsbPortRear
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting USB Port SD Card configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.UsbPortSdCardEnum UsbPortSdCard
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting USB Port VMedia configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.UsbPortVmediaEnum UsbPortVmedia
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting XHCI Legacy Support configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.UsbXhciSupportEnum UsbXhciSupport
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting VGA Priority configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Offboard` - Value - Offboard for configuring VgaPriority token.\n* `Onboard` - Value - Onboard for configuring VgaPriority token.\n* `Onboard VGA Disabled` - Value - Onboard VGA Disabled for configuring VgaPriority token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.VgaPriorityEnum VgaPriority
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Virtual NUMA configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.VirtualNumaEnum VirtualNuma
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting VMD Enablement configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `enabled` - Enables the BIOS setting.\n* `disabled` - Disables the BIOS setting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.VmdEnableEnum VmdEnable
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Volatile Memory Mode configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `1LM` - Value - 1LM for configuring VolMemoryMode token.\n* `2LM` - Value - 2LM for configuring VolMemoryMode token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.VolMemoryModeEnum VolMemoryMode
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting Workload Configuration configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Balanced` - Value - Balanced for configuring WorkLoadConfig token.\n* `I/O Sensitive` - Value - I/O Sensitive for configuring WorkLoadConfig token.\n* `NUMA` - Value - NUMA for configuring WorkLoadConfig token.\n* `UMA` - Value - UMA for configuring WorkLoadConfig token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.WorkLoadConfigEnum WorkLoadConfig
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting XPT Prefetch configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring XptPrefetch token.\n* `disabled` - Value - disabled for configuring XptPrefetch token.\n* `enabled` - Value - enabled for configuring XptPrefetch token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.XptPrefetchEnum XptPrefetch
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BIOS Token for setting XPT Remote Prefetch configuration.\n* `platform-default` - Default value used by the platform for the BIOS setting.\n* `Auto` - Value - Auto for configuring XptRemotePrefetch token.\n* `disabled` - Value - disabled for configuring XptRemotePrefetch token.\n* `enabled` - Value - enabled for configuring XptRemotePrefetch token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosPolicy.XptRemotePrefetchEnum XptRemotePrefetch
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.BiosPolicy initObject = new Intersight.Model.BiosPolicy();
            if (this.MyInvocation.BoundParameters.ContainsKey("AcsControlGpu1state"))
            {
                initObject.AcsControlGpu1state = this.AcsControlGpu1state;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AcsControlGpu2state"))
            {
                initObject.AcsControlGpu2state = this.AcsControlGpu2state;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AcsControlGpu3state"))
            {
                initObject.AcsControlGpu3state = this.AcsControlGpu3state;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AcsControlGpu4state"))
            {
                initObject.AcsControlGpu4state = this.AcsControlGpu4state;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AcsControlGpu5state"))
            {
                initObject.AcsControlGpu5state = this.AcsControlGpu5state;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AcsControlGpu6state"))
            {
                initObject.AcsControlGpu6state = this.AcsControlGpu6state;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AcsControlGpu7state"))
            {
                initObject.AcsControlGpu7state = this.AcsControlGpu7state;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AcsControlGpu8state"))
            {
                initObject.AcsControlGpu8state = this.AcsControlGpu8state;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AcsControlSlot11state"))
            {
                initObject.AcsControlSlot11state = this.AcsControlSlot11state;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AcsControlSlot12state"))
            {
                initObject.AcsControlSlot12state = this.AcsControlSlot12state;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AcsControlSlot13state"))
            {
                initObject.AcsControlSlot13state = this.AcsControlSlot13state;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AcsControlSlot14state"))
            {
                initObject.AcsControlSlot14state = this.AcsControlSlot14state;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdjacentCacheLinePrefetch"))
            {
                initObject.AdjacentCacheLinePrefetch = this.AdjacentCacheLinePrefetch;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdvancedMemTest"))
            {
                initObject.AdvancedMemTest = this.AdvancedMemTest;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AllUsbDevices"))
            {
                initObject.AllUsbDevices = this.AllUsbDevices;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Altitude"))
            {
                initObject.Altitude = this.Altitude;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AspmSupport"))
            {
                initObject.AspmSupport = this.AspmSupport;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AssertNmiOnPerr"))
            {
                initObject.AssertNmiOnPerr = this.AssertNmiOnPerr;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AssertNmiOnSerr"))
            {
                initObject.AssertNmiOnSerr = this.AssertNmiOnSerr;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AutoCcState"))
            {
                initObject.AutoCcState = this.AutoCcState;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AutonumousCstateEnable"))
            {
                initObject.AutonumousCstateEnable = this.AutonumousCstateEnable;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BaudRate"))
            {
                initObject.BaudRate = this.BaudRate;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BmeDmaMitigation"))
            {
                initObject.BmeDmaMitigation = this.BmeDmaMitigation;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BootOptionNumRetry"))
            {
                initObject.BootOptionNumRetry = this.BootOptionNumRetry;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BootOptionReCoolDown"))
            {
                initObject.BootOptionReCoolDown = this.BootOptionReCoolDown;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BootOptionRetry"))
            {
                initObject.BootOptionRetry = this.BootOptionRetry;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BootPerformanceMode"))
            {
                initObject.BootPerformanceMode = this.BootPerformanceMode;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BurstAndPostponedRefresh"))
            {
                initObject.BurstAndPostponedRefresh = this.BurstAndPostponedRefresh;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("C1autoDemotion"))
            {
                initObject.C1autoDemotion = this.C1autoDemotion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("C1autoUnDemotion"))
            {
                initObject.C1autoUnDemotion = this.C1autoUnDemotion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CbsCmnApbdis"))
            {
                initObject.CbsCmnApbdis = this.CbsCmnApbdis;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CbsCmnCpuCpb"))
            {
                initObject.CbsCmnCpuCpb = this.CbsCmnCpuCpb;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CbsCmnCpuGenDowncoreCtrl"))
            {
                initObject.CbsCmnCpuGenDowncoreCtrl = this.CbsCmnCpuGenDowncoreCtrl;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CbsCmnCpuGlobalCstateCtrl"))
            {
                initObject.CbsCmnCpuGlobalCstateCtrl = this.CbsCmnCpuGlobalCstateCtrl;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CbsCmnCpuL1streamHwPrefetcher"))
            {
                initObject.CbsCmnCpuL1streamHwPrefetcher = this.CbsCmnCpuL1streamHwPrefetcher;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CbsCmnCpuL2streamHwPrefetcher"))
            {
                initObject.CbsCmnCpuL2streamHwPrefetcher = this.CbsCmnCpuL2streamHwPrefetcher;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CbsCmnCpuSmee"))
            {
                initObject.CbsCmnCpuSmee = this.CbsCmnCpuSmee;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CbsCmnCpuStreamingStoresCtrl"))
            {
                initObject.CbsCmnCpuStreamingStoresCtrl = this.CbsCmnCpuStreamingStoresCtrl;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CbsCmnDeterminismSlider"))
            {
                initObject.CbsCmnDeterminismSlider = this.CbsCmnDeterminismSlider;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CbsCmnEfficiencyModeEn"))
            {
                initObject.CbsCmnEfficiencyModeEn = this.CbsCmnEfficiencyModeEn;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CbsCmnFixedSocPstate"))
            {
                initObject.CbsCmnFixedSocPstate = this.CbsCmnFixedSocPstate;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CbsCmnGnbNbIommu"))
            {
                initObject.CbsCmnGnbNbIommu = this.CbsCmnGnbNbIommu;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CbsCmnGnbSmuDfCstates"))
            {
                initObject.CbsCmnGnbSmuDfCstates = this.CbsCmnGnbSmuDfCstates;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CbsCmnGnbSmucppc"))
            {
                initObject.CbsCmnGnbSmucppc = this.CbsCmnGnbSmucppc;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CbsCmnMemCtrlBankGroupSwapDdr4"))
            {
                initObject.CbsCmnMemCtrlBankGroupSwapDdr4 = this.CbsCmnMemCtrlBankGroupSwapDdr4;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CbsCmnMemMapBankInterleaveDdr4"))
            {
                initObject.CbsCmnMemMapBankInterleaveDdr4 = this.CbsCmnMemMapBankInterleaveDdr4;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CbsCmncTdpCtl"))
            {
                initObject.CbsCmncTdpCtl = this.CbsCmncTdpCtl;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CbsCpuCcdCtrlSsp"))
            {
                initObject.CbsCpuCcdCtrlSsp = this.CbsCpuCcdCtrlSsp;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CbsCpuCoreCtrl"))
            {
                initObject.CbsCpuCoreCtrl = this.CbsCpuCoreCtrl;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CbsCpuSmtCtrl"))
            {
                initObject.CbsCpuSmtCtrl = this.CbsCpuSmtCtrl;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CbsDbgCpuSnpMemCover"))
            {
                initObject.CbsDbgCpuSnpMemCover = this.CbsDbgCpuSnpMemCover;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CbsDbgCpuSnpMemSizeCover"))
            {
                initObject.CbsDbgCpuSnpMemSizeCover = this.CbsDbgCpuSnpMemSizeCover;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CbsDfCmnAcpiSratL3numa"))
            {
                initObject.CbsDfCmnAcpiSratL3numa = this.CbsDfCmnAcpiSratL3numa;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CbsDfCmnDramNps"))
            {
                initObject.CbsDfCmnDramNps = this.CbsDfCmnDramNps;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CbsDfCmnMemIntlv"))
            {
                initObject.CbsDfCmnMemIntlv = this.CbsDfCmnMemIntlv;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CbsDfCmnMemIntlvSize"))
            {
                initObject.CbsDfCmnMemIntlvSize = this.CbsDfCmnMemIntlvSize;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CbsSevSnpSupport"))
            {
                initObject.CbsSevSnpSupport = this.CbsSevSnpSupport;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CdnEnable"))
            {
                initObject.CdnEnable = this.CdnEnable;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CdnSupport"))
            {
                initObject.CdnSupport = this.CdnSupport;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ChannelInterLeave"))
            {
                initObject.ChannelInterLeave = this.ChannelInterLeave;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CiscoAdaptiveMemTraining"))
            {
                initObject.CiscoAdaptiveMemTraining = this.CiscoAdaptiveMemTraining;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CiscoDebugLevel"))
            {
                initObject.CiscoDebugLevel = this.CiscoDebugLevel;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CiscoOpromLaunchOptimization"))
            {
                initObject.CiscoOpromLaunchOptimization = this.CiscoOpromLaunchOptimization;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CiscoXgmiMaxSpeed"))
            {
                initObject.CiscoXgmiMaxSpeed = this.CiscoXgmiMaxSpeed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CkeLowPolicy"))
            {
                initObject.CkeLowPolicy = this.CkeLowPolicy;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ClosedLoopThermThrotl"))
            {
                initObject.ClosedLoopThermThrotl = this.ClosedLoopThermThrotl;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CmciEnable"))
            {
                initObject.CmciEnable = this.CmciEnable;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ConfigTdp"))
            {
                initObject.ConfigTdp = this.ConfigTdp;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ConfigTdpLevel"))
            {
                initObject.ConfigTdpLevel = this.ConfigTdpLevel;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ConsoleRedirection"))
            {
                initObject.ConsoleRedirection = this.ConsoleRedirection;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CoreMultiProcessing"))
            {
                initObject.CoreMultiProcessing = this.CoreMultiProcessing;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CpuEnergyPerformance"))
            {
                initObject.CpuEnergyPerformance = this.CpuEnergyPerformance;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CpuFrequencyFloor"))
            {
                initObject.CpuFrequencyFloor = this.CpuFrequencyFloor;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CpuPerfEnhancement"))
            {
                initObject.CpuPerfEnhancement = this.CpuPerfEnhancement;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CpuPerformance"))
            {
                initObject.CpuPerformance = this.CpuPerformance;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CpuPowerManagement"))
            {
                initObject.CpuPowerManagement = this.CpuPowerManagement;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CrQos"))
            {
                initObject.CrQos = this.CrQos;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CrfastgoConfig"))
            {
                initObject.CrfastgoConfig = this.CrfastgoConfig;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DcpmmFirmwareDowngrade"))
            {
                initObject.DcpmmFirmwareDowngrade = this.DcpmmFirmwareDowngrade;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DemandScrub"))
            {
                initObject.DemandScrub = this.DemandScrub;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DirectCacheAccess"))
            {
                initObject.DirectCacheAccess = this.DirectCacheAccess;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DramClockThrottling"))
            {
                initObject.DramClockThrottling = this.DramClockThrottling;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DramRefreshRate"))
            {
                initObject.DramRefreshRate = this.DramRefreshRate;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DramSwThermalThrottling"))
            {
                initObject.DramSwThermalThrottling = this.DramSwThermalThrottling;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EadrSupport"))
            {
                initObject.EadrSupport = this.EadrSupport;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EdpcEn"))
            {
                initObject.EdpcEn = this.EdpcEn;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EnableClockSpreadSpec"))
            {
                initObject.EnableClockSpreadSpec = this.EnableClockSpreadSpec;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EnableMktme"))
            {
                initObject.EnableMktme = this.EnableMktme;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EnableSgx"))
            {
                initObject.EnableSgx = this.EnableSgx;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EnableTme"))
            {
                initObject.EnableTme = this.EnableTme;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EnergyEfficientTurbo"))
            {
                initObject.EnergyEfficientTurbo = this.EnergyEfficientTurbo;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EngPerfTuning"))
            {
                initObject.EngPerfTuning = this.EngPerfTuning;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EnhancedIntelSpeedStepTech"))
            {
                initObject.EnhancedIntelSpeedStepTech = this.EnhancedIntelSpeedStepTech;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EpochUpdate"))
            {
                initObject.EpochUpdate = this.EpochUpdate;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EppEnable"))
            {
                initObject.EppEnable = this.EppEnable;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EppProfile"))
            {
                initObject.EppProfile = this.EppProfile;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ExecuteDisableBit"))
            {
                initObject.ExecuteDisableBit = this.ExecuteDisableBit;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ExtendedApic"))
            {
                initObject.ExtendedApic = this.ExtendedApic;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FlowControl"))
            {
                initObject.FlowControl = this.FlowControl;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Frb2enable"))
            {
                initObject.Frb2enable = this.Frb2enable;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HardwarePrefetch"))
            {
                initObject.HardwarePrefetch = this.HardwarePrefetch;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HwpmEnable"))
            {
                initObject.HwpmEnable = this.HwpmEnable;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ImcInterleave"))
            {
                initObject.ImcInterleave = this.ImcInterleave;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IntelDynamicSpeedSelect"))
            {
                initObject.IntelDynamicSpeedSelect = this.IntelDynamicSpeedSelect;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IntelHyperThreadingTech"))
            {
                initObject.IntelHyperThreadingTech = this.IntelHyperThreadingTech;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IntelSpeedSelect"))
            {
                initObject.IntelSpeedSelect = this.IntelSpeedSelect;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IntelTurboBoostTech"))
            {
                initObject.IntelTurboBoostTech = this.IntelTurboBoostTech;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IntelVirtualizationTechnology"))
            {
                initObject.IntelVirtualizationTechnology = this.IntelVirtualizationTechnology;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IntelVtForDirectedIo"))
            {
                initObject.IntelVtForDirectedIo = this.IntelVtForDirectedIo;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IntelVtdCoherencySupport"))
            {
                initObject.IntelVtdCoherencySupport = this.IntelVtdCoherencySupport;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IntelVtdInterruptRemapping"))
            {
                initObject.IntelVtdInterruptRemapping = this.IntelVtdInterruptRemapping;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IntelVtdPassThroughDmaSupport"))
            {
                initObject.IntelVtdPassThroughDmaSupport = this.IntelVtdPassThroughDmaSupport;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IntelVtdatsSupport"))
            {
                initObject.IntelVtdatsSupport = this.IntelVtdatsSupport;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IohErrorEnable"))
            {
                initObject.IohErrorEnable = this.IohErrorEnable;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IohResource"))
            {
                initObject.IohResource = this.IohResource;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IpPrefetch"))
            {
                initObject.IpPrefetch = this.IpPrefetch;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Ipv4http"))
            {
                initObject.Ipv4http = this.Ipv4http;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Ipv4pxe"))
            {
                initObject.Ipv4pxe = this.Ipv4pxe;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Ipv6http"))
            {
                initObject.Ipv6http = this.Ipv6http;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Ipv6pxe"))
            {
                initObject.Ipv6pxe = this.Ipv6pxe;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("KtiPrefetch"))
            {
                initObject.KtiPrefetch = this.KtiPrefetch;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LegacyOsRedirection"))
            {
                initObject.LegacyOsRedirection = this.LegacyOsRedirection;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LegacyUsbSupport"))
            {
                initObject.LegacyUsbSupport = this.LegacyUsbSupport;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LlcAlloc"))
            {
                initObject.LlcAlloc = this.LlcAlloc;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LlcPrefetch"))
            {
                initObject.LlcPrefetch = this.LlcPrefetch;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LomPort0state"))
            {
                initObject.LomPort0state = this.LomPort0state;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LomPort1state"))
            {
                initObject.LomPort1state = this.LomPort1state;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LomPort2state"))
            {
                initObject.LomPort2state = this.LomPort2state;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LomPort3state"))
            {
                initObject.LomPort3state = this.LomPort3state;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LomPortsAllState"))
            {
                initObject.LomPortsAllState = this.LomPortsAllState;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LvDdrMode"))
            {
                initObject.LvDdrMode = this.LvDdrMode;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MakeDeviceNonBootable"))
            {
                initObject.MakeDeviceNonBootable = this.MakeDeviceNonBootable;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MemoryBandwidthBoost"))
            {
                initObject.MemoryBandwidthBoost = this.MemoryBandwidthBoost;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MemoryInterLeave"))
            {
                initObject.MemoryInterLeave = this.MemoryInterLeave;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MemoryMappedIoAbove4gb"))
            {
                initObject.MemoryMappedIoAbove4gb = this.MemoryMappedIoAbove4gb;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MemoryRefreshRate"))
            {
                initObject.MemoryRefreshRate = this.MemoryRefreshRate;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MemorySizeLimit"))
            {
                initObject.MemorySizeLimit = this.MemorySizeLimit;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MemoryThermalThrottling"))
            {
                initObject.MemoryThermalThrottling = this.MemoryThermalThrottling;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MirroringMode"))
            {
                initObject.MirroringMode = this.MirroringMode;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MmcfgBase"))
            {
                initObject.MmcfgBase = this.MmcfgBase;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NetworkStack"))
            {
                initObject.NetworkStack = this.NetworkStack;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NumaOptimized"))
            {
                initObject.NumaOptimized = this.NumaOptimized;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NvmdimmPerformConfig"))
            {
                initObject.NvmdimmPerformConfig = this.NvmdimmPerformConfig;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Onboard10gbitLom"))
            {
                initObject.Onboard10gbitLom = this.Onboard10gbitLom;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("OnboardGbitLom"))
            {
                initObject.OnboardGbitLom = this.OnboardGbitLom;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("OnboardScuStorageSupport"))
            {
                initObject.OnboardScuStorageSupport = this.OnboardScuStorageSupport;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("OnboardScuStorageSwStack"))
            {
                initObject.OnboardScuStorageSwStack = this.OnboardScuStorageSwStack;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("OperationMode"))
            {
                initObject.OperationMode = this.OperationMode;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Organization"))
            {
                initObject.Organization = this.Organization;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("OsBootWatchdogTimer"))
            {
                initObject.OsBootWatchdogTimer = this.OsBootWatchdogTimer;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("OsBootWatchdogTimerPolicy"))
            {
                initObject.OsBootWatchdogTimerPolicy = this.OsBootWatchdogTimerPolicy;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("OsBootWatchdogTimerTimeout"))
            {
                initObject.OsBootWatchdogTimerTimeout = this.OsBootWatchdogTimerTimeout;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("OutOfBandMgmtPort"))
            {
                initObject.OutOfBandMgmtPort = this.OutOfBandMgmtPort;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PackageCstateLimit"))
            {
                initObject.PackageCstateLimit = this.PackageCstateLimit;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PanicHighWatermark"))
            {
                initObject.PanicHighWatermark = this.PanicHighWatermark;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PartialCacheLineSparing"))
            {
                initObject.PartialCacheLineSparing = this.PartialCacheLineSparing;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PartialMirrorModeConfig"))
            {
                initObject.PartialMirrorModeConfig = this.PartialMirrorModeConfig;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PartialMirrorPercent"))
            {
                initObject.PartialMirrorPercent = this.PartialMirrorPercent;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PartialMirrorValue1"))
            {
                initObject.PartialMirrorValue1 = this.PartialMirrorValue1;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PartialMirrorValue2"))
            {
                initObject.PartialMirrorValue2 = this.PartialMirrorValue2;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PartialMirrorValue3"))
            {
                initObject.PartialMirrorValue3 = this.PartialMirrorValue3;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PartialMirrorValue4"))
            {
                initObject.PartialMirrorValue4 = this.PartialMirrorValue4;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PatrolScrub"))
            {
                initObject.PatrolScrub = this.PatrolScrub;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PatrolScrubDuration"))
            {
                initObject.PatrolScrubDuration = this.PatrolScrubDuration;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PcIeRasSupport"))
            {
                initObject.PcIeRasSupport = this.PcIeRasSupport;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PcIeSsdHotPlugSupport"))
            {
                initObject.PcIeSsdHotPlugSupport = this.PcIeSsdHotPlugSupport;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PchUsb30mode"))
            {
                initObject.PchUsb30mode = this.PchUsb30mode;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PciOptionRoMs"))
            {
                initObject.PciOptionRoMs = this.PciOptionRoMs;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PciRomClp"))
            {
                initObject.PciRomClp = this.PciRomClp;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PcieAriSupport"))
            {
                initObject.PcieAriSupport = this.PcieAriSupport;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PciePllSsc"))
            {
                initObject.PciePllSsc = this.PciePllSsc;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PcieSlotMraid1linkSpeed"))
            {
                initObject.PcieSlotMraid1linkSpeed = this.PcieSlotMraid1linkSpeed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PcieSlotMraid1optionRom"))
            {
                initObject.PcieSlotMraid1optionRom = this.PcieSlotMraid1optionRom;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PcieSlotMraid2linkSpeed"))
            {
                initObject.PcieSlotMraid2linkSpeed = this.PcieSlotMraid2linkSpeed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PcieSlotMraid2optionRom"))
            {
                initObject.PcieSlotMraid2optionRom = this.PcieSlotMraid2optionRom;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PcieSlotMstorraidLinkSpeed"))
            {
                initObject.PcieSlotMstorraidLinkSpeed = this.PcieSlotMstorraidLinkSpeed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PcieSlotMstorraidOptionRom"))
            {
                initObject.PcieSlotMstorraidOptionRom = this.PcieSlotMstorraidOptionRom;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PcieSlotNvme1linkSpeed"))
            {
                initObject.PcieSlotNvme1linkSpeed = this.PcieSlotNvme1linkSpeed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PcieSlotNvme1optionRom"))
            {
                initObject.PcieSlotNvme1optionRom = this.PcieSlotNvme1optionRom;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PcieSlotNvme2linkSpeed"))
            {
                initObject.PcieSlotNvme2linkSpeed = this.PcieSlotNvme2linkSpeed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PcieSlotNvme2optionRom"))
            {
                initObject.PcieSlotNvme2optionRom = this.PcieSlotNvme2optionRom;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PcieSlotNvme3linkSpeed"))
            {
                initObject.PcieSlotNvme3linkSpeed = this.PcieSlotNvme3linkSpeed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PcieSlotNvme3optionRom"))
            {
                initObject.PcieSlotNvme3optionRom = this.PcieSlotNvme3optionRom;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PcieSlotNvme4linkSpeed"))
            {
                initObject.PcieSlotNvme4linkSpeed = this.PcieSlotNvme4linkSpeed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PcieSlotNvme4optionRom"))
            {
                initObject.PcieSlotNvme4optionRom = this.PcieSlotNvme4optionRom;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PcieSlotNvme5linkSpeed"))
            {
                initObject.PcieSlotNvme5linkSpeed = this.PcieSlotNvme5linkSpeed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PcieSlotNvme5optionRom"))
            {
                initObject.PcieSlotNvme5optionRom = this.PcieSlotNvme5optionRom;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PcieSlotNvme6linkSpeed"))
            {
                initObject.PcieSlotNvme6linkSpeed = this.PcieSlotNvme6linkSpeed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PcieSlotNvme6optionRom"))
            {
                initObject.PcieSlotNvme6optionRom = this.PcieSlotNvme6optionRom;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PcieSlotsCdnEnable"))
            {
                initObject.PcieSlotsCdnEnable = this.PcieSlotsCdnEnable;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PopSupport"))
            {
                initObject.PopSupport = this.PopSupport;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PostErrorPause"))
            {
                initObject.PostErrorPause = this.PostErrorPause;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PostPackageRepair"))
            {
                initObject.PostPackageRepair = this.PostPackageRepair;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ProcessorC1e"))
            {
                initObject.ProcessorC1e = this.ProcessorC1e;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ProcessorC3report"))
            {
                initObject.ProcessorC3report = this.ProcessorC3report;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ProcessorC6report"))
            {
                initObject.ProcessorC6report = this.ProcessorC6report;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ProcessorCstate"))
            {
                initObject.ProcessorCstate = this.ProcessorCstate;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Profiles"))
            {
                initObject.Profiles = this.Profiles;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Psata"))
            {
                initObject.Psata = this.Psata;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PstateCoordType"))
            {
                initObject.PstateCoordType = this.PstateCoordType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PuttyKeyPad"))
            {
                initObject.PuttyKeyPad = this.PuttyKeyPad;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PwrPerfTuning"))
            {
                initObject.PwrPerfTuning = this.PwrPerfTuning;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("QpiLinkFrequency"))
            {
                initObject.QpiLinkFrequency = this.QpiLinkFrequency;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("QpiLinkSpeed"))
            {
                initObject.QpiLinkSpeed = this.QpiLinkSpeed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("QpiSnoopMode"))
            {
                initObject.QpiSnoopMode = this.QpiSnoopMode;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RankInterLeave"))
            {
                initObject.RankInterLeave = this.RankInterLeave;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RedirectionAfterPost"))
            {
                initObject.RedirectionAfterPost = this.RedirectionAfterPost;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SataModeSelect"))
            {
                initObject.SataModeSelect = this.SataModeSelect;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SelectMemoryRasConfiguration"))
            {
                initObject.SelectMemoryRasConfiguration = this.SelectMemoryRasConfiguration;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SelectPprType"))
            {
                initObject.SelectPprType = this.SelectPprType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SerialPortAenable"))
            {
                initObject.SerialPortAenable = this.SerialPortAenable;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Sev"))
            {
                initObject.Sev = this.Sev;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SgxAutoRegistrationAgent"))
            {
                initObject.SgxAutoRegistrationAgent = this.SgxAutoRegistrationAgent;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SgxEpoch0"))
            {
                initObject.SgxEpoch0 = this.SgxEpoch0;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SgxEpoch1"))
            {
                initObject.SgxEpoch1 = this.SgxEpoch1;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SgxFactoryReset"))
            {
                initObject.SgxFactoryReset = this.SgxFactoryReset;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SgxLePubKeyHash0"))
            {
                initObject.SgxLePubKeyHash0 = this.SgxLePubKeyHash0;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SgxLePubKeyHash1"))
            {
                initObject.SgxLePubKeyHash1 = this.SgxLePubKeyHash1;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SgxLePubKeyHash2"))
            {
                initObject.SgxLePubKeyHash2 = this.SgxLePubKeyHash2;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SgxLePubKeyHash3"))
            {
                initObject.SgxLePubKeyHash3 = this.SgxLePubKeyHash3;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SgxLeWr"))
            {
                initObject.SgxLeWr = this.SgxLeWr;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SgxPackageInfoInBandAccess"))
            {
                initObject.SgxPackageInfoInBandAccess = this.SgxPackageInfoInBandAccess;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SgxQos"))
            {
                initObject.SgxQos = this.SgxQos;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Sha1pcrBank"))
            {
                initObject.Sha1pcrBank = this.Sha1pcrBank;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Sha256pcrBank"))
            {
                initObject.Sha256pcrBank = this.Sha256pcrBank;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SinglePctlEnable"))
            {
                initObject.SinglePctlEnable = this.SinglePctlEnable;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Slot10linkSpeed"))
            {
                initObject.Slot10linkSpeed = this.Slot10linkSpeed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Slot10state"))
            {
                initObject.Slot10state = this.Slot10state;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Slot11linkSpeed"))
            {
                initObject.Slot11linkSpeed = this.Slot11linkSpeed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Slot11state"))
            {
                initObject.Slot11state = this.Slot11state;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Slot12linkSpeed"))
            {
                initObject.Slot12linkSpeed = this.Slot12linkSpeed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Slot12state"))
            {
                initObject.Slot12state = this.Slot12state;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Slot13state"))
            {
                initObject.Slot13state = this.Slot13state;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Slot14state"))
            {
                initObject.Slot14state = this.Slot14state;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Slot1linkSpeed"))
            {
                initObject.Slot1linkSpeed = this.Slot1linkSpeed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Slot1state"))
            {
                initObject.Slot1state = this.Slot1state;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Slot2linkSpeed"))
            {
                initObject.Slot2linkSpeed = this.Slot2linkSpeed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Slot2state"))
            {
                initObject.Slot2state = this.Slot2state;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Slot3linkSpeed"))
            {
                initObject.Slot3linkSpeed = this.Slot3linkSpeed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Slot3state"))
            {
                initObject.Slot3state = this.Slot3state;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Slot4linkSpeed"))
            {
                initObject.Slot4linkSpeed = this.Slot4linkSpeed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Slot4state"))
            {
                initObject.Slot4state = this.Slot4state;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Slot5linkSpeed"))
            {
                initObject.Slot5linkSpeed = this.Slot5linkSpeed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Slot5state"))
            {
                initObject.Slot5state = this.Slot5state;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Slot6linkSpeed"))
            {
                initObject.Slot6linkSpeed = this.Slot6linkSpeed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Slot6state"))
            {
                initObject.Slot6state = this.Slot6state;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Slot7linkSpeed"))
            {
                initObject.Slot7linkSpeed = this.Slot7linkSpeed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Slot7state"))
            {
                initObject.Slot7state = this.Slot7state;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Slot8linkSpeed"))
            {
                initObject.Slot8linkSpeed = this.Slot8linkSpeed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Slot8state"))
            {
                initObject.Slot8state = this.Slot8state;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Slot9linkSpeed"))
            {
                initObject.Slot9linkSpeed = this.Slot9linkSpeed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Slot9state"))
            {
                initObject.Slot9state = this.Slot9state;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotFlomLinkSpeed"))
            {
                initObject.SlotFlomLinkSpeed = this.SlotFlomLinkSpeed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotFrontNvme10linkSpeed"))
            {
                initObject.SlotFrontNvme10linkSpeed = this.SlotFrontNvme10linkSpeed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotFrontNvme10optionRom"))
            {
                initObject.SlotFrontNvme10optionRom = this.SlotFrontNvme10optionRom;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotFrontNvme11linkSpeed"))
            {
                initObject.SlotFrontNvme11linkSpeed = this.SlotFrontNvme11linkSpeed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotFrontNvme11optionRom"))
            {
                initObject.SlotFrontNvme11optionRom = this.SlotFrontNvme11optionRom;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotFrontNvme12linkSpeed"))
            {
                initObject.SlotFrontNvme12linkSpeed = this.SlotFrontNvme12linkSpeed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotFrontNvme12optionRom"))
            {
                initObject.SlotFrontNvme12optionRom = this.SlotFrontNvme12optionRom;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotFrontNvme13optionRom"))
            {
                initObject.SlotFrontNvme13optionRom = this.SlotFrontNvme13optionRom;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotFrontNvme14optionRom"))
            {
                initObject.SlotFrontNvme14optionRom = this.SlotFrontNvme14optionRom;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotFrontNvme15optionRom"))
            {
                initObject.SlotFrontNvme15optionRom = this.SlotFrontNvme15optionRom;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotFrontNvme16optionRom"))
            {
                initObject.SlotFrontNvme16optionRom = this.SlotFrontNvme16optionRom;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotFrontNvme17optionRom"))
            {
                initObject.SlotFrontNvme17optionRom = this.SlotFrontNvme17optionRom;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotFrontNvme18optionRom"))
            {
                initObject.SlotFrontNvme18optionRom = this.SlotFrontNvme18optionRom;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotFrontNvme19optionRom"))
            {
                initObject.SlotFrontNvme19optionRom = this.SlotFrontNvme19optionRom;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotFrontNvme1linkSpeed"))
            {
                initObject.SlotFrontNvme1linkSpeed = this.SlotFrontNvme1linkSpeed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotFrontNvme1optionRom"))
            {
                initObject.SlotFrontNvme1optionRom = this.SlotFrontNvme1optionRom;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotFrontNvme20optionRom"))
            {
                initObject.SlotFrontNvme20optionRom = this.SlotFrontNvme20optionRom;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotFrontNvme21optionRom"))
            {
                initObject.SlotFrontNvme21optionRom = this.SlotFrontNvme21optionRom;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotFrontNvme22optionRom"))
            {
                initObject.SlotFrontNvme22optionRom = this.SlotFrontNvme22optionRom;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotFrontNvme23optionRom"))
            {
                initObject.SlotFrontNvme23optionRom = this.SlotFrontNvme23optionRom;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotFrontNvme24optionRom"))
            {
                initObject.SlotFrontNvme24optionRom = this.SlotFrontNvme24optionRom;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotFrontNvme2linkSpeed"))
            {
                initObject.SlotFrontNvme2linkSpeed = this.SlotFrontNvme2linkSpeed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotFrontNvme2optionRom"))
            {
                initObject.SlotFrontNvme2optionRom = this.SlotFrontNvme2optionRom;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotFrontNvme3linkSpeed"))
            {
                initObject.SlotFrontNvme3linkSpeed = this.SlotFrontNvme3linkSpeed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotFrontNvme3optionRom"))
            {
                initObject.SlotFrontNvme3optionRom = this.SlotFrontNvme3optionRom;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotFrontNvme4linkSpeed"))
            {
                initObject.SlotFrontNvme4linkSpeed = this.SlotFrontNvme4linkSpeed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotFrontNvme4optionRom"))
            {
                initObject.SlotFrontNvme4optionRom = this.SlotFrontNvme4optionRom;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotFrontNvme5linkSpeed"))
            {
                initObject.SlotFrontNvme5linkSpeed = this.SlotFrontNvme5linkSpeed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotFrontNvme5optionRom"))
            {
                initObject.SlotFrontNvme5optionRom = this.SlotFrontNvme5optionRom;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotFrontNvme6linkSpeed"))
            {
                initObject.SlotFrontNvme6linkSpeed = this.SlotFrontNvme6linkSpeed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotFrontNvme6optionRom"))
            {
                initObject.SlotFrontNvme6optionRom = this.SlotFrontNvme6optionRom;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotFrontNvme7linkSpeed"))
            {
                initObject.SlotFrontNvme7linkSpeed = this.SlotFrontNvme7linkSpeed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotFrontNvme7optionRom"))
            {
                initObject.SlotFrontNvme7optionRom = this.SlotFrontNvme7optionRom;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotFrontNvme8linkSpeed"))
            {
                initObject.SlotFrontNvme8linkSpeed = this.SlotFrontNvme8linkSpeed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotFrontNvme8optionRom"))
            {
                initObject.SlotFrontNvme8optionRom = this.SlotFrontNvme8optionRom;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotFrontNvme9linkSpeed"))
            {
                initObject.SlotFrontNvme9linkSpeed = this.SlotFrontNvme9linkSpeed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotFrontNvme9optionRom"))
            {
                initObject.SlotFrontNvme9optionRom = this.SlotFrontNvme9optionRom;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotFrontSlot5linkSpeed"))
            {
                initObject.SlotFrontSlot5linkSpeed = this.SlotFrontSlot5linkSpeed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotFrontSlot6linkSpeed"))
            {
                initObject.SlotFrontSlot6linkSpeed = this.SlotFrontSlot6linkSpeed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotGpu1state"))
            {
                initObject.SlotGpu1state = this.SlotGpu1state;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotGpu2state"))
            {
                initObject.SlotGpu2state = this.SlotGpu2state;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotGpu3state"))
            {
                initObject.SlotGpu3state = this.SlotGpu3state;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotGpu4state"))
            {
                initObject.SlotGpu4state = this.SlotGpu4state;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotGpu5state"))
            {
                initObject.SlotGpu5state = this.SlotGpu5state;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotGpu6state"))
            {
                initObject.SlotGpu6state = this.SlotGpu6state;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotGpu7state"))
            {
                initObject.SlotGpu7state = this.SlotGpu7state;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotGpu8state"))
            {
                initObject.SlotGpu8state = this.SlotGpu8state;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotHbaLinkSpeed"))
            {
                initObject.SlotHbaLinkSpeed = this.SlotHbaLinkSpeed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotHbaState"))
            {
                initObject.SlotHbaState = this.SlotHbaState;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotLom1link"))
            {
                initObject.SlotLom1link = this.SlotLom1link;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotLom2link"))
            {
                initObject.SlotLom2link = this.SlotLom2link;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotMezzState"))
            {
                initObject.SlotMezzState = this.SlotMezzState;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotMlomLinkSpeed"))
            {
                initObject.SlotMlomLinkSpeed = this.SlotMlomLinkSpeed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotMlomState"))
            {
                initObject.SlotMlomState = this.SlotMlomState;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotMraidLinkSpeed"))
            {
                initObject.SlotMraidLinkSpeed = this.SlotMraidLinkSpeed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotMraidState"))
            {
                initObject.SlotMraidState = this.SlotMraidState;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotN10state"))
            {
                initObject.SlotN10state = this.SlotN10state;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotN11state"))
            {
                initObject.SlotN11state = this.SlotN11state;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotN12state"))
            {
                initObject.SlotN12state = this.SlotN12state;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotN13state"))
            {
                initObject.SlotN13state = this.SlotN13state;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotN14state"))
            {
                initObject.SlotN14state = this.SlotN14state;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotN15state"))
            {
                initObject.SlotN15state = this.SlotN15state;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotN16state"))
            {
                initObject.SlotN16state = this.SlotN16state;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotN17state"))
            {
                initObject.SlotN17state = this.SlotN17state;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotN18state"))
            {
                initObject.SlotN18state = this.SlotN18state;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotN19state"))
            {
                initObject.SlotN19state = this.SlotN19state;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotN1state"))
            {
                initObject.SlotN1state = this.SlotN1state;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotN20state"))
            {
                initObject.SlotN20state = this.SlotN20state;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotN21state"))
            {
                initObject.SlotN21state = this.SlotN21state;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotN22state"))
            {
                initObject.SlotN22state = this.SlotN22state;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotN23state"))
            {
                initObject.SlotN23state = this.SlotN23state;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotN24state"))
            {
                initObject.SlotN24state = this.SlotN24state;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotN2state"))
            {
                initObject.SlotN2state = this.SlotN2state;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotN3state"))
            {
                initObject.SlotN3state = this.SlotN3state;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotN4state"))
            {
                initObject.SlotN4state = this.SlotN4state;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotN5state"))
            {
                initObject.SlotN5state = this.SlotN5state;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotN6state"))
            {
                initObject.SlotN6state = this.SlotN6state;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotN7state"))
            {
                initObject.SlotN7state = this.SlotN7state;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotN8state"))
            {
                initObject.SlotN8state = this.SlotN8state;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotN9state"))
            {
                initObject.SlotN9state = this.SlotN9state;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotRaidLinkSpeed"))
            {
                initObject.SlotRaidLinkSpeed = this.SlotRaidLinkSpeed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotRaidState"))
            {
                initObject.SlotRaidState = this.SlotRaidState;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotRearNvme1linkSpeed"))
            {
                initObject.SlotRearNvme1linkSpeed = this.SlotRearNvme1linkSpeed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotRearNvme1state"))
            {
                initObject.SlotRearNvme1state = this.SlotRearNvme1state;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotRearNvme2linkSpeed"))
            {
                initObject.SlotRearNvme2linkSpeed = this.SlotRearNvme2linkSpeed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotRearNvme2state"))
            {
                initObject.SlotRearNvme2state = this.SlotRearNvme2state;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotRearNvme3linkSpeed"))
            {
                initObject.SlotRearNvme3linkSpeed = this.SlotRearNvme3linkSpeed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotRearNvme3state"))
            {
                initObject.SlotRearNvme3state = this.SlotRearNvme3state;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotRearNvme4linkSpeed"))
            {
                initObject.SlotRearNvme4linkSpeed = this.SlotRearNvme4linkSpeed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotRearNvme4state"))
            {
                initObject.SlotRearNvme4state = this.SlotRearNvme4state;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotRearNvme5state"))
            {
                initObject.SlotRearNvme5state = this.SlotRearNvme5state;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotRearNvme6state"))
            {
                initObject.SlotRearNvme6state = this.SlotRearNvme6state;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotRearNvme7state"))
            {
                initObject.SlotRearNvme7state = this.SlotRearNvme7state;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotRearNvme8state"))
            {
                initObject.SlotRearNvme8state = this.SlotRearNvme8state;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotRiser1linkSpeed"))
            {
                initObject.SlotRiser1linkSpeed = this.SlotRiser1linkSpeed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotRiser1slot1linkSpeed"))
            {
                initObject.SlotRiser1slot1linkSpeed = this.SlotRiser1slot1linkSpeed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotRiser1slot2linkSpeed"))
            {
                initObject.SlotRiser1slot2linkSpeed = this.SlotRiser1slot2linkSpeed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotRiser1slot3linkSpeed"))
            {
                initObject.SlotRiser1slot3linkSpeed = this.SlotRiser1slot3linkSpeed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotRiser2linkSpeed"))
            {
                initObject.SlotRiser2linkSpeed = this.SlotRiser2linkSpeed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotRiser2slot4linkSpeed"))
            {
                initObject.SlotRiser2slot4linkSpeed = this.SlotRiser2slot4linkSpeed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotRiser2slot5linkSpeed"))
            {
                initObject.SlotRiser2slot5linkSpeed = this.SlotRiser2slot5linkSpeed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotRiser2slot6linkSpeed"))
            {
                initObject.SlotRiser2slot6linkSpeed = this.SlotRiser2slot6linkSpeed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotSasState"))
            {
                initObject.SlotSasState = this.SlotSasState;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotSsdSlot1linkSpeed"))
            {
                initObject.SlotSsdSlot1linkSpeed = this.SlotSsdSlot1linkSpeed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotSsdSlot2linkSpeed"))
            {
                initObject.SlotSsdSlot2linkSpeed = this.SlotSsdSlot2linkSpeed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Smee"))
            {
                initObject.Smee = this.Smee;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SmtMode"))
            {
                initObject.SmtMode = this.SmtMode;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Snc"))
            {
                initObject.Snc = this.Snc;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SnoopyModeFor2lm"))
            {
                initObject.SnoopyModeFor2lm = this.SnoopyModeFor2lm;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SnoopyModeForAd"))
            {
                initObject.SnoopyModeForAd = this.SnoopyModeForAd;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SparingMode"))
            {
                initObject.SparingMode = this.SparingMode;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SrIov"))
            {
                initObject.SrIov = this.SrIov;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("StreamerPrefetch"))
            {
                initObject.StreamerPrefetch = this.StreamerPrefetch;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SvmMode"))
            {
                initObject.SvmMode = this.SvmMode;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TerminalType"))
            {
                initObject.TerminalType = this.TerminalType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TpmControl"))
            {
                initObject.TpmControl = this.TpmControl;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TpmPendingOperation"))
            {
                initObject.TpmPendingOperation = this.TpmPendingOperation;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TpmSupport"))
            {
                initObject.TpmSupport = this.TpmSupport;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tsme"))
            {
                initObject.Tsme = this.Tsme;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TxtSupport"))
            {
                initObject.TxtSupport = this.TxtSupport;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UcsmBootOrderRule"))
            {
                initObject.UcsmBootOrderRule = this.UcsmBootOrderRule;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UfsDisable"))
            {
                initObject.UfsDisable = this.UfsDisable;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UmaBasedClustering"))
            {
                initObject.UmaBasedClustering = this.UmaBasedClustering;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UpiLinkEnablement"))
            {
                initObject.UpiLinkEnablement = this.UpiLinkEnablement;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UpiPowerManagement"))
            {
                initObject.UpiPowerManagement = this.UpiPowerManagement;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UsbEmul6064"))
            {
                initObject.UsbEmul6064 = this.UsbEmul6064;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UsbPortFront"))
            {
                initObject.UsbPortFront = this.UsbPortFront;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UsbPortInternal"))
            {
                initObject.UsbPortInternal = this.UsbPortInternal;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UsbPortKvm"))
            {
                initObject.UsbPortKvm = this.UsbPortKvm;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UsbPortRear"))
            {
                initObject.UsbPortRear = this.UsbPortRear;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UsbPortSdCard"))
            {
                initObject.UsbPortSdCard = this.UsbPortSdCard;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UsbPortVmedia"))
            {
                initObject.UsbPortVmedia = this.UsbPortVmedia;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UsbXhciSupport"))
            {
                initObject.UsbXhciSupport = this.UsbXhciSupport;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VgaPriority"))
            {
                initObject.VgaPriority = this.VgaPriority;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VirtualNuma"))
            {
                initObject.VirtualNuma = this.VirtualNuma;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VmdEnable"))
            {
                initObject.VmdEnable = this.VmdEnable;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VolMemoryMode"))
            {
                initObject.VolMemoryMode = this.VolMemoryMode;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("WorkLoadConfig"))
            {
                initObject.WorkLoadConfig = this.WorkLoadConfig;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("XptPrefetch"))
            {
                initObject.XptPrefetch = this.XptPrefetch;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("XptRemotePrefetch"))
            {
                initObject.XptRemotePrefetch = this.XptRemotePrefetch;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize BiosSystemBootOrder.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightBiosSystemBootOrder")]
    public class InitializeIntersightBiosSystemBootOrder : PSCmdlet
    {
        public InitializeIntersightBiosSystemBootOrder()
        {
            ClassId = BiosSystemBootOrder.ClassIdEnum.BiosSystemBootOrder;
            ObjectType = BiosSystemBootOrder.ObjectTypeEnum.BiosSystemBootOrder;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a biosUnit resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.BiosUnitRelationship BiosUnit
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosSystemBootOrder.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosSystemBootOrder.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.BiosSystemBootOrder initObject = new Intersight.Model.BiosSystemBootOrder();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BiosUnit"))
            {
                initObject.BiosUnit = this.BiosUnit;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize BiosTokenSettings.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightBiosTokenSettings")]
    public class InitializeIntersightBiosTokenSettings : PSCmdlet
    {
        public InitializeIntersightBiosTokenSettings()
        {
            ClassId = BiosTokenSettings.ClassIdEnum.BiosTokenSettings;
            ObjectType = BiosTokenSettings.ObjectTypeEnum.BiosTokenSettings;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosTokenSettings.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a computeBlade resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.ComputeBladeRelationship ComputeBlade
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a computeRackUnit resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.ComputeRackUnitRelationship ComputeRackUnit
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosTokenSettings.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Parent server serial number."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Serial
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.BiosTokenSettings initObject = new Intersight.Model.BiosTokenSettings();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ComputeBlade"))
            {
                initObject.ComputeBlade = this.ComputeBlade;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ComputeRackUnit"))
            {
                initObject.ComputeRackUnit = this.ComputeRackUnit;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Serial"))
            {
                initObject.Serial = this.Serial;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize BiosUnit.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightBiosUnit")]
    public class InitializeIntersightBiosUnit : PSCmdlet
    {
        public InitializeIntersightBiosUnit()
        {
            ClassId = BiosUnit.ClassIdEnum.BiosUnit;
            ObjectType = BiosUnit.ObjectTypeEnum.BiosUnit;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosUnit.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosUnit.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a equipmentFru resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.EquipmentFruRelationship PreviousFru
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a biosSystemBootOrder resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.BiosSystemBootOrderRelationship SystemBootOrder
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.BiosUnit initObject = new Intersight.Model.BiosUnit();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("PreviousFru"))
            {
                initObject.PreviousFru = this.PreviousFru;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SystemBootOrder"))
            {
                initObject.SystemBootOrder = this.SystemBootOrder;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize BiosVfSelectMemoryRasConfiguration.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightBiosVfSelectMemoryRasConfiguration")]
    public class InitializeIntersightBiosVfSelectMemoryRasConfiguration : PSCmdlet
    {
        public InitializeIntersightBiosVfSelectMemoryRasConfiguration()
        {
            ClassId = BiosVfSelectMemoryRasConfiguration.ClassIdEnum.BiosVfSelectMemoryRasConfiguration;
            ObjectType = BiosVfSelectMemoryRasConfiguration.ObjectTypeEnum.BiosVfSelectMemoryRasConfiguration;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosVfSelectMemoryRasConfiguration.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a computeBlade resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.ComputeBladeRelationship ComputeBlade
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a computeRackUnit resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.ComputeRackUnitRelationship ComputeRackUnit
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosVfSelectMemoryRasConfiguration.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Parent server serial number."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Serial
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.BiosVfSelectMemoryRasConfiguration initObject = new Intersight.Model.BiosVfSelectMemoryRasConfiguration();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ComputeBlade"))
            {
                initObject.ComputeBlade = this.ComputeBlade;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ComputeRackUnit"))
            {
                initObject.ComputeRackUnit = this.ComputeRackUnit;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Serial"))
            {
                initObject.Serial = this.Serial;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
}