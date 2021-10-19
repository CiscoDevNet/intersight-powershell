using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;
using System.Management.Automation;

namespace Intersight.PowerShell
{
    [Cmdlet(VerbsCommon.Get, "IntersightManagedObject",DefaultParameterSetName = "CmdletParam")]
    public class GetCmdlet : GetCmdletBase
    {
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ParameterSetName = "CmdletParam")]
        public string Moid
        {
            get; set;
        }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ParameterSetName = "CmdletParam")]
        public string Name
        {
            get; set;
        }

        [Parameter(Mandatory = true,ValueFromPipelineByPropertyName = true, ParameterSetName = "CmdletParam")]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ParameterSetName = "QueryParam")]
        //[ValidatePattern("^[a-z][a-z0-9A-Z]*.[A-Z][a-zA-Z0-9]*")]
        public string ObjectType
        {
            get;set;
        }

        [Parameter(Mandatory = false,ValueFromPipelineByPropertyName = false)]
        public Dictionary<string,object> AdditionalProperties
        {
            get;set;
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
            PSRequestOptions psRequestOption = new PSRequestOptions
            {
                BasePath = CmdletBase.Config.BasePath,
                Path = string.Format("/api/v1/{0}", PSUtils.GetPath(ObjectType)),
                Method = "Get",
            };

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
                    if(index != 0)
                    {
                        queryStr += " and ";
                    }
                    queryStr += string.Format("{0} eq \'{1}\'", item.Key,item.Value);
                    index++;
                }

                if (!string.IsNullOrEmpty(queryStr))
                {
                    psRequestOption.QueryParameters.Add("$filter", queryStr);
                }

                
            }
            else if (ParameterSetName == "QueryParam")
            {
                foreach(var item in this.MyInvocation.BoundParameters)
                {
                    if (item.Key == "ObjectType")
                    {
                        continue;
                    }

                    psRequestOption.QueryParameters.Add(string.Concat("$", item.Key.ToLower()), item.Value.ToString());
                }    
            }
            
            var response = psClient.Execute(psRequestOption);

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
