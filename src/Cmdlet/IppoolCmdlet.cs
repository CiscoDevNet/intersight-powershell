using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get IppoolUniverse.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightIppoolUniverse", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightIppoolUniverse:GetCmdletBase
	{
		public GetIntersightIppoolUniverse()
		{
			ApiInstance = new IppoolApi(Config);
            MethodName = "GetIppoolUniverseListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get IppoolIpLease.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightIppoolIpLease", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightIppoolIpLease:GetCmdletBase
	{
		public GetIntersightIppoolIpLease()
		{
			ApiInstance = new IppoolApi(Config);
            MethodName = "GetIppoolIpLeaseListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove IppoolIpLease.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightIppoolIpLease")]
    public class RemoveIntersightIppoolIpLease:RemoveCmdletBase
	{
		public RemoveIntersightIppoolIpLease()
		{
			ApiInstance = new IppoolApi(Config);
            MethodName = "DeleteIppoolIpLeaseWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get IppoolPoolMember.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightIppoolPoolMember", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightIppoolPoolMember:GetCmdletBase
	{
		public GetIntersightIppoolPoolMember()
		{
			ApiInstance = new IppoolApi(Config);
            MethodName = "GetIppoolPoolMemberListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get IppoolPool.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightIppoolPool", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightIppoolPool:GetCmdletBase
	{
		public GetIntersightIppoolPool()
		{
			ApiInstance = new IppoolApi(Config);
            MethodName = "GetIppoolPoolListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New IppoolPool.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightIppoolPool")]
    public class NewIntersightIppoolPool:NewCmdletBase
	{
		public NewIntersightIppoolPool()
		{
			ApiInstance = new IppoolApi(Config);
            ModelObject = new IppoolPool();
            MethodName = "CreateIppoolPoolWithHttpInfo";
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
        /// <para type="description">"Assignment order decides the order in which the next identifier is allocated.\n* `sequential` - Identifiers are assigned in a sequential order.\n* `default` - Assignment order is decided by the system."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IppoolPool.AssignmentOrderEnum AssignmentOrder {
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
        
        public List<IppoolIpV4Block> IpV4Blocks {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Netmask, Gateway and DNS settings for IPv4 addresses."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IppoolIpV4Config IpV4Config {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<IppoolIpV6Block> IpV6Blocks {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Netmask, Gateway and DNS settings for IPv6 addresses."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IppoolIpV6Config IpV6Config {
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get IppoolBlockLease.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightIppoolBlockLease", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightIppoolBlockLease:GetCmdletBase
	{
		public GetIntersightIppoolBlockLease()
		{
			ApiInstance = new IppoolApi(Config);
            MethodName = "GetIppoolBlockLeaseListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get IppoolShadowBlock.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightIppoolShadowBlock", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightIppoolShadowBlock:GetCmdletBase
	{
		public GetIntersightIppoolShadowBlock()
		{
			ApiInstance = new IppoolApi(Config);
            MethodName = "GetIppoolShadowBlockListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get IppoolShadowPool.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightIppoolShadowPool", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightIppoolShadowPool:GetCmdletBase
	{
		public GetIntersightIppoolShadowPool()
		{
			ApiInstance = new IppoolApi(Config);
            MethodName = "GetIppoolShadowPoolListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove IppoolPool.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightIppoolPool")]
    public class RemoveIntersightIppoolPool:RemoveCmdletBase
	{
		public RemoveIntersightIppoolPool()
		{
			ApiInstance = new IppoolApi(Config);
            MethodName = "DeleteIppoolPoolWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set IppoolPool.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightIppoolPool")]
    public class SetIntersightIppoolPool:SetCmdletBase
	{
		public SetIntersightIppoolPool()
		{
			ApiInstance = new IppoolApi(Config);
            ModelObject = new IppoolPool();
            MethodName = "UpdateIppoolPoolWithHttpInfo";
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
        /// <para type="description">"Assignment order decides the order in which the next identifier is allocated.\n* `sequential` - Identifiers are assigned in a sequential order.\n* `default` - Assignment order is decided by the system."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IppoolPool.AssignmentOrderEnum AssignmentOrder {
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
        
        public List<IppoolIpV4Block> IpV4Blocks {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Netmask, Gateway and DNS settings for IPv4 addresses."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IppoolIpV4Config IpV4Config {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<IppoolIpV6Block> IpV6Blocks {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Netmask, Gateway and DNS settings for IPv6 addresses."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IppoolIpV6Config IpV6Config {
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
}