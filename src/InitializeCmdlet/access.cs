using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize AccessAddressType.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAccessAddressType")]
    public class InitializeIntersightAccessAddressType:PSCmdlet
	{
		public InitializeIntersightAccessAddressType()
		{
            ClassId = AccessAddressType.ClassIdEnum.AccessAddressType;
            ObjectType = AccessAddressType.ObjectTypeEnum.AccessAddressType;
            
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
        
        public AccessAddressType.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"This flag enables the use of IPv4 address for end-point access."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool EnableIpV4 {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"This flag enables the use of IPv6 address for end-point access."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool EnableIpV6 {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AccessAddressType.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.AccessAddressType initObject = new Intersight.Model.AccessAddressType();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("EnableIpV4"))
            {
                initObject.EnableIpV4 = this.EnableIpV4;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EnableIpV6"))
            {
                initObject.EnableIpV6 = this.EnableIpV6;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize AccessConfigurationType.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAccessConfigurationType")]
    public class InitializeIntersightAccessConfigurationType:PSCmdlet
	{
		public InitializeIntersightAccessConfigurationType()
		{
            ClassId = AccessConfigurationType.ClassIdEnum.AccessConfigurationType;
            ObjectType = AccessConfigurationType.ObjectTypeEnum.AccessConfigurationType;
            
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
        
        public AccessConfigurationType.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"This flag enables the use of In-Band configuration for end-point access."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool ConfigureInband {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"This flag enables the use of Out-Of-Band configuration for end-point access."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool ConfigureOutOfBand {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AccessConfigurationType.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.AccessConfigurationType initObject = new Intersight.Model.AccessConfigurationType();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ConfigureInband"))
            {
                initObject.ConfigureInband = this.ConfigureInband;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ConfigureOutOfBand"))
            {
                initObject.ConfigureOutOfBand = this.ConfigureOutOfBand;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
}