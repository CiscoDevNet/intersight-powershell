﻿using Intersight.Client;
using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;
using System.Management.Automation;

namespace Intersight.PowerShell
{
    [Cmdlet(VerbsCommon.Get, "IntersightManagedObject", DefaultParameterSetName = "CmdletParam")]
    public class GetCmdlet : CmdletBase
    {
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ParameterSetName = "CmdletParam")]
        public string Moid
        {
            get; set;
        }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ParameterSetName = "CmdletParam")]
        public string Name
        {
            get; set;
        }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ParameterSetName = "CmdletParam")]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ParameterSetName = "QueryParam")]
        //[ValidatePattern("^[a-z][a-z0-9A-Z]*.[A-Z][a-zA-Z0-9]*")]
        public string ObjectType
        {
            get; set;
        }

        [Parameter(Mandatory = false, ParameterSetName = "QueryParam")]
        public bool? Count { get; set; } = null;

        [Parameter(Mandatory = false, ParameterSetName = "QueryParam")]
        [ValidateSet("allpages", "none")]
        public string InlineCount { get; set; } = null;

        [Parameter(Mandatory = false, ParameterSetName = "QueryParam")]
        public string Select { get; set; } = null;

        [Parameter(Mandatory = false, ParameterSetName = "QueryParam")]
        public string Filter { get; set; } = null;

        [Parameter(Mandatory = false, ParameterSetName = "QueryParam")]
        public string Expand { get; set; } = null;

        [Parameter(Mandatory = false, ParameterSetName = "QueryParam")]
        public int? Skip { get; set; } = null;

        [Parameter(Mandatory = false, ParameterSetName = "QueryParam")]
        public int? Top { get; set; } = null;

        [Parameter(Mandatory = false, ParameterSetName = "QueryParam")]
        public string At { get; set; } = null;

        [Parameter(Mandatory = false, ParameterSetName = "QueryParam")]
        public string Orderby { get; set; } = null;

        [Parameter(Mandatory = false, ParameterSetName = "QueryParam")]
        public string Apply { get; set; } = null;

        [Parameter(Mandatory = false, ParameterSetName = "QueryParam")]
        public string Tag { get; set; } = null;


        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false)]
        public Dictionary<string, object> AdditionalProperties
        {
            get; set;
        }


        protected override void ProcessRecord()
        {
            // ExecuteRequestAsync(string.Format("/api/v1/{0}",ObjectType));

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
            psClient.Method = "Get";
            psClient.BasePath = CmdletBase.Config.BasePath;
            psClient.Path = string.Format("/api/v1/{0}", PSUtils.GetPath(ObjectType));
            RequestOptions requestOption = new RequestOptions();

            if (ParameterSetName == "CmdletParam")
            {
                string queryStr = string.Empty;
                var index = 0;
                foreach (var item in this.MyInvocation.BoundParameters)
                {
                    if (item.Key == "ObjectType")
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
            else if (ParameterSetName == "QueryParam")
            {
                foreach (var item in this.MyInvocation.BoundParameters)
                {
                    if (item.Key == "ObjectType")
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
                if (ParameterSetName == "CmdletParam" && responseData.ContainsKey("Results"))
                {
                    var moList = JsonConvert.SerializeObject(responseData["Results"], Formatting.Indented);
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
