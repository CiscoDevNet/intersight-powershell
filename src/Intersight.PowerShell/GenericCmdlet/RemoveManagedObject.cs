using Intersight.Client;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;

namespace Intersight.PowerShell
{
    [Cmdlet(VerbsCommon.Remove, "IntersightManagedObject")]
    public class RemoveManagedObject : CmdletBase
    {
        public RemoveManagedObject()
        {

        }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true)]
        public string Moid { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true)]
        public string ObjectType { get; set; }

        protected override void ProcessRecord()
        {
            //Check the objectType in MoBaseMo.ObjectTypeEnum if it belongs to that enum
            //fetch the display name.
            //this is done to work with specific Get cmdlets.
            // Get-IntersightNtpPoicy -Name xxxx | Remove-IntersightManagedObject
            var result = PSUtils.GetObjectTypeDisplayName(ObjectType);
            if (!string.IsNullOrEmpty(result))
            {
                ObjectType = result;
            }

            var psClient = new PSHttpClient(CmdletBase.Config);
            RequestOptions requestOption = new RequestOptions();

            psClient.BasePath = CmdletBase.Config.BasePath;
            psClient.Path = string.Format("/api/v1/{0}/{{Moid}}", PSUtils.GetPath(ObjectType));
            psClient.Method = "Delete";
            requestOption.PathParameters.Add(PSUtils.Moid, Moid);
            var response = psClient.Execute(requestOption);
            WriteObject(response);
        }
    }
}
