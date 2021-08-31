using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set AdapterConfigPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightAdapterConfigPolicy")]
    public class SetIntersightAdapterConfigPolicy:SetCmdletBase
	{
		public SetIntersightAdapterConfigPolicy()
		{
			ApiInstance = new AdapterApi(Config);
            ModelObject = new AdapterConfigPolicy();
            MethodName = "UpdateAdapterConfigPolicyWithHttpInfo";
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
        
        public List<AdapterAdapterConfig> Settings {
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
    /// <para type="synopsis">This is the cmdlet to Remove AdapterConfigPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightAdapterConfigPolicy")]
    public class RemoveIntersightAdapterConfigPolicy:RemoveCmdletBase
	{
		public RemoveIntersightAdapterConfigPolicy()
		{
			ApiInstance = new AdapterApi(Config);
            MethodName = "DeleteAdapterConfigPolicyWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get AdapterHostFcInterface.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightAdapterHostFcInterface", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightAdapterHostFcInterface:GetCmdletBase
	{
		public GetIntersightAdapterHostFcInterface()
		{
			ApiInstance = new AdapterApi(Config);
            MethodName = "GetAdapterHostFcInterfaceListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get AdapterExtEthInterface.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightAdapterExtEthInterface", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightAdapterExtEthInterface:GetCmdletBase
	{
		public GetIntersightAdapterExtEthInterface()
		{
			ApiInstance = new AdapterApi(Config);
            MethodName = "GetAdapterExtEthInterfaceListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get AdapterConfigPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightAdapterConfigPolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightAdapterConfigPolicy:GetCmdletBase
	{
		public GetIntersightAdapterConfigPolicy()
		{
			ApiInstance = new AdapterApi(Config);
            MethodName = "GetAdapterConfigPolicyListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New AdapterConfigPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightAdapterConfigPolicy")]
    public class NewIntersightAdapterConfigPolicy:NewCmdletBase
	{
		public NewIntersightAdapterConfigPolicy()
		{
			ApiInstance = new AdapterApi(Config);
            ModelObject = new AdapterConfigPolicy();
            MethodName = "CreateAdapterConfigPolicyWithHttpInfo";
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
        
        public List<AdapterAdapterConfig> Settings {
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
    /// <para type="synopsis">This is the cmdlet to Get AdapterUnitExpander.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightAdapterUnitExpander", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightAdapterUnitExpander:GetCmdletBase
	{
		public GetIntersightAdapterUnitExpander()
		{
			ApiInstance = new AdapterApi(Config);
            MethodName = "GetAdapterUnitExpanderListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get AdapterUnit.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightAdapterUnit", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightAdapterUnit:GetCmdletBase
	{
		public GetIntersightAdapterUnit()
		{
			ApiInstance = new AdapterApi(Config);
            MethodName = "GetAdapterUnitListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get AdapterHostEthInterface.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightAdapterHostEthInterface", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightAdapterHostEthInterface:GetCmdletBase
	{
		public GetIntersightAdapterHostEthInterface()
		{
			ApiInstance = new AdapterApi(Config);
            MethodName = "GetAdapterHostEthInterfaceListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get AdapterHostIscsiInterface.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightAdapterHostIscsiInterface", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightAdapterHostIscsiInterface:GetCmdletBase
	{
		public GetIntersightAdapterHostIscsiInterface()
		{
			ApiInstance = new AdapterApi(Config);
            MethodName = "GetAdapterHostIscsiInterfaceListWithHttpInfo";
		}
    }
}