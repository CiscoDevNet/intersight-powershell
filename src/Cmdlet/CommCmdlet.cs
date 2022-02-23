using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New CommHttpProxyPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightCommHttpProxyPolicy")]
    public class NewIntersightCommHttpProxyPolicy:NewCmdletBase
	{
		public NewIntersightCommHttpProxyPolicy()
		{
			ApiInstance = new CommApi(Config);
            ModelObject = new CommHttpProxyPolicy();
            MethodName = "CreateCommHttpProxyPolicyWithHttpInfo";
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
        /// <para type="description">"An array of relationships to hyperflexClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<HyperflexClusterProfileRelationship> ClusterProfiles {
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
        /// <para type="description">"HTTP Proxy server FQDN or IP."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[A-Za-z]([A-Za-z0-9-]*[A-Za-z0-9])?$|^[A-Za-z0-9]([A-Za-z0-9-]*[A-Za-z0-9])?(\\.[A-Za-z0-9]([A-Za-z0-9-]*[A-Za-z0-9])?)*(\\.[A-Za-z]([A-Za-z0-9-]*[A-Za-z0-9])?)$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string Hostname {
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
        /// <para type="description">"The password for the HTTP Proxy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Password {
            get;
            set;
        }
        
        
        // <summary>
        /// <para type="description">"The HTTP Proxy port number.\nThe port number of the HTTP proxy must be between 1 and 65535, inclusive."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1, 65535)]
        public long Port {
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
        /// <para type="description">"The username for the HTTP Proxy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Username {
            get;
            set;
        }
        
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get CommHttpProxyPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightCommHttpProxyPolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightCommHttpProxyPolicy:GetCmdletBase
	{
		public GetIntersightCommHttpProxyPolicy()
		{
			ApiInstance = new CommApi(Config);
            MethodName = "GetCommHttpProxyPolicyListWithHttpInfo";
		}
        
        // <summary>
        /// <para type="description">"The Account ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        
        public string AccountMoid {
            get;
            set;
        }
        
        
        
        
        // <summary>
        /// <para type="description">"The time when this managed object was created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        
        public DateTime CreateTime {
            get;
            set;
        }
        
        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
            get;
            set;
        }
        
        // <summary>
        /// <para type="description">"The DomainGroup ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        
        public string DomainGroupMoid {
            get;
            set;
        }
        
        // <summary>
        /// <para type="description">"HTTP Proxy server FQDN or IP."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^[A-Za-z]([A-Za-z0-9-]*[A-Za-z0-9])?$|^[A-Za-z0-9]([A-Za-z0-9-]*[A-Za-z0-9])?(\\.[A-Za-z0-9]([A-Za-z0-9-]*[A-Za-z0-9])?)*(\\.[A-Za-z]([A-Za-z0-9-]*[A-Za-z0-9])?)$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string Hostname {
            get;
            set;
        }
        
        // <summary>
        /// <para type="description">"Indicates whether the value of the 'password' property has been set."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        
        public bool IsPasswordSet {
            get;
            set;
        }
        
        // <summary>
        /// <para type="description">"The time when this managed object was last modified."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        
        public DateTime ModTime {
            get;
            set;
        }
        
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        
        public string Moid {
            get;
            set;
        }
        
        // <summary>
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = true, ParameterSetName = "CmdletParam")]
        
        public OrganizationOrganizationRelationship Organization {
            get;
            set;
        }
        
        
        // <summary>
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false,ValueFromPipeline = true, ParameterSetName = "CmdletParam")]
        
        public MoBaseMoRelationship Parent {
            get;
            set;
        }
        
        // <summary>
        /// <para type="description">"The password for the HTTP Proxy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        
        public string Password {
            get;
            set;
        }
        
        
        // <summary>
        /// <para type="description">"The HTTP Proxy port number.\nThe port number of the HTTP proxy must be between 1 and 65535, inclusive."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidateRange(1, 65535)]
        public long Port {
            get;
            set;
        }
        
        // <summary>
        /// <para type="description">"Intersight provides pre-built workflows, tasks and policies to end users through global catalogs.\nObjects that are made available through global catalogs are said to have a 'shared' ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        
        public string SharedScope {
            get;
            set;
        }
        
        
        // <summary>
        /// <para type="description">"The username for the HTTP Proxy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        
        public string Username {
            get;
            set;
        }
        

        
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set CommHttpProxyPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightCommHttpProxyPolicy")]
    public class SetIntersightCommHttpProxyPolicy:SetCmdletBase
	{
		public SetIntersightCommHttpProxyPolicy()
		{
			ApiInstance = new CommApi(Config);
            ModelObject = new CommHttpProxyPolicy();
            MethodName = "UpdateCommHttpProxyPolicyWithHttpInfo";
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
        /// <para type="description">"An array of relationships to hyperflexClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<HyperflexClusterProfileRelationship> ClusterProfiles {
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
        /// <para type="description">"HTTP Proxy server FQDN or IP."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[A-Za-z]([A-Za-z0-9-]*[A-Za-z0-9])?$|^[A-Za-z0-9]([A-Za-z0-9-]*[A-Za-z0-9])?(\\.[A-Za-z0-9]([A-Za-z0-9-]*[A-Za-z0-9])?)*(\\.[A-Za-z]([A-Za-z0-9-]*[A-Za-z0-9])?)$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string Hostname {
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
        /// <para type="description">"The password for the HTTP Proxy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Password {
            get;
            set;
        }
        
        
        // <summary>
        /// <para type="description">"The HTTP Proxy port number.\nThe port number of the HTTP proxy must be between 1 and 65535, inclusive."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1, 65535)]
        public long Port {
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
        /// <para type="description">"The username for the HTTP Proxy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Username {
            get;
            set;
        }
        
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove CommHttpProxyPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightCommHttpProxyPolicy")]
    public class RemoveIntersightCommHttpProxyPolicy:RemoveCmdletBase
	{
		public RemoveIntersightCommHttpProxyPolicy()
		{
			ApiInstance = new CommApi(Config);
            MethodName = "DeleteCommHttpProxyPolicyWithHttpInfo";
		}
    }
}