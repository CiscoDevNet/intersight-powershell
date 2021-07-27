using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FcpoolPoolMember.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFcpoolPoolMember", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFcpoolPoolMember:GetCmdletBase
	{
		public GetIntersightFcpoolPoolMember()
		{
			ApiInstance = new FcpoolApi(Config);
            MethodName = "GetFcpoolPoolMemberList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FcpoolPool.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFcpoolPool", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFcpoolPool:GetCmdletBase
	{
		public GetIntersightFcpoolPool()
		{
			ApiInstance = new FcpoolApi(Config);
            MethodName = "GetFcpoolPoolList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FcpoolPool.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFcpoolPool")]
    public class NewIntersightFcpoolPool:NewCmdletBase
	{
		public NewIntersightFcpoolPool()
		{
			ApiInstance = new FcpoolApi(Config);
            ModelObject = new FcpoolPool();
            MethodName = "CreateFcpoolPool";
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
        
        public FcpoolPool.AssignmentOrderEnum AssignmentOrder {
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
        
        public List<FcpoolBlock> IdBlocks {
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
        /// <para type="description">"Purpose of this WWN pool."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string PoolPurpose {
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
    /// <para type="synopsis">This is the cmdlet to Remove FcpoolLease.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFcpoolLease")]
    public class RemoveIntersightFcpoolLease:RemoveCmdletBase
	{
		public RemoveIntersightFcpoolLease()
		{
			ApiInstance = new FcpoolApi(Config);
            MethodName = "DeleteFcpoolLease";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FcpoolFcBlock.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFcpoolFcBlock", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFcpoolFcBlock:GetCmdletBase
	{
		public GetIntersightFcpoolFcBlock()
		{
			ApiInstance = new FcpoolApi(Config);
            MethodName = "GetFcpoolFcBlockList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FcpoolLease.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFcpoolLease", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFcpoolLease:GetCmdletBase
	{
		public GetIntersightFcpoolLease()
		{
			ApiInstance = new FcpoolApi(Config);
            MethodName = "GetFcpoolLeaseList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FcpoolPool.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFcpoolPool")]
    public class SetIntersightFcpoolPool:SetCmdletBase
	{
		public SetIntersightFcpoolPool()
		{
			ApiInstance = new FcpoolApi(Config);
            ModelObject = new FcpoolPool();
            MethodName = "UpdateFcpoolPool";
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
        
        public FcpoolPool.AssignmentOrderEnum AssignmentOrder {
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
        
        public List<FcpoolBlock> IdBlocks {
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
        /// <para type="description">"Purpose of this WWN pool."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string PoolPurpose {
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
    /// <para type="synopsis">This is the cmdlet to Remove FcpoolPool.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFcpoolPool")]
    public class RemoveIntersightFcpoolPool:RemoveCmdletBase
	{
		public RemoveIntersightFcpoolPool()
		{
			ApiInstance = new FcpoolApi(Config);
            MethodName = "DeleteFcpoolPool";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FcpoolUniverse.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFcpoolUniverse", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFcpoolUniverse:GetCmdletBase
	{
		public GetIntersightFcpoolUniverse()
		{
			ApiInstance = new FcpoolApi(Config);
            MethodName = "GetFcpoolUniverseList";
		}
    }
}