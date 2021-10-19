using Newtonsoft.Json;
using System;
using System.Collections;
using System.Management.Automation;

namespace Intersight.PowerShell
{
    [Cmdlet(VerbsCommon.Set, "IntersightManagedObject")]
    public class SetManagedObject:CmdletBase
    {
        public SetManagedObject()
        {

        }

        [Parameter(Mandatory = true,ValueFromPipelineByPropertyName = true, ParameterSetName = "cmdletParam")]
        public string ObjectType { get; set; }

        [Parameter(Mandatory = true,ValueFromPipelineByPropertyName = true, ParameterSetName = "cmdletParam")]
        public string Moid { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ParameterSetName = "cmdletParam")]
        public Hashtable AdditionalProperties { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ParameterSetName = "jsonData")]
        public string JsonRequestBody { get; set; }

        protected override void ProcessRecord()
        {
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
            PSRequestOptions psRequestOption = new PSRequestOptions
            {
                BasePath = CmdletBase.Config.BasePath,
                Method = "POST",
            };

            if(ParameterSetName == PSUtils.CmdletParam)
            {
                psRequestOption.RequestData = JsonConvert.SerializeObject(AdditionalProperties, Formatting.Indented);
            }
            else
            {
                var tempHashTable = JsonConvert.DeserializeObject<Hashtable>(JsonRequestBody);
                if (tempHashTable.ContainsKey(PSUtils.ObjectType))
                {
                    ObjectType = tempHashTable[PSUtils.ObjectType].ToString();
                }
                else
                {
                    throw new Exception(string.Format("Property {0} is missing in JsonRequestBody", PSUtils.ObjectType));
                }

                if (tempHashTable.ContainsKey(PSUtils.Moid))
                {
                    Moid = tempHashTable[PSUtils.Moid].ToString();
                }
                else
                {
                    throw new Exception(string.Format("Property {0} is missing in JsonRequestBody", PSUtils.Moid));
                }

                psRequestOption.RequestData = JsonRequestBody;
            }

            psRequestOption.PathParameters.Add(PSUtils.Moid, Moid);
            psRequestOption.Path = string.Format("/api/v1/{0}/{{Moid}}", PSUtils.GetPath(ObjectType));
            var response = psClient.Execute(psRequestOption);
            WriteObject(response);
        }
    }
}
