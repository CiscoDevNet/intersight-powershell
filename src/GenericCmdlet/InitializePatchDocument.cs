using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;
using Intersight.Model;

namespace Intersight.PowerShell.GenericCmdlet
{
    [Cmdlet(VerbsData.Initialize, "IntersightPatchDocument")]
    public class InitializePatchDocument : PSCmdlet
    {
        public InitializePatchDocument()
        {

        }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true)]
        //[ValidateSet("add","replace","test","remove")]
        public PatchDocument.OpEnum Op
        {
            get; set;
        }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true)]
        public string Path
        {
            get; set;
        }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true)]
        public object Value
        {
            get; set;
        }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true)]
        public string From
        {
            get; set;
        }

        protected override void ProcessRecord()
        {
            var patchDoc = new PatchDocument(Op, Path, Value);
            patchDoc.Op = this.Op;
            patchDoc.Path = this.Path;
            patchDoc.Value = this.Value;
            if (!string.IsNullOrEmpty(From))
            {
                patchDoc.From = From;
            }
            WriteObject(patchDoc);
        }
    }
}
