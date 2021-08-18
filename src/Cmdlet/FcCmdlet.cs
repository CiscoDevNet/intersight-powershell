using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FcPortChannel.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFcPortChannel", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFcPortChannel:GetCmdletBase
	{
		public GetIntersightFcPortChannel()
		{
			ApiInstance = new FcApi(Config);
            MethodName = "GetFcPortChannelListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FcPhysicalPort.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFcPhysicalPort", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFcPhysicalPort:GetCmdletBase
	{
		public GetIntersightFcPhysicalPort()
		{
			ApiInstance = new FcApi(Config);
            MethodName = "GetFcPhysicalPortListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FcPhysicalPort.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFcPhysicalPort")]
    public class SetIntersightFcPhysicalPort:SetCmdletBase
	{
		public SetIntersightFcPhysicalPort()
		{
			ApiInstance = new FcApi(Config);
            ModelObject = new FcPhysicalPort();
            MethodName = "UpdateFcPhysicalPortWithHttpInfo";
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