using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexAlarm.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexAlarm")]
    public class InitializeIntersightHyperflexAlarm : PSCmdlet
    {
        public InitializeIntersightHyperflexAlarm()
        {
            ClassId = HyperflexAlarm.ClassIdEnum.HyperflexAlarm;
            ObjectType = HyperflexAlarm.ObjectTypeEnum.HyperflexAlarm;

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

        public HyperflexAlarm.ClassIdEnum ClassId
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

        public HyperflexAlarm.ObjectTypeEnum ObjectType
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
            Intersight.Model.HyperflexAlarm initObject = new Intersight.Model.HyperflexAlarm();
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexAlarmSummary.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexAlarmSummary")]
    public class InitializeIntersightHyperflexAlarmSummary : PSCmdlet
    {
        public InitializeIntersightHyperflexAlarmSummary()
        {
            ClassId = HyperflexAlarmSummary.ClassIdEnum.HyperflexAlarmSummary;
            ObjectType = HyperflexAlarmSummary.ObjectTypeEnum.HyperflexAlarmSummary;

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

        public HyperflexAlarmSummary.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexAlarmSummary.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexAlarmSummary initObject = new Intersight.Model.HyperflexAlarmSummary();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexAppCatalog.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexAppCatalog")]
    public class InitializeIntersightHyperflexAppCatalog : PSCmdlet
    {
        public InitializeIntersightHyperflexAppCatalog()
        {
            ClassId = HyperflexAppCatalog.ClassIdEnum.HyperflexAppCatalog;
            ObjectType = HyperflexAppCatalog.ObjectTypeEnum.HyperflexAppCatalog;

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

        public HyperflexAppCatalog.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a hyperflexFeatureLimitExternal resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.HyperflexFeatureLimitExternalRelationship FeatureLimitExternal
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a hyperflexFeatureLimitInternal resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.HyperflexFeatureLimitInternalRelationship FeatureLimitInternal
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to hyperflexHxdpVersion resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.HyperflexHxdpVersionRelationship> HxdpVersions
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to hyperflexCapabilityInfo resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.HyperflexCapabilityInfoRelationship> HyperflexCapabilityInfos
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to hclHyperflexSoftwareCompatibilityInfo resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.HclHyperflexSoftwareCompatibilityInfoRelationship> HyperflexSoftwareCompatibilityInfos
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

        public HyperflexAppCatalog.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a hyperflexServerFirmwareVersion resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.HyperflexServerFirmwareVersionRelationship ServerFirmwareVersion
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a hyperflexServerModel resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.HyperflexServerModelRelationship ServerModel
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to hyperflexSoftwareDistributionEntry resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.HyperflexSoftwareDistributionEntryRelationship> SoftwareDistributions
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
        /// <para type="description">"The catalog version used in HyperFlex cluster configuration service."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Version
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexAppCatalog initObject = new Intersight.Model.HyperflexAppCatalog();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("FeatureLimitExternal"))
            {
                initObject.FeatureLimitExternal = this.FeatureLimitExternal;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FeatureLimitInternal"))
            {
                initObject.FeatureLimitInternal = this.FeatureLimitInternal;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HxdpVersions"))
            {
                initObject.HxdpVersions = this.HxdpVersions;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HyperflexCapabilityInfos"))
            {
                initObject.HyperflexCapabilityInfos = this.HyperflexCapabilityInfos;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HyperflexSoftwareCompatibilityInfos"))
            {
                initObject.HyperflexSoftwareCompatibilityInfos = this.HyperflexSoftwareCompatibilityInfos;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("ServerFirmwareVersion"))
            {
                initObject.ServerFirmwareVersion = this.ServerFirmwareVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ServerModel"))
            {
                initObject.ServerModel = this.ServerModel;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SoftwareDistributions"))
            {
                initObject.SoftwareDistributions = this.SoftwareDistributions;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Version"))
            {
                initObject.VarVersion = this.Version;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexAppSettingConstraint.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexAppSettingConstraint")]
    public class InitializeIntersightHyperflexAppSettingConstraint : PSCmdlet
    {
        public InitializeIntersightHyperflexAppSettingConstraint()
        {
            ClassId = HyperflexAppSettingConstraint.ClassIdEnum.HyperflexAppSettingConstraint;
            DeploymentType = HyperflexAppSettingConstraint.DeploymentTypeEnum.NA;
            HypervisorType = HyperflexAppSettingConstraint.HypervisorTypeEnum.ESXi;
            MgmtPlatform = HyperflexAppSettingConstraint.MgmtPlatformEnum.FI;
            ObjectType = HyperflexAppSettingConstraint.ObjectTypeEnum.HyperflexAppSettingConstraint;

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

        public HyperflexAppSettingConstraint.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The deployment type of the cluster.\n* `NA` - The deployment type of the HyperFlex cluster is not available.\n* `Datacenter` - The deployment type of a HyperFlex cluster consisting of UCS Fabric Interconnect-attached nodes on the same site.\n* `Stretched Cluster` - The deployment type of a HyperFlex cluster consisting of UCS Fabric Interconnect-attached nodes across different sites.\n* `Edge` - The deployment type of a HyperFlex cluster consisting of 2 or more standalone nodes.\n* `DC-No-FI` - The deployment type of a HyperFlex cluster consisting of 3 or more standalone nodes with the required Datacenter license."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexAppSettingConstraint.DeploymentTypeEnum DeploymentType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The supported HyperFlex Data Platform version in regex format."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string HxdpVersion
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The hypervisor type for the HyperFlex cluster.\n* `ESXi` - The hypervisor running on the HyperFlex cluster is a Vmware ESXi hypervisor of any version.\n* `Hyper-V` - The hypervisor running on the HyperFlex cluster is Microsoft Hyper-V.\n* `Unknown` - The hypervisor running on the HyperFlex cluster is not known."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexAppSettingConstraint.HypervisorTypeEnum HypervisorType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The supported management platform for the HyperFlex Cluster.\n* `FI` - The host servers used in the cluster deployment are managed by a UCS Fabric Interconnect.\n* `EDGE` - The host servers used in the cluster deployment are standalone severs.\n* `DC-No-FI` - The host servers used in the cluster deployment are standalone servers with the DC Advantage license."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexAppSettingConstraint.MgmtPlatformEnum MgmtPlatform
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexAppSettingConstraint.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The supported server models in regex format."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ServerModel
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexAppSettingConstraint initObject = new Intersight.Model.HyperflexAppSettingConstraint();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("DeploymentType"))
            {
                initObject.DeploymentType = this.DeploymentType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HxdpVersion"))
            {
                initObject.HxdpVersion = this.HxdpVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HypervisorType"))
            {
                initObject.HypervisorType = this.HypervisorType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MgmtPlatform"))
            {
                initObject.MgmtPlatform = this.MgmtPlatform;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("ServerModel"))
            {
                initObject.ServerModel = this.ServerModel;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexAutoSupportPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexAutoSupportPolicy")]
    public class InitializeIntersightHyperflexAutoSupportPolicy : PSCmdlet
    {
        public InitializeIntersightHyperflexAutoSupportPolicy()
        {
            ClassId = HyperflexAutoSupportPolicy.ClassIdEnum.HyperflexAutoSupportPolicy;
            ObjectType = HyperflexAutoSupportPolicy.ObjectTypeEnum.HyperflexAutoSupportPolicy;

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
        /// <para type="description">"Enable or disable Auto-Support."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool AdminState
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexAutoSupportPolicy.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to hyperflexClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.HyperflexClusterProfileRelationship> ClusterProfiles
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

        public HyperflexAutoSupportPolicy.ObjectTypeEnum ObjectType
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
        /// <para type="description">"The recipient email address for support tickets."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$")]
        public string ServiceTicketReceipient
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
            Intersight.Model.HyperflexAutoSupportPolicy initObject = new Intersight.Model.HyperflexAutoSupportPolicy();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdminState"))
            {
                initObject.AdminState = this.AdminState;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("ServiceTicketReceipient"))
            {
                initObject.ServiceTicketReceipient = this.ServiceTicketReceipient;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexBackupCluster.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexBackupCluster")]
    public class InitializeIntersightHyperflexBackupCluster : PSCmdlet
    {
        public InitializeIntersightHyperflexBackupCluster()
        {
            ClassId = HyperflexBackupCluster.ClassIdEnum.HyperflexBackupCluster;
            ObjectType = HyperflexBackupCluster.ObjectTypeEnum.HyperflexBackupCluster;

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

        public HyperflexBackupCluster.ClassIdEnum ClassId
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

        public HyperflexBackupCluster.ObjectTypeEnum ObjectType
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
            Intersight.Model.HyperflexBackupCluster initObject = new Intersight.Model.HyperflexBackupCluster();
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexBackupPolicySettings.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexBackupPolicySettings")]
    public class InitializeIntersightHyperflexBackupPolicySettings : PSCmdlet
    {
        public InitializeIntersightHyperflexBackupPolicySettings()
        {
            ClassId = HyperflexBackupPolicySettings.ClassIdEnum.HyperflexBackupPolicySettings;
            ObjectType = HyperflexBackupPolicySettings.ObjectTypeEnum.HyperflexBackupPolicySettings;

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

        public HyperflexBackupPolicySettings.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexBackupPolicySettings.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexBackupPolicySettings initObject = new Intersight.Model.HyperflexBackupPolicySettings();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexCapability.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexCapability")]
    public class InitializeIntersightHyperflexCapability : PSCmdlet
    {
        public InitializeIntersightHyperflexCapability()
        {
            ClassId = HyperflexCapability.ClassIdEnum.HyperflexCapability;
            ObjectType = HyperflexCapability.ObjectTypeEnum.HyperflexCapability;

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

        public HyperflexCapability.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexCapability.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexCapability initObject = new Intersight.Model.HyperflexCapability();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexCapabilityInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexCapabilityInfo")]
    public class InitializeIntersightHyperflexCapabilityInfo : PSCmdlet
    {
        public InitializeIntersightHyperflexCapabilityInfo()
        {
            ClassId = HyperflexCapabilityInfo.ClassIdEnum.HyperflexCapabilityInfo;
            ObjectType = HyperflexCapabilityInfo.ObjectTypeEnum.HyperflexCapabilityInfo;

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
        /// <para type="description">"A reference to a hyperflexAppCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.HyperflexAppCatalogRelationship AppCatalog
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.HclConstraint> CapabilityConstraints
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexCapabilityInfo.ClassIdEnum ClassId
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
        /// <para type="description">"Name of the capability or feature set consisting of a collection of constraint rules and value."</para>
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

        public HyperflexCapabilityInfo.ObjectTypeEnum ObjectType
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
            Intersight.Model.HyperflexCapabilityInfo initObject = new Intersight.Model.HyperflexCapabilityInfo();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AppCatalog"))
            {
                initObject.AppCatalog = this.AppCatalog;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CapabilityConstraints"))
            {
                initObject.CapabilityConstraints = this.CapabilityConstraints;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexCluster.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexCluster")]
    public class InitializeIntersightHyperflexCluster : PSCmdlet
    {
        public InitializeIntersightHyperflexCluster()
        {
            ClassId = HyperflexCluster.ClassIdEnum.HyperflexCluster;
            ClusterPurpose = HyperflexCluster.ClusterPurposeEnum.Storage;
            HypervisorType = HyperflexCluster.HypervisorTypeEnum.ESXi;
            ObjectType = HyperflexCluster.ObjectTypeEnum.HyperflexCluster;

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
        /// <para type="description">"A reference to a policyAbstractProfile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.PolicyAbstractProfileRelationship AssociatedProfile
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to hyperflexBaseCluster resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.HyperflexBaseClusterRelationship> ChildClusters
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexCluster.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"This can be a Storage or Compute cluster. A storage cluster contains storage nodes that are used to persist data. A compute cluster contains compute nodes that are used for executing business logic.\n* `Storage` - Cluster of storage nodes used to persist data.\n* `Compute` - Cluster of compute nodes used to execute business logic.\n* `Unknown` - This cluster type is Unknown. Expect Compute or Storage as valid values."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexCluster.ClusterPurposeEnum ClusterPurpose
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"This captures the encryption status for a HyperFlex cluster.\nCurrently it will have the status if HXA-CLU-0020 alarm is raised. In the future it can capture other details."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string EncryptionStatus
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Identifies the broad type of the underlying hypervisor.\n* `ESXi` - The hypervisor running on the HyperFlex cluster is a Vmware ESXi hypervisor of any version.\n* `Hyper-V` - The hypervisor running on the HyperFlex cluster is Microsoft Hyper-V.\n* `Unknown` - The hypervisor running on the HyperFlex cluster is not known."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexCluster.HypervisorTypeEnum HypervisorType
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

        public HyperflexCluster.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a computeBaseCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.ComputeBaseClusterRelationship ParentCluster
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
            Intersight.Model.HyperflexCluster initObject = new Intersight.Model.HyperflexCluster();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AssociatedProfile"))
            {
                initObject.AssociatedProfile = this.AssociatedProfile;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ChildClusters"))
            {
                initObject.ChildClusters = this.ChildClusters;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ClusterPurpose"))
            {
                initObject.ClusterPurpose = this.ClusterPurpose;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EncryptionStatus"))
            {
                initObject.EncryptionStatus = this.EncryptionStatus;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HypervisorType"))
            {
                initObject.HypervisorType = this.HypervisorType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("ParentCluster"))
            {
                initObject.ParentCluster = this.ParentCluster;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexClusterBackupPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexClusterBackupPolicy")]
    public class InitializeIntersightHyperflexClusterBackupPolicy : PSCmdlet
    {
        public InitializeIntersightHyperflexClusterBackupPolicy()
        {
            ClassId = HyperflexClusterBackupPolicy.ClassIdEnum.HyperflexClusterBackupPolicy;
            ObjectType = HyperflexClusterBackupPolicy.ObjectTypeEnum.HyperflexClusterBackupPolicy;

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
        /// <para type="description">"Backup datastore name prefix used during the auto creation of the datastore. All VMs created in this datastore will be automatically backed up."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string BackupDataStoreName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Replication data store size in backupDataStoreSizeUnit."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long BackupDataStoreSize
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Replication data store size."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string BackupDataStoreSizeUnit
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a hyperflexCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.HyperflexClusterRelationship BackupTarget
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexClusterBackupPolicy.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to hyperflexClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.HyperflexClusterProfileRelationship> ClusterProfiles
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Whether the datastore is encrypted or not."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool DataStoreEncryptionEnabled
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
        /// <para type="description">"Number of snapshots that will be retained as part of the Multi Point in Time support."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 30)]
        public long LocalSnapshotRetentionCount
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

        public HyperflexClusterBackupPolicy.ObjectTypeEnum ObjectType
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
        /// <para type="description">"Replication cluster pairing name prefix."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ReplicationPairNamePrefix
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Backup policy replication schedule."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.HyperflexReplicationSchedule ReplicationSchedule
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of snapshots that will be retained as part of the Multi Point in Time support."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 30)]
        public long SnapshotRetentionCount
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
            Intersight.Model.HyperflexClusterBackupPolicy initObject = new Intersight.Model.HyperflexClusterBackupPolicy();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BackupDataStoreName"))
            {
                initObject.BackupDataStoreName = this.BackupDataStoreName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BackupDataStoreSize"))
            {
                initObject.BackupDataStoreSize = this.BackupDataStoreSize;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BackupDataStoreSizeUnit"))
            {
                initObject.BackupDataStoreSizeUnit = this.BackupDataStoreSizeUnit;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BackupTarget"))
            {
                initObject.BackupTarget = this.BackupTarget;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ClusterProfiles"))
            {
                initObject.ClusterProfiles = this.ClusterProfiles;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DataStoreEncryptionEnabled"))
            {
                initObject.DataStoreEncryptionEnabled = this.DataStoreEncryptionEnabled;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LocalSnapshotRetentionCount"))
            {
                initObject.LocalSnapshotRetentionCount = this.LocalSnapshotRetentionCount;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("ReplicationPairNamePrefix"))
            {
                initObject.ReplicationPairNamePrefix = this.ReplicationPairNamePrefix;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ReplicationSchedule"))
            {
                initObject.ReplicationSchedule = this.ReplicationSchedule;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SnapshotRetentionCount"))
            {
                initObject.SnapshotRetentionCount = this.SnapshotRetentionCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexClusterBackupPolicyDeployment.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexClusterBackupPolicyDeployment")]
    public class InitializeIntersightHyperflexClusterBackupPolicyDeployment : PSCmdlet
    {
        public InitializeIntersightHyperflexClusterBackupPolicyDeployment()
        {
            ClassId = HyperflexClusterBackupPolicyDeployment.ClassIdEnum.HyperflexClusterBackupPolicyDeployment;
            ObjectType = HyperflexClusterBackupPolicyDeployment.ObjectTypeEnum.HyperflexClusterBackupPolicyDeployment;

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
        /// <para type="description">"A reference to a hyperflexCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.HyperflexClusterRelationship BackupTarget
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexClusterBackupPolicyDeployment.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"True if record created by discovery on HyperFlex cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Discovered
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

        public HyperflexClusterBackupPolicyDeployment.ObjectTypeEnum ObjectType
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
        /// <para type="description">"A reference to a hyperflexCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.HyperflexClusterRelationship SourceCluster
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"True if policy was detached from source Hyperflex Cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool SourceDetached
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
        /// <para type="description">"True if policy was detached from target Hyperflex Cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool TargetDetached
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexClusterBackupPolicyDeployment initObject = new Intersight.Model.HyperflexClusterBackupPolicyDeployment();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BackupTarget"))
            {
                initObject.BackupTarget = this.BackupTarget;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Discovered"))
            {
                initObject.Discovered = this.Discovered;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("SourceCluster"))
            {
                initObject.SourceCluster = this.SourceCluster;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SourceDetached"))
            {
                initObject.SourceDetached = this.SourceDetached;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TargetDetached"))
            {
                initObject.TargetDetached = this.TargetDetached;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexClusterBackupPolicyInventory.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexClusterBackupPolicyInventory")]
    public class InitializeIntersightHyperflexClusterBackupPolicyInventory : PSCmdlet
    {
        public InitializeIntersightHyperflexClusterBackupPolicyInventory()
        {
            ClassId = HyperflexClusterBackupPolicyInventory.ClassIdEnum.HyperflexClusterBackupPolicyInventory;
            ObjectType = HyperflexClusterBackupPolicyInventory.ObjectTypeEnum.HyperflexClusterBackupPolicyInventory;

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

        public HyperflexClusterBackupPolicyInventory.ClassIdEnum ClassId
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

        public HyperflexClusterBackupPolicyInventory.ObjectTypeEnum ObjectType
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
            Intersight.Model.HyperflexClusterBackupPolicyInventory initObject = new Intersight.Model.HyperflexClusterBackupPolicyInventory();
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexClusterHealthCheckExecutionSnapshot.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexClusterHealthCheckExecutionSnapshot")]
    public class InitializeIntersightHyperflexClusterHealthCheckExecutionSnapshot : PSCmdlet
    {
        public InitializeIntersightHyperflexClusterHealthCheckExecutionSnapshot()
        {
            ClassId = HyperflexClusterHealthCheckExecutionSnapshot.ClassIdEnum.HyperflexClusterHealthCheckExecutionSnapshot;
            ExecutionContext = HyperflexClusterHealthCheckExecutionSnapshot.ExecutionContextEnum.UNKNOWN;
            ObjectType = HyperflexClusterHealthCheckExecutionSnapshot.ObjectTypeEnum.HyperflexClusterHealthCheckExecutionSnapshot;

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

        public HyperflexClusterHealthCheckExecutionSnapshot.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The execution context of the HyperFlex health checks.\n* `UNKNOWN` - The current context of HyperFlex health check execution is unknown.\n* `WORKFLOW` - The HyperFlex health check execution is initiated through an orchestration workflow.\n* `SCHEDULED` - The HyperFlex health check execution is through a scheduled run."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexClusterHealthCheckExecutionSnapshot.ExecutionContextEnum ExecutionContext
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

        public HyperflexClusterHealthCheckExecutionSnapshot.ObjectTypeEnum ObjectType
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
        /// <para type="description">"Timestamp of the last health check execution on the HyperFlex cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime Timestamp
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexClusterHealthCheckExecutionSnapshot initObject = new Intersight.Model.HyperflexClusterHealthCheckExecutionSnapshot();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ExecutionContext"))
            {
                initObject.ExecutionContext = this.ExecutionContext;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Timestamp"))
            {
                initObject.Timestamp = this.Timestamp;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexClusterNetworkPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexClusterNetworkPolicy")]
    public class InitializeIntersightHyperflexClusterNetworkPolicy : PSCmdlet
    {
        public InitializeIntersightHyperflexClusterNetworkPolicy()
        {
            ClassId = HyperflexClusterNetworkPolicy.ClassIdEnum.HyperflexClusterNetworkPolicy;
            ObjectType = HyperflexClusterNetworkPolicy.ObjectTypeEnum.HyperflexClusterNetworkPolicy;
            UplinkSpeed = HyperflexClusterNetworkPolicy.UplinkSpeedEnum.Default;

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

        public HyperflexClusterNetworkPolicy.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to hyperflexClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.HyperflexClusterProfileRelationship> ClusterProfiles
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
        /// <para type="description">"Enable or disable Jumbo Frames (MTU=9000). Jumbo Frames are used by Storage Network, VM Migration Network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool JumboFrame
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Out-of-band KVM IP range.\nConfigures the service profiles to use IP addresses within this range for setting the KVM IP of a server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.HyperflexIpAddrRange KvmIpRange
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The MAC address prefix range for configuring vNICs.\nConfigures the service profiles to use MAC address prefixes within this range for setting the MAC address of server vNICs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.HyperflexMacAddrPrefixRange MacPrefixRange
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The VLAN for the management network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.HyperflexNamedVlan MgmtVlan
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

        public HyperflexClusterNetworkPolicy.ObjectTypeEnum ObjectType
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
        /// <para type="description">"Link speed of the server adapter port to the upstream switch. When the policy is attached to a cluster profile with EDGE management platform, the uplink speed can be '1G' or '10G+'. Use '10G+' for link speeds of 10G or above. When the policy is attached to a cluster profile with Fabric Interconnect management platform, the uplink speed can be 'default' only.\n* `default` - Current default value set on the hardware platform.\n* `1G` - A link speed of 1 gigabit per second.\n* `10G` - A link speed of 10 gigabits per second or above."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexClusterNetworkPolicy.UplinkSpeedEnum UplinkSpeed
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The VM migration VLAN.\nThis VLAN is used for transfering VMs from one host to another during operations such a cluster upgrade.\nFor HyperFlex Application Platform clusters, this VLAN is also used for hypervisor control traffic such as\nnode to node communication, pod-to-pod communication, etc."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.HyperflexNamedVlan VmMigrationVlan
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.HyperflexNamedVlan> VmNetworkVlans
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexClusterNetworkPolicy initObject = new Intersight.Model.HyperflexClusterNetworkPolicy();
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
            if (this.MyInvocation.BoundParameters.ContainsKey("JumboFrame"))
            {
                initObject.JumboFrame = this.JumboFrame;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("KvmIpRange"))
            {
                initObject.KvmIpRange = this.KvmIpRange;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MacPrefixRange"))
            {
                initObject.MacPrefixRange = this.MacPrefixRange;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MgmtVlan"))
            {
                initObject.MgmtVlan = this.MgmtVlan;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("UplinkSpeed"))
            {
                initObject.UplinkSpeed = this.UplinkSpeed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VmMigrationVlan"))
            {
                initObject.VmMigrationVlan = this.VmMigrationVlan;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VmNetworkVlans"))
            {
                initObject.VmNetworkVlans = this.VmNetworkVlans;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexClusterProfile.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexClusterProfile")]
    public class InitializeIntersightHyperflexClusterProfile : PSCmdlet
    {
        public InitializeIntersightHyperflexClusterProfile()
        {
            ClassId = HyperflexClusterProfile.ClassIdEnum.HyperflexClusterProfile;
            HypervisorType = HyperflexClusterProfile.HypervisorTypeEnum.ESXi;
            MgmtPlatform = HyperflexClusterProfile.MgmtPlatformEnum.FI;
            ObjectType = HyperflexClusterProfile.ObjectTypeEnum.HyperflexClusterProfile;
            StorageType = HyperflexClusterProfile.StorageTypeEnum.HyperFlexDp;
            Type = HyperflexClusterProfile.TypeEnum.Instance;

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
        /// <para type="description">"A reference to a hyperflexCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.HyperflexClusterRelationship AssociatedCluster
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a hyperflexAutoSupportPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.HyperflexAutoSupportPolicyRelationship AutoSupport
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexClusterProfile.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A CIDR subnet for the cluster internal network. This applies to Intersight Workload Engine clusters only."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.CommIpV4Interface ClusterInternalSubnet
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a hyperflexClusterNetworkPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.HyperflexClusterNetworkPolicyRelationship ClusterNetwork
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a hyperflexClusterStoragePolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.HyperflexClusterStoragePolicyRelationship ClusterStorage
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
        /// <para type="description">"The storage data IP address for the HyperFlex cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string DataIpAddress
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
        /// <para type="description">"A reference to a hyperflexExtFcStoragePolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.HyperflexExtFcStoragePolicyRelationship ExtFcStorage
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a hyperflexExtIscsiStoragePolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.HyperflexExtIscsiStoragePolicyRelationship ExtIscsiStorage
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The node name prefix that is used to automatically generate the default hostname for each server.\nA dash (-) will be appended to the prefix followed by the node number to form a hostname.\nThis default naming scheme can be manually overridden in the node configuration.\nThe maximum length of a prefix is 60, must only contain alphanumeric characters or dash (-), and must\nstart with an alphanumeric character."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9][a-zA-Z0-9-]{1,59}$")]
        public string HostNamePrefix
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a commHttpProxyPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.CommHttpProxyPolicyRelationship Httpproxypolicy
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The hypervisor control virtual IP address for the HyperFlex compute cluster that is used for node/pod management."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string HypervisorControlIpAddress
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The hypervisor type for the HyperFlex cluster.\n* `ESXi` - The hypervisor running on the HyperFlex cluster is a Vmware ESXi hypervisor of any version.\n* `Hyper-V` - The hypervisor running on the HyperFlex cluster is Microsoft Hyper-V.\n* `Unknown` - The hypervisor running on the HyperFlex cluster is not known."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexClusterProfile.HypervisorTypeEnum HypervisorType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a hyperflexLocalCredentialPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.HyperflexLocalCredentialPolicyRelationship LocalCredential
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The MAC address prefix in the form of 00:25:B5:XX."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^00:25:B5:[0-9a-fA-F]{2}$")]
        public string MacAddressPrefix
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The management IP address for the HyperFlex cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string MgmtIpAddress
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The management platform for the HyperFlex cluster.\n* `FI` - The host servers used in the cluster deployment are managed by a UCS Fabric Interconnect.\n* `EDGE` - The host servers used in the cluster deployment are standalone severs.\n* `DC-No-FI` - The host servers used in the cluster deployment are standalone servers with the DC Advantage license."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexClusterProfile.MgmtPlatformEnum MgmtPlatform
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
        /// <para type="description">"A reference to a hyperflexNodeConfigPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.HyperflexNodeConfigPolicyRelationship NodeConfig
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to hyperflexNodeProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.HyperflexNodeProfileRelationship> NodeProfileConfig
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexClusterProfile.ObjectTypeEnum ObjectType
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
        /// <para type="description">"An array of relationships to policyAbstractPolicy resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.PolicyAbstractPolicyRelationship> PolicyBucket
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a hyperflexProxySettingPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.HyperflexProxySettingPolicyRelationship ProxySetting
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of copies of each data block written."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Replication
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.PolicyScheduledAction> ScheduledActions
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a hyperflexSoftwareVersionPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.HyperflexSoftwareVersionPolicyRelationship SoftwareVersion
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
        /// <para type="description">"The storage data IP address for the HyperFlex cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string StorageClientIpAddress
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The netmask for the Storage client network IP address."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string StorageClientNetmask
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The named VLAN associated with this cluster's storage client network. This applies to Intersight Workload Engine clusters only."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.HyperflexNamedVlan StorageClientVlan
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The auxiliary storage IP address for the HyperFlex cluster. For two node clusters, this is the IP address of the auxiliary ZK controller."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string StorageClusterAuxiliaryIp
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The VLAN for the HyperFlex storage data traffic."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.HyperflexNamedVlan StorageDataVlan
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The storage type used for the HyperFlex cluster (HyperFlex Storage or 3rd party).\n* `HyperFlexDp` - The type of storage is HyperFlex Data Platform.\n* `ThirdParty` - The type of storage is 3rd Party Storage (PureStorage, etc..)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexClusterProfile.StorageTypeEnum StorageType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a hyperflexSysConfigPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.HyperflexSysConfigPolicyRelationship SysConfig
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

        public HyperflexClusterProfile.TypeEnum Type
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a hyperflexUcsmConfigPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.HyperflexUcsmConfigPolicyRelationship UcsmConfig
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a hyperflexVcenterConfigPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.HyperflexVcenterConfigPolicyRelationship VcenterConfig
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The WWxN prefix in the form of 20:00:00:25:B5:XX."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^20:00:00:25:B5:[0-9a-fA-F]{2}$")]
        public string WwxnPrefix
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexClusterProfile initObject = new Intersight.Model.HyperflexClusterProfile();
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
            if (this.MyInvocation.BoundParameters.ContainsKey("AssociatedCluster"))
            {
                initObject.AssociatedCluster = this.AssociatedCluster;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AutoSupport"))
            {
                initObject.AutoSupport = this.AutoSupport;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ClusterInternalSubnet"))
            {
                initObject.ClusterInternalSubnet = this.ClusterInternalSubnet;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ClusterNetwork"))
            {
                initObject.ClusterNetwork = this.ClusterNetwork;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ClusterStorage"))
            {
                initObject.ClusterStorage = this.ClusterStorage;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ConfigContext"))
            {
                initObject.ConfigContext = this.ConfigContext;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DataIpAddress"))
            {
                initObject.DataIpAddress = this.DataIpAddress;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ExtFcStorage"))
            {
                initObject.ExtFcStorage = this.ExtFcStorage;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ExtIscsiStorage"))
            {
                initObject.ExtIscsiStorage = this.ExtIscsiStorage;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HostNamePrefix"))
            {
                initObject.HostNamePrefix = this.HostNamePrefix;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Httpproxypolicy"))
            {
                initObject.Httpproxypolicy = this.Httpproxypolicy;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HypervisorControlIpAddress"))
            {
                initObject.HypervisorControlIpAddress = this.HypervisorControlIpAddress;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HypervisorType"))
            {
                initObject.HypervisorType = this.HypervisorType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LocalCredential"))
            {
                initObject.LocalCredential = this.LocalCredential;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MacAddressPrefix"))
            {
                initObject.MacAddressPrefix = this.MacAddressPrefix;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MgmtIpAddress"))
            {
                initObject.MgmtIpAddress = this.MgmtIpAddress;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MgmtPlatform"))
            {
                initObject.MgmtPlatform = this.MgmtPlatform;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NodeConfig"))
            {
                initObject.NodeConfig = this.NodeConfig;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NodeProfileConfig"))
            {
                initObject.NodeProfileConfig = this.NodeProfileConfig;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Organization"))
            {
                initObject.Organization = this.Organization;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PolicyBucket"))
            {
                initObject.PolicyBucket = this.PolicyBucket;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ProxySetting"))
            {
                initObject.ProxySetting = this.ProxySetting;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Replication"))
            {
                initObject.Replication = this.Replication;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ScheduledActions"))
            {
                initObject.ScheduledActions = this.ScheduledActions;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SoftwareVersion"))
            {
                initObject.SoftwareVersion = this.SoftwareVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SrcTemplate"))
            {
                initObject.SrcTemplate = this.SrcTemplate;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("StorageClientIpAddress"))
            {
                initObject.StorageClientIpAddress = this.StorageClientIpAddress;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("StorageClientNetmask"))
            {
                initObject.StorageClientNetmask = this.StorageClientNetmask;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("StorageClientVlan"))
            {
                initObject.StorageClientVlan = this.StorageClientVlan;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("StorageClusterAuxiliaryIp"))
            {
                initObject.StorageClusterAuxiliaryIp = this.StorageClusterAuxiliaryIp;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("StorageDataVlan"))
            {
                initObject.StorageDataVlan = this.StorageDataVlan;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("StorageType"))
            {
                initObject.StorageType = this.StorageType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SysConfig"))
            {
                initObject.SysConfig = this.SysConfig;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Type"))
            {
                initObject.Type = this.Type;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UcsmConfig"))
            {
                initObject.UcsmConfig = this.UcsmConfig;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VcenterConfig"))
            {
                initObject.VcenterConfig = this.VcenterConfig;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("WwxnPrefix"))
            {
                initObject.WwxnPrefix = this.WwxnPrefix;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexClusterReplicationNetworkPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexClusterReplicationNetworkPolicy")]
    public class InitializeIntersightHyperflexClusterReplicationNetworkPolicy : PSCmdlet
    {
        public InitializeIntersightHyperflexClusterReplicationNetworkPolicy()
        {
            ClassId = HyperflexClusterReplicationNetworkPolicy.ClassIdEnum.HyperflexClusterReplicationNetworkPolicy;
            ObjectType = HyperflexClusterReplicationNetworkPolicy.ObjectTypeEnum.HyperflexClusterReplicationNetworkPolicy;

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

        public HyperflexClusterReplicationNetworkPolicy.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to hyperflexClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.HyperflexClusterProfileRelationship> ClusterProfiles
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

        public HyperflexClusterReplicationNetworkPolicy.ObjectTypeEnum ObjectType
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
        /// <para type="description">"Bandwidth for the Replication network in Mbps."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long ReplicationBandwidthMbps
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.HyperflexIpAddrRange> ReplicationIpranges
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"MTU for the Replication network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1024, 1500)]
        public long ReplicationMtu
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"VLAN for the Replication network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.HyperflexNamedVlan ReplicationVlan
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
            Intersight.Model.HyperflexClusterReplicationNetworkPolicy initObject = new Intersight.Model.HyperflexClusterReplicationNetworkPolicy();
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
            if (this.MyInvocation.BoundParameters.ContainsKey("ReplicationBandwidthMbps"))
            {
                initObject.ReplicationBandwidthMbps = this.ReplicationBandwidthMbps;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ReplicationIpranges"))
            {
                initObject.ReplicationIpranges = this.ReplicationIpranges;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ReplicationMtu"))
            {
                initObject.ReplicationMtu = this.ReplicationMtu;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ReplicationVlan"))
            {
                initObject.ReplicationVlan = this.ReplicationVlan;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexClusterReplicationNetworkPolicyDeployment.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexClusterReplicationNetworkPolicyDeployment")]
    public class InitializeIntersightHyperflexClusterReplicationNetworkPolicyDeployment : PSCmdlet
    {
        public InitializeIntersightHyperflexClusterReplicationNetworkPolicyDeployment()
        {
            ClassId = HyperflexClusterReplicationNetworkPolicyDeployment.ClassIdEnum.HyperflexClusterReplicationNetworkPolicyDeployment;
            ObjectType = HyperflexClusterReplicationNetworkPolicyDeployment.ObjectTypeEnum.HyperflexClusterReplicationNetworkPolicyDeployment;

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

        public HyperflexClusterReplicationNetworkPolicyDeployment.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a hyperflexCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.HyperflexClusterRelationship Cluster
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"True if record created by discovery on HyperFlex cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Discovered
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

        public HyperflexClusterReplicationNetworkPolicyDeployment.ObjectTypeEnum ObjectType
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
            Intersight.Model.HyperflexClusterReplicationNetworkPolicyDeployment initObject = new Intersight.Model.HyperflexClusterReplicationNetworkPolicyDeployment();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Cluster"))
            {
                initObject.Cluster = this.Cluster;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Discovered"))
            {
                initObject.Discovered = this.Discovered;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexClusterStoragePolicy.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexClusterStoragePolicy")]
    public class InitializeIntersightHyperflexClusterStoragePolicy : PSCmdlet
    {
        public InitializeIntersightHyperflexClusterStoragePolicy()
        {
            ClassId = HyperflexClusterStoragePolicy.ClassIdEnum.HyperflexClusterStoragePolicy;
            ObjectType = HyperflexClusterStoragePolicy.ObjectTypeEnum.HyperflexClusterStoragePolicy;

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

        public HyperflexClusterStoragePolicy.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to hyperflexClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.HyperflexClusterProfileRelationship> ClusterProfiles
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
        /// <para type="description">"If enabled, formats existing disk partitions (destroys all user data)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool DiskPartitionCleanup
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Enable or disable Logical Availability Zones (LAZ). If enabled, HyperFlex Data Platform automatically selects and groups nodes into different availability zones. For HyperFlex Data Platform versions prior to 3.0 release, this setting does not apply. For HyperFlex Data Platform versions 3.0 or higher, this setting is only applicable to HyperFlex systems with 8 or more converged nodes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.HyperflexLogicalAvailabilityZone LogicalAvalabilityZoneConfig
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

        public HyperflexClusterStoragePolicy.ObjectTypeEnum ObjectType
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
        /// <para type="description">"Enable or disable VDI optimization (hybrid HyperFlex systems only)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool VdiOptimization
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexClusterStoragePolicy initObject = new Intersight.Model.HyperflexClusterStoragePolicy();
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
            if (this.MyInvocation.BoundParameters.ContainsKey("DiskPartitionCleanup"))
            {
                initObject.DiskPartitionCleanup = this.DiskPartitionCleanup;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LogicalAvalabilityZoneConfig"))
            {
                initObject.LogicalAvalabilityZoneConfig = this.LogicalAvalabilityZoneConfig;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("VdiOptimization"))
            {
                initObject.VdiOptimization = this.VdiOptimization;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexConfigResult.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexConfigResult")]
    public class InitializeIntersightHyperflexConfigResult : PSCmdlet
    {
        public InitializeIntersightHyperflexConfigResult()
        {
            ClassId = HyperflexConfigResult.ClassIdEnum.HyperflexConfigResult;
            ObjectType = HyperflexConfigResult.ObjectTypeEnum.HyperflexConfigResult;

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

        public HyperflexConfigResult.ClassIdEnum ClassId
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

        public HyperflexConfigResult.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to hyperflexConfigResultEntry resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.HyperflexConfigResultEntryRelationship> ResultEntries
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
            Intersight.Model.HyperflexConfigResult initObject = new Intersight.Model.HyperflexConfigResult();
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
            if (this.MyInvocation.BoundParameters.ContainsKey("ResultEntries"))
            {
                initObject.ResultEntries = this.ResultEntries;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexConfigResultEntry.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexConfigResultEntry")]
    public class InitializeIntersightHyperflexConfigResultEntry : PSCmdlet
    {
        public InitializeIntersightHyperflexConfigResultEntry()
        {
            ClassId = HyperflexConfigResultEntry.ClassIdEnum.HyperflexConfigResultEntry;
            ObjectType = HyperflexConfigResultEntry.ObjectTypeEnum.HyperflexConfigResultEntry;

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

        public HyperflexConfigResultEntry.ClassIdEnum ClassId
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
        /// <para type="description">"A reference to a hyperflexConfigResult resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.HyperflexConfigResultRelationship ConfigResult
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

        public HyperflexConfigResultEntry.ObjectTypeEnum ObjectType
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
            Intersight.Model.HyperflexConfigResultEntry initObject = new Intersight.Model.HyperflexConfigResultEntry();
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexDataProtectionPeer.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexDataProtectionPeer")]
    public class InitializeIntersightHyperflexDataProtectionPeer : PSCmdlet
    {
        public InitializeIntersightHyperflexDataProtectionPeer()
        {
            ClassId = HyperflexDataProtectionPeer.ClassIdEnum.HyperflexDataProtectionPeer;
            ObjectType = HyperflexDataProtectionPeer.ObjectTypeEnum.HyperflexDataProtectionPeer;

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

        public HyperflexDataProtectionPeer.ClassIdEnum ClassId
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

        public HyperflexDataProtectionPeer.ObjectTypeEnum ObjectType
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
            Intersight.Model.HyperflexDataProtectionPeer initObject = new Intersight.Model.HyperflexDataProtectionPeer();
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexDatastoreInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexDatastoreInfo")]
    public class InitializeIntersightHyperflexDatastoreInfo : PSCmdlet
    {
        public InitializeIntersightHyperflexDatastoreInfo()
        {
            ClassId = HyperflexDatastoreInfo.ClassIdEnum.HyperflexDatastoreInfo;
            ObjectType = HyperflexDatastoreInfo.ObjectTypeEnum.HyperflexDatastoreInfo;

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

        public HyperflexDatastoreInfo.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexDatastoreInfo.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexDatastoreInfo initObject = new Intersight.Model.HyperflexDatastoreInfo();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexDatastoreStatistic.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexDatastoreStatistic")]
    public class InitializeIntersightHyperflexDatastoreStatistic : PSCmdlet
    {
        public InitializeIntersightHyperflexDatastoreStatistic()
        {
            ClassId = HyperflexDatastoreStatistic.ClassIdEnum.HyperflexDatastoreStatistic;
            ObjectType = HyperflexDatastoreStatistic.ObjectTypeEnum.HyperflexDatastoreStatistic;

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

        public HyperflexDatastoreStatistic.ClassIdEnum ClassId
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

        public HyperflexDatastoreStatistic.ObjectTypeEnum ObjectType
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
            Intersight.Model.HyperflexDatastoreStatistic initObject = new Intersight.Model.HyperflexDatastoreStatistic();
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexDevicePackageDownloadState.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexDevicePackageDownloadState")]
    public class InitializeIntersightHyperflexDevicePackageDownloadState : PSCmdlet
    {
        public InitializeIntersightHyperflexDevicePackageDownloadState()
        {
            ClassId = HyperflexDevicePackageDownloadState.ClassIdEnum.HyperflexDevicePackageDownloadState;
            ObjectType = HyperflexDevicePackageDownloadState.ObjectTypeEnum.HyperflexDevicePackageDownloadState;

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
        /// <para type="description">"Checksum of HyperFlex health check Debian package installed on the HyperFlex Device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Checksum
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexDevicePackageDownloadState.ClassIdEnum ClassId
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

        public HyperflexDevicePackageDownloadState.ObjectTypeEnum ObjectType
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
        /// <para type="description">"Timestamp of the last health check Debian package installation on the HyperFlex Device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime Timestamp
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexDevicePackageDownloadState initObject = new Intersight.Model.HyperflexDevicePackageDownloadState();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Checksum"))
            {
                initObject.Checksum = this.Checksum;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Timestamp"))
            {
                initObject.Timestamp = this.Timestamp;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexDrive.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexDrive")]
    public class InitializeIntersightHyperflexDrive : PSCmdlet
    {
        public InitializeIntersightHyperflexDrive()
        {
            ClassId = HyperflexDrive.ClassIdEnum.HyperflexDrive;
            ObjectType = HyperflexDrive.ObjectTypeEnum.HyperflexDrive;

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

        public HyperflexDrive.ClassIdEnum ClassId
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

        public HyperflexDrive.ObjectTypeEnum ObjectType
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
            Intersight.Model.HyperflexDrive initObject = new Intersight.Model.HyperflexDrive();
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexEncryption.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexEncryption")]
    public class InitializeIntersightHyperflexEncryption : PSCmdlet
    {
        public InitializeIntersightHyperflexEncryption()
        {
            ClassId = HyperflexEncryption.ClassIdEnum.HyperflexEncryption;
            ObjectType = HyperflexEncryption.ObjectTypeEnum.HyperflexEncryption;

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

        public HyperflexEncryption.ClassIdEnum ClassId
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

        public HyperflexEncryption.ObjectTypeEnum ObjectType
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
            Intersight.Model.HyperflexEncryption initObject = new Intersight.Model.HyperflexEncryption();
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexEntityReference.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexEntityReference")]
    public class InitializeIntersightHyperflexEntityReference : PSCmdlet
    {
        public InitializeIntersightHyperflexEntityReference()
        {
            ClassId = HyperflexEntityReference.ClassIdEnum.HyperflexEntityReference;
            ObjectType = HyperflexEntityReference.ObjectTypeEnum.HyperflexEntityReference;

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

        public HyperflexEntityReference.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexEntityReference.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexEntityReference initObject = new Intersight.Model.HyperflexEntityReference();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexErrorStack.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexErrorStack")]
    public class InitializeIntersightHyperflexErrorStack : PSCmdlet
    {
        public InitializeIntersightHyperflexErrorStack()
        {
            ClassId = HyperflexErrorStack.ClassIdEnum.HyperflexErrorStack;
            ObjectType = HyperflexErrorStack.ObjectTypeEnum.HyperflexErrorStack;

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

        public HyperflexErrorStack.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexErrorStack.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexErrorStack initObject = new Intersight.Model.HyperflexErrorStack();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexExtFcStoragePolicy.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexExtFcStoragePolicy")]
    public class InitializeIntersightHyperflexExtFcStoragePolicy : PSCmdlet
    {
        public InitializeIntersightHyperflexExtFcStoragePolicy()
        {
            ClassId = HyperflexExtFcStoragePolicy.ClassIdEnum.HyperflexExtFcStoragePolicy;
            ObjectType = HyperflexExtFcStoragePolicy.ObjectTypeEnum.HyperflexExtFcStoragePolicy;

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
        /// <para type="description">"Enables or disables external FC storage configuration."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool AdminState
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexExtFcStoragePolicy.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to hyperflexClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.HyperflexClusterProfileRelationship> ClusterProfiles
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
        /// <para type="description">"VSAN for the primary Fabric Interconnect external FC storage traffic."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.HyperflexNamedVsan ExtaTraffic
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"VSAN for the secondary Fabric Interconnect external FC storage traffic."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.HyperflexNamedVsan ExtbTraffic
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

        public HyperflexExtFcStoragePolicy.ObjectTypeEnum ObjectType
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
        /// <para type="description">"The range of WWxN addresses to use for the FC storage configuration."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.HyperflexWwxnPrefixRange WwxnPrefixRange
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexExtFcStoragePolicy initObject = new Intersight.Model.HyperflexExtFcStoragePolicy();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdminState"))
            {
                initObject.AdminState = this.AdminState;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("ExtaTraffic"))
            {
                initObject.ExtaTraffic = this.ExtaTraffic;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ExtbTraffic"))
            {
                initObject.ExtbTraffic = this.ExtbTraffic;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("WwxnPrefixRange"))
            {
                initObject.WwxnPrefixRange = this.WwxnPrefixRange;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexExtIscsiStoragePolicy.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexExtIscsiStoragePolicy")]
    public class InitializeIntersightHyperflexExtIscsiStoragePolicy : PSCmdlet
    {
        public InitializeIntersightHyperflexExtIscsiStoragePolicy()
        {
            ClassId = HyperflexExtIscsiStoragePolicy.ClassIdEnum.HyperflexExtIscsiStoragePolicy;
            ObjectType = HyperflexExtIscsiStoragePolicy.ObjectTypeEnum.HyperflexExtIscsiStoragePolicy;

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
        /// <para type="description">"Enable or disable external iSCSI storage configuration."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool AdminState
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexExtIscsiStoragePolicy.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to hyperflexClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.HyperflexClusterProfileRelationship> ClusterProfiles
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
        /// <para type="description">"VLAN for the primary Fabric Interconnect external iSCSI storage traffic."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.HyperflexNamedVlan ExtaTraffic
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"VLAN for the secondary Fabric Interconnect external iSCSI storage traffic."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.HyperflexNamedVlan ExtbTraffic
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

        public HyperflexExtIscsiStoragePolicy.ObjectTypeEnum ObjectType
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
            Intersight.Model.HyperflexExtIscsiStoragePolicy initObject = new Intersight.Model.HyperflexExtIscsiStoragePolicy();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdminState"))
            {
                initObject.AdminState = this.AdminState;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("ExtaTraffic"))
            {
                initObject.ExtaTraffic = this.ExtaTraffic;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ExtbTraffic"))
            {
                initObject.ExtbTraffic = this.ExtbTraffic;
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexFeatureLimitEntry.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexFeatureLimitEntry")]
    public class InitializeIntersightHyperflexFeatureLimitEntry : PSCmdlet
    {
        public InitializeIntersightHyperflexFeatureLimitEntry()
        {
            ClassId = HyperflexFeatureLimitEntry.ClassIdEnum.HyperflexFeatureLimitEntry;
            ObjectType = HyperflexFeatureLimitEntry.ObjectTypeEnum.HyperflexFeatureLimitEntry;

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

        public HyperflexFeatureLimitEntry.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The conditions that must be satisfied before applying the AppSetting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.HyperflexAppSettingConstraint Constraint
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The application setting identifier."</para>
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

        public HyperflexFeatureLimitEntry.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The application setting value."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Value
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexFeatureLimitEntry initObject = new Intersight.Model.HyperflexFeatureLimitEntry();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Constraint"))
            {
                initObject.Constraint = this.Constraint;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexFeatureLimitExternal.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexFeatureLimitExternal")]
    public class InitializeIntersightHyperflexFeatureLimitExternal : PSCmdlet
    {
        public InitializeIntersightHyperflexFeatureLimitExternal()
        {
            ClassId = HyperflexFeatureLimitExternal.ClassIdEnum.HyperflexFeatureLimitExternal;
            ObjectType = HyperflexFeatureLimitExternal.ObjectTypeEnum.HyperflexFeatureLimitExternal;

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
        /// <para type="description">"A reference to a hyperflexAppCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.HyperflexAppCatalogRelationship AppCatalog
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexFeatureLimitExternal.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.HyperflexFeatureLimitEntry> FeatureLimitEntries
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

        public HyperflexFeatureLimitExternal.ObjectTypeEnum ObjectType
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
            Intersight.Model.HyperflexFeatureLimitExternal initObject = new Intersight.Model.HyperflexFeatureLimitExternal();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AppCatalog"))
            {
                initObject.AppCatalog = this.AppCatalog;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("FeatureLimitEntries"))
            {
                initObject.FeatureLimitEntries = this.FeatureLimitEntries;
            }
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexFeatureLimitInternal.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexFeatureLimitInternal")]
    public class InitializeIntersightHyperflexFeatureLimitInternal : PSCmdlet
    {
        public InitializeIntersightHyperflexFeatureLimitInternal()
        {
            ClassId = HyperflexFeatureLimitInternal.ClassIdEnum.HyperflexFeatureLimitInternal;
            ObjectType = HyperflexFeatureLimitInternal.ObjectTypeEnum.HyperflexFeatureLimitInternal;

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
        /// <para type="description">"A reference to a hyperflexAppCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.HyperflexAppCatalogRelationship AppCatalog
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexFeatureLimitInternal.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.HyperflexFeatureLimitEntry> FeatureLimitEntries
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

        public HyperflexFeatureLimitInternal.ObjectTypeEnum ObjectType
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
            Intersight.Model.HyperflexFeatureLimitInternal initObject = new Intersight.Model.HyperflexFeatureLimitInternal();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AppCatalog"))
            {
                initObject.AppCatalog = this.AppCatalog;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("FeatureLimitEntries"))
            {
                initObject.FeatureLimitEntries = this.FeatureLimitEntries;
            }
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexFilePath.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexFilePath")]
    public class InitializeIntersightHyperflexFilePath : PSCmdlet
    {
        public InitializeIntersightHyperflexFilePath()
        {
            ClassId = HyperflexFilePath.ClassIdEnum.HyperflexFilePath;
            ObjectType = HyperflexFilePath.ObjectTypeEnum.HyperflexFilePath;

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

        public HyperflexFilePath.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexFilePath.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexFilePath initObject = new Intersight.Model.HyperflexFilePath();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexHealth.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexHealth")]
    public class InitializeIntersightHyperflexHealth : PSCmdlet
    {
        public InitializeIntersightHyperflexHealth()
        {
            ClassId = HyperflexHealth.ClassIdEnum.HyperflexHealth;
            ObjectType = HyperflexHealth.ObjectTypeEnum.HyperflexHealth;

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

        public HyperflexHealth.ClassIdEnum ClassId
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

        public HyperflexHealth.ObjectTypeEnum ObjectType
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
            Intersight.Model.HyperflexHealth initObject = new Intersight.Model.HyperflexHealth();
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexHealthCheckDefinition.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexHealthCheckDefinition")]
    public class InitializeIntersightHyperflexHealthCheckDefinition : PSCmdlet
    {
        public InitializeIntersightHyperflexHealthCheckDefinition()
        {
            ClassId = HyperflexHealthCheckDefinition.ClassIdEnum.HyperflexHealthCheckDefinition;
            ObjectType = HyperflexHealthCheckDefinition.ObjectTypeEnum.HyperflexHealthCheckDefinition;
            ScriptExecutionMode = HyperflexHealthCheckDefinition.ScriptExecutionModeEnum.ONDEMAND;
            TargetExecutionType = HyperflexHealthCheckDefinition.TargetExecutionTypeEnum.EXECUTEONLEADERNODE;

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
        /// <para type="description">"Category that the health check belongs to."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Category
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexHealthCheckDefinition.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Static information detailing the common causes for the health check failure."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string CommonCauses
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Execution configuration fo the health check script."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Configuration
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the health check definition."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Static information detailing the health impact of the health check failure."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string HealthImpact
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Internal name of the health check definition."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string InternalName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Minimum HyperFlex version that the check is supported on. Defaults to version 3.0.1."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string MinimumHyperFlexVersion
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
        /// <para type="description">"Name of the health check definition."</para>
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

        public HyperflexHealthCheckDefinition.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Static information containing additional reference for the health check."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Reference
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Static information detailing the possible remediation actions that can be taken to remedy the health check failure."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Resolution
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Execution mode of the health script on the HyperFlex cluster.\n* `ON_DEMAND` - Execute the health check on-demand.\n* `SCHEDULED` - Execute the health check on a scheduled interval."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexHealthCheckDefinition.ScriptExecutionModeEnum ScriptExecutionMode
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Indicates if the script needs to be executed on HyperFlex compute nodes. |\nTypically, scripts are only executed on the storage Nodes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool ScriptExecutionOnComputeNodes
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
        /// <para type="description">"Indicates whether the health check is executed only on the leader node, or on all nodes in the HyperFlex cluster.\n* `EXECUTE_ON_LEADER_NODE` - Execute the health check script only on the HyperFlex cluster's leader node.\n* `EXECUTE_ON_ALL_NODES` - Execute health check on all nodes and aggregate the results.\n* `EXECUTE_ON_ALL_NODES_AND_AGGREGATE` - Execute the health check on all Nodes and perform custom aggregation.\n* `EXECUTE_ON_CURRENT_NODE` - The HyperFlex health check is executed on the node which receives the request."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexHealthCheckDefinition.TargetExecutionTypeEnum TargetExecutionType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Health check script execution timeout."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Timeout
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexHealthCheckDefinition initObject = new Intersight.Model.HyperflexHealthCheckDefinition();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Category"))
            {
                initObject.Category = this.Category;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("CommonCauses"))
            {
                initObject.CommonCauses = this.CommonCauses;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Configuration"))
            {
                initObject.VarConfiguration = this.Configuration;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HealthImpact"))
            {
                initObject.HealthImpact = this.HealthImpact;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InternalName"))
            {
                initObject.InternalName = this.InternalName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MinimumHyperFlexVersion"))
            {
                initObject.MinimumHyperFlexVersion = this.MinimumHyperFlexVersion;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Reference"))
            {
                initObject.Reference = this.Reference;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Resolution"))
            {
                initObject.Resolution = this.Resolution;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ScriptExecutionMode"))
            {
                initObject.ScriptExecutionMode = this.ScriptExecutionMode;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ScriptExecutionOnComputeNodes"))
            {
                initObject.ScriptExecutionOnComputeNodes = this.ScriptExecutionOnComputeNodes;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TargetExecutionType"))
            {
                initObject.TargetExecutionType = this.TargetExecutionType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Timeout"))
            {
                initObject.Timeout = this.Timeout;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexHealthCheckExecution.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexHealthCheckExecution")]
    public class InitializeIntersightHyperflexHealthCheckExecution : PSCmdlet
    {
        public InitializeIntersightHyperflexHealthCheckExecution()
        {
            ClassId = HyperflexHealthCheckExecution.ClassIdEnum.HyperflexHealthCheckExecution;
            ObjectType = HyperflexHealthCheckExecution.ObjectTypeEnum.HyperflexHealthCheckExecution;

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
        /// <para type="description">"Information detailing the possible cause of the healthcheck failure, if the check fails."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Cause
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexHealthCheckExecution.ClassIdEnum ClassId
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

        public HyperflexHealthCheckExecution.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Information detailing a suggested resolution for the healthcheck failure, if the check fails."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SuggestedResolution
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
            Intersight.Model.HyperflexHealthCheckExecution initObject = new Intersight.Model.HyperflexHealthCheckExecution();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Cause"))
            {
                initObject.Cause = this.Cause;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("SuggestedResolution"))
            {
                initObject.SuggestedResolution = this.SuggestedResolution;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexHealthCheckExecutionSnapshot.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexHealthCheckExecutionSnapshot")]
    public class InitializeIntersightHyperflexHealthCheckExecutionSnapshot : PSCmdlet
    {
        public InitializeIntersightHyperflexHealthCheckExecutionSnapshot()
        {
            ClassId = HyperflexHealthCheckExecutionSnapshot.ClassIdEnum.HyperflexHealthCheckExecutionSnapshot;
            ObjectType = HyperflexHealthCheckExecutionSnapshot.ObjectTypeEnum.HyperflexHealthCheckExecutionSnapshot;

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
        /// <para type="description">"Information detailing the possible cause of the healthcheck failure, if the check fails."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Cause
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexHealthCheckExecutionSnapshot.ClassIdEnum ClassId
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

        public HyperflexHealthCheckExecutionSnapshot.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Information detailing a suggegsted resolution for the healthcheck failure, if the check fails."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SuggestedResolution
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
            Intersight.Model.HyperflexHealthCheckExecutionSnapshot initObject = new Intersight.Model.HyperflexHealthCheckExecutionSnapshot();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Cause"))
            {
                initObject.Cause = this.Cause;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("SuggestedResolution"))
            {
                initObject.SuggestedResolution = this.SuggestedResolution;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexHealthCheckNodeLevelInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexHealthCheckNodeLevelInfo")]
    public class InitializeIntersightHyperflexHealthCheckNodeLevelInfo : PSCmdlet
    {
        public InitializeIntersightHyperflexHealthCheckNodeLevelInfo()
        {
            ClassId = HyperflexHealthCheckNodeLevelInfo.ClassIdEnum.HyperflexHealthCheckNodeLevelInfo;
            ObjectType = HyperflexHealthCheckNodeLevelInfo.ObjectTypeEnum.HyperflexHealthCheckNodeLevelInfo;

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

        public HyperflexHealthCheckNodeLevelInfo.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexHealthCheckNodeLevelInfo.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexHealthCheckNodeLevelInfo initObject = new Intersight.Model.HyperflexHealthCheckNodeLevelInfo();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexHealthCheckPackageChecksum.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexHealthCheckPackageChecksum")]
    public class InitializeIntersightHyperflexHealthCheckPackageChecksum : PSCmdlet
    {
        public InitializeIntersightHyperflexHealthCheckPackageChecksum()
        {
            ClassId = HyperflexHealthCheckPackageChecksum.ClassIdEnum.HyperflexHealthCheckPackageChecksum;
            ObjectType = HyperflexHealthCheckPackageChecksum.ObjectTypeEnum.HyperflexHealthCheckPackageChecksum;

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
        /// <para type="description">"SHA512 checksum of the health check package."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Checksum
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexHealthCheckPackageChecksum.ClassIdEnum ClassId
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
        /// <para type="description">"Name of the health check Debian package."</para>
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

        public HyperflexHealthCheckPackageChecksum.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"HyperFlex health check Debian package file name."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string PackageName
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
        /// <para type="description">"Timestamp of last update of HyperFlex health check package checksum."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime Timestamp
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"HyperFlex health check Debian Package Version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Version
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexHealthCheckPackageChecksum initObject = new Intersight.Model.HyperflexHealthCheckPackageChecksum();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Checksum"))
            {
                initObject.Checksum = this.Checksum;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("PackageName"))
            {
                initObject.PackageName = this.PackageName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Timestamp"))
            {
                initObject.Timestamp = this.Timestamp;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Version"))
            {
                initObject.VarVersion = this.Version;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexHealthCheckSchedulePolicy.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexHealthCheckSchedulePolicy")]
    public class InitializeIntersightHyperflexHealthCheckSchedulePolicy : PSCmdlet
    {
        public InitializeIntersightHyperflexHealthCheckSchedulePolicy()
        {
            ClassId = HyperflexHealthCheckSchedulePolicy.ClassIdEnum.HyperflexHealthCheckSchedulePolicy;
            ObjectType = HyperflexHealthCheckSchedulePolicy.ObjectTypeEnum.HyperflexHealthCheckSchedulePolicy;
            ScheduleInterval = HyperflexHealthCheckSchedulePolicy.ScheduleIntervalEnum.NUMBER_86400;

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

        public HyperflexHealthCheckSchedulePolicy.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The date and time when this HealthCheck Policy was last enabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime LastScheduledOn
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The date and time when this HealthCheck Policy was last disabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime LastUnscheduledOn
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
        /// <para type="description">"The date and time when the next health check execution is expected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime NextExpectedExecution
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexHealthCheckSchedulePolicy.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Indicates whether HealthCheck schedule policy is enabled on the HyperFlex cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool PolicyEnabled
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The frequency at which the health checks are run on the HyperFlex cluster.\n* `86400` - Execute the health check every 24 hours.\n* `43200` - Execute the health check every 12 hours.\n* `21600` - Execute the health check every 6 hours.\n* `10800` - Execute the health check every 3 hours.\n* `3600` - Execute the health check every 1 hours.\n* `300` - Execute the health check every 5 minutes.\n* `0` - Disable the continuous health check."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexHealthCheckSchedulePolicy.ScheduleIntervalEnum ScheduleInterval
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
        /// <para type="description">"The unique identifier of the health check policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Uuid
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexHealthCheckSchedulePolicy initObject = new Intersight.Model.HyperflexHealthCheckSchedulePolicy();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("LastScheduledOn"))
            {
                initObject.LastScheduledOn = this.LastScheduledOn;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LastUnscheduledOn"))
            {
                initObject.LastUnscheduledOn = this.LastUnscheduledOn;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NextExpectedExecution"))
            {
                initObject.NextExpectedExecution = this.NextExpectedExecution;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("PolicyEnabled"))
            {
                initObject.PolicyEnabled = this.PolicyEnabled;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ScheduleInterval"))
            {
                initObject.ScheduleInterval = this.ScheduleInterval;
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexHealthCheckScriptInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexHealthCheckScriptInfo")]
    public class InitializeIntersightHyperflexHealthCheckScriptInfo : PSCmdlet
    {
        public InitializeIntersightHyperflexHealthCheckScriptInfo()
        {
            ClassId = HyperflexHealthCheckScriptInfo.ClassIdEnum.HyperflexHealthCheckScriptInfo;
            ObjectType = HyperflexHealthCheckScriptInfo.ObjectTypeEnum.HyperflexHealthCheckScriptInfo;

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

        public HyperflexHealthCheckScriptInfo.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexHealthCheckScriptInfo.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexHealthCheckScriptInfo initObject = new Intersight.Model.HyperflexHealthCheckScriptInfo();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexHwCatalog.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexHwCatalog")]
    public class InitializeIntersightHyperflexHwCatalog : PSCmdlet
    {
        public InitializeIntersightHyperflexHwCatalog()
        {
            ClassId = HyperflexHwCatalog.ClassIdEnum.HyperflexHwCatalog;
            ObjectType = HyperflexHwCatalog.ObjectTypeEnum.HyperflexHwCatalog;

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
        /// <para type="description">"An array of relationships to hclHwCatalogInfo resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.HclHwCatalogInfoRelationship> CatalogInfos
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexHwCatalog.ClassIdEnum ClassId
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

        public HyperflexHwCatalog.ObjectTypeEnum ObjectType
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
        /// <para type="description">"Hardware catalog version for HyperFlex hardware catalog."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Version
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexHwCatalog initObject = new Intersight.Model.HyperflexHwCatalog();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CatalogInfos"))
            {
                initObject.CatalogInfos = this.CatalogInfos;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Version"))
            {
                initObject.VarVersion = this.Version;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexHxHostMountStatusDt.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexHxHostMountStatusDt")]
    public class InitializeIntersightHyperflexHxHostMountStatusDt : PSCmdlet
    {
        public InitializeIntersightHyperflexHxHostMountStatusDt()
        {
            ClassId = HyperflexHxHostMountStatusDt.ClassIdEnum.HyperflexHxHostMountStatusDt;
            ObjectType = HyperflexHxHostMountStatusDt.ObjectTypeEnum.HyperflexHxHostMountStatusDt;

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

        public HyperflexHxHostMountStatusDt.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexHxHostMountStatusDt.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexHxHostMountStatusDt initObject = new Intersight.Model.HyperflexHxHostMountStatusDt();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexHxLicenseAuthorizationDetailsDt.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexHxLicenseAuthorizationDetailsDt")]
    public class InitializeIntersightHyperflexHxLicenseAuthorizationDetailsDt : PSCmdlet
    {
        public InitializeIntersightHyperflexHxLicenseAuthorizationDetailsDt()
        {
            ClassId = HyperflexHxLicenseAuthorizationDetailsDt.ClassIdEnum.HyperflexHxLicenseAuthorizationDetailsDt;
            ObjectType = HyperflexHxLicenseAuthorizationDetailsDt.ObjectTypeEnum.HyperflexHxLicenseAuthorizationDetailsDt;

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

        public HyperflexHxLicenseAuthorizationDetailsDt.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexHxLicenseAuthorizationDetailsDt.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexHxLicenseAuthorizationDetailsDt initObject = new Intersight.Model.HyperflexHxLicenseAuthorizationDetailsDt();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexHxLinkDt.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexHxLinkDt")]
    public class InitializeIntersightHyperflexHxLinkDt : PSCmdlet
    {
        public InitializeIntersightHyperflexHxLinkDt()
        {
            ClassId = HyperflexHxLinkDt.ClassIdEnum.HyperflexHxLinkDt;
            ObjectType = HyperflexHxLinkDt.ObjectTypeEnum.HyperflexHxLinkDt;

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

        public HyperflexHxLinkDt.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexHxLinkDt.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexHxLinkDt initObject = new Intersight.Model.HyperflexHxLinkDt();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexHxNetworkAddressDt.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexHxNetworkAddressDt")]
    public class InitializeIntersightHyperflexHxNetworkAddressDt : PSCmdlet
    {
        public InitializeIntersightHyperflexHxNetworkAddressDt()
        {
            ClassId = HyperflexHxNetworkAddressDt.ClassIdEnum.HyperflexHxNetworkAddressDt;
            ObjectType = HyperflexHxNetworkAddressDt.ObjectTypeEnum.HyperflexHxNetworkAddressDt;

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

        public HyperflexHxNetworkAddressDt.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexHxNetworkAddressDt.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexHxNetworkAddressDt initObject = new Intersight.Model.HyperflexHxNetworkAddressDt();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexHxPlatformDatastoreConfigDt.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexHxPlatformDatastoreConfigDt")]
    public class InitializeIntersightHyperflexHxPlatformDatastoreConfigDt : PSCmdlet
    {
        public InitializeIntersightHyperflexHxPlatformDatastoreConfigDt()
        {
            ClassId = HyperflexHxPlatformDatastoreConfigDt.ClassIdEnum.HyperflexHxPlatformDatastoreConfigDt;
            ObjectType = HyperflexHxPlatformDatastoreConfigDt.ObjectTypeEnum.HyperflexHxPlatformDatastoreConfigDt;

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

        public HyperflexHxPlatformDatastoreConfigDt.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexHxPlatformDatastoreConfigDt.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexHxPlatformDatastoreConfigDt initObject = new Intersight.Model.HyperflexHxPlatformDatastoreConfigDt();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexHxRegistrationDetailsDt.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexHxRegistrationDetailsDt")]
    public class InitializeIntersightHyperflexHxRegistrationDetailsDt : PSCmdlet
    {
        public InitializeIntersightHyperflexHxRegistrationDetailsDt()
        {
            ClassId = HyperflexHxRegistrationDetailsDt.ClassIdEnum.HyperflexHxRegistrationDetailsDt;
            ObjectType = HyperflexHxRegistrationDetailsDt.ObjectTypeEnum.HyperflexHxRegistrationDetailsDt;

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

        public HyperflexHxRegistrationDetailsDt.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexHxRegistrationDetailsDt.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexHxRegistrationDetailsDt initObject = new Intersight.Model.HyperflexHxRegistrationDetailsDt();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexHxResiliencyInfoDt.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexHxResiliencyInfoDt")]
    public class InitializeIntersightHyperflexHxResiliencyInfoDt : PSCmdlet
    {
        public InitializeIntersightHyperflexHxResiliencyInfoDt()
        {
            ClassId = HyperflexHxResiliencyInfoDt.ClassIdEnum.HyperflexHxResiliencyInfoDt;
            ObjectType = HyperflexHxResiliencyInfoDt.ObjectTypeEnum.HyperflexHxResiliencyInfoDt;

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

        public HyperflexHxResiliencyInfoDt.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexHxResiliencyInfoDt.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexHxResiliencyInfoDt initObject = new Intersight.Model.HyperflexHxResiliencyInfoDt();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexHxSiteDt.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexHxSiteDt")]
    public class InitializeIntersightHyperflexHxSiteDt : PSCmdlet
    {
        public InitializeIntersightHyperflexHxSiteDt()
        {
            ClassId = HyperflexHxSiteDt.ClassIdEnum.HyperflexHxSiteDt;
            ObjectType = HyperflexHxSiteDt.ObjectTypeEnum.HyperflexHxSiteDt;

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

        public HyperflexHxSiteDt.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexHxSiteDt.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexHxSiteDt initObject = new Intersight.Model.HyperflexHxSiteDt();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexHxUuIdDt.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexHxUuIdDt")]
    public class InitializeIntersightHyperflexHxUuIdDt : PSCmdlet
    {
        public InitializeIntersightHyperflexHxUuIdDt()
        {
            ClassId = HyperflexHxUuIdDt.ClassIdEnum.HyperflexHxUuIdDt;
            ObjectType = HyperflexHxUuIdDt.ObjectTypeEnum.HyperflexHxUuIdDt;

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

        public HyperflexHxUuIdDt.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexHxUuIdDt.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexHxUuIdDt initObject = new Intersight.Model.HyperflexHxUuIdDt();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexHxZoneInfoDt.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexHxZoneInfoDt")]
    public class InitializeIntersightHyperflexHxZoneInfoDt : PSCmdlet
    {
        public InitializeIntersightHyperflexHxZoneInfoDt()
        {
            ClassId = HyperflexHxZoneInfoDt.ClassIdEnum.HyperflexHxZoneInfoDt;
            ObjectType = HyperflexHxZoneInfoDt.ObjectTypeEnum.HyperflexHxZoneInfoDt;

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

        public HyperflexHxZoneInfoDt.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexHxZoneInfoDt.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexHxZoneInfoDt initObject = new Intersight.Model.HyperflexHxZoneInfoDt();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexHxZoneResiliencyInfoDt.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexHxZoneResiliencyInfoDt")]
    public class InitializeIntersightHyperflexHxZoneResiliencyInfoDt : PSCmdlet
    {
        public InitializeIntersightHyperflexHxZoneResiliencyInfoDt()
        {
            ClassId = HyperflexHxZoneResiliencyInfoDt.ClassIdEnum.HyperflexHxZoneResiliencyInfoDt;
            ObjectType = HyperflexHxZoneResiliencyInfoDt.ObjectTypeEnum.HyperflexHxZoneResiliencyInfoDt;

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

        public HyperflexHxZoneResiliencyInfoDt.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexHxZoneResiliencyInfoDt.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexHxZoneResiliencyInfoDt initObject = new Intersight.Model.HyperflexHxZoneResiliencyInfoDt();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexHxdpVersion.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexHxdpVersion")]
    public class InitializeIntersightHyperflexHxdpVersion : PSCmdlet
    {
        public InitializeIntersightHyperflexHxdpVersion()
        {
            ClassId = HyperflexHxdpVersion.ClassIdEnum.HyperflexHxdpVersion;
            ObjectType = HyperflexHxdpVersion.ObjectTypeEnum.HyperflexHxdpVersion;

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
        /// <para type="description">"A reference to a hyperflexAppCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.HyperflexAppCatalogRelationship AppCatalog
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexHxdpVersion.ClassIdEnum ClassId
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

        public HyperflexHxdpVersion.ObjectTypeEnum ObjectType
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
        /// <para type="description">"The HyperFlex Data Platform version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Version
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexHxdpVersion initObject = new Intersight.Model.HyperflexHxdpVersion();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AppCatalog"))
            {
                initObject.AppCatalog = this.AppCatalog;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Version"))
            {
                initObject.VarVersion = this.Version;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexHypervisorHost.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexHypervisorHost")]
    public class InitializeIntersightHyperflexHypervisorHost : PSCmdlet
    {
        public InitializeIntersightHyperflexHypervisorHost()
        {
            ClassId = HyperflexHypervisorHost.ClassIdEnum.HyperflexHypervisorHost;
            HypervisorType = HyperflexHypervisorHost.HypervisorTypeEnum.ESXi;
            ObjectType = HyperflexHypervisorHost.ObjectTypeEnum.HyperflexHypervisorHost;
            Status = HyperflexHypervisorHost.StatusEnum.Unknown;

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

        public HyperflexHypervisorHost.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Details about the CPUs installed on this host are represented here."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VirtualizationCpuInfo CpuInfo
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The hardware details of this host. It includes capacity, manufacturer, and model information."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.InfraHardwareInfo HardwareInfo
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Identifies the broad type of the underlying hypervisor.\n* `ESXi` - The hypervisor running on the HyperFlex cluster is a Vmware ESXi hypervisor of any version.\n* `Hyper-V` - The hypervisor running on the HyperFlex cluster is Microsoft Hyper-V.\n* `Unknown` - The hypervisor running on the HyperFlex cluster is not known."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexHypervisorHost.HypervisorTypeEnum HypervisorType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The internally generated identity of this host. This entity is not manipulated by users. It aids in uniquely identifying the datacenter object. For VMware, this is an MOR (managed object reference)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Identity
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Is this host in maintenance mode. Set to true or false."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool MaintenanceMode
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The memory capacity and usage information on this host."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VirtualizationMemoryCapacity MemoryCapacity
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Commercial model information about this hardware."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Model
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
        /// <para type="description">"Name of this host supplied by user. It is not the identity of the host. The name is subject to user manipulations."</para>
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

        public HyperflexHypervisorHost.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The capacity and usage information for CPU power on this host."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VirtualizationComputeCapacity ProcessorCapacity
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Details of this product, such as vendor, model, etc. are represented here."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VirtualizationProductInfo ProductInfo
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
        /// <para type="description">"Serial number of this host (internally generated)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Serial
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Host health status, as reported by the hypervisor platform.\n* `Unknown` - Entity status is unknown.\n* `Degraded` - State is degraded, and might impact normal operation of the entity.\n* `Critical` - Entity is in a critical state, impacting operations.\n* `Ok` - Entity status is in a stable state, operating normally."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexHypervisorHost.StatusEnum Status
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
        /// <para type="description">"The uptime of the host, stored as Duration (from w3c)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string UpTime
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Universally unique identity of this host (example b3d4483b-5560-9342-8309-b486c9236610). Internally generated."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12}$")]
        public string Uuid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Commercial vendor details of this hardware."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Vendor
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexHypervisorHost initObject = new Intersight.Model.HyperflexHypervisorHost();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("CpuInfo"))
            {
                initObject.CpuInfo = this.CpuInfo;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HardwareInfo"))
            {
                initObject.HardwareInfo = this.HardwareInfo;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HypervisorType"))
            {
                initObject.HypervisorType = this.HypervisorType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Identity"))
            {
                initObject.Identity = this.Identity;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaintenanceMode"))
            {
                initObject.MaintenanceMode = this.MaintenanceMode;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MemoryCapacity"))
            {
                initObject.MemoryCapacity = this.MemoryCapacity;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Model"))
            {
                initObject.Model = this.Model;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("ProcessorCapacity"))
            {
                initObject.ProcessorCapacity = this.ProcessorCapacity;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ProductInfo"))
            {
                initObject.ProductInfo = this.ProductInfo;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RegisteredDevice"))
            {
                initObject.RegisteredDevice = this.RegisteredDevice;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Serial"))
            {
                initObject.Serial = this.Serial;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Status"))
            {
                initObject.Status = this.Status;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UpTime"))
            {
                initObject.UpTime = this.UpTime;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Uuid"))
            {
                initObject.Uuid = this.Uuid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Vendor"))
            {
                initObject.Vendor = this.Vendor;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexHypervisorVirtualMachine.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexHypervisorVirtualMachine")]
    public class InitializeIntersightHyperflexHypervisorVirtualMachine : PSCmdlet
    {
        public InitializeIntersightHyperflexHypervisorVirtualMachine()
        {
            ClassId = HyperflexHypervisorVirtualMachine.ClassIdEnum.HyperflexHypervisorVirtualMachine;
            HypervisorType = HyperflexHypervisorVirtualMachine.HypervisorTypeEnum.ESXi;
            ObjectType = HyperflexHypervisorVirtualMachine.ObjectTypeEnum.HyperflexHypervisorVirtualMachine;
            PowerState = HyperflexHypervisorVirtualMachine.PowerStateEnum.Unknown;
            Provider = HyperflexHypervisorVirtualMachine.ProviderEnum.Unknown;
            State = HyperflexHypervisorVirtualMachine.StateEnum.None;

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
        /// <para type="description">"Time when this VM booted up."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime BootTime
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Provisioned CPU and memory information for this virtual machine."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.InfraHardwareInfo Capacity
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexHypervisorVirtualMachine.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Average CPU utilization percentage derived as a ratio of CPU used to CPU allocated. The value is calculated whenever inventory is performed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public float CpuUtilization
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Guest operating system details running on this machine."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VirtualizationGuestInfo GuestInfo
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of hypervisor where the virtual machine is hosted for example ESXi.\n* `ESXi` - The hypervisor running on the HyperFlex cluster is a Vmware ESXi hypervisor of any version.\n* `Hyper-V` - The hypervisor running on the HyperFlex cluster is Microsoft Hyper-V.\n* `Unknown` - The hypervisor running on the HyperFlex cluster is not known."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexHypervisorVirtualMachine.HypervisorTypeEnum HypervisorType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The internally generated identity of this VM. This entity is not manipulated by users. It aids in uniquely identifying the virtual machine object. For VMware, this is MOR (managed object reference)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Identity
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> IpAddress
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The capacity and usage information for memory on this virtual machine."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VirtualizationMemoryCapacity MemoryCapacity
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Average memory utilization percentage derived as a ratio of memory used to available memory. The value is calculated whenever inventory is performed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public float MemoryUtilization
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
        /// <para type="description">"User-provided name to identify the virtual machine."</para>
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

        public HyperflexHypervisorVirtualMachine.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Power state of the virtual machine.\n* `Unknown` - The entity's power state is unknown.\n* `PoweringOn` - The entity is powering on.\n* `PoweredOn` - The entity is powered on.\n* `PoweringOff` - The entity is powering off.\n* `PoweredOff` - The entity is powered down.\n* `StandBy` - The entity is in standby mode.\n* `Paused` - The entity is in pause state.\n* `Rebooting` - The entity reboot is in progress.\n* `` - The entity's power state is not available."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexHypervisorVirtualMachine.PowerStateEnum PowerState
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The capacity and usage information for CPU power on this virtual machine."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VirtualizationComputeCapacity ProcessorCapacity
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Cloud platform, where the virtual machine is launched.\n* `Unknown` - Cloud provider is not known.\n* `VMwarevSphere` - Cloud provider named VMware vSphere.\n* `AmazonWebServices` - Cloud provider named Amazon Web Services.\n* `MicrosoftAzure` - Cloud provider named Microsoft Azure.\n* `GoogleCloudPlatform` - Cloud provider named Google Cloud Platform."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexHypervisorVirtualMachine.ProviderEnum Provider
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
        /// <para type="description">"The current state of the virtual machine. For example, starting, stopped, etc.\n* `None` - A place holder for the default value.\n* `Creating` - Virtual machine creation is in progress.\n* `Pending` - The virtual machine is preparing to enter the started state.\n* `Starting` - The virtual machine is starting.\n* `Started` - The virtual machine is running and ready for use.\n* `Stopping` - The virtual machine is preparing to be stopped.\n* `Stopped` - The virtual machine is shut down and cannot be used. The virtual machine can be started again at any time.\n* `Pausing` - The virtual machine is preparing to be paused.\n* `Paused` - The virtual machine enters into paused state due to low free disk space.\n* `Suspending` - The virtual machine is preparing to be suspended.\n* `Suspended` - Virtual machine is in sleep mode.When a virtual machine is suspended, the current state of theoperating system, and applications is saved, and the virtual machine put into a suspended mode.\n* `Deleting` - The virtual machine is preparing to be terminated.\n* `Terminated` - The virtual machine has been permanently deleted and cannot be started.\n* `Rebooting` - The virtual machine reboot is in progress.\n* `Error` - The deployment of virtual machine is failed.\n* `Warning` - The virtual machine is in warning state."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexHypervisorVirtualMachine.StateEnum State
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
        /// <para type="description">"The uuid of this virtual machine. The uuid is internally generated and not user specified."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12}$")]
        public string Uuid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Time when this virtualmachine is created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime VmCreationTime
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexHypervisorVirtualMachine initObject = new Intersight.Model.HyperflexHypervisorVirtualMachine();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BootTime"))
            {
                initObject.BootTime = this.BootTime;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Capacity"))
            {
                initObject.Capacity = this.Capacity;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("CpuUtilization"))
            {
                initObject.CpuUtilization = this.CpuUtilization;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("GuestInfo"))
            {
                initObject.GuestInfo = this.GuestInfo;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HypervisorType"))
            {
                initObject.HypervisorType = this.HypervisorType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Identity"))
            {
                initObject.Identity = this.Identity;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IpAddress"))
            {
                initObject.IpAddress = this.IpAddress;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MemoryCapacity"))
            {
                initObject.MemoryCapacity = this.MemoryCapacity;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MemoryUtilization"))
            {
                initObject.MemoryUtilization = this.MemoryUtilization;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("PowerState"))
            {
                initObject.PowerState = this.PowerState;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ProcessorCapacity"))
            {
                initObject.ProcessorCapacity = this.ProcessorCapacity;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Provider"))
            {
                initObject.Provider = this.Provider;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RegisteredDevice"))
            {
                initObject.RegisteredDevice = this.RegisteredDevice;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("State"))
            {
                initObject.State = this.State;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Uuid"))
            {
                initObject.Uuid = this.Uuid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VmCreationTime"))
            {
                initObject.VmCreationTime = this.VmCreationTime;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexInitiatorGroup.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexInitiatorGroup")]
    public class InitializeIntersightHyperflexInitiatorGroup : PSCmdlet
    {
        public InitializeIntersightHyperflexInitiatorGroup()
        {
            ClassId = HyperflexInitiatorGroup.ClassIdEnum.HyperflexInitiatorGroup;
            ObjectType = HyperflexInitiatorGroup.ObjectTypeEnum.HyperflexInitiatorGroup;

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

        public HyperflexInitiatorGroup.ClassIdEnum ClassId
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

        public HyperflexInitiatorGroup.ObjectTypeEnum ObjectType
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
            Intersight.Model.HyperflexInitiatorGroup initObject = new Intersight.Model.HyperflexInitiatorGroup();
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexIpAddrRange.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexIpAddrRange")]
    public class InitializeIntersightHyperflexIpAddrRange : PSCmdlet
    {
        public InitializeIntersightHyperflexIpAddrRange()
        {
            ClassId = HyperflexIpAddrRange.ClassIdEnum.HyperflexIpAddrRange;
            ObjectType = HyperflexIpAddrRange.ObjectTypeEnum.HyperflexIpAddrRange;

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

        public HyperflexIpAddrRange.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The end IPv4 address of the range."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string EndAddr
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The default gateway for the start and end IPv4 addresses."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string Gateway
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.CommIpV4AddressBlock> IpAddrBlocks
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The netmask specified in dot decimal notation.\nThe start address, end address, and gateway must all be within the network specified by this netmask."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^(((255\\.){3}(255|254|252|248|240|224|192|128|0+))|((255\\.){2}(255|254|252|248|240|224|192|128|0+)\\.0)|((255\\.)(255|254|252|248|240|224|192|128|0+)(\\.0+){2})|((255|254|252|248|240|224|192|128|0+)(\\.0+){3}))$")]
        public string Netmask
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexIpAddrRange.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The start IPv4 address of the range."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string StartAddr
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexIpAddrRange initObject = new Intersight.Model.HyperflexIpAddrRange();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("EndAddr"))
            {
                initObject.EndAddr = this.EndAddr;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Gateway"))
            {
                initObject.Gateway = this.Gateway;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IpAddrBlocks"))
            {
                initObject.IpAddrBlocks = this.IpAddrBlocks;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Netmask"))
            {
                initObject.Netmask = this.Netmask;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("StartAddr"))
            {
                initObject.StartAddr = this.StartAddr;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexIscsiNetwork.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexIscsiNetwork")]
    public class InitializeIntersightHyperflexIscsiNetwork : PSCmdlet
    {
        public InitializeIntersightHyperflexIscsiNetwork()
        {
            ClassId = HyperflexIscsiNetwork.ClassIdEnum.HyperflexIscsiNetwork;
            ObjectType = HyperflexIscsiNetwork.ObjectTypeEnum.HyperflexIscsiNetwork;

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

        public HyperflexIscsiNetwork.ClassIdEnum ClassId
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

        public HyperflexIscsiNetwork.ObjectTypeEnum ObjectType
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
            Intersight.Model.HyperflexIscsiNetwork initObject = new Intersight.Model.HyperflexIscsiNetwork();
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexKeyEncryptionKey.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexKeyEncryptionKey")]
    public class InitializeIntersightHyperflexKeyEncryptionKey : PSCmdlet
    {
        public InitializeIntersightHyperflexKeyEncryptionKey()
        {
            ClassId = HyperflexKeyEncryptionKey.ClassIdEnum.HyperflexKeyEncryptionKey;
            KeyState = HyperflexKeyEncryptionKey.KeyStateEnum.NEW;
            ObjectType = HyperflexKeyEncryptionKey.ObjectTypeEnum.HyperflexKeyEncryptionKey;
            ResourceType = HyperflexKeyEncryptionKey.ResourceTypeEnum.CLUSTER;

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

        public HyperflexKeyEncryptionKey.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a hyperflexClusterProfile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.HyperflexClusterProfileRelationship ClusterProfile
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"This defines whether we need to operate in an account recovery scenario or not. If yes, then most of the parameters will be populated from an internal MO. So, some of the input parameters MAY be ignored, if this value is set to true."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool IsAccountRecovery
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of iterations we want the hash to be run."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Iteration
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Key encryption key used to encrypt the DEK's on the HyperFlex cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Kek
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Resource id + time of creation used for retrieving the KEK."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string KeyId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Last known Key encryption key state for this Key.\n* `NEW` - Key Encryption key is newly created.\n* `ACTIVE` - Key Encryption key is deployed on active resource.\n* `INACTIVE` - Key Encryption key is inactive and not used.\n* `INPROGRESS` - Key Encryption key is in a state where it was used on Intersight but did not receive confirmation from platform of success/failure."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexKeyEncryptionKey.KeyStateEnum KeyState
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

        public HyperflexKeyEncryptionKey.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Initial passphrase for the encryption policy, password must contain a minimum of 12 characters, with at least 1 lowercase, 1 uppercase, 1 numeric."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Passphrase
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.MoBaseMoRelationship ResourceMo
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Resource type on which this key will be applied.\n* `CLUSTER` - Encryption is per HyperFlex cluster.\n* `DATASTORE` - Encryption is per dataStore on the HyperFlex cluster.\n* `DRIVE` - Encryption is per drive on the HyperFlex cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexKeyEncryptionKey.ResourceTypeEnum ResourceType
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
        /// <para type="description">"Copy of Key encryption key, which is used for sending the key over to the remote device endpoint. It is not persisited anywhere."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string TransitKek
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexKeyEncryptionKey initObject = new Intersight.Model.HyperflexKeyEncryptionKey();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ClusterProfile"))
            {
                initObject.ClusterProfile = this.ClusterProfile;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IsAccountRecovery"))
            {
                initObject.IsAccountRecovery = this.IsAccountRecovery;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Iteration"))
            {
                initObject.Iteration = this.Iteration;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Kek"))
            {
                initObject.Kek = this.Kek;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("KeyId"))
            {
                initObject.KeyId = this.KeyId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("KeyState"))
            {
                initObject.KeyState = this.KeyState;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Passphrase"))
            {
                initObject.Passphrase = this.Passphrase;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ResourceMo"))
            {
                initObject.ResourceMo = this.ResourceMo;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ResourceType"))
            {
                initObject.ResourceType = this.ResourceType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TransitKek"))
            {
                initObject.TransitKek = this.TransitKek;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexLicense.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexLicense")]
    public class InitializeIntersightHyperflexLicense : PSCmdlet
    {
        public InitializeIntersightHyperflexLicense()
        {
            ClassId = HyperflexLicense.ClassIdEnum.HyperflexLicense;
            ObjectType = HyperflexLicense.ObjectTypeEnum.HyperflexLicense;

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

        public HyperflexLicense.ClassIdEnum ClassId
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

        public HyperflexLicense.ObjectTypeEnum ObjectType
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
            Intersight.Model.HyperflexLicense initObject = new Intersight.Model.HyperflexLicense();
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexLocalCredentialPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexLocalCredentialPolicy")]
    public class InitializeIntersightHyperflexLocalCredentialPolicy : PSCmdlet
    {
        public InitializeIntersightHyperflexLocalCredentialPolicy()
        {
            ClassId = HyperflexLocalCredentialPolicy.ClassIdEnum.HyperflexLocalCredentialPolicy;
            ObjectType = HyperflexLocalCredentialPolicy.ObjectTypeEnum.HyperflexLocalCredentialPolicy;

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

        public HyperflexLocalCredentialPolicy.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to hyperflexClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.HyperflexClusterProfileRelationship> ClusterProfiles
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
        /// <para type="description">"Indicates if Hypervisor password is the factory set default password. For HyperFlex Data Platform versions 3.0 or higher, enable this if the default password was not changed on the Hypervisor. It is required to supply a new custom Hypervisor password that will be applied to the Hypervisor during deployment. For HyperFlex Data Platform versions prior to 3.0 release, this setting has no effect and the default password will be used for initial install. The Hypervisor password should be changed after deployment."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool FactoryHypervisorPassword
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"HyperFlex storage controller VM password must contain a minimum of 10 characters, with at least 1 lowercase, 1 uppercase, 1 numeric, and 1 of these -_@#$%^&*! special characters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9!@#$%^&*_-]{10,}$")]
        public string HxdpRootPwd
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Hypervisor administrator username must contain only alphanumeric characters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9]{1,}$")]
        public string HypervisorAdmin
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Hypervisor root password. For HyperFlex Data Platform 3.0 or later, if the factory default password was not manually changed, you must set a new custom password. If the password was manually changed, you must not enable the factory default password property and provide the current hypervisor password. Note - All HyperFlex nodes require the same hypervisor password for installation. For HyperFlex Data Platform prior to 3.0, use the default password \"Cisco123\" for newly manufactured HyperFlex servers. A custom password should only be entered if hypervisor credentials were manually changed prior to deployment."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^.{7,40}$")]
        public string HypervisorAdminPwd
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

        public HyperflexLocalCredentialPolicy.ObjectTypeEnum ObjectType
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
            Intersight.Model.HyperflexLocalCredentialPolicy initObject = new Intersight.Model.HyperflexLocalCredentialPolicy();
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
            if (this.MyInvocation.BoundParameters.ContainsKey("FactoryHypervisorPassword"))
            {
                initObject.FactoryHypervisorPassword = this.FactoryHypervisorPassword;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HxdpRootPwd"))
            {
                initObject.HxdpRootPwd = this.HxdpRootPwd;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HypervisorAdmin"))
            {
                initObject.HypervisorAdmin = this.HypervisorAdmin;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HypervisorAdminPwd"))
            {
                initObject.HypervisorAdminPwd = this.HypervisorAdminPwd;
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexLogicalAvailabilityZone.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexLogicalAvailabilityZone")]
    public class InitializeIntersightHyperflexLogicalAvailabilityZone : PSCmdlet
    {
        public InitializeIntersightHyperflexLogicalAvailabilityZone()
        {
            ClassId = HyperflexLogicalAvailabilityZone.ClassIdEnum.HyperflexLogicalAvailabilityZone;
            ObjectType = HyperflexLogicalAvailabilityZone.ObjectTypeEnum.HyperflexLogicalAvailabilityZone;

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
        /// <para type="description">"Enable or disable Logical Availability Zones (LAZ).\nIf enabled, HyperFlex Data Platform automatically selects and groups nodes into different availability zones. For HyperFlex Data Platform versions prior to 3.0 release, this setting does not apply. For HyperFlex Data Platform versions 3.0 or higher, this setting is only applicable to HyperFlex systems with 8 or more converged nodes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool AutoConfig
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexLogicalAvailabilityZone.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexLogicalAvailabilityZone.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexLogicalAvailabilityZone initObject = new Intersight.Model.HyperflexLogicalAvailabilityZone();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AutoConfig"))
            {
                initObject.AutoConfig = this.AutoConfig;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexLun.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexLun")]
    public class InitializeIntersightHyperflexLun : PSCmdlet
    {
        public InitializeIntersightHyperflexLun()
        {
            ClassId = HyperflexLun.ClassIdEnum.HyperflexLun;
            ObjectType = HyperflexLun.ObjectTypeEnum.HyperflexLun;

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

        public HyperflexLun.ClassIdEnum ClassId
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

        public HyperflexLun.ObjectTypeEnum ObjectType
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
            Intersight.Model.HyperflexLun initObject = new Intersight.Model.HyperflexLun();
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexMacAddrPrefixRange.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexMacAddrPrefixRange")]
    public class InitializeIntersightHyperflexMacAddrPrefixRange : PSCmdlet
    {
        public InitializeIntersightHyperflexMacAddrPrefixRange()
        {
            ClassId = HyperflexMacAddrPrefixRange.ClassIdEnum.HyperflexMacAddrPrefixRange;
            ObjectType = HyperflexMacAddrPrefixRange.ObjectTypeEnum.HyperflexMacAddrPrefixRange;

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

        public HyperflexMacAddrPrefixRange.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The end MAC address prefix of a MAC address prefix range in the form of 00:25:B5:XX."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^00:25:B5:[0-9a-fA-F]{2}$")]
        public string EndAddr
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexMacAddrPrefixRange.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The start MAC address prefix of a MAC address prefix range in the form of 00:25:B5:XX."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^00:25:B5:[0-9a-fA-F]{2}$")]
        public string StartAddr
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexMacAddrPrefixRange initObject = new Intersight.Model.HyperflexMacAddrPrefixRange();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("EndAddr"))
            {
                initObject.EndAddr = this.EndAddr;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("StartAddr"))
            {
                initObject.StartAddr = this.StartAddr;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexMapClusterIdToProtectionInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexMapClusterIdToProtectionInfo")]
    public class InitializeIntersightHyperflexMapClusterIdToProtectionInfo : PSCmdlet
    {
        public InitializeIntersightHyperflexMapClusterIdToProtectionInfo()
        {
            ClassId = HyperflexMapClusterIdToProtectionInfo.ClassIdEnum.HyperflexMapClusterIdToProtectionInfo;
            ObjectType = HyperflexMapClusterIdToProtectionInfo.ObjectTypeEnum.HyperflexMapClusterIdToProtectionInfo;

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

        public HyperflexMapClusterIdToProtectionInfo.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexMapClusterIdToProtectionInfo.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexMapClusterIdToProtectionInfo initObject = new Intersight.Model.HyperflexMapClusterIdToProtectionInfo();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexMapClusterIdToStSnapshotPoint.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexMapClusterIdToStSnapshotPoint")]
    public class InitializeIntersightHyperflexMapClusterIdToStSnapshotPoint : PSCmdlet
    {
        public InitializeIntersightHyperflexMapClusterIdToStSnapshotPoint()
        {
            ClassId = HyperflexMapClusterIdToStSnapshotPoint.ClassIdEnum.HyperflexMapClusterIdToStSnapshotPoint;
            ObjectType = HyperflexMapClusterIdToStSnapshotPoint.ObjectTypeEnum.HyperflexMapClusterIdToStSnapshotPoint;

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

        public HyperflexMapClusterIdToStSnapshotPoint.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexMapClusterIdToStSnapshotPoint.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexMapClusterIdToStSnapshotPoint initObject = new Intersight.Model.HyperflexMapClusterIdToStSnapshotPoint();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexMapUuidToTrackedDisk.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexMapUuidToTrackedDisk")]
    public class InitializeIntersightHyperflexMapUuidToTrackedDisk : PSCmdlet
    {
        public InitializeIntersightHyperflexMapUuidToTrackedDisk()
        {
            ClassId = HyperflexMapUuidToTrackedDisk.ClassIdEnum.HyperflexMapUuidToTrackedDisk;
            ObjectType = HyperflexMapUuidToTrackedDisk.ObjectTypeEnum.HyperflexMapUuidToTrackedDisk;

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

        public HyperflexMapUuidToTrackedDisk.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexMapUuidToTrackedDisk.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexMapUuidToTrackedDisk initObject = new Intersight.Model.HyperflexMapUuidToTrackedDisk();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexNamedVlan.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexNamedVlan")]
    public class InitializeIntersightHyperflexNamedVlan : PSCmdlet
    {
        public InitializeIntersightHyperflexNamedVlan()
        {
            ClassId = HyperflexNamedVlan.ClassIdEnum.HyperflexNamedVlan;
            ObjectType = HyperflexNamedVlan.ObjectTypeEnum.HyperflexNamedVlan;

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

        public HyperflexNamedVlan.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the VLAN.\nThe name can be from 1 to 32 characters long and can contain a combination of alphanumeric characters, underscores, and hyphens."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9-_.]{1,32}$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexNamedVlan.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The ID of the named VLAN. An ID of 0 means the traffic is untagged.\nThe ID can be any number between 0 and 4095, inclusive."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long VlanId
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexNamedVlan initObject = new Intersight.Model.HyperflexNamedVlan();
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
            if (this.MyInvocation.BoundParameters.ContainsKey("VlanId"))
            {
                initObject.VlanId = this.VlanId;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexNamedVsan.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexNamedVsan")]
    public class InitializeIntersightHyperflexNamedVsan : PSCmdlet
    {
        public InitializeIntersightHyperflexNamedVsan()
        {
            ClassId = HyperflexNamedVsan.ClassIdEnum.HyperflexNamedVsan;
            ObjectType = HyperflexNamedVsan.ObjectTypeEnum.HyperflexNamedVsan;

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

        public HyperflexNamedVsan.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the VSAN.\nThe name can be from 1 to 32 characters long and can contain a combination of alphanumeric characters, underscores, and hyphens."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9-_.]{1,32}$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexNamedVsan.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The ID of the named VSAN.\nThe ID can be any number between 1 and 4093, inclusive."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 4093)]
        public long VsanId
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexNamedVsan initObject = new Intersight.Model.HyperflexNamedVsan();
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
            if (this.MyInvocation.BoundParameters.ContainsKey("VsanId"))
            {
                initObject.VsanId = this.VsanId;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexNetworkConfiguration.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexNetworkConfiguration")]
    public class InitializeIntersightHyperflexNetworkConfiguration : PSCmdlet
    {
        public InitializeIntersightHyperflexNetworkConfiguration()
        {
            ClassId = HyperflexNetworkConfiguration.ClassIdEnum.HyperflexNetworkConfiguration;
            ObjectType = HyperflexNetworkConfiguration.ObjectTypeEnum.HyperflexNetworkConfiguration;

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

        public HyperflexNetworkConfiguration.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Cluster data IP of the HyperFlex cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string ClusterDataIp
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Cluster management IP of the HyperFlex cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string ClusterManagementIp
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Default gateway of the data network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string DataDefaultGateway
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Boolean value to indicate if jumboframes is enabled for storage-data network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool DataJumboFrame
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Subnet mask of the data network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string DataSubNetmask
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Data VLAN ID. Enter the correct VLAN tags if you are using trunk ports. The VLAN tags must be different when using trunk mode."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long DataVlanId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"VLAN ID for virtual machine live migration."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long LiveMigrationVlanId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Default gateway of the management network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ManagementDefaultGateway
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Subnet mask of the management network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ManagementSubNetmask
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Management VLAN ID. Enter the correct VLAN tags if you are using trunk ports. The VLAN tags must be different when using trunk mode."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long ManagementVlanId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexNetworkConfiguration.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"VM network VLAN ID. Used for VM data traffic."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long VmNetworkVlanId
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexNetworkConfiguration initObject = new Intersight.Model.HyperflexNetworkConfiguration();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ClusterDataIp"))
            {
                initObject.ClusterDataIp = this.ClusterDataIp;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ClusterManagementIp"))
            {
                initObject.ClusterManagementIp = this.ClusterManagementIp;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DataDefaultGateway"))
            {
                initObject.DataDefaultGateway = this.DataDefaultGateway;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DataJumboFrame"))
            {
                initObject.DataJumboFrame = this.DataJumboFrame;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DataSubNetmask"))
            {
                initObject.DataSubNetmask = this.DataSubNetmask;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DataVlanId"))
            {
                initObject.DataVlanId = this.DataVlanId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LiveMigrationVlanId"))
            {
                initObject.LiveMigrationVlanId = this.LiveMigrationVlanId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ManagementDefaultGateway"))
            {
                initObject.ManagementDefaultGateway = this.ManagementDefaultGateway;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ManagementSubNetmask"))
            {
                initObject.ManagementSubNetmask = this.ManagementSubNetmask;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ManagementVlanId"))
            {
                initObject.ManagementVlanId = this.ManagementVlanId;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("VmNetworkVlanId"))
            {
                initObject.VmNetworkVlanId = this.VmNetworkVlanId;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexNode.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexNode")]
    public class InitializeIntersightHyperflexNode : PSCmdlet
    {
        public InitializeIntersightHyperflexNode()
        {
            ClassId = HyperflexNode.ClassIdEnum.HyperflexNode;
            ObjectType = HyperflexNode.ObjectTypeEnum.HyperflexNode;

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

        public HyperflexNode.ClassIdEnum ClassId
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

        public HyperflexNode.ObjectTypeEnum ObjectType
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
            Intersight.Model.HyperflexNode initObject = new Intersight.Model.HyperflexNode();
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexNodeConfigPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexNodeConfigPolicy")]
    public class InitializeIntersightHyperflexNodeConfigPolicy : PSCmdlet
    {
        public InitializeIntersightHyperflexNodeConfigPolicy()
        {
            ClassId = HyperflexNodeConfigPolicy.ClassIdEnum.HyperflexNodeConfigPolicy;
            ObjectType = HyperflexNodeConfigPolicy.ObjectTypeEnum.HyperflexNodeConfigPolicy;

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

        public HyperflexNodeConfigPolicy.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to hyperflexClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.HyperflexClusterProfileRelationship> ClusterProfiles
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The range of storage data IPs to be assigned to the nodes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.HyperflexIpAddrRange DataIpRange
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
        /// <para type="description">"The range of storage management IPs to be assigned to the nodes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.HyperflexIpAddrRange HxdpIpRange
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The range of IPs to be assigned to each hypervisor node for VM migration and hypervior control."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.HyperflexIpAddrRange HypervisorControlIpRange
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The range of management IPs to be assigned to the nodes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.HyperflexIpAddrRange MgmtIpRange
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
        /// <para type="description">"The node name prefix that is used to automatically generate the default hostname for each server.\nA dash (-) will be appended to the prefix followed by the node number to form a hostname.\nThis default naming scheme can be manually overridden in the node configuration.\nThe maximum length of a prefix is 60, must only contain alphanumeric characters or dash (-), and must\nstart with an alphanumeric character."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9][a-zA-Z0-9-]{1,59}$")]
        public string NodeNamePrefix
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexNodeConfigPolicy.ObjectTypeEnum ObjectType
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
            Intersight.Model.HyperflexNodeConfigPolicy initObject = new Intersight.Model.HyperflexNodeConfigPolicy();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ClusterProfiles"))
            {
                initObject.ClusterProfiles = this.ClusterProfiles;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DataIpRange"))
            {
                initObject.DataIpRange = this.DataIpRange;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HxdpIpRange"))
            {
                initObject.HxdpIpRange = this.HxdpIpRange;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HypervisorControlIpRange"))
            {
                initObject.HypervisorControlIpRange = this.HypervisorControlIpRange;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MgmtIpRange"))
            {
                initObject.MgmtIpRange = this.MgmtIpRange;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NodeNamePrefix"))
            {
                initObject.NodeNamePrefix = this.NodeNamePrefix;
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexNodeProfile.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexNodeProfile")]
    public class InitializeIntersightHyperflexNodeProfile : PSCmdlet
    {
        public InitializeIntersightHyperflexNodeProfile()
        {
            ClassId = HyperflexNodeProfile.ClassIdEnum.HyperflexNodeProfile;
            NodeRole = HyperflexNodeProfile.NodeRoleEnum.Unknown;
            ObjectType = HyperflexNodeProfile.ObjectTypeEnum.HyperflexNodeProfile;
            Type = HyperflexNodeProfile.TypeEnum.Instance;

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
        /// <para type="description">"A reference to a computePhysical resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.ComputePhysicalRelationship AssignedServer
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexNodeProfile.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a hyperflexClusterProfile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.HyperflexClusterProfileRelationship ClusterProfile
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
        /// <para type="description">"IP address for storage data network (Controller VM interface)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string HxdpDataIp
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"IP address for HyperFlex management network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string HxdpMgmtIp
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"IP address for storage client network (Controller VM interface)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string HxdpStorageClientIp
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"IP address for hypervisor control such as VM migration or pod management."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string HypervisorControlIp
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"IP address for storage data network (Hypervisor interface)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string HypervisorDataIp
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"IP address for Hypervisor management network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string HypervisorMgmtIp
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
        /// <para type="description">"The role that this node performs in the HyperFlex cluster.\n* `Unknown` - The node role is not available.\n* `Storage` - The node persists data and contributes to the storage capacity of a cluster.\n* `Compute` - The node contributes to the compute capacity of a cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexNodeProfile.NodeRoleEnum NodeRole
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexNodeProfile.ObjectTypeEnum ObjectType
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.PolicyScheduledAction> ScheduledActions
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

        public HyperflexNodeProfile.TypeEnum Type
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexNodeProfile initObject = new Intersight.Model.HyperflexNodeProfile();
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
            if (this.MyInvocation.BoundParameters.ContainsKey("AssignedServer"))
            {
                initObject.AssignedServer = this.AssignedServer;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("HxdpDataIp"))
            {
                initObject.HxdpDataIp = this.HxdpDataIp;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HxdpMgmtIp"))
            {
                initObject.HxdpMgmtIp = this.HxdpMgmtIp;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HxdpStorageClientIp"))
            {
                initObject.HxdpStorageClientIp = this.HxdpStorageClientIp;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HypervisorControlIp"))
            {
                initObject.HypervisorControlIp = this.HypervisorControlIp;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HypervisorDataIp"))
            {
                initObject.HypervisorDataIp = this.HypervisorDataIp;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HypervisorMgmtIp"))
            {
                initObject.HypervisorMgmtIp = this.HypervisorMgmtIp;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NodeRole"))
            {
                initObject.NodeRole = this.NodeRole;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("PolicyBucket"))
            {
                initObject.PolicyBucket = this.PolicyBucket;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ScheduledActions"))
            {
                initObject.ScheduledActions = this.ScheduledActions;
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
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexPortTypeToPortNumberMap.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexPortTypeToPortNumberMap")]
    public class InitializeIntersightHyperflexPortTypeToPortNumberMap : PSCmdlet
    {
        public InitializeIntersightHyperflexPortTypeToPortNumberMap()
        {
            ClassId = HyperflexPortTypeToPortNumberMap.ClassIdEnum.HyperflexPortTypeToPortNumberMap;
            ObjectType = HyperflexPortTypeToPortNumberMap.ObjectTypeEnum.HyperflexPortTypeToPortNumberMap;

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

        public HyperflexPortTypeToPortNumberMap.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexPortTypeToPortNumberMap.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexPortTypeToPortNumberMap initObject = new Intersight.Model.HyperflexPortTypeToPortNumberMap();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexProtectedCluster.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexProtectedCluster")]
    public class InitializeIntersightHyperflexProtectedCluster : PSCmdlet
    {
        public InitializeIntersightHyperflexProtectedCluster()
        {
            ClassId = HyperflexProtectedCluster.ClassIdEnum.HyperflexProtectedCluster;
            ObjectType = HyperflexProtectedCluster.ObjectTypeEnum.HyperflexProtectedCluster;

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

        public HyperflexProtectedCluster.ClassIdEnum ClassId
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

        public HyperflexProtectedCluster.ObjectTypeEnum ObjectType
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
            Intersight.Model.HyperflexProtectedCluster initObject = new Intersight.Model.HyperflexProtectedCluster();
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexProtectionInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexProtectionInfo")]
    public class InitializeIntersightHyperflexProtectionInfo : PSCmdlet
    {
        public InitializeIntersightHyperflexProtectionInfo()
        {
            ClassId = HyperflexProtectionInfo.ClassIdEnum.HyperflexProtectionInfo;
            ObjectType = HyperflexProtectionInfo.ObjectTypeEnum.HyperflexProtectionInfo;

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

        public HyperflexProtectionInfo.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexProtectionInfo.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexProtectionInfo initObject = new Intersight.Model.HyperflexProtectionInfo();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexProxySettingPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexProxySettingPolicy")]
    public class InitializeIntersightHyperflexProxySettingPolicy : PSCmdlet
    {
        public InitializeIntersightHyperflexProxySettingPolicy()
        {
            ClassId = HyperflexProxySettingPolicy.ClassIdEnum.HyperflexProxySettingPolicy;
            ObjectType = HyperflexProxySettingPolicy.ObjectTypeEnum.HyperflexProxySettingPolicy;

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

        public HyperflexProxySettingPolicy.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to hyperflexClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.HyperflexClusterProfileRelationship> ClusterProfiles
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
        /// <para type="description">"HTTP Proxy server FQDN or IP."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[A-Za-z]([A-Za-z0-9-]*[A-Za-z0-9])?$|^[A-Za-z0-9]([A-Za-z0-9-]*[A-Za-z0-9])?(\\.[A-Za-z0-9]([A-Za-z0-9-]*[A-Za-z0-9])?)*(\\.[A-Za-z]([A-Za-z0-9-]*[A-Za-z0-9])?)$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string Hostname
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

        public HyperflexProxySettingPolicy.ObjectTypeEnum ObjectType
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
        /// <para type="description">"The password for the HTTP Proxy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Password
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The HTTP Proxy port number.\nThe port number of the HTTP proxy must be between 1 and 65535, inclusive."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 65535)]
        public long Port
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
        /// <para type="description">"The username for the HTTP Proxy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Username
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexProxySettingPolicy initObject = new Intersight.Model.HyperflexProxySettingPolicy();
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Hostname"))
            {
                initObject.Hostname = this.Hostname;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Password"))
            {
                initObject.Password = this.Password;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Port"))
            {
                initObject.Port = this.Port;
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexReSyncClusterMoIds.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexReSyncClusterMoIds")]
    public class InitializeIntersightHyperflexReSyncClusterMoIds : PSCmdlet
    {
        public InitializeIntersightHyperflexReSyncClusterMoIds()
        {
            ClassId = HyperflexReSyncClusterMoIds.ClassIdEnum.HyperflexReSyncClusterMoIds;
            ObjectType = HyperflexReSyncClusterMoIds.ObjectTypeEnum.HyperflexReSyncClusterMoIds;

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

        public HyperflexReSyncClusterMoIds.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexReSyncClusterMoIds.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexReSyncClusterMoIds initObject = new Intersight.Model.HyperflexReSyncClusterMoIds();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexReduceReSync.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexReduceReSync")]
    public class InitializeIntersightHyperflexReduceReSync : PSCmdlet
    {
        public InitializeIntersightHyperflexReduceReSync()
        {
            ClassId = HyperflexReduceReSync.ClassIdEnum.HyperflexReduceReSync;
            ObjectType = HyperflexReduceReSync.ObjectTypeEnum.HyperflexReduceReSync;

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

        public HyperflexReduceReSync.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The HyperFlex reduce re-sync script execution completion status."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool CompletionStatus
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

        public HyperflexReduceReSync.ObjectTypeEnum ObjectType
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
            Intersight.Model.HyperflexReduceReSync initObject = new Intersight.Model.HyperflexReduceReSync();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("CompletionStatus"))
            {
                initObject.CompletionStatus = this.CompletionStatus;
            }
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexReplicationClusterReferenceToSchedule.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexReplicationClusterReferenceToSchedule")]
    public class InitializeIntersightHyperflexReplicationClusterReferenceToSchedule : PSCmdlet
    {
        public InitializeIntersightHyperflexReplicationClusterReferenceToSchedule()
        {
            ClassId = HyperflexReplicationClusterReferenceToSchedule.ClassIdEnum.HyperflexReplicationClusterReferenceToSchedule;
            ObjectType = HyperflexReplicationClusterReferenceToSchedule.ObjectTypeEnum.HyperflexReplicationClusterReferenceToSchedule;

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

        public HyperflexReplicationClusterReferenceToSchedule.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexReplicationClusterReferenceToSchedule.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexReplicationClusterReferenceToSchedule initObject = new Intersight.Model.HyperflexReplicationClusterReferenceToSchedule();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexReplicationPeerInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexReplicationPeerInfo")]
    public class InitializeIntersightHyperflexReplicationPeerInfo : PSCmdlet
    {
        public InitializeIntersightHyperflexReplicationPeerInfo()
        {
            ClassId = HyperflexReplicationPeerInfo.ClassIdEnum.HyperflexReplicationPeerInfo;
            ObjectType = HyperflexReplicationPeerInfo.ObjectTypeEnum.HyperflexReplicationPeerInfo;

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

        public HyperflexReplicationPeerInfo.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexReplicationPeerInfo.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexReplicationPeerInfo initObject = new Intersight.Model.HyperflexReplicationPeerInfo();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexReplicationPlatDatastore.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexReplicationPlatDatastore")]
    public class InitializeIntersightHyperflexReplicationPlatDatastore : PSCmdlet
    {
        public InitializeIntersightHyperflexReplicationPlatDatastore()
        {
            ClassId = HyperflexReplicationPlatDatastore.ClassIdEnum.HyperflexReplicationPlatDatastore;
            ObjectType = HyperflexReplicationPlatDatastore.ObjectTypeEnum.HyperflexReplicationPlatDatastore;

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

        public HyperflexReplicationPlatDatastore.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexReplicationPlatDatastore.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexReplicationPlatDatastore initObject = new Intersight.Model.HyperflexReplicationPlatDatastore();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexReplicationPlatDatastorePair.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexReplicationPlatDatastorePair")]
    public class InitializeIntersightHyperflexReplicationPlatDatastorePair : PSCmdlet
    {
        public InitializeIntersightHyperflexReplicationPlatDatastorePair()
        {
            ClassId = HyperflexReplicationPlatDatastorePair.ClassIdEnum.HyperflexReplicationPlatDatastorePair;
            ObjectType = HyperflexReplicationPlatDatastorePair.ObjectTypeEnum.HyperflexReplicationPlatDatastorePair;

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

        public HyperflexReplicationPlatDatastorePair.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexReplicationPlatDatastorePair.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexReplicationPlatDatastorePair initObject = new Intersight.Model.HyperflexReplicationPlatDatastorePair();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexReplicationSchedule.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexReplicationSchedule")]
    public class InitializeIntersightHyperflexReplicationSchedule : PSCmdlet
    {
        public InitializeIntersightHyperflexReplicationSchedule()
        {
            ClassId = HyperflexReplicationSchedule.ClassIdEnum.HyperflexReplicationSchedule;
            ObjectType = HyperflexReplicationSchedule.ObjectTypeEnum.HyperflexReplicationSchedule;

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
        /// <para type="description">"Time interval between two copies in minutes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(5, 10080)]
        public long BackupInterval
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexReplicationSchedule.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexReplicationSchedule.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexReplicationSchedule initObject = new Intersight.Model.HyperflexReplicationSchedule();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BackupInterval"))
            {
                initObject.BackupInterval = this.BackupInterval;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexReplicationStatus.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexReplicationStatus")]
    public class InitializeIntersightHyperflexReplicationStatus : PSCmdlet
    {
        public InitializeIntersightHyperflexReplicationStatus()
        {
            ClassId = HyperflexReplicationStatus.ClassIdEnum.HyperflexReplicationStatus;
            ObjectType = HyperflexReplicationStatus.ObjectTypeEnum.HyperflexReplicationStatus;

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

        public HyperflexReplicationStatus.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexReplicationStatus.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexReplicationStatus initObject = new Intersight.Model.HyperflexReplicationStatus();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexRpoStatus.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexRpoStatus")]
    public class InitializeIntersightHyperflexRpoStatus : PSCmdlet
    {
        public InitializeIntersightHyperflexRpoStatus()
        {
            ClassId = HyperflexRpoStatus.ClassIdEnum.HyperflexRpoStatus;
            ObjectType = HyperflexRpoStatus.ObjectTypeEnum.HyperflexRpoStatus;

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

        public HyperflexRpoStatus.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexRpoStatus.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexRpoStatus initObject = new Intersight.Model.HyperflexRpoStatus();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexServerFirmwareVersion.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexServerFirmwareVersion")]
    public class InitializeIntersightHyperflexServerFirmwareVersion : PSCmdlet
    {
        public InitializeIntersightHyperflexServerFirmwareVersion()
        {
            ClassId = HyperflexServerFirmwareVersion.ClassIdEnum.HyperflexServerFirmwareVersion;
            ObjectType = HyperflexServerFirmwareVersion.ObjectTypeEnum.HyperflexServerFirmwareVersion;

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
        /// <para type="description">"A reference to a hyperflexAppCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.HyperflexAppCatalogRelationship AppCatalog
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexServerFirmwareVersion.ClassIdEnum ClassId
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

        public HyperflexServerFirmwareVersion.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to hyperflexServerFirmwareVersionEntry resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.HyperflexServerFirmwareVersionEntryRelationship> ServerFirmwareVersionEntries
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
            Intersight.Model.HyperflexServerFirmwareVersion initObject = new Intersight.Model.HyperflexServerFirmwareVersion();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AppCatalog"))
            {
                initObject.AppCatalog = this.AppCatalog;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("ServerFirmwareVersionEntries"))
            {
                initObject.ServerFirmwareVersionEntries = this.ServerFirmwareVersionEntries;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexServerFirmwareVersionEntry.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexServerFirmwareVersionEntry")]
    public class InitializeIntersightHyperflexServerFirmwareVersionEntry : PSCmdlet
    {
        public InitializeIntersightHyperflexServerFirmwareVersionEntry()
        {
            ClassId = HyperflexServerFirmwareVersionEntry.ClassIdEnum.HyperflexServerFirmwareVersionEntry;
            ObjectType = HyperflexServerFirmwareVersionEntry.ObjectTypeEnum.HyperflexServerFirmwareVersionEntry;
            ServerPlatform = HyperflexServerFirmwareVersionEntry.ServerPlatformEnum.M5;

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

        public HyperflexServerFirmwareVersionEntry.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The conditions that must be satisfied before applying the AppSetting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.HyperflexAppSettingConstraint Constraint
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

        public HyperflexServerFirmwareVersionEntry.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a hyperflexServerFirmwareVersion resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.HyperflexServerFirmwareVersionRelationship ServerFirmwareVersion
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The server platform type that is applicable for the server firmware bundle version.\n* `M5` - M5 generation of UCS server.\n* `M3` - M3 generation of UCS server.\n* `M4` - M4 generation of UCS server.\n* `M6` - M6 generation of UCS server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexServerFirmwareVersionEntry.ServerPlatformEnum ServerPlatform
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
        /// <para type="description">"The server firmware bundle version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("(^3\\.[1-9]\\([1-9][a-z]\\)$|^[4-9]\\.[0-9]\\([1-9][a-z]\\)$)")]
        public string Version
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexServerFirmwareVersionEntry initObject = new Intersight.Model.HyperflexServerFirmwareVersionEntry();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Constraint"))
            {
                initObject.Constraint = this.Constraint;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("ServerFirmwareVersion"))
            {
                initObject.ServerFirmwareVersion = this.ServerFirmwareVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ServerPlatform"))
            {
                initObject.ServerPlatform = this.ServerPlatform;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Version"))
            {
                initObject.VarVersion = this.Version;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexServerFirmwareVersionInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexServerFirmwareVersionInfo")]
    public class InitializeIntersightHyperflexServerFirmwareVersionInfo : PSCmdlet
    {
        public InitializeIntersightHyperflexServerFirmwareVersionInfo()
        {
            ClassId = HyperflexServerFirmwareVersionInfo.ClassIdEnum.HyperflexServerFirmwareVersionInfo;
            ObjectType = HyperflexServerFirmwareVersionInfo.ObjectTypeEnum.HyperflexServerFirmwareVersionInfo;
            ServerPlatform = HyperflexServerFirmwareVersionInfo.ServerPlatformEnum.M5;

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

        public HyperflexServerFirmwareVersionInfo.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexServerFirmwareVersionInfo.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The platform type for UCS server.\n* `M5` - M5 generation of UCS server.\n* `M3` - M3 generation of UCS server.\n* `M4` - M4 generation of UCS server.\n* `M6` - M6 generation of UCS server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexServerFirmwareVersionInfo.ServerPlatformEnum ServerPlatform
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The server firmware bundle version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("(^3\\.[1-9]\\([1-9][a-z]\\)$|^[4-9]\\.[0-9]\\([1-9][a-z]\\)$|^[4-9]\\.[0-9]\\([0-9](\\.[0-9]+|[a-z]).*\\)$)")]
        public string Version
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexServerFirmwareVersionInfo initObject = new Intersight.Model.HyperflexServerFirmwareVersionInfo();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("ServerPlatform"))
            {
                initObject.ServerPlatform = this.ServerPlatform;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Version"))
            {
                initObject.VarVersion = this.Version;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexServerModel.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexServerModel")]
    public class InitializeIntersightHyperflexServerModel : PSCmdlet
    {
        public InitializeIntersightHyperflexServerModel()
        {
            ClassId = HyperflexServerModel.ClassIdEnum.HyperflexServerModel;
            ObjectType = HyperflexServerModel.ObjectTypeEnum.HyperflexServerModel;

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
        /// <para type="description">"A reference to a hyperflexAppCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.HyperflexAppCatalogRelationship AppCatalog
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexServerModel.ClassIdEnum ClassId
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

        public HyperflexServerModel.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.HyperflexServerModelEntry> ServerModelEntries
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
            Intersight.Model.HyperflexServerModel initObject = new Intersight.Model.HyperflexServerModel();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AppCatalog"))
            {
                initObject.AppCatalog = this.AppCatalog;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("ServerModelEntries"))
            {
                initObject.ServerModelEntries = this.ServerModelEntries;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexServerModelEntry.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexServerModelEntry")]
    public class InitializeIntersightHyperflexServerModelEntry : PSCmdlet
    {
        public InitializeIntersightHyperflexServerModelEntry()
        {
            ClassId = HyperflexServerModelEntry.ClassIdEnum.HyperflexServerModelEntry;
            ObjectType = HyperflexServerModelEntry.ObjectTypeEnum.HyperflexServerModelEntry;

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

        public HyperflexServerModelEntry.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The conditions that must be satisfied before applying the AppSetting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.HyperflexAppSettingConstraint Constraint
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The application setting identifier."</para>
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

        public HyperflexServerModelEntry.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The application setting value."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Value
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexServerModelEntry initObject = new Intersight.Model.HyperflexServerModelEntry();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Constraint"))
            {
                initObject.Constraint = this.Constraint;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexServiceAuthToken.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexServiceAuthToken")]
    public class InitializeIntersightHyperflexServiceAuthToken : PSCmdlet
    {
        public InitializeIntersightHyperflexServiceAuthToken()
        {
            ClassId = HyperflexServiceAuthToken.ClassIdEnum.HyperflexServiceAuthToken;
            ObjectType = HyperflexServiceAuthToken.ObjectTypeEnum.HyperflexServiceAuthToken;

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

        public HyperflexServiceAuthToken.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Client Id or tenant Id of the entity that uses the service auth token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ClientId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a hyperflexCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.HyperflexClusterRelationship Cluster
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version of Container Storage Interface (CSI) that the tokenOwner is associated with."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string CsiVersion
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

        public HyperflexServiceAuthToken.ObjectTypeEnum ObjectType
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
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.MoBaseMoRelationship TokenOwner
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexServiceAuthToken initObject = new Intersight.Model.HyperflexServiceAuthToken();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ClientId"))
            {
                initObject.ClientId = this.ClientId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Cluster"))
            {
                initObject.Cluster = this.Cluster;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CsiVersion"))
            {
                initObject.CsiVersion = this.CsiVersion;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TokenOwner"))
            {
                initObject.TokenOwner = this.TokenOwner;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexSiteDetails.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexSiteDetails")]
    public class InitializeIntersightHyperflexSiteDetails : PSCmdlet
    {
        public InitializeIntersightHyperflexSiteDetails()
        {
            ClassId = HyperflexSiteDetails.ClassIdEnum.HyperflexSiteDetails;
            ObjectType = HyperflexSiteDetails.ObjectTypeEnum.HyperflexSiteDetails;

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

        public HyperflexSiteDetails.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexSiteDetails.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexSiteDetails initObject = new Intersight.Model.HyperflexSiteDetails();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexSnapshotFiles.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexSnapshotFiles")]
    public class InitializeIntersightHyperflexSnapshotFiles : PSCmdlet
    {
        public InitializeIntersightHyperflexSnapshotFiles()
        {
            ClassId = HyperflexSnapshotFiles.ClassIdEnum.HyperflexSnapshotFiles;
            ObjectType = HyperflexSnapshotFiles.ObjectTypeEnum.HyperflexSnapshotFiles;

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

        public HyperflexSnapshotFiles.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexSnapshotFiles.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexSnapshotFiles initObject = new Intersight.Model.HyperflexSnapshotFiles();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexSnapshotInfoBrief.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexSnapshotInfoBrief")]
    public class InitializeIntersightHyperflexSnapshotInfoBrief : PSCmdlet
    {
        public InitializeIntersightHyperflexSnapshotInfoBrief()
        {
            ClassId = HyperflexSnapshotInfoBrief.ClassIdEnum.HyperflexSnapshotInfoBrief;
            ObjectType = HyperflexSnapshotInfoBrief.ObjectTypeEnum.HyperflexSnapshotInfoBrief;

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

        public HyperflexSnapshotInfoBrief.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexSnapshotInfoBrief.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexSnapshotInfoBrief initObject = new Intersight.Model.HyperflexSnapshotInfoBrief();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexSnapshotPoint.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexSnapshotPoint")]
    public class InitializeIntersightHyperflexSnapshotPoint : PSCmdlet
    {
        public InitializeIntersightHyperflexSnapshotPoint()
        {
            ClassId = HyperflexSnapshotPoint.ClassIdEnum.HyperflexSnapshotPoint;
            ObjectType = HyperflexSnapshotPoint.ObjectTypeEnum.HyperflexSnapshotPoint;

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

        public HyperflexSnapshotPoint.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexSnapshotPoint.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexSnapshotPoint initObject = new Intersight.Model.HyperflexSnapshotPoint();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexSnapshotStatus.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexSnapshotStatus")]
    public class InitializeIntersightHyperflexSnapshotStatus : PSCmdlet
    {
        public InitializeIntersightHyperflexSnapshotStatus()
        {
            ClassId = HyperflexSnapshotStatus.ClassIdEnum.HyperflexSnapshotStatus;
            ObjectType = HyperflexSnapshotStatus.ObjectTypeEnum.HyperflexSnapshotStatus;

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

        public HyperflexSnapshotStatus.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexSnapshotStatus.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexSnapshotStatus initObject = new Intersight.Model.HyperflexSnapshotStatus();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexSoftwareDistributionComponent.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexSoftwareDistributionComponent")]
    public class InitializeIntersightHyperflexSoftwareDistributionComponent : PSCmdlet
    {
        public InitializeIntersightHyperflexSoftwareDistributionComponent()
        {
            ClassId = HyperflexSoftwareDistributionComponent.ClassIdEnum.HyperflexSoftwareDistributionComponent;
            ObjectType = HyperflexSoftwareDistributionComponent.ObjectTypeEnum.HyperflexSoftwareDistributionComponent;

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
        /// <para type="description">"The bucket name where the files are present, if source is external cloud store."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string BucketName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexSoftwareDistributionComponent.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The HyperFlex Software Distribution Component Identifier."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ComponentId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The HyperFlex Software Distribution Component Name."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ComponentName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"File location on the cloud storage."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string FilePath
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> FilesToDownload
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

        public HyperflexSoftwareDistributionComponent.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a hyperflexSoftwareDistributionVersion resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.HyperflexSoftwareDistributionVersionRelationship SoftwareDistributionVersion
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
        /// <para type="description">"The HyperFlex Software Distribution Component Version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Version
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexSoftwareDistributionComponent initObject = new Intersight.Model.HyperflexSoftwareDistributionComponent();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BucketName"))
            {
                initObject.BucketName = this.BucketName;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ComponentId"))
            {
                initObject.ComponentId = this.ComponentId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ComponentName"))
            {
                initObject.ComponentName = this.ComponentName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FilePath"))
            {
                initObject.FilePath = this.FilePath;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FilesToDownload"))
            {
                initObject.FilesToDownload = this.FilesToDownload;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("SoftwareDistributionVersion"))
            {
                initObject.SoftwareDistributionVersion = this.SoftwareDistributionVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Version"))
            {
                initObject.VarVersion = this.Version;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexSoftwareDistributionEntry.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexSoftwareDistributionEntry")]
    public class InitializeIntersightHyperflexSoftwareDistributionEntry : PSCmdlet
    {
        public InitializeIntersightHyperflexSoftwareDistributionEntry()
        {
            ClassId = HyperflexSoftwareDistributionEntry.ClassIdEnum.HyperflexSoftwareDistributionEntry;
            ObjectType = HyperflexSoftwareDistributionEntry.ObjectTypeEnum.HyperflexSoftwareDistributionEntry;

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
        /// <para type="description">"A reference to a hyperflexAppCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.HyperflexAppCatalogRelationship AppCatalog
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexSoftwareDistributionEntry.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The HyperFlex Software Distribution type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string DistributionType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to hyperflexSoftwareDistributionVersion resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.HyperflexSoftwareDistributionVersionRelationship> DistributionVersions
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

        public HyperflexSoftwareDistributionEntry.ObjectTypeEnum ObjectType
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
            Intersight.Model.HyperflexSoftwareDistributionEntry initObject = new Intersight.Model.HyperflexSoftwareDistributionEntry();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AppCatalog"))
            {
                initObject.AppCatalog = this.AppCatalog;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("DistributionType"))
            {
                initObject.DistributionType = this.DistributionType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DistributionVersions"))
            {
                initObject.DistributionVersions = this.DistributionVersions;
            }
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexSoftwareDistributionVersion.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexSoftwareDistributionVersion")]
    public class InitializeIntersightHyperflexSoftwareDistributionVersion : PSCmdlet
    {
        public InitializeIntersightHyperflexSoftwareDistributionVersion()
        {
            ClassId = HyperflexSoftwareDistributionVersion.ClassIdEnum.HyperflexSoftwareDistributionVersion;
            ObjectType = HyperflexSoftwareDistributionVersion.ObjectTypeEnum.HyperflexSoftwareDistributionVersion;

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

        public HyperflexSoftwareDistributionVersion.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to hyperflexSoftwareDistributionComponent resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.HyperflexSoftwareDistributionComponentRelationship> DistributionComponents
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

        public HyperflexSoftwareDistributionVersion.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a hyperflexSoftwareDistributionEntry resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.HyperflexSoftwareDistributionEntryRelationship SoftwareDistributionEntry
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
        /// <para type="description">"The HyperFlex Software Distribution version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Version
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexSoftwareDistributionVersion initObject = new Intersight.Model.HyperflexSoftwareDistributionVersion();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("DistributionComponents"))
            {
                initObject.DistributionComponents = this.DistributionComponents;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("SoftwareDistributionEntry"))
            {
                initObject.SoftwareDistributionEntry = this.SoftwareDistributionEntry;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Version"))
            {
                initObject.VarVersion = this.Version;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexSoftwareVersionPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexSoftwareVersionPolicy")]
    public class InitializeIntersightHyperflexSoftwareVersionPolicy : PSCmdlet
    {
        public InitializeIntersightHyperflexSoftwareVersionPolicy()
        {
            ClassId = HyperflexSoftwareVersionPolicy.ClassIdEnum.HyperflexSoftwareVersionPolicy;
            ObjectType = HyperflexSoftwareVersionPolicy.ObjectTypeEnum.HyperflexSoftwareVersionPolicy;

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

        public HyperflexSoftwareVersionPolicy.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to hyperflexClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.HyperflexClusterProfileRelationship> ClusterProfiles
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
        /// <para type="description">"Desired HyperFlex Data Platform software version to apply on the HyperFlex cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string HxdpVersion
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Desired  hypervisor version to apply for all the nodes on the HyperFlex cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string HypervisorVersion
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

        public HyperflexSoftwareVersionPolicy.ObjectTypeEnum ObjectType
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
        /// <para type="description">"Desired server firmware version to apply on the HyperFlex Cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|(^3\\.[0-9]\\([1-9][a-z]\\)$|^[4-9]\\.[1-9]\\([1-9][a-z]\\)$|^4\\.0\\([1-3][a-z]\\)$|^4\\.0\\(4[d-z]\\)$|4\\.0\\([5-9][a-z]\\)$|^[4-9]\\.[0-9]\\([0-9](\\.[0-9]+|[a-z]).*\\)$)")]
        public string ServerFirmwareVersion
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.HyperflexServerFirmwareVersionInfo> ServerFirmwareVersions
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

        public List<HyperflexSoftwareVersionPolicy.UpgradeTypesEnum> UpgradeTypes
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexSoftwareVersionPolicy initObject = new Intersight.Model.HyperflexSoftwareVersionPolicy();
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
            if (this.MyInvocation.BoundParameters.ContainsKey("HxdpVersion"))
            {
                initObject.HxdpVersion = this.HxdpVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HypervisorVersion"))
            {
                initObject.HypervisorVersion = this.HypervisorVersion;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("ServerFirmwareVersion"))
            {
                initObject.ServerFirmwareVersion = this.ServerFirmwareVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ServerFirmwareVersions"))
            {
                initObject.ServerFirmwareVersions = this.ServerFirmwareVersions;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UpgradeTypes"))
            {
                initObject.UpgradeTypes = this.UpgradeTypes;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexStPlatformClusterHealingInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexStPlatformClusterHealingInfo")]
    public class InitializeIntersightHyperflexStPlatformClusterHealingInfo : PSCmdlet
    {
        public InitializeIntersightHyperflexStPlatformClusterHealingInfo()
        {
            ClassId = HyperflexStPlatformClusterHealingInfo.ClassIdEnum.HyperflexStPlatformClusterHealingInfo;
            ObjectType = HyperflexStPlatformClusterHealingInfo.ObjectTypeEnum.HyperflexStPlatformClusterHealingInfo;

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

        public HyperflexStPlatformClusterHealingInfo.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexStPlatformClusterHealingInfo.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexStPlatformClusterHealingInfo initObject = new Intersight.Model.HyperflexStPlatformClusterHealingInfo();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexStPlatformClusterResiliencyInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexStPlatformClusterResiliencyInfo")]
    public class InitializeIntersightHyperflexStPlatformClusterResiliencyInfo : PSCmdlet
    {
        public InitializeIntersightHyperflexStPlatformClusterResiliencyInfo()
        {
            ClassId = HyperflexStPlatformClusterResiliencyInfo.ClassIdEnum.HyperflexStPlatformClusterResiliencyInfo;
            ObjectType = HyperflexStPlatformClusterResiliencyInfo.ObjectTypeEnum.HyperflexStPlatformClusterResiliencyInfo;

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

        public HyperflexStPlatformClusterResiliencyInfo.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexStPlatformClusterResiliencyInfo.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexStPlatformClusterResiliencyInfo initObject = new Intersight.Model.HyperflexStPlatformClusterResiliencyInfo();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexStartReduceReSync.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexStartReduceReSync")]
    public class InitializeIntersightHyperflexStartReduceReSync : PSCmdlet
    {
        public InitializeIntersightHyperflexStartReduceReSync()
        {
            ClassId = HyperflexStartReduceReSync.ClassIdEnum.HyperflexStartReduceReSync;
            ObjectType = HyperflexStartReduceReSync.ObjectTypeEnum.HyperflexStartReduceReSync;
            Operation = HyperflexStartReduceReSync.OperationEnum.NoOp;

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

        public HyperflexStartReduceReSync.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> ClusterMoIds
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

        public HyperflexStartReduceReSync.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The cleanup operation to perform.\n* `NoOp` - Does not perform any operation when the API is called.\n* `StartReduceResync` - Start the execution of reduce re-sync and stale mirror cleanup for the HyperFlex clusters associated with the account."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexStartReduceReSync.OperationEnum Operation
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

        public List<Model.HyperflexReSyncClusterMoIds> TargetDetails
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexStartReduceReSync initObject = new Intersight.Model.HyperflexStartReduceReSync();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ClusterMoIds"))
            {
                initObject.ClusterMoIds = this.ClusterMoIds;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Operation"))
            {
                initObject.Operation = this.Operation;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TargetDetails"))
            {
                initObject.TargetDetails = this.TargetDetails;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexStorageContainer.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexStorageContainer")]
    public class InitializeIntersightHyperflexStorageContainer : PSCmdlet
    {
        public InitializeIntersightHyperflexStorageContainer()
        {
            ClassId = HyperflexStorageContainer.ClassIdEnum.HyperflexStorageContainer;
            ObjectType = HyperflexStorageContainer.ObjectTypeEnum.HyperflexStorageContainer;

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

        public HyperflexStorageContainer.ClassIdEnum ClassId
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

        public HyperflexStorageContainer.ObjectTypeEnum ObjectType
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
            Intersight.Model.HyperflexStorageContainer initObject = new Intersight.Model.HyperflexStorageContainer();
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexSummary.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexSummary")]
    public class InitializeIntersightHyperflexSummary : PSCmdlet
    {
        public InitializeIntersightHyperflexSummary()
        {
            ClassId = HyperflexSummary.ClassIdEnum.HyperflexSummary;
            ObjectType = HyperflexSummary.ObjectTypeEnum.HyperflexSummary;

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

        public HyperflexSummary.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexSummary.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexSummary initObject = new Intersight.Model.HyperflexSummary();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexSysConfigPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexSysConfigPolicy")]
    public class InitializeIntersightHyperflexSysConfigPolicy : PSCmdlet
    {
        public InitializeIntersightHyperflexSysConfigPolicy()
        {
            ClassId = HyperflexSysConfigPolicy.ClassIdEnum.HyperflexSysConfigPolicy;
            ObjectType = HyperflexSysConfigPolicy.ObjectTypeEnum.HyperflexSysConfigPolicy;
            Timezone = HyperflexSysConfigPolicy.TimezoneEnum.PacificNiue;

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

        public HyperflexSysConfigPolicy.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to hyperflexClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.HyperflexClusterProfileRelationship> ClusterProfiles
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
        /// <para type="description">"The DNS Search Domain Name. This setting applies to HyperFlex Data Platform 3.0 or later only."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^([a-zA-Z0-9]([a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?\\.)*[a-zA-Z]{2,63}$")]
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

        public HyperflexSysConfigPolicy.ObjectTypeEnum ObjectType
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
        /// <para type="description">"The timezone of the HyperFlex cluster's system clock.\n* `Pacific/Niue` - \n* `Pacific/Pago_Pago` - \n* `Pacific/Honolulu` - \n* `Pacific/Rarotonga` - \n* `Pacific/Tahiti` - \n* `Pacific/Marquesas` - \n* `America/Anchorage` - \n* `Pacific/Gambier` - \n* `America/Los_Angeles` - \n* `America/Tijuana` - \n* `America/Vancouver` - \n* `America/Whitehorse` - \n* `Pacific/Pitcairn` - \n* `America/Dawson_Creek` - \n* `America/Denver` - \n* `America/Edmonton` - \n* `America/Hermosillo` - \n* `America/Mazatlan` - \n* `America/Phoenix` - \n* `America/Yellowknife` - \n* `America/Belize` - \n* `America/Chicago` - \n* `America/Costa_Rica` - \n* `America/El_Salvador` - \n* `America/Guatemala` - \n* `America/Managua` - \n* `America/Mexico_City` - \n* `America/Regina` - \n* `America/Tegucigalpa` - \n* `America/Winnipeg` - \n* `Pacific/Galapagos` - \n* `America/Bogota` - \n* `America/Cancun` - \n* `America/Cayman` - \n* `America/Guayaquil` - \n* `America/Havana` - \n* `America/Iqaluit` - \n* `America/Jamaica` - \n* `America/Lima` - \n* `America/Nassau` - \n* `America/New_York` - \n* `America/Nuuk` - \n* `America/Panama` - \n* `America/Port-au-Prince` - \n* `America/Rio_Branco` - \n* `America/Toronto` - \n* `Pacific/Easter` - \n* `America/Caracas` - \n* `America/Asuncion` - \n* `America/Barbados` - \n* `America/Boa_Vista` - \n* `America/Campo_Grande` - \n* `America/Cuiaba` - \n* `America/Curacao` - \n* `America/Grand_Turk` - \n* `America/Guyana` - \n* `America/Halifax` - \n* `America/La_Paz` - \n* `America/Manaus` - \n* `America/Martinique` - \n* `America/Port_of_Spain` - \n* `America/Porto_Velho` - \n* `America/Puerto_Rico` - \n* `America/Santo_Domingo` - \n* `America/Thule` - \n* `Atlantic/Bermuda` - \n* `America/St_Johns` - \n* `America/Araguaina` - \n* `America/Argentina/Buenos_Aires` - \n* `America/Bahia` - \n* `America/Belem` - \n* `America/Cayenne` - \n* `America/Fortaleza` - \n* `America/Godthab` - \n* `America/Maceio` - \n* `America/Miquelon` - \n* `America/Montevideo` - \n* `America/Paramaribo` - \n* `America/Recife` - \n* `America/Santiago` - \n* `America/Sao_Paulo` - \n* `Antarctica/Palmer` - \n* `Antarctica/Rothera` - \n* `Atlantic/Stanley` - \n* `America/Noronha` - \n* `Atlantic/South_Georgia` - \n* `America/Scoresbysund` - \n* `Atlantic/Azores` - \n* `Atlantic/Cape_Verde` - \n* `Africa/Abidjan` - \n* `Africa/Accra` - \n* `Africa/Bissau` - \n* `Africa/Casablanca` - \n* `Africa/El_Aaiun` - \n* `Africa/Monrovia` - \n* `America/Danmarkshavn` - \n* `Atlantic/Canary` - \n* `Atlantic/Faroe` - \n* `Atlantic/Reykjavik` - \n* `Etc/GMT` - \n* `Europe/Dublin` - \n* `Europe/Lisbon` - \n* `Europe/London` - \n* `Africa/Algiers` - \n* `Africa/Ceuta` - \n* `Africa/Lagos` - \n* `Africa/Ndjamena` - \n* `Africa/Tunis` - \n* `Africa/Windhoek` - \n* `Europe/Amsterdam` - \n* `Europe/Andorra` - \n* `Europe/Belgrade` - \n* `Europe/Berlin` - \n* `Europe/Brussels` - \n* `Europe/Budapest` - \n* `Europe/Copenhagen` - \n* `Europe/Gibraltar` - \n* `Europe/Luxembourg` - \n* `Europe/Madrid` - \n* `Europe/Malta` - \n* `Europe/Monaco` - \n* `Europe/Oslo` - \n* `Europe/Paris` - \n* `Europe/Prague` - \n* `Europe/Rome` - \n* `Europe/Stockholm` - \n* `Europe/Tirane` - \n* `Europe/Vienna` - \n* `Europe/Warsaw` - \n* `Europe/Zurich` - \n* `Africa/Cairo` - \n* `Africa/Johannesburg` - \n* `Africa/Maputo` - \n* `Africa/Tripoli` - \n* `Asia/Amman` - \n* `Asia/Beirut` - \n* `Asia/Damascus` - \n* `Asia/Gaza` - \n* `Asia/Jerusalem` - \n* `Asia/Nicosia` - \n* `Europe/Athens` - \n* `Europe/Bucharest` - \n* `Europe/Chisinau` - \n* `Europe/Helsinki` - \n* `Europe/Istanbul` - \n* `Europe/Kaliningrad` - \n* `Europe/Kiev` - \n* `Europe/Riga` - \n* `Europe/Sofia` - \n* `Europe/Tallinn` - \n* `Europe/Vilnius` - \n* `Africa/Khartoum` - \n* `Africa/Nairobi` - \n* `Antarctica/Syowa` - \n* `Asia/Baghdad` - \n* `Asia/Qatar` - \n* `Asia/Riyadh` - \n* `Europe/Minsk` - \n* `Europe/Moscow` - \n* `Asia/Tehran` - \n* `Asia/Baku` - \n* `Asia/Dubai` - \n* `Asia/Tbilisi` - \n* `Asia/Yerevan` - \n* `Europe/Samara` - \n* `Indian/Mahe` - \n* `Indian/Mauritius` - \n* `Indian/Reunion` - \n* `Asia/Kabul` - \n* `Antarctica/Mawson` - \n* `Asia/Aqtau` - \n* `Asia/Aqtobe` - \n* `Asia/Ashgabat` - \n* `Asia/Dushanbe` - \n* `Asia/Karachi` - \n* `Asia/Tashkent` - \n* `Asia/Yekaterinburg` - \n* `Indian/Kerguelen` - \n* `Indian/Maldives` - \n* `Asia/Calcutta` - \n* `Asia/Kolkata` - \n* `Asia/Colombo` - \n* `Asia/Kathmandu` - \n* `Asia/Katmandu` - \n* `Antarctica/Vostok` - \n* `Asia/Almaty` - \n* `Asia/Bishkek` - \n* `Asia/Dhaka` - \n* `Asia/Omsk` - \n* `Asia/Thimphu` - \n* `Indian/Chagos` - \n* `Asia/Rangoon` - \n* `Indian/Cocos` - \n* `Antarctica/Davis` - \n* `Asia/Bangkok` - \n* `Asia/Ho_Chi_Minh` - \n* `Asia/Hovd` - \n* `Asia/Jakarta` - \n* `Asia/Krasnoyarsk` - \n* `Asia/Saigon` - \n* `Indian/Christmas` - \n* `Antarctica/Casey` - \n* `Asia/Brunei` - \n* `Asia/Choibalsan` - \n* `Asia/Hong_Kong` - \n* `Asia/Irkutsk` - \n* `Asia/Kuala_Lumpur` - \n* `Asia/Macau` - \n* `Asia/Makassar` - \n* `Asia/Manila` - \n* `Asia/Shanghai` - \n* `Asia/Singapore` - \n* `Asia/Taipei` - \n* `Asia/Ulaanbaatar` - \n* `Australia/Perth` - \n* `Asia/Pyongyang` - \n* `Asia/Dili` - \n* `Asia/Jayapura` - \n* `Asia/Seoul` - \n* `Asia/Tokyo` - \n* `Asia/Yakutsk` - \n* `Asia/Yangon` - \n* `Pacific/Palau` - \n* `Australia/Adelaide` - \n* `Australia/Darwin` - \n* `Antarctica/DumontDUrville` - \n* `Asia/Magadan` - \n* `Asia/Vladivostok` - \n* `Australia/Brisbane` - \n* `Australia/Hobart` - \n* `Australia/Sydney` - \n* `Pacific/Chuuk` - \n* `Pacific/Guam` - \n* `Pacific/Port_Moresby` - \n* `Pacific/Efate` - \n* `Pacific/Guadalcanal` - \n* `Pacific/Kosrae` - \n* `Pacific/Norfolk` - \n* `Pacific/Noumea` - \n* `Pacific/Pohnpei` - \n* `Asia/Kamchatka` - \n* `Pacific/Auckland` - \n* `Pacific/Fiji` - \n* `Pacific/Funafuti` - \n* `Pacific/Kwajalein` - \n* `Pacific/Majuro` - \n* `Pacific/Nauru` - \n* `Pacific/Tarawa` - \n* `Pacific/Wake` - \n* `Pacific/Wallis` - \n* `Pacific/Apia` - \n* `Pacific/Enderbury` - \n* `Pacific/Fakaofo` - \n* `Pacific/Tongatapu` - \n* `Pacific/Kiritimati` - \n* `UTC` -"</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexSysConfigPolicy.TimezoneEnum Timezone
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexSysConfigPolicy initObject = new Intersight.Model.HyperflexSysConfigPolicy();
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexTarget.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexTarget")]
    public class InitializeIntersightHyperflexTarget : PSCmdlet
    {
        public InitializeIntersightHyperflexTarget()
        {
            ClassId = HyperflexTarget.ClassIdEnum.HyperflexTarget;
            ObjectType = HyperflexTarget.ObjectTypeEnum.HyperflexTarget;

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

        public HyperflexTarget.ClassIdEnum ClassId
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

        public HyperflexTarget.ObjectTypeEnum ObjectType
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
            Intersight.Model.HyperflexTarget initObject = new Intersight.Model.HyperflexTarget();
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexTrackedDisk.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexTrackedDisk")]
    public class InitializeIntersightHyperflexTrackedDisk : PSCmdlet
    {
        public InitializeIntersightHyperflexTrackedDisk()
        {
            ClassId = HyperflexTrackedDisk.ClassIdEnum.HyperflexTrackedDisk;
            ObjectType = HyperflexTrackedDisk.ObjectTypeEnum.HyperflexTrackedDisk;

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

        public HyperflexTrackedDisk.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexTrackedDisk.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexTrackedDisk initObject = new Intersight.Model.HyperflexTrackedDisk();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexTrackedFile.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexTrackedFile")]
    public class InitializeIntersightHyperflexTrackedFile : PSCmdlet
    {
        public InitializeIntersightHyperflexTrackedFile()
        {
            ClassId = HyperflexTrackedFile.ClassIdEnum.HyperflexTrackedFile;
            ObjectType = HyperflexTrackedFile.ObjectTypeEnum.HyperflexTrackedFile;

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

        public HyperflexTrackedFile.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexTrackedFile.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexTrackedFile initObject = new Intersight.Model.HyperflexTrackedFile();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexUcsmConfigPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexUcsmConfigPolicy")]
    public class InitializeIntersightHyperflexUcsmConfigPolicy : PSCmdlet
    {
        public InitializeIntersightHyperflexUcsmConfigPolicy()
        {
            ClassId = HyperflexUcsmConfigPolicy.ClassIdEnum.HyperflexUcsmConfigPolicy;
            ObjectType = HyperflexUcsmConfigPolicy.ObjectTypeEnum.HyperflexUcsmConfigPolicy;

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

        public HyperflexUcsmConfigPolicy.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to hyperflexClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.HyperflexClusterProfileRelationship> ClusterProfiles
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
        /// <para type="description">"The Out-of-band KVM IP range.\nConfigures the service profiles to use IP addresses within this range for setting the KVM IP of a server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.HyperflexIpAddrRange KvmIpRange
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The MAC address prefix range for configuring vNICs.\nConfigures the service profiles to use MAC address prefixes within this range for setting the MAC address of server vNICs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.HyperflexMacAddrPrefixRange MacPrefixRange
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

        public HyperflexUcsmConfigPolicy.ObjectTypeEnum ObjectType
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
        /// <para type="description">"The server firmware bundle version used for server components such as CIMC, adapters, BIOS, etc."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("(^3\\.[1-9]\\([1-9][a-z]\\)$|^[4-9]\\.[0-9]\\([1-9][a-z]\\)$)")]
        public string ServerFirmwareVersion
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
            Intersight.Model.HyperflexUcsmConfigPolicy initObject = new Intersight.Model.HyperflexUcsmConfigPolicy();
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
            if (this.MyInvocation.BoundParameters.ContainsKey("KvmIpRange"))
            {
                initObject.KvmIpRange = this.KvmIpRange;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MacPrefixRange"))
            {
                initObject.MacPrefixRange = this.MacPrefixRange;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("ServerFirmwareVersion"))
            {
                initObject.ServerFirmwareVersion = this.ServerFirmwareVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexVcenterConfigPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexVcenterConfigPolicy")]
    public class InitializeIntersightHyperflexVcenterConfigPolicy : PSCmdlet
    {
        public InitializeIntersightHyperflexVcenterConfigPolicy()
        {
            ClassId = HyperflexVcenterConfigPolicy.ClassIdEnum.HyperflexVcenterConfigPolicy;
            ObjectType = HyperflexVcenterConfigPolicy.ObjectTypeEnum.HyperflexVcenterConfigPolicy;

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

        public HyperflexVcenterConfigPolicy.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to hyperflexClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.HyperflexClusterProfileRelationship> ClusterProfiles
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The vCenter datacenter name."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9~!@#$%&*()-_][a-zA-Z0-9~!@#$%&* ()-_]{0,79}$")]
        public string DataCenter
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
        /// <para type="description">"The vCenter server FQDN or IP."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[A-Za-z]([A-Za-z0-9-]*[A-Za-z0-9])?$|^[A-Za-z0-9]([A-Za-z0-9-]*[A-Za-z0-9])?(\\.[A-Za-z0-9]([A-Za-z0-9-]*[A-Za-z0-9])?)*(\\.[A-Za-z]([A-Za-z0-9-]*[A-Za-z0-9])?)$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string Hostname
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

        public HyperflexVcenterConfigPolicy.ObjectTypeEnum ObjectType
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
        /// <para type="description">"The password for authenticating with vCenter. Follow the corresponding password policy governed by vCenter."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Password
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Overrides the default vCenter Single Sign-On URL. Do not specify unless instructed by Cisco TAC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SsoUrl
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
        /// <para type="description">"The vCenter username (e.g. administrator@vsphere.local)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^([a-zA-Z0-9._-]+)@([a-zA-Z0-9._-]+)$")]
        public string Username
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexVcenterConfigPolicy initObject = new Intersight.Model.HyperflexVcenterConfigPolicy();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ClusterProfiles"))
            {
                initObject.ClusterProfiles = this.ClusterProfiles;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DataCenter"))
            {
                initObject.DataCenter = this.DataCenter;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Hostname"))
            {
                initObject.Hostname = this.Hostname;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Password"))
            {
                initObject.Password = this.Password;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SsoUrl"))
            {
                initObject.SsoUrl = this.SsoUrl;
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexVcenterConfiguration.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexVcenterConfiguration")]
    public class InitializeIntersightHyperflexVcenterConfiguration : PSCmdlet
    {
        public InitializeIntersightHyperflexVcenterConfiguration()
        {
            ClassId = HyperflexVcenterConfiguration.ClassIdEnum.HyperflexVcenterConfiguration;
            ObjectType = HyperflexVcenterConfiguration.ObjectTypeEnum.HyperflexVcenterConfiguration;

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

        public HyperflexVcenterConfiguration.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexVcenterConfiguration.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexVcenterConfiguration initObject = new Intersight.Model.HyperflexVcenterConfiguration();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexVirtualMachine.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexVirtualMachine")]
    public class InitializeIntersightHyperflexVirtualMachine : PSCmdlet
    {
        public InitializeIntersightHyperflexVirtualMachine()
        {
            ClassId = HyperflexVirtualMachine.ClassIdEnum.HyperflexVirtualMachine;
            ObjectType = HyperflexVirtualMachine.ObjectTypeEnum.HyperflexVirtualMachine;

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

        public HyperflexVirtualMachine.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexVirtualMachine.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexVirtualMachine initObject = new Intersight.Model.HyperflexVirtualMachine();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexVirtualMachineRuntimeInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexVirtualMachineRuntimeInfo")]
    public class InitializeIntersightHyperflexVirtualMachineRuntimeInfo : PSCmdlet
    {
        public InitializeIntersightHyperflexVirtualMachineRuntimeInfo()
        {
            ClassId = HyperflexVirtualMachineRuntimeInfo.ClassIdEnum.HyperflexVirtualMachineRuntimeInfo;
            ObjectType = HyperflexVirtualMachineRuntimeInfo.ObjectTypeEnum.HyperflexVirtualMachineRuntimeInfo;

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

        public HyperflexVirtualMachineRuntimeInfo.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexVirtualMachineRuntimeInfo.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexVirtualMachineRuntimeInfo initObject = new Intersight.Model.HyperflexVirtualMachineRuntimeInfo();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexVmBackupInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexVmBackupInfo")]
    public class InitializeIntersightHyperflexVmBackupInfo : PSCmdlet
    {
        public InitializeIntersightHyperflexVmBackupInfo()
        {
            ClassId = HyperflexVmBackupInfo.ClassIdEnum.HyperflexVmBackupInfo;
            ObjectType = HyperflexVmBackupInfo.ObjectTypeEnum.HyperflexVmBackupInfo;

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

        public HyperflexVmBackupInfo.ClassIdEnum ClassId
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

        public HyperflexVmBackupInfo.ObjectTypeEnum ObjectType
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
            Intersight.Model.HyperflexVmBackupInfo initObject = new Intersight.Model.HyperflexVmBackupInfo();
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexVmImportOperation.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexVmImportOperation")]
    public class InitializeIntersightHyperflexVmImportOperation : PSCmdlet
    {
        public InitializeIntersightHyperflexVmImportOperation()
        {
            ClassId = HyperflexVmImportOperation.ClassIdEnum.HyperflexVmImportOperation;
            ObjectType = HyperflexVmImportOperation.ObjectTypeEnum.HyperflexVmImportOperation;

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

        public HyperflexVmImportOperation.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.AssetDeviceRegistrationRelationship DeviceMoid
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

        public HyperflexVmImportOperation.ObjectTypeEnum ObjectType
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
            Intersight.Model.HyperflexVmImportOperation initObject = new Intersight.Model.HyperflexVmImportOperation();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("DeviceMoid"))
            {
                initObject.DeviceMoid = this.DeviceMoid;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexVmProtectionSpaceUsage.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexVmProtectionSpaceUsage")]
    public class InitializeIntersightHyperflexVmProtectionSpaceUsage : PSCmdlet
    {
        public InitializeIntersightHyperflexVmProtectionSpaceUsage()
        {
            ClassId = HyperflexVmProtectionSpaceUsage.ClassIdEnum.HyperflexVmProtectionSpaceUsage;
            ObjectType = HyperflexVmProtectionSpaceUsage.ObjectTypeEnum.HyperflexVmProtectionSpaceUsage;

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

        public HyperflexVmProtectionSpaceUsage.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexVmProtectionSpaceUsage.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexVmProtectionSpaceUsage initObject = new Intersight.Model.HyperflexVmProtectionSpaceUsage();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexVmRestoreOperation.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexVmRestoreOperation")]
    public class InitializeIntersightHyperflexVmRestoreOperation : PSCmdlet
    {
        public InitializeIntersightHyperflexVmRestoreOperation()
        {
            ClassId = HyperflexVmRestoreOperation.ClassIdEnum.HyperflexVmRestoreOperation;
            ObjectType = HyperflexVmRestoreOperation.ObjectTypeEnum.HyperflexVmRestoreOperation;

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

        public HyperflexVmRestoreOperation.ClassIdEnum ClassId
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
        /// <para type="description">"New name for the Virtual Machine after recovery."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string NewName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexVmRestoreOperation.ObjectTypeEnum ObjectType
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
        /// <para type="description">"Power on the Virtual Machine after recovery."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool PowerOn
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a hyperflexCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.HyperflexClusterRelationship RestoreEdgeClusterMoid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Start time for the replication."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long StartTime
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
        /// <para type="description">"A reference to a hyperflexVmBackupInfo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.HyperflexVmBackupInfoRelationship VmBackupInfoMoid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a hyperflexVmSnapshotInfo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.HyperflexVmSnapshotInfoRelationship VmSnapshotInfoMoid
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexVmRestoreOperation initObject = new Intersight.Model.HyperflexVmRestoreOperation();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NewName"))
            {
                initObject.NewName = this.NewName;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Organization"))
            {
                initObject.Organization = this.Organization;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PowerOn"))
            {
                initObject.PowerOn = this.PowerOn;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RestoreEdgeClusterMoid"))
            {
                initObject.RestoreEdgeClusterMoid = this.RestoreEdgeClusterMoid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("StartTime"))
            {
                initObject.StartTime = this.StartTime;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VmBackupInfoMoid"))
            {
                initObject.VmBackupInfoMoid = this.VmBackupInfoMoid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VmSnapshotInfoMoid"))
            {
                initObject.VmSnapshotInfoMoid = this.VmSnapshotInfoMoid;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexVmSnapshotInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexVmSnapshotInfo")]
    public class InitializeIntersightHyperflexVmSnapshotInfo : PSCmdlet
    {
        public InitializeIntersightHyperflexVmSnapshotInfo()
        {
            ClassId = HyperflexVmSnapshotInfo.ClassIdEnum.HyperflexVmSnapshotInfo;
            ObjectType = HyperflexVmSnapshotInfo.ObjectTypeEnum.HyperflexVmSnapshotInfo;

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

        public HyperflexVmSnapshotInfo.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the Virtual Machine and the time stamp of the snapshot."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Label
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

        public HyperflexVmSnapshotInfo.ObjectTypeEnum ObjectType
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
            Intersight.Model.HyperflexVmSnapshotInfo initObject = new Intersight.Model.HyperflexVmSnapshotInfo();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Label"))
            {
                initObject.Label = this.Label;
            }
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexVolume.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexVolume")]
    public class InitializeIntersightHyperflexVolume : PSCmdlet
    {
        public InitializeIntersightHyperflexVolume()
        {
            ClassId = HyperflexVolume.ClassIdEnum.HyperflexVolume;
            ObjectType = HyperflexVolume.ObjectTypeEnum.HyperflexVolume;

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

        public HyperflexVolume.ClassIdEnum ClassId
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

        public HyperflexVolume.ObjectTypeEnum ObjectType
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
            Intersight.Model.HyperflexVolume initObject = new Intersight.Model.HyperflexVolume();
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexWitnessConfiguration.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexWitnessConfiguration")]
    public class InitializeIntersightHyperflexWitnessConfiguration : PSCmdlet
    {
        public InitializeIntersightHyperflexWitnessConfiguration()
        {
            ClassId = HyperflexWitnessConfiguration.ClassIdEnum.HyperflexWitnessConfiguration;
            ObjectType = HyperflexWitnessConfiguration.ObjectTypeEnum.HyperflexWitnessConfiguration;

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

        public HyperflexWitnessConfiguration.ClassIdEnum ClassId
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

        public HyperflexWitnessConfiguration.ObjectTypeEnum ObjectType
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
            Intersight.Model.HyperflexWitnessConfiguration initObject = new Intersight.Model.HyperflexWitnessConfiguration();
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexWwxnPrefixRange.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexWwxnPrefixRange")]
    public class InitializeIntersightHyperflexWwxnPrefixRange : PSCmdlet
    {
        public InitializeIntersightHyperflexWwxnPrefixRange()
        {
            ClassId = HyperflexWwxnPrefixRange.ClassIdEnum.HyperflexWwxnPrefixRange;
            ObjectType = HyperflexWwxnPrefixRange.ObjectTypeEnum.HyperflexWwxnPrefixRange;

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

        public HyperflexWwxnPrefixRange.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The end WWxN prefix of a WWPN/WWNN range in the form of 20:00:00:25:B5:XX."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^20:00:00:25:B5:[0-9a-fA-F]{2}$")]
        public string EndAddr
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexWwxnPrefixRange.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The start WWxN prefix of a WWPN/WWNN range in the form of 20:00:00:25:B5:XX."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^20:00:00:25:B5:[0-9a-fA-F]{2}$")]
        public string StartAddr
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HyperflexWwxnPrefixRange initObject = new Intersight.Model.HyperflexWwxnPrefixRange();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("EndAddr"))
            {
                initObject.EndAddr = this.EndAddr;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("StartAddr"))
            {
                initObject.StartAddr = this.StartAddr;
            }
            WriteObject(initObject);
        }

    }
}