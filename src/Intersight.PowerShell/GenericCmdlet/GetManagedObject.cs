using Intersight.Client;
using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;
using System.Management.Automation;
using System.Reflection.Metadata;

namespace Intersight.PowerShell
{
    [Cmdlet(VerbsCommon.Get, "IntersightManagedObject", DefaultParameterSetName = Constants.CmdletParam, SupportsShouldProcess = true)]
    public class GetCmdlet : CmdletBase
    {
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ParameterSetName = Constants.CmdletParam)]
        public string Moid
        {
            get; set;
        }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ParameterSetName = Constants.CmdletParam)]
        public string Name
        {
            get; set;
        }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ParameterSetName = Constants.CmdletParam)]
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ParameterSetName = Constants.QueryParam)]
        //[ValidatePattern("^[a-z][a-z0-9A-Z]*.[A-Z][a-zA-Z0-9]*")]
        public string ObjectType
        {
            get; set;
        }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ParameterSetName = Constants.CmdletParam)]
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ParameterSetName = Constants.QueryParam)]
        [ValidatePattern("^/api/v1/*")]
        public string APIPath
        {
            get; set;
        }

        [Parameter(Mandatory = false, ParameterSetName = Constants.QueryParam)]
        public bool? Count { get; set; } = null;

        [Parameter(Mandatory = false, ParameterSetName = Constants.QueryParam)]
        [ValidateSet("allpages", "none")]
        public string InlineCount { get; set; } = null;

        [Parameter(Mandatory = false, ParameterSetName = Constants.QueryParam)]
        public string Select { get; set; } = null;

        [Parameter(Mandatory = false, ParameterSetName = Constants.QueryParam)]
        public string Filter { get; set; } = null;

        [Parameter(Mandatory = false, ParameterSetName = Constants.QueryParam)]
        public string Expand { get; set; } = null;

        [Parameter(Mandatory = false, ParameterSetName = Constants.QueryParam)]
        public int? Skip { get; set; } = null;

        [Parameter(Mandatory = false, ParameterSetName = Constants.QueryParam)]
        public int? Top { get; set; } = null;

        [Parameter(Mandatory = false, ParameterSetName = Constants.QueryParam)]
        public string At { get; set; } = null;

        [Parameter(Mandatory = false, ParameterSetName = Constants.QueryParam)]
        public string Orderby { get; set; } = null;

        [Parameter(Mandatory = false, ParameterSetName = Constants.QueryParam)]
        public string Apply { get; set; } = null;

        [Parameter(Mandatory = false, ParameterSetName = Constants.QueryParam)]
        public string Tag { get; set; } = null;


        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false)]
        public Dictionary<string, object> AdditionalProperties
        {
            get; set;
        }


        protected override void ProcessRecord()
        {
            PSUtils.CheckMutualExclusiveForObjectTypeAndAPIPath(ObjectType, APIPath);
            // ExecuteRequestAsync(string.Format("/api/v1/{0}",ObjectType));
            if (!ShouldProcess(CmdletBase.Config.BasePath, string.Format("Get {0}", ObjectType)))
            {
                return;
            }

            //Check the objectType in MoBaseMo.ObjectTypeEnum if it belongs to that enum
            //fetch the display name.
            //this is done to work with specific Get cmdlets.
            // Get-IntersightNtpPoicy -Name xxxx | Get-IntersightManagedObject
            var result = PSUtils.GetObjectTypeDisplayName(ObjectType);
            if (!string.IsNullOrEmpty(result))
            {
                ObjectType = result;
            }

            var psClient = new PSHttpClient(CmdletBase.Config);
            psClient.Method = HttpMethod.Get.ToString();
            psClient.BasePath = CmdletBase.Config.BasePath;
            psClient.Path = PSUtils.GetPath(ObjectType, APIPath, VerbsCommon.Get);
            RequestOptions requestOption = new RequestOptions();

            if (ParameterSetName == Constants.CmdletParam)
            {
                string queryStr = string.Empty;
                var index = 0;
                foreach (var item in this.MyInvocation.BoundParameters)
                {
                    if (item.Key == Constants.ObjectType || item.Key == "APIPath")
                    {
                        continue;
                    }
                    if (index != 0)
                    {
                        queryStr += " and ";
                    }
                    queryStr += string.Format("{0} eq \'{1}\'", item.Key, item.Value);
                    index++;
                }

                if (!string.IsNullOrEmpty(queryStr))
                {
                    requestOption.QueryParameters.Add("$filter", queryStr);
                }


            }
            else if (ParameterSetName == Constants.QueryParam)
            {
                foreach (var item in this.MyInvocation.BoundParameters)
                {
                    if (item.Key == Constants.ObjectType)
                    {
                        continue;
                    }

                    requestOption.QueryParameters.Add(string.Concat("$", item.Key.ToLower()), item.Value.ToString());
                }
            }

            var response = psClient.Execute(requestOption);

            if (!string.IsNullOrEmpty(response))
            {
                Dictionary<string, object> responseData = JsonConvert.DeserializeObject<Dictionary<string, object>>(response);
                if (ParameterSetName == Constants.CmdletParam && responseData.ContainsKey(Constants.Results))
                {
                    var moList = JsonConvert.SerializeObject(responseData[Constants.Results], Formatting.Indented);
                    WriteObject(moList);
                }
                else
                {
                    WriteObject(response);
                }

            }
        }
    }
}
