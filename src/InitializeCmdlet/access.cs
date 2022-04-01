using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize AccessPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAccessPolicy")]
    public class InitializeIntersightAccessPolicy:PSCmdlet
	{
		public InitializeIntersightAccessPolicy()
		{
            ClassId = AccessPolicy.ClassIdEnum.AccessPolicy;
            ObjectType = AccessPolicy.ObjectTypeEnum.AccessPolicy;
            
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
        /// <para type="description">"The type of address to be retrieved from Inband IP Pool object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.AccessAddressType AddressType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AccessPolicy.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The type of configuration, In-Band and/or Out-Of-Band to be configured on the CIMC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.AccessConfigurationType ConfigurationType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a ippoolPool resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.IppoolPoolRelationship InbandIpPool {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"VLAN to be used for server access over Inband network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(4, 4093)]
        public long InbandVlan {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a vrfVrf resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.VrfVrfRelationship InbandVrf {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AccessPolicy.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.OrganizationOrganizationRelationship Organization {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a ippoolPool resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.IppoolPoolRelationship OutOfBandIpPool {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a vrfVrf resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.VrfVrfRelationship OutOfBandVrf {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to policyAbstractConfigProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Model.PolicyAbstractConfigProfileRelationship> Profiles {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Model.MoTag> Tags {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.AccessPolicy initObject = new Intersight.Model.AccessPolicy();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AddressType"))
            {
                initObject.AddressType = this.AddressType;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ConfigurationType"))
            {
                initObject.ConfigurationType = this.ConfigurationType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InbandIpPool"))
            {
                initObject.InbandIpPool = this.InbandIpPool;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InbandVlan"))
            {
                initObject.InbandVlan = this.InbandVlan;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InbandVrf"))
            {
                initObject.InbandVrf = this.InbandVrf;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Organization"))
            {
                initObject.Organization = this.Organization;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("OutOfBandIpPool"))
            {
                initObject.OutOfBandIpPool = this.OutOfBandIpPool;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("OutOfBandVrf"))
            {
                initObject.OutOfBandVrf = this.OutOfBandVrf;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Profiles"))
            {
                initObject.Profiles = this.Profiles;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
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