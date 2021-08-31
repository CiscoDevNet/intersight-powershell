using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get RecommendationCapacityRunway.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightRecommendationCapacityRunway", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightRecommendationCapacityRunway:GetCmdletBase
	{
		public GetIntersightRecommendationCapacityRunway()
		{
			ApiInstance = new RecommendationApi(Config);
            MethodName = "GetRecommendationCapacityRunwayListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get RecommendationPhysicalItem.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightRecommendationPhysicalItem", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightRecommendationPhysicalItem:GetCmdletBase
	{
		public GetIntersightRecommendationPhysicalItem()
		{
			ApiInstance = new RecommendationApi(Config);
            MethodName = "GetRecommendationPhysicalItemListWithHttpInfo";
		}
    }
}