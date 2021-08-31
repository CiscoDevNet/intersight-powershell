using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get SearchTagItem.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightSearchTagItem", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightSearchTagItem:GetCmdletBase
	{
		public GetIntersightSearchTagItem()
		{
			ApiInstance = new SearchApi(Config);
            MethodName = "GetSearchTagItemListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get SearchSearchItem.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightSearchSearchItem", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightSearchSearchItem:GetCmdletBase
	{
		public GetIntersightSearchSearchItem()
		{
			ApiInstance = new SearchApi(Config);
            MethodName = "GetSearchSearchItemListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New SearchSuggestItem.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightSearchSuggestItem")]
    public class NewIntersightSearchSuggestItem:NewCmdletBase
	{
		public NewIntersightSearchSuggestItem()
		{
			ApiInstance = new SearchApi(Config);
            ModelObject = new SearchSuggestItem();
            MethodName = "CreateSearchSuggestItemWithHttpInfo";
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
    }
}