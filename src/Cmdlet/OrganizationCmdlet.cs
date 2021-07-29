using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set OrganizationOrganization.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightOrganizationOrganization")]
    public class SetIntersightOrganizationOrganization:SetCmdletBase
	{
		public SetIntersightOrganizationOrganization()
		{
			ApiInstance = new OrganizationApi(Config);
            ModelObject = new OrganizationOrganization();
            MethodName = "UpdateOrganizationOrganization";
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
        /// <para type="description">"The informative description about the usage of this organization."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
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
        /// <para type="description">"The name of the organization. There can be multiple organizations under an account."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to resourceGroup resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<ResourceGroupRelationship> ResourceGroups {
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
    /// <para type="synopsis">This is the cmdlet to Remove OrganizationOrganization.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightOrganizationOrganization")]
    public class RemoveIntersightOrganizationOrganization:RemoveCmdletBase
	{
		public RemoveIntersightOrganizationOrganization()
		{
			ApiInstance = new OrganizationApi(Config);
            MethodName = "DeleteOrganizationOrganization";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New OrganizationOrganization.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightOrganizationOrganization")]
    public class NewIntersightOrganizationOrganization:NewCmdletBase
	{
		public NewIntersightOrganizationOrganization()
		{
			ApiInstance = new OrganizationApi(Config);
            ModelObject = new OrganizationOrganization();
            MethodName = "CreateOrganizationOrganization";
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
        /// <para type="description">"The informative description about the usage of this organization."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
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
        /// <para type="description">"The name of the organization. There can be multiple organizations under an account."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to resourceGroup resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<ResourceGroupRelationship> ResourceGroups {
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
    /// <para type="synopsis">This is the cmdlet to Get OrganizationOrganization.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightOrganizationOrganization", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightOrganizationOrganization:GetCmdletBase
	{
		public GetIntersightOrganizationOrganization()
		{
			ApiInstance = new OrganizationApi(Config);
            MethodName = "GetOrganizationOrganizationList";
		}
    }
}