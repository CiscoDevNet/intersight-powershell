using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get ComputeBlade.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightComputeBlade", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightComputeBlade : GetCmdletBase
    {
        public GetIntersightComputeBlade()
        {
            ApiInstance = new ComputeApi(Config);
            MethodName = "GetComputeBladeListWithHttpInfo";
        }

        // <summary>
        /// <para type="description">"The Account ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string AccountMoid
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"The desired power state of the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string AdminPowerState
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"The user defined asset tag assigned to the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string AssetTag
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The amount of memory available on the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long AvailableMemory
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a biosBootMode resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public BiosBootModeRelationship BiosBootmode
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The BIOS POST completion status of the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool BiosPostComplete
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a biosTokenSettings resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public BiosTokenSettingsRelationship BiosTokenSettings
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a biosVfSelectMemoryRasConfiguration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public BiosVfSelectMemoryRasConfigurationRelationship BiosVfSelectMemoryRasConfiguration
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a managementController resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public ManagementControllerRelationship Bmc
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a computeBoard resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public ComputeBoardRelationship Board
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a bootDeviceBootSecurity resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public BootDeviceBootSecurityRelationship BootDeviceBootSecurity
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a bootDeviceBootMode resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public BootDeviceBootModeRelationship BootDeviceBootmode
        {
            get;
            set;
        }











        // <summary>
        /// <para type="description">"The id of the chassis that the blade is discovered in."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string ChassisId
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The time when this managed object was created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime CreateTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Connection status of the server's device connector."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string DeviceConnectionStatus
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The database identifier of the registered device of an object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string DeviceMoId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The Distinguished Name unambiguously identifies an object in the system."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Dn
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The DomainGroup ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string DomainGroupMoid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a equipmentChassis resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public EquipmentChassisRelationship EquipmentChassis
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The fault summary for the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long FaultSummary
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"The universally unique hardware identity of the server provided by the manufacturer."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string HardwareUuid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a inventoryDeviceInfo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public InventoryDeviceInfoRelationship InventoryDeviceInfo
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The KVM server state of the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool KvmServerStateEnabled
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The KVM Vendor for the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string KvmVendor
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The lifecycle state of the server. This will map to the discovery lifecycle as represented in the server Identity object.\n* `None` - Default state of an equipment. This should be an initial state when no state is defined for an equipment.\n* `Active` - Default Lifecycle State for a physical entity.\n* `Decommissioned` - Decommission Lifecycle state.\n* `DiscoveryInProgress` - DiscoveryInProgress Lifecycle state.\n* `DiscoveryFailed` - DiscoveryFailed Lifecycle state.\n* `FirmwareUpgradeInProgress` - Firmware upgrade is in progress on given physical entity.\n* `BladeMigrationInProgress` - Server slot migration is in progress on given physical entity.\n* `SlotMismatch` - The blade server is detected in a different chassis/slot than it was previously."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public ComputeBlade.LifecycleEnum Lifecycle
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a equipmentLocatorLed resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public EquipmentLocatorLedRelationship LocatorLed
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The management mode of the server.\n* `IntersightStandalone` - Intersight Standalone mode of operation.\n* `UCSM` - Unified Computing System Manager mode of operation.\n* `Intersight` - Intersight managed mode of operation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public ComputeBlade.ManagementModeEnum ManagementMode
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The maximum memory speed in MHz available on the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string MemorySpeed
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a equipmentPhysicalIdentity resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public EquipmentPhysicalIdentityRelationship MgmtIdentity
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Management address of the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string MgmtIpAddress
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The time when this managed object was last modified."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime ModTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"This field identifies the model of the given component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Model
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Moid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The name of the UCS Fabric Interconnect cluster or Cisco Integrated Management Controller (CIMC). When this server is attached to a UCS Fabric Interconnect, the value of this property is the name of the UCS Fabric Interconnect along with chassis/server Id. When this server configured in standalone mode, the value of this property is the name of the Cisco Integrated Management Controller. when this server is configired in IMM mode, the value of this property contains model and chassis/server Id."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Name
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The total number of network adapters present on the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long NumAdaptors
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The total number of CPU cores present on the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long NumCpuCores
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The total number of CPU cores enabled on the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long NumCpuCoresEnabled
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The total number of CPUs present on the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long NumCpus
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The total number of vNICs which are visible to a host on the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long NumEthHostInterfaces
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The total number of vHBAs which are visible to a host on the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long NumFcHostInterfaces
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The total number of threads the server is capable of handling."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long NumThreads
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The actual power state of the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string OperPowerState
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The operational state of the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string OperState
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The operability of the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Operability
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public MoBaseMoRelationship Parent
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"The platform type of the registered device - whether managed by UCSM or operating in standalone mode."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string PlatformType
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"This field identifies the presence (equipped) or absence of the given component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Presence
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a equipmentFru resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public EquipmentFruRelationship PreviousFru
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public AssetDeviceRegistrationRelationship RegisteredDevice
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"This field identifies the revision of the given component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Revision
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The Relative Name uniquely identifies an object within a given context."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Rn
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The mode of the server that determines it is scaled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string ScaledMode
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"This field identifies the serial of the given component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Serial
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The distinguished name of the service profile to which the server is associated to. It is applicable only for servers which are managed via UCSM."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string ServiceProfile
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Intersight provides pre-built workflows, tasks and policies to end users through global catalogs.\nObjects that are made available through global catalogs are said to have a 'shared' ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SharedScope
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The slot number in the chassis that the blade is discovered in."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long SlotId
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"A reference to a topSystem resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public TopSystemRelationship TopSystem
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The total memory available on the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long TotalMemory
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The Tunneled vKVM status of the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool TunneledKvm
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The user defined label assigned to the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string UserLabel
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The universally unique identity of the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Uuid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"This field identifies the vendor of the given component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Vendor
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a computeVmedia resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public ComputeVmediaRelationship Vmedia
        {
            get;
            set;
        }


    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get ComputeBladeIdentity.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightComputeBladeIdentity", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightComputeBladeIdentity : GetCmdletBase
    {
        public GetIntersightComputeBladeIdentity()
        {
            ApiInstance = new ComputeApi(Config);
            MethodName = "GetComputeBladeIdentityListWithHttpInfo";
        }

        // <summary>
        /// <para type="description">"The Account ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string AccountMoid
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Updated by UI/API to trigger specific action type.\n* `None` - No operation value for maintenance actions on an equipment.\n* `Decommission` - Decommission the equipment and temporarily remove it from being managed by Intersight.\n* `Recommission` - Recommission the equipment.\n* `Reack` - Reacknowledge the equipment and discover it again.\n* `Remove` - Remove the equipment permanently from Intersight management.\n* `Replace` - Replace the equipment with the other one."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public ComputeBladeIdentity.AdminActionEnum AdminAction
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The state of Maintenance Action performed. This will have three states. Applying - Action is in progress. Applied - Action is completed and applied. Failed - Action has failed.\n* `None` - Nil value when no action has been triggered by the user.\n* `Applied` - User configured settings are in applied state.\n* `Applying` - User settings are being applied on the target server.\n* `Failed` - User configured settings could not be applied."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public ComputeBladeIdentity.AdminActionStateEnum AdminActionState
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Chassis Identifier of a blade server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long ChassisId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The time when this managed object was created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime CreateTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The id of the chassis that the blade is currently located in."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long CurrentChassisId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The slot number in the chassis that the blade is currently located in."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long CurrentSlotId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The DomainGroup ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string DomainGroupMoid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Describes whether the running CIMC version supports Intersight managed mode.\n* `Unknown` - The running firmware version is unknown.\n* `Supported` - The running firmware version is known and supports IMM mode.\n* `NotSupported` - The running firmware version is known and does not support IMM mode."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public ComputeBladeIdentity.FirmwareSupportabilityEnum FirmwareSupportability
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Numeric Identifier assigned by the management system to the equipment. Identifier can only be changed if it has been PATCHED with the AdminAction property set to 'Recommission'."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long Identifier
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Denotes the type of discovery that was most recently triggered on this server.\n* `Unknown` - The last discovery type is unknown.\n* `Deep` - The last discovery triggered is deep.\n* `Shallow` - The last discovery triggered is shallow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public ComputeBladeIdentity.LastDiscoveryTriggeredEnum LastDiscoveryTriggered
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The equipment's lifecycle status.\n* `None` - Default state of an equipment. This should be an initial state when no state is defined for an equipment.\n* `Active` - Default Lifecycle State for a physical entity.\n* `Decommissioned` - Decommission Lifecycle state.\n* `DecommissionInProgress` - Decommission Inprogress Lifecycle state.\n* `RecommissionInProgress` - Recommission Inprogress Lifecycle state.\n* `OperationFailed` - Failed Operation Lifecycle state.\n* `ReackInProgress` - ReackInProgress Lifecycle state.\n* `RemoveInProgress` - RemoveInProgress Lifecycle state.\n* `Discovered` - Discovered Lifecycle state.\n* `DiscoveryInProgress` - DiscoveryInProgress Lifecycle state.\n* `DiscoveryFailed` - DiscoveryFailed Lifecycle state.\n* `FirmwareUpgradeInProgress` - Firmware upgrade is in progress on given physical entity.\n* `BladeMigrationInProgress` - Server slot migration is in progress on given physical entity.\n* `Inactive` - Inactive Lifecycle state.\n* `ReplaceInProgress` - ReplaceInProgress Lifecycle state.\n* `SlotMismatch` - The blade server is detected in a different chassis/slot than it was previously."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public ComputeBladeIdentity.LifecycleEnum Lifecycle
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Chassis slot number of the manager compute server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long ManagerSlotId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The time when this managed object was last modified."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime ModTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The vendor provided model name for the equipment."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Model
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Moid
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public MoBaseMoRelationship Parent
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public AssetDeviceRegistrationRelationship PhysicalDeviceRegistration
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The presence state of the blade server.\n* `Unknown` - The default presence state.\n* `Equipped` - The server is equipped in the slot.\n* `EquippedMismatch` - The slot is equipped, but there is another server currently inventoried in the slot.\n* `Missing` - The server is not present in the given slot."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public ComputeBladeIdentity.PresenceEnum Presence
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public AssetDeviceRegistrationRelationship RegisteredDevice
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The serial number of the equipment."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Serial
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Intersight provides pre-built workflows, tasks and policies to end users through global catalogs.\nObjects that are made available through global catalogs are said to have a 'shared' ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SharedScope
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Chassis slot number of a blade server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long SlotId
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The manufacturer of the equipment."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Vendor
        {
            get;
            set;
        }



    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get ComputeBoard.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightComputeBoard", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightComputeBoard : GetCmdletBase
    {
        public GetIntersightComputeBoard()
        {
            ApiInstance = new ComputeApi(Config);
            MethodName = "GetComputeBoardListWithHttpInfo";
        }

        // <summary>
        /// <para type="description">"The Account ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string AccountMoid
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"Unique identifier of the mother board present in the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long BoardId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a computeBlade resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public ComputeBladeRelationship ComputeBlade
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a computeRackUnit resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public ComputeRackUnitRelationship ComputeRackUnit
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The type of central processing unit on the mother board."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string CpuTypeController
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The time when this managed object was created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime CreateTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The database identifier of the registered device of an object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string DeviceMoId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The Distinguished Name unambiguously identifies an object in the system."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Dn
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The DomainGroup ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string DomainGroupMoid
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"A reference to a inventoryDeviceInfo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public InventoryDeviceInfoRelationship InventoryDeviceInfo
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The time when this managed object was last modified."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime ModTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"This field identifies the model of the given component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Model
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Moid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Current power state of the mother board of the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string OperPowerState
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public MoBaseMoRelationship Parent
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"A reference to a memoryPersistentMemoryConfiguration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public MemoryPersistentMemoryConfigurationRelationship PersistentMemoryConfiguration
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"This field identifies the presence (equipped) or absence of the given component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Presence
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a equipmentFru resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public EquipmentFruRelationship PreviousFru
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public AssetDeviceRegistrationRelationship RegisteredDevice
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"This field identifies the revision of the given component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Revision
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The Relative Name uniquely identifies an object within a given context."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Rn
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"This field identifies the serial of the given component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Serial
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Intersight provides pre-built workflows, tasks and policies to end users through global catalogs.\nObjects that are made available through global catalogs are said to have a 'shared' ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SharedScope
        {
            get;
            set;
        }





        // <summary>
        /// <para type="description">"This field identifies the vendor of the given component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Vendor
        {
            get;
            set;
        }



    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get ComputeMapping.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightComputeMapping", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightComputeMapping : GetCmdletBase
    {
        public GetIntersightComputeMapping()
        {
            ApiInstance = new ComputeApi(Config);
            MethodName = "GetComputeMappingListWithHttpInfo";
        }

        // <summary>
        /// <para type="description">"The Account ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string AccountMoid
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"The time when this managed object was created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime CreateTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The database identifier of the registered device of an object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string DeviceMoId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The Distinguished Name unambiguously identifies an object in the system."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Dn
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The DomainGroup ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string DomainGroupMoid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Remote image location from where the image is uploaded to server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string FileLocation
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The identity assigned to this Virtual Media Image by server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Identifier
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Image name of uploaded Virtual Media Image."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string ImageName
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a inventoryDeviceInfo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public InventoryDeviceInfoRelationship InventoryDeviceInfo
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The time when this managed object was last modified."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime ModTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Moid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Name of Virtual Media mapping assigne by server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Name
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public MoBaseMoRelationship Parent
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public AssetDeviceRegistrationRelationship RegisteredDevice
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The Relative Name uniquely identifies an object within a given context."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Rn
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Intersight provides pre-built workflows, tasks and policies to end users through global catalogs.\nObjects that are made available through global catalogs are said to have a 'shared' ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SharedScope
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"A reference to a computeVmedia resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public ComputeVmediaRelationship Vmedia
        {
            get;
            set;
        }


    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get ComputePersonality.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightComputePersonality", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightComputePersonality : GetCmdletBase
    {
        public GetIntersightComputePersonality()
        {
            ApiInstance = new ComputeApi(Config);
            MethodName = "GetComputePersonalityListWithHttpInfo";
        }

        // <summary>
        /// <para type="description">"The Account ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string AccountMoid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Additional info about the added software personality."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string AdditionalInfo
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"A reference to a computeBlade resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public ComputeBladeRelationship ComputeBlade
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a computeRackUnit resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public ComputeRackUnitRelationship ComputeRackUnit
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The time when this managed object was created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime CreateTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The database identifier of the registered device of an object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string DeviceMoId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The Distinguished Name unambiguously identifies an object in the system."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Dn
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The DomainGroup ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string DomainGroupMoid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The time when this managed object was last modified."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime ModTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Moid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Name of the software personality."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Name
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public MoBaseMoRelationship Parent
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Unique identity of added software personality."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long PersonalityId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public AssetDeviceRegistrationRelationship RegisteredDevice
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The Relative Name uniquely identifies an object within a given context."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Rn
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Intersight provides pre-built workflows, tasks and policies to end users through global catalogs.\nObjects that are made available through global catalogs are said to have a 'shared' ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SharedScope
        {
            get;
            set;
        }




    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get ComputePhysicalSummary.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightComputePhysicalSummary", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightComputePhysicalSummary : GetCmdletBase
    {
        public GetIntersightComputePhysicalSummary()
        {
            ApiInstance = new ComputeApi(Config);
            MethodName = "GetComputePhysicalSummaryListWithHttpInfo";
        }

        // <summary>
        /// <para type="description">"The Account ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string AccountMoid
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The desired power state of the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string AdminPowerState
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"The user defined asset tag assigned to the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string AssetTag
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The amount of memory available on the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long AvailableMemory
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The BIOS POST completion status of the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool BiosPostComplete
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The id of the chassis that the blade is discovered in."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string ChassisId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Connectivity Status of RackUnit to Switch - A or B or AB."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string ConnectionStatus
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"CPU Capacity = Number of CPU Sockets x Enabled Cores x Speed (GHz)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public float CpuCapacity
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The time when this managed object was created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime CreateTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Connection status of the server's device connector."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string DeviceConnectionStatus
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The database identifier of the registered device of an object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string DeviceMoId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The Distinguished Name unambiguously identifies an object in the system."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Dn
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The DomainGroup ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string DomainGroupMoid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a equipmentChassis resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public EquipmentChassisRelationship EquipmentChassis
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The fault summary for the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long FaultSummary
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The firmware version of the Cisco Integrated Management Controller (CIMC) for this server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Firmware
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The universally unique hardware identity of the server provided by the manufacturer."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string HardwareUuid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a inventoryDeviceInfo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public InventoryDeviceInfoRelationship InventoryDeviceInfo
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The IPv4 address configured on the management interface of the Integrated Management Controller."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Ipv4Address
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The KVM server state of the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool KvmServerStateEnabled
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The KVM Vendor for the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string KvmVendor
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The lifecycle state of the server. This will map to the discovery lifecycle as represented in the server Identity object.\n* `None` - Default state of an equipment. This should be an initial state when no state is defined for an equipment.\n* `Active` - Default Lifecycle State for a physical entity.\n* `Decommissioned` - Decommission Lifecycle state.\n* `DiscoveryInProgress` - DiscoveryInProgress Lifecycle state.\n* `DiscoveryFailed` - DiscoveryFailed Lifecycle state.\n* `FirmwareUpgradeInProgress` - Firmware upgrade is in progress on given physical entity.\n* `BladeMigrationInProgress` - Server slot migration is in progress on given physical entity.\n* `SlotMismatch` - The blade server is detected in a different chassis/slot than it was previously."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public ComputePhysicalSummary.LifecycleEnum Lifecycle
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The management mode of the server.\n* `IntersightStandalone` - Intersight Standalone mode of operation.\n* `UCSM` - Unified Computing System Manager mode of operation.\n* `Intersight` - Intersight managed mode of operation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public ComputePhysicalSummary.ManagementModeEnum ManagementMode
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The maximum memory speed in MHz available on the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string MemorySpeed
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Management address of the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string MgmtIpAddress
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The time when this managed object was last modified."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime ModTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"This field identifies the model of the given component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Model
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Moid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The name of the UCS Fabric Interconnect cluster or Cisco Integrated Management Controller (CIMC). When this server is attached to a UCS Fabric Interconnect, the value of this property is the name of the UCS Fabric Interconnect along with chassis/server Id. When this server configured in standalone mode, the value of this property is the name of the Cisco Integrated Management Controller. when this server is configired in IMM mode, the value of this property contains model and chassis/server Id."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Name
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The total number of network adapters present on the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long NumAdaptors
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The total number of CPU cores present on the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long NumCpuCores
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The total number of CPU cores enabled on the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long NumCpuCoresEnabled
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The total number of CPUs present on the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long NumCpus
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The total number of vNICs which are visible to a host on the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long NumEthHostInterfaces
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The total number of vHBAs which are visible to a host on the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long NumFcHostInterfaces
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The total number of threads the server is capable of handling."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long NumThreads
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The actual power state of the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string OperPowerState
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The operational state of the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string OperState
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The operability of the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Operability
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public MoBaseMoRelationship Parent
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The Rack unit software Personality."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Personality
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The platform type of the registered device - whether managed by UCSM or operating in standalone mode."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string PlatformType
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"This field identifies the presence (equipped) or absence of the given component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Presence
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public AssetDeviceRegistrationRelationship RegisteredDevice
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"This field identifies the revision of the given component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Revision
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The Relative Name uniquely identifies an object within a given context."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Rn
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The mode of the server that determines it is scaled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string ScaledMode
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"This field identifies the serial of the given component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Serial
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"RackUnit ID that uniquely identifies the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long ServerId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The distinguished name of the service profile to which the server is associated to. It is applicable only for servers which are managed via UCSM."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string ServiceProfile
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Intersight provides pre-built workflows, tasks and policies to end users through global catalogs.\nObjects that are made available through global catalogs are said to have a 'shared' ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SharedScope
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The slot number in the chassis that the blade is discovered in."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long SlotId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The source object type of this view MO."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SourceObjectType
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"To maintain the Topology workflow run status."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string TopologyScanStatus
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The total memory available on the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long TotalMemory
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The Tunneled vKVM status of the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool TunneledKvm
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The user defined label assigned to the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string UserLabel
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The universally unique identity of the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Uuid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"This field identifies the vendor of the given component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Vendor
        {
            get;
            set;
        }



    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get ComputeRackUnit.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightComputeRackUnit", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightComputeRackUnit : GetCmdletBase
    {
        public GetIntersightComputeRackUnit()
        {
            ApiInstance = new ComputeApi(Config);
            MethodName = "GetComputeRackUnitListWithHttpInfo";
        }

        // <summary>
        /// <para type="description">"The Account ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string AccountMoid
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"The desired power state of the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string AdminPowerState
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"The user defined asset tag assigned to the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string AssetTag
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The amount of memory available on the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long AvailableMemory
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a biosBootMode resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public BiosBootModeRelationship BiosBootmode
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The BIOS POST completion status of the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool BiosPostComplete
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a biosTokenSettings resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public BiosTokenSettingsRelationship BiosTokenSettings
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a biosVfSelectMemoryRasConfiguration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public BiosVfSelectMemoryRasConfigurationRelationship BiosVfSelectMemoryRasConfiguration
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a managementController resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public ManagementControllerRelationship Bmc
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a computeBoard resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public ComputeBoardRelationship Board
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a bootDeviceBootSecurity resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public BootDeviceBootSecurityRelationship BootDeviceBootSecurity
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a bootDeviceBootMode resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public BootDeviceBootModeRelationship BootDeviceBootmode
        {
            get;
            set;
        }












        // <summary>
        /// <para type="description">"Connectivity Status of RackUnit to Switch - A or B or AB."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string ConnectionStatus
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The time when this managed object was created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime CreateTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Connection status of the server's device connector."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string DeviceConnectionStatus
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The database identifier of the registered device of an object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string DeviceMoId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The Distinguished Name unambiguously identifies an object in the system."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Dn
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The DomainGroup ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string DomainGroupMoid
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The fault summary for the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long FaultSummary
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"The universally unique hardware identity of the server provided by the manufacturer."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string HardwareUuid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a inventoryDeviceInfo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public InventoryDeviceInfoRelationship InventoryDeviceInfo
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The KVM server state of the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool KvmServerStateEnabled
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The KVM Vendor for the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string KvmVendor
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The lifecycle state of the server. This will map to the discovery lifecycle as represented in the server Identity object.\n* `None` - Default state of an equipment. This should be an initial state when no state is defined for an equipment.\n* `Active` - Default Lifecycle State for a physical entity.\n* `Decommissioned` - Decommission Lifecycle state.\n* `DiscoveryInProgress` - DiscoveryInProgress Lifecycle state.\n* `DiscoveryFailed` - DiscoveryFailed Lifecycle state.\n* `FirmwareUpgradeInProgress` - Firmware upgrade is in progress on given physical entity.\n* `BladeMigrationInProgress` - Server slot migration is in progress on given physical entity.\n* `SlotMismatch` - The blade server is detected in a different chassis/slot than it was previously."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public ComputeRackUnit.LifecycleEnum Lifecycle
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a equipmentLocatorLed resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public EquipmentLocatorLedRelationship LocatorLed
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The management mode of the server.\n* `IntersightStandalone` - Intersight Standalone mode of operation.\n* `UCSM` - Unified Computing System Manager mode of operation.\n* `Intersight` - Intersight managed mode of operation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public ComputeRackUnit.ManagementModeEnum ManagementMode
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The maximum memory speed in MHz available on the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string MemorySpeed
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a equipmentPhysicalIdentity resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public EquipmentPhysicalIdentityRelationship MgmtIdentity
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Management address of the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string MgmtIpAddress
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The time when this managed object was last modified."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime ModTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"This field identifies the model of the given component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Model
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Moid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The name of the UCS Fabric Interconnect cluster or Cisco Integrated Management Controller (CIMC). When this server is attached to a UCS Fabric Interconnect, the value of this property is the name of the UCS Fabric Interconnect along with chassis/server Id. When this server configured in standalone mode, the value of this property is the name of the Cisco Integrated Management Controller. when this server is configired in IMM mode, the value of this property contains model and chassis/server Id."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Name
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The total number of network adapters present on the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long NumAdaptors
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The total number of CPU cores present on the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long NumCpuCores
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The total number of CPU cores enabled on the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long NumCpuCoresEnabled
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The total number of CPUs present on the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long NumCpus
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The total number of vNICs which are visible to a host on the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long NumEthHostInterfaces
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The total number of vHBAs which are visible to a host on the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long NumFcHostInterfaces
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The total number of threads the server is capable of handling."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long NumThreads
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The actual power state of the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string OperPowerState
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The operational state of the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string OperState
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The operability of the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Operability
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public MoBaseMoRelationship Parent
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"The platform type of the registered device - whether managed by UCSM or operating in standalone mode."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string PlatformType
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"This field identifies the presence (equipped) or absence of the given component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Presence
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a equipmentFru resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public EquipmentFruRelationship PreviousFru
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"A reference to a equipmentRackEnclosureSlot resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public EquipmentRackEnclosureSlotRelationship RackEnclosureSlot
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public AssetDeviceRegistrationRelationship RegisteredDevice
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"This field identifies the revision of the given component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Revision
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The Relative Name uniquely identifies an object within a given context."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Rn
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"This field identifies the serial of the given component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Serial
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"RackUnit ID that uniquely identifies the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long ServerId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The distinguished name of the service profile to which the server is associated to. It is applicable only for servers which are managed via UCSM."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string ServiceProfile
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Intersight provides pre-built workflows, tasks and policies to end users through global catalogs.\nObjects that are made available through global catalogs are said to have a 'shared' ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SharedScope
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"A reference to a topSystem resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public TopSystemRelationship TopSystem
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"To maintain the Topology workflow run status."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string TopologyScanStatus
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The total memory available on the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long TotalMemory
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The Tunneled vKVM status of the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool TunneledKvm
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The user defined label assigned to the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string UserLabel
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The universally unique identity of the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Uuid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"This field identifies the vendor of the given component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Vendor
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a computeVmedia resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public ComputeVmediaRelationship Vmedia
        {
            get;
            set;
        }


    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get ComputeRackUnitIdentity.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightComputeRackUnitIdentity", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightComputeRackUnitIdentity : GetCmdletBase
    {
        public GetIntersightComputeRackUnitIdentity()
        {
            ApiInstance = new ComputeApi(Config);
            MethodName = "GetComputeRackUnitIdentityListWithHttpInfo";
        }

        // <summary>
        /// <para type="description">"The Account ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string AccountMoid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Serial Identifier of an adapter participating in SWM."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string AdapterSerial
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Updated by UI/API to trigger specific action type.\n* `None` - No operation value for maintenance actions on an equipment.\n* `Decommission` - Decommission the equipment and temporarily remove it from being managed by Intersight.\n* `Recommission` - Recommission the equipment.\n* `Reack` - Reacknowledge the equipment and discover it again.\n* `Remove` - Remove the equipment permanently from Intersight management.\n* `Replace` - Replace the equipment with the other one."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public ComputeRackUnitIdentity.AdminActionEnum AdminAction
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The state of Maintenance Action performed. This will have three states. Applying - Action is in progress. Applied - Action is completed and applied. Failed - Action has failed.\n* `None` - Nil value when no action has been triggered by the user.\n* `Applied` - User configured settings are in applied state.\n* `Applying` - User settings are being applied on the target server.\n* `Failed` - User configured settings could not be applied."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public ComputeRackUnitIdentity.AdminActionStateEnum AdminActionState
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The time when this managed object was created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime CreateTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The DomainGroup ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string DomainGroupMoid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Numeric Identifier assigned by the management system to the equipment. Identifier can only be changed if it has been PATCHED with the AdminAction property set to 'Recommission'."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long Identifier
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Denotes the type of discovery that was most recently triggered on this server.\n* `Unknown` - The last discovery type is unknown.\n* `Deep` - The last discovery triggered is deep.\n* `Shallow` - The last discovery triggered is shallow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public ComputeRackUnitIdentity.LastDiscoveryTriggeredEnum LastDiscoveryTriggered
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The equipment's lifecycle status.\n* `None` - Default state of an equipment. This should be an initial state when no state is defined for an equipment.\n* `Active` - Default Lifecycle State for a physical entity.\n* `Decommissioned` - Decommission Lifecycle state.\n* `DecommissionInProgress` - Decommission Inprogress Lifecycle state.\n* `RecommissionInProgress` - Recommission Inprogress Lifecycle state.\n* `OperationFailed` - Failed Operation Lifecycle state.\n* `ReackInProgress` - ReackInProgress Lifecycle state.\n* `RemoveInProgress` - RemoveInProgress Lifecycle state.\n* `Discovered` - Discovered Lifecycle state.\n* `DiscoveryInProgress` - DiscoveryInProgress Lifecycle state.\n* `DiscoveryFailed` - DiscoveryFailed Lifecycle state.\n* `FirmwareUpgradeInProgress` - Firmware upgrade is in progress on given physical entity.\n* `BladeMigrationInProgress` - Server slot migration is in progress on given physical entity.\n* `Inactive` - Inactive Lifecycle state.\n* `ReplaceInProgress` - ReplaceInProgress Lifecycle state.\n* `SlotMismatch` - The blade server is detected in a different chassis/slot than it was previously."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public ComputeRackUnitIdentity.LifecycleEnum Lifecycle
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The time when this managed object was last modified."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime ModTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The vendor provided model name for the equipment."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Model
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Moid
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public MoBaseMoRelationship Parent
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public AssetDeviceRegistrationRelationship PhysicalDeviceRegistration
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public AssetDeviceRegistrationRelationship RegisteredDevice
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The serial number of the equipment."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Serial
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Intersight provides pre-built workflows, tasks and policies to end users through global catalogs.\nObjects that are made available through global catalogs are said to have a 'shared' ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SharedScope
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The manufacturer of the equipment."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Vendor
        {
            get;
            set;
        }



    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get ComputeServerIdPool.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightComputeServerIdPool", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightComputeServerIdPool : GetCmdletBase
    {
        public GetIntersightComputeServerIdPool()
        {
            ApiInstance = new ComputeApi(Config);
            MethodName = "GetComputeServerIdPoolListWithHttpInfo";
        }

        // <summary>
        /// <para type="description">"The Account ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string AccountMoid
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"The time when this managed object was created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime CreateTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public AssetDeviceRegistrationRelationship DeviceRegistration
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The DomainGroup ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string DomainGroupMoid
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The time when this managed object was last modified."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime ModTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Moid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Shows the next available Chassis ID to be allocated."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long NextAvailableId
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public MoBaseMoRelationship Parent
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"Intersight provides pre-built workflows, tasks and policies to end users through global catalogs.\nObjects that are made available through global catalogs are said to have a 'shared' ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SharedScope
        {
            get;
            set;
        }




    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get ComputeServerPowerPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightComputeServerPowerPolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightComputeServerPowerPolicy : GetCmdletBase
    {
        public GetIntersightComputeServerPowerPolicy()
        {
            ApiInstance = new ComputeApi(Config);
            MethodName = "GetComputeServerPowerPolicyListWithHttpInfo";
        }

        // <summary>
        /// <para type="description">"The Account ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string AccountMoid
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"The time when this managed object was created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime CreateTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The DomainGroup ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string DomainGroupMoid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The time when this managed object was last modified."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime ModTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Moid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public OrganizationOrganizationRelationship Organization
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public MoBaseMoRelationship Parent
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"User configured power state of server.\n* `Policy` - Power state is set to the default value in the policy.\n* `PowerOn` - Power state of the server is set to On.\n* `PowerOff` - Power state is the server set to Off.\n* `PowerCycle` - Power state the server is reset.\n* `HardReset` - Power state the server is hard reset.\n* `Shutdown` - Operating system on the server is shut down.\n* `Reboot` - Power state of IMC is rebooted."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public ComputeServerPowerPolicy.PowerStateEnum PowerState
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public AssetDeviceRegistrationRelationship RegisteredDevice
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a computePhysical resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public ComputePhysicalRelationship Server
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The name of the server it is associated with."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string ServerName
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Intersight provides pre-built workflows, tasks and policies to end users through global catalogs.\nObjects that are made available through global catalogs are said to have a 'shared' ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SharedScope
        {
            get;
            set;
        }




    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get ComputeServerSetting.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightComputeServerSetting", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightComputeServerSetting : GetCmdletBase
    {
        public GetIntersightComputeServerSetting()
        {
            ApiInstance = new ComputeApi(Config);
            MethodName = "GetComputeServerSettingListWithHttpInfo";
        }

        // <summary>
        /// <para type="description">"The Account ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string AccountMoid
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"User configured state of the locator LED for the server.\n* `None` - No operation property for locator led.\n* `On` - The Locator Led is turned on.\n* `Off` - The Locator Led is turned off."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public ComputeServerSetting.AdminLocatorLedStateEnum AdminLocatorLedState
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"User configured power state of the server.\n* `Policy` - Power state is set to the default value in the policy.\n* `PowerOn` - Power state of the server is set to On.\n* `PowerOff` - Power state is the server set to Off.\n* `PowerCycle` - Power state the server is reset.\n* `HardReset` - Power state the server is hard reset.\n* `Shutdown` - Operating system on the server is shut down.\n* `Reboot` - Power state of IMC is rebooted."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public ComputeServerSetting.AdminPowerStateEnum AdminPowerState
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"The allowed actions on the CMOS Reset.\n* `Ready` - CMOS Reset operation is allowed to be done on the server in this state.\n* `Pending` - The identifier to state that the previous CMOS Reset operation on this server has not completed due to a pending power cycle. CMOS Reset operation cannot be done on the server when in this state.\n* `Reset` - The value that the UI/API needs to provide to trigger a CMOS Reset operation on a server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public ComputeServerSetting.CmosResetEnum CmosReset
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The configured state of these settings in the target server. The value is any one of Applied, Applying, Failed. Applied - This state denotes that the settings are applied successfully in the target server. Applying - This state denotes that the settings are being applied in the target server. Failed - This state denotes that the settings could not be applied in the target server.\n* `Applied` - User configured settings are in applied state.\n* `Applying` - User settings are being applied on the target server.\n* `Scheduled` - User configured settings are scheduled to be applied.\n* `Failed` - User configured settings could not be applied."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public ComputeServerSetting.ConfigStateEnum ConfigState
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The time when this managed object was created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime CreateTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The database identifier of the registered device of an object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string DeviceMoId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The Distinguished Name unambiguously identifies an object in the system."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Dn
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The DomainGroup ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string DomainGroupMoid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The allowed actions on the Front Panel Lock.\n* `Unlock` - Front Panel of the server is set to Unlocked state.\n* `Lock` - Front Panel of the server is set to Locked state."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public ComputeServerSetting.FrontPanelLockStateEnum FrontPanelLockState
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The allowed actions on the vKVM Reset.\n* `Ready` - Reset vKVM operation is allowed to be done on the server in this state.\n* `Reset` - The value that the UI/API needs to provide to trigger a Reset vKVM operation on a server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public ComputeServerSetting.KvmResetEnum KvmReset
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a equipmentLocatorLed resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public EquipmentLocatorLedRelationship LocatorLed
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The time when this managed object was last modified."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime ModTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Moid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The property used to identify the name of the server it is associated with."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Name
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The name of the device chosen by user for configuring One-Time Boot device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string OneTimeBootDevice
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public MoBaseMoRelationship Parent
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public AssetDeviceRegistrationRelationship RegisteredDevice
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The Relative Name uniquely identifies an object within a given context."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Rn
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a workflowWorkflowInfo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public WorkflowWorkflowInfoRelationship RunningWorkflow
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a computePhysical resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public ComputePhysicalRelationship Server
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"Intersight provides pre-built workflows, tasks and policies to end users through global catalogs.\nObjects that are made available through global catalogs are said to have a 'shared' ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SharedScope
        {
            get;
            set;
        }





        // <summary>
        /// <para type="description">"Clear the configuration of TPM chip in the server.\n* `None` - Perform no action on the TPM.\n* `ClearTpm` - Clear the configuration and restore factory defaults of TPM chip in the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public ComputeServerSetting.TpmResetEnum TpmReset
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"By default, the tunneled vKVM property appears in Ready state. The property can be configured by performing allowed actions. Once the property is configured, it reverts to Ready state.\n* `Ready` - Tunneled vKVM is ready to be configured on the server.\n* `Enable` - Tunneled vKVM is enabled for the server.\n* `Disable` - Tunneled vKVM is disabled for the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public ComputeServerSetting.TunneledKvmStateEnum TunneledKvmState
        {
            get;
            set;
        }



    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get ComputeVmedia.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightComputeVmedia", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightComputeVmedia : GetCmdletBase
    {
        public GetIntersightComputeVmedia()
        {
            ApiInstance = new ComputeApi(Config);
            MethodName = "GetComputeVmediaListWithHttpInfo";
        }

        // <summary>
        /// <para type="description">"The Account ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string AccountMoid
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"A reference to a computePhysical resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public ComputePhysicalRelationship ComputePhysicalUnit
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The time when this managed object was created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime CreateTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The database identifier of the registered device of an object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string DeviceMoId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The Distinguished Name unambiguously identifies an object in the system."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Dn
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The DomainGroup ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string DomainGroupMoid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"State of the Virtual Media service on the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool Enabled
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"If enabled, allows encryption of all Virtual Media communications."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool Encryption
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a inventoryDeviceInfo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public InventoryDeviceInfoRelationship InventoryDeviceInfo
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"If enabled, the virtual drives appear on the boot selection menu after mapping the image and rebooting the host."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool LowPowerUsb
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The time when this managed object was last modified."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime ModTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Moid
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public MoBaseMoRelationship Parent
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public AssetDeviceRegistrationRelationship RegisteredDevice
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The Relative Name uniquely identifies an object within a given context."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Rn
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Intersight provides pre-built workflows, tasks and policies to end users through global catalogs.\nObjects that are made available through global catalogs are said to have a 'shared' ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SharedScope
        {
            get;
            set;
        }




    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove ComputeRackUnit.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightComputeRackUnit")]
    public class RemoveIntersightComputeRackUnit : RemoveCmdletBase
    {
        public RemoveIntersightComputeRackUnit()
        {
            ApiInstance = new ComputeApi(Config);
            MethodName = "DeleteComputeRackUnitWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove ComputeRackUnitIdentity.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightComputeRackUnitIdentity")]
    public class RemoveIntersightComputeRackUnitIdentity : RemoveCmdletBase
    {
        public RemoveIntersightComputeRackUnitIdentity()
        {
            ApiInstance = new ComputeApi(Config);
            MethodName = "DeleteComputeRackUnitIdentityWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove ComputeServerPowerPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightComputeServerPowerPolicy")]
    public class RemoveIntersightComputeServerPowerPolicy : RemoveCmdletBase
    {
        public RemoveIntersightComputeServerPowerPolicy()
        {
            ApiInstance = new ComputeApi(Config);
            MethodName = "DeleteComputeServerPowerPolicyWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set ComputeBlade.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightComputeBlade")]
    public class SetIntersightComputeBlade : SetCmdletBase
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

        public ComputeAlarmSummary AlarmSummary
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"A reference to a biosBootMode resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosBootModeRelationship BiosBootmode
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

        public BiosTokenSettingsRelationship BiosTokenSettings
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a biosVfSelectMemoryRasConfiguration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosVfSelectMemoryRasConfigurationRelationship BiosVfSelectMemoryRasConfiguration
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"An array of relationships to bootCddDevice resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<BootCddDeviceRelationship> BootCddDevices
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a bootDeviceBootSecurity resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BootDeviceBootSecurityRelationship BootDeviceBootSecurity
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"An array of relationships to bootHddDevice resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<BootHddDeviceRelationship> BootHddDevices
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"An array of relationships to bootIscsiDevice resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<BootIscsiDeviceRelationship> BootIscsiDevices
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"An array of relationships to bootNvmeDevice resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<BootNvmeDeviceRelationship> BootNvmeDevices
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"An array of relationships to bootPchStorageDevice resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<BootPchStorageDeviceRelationship> BootPchStorageDevices
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"An array of relationships to bootPxeDevice resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<BootPxeDeviceRelationship> BootPxeDevices
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"An array of relationships to bootSanDevice resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<BootSanDeviceRelationship> BootSanDevices
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"An array of relationships to bootSdDevice resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<BootSdDeviceRelationship> BootSdDevices
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"An array of relationships to bootUefiShellDevice resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<BootUefiShellDeviceRelationship> BootUefiShellDevices
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"An array of relationships to bootUsbDevice resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<BootUsbDeviceRelationship> BootUsbDevices
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"An array of relationships to bootVmediaDevice resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<BootVmediaDeviceRelationship> BootVmediaDevices
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

        public List<GraphicsCardRelationship> GraphicsCards
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

        public List<ComputeIpAddress> KvmIpAddresses
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

        public List<MemoryArrayRelationship> MemoryArrays
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a equipmentPhysicalIdentity resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public EquipmentPhysicalIdentityRelationship MgmtIdentity
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
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> OperReason
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

        public EquipmentFruRelationship PreviousFru
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"An array of relationships to processorUnit resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<ProcessorUnitRelationship> Processors
        {
            get;
            set;
        }









        // <summary>
        /// <para type="description">"An array of relationships to storageController resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<StorageControllerRelationship> StorageControllers
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<MoTag> Tags
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a topSystem resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public TopSystemRelationship TopSystem
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

        public ComputeVmediaRelationship Vmedia
        {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set ComputeBladeIdentity.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightComputeBladeIdentity")]
    public class SetIntersightComputeBladeIdentity : SetCmdletBase
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Updated by UI/API to trigger specific action type.\n* `None` - No operation value for maintenance actions on an equipment.\n* `Decommission` - Decommission the equipment and temporarily remove it from being managed by Intersight.\n* `Recommission` - Recommission the equipment.\n* `Reack` - Reacknowledge the equipment and discover it again.\n* `Remove` - Remove the equipment permanently from Intersight management.\n* `Replace` - Replace the equipment with the other one."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ComputeBladeIdentity.AdminActionEnum AdminAction
        {
            get;
            set;
        }









        // <summary>
        /// <para type="description">"Numeric Identifier assigned by the management system to the equipment. Identifier can only be changed if it has been PATCHED with the AdminAction property set to 'Recommission'."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Identifier
        {
            get;
            set;
        }







        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetDeviceRegistrationRelationship PhysicalDeviceRegistration
        {
            get;
            set;
        }






        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<MoTag> Tags
        {
            get;
            set;
        }


    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set ComputeBoard.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightComputeBoard")]
    public class SetIntersightComputeBoard : SetCmdletBase
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
















        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }










        // <summary>
        /// <para type="description">"A reference to a equipmentFru resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public EquipmentFruRelationship PreviousFru
        {
            get;
            set;
        }











        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<MoTag> Tags
        {
            get;
            set;
        }


    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set ComputeMapping.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightComputeMapping")]
    public class SetIntersightComputeMapping : SetCmdletBase
    {
        public SetIntersightComputeMapping()
        {
            ApiInstance = new ComputeApi(Config);
            ModelObject = new ComputeMapping();
            MethodName = "UpdateComputeMappingWithHttpInfo";
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
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }








        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<MoTag> Tags
        {
            get;
            set;
        }


    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set ComputePersonality.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightComputePersonality")]
    public class SetIntersightComputePersonality : SetCmdletBase
    {
        public SetIntersightComputePersonality()
        {
            ApiInstance = new ComputeApi(Config);
            ModelObject = new ComputePersonality();
            MethodName = "UpdateComputePersonalityWithHttpInfo";
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
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }









        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<MoTag> Tags
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set ComputeRackUnit.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightComputeRackUnit")]
    public class SetIntersightComputeRackUnit : SetCmdletBase
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

        public ComputeAlarmSummary AlarmSummary
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"A reference to a biosBootMode resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosBootModeRelationship BiosBootmode
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

        public BiosTokenSettingsRelationship BiosTokenSettings
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a biosVfSelectMemoryRasConfiguration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BiosVfSelectMemoryRasConfigurationRelationship BiosVfSelectMemoryRasConfiguration
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"An array of relationships to bootCddDevice resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<BootCddDeviceRelationship> BootCddDevices
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a bootDeviceBootSecurity resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BootDeviceBootSecurityRelationship BootDeviceBootSecurity
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"An array of relationships to bootHddDevice resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<BootHddDeviceRelationship> BootHddDevices
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"An array of relationships to bootIscsiDevice resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<BootIscsiDeviceRelationship> BootIscsiDevices
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"An array of relationships to bootNvmeDevice resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<BootNvmeDeviceRelationship> BootNvmeDevices
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"An array of relationships to bootPchStorageDevice resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<BootPchStorageDeviceRelationship> BootPchStorageDevices
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"An array of relationships to bootPxeDevice resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<BootPxeDeviceRelationship> BootPxeDevices
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"An array of relationships to bootSanDevice resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<BootSanDeviceRelationship> BootSanDevices
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"An array of relationships to bootSdDevice resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<BootSdDeviceRelationship> BootSdDevices
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"An array of relationships to bootUefiShellDevice resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<BootUefiShellDeviceRelationship> BootUefiShellDevices
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"An array of relationships to bootUsbDevice resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<BootUsbDeviceRelationship> BootUsbDevices
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"An array of relationships to bootVmediaDevice resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<BootVmediaDeviceRelationship> BootVmediaDevices
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

        public List<GraphicsCardRelationship> GraphicsCards
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

        public List<ComputeIpAddress> KvmIpAddresses
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

        public List<MemoryArrayRelationship> MemoryArrays
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a equipmentPhysicalIdentity resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public EquipmentPhysicalIdentityRelationship MgmtIdentity
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
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> OperReason
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

        public EquipmentFruRelationship PreviousFru
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"An array of relationships to processorUnit resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<ProcessorUnitRelationship> Processors
        {
            get;
            set;
        }






        // <summary>
        /// <para type="description">"An array of relationships to storageSasExpander resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<StorageSasExpanderRelationship> SasExpanders
        {
            get;
            set;
        }





        // <summary>
        /// <para type="description">"An array of relationships to storageController resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<StorageControllerRelationship> StorageControllers
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<MoTag> Tags
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

        public ComputeVmediaRelationship Vmedia
        {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set ComputeRackUnitIdentity.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightComputeRackUnitIdentity")]
    public class SetIntersightComputeRackUnitIdentity : SetCmdletBase
    {
        public SetIntersightComputeRackUnitIdentity()
        {
            ApiInstance = new ComputeApi(Config);
            ModelObject = new ComputeRackUnitIdentity();
            MethodName = "UpdateComputeRackUnitIdentityWithHttpInfo";
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
        /// <para type="description">"Updated by UI/API to trigger specific action type.\n* `None` - No operation value for maintenance actions on an equipment.\n* `Decommission` - Decommission the equipment and temporarily remove it from being managed by Intersight.\n* `Recommission` - Recommission the equipment.\n* `Reack` - Reacknowledge the equipment and discover it again.\n* `Remove` - Remove the equipment permanently from Intersight management.\n* `Replace` - Replace the equipment with the other one."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ComputeRackUnitIdentity.AdminActionEnum AdminAction
        {
            get;
            set;
        }





        // <summary>
        /// <para type="description">"Numeric Identifier assigned by the management system to the equipment. Identifier can only be changed if it has been PATCHED with the AdminAction property set to 'Recommission'."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Identifier
        {
            get;
            set;
        }





        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetDeviceRegistrationRelationship PhysicalDeviceRegistration
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<MoTag> Tags
        {
            get;
            set;
        }


    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set ComputeServerPowerPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightComputeServerPowerPolicy")]
    public class SetIntersightComputeServerPowerPolicy : SetCmdletBase
    {
        public SetIntersightComputeServerPowerPolicy()
        {
            ApiInstance = new ComputeApi(Config);
            ModelObject = new ComputeServerPowerPolicy();
            MethodName = "UpdateComputeServerPowerPolicyWithHttpInfo";
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
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

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
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public OrganizationOrganizationRelationship Organization
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

        public List<PolicyAbstractConfigProfileRelationship> Profiles
        {
            get;
            set;
        }





        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<MoTag> Tags
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set ComputeServerSetting.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightComputeServerSetting")]
    public class SetIntersightComputeServerSetting : SetCmdletBase
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

        public CertificatemanagementCertificateBase CertificatesAction
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
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
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

        public ComputePersistentMemoryOperation PersistentMemoryOperation
        {
            get;
            set;
        }





        // <summary>
        /// <para type="description">"The common server configurable properties between a server and a server profile."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ComputeServerConfig ServerConfig
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<ComputeServerOpStatus> ServerOpStatus
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The Storage Controller operation properties."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ComputeStorageControllerOperation StorageControllerOperation
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The Storage Physical Drives operation properties."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ComputeStoragePhysicalDriveOperation StoragePhysicalDriveOperation
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The Storage Virtual Drives operation properties."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ComputeStorageVirtualDriveOperation StorageVirtualDriveOperation
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<MoTag> Tags
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Clear the configuration of TPM chip in the server.\n* `None` - Perform no action on the TPM.\n* `ClearTpm` - Clear the configuration and restore factory defaults of TPM chip in the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ComputeServerSetting.TpmResetEnum TpmReset
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

    }
}