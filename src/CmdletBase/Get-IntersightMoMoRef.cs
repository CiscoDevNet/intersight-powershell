using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;
using Intersight.Model;
namespace Intersight.PowerShell
{
    [Cmdlet(VerbsCommon.Get,"IntersightMoMoRef")]
   public class Get_IntersightMoMoRef:PSCmdlet
    {
        [Parameter(Mandatory = true,ValueFromPipelineByPropertyName = true,ValueFromPipeline = true)]
        [ValidateNotNull()]
        public MoBaseMo ManagedObject { get; set; }

        protected override void ProcessRecord()
        {
            if (ManagedObject != null)
            {
                MoMoRef moRef = new MoMoRef();
                moRef.Moid = ManagedObject.Moid;
               object result;
                if(Enum.TryParse(typeof(MoMoRef.ObjectTypeEnum), ManagedObject.GetType().Name, out result))
                {
                    moRef.ObjectType = (MoMoRef.ObjectTypeEnum)result;
                }
                WriteObject(moRef);
            }
        }
    }
}
