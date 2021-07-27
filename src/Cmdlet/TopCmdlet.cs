using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set TopSystem.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightTopSystem")]
    public class SetIntersightTopSystem:SetCmdletBase
	{
		public SetIntersightTopSystem()
		{
			ApiInstance = new TopApi(Config);
            ModelObject = new TopSystem();
            MethodName = "UpdateTopSystem";
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
        /// <para type="description">"An array of relationships to computeBlade resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<ComputeBladeRelationship> ComputeBlades {
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
        /// <para type="description">"An array of relationships to networkElement resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<NetworkElementRelationship> NetworkElements {
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
        /// <para type="description">"The operational timezone of the system, empty indicates no timezone has been set specifically."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string TimeZone {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get TopSystem.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightTopSystem", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightTopSystem:GetCmdletBase
	{
		public GetIntersightTopSystem()
		{
			ApiInstance = new TopApi(Config);
            MethodName = "GetTopSystemList";
		}
    }
}