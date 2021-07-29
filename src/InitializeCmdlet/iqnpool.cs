using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IqnpoolIqnSuffixBlock.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIqnpoolIqnSuffixBlock")]
    public class InitializeIntersightIqnpoolIqnSuffixBlock:PSCmdlet
	{
		public InitializeIntersightIqnpoolIqnSuffixBlock()
		{
            ClassId = IqnpoolIqnSuffixBlock.ClassIdEnum.IqnpoolIqnSuffixBlock;
            ObjectType = IqnpoolIqnSuffixBlock.ObjectTypeEnum.IqnpoolIqnSuffixBlock;
            
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
        
        public IqnpoolIqnSuffixBlock.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IqnpoolIqnSuffixBlock.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The suffix for this bock of IQNs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Suffix {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.IqnpoolIqnSuffixBlock initObject = new Intersight.Model.IqnpoolIqnSuffixBlock();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Suffix"))
            {
                initObject.Suffix = this.Suffix;
            }
            WriteObject(initObject);
        }

    }
}