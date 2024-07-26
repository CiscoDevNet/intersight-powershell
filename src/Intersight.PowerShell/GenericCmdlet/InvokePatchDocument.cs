﻿using Intersight.Client;
using Intersight.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Runtime.Serialization;
using System.Text;

namespace Intersight.PowerShell
{
    [Cmdlet(VerbsLifecycle.Invoke, "IntersightPatchDocument")]
    public class InvokePatchDocument : CmdletBase
    {
        public InvokePatchDocument()
        {

        }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true)]
        public string Moid
        {
            get; set;
        }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true)]
        public string ObjectType
        {
            get; set;
        }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ParameterSetName = "jsonData")]
        public string JsonPatchDocument
        {
            get; set;
        }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ParameterSetName = "cmdletParam")]
        public List<PatchDocument> PatchDocument
        {
            get; set;
        }

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
            RequestOptions requestOption = new RequestOptions();
            psClient.BasePath = CmdletBase.Config.BasePath;
            psClient.Method = "PATCH";
            psClient.ContentType = "application/json-patch+json";

            if (ParameterSetName == PSUtils.CmdletParam)
            {
                requestOption.Data = PatchDocument;
            }
            else
            {
                var tempHashTable = JsonConvert.DeserializeObject<List<PatchDocument>>(JsonPatchDocument);
                requestOption.Data = tempHashTable;
            }

            requestOption.PathParameters.Add(PSUtils.Moid, Moid);
            psClient.Path = string.Format("/api/v1/{0}/{{Moid}}", PSUtils.GetPath(ObjectType));
            var response = psClient.Execute(requestOption);
            WriteObject(response);
        }

    }
}
