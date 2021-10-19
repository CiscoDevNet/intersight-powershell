using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize FcpoolBlock.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightFcpoolBlock")]
    public class InitializeIntersightFcpoolBlock:PSCmdlet
	{
		public InitializeIntersightFcpoolBlock()
		{
            ClassId = FcpoolBlock.ClassIdEnum.FcpoolBlock;
            ObjectType = FcpoolBlock.ObjectTypeEnum.FcpoolBlock;
            
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
        
        public FcpoolBlock.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Starting WWN identifier of the block must be in hexadecimal format xx:xx:xx:xx:xx:xx:xx:xx. Allowed ranges are 20:00:00:00:00:00:00:00 to 20:FF:FF:FF:FF:FF:FF:FF or from 50:00:00:00:00:00:00:00 to 5F:FF:FF:FF:FF:FF:FF:FF. To ensure uniqueness of WWN's in the SAN fabric, you are strongly encouraged to use the following WWN prefix; 20:00:00:25:B5:xx:xx:xx."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("((^20|5[0-9a-fA-F]{1}):([0-9a-fA-F]{2}:){6}([0-9a-fA-F]{2}))")]
        public string From {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FcpoolBlock.ObjectTypeEnum ObjectType {
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
        /// <para type="description">"Ending WWN identifier of the block must be in hexadecimal format xx:xx:xx:xx:xx:xx:xx:xx."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|((^20|5[0-9a-fA-F]{1}):([0-9a-fA-F]{2}:){6}([0-9a-fA-F]{2}))")]
        public string To {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.FcpoolBlock initObject = new Intersight.Model.FcpoolBlock();
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