using Intersight.Client;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;

namespace Intersight.PowerShell
{
    [Cmdlet(VerbsCommon.Remove, "IntersightManagedObject", DefaultParameterSetName = Constants.CmdletParam, SupportsShouldProcess = true)]
    public class RemoveManagedObject : CmdletBase
    {
        public RemoveManagedObject()
        {

        }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true)]
        public string Moid { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ParameterSetName = Constants.JsonData)]
        [ValidatePattern("^/api/v1/*")]
        public string APIPath
        {
            get; set;
        }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ParameterSetName = Constants.CmdletParam)]
        public string ObjectType { get; set; }

        protected override void ProcessRecord()
        {

            if (!ShouldProcess(CmdletBase.Config.BasePath, string.Format("Delete {0} : Moid {1}", ObjectType, Moid)))
            {
                return;
            }
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
            psClient.Path = PSUtils.GetPath(ObjectType, APIPath, VerbsCommon.Remove);
            psClient.Method = HttpMethod.Delete.ToString(); ;
            requestOption.PathParameters.Add(Constants.Moid, Moid);
            var response = psClient.Execute(requestOption);
            WriteObject(response);
        }
    }
}
