using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get MacpoolUniverse.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightMacpoolUniverse", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightMacpoolUniverse:GetCmdletBase
	{
		public GetIntersightMacpoolUniverse()
		{
			ApiInstance = new MacpoolApi(Config);
            MethodName = "GetMacpoolUniverseList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set MacpoolPool.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightMacpoolPool")]
    public class SetIntersightMacpoolPool:SetCmdletBase
	{
		public SetIntersightMacpoolPool()
		{
			ApiInstance = new MacpoolApi(Config);
            ModelObject = new MacpoolPool();
            MethodName = "UpdateMacpoolPool";
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
        
        public MacpoolPool.AssignmentOrderEnum AssignmentOrder {
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
        
        public List<MacpoolBlock> MacBlocks {
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
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove MacpoolPool.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightMacpoolPool")]
    public class RemoveIntersightMacpoolPool:RemoveCmdletBase
	{
		public RemoveIntersightMacpoolPool()
		{
			ApiInstance = new MacpoolApi(Config);
            MethodName = "DeleteMacpoolPool";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get MacpoolLease.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightMacpoolLease", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightMacpoolLease:GetCmdletBase
	{
		public GetIntersightMacpoolLease()
		{
			ApiInstance = new MacpoolApi(Config);
            MethodName = "GetMacpoolLeaseList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get MacpoolPoolMember.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightMacpoolPoolMember", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightMacpoolPoolMember:GetCmdletBase
	{
		public GetIntersightMacpoolPoolMember()
		{
			ApiInstance = new MacpoolApi(Config);
            MethodName = "GetMacpoolPoolMemberList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove MacpoolLease.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightMacpoolLease")]
    public class RemoveIntersightMacpoolLease:RemoveCmdletBase
	{
		public RemoveIntersightMacpoolLease()
		{
			ApiInstance = new MacpoolApi(Config);
            MethodName = "DeleteMacpoolLease";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get MacpoolPool.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightMacpoolPool", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightMacpoolPool:GetCmdletBase
	{
		public GetIntersightMacpoolPool()
		{
			ApiInstance = new MacpoolApi(Config);
            MethodName = "GetMacpoolPoolList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New MacpoolPool.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightMacpoolPool")]
    public class NewIntersightMacpoolPool:NewCmdletBase
	{
		public NewIntersightMacpoolPool()
		{
			ApiInstance = new MacpoolApi(Config);
            ModelObject = new MacpoolPool();
            MethodName = "CreateMacpoolPool";
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
        
        public MacpoolPool.AssignmentOrderEnum AssignmentOrder {
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
        
        public List<MacpoolBlock> MacBlocks {
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
    /// <para type="synopsis">This is the cmdlet to Get MacpoolIdBlock.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightMacpoolIdBlock", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightMacpoolIdBlock:GetCmdletBase
	{
		public GetIntersightMacpoolIdBlock()
		{
			ApiInstance = new MacpoolApi(Config);
            MethodName = "GetMacpoolIdBlockList";
		}
    }
}