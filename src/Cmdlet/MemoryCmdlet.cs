using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get MemoryPersistentMemoryUnit.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightMemoryPersistentMemoryUnit", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightMemoryPersistentMemoryUnit:GetCmdletBase
	{
		public GetIntersightMemoryPersistentMemoryUnit()
		{
			ApiInstance = new MemoryApi(Config);
            MethodName = "GetMemoryPersistentMemoryUnitListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get MemoryUnit.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightMemoryUnit", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightMemoryUnit:GetCmdletBase
	{
		public GetIntersightMemoryUnit()
		{
			ApiInstance = new MemoryApi(Config);
            MethodName = "GetMemoryUnitListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get MemoryPersistentMemoryNamespaceConfigResult.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightMemoryPersistentMemoryNamespaceConfigResult", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightMemoryPersistentMemoryNamespaceConfigResult:GetCmdletBase
	{
		public GetIntersightMemoryPersistentMemoryNamespaceConfigResult()
		{
			ApiInstance = new MemoryApi(Config);
            MethodName = "GetMemoryPersistentMemoryNamespaceConfigResultListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set MemoryPersistentMemoryNamespaceConfigResult.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightMemoryPersistentMemoryNamespaceConfigResult")]
    public class SetIntersightMemoryPersistentMemoryNamespaceConfigResult:SetCmdletBase
	{
		public SetIntersightMemoryPersistentMemoryNamespaceConfigResult()
		{
			ApiInstance = new MemoryApi(Config);
            ModelObject = new MemoryPersistentMemoryNamespaceConfigResult();
            MethodName = "UpdateMemoryPersistentMemoryNamespaceConfigResultWithHttpInfo";
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
    /// <para type="synopsis">This is the cmdlet to Set MemoryPersistentMemoryPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightMemoryPersistentMemoryPolicy")]
    public class SetIntersightMemoryPersistentMemoryPolicy:SetCmdletBase
	{
		public SetIntersightMemoryPersistentMemoryPolicy()
		{
			ApiInstance = new MemoryApi(Config);
            ModelObject = new MemoryPersistentMemoryPolicy();
            MethodName = "UpdateMemoryPersistentMemoryPolicyWithHttpInfo";
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MemoryPersistentMemoryGoal> Goals {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Local security for the Persistent Memory Modules on the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public MemoryPersistentMemoryLocalSecurity LocalSecurity {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MemoryPersistentMemoryLogicalNamespace> LogicalNamespaces {
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
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove MemoryPersistentMemoryPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightMemoryPersistentMemoryPolicy")]
    public class RemoveIntersightMemoryPersistentMemoryPolicy:RemoveCmdletBase
	{
		public RemoveIntersightMemoryPersistentMemoryPolicy()
		{
			ApiInstance = new MemoryApi(Config);
            MethodName = "DeleteMemoryPersistentMemoryPolicyWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get MemoryPersistentMemoryConfigResult.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightMemoryPersistentMemoryConfigResult", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightMemoryPersistentMemoryConfigResult:GetCmdletBase
	{
		public GetIntersightMemoryPersistentMemoryConfigResult()
		{
			ApiInstance = new MemoryApi(Config);
            MethodName = "GetMemoryPersistentMemoryConfigResultListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set MemoryPersistentMemoryRegion.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightMemoryPersistentMemoryRegion")]
    public class SetIntersightMemoryPersistentMemoryRegion:SetCmdletBase
	{
		public SetIntersightMemoryPersistentMemoryRegion()
		{
			ApiInstance = new MemoryApi(Config);
            ModelObject = new MemoryPersistentMemoryRegion();
            MethodName = "UpdateMemoryPersistentMemoryRegionWithHttpInfo";
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
    /// <para type="synopsis">This is the cmdlet to Set MemoryPersistentMemoryConfigResult.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightMemoryPersistentMemoryConfigResult")]
    public class SetIntersightMemoryPersistentMemoryConfigResult:SetCmdletBase
	{
		public SetIntersightMemoryPersistentMemoryConfigResult()
		{
			ApiInstance = new MemoryApi(Config);
            ModelObject = new MemoryPersistentMemoryConfigResult();
            MethodName = "UpdateMemoryPersistentMemoryConfigResultWithHttpInfo";
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
    /// <para type="synopsis">This is the cmdlet to Set MemoryUnit.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightMemoryUnit")]
    public class SetIntersightMemoryUnit:SetCmdletBase
	{
		public SetIntersightMemoryUnit()
		{
			ApiInstance = new MemoryApi(Config);
            ModelObject = new MemoryUnit();
            MethodName = "UpdateMemoryUnitWithHttpInfo";
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
    /// <para type="synopsis">This is the cmdlet to Get MemoryArray.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightMemoryArray", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightMemoryArray:GetCmdletBase
	{
		public GetIntersightMemoryArray()
		{
			ApiInstance = new MemoryApi(Config);
            MethodName = "GetMemoryArrayListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get MemoryPersistentMemoryConfiguration.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightMemoryPersistentMemoryConfiguration", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightMemoryPersistentMemoryConfiguration:GetCmdletBase
	{
		public GetIntersightMemoryPersistentMemoryConfiguration()
		{
			ApiInstance = new MemoryApi(Config);
            MethodName = "GetMemoryPersistentMemoryConfigurationListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get MemoryPersistentMemoryRegion.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightMemoryPersistentMemoryRegion", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightMemoryPersistentMemoryRegion:GetCmdletBase
	{
		public GetIntersightMemoryPersistentMemoryRegion()
		{
			ApiInstance = new MemoryApi(Config);
            MethodName = "GetMemoryPersistentMemoryRegionListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set MemoryPersistentMemoryUnit.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightMemoryPersistentMemoryUnit")]
    public class SetIntersightMemoryPersistentMemoryUnit:SetCmdletBase
	{
		public SetIntersightMemoryPersistentMemoryUnit()
		{
			ApiInstance = new MemoryApi(Config);
            ModelObject = new MemoryPersistentMemoryUnit();
            MethodName = "UpdateMemoryPersistentMemoryUnitWithHttpInfo";
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
    /// <para type="synopsis">This is the cmdlet to Set MemoryPersistentMemoryNamespace.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightMemoryPersistentMemoryNamespace")]
    public class SetIntersightMemoryPersistentMemoryNamespace:SetCmdletBase
	{
		public SetIntersightMemoryPersistentMemoryNamespace()
		{
			ApiInstance = new MemoryApi(Config);
            ModelObject = new MemoryPersistentMemoryNamespace();
            MethodName = "UpdateMemoryPersistentMemoryNamespaceWithHttpInfo";
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
    /// <para type="synopsis">This is the cmdlet to Set MemoryArray.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightMemoryArray")]
    public class SetIntersightMemoryArray:SetCmdletBase
	{
		public SetIntersightMemoryArray()
		{
			ApiInstance = new MemoryApi(Config);
            ModelObject = new MemoryArray();
            MethodName = "UpdateMemoryArrayWithHttpInfo";
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
    /// <para type="synopsis">This is the cmdlet to Get MemoryPersistentMemoryNamespace.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightMemoryPersistentMemoryNamespace", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightMemoryPersistentMemoryNamespace:GetCmdletBase
	{
		public GetIntersightMemoryPersistentMemoryNamespace()
		{
			ApiInstance = new MemoryApi(Config);
            MethodName = "GetMemoryPersistentMemoryNamespaceListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set MemoryPersistentMemoryConfiguration.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightMemoryPersistentMemoryConfiguration")]
    public class SetIntersightMemoryPersistentMemoryConfiguration:SetCmdletBase
	{
		public SetIntersightMemoryPersistentMemoryConfiguration()
		{
			ApiInstance = new MemoryApi(Config);
            ModelObject = new MemoryPersistentMemoryConfiguration();
            MethodName = "UpdateMemoryPersistentMemoryConfigurationWithHttpInfo";
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
    /// <para type="synopsis">This is the cmdlet to New MemoryPersistentMemoryPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightMemoryPersistentMemoryPolicy")]
    public class NewIntersightMemoryPersistentMemoryPolicy:NewCmdletBase
	{
		public NewIntersightMemoryPersistentMemoryPolicy()
		{
			ApiInstance = new MemoryApi(Config);
            ModelObject = new MemoryPersistentMemoryPolicy();
            MethodName = "CreateMemoryPersistentMemoryPolicyWithHttpInfo";
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MemoryPersistentMemoryGoal> Goals {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Local security for the Persistent Memory Modules on the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public MemoryPersistentMemoryLocalSecurity LocalSecurity {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MemoryPersistentMemoryLogicalNamespace> LogicalNamespaces {
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
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get MemoryPersistentMemoryPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightMemoryPersistentMemoryPolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightMemoryPersistentMemoryPolicy:GetCmdletBase
	{
		public GetIntersightMemoryPersistentMemoryPolicy()
		{
			ApiInstance = new MemoryApi(Config);
            MethodName = "GetMemoryPersistentMemoryPolicyListWithHttpInfo";
		}
    }
}