using Intersight.Client;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Management.Automation;


namespace Intersight.PowerShell
{
    [Cmdlet(VerbsCommon.Set, "IntersightManagedObject", DefaultParameterSetName = Constants.CmdletParam, SupportsShouldProcess = true)]
    public class SetManagedObject : CmdletBase
    {
        public SetManagedObject()
        {

        }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ParameterSetName = Constants.CmdletParam)]
        public string ObjectType { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ParameterSetName = Constants.CmdletParam)]
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ParameterSetName = Constants.JsonData)]
        [ValidatePattern("^/api/v1/*")]
        public string APIPath
        {
            get; set;
        }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ParameterSetName = Constants.CmdletParam)]
        public string Moid { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ParameterSetName = Constants.CmdletParam)]
        public Hashtable AdditionalProperties { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ParameterSetName = Constants.JsonData)]
        public string JsonRequestBody { get; set; }

        protected override void ProcessRecord()
        {
            if (!ShouldProcess(CmdletBase.Config.BasePath, string.Format("Update {0} : Moid {1}", ObjectType, Moid)))
            {
                return;
            }
            //Check the objectType in MoBaseMo.ObjectTypeEnum if it belongs to that enum
            //fetch the display name.
            //this is done to work with specific Get cmdlets.
            // Get-IntersightNtpPoicy -Name xxxx | Set-IntersightManagedObject
            var result = PSUtils.GetObjectTypeDisplayName(ObjectType);
            if (!string.IsNullOrEmpty(result))
            {
                ObjectType = result;
            }

            var psClient = new PSHttpClient(CmdletBase.Config);
            RequestOptions requestOption = new RequestOptions();

            psClient.BasePath = CmdletBase.Config.BasePath;
            psClient.Method = HttpMethod.Post.ToString();

            if (ParameterSetName == Constants.CmdletParam)
            {
                requestOption.Data = AdditionalProperties;
            }
            else
            {
                var tempHashTable = JsonConvert.DeserializeObject<Hashtable>(JsonRequestBody);
                if (tempHashTable.ContainsKey(Constants.ObjectType))
                {
                    ObjectType = tempHashTable[Constants.ObjectType].ToString();
                }
                else
                {
                    throw new Exception(string.Format("Property {0} is missing in JsonRequestBody", Constants.ObjectType));
                }

                if (tempHashTable.ContainsKey(Constants.Moid))
                {
                    Moid = tempHashTable[Constants.Moid].ToString();
                }
                else
                {
                    throw new Exception(string.Format("Property {0} is missing in JsonRequestBody", Constants.Moid));
                }

                requestOption.Data = tempHashTable;
            }

            requestOption.PathParameters.Add(Constants.Moid, Moid);
            psClient.Path = PSUtils.GetPath(ObjectType, APIPath, VerbsCommon.Set);
            var response = psClient.Execute(requestOption);
            WriteObject(response);
        }
    }
}
