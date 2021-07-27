using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set IpmioverlanPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightIpmioverlanPolicy")]
    public class SetIntersightIpmioverlanPolicy:SetCmdletBase
	{
		public SetIntersightIpmioverlanPolicy()
		{
			ApiInstance = new IpmioverlanApi(Config);
            ModelObject = new IpmioverlanPolicy();
            MethodName = "UpdateIpmioverlanPolicy";
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
        /// <para type="description">"State of the IPMI Over LAN service on the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Enabled {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The encryption key to use for IPMI communication. It should have an even number of hexadecimal characters and not exceed 40 characters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-fA-F0-9]*$")]
        public string EncryptionKey {
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
        /// <para type="description">"The highest privilege level that can be assigned to an IPMI session on a server.\n* `admin` - Privilege to perform all actions available through IPMI.\n* `user` - Privilege to perform some functions through IPMI but restriction on performing administrative tasks.\n* `read-only` - Privilege to view information throught IPMI but restriction on making any changes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IpmioverlanPolicy.PrivilegeEnum Privilege {
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
    /// <para type="synopsis">This is the cmdlet to Remove IpmioverlanPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightIpmioverlanPolicy")]
    public class RemoveIntersightIpmioverlanPolicy:RemoveCmdletBase
	{
		public RemoveIntersightIpmioverlanPolicy()
		{
			ApiInstance = new IpmioverlanApi(Config);
            MethodName = "DeleteIpmioverlanPolicy";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New IpmioverlanPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightIpmioverlanPolicy")]
    public class NewIntersightIpmioverlanPolicy:NewCmdletBase
	{
		public NewIntersightIpmioverlanPolicy()
		{
			ApiInstance = new IpmioverlanApi(Config);
            ModelObject = new IpmioverlanPolicy();
            MethodName = "CreateIpmioverlanPolicy";
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
        /// <para type="description">"State of the IPMI Over LAN service on the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Enabled {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The encryption key to use for IPMI communication. It should have an even number of hexadecimal characters and not exceed 40 characters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-fA-F0-9]*$")]
        public string EncryptionKey {
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
        /// <para type="description">"The highest privilege level that can be assigned to an IPMI session on a server.\n* `admin` - Privilege to perform all actions available through IPMI.\n* `user` - Privilege to perform some functions through IPMI but restriction on performing administrative tasks.\n* `read-only` - Privilege to view information throught IPMI but restriction on making any changes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IpmioverlanPolicy.PrivilegeEnum Privilege {
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
    /// <para type="synopsis">This is the cmdlet to Get IpmioverlanPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightIpmioverlanPolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightIpmioverlanPolicy:GetCmdletBase
	{
		public GetIntersightIpmioverlanPolicy()
		{
			ApiInstance = new IpmioverlanApi(Config);
            MethodName = "GetIpmioverlanPolicyList";
		}
    }
}