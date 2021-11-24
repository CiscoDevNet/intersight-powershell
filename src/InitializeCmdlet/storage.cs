using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize StorageSpanDrives.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightStorageSpanDrives")]
    public class InitializeIntersightStorageSpanDrives:PSCmdlet
	{
		public InitializeIntersightStorageSpanDrives()
		{
            ClassId = StorageSpanDrives.ClassIdEnum.StorageSpanDrives;
            ObjectType = StorageSpanDrives.ObjectTypeEnum.StorageSpanDrives;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageSpanDrives.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageSpanDrives.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Collection of local disks that are part of this span group. Allowed value is a comma or hyphen separated number range. The minimum number of disks needed in a span group varies based on RAID level. RAID0 requires at least one disk, RAID1 and RAID10 requires at least 2 and in multiples of 2, RAID5 RAID50 RAID6 and RAID60 require at least 3 disks in a span group."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^((\\d+\\-\\d+)|(\\d+))(,((\\d+\\-\\d+)|(\\d+)))*$")]
        public string Slots {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.StorageSpanDrives initObject = new Intersight.Model.StorageSpanDrives();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Slots"))
            {
                initObject.Slots = this.Slots;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize StorageHitachiArrayUtilization.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightStorageHitachiArrayUtilization")]
    public class InitializeIntersightStorageHitachiArrayUtilization:PSCmdlet
	{
		public InitializeIntersightStorageHitachiArrayUtilization()
		{
            ClassId = StorageHitachiArrayUtilization.ClassIdEnum.StorageHitachiArrayUtilization;
            ObjectType = StorageHitachiArrayUtilization.ObjectTypeEnum.StorageHitachiArrayUtilization;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageHitachiArrayUtilization.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageHitachiArrayUtilization.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.StorageHitachiArrayUtilization initObject = new Intersight.Model.StorageHitachiArrayUtilization();
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
    /// <para type="synopsis">This is the cmdlet to Initialize StorageNetAppHighAvailability.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightStorageNetAppHighAvailability")]
    public class InitializeIntersightStorageNetAppHighAvailability:PSCmdlet
	{
		public InitializeIntersightStorageNetAppHighAvailability()
		{
            ClassId = StorageNetAppHighAvailability.ClassIdEnum.StorageNetAppHighAvailability;
            ObjectType = StorageNetAppHighAvailability.ObjectTypeEnum.StorageNetAppHighAvailability;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageNetAppHighAvailability.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageNetAppHighAvailability.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.StorageNetAppHighAvailability initObject = new Intersight.Model.StorageNetAppHighAvailability();
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
    /// <para type="synopsis">This is the cmdlet to Initialize StoragePureReplicationBlackout.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightStoragePureReplicationBlackout")]
    public class InitializeIntersightStoragePureReplicationBlackout:PSCmdlet
	{
		public InitializeIntersightStoragePureReplicationBlackout()
		{
            ClassId = StoragePureReplicationBlackout.ClassIdEnum.StoragePureReplicationBlackout;
            ObjectType = StoragePureReplicationBlackout.ObjectTypeEnum.StoragePureReplicationBlackout;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StoragePureReplicationBlackout.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StoragePureReplicationBlackout.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.StoragePureReplicationBlackout initObject = new Intersight.Model.StoragePureReplicationBlackout();
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
    /// <para type="synopsis">This is the cmdlet to Initialize StorageAutomaticDriveGroup.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightStorageAutomaticDriveGroup")]
    public class InitializeIntersightStorageAutomaticDriveGroup:PSCmdlet
	{
		public InitializeIntersightStorageAutomaticDriveGroup()
		{
            ClassId = StorageAutomaticDriveGroup.ClassIdEnum.StorageAutomaticDriveGroup;
            DriveType = StorageAutomaticDriveGroup.DriveTypeEnum.Any;
            ObjectType = StorageAutomaticDriveGroup.ObjectTypeEnum.StorageAutomaticDriveGroup;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageAutomaticDriveGroup.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of drive that should be used for this RAID group.\n* `Any` - Any type of drive can be used for virtual drive creation.\n* `HDD` - Hard disk drives should be used for virtual drive creation.\n* `SSD` - Solid state drives should be used for virtual drive creation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageAutomaticDriveGroup.DriveTypeEnum DriveType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of drives within this span group. The minimum number of disks needed in a span group varies based on RAID level. RAID0 requires at least one disk. RAID1 and RAID10 requires at least 2 and in multiples of . RAID5 and RAID50 require at least 3 disks in a span group. RAID6 and RAID60 require atleast 4 disks in a span."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1, 100)]
        public long DrivesPerSpan {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Minimum size of the drive to be used for creating this RAID group."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long MinimumDriveSize {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of dedicated hot spare disks for this RAID group. Allowed value is a comma or hyphen separated number range."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^((\\d+\\-\\d+)|(\\d+))(,((\\d+\\-\\d+)|(\\d+)))*$")]
        public string NumDedicatedHotSpares {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of span groups to be created for this RAID group. Non-nested RAID levels have a single span."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long NumberOfSpans {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageAutomaticDriveGroup.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"This flag enables the drive group to use all the remaining drives on the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool UseRemainingDrives {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.StorageAutomaticDriveGroup initObject = new Intersight.Model.StorageAutomaticDriveGroup();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("DriveType"))
            {
                initObject.DriveType = this.DriveType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DrivesPerSpan"))
            {
                initObject.DrivesPerSpan = this.DrivesPerSpan;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MinimumDriveSize"))
            {
                initObject.MinimumDriveSize = this.MinimumDriveSize;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NumDedicatedHotSpares"))
            {
                initObject.NumDedicatedHotSpares = this.NumDedicatedHotSpares;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NumberOfSpans"))
            {
                initObject.NumberOfSpans = this.NumberOfSpans;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("UseRemainingDrives"))
            {
                initObject.UseRemainingDrives = this.UseRemainingDrives;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize StorageM2VirtualDriveConfig.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightStorageM2VirtualDriveConfig")]
    public class InitializeIntersightStorageM2VirtualDriveConfig:PSCmdlet
	{
		public InitializeIntersightStorageM2VirtualDriveConfig()
		{
            ClassId = StorageM2VirtualDriveConfig.ClassIdEnum.StorageM2VirtualDriveConfig;
            ControllerSlot = StorageM2VirtualDriveConfig.ControllerSlotEnum.MSTORRAID1;
            ObjectType = StorageM2VirtualDriveConfig.ObjectTypeEnum.StorageM2VirtualDriveConfig;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageM2VirtualDriveConfig.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Select the M.2 RAID controller slot on which the virtual drive is to be created. Select 'MSTOR-RAID-1' to create virtual drive on the M.2 RAID controller in the first slot or in the MSTOR-RAID slot, 'MSTOR-RAID-2' for second slot, 'MSTOR-RAID-1, MSTOR-RAID-2' for both slots or either slot.\n* `MSTOR-RAID-1` - Virtual drive  will be created on the M.2 RAID controller in the first slot.\n* `MSTOR-RAID-2` - Virtual drive  will be created on the M.2 RAID controller in the second slot, if available.\n* `MSTOR-RAID-1,MSTOR-RAID-2` - Virtual drive  will be created on the M.2 RAID controller in both the slots, if available."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageM2VirtualDriveConfig.ControllerSlotEnum ControllerSlot {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"If enabled, this will create a virtual drive on the M.2 RAID controller."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Enable {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageM2VirtualDriveConfig.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.StorageM2VirtualDriveConfig initObject = new Intersight.Model.StorageM2VirtualDriveConfig();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ControllerSlot"))
            {
                initObject.ControllerSlot = this.ControllerSlot;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Enable"))
            {
                initObject.Enable = this.Enable;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize StorageHitachiInitiator.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightStorageHitachiInitiator")]
    public class InitializeIntersightStorageHitachiInitiator:PSCmdlet
	{
		public InitializeIntersightStorageHitachiInitiator()
		{
            ClassId = StorageHitachiInitiator.ClassIdEnum.StorageHitachiInitiator;
            ObjectType = StorageHitachiInitiator.ObjectTypeEnum.StorageHitachiInitiator;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageHitachiInitiator.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageHitachiInitiator.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.StorageHitachiInitiator initObject = new Intersight.Model.StorageHitachiInitiator();
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
    /// <para type="synopsis">This is the cmdlet to Initialize StorageNetAppStorageUtilization.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightStorageNetAppStorageUtilization")]
    public class InitializeIntersightStorageNetAppStorageUtilization:PSCmdlet
	{
		public InitializeIntersightStorageNetAppStorageUtilization()
		{
            ClassId = StorageNetAppStorageUtilization.ClassIdEnum.StorageNetAppStorageUtilization;
            ObjectType = StorageNetAppStorageUtilization.ObjectTypeEnum.StorageNetAppStorageUtilization;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageNetAppStorageUtilization.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageNetAppStorageUtilization.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.StorageNetAppStorageUtilization initObject = new Intersight.Model.StorageNetAppStorageUtilization();
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
    /// <para type="synopsis">This is the cmdlet to Initialize StorageNetAppEthernetPortLag.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightStorageNetAppEthernetPortLag")]
    public class InitializeIntersightStorageNetAppEthernetPortLag:PSCmdlet
	{
		public InitializeIntersightStorageNetAppEthernetPortLag()
		{
            ClassId = StorageNetAppEthernetPortLag.ClassIdEnum.StorageNetAppEthernetPortLag;
            DistributionPolicy = StorageNetAppEthernetPortLag.DistributionPolicyEnum.None;
            Mode = StorageNetAppEthernetPortLag.ModeEnum.None;
            ObjectType = StorageNetAppEthernetPortLag.ObjectTypeEnum.StorageNetAppEthernetPortLag;
            
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Model.StorageNetAppPort> ActivePorts {
            get;
            set;
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageNetAppEthernetPortLag.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Policy for mapping flows to ports for outbound packets through a LAG (ifgrp).\n* `none` - Default unknown distribution policy type.\n* `port` - Network traffic is distributed based on the transport layer (TCP/UDP) ports.\n* `ip` - Network traffic is distributed based on IP addresses.\n* `mac` - Network traffic is distributed based on MAC addresses.\n* `sequential` - Network traffic is distributed in round-robin fashion from the list of configured, available ports."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageNetAppEthernetPortLag.DistributionPolicyEnum DistributionPolicy {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Model.StorageNetAppPort> MemberPorts {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Determines how the ports interact with the switch.\n* `none` - Default unknown lag mode type.\n* `multimode_lacp` - Bundle multiple member ports of the interface group using Link Aggregation Control Protocol.\n* `multimode` - Bundle multiple member ports of the interface group to act as a single trunked port.\n* `singlemode` - Provide port redundancy using member ports of the interface group for failover."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageNetAppEthernetPortLag.ModeEnum Mode {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageNetAppEthernetPortLag.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.StorageNetAppEthernetPortLag initObject = new Intersight.Model.StorageNetAppEthernetPortLag();
            if (this.MyInvocation.BoundParameters.ContainsKey("ActivePorts"))
            {
                initObject.ActivePorts = this.ActivePorts;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("DistributionPolicy"))
            {
                initObject.DistributionPolicy = this.DistributionPolicy;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MemberPorts"))
            {
                initObject.MemberPorts = this.MemberPorts;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Mode"))
            {
                initObject.Mode = this.Mode;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize StorageInitiator.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightStorageInitiator")]
    public class InitializeIntersightStorageInitiator:PSCmdlet
	{
		public InitializeIntersightStorageInitiator()
		{
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageInitiator.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageInitiator.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.StorageInitiator initObject = new Intersight.Model.StorageInitiator();
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
    /// <para type="synopsis">This is the cmdlet to Initialize StorageStorageContainerUtilization.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightStorageStorageContainerUtilization")]
    public class InitializeIntersightStorageStorageContainerUtilization:PSCmdlet
	{
		public InitializeIntersightStorageStorageContainerUtilization()
		{
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageStorageContainerUtilization.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageStorageContainerUtilization.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.StorageStorageContainerUtilization initObject = new Intersight.Model.StorageStorageContainerUtilization();
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
    /// <para type="synopsis">This is the cmdlet to Initialize StorageBaseCapacity.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightStorageBaseCapacity")]
    public class InitializeIntersightStorageBaseCapacity:PSCmdlet
	{
		public InitializeIntersightStorageBaseCapacity()
		{
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageBaseCapacity.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageBaseCapacity.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.StorageBaseCapacity initObject = new Intersight.Model.StorageBaseCapacity();
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
    /// <para type="synopsis">This is the cmdlet to Initialize StorageRemoteKeySetting.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightStorageRemoteKeySetting")]
    public class InitializeIntersightStorageRemoteKeySetting:PSCmdlet
	{
		public InitializeIntersightStorageRemoteKeySetting()
		{
            ClassId = StorageRemoteKeySetting.ClassIdEnum.StorageRemoteKeySetting;
            ObjectType = StorageRemoteKeySetting.ObjectTypeEnum.StorageRemoteKeySetting;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageRemoteKeySetting.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageRemoteKeySetting.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The password for the KMIP server login."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("[!\"#%&'\\(\\)\\*\\+,\\-\\./:;<>@\\[\\\\\\]\\^_`\\{\\|\\}~a-zA-Z0-9]{0,80}")]
        public string Password {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The port to which the KMIP client should connect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1024, 65535)]
        public long Port {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The IP address of the primary KMIP server. It could be an IPv4 address, an IPv6 address, or a hostname. Hostnames are valid only when Inband is configured for the CIMC address."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string PrimaryServer {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The IP address of the secondary KMIP server. It could be an IPv4 address, an IPv6 address, or a hostname. Hostnames are valid only when Inband is configured for the CIMC address."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SecondaryServer {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The certificate/ public key of the KMIP server. It is required for initiating secure communication with the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ServerCertificate {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The user name for the KMIP server login."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|[a-zA-Z][a-zA-Z0-9_.-]{0,31}")]
        public string Username {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.StorageRemoteKeySetting initObject = new Intersight.Model.StorageRemoteKeySetting();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Password"))
            {
                initObject.Password = this.Password;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Port"))
            {
                initObject.Port = this.Port;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PrimaryServer"))
            {
                initObject.PrimaryServer = this.PrimaryServer;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SecondaryServer"))
            {
                initObject.SecondaryServer = this.SecondaryServer;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ServerCertificate"))
            {
                initObject.ServerCertificate = this.ServerCertificate;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Username"))
            {
                initObject.Username = this.Username;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize StoragePureVolumeUtilization.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightStoragePureVolumeUtilization")]
    public class InitializeIntersightStoragePureVolumeUtilization:PSCmdlet
	{
		public InitializeIntersightStoragePureVolumeUtilization()
		{
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StoragePureVolumeUtilization.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StoragePureVolumeUtilization.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.StoragePureVolumeUtilization initObject = new Intersight.Model.StoragePureVolumeUtilization();
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
    /// <para type="synopsis">This is the cmdlet to Initialize StorageLocalKeySetting.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightStorageLocalKeySetting")]
    public class InitializeIntersightStorageLocalKeySetting:PSCmdlet
	{
		public InitializeIntersightStorageLocalKeySetting()
		{
            ClassId = StorageLocalKeySetting.ClassIdEnum.StorageLocalKeySetting;
            ObjectType = StorageLocalKeySetting.ObjectTypeEnum.StorageLocalKeySetting;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageLocalKeySetting.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Existing key which is already configured on the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9=!&#$%+^@_*-]+$")]
        public string ExistingKey {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"New key to be configured on the controller."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9=!&#$%+^@_*-]+$")]
        public string NewKey {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageLocalKeySetting.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.StorageLocalKeySetting initObject = new Intersight.Model.StorageLocalKeySetting();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ExistingKey"))
            {
                initObject.ExistingKey = this.ExistingKey;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NewKey"))
            {
                initObject.NewKey = this.NewKey;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize StorageHitachiCapacity.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightStorageHitachiCapacity")]
    public class InitializeIntersightStorageHitachiCapacity:PSCmdlet
	{
		public InitializeIntersightStorageHitachiCapacity()
		{
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageHitachiCapacity.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageHitachiCapacity.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.StorageHitachiCapacity initObject = new Intersight.Model.StorageHitachiCapacity();
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
    /// <para type="synopsis">This is the cmdlet to Initialize StorageNetAppEthernetPortVlan.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightStorageNetAppEthernetPortVlan")]
    public class InitializeIntersightStorageNetAppEthernetPortVlan:PSCmdlet
	{
		public InitializeIntersightStorageNetAppEthernetPortVlan()
		{
            ClassId = StorageNetAppEthernetPortVlan.ClassIdEnum.StorageNetAppEthernetPortVlan;
            ObjectType = StorageNetAppEthernetPortVlan.ObjectTypeEnum.StorageNetAppEthernetPortVlan;
            
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
        /// <para type="description">"Port UUID along with readable names."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.StorageNetAppPort BasePort {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageNetAppEthernetPortVlan.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageNetAppEthernetPortVlan.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The ID tag of the VLAN for this port."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Tag {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.StorageNetAppEthernetPortVlan initObject = new Intersight.Model.StorageNetAppEthernetPortVlan();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BasePort"))
            {
                initObject.BasePort = this.BasePort;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Tag"))
            {
                initObject.Tag = this.Tag;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize StorageKeySetting.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightStorageKeySetting")]
    public class InitializeIntersightStorageKeySetting:PSCmdlet
	{
		public InitializeIntersightStorageKeySetting()
		{
            ClassId = StorageKeySetting.ClassIdEnum.StorageKeySetting;
            KeyType = StorageKeySetting.KeyTypeEnum.None;
            ObjectType = StorageKeySetting.ObjectTypeEnum.StorageKeySetting;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageKeySetting.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Method to be used for fetching the encryption key.\n* `None` - Drive encryption not configured.\n* `Manual` - Drive encryption using manual key.\n* `Kmip` - Remote encryption using KMIP."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageKeySetting.KeyTypeEnum KeyType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Manual key configuration."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.StorageLocalKeySetting ManualKey {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageKeySetting.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Remote key encryption using KMIP configuraiton."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.StorageRemoteKeySetting RemoteKey {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.StorageKeySetting initObject = new Intersight.Model.StorageKeySetting();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("KeyType"))
            {
                initObject.KeyType = this.KeyType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ManualKey"))
            {
                initObject.ManualKey = this.ManualKey;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("RemoteKey"))
            {
                initObject.RemoteKey = this.RemoteKey;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize StorageNetAppPort.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightStorageNetAppPort")]
    public class InitializeIntersightStorageNetAppPort:PSCmdlet
	{
		public InitializeIntersightStorageNetAppPort()
		{
            ClassId = StorageNetAppPort.ClassIdEnum.StorageNetAppPort;
            ObjectType = StorageNetAppPort.ObjectTypeEnum.StorageNetAppPort;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageNetAppPort.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name associated with this port."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the node associated with this port."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string NodeName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageNetAppPort.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Unique identifier of the port."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Uuid {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.StorageNetAppPort initObject = new Intersight.Model.StorageNetAppPort();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NodeName"))
            {
                initObject.NodeName = this.NodeName;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Uuid"))
            {
                initObject.Uuid = this.Uuid;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize StorageNetAppStorageClusterEfficiency.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightStorageNetAppStorageClusterEfficiency")]
    public class InitializeIntersightStorageNetAppStorageClusterEfficiency:PSCmdlet
	{
		public InitializeIntersightStorageNetAppStorageClusterEfficiency()
		{
            ClassId = StorageNetAppStorageClusterEfficiency.ClassIdEnum.StorageNetAppStorageClusterEfficiency;
            ObjectType = StorageNetAppStorageClusterEfficiency.ObjectTypeEnum.StorageNetAppStorageClusterEfficiency;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageNetAppStorageClusterEfficiency.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageNetAppStorageClusterEfficiency.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.StorageNetAppStorageClusterEfficiency initObject = new Intersight.Model.StorageNetAppStorageClusterEfficiency();
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
    /// <para type="synopsis">This is the cmdlet to Initialize StorageR0Drive.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightStorageR0Drive")]
    public class InitializeIntersightStorageR0Drive:PSCmdlet
	{
		public InitializeIntersightStorageR0Drive()
		{
            ClassId = StorageR0Drive.ClassIdEnum.StorageR0Drive;
            ObjectType = StorageR0Drive.ObjectTypeEnum.StorageR0Drive;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageR0Drive.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The set of drive slots where RAID0 virtual drives must be created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^((\\d+\\-\\d+)|(\\d+))(,((\\d+\\-\\d+)|(\\d+)))*$")]
        public string DriveSlots {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"If enabled, this will create a RAID0 virtual drive per disk and encompassing the whole disk."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Enable {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageR0Drive.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"This defines the characteristics of a specific virtual drive."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.StorageVirtualDrivePolicy VirtualDrivePolicy {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.StorageR0Drive initObject = new Intersight.Model.StorageR0Drive();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("DriveSlots"))
            {
                initObject.DriveSlots = this.DriveSlots;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Enable"))
            {
                initObject.Enable = this.Enable;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("VirtualDrivePolicy"))
            {
                initObject.VirtualDrivePolicy = this.VirtualDrivePolicy;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize StorageNetAppExportPolicyRule.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightStorageNetAppExportPolicyRule")]
    public class InitializeIntersightStorageNetAppExportPolicyRule:PSCmdlet
	{
		public InitializeIntersightStorageNetAppExportPolicyRule()
		{
            ClassId = StorageNetAppExportPolicyRule.ClassIdEnum.StorageNetAppExportPolicyRule;
            ObjectType = StorageNetAppExportPolicyRule.ObjectTypeEnum.StorageNetAppExportPolicyRule;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageNetAppExportPolicyRule.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> ClientMatch {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Position of export rule in the list of rules."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Index {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageNetAppExportPolicyRule.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> RoRule {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> RwRule {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> SuperUser {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Export Policy rule that are mapped to this User ID."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string User {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.StorageNetAppExportPolicyRule initObject = new Intersight.Model.StorageNetAppExportPolicyRule();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ClientMatch"))
            {
                initObject.ClientMatch = this.ClientMatch;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Index"))
            {
                initObject.Index = this.Index;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("RoRule"))
            {
                initObject.RoRule = this.RoRule;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RwRule"))
            {
                initObject.RwRule = this.RwRule;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SuperUser"))
            {
                initObject.SuperUser = this.SuperUser;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("User"))
            {
                initObject.User = this.User;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize StorageBaseInitiator.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightStorageBaseInitiator")]
    public class InitializeIntersightStorageBaseInitiator:PSCmdlet
	{
		public InitializeIntersightStorageBaseInitiator()
		{
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageBaseInitiator.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageBaseInitiator.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.StorageBaseInitiator initObject = new Intersight.Model.StorageBaseInitiator();
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
    /// <para type="synopsis">This is the cmdlet to Initialize StoragePureHostUtilization.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightStoragePureHostUtilization")]
    public class InitializeIntersightStoragePureHostUtilization:PSCmdlet
	{
		public InitializeIntersightStoragePureHostUtilization()
		{
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StoragePureHostUtilization.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StoragePureHostUtilization.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.StoragePureHostUtilization initObject = new Intersight.Model.StoragePureHostUtilization();
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
    /// <para type="synopsis">This is the cmdlet to Initialize StorageStorageContainerHostMountStatus.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightStorageStorageContainerHostMountStatus")]
    public class InitializeIntersightStorageStorageContainerHostMountStatus:PSCmdlet
	{
		public InitializeIntersightStorageStorageContainerHostMountStatus()
		{
            ClassId = StorageStorageContainerHostMountStatus.ClassIdEnum.StorageStorageContainerHostMountStatus;
            ObjectType = StorageStorageContainerHostMountStatus.ObjectTypeEnum.StorageStorageContainerHostMountStatus;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageStorageContainerHostMountStatus.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageStorageContainerHostMountStatus.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.StorageStorageContainerHostMountStatus initObject = new Intersight.Model.StorageStorageContainerHostMountStatus();
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
    /// <para type="synopsis">This is the cmdlet to Initialize StoragePureDiskUtilization.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightStoragePureDiskUtilization")]
    public class InitializeIntersightStoragePureDiskUtilization:PSCmdlet
	{
		public InitializeIntersightStoragePureDiskUtilization()
		{
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StoragePureDiskUtilization.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StoragePureDiskUtilization.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.StoragePureDiskUtilization initObject = new Intersight.Model.StoragePureDiskUtilization();
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
    /// <para type="synopsis">This is the cmdlet to Initialize StorageManualDriveGroup.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightStorageManualDriveGroup")]
    public class InitializeIntersightStorageManualDriveGroup:PSCmdlet
	{
		public InitializeIntersightStorageManualDriveGroup()
		{
            ClassId = StorageManualDriveGroup.ClassIdEnum.StorageManualDriveGroup;
            ObjectType = StorageManualDriveGroup.ObjectTypeEnum.StorageManualDriveGroup;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageManualDriveGroup.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A collection of drives to be used as hot spares for this Drive Group."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^((\\d+\\-\\d+)|(\\d+))(,((\\d+\\-\\d+)|(\\d+)))*$")]
        public string DedicatedHotSpares {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageManualDriveGroup.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Model.StorageSpanDrives> SpanGroups {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.StorageManualDriveGroup initObject = new Intersight.Model.StorageManualDriveGroup();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("DedicatedHotSpares"))
            {
                initObject.DedicatedHotSpares = this.DedicatedHotSpares;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("SpanGroups"))
            {
                initObject.SpanGroups = this.SpanGroups;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize StorageVolumeUtilization.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightStorageVolumeUtilization")]
    public class InitializeIntersightStorageVolumeUtilization:PSCmdlet
	{
		public InitializeIntersightStorageVolumeUtilization()
		{
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageVolumeUtilization.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageVolumeUtilization.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.StorageVolumeUtilization initObject = new Intersight.Model.StorageVolumeUtilization();
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
    /// <para type="synopsis">This is the cmdlet to Initialize StorageVirtualDriveConfiguration.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightStorageVirtualDriveConfiguration")]
    public class InitializeIntersightStorageVirtualDriveConfiguration:PSCmdlet
	{
		public InitializeIntersightStorageVirtualDriveConfiguration()
		{
            ClassId = StorageVirtualDriveConfiguration.ClassIdEnum.StorageVirtualDriveConfiguration;
            ObjectType = StorageVirtualDriveConfiguration.ObjectTypeEnum.StorageVirtualDriveConfiguration;
            
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
        /// <para type="description">"This flag enables this virtual drive to be used as a boot drive."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool BootDrive {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageVirtualDriveConfiguration.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"This flag enables the virtual drive to use all the space available in the disk group. When this flag is enabled, the size property is ignored."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool ExpandToAvailable {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the virtual drive. The name can be between 1 and 15 alphanumeric characters. Spaces or any special characters other than - (hyphen), _ (underscore), : (colon), and . (period) are not allowed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9\\-\\._:]*$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageVirtualDriveConfiguration.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Virtual drive size in MebiBytes. Size is mandatory field except when the Expand to Available option is enabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Size {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"This defines the characteristics of a specific virtual drive."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.StorageVirtualDrivePolicy VirtualDrivePolicy {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.StorageVirtualDriveConfiguration initObject = new Intersight.Model.StorageVirtualDriveConfiguration();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BootDrive"))
            {
                initObject.BootDrive = this.BootDrive;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ExpandToAvailable"))
            {
                initObject.ExpandToAvailable = this.ExpandToAvailable;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Size"))
            {
                initObject.Size = this.Size;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VirtualDrivePolicy"))
            {
                initObject.VirtualDrivePolicy = this.VirtualDrivePolicy;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize StoragePureArrayUtilization.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightStoragePureArrayUtilization")]
    public class InitializeIntersightStoragePureArrayUtilization:PSCmdlet
	{
		public InitializeIntersightStoragePureArrayUtilization()
		{
            ClassId = StoragePureArrayUtilization.ClassIdEnum.StoragePureArrayUtilization;
            ObjectType = StoragePureArrayUtilization.ObjectTypeEnum.StoragePureArrayUtilization;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StoragePureArrayUtilization.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StoragePureArrayUtilization.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.StoragePureArrayUtilization initObject = new Intersight.Model.StoragePureArrayUtilization();
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
    /// <para type="synopsis">This is the cmdlet to Initialize StorageVirtualDrivePolicy.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightStorageVirtualDrivePolicy")]
    public class InitializeIntersightStorageVirtualDrivePolicy:PSCmdlet
	{
		public InitializeIntersightStorageVirtualDrivePolicy()
		{
            AccessPolicy = StorageVirtualDrivePolicy.AccessPolicyEnum.Default;
            ClassId = StorageVirtualDrivePolicy.ClassIdEnum.StorageVirtualDrivePolicy;
            DriveCache = StorageVirtualDrivePolicy.DriveCacheEnum.Default;
            ObjectType = StorageVirtualDrivePolicy.ObjectTypeEnum.StorageVirtualDrivePolicy;
            ReadPolicy = StorageVirtualDrivePolicy.ReadPolicyEnum.Default;
            StripSize = StorageVirtualDrivePolicy.StripSizeEnum.NUMBER_64;
            WritePolicy = StorageVirtualDrivePolicy.WritePolicyEnum.Default;
            
		}
        // <summary>
        /// <para type="description">"Access policy that host has on this virtual drive.\n* `Default` - Use platform default access mode.\n* `ReadWrite` - Enables host to perform read-write on the VD.\n* `ReadOnly` - Host can only read from the VD.\n* `Blocked` - Host can neither read nor write to the VD."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageVirtualDrivePolicy.AccessPolicyEnum AccessPolicy {
            get;
            set;
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageVirtualDrivePolicy.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Disk cache policy for the virtual drive.\n* `Default` - Use platform default drive cache mode.\n* `NoChange` - Drive cache policy is unchanged.\n* `Enable` - Enables IO caching on the drive.\n* `Disable` - Disables IO caching on the drive."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageVirtualDrivePolicy.DriveCacheEnum DriveCache {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageVirtualDrivePolicy.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Read ahead mode to be used to read data from this virtual drive.\n* `Default` - Use platform default read ahead mode.\n* `ReadAhead` - Use read ahead mode for the policy.\n* `NoReadAhead` - Do not use read ahead mode for the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageVirtualDrivePolicy.ReadPolicyEnum ReadPolicy {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Desired strip size - Allowed values are 64KiB, 128KiB, 256KiB, 512KiB, 1024KiB.\n* `64` - Number of bytes in a strip is 64 Kibibytes.\n* `128` - Number of bytes in a strip is 128 Kibibytes.\n* `256` - Number of bytes in a strip is 256 Kibibytes.\n* `512` - Number of bytes in a strip is 512 Kibibytes.\n* `1024` - Number of bytes in a strip is 1024 Kibibytes or 1 Mebibyte."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageVirtualDrivePolicy.StripSizeEnum StripSize {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Write mode to be used to write data to this virtual drive.\n* `Default` - Use platform default write mode.\n* `WriteThrough` - Data is written through the cache and to the physical drives. Performance is improved, because subsequent reads of that data can be satisfied from the cache.\n* `WriteBackGoodBbu` - Data is stored in the cache, and is only written to the physical drives when space in the cache is needed. Virtual drives requesting this policy fall back to Write Through caching when the battery backup unit (BBU) cannot guarantee the safety of the cache in the event of a power failure.\n* `AlwaysWriteBack` - With this policy, write caching remains Write Back even if the battery backup unit is defective or discharged."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageVirtualDrivePolicy.WritePolicyEnum WritePolicy {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.StorageVirtualDrivePolicy initObject = new Intersight.Model.StorageVirtualDrivePolicy();
            if (this.MyInvocation.BoundParameters.ContainsKey("AccessPolicy"))
            {
                initObject.AccessPolicy = this.AccessPolicy;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("DriveCache"))
            {
                initObject.DriveCache = this.DriveCache;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("ReadPolicy"))
            {
                initObject.ReadPolicy = this.ReadPolicy;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("StripSize"))
            {
                initObject.StripSize = this.StripSize;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("WritePolicy"))
            {
                initObject.WritePolicy = this.WritePolicy;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize StorageNetAppPerformanceMetricsAverage.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightStorageNetAppPerformanceMetricsAverage")]
    public class InitializeIntersightStorageNetAppPerformanceMetricsAverage:PSCmdlet
	{
		public InitializeIntersightStorageNetAppPerformanceMetricsAverage()
		{
            ClassId = StorageNetAppPerformanceMetricsAverage.ClassIdEnum.StorageNetAppPerformanceMetricsAverage;
            ObjectType = StorageNetAppPerformanceMetricsAverage.ObjectTypeEnum.StorageNetAppPerformanceMetricsAverage;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageNetAppPerformanceMetricsAverage.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageNetAppPerformanceMetricsAverage.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.StorageNetAppPerformanceMetricsAverage initObject = new Intersight.Model.StorageNetAppPerformanceMetricsAverage();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
}