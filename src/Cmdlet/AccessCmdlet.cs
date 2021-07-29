using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get AccessPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightAccessPolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightAccessPolicy:GetCmdletBase
	{
		public GetIntersightAccessPolicy()
		{
			ApiInstance = new AccessApi(Config);
            MethodName = "GetAccessPolicyList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New AccessPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightAccessPolicy")]
    public class NewIntersightAccessPolicy:NewCmdletBase
	{
		public NewIntersightAccessPolicy()
		{
			ApiInstance = new AccessApi(Config);
            ModelObject = new AccessPolicy();
            MethodName = "CreateAccessPolicy";
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
        /// <para type="description">"The type of address to be retrieved from Inband IP Pool object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AccessAddressType AddressType {
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
        /// <para type="description">"A reference to a ippoolPool resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IppoolPoolRelationship InbandIpPool {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"VLAN to be used for server access over Inband network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(4, 4093)]
        public long InbandVlan {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a vrfVrf resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VrfVrfRelationship InbandVrf {
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set AccessPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightAccessPolicy")]
    public class SetIntersightAccessPolicy:SetCmdletBase
	{
		public SetIntersightAccessPolicy()
		{
			ApiInstance = new AccessApi(Config);
            ModelObject = new AccessPolicy();
            MethodName = "UpdateAccessPolicy";
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
        /// <para type="description">"The type of address to be retrieved from Inband IP Pool object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AccessAddressType AddressType {
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
        /// <para type="description">"A reference to a ippoolPool resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IppoolPoolRelationship InbandIpPool {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"VLAN to be used for server access over Inband network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(4, 4093)]
        public long InbandVlan {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a vrfVrf resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VrfVrfRelationship InbandVrf {
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove AccessPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightAccessPolicy")]
    public class RemoveIntersightAccessPolicy:RemoveCmdletBase
	{
		public RemoveIntersightAccessPolicy()
		{
			ApiInstance = new AccessApi(Config);
            MethodName = "DeleteAccessPolicy";
		}
    }
}