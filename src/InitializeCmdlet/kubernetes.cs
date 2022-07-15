using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesAciCniApic.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesAciCniApic")]
    public class InitializeIntersightKubernetesAciCniApic : PSCmdlet
    {
        public InitializeIntersightKubernetesAciCniApic()
        {
            ClassId = KubernetesAciCniApic.ClassIdEnum.KubernetesAciCniApic;
            ObjectType = KubernetesAciCniApic.ObjectTypeEnum.KubernetesAciCniApic;

        }
        // <summary>
        /// <para type="description">"An array of relationships to kubernetesAciCniProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.KubernetesAciCniProfileRelationship> AciCniProfiles
        {
            get;
            set;
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
        /// <para type="description">"The Moid of the apic device under the asset service."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string AssetApicMoid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesAciCniApic.ClassIdEnum ClassId
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
        /// <para type="description">"The number of ACI CNI profiles configured for this APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long NumAciCniProfiles
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesAciCniApic.ObjectTypeEnum ObjectType
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
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.AssetDeviceRegistrationRelationship RegisteredDevice
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
            Intersight.Model.KubernetesAciCniApic initObject = new Intersight.Model.KubernetesAciCniApic();
            if (this.MyInvocation.BoundParameters.ContainsKey("AciCniProfiles"))
            {
                initObject.AciCniProfiles = this.AciCniProfiles;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AssetApicMoid"))
            {
                initObject.AssetApicMoid = this.AssetApicMoid;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NumAciCniProfiles"))
            {
                initObject.NumAciCniProfiles = this.NumAciCniProfiles;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Organization"))
            {
                initObject.Organization = this.Organization;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RegisteredDevice"))
            {
                initObject.RegisteredDevice = this.RegisteredDevice;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesAciCniProfile.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesAciCniProfile")]
    public class InitializeIntersightKubernetesAciCniProfile : PSCmdlet
    {
        public InitializeIntersightKubernetesAciCniProfile()
        {
            ClassId = KubernetesAciCniProfile.ClassIdEnum.KubernetesAciCniProfile;
            ObjectType = KubernetesAciCniProfile.ObjectTypeEnum.KubernetesAciCniProfile;
            Type = KubernetesAciCniProfile.TypeEnum.Instance;

        }
        // <summary>
        /// <para type="description">"Name of ACI AAEP (Attachable Access Entity Profile) to be used for all Kubernetes clusters using this policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9][a-zA-Z0-9-_]*[a-zA-Z0-9]$")]
        public string AaepName
        {
            get;
            set;
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesAciCniProfile.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the profile."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Start of range of IP subnets for external services with dynamic IP allocation for use by Kubernetes clusters using this ACI CNI policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5]).([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5]).([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5]).([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\/([0-9]|[1-2][0-9]|3[0-2])$")]
        public string ExtSvcDynSubnetStart
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Start of range of IP subnets for external services with static IP allocation for use by Kubernetes clusters using this ACI CNI policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5]).([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5]).([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5]).([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\/([0-9]|[1-2][0-9]|3[0-2])$")]
        public string ExtSvcStaticSubnetStart
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of ACI L3Out network to be used for all Kubernetes clusters using this policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9][a-zA-Z0-9-_]*[a-zA-Z0-9]$")]
        public string L3OutNetworkName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of ACI L3Out policy to be used for all Kubernetes clusters using this policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9][a-zA-Z0-9-_]*[a-zA-Z0-9]$")]
        public string L3OutPolicyName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Tenant in ACI used by this L3Out and Common VRF."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9][a-zA-Z0-9-_]*[a-zA-Z0-9]$")]
        public string L3OutTenant
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
        /// <para type="description">"Name of the profile instance or profile template."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"VMM domain within which Kubernetes clusters using this policy are nested."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9][a-zA-Z0-9-_]*[a-zA-Z0-9]$")]
        public string NestedVmmDomain
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Start of range of ACI Node Service IP subnets to use by Kubernetes clusters using this ACI CNI policy This is used for the service graph which is used for ACI PBR based load balancing."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5]).([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5]).([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5]).([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\/([0-9]|[1-2][0-9]|3[0-2])$")]
        public string NodeSvcSubnetStart
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Ending value of VLAN range used to assign Node VLAN Ids for each Kubernetes cluster using this policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long NodeVlanRangeEnd
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Starting value of VLAN range used to assign Node VLAN Ids for each Kubernetes cluster using this policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long NodeVlanRangeStart
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesAciCniProfile.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Range of IP Multicast addresses to be used by the Opflex protocol for Kubernetes clusters using this policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5]).([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5]).([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5]).([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\/([0-9]|[1-2][0-9]|3[0-2])$")]
        public string OpflexMulticastAddressRange
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
        /// <para type="description">"Start of range of Kubernetes pod IP subnets to use by Kubernetes clusters using this ACI CNI policy This should be a /8 IP subnet so that multiple /16 subnets can be assigned for pod subnets of Kubernetes clusters using this profile."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5]).([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5]).([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5]).([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\/([0-9]|[1-2][0-9]|3[0-2])$")]
        public string PodSubnetStart
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.AssetDeviceRegistrationRelationship RegisteredDevice
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a policyAbstractProfile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.PolicyAbstractProfileRelationship SrcTemplate
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
        // <summary>
        /// <para type="description">"Defines the type of the profile. Accepted values are instance or template.\n* `instance` - The profile defines the configuration for a specific instance of a target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesAciCniProfile.TypeEnum Type
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"VRF (Virtual Routing and Forwarding) domain to be used within ACI fabric by all k8s clusters using this policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9][a-zA-Z0-9-_]*[a-zA-Z0-9]$")]
        public string Vrf
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.KubernetesAciCniProfile initObject = new Intersight.Model.KubernetesAciCniProfile();
            if (this.MyInvocation.BoundParameters.ContainsKey("AaepName"))
            {
                initObject.AaepName = this.AaepName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ExtSvcDynSubnetStart"))
            {
                initObject.ExtSvcDynSubnetStart = this.ExtSvcDynSubnetStart;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ExtSvcStaticSubnetStart"))
            {
                initObject.ExtSvcStaticSubnetStart = this.ExtSvcStaticSubnetStart;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("L3OutNetworkName"))
            {
                initObject.L3OutNetworkName = this.L3OutNetworkName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("L3OutPolicyName"))
            {
                initObject.L3OutPolicyName = this.L3OutPolicyName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("L3OutTenant"))
            {
                initObject.L3OutTenant = this.L3OutTenant;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NestedVmmDomain"))
            {
                initObject.NestedVmmDomain = this.NestedVmmDomain;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NodeSvcSubnetStart"))
            {
                initObject.NodeSvcSubnetStart = this.NodeSvcSubnetStart;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NodeVlanRangeEnd"))
            {
                initObject.NodeVlanRangeEnd = this.NodeVlanRangeEnd;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NodeVlanRangeStart"))
            {
                initObject.NodeVlanRangeStart = this.NodeVlanRangeStart;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("OpflexMulticastAddressRange"))
            {
                initObject.OpflexMulticastAddressRange = this.OpflexMulticastAddressRange;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Organization"))
            {
                initObject.Organization = this.Organization;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PodSubnetStart"))
            {
                initObject.PodSubnetStart = this.PodSubnetStart;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RegisteredDevice"))
            {
                initObject.RegisteredDevice = this.RegisteredDevice;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SrcTemplate"))
            {
                initObject.SrcTemplate = this.SrcTemplate;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Type"))
            {
                initObject.Type = this.Type;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Vrf"))
            {
                initObject.Vrf = this.Vrf;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesAciCniTenantClusterAllocation.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesAciCniTenantClusterAllocation")]
    public class InitializeIntersightKubernetesAciCniTenantClusterAllocation : PSCmdlet
    {
        public InitializeIntersightKubernetesAciCniTenantClusterAllocation()
        {
            ClassId = KubernetesAciCniTenantClusterAllocation.ClassIdEnum.KubernetesAciCniTenantClusterAllocation;
            ObjectType = KubernetesAciCniTenantClusterAllocation.ObjectTypeEnum.KubernetesAciCniTenantClusterAllocation;

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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesAciCniTenantClusterAllocation.ClassIdEnum ClassId
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesAciCniTenantClusterAllocation.ObjectTypeEnum ObjectType
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
            Intersight.Model.KubernetesAciCniTenantClusterAllocation initObject = new Intersight.Model.KubernetesAciCniTenantClusterAllocation();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Organization"))
            {
                initObject.Organization = this.Organization;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesActionInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesActionInfo")]
    public class InitializeIntersightKubernetesActionInfo : PSCmdlet
    {
        public InitializeIntersightKubernetesActionInfo()
        {
            ClassId = KubernetesActionInfo.ClassIdEnum.KubernetesActionInfo;
            ObjectType = KubernetesActionInfo.ObjectTypeEnum.KubernetesActionInfo;
            Status = KubernetesActionInfo.StatusEnum.None;

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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesActionInfo.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesActionInfo.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"No longer maintained and will be removed soon.\n* `None` - A place holder for the default value.\n* `InProgress` - Action triggered on the resource is still running.\n* `Success` - Action triggered on the resource is completed successfully.\n* `Failure` - Action triggered on the resource is failed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesActionInfo.StatusEnum Status
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.KubernetesActionInfo initObject = new Intersight.Model.KubernetesActionInfo();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Status"))
            {
                initObject.Status = this.Status;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesAddon.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesAddon")]
    public class InitializeIntersightKubernetesAddon : PSCmdlet
    {
        public InitializeIntersightKubernetesAddon()
        {
            ClassId = KubernetesAddon.ClassIdEnum.KubernetesAddon;
            ObjectType = KubernetesAddon.ObjectTypeEnum.KubernetesAddon;

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
        /// <para type="description">"Addon configuration settings that are specific to a single cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.KubernetesAddonConfiguration AddonConfiguration
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Addon policy associated with the addon."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.MoMoRef AddonPolicy
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesAddon.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of addon to be installed on a Kubernetes cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesAddon.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.KubernetesAddon initObject = new Intersight.Model.KubernetesAddon();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AddonConfiguration"))
            {
                initObject.AddonConfiguration = this.AddonConfiguration;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AddonPolicy"))
            {
                initObject.AddonPolicy = this.AddonPolicy;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesAddonConfiguration.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesAddonConfiguration")]
    public class InitializeIntersightKubernetesAddonConfiguration : PSCmdlet
    {
        public InitializeIntersightKubernetesAddonConfiguration()
        {
            ClassId = KubernetesAddonConfiguration.ClassIdEnum.KubernetesAddonConfiguration;
            InstallStrategy = KubernetesAddonConfiguration.InstallStrategyEnum.None;
            ObjectType = KubernetesAddonConfiguration.ObjectTypeEnum.KubernetesAddonConfiguration;
            UpgradeStrategy = KubernetesAddonConfiguration.UpgradeStrategyEnum.None;

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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesAddonConfiguration.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Addon install strategy to determine whether an addon is installed if not present.\n* `None` - Unspecified install strategy.\n* `NoAction` - No install action performed.\n* `InstallOnly` - Only install in green field. No action in case of failure or removal.\n* `Always` - Attempt install if chart is not already installed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesAddonConfiguration.InstallStrategyEnum InstallStrategy
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesAddonConfiguration.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.KubernetesKeyValue> OverrideSets
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Properties that can be overridden for an addon."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Overrides
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name for the helm release."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ReleaseName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Namespace for the helm release."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ReleaseNamespace
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Addon upgrade strategy to determine whether an addon configuration is overwritten on upgrade.\n* `None` - Unspecified upgrade strategy.\n* `NoAction` - This choice enables No upgrades to be performed.\n* `UpgradeOnly` - Attempt upgrade if chart or overrides options change, no action on upgrade failure.\n* `ReinstallOnFailure` - Attempt upgrade first. Remove and install on upgrade failure.\n* `AlwaysReinstall` - Always remove older release and reinstall."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesAddonConfiguration.UpgradeStrategyEnum UpgradeStrategy
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.KubernetesAddonConfiguration initObject = new Intersight.Model.KubernetesAddonConfiguration();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("InstallStrategy"))
            {
                initObject.InstallStrategy = this.InstallStrategy;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("OverrideSets"))
            {
                initObject.OverrideSets = this.OverrideSets;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Overrides"))
            {
                initObject.Overrides = this.Overrides;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ReleaseName"))
            {
                initObject.ReleaseName = this.ReleaseName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ReleaseNamespace"))
            {
                initObject.ReleaseNamespace = this.ReleaseNamespace;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UpgradeStrategy"))
            {
                initObject.UpgradeStrategy = this.UpgradeStrategy;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesAddonDefinition.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesAddonDefinition")]
    public class InitializeIntersightKubernetesAddonDefinition : PSCmdlet
    {
        public InitializeIntersightKubernetesAddonDefinition()
        {
            ClassId = KubernetesAddonDefinition.ClassIdEnum.KubernetesAddonDefinition;
            DefaultInstallStrategy = KubernetesAddonDefinition.DefaultInstallStrategyEnum.None;
            DefaultUpgradeStrategy = KubernetesAddonDefinition.DefaultUpgradeStrategyEnum.None;
            ObjectType = KubernetesAddonDefinition.ObjectTypeEnum.KubernetesAddonDefinition;

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
        /// <para type="description">"A reference to a kubernetesCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.KubernetesCatalogRelationship Catalog
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the addon component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ChartUrl
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesAddonDefinition.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Default installation strategy for the release.\n* `None` - Unspecified install strategy.\n* `NoAction` - No install action performed.\n* `InstallOnly` - Only install in green field. No action in case of failure or removal.\n* `Always` - Attempt install if chart is not already installed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesAddonDefinition.DefaultInstallStrategyEnum DefaultInstallStrategy
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Default namespace to install the release."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string DefaultNamespace
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Default upgrade strategy for the release.\n* `None` - Unspecified upgrade strategy.\n* `NoAction` - This choice enables No upgrades to be performed.\n* `UpgradeOnly` - Attempt upgrade if chart or overrides options change, no action on upgrade failure.\n* `ReinstallOnFailure` - Attempt upgrade first. Remove and install on upgrade failure.\n* `AlwaysReinstall` - Always remove older release and reinstall."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesAddonDefinition.DefaultUpgradeStrategyEnum DefaultUpgradeStrategy
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the addon component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Digest used to verify the integrity of an addon."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Digest
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Icon used to represent the addon in UI."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string IconUrl
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<KubernetesAddonDefinition.LabelsEnum> Labels
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
        /// <para type="description">"Name of an addon component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesAddonDefinition.ObjectTypeEnum ObjectType
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
        /// <para type="description">"Properties that can be overridden for an addon."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Overrides
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<KubernetesAddonDefinition.PlatformsEnum> Platforms
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
        // <summary>
        /// <para type="description">"Version of the addon component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Version
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.KubernetesAddonDefinition initObject = new Intersight.Model.KubernetesAddonDefinition();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Catalog"))
            {
                initObject.Catalog = this.Catalog;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ChartUrl"))
            {
                initObject.ChartUrl = this.ChartUrl;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("DefaultInstallStrategy"))
            {
                initObject.DefaultInstallStrategy = this.DefaultInstallStrategy;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DefaultNamespace"))
            {
                initObject.DefaultNamespace = this.DefaultNamespace;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DefaultUpgradeStrategy"))
            {
                initObject.DefaultUpgradeStrategy = this.DefaultUpgradeStrategy;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Digest"))
            {
                initObject.Digest = this.Digest;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IconUrl"))
            {
                initObject.IconUrl = this.IconUrl;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Labels"))
            {
                initObject.Labels = this.Labels;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Overrides"))
            {
                initObject.Overrides = this.Overrides;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Platforms"))
            {
                initObject.Platforms = this.Platforms;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Version"))
            {
                initObject._Version = this.Version;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesAddonPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesAddonPolicy")]
    public class InitializeIntersightKubernetesAddonPolicy : PSCmdlet
    {
        public InitializeIntersightKubernetesAddonPolicy()
        {
            ClassId = KubernetesAddonPolicy.ClassIdEnum.KubernetesAddonPolicy;
            ObjectType = KubernetesAddonPolicy.ObjectTypeEnum.KubernetesAddonPolicy;

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
        /// <para type="description">"Addon configuration settings that are suitable to be shared across clusters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.KubernetesAddonConfiguration AddonConfiguration
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a kubernetesAddonDefinition resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.KubernetesAddonDefinitionRelationship AddonDefinition
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesAddonPolicy.ClassIdEnum ClassId
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

        public KubernetesAddonPolicy.ObjectTypeEnum ObjectType
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
            Intersight.Model.KubernetesAddonPolicy initObject = new Intersight.Model.KubernetesAddonPolicy();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AddonConfiguration"))
            {
                initObject.AddonConfiguration = this.AddonConfiguration;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AddonDefinition"))
            {
                initObject.AddonDefinition = this.AddonDefinition;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesAddonRepository.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesAddonRepository")]
    public class InitializeIntersightKubernetesAddonRepository : PSCmdlet
    {
        public InitializeIntersightKubernetesAddonRepository()
        {
            ClassId = KubernetesAddonRepository.ClassIdEnum.KubernetesAddonRepository;
            ObjectType = KubernetesAddonRepository.ObjectTypeEnum.KubernetesAddonRepository;

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
        /// <para type="description">"CA certificate for the addon registry if it is not a well known CA."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.X509Certificate CaCert
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a workflowCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkflowCatalogRelationship Catalog
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesAddonRepository.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Allow connecting to http registries or https registries which do not have certificate signed by a well known CA."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool InsecureSkipVerification
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
        /// <para type="description">"Name of the addon repository or registry."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesAddonRepository.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.AssetDeviceRegistrationRelationship RegisteredDevice
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"URL for the repository where the addon is hosted."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string RepositoryUrl
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
        // <summary>
        /// <para type="description">"Username to authenticate to the addon registry."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Username
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.KubernetesAddonRepository initObject = new Intersight.Model.KubernetesAddonRepository();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CaCert"))
            {
                initObject.CaCert = this.CaCert;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Catalog"))
            {
                initObject.Catalog = this.Catalog;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("InsecureSkipVerification"))
            {
                initObject.InsecureSkipVerification = this.InsecureSkipVerification;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("RegisteredDevice"))
            {
                initObject.RegisteredDevice = this.RegisteredDevice;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RepositoryUrl"))
            {
                initObject.RepositoryUrl = this.RepositoryUrl;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Username"))
            {
                initObject.Username = this.Username;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesAddonVersionReference.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesAddonVersionReference")]
    public class InitializeIntersightKubernetesAddonVersionReference : PSCmdlet
    {
        public InitializeIntersightKubernetesAddonVersionReference()
        {
            ClassId = KubernetesAddonVersionReference.ClassIdEnum.KubernetesAddonVersionReference;
            ObjectType = KubernetesAddonVersionReference.ObjectTypeEnum.KubernetesAddonVersionReference;

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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesAddonVersionReference.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the addon to lookup."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesAddonVersionReference.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version number to filter the addon with."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Version
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.KubernetesAddonVersionReference initObject = new Intersight.Model.KubernetesAddonVersionReference();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Version"))
            {
                initObject._Version = this.Version;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesBaremetalNetworkInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesBaremetalNetworkInfo")]
    public class InitializeIntersightKubernetesBaremetalNetworkInfo : PSCmdlet
    {
        public InitializeIntersightKubernetesBaremetalNetworkInfo()
        {
            ClassId = KubernetesBaremetalNetworkInfo.ClassIdEnum.KubernetesBaremetalNetworkInfo;
            ObjectType = KubernetesBaremetalNetworkInfo.ObjectTypeEnum.KubernetesBaremetalNetworkInfo;

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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesBaremetalNetworkInfo.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.KubernetesEthernet> Ethernets
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesBaremetalNetworkInfo.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.KubernetesOvsBond> Ovsbonds
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.KubernetesBaremetalNetworkInfo initObject = new Intersight.Model.KubernetesBaremetalNetworkInfo();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Ethernets"))
            {
                initObject.Ethernets = this.Ethernets;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Ovsbonds"))
            {
                initObject.Ovsbonds = this.Ovsbonds;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesBaremetalNodeProfile.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesBaremetalNodeProfile")]
    public class InitializeIntersightKubernetesBaremetalNodeProfile : PSCmdlet
    {
        public InitializeIntersightKubernetesBaremetalNodeProfile()
        {
            ClassId = KubernetesBaremetalNodeProfile.ClassIdEnum.KubernetesBaremetalNodeProfile;
            CloudProvider = KubernetesBaremetalNodeProfile.CloudProviderEnum.NoProvider;
            ObjectType = KubernetesBaremetalNodeProfile.ObjectTypeEnum.KubernetesBaremetalNodeProfile;
            Type = KubernetesBaremetalNodeProfile.TypeEnum.Instance;

        }
        // <summary>
        /// <para type="description">"User initiated action. Each profile type has its own supported actions. For HyperFlex cluster profile, the supported actions are -- Validate, Deploy, Continue, Retry, Abort, Unassign For server profile, the support actions are -- Deploy, Unassign."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Action
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.PolicyActionParam> ActionParams
        {
            get;
            set;
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesBaremetalNodeProfile.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Cloud provider for this node profile.\n* `noProvider` - Enables the use of no cloud provider.\n* `external` - Out of tree cloud provider, e.g. CPI for vsphere."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesBaremetalNodeProfile.CloudProviderEnum CloudProvider
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The configuration state and results of the last configuration operation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.PolicyConfigContext ConfigContext
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the profile."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Network interface from NetworkInfo (by name) to use for kubernetes VIP."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string KubernetesNic
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
        /// <para type="description">"Name of the profile instance or profile template."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The network configuration for this baremetal server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.KubernetesBaremetalNetworkInfo NetworkInfo
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a kubernetesNodeGroupProfile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.KubernetesNodeGroupProfileRelationship NodeGroup
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesBaremetalNodeProfile.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to policyAbstractPolicy resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.PolicyAbstractPolicyRelationship> PolicyBucket
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a computeRackUnit resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.ComputeRackUnitRelationship Server
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a policyAbstractProfile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.PolicyAbstractProfileRelationship SrcTemplate
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
        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.AssetDeviceRegistrationRelationship Target
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Defines the type of the profile. Accepted values are instance or template.\n* `instance` - The profile defines the configuration for a specific instance of a target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesBaremetalNodeProfile.TypeEnum Type
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.KubernetesBaremetalNodeProfile initObject = new Intersight.Model.KubernetesBaremetalNodeProfile();
            if (this.MyInvocation.BoundParameters.ContainsKey("Action"))
            {
                initObject.Action = this.Action;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ActionParams"))
            {
                initObject.ActionParams = this.ActionParams;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("CloudProvider"))
            {
                initObject.CloudProvider = this.CloudProvider;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ConfigContext"))
            {
                initObject.ConfigContext = this.ConfigContext;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("KubernetesNic"))
            {
                initObject.KubernetesNic = this.KubernetesNic;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NetworkInfo"))
            {
                initObject.NetworkInfo = this.NetworkInfo;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NodeGroup"))
            {
                initObject.NodeGroup = this.NodeGroup;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("PolicyBucket"))
            {
                initObject.PolicyBucket = this.PolicyBucket;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Server"))
            {
                initObject.Server = this.Server;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SrcTemplate"))
            {
                initObject.SrcTemplate = this.SrcTemplate;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Target"))
            {
                initObject.Target = this.Target;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Type"))
            {
                initObject.Type = this.Type;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesBaseVirtualMachineInfraConfig.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesBaseVirtualMachineInfraConfig")]
    public class InitializeIntersightKubernetesBaseVirtualMachineInfraConfig : PSCmdlet
    {
        public InitializeIntersightKubernetesBaseVirtualMachineInfraConfig()
        {

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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesBaseVirtualMachineInfraConfig.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> Interfaces
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.KubernetesNetworkInterfaceSpec> NetworkInterfaces
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesBaseVirtualMachineInfraConfig.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.KubernetesBaseVirtualMachineInfraConfig initObject = new Intersight.Model.KubernetesBaseVirtualMachineInfraConfig();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Interfaces"))
            {
                initObject.Interfaces = this.Interfaces;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NetworkInterfaces"))
            {
                initObject.NetworkInterfaces = this.NetworkInterfaces;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesCalicoConfig.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesCalicoConfig")]
    public class InitializeIntersightKubernetesCalicoConfig : PSCmdlet
    {
        public InitializeIntersightKubernetesCalicoConfig()
        {
            ClassId = KubernetesCalicoConfig.ClassIdEnum.KubernetesCalicoConfig;
            IpVersion = KubernetesCalicoConfig.IpVersionEnum.V4;
            ObjectType = KubernetesCalicoConfig.ObjectTypeEnum.KubernetesCalicoConfig;

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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesCalicoConfig.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"IP version that can take on values v4 or v6.\n* `v4` - This refers to the IPv4 address.\n* `v6` - This refers to the IPv6 address."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesCalicoConfig.IpVersionEnum IpVersion
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Workload interface maximum transmission unit (MTU)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Mtu
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesCalicoConfig.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"CNI Image registry location."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Registry
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Container newtork interface plugin configuration."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Version
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.KubernetesCalicoConfig initObject = new Intersight.Model.KubernetesCalicoConfig();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("IpVersion"))
            {
                initObject.IpVersion = this.IpVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Mtu"))
            {
                initObject.Mtu = this.Mtu;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Registry"))
            {
                initObject.Registry = this.Registry;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Version"))
            {
                initObject._Version = this.Version;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesCatalog.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesCatalog")]
    public class InitializeIntersightKubernetesCatalog : PSCmdlet
    {
        public InitializeIntersightKubernetesCatalog()
        {
            ClassId = KubernetesCatalog.ClassIdEnum.KubernetesCatalog;
            ObjectType = KubernetesCatalog.ObjectTypeEnum.KubernetesCatalog;

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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesCatalog.ClassIdEnum ClassId
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesCatalog.ObjectTypeEnum ObjectType
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
            Intersight.Model.KubernetesCatalog initObject = new Intersight.Model.KubernetesCatalog();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesCluster.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesCluster")]
    public class InitializeIntersightKubernetesCluster : PSCmdlet
    {
        public InitializeIntersightKubernetesCluster()
        {
            ClassId = KubernetesCluster.ClassIdEnum.KubernetesCluster;
            ObjectType = KubernetesCluster.ObjectTypeEnum.KubernetesCluster;

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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesCluster.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a kubernetesClusterAddonProfile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.KubernetesClusterAddonProfileRelationship ClusterAddonProfile
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Status of the endpoint connection of this Kubernetes cluster.\n* `` - The target details have been persisted but Intersight has not yet attempted to connect to the target.\n* `Connected` - Intersight is able to establish a connection to the target and initiate management activities.\n* `NotConnected` - Intersight is unable to establish a connection to the target.\n* `ClaimInProgress` - Claim of the target is in progress. A connection to the target has not been fully established.\n* `UnclaimInProgress` - Unclaim of the target is in progress. Intersight is able to connect to the target and all management operations are supported.\n* `Unclaimed` - The device was un-claimed from the users account by an Administrator of the device. Also indicates the failure to claim Targets of type HTTP Endpoint in Intersight.\n* `Claimed` - Target of type HTTP Endpoint is successfully claimed in Intersight. Currently no validation is performed to verify the Target connectivity from Intersight at the time of creation. However invoking API from Intersight Orchestrator fails if this Target is not reachable from Intersight or if Target API credentials are incorrect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesCluster.ConnectionStatusEnum ConnectionStatus
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Kubeconfig for the cluster to collect inventory for."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string KubeConfig
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesCluster.ObjectTypeEnum ObjectType
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
        /// <para type="description">"An array of relationships to assetDeviceRegistration resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.AssetDeviceRegistrationRelationship> RegisteredDevices
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to storageBaseCluster resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.StorageBaseClusterRelationship> StorageClusters
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
            Intersight.Model.KubernetesCluster initObject = new Intersight.Model.KubernetesCluster();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ClusterAddonProfile"))
            {
                initObject.ClusterAddonProfile = this.ClusterAddonProfile;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ConnectionStatus"))
            {
                initObject.ConnectionStatus = this.ConnectionStatus;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("KubeConfig"))
            {
                initObject.KubeConfig = this.KubeConfig;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Organization"))
            {
                initObject.Organization = this.Organization;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RegisteredDevices"))
            {
                initObject.RegisteredDevices = this.RegisteredDevices;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("StorageClusters"))
            {
                initObject.StorageClusters = this.StorageClusters;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesClusterAddonProfile.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesClusterAddonProfile")]
    public class InitializeIntersightKubernetesClusterAddonProfile : PSCmdlet
    {
        public InitializeIntersightKubernetesClusterAddonProfile()
        {
            ClassId = KubernetesClusterAddonProfile.ClassIdEnum.KubernetesClusterAddonProfile;
            ObjectType = KubernetesClusterAddonProfile.ObjectTypeEnum.KubernetesClusterAddonProfile;

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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.KubernetesAddon> Addons
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a kubernetesCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.KubernetesClusterRelationship AssociatedCluster
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesClusterAddonProfile.ClassIdEnum ClassId
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
        /// <para type="description">"Name of the cluster addon profile."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesClusterAddonProfile.ObjectTypeEnum ObjectType
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
            Intersight.Model.KubernetesClusterAddonProfile initObject = new Intersight.Model.KubernetesClusterAddonProfile();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Addons"))
            {
                initObject.Addons = this.Addons;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AssociatedCluster"))
            {
                initObject.AssociatedCluster = this.AssociatedCluster;
            }
            initObject.ClassId = this.ClassId;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesClusterCertificateConfiguration.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesClusterCertificateConfiguration")]
    public class InitializeIntersightKubernetesClusterCertificateConfiguration : PSCmdlet
    {
        public InitializeIntersightKubernetesClusterCertificateConfiguration()
        {
            ClassId = KubernetesClusterCertificateConfiguration.ClassIdEnum.KubernetesClusterCertificateConfiguration;
            ObjectType = KubernetesClusterCertificateConfiguration.ObjectTypeEnum.KubernetesClusterCertificateConfiguration;

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
        /// <para type="description">"Certificate for the Kubernetes API server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string CaCert
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Private Key for the Kubernetes API server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string CaKey
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesClusterCertificateConfiguration.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Certificate for the etcd cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string EtcdCert
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> EtcdEncryptionKey
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Private key for the etcd cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string EtcdKey
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Certificate for the front proxy to support Kubernetes API aggregators."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string FrontProxyCert
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Private key for the front proxy to support Kubernetes API aggregators."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string FrontProxyKey
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesClusterCertificateConfiguration.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Service account private key used by Kubernetes Token Controller to sign generated service account tokens."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SaPrivateKey
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Service account public key used by Kubernetes API Server to validate service account tokens generated by the Token Controller."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SaPublicKey
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.KubernetesClusterCertificateConfiguration initObject = new Intersight.Model.KubernetesClusterCertificateConfiguration();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CaCert"))
            {
                initObject.CaCert = this.CaCert;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CaKey"))
            {
                initObject.CaKey = this.CaKey;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("EtcdCert"))
            {
                initObject.EtcdCert = this.EtcdCert;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EtcdEncryptionKey"))
            {
                initObject.EtcdEncryptionKey = this.EtcdEncryptionKey;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EtcdKey"))
            {
                initObject.EtcdKey = this.EtcdKey;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FrontProxyCert"))
            {
                initObject.FrontProxyCert = this.FrontProxyCert;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FrontProxyKey"))
            {
                initObject.FrontProxyKey = this.FrontProxyKey;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("SaPrivateKey"))
            {
                initObject.SaPrivateKey = this.SaPrivateKey;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SaPublicKey"))
            {
                initObject.SaPublicKey = this.SaPublicKey;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesClusterManagementConfig.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesClusterManagementConfig")]
    public class InitializeIntersightKubernetesClusterManagementConfig : PSCmdlet
    {
        public InitializeIntersightKubernetesClusterManagementConfig()
        {
            ClassId = KubernetesClusterManagementConfig.ClassIdEnum.KubernetesClusterManagementConfig;
            ObjectType = KubernetesClusterManagementConfig.ObjectTypeEnum.KubernetesClusterManagementConfig;

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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesClusterManagementConfig.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of IP addresses to reserve for load balancer services."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long LoadBalancerCount
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> LoadBalancers
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"VIP for the cluster Kubernetes API server. If this is empty and a cluster IP pool is specified, it will be allocated from the IP pool."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string MasterVip
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesClusterManagementConfig.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> SshKeys
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Hashed password of the TAC user."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string TacPasswd
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.KubernetesClusterManagementConfig initObject = new Intersight.Model.KubernetesClusterManagementConfig();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("LoadBalancerCount"))
            {
                initObject.LoadBalancerCount = this.LoadBalancerCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LoadBalancers"))
            {
                initObject.LoadBalancers = this.LoadBalancers;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MasterVip"))
            {
                initObject.MasterVip = this.MasterVip;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("SshKeys"))
            {
                initObject.SshKeys = this.SshKeys;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TacPasswd"))
            {
                initObject.TacPasswd = this.TacPasswd;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesClusterProfile.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesClusterProfile")]
    public class InitializeIntersightKubernetesClusterProfile : PSCmdlet
    {
        public InitializeIntersightKubernetesClusterProfile()
        {
            ClassId = KubernetesClusterProfile.ClassIdEnum.KubernetesClusterProfile;
            ManagedMode = KubernetesClusterProfile.ManagedModeEnum.Provided;
            ObjectType = KubernetesClusterProfile.ObjectTypeEnum.KubernetesClusterProfile;
            Status = KubernetesClusterProfile.StatusEnum.Undeployed;
            Type = KubernetesClusterProfile.TypeEnum.Instance;

        }
        // <summary>
        /// <para type="description">"User initiated action. Each profile type has its own supported actions. For HyperFlex cluster profile, the supported actions are -- Validate, Deploy, Continue, Retry, Abort, Unassign For server profile, the support actions are -- Deploy, Unassign."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Action
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.PolicyActionParam> ActionParams
        {
            get;
            set;
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
        /// <para type="description">"Certificates and keys that are used to configure a Kubernetes\ncluster. If user does not specify any Certificates or Keys,\nsystem generated certificates will be used to configure the cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.KubernetesClusterCertificateConfiguration CertConfig
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesClusterProfile.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to ippoolPool resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.IppoolPoolRelationship> ClusterIpPools
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The configuration state and results of the last configuration operation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.PolicyConfigContext ConfigContext
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a kubernetesContainerRuntimePolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.KubernetesContainerRuntimePolicyRelationship ContainerRuntimeConfig
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a kubernetesHttpProxyPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.KubernetesHttpProxyPolicyRelationship ContainerRuntimeProxyPolicy
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the profile."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a kubernetesHttpProxyPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.KubernetesHttpProxyPolicyRelationship DeviceConnectorProxyPolicy
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.KubernetesEssentialAddon> EssentialAddons
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Certificates and keys that are used to access a Kubernetes\ncluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.KubernetesConfiguration KubeConfig
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to ippoolBlockLease resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.IppoolBlockLeaseRelationship> LoadbalancerBlockIpLeases
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to ippoolIpLease resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.IppoolIpLeaseRelationship> LoadbalancerIpLeases
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Management mode for the cluster. In some cases Intersight kubernetes service is not required\nto provision and manage the management entities and endpoints (for e.g. EKS). In most other cases\nit will be required to provision and manage these entities and endpoints.\n* `Provided` - Cluster management entities and endpoints are provided by the infrastructure platform.\n* `Managed` - Cluster management entities and endpoints are provisioned and managed by Intersight kubernetes service."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesClusterProfile.ManagedModeEnum ManagedMode
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Configuration required for provisioning and management of cluster management entities. Required if\n'managedMode' is set to 'Managed'."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.KubernetesClusterManagementConfig ManagementConfig
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a ippoolIpLease resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IppoolIpLeaseRelationship MasterVipLease
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
        /// <para type="description">"Name of the profile instance or profile template."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a kubernetesNetworkPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.KubernetesNetworkPolicyRelationship NetConfig
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to kubernetesNodeGroupProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.KubernetesNodeGroupProfileRelationship> NodeGroups
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesClusterProfile.ObjectTypeEnum ObjectType
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
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.MoBaseMoRelationship ParentSolutionProfile
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to policyAbstractPolicy resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.PolicyAbstractPolicyRelationship> PolicyBucket
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a policyAbstractProfile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.PolicyAbstractProfileRelationship SrcTemplate
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Status of the Kubernetes cluster and its nodes.\n* `Undeployed` - The cluster is undeployed.\n* `Configuring` - The cluster is being configured.\n* `Deploying` - The cluster is being deployed.\n* `Undeploying` - The cluster is being undeployed.\n* `DeployFailedTerminal` - The Cluster Deploy failed creation and can not be recovered, only Delete or Undeploy operations are available for this Cluster.\n* `DeployFailed` - The cluster deployment failed.\n* `Upgrading` - The cluster is being upgraded.\n* `Deleting` - The cluster is being deleted.\n* `DeleteFailed` - The Cluster Delete failed and the Cluster can not be recovered, only Delete or Undeploy operations are available for this Cluster.\n* `Ready` - The cluster is ready for use.\n* `Active` - The cluster is being active.\n* `Shutdown` - All the nodes in the cluster are powered off.\n* `Terminated` - The cluster is terminated.\n* `Deployed` - The cluster is deployed. The cluster may not yet be ready for use.\n* `UndeployFailed` - The cluster undeploy action failed.\n* `NotReady` - The cluster is created and some nodes are not ready."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesClusterProfile.StatusEnum Status
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a kubernetesSysConfigPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.KubernetesSysConfigPolicyRelationship SysConfig
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
        // <summary>
        /// <para type="description">"A reference to a kubernetesTrustedRegistriesPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.KubernetesTrustedRegistriesPolicyRelationship TrustedRegistries
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Defines the type of the profile. Accepted values are instance or template.\n* `instance` - The profile defines the configuration for a specific instance of a target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesClusterProfile.TypeEnum Type
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.KubernetesClusterProfile initObject = new Intersight.Model.KubernetesClusterProfile();
            if (this.MyInvocation.BoundParameters.ContainsKey("Action"))
            {
                initObject.Action = this.Action;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ActionParams"))
            {
                initObject.ActionParams = this.ActionParams;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CertConfig"))
            {
                initObject.CertConfig = this.CertConfig;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ClusterIpPools"))
            {
                initObject.ClusterIpPools = this.ClusterIpPools;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ConfigContext"))
            {
                initObject.ConfigContext = this.ConfigContext;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ContainerRuntimeConfig"))
            {
                initObject.ContainerRuntimeConfig = this.ContainerRuntimeConfig;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ContainerRuntimeProxyPolicy"))
            {
                initObject.ContainerRuntimeProxyPolicy = this.ContainerRuntimeProxyPolicy;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DeviceConnectorProxyPolicy"))
            {
                initObject.DeviceConnectorProxyPolicy = this.DeviceConnectorProxyPolicy;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EssentialAddons"))
            {
                initObject.EssentialAddons = this.EssentialAddons;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("KubeConfig"))
            {
                initObject.KubeConfig = this.KubeConfig;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LoadbalancerBlockIpLeases"))
            {
                initObject.LoadbalancerBlockIpLeases = this.LoadbalancerBlockIpLeases;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LoadbalancerIpLeases"))
            {
                initObject.LoadbalancerIpLeases = this.LoadbalancerIpLeases;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ManagedMode"))
            {
                initObject.ManagedMode = this.ManagedMode;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ManagementConfig"))
            {
                initObject.ManagementConfig = this.ManagementConfig;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MasterVipLease"))
            {
                initObject.MasterVipLease = this.MasterVipLease;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NetConfig"))
            {
                initObject.NetConfig = this.NetConfig;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NodeGroups"))
            {
                initObject.NodeGroups = this.NodeGroups;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Organization"))
            {
                initObject.Organization = this.Organization;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ParentSolutionProfile"))
            {
                initObject.ParentSolutionProfile = this.ParentSolutionProfile;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PolicyBucket"))
            {
                initObject.PolicyBucket = this.PolicyBucket;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SrcTemplate"))
            {
                initObject.SrcTemplate = this.SrcTemplate;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Status"))
            {
                initObject.Status = this.Status;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SysConfig"))
            {
                initObject.SysConfig = this.SysConfig;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TrustedRegistries"))
            {
                initObject.TrustedRegistries = this.TrustedRegistries;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Type"))
            {
                initObject.Type = this.Type;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesCniConfig.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesCniConfig")]
    public class InitializeIntersightKubernetesCniConfig : PSCmdlet
    {
        public InitializeIntersightKubernetesCniConfig()
        {
            ClassId = KubernetesCniConfig.ClassIdEnum.KubernetesCalicoConfig;
            ObjectType = KubernetesCniConfig.ObjectTypeEnum.KubernetesCalicoConfig;

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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesCniConfig.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesCniConfig.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"CNI Image registry location."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Registry
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Container newtork interface plugin configuration."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Version
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.KubernetesCniConfig initObject = new Intersight.Model.KubernetesCniConfig();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Registry"))
            {
                initObject.Registry = this.Registry;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Version"))
            {
                initObject._Version = this.Version;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesConfigResult.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesConfigResult")]
    public class InitializeIntersightKubernetesConfigResult : PSCmdlet
    {
        public InitializeIntersightKubernetesConfigResult()
        {
            ClassId = KubernetesConfigResult.ClassIdEnum.KubernetesConfigResult;
            ObjectType = KubernetesConfigResult.ObjectTypeEnum.KubernetesConfigResult;

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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesConfigResult.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The current running stage of the configuration or workflow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ConfigStage
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Indicates overall configuration state for applying the configuration to the end point. Values  -- Ok, Ok-with-warning, Errored."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ConfigState
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesConfigResult.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to kubernetesConfigResultEntry resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.KubernetesConfigResultEntryRelationship> ResultEntries
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
        // <summary>
        /// <para type="description">"Indicates overall state for logical model validation. Values  -- Ok, Ok-with-warning, Errored."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ValidationState
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.KubernetesConfigResult initObject = new Intersight.Model.KubernetesConfigResult();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ConfigStage"))
            {
                initObject.ConfigStage = this.ConfigStage;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ConfigState"))
            {
                initObject.ConfigState = this.ConfigState;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("ResultEntries"))
            {
                initObject.ResultEntries = this.ResultEntries;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ValidationState"))
            {
                initObject.ValidationState = this.ValidationState;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesConfigResultEntry.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesConfigResultEntry")]
    public class InitializeIntersightKubernetesConfigResultEntry : PSCmdlet
    {
        public InitializeIntersightKubernetesConfigResultEntry()
        {
            ClassId = KubernetesConfigResultEntry.ClassIdEnum.KubernetesConfigResultEntry;
            ObjectType = KubernetesConfigResultEntry.ObjectTypeEnum.KubernetesConfigResultEntry;

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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesConfigResultEntry.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The completed time of the task in installer."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string CompletedTime
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a kubernetesConfigResult resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.KubernetesConfigResultRelationship ConfigResult
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Context information on the change."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.PolicyConfigResultContext Context
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Localized message based on the locale setting of the user's context."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Message
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesConfigResultEntry.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The identifier of the object that owns the result message.\nThe owner ID is used to correlate a given result entry to a task or entity. For example, a config result\nentry that describes the result of a workflow task may have the task's instance ID as the owner."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string OwnerId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Values  -- Ok, Ok-with-warning, Errored."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string State
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
        // <summary>
        /// <para type="description">"Indicates if the result is reported during the logical model validation/resource allocation phase. or the configuration applying phase. Values -- validation, config."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Type
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.KubernetesConfigResultEntry initObject = new Intersight.Model.KubernetesConfigResultEntry();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("CompletedTime"))
            {
                initObject.CompletedTime = this.CompletedTime;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ConfigResult"))
            {
                initObject.ConfigResult = this.ConfigResult;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Context"))
            {
                initObject.Context = this.Context;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Message"))
            {
                initObject.Message = this.Message;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("OwnerId"))
            {
                initObject.OwnerId = this.OwnerId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("State"))
            {
                initObject.State = this.State;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Type"))
            {
                initObject.Type = this.Type;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesConfiguration.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesConfiguration")]
    public class InitializeIntersightKubernetesConfiguration : PSCmdlet
    {
        public InitializeIntersightKubernetesConfiguration()
        {
            ClassId = KubernetesConfiguration.ClassIdEnum.KubernetesConfiguration;
            ObjectType = KubernetesConfiguration.ObjectTypeEnum.KubernetesConfiguration;

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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesConfiguration.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Kubernetes configuration to connect to the cluster as an system administrator."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string KubeConfig
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesConfiguration.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.KubernetesConfiguration initObject = new Intersight.Model.KubernetesConfiguration();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("KubeConfig"))
            {
                initObject.KubeConfig = this.KubeConfig;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesContainerRuntimePolicy.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesContainerRuntimePolicy")]
    public class InitializeIntersightKubernetesContainerRuntimePolicy : PSCmdlet
    {
        public InitializeIntersightKubernetesContainerRuntimePolicy()
        {
            ClassId = KubernetesContainerRuntimePolicy.ClassIdEnum.KubernetesContainerRuntimePolicy;
            ObjectType = KubernetesContainerRuntimePolicy.ObjectTypeEnum.KubernetesContainerRuntimePolicy;

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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesContainerRuntimePolicy.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to kubernetesClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.KubernetesClusterProfileRelationship> ClusterProfiles
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
        /// <para type="description">"Bridge IP (--bip) including Prefix (e.g., 172.17.0.5/24) that Docker will use for the default bridge network (docker0). Containers will connect to this if no other network is configured, not used by kubernetes pods because their network is managed by CNI. However this address space must not collide with other CIDRs on your networks, including the cluster's Service CIDR, Pod Network CIDR and IP Pools."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5]).([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5]).([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5]).([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\/([0-9]|[1-2][0-9]|3[0-2])$")]
        public string DockerBridgeNetworkCidr
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The HTTP proxy configuration for docker. Refer to https://docs.docker.com/network/proxy/ for details. Deprecated, assign a HttpProxyPolicy to the ClusterProfile ContainerRuntimeProxyPolicy field instead."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.KubernetesProxyConfig DockerHttpProxy
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The https proxy configuration for docker. Refer to https://docs.docker.com/network/proxy/ for details. Deprecated, assign a HttpProxyPolicy to the ClusterProfile ContainerRuntimeProxyPolicy field instead."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.KubernetesProxyConfig DockerHttpsProxy
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> DockerNoProxy
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

        public KubernetesContainerRuntimePolicy.ObjectTypeEnum ObjectType
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
            Intersight.Model.KubernetesContainerRuntimePolicy initObject = new Intersight.Model.KubernetesContainerRuntimePolicy();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ClusterProfiles"))
            {
                initObject.ClusterProfiles = this.ClusterProfiles;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DockerBridgeNetworkCidr"))
            {
                initObject.DockerBridgeNetworkCidr = this.DockerBridgeNetworkCidr;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DockerHttpProxy"))
            {
                initObject.DockerHttpProxy = this.DockerHttpProxy;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DockerHttpsProxy"))
            {
                initObject.DockerHttpsProxy = this.DockerHttpsProxy;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DockerNoProxy"))
            {
                initObject.DockerNoProxy = this.DockerNoProxy;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesDaemonSet.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesDaemonSet")]
    public class InitializeIntersightKubernetesDaemonSet : PSCmdlet
    {
        public InitializeIntersightKubernetesDaemonSet()
        {
            ClassId = KubernetesDaemonSet.ClassIdEnum.KubernetesDaemonSet;
            ObjectType = KubernetesDaemonSet.ObjectTypeEnum.KubernetesDaemonSet;

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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesDaemonSet.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Meta data of the kubernetes resource."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.KubernetesObjectMeta Metadata
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
        /// <para type="description">"Name of the referenced kubernetes resource."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesDaemonSet.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"DaemonSetstatus represents the current status of the corresponding DaemonSetStatus in a Kubernetes cluster. For detail, please refer to kubernetes.DaemonSetStatus."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.KubernetesDaemonSetStatus Status
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
        // <summary>
        /// <para type="description">"UUID of the referenced kubernetes resource. It is generated by the kubernetes cluster itself."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Uuid
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.KubernetesDaemonSet initObject = new Intersight.Model.KubernetesDaemonSet();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Metadata"))
            {
                initObject.Metadata = this.Metadata;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Status"))
            {
                initObject.Status = this.Status;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Uuid"))
            {
                initObject.Uuid = this.Uuid;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesDaemonSetStatus.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesDaemonSetStatus")]
    public class InitializeIntersightKubernetesDaemonSetStatus : PSCmdlet
    {
        public InitializeIntersightKubernetesDaemonSetStatus()
        {
            ClassId = KubernetesDaemonSetStatus.ClassIdEnum.KubernetesDaemonSetStatus;
            ObjectType = KubernetesDaemonSetStatus.ObjectTypeEnum.KubernetesDaemonSetStatus;

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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesDaemonSetStatus.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of nodes that are running at least 1 daemon pod and are supposed to run the daemon pod."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long CurrentNumberScheduled
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The total number of nodes that should be running the daemon pod (including nodes correctly running the daemon pod)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long DesiredNumberScheduled
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of nodes that should be running the daemon pod and have one or more of the daemon pod running and available (ready for at least spec.minReadySeconds)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string NumberAvailable
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of nodes that are running the daemon pod, but are not supposed to run the daemon pod."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long NumberMisscheduled
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of nodes that should be running the daemon pod and have one or more of the daemon pod running and ready."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long NumberReady
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesDaemonSetStatus.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The most recent generation observed by the daemon set controller."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long ObservedGeneration
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The total number of nodes that are running updated daemon pod."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string UpdatedNumberScheduled
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.KubernetesDaemonSetStatus initObject = new Intersight.Model.KubernetesDaemonSetStatus();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("CurrentNumberScheduled"))
            {
                initObject.CurrentNumberScheduled = this.CurrentNumberScheduled;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DesiredNumberScheduled"))
            {
                initObject.DesiredNumberScheduled = this.DesiredNumberScheduled;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NumberAvailable"))
            {
                initObject.NumberAvailable = this.NumberAvailable;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NumberMisscheduled"))
            {
                initObject.NumberMisscheduled = this.NumberMisscheduled;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NumberReady"))
            {
                initObject.NumberReady = this.NumberReady;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("ObservedGeneration"))
            {
                initObject.ObservedGeneration = this.ObservedGeneration;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UpdatedNumberScheduled"))
            {
                initObject.UpdatedNumberScheduled = this.UpdatedNumberScheduled;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesDeployment.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesDeployment")]
    public class InitializeIntersightKubernetesDeployment : PSCmdlet
    {
        public InitializeIntersightKubernetesDeployment()
        {
            ClassId = KubernetesDeployment.ClassIdEnum.KubernetesDeployment;
            ObjectType = KubernetesDeployment.ObjectTypeEnum.KubernetesDeployment;

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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesDeployment.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Meta data of the kubernetes resource."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.KubernetesObjectMeta Metadata
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
        /// <para type="description">"Name of the referenced kubernetes resource."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesDeployment.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The status of the deployment. It reflect the number of ready and desired replicas. In Kubernetes, a Deployment enters various states during its lifecycle. It can be progressing while rolling out a new ReplicaSet, it can be complete, or it can fail to progress."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.KubernetesDeploymentStatus Status
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
        // <summary>
        /// <para type="description">"UUID of the referenced kubernetes resource. It is generated by the kubernetes cluster itself."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Uuid
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.KubernetesDeployment initObject = new Intersight.Model.KubernetesDeployment();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Metadata"))
            {
                initObject.Metadata = this.Metadata;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Status"))
            {
                initObject.Status = this.Status;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Uuid"))
            {
                initObject.Uuid = this.Uuid;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesDeploymentStatus.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesDeploymentStatus")]
    public class InitializeIntersightKubernetesDeploymentStatus : PSCmdlet
    {
        public InitializeIntersightKubernetesDeploymentStatus()
        {
            ClassId = KubernetesDeploymentStatus.ClassIdEnum.KubernetesDeploymentStatus;
            ObjectType = KubernetesDeploymentStatus.ObjectTypeEnum.KubernetesDeploymentStatus;

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
        /// <para type="description">"Total number of available pods (ready for at least minReadySeconds) targeted by this deployment."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long AvailableReplicas
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesDeploymentStatus.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesDeploymentStatus.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The generation observed by the deployment controller."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long ObservedGeneration
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Total number of ready pods targeted by this deployment."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long ReadyReplicas
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Total number of non-terminated pods targeted by this deployment (their labels match the selector)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Replicas
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Total number of non-terminated pods targeted by this deployment that have the desired template spec."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long UpdatedReplicas
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.KubernetesDeploymentStatus initObject = new Intersight.Model.KubernetesDeploymentStatus();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AvailableReplicas"))
            {
                initObject.AvailableReplicas = this.AvailableReplicas;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("ObservedGeneration"))
            {
                initObject.ObservedGeneration = this.ObservedGeneration;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ReadyReplicas"))
            {
                initObject.ReadyReplicas = this.ReadyReplicas;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Replicas"))
            {
                initObject.Replicas = this.Replicas;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UpdatedReplicas"))
            {
                initObject.UpdatedReplicas = this.UpdatedReplicas;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesEssentialAddon.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesEssentialAddon")]
    public class InitializeIntersightKubernetesEssentialAddon : PSCmdlet
    {
        public InitializeIntersightKubernetesEssentialAddon()
        {
            ClassId = KubernetesEssentialAddon.ClassIdEnum.KubernetesEssentialAddon;
            ObjectType = KubernetesEssentialAddon.ObjectTypeEnum.KubernetesEssentialAddon;

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
        /// <para type="description">"Addon configuration settings that are specific to a single cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.KubernetesAddonConfiguration AddonConfiguration
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Addon definition associated with the addon."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.MoMoRef AddonDefinition
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesEssentialAddon.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of addon to be installed on a Kubernetes cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesEssentialAddon.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.KubernetesEssentialAddon initObject = new Intersight.Model.KubernetesEssentialAddon();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AddonConfiguration"))
            {
                initObject.AddonConfiguration = this.AddonConfiguration;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AddonDefinition"))
            {
                initObject.AddonDefinition = this.AddonDefinition;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesEsxiVirtualMachineInfraConfig.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesEsxiVirtualMachineInfraConfig")]
    public class InitializeIntersightKubernetesEsxiVirtualMachineInfraConfig : PSCmdlet
    {
        public InitializeIntersightKubernetesEsxiVirtualMachineInfraConfig()
        {
            ClassId = KubernetesEsxiVirtualMachineInfraConfig.ClassIdEnum.KubernetesEsxiVirtualMachineInfraConfig;
            ObjectType = KubernetesEsxiVirtualMachineInfraConfig.ObjectTypeEnum.KubernetesEsxiVirtualMachineInfraConfig;

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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesEsxiVirtualMachineInfraConfig.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the vSphere cluster on which the virtual machines are created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Cluster
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the datasore on which the virtual machine disks are created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Datastore
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> Interfaces
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.KubernetesNetworkInterfaceSpec> NetworkInterfaces
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesEsxiVirtualMachineInfraConfig.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Passphrase for the vcenter user."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Passphrase
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the vSphere resource pool on which the virtual machines are created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ResourcePool
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.KubernetesEsxiVirtualMachineInfraConfig initObject = new Intersight.Model.KubernetesEsxiVirtualMachineInfraConfig();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Cluster"))
            {
                initObject.Cluster = this.Cluster;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Datastore"))
            {
                initObject.Datastore = this.Datastore;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Interfaces"))
            {
                initObject.Interfaces = this.Interfaces;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NetworkInterfaces"))
            {
                initObject.NetworkInterfaces = this.NetworkInterfaces;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Passphrase"))
            {
                initObject.Passphrase = this.Passphrase;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ResourcePool"))
            {
                initObject.ResourcePool = this.ResourcePool;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesEthernet.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesEthernet")]
    public class InitializeIntersightKubernetesEthernet : PSCmdlet
    {
        public InitializeIntersightKubernetesEthernet()
        {
            ClassId = KubernetesEthernet.ClassIdEnum.KubernetesEthernet;
            ObjectType = KubernetesEthernet.ObjectTypeEnum.KubernetesEthernet;

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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> Addresses
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesEthernet.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Deprecated. This will add a default route as long as the first default route in Routes is not different. If is different, Gateway will be replaced with that default route. If there is no default Route and this is set, then Routes will be updated with the first entry as a default with this default gateway. If there is only one default Route and this gateway becomes empty, then the default routes will all be removed. Do not set if using Ip Pools, as the gateway is configured in the pool. This will be removed in the future."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Gateway
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.KubernetesIpV4Config> IpV4Configs
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The matcher to be used to find the physical network interface represented by this ethernet device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.KubernetesEthernetMatcher Matcher
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The MTU to assign to this Network Interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Mtu
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name for this network interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesEthernet.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"If the infrastructure network is selectable, this indicates which network to attach to the port."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ProviderName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.KubernetesRoute> Routes
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.KubernetesEthernet initObject = new Intersight.Model.KubernetesEthernet();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Addresses"))
            {
                initObject.Addresses = this.Addresses;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Gateway"))
            {
                initObject.Gateway = this.Gateway;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IpV4Configs"))
            {
                initObject.IpV4Configs = this.IpV4Configs;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Matcher"))
            {
                initObject.Matcher = this.Matcher;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Mtu"))
            {
                initObject.Mtu = this.Mtu;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("ProviderName"))
            {
                initObject.ProviderName = this.ProviderName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Routes"))
            {
                initObject.Routes = this.Routes;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesEthernetMatcher.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesEthernetMatcher")]
    public class InitializeIntersightKubernetesEthernetMatcher : PSCmdlet
    {
        public InitializeIntersightKubernetesEthernetMatcher()
        {
            ClassId = KubernetesEthernetMatcher.ClassIdEnum.KubernetesEthernetMatcher;
            ObjectType = KubernetesEthernetMatcher.ObjectTypeEnum.KubernetesEthernetMatcher;
            Type = KubernetesEthernetMatcher.TypeEnum.Name;

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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesEthernetMatcher.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesEthernetMatcher.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Which property we should use to find the ethernet interface.\n* `Name` - A network interface name, e.g. eth0, eno9.\n* `MacAddress` - A network interface Mac Address."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesEthernetMatcher.TypeEnum Type
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The value to match for the property specified by type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Value
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.KubernetesEthernetMatcher initObject = new Intersight.Model.KubernetesEthernetMatcher();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Type"))
            {
                initObject.Type = this.Type;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Value"))
            {
                initObject.Value = this.Value;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesHttpProxyPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesHttpProxyPolicy")]
    public class InitializeIntersightKubernetesHttpProxyPolicy : PSCmdlet
    {
        public InitializeIntersightKubernetesHttpProxyPolicy()
        {
            ClassId = KubernetesHttpProxyPolicy.ClassIdEnum.KubernetesHttpProxyPolicy;
            ObjectType = KubernetesHttpProxyPolicy.ObjectTypeEnum.KubernetesHttpProxyPolicy;

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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesHttpProxyPolicy.ClassIdEnum ClassId
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
        /// <para type="description">"The proxy configuration for HTTP communication."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.KubernetesProxyConfig HttpProxy
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The proxy configuration for HTTPS communication."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.KubernetesProxyConfig HttpsProxy
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> NoProxy
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesHttpProxyPolicy.ObjectTypeEnum ObjectType
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
            Intersight.Model.KubernetesHttpProxyPolicy initObject = new Intersight.Model.KubernetesHttpProxyPolicy();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HttpProxy"))
            {
                initObject.HttpProxy = this.HttpProxy;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HttpsProxy"))
            {
                initObject.HttpsProxy = this.HttpsProxy;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NoProxy"))
            {
                initObject.NoProxy = this.NoProxy;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Organization"))
            {
                initObject.Organization = this.Organization;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesHyperFlexApVirtualMachineInfraConfig.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesHyperFlexApVirtualMachineInfraConfig")]
    public class InitializeIntersightKubernetesHyperFlexApVirtualMachineInfraConfig : PSCmdlet
    {
        public InitializeIntersightKubernetesHyperFlexApVirtualMachineInfraConfig()
        {
            ClassId = KubernetesHyperFlexApVirtualMachineInfraConfig.ClassIdEnum.KubernetesHyperFlexApVirtualMachineInfraConfig;
            DiskMode = KubernetesHyperFlexApVirtualMachineInfraConfig.DiskModeEnum.Block;
            ObjectType = KubernetesHyperFlexApVirtualMachineInfraConfig.ObjectTypeEnum.KubernetesHyperFlexApVirtualMachineInfraConfig;

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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesHyperFlexApVirtualMachineInfraConfig.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Disk mode to use for volumes.\n* `Block` - It is a Block virtual disk.\n* `Filesystem` - It is a File system virtual disk.\n* `` - Disk mode is either unknown or not supported."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesHyperFlexApVirtualMachineInfraConfig.DiskModeEnum DiskMode
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> Interfaces
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.KubernetesNetworkInterfaceSpec> NetworkInterfaces
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesHyperFlexApVirtualMachineInfraConfig.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.KubernetesHyperFlexApVirtualMachineInfraConfig initObject = new Intersight.Model.KubernetesHyperFlexApVirtualMachineInfraConfig();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("DiskMode"))
            {
                initObject.DiskMode = this.DiskMode;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Interfaces"))
            {
                initObject.Interfaces = this.Interfaces;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NetworkInterfaces"))
            {
                initObject.NetworkInterfaces = this.NetworkInterfaces;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesIngress.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesIngress")]
    public class InitializeIntersightKubernetesIngress : PSCmdlet
    {
        public InitializeIntersightKubernetesIngress()
        {
            ClassId = KubernetesIngress.ClassIdEnum.KubernetesIngress;
            ObjectType = KubernetesIngress.ObjectTypeEnum.KubernetesIngress;

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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesIngress.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Meta data of the kubernetes resource."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.KubernetesObjectMeta Metadata
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
        /// <para type="description">"Name of the referenced kubernetes resource."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesIngress.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"IngressStatus represents the current status of the corresponding Ingress in a Kubernetes cluster. Currently, IngressStatus represents the LoadBalancer IP of the Ingress Endpoints."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.KubernetesIngressStatus Status
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
        // <summary>
        /// <para type="description">"UUID of the referenced kubernetes resource. It is generated by the kubernetes cluster itself."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Uuid
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.KubernetesIngress initObject = new Intersight.Model.KubernetesIngress();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Metadata"))
            {
                initObject.Metadata = this.Metadata;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Status"))
            {
                initObject.Status = this.Status;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Uuid"))
            {
                initObject.Uuid = this.Uuid;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesIngressStatus.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesIngressStatus")]
    public class InitializeIntersightKubernetesIngressStatus : PSCmdlet
    {
        public InitializeIntersightKubernetesIngressStatus()
        {
            ClassId = KubernetesIngressStatus.ClassIdEnum.KubernetesIngressStatus;
            ObjectType = KubernetesIngressStatus.ObjectTypeEnum.KubernetesIngressStatus;

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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesIngressStatus.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"LoadBalancer contains the current status of the load-balancer."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.KubernetesLoadBalancer LoadBalancer
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesIngressStatus.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.KubernetesIngressStatus initObject = new Intersight.Model.KubernetesIngressStatus();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("LoadBalancer"))
            {
                initObject.LoadBalancer = this.LoadBalancer;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesInstanceTypeDetails.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesInstanceTypeDetails")]
    public class InitializeIntersightKubernetesInstanceTypeDetails : PSCmdlet
    {
        public InitializeIntersightKubernetesInstanceTypeDetails()
        {
            ClassId = KubernetesInstanceTypeDetails.ClassIdEnum.KubernetesInstanceTypeDetails;
            ObjectType = KubernetesInstanceTypeDetails.ObjectTypeEnum.KubernetesInstanceTypeDetails;

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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesInstanceTypeDetails.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of CPUs in the instancetype."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Cpu
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Ephemeral disk capacity to be provided with units example - 10Gi."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long DiskSize
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Virtual machine memory defined in mebibytes (MiB)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Memory
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesInstanceTypeDetails.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.KubernetesInstanceTypeDetails initObject = new Intersight.Model.KubernetesInstanceTypeDetails();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Cpu"))
            {
                initObject.Cpu = this.Cpu;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DiskSize"))
            {
                initObject.DiskSize = this.DiskSize;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Memory"))
            {
                initObject.Memory = this.Memory;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesIpV4Config.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesIpV4Config")]
    public class InitializeIntersightKubernetesIpV4Config : PSCmdlet
    {
        public InitializeIntersightKubernetesIpV4Config()
        {
            ClassId = KubernetesIpV4Config.ClassIdEnum.KubernetesIpV4Config;
            ObjectType = KubernetesIpV4Config.ObjectTypeEnum.KubernetesIpV4Config;

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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesIpV4Config.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"IPv4 Address in CIDR format."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5]).([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5]).([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5]).([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\/([0-9]|[1-2][0-9]|3[0-2])$")]
        public string Ip
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesIpV4Config.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.KubernetesIpV4Config initObject = new Intersight.Model.KubernetesIpV4Config();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Ip"))
            {
                initObject.Ip = this.Ip;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesKeyValue.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesKeyValue")]
    public class InitializeIntersightKubernetesKeyValue : PSCmdlet
    {
        public InitializeIntersightKubernetesKeyValue()
        {
            ClassId = KubernetesKeyValue.ClassIdEnum.KubernetesKeyValue;
            ObjectType = KubernetesKeyValue.ObjectTypeEnum.KubernetesKeyValue;

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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesKeyValue.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Key or property name in a key/value pair."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Key
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesKeyValue.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Property value in a key/value pair."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Value
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.KubernetesKeyValue initObject = new Intersight.Model.KubernetesKeyValue();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Key"))
            {
                initObject.Key = this.Key;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Value"))
            {
                initObject.Value = this.Value;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesLoadBalancer.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesLoadBalancer")]
    public class InitializeIntersightKubernetesLoadBalancer : PSCmdlet
    {
        public InitializeIntersightKubernetesLoadBalancer()
        {
            ClassId = KubernetesLoadBalancer.ClassIdEnum.KubernetesLoadBalancer;
            ObjectType = KubernetesLoadBalancer.ObjectTypeEnum.KubernetesLoadBalancer;

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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesLoadBalancer.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> IpAddresses
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesLoadBalancer.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.KubernetesLoadBalancer initObject = new Intersight.Model.KubernetesLoadBalancer();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("IpAddresses"))
            {
                initObject.IpAddresses = this.IpAddresses;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesNetworkInterfaceSpec.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesNetworkInterfaceSpec")]
    public class InitializeIntersightKubernetesNetworkInterfaceSpec : PSCmdlet
    {
        public InitializeIntersightKubernetesNetworkInterfaceSpec()
        {
            ClassId = KubernetesNetworkInterfaceSpec.ClassIdEnum.KubernetesNetworkInterfaceSpec;
            ObjectType = KubernetesNetworkInterfaceSpec.ObjectTypeEnum.KubernetesNetworkInterfaceSpec;

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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesNetworkInterfaceSpec.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The MTU for this Network Interface.  If left blank a default value will apply by the Operating System."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Mtu
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"NetworkInterfaceSpec is the specification for network interfaces - including configuration of IP Pools and VRF to determine IP configuration, the operating system device settings, and virtual adapter network settings. It can be left empty when used with VirtualMachineInfraConfigPolicy - it will be filled out based on the hypervisor platform type and will match the naming and order of interfaces provided by the hypervisor."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesNetworkInterfaceSpec.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoMoRef> Pools
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"In other words, to which named network from the Instructure Provider will the port be connected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ProviderName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Allows for reusing IP Pools across disconnected L2 segments for different Kubernetes clusters within an account. If not set, the VRF named (default) will be used."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.MoMoRef Vrf
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.KubernetesNetworkInterfaceSpec initObject = new Intersight.Model.KubernetesNetworkInterfaceSpec();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Mtu"))
            {
                initObject.Mtu = this.Mtu;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Pools"))
            {
                initObject.Pools = this.Pools;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ProviderName"))
            {
                initObject.ProviderName = this.ProviderName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Vrf"))
            {
                initObject.Vrf = this.Vrf;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesNetworkPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesNetworkPolicy")]
    public class InitializeIntersightKubernetesNetworkPolicy : PSCmdlet
    {
        public InitializeIntersightKubernetesNetworkPolicy()
        {
            ClassId = KubernetesNetworkPolicy.ClassIdEnum.KubernetesNetworkPolicy;
            CniType = KubernetesNetworkPolicy.CniTypeEnum.Calico;
            ObjectType = KubernetesNetworkPolicy.ObjectTypeEnum.KubernetesNetworkPolicy;

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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesNetworkPolicy.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to kubernetesClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.KubernetesClusterProfileRelationship> ClusterProfiles
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"CNI configuration for a Kubernetes cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.KubernetesCniConfig CniConfig
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Supported CNI type. Currently we only support Calico.\n* `Calico` - Calico CNI plugin as described in https://github.com/projectcalico/cni-plugin.\n* `Aci` - Cisco ACI Container Network Interface plugin."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesNetworkPolicy.CniTypeEnum CniType
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

        public KubernetesNetworkPolicy.ObjectTypeEnum ObjectType
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
        /// <para type="description">"CIDR block to allocate Pod network IP addresses from."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5]).([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5]).([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5]).([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\/([0-9]|[1-2][0-9]|3[0-2])$")]
        public string PodNetworkCidr
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"CIDR block to allocate cluster service IP addresses from."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5]).([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5]).([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5]).([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\/([0-9]|[1-2][0-9]|3[0-2])$")]
        public string ServiceCidr
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
            Intersight.Model.KubernetesNetworkPolicy initObject = new Intersight.Model.KubernetesNetworkPolicy();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ClusterProfiles"))
            {
                initObject.ClusterProfiles = this.ClusterProfiles;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CniConfig"))
            {
                initObject.CniConfig = this.CniConfig;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CniType"))
            {
                initObject.CniType = this.CniType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("PodNetworkCidr"))
            {
                initObject.PodNetworkCidr = this.PodNetworkCidr;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ServiceCidr"))
            {
                initObject.ServiceCidr = this.ServiceCidr;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesNode.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesNode")]
    public class InitializeIntersightKubernetesNode : PSCmdlet
    {
        public InitializeIntersightKubernetesNode()
        {
            ClassId = KubernetesNode.ClassIdEnum.KubernetesNode;
            ObjectType = KubernetesNode.ObjectTypeEnum.KubernetesNode;

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
        /// <para type="description">"Kubernetes metadata annotations for a Node."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object Annotations
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesNode.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Kubernetes metadata labels for a Node."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object Labels
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Meta data of the kubernetes resource."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.KubernetesObjectMeta Metadata
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
        /// <para type="description">"Name of the referenced kubernetes resource."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.KubernetesNodeAddress> NodeAddresses
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Describes general information about the node, such as kernel version, Kubernetes version (kubelet and kube-proxy version), Docker version (if used), and OS name."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.KubernetesNodeInfo NodeInfo
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Represent the specification of a Kubernetes node."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.KubernetesNodeSpec NodeSpec
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.KubernetesNodeStatus> NodeStatuses
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesNode.ObjectTypeEnum ObjectType
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
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.KubernetesTaint> Taints
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"UUID of the referenced kubernetes resource. It is generated by the kubernetes cluster itself."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Uuid
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.KubernetesNode initObject = new Intersight.Model.KubernetesNode();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Annotations"))
            {
                initObject.Annotations = this.Annotations;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Labels"))
            {
                initObject.Labels = this.Labels;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Metadata"))
            {
                initObject.Metadata = this.Metadata;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NodeAddresses"))
            {
                initObject.NodeAddresses = this.NodeAddresses;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NodeInfo"))
            {
                initObject.NodeInfo = this.NodeInfo;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NodeSpec"))
            {
                initObject.NodeSpec = this.NodeSpec;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NodeStatuses"))
            {
                initObject.NodeStatuses = this.NodeStatuses;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Taints"))
            {
                initObject.Taints = this.Taints;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Uuid"))
            {
                initObject.Uuid = this.Uuid;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesNodeAddress.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesNodeAddress")]
    public class InitializeIntersightKubernetesNodeAddress : PSCmdlet
    {
        public InitializeIntersightKubernetesNodeAddress()
        {
            ClassId = KubernetesNodeAddress.ClassIdEnum.KubernetesNodeAddress;
            ObjectType = KubernetesNodeAddress.ObjectTypeEnum.KubernetesNodeAddress;

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
        /// <para type="description">"The address of type specified by the type field."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Address
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesNodeAddress.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesNodeAddress.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The address type of the Node. The usage of the IP address depending on the cloud provider or bare metal configuration. HostName - The hostname as reported by the node's kernel. ExternalIP - Typically the IP address of the node that is externally routable (available from outside the cluster) InternalIP - Typically the IP address of the node that is routable only within the cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Type
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.KubernetesNodeAddress initObject = new Intersight.Model.KubernetesNodeAddress();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Address"))
            {
                initObject.Address = this.Address;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Type"))
            {
                initObject.Type = this.Type;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesNodeGroupLabel.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesNodeGroupLabel")]
    public class InitializeIntersightKubernetesNodeGroupLabel : PSCmdlet
    {
        public InitializeIntersightKubernetesNodeGroupLabel()
        {
            ClassId = KubernetesNodeGroupLabel.ClassIdEnum.KubernetesNodeGroupLabel;
            ObjectType = KubernetesNodeGroupLabel.ObjectTypeEnum.KubernetesNodeGroupLabel;

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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesNodeGroupLabel.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The key for a Kubernetes label for a node."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Key
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesNodeGroupLabel.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The value for a Kubernetes label for a node."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Value
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.KubernetesNodeGroupLabel initObject = new Intersight.Model.KubernetesNodeGroupLabel();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Key"))
            {
                initObject.Key = this.Key;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Value"))
            {
                initObject.Value = this.Value;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesNodeGroupProfile.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesNodeGroupProfile")]
    public class InitializeIntersightKubernetesNodeGroupProfile : PSCmdlet
    {
        public InitializeIntersightKubernetesNodeGroupProfile()
        {
            ClassId = KubernetesNodeGroupProfile.ClassIdEnum.KubernetesNodeGroupProfile;
            NodeType = KubernetesNodeGroupProfile.NodeTypeEnum.Worker;
            ObjectType = KubernetesNodeGroupProfile.ObjectTypeEnum.KubernetesNodeGroupProfile;
            Type = KubernetesNodeGroupProfile.TypeEnum.Instance;

        }
        // <summary>
        /// <para type="description">"User initiated action. Each profile type has its own supported actions. For HyperFlex cluster profile, the supported actions are -- Validate, Deploy, Continue, Retry, Abort, Unassign For server profile, the support actions are -- Deploy, Unassign."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Action
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.PolicyActionParam> ActionParams
        {
            get;
            set;
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesNodeGroupProfile.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a kubernetesClusterProfile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.KubernetesClusterProfileRelationship ClusterProfile
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The configuration state and results of the last configuration operation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.PolicyConfigContext ConfigContext
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the profile."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Desired number of nodes in this node group, same as minsize initially and is updated by the auto-scaler."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Desiredsize
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.InfraBaseGpuConfiguration> GpuConfig
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a kubernetesBaseInfrastructureProvider resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.KubernetesBaseInfrastructureProviderRelationship InfraProvider
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to ippoolPool resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.IppoolPoolRelationship> IpPools
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a kubernetesVersionPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.KubernetesVersionPolicyRelationship KubernetesVersion
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.KubernetesNodeGroupLabel> Labels
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Maximum number of nodes this node group can scale up to during repair, replacement or upgrade operations."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Maxsize
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Minimum number of available nodes this node group can scale down to during repair, replacement or upgrade operations."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Minsize
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
        /// <para type="description">"Name of the profile instance or profile template."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The node type ControlPlane, Worker or ControlPlaneWorker.\n* `Worker` - Node will be marked as a worker node.\n* `ControlPlane` - Node will be marked as a control plane node.\n* `ControlPlaneWorker` - Node will be both a controle plane and a worker."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesNodeGroupProfile.NodeTypeEnum NodeType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to kubernetesNodeProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.KubernetesNodeProfileRelationship> Nodes
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesNodeGroupProfile.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to policyAbstractPolicy resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.PolicyAbstractPolicyRelationship> PolicyBucket
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a policyAbstractProfile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.PolicyAbstractProfileRelationship SrcTemplate
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
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.KubernetesNodeGroupTaint> Taints
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Defines the type of the profile. Accepted values are instance or template.\n* `instance` - The profile defines the configuration for a specific instance of a target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesNodeGroupProfile.TypeEnum Type
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.KubernetesNodeGroupProfile initObject = new Intersight.Model.KubernetesNodeGroupProfile();
            if (this.MyInvocation.BoundParameters.ContainsKey("Action"))
            {
                initObject.Action = this.Action;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ActionParams"))
            {
                initObject.ActionParams = this.ActionParams;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ClusterProfile"))
            {
                initObject.ClusterProfile = this.ClusterProfile;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ConfigContext"))
            {
                initObject.ConfigContext = this.ConfigContext;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Desiredsize"))
            {
                initObject.Desiredsize = this.Desiredsize;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("GpuConfig"))
            {
                initObject.GpuConfig = this.GpuConfig;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InfraProvider"))
            {
                initObject.InfraProvider = this.InfraProvider;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IpPools"))
            {
                initObject.IpPools = this.IpPools;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("KubernetesVersion"))
            {
                initObject.KubernetesVersion = this.KubernetesVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Labels"))
            {
                initObject.Labels = this.Labels;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Maxsize"))
            {
                initObject.Maxsize = this.Maxsize;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Minsize"))
            {
                initObject.Minsize = this.Minsize;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NodeType"))
            {
                initObject.NodeType = this.NodeType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Nodes"))
            {
                initObject.Nodes = this.Nodes;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("PolicyBucket"))
            {
                initObject.PolicyBucket = this.PolicyBucket;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SrcTemplate"))
            {
                initObject.SrcTemplate = this.SrcTemplate;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Taints"))
            {
                initObject.Taints = this.Taints;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Type"))
            {
                initObject.Type = this.Type;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesNodeGroupTaint.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesNodeGroupTaint")]
    public class InitializeIntersightKubernetesNodeGroupTaint : PSCmdlet
    {
        public InitializeIntersightKubernetesNodeGroupTaint()
        {
            ClassId = KubernetesNodeGroupTaint.ClassIdEnum.KubernetesNodeGroupTaint;
            ObjectType = KubernetesNodeGroupTaint.ObjectTypeEnum.KubernetesNodeGroupTaint;

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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesNodeGroupTaint.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The effect to enforce when the key does not match the value."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Effect
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The key for a Kubernetes taint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Key
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesNodeGroupTaint.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"If the key does not match this value, the specified effect is enforced."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Value
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.KubernetesNodeGroupTaint initObject = new Intersight.Model.KubernetesNodeGroupTaint();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Effect"))
            {
                initObject.Effect = this.Effect;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Key"))
            {
                initObject.Key = this.Key;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Value"))
            {
                initObject.Value = this.Value;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesNodeInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesNodeInfo")]
    public class InitializeIntersightKubernetesNodeInfo : PSCmdlet
    {
        public InitializeIntersightKubernetesNodeInfo()
        {
            ClassId = KubernetesNodeInfo.ClassIdEnum.KubernetesNodeInfo;
            ObjectType = KubernetesNodeInfo.ObjectTypeEnum.KubernetesNodeInfo;

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
        /// <para type="description">"Node Operating System architecture (amd64, arm64)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Architecture
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A Boot ID is an Identifier generated by the host everytimes it gets reboot."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string BootId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesNodeInfo.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"To run containers in Pods, Kubernetes uses a container runtime. This field describes Container Runtime Version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ContainerRuntimeVersion
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Node Operating System kernel version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string KernelVersion
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Kubernetes network proxy runs on each node. This reflects services as defined in the Kubernetes API on each node and can do simple TCP, UDP, and SCTP stream forwarding or round robin TCP, UDP, and SCTP forwarding across a set of backends. This field describes the kube-proxy version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string KubeProxyVersion
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The kubelet is the primary \"node agent\" that runs on each node. It can register the node with the apiserver using one of such as the hostname; a flag to override the hostname; or specific logic for a cloud provider. This field describes the kubelet version the node currently using."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string KubeletVersion
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"It is a node identifier in Kubernetes. When the node joins a kubernetes cluster, Kubernetes will assign a machine ID to that node. Learn more from man machine-id from http://man7.org/linux/man-pages/man5/machine-id.5.html."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string MachineId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesNodeInfo.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Operating System installed on this Node."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string OperatingSystem
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Node current Operating System image."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string OsImage
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"SystemUUID reported by the node. For unique machine identification MachineID is preferred. This field is specific to Red Hat hosts https://access.redhat.com/documentation/en-US/Red_Hat_Subscription_Management/1/html/RHSM/getting-system-uuid.html."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SystemUuid
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.KubernetesNodeInfo initObject = new Intersight.Model.KubernetesNodeInfo();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Architecture"))
            {
                initObject.Architecture = this.Architecture;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BootId"))
            {
                initObject.BootId = this.BootId;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ContainerRuntimeVersion"))
            {
                initObject.ContainerRuntimeVersion = this.ContainerRuntimeVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("KernelVersion"))
            {
                initObject.KernelVersion = this.KernelVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("KubeProxyVersion"))
            {
                initObject.KubeProxyVersion = this.KubeProxyVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("KubeletVersion"))
            {
                initObject.KubeletVersion = this.KubeletVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MachineId"))
            {
                initObject.MachineId = this.MachineId;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("OperatingSystem"))
            {
                initObject.OperatingSystem = this.OperatingSystem;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("OsImage"))
            {
                initObject.OsImage = this.OsImage;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SystemUuid"))
            {
                initObject.SystemUuid = this.SystemUuid;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesNodeSpec.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesNodeSpec")]
    public class InitializeIntersightKubernetesNodeSpec : PSCmdlet
    {
        public InitializeIntersightKubernetesNodeSpec()
        {
            ClassId = KubernetesNodeSpec.ClassIdEnum.KubernetesNodeSpec;
            ObjectType = KubernetesNodeSpec.ObjectTypeEnum.KubernetesNodeSpec;

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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesNodeSpec.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesNodeSpec.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Node Pod CIDR. In Kubernetes, the workload (Pod) is allocated to an IP address by Kubernetes. The IP address is from a Pod CIDR of the cluster. Each node will (mostly) evenly be distributed the Pod CIDR."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string PodCidr
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Kubernetes can be running on a specific cloud provider such as Openstack, Amazon Web Services, vCenter etc. Each cloud provider will have a specific cloud provider ID. This field is to represent that ID for the corresponding Kubernetes cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ProviderId
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.KubernetesNodeSpec initObject = new Intersight.Model.KubernetesNodeSpec();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("PodCidr"))
            {
                initObject.PodCidr = this.PodCidr;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ProviderId"))
            {
                initObject.ProviderId = this.ProviderId;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesNodeStatus.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesNodeStatus")]
    public class InitializeIntersightKubernetesNodeStatus : PSCmdlet
    {
        public InitializeIntersightKubernetesNodeStatus()
        {
            ClassId = KubernetesNodeStatus.ClassIdEnum.KubernetesNodeStatus;
            ObjectType = KubernetesNodeStatus.ObjectTypeEnum.KubernetesNodeStatus;

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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesNodeStatus.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesNodeStatus.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Statue of the node. Indicate if the node is kubernetes ready or not."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Status
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of the node. It can be either Master or Worker."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Type
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.KubernetesNodeStatus initObject = new Intersight.Model.KubernetesNodeStatus();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Status"))
            {
                initObject.Status = this.Status;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Type"))
            {
                initObject.Type = this.Type;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesNvidiaGpuProduct.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesNvidiaGpuProduct")]
    public class InitializeIntersightKubernetesNvidiaGpuProduct : PSCmdlet
    {
        public InitializeIntersightKubernetesNvidiaGpuProduct()
        {
            ClassId = KubernetesNvidiaGpuProduct.ClassIdEnum.KubernetesNvidiaGpuProduct;
            ObjectType = KubernetesNvidiaGpuProduct.ObjectTypeEnum.KubernetesNvidiaGpuProduct;

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
        /// <para type="description">"A reference to a kubernetesCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.KubernetesCatalogRelationship Catalog
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesNvidiaGpuProduct.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Optional description of a product."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Device Id of a product, which is unique within a vendor."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long DeviceId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Memory size of a GPU product in GB."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long MemorySize
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"True if this Nvidia GPU supports MIG."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool MigCapable
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> MigProfiles
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
        /// <para type="description">"Display Name of a product."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesNvidiaGpuProduct.ObjectTypeEnum ObjectType
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
        // <summary>
        /// <para type="description">"Vendor Id of a product. Each vendor has a globally unique Id, for example 0x10DE for Nvidia."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long VendorId
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.KubernetesNvidiaGpuProduct initObject = new Intersight.Model.KubernetesNvidiaGpuProduct();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Catalog"))
            {
                initObject.Catalog = this.Catalog;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DeviceId"))
            {
                initObject.DeviceId = this.DeviceId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MemorySize"))
            {
                initObject.MemorySize = this.MemorySize;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MigCapable"))
            {
                initObject.MigCapable = this.MigCapable;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MigProfiles"))
            {
                initObject.MigProfiles = this.MigProfiles;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VendorId"))
            {
                initObject.VendorId = this.VendorId;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesObjectMeta.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesObjectMeta")]
    public class InitializeIntersightKubernetesObjectMeta : PSCmdlet
    {
        public InitializeIntersightKubernetesObjectMeta()
        {
            ClassId = KubernetesObjectMeta.ClassIdEnum.KubernetesObjectMeta;
            ObjectType = KubernetesObjectMeta.ObjectTypeEnum.KubernetesObjectMeta;

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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesObjectMeta.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesObjectMeta.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Specific resourceVersion to which this reference is made, if any."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ResourceVersion
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.KubernetesObjectMeta initObject = new Intersight.Model.KubernetesObjectMeta();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("ResourceVersion"))
            {
                initObject.ResourceVersion = this.ResourceVersion;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesOvsBond.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesOvsBond")]
    public class InitializeIntersightKubernetesOvsBond : PSCmdlet
    {
        public InitializeIntersightKubernetesOvsBond()
        {
            ClassId = KubernetesOvsBond.ClassIdEnum.KubernetesOvsBond;
            ObjectType = KubernetesOvsBond.ObjectTypeEnum.KubernetesOvsBond;

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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> Addresses
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesOvsBond.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Deprecated. This will add a default route as long as the first default route in Routes is not different. If is different, Gateway will be replaced with that default route. If there is no default Route and this is set, then Routes will be updated with the first entry as a default with this default gateway. If there is only one default Route and this gateway becomes empty, then the default routes will all be removed. Do not set if using Ip Pools, as the gateway is configured in the pool. This will be removed in the future."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Gateway
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> Interfaces
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.KubernetesIpV4Config> IpV4Configs
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The MTU to assign to this Network Interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Mtu
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name for this network interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesOvsBond.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.KubernetesRoute> Routes
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Native VLAN for to use for the bond."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Vlan
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.KubernetesOvsBond initObject = new Intersight.Model.KubernetesOvsBond();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Addresses"))
            {
                initObject.Addresses = this.Addresses;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Gateway"))
            {
                initObject.Gateway = this.Gateway;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Interfaces"))
            {
                initObject.Interfaces = this.Interfaces;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IpV4Configs"))
            {
                initObject.IpV4Configs = this.IpV4Configs;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Mtu"))
            {
                initObject.Mtu = this.Mtu;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Routes"))
            {
                initObject.Routes = this.Routes;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Vlan"))
            {
                initObject.Vlan = this.Vlan;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesPod.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesPod")]
    public class InitializeIntersightKubernetesPod : PSCmdlet
    {
        public InitializeIntersightKubernetesPod()
        {
            ClassId = KubernetesPod.ClassIdEnum.KubernetesPod;
            ObjectType = KubernetesPod.ObjectTypeEnum.KubernetesPod;

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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesPod.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Meta data of the kubernetes resource."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.KubernetesObjectMeta Metadata
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
        /// <para type="description">"Name of the referenced kubernetes resource."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesPod.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"PodStatus represent the status of the Pod in the corresponding Kubernetes cluster. It report the Pod status such as the Pod IP, IP of the Host that is running the Pod, Pod start time and the Pod Phase. For the Pod Phase, please refer to [Kubernetes Document](https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle/)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.KubernetesPodStatus Status
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
        // <summary>
        /// <para type="description">"UUID of the referenced kubernetes resource. It is generated by the kubernetes cluster itself."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Uuid
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.KubernetesPod initObject = new Intersight.Model.KubernetesPod();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Metadata"))
            {
                initObject.Metadata = this.Metadata;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Status"))
            {
                initObject.Status = this.Status;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Uuid"))
            {
                initObject.Uuid = this.Uuid;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesPodStatus.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesPodStatus")]
    public class InitializeIntersightKubernetesPodStatus : PSCmdlet
    {
        public InitializeIntersightKubernetesPodStatus()
        {
            ClassId = KubernetesPodStatus.ClassIdEnum.KubernetesPodStatus;
            ObjectType = KubernetesPodStatus.ObjectTypeEnum.KubernetesPodStatus;

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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesPodStatus.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The IP of the host that the pod is running on."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string HostIp
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesPodStatus.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The phase of a Pod is a simple, high-level summary of where the Pod is in its lifecycle."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Phase
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The IP of the pod. The IP is allocated by the Pod CIDR from the kubernetes cluster itself."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string PodIp
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Quality of Service (QOS) classification assigned to the pod based on resource requirements."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string QosClass
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The time that the pod was started."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string StartTime
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.KubernetesPodStatus initObject = new Intersight.Model.KubernetesPodStatus();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("HostIp"))
            {
                initObject.HostIp = this.HostIp;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Phase"))
            {
                initObject.Phase = this.Phase;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PodIp"))
            {
                initObject.PodIp = this.PodIp;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("QosClass"))
            {
                initObject.QosClass = this.QosClass;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("StartTime"))
            {
                initObject.StartTime = this.StartTime;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesProxyConfig.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesProxyConfig")]
    public class InitializeIntersightKubernetesProxyConfig : PSCmdlet
    {
        public InitializeIntersightKubernetesProxyConfig()
        {
            ClassId = KubernetesProxyConfig.ClassIdEnum.KubernetesProxyConfig;
            ObjectType = KubernetesProxyConfig.ObjectTypeEnum.KubernetesProxyConfig;

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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesProxyConfig.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"HTTP/HTTPS Proxy server FQDN or IP."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[A-Za-z]([A-Za-z0-9-]*[A-Za-z0-9])?$|^[A-Za-z0-9]([A-Za-z0-9-]*[A-Za-z0-9])?(\\.[A-Za-z0-9]([A-Za-z0-9-]*[A-Za-z0-9])?)*(\\.[A-Za-z]([A-Za-z0-9-]*[A-Za-z0-9])?)$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string Hostname
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesProxyConfig.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The password for the HTTP/HTTPS Proxy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Password
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The HTTP Proxy port number.\nThe port number of the HTTP/HTTPS proxy must be between 1 and 65535, inclusive."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 65535)]
        public long Port
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Protocol to use for the HTTP/HTTPS Proxy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Protocol
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The username for the HTTP/HTTPS Proxy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Username
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.KubernetesProxyConfig initObject = new Intersight.Model.KubernetesProxyConfig();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Hostname"))
            {
                initObject.Hostname = this.Hostname;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Password"))
            {
                initObject.Password = this.Password;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Port"))
            {
                initObject.Port = this.Port;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Protocol"))
            {
                initObject.Protocol = this.Protocol;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Username"))
            {
                initObject.Username = this.Username;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesRoute.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesRoute")]
    public class InitializeIntersightKubernetesRoute : PSCmdlet
    {
        public InitializeIntersightKubernetesRoute()
        {
            ClassId = KubernetesRoute.ClassIdEnum.KubernetesRoute;
            ObjectType = KubernetesRoute.ObjectTypeEnum.KubernetesRoute;

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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesRoute.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesRoute.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The destination subnet, if set to 0.0.0.0/0 then the Route is considered a default route."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5]).([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5]).([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5]).([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\/([0-9]|[1-2][0-9]|3[0-2])$")]
        public string To
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Via is the gateway for traffic destined for the subnet in the To property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string Via
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.KubernetesRoute initObject = new Intersight.Model.KubernetesRoute();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("To"))
            {
                initObject.To = this.To;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Via"))
            {
                initObject.Via = this.Via;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesService.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesService")]
    public class InitializeIntersightKubernetesService : PSCmdlet
    {
        public InitializeIntersightKubernetesService()
        {
            ClassId = KubernetesService.ClassIdEnum.KubernetesService;
            ObjectType = KubernetesService.ObjectTypeEnum.KubernetesService;

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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesService.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Meta data of the kubernetes resource."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.KubernetesObjectMeta Metadata
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
        /// <para type="description">"Name of the referenced kubernetes resource."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesService.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Status of the kubernetes service. It reflects the Kubernetes Load Balancer Type (Cluster IP, NodePort and LoadBalancer). If the service is a LoadBalancer type of service, it will also report the LoadBalancer IP."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.KubernetesServiceStatus Status
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
        // <summary>
        /// <para type="description">"UUID of the referenced kubernetes resource. It is generated by the kubernetes cluster itself."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Uuid
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.KubernetesService initObject = new Intersight.Model.KubernetesService();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Metadata"))
            {
                initObject.Metadata = this.Metadata;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Status"))
            {
                initObject.Status = this.Status;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Uuid"))
            {
                initObject.Uuid = this.Uuid;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesServiceStatus.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesServiceStatus")]
    public class InitializeIntersightKubernetesServiceStatus : PSCmdlet
    {
        public InitializeIntersightKubernetesServiceStatus()
        {
            ClassId = KubernetesServiceStatus.ClassIdEnum.KubernetesServiceStatus;
            ObjectType = KubernetesServiceStatus.ObjectTypeEnum.KubernetesServiceStatus;

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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesServiceStatus.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"It reflects the Kubernetes Load Balancer Type (Cluster IP, NodePort and LoadBalancer). If the service is a LoadBalancer type of service, it will also report the LoadBalancer IP."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.KubernetesLoadBalancer LoadBalancer
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesServiceStatus.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.KubernetesServiceStatus initObject = new Intersight.Model.KubernetesServiceStatus();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("LoadBalancer"))
            {
                initObject.LoadBalancer = this.LoadBalancer;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesStatefulSet.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesStatefulSet")]
    public class InitializeIntersightKubernetesStatefulSet : PSCmdlet
    {
        public InitializeIntersightKubernetesStatefulSet()
        {
            ClassId = KubernetesStatefulSet.ClassIdEnum.KubernetesStatefulSet;
            ObjectType = KubernetesStatefulSet.ObjectTypeEnum.KubernetesStatefulSet;

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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesStatefulSet.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Meta data of the kubernetes resource."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.KubernetesObjectMeta Metadata
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
        /// <para type="description">"Name of the referenced kubernetes resource."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesStatefulSet.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"StatefuleSetStatus represents the current status of the corresponding StatefuleSet in a Kubernetes cluster. It reports several number of statefulset useful information such as replicas count, updated replicas, etc. For details, please refer to kubernetes.StatefuleSetStatus."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.KubernetesStatefulSetStatus Status
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
        // <summary>
        /// <para type="description">"UUID of the referenced kubernetes resource. It is generated by the kubernetes cluster itself."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Uuid
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.KubernetesStatefulSet initObject = new Intersight.Model.KubernetesStatefulSet();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Metadata"))
            {
                initObject.Metadata = this.Metadata;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Status"))
            {
                initObject.Status = this.Status;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Uuid"))
            {
                initObject.Uuid = this.Uuid;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesStatefulSetStatus.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesStatefulSetStatus")]
    public class InitializeIntersightKubernetesStatefulSetStatus : PSCmdlet
    {
        public InitializeIntersightKubernetesStatefulSetStatus()
        {
            ClassId = KubernetesStatefulSetStatus.ClassIdEnum.KubernetesStatefulSetStatus;
            ObjectType = KubernetesStatefulSetStatus.ObjectTypeEnum.KubernetesStatefulSetStatus;

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
        /// <para type="description">"AvailableReplicas indicates the current avaliable replicas running."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long AvailableReplicas
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesStatefulSetStatus.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"CollisionCount is the count of hash collisions for the StatefulSet. The StatefulSet controller uses this field as a collision avoidance mechanism when it needs to create the name for the newest ControllerRevision."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long CollisionCount
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"CurrentRevision, if not empty, indicates the version of the StatefulSet used to generate Pods."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string CurrentRevision
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesStatefulSetStatus.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"ObservedGeneration is the most recent generation observed for this StatefulSet. It corresponds to the StatefulSet's generation, which is updated on mutation by the API Server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long ObservedGeneration
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"ReadyReplicas is the number of Pods created by the StatefulSet controller that have a Ready Condition."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long ReadyReplicas
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of replicas the statefulset desired to have."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Replicas
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"UpdateRevision, if not empty, indicates the version of the StatefulSet used to generate the pods that have yet to be updated, i.e. pod number <replicas> - <updatedReplicas>, until pod number <replicas>."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string UpdateRevision
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"UpdatedReplicas is the number of Pods created by the StatefulSet controller from the StatefulSet version indicated by updateRevision."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long UpdatedReplicas
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.KubernetesStatefulSetStatus initObject = new Intersight.Model.KubernetesStatefulSetStatus();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AvailableReplicas"))
            {
                initObject.AvailableReplicas = this.AvailableReplicas;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("CollisionCount"))
            {
                initObject.CollisionCount = this.CollisionCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CurrentRevision"))
            {
                initObject.CurrentRevision = this.CurrentRevision;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("ObservedGeneration"))
            {
                initObject.ObservedGeneration = this.ObservedGeneration;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ReadyReplicas"))
            {
                initObject.ReadyReplicas = this.ReadyReplicas;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Replicas"))
            {
                initObject.Replicas = this.Replicas;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UpdateRevision"))
            {
                initObject.UpdateRevision = this.UpdateRevision;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UpdatedReplicas"))
            {
                initObject.UpdatedReplicas = this.UpdatedReplicas;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesSysConfigPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesSysConfigPolicy")]
    public class InitializeIntersightKubernetesSysConfigPolicy : PSCmdlet
    {
        public InitializeIntersightKubernetesSysConfigPolicy()
        {
            ClassId = KubernetesSysConfigPolicy.ClassIdEnum.KubernetesSysConfigPolicy;
            ObjectType = KubernetesSysConfigPolicy.ObjectTypeEnum.KubernetesSysConfigPolicy;
            Timezone = KubernetesSysConfigPolicy.TimezoneEnum.PacificNiue;

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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesSysConfigPolicy.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to kubernetesClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.KubernetesClusterProfileRelationship> ClusterProfiles
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
        /// <para type="description">"The DNS Search Domain Name."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^([a-zA-Z0-9]([a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?\\.)+[a-zA-Z]{2,63}$")]
        public string DnsDomainName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> DnsServers
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> NtpServers
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesSysConfigPolicy.ObjectTypeEnum ObjectType
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The timezone of the node's system clock.\n* `Pacific/Niue` - \n* `Pacific/Pago_Pago` - \n* `Pacific/Honolulu` - \n* `Pacific/Rarotonga` - \n* `Pacific/Tahiti` - \n* `Pacific/Marquesas` - \n* `America/Anchorage` - \n* `Pacific/Gambier` - \n* `America/Los_Angeles` - \n* `America/Tijuana` - \n* `America/Vancouver` - \n* `America/Whitehorse` - \n* `Pacific/Pitcairn` - \n* `America/Dawson_Creek` - \n* `America/Denver` - \n* `America/Edmonton` - \n* `America/Hermosillo` - \n* `America/Mazatlan` - \n* `America/Phoenix` - \n* `America/Yellowknife` - \n* `America/Belize` - \n* `America/Chicago` - \n* `America/Costa_Rica` - \n* `America/El_Salvador` - \n* `America/Guatemala` - \n* `America/Managua` - \n* `America/Mexico_City` - \n* `America/Regina` - \n* `America/Tegucigalpa` - \n* `America/Winnipeg` - \n* `Pacific/Galapagos` - \n* `America/Bogota` - \n* `America/Cancun` - \n* `America/Cayman` - \n* `America/Guayaquil` - \n* `America/Havana` - \n* `America/Iqaluit` - \n* `America/Jamaica` - \n* `America/Lima` - \n* `America/Nassau` - \n* `America/New_York` - \n* `America/Nuuk` - \n* `America/Panama` - \n* `America/Port-au-Prince` - \n* `America/Rio_Branco` - \n* `America/Toronto` - \n* `Pacific/Easter` - \n* `America/Caracas` - \n* `America/Asuncion` - \n* `America/Barbados` - \n* `America/Boa_Vista` - \n* `America/Campo_Grande` - \n* `America/Cuiaba` - \n* `America/Curacao` - \n* `America/Grand_Turk` - \n* `America/Guyana` - \n* `America/Halifax` - \n* `America/La_Paz` - \n* `America/Manaus` - \n* `America/Martinique` - \n* `America/Port_of_Spain` - \n* `America/Porto_Velho` - \n* `America/Puerto_Rico` - \n* `America/Santo_Domingo` - \n* `America/Thule` - \n* `Atlantic/Bermuda` - \n* `America/St_Johns` - \n* `America/Araguaina` - \n* `America/Argentina/Buenos_Aires` - \n* `America/Bahia` - \n* `America/Belem` - \n* `America/Cayenne` - \n* `America/Fortaleza` - \n* `America/Godthab` - \n* `America/Maceio` - \n* `America/Miquelon` - \n* `America/Montevideo` - \n* `America/Paramaribo` - \n* `America/Recife` - \n* `America/Santiago` - \n* `America/Sao_Paulo` - \n* `Antarctica/Palmer` - \n* `Antarctica/Rothera` - \n* `Atlantic/Stanley` - \n* `America/Noronha` - \n* `Atlantic/South_Georgia` - \n* `America/Scoresbysund` - \n* `Atlantic/Azores` - \n* `Atlantic/Cape_Verde` - \n* `Africa/Abidjan` - \n* `Africa/Accra` - \n* `Africa/Bissau` - \n* `Africa/Casablanca` - \n* `Africa/El_Aaiun` - \n* `Africa/Monrovia` - \n* `America/Danmarkshavn` - \n* `Atlantic/Canary` - \n* `Atlantic/Faroe` - \n* `Atlantic/Reykjavik` - \n* `Etc/GMT` - \n* `Europe/Dublin` - \n* `Europe/Lisbon` - \n* `Europe/London` - \n* `Africa/Algiers` - \n* `Africa/Ceuta` - \n* `Africa/Lagos` - \n* `Africa/Ndjamena` - \n* `Africa/Tunis` - \n* `Africa/Windhoek` - \n* `Europe/Amsterdam` - \n* `Europe/Andorra` - \n* `Europe/Belgrade` - \n* `Europe/Berlin` - \n* `Europe/Brussels` - \n* `Europe/Budapest` - \n* `Europe/Copenhagen` - \n* `Europe/Gibraltar` - \n* `Europe/Luxembourg` - \n* `Europe/Madrid` - \n* `Europe/Malta` - \n* `Europe/Monaco` - \n* `Europe/Oslo` - \n* `Europe/Paris` - \n* `Europe/Prague` - \n* `Europe/Rome` - \n* `Europe/Stockholm` - \n* `Europe/Tirane` - \n* `Europe/Vienna` - \n* `Europe/Warsaw` - \n* `Europe/Zurich` - \n* `Africa/Cairo` - \n* `Africa/Johannesburg` - \n* `Africa/Maputo` - \n* `Africa/Tripoli` - \n* `Asia/Amman` - \n* `Asia/Beirut` - \n* `Asia/Damascus` - \n* `Asia/Gaza` - \n* `Asia/Jerusalem` - \n* `Asia/Nicosia` - \n* `Europe/Athens` - \n* `Europe/Bucharest` - \n* `Europe/Chisinau` - \n* `Europe/Helsinki` - \n* `Europe/Istanbul` - \n* `Europe/Kaliningrad` - \n* `Europe/Kiev` - \n* `Europe/Riga` - \n* `Europe/Sofia` - \n* `Europe/Tallinn` - \n* `Europe/Vilnius` - \n* `Africa/Khartoum` - \n* `Africa/Nairobi` - \n* `Antarctica/Syowa` - \n* `Asia/Baghdad` - \n* `Asia/Qatar` - \n* `Asia/Riyadh` - \n* `Europe/Minsk` - \n* `Europe/Moscow` - \n* `Asia/Tehran` - \n* `Asia/Baku` - \n* `Asia/Dubai` - \n* `Asia/Tbilisi` - \n* `Asia/Yerevan` - \n* `Europe/Samara` - \n* `Indian/Mahe` - \n* `Indian/Mauritius` - \n* `Indian/Reunion` - \n* `Asia/Kabul` - \n* `Antarctica/Mawson` - \n* `Asia/Aqtau` - \n* `Asia/Aqtobe` - \n* `Asia/Ashgabat` - \n* `Asia/Dushanbe` - \n* `Asia/Karachi` - \n* `Asia/Tashkent` - \n* `Asia/Yekaterinburg` - \n* `Indian/Kerguelen` - \n* `Indian/Maldives` - \n* `Asia/Calcutta` - \n* `Asia/Kolkata` - \n* `Asia/Colombo` - \n* `Asia/Kathmandu` - \n* `Asia/Katmandu` - \n* `Antarctica/Vostok` - \n* `Asia/Almaty` - \n* `Asia/Bishkek` - \n* `Asia/Dhaka` - \n* `Asia/Omsk` - \n* `Asia/Thimphu` - \n* `Indian/Chagos` - \n* `Asia/Rangoon` - \n* `Indian/Cocos` - \n* `Antarctica/Davis` - \n* `Asia/Bangkok` - \n* `Asia/Ho_Chi_Minh` - \n* `Asia/Hovd` - \n* `Asia/Jakarta` - \n* `Asia/Krasnoyarsk` - \n* `Asia/Saigon` - \n* `Indian/Christmas` - \n* `Antarctica/Casey` - \n* `Asia/Brunei` - \n* `Asia/Choibalsan` - \n* `Asia/Hong_Kong` - \n* `Asia/Irkutsk` - \n* `Asia/Kuala_Lumpur` - \n* `Asia/Macau` - \n* `Asia/Makassar` - \n* `Asia/Manila` - \n* `Asia/Shanghai` - \n* `Asia/Singapore` - \n* `Asia/Taipei` - \n* `Asia/Ulaanbaatar` - \n* `Australia/Perth` - \n* `Asia/Pyongyang` - \n* `Asia/Dili` - \n* `Asia/Jayapura` - \n* `Asia/Seoul` - \n* `Asia/Tokyo` - \n* `Asia/Yakutsk` - \n* `Asia/Yangon` - \n* `Pacific/Palau` - \n* `Australia/Adelaide` - \n* `Australia/Darwin` - \n* `Antarctica/DumontDUrville` - \n* `Asia/Magadan` - \n* `Asia/Vladivostok` - \n* `Australia/Brisbane` - \n* `Australia/Hobart` - \n* `Australia/Sydney` - \n* `Pacific/Chuuk` - \n* `Pacific/Guam` - \n* `Pacific/Port_Moresby` - \n* `Pacific/Efate` - \n* `Pacific/Guadalcanal` - \n* `Pacific/Kosrae` - \n* `Pacific/Norfolk` - \n* `Pacific/Noumea` - \n* `Pacific/Pohnpei` - \n* `Asia/Kamchatka` - \n* `Pacific/Auckland` - \n* `Pacific/Fiji` - \n* `Pacific/Funafuti` - \n* `Pacific/Kwajalein` - \n* `Pacific/Majuro` - \n* `Pacific/Nauru` - \n* `Pacific/Tarawa` - \n* `Pacific/Wake` - \n* `Pacific/Wallis` - \n* `Pacific/Apia` - \n* `Pacific/Enderbury` - \n* `Pacific/Fakaofo` - \n* `Pacific/Tongatapu` - \n* `Pacific/Kiritimati` -"</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesSysConfigPolicy.TimezoneEnum Timezone
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.KubernetesSysConfigPolicy initObject = new Intersight.Model.KubernetesSysConfigPolicy();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ClusterProfiles"))
            {
                initObject.ClusterProfiles = this.ClusterProfiles;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DnsDomainName"))
            {
                initObject.DnsDomainName = this.DnsDomainName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DnsServers"))
            {
                initObject.DnsServers = this.DnsServers;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NtpServers"))
            {
                initObject.NtpServers = this.NtpServers;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Organization"))
            {
                initObject.Organization = this.Organization;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Timezone"))
            {
                initObject.Timezone = this.Timezone;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesTaint.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesTaint")]
    public class InitializeIntersightKubernetesTaint : PSCmdlet
    {
        public InitializeIntersightKubernetesTaint()
        {
            ClassId = KubernetesTaint.ClassIdEnum.KubernetesTaint;
            ObjectType = KubernetesTaint.ObjectTypeEnum.KubernetesTaint;

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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesTaint.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Effect of the taint is one of the following NoSchedule,\nPreferNoSchedule, NoExecute."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Effect
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The key is any string, up to 253 characters. The key must begin\nwith a letter or number, and may contain letters, numbers,\nhyphens, dots, and underscores."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Key
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesTaint.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The value is any string, up to 63 characters. The value must\nbegin with a letter or number, and may contain letters,\nnumbers, hyphens, dots, and underscores."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Value
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.KubernetesTaint initObject = new Intersight.Model.KubernetesTaint();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Effect"))
            {
                initObject.Effect = this.Effect;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Key"))
            {
                initObject.Key = this.Key;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Value"))
            {
                initObject.Value = this.Value;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesTrustedRegistriesPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesTrustedRegistriesPolicy")]
    public class InitializeIntersightKubernetesTrustedRegistriesPolicy : PSCmdlet
    {
        public InitializeIntersightKubernetesTrustedRegistriesPolicy()
        {
            ClassId = KubernetesTrustedRegistriesPolicy.ClassIdEnum.KubernetesTrustedRegistriesPolicy;
            ObjectType = KubernetesTrustedRegistriesPolicy.ObjectTypeEnum.KubernetesTrustedRegistriesPolicy;

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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesTrustedRegistriesPolicy.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to kubernetesClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.KubernetesClusterProfileRelationship> ClusterProfiles
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

        public KubernetesTrustedRegistriesPolicy.ObjectTypeEnum ObjectType
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> RootCaRegistries
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
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> UnsignedRegistries
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.KubernetesTrustedRegistriesPolicy initObject = new Intersight.Model.KubernetesTrustedRegistriesPolicy();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ClusterProfiles"))
            {
                initObject.ClusterProfiles = this.ClusterProfiles;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("RootCaRegistries"))
            {
                initObject.RootCaRegistries = this.RootCaRegistries;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UnsignedRegistries"))
            {
                initObject.UnsignedRegistries = this.UnsignedRegistries;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesVersion.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesVersion")]
    public class InitializeIntersightKubernetesVersion : PSCmdlet
    {
        public InitializeIntersightKubernetesVersion()
        {
            ClassId = Model.KubernetesVersion.ClassIdEnum.KubernetesVersion;
            ObjectType = Model.KubernetesVersion.ObjectTypeEnum.KubernetesVersion;

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
        /// <para type="description">"A reference to a softwareSolutionDistributable resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.SoftwareSolutionDistributableRelationship BootIso
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a kubernetesCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.KubernetesCatalogRelationship Catalog
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.KubernetesVersion.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.KubernetesAddonVersionReference> EssentialAddons
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version of helm operator to use for this kubernetes version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string HelmOperatorVersion
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The iks utility container to use for the kubernetes version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string IksUtilityContainer
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Desired Kubernetes version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^v[0-9]+\\.[0-9]+\\.[0-9]+$")]
        public string KubernetesVersion
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
        /// <para type="description">"The name of this IKS kubernetes version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.KubernetesVersion.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a softwareSolutionDistributable resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.SoftwareSolutionDistributableRelationship OvaImageTemplate
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a softwareSolutionDistributable resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.SoftwareSolutionDistributableRelationship Qcow2NodeTemplate
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a softwareSolutionDistributable resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.SoftwareSolutionDistributableRelationship Qcow2VirtualMachineTemplate
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
            Intersight.Model.KubernetesVersion initObject = new Intersight.Model.KubernetesVersion();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BootIso"))
            {
                initObject.BootIso = this.BootIso;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Catalog"))
            {
                initObject.Catalog = this.Catalog;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("EssentialAddons"))
            {
                initObject.EssentialAddons = this.EssentialAddons;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HelmOperatorVersion"))
            {
                initObject.HelmOperatorVersion = this.HelmOperatorVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IksUtilityContainer"))
            {
                initObject.IksUtilityContainer = this.IksUtilityContainer;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("KubernetesVersion"))
            {
                initObject._KubernetesVersion = this.KubernetesVersion;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("OvaImageTemplate"))
            {
                initObject.OvaImageTemplate = this.OvaImageTemplate;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Qcow2NodeTemplate"))
            {
                initObject.Qcow2NodeTemplate = this.Qcow2NodeTemplate;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Qcow2VirtualMachineTemplate"))
            {
                initObject.Qcow2VirtualMachineTemplate = this.Qcow2VirtualMachineTemplate;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesVersionPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesVersionPolicy")]
    public class InitializeIntersightKubernetesVersionPolicy : PSCmdlet
    {
        public InitializeIntersightKubernetesVersionPolicy()
        {
            ClassId = KubernetesVersionPolicy.ClassIdEnum.KubernetesVersionPolicy;
            ObjectType = KubernetesVersionPolicy.ObjectTypeEnum.KubernetesVersionPolicy;

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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesVersionPolicy.ClassIdEnum ClassId
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

        public KubernetesVersionPolicy.ObjectTypeEnum ObjectType
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
        /// <para type="description">"An array of relationships to kubernetesNodeGroupProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.KubernetesNodeGroupProfileRelationship> Profiles
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
        // <summary>
        /// <para type="description">"A reference to a kubernetesVersion resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.KubernetesVersionRelationship Version
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.KubernetesVersionPolicy initObject = new Intersight.Model.KubernetesVersionPolicy();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Profiles"))
            {
                initObject.Profiles = this.Profiles;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Version"))
            {
                initObject._Version = this.Version;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesVirtualMachineInfraConfigPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesVirtualMachineInfraConfigPolicy")]
    public class InitializeIntersightKubernetesVirtualMachineInfraConfigPolicy : PSCmdlet
    {
        public InitializeIntersightKubernetesVirtualMachineInfraConfigPolicy()
        {
            ClassId = KubernetesVirtualMachineInfraConfigPolicy.ClassIdEnum.KubernetesVirtualMachineInfraConfigPolicy;
            ObjectType = KubernetesVirtualMachineInfraConfigPolicy.ObjectTypeEnum.KubernetesVirtualMachineInfraConfigPolicy;

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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesVirtualMachineInfraConfigPolicy.ClassIdEnum ClassId
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

        public KubernetesVirtualMachineInfraConfigPolicy.ObjectTypeEnum ObjectType
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
        /// <para type="description">"An array of relationships to kubernetesVirtualMachineInfrastructureProvider resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.KubernetesVirtualMachineInfrastructureProviderRelationship> Profiles
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
        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.AssetDeviceRegistrationRelationship Target
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Virtual machine infrastucture provider allocation properties."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.KubernetesBaseVirtualMachineInfraConfig VmConfig
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.KubernetesVirtualMachineInfraConfigPolicy initObject = new Intersight.Model.KubernetesVirtualMachineInfraConfigPolicy();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Profiles"))
            {
                initObject.Profiles = this.Profiles;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Target"))
            {
                initObject.Target = this.Target;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VmConfig"))
            {
                initObject.VmConfig = this.VmConfig;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesVirtualMachineInfrastructureProvider.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesVirtualMachineInfrastructureProvider")]
    public class InitializeIntersightKubernetesVirtualMachineInfrastructureProvider : PSCmdlet
    {
        public InitializeIntersightKubernetesVirtualMachineInfrastructureProvider()
        {
            ClassId = KubernetesVirtualMachineInfrastructureProvider.ClassIdEnum.KubernetesVirtualMachineInfrastructureProvider;
            ObjectType = KubernetesVirtualMachineInfrastructureProvider.ObjectTypeEnum.KubernetesVirtualMachineInfrastructureProvider;

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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesVirtualMachineInfrastructureProvider.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description for the infrastructure provider."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Virtual machine infrastucture provider allocation properties."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.KubernetesBaseVirtualMachineInfraConfig InfraConfig
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a kubernetesVirtualMachineInfraConfigPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.KubernetesVirtualMachineInfraConfigPolicyRelationship InfraConfigPolicy
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a kubernetesVirtualMachineInstanceType resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.KubernetesVirtualMachineInstanceTypeRelationship InstanceType
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
        /// <para type="description">"Name of an infrastructure provider."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a kubernetesNodeGroupProfile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.KubernetesNodeGroupProfileRelationship NodeGroup
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesVirtualMachineInfrastructureProvider.ObjectTypeEnum ObjectType
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
        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.AssetDeviceRegistrationRelationship Target
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.KubernetesVirtualMachineInfrastructureProvider initObject = new Intersight.Model.KubernetesVirtualMachineInfrastructureProvider();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InfraConfig"))
            {
                initObject.InfraConfig = this.InfraConfig;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InfraConfigPolicy"))
            {
                initObject.InfraConfigPolicy = this.InfraConfigPolicy;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InstanceType"))
            {
                initObject.InstanceType = this.InstanceType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NodeGroup"))
            {
                initObject.NodeGroup = this.NodeGroup;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Target"))
            {
                initObject.Target = this.Target;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesVirtualMachineInstanceType.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesVirtualMachineInstanceType")]
    public class InitializeIntersightKubernetesVirtualMachineInstanceType : PSCmdlet
    {
        public InitializeIntersightKubernetesVirtualMachineInstanceType()
        {
            ClassId = KubernetesVirtualMachineInstanceType.ClassIdEnum.KubernetesVirtualMachineInstanceType;
            ObjectType = KubernetesVirtualMachineInstanceType.ObjectTypeEnum.KubernetesVirtualMachineInstanceType;

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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesVirtualMachineInstanceType.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of CPUs allocated to virtual machine."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 40)]
        public long Cpu
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
        /// <para type="description">"Ephemeral disk capacity to be provided with units example - 10Gi."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long DiskSize
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Virtual machine memory defined in mebibytes (MiB)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 4.17792e+06)]
        public long Memory
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

        public KubernetesVirtualMachineInstanceType.ObjectTypeEnum ObjectType
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
        /// <para type="description">"An array of relationships to kubernetesVirtualMachineInfrastructureProvider resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.KubernetesVirtualMachineInfrastructureProviderRelationship> Profiles
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
            Intersight.Model.KubernetesVirtualMachineInstanceType initObject = new Intersight.Model.KubernetesVirtualMachineInstanceType();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Cpu"))
            {
                initObject.Cpu = this.Cpu;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DiskSize"))
            {
                initObject.DiskSize = this.DiskSize;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Memory"))
            {
                initObject.Memory = this.Memory;
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
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesVirtualMachineNodeProfile.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesVirtualMachineNodeProfile")]
    public class InitializeIntersightKubernetesVirtualMachineNodeProfile : PSCmdlet
    {
        public InitializeIntersightKubernetesVirtualMachineNodeProfile()
        {
            ClassId = KubernetesVirtualMachineNodeProfile.ClassIdEnum.KubernetesVirtualMachineNodeProfile;
            CloudProvider = KubernetesVirtualMachineNodeProfile.CloudProviderEnum.NoProvider;
            ObjectType = KubernetesVirtualMachineNodeProfile.ObjectTypeEnum.KubernetesVirtualMachineNodeProfile;
            Type = KubernetesVirtualMachineNodeProfile.TypeEnum.Instance;

        }
        // <summary>
        /// <para type="description">"User initiated action. Each profile type has its own supported actions. For HyperFlex cluster profile, the supported actions are -- Validate, Deploy, Continue, Retry, Abort, Unassign For server profile, the support actions are -- Deploy, Unassign."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Action
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.PolicyActionParam> ActionParams
        {
            get;
            set;
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesVirtualMachineNodeProfile.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Cloud provider for this node profile.\n* `noProvider` - Enables the use of no cloud provider.\n* `external` - Out of tree cloud provider, e.g. CPI for vsphere."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesVirtualMachineNodeProfile.CloudProviderEnum CloudProvider
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The configuration state and results of the last configuration operation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.PolicyConfigContext ConfigContext
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the profile."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.KubernetesEthernet> Interfaces
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to ippoolIpLease resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.IppoolIpLeaseRelationship> IpAddresses
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
        /// <para type="description">"Name of the profile instance or profile template."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a kubernetesNodeGroupProfile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.KubernetesNodeGroupProfileRelationship NodeGroup
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesVirtualMachineNodeProfile.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to policyAbstractPolicy resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.PolicyAbstractPolicyRelationship> PolicyBucket
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a policyAbstractProfile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.PolicyAbstractProfileRelationship SrcTemplate
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
        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.AssetDeviceRegistrationRelationship Target
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Defines the type of the profile. Accepted values are instance or template.\n* `instance` - The profile defines the configuration for a specific instance of a target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public KubernetesVirtualMachineNodeProfile.TypeEnum Type
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a virtualizationVirtualMachine resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VirtualizationVirtualMachineRelationship VirtualMachine
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.KubernetesVirtualMachineNodeProfile initObject = new Intersight.Model.KubernetesVirtualMachineNodeProfile();
            if (this.MyInvocation.BoundParameters.ContainsKey("Action"))
            {
                initObject.Action = this.Action;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ActionParams"))
            {
                initObject.ActionParams = this.ActionParams;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("CloudProvider"))
            {
                initObject.CloudProvider = this.CloudProvider;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ConfigContext"))
            {
                initObject.ConfigContext = this.ConfigContext;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Interfaces"))
            {
                initObject.Interfaces = this.Interfaces;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IpAddresses"))
            {
                initObject.IpAddresses = this.IpAddresses;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NodeGroup"))
            {
                initObject.NodeGroup = this.NodeGroup;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("PolicyBucket"))
            {
                initObject.PolicyBucket = this.PolicyBucket;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SrcTemplate"))
            {
                initObject.SrcTemplate = this.SrcTemplate;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Target"))
            {
                initObject.Target = this.Target;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Type"))
            {
                initObject.Type = this.Type;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VirtualMachine"))
            {
                initObject.VirtualMachine = this.VirtualMachine;
            }
            WriteObject(initObject);
        }

    }
}