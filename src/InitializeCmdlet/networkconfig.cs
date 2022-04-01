using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NetworkconfigPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNetworkconfigPolicy")]
    public class InitializeIntersightNetworkconfigPolicy : PSCmdlet
    {
        public InitializeIntersightNetworkconfigPolicy()
        {
            ClassId = NetworkconfigPolicy.ClassIdEnum.NetworkconfigPolicy;
            ObjectType = NetworkconfigPolicy.ObjectTypeEnum.NetworkconfigPolicy;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"IP address of the secondary DNS server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string AlternateIpv4dnsServer
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"IP address of the secondary DNS server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string AlternateIpv6dnsServer
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a iamAccount resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IamAccountRelationship ApplianceAccount
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public NetworkconfigPolicy.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The domain name appended to a hostname for a Dynamic DNS (DDNS) update. If left blank, only a hostname is sent to the DDNS update request."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+([-.]{1}[a-zA-Z0-9]+)*$")]
        public string DynamicDnsDomain
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"If enabled, updates the resource records to the DNS from Cisco IMC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool EnableDynamicDns
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"If enabled, Cisco IMC retrieves the DNS server addresses from DHCP. Use DHCP field must be enabled for IPv4 in Cisco IMC to enable it."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool EnableIpv4dnsFromDhcp
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"If enabled, allows to configure IPv6 properties."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool EnableIpv6
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"If enabled, Cisco IMC retrieves the DNS server addresses from DHCP. Use DHCP field must be enabled for IPv6 in Cisco IMC to enable it."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool EnableIpv6dnsFromDhcp
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public NetworkconfigPolicy.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.OrganizationOrganizationRelationship Organization
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"IP address of the primary DNS server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string PreferredIpv4dnsServer
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"IP address of the primary DNS server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string PreferredIpv6dnsServer
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to policyAbstractConfigProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.PolicyAbstractConfigProfileRelationship> Profiles
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.NetworkconfigPolicy initObject = new Intersight.Model.NetworkconfigPolicy();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AlternateIpv4dnsServer"))
            {
                initObject.AlternateIpv4dnsServer = this.AlternateIpv4dnsServer;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AlternateIpv6dnsServer"))
            {
                initObject.AlternateIpv6dnsServer = this.AlternateIpv6dnsServer;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ApplianceAccount"))
            {
                initObject.ApplianceAccount = this.ApplianceAccount;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DynamicDnsDomain"))
            {
                initObject.DynamicDnsDomain = this.DynamicDnsDomain;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EnableDynamicDns"))
            {
                initObject.EnableDynamicDns = this.EnableDynamicDns;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EnableIpv4dnsFromDhcp"))
            {
                initObject.EnableIpv4dnsFromDhcp = this.EnableIpv4dnsFromDhcp;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EnableIpv6"))
            {
                initObject.EnableIpv6 = this.EnableIpv6;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EnableIpv6dnsFromDhcp"))
            {
                initObject.EnableIpv6dnsFromDhcp = this.EnableIpv6dnsFromDhcp;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("PreferredIpv4dnsServer"))
            {
                initObject.PreferredIpv4dnsServer = this.PreferredIpv4dnsServer;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PreferredIpv6dnsServer"))
            {
                initObject.PreferredIpv6dnsServer = this.PreferredIpv6dnsServer;
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
}