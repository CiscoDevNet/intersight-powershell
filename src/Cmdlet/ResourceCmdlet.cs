using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New ResourceGroup.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightResourceGroup")]
    public class NewIntersightResourceGroup:NewCmdletBase
	{
		public NewIntersightResourceGroup()
		{
			ApiInstance = new ResourceApi(Config);
            ModelObject = new ResourceGroup();
            MethodName = "CreateResourceGroupWithHttpInfo";
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of this resource group."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,128}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to organizationOrganization resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<OrganizationOrganizationRelationship> Organizations {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<ResourcePerTypeCombinedSelector> PerTypeCombinedSelector {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Qualifier shall be used to specify if we want to organize resources using multiple resource group or single For an account, resource groups can be of only one of the above types. (Both the types are mutually exclusive for an account.).\n* `Allow-Selectors` - Resources will be added to resource groups based on ODATA filter. Multiple resource group can be created to organize resources.\n* `Allow-All` - All resources will become part of the Resource Group. Only one resource group can be created to organize resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ResourceGroup.QualifierEnum Qualifier {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<ResourceSelector> Selectors {
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
    /// <para type="synopsis">This is the cmdlet to Get ResourceGroup.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightResourceGroup", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightResourceGroup:GetCmdletBase
	{
		public GetIntersightResourceGroup()
		{
			ApiInstance = new ResourceApi(Config);
            MethodName = "GetResourceGroupListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set ResourceGroup.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightResourceGroup")]
    public class SetIntersightResourceGroup:SetCmdletBase
	{
		public SetIntersightResourceGroup()
		{
			ApiInstance = new ResourceApi(Config);
            ModelObject = new ResourceGroup();
            MethodName = "UpdateResourceGroupWithHttpInfo";
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
        /// <para type="description">"The name of this resource group."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,128}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to organizationOrganization resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<OrganizationOrganizationRelationship> Organizations {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<ResourcePerTypeCombinedSelector> PerTypeCombinedSelector {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Qualifier shall be used to specify if we want to organize resources using multiple resource group or single For an account, resource groups can be of only one of the above types. (Both the types are mutually exclusive for an account.).\n* `Allow-Selectors` - Resources will be added to resource groups based on ODATA filter. Multiple resource group can be created to organize resources.\n* `Allow-All` - All resources will become part of the Resource Group. Only one resource group can be created to organize resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ResourceGroup.QualifierEnum Qualifier {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<ResourceSelector> Selectors {
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
    /// <para type="synopsis">This is the cmdlet to Remove ResourceGroup.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightResourceGroup")]
    public class RemoveIntersightResourceGroup:RemoveCmdletBase
	{
		public RemoveIntersightResourceGroup()
		{
			ApiInstance = new ResourceApi(Config);
            MethodName = "DeleteResourceGroupWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get ResourceGroupMember.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightResourceGroupMember", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightResourceGroupMember:GetCmdletBase
	{
		public GetIntersightResourceGroupMember()
		{
			ApiInstance = new ResourceApi(Config);
            MethodName = "GetResourceGroupMemberListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get ResourceMembership.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightResourceMembership", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightResourceMembership:GetCmdletBase
	{
		public GetIntersightResourceMembership()
		{
			ApiInstance = new ResourceApi(Config);
            MethodName = "GetResourceMembershipListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get ResourceMembershipHolder.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightResourceMembershipHolder", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightResourceMembershipHolder:GetCmdletBase
	{
		public GetIntersightResourceMembershipHolder()
		{
			ApiInstance = new ResourceApi(Config);
            MethodName = "GetResourceMembershipHolderListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get ResourceLicenseResourceCount.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightResourceLicenseResourceCount", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightResourceLicenseResourceCount:GetCmdletBase
	{
		public GetIntersightResourceLicenseResourceCount()
		{
			ApiInstance = new ResourceApi(Config);
            MethodName = "GetResourceLicenseResourceCountListWithHttpInfo";
		}
    }
}