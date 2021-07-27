using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
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
    /// <para type="synopsis">This is the cmdlet to Initialize StorageSpanGroup.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightStorageSpanGroup")]
    public class InitializeIntersightStorageSpanGroup:PSCmdlet
	{
		public InitializeIntersightStorageSpanGroup()
		{
            ClassId = StorageSpanGroup.ClassIdEnum.StorageSpanGroup;
            ObjectType = StorageSpanGroup.ObjectTypeEnum.StorageSpanGroup;
            
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
        
        public StorageSpanGroup.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Model.StorageLocalDisk> Disks {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageSpanGroup.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.StorageSpanGroup initObject = new Intersight.Model.StorageSpanGroup();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Disks"))
            {
                initObject.Disks = this.Disks;
            }
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
    /// <para type="synopsis">This is the cmdlet to Initialize StorageLocalDisk.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightStorageLocalDisk")]
    public class InitializeIntersightStorageLocalDisk:PSCmdlet
	{
		public InitializeIntersightStorageLocalDisk()
		{
            ClassId = StorageLocalDisk.ClassIdEnum.StorageLocalDisk;
            ObjectType = StorageLocalDisk.ObjectTypeEnum.StorageLocalDisk;
            
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
        
        public StorageLocalDisk.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageLocalDisk.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The slot number of the disk to be referenced. As this is a policy, this slot number may or may not be valid depending on the number of disks in the associated server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1, 254)]
        public long SlotNumber {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.StorageLocalDisk initObject = new Intersight.Model.StorageLocalDisk();
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
    /// <para type="synopsis">This is the cmdlet to Initialize StorageVirtualDriveConfig.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightStorageVirtualDriveConfig")]
    public class InitializeIntersightStorageVirtualDriveConfig:PSCmdlet
	{
		public InitializeIntersightStorageVirtualDriveConfig()
		{
            AccessPolicy = StorageVirtualDriveConfig.AccessPolicyEnum.Default;
            ClassId = StorageVirtualDriveConfig.ClassIdEnum.StorageVirtualDriveConfig;
            DriveCache = StorageVirtualDriveConfig.DriveCacheEnum.Default;
            IoPolicy = StorageVirtualDriveConfig.IoPolicyEnum.Default;
            ObjectType = StorageVirtualDriveConfig.ObjectTypeEnum.StorageVirtualDriveConfig;
            ReadPolicy = StorageVirtualDriveConfig.ReadPolicyEnum.Default;
            StripSize = StorageVirtualDriveConfig.StripSizeEnum.Default;
            WritePolicy = StorageVirtualDriveConfig.WritePolicyEnum.Default;
            
		}
        // <summary>
        /// <para type="description">"Access policy that host has on this virtual drive.\n* `Default` - Use platform default access mode.\n* `ReadWrite` - Enables host to perform read-write on the VD.\n* `ReadOnly` - Host can only read from the VD.\n* `Blocked` - Host can neither read nor write to the VD."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageVirtualDriveConfig.AccessPolicyEnum AccessPolicy {
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
        /// <para type="description">"The flag enables the use of this virtual drive as a boot drive."</para>
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
        
        public StorageVirtualDriveConfig.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Disk group policy that has the disk group in which this virtual drive needs to be created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string DiskGroupPolicy {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Drive Cache property expect disk cache policy.\n* `Default` - Use platform default drive cache mode.\n* `NoChange` - Drive cache policy is unchanged.\n* `Enable` - Enables IO caching on the drive.\n* `Disable` - Disables IO caching on the drive."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageVirtualDriveConfig.DriveCacheEnum DriveCache {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The flag enables this virtual drive to use all the available space in the disk group. When this flag is configured, the size property is ignored."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool ExpandToAvailable {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Desired IO mode - direct IO or cached IO.\n* `Default` - Use platform default IO mode.\n* `Direct` - Use direct IO for writing directly into the disk.\n* `Cached` - Use cached IO for writing into cache and then to disk."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageVirtualDriveConfig.IoPolicyEnum IoPolicy {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the virtual drive. The name can be between 1 and 15 alphanumeric characters. Spaces or any special characters other than - (hyphen), _ (underscore), : (colon), and . (period) are not allowed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("[-.:_a-zA-Z0-9]{1,15}")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageVirtualDriveConfig.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Read ahead mode to be used to read data from this virtual drive.\n* `Default` - Use platform default read ahead mode.\n* `ReadAhead` - Use read ahead mode for the policy.\n* `NoReadAhead` - Do not use read ahead mode for the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageVirtualDriveConfig.ReadPolicyEnum ReadPolicy {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Virtual drive size in MB. Size is mandatory field unless the 'Expand to Available' option is enabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Size {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The strip size is the portion of a stripe that resides on a single drive in the drive group. The stripe consists of the data segments that the RAID controller writes across multiple drives, not including parity drives.\n* `Default` - Use platform default strip size for a virtual drive.\n* `32k` - Enables a strip size of 32k for a virtual drive.\n* `64k` - Enables a strip size of 64k for a virtual drive.\n* `128k` - Enables a strip size of 128k for a virtual drive.\n* `256k` - Enables a strip size of 256k for a virtual drive.\n* `512k` - Enables a strip size of 512k for a virtual drive.\n* `1024k` - Enables a strip size of 1024k for a virtual drive."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageVirtualDriveConfig.StripSizeEnum StripSize {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Write mode to be used to write data to this virtual drive.\n* `Default` - Use platform default write mode.\n* `WriteThrough` - Data is written through the cache and to the physical drives. Performance is improved, because subsequent reads of that data can be satisfied from the cache.\n* `WriteBackGoodBbu` - Data is stored in the cache, and is only written to the physical drives when space in the cache is needed. Virtual drives requesting this policy fall back to Write Through caching when the battery backup unit (BBU) cannot guarantee the safety of the cache in the event of a power failure.\n* `AlwaysWriteBack` - With this policy, write caching remains Write Back even if the battery backup unit is defective or discharged."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public StorageVirtualDriveConfig.WritePolicyEnum WritePolicy {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.StorageVirtualDriveConfig initObject = new Intersight.Model.StorageVirtualDriveConfig();
            if (this.MyInvocation.BoundParameters.ContainsKey("AccessPolicy"))
            {
                initObject.AccessPolicy = this.AccessPolicy;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BootDrive"))
            {
                initObject.BootDrive = this.BootDrive;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("DiskGroupPolicy"))
            {
                initObject.DiskGroupPolicy = this.DiskGroupPolicy;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DriveCache"))
            {
                initObject.DriveCache = this.DriveCache;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ExpandToAvailable"))
            {
                initObject.ExpandToAvailable = this.ExpandToAvailable;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IoPolicy"))
            {
                initObject.IoPolicy = this.IoPolicy;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("ReadPolicy"))
            {
                initObject.ReadPolicy = this.ReadPolicy;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Size"))
            {
                initObject.Size = this.Size;
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
}