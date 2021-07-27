using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get StorageHitachiHost.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStorageHitachiHost", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStorageHitachiHost:GetCmdletBase
	{
		public GetIntersightStorageHitachiHost()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStorageHitachiHostList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get StorageNetAppCluster.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStorageNetAppCluster", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStorageNetAppCluster:GetCmdletBase
	{
		public GetIntersightStorageNetAppCluster()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStorageNetAppClusterList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get StoragePureVolumeSnapshot.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStoragePureVolumeSnapshot", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStoragePureVolumeSnapshot:GetCmdletBase
	{
		public GetIntersightStoragePureVolumeSnapshot()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStoragePureVolumeSnapshotList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set StorageFlexUtilPhysicalDrive.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightStorageFlexUtilPhysicalDrive")]
    public class SetIntersightStorageFlexUtilPhysicalDrive:SetCmdletBase
	{
		public SetIntersightStorageFlexUtilPhysicalDrive()
		{
			ApiInstance = new StorageApi(Config);
            ModelObject = new StorageFlexUtilPhysicalDrive();
            MethodName = "UpdateStorageFlexUtilPhysicalDrive";
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
        /// <para type="description">"Block size of the FlexUtil Physical drive."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string BlockSize {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Capacity of the FlexUtil Physical drive."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Capacity {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of the Physical Drive Controller."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Controller {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of drives enabled in the FlexUtil Physical Drive."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string DrivesEnabled {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Health of the FlexUtil Physical drive."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Health {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Manufacturing date of the FlexUtil Physical Drive."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ManufacturerDate {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Manufacturer identity of the FlexUtil Physical Drive."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ManufacturerId {
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
        /// <para type="description">"The OEM Identifier of the FlexUtil physical drive."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string OemId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of partitions present on the FlexUtil Physical Drive."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string PartitionCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Status of the FlexUtil Physical Drive."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string PdStatus {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The type of physical drive. Example - microSD."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string PhysicalDrive {
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
        /// <para type="description">"Product name of the FlexUtil Physical Drive."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ProductName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Product revision of the FlexUtil Physical Drive."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ProductRevision {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Read error count of the FlexUtil Physical Drive."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ReadErrorCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Read error threshold for FlexUtil Physical Drive."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ReadErrorThreshold {
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
        /// <para type="description">"Write access state of the FlexUtil Physical Drive."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string WriteEnabled {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Write error count of the FlexUtil Physical Drive."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string WriteErrorCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Write error threshold for FlexUtil Physical Drive."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string WriteErrorThreshold {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set StorageSasPort.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightStorageSasPort")]
    public class SetIntersightStorageSasPort:SetCmdletBase
	{
		public SetIntersightStorageSasPort()
		{
			ApiInstance = new StorageApi(Config);
            ModelObject = new StorageSasPort();
            MethodName = "UpdateStorageSasPort";
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
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get StorageNetAppExportPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStorageNetAppExportPolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStorageNetAppExportPolicy:GetCmdletBase
	{
		public GetIntersightStorageNetAppExportPolicy()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStorageNetAppExportPolicyList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get StorageFlexUtilVirtualDrive.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStorageFlexUtilVirtualDrive", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStorageFlexUtilVirtualDrive:GetCmdletBase
	{
		public GetIntersightStorageFlexUtilVirtualDrive()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStorageFlexUtilVirtualDriveList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get StorageNetAppFcInterface.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStorageNetAppFcInterface", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStorageNetAppFcInterface:GetCmdletBase
	{
		public GetIntersightStorageNetAppFcInterface()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStorageNetAppFcInterfaceList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get StorageVirtualDriveContainer.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStorageVirtualDriveContainer", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStorageVirtualDriveContainer:GetCmdletBase
	{
		public GetIntersightStorageVirtualDriveContainer()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStorageVirtualDriveContainerList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get StorageHitachiParityGroup.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStorageHitachiParityGroup", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStorageHitachiParityGroup:GetCmdletBase
	{
		public GetIntersightStorageHitachiParityGroup()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStorageHitachiParityGroupList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get StorageEnclosure.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStorageEnclosure", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStorageEnclosure:GetCmdletBase
	{
		public GetIntersightStorageEnclosure()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStorageEnclosureList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get StorageNetAppIpInterface.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStorageNetAppIpInterface", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStorageNetAppIpInterface:GetCmdletBase
	{
		public GetIntersightStorageNetAppIpInterface()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStorageNetAppIpInterfaceList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set StorageFlexFlashController.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightStorageFlexFlashController")]
    public class SetIntersightStorageFlexFlashController:SetCmdletBase
	{
		public SetIntersightStorageFlexFlashController()
		{
			ApiInstance = new StorageApi(Config);
            ModelObject = new StorageFlexFlashController();
            MethodName = "UpdateStorageFlexFlashController";
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
    /// <para type="synopsis">This is the cmdlet to Get StorageDiskGroup.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStorageDiskGroup", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStorageDiskGroup:GetCmdletBase
	{
		public GetIntersightStorageDiskGroup()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStorageDiskGroupList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set StorageSasExpander.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightStorageSasExpander")]
    public class SetIntersightStorageSasExpander:SetCmdletBase
	{
		public SetIntersightStorageSasExpander()
		{
			ApiInstance = new StorageApi(Config);
            ModelObject = new StorageSasExpander();
            MethodName = "UpdateStorageSasExpander";
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
        /// <para type="description">"A reference to a computeRackUnit resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ComputeRackUnitRelationship ComputeRackUnit {
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
        /// <para type="description">"The name  of the installed storage expander."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Name {
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
    /// <para type="synopsis">This is the cmdlet to Get StorageSpan.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStorageSpan", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStorageSpan:GetCmdletBase
	{
		public GetIntersightStorageSpan()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStorageSpanList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get StoragePurePort.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStoragePurePort", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStoragePurePort:GetCmdletBase
	{
		public GetIntersightStoragePurePort()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStoragePurePortList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get StorageNetAppFcPort.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStorageNetAppFcPort", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStorageNetAppFcPort:GetCmdletBase
	{
		public GetIntersightStorageNetAppFcPort()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStorageNetAppFcPortList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set StorageFlexFlashControllerProps.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightStorageFlexFlashControllerProps")]
    public class SetIntersightStorageFlexFlashControllerProps:SetCmdletBase
	{
		public SetIntersightStorageFlexFlashControllerProps()
		{
			ApiInstance = new StorageApi(Config);
            ModelObject = new StorageFlexFlashControllerProps();
            MethodName = "UpdateStorageFlexFlashControllerProps";
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
        /// <para type="description">"Manageable card on the flex flash controller."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string CardsManageable {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Mode configured on the flex flash controller."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ConfiguredMode {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The current name of the flex flash controller."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ControllerName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The current status of the flex flash controller."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ControllerStatus {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Firmware version of the flex flash controller."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string FwVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Internal state of the flex flash controller."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string InternalState {
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
        /// <para type="description">"Operating mode of flex flash controller."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string OperatingMode {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of connected physical drives to a specific Flex flash controller."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string PhysicalDriveCount {
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
        /// <para type="description">"Product name of the flex flash controller."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ProductName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Startup firmware version of the Flex flash controller."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string StartupFwVersion {
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
        /// <para type="description">"Number of virtual drives for a specific Flex flash controller."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string VirtualDriveCount {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set StorageVirtualDriveContainer.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightStorageVirtualDriveContainer")]
    public class SetIntersightStorageVirtualDriveContainer:SetCmdletBase
	{
		public SetIntersightStorageVirtualDriveContainer()
		{
			ApiInstance = new StorageApi(Config);
            ModelObject = new StorageVirtualDriveContainer();
            MethodName = "UpdateStorageVirtualDriveContainer";
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
        /// <para type="description">"A reference to a equipmentChassis resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public EquipmentChassisRelationship EquipmentChassis {
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
        // <summary>
        /// <para type="description">"An array of relationships to storageVirtualDrive resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<StorageVirtualDriveRelationship> VirtualDrive {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get StorageNetAppLun.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStorageNetAppLun", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStorageNetAppLun:GetCmdletBase
	{
		public GetIntersightStorageNetAppLun()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStorageNetAppLunList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get StorageNetAppLicense.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStorageNetAppLicense", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStorageNetAppLicense:GetCmdletBase
	{
		public GetIntersightStorageNetAppLicense()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStorageNetAppLicenseList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get StorageHitachiPort.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStorageHitachiPort", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStorageHitachiPort:GetCmdletBase
	{
		public GetIntersightStorageHitachiPort()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStorageHitachiPortList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get StorageNetAppLunMap.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStorageNetAppLunMap", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStorageNetAppLunMap:GetCmdletBase
	{
		public GetIntersightStorageNetAppLunMap()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStorageNetAppLunMapList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get StorageSasExpander.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStorageSasExpander", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStorageSasExpander:GetCmdletBase
	{
		public GetIntersightStorageSasExpander()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStorageSasExpanderList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set StorageFlexUtilController.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightStorageFlexUtilController")]
    public class SetIntersightStorageFlexUtilController:SetCmdletBase
	{
		public SetIntersightStorageFlexUtilController()
		{
			ApiInstance = new StorageApi(Config);
            ModelObject = new StorageFlexUtilController();
            MethodName = "UpdateStorageFlexUtilController";
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
        /// <para type="description">"Name of the Flex Util Controller."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ControllerName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The current status of the controller."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ControllerStatus {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Identifier for the Storage Flex Util Controller."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string FfControllerId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The internal state of the controller."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string InternalState {
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
    /// <para type="synopsis">This is the cmdlet to Set StorageEnclosure.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightStorageEnclosure")]
    public class SetIntersightStorageEnclosure:SetCmdletBase
	{
		public SetIntersightStorageEnclosure()
		{
			ApiInstance = new StorageApi(Config);
            ModelObject = new StorageEnclosure();
            MethodName = "UpdateStorageEnclosure";
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
    /// <para type="synopsis">This is the cmdlet to Set StoragePhysicalDiskExtension.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightStoragePhysicalDiskExtension")]
    public class SetIntersightStoragePhysicalDiskExtension:SetCmdletBase
	{
		public SetIntersightStoragePhysicalDiskExtension()
		{
			ApiInstance = new StorageApi(Config);
            ModelObject = new StoragePhysicalDiskExtension();
            MethodName = "PatchStoragePhysicalDiskExtension";
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
        /// <para type="description">"The current drive state of disk."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Health {
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
        /// <para type="description">"A reference to a storagePhysicalDisk resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StoragePhysicalDiskRelationship PhysicalDisk {
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
    /// <para type="synopsis">This is the cmdlet to Get StorageFlexFlashVirtualDrive.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStorageFlexFlashVirtualDrive", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStorageFlexFlashVirtualDrive:GetCmdletBase
	{
		public GetIntersightStorageFlexFlashVirtualDrive()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStorageFlexFlashVirtualDriveList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set StorageVdMemberEp.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightStorageVdMemberEp")]
    public class SetIntersightStorageVdMemberEp:SetCmdletBase
	{
		public SetIntersightStorageVdMemberEp()
		{
			ApiInstance = new StorageApi(Config);
            ModelObject = new StorageVdMemberEp();
            MethodName = "UpdateStorageVdMemberEp";
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
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get StorageController.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStorageController", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStorageController:GetCmdletBase
	{
		public GetIntersightStorageController()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStorageControllerList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get StoragePureVolume.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStoragePureVolume", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStoragePureVolume:GetCmdletBase
	{
		public GetIntersightStoragePureVolume()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStoragePureVolumeList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set StorageEnclosureDiskSlotEp.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightStorageEnclosureDiskSlotEp")]
    public class SetIntersightStorageEnclosureDiskSlotEp:SetCmdletBase
	{
		public SetIntersightStorageEnclosureDiskSlotEp()
		{
			ApiInstance = new StorageApi(Config);
            ModelObject = new StorageEnclosureDiskSlotEp();
            MethodName = "UpdateStorageEnclosureDiskSlotEp";
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
        /// <para type="description">"This field identifies the zoning configuration applied to  this enclosure slot."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string DrivePath {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"This field identifies the health of the disk inserted in the slot."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Health {
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
        /// <para type="description">"This field identifies the disk is present in the enclosure slot."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Presence {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"This field represents the slot Id in the storage enclosure."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Slot {
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
    /// <para type="synopsis">This is the cmdlet to Get StoragePureArray.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStoragePureArray", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStoragePureArray:GetCmdletBase
	{
		public GetIntersightStoragePureArray()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStoragePureArrayList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get StoragePureDisk.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStoragePureDisk", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStoragePureDisk:GetCmdletBase
	{
		public GetIntersightStoragePureDisk()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStoragePureDiskList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get StorageSasPort.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStorageSasPort", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStorageSasPort:GetCmdletBase
	{
		public GetIntersightStorageSasPort()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStorageSasPortList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get StoragePureController.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStoragePureController", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStoragePureController:GetCmdletBase
	{
		public GetIntersightStoragePureController()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStoragePureControllerList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get StoragePureSnapshotSchedule.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStoragePureSnapshotSchedule", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStoragePureSnapshotSchedule:GetCmdletBase
	{
		public GetIntersightStoragePureSnapshotSchedule()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStoragePureSnapshotScheduleList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set StorageFlexUtilVirtualDrive.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightStorageFlexUtilVirtualDrive")]
    public class SetIntersightStorageFlexUtilVirtualDrive:SetCmdletBase
	{
		public SetIntersightStorageFlexUtilVirtualDrive()
		{
			ApiInstance = new StorageApi(Config);
            ModelObject = new StorageFlexUtilVirtualDrive();
            MethodName = "PatchStorageFlexUtilVirtualDrive";
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
        /// <para type="description">"Status of the Flex Util virtual drive."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string DriveStatus {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of virtual drive managed by flex util controller."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string DriveType {
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
        /// <para type="description">"Disk Partition Id of virtual drive managed by flex util controller."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string PartitionId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Partition name of the Flex Util virtual drive."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string PartitionName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The resident image on the flex util virtual Drive."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ResidentImage {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Size of the Flex Util virtual drive."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Size {
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
        /// <para type="description">"Virtual drive on the Flex Util controller."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string VirtualDrive {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set StorageNetAppCluster.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightStorageNetAppCluster")]
    public class SetIntersightStorageNetAppCluster:SetCmdletBase
	{
		public SetIntersightStorageNetAppCluster()
		{
			ApiInstance = new StorageApi(Config);
            ModelObject = new StorageNetAppCluster();
            MethodName = "UpdateStorageNetAppCluster";
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
    /// <para type="synopsis">This is the cmdlet to Get StorageHyperFlexVolume.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStorageHyperFlexVolume", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStorageHyperFlexVolume:GetCmdletBase
	{
		public GetIntersightStorageHyperFlexVolume()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStorageHyperFlexVolumeList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get StorageFlexUtilPhysicalDrive.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStorageFlexUtilPhysicalDrive", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStorageFlexUtilPhysicalDrive:GetCmdletBase
	{
		public GetIntersightStorageFlexUtilPhysicalDrive()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStorageFlexUtilPhysicalDriveList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get StoragePureReplicationSchedule.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStoragePureReplicationSchedule", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStoragePureReplicationSchedule:GetCmdletBase
	{
		public GetIntersightStoragePureReplicationSchedule()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStoragePureReplicationScheduleList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get StoragePureHostLun.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStoragePureHostLun", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStoragePureHostLun:GetCmdletBase
	{
		public GetIntersightStoragePureHostLun()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStoragePureHostLunList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get StorageVirtualDrive.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStorageVirtualDrive", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStorageVirtualDrive:GetCmdletBase
	{
		public GetIntersightStorageVirtualDrive()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStorageVirtualDriveList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get StorageNetAppBaseDisk.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStorageNetAppBaseDisk", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStorageNetAppBaseDisk:GetCmdletBase
	{
		public GetIntersightStorageNetAppBaseDisk()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStorageNetAppBaseDiskList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get StorageNetAppVolumeSnapshot.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStorageNetAppVolumeSnapshot", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStorageNetAppVolumeSnapshot:GetCmdletBase
	{
		public GetIntersightStorageNetAppVolumeSnapshot()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStorageNetAppVolumeSnapshotList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get StorageFlexFlashControllerProps.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStorageFlexFlashControllerProps", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStorageFlexFlashControllerProps:GetCmdletBase
	{
		public GetIntersightStorageFlexFlashControllerProps()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStorageFlexFlashControllerPropsList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set StoragePureArray.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightStoragePureArray")]
    public class SetIntersightStoragePureArray:SetCmdletBase
	{
		public SetIntersightStoragePureArray()
		{
			ApiInstance = new StorageApi(Config);
            ModelObject = new StoragePureArray();
            MethodName = "UpdateStoragePureArray";
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
    /// <para type="synopsis">This is the cmdlet to Get StoragePureHost.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStoragePureHost", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStoragePureHost:GetCmdletBase
	{
		public GetIntersightStoragePureHost()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStoragePureHostList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get StorageHyperFlexStorageContainer.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStorageHyperFlexStorageContainer", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStorageHyperFlexStorageContainer:GetCmdletBase
	{
		public GetIntersightStorageHyperFlexStorageContainer()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStorageHyperFlexStorageContainerList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set StoragePhysicalDisk.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightStoragePhysicalDisk")]
    public class SetIntersightStoragePhysicalDisk:SetCmdletBase
	{
		public SetIntersightStoragePhysicalDisk()
		{
			ApiInstance = new StorageApi(Config);
            ModelObject = new StoragePhysicalDisk();
            MethodName = "UpdateStoragePhysicalDisk";
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
        /// <para type="description">"This field identifies the disk firmware running in the disk."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string DriveFirmware {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Full-Disk Encryption capability parameter of the physical disk."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string FdeCapable {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of hotspare configured on the physical disk."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string HotSpareType {
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
        /// <para type="description">"An array of relationships to storagePhysicalDiskExtension resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<StoragePhysicalDiskExtensionRelationship> PhysicalDiskExtensions {
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
        /// <para type="description">"This field identifies whether the disk is encrypted."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Secured {
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
    /// <para type="synopsis">This is the cmdlet to Get StorageNetAppAggregate.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStorageNetAppAggregate", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStorageNetAppAggregate:GetCmdletBase
	{
		public GetIntersightStorageNetAppAggregate()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStorageNetAppAggregateList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get StorageEnclosureDisk.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStorageEnclosureDisk", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStorageEnclosureDisk:GetCmdletBase
	{
		public GetIntersightStorageEnclosureDisk()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStorageEnclosureDiskList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get StorageHitachiArray.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStorageHitachiArray", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStorageHitachiArray:GetCmdletBase
	{
		public GetIntersightStorageHitachiArray()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStorageHitachiArrayList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get StoragePureProtectionGroupSnapshot.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStoragePureProtectionGroupSnapshot", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStoragePureProtectionGroupSnapshot:GetCmdletBase
	{
		public GetIntersightStoragePureProtectionGroupSnapshot()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStoragePureProtectionGroupSnapshotList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get StorageDiskGroupPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStorageDiskGroupPolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStorageDiskGroupPolicy:GetCmdletBase
	{
		public GetIntersightStorageDiskGroupPolicy()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStorageDiskGroupPolicyList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New StorageDiskGroupPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightStorageDiskGroupPolicy")]
    public class NewIntersightStorageDiskGroupPolicy:NewCmdletBase
	{
		public NewIntersightStorageDiskGroupPolicy()
		{
			ApiInstance = new StorageApi(Config);
            ModelObject = new StorageDiskGroupPolicy();
            MethodName = "CreateStorageDiskGroupPolicy";
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<StorageLocalDisk> DedicatedHotSpares {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The supported RAID level for the disk group.\n* `Raid0` - RAID 0 Stripe Raid Level.\n* `Raid1` - RAID 1 Mirror Raid Level.\n* `Raid5` - RAID 5 Mirror Raid Level.\n* `Raid6` - RAID 6 Mirror Raid Level.\n* `Raid10` - RAID 10 Mirror Raid Level.\n* `Raid50` - RAID 50 Mirror Raid Level.\n* `Raid60` - RAID 60 Mirror Raid Level."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageDiskGroupPolicy.RaidLevelEnum RaidLevel {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<StorageSpanGroup> SpanGroups {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to storageStoragePolicy resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<StorageStoragePolicyRelationship> StoragePolicies {
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
        /// <para type="description">"Selected disks in the disk group in JBOD state will be set to Unconfigured Good state before they are used in virtual drive creation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool UseJbods {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get StorageNetAppInitiatorGroup.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStorageNetAppInitiatorGroup", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStorageNetAppInitiatorGroup:GetCmdletBase
	{
		public GetIntersightStorageNetAppInitiatorGroup()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStorageNetAppInitiatorGroupList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get StoragePureHostGroup.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStoragePureHostGroup", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStoragePureHostGroup:GetCmdletBase
	{
		public GetIntersightStoragePureHostGroup()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStoragePureHostGroupList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get StorageDiskSlot.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStorageDiskSlot", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStorageDiskSlot:GetCmdletBase
	{
		public GetIntersightStorageDiskSlot()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStorageDiskSlotList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove StorageStoragePolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightStorageStoragePolicy")]
    public class RemoveIntersightStorageStoragePolicy:RemoveCmdletBase
	{
		public RemoveIntersightStorageStoragePolicy()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "DeleteStorageStoragePolicy";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set StorageStoragePolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightStorageStoragePolicy")]
    public class SetIntersightStorageStoragePolicy:SetCmdletBase
	{
		public SetIntersightStorageStoragePolicy()
		{
			ApiInstance = new StorageApi(Config);
            ModelObject = new StorageStoragePolicy();
            MethodName = "UpdateStorageStoragePolicy";
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
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to storageDiskGroupPolicy resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<StorageDiskGroupPolicyRelationship> DiskGroupPolicies {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<StorageLocalDisk> GlobalHotSpares {
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to policyAbstractConfigProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<PolicyAbstractConfigProfileRelationship> Profiles {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Retains the virtual drives defined in policy if they exist already. If this flag is false, the existing virtual drives are removed and created again based on virtual drives in the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool RetainPolicyVirtualDrives {
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
        /// <para type="description">"Unused Disks State is used to specify the state, unconfigured good or jbod, in which the disks that are not used in this policy should be moved.\n* `UnconfiguredGood` - Unconfigured good state -ready to be added in a RAID group.\n* `Jbod` - JBOD state where the disks start showing up to host os."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageStoragePolicy.UnusedDisksStateEnum UnusedDisksState {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<StorageVirtualDriveConfig> VirtualDrives {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get StorageHitachiController.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStorageHitachiController", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStorageHitachiController:GetCmdletBase
	{
		public GetIntersightStorageHitachiController()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStorageHitachiControllerList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get StorageHitachiPool.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStorageHitachiPool", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStorageHitachiPool:GetCmdletBase
	{
		public GetIntersightStorageHitachiPool()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStorageHitachiPoolList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set StoragePhysicalDiskUsage.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightStoragePhysicalDiskUsage")]
    public class SetIntersightStoragePhysicalDiskUsage:SetCmdletBase
	{
		public SetIntersightStoragePhysicalDiskUsage()
		{
			ApiInstance = new StorageApi(Config);
            ModelObject = new StoragePhysicalDiskUsage();
            MethodName = "UpdateStoragePhysicalDiskUsage";
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
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get StorageFlexUtilController.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStorageFlexUtilController", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStorageFlexUtilController:GetCmdletBase
	{
		public GetIntersightStorageFlexUtilController()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStorageFlexUtilControllerList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set StorageSpan.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightStorageSpan")]
    public class SetIntersightStorageSpan:SetCmdletBase
	{
		public SetIntersightStorageSpan()
		{
			ApiInstance = new StorageApi(Config);
            ModelObject = new StorageSpan();
            MethodName = "UpdateStorageSpan";
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
        /// <para type="description">"A reference to a storageDiskGroup resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageDiskGroupRelationship DiskGroup {
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
        /// <para type="description">"An array of relationships to storagePhysicalDisk resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<StoragePhysicalDiskRelationship> PhysicalDisks {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<long> Slots {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Unique identifier value of this span."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long SpanId {
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
    /// <para type="synopsis">This is the cmdlet to Get StorageEnclosureDiskSlotEp.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStorageEnclosureDiskSlotEp", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStorageEnclosureDiskSlotEp:GetCmdletBase
	{
		public GetIntersightStorageEnclosureDiskSlotEp()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStorageEnclosureDiskSlotEpList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set StorageFlexFlashVirtualDrive.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightStorageFlexFlashVirtualDrive")]
    public class SetIntersightStorageFlexFlashVirtualDrive:SetCmdletBase
	{
		public SetIntersightStorageFlexFlashVirtualDrive()
		{
			ApiInstance = new StorageApi(Config);
            ModelObject = new StorageFlexFlashVirtualDrive();
            MethodName = "UpdateStorageFlexFlashVirtualDrive";
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
        /// <para type="description">"The drive scope of the flex flash virtual drive."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string DriveScope {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Status of virtual drive on the flex controller."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string DriveStatus {
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
        /// <para type="description">"The partition Id of the flex flash virtual Drive."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string PartitionId {
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
        /// <para type="description">"The resident image on the flex flash virtual Drive."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ResidentImage {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Size of virtual drive on the flex controller."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Size {
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
        /// <para type="description">"Virtual drive on the flex flash controller."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string VirtualDrive {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get StorageItem.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStorageItem", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStorageItem:GetCmdletBase
	{
		public GetIntersightStorageItem()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStorageItemList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set StorageController.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightStorageController")]
    public class SetIntersightStorageController:SetCmdletBase
	{
		public SetIntersightStorageController()
		{
			ApiInstance = new StorageApi(Config);
            ModelObject = new StorageController();
            MethodName = "UpdateStorageController";
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
        /// <para type="description">"A reference to a computeBlade resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ComputeBladeRelationship ComputeBlade {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a computeRackUnit resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ComputeRackUnitRelationship ComputeRackUnit {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to storageDiskGroup resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<StorageDiskGroupRelationship> DiskGroup {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Storage controller has detected disks in foreign config."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool ForeignConfigPresent {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Interface types are Sas, Sata, PCH."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string InterfaceType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Maximum virtual drives that can be created on this Storage Controller."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long MaxVolumesSupported {
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
        /// <para type="description">"A reference to a equipmentFru resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public EquipmentFruRelationship PreviousFru {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Storage controller disk self encryption state."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SelfEncryptEnabled {
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
    /// <para type="synopsis">This is the cmdlet to Set StorageDiskGroup.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightStorageDiskGroup")]
    public class SetIntersightStorageDiskGroup:SetCmdletBase
	{
		public SetIntersightStorageDiskGroup()
		{
			ApiInstance = new StorageApi(Config);
            ModelObject = new StorageDiskGroup();
            MethodName = "UpdateStorageDiskGroup";
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
        /// <para type="description">"An array of relationships to storagePhysicalDisk resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<StoragePhysicalDiskRelationship> DedicatedHotSpares {
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
        /// <para type="description">"Name to identity this disk group in the controller."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Raid level of the virtual drives in this diskgroup."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RaidType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to storageSpan resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<StorageSpanRelationship> Spans {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a storageController resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageControllerRelationship StorageController {
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
        /// <para type="description">"An array of relationships to storageVirtualDrive resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<StorageVirtualDriveRelationship> VirtualDrives {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set StorageHitachiArray.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightStorageHitachiArray")]
    public class SetIntersightStorageHitachiArray:SetCmdletBase
	{
		public SetIntersightStorageHitachiArray()
		{
			ApiInstance = new StorageApi(Config);
            ModelObject = new StorageHitachiArray();
            MethodName = "UpdateStorageHitachiArray";
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
    /// <para type="synopsis">This is the cmdlet to Get StorageStoragePolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStorageStoragePolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStorageStoragePolicy:GetCmdletBase
	{
		public GetIntersightStorageStoragePolicy()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStorageStoragePolicyList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New StorageStoragePolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightStorageStoragePolicy")]
    public class NewIntersightStorageStoragePolicy:NewCmdletBase
	{
		public NewIntersightStorageStoragePolicy()
		{
			ApiInstance = new StorageApi(Config);
            ModelObject = new StorageStoragePolicy();
            MethodName = "CreateStorageStoragePolicy";
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
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to storageDiskGroupPolicy resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<StorageDiskGroupPolicyRelationship> DiskGroupPolicies {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<StorageLocalDisk> GlobalHotSpares {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to policyAbstractConfigProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<PolicyAbstractConfigProfileRelationship> Profiles {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Retains the virtual drives defined in policy if they exist already. If this flag is false, the existing virtual drives are removed and created again based on virtual drives in the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool RetainPolicyVirtualDrives {
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
        /// <para type="description">"Unused Disks State is used to specify the state, unconfigured good or jbod, in which the disks that are not used in this policy should be moved.\n* `UnconfiguredGood` - Unconfigured good state -ready to be added in a RAID group.\n* `Jbod` - JBOD state where the disks start showing up to host os."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageStoragePolicy.UnusedDisksStateEnum UnusedDisksState {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<StorageVirtualDriveConfig> VirtualDrives {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get StorageHitachiDisk.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStorageHitachiDisk", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStorageHitachiDisk:GetCmdletBase
	{
		public GetIntersightStorageHitachiDisk()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStorageHitachiDiskList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set StorageVirtualDrive.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightStorageVirtualDrive")]
    public class SetIntersightStorageVirtualDrive:SetCmdletBase
	{
		public SetIntersightStorageVirtualDrive()
		{
			ApiInstance = new StorageApi(Config);
            ModelObject = new StorageVirtualDrive();
            MethodName = "UpdateStorageVirtualDrive";
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
        /// <para type="description">"A reference to a storageDiskGroup resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageDiskGroupRelationship DiskGroup {
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
        /// <para type="description">"An array of relationships to storagePhysicalDiskUsage resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<StoragePhysicalDiskUsageRelationship> PhysicalDiskUsages {
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
        /// <para type="description">"A reference to a storageVirtualDriveContainer resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageVirtualDriveContainerRelationship StorageVirtualDriveContainer {
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
    /// <para type="synopsis">This is the cmdlet to Get StorageNetAppNode.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStorageNetAppNode", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStorageNetAppNode:GetCmdletBase
	{
		public GetIntersightStorageNetAppNode()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStorageNetAppNodeList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get StorageHitachiVolume.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStorageHitachiVolume", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStorageHitachiVolume:GetCmdletBase
	{
		public GetIntersightStorageHitachiVolume()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStorageHitachiVolumeList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get StoragePureProtectionGroup.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStoragePureProtectionGroup", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStoragePureProtectionGroup:GetCmdletBase
	{
		public GetIntersightStoragePureProtectionGroup()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStoragePureProtectionGroupList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get StorageVirtualDriveExtension.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStorageVirtualDriveExtension", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStorageVirtualDriveExtension:GetCmdletBase
	{
		public GetIntersightStorageVirtualDriveExtension()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStorageVirtualDriveExtensionList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get StorageFlexFlashPhysicalDrive.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStorageFlexFlashPhysicalDrive", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStorageFlexFlashPhysicalDrive:GetCmdletBase
	{
		public GetIntersightStorageFlexFlashPhysicalDrive()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStorageFlexFlashPhysicalDriveList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get StoragePhysicalDisk.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStoragePhysicalDisk", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStoragePhysicalDisk:GetCmdletBase
	{
		public GetIntersightStoragePhysicalDisk()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStoragePhysicalDiskList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get StoragePhysicalDiskUsage.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStoragePhysicalDiskUsage", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStoragePhysicalDiskUsage:GetCmdletBase
	{
		public GetIntersightStoragePhysicalDiskUsage()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStoragePhysicalDiskUsageList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set StorageVirtualDriveExtension.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightStorageVirtualDriveExtension")]
    public class SetIntersightStorageVirtualDriveExtension:SetCmdletBase
	{
		public SetIntersightStorageVirtualDriveExtension()
		{
			ApiInstance = new StorageApi(Config);
            ModelObject = new StorageVirtualDriveExtension();
            MethodName = "UpdateStorageVirtualDriveExtension";
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
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get StoragePhysicalDiskExtension.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStoragePhysicalDiskExtension", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStoragePhysicalDiskExtension:GetCmdletBase
	{
		public GetIntersightStoragePhysicalDiskExtension()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStoragePhysicalDiskExtensionList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get StorageVdMemberEp.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStorageVdMemberEp", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStorageVdMemberEp:GetCmdletBase
	{
		public GetIntersightStorageVdMemberEp()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStorageVdMemberEpList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get StorageNetAppVolume.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStorageNetAppVolume", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStorageNetAppVolume:GetCmdletBase
	{
		public GetIntersightStorageNetAppVolume()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStorageNetAppVolumeList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set StorageEnclosureDisk.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightStorageEnclosureDisk")]
    public class SetIntersightStorageEnclosureDisk:SetCmdletBase
	{
		public SetIntersightStorageEnclosureDisk()
		{
			ApiInstance = new StorageApi(Config);
            ModelObject = new StorageEnclosureDisk();
            MethodName = "UpdateStorageEnclosureDisk";
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
        /// <para type="description">"The block size of the physical disk in bytes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string BlockSize {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"This field represents the disk Id in the storage enclosure."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string DiskId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"This field identifies the current disk configuration applied in the physical disk."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string DiskState {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The current health state of the enclosure disk."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Health {
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
        /// <para type="description">"The number of blocks present on the physical disk."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string NumBlocks {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a storagePhysicalDisk resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StoragePhysicalDiskRelationship PhysicalDisk {
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
        /// <para type="description">"This field identifies the SAS address assigned to the disk SAS port-1."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SasAddress1 {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"This field identifies the SAS address assigned to the disk SAS port-2."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SasAddress2 {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The size of the physical disk in MB."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Size {
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
    /// <para type="synopsis">This is the cmdlet to Get StorageHitachiHostLun.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStorageHitachiHostLun", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStorageHitachiHostLun:GetCmdletBase
	{
		public GetIntersightStorageHitachiHostLun()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStorageHitachiHostLunList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get StorageNetAppEthernetPort.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStorageNetAppEthernetPort", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStorageNetAppEthernetPort:GetCmdletBase
	{
		public GetIntersightStorageNetAppEthernetPort()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStorageNetAppEthernetPortList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get StorageFlexFlashController.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStorageFlexFlashController", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStorageFlexFlashController:GetCmdletBase
	{
		public GetIntersightStorageFlexFlashController()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStorageFlexFlashControllerList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get StorageNetAppStorageVm.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStorageNetAppStorageVm", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStorageNetAppStorageVm:GetCmdletBase
	{
		public GetIntersightStorageNetAppStorageVm()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStorageNetAppStorageVmList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set StorageFlexFlashPhysicalDrive.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightStorageFlexFlashPhysicalDrive")]
    public class SetIntersightStorageFlexFlashPhysicalDrive:SetCmdletBase
	{
		public SetIntersightStorageFlexFlashPhysicalDrive()
		{
			ApiInstance = new StorageApi(Config);
            ModelObject = new StorageFlexFlashPhysicalDrive();
            MethodName = "UpdateStorageFlexFlashPhysicalDrive";
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
        /// <para type="description">"The status of the flex flash physical drive."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string CardStatus {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The card type of the flex flash physical drive."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string CardType {
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
        /// <para type="description">"The OEM Identifier of the flex flash physical drive."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string OemId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The drive status of the flex flash physical drive."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string PdStatus {
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
    /// <para type="synopsis">This is the cmdlet to Set StorageDiskGroupPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightStorageDiskGroupPolicy")]
    public class SetIntersightStorageDiskGroupPolicy:SetCmdletBase
	{
		public SetIntersightStorageDiskGroupPolicy()
		{
			ApiInstance = new StorageApi(Config);
            ModelObject = new StorageDiskGroupPolicy();
            MethodName = "UpdateStorageDiskGroupPolicy";
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<StorageLocalDisk> DedicatedHotSpares {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The supported RAID level for the disk group.\n* `Raid0` - RAID 0 Stripe Raid Level.\n* `Raid1` - RAID 1 Mirror Raid Level.\n* `Raid5` - RAID 5 Mirror Raid Level.\n* `Raid6` - RAID 6 Mirror Raid Level.\n* `Raid10` - RAID 10 Mirror Raid Level.\n* `Raid50` - RAID 50 Mirror Raid Level.\n* `Raid60` - RAID 60 Mirror Raid Level."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageDiskGroupPolicy.RaidLevelEnum RaidLevel {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<StorageSpanGroup> SpanGroups {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to storageStoragePolicy resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<StorageStoragePolicyRelationship> StoragePolicies {
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
        /// <para type="description">"Selected disks in the disk group in JBOD state will be set to Unconfigured Good state before they are used in virtual drive creation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool UseJbods {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove StorageDiskGroupPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightStorageDiskGroupPolicy")]
    public class RemoveIntersightStorageDiskGroupPolicy:RemoveCmdletBase
	{
		public RemoveIntersightStorageDiskGroupPolicy()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "DeleteStorageDiskGroupPolicy";
		}
    }
}