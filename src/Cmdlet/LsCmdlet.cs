using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get LsServiceProfile.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightLsServiceProfile", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightLsServiceProfile:GetCmdletBase
	{
		public GetIntersightLsServiceProfile()
		{
			ApiInstance = new LsApi(Config);
            MethodName = "GetLsServiceProfileListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set LsServiceProfile.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightLsServiceProfile")]
    public class SetIntersightLsServiceProfile:SetCmdletBase
	{
		public SetIntersightLsServiceProfile()
		{
			ApiInstance = new LsApi(Config);
            ModelObject = new LsServiceProfile();
            MethodName = "UpdateLsServiceProfileWithHttpInfo";
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