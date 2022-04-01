using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ComputeBoard.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightComputeBoard")]
    public class InitializeIntersightComputeBoard : PSCmdlet
    {
        public InitializeIntersightComputeBoard()
        {
            ClassId = ComputeBoard.ClassIdEnum.ComputeBoard;
            ObjectType = ComputeBoard.ObjectTypeEnum.ComputeBoard;

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

        public ComputeBoard.ClassIdEnum ClassId
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

        public ComputeBoard.ObjectTypeEnum ObjectType
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
            Intersight.Model.ComputeBoard initObject = new Intersight.Model.ComputeBoard();
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ComputeAlarmSummary.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightComputeAlarmSummary")]
    public class InitializeIntersightComputeAlarmSummary : PSCmdlet
    {
        public InitializeIntersightComputeAlarmSummary()
        {
            ClassId = ComputeAlarmSummary.ClassIdEnum.ComputeAlarmSummary;
            ObjectType = ComputeAlarmSummary.ObjectTypeEnum.ComputeAlarmSummary;

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

        public ComputeAlarmSummary.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The count of alarms that have severity type Critical."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Critical
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ComputeAlarmSummary.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The count of alarms that have severity type Warning."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Warning
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.ComputeAlarmSummary initObject = new Intersight.Model.ComputeAlarmSummary();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Critical"))
            {
                initObject.Critical = this.Critical;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Warning"))
            {
                initObject.Warning = this.Warning;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ComputeServerSetting.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightComputeServerSetting")]
    public class InitializeIntersightComputeServerSetting : PSCmdlet
    {
        public InitializeIntersightComputeServerSetting()
        {
            AdminLocatorLedState = ComputeServerSetting.AdminLocatorLedStateEnum.None;
            AdminPowerState = ComputeServerSetting.AdminPowerStateEnum.Policy;
            ClassId = ComputeServerSetting.ClassIdEnum.ComputeServerSetting;
            CmosReset = ComputeServerSetting.CmosResetEnum.Ready;
            FrontPanelLockState = ComputeServerSetting.FrontPanelLockStateEnum.Unlock;
            KvmReset = ComputeServerSetting.KvmResetEnum.Ready;
            ObjectType = ComputeServerSetting.ObjectTypeEnum.ComputeServerSetting;
            TunneledKvmState = ComputeServerSetting.TunneledKvmStateEnum.Ready;

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
        /// <para type="description">"User configured state of the locator LED for the server.\n* `None` - No operation property for locator led.\n* `On` - The Locator Led is turned on.\n* `Off` - The Locator Led is turned off."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ComputeServerSetting.AdminLocatorLedStateEnum AdminLocatorLedState
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"User configured power state of the server.\n* `Policy` - Power state is set to the default value in the policy.\n* `PowerOn` - Power state of the server is set to On.\n* `PowerOff` - Power state is the server set to Off.\n* `PowerCycle` - Power state the server is reset.\n* `HardReset` - Power state the server is hard reset.\n* `Shutdown` - Operating system on the server is shut down.\n* `Reboot` - Power state of IMC is rebooted."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ComputeServerSetting.AdminPowerStateEnum AdminPowerState
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Certificates Action configures the Certificate and PrivateKey at the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.CertificatemanagementCertificateBase CertificatesAction
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ComputeServerSetting.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The allowed actions on the CMOS Reset.\n* `Ready` - CMOS Reset operation is allowed to be done on the server in this state.\n* `Pending` - The identifier to state that the previous CMOS Reset operation on this server has not completed due to a pending power cycle. CMOS Reset operation cannot be done on the server when in this state.\n* `Reset` - The value that the UI/API needs to provide to trigger a CMOS Reset operation on a server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ComputeServerSetting.CmosResetEnum CmosReset
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The allowed actions on the Front Panel Lock.\n* `Unlock` - Front Panel of the server is set to Unlocked state.\n* `Lock` - Front Panel of the server is set to Locked state."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ComputeServerSetting.FrontPanelLockStateEnum FrontPanelLockState
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The allowed actions on the vKVM Reset.\n* `Ready` - Reset vKVM operation is allowed to be done on the server in this state.\n* `Reset` - The value that the UI/API needs to provide to trigger a Reset vKVM operation on a server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ComputeServerSetting.KvmResetEnum KvmReset
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

        public ComputeServerSetting.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the device chosen by user for configuring One-Time Boot device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string OneTimeBootDevice
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Persistent Memory Modules operation properties."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.ComputePersistentMemoryOperation PersistentMemoryOperation
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The common server configurable properties between a server and a server profile."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.ComputeServerConfig ServerConfig
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.ComputeServerOpStatus> ServerOpStatus
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Storage Controller operation properties."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.ComputeStorageControllerOperation StorageControllerOperation
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Storage Physical Drives operation properties."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.ComputeStoragePhysicalDriveOperation StoragePhysicalDriveOperation
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Storage Virtual Drives operation properties."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.ComputeStorageVirtualDriveOperation StorageVirtualDriveOperation
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
        /// <para type="description">"By default, the tunneled vKVM property appears in Ready state. The property can be configured by performing allowed actions. Once the property is configured, it reverts to Ready state.\n* `Ready` - Tunneled vKVM is ready to be configured on the server.\n* `Enable` - Tunneled vKVM is enabled for the server.\n* `Disable` - Tunneled vKVM is disabled for the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ComputeServerSetting.TunneledKvmStateEnum TunneledKvmState
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.ComputeServerSetting initObject = new Intersight.Model.ComputeServerSetting();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdminLocatorLedState"))
            {
                initObject.AdminLocatorLedState = this.AdminLocatorLedState;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdminPowerState"))
            {
                initObject.AdminPowerState = this.AdminPowerState;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CertificatesAction"))
            {
                initObject.CertificatesAction = this.CertificatesAction;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("CmosReset"))
            {
                initObject.CmosReset = this.CmosReset;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FrontPanelLockState"))
            {
                initObject.FrontPanelLockState = this.FrontPanelLockState;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("KvmReset"))
            {
                initObject.KvmReset = this.KvmReset;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("OneTimeBootDevice"))
            {
                initObject.OneTimeBootDevice = this.OneTimeBootDevice;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PersistentMemoryOperation"))
            {
                initObject.PersistentMemoryOperation = this.PersistentMemoryOperation;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ServerConfig"))
            {
                initObject.ServerConfig = this.ServerConfig;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ServerOpStatus"))
            {
                initObject.ServerOpStatus = this.ServerOpStatus;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("StorageControllerOperation"))
            {
                initObject.StorageControllerOperation = this.StorageControllerOperation;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("StoragePhysicalDriveOperation"))
            {
                initObject.StoragePhysicalDriveOperation = this.StoragePhysicalDriveOperation;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("StorageVirtualDriveOperation"))
            {
                initObject.StorageVirtualDriveOperation = this.StorageVirtualDriveOperation;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TunneledKvmState"))
            {
                initObject.TunneledKvmState = this.TunneledKvmState;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ComputeRackUnit.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightComputeRackUnit")]
    public class InitializeIntersightComputeRackUnit : PSCmdlet
    {
        public InitializeIntersightComputeRackUnit()
        {
            ClassId = ComputeRackUnit.ClassIdEnum.ComputeRackUnit;
            ManagementMode = ComputeRackUnit.ManagementModeEnum.IntersightStandalone;
            ObjectType = ComputeRackUnit.ObjectTypeEnum.ComputeRackUnit;

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
        /// <para type="description">"The summary of alarm counts based on the severity types (Critical or Warning)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.ComputeAlarmSummary AlarmSummary
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a biosBootMode resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.BiosBootModeRelationship BiosBootmode
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The BIOS POST completion status of the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool BiosPostComplete
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a biosTokenSettings resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.BiosTokenSettingsRelationship BiosTokenSettings
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a biosVfSelectMemoryRasConfiguration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.BiosVfSelectMemoryRasConfigurationRelationship BiosVfSelectMemoryRasConfiguration
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to bootCddDevice resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.BootCddDeviceRelationship> BootCddDevices
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a bootDeviceBootSecurity resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.BootDeviceBootSecurityRelationship BootDeviceBootSecurity
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to bootHddDevice resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.BootHddDeviceRelationship> BootHddDevices
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to bootIscsiDevice resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.BootIscsiDeviceRelationship> BootIscsiDevices
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to bootNvmeDevice resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.BootNvmeDeviceRelationship> BootNvmeDevices
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to bootPchStorageDevice resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.BootPchStorageDeviceRelationship> BootPchStorageDevices
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to bootPxeDevice resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.BootPxeDeviceRelationship> BootPxeDevices
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to bootSanDevice resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.BootSanDeviceRelationship> BootSanDevices
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to bootSdDevice resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.BootSdDeviceRelationship> BootSdDevices
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to bootUefiShellDevice resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.BootUefiShellDeviceRelationship> BootUefiShellDevices
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to bootUsbDevice resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.BootUsbDeviceRelationship> BootUsbDevices
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to bootVmediaDevice resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.BootVmediaDeviceRelationship> BootVmediaDevices
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ComputeRackUnit.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fault summary for the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long FaultSummary
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to graphicsCard resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.GraphicsCardRelationship> GraphicsCards
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The universally unique hardware identity of the server provided by the manufacturer."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string HardwareUuid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.ComputeIpAddress> KvmIpAddresses
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The management mode of the server.\n* `IntersightStandalone` - Intersight Standalone mode of operation.\n* `UCSM` - Unified Computing System Manager mode of operation.\n* `Intersight` - Intersight managed mode of operation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ComputeRackUnit.ManagementModeEnum ManagementMode
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to memoryArray resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MemoryArrayRelationship> MemoryArrays
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a equipmentPhysicalIdentity resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.EquipmentPhysicalIdentityRelationship MgmtIdentity
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Management address of the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string MgmtIpAddress
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
        /// <para type="description">"The name of the UCS Fabric Interconnect cluster or Cisco Integrated Management Controller (CIMC). When this server is attached to a UCS Fabric Interconnect, the value of this property is the name of the UCS Fabric Interconnect along with chassis/server Id. When this server configured in standalone mode, the value of this property is the name of the Cisco Integrated Management Controller. when this server is configired in IMM mode, the value of this property contains model and chassis/server Id."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ComputeRackUnit.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<ComputeRackUnit.OperReasonEnum> OperReason
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The platform type of the registered device - whether managed by UCSM or operating in standalone mode."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string PlatformType
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
        /// <para type="description">"An array of relationships to processorUnit resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.ProcessorUnitRelationship> Processors
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to storageSasExpander resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.StorageSasExpanderRelationship> SasExpanders
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to storageController resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.StorageControllerRelationship> StorageControllers
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
        /// <para type="description">"To maintain the Topology workflow run status."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string TopologyScanStatus
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Tunneled vKVM status of the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool TunneledKvm
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a computeVmedia resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.ComputeVmediaRelationship Vmedia
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.ComputeRackUnit initObject = new Intersight.Model.ComputeRackUnit();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AlarmSummary"))
            {
                initObject.AlarmSummary = this.AlarmSummary;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BiosBootmode"))
            {
                initObject.BiosBootmode = this.BiosBootmode;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BiosPostComplete"))
            {
                initObject.BiosPostComplete = this.BiosPostComplete;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BiosTokenSettings"))
            {
                initObject.BiosTokenSettings = this.BiosTokenSettings;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BiosVfSelectMemoryRasConfiguration"))
            {
                initObject.BiosVfSelectMemoryRasConfiguration = this.BiosVfSelectMemoryRasConfiguration;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BootCddDevices"))
            {
                initObject.BootCddDevices = this.BootCddDevices;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BootDeviceBootSecurity"))
            {
                initObject.BootDeviceBootSecurity = this.BootDeviceBootSecurity;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BootHddDevices"))
            {
                initObject.BootHddDevices = this.BootHddDevices;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BootIscsiDevices"))
            {
                initObject.BootIscsiDevices = this.BootIscsiDevices;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BootNvmeDevices"))
            {
                initObject.BootNvmeDevices = this.BootNvmeDevices;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BootPchStorageDevices"))
            {
                initObject.BootPchStorageDevices = this.BootPchStorageDevices;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BootPxeDevices"))
            {
                initObject.BootPxeDevices = this.BootPxeDevices;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BootSanDevices"))
            {
                initObject.BootSanDevices = this.BootSanDevices;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BootSdDevices"))
            {
                initObject.BootSdDevices = this.BootSdDevices;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BootUefiShellDevices"))
            {
                initObject.BootUefiShellDevices = this.BootUefiShellDevices;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BootUsbDevices"))
            {
                initObject.BootUsbDevices = this.BootUsbDevices;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BootVmediaDevices"))
            {
                initObject.BootVmediaDevices = this.BootVmediaDevices;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("FaultSummary"))
            {
                initObject.FaultSummary = this.FaultSummary;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("GraphicsCards"))
            {
                initObject.GraphicsCards = this.GraphicsCards;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HardwareUuid"))
            {
                initObject.HardwareUuid = this.HardwareUuid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("KvmIpAddresses"))
            {
                initObject.KvmIpAddresses = this.KvmIpAddresses;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ManagementMode"))
            {
                initObject.ManagementMode = this.ManagementMode;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MemoryArrays"))
            {
                initObject.MemoryArrays = this.MemoryArrays;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MgmtIdentity"))
            {
                initObject.MgmtIdentity = this.MgmtIdentity;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MgmtIpAddress"))
            {
                initObject.MgmtIpAddress = this.MgmtIpAddress;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("OperReason"))
            {
                initObject.OperReason = this.OperReason;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PlatformType"))
            {
                initObject.PlatformType = this.PlatformType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PreviousFru"))
            {
                initObject.PreviousFru = this.PreviousFru;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Processors"))
            {
                initObject.Processors = this.Processors;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SasExpanders"))
            {
                initObject.SasExpanders = this.SasExpanders;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("StorageControllers"))
            {
                initObject.StorageControllers = this.StorageControllers;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TopologyScanStatus"))
            {
                initObject.TopologyScanStatus = this.TopologyScanStatus;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TunneledKvm"))
            {
                initObject.TunneledKvm = this.TunneledKvm;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Vmedia"))
            {
                initObject.Vmedia = this.Vmedia;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ComputeVmedia.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightComputeVmedia")]
    public class InitializeIntersightComputeVmedia : PSCmdlet
    {
        public InitializeIntersightComputeVmedia()
        {
            ClassId = ComputeVmedia.ClassIdEnum.ComputeVmedia;
            ObjectType = ComputeVmedia.ObjectTypeEnum.ComputeVmedia;

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

        public ComputeVmedia.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a computePhysical resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.ComputePhysicalRelationship ComputePhysicalUnit
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

        public ComputeVmedia.ObjectTypeEnum ObjectType
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
            Intersight.Model.ComputeVmedia initObject = new Intersight.Model.ComputeVmedia();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ComputePhysicalUnit"))
            {
                initObject.ComputePhysicalUnit = this.ComputePhysicalUnit;
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
    /// <para type="synopsis">This is the cmdlet to Initialize ComputeServerConfig.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightComputeServerConfig")]
    public class InitializeIntersightComputeServerConfig : PSCmdlet
    {
        public InitializeIntersightComputeServerConfig()
        {
            ClassId = ComputeServerConfig.ClassIdEnum.ComputeServerConfig;
            ObjectType = ComputeServerConfig.ObjectTypeEnum.ComputeServerConfig;

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
        /// <para type="description">"User defined asset tag of the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[ #$%\\(\\)\\*\\+,\\-\\./:;\\?@\\[\\]_\\{\\|\\}\\^\\`\\>\\<~a-zA-Z0-9]*$")]
        public string AssetTag
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ComputeServerConfig.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ComputeServerConfig.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"User defined description of the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[ !#$%&\\(\\)\\*\\+,\\-\\./:;\\?@\\[\\]_\\{\\|\\}~a-zA-Z0-9]*$")]
        public string UserLabel
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.ComputeServerConfig initObject = new Intersight.Model.ComputeServerConfig();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AssetTag"))
            {
                initObject.AssetTag = this.AssetTag;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("UserLabel"))
            {
                initObject.UserLabel = this.UserLabel;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ComputeBladeIdentity.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightComputeBladeIdentity")]
    public class InitializeIntersightComputeBladeIdentity : PSCmdlet
    {
        public InitializeIntersightComputeBladeIdentity()
        {
            AdminAction = ComputeBladeIdentity.AdminActionEnum.None;
            ClassId = ComputeBladeIdentity.ClassIdEnum.ComputeBladeIdentity;
            ObjectType = ComputeBladeIdentity.ObjectTypeEnum.ComputeBladeIdentity;

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
        /// <para type="description">"Updated by UI/API to trigger specific chassis action type.\n* `None` - No operation value for maintenance actions on an equipment.\n* `Decommission` - Decommission the equipment and temporarily remove it from being managed by Intersight.\n* `Recommission` - Recommission the equipment.\n* `Reack` - Reacknowledge the equipment and discover it again.\n* `Remove` - Remove the equipment permanently from Intersight management.\n* `Replace` - Replace the equipment with the other one."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ComputeBladeIdentity.AdminActionEnum AdminAction
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ComputeBladeIdentity.ClassIdEnum ClassId
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

        public ComputeBladeIdentity.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.AssetDeviceRegistrationRelationship PhysicalDeviceRegistration
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
            Intersight.Model.ComputeBladeIdentity initObject = new Intersight.Model.ComputeBladeIdentity();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdminAction"))
            {
                initObject.AdminAction = this.AdminAction;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("PhysicalDeviceRegistration"))
            {
                initObject.PhysicalDeviceRegistration = this.PhysicalDeviceRegistration;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ComputeRackUnitIdentity.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightComputeRackUnitIdentity")]
    public class InitializeIntersightComputeRackUnitIdentity : PSCmdlet
    {
        public InitializeIntersightComputeRackUnitIdentity()
        {
            AdminAction = ComputeRackUnitIdentity.AdminActionEnum.None;
            ClassId = ComputeRackUnitIdentity.ClassIdEnum.ComputeRackUnitIdentity;
            ObjectType = ComputeRackUnitIdentity.ObjectTypeEnum.ComputeRackUnitIdentity;

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
        /// <para type="description">"Updated by UI/API to trigger specific chassis action type.\n* `None` - No operation value for maintenance actions on an equipment.\n* `Decommission` - Decommission the equipment and temporarily remove it from being managed by Intersight.\n* `Recommission` - Recommission the equipment.\n* `Reack` - Reacknowledge the equipment and discover it again.\n* `Remove` - Remove the equipment permanently from Intersight management.\n* `Replace` - Replace the equipment with the other one."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ComputeRackUnitIdentity.AdminActionEnum AdminAction
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ComputeRackUnitIdentity.ClassIdEnum ClassId
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

        public ComputeRackUnitIdentity.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.AssetDeviceRegistrationRelationship PhysicalDeviceRegistration
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
            Intersight.Model.ComputeRackUnitIdentity initObject = new Intersight.Model.ComputeRackUnitIdentity();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdminAction"))
            {
                initObject.AdminAction = this.AdminAction;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("PhysicalDeviceRegistration"))
            {
                initObject.PhysicalDeviceRegistration = this.PhysicalDeviceRegistration;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ComputePersistentMemoryModule.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightComputePersistentMemoryModule")]
    public class InitializeIntersightComputePersistentMemoryModule : PSCmdlet
    {
        public InitializeIntersightComputePersistentMemoryModule()
        {
            ClassId = ComputePersistentMemoryModule.ClassIdEnum.ComputePersistentMemoryModule;
            ObjectType = ComputePersistentMemoryModule.ObjectTypeEnum.ComputePersistentMemoryModule;

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

        public ComputePersistentMemoryModule.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ComputePersistentMemoryModule.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Socket ID of the Persistent Memory Module on the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SocketId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Socket Memory ID of the Persistent Memory Module on the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SocketMemoryId
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.ComputePersistentMemoryModule initObject = new Intersight.Model.ComputePersistentMemoryModule();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("SocketId"))
            {
                initObject.SocketId = this.SocketId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SocketMemoryId"))
            {
                initObject.SocketMemoryId = this.SocketMemoryId;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ComputeStorageControllerOperation.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightComputeStorageControllerOperation")]
    public class InitializeIntersightComputeStorageControllerOperation : PSCmdlet
    {
        public InitializeIntersightComputeStorageControllerOperation()
        {
            AdminAction = ComputeStorageControllerOperation.AdminActionEnum.None;
            ClassId = ComputeStorageControllerOperation.ClassIdEnum.ComputeStorageControllerOperation;
            ObjectType = ComputeStorageControllerOperation.ObjectTypeEnum.ComputeStorageControllerOperation;

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
        /// <para type="description">"Administrative actions that can be performed on the Storage Controller.\n* `None` - No action on the selected Storage Controller.\n* `Import` - Import Foreign config action on the selected Storage Controller.\n* `Clear` - Clear Foreign config action on the selected Storage Controller.\n* `ClearConfig` - Clear Config action on the selected Storage Controller."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ComputeStorageControllerOperation.AdminActionEnum AdminAction
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ComputeStorageControllerOperation.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Storage Controller Id of the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ControllerId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ComputeStorageControllerOperation.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.ComputeStorageControllerOperation initObject = new Intersight.Model.ComputeStorageControllerOperation();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdminAction"))
            {
                initObject.AdminAction = this.AdminAction;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ControllerId"))
            {
                initObject.ControllerId = this.ControllerId;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ComputeMapping.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightComputeMapping")]
    public class InitializeIntersightComputeMapping : PSCmdlet
    {
        public InitializeIntersightComputeMapping()
        {
            ClassId = ComputeMapping.ClassIdEnum.ComputeMapping;
            ObjectType = ComputeMapping.ObjectTypeEnum.ComputeMapping;

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

        public ComputeMapping.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Remote image location from where the image is uploaded to server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string FileLocation
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

        public ComputeMapping.ObjectTypeEnum ObjectType
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
            Intersight.Model.ComputeMapping initObject = new Intersight.Model.ComputeMapping();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("FileLocation"))
            {
                initObject.FileLocation = this.FileLocation;
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
    /// <para type="synopsis">This is the cmdlet to Initialize ComputeIpAddress.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightComputeIpAddress")]
    public class InitializeIntersightComputeIpAddress : PSCmdlet
    {
        public InitializeIntersightComputeIpAddress()
        {
            ClassId = ComputeIpAddress.ClassIdEnum.ComputeIpAddress;
            ObjectType = ComputeIpAddress.ObjectTypeEnum.ComputeIpAddress;

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

        public ComputeIpAddress.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ComputeIpAddress.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.ComputeIpAddress initObject = new Intersight.Model.ComputeIpAddress();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ComputeStorageVirtualDriveOperation.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightComputeStorageVirtualDriveOperation")]
    public class InitializeIntersightComputeStorageVirtualDriveOperation : PSCmdlet
    {
        public InitializeIntersightComputeStorageVirtualDriveOperation()
        {
            AdminAction = ComputeStorageVirtualDriveOperation.AdminActionEnum.None;
            ClassId = ComputeStorageVirtualDriveOperation.ClassIdEnum.ComputeStorageVirtualDriveOperation;
            ObjectType = ComputeStorageVirtualDriveOperation.ObjectTypeEnum.ComputeStorageVirtualDriveOperation;

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
        /// <para type="description">"Administrative actions that can be performed on the Storage Virtual Drives.\n* `None` - No action on the selected Storage virtual Drives.\n* `Delete` - Delete action on the selected Storage Virtual Drives."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ComputeStorageVirtualDriveOperation.AdminActionEnum AdminAction
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ComputeStorageVirtualDriveOperation.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Storage Controller Id of the storage Virtual Drives of the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ControllerId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ComputeStorageVirtualDriveOperation.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.ComputeStorageVirtualDrive> VirtualDrives
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.ComputeStorageVirtualDriveOperation initObject = new Intersight.Model.ComputeStorageVirtualDriveOperation();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdminAction"))
            {
                initObject.AdminAction = this.AdminAction;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ControllerId"))
            {
                initObject.ControllerId = this.ControllerId;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("VirtualDrives"))
            {
                initObject.VirtualDrives = this.VirtualDrives;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ComputeStoragePhysicalDrive.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightComputeStoragePhysicalDrive")]
    public class InitializeIntersightComputeStoragePhysicalDrive : PSCmdlet
    {
        public InitializeIntersightComputeStoragePhysicalDrive()
        {
            ClassId = ComputeStoragePhysicalDrive.ClassIdEnum.ComputeStoragePhysicalDrive;
            ObjectType = ComputeStoragePhysicalDrive.ObjectTypeEnum.ComputeStoragePhysicalDrive;

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

        public ComputeStoragePhysicalDrive.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ComputeStoragePhysicalDrive.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Physical Drive ID of the storage on the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long SlotNumber
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.ComputeStoragePhysicalDrive initObject = new Intersight.Model.ComputeStoragePhysicalDrive();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotNumber"))
            {
                initObject.SlotNumber = this.SlotNumber;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ComputeStorageVirtualDrive.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightComputeStorageVirtualDrive")]
    public class InitializeIntersightComputeStorageVirtualDrive : PSCmdlet
    {
        public InitializeIntersightComputeStorageVirtualDrive()
        {
            ClassId = ComputeStorageVirtualDrive.ClassIdEnum.ComputeStorageVirtualDrive;
            ObjectType = ComputeStorageVirtualDrive.ObjectTypeEnum.ComputeStorageVirtualDrive;

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

        public ComputeStorageVirtualDrive.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Virtual Drive ID of the storage on the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Id
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ComputeStorageVirtualDrive.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.ComputeStorageVirtualDrive initObject = new Intersight.Model.ComputeStorageVirtualDrive();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Id"))
            {
                initObject.Id = this.Id;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ComputeBlade.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightComputeBlade")]
    public class InitializeIntersightComputeBlade : PSCmdlet
    {
        public InitializeIntersightComputeBlade()
        {
            ClassId = ComputeBlade.ClassIdEnum.ComputeBlade;
            ManagementMode = ComputeBlade.ManagementModeEnum.IntersightStandalone;
            ObjectType = ComputeBlade.ObjectTypeEnum.ComputeBlade;

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
        /// <para type="description">"The summary of alarm counts based on the severity types (Critical or Warning)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.ComputeAlarmSummary AlarmSummary
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a biosBootMode resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.BiosBootModeRelationship BiosBootmode
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The BIOS POST completion status of the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool BiosPostComplete
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a biosTokenSettings resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.BiosTokenSettingsRelationship BiosTokenSettings
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a biosVfSelectMemoryRasConfiguration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.BiosVfSelectMemoryRasConfigurationRelationship BiosVfSelectMemoryRasConfiguration
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to bootCddDevice resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.BootCddDeviceRelationship> BootCddDevices
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a bootDeviceBootSecurity resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.BootDeviceBootSecurityRelationship BootDeviceBootSecurity
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to bootHddDevice resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.BootHddDeviceRelationship> BootHddDevices
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to bootIscsiDevice resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.BootIscsiDeviceRelationship> BootIscsiDevices
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to bootNvmeDevice resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.BootNvmeDeviceRelationship> BootNvmeDevices
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to bootPchStorageDevice resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.BootPchStorageDeviceRelationship> BootPchStorageDevices
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to bootPxeDevice resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.BootPxeDeviceRelationship> BootPxeDevices
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to bootSanDevice resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.BootSanDeviceRelationship> BootSanDevices
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to bootSdDevice resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.BootSdDeviceRelationship> BootSdDevices
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to bootUefiShellDevice resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.BootUefiShellDeviceRelationship> BootUefiShellDevices
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to bootUsbDevice resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.BootUsbDeviceRelationship> BootUsbDevices
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to bootVmediaDevice resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.BootVmediaDeviceRelationship> BootVmediaDevices
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ComputeBlade.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fault summary for the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long FaultSummary
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to graphicsCard resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.GraphicsCardRelationship> GraphicsCards
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The universally unique hardware identity of the server provided by the manufacturer."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string HardwareUuid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.ComputeIpAddress> KvmIpAddresses
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The management mode of the server.\n* `IntersightStandalone` - Intersight Standalone mode of operation.\n* `UCSM` - Unified Computing System Manager mode of operation.\n* `Intersight` - Intersight managed mode of operation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ComputeBlade.ManagementModeEnum ManagementMode
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to memoryArray resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MemoryArrayRelationship> MemoryArrays
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a equipmentPhysicalIdentity resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.EquipmentPhysicalIdentityRelationship MgmtIdentity
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Management address of the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string MgmtIpAddress
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
        /// <para type="description">"The name of the UCS Fabric Interconnect cluster or Cisco Integrated Management Controller (CIMC). When this server is attached to a UCS Fabric Interconnect, the value of this property is the name of the UCS Fabric Interconnect along with chassis/server Id. When this server configured in standalone mode, the value of this property is the name of the Cisco Integrated Management Controller. when this server is configired in IMM mode, the value of this property contains model and chassis/server Id."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ComputeBlade.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<ComputeBlade.OperReasonEnum> OperReason
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The platform type of the registered device - whether managed by UCSM or operating in standalone mode."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string PlatformType
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
        /// <para type="description">"An array of relationships to processorUnit resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.ProcessorUnitRelationship> Processors
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to storageController resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.StorageControllerRelationship> StorageControllers
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
        /// <para type="description">"A reference to a topSystem resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.TopSystemRelationship TopSystem
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Tunneled vKVM status of the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool TunneledKvm
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a computeVmedia resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.ComputeVmediaRelationship Vmedia
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.ComputeBlade initObject = new Intersight.Model.ComputeBlade();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AlarmSummary"))
            {
                initObject.AlarmSummary = this.AlarmSummary;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BiosBootmode"))
            {
                initObject.BiosBootmode = this.BiosBootmode;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BiosPostComplete"))
            {
                initObject.BiosPostComplete = this.BiosPostComplete;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BiosTokenSettings"))
            {
                initObject.BiosTokenSettings = this.BiosTokenSettings;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BiosVfSelectMemoryRasConfiguration"))
            {
                initObject.BiosVfSelectMemoryRasConfiguration = this.BiosVfSelectMemoryRasConfiguration;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BootCddDevices"))
            {
                initObject.BootCddDevices = this.BootCddDevices;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BootDeviceBootSecurity"))
            {
                initObject.BootDeviceBootSecurity = this.BootDeviceBootSecurity;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BootHddDevices"))
            {
                initObject.BootHddDevices = this.BootHddDevices;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BootIscsiDevices"))
            {
                initObject.BootIscsiDevices = this.BootIscsiDevices;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BootNvmeDevices"))
            {
                initObject.BootNvmeDevices = this.BootNvmeDevices;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BootPchStorageDevices"))
            {
                initObject.BootPchStorageDevices = this.BootPchStorageDevices;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BootPxeDevices"))
            {
                initObject.BootPxeDevices = this.BootPxeDevices;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BootSanDevices"))
            {
                initObject.BootSanDevices = this.BootSanDevices;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BootSdDevices"))
            {
                initObject.BootSdDevices = this.BootSdDevices;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BootUefiShellDevices"))
            {
                initObject.BootUefiShellDevices = this.BootUefiShellDevices;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BootUsbDevices"))
            {
                initObject.BootUsbDevices = this.BootUsbDevices;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BootVmediaDevices"))
            {
                initObject.BootVmediaDevices = this.BootVmediaDevices;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("FaultSummary"))
            {
                initObject.FaultSummary = this.FaultSummary;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("GraphicsCards"))
            {
                initObject.GraphicsCards = this.GraphicsCards;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HardwareUuid"))
            {
                initObject.HardwareUuid = this.HardwareUuid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("KvmIpAddresses"))
            {
                initObject.KvmIpAddresses = this.KvmIpAddresses;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ManagementMode"))
            {
                initObject.ManagementMode = this.ManagementMode;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MemoryArrays"))
            {
                initObject.MemoryArrays = this.MemoryArrays;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MgmtIdentity"))
            {
                initObject.MgmtIdentity = this.MgmtIdentity;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MgmtIpAddress"))
            {
                initObject.MgmtIpAddress = this.MgmtIpAddress;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("OperReason"))
            {
                initObject.OperReason = this.OperReason;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PlatformType"))
            {
                initObject.PlatformType = this.PlatformType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PreviousFru"))
            {
                initObject.PreviousFru = this.PreviousFru;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Processors"))
            {
                initObject.Processors = this.Processors;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("StorageControllers"))
            {
                initObject.StorageControllers = this.StorageControllers;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TopSystem"))
            {
                initObject.TopSystem = this.TopSystem;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TunneledKvm"))
            {
                initObject.TunneledKvm = this.TunneledKvm;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Vmedia"))
            {
                initObject.Vmedia = this.Vmedia;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ComputeStoragePhysicalDriveOperation.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightComputeStoragePhysicalDriveOperation")]
    public class InitializeIntersightComputeStoragePhysicalDriveOperation : PSCmdlet
    {
        public InitializeIntersightComputeStoragePhysicalDriveOperation()
        {
            AdminAction = ComputeStoragePhysicalDriveOperation.AdminActionEnum.None;
            ClassId = ComputeStoragePhysicalDriveOperation.ClassIdEnum.ComputeStoragePhysicalDriveOperation;
            ObjectType = ComputeStoragePhysicalDriveOperation.ObjectTypeEnum.ComputeStoragePhysicalDriveOperation;

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
        /// <para type="description">"Administrative actions that can be performed on the Storage Physical Drives.\n* `None` - No action on the selected Storage Physical Drives.\n* `SetJbod` - Set Jbod action state on the selected Storage Physical Drives.\n* `SetUnconfiguredGood` - Set Unconfigured Good action state on the selected Storage Physical Drives."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ComputeStoragePhysicalDriveOperation.AdminActionEnum AdminAction
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ComputeStoragePhysicalDriveOperation.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Storage Controller Id of the storage Physical Drives of the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ControllerId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ComputeStoragePhysicalDriveOperation.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.ComputeStoragePhysicalDrive> PhysicalDrives
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.ComputeStoragePhysicalDriveOperation initObject = new Intersight.Model.ComputeStoragePhysicalDriveOperation();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdminAction"))
            {
                initObject.AdminAction = this.AdminAction;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ControllerId"))
            {
                initObject.ControllerId = this.ControllerId;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("PhysicalDrives"))
            {
                initObject.PhysicalDrives = this.PhysicalDrives;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ComputeServerOpStatus.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightComputeServerOpStatus")]
    public class InitializeIntersightComputeServerOpStatus : PSCmdlet
    {
        public InitializeIntersightComputeServerOpStatus()
        {
            ClassId = ComputeServerOpStatus.ClassIdEnum.ComputeServerOpStatus;
            ConfigState = ComputeServerOpStatus.ConfigStateEnum.Applied;
            ObjectType = ComputeServerOpStatus.ObjectTypeEnum.ComputeServerOpStatus;

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

        public ComputeServerOpStatus.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The configured state of these settings in the target server. The value is any one of Applied, Applying, Failed. Applied - The state denotes that the settings are applied successfully in the target server. Applying - The state denotes that the settings are being applied in the target server. Failed - The state denotes that the settings could not be applied in the target server.\n* `Applied` - User configured settings are in applied state.\n* `Applying` - User settings are being applied on the target server.\n* `Failed` - User configured settings could not be applied."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ComputeServerOpStatus.ConfigStateEnum ConfigState
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ComputeServerOpStatus.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The workflow type being started. The workflow name to distinguish workflow by type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string WorkflowType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.ComputeServerOpStatus initObject = new Intersight.Model.ComputeServerOpStatus();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ConfigState"))
            {
                initObject.ConfigState = this.ConfigState;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("WorkflowType"))
            {
                initObject.WorkflowType = this.WorkflowType;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ComputePhysicalSummary.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightComputePhysicalSummary")]
    public class InitializeIntersightComputePhysicalSummary : PSCmdlet
    {
        public InitializeIntersightComputePhysicalSummary()
        {
            ClassId = ComputePhysicalSummary.ClassIdEnum.ComputePhysicalSummary;
            ObjectType = ComputePhysicalSummary.ObjectTypeEnum.ComputePhysicalSummary;

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

        public ComputePhysicalSummary.ClassIdEnum ClassId
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

        public ComputePhysicalSummary.ObjectTypeEnum ObjectType
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
            Intersight.Model.ComputePhysicalSummary initObject = new Intersight.Model.ComputePhysicalSummary();
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
    /// <para type="synopsis">This is the cmdlet to Initialize ComputePersistentMemoryOperation.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightComputePersistentMemoryOperation")]
    public class InitializeIntersightComputePersistentMemoryOperation : PSCmdlet
    {
        public InitializeIntersightComputePersistentMemoryOperation()
        {
            AdminAction = ComputePersistentMemoryOperation.AdminActionEnum.None;
            ClassId = ComputePersistentMemoryOperation.ClassIdEnum.ComputePersistentMemoryOperation;
            ObjectType = ComputePersistentMemoryOperation.ObjectTypeEnum.ComputePersistentMemoryOperation;

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
        /// <para type="description">"Administrative actions that can be performed on the Persistent Memory Modules.\n* `None` - No action on the selected Persistent Memory Modules.\n* `SecureErase` - Secure Erase action on the selected Persistent Memory Modules.\n* `Unlock` - Unlock action on the selected Persistent Memory Modules."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ComputePersistentMemoryOperation.AdminActionEnum AdminAction
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ComputePersistentMemoryOperation.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.ComputePersistentMemoryModule> Modules
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ComputePersistentMemoryOperation.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Secure passphrase of the Persistent Memory Modules of the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SecurePassphrase
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.ComputePersistentMemoryOperation initObject = new Intersight.Model.ComputePersistentMemoryOperation();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdminAction"))
            {
                initObject.AdminAction = this.AdminAction;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Modules"))
            {
                initObject.Modules = this.Modules;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("SecurePassphrase"))
            {
                initObject.SecurePassphrase = this.SecurePassphrase;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ComputeServerPowerPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightComputeServerPowerPolicy")]
    public class InitializeIntersightComputeServerPowerPolicy : PSCmdlet
    {
        public InitializeIntersightComputeServerPowerPolicy()
        {
            ClassId = ComputeServerPowerPolicy.ClassIdEnum.ComputeServerPowerPolicy;
            ObjectType = ComputeServerPowerPolicy.ObjectTypeEnum.ComputeServerPowerPolicy;
            PowerState = ComputeServerPowerPolicy.PowerStateEnum.Policy;

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

        public ComputeServerPowerPolicy.ClassIdEnum ClassId
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ComputeServerPowerPolicy.ObjectTypeEnum ObjectType
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
        /// <para type="description">"User configured power state of server.\n* `Policy` - Power state is set to the default value in the policy.\n* `PowerOn` - Power state of the server is set to On.\n* `PowerOff` - Power state is the server set to Off.\n* `PowerCycle` - Power state the server is reset.\n* `HardReset` - Power state the server is hard reset.\n* `Shutdown` - Operating system on the server is shut down.\n* `Reboot` - Power state of IMC is rebooted."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ComputeServerPowerPolicy.PowerStateEnum PowerState
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
            Intersight.Model.ComputeServerPowerPolicy initObject = new Intersight.Model.ComputeServerPowerPolicy();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Organization"))
            {
                initObject.Organization = this.Organization;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PowerState"))
            {
                initObject.PowerState = this.PowerState;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Profiles"))
            {
                initObject.Profiles = this.Profiles;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
}