using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set ForecastInstance.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightForecastInstance")]
    public class SetIntersightForecastInstance:SetCmdletBase
	{
		public SetIntersightForecastInstance()
		{
			ApiInstance = new ForecastApi(Config);
            ModelObject = new ForecastInstance();
            MethodName = "PatchForecastInstanceWithHttpInfo";
		}
        // <summary>
        /// <para type="description">"Action to be triggered on forecast instance. Default value is None.\n* `None` - The Enum value None represents that no action is triggered on the forecast Instance managed object.\n* `Evaluate` - The Enum value Evaluate represents that a re-evaluation of the forecast needs to be triggered."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ForecastInstance.ActionEnum Action {
            get;
            set;
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<decimal> AltModel {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The time interval (in days) for the data to be used for computing forecast model."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(60, 365)]
        public long DataInterval {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The start date from when the data should be used for computing forecast model."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public DateTime DataStartDate {
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
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get ForecastDefinition.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightForecastDefinition", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightForecastDefinition:GetCmdletBase
	{
		public GetIntersightForecastDefinition()
		{
			ApiInstance = new ForecastApi(Config);
            MethodName = "GetForecastDefinitionListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get ForecastInstance.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightForecastInstance", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightForecastInstance:GetCmdletBase
	{
		public GetIntersightForecastInstance()
		{
			ApiInstance = new ForecastApi(Config);
            MethodName = "GetForecastInstanceListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get ForecastCatalog.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightForecastCatalog", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightForecastCatalog:GetCmdletBase
	{
		public GetIntersightForecastCatalog()
		{
			ApiInstance = new ForecastApi(Config);
            MethodName = "GetForecastCatalogListWithHttpInfo";
		}
    }
}