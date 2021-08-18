using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
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
            MethodName = "UpdateStorageEnclosureWithHttpInfo";
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
    /// <para type="synopsis">This is the cmdlet to Get StorageNetAppLunMap.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStorageNetAppLunMap", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStorageNetAppLunMap:GetCmdletBase
	{
		public GetIntersightStorageNetAppLunMap()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStorageNetAppLunMapListWithHttpInfo";
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
            MethodName = "GetStorageNetAppNodeListWithHttpInfo";
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
            MethodName = "GetStorageHitachiPoolListWithHttpInfo";
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
            MethodName = "PatchStorageSasExpanderWithHttpInfo";
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
    /// <para type="synopsis">This is the cmdlet to Set StorageNetAppCluster.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightStorageNetAppCluster")]
    public class SetIntersightStorageNetAppCluster:SetCmdletBase
	{
		public SetIntersightStorageNetAppCluster()
		{
			ApiInstance = new StorageApi(Config);
            ModelObject = new StorageNetAppCluster();
            MethodName = "PatchStorageNetAppClusterWithHttpInfo";
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
    /// <para type="synopsis">This is the cmdlet to Set StorageFlexFlashVirtualDrive.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightStorageFlexFlashVirtualDrive")]
    public class SetIntersightStorageFlexFlashVirtualDrive:SetCmdletBase
	{
		public SetIntersightStorageFlexFlashVirtualDrive()
		{
			ApiInstance = new StorageApi(Config);
            ModelObject = new StorageFlexFlashVirtualDrive();
            MethodName = "UpdateStorageFlexFlashVirtualDriveWithHttpInfo";
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
    /// <para type="synopsis">This is the cmdlet to Get StorageHitachiHost.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStorageHitachiHost", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStorageHitachiHost:GetCmdletBase
	{
		public GetIntersightStorageHitachiHost()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStorageHitachiHostListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get StorageDriveGroup.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStorageDriveGroup", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStorageDriveGroup:GetCmdletBase
	{
		public GetIntersightStorageDriveGroup()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStorageDriveGroupListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New StorageDriveGroup.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightStorageDriveGroup")]
    public class NewIntersightStorageDriveGroup:NewCmdletBase
	{
		public NewIntersightStorageDriveGroup()
		{
			ApiInstance = new StorageApi(Config);
            ModelObject = new StorageDriveGroup();
            MethodName = "CreateStorageDriveGroupWithHttpInfo";
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
        /// <para type="description">"This drive group is created using automatic drive selection."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageAutomaticDriveGroup AutomaticDriveGroup {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"This drive group is created by specifying the drive slots to be used."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageManualDriveGroup ManualDriveGroup {
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
        /// <para type="description">"The name of the drive group. The name can be between 1 and 15 alphanumeric characters. Spaces or any special characters other than - (hyphen), _ (underscore), : (colon), and . (period) are not allowed."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false)]
        [ValidatePattern("[-.:_a-zA-Z0-9]{1,15}")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The supported RAID level for the disk group.\n* `Raid0` - RAID 0 Stripe Raid Level.\n* `Raid1` - RAID 1 Mirror Raid Level.\n* `Raid5` - RAID 5 Mirror Raid Level.\n* `Raid6` - RAID 6 Mirror Raid Level.\n* `Raid10` - RAID 10 Mirror Raid Level.\n* `Raid50` - RAID 50 Mirror Raid Level.\n* `Raid60` - RAID 60 Mirror Raid Level."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageDriveGroup.RaidLevelEnum RaidLevel {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a storageStoragePolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageStoragePolicyRelationship StoragePolicy {
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<StorageVirtualDriveConfiguration> VirtualDrives {
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
            MethodName = "GetStorageSpanListWithHttpInfo";
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
            MethodName = "UpdateStorageHitachiArrayWithHttpInfo";
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
    /// <para type="synopsis">This is the cmdlet to Get StorageEnclosureDiskSlotEp.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStorageEnclosureDiskSlotEp", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStorageEnclosureDiskSlotEp:GetCmdletBase
	{
		public GetIntersightStorageEnclosureDiskSlotEp()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStorageEnclosureDiskSlotEpListWithHttpInfo";
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
            MethodName = "GetStoragePureReplicationScheduleListWithHttpInfo";
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
            MethodName = "GetStoragePureProtectionGroupListWithHttpInfo";
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
            MethodName = "PatchStoragePhysicalDiskExtensionWithHttpInfo";
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
    /// <para type="synopsis">This is the cmdlet to Get StorageItem.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStorageItem", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStorageItem:GetCmdletBase
	{
		public GetIntersightStorageItem()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStorageItemListWithHttpInfo";
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
            MethodName = "GetStorageHyperFlexVolumeListWithHttpInfo";
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
            MethodName = "GetStoragePureControllerListWithHttpInfo";
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
            MethodName = "GetStorageFlexFlashPhysicalDriveListWithHttpInfo";
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
            MethodName = "GetStorageNetAppVolumeListWithHttpInfo";
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
            MethodName = "GetStorageVirtualDriveContainerListWithHttpInfo";
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
            MethodName = "UpdateStorageEnclosureDiskWithHttpInfo";
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
    /// <para type="synopsis">This is the cmdlet to Get StorageNetAppFcInterface.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStorageNetAppFcInterface", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStorageNetAppFcInterface:GetCmdletBase
	{
		public GetIntersightStorageNetAppFcInterface()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStorageNetAppFcInterfaceListWithHttpInfo";
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
            MethodName = "GetStorageNetAppStorageVmListWithHttpInfo";
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
            MethodName = "GetStoragePureHostListWithHttpInfo";
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
            MethodName = "GetStoragePureSnapshotScheduleListWithHttpInfo";
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
            MethodName = "GetStorageFlexUtilControllerListWithHttpInfo";
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
            MethodName = "UpdateStorageFlexUtilPhysicalDriveWithHttpInfo";
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
    /// <para type="synopsis">This is the cmdlet to Get StorageNetAppBaseDisk.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStorageNetAppBaseDisk", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStorageNetAppBaseDisk:GetCmdletBase
	{
		public GetIntersightStorageNetAppBaseDisk()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStorageNetAppBaseDiskListWithHttpInfo";
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
            MethodName = "GetStorageControllerListWithHttpInfo";
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
            MethodName = "GetStorageNetAppFcPortListWithHttpInfo";
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
            MethodName = "UpdateStorageVirtualDriveContainerWithHttpInfo";
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
    /// <para type="synopsis">This is the cmdlet to Set StorageSpan.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightStorageSpan")]
    public class SetIntersightStorageSpan:SetCmdletBase
	{
		public SetIntersightStorageSpan()
		{
			ApiInstance = new StorageApi(Config);
            ModelObject = new StorageSpan();
            MethodName = "UpdateStorageSpanWithHttpInfo";
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
    /// <para type="synopsis">This is the cmdlet to Get StorageNetAppIpInterface.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStorageNetAppIpInterface", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStorageNetAppIpInterface:GetCmdletBase
	{
		public GetIntersightStorageNetAppIpInterface()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStorageNetAppIpInterfaceListWithHttpInfo";
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
            MethodName = "GetStorageStoragePolicyListWithHttpInfo";
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
            MethodName = "CreateStorageStoragePolicyWithHttpInfo";
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
        /// <para type="description">"An array of relationships to storageDriveGroup resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<StorageDriveGroupRelationship> DriveGroup {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A collection of disks that is to be used as hot spares, globally, for all the RAID groups. Allowed value is a number range separated by a comma or a hyphen."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^((\\d+\\-\\d+)|(\\d+))(,((\\d+\\-\\d+)|(\\d+)))*$")]
        public string GlobalHotSpares {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Virtual Drive configuration for M.2 RAID controller."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageM2VirtualDriveConfig M2VirtualDrive {
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
        /// <para type="description">"The list of disks where RAID0 virtual drives must be created on each individual drive."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageR0Drive Raid0Drive {
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
        /// <para type="description">"State to which disks, not used in this policy, are to be moved. NoChange will not change the drive state.\n* `NoChange` - Drive state will not be modified by Storage Policy.\n* `UnconfiguredGood` - Unconfigured good state -ready to be added in a RAID group.\n* `Jbod` - JBOD state where the disks start showing up to Host OS."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageStoragePolicy.UnusedDisksStateEnum UnusedDisksState {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Disks in JBOD State are used to create virtual drives."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool UseJbodForVdCreation {
            get;
            set;
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
            MethodName = "GetStorageFlexFlashControllerPropsListWithHttpInfo";
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
            MethodName = "GetStorageNetAppAggregateListWithHttpInfo";
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
            MethodName = "GetStorageSasExpanderListWithHttpInfo";
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
            MethodName = "GetStorageNetAppVolumeSnapshotListWithHttpInfo";
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
            MethodName = "GetStorageNetAppLunListWithHttpInfo";
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
            MethodName = "GetStorageFlexUtilVirtualDriveListWithHttpInfo";
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
            MethodName = "GetStorageVirtualDriveExtensionListWithHttpInfo";
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
            MethodName = "UpdateStoragePhysicalDiskUsageWithHttpInfo";
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
    /// <para type="synopsis">This is the cmdlet to Get StorageEnclosure.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStorageEnclosure", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStorageEnclosure:GetCmdletBase
	{
		public GetIntersightStorageEnclosure()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStorageEnclosureListWithHttpInfo";
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
            MethodName = "GetStoragePureArrayListWithHttpInfo";
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
            MethodName = "GetStorageVdMemberEpListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get StorageVirtualDriveIdentity.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStorageVirtualDriveIdentity", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStorageVirtualDriveIdentity:GetCmdletBase
	{
		public GetIntersightStorageVirtualDriveIdentity()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStorageVirtualDriveIdentityListWithHttpInfo";
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
            MethodName = "UpdateStorageVirtualDriveExtensionWithHttpInfo";
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
    /// <para type="synopsis">This is the cmdlet to Set StorageFlexFlashPhysicalDrive.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightStorageFlexFlashPhysicalDrive")]
    public class SetIntersightStorageFlexFlashPhysicalDrive:SetCmdletBase
	{
		public SetIntersightStorageFlexFlashPhysicalDrive()
		{
			ApiInstance = new StorageApi(Config);
            ModelObject = new StorageFlexFlashPhysicalDrive();
            MethodName = "UpdateStorageFlexFlashPhysicalDriveWithHttpInfo";
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
    /// <para type="synopsis">This is the cmdlet to Get StorageVirtualDrive.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStorageVirtualDrive", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStorageVirtualDrive:GetCmdletBase
	{
		public GetIntersightStorageVirtualDrive()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStorageVirtualDriveListWithHttpInfo";
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
            MethodName = "GetStorageHitachiDiskListWithHttpInfo";
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
            MethodName = "GetStoragePhysicalDiskUsageListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set StorageDriveGroup.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightStorageDriveGroup")]
    public class SetIntersightStorageDriveGroup:SetCmdletBase
	{
		public SetIntersightStorageDriveGroup()
		{
			ApiInstance = new StorageApi(Config);
            ModelObject = new StorageDriveGroup();
            MethodName = "PatchStorageDriveGroupWithHttpInfo";
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
        /// <para type="description">"This drive group is created using automatic drive selection."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageAutomaticDriveGroup AutomaticDriveGroup {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"This drive group is created by specifying the drive slots to be used."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageManualDriveGroup ManualDriveGroup {
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
        /// <para type="description">"The name of the drive group. The name can be between 1 and 15 alphanumeric characters. Spaces or any special characters other than - (hyphen), _ (underscore), : (colon), and . (period) are not allowed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("[-.:_a-zA-Z0-9]{1,15}")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The supported RAID level for the disk group.\n* `Raid0` - RAID 0 Stripe Raid Level.\n* `Raid1` - RAID 1 Mirror Raid Level.\n* `Raid5` - RAID 5 Mirror Raid Level.\n* `Raid6` - RAID 6 Mirror Raid Level.\n* `Raid10` - RAID 10 Mirror Raid Level.\n* `Raid50` - RAID 50 Mirror Raid Level.\n* `Raid60` - RAID 60 Mirror Raid Level."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageDriveGroup.RaidLevelEnum RaidLevel {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a storageStoragePolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageStoragePolicyRelationship StoragePolicy {
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<StorageVirtualDriveConfiguration> VirtualDrives {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove StorageDriveGroup.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightStorageDriveGroup")]
    public class RemoveIntersightStorageDriveGroup:RemoveCmdletBase
	{
		public RemoveIntersightStorageDriveGroup()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "DeleteStorageDriveGroupWithHttpInfo";
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
            MethodName = "GetStorageEnclosureDiskListWithHttpInfo";
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
            MethodName = "GetStorageHitachiControllerListWithHttpInfo";
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
            MethodName = "UpdateStoragePhysicalDiskWithHttpInfo";
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
    /// <para type="synopsis">This is the cmdlet to Get StoragePureVolumeSnapshot.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStoragePureVolumeSnapshot", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStoragePureVolumeSnapshot:GetCmdletBase
	{
		public GetIntersightStoragePureVolumeSnapshot()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStoragePureVolumeSnapshotListWithHttpInfo";
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
            MethodName = "GetStoragePureDiskListWithHttpInfo";
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
            MethodName = "GetStoragePhysicalDiskExtensionListWithHttpInfo";
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
            MethodName = "PatchStorageControllerWithHttpInfo";
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
    /// <para type="synopsis">This is the cmdlet to Get StorageFlexFlashVirtualDrive.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStorageFlexFlashVirtualDrive", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStorageFlexFlashVirtualDrive:GetCmdletBase
	{
		public GetIntersightStorageFlexFlashVirtualDrive()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStorageFlexFlashVirtualDriveListWithHttpInfo";
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
            MethodName = "GetStorageHitachiArrayListWithHttpInfo";
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
            MethodName = "GetStorageHitachiVolumeListWithHttpInfo";
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
            MethodName = "GetStorageNetAppEthernetPortListWithHttpInfo";
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
            MethodName = "GetStorageNetAppLicenseListWithHttpInfo";
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
            MethodName = "UpdateStorageVirtualDriveWithHttpInfo";
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
    /// <para type="synopsis">This is the cmdlet to Get StoragePureProtectionGroupSnapshot.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStoragePureProtectionGroupSnapshot", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStoragePureProtectionGroupSnapshot:GetCmdletBase
	{
		public GetIntersightStoragePureProtectionGroupSnapshot()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStoragePureProtectionGroupSnapshotListWithHttpInfo";
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
            MethodName = "UpdateStorageFlexUtilControllerWithHttpInfo";
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
    /// <para type="synopsis">This is the cmdlet to Get StoragePhysicalDisk.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStoragePhysicalDisk", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStoragePhysicalDisk:GetCmdletBase
	{
		public GetIntersightStoragePhysicalDisk()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStoragePhysicalDiskListWithHttpInfo";
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
            MethodName = "GetStoragePureHostGroupListWithHttpInfo";
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
            MethodName = "GetStorageSasPortListWithHttpInfo";
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
            MethodName = "UpdateStorageEnclosureDiskSlotEpWithHttpInfo";
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
    /// <para type="synopsis">This is the cmdlet to Set StorageSasPort.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightStorageSasPort")]
    public class SetIntersightStorageSasPort:SetCmdletBase
	{
		public SetIntersightStorageSasPort()
		{
			ApiInstance = new StorageApi(Config);
            ModelObject = new StorageSasPort();
            MethodName = "UpdateStorageSasPortWithHttpInfo";
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
    /// <para type="synopsis">This is the cmdlet to Get StorageNetAppCluster.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStorageNetAppCluster", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStorageNetAppCluster:GetCmdletBase
	{
		public GetIntersightStorageNetAppCluster()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStorageNetAppClusterListWithHttpInfo";
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
            MethodName = "UpdateStorageDiskGroupWithHttpInfo";
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
    /// <para type="synopsis">This is the cmdlet to Get StorageHitachiPort.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStorageHitachiPort", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStorageHitachiPort:GetCmdletBase
	{
		public GetIntersightStorageHitachiPort()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStorageHitachiPortListWithHttpInfo";
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
            MethodName = "UpdateStoragePureArrayWithHttpInfo";
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
    /// <para type="synopsis">This is the cmdlet to Get StorageFlexFlashController.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStorageFlexFlashController", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStorageFlexFlashController:GetCmdletBase
	{
		public GetIntersightStorageFlexFlashController()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStorageFlexFlashControllerListWithHttpInfo";
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
            MethodName = "UpdateStorageFlexUtilVirtualDriveWithHttpInfo";
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
    /// <para type="synopsis">This is the cmdlet to Set StorageFlexFlashController.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightStorageFlexFlashController")]
    public class SetIntersightStorageFlexFlashController:SetCmdletBase
	{
		public SetIntersightStorageFlexFlashController()
		{
			ApiInstance = new StorageApi(Config);
            ModelObject = new StorageFlexFlashController();
            MethodName = "UpdateStorageFlexFlashControllerWithHttpInfo";
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
    /// <para type="synopsis">This is the cmdlet to Get StorageHitachiHostLun.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStorageHitachiHostLun", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStorageHitachiHostLun:GetCmdletBase
	{
		public GetIntersightStorageHitachiHostLun()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStorageHitachiHostLunListWithHttpInfo";
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
            MethodName = "GetStorageNetAppExportPolicyListWithHttpInfo";
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
            MethodName = "GetStoragePureVolumeListWithHttpInfo";
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
            MethodName = "GetStorageHitachiParityGroupListWithHttpInfo";
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
            MethodName = "GetStoragePurePortListWithHttpInfo";
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
            MethodName = "PatchStorageStoragePolicyWithHttpInfo";
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
        /// <para type="description">"An array of relationships to storageDriveGroup resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<StorageDriveGroupRelationship> DriveGroup {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A collection of disks that is to be used as hot spares, globally, for all the RAID groups. Allowed value is a number range separated by a comma or a hyphen."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^((\\d+\\-\\d+)|(\\d+))(,((\\d+\\-\\d+)|(\\d+)))*$")]
        public string GlobalHotSpares {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Virtual Drive configuration for M.2 RAID controller."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageM2VirtualDriveConfig M2VirtualDrive {
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
        /// <para type="description">"The list of disks where RAID0 virtual drives must be created on each individual drive."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageR0Drive Raid0Drive {
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
        /// <para type="description">"State to which disks, not used in this policy, are to be moved. NoChange will not change the drive state.\n* `NoChange` - Drive state will not be modified by Storage Policy.\n* `UnconfiguredGood` - Unconfigured good state -ready to be added in a RAID group.\n* `Jbod` - JBOD state where the disks start showing up to Host OS."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageStoragePolicy.UnusedDisksStateEnum UnusedDisksState {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Disks in JBOD State are used to create virtual drives."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool UseJbodForVdCreation {
            get;
            set;
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
            MethodName = "DeleteStorageStoragePolicyWithHttpInfo";
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
            MethodName = "GetStorageDiskGroupListWithHttpInfo";
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
            MethodName = "GetStorageHyperFlexStorageContainerListWithHttpInfo";
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
            MethodName = "GetStoragePureHostLunListWithHttpInfo";
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
            MethodName = "GetStorageNetAppInitiatorGroupListWithHttpInfo";
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
            MethodName = "UpdateStorageFlexFlashControllerPropsWithHttpInfo";
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
    /// <para type="synopsis">This is the cmdlet to Get StorageFlexUtilPhysicalDrive.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightStorageFlexUtilPhysicalDrive", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightStorageFlexUtilPhysicalDrive:GetCmdletBase
	{
		public GetIntersightStorageFlexUtilPhysicalDrive()
		{
			ApiInstance = new StorageApi(Config);
            MethodName = "GetStorageFlexUtilPhysicalDriveListWithHttpInfo";
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
            MethodName = "GetStorageDiskSlotListWithHttpInfo";
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
            MethodName = "UpdateStorageVdMemberEpWithHttpInfo";
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
}