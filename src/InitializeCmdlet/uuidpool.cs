using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize UuidpoolUuidBlock.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightUuidpoolUuidBlock")]
    public class InitializeIntersightUuidpoolUuidBlock:PSCmdlet
	{
		public InitializeIntersightUuidpoolUuidBlock()
		{
            ClassId = UuidpoolUuidBlock.ClassIdEnum.UuidpoolUuidBlock;
            ObjectType = UuidpoolUuidBlock.ObjectTypeEnum.UuidpoolUuidBlock;
            
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public UuidpoolUuidBlock.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Starting UUID suffix of the block must be in hexadecimal format xxxx-xxxxxxxxxxxx."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-fA-F0-9]{4}-[a-fA-F0-9]{12}$")]
        public string From {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public UuidpoolUuidBlock.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of identifiers this block can hold."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1, 1000)]
        public long Size {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Starting UUID suffix of the block must be in hexadecimal format xxxx-xxxxxxxxxxxx."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-fA-F0-9]{4}-[a-fA-F0-9]{12}$")]
        public string To {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.UuidpoolUuidBlock initObject = new Intersight.Model.UuidpoolUuidBlock();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("From"))
            {
                initObject.From = this.From;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Size"))
            {
                initObject.Size = this.Size;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("To"))
            {
                initObject.To = this.To;
            }
            WriteObject(initObject);
        }

    }
}