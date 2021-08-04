using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New UuidpoolPool.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightUuidpoolPool")]
    public class NewIntersightUuidpoolPool:NewCmdletBase
	{
		public NewIntersightUuidpoolPool()
		{
			ApiInstance = new UuidpoolApi(Config);
            ModelObject = new UuidpoolPool();
            MethodName = "CreateUuidpoolPoolWithHttpInfo";
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
        
        public UuidpoolPool.AssignmentOrderEnum AssignmentOrder {
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
        /// <para type="description">"The UUID prefix must be in hexadecimal format xxxxxxxx-xxxx-xxxx."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}$")]
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
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<UuidpoolUuidBlock> UuidSuffixBlocks {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get UuidpoolPool.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightUuidpoolPool", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightUuidpoolPool:GetCmdletBase
	{
		public GetIntersightUuidpoolPool()
		{
			ApiInstance = new UuidpoolApi(Config);
            MethodName = "GetUuidpoolPoolListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get UuidpoolPoolMember.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightUuidpoolPoolMember", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightUuidpoolPoolMember:GetCmdletBase
	{
		public GetIntersightUuidpoolPoolMember()
		{
			ApiInstance = new UuidpoolApi(Config);
            MethodName = "GetUuidpoolPoolMemberListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get UuidpoolBlock.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightUuidpoolBlock", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightUuidpoolBlock:GetCmdletBase
	{
		public GetIntersightUuidpoolBlock()
		{
			ApiInstance = new UuidpoolApi(Config);
            MethodName = "GetUuidpoolBlockListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get UuidpoolUuidLease.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightUuidpoolUuidLease", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightUuidpoolUuidLease:GetCmdletBase
	{
		public GetIntersightUuidpoolUuidLease()
		{
			ApiInstance = new UuidpoolApi(Config);
            MethodName = "GetUuidpoolUuidLeaseListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get UuidpoolUniverse.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightUuidpoolUniverse", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightUuidpoolUniverse:GetCmdletBase
	{
		public GetIntersightUuidpoolUniverse()
		{
			ApiInstance = new UuidpoolApi(Config);
            MethodName = "GetUuidpoolUniverseListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove UuidpoolUuidLease.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightUuidpoolUuidLease")]
    public class RemoveIntersightUuidpoolUuidLease:RemoveCmdletBase
	{
		public RemoveIntersightUuidpoolUuidLease()
		{
			ApiInstance = new UuidpoolApi(Config);
            MethodName = "DeleteUuidpoolUuidLeaseWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set UuidpoolPool.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightUuidpoolPool")]
    public class SetIntersightUuidpoolPool:SetCmdletBase
	{
		public SetIntersightUuidpoolPool()
		{
			ApiInstance = new UuidpoolApi(Config);
            ModelObject = new UuidpoolPool();
            MethodName = "UpdateUuidpoolPoolWithHttpInfo";
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
        
        public UuidpoolPool.AssignmentOrderEnum AssignmentOrder {
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
        /// <para type="description">"The UUID prefix must be in hexadecimal format xxxxxxxx-xxxx-xxxx."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}$")]
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
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<UuidpoolUuidBlock> UuidSuffixBlocks {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove UuidpoolPool.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightUuidpoolPool")]
    public class RemoveIntersightUuidpoolPool:RemoveCmdletBase
	{
		public RemoveIntersightUuidpoolPool()
		{
			ApiInstance = new UuidpoolApi(Config);
            MethodName = "DeleteUuidpoolPoolWithHttpInfo";
		}
    }
}