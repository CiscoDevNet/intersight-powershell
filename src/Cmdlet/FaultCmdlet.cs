using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FaultInstance.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFaultInstance", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFaultInstance:GetCmdletBase
	{
		public GetIntersightFaultInstance()
		{
			ApiInstance = new FaultApi(Config);
            MethodName = "GetFaultInstanceList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FaultInstance.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFaultInstance")]
    public class SetIntersightFaultInstance:SetCmdletBase
	{
		public SetIntersightFaultInstance()
		{
			ApiInstance = new FaultApi(Config);
            ModelObject = new FaultInstance();
            MethodName = "UpdateFaultInstance";
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
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
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