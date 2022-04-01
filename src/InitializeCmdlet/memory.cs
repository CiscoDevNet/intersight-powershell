using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize MemoryPersistentMemoryConfiguration.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightMemoryPersistentMemoryConfiguration")]
    public class InitializeIntersightMemoryPersistentMemoryConfiguration:PSCmdlet
	{
		public InitializeIntersightMemoryPersistentMemoryConfiguration()
		{
            ClassId = MemoryPersistentMemoryConfiguration.ClassIdEnum.MemoryPersistentMemoryConfiguration;
            ObjectType = MemoryPersistentMemoryConfiguration.ObjectTypeEnum.MemoryPersistentMemoryConfiguration;
            
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
        
        public MemoryPersistentMemoryConfiguration.ClassIdEnum ClassId {
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public MemoryPersistentMemoryConfiguration.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Model.MoTag> Tags {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.MemoryPersistentMemoryConfiguration initObject = new Intersight.Model.MemoryPersistentMemoryConfiguration();
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
    /// <para type="synopsis">This is the cmdlet to Initialize MemoryPersistentMemoryGoal.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightMemoryPersistentMemoryGoal")]
    public class InitializeIntersightMemoryPersistentMemoryGoal:PSCmdlet
	{
		public InitializeIntersightMemoryPersistentMemoryGoal()
		{
            ClassId = MemoryPersistentMemoryGoal.ClassIdEnum.MemoryPersistentMemoryGoal;
            ObjectType = MemoryPersistentMemoryGoal.ObjectTypeEnum.MemoryPersistentMemoryGoal;
            PersistentMemoryType = MemoryPersistentMemoryGoal.PersistentMemoryTypeEnum.AppDirect;
            SocketId = MemoryPersistentMemoryGoal.SocketIdEnum.AllSockets;
            
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
        
        public MemoryPersistentMemoryGoal.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Volatile memory percentage."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long MemoryModePercentage {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public MemoryPersistentMemoryGoal.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of the Persistent Memory configuration where the Persistent Memory Modules are combined in an interleaved set or not.\n* `app-direct` - The App Direct interleaved Persistent Memory type.\n* `app-direct-non-interleaved` - The App Direct non-interleaved Persistent Memory type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public MemoryPersistentMemoryGoal.PersistentMemoryTypeEnum PersistentMemoryType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"CPU Socket ID to which this goal will be applied.\n* `All Sockets` - All the CPU socket IDs in a server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public MemoryPersistentMemoryGoal.SocketIdEnum SocketId {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.MemoryPersistentMemoryGoal initObject = new Intersight.Model.MemoryPersistentMemoryGoal();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("MemoryModePercentage"))
            {
                initObject.MemoryModePercentage = this.MemoryModePercentage;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("PersistentMemoryType"))
            {
                initObject.PersistentMemoryType = this.PersistentMemoryType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SocketId"))
            {
                initObject.SocketId = this.SocketId;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize MemoryPersistentMemoryNamespaceConfigResult.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightMemoryPersistentMemoryNamespaceConfigResult")]
    public class InitializeIntersightMemoryPersistentMemoryNamespaceConfigResult:PSCmdlet
	{
		public InitializeIntersightMemoryPersistentMemoryNamespaceConfigResult()
		{
            ClassId = MemoryPersistentMemoryNamespaceConfigResult.ClassIdEnum.MemoryPersistentMemoryNamespaceConfigResult;
            ObjectType = MemoryPersistentMemoryNamespaceConfigResult.ObjectTypeEnum.MemoryPersistentMemoryNamespaceConfigResult;
            
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
        
        public MemoryPersistentMemoryNamespaceConfigResult.ClassIdEnum ClassId {
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public MemoryPersistentMemoryNamespaceConfigResult.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Model.MoTag> Tags {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.MemoryPersistentMemoryNamespaceConfigResult initObject = new Intersight.Model.MemoryPersistentMemoryNamespaceConfigResult();
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
    /// <para type="synopsis">This is the cmdlet to Initialize MemoryPersistentMemoryConfigResult.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightMemoryPersistentMemoryConfigResult")]
    public class InitializeIntersightMemoryPersistentMemoryConfigResult:PSCmdlet
	{
		public InitializeIntersightMemoryPersistentMemoryConfigResult()
		{
            ClassId = MemoryPersistentMemoryConfigResult.ClassIdEnum.MemoryPersistentMemoryConfigResult;
            ObjectType = MemoryPersistentMemoryConfigResult.ObjectTypeEnum.MemoryPersistentMemoryConfigResult;
            
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
        
        public MemoryPersistentMemoryConfigResult.ClassIdEnum ClassId {
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public MemoryPersistentMemoryConfigResult.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Model.MoTag> Tags {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.MemoryPersistentMemoryConfigResult initObject = new Intersight.Model.MemoryPersistentMemoryConfigResult();
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
    /// <para type="synopsis">This is the cmdlet to Initialize MemoryPersistentMemoryRegion.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightMemoryPersistentMemoryRegion")]
    public class InitializeIntersightMemoryPersistentMemoryRegion:PSCmdlet
	{
		public InitializeIntersightMemoryPersistentMemoryRegion()
		{
            ClassId = MemoryPersistentMemoryRegion.ClassIdEnum.MemoryPersistentMemoryRegion;
            ObjectType = MemoryPersistentMemoryRegion.ObjectTypeEnum.MemoryPersistentMemoryRegion;
            
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
        
        public MemoryPersistentMemoryRegion.ClassIdEnum ClassId {
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public MemoryPersistentMemoryRegion.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Model.MoTag> Tags {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.MemoryPersistentMemoryRegion initObject = new Intersight.Model.MemoryPersistentMemoryRegion();
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
    /// <para type="synopsis">This is the cmdlet to Initialize MemoryPersistentMemoryPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightMemoryPersistentMemoryPolicy")]
    public class InitializeIntersightMemoryPersistentMemoryPolicy:PSCmdlet
	{
		public InitializeIntersightMemoryPersistentMemoryPolicy()
		{
            ClassId = MemoryPersistentMemoryPolicy.ClassIdEnum.MemoryPersistentMemoryPolicy;
            ManagementMode = MemoryPersistentMemoryPolicy.ManagementModeEnum.ConfiguredFromIntersight;
            ObjectType = MemoryPersistentMemoryPolicy.ObjectTypeEnum.MemoryPersistentMemoryPolicy;
            
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
        
        public MemoryPersistentMemoryPolicy.ClassIdEnum ClassId {
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Model.MemoryPersistentMemoryGoal> Goals {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Local security for the Persistent Memory Modules on the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.MemoryPersistentMemoryLocalSecurity LocalSecurity {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Model.MemoryPersistentMemoryLogicalNamespace> LogicalNamespaces {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Management Mode of the policy. This can be either Configured from Intersight or Configured from Operating System.\n* `configured-from-intersight` - The Persistent Memory Modules are configured from Intersight thorugh Persistent Memory policy.\n* `configured-from-operating-system` - The Persistent Memory Modules are configured from operating system thorugh OS tools."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public MemoryPersistentMemoryPolicy.ManagementModeEnum ManagementMode {
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public MemoryPersistentMemoryPolicy.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.OrganizationOrganizationRelationship Organization {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to policyAbstractConfigProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Model.PolicyAbstractConfigProfileRelationship> Profiles {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Persistent Memory Namespaces to be retained or not."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool RetainNamespaces {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Model.MoTag> Tags {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.MemoryPersistentMemoryPolicy initObject = new Intersight.Model.MemoryPersistentMemoryPolicy();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Goals"))
            {
                initObject.Goals = this.Goals;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LocalSecurity"))
            {
                initObject.LocalSecurity = this.LocalSecurity;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LogicalNamespaces"))
            {
                initObject.LogicalNamespaces = this.LogicalNamespaces;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ManagementMode"))
            {
                initObject.ManagementMode = this.ManagementMode;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Profiles"))
            {
                initObject.Profiles = this.Profiles;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RetainNamespaces"))
            {
                initObject.RetainNamespaces = this.RetainNamespaces;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize MemoryArray.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightMemoryArray")]
    public class InitializeIntersightMemoryArray:PSCmdlet
	{
		public InitializeIntersightMemoryArray()
		{
            ClassId = MemoryArray.ClassIdEnum.MemoryArray;
            ObjectType = MemoryArray.ObjectTypeEnum.MemoryArray;
            
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
        
        public MemoryArray.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a computeBlade resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.ComputeBladeRelationship ComputeBlade {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a computeRackUnit resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.ComputeRackUnitRelationship ComputeRackUnit {
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public MemoryArray.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a equipmentFru resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.EquipmentFruRelationship PreviousFru {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Model.MoTag> Tags {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.MemoryArray initObject = new Intersight.Model.MemoryArray();
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
    /// <para type="synopsis">This is the cmdlet to Initialize MemoryUnit.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightMemoryUnit")]
    public class InitializeIntersightMemoryUnit:PSCmdlet
	{
		public InitializeIntersightMemoryUnit()
		{
            ClassId = MemoryUnit.ClassIdEnum.MemoryUnit;
            ObjectType = MemoryUnit.ObjectTypeEnum.MemoryUnit;
            
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
        
        public MemoryUnit.ClassIdEnum ClassId {
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public MemoryUnit.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a equipmentFru resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.EquipmentFruRelationship PreviousFru {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Model.MoTag> Tags {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.MemoryUnit initObject = new Intersight.Model.MemoryUnit();
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
    /// <para type="synopsis">This is the cmdlet to Initialize MemoryPersistentMemoryLocalSecurity.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightMemoryPersistentMemoryLocalSecurity")]
    public class InitializeIntersightMemoryPersistentMemoryLocalSecurity:PSCmdlet
	{
		public InitializeIntersightMemoryPersistentMemoryLocalSecurity()
		{
            ClassId = MemoryPersistentMemoryLocalSecurity.ClassIdEnum.MemoryPersistentMemoryLocalSecurity;
            ObjectType = MemoryPersistentMemoryLocalSecurity.ObjectTypeEnum.MemoryPersistentMemoryLocalSecurity;
            
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
        
        public MemoryPersistentMemoryLocalSecurity.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Persistent Memory Security state."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Enabled {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public MemoryPersistentMemoryLocalSecurity.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Secure passphrase to be applied on the Persistent Memory Modules on the server. The allowed characters are a-z, A to Z, 0-9, and special characters =, \\u0021, &, \\#, $, %, +, ^, @, _, *, -."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9=!&#$%+^@_*-]+$")]
        public string SecurePassphrase {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.MemoryPersistentMemoryLocalSecurity initObject = new Intersight.Model.MemoryPersistentMemoryLocalSecurity();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Enabled"))
            {
                initObject.Enabled = this.Enabled;
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
    /// <para type="synopsis">This is the cmdlet to Initialize MemoryPersistentMemoryUnit.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightMemoryPersistentMemoryUnit")]
    public class InitializeIntersightMemoryPersistentMemoryUnit:PSCmdlet
	{
		public InitializeIntersightMemoryPersistentMemoryUnit()
		{
            ClassId = MemoryPersistentMemoryUnit.ClassIdEnum.MemoryPersistentMemoryUnit;
            ObjectType = MemoryPersistentMemoryUnit.ObjectTypeEnum.MemoryPersistentMemoryUnit;
            
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
        
        public MemoryPersistentMemoryUnit.ClassIdEnum ClassId {
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public MemoryPersistentMemoryUnit.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a equipmentFru resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.EquipmentFruRelationship PreviousFru {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Model.MoTag> Tags {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.MemoryPersistentMemoryUnit initObject = new Intersight.Model.MemoryPersistentMemoryUnit();
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
    /// <para type="synopsis">This is the cmdlet to Initialize MemoryPersistentMemoryNamespace.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightMemoryPersistentMemoryNamespace")]
    public class InitializeIntersightMemoryPersistentMemoryNamespace:PSCmdlet
	{
		public InitializeIntersightMemoryPersistentMemoryNamespace()
		{
            ClassId = MemoryPersistentMemoryNamespace.ClassIdEnum.MemoryPersistentMemoryNamespace;
            ObjectType = MemoryPersistentMemoryNamespace.ObjectTypeEnum.MemoryPersistentMemoryNamespace;
            
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
        
        public MemoryPersistentMemoryNamespace.ClassIdEnum ClassId {
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public MemoryPersistentMemoryNamespace.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Model.MoTag> Tags {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.MemoryPersistentMemoryNamespace initObject = new Intersight.Model.MemoryPersistentMemoryNamespace();
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
    /// <para type="synopsis">This is the cmdlet to Initialize MemoryPersistentMemoryLogicalNamespace.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightMemoryPersistentMemoryLogicalNamespace")]
    public class InitializeIntersightMemoryPersistentMemoryLogicalNamespace:PSCmdlet
	{
		public InitializeIntersightMemoryPersistentMemoryLogicalNamespace()
		{
            ClassId = MemoryPersistentMemoryLogicalNamespace.ClassIdEnum.MemoryPersistentMemoryLogicalNamespace;
            Mode = MemoryPersistentMemoryLogicalNamespace.ModeEnum.Raw;
            ObjectType = MemoryPersistentMemoryLogicalNamespace.ObjectTypeEnum.MemoryPersistentMemoryLogicalNamespace;
            SocketId = MemoryPersistentMemoryLogicalNamespace.SocketIdEnum.NUMBER_1;
            SocketMemoryId = MemoryPersistentMemoryLogicalNamespace.SocketMemoryIdEnum.NotApplicable;
            
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
        /// <para type="description">"Capacity of this Namespace that is created or modified."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1, 9.223372036854776e+18)]
        public long Capacity {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public MemoryPersistentMemoryLogicalNamespace.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Mode of this Namespace that is created or modified.\n* `raw` - The raw mode of Persistent Memory Namespace.\n* `block` - The block mode of Persistent Memory Namespace."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public MemoryPersistentMemoryLogicalNamespace.ModeEnum Mode {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of this Namespace to be created on the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9#_-][a-zA-Z0-9#_ -]*$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public MemoryPersistentMemoryLogicalNamespace.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Socket ID of the region on which this Namespace has to be created or modified.\n* `1` - The first CPU socket in a server.\n* `2` - The second CPU socket in a server.\n* `3` - The third CPU socket in a server.\n* `4` - The fourth CPU socket in a server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public MemoryPersistentMemoryLogicalNamespace.SocketIdEnum SocketId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Socket Memory ID of the region on which this Namespace has to be created or modified.\n* `Not Applicable` - The socket memory ID is not applicable if app-direct persistent memory type is selected in the goal.\n* `2` - The second socket memory ID within a socket in a server.\n* `4` - The fourth socket memory ID within a socket in a server.\n* `6` - The sixth socket memory ID within a socket in a server.\n* `8` - The eighth socket memory ID within a socket in a server.\n* `10` - The tenth socket memory ID within a socket in a server.\n* `12` - The twelfth socket memory ID within a socket in a server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public MemoryPersistentMemoryLogicalNamespace.SocketMemoryIdEnum SocketMemoryId {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.MemoryPersistentMemoryLogicalNamespace initObject = new Intersight.Model.MemoryPersistentMemoryLogicalNamespace();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Capacity"))
            {
                initObject.Capacity = this.Capacity;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Mode"))
            {
                initObject.Mode = this.Mode;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
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
}