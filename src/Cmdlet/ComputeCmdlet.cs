using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get ComputeRackUnit.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightComputeRackUnit", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightComputeRackUnit:GetCmdletBase
	{
		public GetIntersightComputeRackUnit()
		{
			ApiInstance = new ComputeApi(Config);
            MethodName = "GetComputeRackUnitListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set ComputeMapping.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightComputeMapping")]
    public class SetIntersightComputeMapping:SetCmdletBase
	{
		public SetIntersightComputeMapping()
		{
			ApiInstance = new ComputeApi(Config);
            ModelObject = new ComputeMapping();
            MethodName = "PatchComputeMappingWithHttpInfo";
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Remote image location from where the image is uploaded to server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string FileLocation {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> MediaTypes {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set ComputeServerSetting.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightComputeServerSetting")]
    public class SetIntersightComputeServerSetting:SetCmdletBase
	{
		public SetIntersightComputeServerSetting()
		{
			ApiInstance = new ComputeApi(Config);
            ModelObject = new ComputeServerSetting();
            MethodName = "UpdateComputeServerSettingWithHttpInfo";
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"User configured state of the locator LED for the server.\n* `None` - No operation property for locator led.\n* `On` - The Locator Led is turned on.\n* `Off` - The Locator Led is turned off."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ComputeServerSetting.AdminLocatorLedStateEnum AdminLocatorLedState {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"User configured power state of the server.\n* `Policy` - Power state is set to the default value in the policy.\n* `PowerOn` - Power state of the server is set to On.\n* `PowerOff` - Power state is the server set to Off.\n* `PowerCycle` - Power state the server is reset.\n* `HardReset` - Power state the server is hard reset.\n* `Shutdown` - Operating system on the server is shut down.\n* `Reboot` - Power state of IMC is rebooted."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ComputeServerSetting.AdminPowerStateEnum AdminPowerState {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Certificates Action configures the Certificate and PrivateKey at the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public CertificatemanagementCertificateBase CertificatesAction {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The allowed actions on the CMOS Reset.\n* `Ready` - CMOS Reset operation is allowed to be done on the server in this state.\n* `Pending` - This indicates that the previous CMOS Reset operation on this server has not completed due to a pending power cycle. CMOS Reset operation cannot be done on the server when in this state.\n* `Reset` - The value that the UI/API needs to provide to trigger a CMOS Reset operation on a server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ComputeServerSetting.CmosResetEnum CmosReset {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The allowed actions on the Front Panel Lock.\n* `Unlock` - Front Panel of the server is set to Unlocked state.\n* `Lock` - Front Panel of the server is set to Locked state."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ComputeServerSetting.FrontPanelLockStateEnum FrontPanelLockState {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the device chosen by user for configuring One-Time Boot device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string OneTimeBootDevice {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Persistent Memory Modules operation properties."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ComputePersistentMemoryOperation PersistentMemoryOperation {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The common server configurable properties between a server and a server profile."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ComputeServerConfig ServerConfig {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Storage Controller operation properties."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ComputeStorageControllerOperation StorageControllerOperation {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Storage Physical Drives operation properties."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ComputeStoragePhysicalDriveOperation StoragePhysicalDriveOperation {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Storage Virtual Drives operation properties."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ComputeStorageVirtualDriveOperation StorageVirtualDriveOperation {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get ComputeRackUnitIdentity.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightComputeRackUnitIdentity", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightComputeRackUnitIdentity:GetCmdletBase
	{
		public GetIntersightComputeRackUnitIdentity()
		{
			ApiInstance = new ComputeApi(Config);
            MethodName = "GetComputeRackUnitIdentityListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get ComputeServerSetting.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightComputeServerSetting", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightComputeServerSetting:GetCmdletBase
	{
		public GetIntersightComputeServerSetting()
		{
			ApiInstance = new ComputeApi(Config);
            MethodName = "GetComputeServerSettingListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set ComputeRackUnitIdentity.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightComputeRackUnitIdentity")]
    public class SetIntersightComputeRackUnitIdentity:SetCmdletBase
	{
		public SetIntersightComputeRackUnitIdentity()
		{
			ApiInstance = new ComputeApi(Config);
            ModelObject = new ComputeRackUnitIdentity();
            MethodName = "PatchComputeRackUnitIdentityWithHttpInfo";
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Updated by UI/API to trigger specific chassis action type.\n* `None` - No operation value for maintenance actions on an equipment.\n* `Decommission` - Decommission the equipment and temporarily remove it from being managed by Intersight.\n* `Recommission` - Recommission the equipment.\n* `Reack` - Reacknowledge the equipment and discover it again.\n* `Remove` - Remove the equipment permanently from Intersight management.\n* `Replace` - Replace the equipment with the other one."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ComputeRackUnitIdentity.AdminActionEnum AdminAction {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetDeviceRegistrationRelationship PhysicalDeviceRegistration {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove ComputeRackUnitIdentity.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightComputeRackUnitIdentity")]
    public class RemoveIntersightComputeRackUnitIdentity:RemoveCmdletBase
	{
		public RemoveIntersightComputeRackUnitIdentity()
		{
			ApiInstance = new ComputeApi(Config);
            MethodName = "DeleteComputeRackUnitIdentityWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get ComputeMapping.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightComputeMapping", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightComputeMapping:GetCmdletBase
	{
		public GetIntersightComputeMapping()
		{
			ApiInstance = new ComputeApi(Config);
            MethodName = "GetComputeMappingListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set ComputeBladeIdentity.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightComputeBladeIdentity")]
    public class SetIntersightComputeBladeIdentity:SetCmdletBase
	{
		public SetIntersightComputeBladeIdentity()
		{
			ApiInstance = new ComputeApi(Config);
            ModelObject = new ComputeBladeIdentity();
            MethodName = "UpdateComputeBladeIdentityWithHttpInfo";
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Updated by UI/API to trigger specific chassis action type.\n* `None` - No operation value for maintenance actions on an equipment.\n* `Decommission` - Decommission the equipment and temporarily remove it from being managed by Intersight.\n* `Recommission` - Recommission the equipment.\n* `Reack` - Reacknowledge the equipment and discover it again.\n* `Remove` - Remove the equipment permanently from Intersight management.\n* `Replace` - Replace the equipment with the other one."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ComputeBladeIdentity.AdminActionEnum AdminAction {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetDeviceRegistrationRelationship PhysicalDeviceRegistration {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove ComputeBladeIdentity.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightComputeBladeIdentity")]
    public class RemoveIntersightComputeBladeIdentity:RemoveCmdletBase
	{
		public RemoveIntersightComputeBladeIdentity()
		{
			ApiInstance = new ComputeApi(Config);
            MethodName = "DeleteComputeBladeIdentityWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set ComputeRackUnit.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightComputeRackUnit")]
    public class SetIntersightComputeRackUnit:SetCmdletBase
	{
		public SetIntersightComputeRackUnit()
		{
			ApiInstance = new ComputeApi(Config);
            ModelObject = new ComputeRackUnit();
            MethodName = "UpdateComputeRackUnitWithHttpInfo";
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The summary of alarm counts based on the severity types (Critical or Warning)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ComputeAlarmSummary AlarmSummary {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a biosBootMode resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public BiosBootModeRelationship BiosBootmode {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The BIOS POST completion status of the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool BiosPostComplete {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a biosTokenSettings resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public BiosTokenSettingsRelationship BiosTokenSettings {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a biosVfSelectMemoryRasConfiguration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public BiosVfSelectMemoryRasConfigurationRelationship BiosVfSelectMemoryRasConfiguration {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to bootCddDevice resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<BootCddDeviceRelationship> BootCddDevices {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a bootDeviceBootSecurity resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public BootDeviceBootSecurityRelationship BootDeviceBootSecurity {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to bootHddDevice resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<BootHddDeviceRelationship> BootHddDevices {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to bootIscsiDevice resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<BootIscsiDeviceRelationship> BootIscsiDevices {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to bootNvmeDevice resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<BootNvmeDeviceRelationship> BootNvmeDevices {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to bootPchStorageDevice resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<BootPchStorageDeviceRelationship> BootPchStorageDevices {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to bootPxeDevice resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<BootPxeDeviceRelationship> BootPxeDevices {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to bootSanDevice resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<BootSanDeviceRelationship> BootSanDevices {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to bootSdDevice resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<BootSdDeviceRelationship> BootSdDevices {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to bootUefiShellDevice resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<BootUefiShellDeviceRelationship> BootUefiShellDevices {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to bootUsbDevice resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<BootUsbDeviceRelationship> BootUsbDevices {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to bootVmediaDevice resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<BootVmediaDeviceRelationship> BootVmediaDevices {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fault summary for the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long FaultSummary {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to graphicsCard resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<GraphicsCardRelationship> GraphicsCards {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<ComputeIpAddress> KvmIpAddresses {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The management mode of the server.\n* `IntersightStandalone` - Intersight Standalone mode of operation.\n* `UCSM` - Unified Computing System Manager mode of operation.\n* `Intersight` - Intersight managed mode of operation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ComputeRackUnit.ManagementModeEnum ManagementMode {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to memoryArray resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MemoryArrayRelationship> MemoryArrays {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a equipmentPhysicalIdentity resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public EquipmentPhysicalIdentityRelationship MgmtIdentity {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Management address of the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string MgmtIpAddress {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> OperReason {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The platform type of the registered device - whether managed by UCSM or operating in standalone mode."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string PlatformType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a equipmentFru resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public EquipmentFruRelationship PreviousFru {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to processorUnit resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<ProcessorUnitRelationship> Processors {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to storageSasExpander resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<StorageSasExpanderRelationship> SasExpanders {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to storageController resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<StorageControllerRelationship> StorageControllers {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"To maintain the Topology workflow run status."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string TopologyScanStatus {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a computeVmedia resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ComputeVmediaRelationship Vmedia {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get ComputeBoard.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightComputeBoard", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightComputeBoard:GetCmdletBase
	{
		public GetIntersightComputeBoard()
		{
			ApiInstance = new ComputeApi(Config);
            MethodName = "GetComputeBoardListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set ComputeBoard.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightComputeBoard")]
    public class SetIntersightComputeBoard:SetCmdletBase
	{
		public SetIntersightComputeBoard()
		{
			ApiInstance = new ComputeApi(Config);
            ModelObject = new ComputeBoard();
            MethodName = "UpdateComputeBoardWithHttpInfo";
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> OperReason {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a equipmentFru resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public EquipmentFruRelationship PreviousFru {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get ComputeBlade.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightComputeBlade", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightComputeBlade:GetCmdletBase
	{
		public GetIntersightComputeBlade()
		{
			ApiInstance = new ComputeApi(Config);
            MethodName = "GetComputeBladeListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get ComputeVmedia.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightComputeVmedia", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightComputeVmedia:GetCmdletBase
	{
		public GetIntersightComputeVmedia()
		{
			ApiInstance = new ComputeApi(Config);
            MethodName = "GetComputeVmediaListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set ComputeBlade.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightComputeBlade")]
    public class SetIntersightComputeBlade:SetCmdletBase
	{
		public SetIntersightComputeBlade()
		{
			ApiInstance = new ComputeApi(Config);
            ModelObject = new ComputeBlade();
            MethodName = "UpdateComputeBladeWithHttpInfo";
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The summary of alarm counts based on the severity types (Critical or Warning)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ComputeAlarmSummary AlarmSummary {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a biosBootMode resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public BiosBootModeRelationship BiosBootmode {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The BIOS POST completion status of the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool BiosPostComplete {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a biosTokenSettings resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public BiosTokenSettingsRelationship BiosTokenSettings {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a biosVfSelectMemoryRasConfiguration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public BiosVfSelectMemoryRasConfigurationRelationship BiosVfSelectMemoryRasConfiguration {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to bootCddDevice resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<BootCddDeviceRelationship> BootCddDevices {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a bootDeviceBootSecurity resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public BootDeviceBootSecurityRelationship BootDeviceBootSecurity {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to bootHddDevice resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<BootHddDeviceRelationship> BootHddDevices {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to bootIscsiDevice resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<BootIscsiDeviceRelationship> BootIscsiDevices {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to bootNvmeDevice resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<BootNvmeDeviceRelationship> BootNvmeDevices {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to bootPchStorageDevice resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<BootPchStorageDeviceRelationship> BootPchStorageDevices {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to bootPxeDevice resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<BootPxeDeviceRelationship> BootPxeDevices {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to bootSanDevice resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<BootSanDeviceRelationship> BootSanDevices {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to bootSdDevice resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<BootSdDeviceRelationship> BootSdDevices {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to bootUefiShellDevice resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<BootUefiShellDeviceRelationship> BootUefiShellDevices {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to bootUsbDevice resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<BootUsbDeviceRelationship> BootUsbDevices {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to bootVmediaDevice resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<BootVmediaDeviceRelationship> BootVmediaDevices {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fault summary for the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long FaultSummary {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to graphicsCard resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<GraphicsCardRelationship> GraphicsCards {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<ComputeIpAddress> KvmIpAddresses {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The management mode of the server.\n* `IntersightStandalone` - Intersight Standalone mode of operation.\n* `UCSM` - Unified Computing System Manager mode of operation.\n* `Intersight` - Intersight managed mode of operation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ComputeBlade.ManagementModeEnum ManagementMode {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to memoryArray resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MemoryArrayRelationship> MemoryArrays {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a equipmentPhysicalIdentity resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public EquipmentPhysicalIdentityRelationship MgmtIdentity {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Management address of the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string MgmtIpAddress {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> OperReason {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The platform type of the registered device - whether managed by UCSM or operating in standalone mode."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string PlatformType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a equipmentFru resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public EquipmentFruRelationship PreviousFru {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to processorUnit resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<ProcessorUnitRelationship> Processors {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to storageController resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<StorageControllerRelationship> StorageControllers {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a topSystem resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public TopSystemRelationship TopSystem {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a computeVmedia resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ComputeVmediaRelationship Vmedia {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get ComputeBladeIdentity.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightComputeBladeIdentity", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightComputeBladeIdentity:GetCmdletBase
	{
		public GetIntersightComputeBladeIdentity()
		{
			ApiInstance = new ComputeApi(Config);
            MethodName = "GetComputeBladeIdentityListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get ComputePhysicalSummary.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightComputePhysicalSummary", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightComputePhysicalSummary:GetCmdletBase
	{
		public GetIntersightComputePhysicalSummary()
		{
			ApiInstance = new ComputeApi(Config);
            MethodName = "GetComputePhysicalSummaryListWithHttpInfo";
		}
    }
}