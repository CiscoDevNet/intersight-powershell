using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize MacpoolBlock.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightMacpoolBlock")]
    public class InitializeIntersightMacpoolBlock:PSCmdlet
	{
		public InitializeIntersightMacpoolBlock()
		{
            ClassId = MacpoolBlock.ClassIdEnum.MacpoolBlock;
            ObjectType = MacpoolBlock.ObjectTypeEnum.MacpoolBlock;
            
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
        
        public MacpoolBlock.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Starting address of the block must be in hexadecimal format xx:xx:xx:xx:xx:xx. To ensure uniqueness of MACs in the LAN fabric, you are strongly encouraged to use the following MAC prefix 00:25:B5:xx:xx:xx."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string From {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public MacpoolBlock.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Ending address of the block must be in hexadecimal format xx:xx:xx:xx:xx:xx."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string To {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.MacpoolBlock initObject = new Intersight.Model.MacpoolBlock();
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
            if (this.MyInvocation.BoundParameters.ContainsKey("To"))
            {
                initObject.To = this.To;
            }
            WriteObject(initObject);
        }

    }
}