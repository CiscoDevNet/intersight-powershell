using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ComputeStoragePhysicalDrive.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightComputeStoragePhysicalDrive")]
    public class InitializeIntersightComputeStoragePhysicalDrive:PSCmdlet
	{
		public InitializeIntersightComputeStoragePhysicalDrive()
		{
            ClassId = ComputeStoragePhysicalDrive.ClassIdEnum.ComputeStoragePhysicalDrive;
            ObjectType = ComputeStoragePhysicalDrive.ObjectTypeEnum.ComputeStoragePhysicalDrive;
            
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
        
        public ComputeStoragePhysicalDrive.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ComputeStoragePhysicalDrive.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Physical Drive ID of the storage on the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long SlotNumber {
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
    /// <para type="synopsis">This is the cmdlet to Initialize ComputePersistentMemoryModule.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightComputePersistentMemoryModule")]
    public class InitializeIntersightComputePersistentMemoryModule:PSCmdlet
	{
		public InitializeIntersightComputePersistentMemoryModule()
		{
            ClassId = ComputePersistentMemoryModule.ClassIdEnum.ComputePersistentMemoryModule;
            ObjectType = ComputePersistentMemoryModule.ObjectTypeEnum.ComputePersistentMemoryModule;
            
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
        
        public ComputePersistentMemoryModule.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ComputePersistentMemoryModule.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Socket ID of the Persistent Memory Module on the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SocketId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Socket Memory ID of the Persistent Memory Module on the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SocketMemoryId {
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
    public class InitializeIntersightComputeStorageControllerOperation:PSCmdlet
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Administrative actions that can be performed on the Storage Controller.\n* `None` - No action on the selected Storage Controller.\n* `Import` - Import Foreign config action on the selected Storage Controller.\n* `Clear` - Clear Foreign config action on the selected Storage Controller."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ComputeStorageControllerOperation.AdminActionEnum AdminAction {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ComputeStorageControllerOperation.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Storage Controller Id of the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ControllerId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ComputeStorageControllerOperation.ObjectTypeEnum ObjectType {
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
    /// <para type="synopsis">This is the cmdlet to Initialize ComputeIpAddress.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightComputeIpAddress")]
    public class InitializeIntersightComputeIpAddress:PSCmdlet
	{
		public InitializeIntersightComputeIpAddress()
		{
            ClassId = ComputeIpAddress.ClassIdEnum.ComputeIpAddress;
            ObjectType = ComputeIpAddress.ObjectTypeEnum.ComputeIpAddress;
            
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
        
        public ComputeIpAddress.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ComputeIpAddress.ObjectTypeEnum ObjectType {
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
    /// <para type="synopsis">This is the cmdlet to Initialize ComputeStorageVirtualDrive.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightComputeStorageVirtualDrive")]
    public class InitializeIntersightComputeStorageVirtualDrive:PSCmdlet
	{
		public InitializeIntersightComputeStorageVirtualDrive()
		{
            ClassId = ComputeStorageVirtualDrive.ClassIdEnum.ComputeStorageVirtualDrive;
            ObjectType = ComputeStorageVirtualDrive.ObjectTypeEnum.ComputeStorageVirtualDrive;
            
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
        
        public ComputeStorageVirtualDrive.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Virtual Drive ID of the storage on the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Id {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ComputeStorageVirtualDrive.ObjectTypeEnum ObjectType {
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
    /// <para type="synopsis">This is the cmdlet to Initialize ComputeAlarmSummary.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightComputeAlarmSummary")]
    public class InitializeIntersightComputeAlarmSummary:PSCmdlet
	{
		public InitializeIntersightComputeAlarmSummary()
		{
            ClassId = ComputeAlarmSummary.ClassIdEnum.ComputeAlarmSummary;
            ObjectType = ComputeAlarmSummary.ObjectTypeEnum.ComputeAlarmSummary;
            
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
        
        public ComputeAlarmSummary.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The count of alarms that have severity type Critical."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Critical {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ComputeAlarmSummary.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The count of alarms that have severity type Warning."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Warning {
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
    /// <para type="synopsis">This is the cmdlet to Initialize ComputeStorageVirtualDriveOperation.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightComputeStorageVirtualDriveOperation")]
    public class InitializeIntersightComputeStorageVirtualDriveOperation:PSCmdlet
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Administrative actions that can be performed on the Storage Virtual Drives.\n* `None` - No action on the selected Storage virtual Drives.\n* `Delete` - Delete action on the selected Storage Virtual Drives."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ComputeStorageVirtualDriveOperation.AdminActionEnum AdminAction {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ComputeStorageVirtualDriveOperation.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Storage Controller Id of the storage Virtual Drives of the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ControllerId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ComputeStorageVirtualDriveOperation.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Model.ComputeStorageVirtualDrive> VirtualDrives {
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
    /// <para type="synopsis">This is the cmdlet to Initialize ComputeStoragePhysicalDriveOperation.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightComputeStoragePhysicalDriveOperation")]
    public class InitializeIntersightComputeStoragePhysicalDriveOperation:PSCmdlet
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Administrative actions that can be performed on the Storage Physical Drives.\n* `None` - No action on the selected Storage Physical Drives.\n* `SetJbod` - Set Jbod action state on the selected Storage Physical Drives.\n* `SetUnconfiguredGood` - Set Unconfigured Good action state on the selected Storage Physical Drives."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ComputeStoragePhysicalDriveOperation.AdminActionEnum AdminAction {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ComputeStoragePhysicalDriveOperation.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Storage Controller Id of the storage Physical Drives of the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ControllerId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ComputeStoragePhysicalDriveOperation.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Model.ComputeStoragePhysicalDrive> PhysicalDrives {
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
    /// <para type="synopsis">This is the cmdlet to Initialize ComputeServerConfig.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightComputeServerConfig")]
    public class InitializeIntersightComputeServerConfig:PSCmdlet
	{
		public InitializeIntersightComputeServerConfig()
		{
            ClassId = ComputeServerConfig.ClassIdEnum.ComputeServerConfig;
            ObjectType = ComputeServerConfig.ObjectTypeEnum.ComputeServerConfig;
            
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
        /// <para type="description">"User defined asset tag of the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[ #$%\\(\\)\\*\\+,\\-\\./:;\\?@\\[\\]_\\{\\|\\}~a-zA-Z0-9]*$")]
        public string AssetTag {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ComputeServerConfig.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ComputeServerConfig.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"User defined description of the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[ !#$%&\\(\\)\\*\\+,\\-\\./:;\\?@\\[\\]_\\{\\|\\}~a-zA-Z0-9]*$")]
        public string UserLabel {
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
    /// <para type="synopsis">This is the cmdlet to Initialize ComputePersistentMemoryOperation.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightComputePersistentMemoryOperation")]
    public class InitializeIntersightComputePersistentMemoryOperation:PSCmdlet
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Administrative actions that can be performed on the Persistent Memory Modules.\n* `None` - No action on the selected Persistent Memory Modules.\n* `SecureErase` - Secure Erase action on the selected Persistent Memory Modules.\n* `Unlock` - Unlock action on the selected Persistent Memory Modules."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ComputePersistentMemoryOperation.AdminActionEnum AdminAction {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ComputePersistentMemoryOperation.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Model.ComputePersistentMemoryModule> Modules {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ComputePersistentMemoryOperation.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Secure passphrase of the Persistent Memory Modules of the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SecurePassphrase {
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
}