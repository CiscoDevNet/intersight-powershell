using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get IqnpoolLease.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightIqnpoolLease", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightIqnpoolLease:GetCmdletBase
	{
		public GetIntersightIqnpoolLease()
		{
			ApiInstance = new IqnpoolApi(Config);
            MethodName = "GetIqnpoolLeaseListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set IqnpoolPool.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightIqnpoolPool")]
    public class SetIntersightIqnpoolPool:SetCmdletBase
	{
		public SetIntersightIqnpoolPool()
		{
			ApiInstance = new IqnpoolApi(Config);
            ModelObject = new IqnpoolPool();
            MethodName = "PatchIqnpoolPoolWithHttpInfo";
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
        
        public IqnpoolPool.AssignmentOrderEnum AssignmentOrder {
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
        
        public List<IqnpoolIqnSuffixBlock> IqnSuffixBlocks {
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
        /// <para type="description">"The prefix for any IQN blocks created for this pool. IQN Prefix must have the following format \"iqn.yyyy-mm.naming-authority\", where naming-authority is usually the reverse syntax of the Internet domain name of the naming authority."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Prefix {
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
    /// <para type="synopsis">This is the cmdlet to Remove IqnpoolPool.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightIqnpoolPool")]
    public class RemoveIntersightIqnpoolPool:RemoveCmdletBase
	{
		public RemoveIntersightIqnpoolPool()
		{
			ApiInstance = new IqnpoolApi(Config);
            MethodName = "DeleteIqnpoolPoolWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove IqnpoolLease.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightIqnpoolLease")]
    public class RemoveIntersightIqnpoolLease:RemoveCmdletBase
	{
		public RemoveIntersightIqnpoolLease()
		{
			ApiInstance = new IqnpoolApi(Config);
            MethodName = "DeleteIqnpoolLeaseWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New IqnpoolPool.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightIqnpoolPool")]
    public class NewIntersightIqnpoolPool:NewCmdletBase
	{
		public NewIntersightIqnpoolPool()
		{
			ApiInstance = new IqnpoolApi(Config);
            ModelObject = new IqnpoolPool();
            MethodName = "CreateIqnpoolPoolWithHttpInfo";
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
        
        public IqnpoolPool.AssignmentOrderEnum AssignmentOrder {
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
        
        public List<IqnpoolIqnSuffixBlock> IqnSuffixBlocks {
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
        /// <para type="description">"The prefix for any IQN blocks created for this pool. IQN Prefix must have the following format \"iqn.yyyy-mm.naming-authority\", where naming-authority is usually the reverse syntax of the Internet domain name of the naming authority."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Prefix {
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
    /// <para type="synopsis">This is the cmdlet to Get IqnpoolPool.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightIqnpoolPool", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightIqnpoolPool:GetCmdletBase
	{
		public GetIntersightIqnpoolPool()
		{
			ApiInstance = new IqnpoolApi(Config);
            MethodName = "GetIqnpoolPoolListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get IqnpoolUniverse.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightIqnpoolUniverse", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightIqnpoolUniverse:GetCmdletBase
	{
		public GetIntersightIqnpoolUniverse()
		{
			ApiInstance = new IqnpoolApi(Config);
            MethodName = "GetIqnpoolUniverseListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get IqnpoolPoolMember.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightIqnpoolPoolMember", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightIqnpoolPoolMember:GetCmdletBase
	{
		public GetIntersightIqnpoolPoolMember()
		{
			ApiInstance = new IqnpoolApi(Config);
            MethodName = "GetIqnpoolPoolMemberListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get IqnpoolBlock.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightIqnpoolBlock", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightIqnpoolBlock:GetCmdletBase
	{
		public GetIntersightIqnpoolBlock()
		{
			ApiInstance = new IqnpoolApi(Config);
            MethodName = "GetIqnpoolBlockListWithHttpInfo";
		}
    }
}