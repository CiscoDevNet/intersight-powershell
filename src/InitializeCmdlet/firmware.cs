using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize FirmwareBaseImpact.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightFirmwareBaseImpact")]
    public class InitializeIntersightFirmwareBaseImpact : PSCmdlet
    {
        public InitializeIntersightFirmwareBaseImpact()
        {
            ComputationStatusDetail = FirmwareBaseImpact.ComputationStatusDetailEnum.Inprogress;
            ImpactType = FirmwareBaseImpact.ImpactTypeEnum.NoReboot;
            VersionImpact = FirmwareBaseImpact.VersionImpactEnum.None;

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

        public FirmwareBaseImpact.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Details for the error that occurred during the reboot validation analysis."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ComputationError
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The computation status of the estimate operation for a component.\n* `Inprogress` - Upgrade impact calculation is in progress.\n* `Completed` - Upgrade impact calculation is completed.\n* `Unavailable` - Upgrade impact is not available since the image is not present in the Fabric Interconnect.\n* `Failed` - Upgrade impact is not available due to an unknown error."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareBaseImpact.ComputationStatusDetailEnum ComputationStatusDetail
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The endpoint type or name."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string DomainName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a REST resource, uniquely identified by object type and MOID."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string EndPoint
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The current firmware version of the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string FirmwareVersion
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The impact type of the endpoint, whether a reboot is required or not.\n* `NoReboot` - A reboot is not required for the endpoint after upgrade.\n* `Reboot` - A reboot is required to the endpoint after upgrade."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareBaseImpact.ImpactTypeEnum ImpactType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The model details of the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Model
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareBaseImpact.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The target firmware version of the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string TargetFirmwareVersion
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The change of version impact for the endpoint.\n* `None` - No change in version for the component.\n* `Upgrade` - The component will be upgraded.\n* `Downgrade` - The component will be downgraded."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareBaseImpact.VersionImpactEnum VersionImpact
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.FirmwareBaseImpact initObject = new Intersight.Model.FirmwareBaseImpact();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ComputationError"))
            {
                initObject.ComputationError = this.ComputationError;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ComputationStatusDetail"))
            {
                initObject.ComputationStatusDetail = this.ComputationStatusDetail;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DomainName"))
            {
                initObject.DomainName = this.DomainName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EndPoint"))
            {
                initObject.EndPoint = this.EndPoint;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FirmwareVersion"))
            {
                initObject.FirmwareVersion = this.FirmwareVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ImpactType"))
            {
                initObject.ImpactType = this.ImpactType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Model"))
            {
                initObject.Model = this.Model;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("TargetFirmwareVersion"))
            {
                initObject.TargetFirmwareVersion = this.TargetFirmwareVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VersionImpact"))
            {
                initObject.VersionImpact = this.VersionImpact;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize FirmwareBiosDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightFirmwareBiosDescriptor")]
    public class InitializeIntersightFirmwareBiosDescriptor : PSCmdlet
    {
        public InitializeIntersightFirmwareBiosDescriptor()
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
        /// <para type="description">"The brand string of the endpoint for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string BrandString
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to capabilityCapability resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.CapabilityCapabilityRelationship> Capabilities
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareBiosDescriptor.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Detailed information about the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The label type for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Label
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The model of the endpoint, for which this capability information is applicable."</para>
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareBiosDescriptor.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The revision for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Revision
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
        /// <para type="description">"The vendor of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Vendor
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The firmware or software version of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Version
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.FirmwareBiosDescriptor initObject = new Intersight.Model.FirmwareBiosDescriptor();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BrandString"))
            {
                initObject.BrandString = this.BrandString;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Capabilities"))
            {
                initObject.Capabilities = this.Capabilities;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Label"))
            {
                initObject.Label = this.Label;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Model"))
            {
                initObject.Model = this.Model;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Revision"))
            {
                initObject.Revision = this.Revision;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Vendor"))
            {
                initObject.Vendor = this.Vendor;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Version"))
            {
                initObject._Version = this.Version;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize FirmwareBoardControllerDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightFirmwareBoardControllerDescriptor")]
    public class InitializeIntersightFirmwareBoardControllerDescriptor : PSCmdlet
    {
        public InitializeIntersightFirmwareBoardControllerDescriptor()
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
        /// <para type="description">"The brand string of the endpoint for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string BrandString
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to capabilityCapability resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.CapabilityCapabilityRelationship> Capabilities
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareBoardControllerDescriptor.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Detailed information about the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The label type for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Label
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The model of the endpoint, for which this capability information is applicable."</para>
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareBoardControllerDescriptor.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The revision for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Revision
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
        /// <para type="description">"The vendor of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Vendor
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The firmware or software version of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Version
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.FirmwareBoardControllerDescriptor initObject = new Intersight.Model.FirmwareBoardControllerDescriptor();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BrandString"))
            {
                initObject.BrandString = this.BrandString;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Capabilities"))
            {
                initObject.Capabilities = this.Capabilities;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Label"))
            {
                initObject.Label = this.Label;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Model"))
            {
                initObject.Model = this.Model;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Revision"))
            {
                initObject.Revision = this.Revision;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Vendor"))
            {
                initObject.Vendor = this.Vendor;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Version"))
            {
                initObject._Version = this.Version;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize FirmwareChassisUpgrade.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightFirmwareChassisUpgrade")]
    public class InitializeIntersightFirmwareChassisUpgrade : PSCmdlet
    {
        public InitializeIntersightFirmwareChassisUpgrade()
        {
            ClassId = FirmwareChassisUpgrade.ClassIdEnum.FirmwareChassisUpgrade;
            ObjectType = FirmwareChassisUpgrade.ObjectTypeEnum.FirmwareChassisUpgrade;
            Status = FirmwareChassisUpgrade.StatusEnum.NONE;
            UpgradeType = FirmwareChassisUpgrade.UpgradeTypeEnum.DirectUpgrade;

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
        /// <para type="description">"A reference to a equipmentChassis resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.EquipmentChassisRelationship Chassis
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareChassisUpgrade.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Direct download options in case the upgradeType is direct download based upgrade."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.FirmwareDirectDownload DirectDownload
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a firmwareDistributable resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.FirmwareDistributableRelationship Distributable
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<FirmwareChassisUpgrade.ExcludeComponentListEnum> ExcludeComponentList
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Location of the image in user software repository."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.SoftwarerepositoryFileServer FileServer
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
        /// <para type="description">"Deprecated (Use 'fileServer' property). Network share options in case of the upgradeType is network share based upgrade."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.FirmwareNetworkShare NetworkShare
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareChassisUpgrade.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a softwarerepositoryRelease resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.SoftwarerepositoryReleaseRelationship Release
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"User has the option to skip the estimate impact calculation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool SkipEstimateImpact
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Status of the upgrade operation.\n* `NONE` - Upgrade status is not populated.\n* `IN_PROGRESS` - The upgrade is in progress.\n* `SUCCESSFUL` - The upgrade successfully completed.\n* `FAILED` - The upgrade shows failed status.\n* `TERMINATED` - The upgrade has been terminated."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareChassisUpgrade.StatusEnum Status
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
        /// <para type="description">"Desired upgrade mode to choose either direct download based upgrade or network share upgrade.\n* `direct_upgrade` - Upgrade mode is direct download.\n* `network_upgrade` - Upgrade mode is network upgrade."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareChassisUpgrade.UpgradeTypeEnum UpgradeType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.FirmwareChassisUpgrade initObject = new Intersight.Model.FirmwareChassisUpgrade();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Chassis"))
            {
                initObject.Chassis = this.Chassis;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("DirectDownload"))
            {
                initObject.DirectDownload = this.DirectDownload;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Distributable"))
            {
                initObject.Distributable = this.Distributable;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ExcludeComponentList"))
            {
                initObject.ExcludeComponentList = this.ExcludeComponentList;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FileServer"))
            {
                initObject.FileServer = this.FileServer;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NetworkShare"))
            {
                initObject.NetworkShare = this.NetworkShare;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Release"))
            {
                initObject.Release = this.Release;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SkipEstimateImpact"))
            {
                initObject.SkipEstimateImpact = this.SkipEstimateImpact;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Status"))
            {
                initObject.Status = this.Status;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UpgradeType"))
            {
                initObject.UpgradeType = this.UpgradeType;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize FirmwareChassisUpgradeImpact.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightFirmwareChassisUpgradeImpact")]
    public class InitializeIntersightFirmwareChassisUpgradeImpact : PSCmdlet
    {
        public InitializeIntersightFirmwareChassisUpgradeImpact()
        {
            ClassId = FirmwareChassisUpgradeImpact.ClassIdEnum.FirmwareChassisUpgradeImpact;
            ComputationStatusDetail = FirmwareChassisUpgradeImpact.ComputationStatusDetailEnum.Inprogress;
            ImpactType = FirmwareChassisUpgradeImpact.ImpactTypeEnum.NoReboot;
            ObjectType = FirmwareChassisUpgradeImpact.ObjectTypeEnum.FirmwareChassisUpgradeImpact;
            VersionImpact = FirmwareChassisUpgradeImpact.VersionImpactEnum.None;

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

        public FirmwareChassisUpgradeImpact.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Details for the error that occurred during the reboot validation analysis."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ComputationError
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The computation status of the estimate operation for a component.\n* `Inprogress` - Upgrade impact calculation is in progress.\n* `Completed` - Upgrade impact calculation is completed.\n* `Unavailable` - Upgrade impact is not available since the image is not present in the Fabric Interconnect.\n* `Failed` - Upgrade impact is not available due to an unknown error."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareChassisUpgradeImpact.ComputationStatusDetailEnum ComputationStatusDetail
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The endpoint type or name."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string DomainName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a REST resource, uniquely identified by object type and MOID."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string EndPoint
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The current firmware version of the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string FirmwareVersion
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.FirmwareComponentImpact> ImpactDetail
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The impact type of the endpoint, whether a reboot is required or not.\n* `NoReboot` - A reboot is not required for the endpoint after upgrade.\n* `Reboot` - A reboot is required to the endpoint after upgrade."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareChassisUpgradeImpact.ImpactTypeEnum ImpactType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The model details of the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Model
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the chassis that will be affected by the upgrade."</para>
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

        public FirmwareChassisUpgradeImpact.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The target firmware version of the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string TargetFirmwareVersion
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Details for the chassis that will be impacted by the upgrade."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string UserLabel
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The change of version impact for the endpoint.\n* `None` - No change in version for the component.\n* `Upgrade` - The component will be upgraded.\n* `Downgrade` - The component will be downgraded."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareChassisUpgradeImpact.VersionImpactEnum VersionImpact
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.FirmwareChassisUpgradeImpact initObject = new Intersight.Model.FirmwareChassisUpgradeImpact();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ComputationError"))
            {
                initObject.ComputationError = this.ComputationError;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ComputationStatusDetail"))
            {
                initObject.ComputationStatusDetail = this.ComputationStatusDetail;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DomainName"))
            {
                initObject.DomainName = this.DomainName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EndPoint"))
            {
                initObject.EndPoint = this.EndPoint;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FirmwareVersion"))
            {
                initObject.FirmwareVersion = this.FirmwareVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ImpactDetail"))
            {
                initObject.ImpactDetail = this.ImpactDetail;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ImpactType"))
            {
                initObject.ImpactType = this.ImpactType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Model"))
            {
                initObject.Model = this.Model;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("TargetFirmwareVersion"))
            {
                initObject.TargetFirmwareVersion = this.TargetFirmwareVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UserLabel"))
            {
                initObject.UserLabel = this.UserLabel;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VersionImpact"))
            {
                initObject.VersionImpact = this.VersionImpact;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize FirmwareCifsServer.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightFirmwareCifsServer")]
    public class InitializeIntersightFirmwareCifsServer : PSCmdlet
    {
        public InitializeIntersightFirmwareCifsServer()
        {
            ClassId = FirmwareCifsServer.ClassIdEnum.FirmwareCifsServer;
            MountOptions = FirmwareCifsServer.MountOptionsEnum.None;
            ObjectType = FirmwareCifsServer.ObjectTypeEnum.FirmwareCifsServer;

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

        public FirmwareCifsServer.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The location to the image file. The accepted format is IP-or-hostname/folder1/folder2/.../imageFile."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string FileLocation
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Mount option (Authentication Protocol) as configured on the CIFS Server. Example:ntlmv2.\n* `none` - The default authentication protocol is decided by the endpoint.\n* `ntlm` - The external CIFS server is configured with ntlm as the authentication protocol.\n* `ntlmi` - Mount options of CIFS file server is ntlmi.\n* `ntlmv2` - Mount options of CIFS file server is ntlmv2.\n* `ntlmv2i` - Mount options of CIFS file server is ntlmv2i.\n* `ntlmssp` - Mount options of CIFS file server is ntlmssp.\n* `ntlmsspi` - Mount options of CIFS file server is ntlmsspi."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareCifsServer.MountOptionsEnum MountOptions
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareCifsServer.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.FirmwareCifsServer initObject = new Intersight.Model.FirmwareCifsServer();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("FileLocation"))
            {
                initObject.FileLocation = this.FileLocation;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MountOptions"))
            {
                initObject.MountOptions = this.MountOptions;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize FirmwareCimcDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightFirmwareCimcDescriptor")]
    public class InitializeIntersightFirmwareCimcDescriptor : PSCmdlet
    {
        public InitializeIntersightFirmwareCimcDescriptor()
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
        /// <para type="description">"The brand string of the endpoint for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string BrandString
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to capabilityCapability resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.CapabilityCapabilityRelationship> Capabilities
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareCimcDescriptor.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Detailed information about the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The label type for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Label
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The model of the endpoint, for which this capability information is applicable."</para>
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareCimcDescriptor.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The revision for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Revision
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
        /// <para type="description">"The vendor of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Vendor
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The firmware or software version of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Version
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.FirmwareCimcDescriptor initObject = new Intersight.Model.FirmwareCimcDescriptor();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BrandString"))
            {
                initObject.BrandString = this.BrandString;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Capabilities"))
            {
                initObject.Capabilities = this.Capabilities;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Label"))
            {
                initObject.Label = this.Label;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Model"))
            {
                initObject.Model = this.Model;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Revision"))
            {
                initObject.Revision = this.Revision;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Vendor"))
            {
                initObject.Vendor = this.Vendor;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Version"))
            {
                initObject._Version = this.Version;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize FirmwareComponentImpact.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightFirmwareComponentImpact")]
    public class InitializeIntersightFirmwareComponentImpact : PSCmdlet
    {
        public InitializeIntersightFirmwareComponentImpact()
        {
            ClassId = FirmwareComponentImpact.ClassIdEnum.FirmwareComponentImpact;
            Component = FirmwareComponentImpact.ComponentEnum.ALL;
            ComputationStatusDetail = FirmwareComponentImpact.ComputationStatusDetailEnum.Inprogress;
            ImpactType = FirmwareComponentImpact.ImpactTypeEnum.NoReboot;
            ObjectType = FirmwareComponentImpact.ObjectTypeEnum.FirmwareComponentImpact;
            VersionImpact = FirmwareComponentImpact.VersionImpactEnum.None;

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

        public FirmwareComponentImpact.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Impact on the component after the upgrade.\n* `ALL` - This represents all the components.\n* `ALL,HDD` - This represents all the components plus the HDDs.\n* `Drive-U.2` - This represents the U.2 drives that are SFF/LFF drives (mostly all the drives will fall under this category).\n* `Storage` - This represents the storage controller components.\n* `None` - This represents none of the components.\n* `NXOS` - This represents NXOS components.\n* `IOM` - This represents IOM components.\n* `PSU` - This represents PSU components.\n* `CIMC` - This represents CIMC components.\n* `BIOS` - This represents BIOS components.\n* `PCIE` - This represents PCIE components.\n* `Drive` - This represents Drive components.\n* `DIMM` - This represents DIMM components.\n* `BoardController` - This represents Board Controller components.\n* `StorageController` - This represents Storage Controller components.\n* `Storage-Sasexpander` - This represents Storage Sas-Expander components.\n* `Storage-U.2` - This represents U2 Storage Controller components.\n* `HBA` - This represents HBA components.\n* `GPU` - This represents GPU components.\n* `SasExpander` - This represents SasExpander components.\n* `MSwitch` - This represents mSwitch components.\n* `CMC` - This represents CMC components."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareComponentImpact.ComponentEnum Component
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Details for the error that occurred during the reboot validation analysis."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ComputationError
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The computation status of the estimate operation for a component.\n* `Inprogress` - Upgrade impact calculation is in progress.\n* `Completed` - Upgrade impact calculation is completed.\n* `Unavailable` - Upgrade impact is not available since the image is not present in the Fabric Interconnect.\n* `Failed` - Upgrade impact is not available due to an unknown error."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareComponentImpact.ComputationStatusDetailEnum ComputationStatusDetail
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The endpoint type or name."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string DomainName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a REST resource, uniquely identified by object type and MOID."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string EndPoint
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The current firmware version of the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string FirmwareVersion
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The impact type of the endpoint, whether a reboot is required or not.\n* `NoReboot` - A reboot is not required for the endpoint after upgrade.\n* `Reboot` - A reboot is required to the endpoint after upgrade."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareComponentImpact.ImpactTypeEnum ImpactType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The model details of the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Model
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareComponentImpact.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The target firmware version of the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string TargetFirmwareVersion
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The change of version impact for the endpoint.\n* `None` - No change in version for the component.\n* `Upgrade` - The component will be upgraded.\n* `Downgrade` - The component will be downgraded."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareComponentImpact.VersionImpactEnum VersionImpact
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.FirmwareComponentImpact initObject = new Intersight.Model.FirmwareComponentImpact();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Component"))
            {
                initObject.Component = this.Component;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ComputationError"))
            {
                initObject.ComputationError = this.ComputationError;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ComputationStatusDetail"))
            {
                initObject.ComputationStatusDetail = this.ComputationStatusDetail;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DomainName"))
            {
                initObject.DomainName = this.DomainName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EndPoint"))
            {
                initObject.EndPoint = this.EndPoint;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FirmwareVersion"))
            {
                initObject.FirmwareVersion = this.FirmwareVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ImpactType"))
            {
                initObject.ImpactType = this.ImpactType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Model"))
            {
                initObject.Model = this.Model;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("TargetFirmwareVersion"))
            {
                initObject.TargetFirmwareVersion = this.TargetFirmwareVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VersionImpact"))
            {
                initObject.VersionImpact = this.VersionImpact;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize FirmwareComponentMeta.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightFirmwareComponentMeta")]
    public class InitializeIntersightFirmwareComponentMeta : PSCmdlet
    {
        public InitializeIntersightFirmwareComponentMeta()
        {
            ClassId = FirmwareComponentMeta.ClassIdEnum.FirmwareComponentMeta;
            ComponentType = FirmwareComponentMeta.ComponentTypeEnum.ALL;
            Disruption = FirmwareComponentMeta.DisruptionEnum.None;
            ObjectType = FirmwareComponentMeta.ObjectTypeEnum.FirmwareComponentMeta;

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

        public FirmwareComponentMeta.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the component in the compressed HSU bundle."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ComponentLabel
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The type of component image within the distributable.\n* `ALL` - This represents all the components.\n* `ALL,HDD` - This represents all the components plus the HDDs.\n* `Drive-U.2` - This represents the U.2 drives that are SFF/LFF drives (mostly all the drives will fall under this category).\n* `Storage` - This represents the storage controller components.\n* `None` - This represents none of the components.\n* `NXOS` - This represents NXOS components.\n* `IOM` - This represents IOM components.\n* `PSU` - This represents PSU components.\n* `CIMC` - This represents CIMC components.\n* `BIOS` - This represents BIOS components.\n* `PCIE` - This represents PCIE components.\n* `Drive` - This represents Drive components.\n* `DIMM` - This represents DIMM components.\n* `BoardController` - This represents Board Controller components.\n* `StorageController` - This represents Storage Controller components.\n* `Storage-Sasexpander` - This represents Storage Sas-Expander components.\n* `Storage-U.2` - This represents U2 Storage Controller components.\n* `HBA` - This represents HBA components.\n* `GPU` - This represents GPU components.\n* `SasExpander` - This represents SasExpander components.\n* `MSwitch` - This represents mSwitch components.\n* `CMC` - This represents CMC components."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareComponentMeta.ComponentTypeEnum ComponentType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"This shows the description of component image within the distributable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The type of disruption on each component. For example, host reboot, automatic power cycle, and manual power cycle.\n* `None` - Indicates that the component did not receive a disruption request.\n* `HostReboot` - Indicates that the component received a host reboot request.\n* `EndpointReboot` - Indicates that the component received an end point reboot request.\n* `ManualPowerCycle` - Indicates that the component received a manual power cycle request.\n* `AutomaticPowerCycle` - Indicates that the component received an automatic power cycle request."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareComponentMeta.DisruptionEnum Disruption
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"This shows the path of component image within the distributable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ImagePath
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"If set, the component can be updated through out-of-band management, else, is updated through host service utility boot."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool IsOobSupported
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The model of the component image in the distributable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Model
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareComponentMeta.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<FirmwareComponentMeta.OobManageabilityEnum> OobManageability
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The image version of components packaged in the distributable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string PackedVersion
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The redfish target for each component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string RedfishUrl
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The version of component image in the distributable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Vendor
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.FirmwareComponentMeta initObject = new Intersight.Model.FirmwareComponentMeta();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ComponentLabel"))
            {
                initObject.ComponentLabel = this.ComponentLabel;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ComponentType"))
            {
                initObject.ComponentType = this.ComponentType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Disruption"))
            {
                initObject.Disruption = this.Disruption;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ImagePath"))
            {
                initObject.ImagePath = this.ImagePath;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IsOobSupported"))
            {
                initObject.IsOobSupported = this.IsOobSupported;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Model"))
            {
                initObject.Model = this.Model;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("OobManageability"))
            {
                initObject.OobManageability = this.OobManageability;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PackedVersion"))
            {
                initObject.PackedVersion = this.PackedVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RedfishUrl"))
            {
                initObject.RedfishUrl = this.RedfishUrl;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Vendor"))
            {
                initObject.Vendor = this.Vendor;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize FirmwareDimmDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightFirmwareDimmDescriptor")]
    public class InitializeIntersightFirmwareDimmDescriptor : PSCmdlet
    {
        public InitializeIntersightFirmwareDimmDescriptor()
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
        /// <para type="description">"The brand string of the endpoint for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string BrandString
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to capabilityCapability resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.CapabilityCapabilityRelationship> Capabilities
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareDimmDescriptor.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Detailed information about the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The label type for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Label
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The model of the endpoint, for which this capability information is applicable."</para>
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareDimmDescriptor.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The revision for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Revision
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
        /// <para type="description">"The vendor of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Vendor
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The firmware or software version of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Version
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.FirmwareDimmDescriptor initObject = new Intersight.Model.FirmwareDimmDescriptor();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BrandString"))
            {
                initObject.BrandString = this.BrandString;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Capabilities"))
            {
                initObject.Capabilities = this.Capabilities;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Label"))
            {
                initObject.Label = this.Label;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Model"))
            {
                initObject.Model = this.Model;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Revision"))
            {
                initObject.Revision = this.Revision;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Vendor"))
            {
                initObject.Vendor = this.Vendor;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Version"))
            {
                initObject._Version = this.Version;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize FirmwareDirectDownload.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightFirmwareDirectDownload")]
    public class InitializeIntersightFirmwareDirectDownload : PSCmdlet
    {
        public InitializeIntersightFirmwareDirectDownload()
        {
            ClassId = FirmwareDirectDownload.ClassIdEnum.FirmwareDirectDownload;
            ImageSource = FirmwareDirectDownload.ImageSourceEnum.Cisco;
            ObjectType = FirmwareDirectDownload.ObjectTypeEnum.FirmwareDirectDownload;
            Upgradeoption = FirmwareDirectDownload.UpgradeoptionEnum.SdUpgradeMountOnly;

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

        public FirmwareDirectDownload.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"HTTP Server option when the image source is a local HTTPS server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.FirmwareHttpServer HttpServer
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Source type referring the image to be downloaded from CCO or from a local HTTPS server.\n* `cisco` - Image to be downloaded from Cisco software repository.\n* `localHttp` - Image to be downloaded from a https server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareDirectDownload.ImageSourceEnum ImageSource
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareDirectDownload.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Password as configured on the local https server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Password
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Option to control the upgrade, e.g., sd_upgrade_mount_only - download the image into sd and upgrade wait for the server on-next boot.\n* `sd_upgrade_mount_only` - Direct upgrade SD upgrade mount only.\n* `sd_download_only` - Direct upgrade SD download only.\n* `sd_upgrade_only` - Direct upgrade SD upgrade only.\n* `sd_upgrade_full` - Direct upgrade SD upgrade full.\n* `download_only` - Direct upgrade image download only.\n* `upgrade_full` - The upgrade downloads or mounts the image, and reboots immediately for an upgrade.\n* `upgrade_mount_only` - The upgrade downloads or mounts the image. The upgrade happens in next reboot.\n* `chassis_upgrade_full` - Direct upgrade chassis upgrade full.\n* `monitor_only` - Direct upgrade monitor progress only.\n* `validate_only` - Validate whether a component is ready for ugprade."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareDirectDownload.UpgradeoptionEnum Upgradeoption
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Username as configured on the local https server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Username
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.FirmwareDirectDownload initObject = new Intersight.Model.FirmwareDirectDownload();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("HttpServer"))
            {
                initObject.HttpServer = this.HttpServer;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ImageSource"))
            {
                initObject.ImageSource = this.ImageSource;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Password"))
            {
                initObject.Password = this.Password;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Upgradeoption"))
            {
                initObject.Upgradeoption = this.Upgradeoption;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Username"))
            {
                initObject.Username = this.Username;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize FirmwareDistributable.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightFirmwareDistributable")]
    public class InitializeIntersightFirmwareDistributable : PSCmdlet
    {
        public InitializeIntersightFirmwareDistributable()
        {
            ClassId = FirmwareDistributable.ClassIdEnum.FirmwareDistributable;
            ImportAction = FirmwareDistributable.ImportActionEnum.None;
            ObjectType = FirmwareDistributable.ObjectTypeEnum.FirmwareDistributable;
            Origin = FirmwareDistributable.OriginEnum.System;

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
        /// <para type="description">"A reference to a softwarerepositoryCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.SoftwarerepositoryCatalogRelationship Catalog
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareDistributable.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.FirmwareComponentMeta> ComponentMeta
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"User provided description about the file. Cisco provided description for image inventoried from a Cisco repository."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to firmwareDistributableMeta resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.FirmwareDistributableMetaRelationship> DistributableMetas
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The file location of the distributable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string FileLocation
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The category into which the distributable falls into according to the supported platform series. For e.g.; C-Series/B-Series/Infrastructure."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ImageCategory
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The type of image which the distributable falls into according to the component it can upgrade. For e.g.; Standalone server, Intersight managed server, UCS Managed Fabric Interconnect. The field is used in private appliance mode, where image does not have description populated from CCO."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ImageType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The action to be performed on the imported file. If 'PreCache' is set, the image will be cached in Appliance. Applicable in Intersight appliance deployment. If 'Evict' is set, the cached file will be removed. Applicable in Intersight appliance deployment. If 'GeneratePreSignedUploadUrl' is set, generates pre signed URL (s) for the file to be imported into the repository. Applicable for local machine source. The URL (s) will be populated under LocalMachine file server. If 'CompleteImportProcess' is set, the ImportState is marked as 'Imported'. Applicable for local machine source. If 'Cancel' is set, the ImportState is marked as 'Failed'. Applicable for local machine source.\n* `None` - No action should be taken on the imported file.\n* `GeneratePreSignedUploadUrl` - Generate pre signed URL of file for importing into the repository.\n* `GeneratePreSignedDownloadUrl` - Generate pre signed URL of file in the repository to download.\n* `CompleteImportProcess` - Mark that the import process of the file into the repository is complete.\n* `MarkImportFailed` - Mark to indicate that the import process of the file into the repository failed.\n* `PreCache` - Cache the file into the Intersight Appliance.\n* `Cancel` - The cancel import process for the file into the repository.\n* `Extract` - The action to extract the file in the external repository.\n* `Evict` - Evict the cached file from the Intersight Appliance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareDistributable.ImportActionEnum ImportAction
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The MD5 ETag for a file that is stored in Intersight repository or in the appliance cache. Warning - MD5 is currently broken and this will be migrated to SHA shortly."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Md5eTag
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The md5sum checksum of the file. This information is available for all Cisco distributed images and files imported to the local repository."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Md5sum
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The mdfid of the image provided by cisco.com."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Mdfid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The endpoint model for which this firmware image is applicable."</para>
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
        /// <para type="description">"The name of the file. It is populated as part of the image import operation."</para>
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

        public FirmwareDistributable.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The source of the distributable. If it has been created by the user or system.\n* `System` - The distributable has been created by the System.\n* `User` - The distributable has been created by the User."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareDistributable.OriginEnum Origin
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The build which is recommended by Cisco."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string RecommendedBuild
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a softwarerepositoryRelease resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.SoftwarerepositoryReleaseRelationship Release
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The date on which the file was released or distributed by its vendor."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime ReleaseDate
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The url for the release notes of this image."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ReleaseNotesUrl
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The sha512sum of the file. This information is available for all Cisco distributed images and files imported to the local repository."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Sha512sum
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The size (in bytes) of the file. This information is available for all Cisco distributed images and files imported to the local repository."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Size
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The software advisory, if any, provided by the vendor for this file."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SoftwareAdvisoryUrl
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Location of the file in an external repository."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.SoftwarerepositoryFileServer Source
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> SupportedModels
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
        /// <para type="description">"The vendor or publisher of this file."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Vendor
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Vendor provided version for the file."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Version
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.FirmwareDistributable initObject = new Intersight.Model.FirmwareDistributable();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Catalog"))
            {
                initObject.Catalog = this.Catalog;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ComponentMeta"))
            {
                initObject.ComponentMeta = this.ComponentMeta;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DistributableMetas"))
            {
                initObject.DistributableMetas = this.DistributableMetas;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FileLocation"))
            {
                initObject.FileLocation = this.FileLocation;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ImageCategory"))
            {
                initObject.ImageCategory = this.ImageCategory;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ImageType"))
            {
                initObject.ImageType = this.ImageType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ImportAction"))
            {
                initObject.ImportAction = this.ImportAction;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Md5eTag"))
            {
                initObject.Md5eTag = this.Md5eTag;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Md5sum"))
            {
                initObject.Md5sum = this.Md5sum;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Mdfid"))
            {
                initObject.Mdfid = this.Mdfid;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Origin"))
            {
                initObject.Origin = this.Origin;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecommendedBuild"))
            {
                initObject.RecommendedBuild = this.RecommendedBuild;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Release"))
            {
                initObject.Release = this.Release;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ReleaseDate"))
            {
                initObject.ReleaseDate = this.ReleaseDate;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ReleaseNotesUrl"))
            {
                initObject.ReleaseNotesUrl = this.ReleaseNotesUrl;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Sha512sum"))
            {
                initObject.Sha512sum = this.Sha512sum;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Size"))
            {
                initObject.Size = this.Size;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SoftwareAdvisoryUrl"))
            {
                initObject.SoftwareAdvisoryUrl = this.SoftwareAdvisoryUrl;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Source"))
            {
                initObject.Source = this.Source;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SupportedModels"))
            {
                initObject.SupportedModels = this.SupportedModels;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Vendor"))
            {
                initObject.Vendor = this.Vendor;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Version"))
            {
                initObject._Version = this.Version;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize FirmwareDistributableMeta.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightFirmwareDistributableMeta")]
    public class InitializeIntersightFirmwareDistributableMeta : PSCmdlet
    {
        public InitializeIntersightFirmwareDistributableMeta()
        {
            ClassId = FirmwareDistributableMeta.ClassIdEnum.FirmwareDistributableMeta;
            FileType = FirmwareDistributableMeta.FileTypeEnum.Distributable;
            ObjectType = FirmwareDistributableMeta.ObjectTypeEnum.FirmwareDistributableMeta;
            Source = FirmwareDistributableMeta.SourceEnum.Cisco;

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
        /// <para type="description">"The S3 bucket name where the images are present, if source is external cloud store."</para>
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

        public FirmwareDistributableMeta.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The type of distributable image, example huu, scu, driver, os.\n* `Distributable` - Stores firmware host utility images and fabric images.\n* `DriverDistributable` - Stores driver distributable images.\n* `ServerConfigurationUtilityDistributable` - Stores server configuration utility images.\n* `OperatingSystemFile` - Stores operating system iso images.\n* `HyperflexDistributable` - It stores HyperFlex images."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareDistributableMeta.FileTypeEnum FileType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The version from which user can download images from amazon store, if source is external cloud store."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string FromVersion
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The mdfid of the image provided by cisco.com."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Mdfid
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

        public FirmwareDistributableMeta.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The software type id provided by cisco.com."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SoftwareTypeId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The image can be downloaded from cisco.com or external cloud store.\n* `Cisco` - External repository hosted on cisco.com.\n* `IntersightCloud` - Repository hosted by the Intersight Cloud.\n* `LocalMachine` - The file is available on the local client machine. Used as an upload source type.\n* `NetworkShare` - External repository in the customer datacenter. This will typically be a file server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareDistributableMeta.SourceEnum Source
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> SupportedModels
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
        /// <para type="description">"The version till which user can download images from amazon store, if source is external cloud store."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ToVersion
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.FirmwareDistributableMeta initObject = new Intersight.Model.FirmwareDistributableMeta();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BucketName"))
            {
                initObject.BucketName = this.BucketName;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("FileType"))
            {
                initObject.FileType = this.FileType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FromVersion"))
            {
                initObject.FromVersion = this.FromVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Mdfid"))
            {
                initObject.Mdfid = this.Mdfid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("SoftwareTypeId"))
            {
                initObject.SoftwareTypeId = this.SoftwareTypeId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Source"))
            {
                initObject.Source = this.Source;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SupportedModels"))
            {
                initObject.SupportedModels = this.SupportedModels;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ToVersion"))
            {
                initObject.ToVersion = this.ToVersion;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize FirmwareDriveDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightFirmwareDriveDescriptor")]
    public class InitializeIntersightFirmwareDriveDescriptor : PSCmdlet
    {
        public InitializeIntersightFirmwareDriveDescriptor()
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
        /// <para type="description">"The brand string of the endpoint for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string BrandString
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to capabilityCapability resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.CapabilityCapabilityRelationship> Capabilities
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareDriveDescriptor.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Detailed information about the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The label type for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Label
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The model of the endpoint, for which this capability information is applicable."</para>
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareDriveDescriptor.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The revision for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Revision
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
        /// <para type="description">"The vendor of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Vendor
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The firmware or software version of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Version
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.FirmwareDriveDescriptor initObject = new Intersight.Model.FirmwareDriveDescriptor();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BrandString"))
            {
                initObject.BrandString = this.BrandString;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Capabilities"))
            {
                initObject.Capabilities = this.Capabilities;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Label"))
            {
                initObject.Label = this.Label;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Model"))
            {
                initObject.Model = this.Model;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Revision"))
            {
                initObject.Revision = this.Revision;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Vendor"))
            {
                initObject.Vendor = this.Vendor;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Version"))
            {
                initObject._Version = this.Version;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize FirmwareDriverDistributable.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightFirmwareDriverDistributable")]
    public class InitializeIntersightFirmwareDriverDistributable : PSCmdlet
    {
        public InitializeIntersightFirmwareDriverDistributable()
        {
            ClassId = FirmwareDriverDistributable.ClassIdEnum.FirmwareDriverDistributable;
            ImportAction = FirmwareDriverDistributable.ImportActionEnum.None;
            ObjectType = FirmwareDriverDistributable.ObjectTypeEnum.FirmwareDriverDistributable;

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
        /// <para type="description">"A reference to a softwarerepositoryCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.SoftwarerepositoryCatalogRelationship Catalog
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The device type on which the driver is installable."</para>
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

        public FirmwareDriverDistributable.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.FirmwareComponentMeta> ComponentMeta
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"User provided description about the file. Cisco provided description for image inventoried from a Cisco repository."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Indicates in which directory path this driver will be added."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Directory
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to firmwareDistributableMeta resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.FirmwareDistributableMetaRelationship> DistributableMetas
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The type of image which the distributable falls into according to the component it can upgrade. For e.g.; Standalone server, Intersight managed server, UCS Managed Fabric Interconnect. The field is used in private appliance mode, where image does not have description populated from CCO."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ImageType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The action to be performed on the imported file. If 'PreCache' is set, the image will be cached in Appliance. Applicable in Intersight appliance deployment. If 'Evict' is set, the cached file will be removed. Applicable in Intersight appliance deployment. If 'GeneratePreSignedUploadUrl' is set, generates pre signed URL (s) for the file to be imported into the repository. Applicable for local machine source. The URL (s) will be populated under LocalMachine file server. If 'CompleteImportProcess' is set, the ImportState is marked as 'Imported'. Applicable for local machine source. If 'Cancel' is set, the ImportState is marked as 'Failed'. Applicable for local machine source.\n* `None` - No action should be taken on the imported file.\n* `GeneratePreSignedUploadUrl` - Generate pre signed URL of file for importing into the repository.\n* `GeneratePreSignedDownloadUrl` - Generate pre signed URL of file in the repository to download.\n* `CompleteImportProcess` - Mark that the import process of the file into the repository is complete.\n* `MarkImportFailed` - Mark to indicate that the import process of the file into the repository failed.\n* `PreCache` - Cache the file into the Intersight Appliance.\n* `Cancel` - The cancel import process for the file into the repository.\n* `Extract` - The action to extract the file in the external repository.\n* `Evict` - Evict the cached file from the Intersight Appliance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareDriverDistributable.ImportActionEnum ImportAction
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The MD5 ETag for a file that is stored in Intersight repository or in the appliance cache. Warning - MD5 is currently broken and this will be migrated to SHA shortly."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Md5eTag
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The md5sum checksum of the file. This information is available for all Cisco distributed images and files imported to the local repository."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Md5sum
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The mdfid of the image provided by cisco.com."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Mdfid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The endpoint model for which this firmware image is applicable."</para>
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
        /// <para type="description">"The name of the file. It is populated as part of the image import operation."</para>
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

        public FirmwareDriverDistributable.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The operating system name to which this driver is compatible."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Osname
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"OS Version. It is populated as part of the image import operation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Osversion
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The build which is recommended by Cisco."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string RecommendedBuild
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a softwarerepositoryRelease resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.SoftwarerepositoryReleaseRelationship Release
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The date on which the file was released or distributed by its vendor."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime ReleaseDate
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The url for the release notes of this image."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ReleaseNotesUrl
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The sha512sum of the file. This information is available for all Cisco distributed images and files imported to the local repository."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Sha512sum
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The size (in bytes) of the file. This information is available for all Cisco distributed images and files imported to the local repository."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Size
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The software advisory, if any, provided by the vendor for this file."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SoftwareAdvisoryUrl
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Location of the file in an external repository."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.SoftwarerepositoryFileServer Source
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> SupportedModels
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
        /// <para type="description">"The vendor or publisher of this file."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Vendor
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Vendor provided version for the file."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Version
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.FirmwareDriverDistributable initObject = new Intersight.Model.FirmwareDriverDistributable();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Catalog"))
            {
                initObject.Catalog = this.Catalog;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Category"))
            {
                initObject.Category = this.Category;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ComponentMeta"))
            {
                initObject.ComponentMeta = this.ComponentMeta;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Directory"))
            {
                initObject.Directory = this.Directory;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DistributableMetas"))
            {
                initObject.DistributableMetas = this.DistributableMetas;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ImageType"))
            {
                initObject.ImageType = this.ImageType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ImportAction"))
            {
                initObject.ImportAction = this.ImportAction;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Md5eTag"))
            {
                initObject.Md5eTag = this.Md5eTag;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Md5sum"))
            {
                initObject.Md5sum = this.Md5sum;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Mdfid"))
            {
                initObject.Mdfid = this.Mdfid;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Osname"))
            {
                initObject.Osname = this.Osname;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Osversion"))
            {
                initObject.Osversion = this.Osversion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecommendedBuild"))
            {
                initObject.RecommendedBuild = this.RecommendedBuild;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Release"))
            {
                initObject.Release = this.Release;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ReleaseDate"))
            {
                initObject.ReleaseDate = this.ReleaseDate;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ReleaseNotesUrl"))
            {
                initObject.ReleaseNotesUrl = this.ReleaseNotesUrl;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Sha512sum"))
            {
                initObject.Sha512sum = this.Sha512sum;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Size"))
            {
                initObject.Size = this.Size;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SoftwareAdvisoryUrl"))
            {
                initObject.SoftwareAdvisoryUrl = this.SoftwareAdvisoryUrl;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Source"))
            {
                initObject.Source = this.Source;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SupportedModels"))
            {
                initObject.SupportedModels = this.SupportedModels;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Vendor"))
            {
                initObject.Vendor = this.Vendor;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Version"))
            {
                initObject._Version = this.Version;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize FirmwareEula.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightFirmwareEula")]
    public class InitializeIntersightFirmwareEula : PSCmdlet
    {
        public InitializeIntersightFirmwareEula()
        {
            ClassId = FirmwareEula.ClassIdEnum.FirmwareEula;
            ObjectType = FirmwareEula.ObjectTypeEnum.FirmwareEula;

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

        public FirmwareEula.ClassIdEnum ClassId
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

        public FirmwareEula.ObjectTypeEnum ObjectType
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
            Intersight.Model.FirmwareEula initObject = new Intersight.Model.FirmwareEula();
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
    /// <para type="synopsis">This is the cmdlet to Initialize FirmwareExcludeComponentPidListType.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightFirmwareExcludeComponentPidListType")]
    public class InitializeIntersightFirmwareExcludeComponentPidListType : PSCmdlet
    {
        public InitializeIntersightFirmwareExcludeComponentPidListType()
        {
            ClassId = FirmwareExcludeComponentPidListType.ClassIdEnum.FirmwareExcludeComponentPidListType;
            ObjectType = FirmwareExcludeComponentPidListType.ObjectTypeEnum.FirmwareExcludeComponentPidListType;

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

        public FirmwareExcludeComponentPidListType.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> ExcludeLocalDiskList
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> ExcludeStorageControllerList
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareExcludeComponentPidListType.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.FirmwareExcludeComponentPidListType initObject = new Intersight.Model.FirmwareExcludeComponentPidListType();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ExcludeLocalDiskList"))
            {
                initObject.ExcludeLocalDiskList = this.ExcludeLocalDiskList;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ExcludeStorageControllerList"))
            {
                initObject.ExcludeStorageControllerList = this.ExcludeStorageControllerList;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize FirmwareFabricUpgradeImpact.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightFirmwareFabricUpgradeImpact")]
    public class InitializeIntersightFirmwareFabricUpgradeImpact : PSCmdlet
    {
        public InitializeIntersightFirmwareFabricUpgradeImpact()
        {
            ClassId = FirmwareFabricUpgradeImpact.ClassIdEnum.FirmwareFabricUpgradeImpact;
            ComputationStatusDetail = FirmwareFabricUpgradeImpact.ComputationStatusDetailEnum.Inprogress;
            ImpactType = FirmwareFabricUpgradeImpact.ImpactTypeEnum.NoReboot;
            ObjectType = FirmwareFabricUpgradeImpact.ObjectTypeEnum.FirmwareFabricUpgradeImpact;
            VersionImpact = FirmwareFabricUpgradeImpact.VersionImpactEnum.None;

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

        public FirmwareFabricUpgradeImpact.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Details for the error that occurred during the reboot validation analysis."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ComputationError
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The computation status of the estimate operation for a component.\n* `Inprogress` - Upgrade impact calculation is in progress.\n* `Completed` - Upgrade impact calculation is completed.\n* `Unavailable` - Upgrade impact is not available since the image is not present in the Fabric Interconnect.\n* `Failed` - Upgrade impact is not available due to an unknown error."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareFabricUpgradeImpact.ComputationStatusDetailEnum ComputationStatusDetail
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The endpoint type or name."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string DomainName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a REST resource, uniquely identified by object type and MOID."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string EndPoint
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The current firmware version of the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string FirmwareVersion
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.FirmwareComponentImpact> ImpactDetail
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The impact type of the endpoint, whether a reboot is required or not.\n* `NoReboot` - A reboot is not required for the endpoint after upgrade.\n* `Reboot` - A reboot is required to the endpoint after upgrade."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareFabricUpgradeImpact.ImpactTypeEnum ImpactType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The model details of the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Model
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareFabricUpgradeImpact.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Details for the Fabric Interconnect that will be impacted by the upgrade."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Serial
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The target firmware version of the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string TargetFirmwareVersion
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The change of version impact for the endpoint.\n* `None` - No change in version for the component.\n* `Upgrade` - The component will be upgraded.\n* `Downgrade` - The component will be downgraded."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareFabricUpgradeImpact.VersionImpactEnum VersionImpact
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.FirmwareFabricUpgradeImpact initObject = new Intersight.Model.FirmwareFabricUpgradeImpact();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ComputationError"))
            {
                initObject.ComputationError = this.ComputationError;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ComputationStatusDetail"))
            {
                initObject.ComputationStatusDetail = this.ComputationStatusDetail;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DomainName"))
            {
                initObject.DomainName = this.DomainName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EndPoint"))
            {
                initObject.EndPoint = this.EndPoint;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FirmwareVersion"))
            {
                initObject.FirmwareVersion = this.FirmwareVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ImpactDetail"))
            {
                initObject.ImpactDetail = this.ImpactDetail;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ImpactType"))
            {
                initObject.ImpactType = this.ImpactType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Model"))
            {
                initObject.Model = this.Model;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Serial"))
            {
                initObject.Serial = this.Serial;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TargetFirmwareVersion"))
            {
                initObject.TargetFirmwareVersion = this.TargetFirmwareVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VersionImpact"))
            {
                initObject.VersionImpact = this.VersionImpact;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize FirmwareFirmwareInventory.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightFirmwareFirmwareInventory")]
    public class InitializeIntersightFirmwareFirmwareInventory : PSCmdlet
    {
        public InitializeIntersightFirmwareFirmwareInventory()
        {
            ClassId = FirmwareFirmwareInventory.ClassIdEnum.FirmwareFirmwareInventory;
            ObjectType = FirmwareFirmwareInventory.ObjectTypeEnum.FirmwareFirmwareInventory;

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
        /// <para type="description">"Component category. For example, MRAID is under storage controller, CIMC is under management controller."</para>
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

        public FirmwareFirmwareInventory.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the component to reflect on UI."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Label
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Model deatils of component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Model
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareFirmwareInventory.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The redfish URI to get the firmware inventory of server components."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string UpdateUri
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The vendor of the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Vendor
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The firmware running version on the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Version
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.FirmwareFirmwareInventory initObject = new Intersight.Model.FirmwareFirmwareInventory();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Category"))
            {
                initObject.Category = this.Category;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Label"))
            {
                initObject.Label = this.Label;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Model"))
            {
                initObject.Model = this.Model;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("UpdateUri"))
            {
                initObject.UpdateUri = this.UpdateUri;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Vendor"))
            {
                initObject.Vendor = this.Vendor;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Version"))
            {
                initObject._Version = this.Version;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize FirmwareFirmwareSummary.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightFirmwareFirmwareSummary")]
    public class InitializeIntersightFirmwareFirmwareSummary : PSCmdlet
    {
        public InitializeIntersightFirmwareFirmwareSummary()
        {
            ClassId = FirmwareFirmwareSummary.ClassIdEnum.FirmwareFirmwareSummary;
            ObjectType = FirmwareFirmwareSummary.ObjectTypeEnum.FirmwareFirmwareSummary;

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
        /// <para type="description">"Version details at the bundle level for the each of server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string BundleVersion
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareFirmwareSummary.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.FirmwareFirmwareInventory> ComponentsFwInventory
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

        public FirmwareFirmwareSummary.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a computePhysical resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.ComputePhysicalRelationship Server
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

        public Model.MoBaseMoRelationship TargetMo
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.FirmwareFirmwareSummary initObject = new Intersight.Model.FirmwareFirmwareSummary();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BundleVersion"))
            {
                initObject.BundleVersion = this.BundleVersion;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ComponentsFwInventory"))
            {
                initObject.ComponentsFwInventory = this.ComponentsFwInventory;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Server"))
            {
                initObject.Server = this.Server;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TargetMo"))
            {
                initObject.TargetMo = this.TargetMo;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize FirmwareGpuDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightFirmwareGpuDescriptor")]
    public class InitializeIntersightFirmwareGpuDescriptor : PSCmdlet
    {
        public InitializeIntersightFirmwareGpuDescriptor()
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
        /// <para type="description">"The brand string of the endpoint for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string BrandString
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to capabilityCapability resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.CapabilityCapabilityRelationship> Capabilities
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareGpuDescriptor.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Detailed information about the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The label type for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Label
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The model of the endpoint, for which this capability information is applicable."</para>
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareGpuDescriptor.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The revision for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Revision
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
        /// <para type="description">"The vendor of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Vendor
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The firmware or software version of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Version
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.FirmwareGpuDescriptor initObject = new Intersight.Model.FirmwareGpuDescriptor();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BrandString"))
            {
                initObject.BrandString = this.BrandString;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Capabilities"))
            {
                initObject.Capabilities = this.Capabilities;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Label"))
            {
                initObject.Label = this.Label;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Model"))
            {
                initObject.Model = this.Model;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Revision"))
            {
                initObject.Revision = this.Revision;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Vendor"))
            {
                initObject.Vendor = this.Vendor;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Version"))
            {
                initObject._Version = this.Version;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize FirmwareHbaDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightFirmwareHbaDescriptor")]
    public class InitializeIntersightFirmwareHbaDescriptor : PSCmdlet
    {
        public InitializeIntersightFirmwareHbaDescriptor()
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
        /// <para type="description">"The brand string of the endpoint for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string BrandString
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to capabilityCapability resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.CapabilityCapabilityRelationship> Capabilities
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareHbaDescriptor.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Detailed information about the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The label type for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Label
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The model of the endpoint, for which this capability information is applicable."</para>
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareHbaDescriptor.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The revision for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Revision
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
        /// <para type="description">"The vendor of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Vendor
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The firmware or software version of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Version
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.FirmwareHbaDescriptor initObject = new Intersight.Model.FirmwareHbaDescriptor();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BrandString"))
            {
                initObject.BrandString = this.BrandString;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Capabilities"))
            {
                initObject.Capabilities = this.Capabilities;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Label"))
            {
                initObject.Label = this.Label;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Model"))
            {
                initObject.Model = this.Model;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Revision"))
            {
                initObject.Revision = this.Revision;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Vendor"))
            {
                initObject.Vendor = this.Vendor;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Version"))
            {
                initObject._Version = this.Version;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize FirmwareHttpServer.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightFirmwareHttpServer")]
    public class InitializeIntersightFirmwareHttpServer : PSCmdlet
    {
        public InitializeIntersightFirmwareHttpServer()
        {
            ClassId = FirmwareHttpServer.ClassIdEnum.FirmwareHttpServer;
            ObjectType = FirmwareHttpServer.ObjectTypeEnum.FirmwareHttpServer;

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

        public FirmwareHttpServer.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"HTTP/HTTPS link to the image. Accepted formats HTTP[s]://server-hostname/share/image or HTTP[s]://serverip/share/image. For a successful upgrade, the remote share server must have network connectivity with the CIMC of the selected devices."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string LocationLink
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Mount option as configured on the HTTP server. Empty if nothing is configured."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string MountOptions
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareHttpServer.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.FirmwareHttpServer initObject = new Intersight.Model.FirmwareHttpServer();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("LocationLink"))
            {
                initObject.LocationLink = this.LocationLink;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MountOptions"))
            {
                initObject.MountOptions = this.MountOptions;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize FirmwareIomDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightFirmwareIomDescriptor")]
    public class InitializeIntersightFirmwareIomDescriptor : PSCmdlet
    {
        public InitializeIntersightFirmwareIomDescriptor()
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
        /// <para type="description">"The brand string of the endpoint for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string BrandString
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to capabilityCapability resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.CapabilityCapabilityRelationship> Capabilities
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareIomDescriptor.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Detailed information about the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The label type for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Label
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The model of the endpoint, for which this capability information is applicable."</para>
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareIomDescriptor.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The revision for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Revision
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
        /// <para type="description">"The vendor of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Vendor
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The firmware or software version of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Version
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.FirmwareIomDescriptor initObject = new Intersight.Model.FirmwareIomDescriptor();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BrandString"))
            {
                initObject.BrandString = this.BrandString;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Capabilities"))
            {
                initObject.Capabilities = this.Capabilities;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Label"))
            {
                initObject.Label = this.Label;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Model"))
            {
                initObject.Model = this.Model;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Revision"))
            {
                initObject.Revision = this.Revision;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Vendor"))
            {
                initObject.Vendor = this.Vendor;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Version"))
            {
                initObject._Version = this.Version;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize FirmwareModelBundleVersion.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightFirmwareModelBundleVersion")]
    public class InitializeIntersightFirmwareModelBundleVersion : PSCmdlet
    {
        public InitializeIntersightFirmwareModelBundleVersion()
        {
            ClassId = FirmwareModelBundleVersion.ClassIdEnum.FirmwareModelBundleVersion;
            ModelFamily = FirmwareModelBundleVersion.ModelFamilyEnum.UCSCC220M5;
            ObjectType = FirmwareModelBundleVersion.ObjectTypeEnum.FirmwareModelBundleVersion;

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
        /// <para type="description">"The bundle version to which the server will be upgraded."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string BundleVersion
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareModelBundleVersion.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The server family that will be impacted by this upgrade.\n* `UCSC-C220-M5` - The upgrade on all C220-M5 servers claimed in setup.\n* `UCSC-C220-M4` - The upgrade on all C220-M4 servers claimed in setup.\n* `UCSC-C240-M4` - The upgrade on all C240-M4 servers claimed in setup.\n* `UCSC-C460-M4` - The upgrade on all C460-M4 servers claimed in setup.\n* `UCSC-C240-M5` - The upgrade on all C240-M5 servers claimed in setup.\n* `UCSC-C480-M5` - The upgrade on all C480-M5 servers claimed in setup.\n* `UCSB-B200-M5` - The upgrade on all B200-M5 servers claimed in setup.\n* `UCSB-B480-M5` - The upgrade on all B480-M5 servers claimed in setup.\n* `UCSC-C220-M6` - The upgrade on all C220-M6 servers claimed in setup.\n* `UCSC-C240-M6` - The upgrade on all C240-M6 servers claimed in setup.\n* `UCSC-C225-M6` - The upgrade on all C225-M6 servers claimed in setup.\n* `UCSC-C245-M6` - The upgrade on all C245-M6 servers claimed in setup.\n* `UCSB-B200-M6` - The upgrade on all B200-M6 servers claimed in setup.\n* `UCSX-210C-M6` - The upgrade on all 210C-M6 servers claimed in setup.\n* `UCSX-210C-M7` - The upgrade on all 210C-M7 servers claimed in setup.\n* `UCSC-C220-M7` - The upgrade on all C220-M7 servers claimed in setup.\n* `UCSC-C240-M7` - The upgrade on all C240-M7 servers claimed in setup.\n* `UCSC-C125` - The upgrade on all C125 servers claimed in setup.\n* `UCSX-410C-M7` - The upgrade on all 410C-M7 servers claimed in setup."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareModelBundleVersion.ModelFamilyEnum ModelFamily
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareModelBundleVersion.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.FirmwareModelBundleVersion initObject = new Intersight.Model.FirmwareModelBundleVersion();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BundleVersion"))
            {
                initObject.BundleVersion = this.BundleVersion;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ModelFamily"))
            {
                initObject.ModelFamily = this.ModelFamily;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize FirmwareMswitchDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightFirmwareMswitchDescriptor")]
    public class InitializeIntersightFirmwareMswitchDescriptor : PSCmdlet
    {
        public InitializeIntersightFirmwareMswitchDescriptor()
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
        /// <para type="description">"The brand string of the endpoint for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string BrandString
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to capabilityCapability resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.CapabilityCapabilityRelationship> Capabilities
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareMswitchDescriptor.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Detailed information about the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The label type for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Label
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The model of the endpoint, for which this capability information is applicable."</para>
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareMswitchDescriptor.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The revision for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Revision
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
        /// <para type="description">"The vendor of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Vendor
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The firmware or software version of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Version
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.FirmwareMswitchDescriptor initObject = new Intersight.Model.FirmwareMswitchDescriptor();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BrandString"))
            {
                initObject.BrandString = this.BrandString;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Capabilities"))
            {
                initObject.Capabilities = this.Capabilities;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Label"))
            {
                initObject.Label = this.Label;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Model"))
            {
                initObject.Model = this.Model;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Revision"))
            {
                initObject.Revision = this.Revision;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Vendor"))
            {
                initObject.Vendor = this.Vendor;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Version"))
            {
                initObject._Version = this.Version;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize FirmwareNetworkShare.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightFirmwareNetworkShare")]
    public class InitializeIntersightFirmwareNetworkShare : PSCmdlet
    {
        public InitializeIntersightFirmwareNetworkShare()
        {
            ClassId = FirmwareNetworkShare.ClassIdEnum.FirmwareNetworkShare;
            MapType = FirmwareNetworkShare.MapTypeEnum.Nfs;
            ObjectType = FirmwareNetworkShare.ObjectTypeEnum.FirmwareNetworkShare;
            Upgradeoption = FirmwareNetworkShare.UpgradeoptionEnum.NwUpgradeFull;

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
        /// <para type="description">"CIFS file server option for network share upgrade."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.FirmwareCifsServer CifsServer
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareNetworkShare.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"HTTP (for WWW) file server option for network share upgrade."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.FirmwareHttpServer HttpServer
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"File server protocols such as CIFS, NFS, WWW for HTTP (S) that hosts the image.\n* `nfs` - File server protocol used is NFS.\n* `cifs` - File server protocol used is CIFS.\n* `www` - File server protocol used is WWW."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareNetworkShare.MapTypeEnum MapType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"NFS file server option for network share upgrade."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.FirmwareNfsServer NfsServer
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareNetworkShare.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Password as configured on the file server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Password
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Option to control the upgrade operation. Some examples, 1) nw_upgrade_mount_only - mount the image from a file server and run the upgrade on the next server boot and 2) nw_upgrade_full - mount the image and immediately run the upgrade.\n* `nw_upgrade_full` - Network upgrade option for full upgrade.\n* `nw_upgrade_mount_only` - Network upgrade mount only."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareNetworkShare.UpgradeoptionEnum Upgradeoption
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Username as configured on the file server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Username
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.FirmwareNetworkShare initObject = new Intersight.Model.FirmwareNetworkShare();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CifsServer"))
            {
                initObject.CifsServer = this.CifsServer;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("HttpServer"))
            {
                initObject.HttpServer = this.HttpServer;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MapType"))
            {
                initObject.MapType = this.MapType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NfsServer"))
            {
                initObject.NfsServer = this.NfsServer;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Password"))
            {
                initObject.Password = this.Password;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Upgradeoption"))
            {
                initObject.Upgradeoption = this.Upgradeoption;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Username"))
            {
                initObject.Username = this.Username;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize FirmwareNfsServer.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightFirmwareNfsServer")]
    public class InitializeIntersightFirmwareNfsServer : PSCmdlet
    {
        public InitializeIntersightFirmwareNfsServer()
        {
            ClassId = FirmwareNfsServer.ClassIdEnum.FirmwareNfsServer;
            ObjectType = FirmwareNfsServer.ObjectTypeEnum.FirmwareNfsServer;

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

        public FirmwareNfsServer.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The location to the image file. The accepted format is IP-or-hostname/folder1/folder2/.../imageFile."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string FileLocation
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Mount option as configured on the NFS Server. For example:nolock."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string MountOptions
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareNfsServer.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.FirmwareNfsServer initObject = new Intersight.Model.FirmwareNfsServer();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("FileLocation"))
            {
                initObject.FileLocation = this.FileLocation;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MountOptions"))
            {
                initObject.MountOptions = this.MountOptions;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize FirmwareNxosDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightFirmwareNxosDescriptor")]
    public class InitializeIntersightFirmwareNxosDescriptor : PSCmdlet
    {
        public InitializeIntersightFirmwareNxosDescriptor()
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
        /// <para type="description">"The brand string of the endpoint for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string BrandString
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to capabilityCapability resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.CapabilityCapabilityRelationship> Capabilities
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareNxosDescriptor.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Detailed information about the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The label type for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Label
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The model of the endpoint, for which this capability information is applicable."</para>
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareNxosDescriptor.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The revision for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Revision
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
        /// <para type="description">"The vendor of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Vendor
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The firmware or software version of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Version
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.FirmwareNxosDescriptor initObject = new Intersight.Model.FirmwareNxosDescriptor();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BrandString"))
            {
                initObject.BrandString = this.BrandString;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Capabilities"))
            {
                initObject.Capabilities = this.Capabilities;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Label"))
            {
                initObject.Label = this.Label;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Model"))
            {
                initObject.Model = this.Model;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Revision"))
            {
                initObject.Revision = this.Revision;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Vendor"))
            {
                initObject.Vendor = this.Vendor;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Version"))
            {
                initObject._Version = this.Version;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize FirmwarePcieDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightFirmwarePcieDescriptor")]
    public class InitializeIntersightFirmwarePcieDescriptor : PSCmdlet
    {
        public InitializeIntersightFirmwarePcieDescriptor()
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
        /// <para type="description">"The brand string of the endpoint for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string BrandString
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to capabilityCapability resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.CapabilityCapabilityRelationship> Capabilities
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwarePcieDescriptor.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Detailed information about the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The label type for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Label
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The model of the endpoint, for which this capability information is applicable."</para>
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwarePcieDescriptor.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The revision for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Revision
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
        /// <para type="description">"The vendor of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Vendor
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The firmware or software version of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Version
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.FirmwarePcieDescriptor initObject = new Intersight.Model.FirmwarePcieDescriptor();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BrandString"))
            {
                initObject.BrandString = this.BrandString;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Capabilities"))
            {
                initObject.Capabilities = this.Capabilities;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Label"))
            {
                initObject.Label = this.Label;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Model"))
            {
                initObject.Model = this.Model;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Revision"))
            {
                initObject.Revision = this.Revision;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Vendor"))
            {
                initObject.Vendor = this.Vendor;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Version"))
            {
                initObject._Version = this.Version;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize FirmwarePolicy.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightFirmwarePolicy")]
    public class InitializeIntersightFirmwarePolicy : PSCmdlet
    {
        public InitializeIntersightFirmwarePolicy()
        {
            ClassId = FirmwarePolicy.ClassIdEnum.FirmwarePolicy;
            ObjectType = FirmwarePolicy.ObjectTypeEnum.FirmwarePolicy;
            TargetPlatform = FirmwarePolicy.TargetPlatformEnum.Standalone;

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

        public FirmwarePolicy.ClassIdEnum ClassId
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<FirmwarePolicy.ExcludeComponentListEnum> ExcludeComponentList
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.FirmwareModelBundleVersion> ModelBundleCombo
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

        public FirmwarePolicy.ObjectTypeEnum ObjectType
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
        // <summary>
        /// <para type="description">"The target platform on which the policy to be applied. Either standalone or connected.\n* `Standalone` - Servers which are operating in standalone mode i.e. not connected to a Fabric Interconnected.\n* `FIAttached` - Servers which are connected to a Fabric Interconnect that is managed by Intersight."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwarePolicy.TargetPlatformEnum TargetPlatform
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.FirmwarePolicy initObject = new Intersight.Model.FirmwarePolicy();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ExcludeComponentList"))
            {
                initObject.ExcludeComponentList = this.ExcludeComponentList;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ModelBundleCombo"))
            {
                initObject.ModelBundleCombo = this.ModelBundleCombo;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("TargetPlatform"))
            {
                initObject.TargetPlatform = this.TargetPlatform;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize FirmwarePsuDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightFirmwarePsuDescriptor")]
    public class InitializeIntersightFirmwarePsuDescriptor : PSCmdlet
    {
        public InitializeIntersightFirmwarePsuDescriptor()
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
        /// <para type="description">"The brand string of the endpoint for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string BrandString
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to capabilityCapability resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.CapabilityCapabilityRelationship> Capabilities
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwarePsuDescriptor.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Detailed information about the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The label type for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Label
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The model of the endpoint, for which this capability information is applicable."</para>
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwarePsuDescriptor.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The revision for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Revision
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
        /// <para type="description">"The vendor of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Vendor
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The firmware or software version of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Version
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.FirmwarePsuDescriptor initObject = new Intersight.Model.FirmwarePsuDescriptor();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BrandString"))
            {
                initObject.BrandString = this.BrandString;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Capabilities"))
            {
                initObject.Capabilities = this.Capabilities;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Label"))
            {
                initObject.Label = this.Label;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Model"))
            {
                initObject.Model = this.Model;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Revision"))
            {
                initObject.Revision = this.Revision;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Vendor"))
            {
                initObject.Vendor = this.Vendor;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Version"))
            {
                initObject._Version = this.Version;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize FirmwareRunningFirmware.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightFirmwareRunningFirmware")]
    public class InitializeIntersightFirmwareRunningFirmware : PSCmdlet
    {
        public InitializeIntersightFirmwareRunningFirmware()
        {
            ClassId = FirmwareRunningFirmware.ClassIdEnum.FirmwareRunningFirmware;
            ObjectType = FirmwareRunningFirmware.ObjectTypeEnum.FirmwareRunningFirmware;

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

        public FirmwareRunningFirmware.ClassIdEnum ClassId
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
        /// <para type="description">"An array of relationships to networkElement resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.NetworkElementRelationship> NetworkElements
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareRunningFirmware.ObjectTypeEnum ObjectType
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
            Intersight.Model.FirmwareRunningFirmware initObject = new Intersight.Model.FirmwareRunningFirmware();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NetworkElements"))
            {
                initObject.NetworkElements = this.NetworkElements;
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
    /// <para type="synopsis">This is the cmdlet to Initialize FirmwareSasExpanderDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightFirmwareSasExpanderDescriptor")]
    public class InitializeIntersightFirmwareSasExpanderDescriptor : PSCmdlet
    {
        public InitializeIntersightFirmwareSasExpanderDescriptor()
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
        /// <para type="description">"The brand string of the endpoint for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string BrandString
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to capabilityCapability resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.CapabilityCapabilityRelationship> Capabilities
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareSasExpanderDescriptor.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Detailed information about the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The label type for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Label
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The model of the endpoint, for which this capability information is applicable."</para>
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareSasExpanderDescriptor.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The revision for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Revision
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
        /// <para type="description">"The vendor of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Vendor
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The firmware or software version of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Version
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.FirmwareSasExpanderDescriptor initObject = new Intersight.Model.FirmwareSasExpanderDescriptor();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BrandString"))
            {
                initObject.BrandString = this.BrandString;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Capabilities"))
            {
                initObject.Capabilities = this.Capabilities;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Label"))
            {
                initObject.Label = this.Label;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Model"))
            {
                initObject.Model = this.Model;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Revision"))
            {
                initObject.Revision = this.Revision;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Vendor"))
            {
                initObject.Vendor = this.Vendor;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Version"))
            {
                initObject._Version = this.Version;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize FirmwareServerConfigurationUtilityDistributable.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightFirmwareServerConfigurationUtilityDistributable")]
    public class InitializeIntersightFirmwareServerConfigurationUtilityDistributable : PSCmdlet
    {
        public InitializeIntersightFirmwareServerConfigurationUtilityDistributable()
        {
            ClassId = FirmwareServerConfigurationUtilityDistributable.ClassIdEnum.FirmwareServerConfigurationUtilityDistributable;
            ImportAction = FirmwareServerConfigurationUtilityDistributable.ImportActionEnum.None;
            ObjectType = FirmwareServerConfigurationUtilityDistributable.ObjectTypeEnum.FirmwareServerConfigurationUtilityDistributable;

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
        /// <para type="description">"A reference to a softwarerepositoryCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.SoftwarerepositoryCatalogRelationship Catalog
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareServerConfigurationUtilityDistributable.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.FirmwareComponentMeta> ComponentMeta
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"User provided description about the file. Cisco provided description for image inventoried from a Cisco repository."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to firmwareDistributableMeta resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.FirmwareDistributableMetaRelationship> DistributableMetas
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The type of image which the distributable falls into according to the component it can upgrade. For e.g.; Standalone server, Intersight managed server, UCS Managed Fabric Interconnect. The field is used in private appliance mode, where image does not have description populated from CCO."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ImageType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The action to be performed on the imported file. If 'PreCache' is set, the image will be cached in Appliance. Applicable in Intersight appliance deployment. If 'Evict' is set, the cached file will be removed. Applicable in Intersight appliance deployment. If 'GeneratePreSignedUploadUrl' is set, generates pre signed URL (s) for the file to be imported into the repository. Applicable for local machine source. The URL (s) will be populated under LocalMachine file server. If 'CompleteImportProcess' is set, the ImportState is marked as 'Imported'. Applicable for local machine source. If 'Cancel' is set, the ImportState is marked as 'Failed'. Applicable for local machine source.\n* `None` - No action should be taken on the imported file.\n* `GeneratePreSignedUploadUrl` - Generate pre signed URL of file for importing into the repository.\n* `GeneratePreSignedDownloadUrl` - Generate pre signed URL of file in the repository to download.\n* `CompleteImportProcess` - Mark that the import process of the file into the repository is complete.\n* `MarkImportFailed` - Mark to indicate that the import process of the file into the repository failed.\n* `PreCache` - Cache the file into the Intersight Appliance.\n* `Cancel` - The cancel import process for the file into the repository.\n* `Extract` - The action to extract the file in the external repository.\n* `Evict` - Evict the cached file from the Intersight Appliance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareServerConfigurationUtilityDistributable.ImportActionEnum ImportAction
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The MD5 ETag for a file that is stored in Intersight repository or in the appliance cache. Warning - MD5 is currently broken and this will be migrated to SHA shortly."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Md5eTag
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The md5sum checksum of the file. This information is available for all Cisco distributed images and files imported to the local repository."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Md5sum
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The mdfid of the image provided by cisco.com."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Mdfid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The endpoint model for which this firmware image is applicable."</para>
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
        /// <para type="description">"The name of the file. It is populated as part of the image import operation."</para>
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

        public FirmwareServerConfigurationUtilityDistributable.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The build which is recommended by Cisco."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string RecommendedBuild
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a softwarerepositoryRelease resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.SoftwarerepositoryReleaseRelationship Release
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The date on which the file was released or distributed by its vendor."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime ReleaseDate
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The url for the release notes of this image."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ReleaseNotesUrl
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The sha512sum of the file. This information is available for all Cisco distributed images and files imported to the local repository."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Sha512sum
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The size (in bytes) of the file. This information is available for all Cisco distributed images and files imported to the local repository."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Size
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The software advisory, if any, provided by the vendor for this file."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SoftwareAdvisoryUrl
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Location of the file in an external repository."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.SoftwarerepositoryFileServer Source
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> SupportedModels
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
        /// <para type="description">"The vendor or publisher of this file."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Vendor
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Vendor provided version for the file."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Version
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.FirmwareServerConfigurationUtilityDistributable initObject = new Intersight.Model.FirmwareServerConfigurationUtilityDistributable();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Catalog"))
            {
                initObject.Catalog = this.Catalog;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ComponentMeta"))
            {
                initObject.ComponentMeta = this.ComponentMeta;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DistributableMetas"))
            {
                initObject.DistributableMetas = this.DistributableMetas;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ImageType"))
            {
                initObject.ImageType = this.ImageType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ImportAction"))
            {
                initObject.ImportAction = this.ImportAction;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Md5eTag"))
            {
                initObject.Md5eTag = this.Md5eTag;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Md5sum"))
            {
                initObject.Md5sum = this.Md5sum;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Mdfid"))
            {
                initObject.Mdfid = this.Mdfid;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("RecommendedBuild"))
            {
                initObject.RecommendedBuild = this.RecommendedBuild;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Release"))
            {
                initObject.Release = this.Release;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ReleaseDate"))
            {
                initObject.ReleaseDate = this.ReleaseDate;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ReleaseNotesUrl"))
            {
                initObject.ReleaseNotesUrl = this.ReleaseNotesUrl;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Sha512sum"))
            {
                initObject.Sha512sum = this.Sha512sum;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Size"))
            {
                initObject.Size = this.Size;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SoftwareAdvisoryUrl"))
            {
                initObject.SoftwareAdvisoryUrl = this.SoftwareAdvisoryUrl;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Source"))
            {
                initObject.Source = this.Source;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SupportedModels"))
            {
                initObject.SupportedModels = this.SupportedModels;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Vendor"))
            {
                initObject.Vendor = this.Vendor;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Version"))
            {
                initObject._Version = this.Version;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize FirmwareServerUpgradeImpact.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightFirmwareServerUpgradeImpact")]
    public class InitializeIntersightFirmwareServerUpgradeImpact : PSCmdlet
    {
        public InitializeIntersightFirmwareServerUpgradeImpact()
        {
            ClassId = FirmwareServerUpgradeImpact.ClassIdEnum.FirmwareServerUpgradeImpact;
            ComputationStatusDetail = FirmwareServerUpgradeImpact.ComputationStatusDetailEnum.Inprogress;
            ImpactType = FirmwareServerUpgradeImpact.ImpactTypeEnum.NoReboot;
            ObjectType = FirmwareServerUpgradeImpact.ObjectTypeEnum.FirmwareServerUpgradeImpact;
            VersionImpact = FirmwareServerUpgradeImpact.VersionImpactEnum.None;

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

        public FirmwareServerUpgradeImpact.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Details for the error that occurred during the reboot validation analysis."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ComputationError
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The computation status of the estimate operation for a component.\n* `Inprogress` - Upgrade impact calculation is in progress.\n* `Completed` - Upgrade impact calculation is completed.\n* `Unavailable` - Upgrade impact is not available since the image is not present in the Fabric Interconnect.\n* `Failed` - Upgrade impact is not available due to an unknown error."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareServerUpgradeImpact.ComputationStatusDetailEnum ComputationStatusDetail
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The endpoint type or name."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string DomainName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a REST resource, uniquely identified by object type and MOID."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string EndPoint
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The current firmware version of the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string FirmwareVersion
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.FirmwareComponentImpact> ImpactDetail
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The impact type of the endpoint, whether a reboot is required or not.\n* `NoReboot` - A reboot is not required for the endpoint after upgrade.\n* `Reboot` - A reboot is required to the endpoint after upgrade."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareServerUpgradeImpact.ImpactTypeEnum ImpactType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The model details of the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Model
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the server impacted by the upgrade."</para>
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

        public FirmwareServerUpgradeImpact.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The target firmware version of the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string TargetFirmwareVersion
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Details about the server which will be impacted by the upgrade."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string UserLabel
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The change of version impact for the endpoint.\n* `None` - No change in version for the component.\n* `Upgrade` - The component will be upgraded.\n* `Downgrade` - The component will be downgraded."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareServerUpgradeImpact.VersionImpactEnum VersionImpact
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.FirmwareServerUpgradeImpact initObject = new Intersight.Model.FirmwareServerUpgradeImpact();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ComputationError"))
            {
                initObject.ComputationError = this.ComputationError;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ComputationStatusDetail"))
            {
                initObject.ComputationStatusDetail = this.ComputationStatusDetail;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DomainName"))
            {
                initObject.DomainName = this.DomainName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EndPoint"))
            {
                initObject.EndPoint = this.EndPoint;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FirmwareVersion"))
            {
                initObject.FirmwareVersion = this.FirmwareVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ImpactDetail"))
            {
                initObject.ImpactDetail = this.ImpactDetail;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ImpactType"))
            {
                initObject.ImpactType = this.ImpactType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Model"))
            {
                initObject.Model = this.Model;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("TargetFirmwareVersion"))
            {
                initObject.TargetFirmwareVersion = this.TargetFirmwareVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UserLabel"))
            {
                initObject.UserLabel = this.UserLabel;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VersionImpact"))
            {
                initObject.VersionImpact = this.VersionImpact;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize FirmwareStorageControllerDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightFirmwareStorageControllerDescriptor")]
    public class InitializeIntersightFirmwareStorageControllerDescriptor : PSCmdlet
    {
        public InitializeIntersightFirmwareStorageControllerDescriptor()
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
        /// <para type="description">"The brand string of the endpoint for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string BrandString
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to capabilityCapability resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.CapabilityCapabilityRelationship> Capabilities
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareStorageControllerDescriptor.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Detailed information about the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The label type for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Label
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The model of the endpoint, for which this capability information is applicable."</para>
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareStorageControllerDescriptor.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The revision for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Revision
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
        /// <para type="description">"The vendor of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Vendor
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The firmware or software version of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Version
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.FirmwareStorageControllerDescriptor initObject = new Intersight.Model.FirmwareStorageControllerDescriptor();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BrandString"))
            {
                initObject.BrandString = this.BrandString;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Capabilities"))
            {
                initObject.Capabilities = this.Capabilities;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Label"))
            {
                initObject.Label = this.Label;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Model"))
            {
                initObject.Model = this.Model;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Revision"))
            {
                initObject.Revision = this.Revision;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Vendor"))
            {
                initObject.Vendor = this.Vendor;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Version"))
            {
                initObject._Version = this.Version;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize FirmwareSwitchUpgrade.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightFirmwareSwitchUpgrade")]
    public class InitializeIntersightFirmwareSwitchUpgrade : PSCmdlet
    {
        public InitializeIntersightFirmwareSwitchUpgrade()
        {
            ClassId = FirmwareSwitchUpgrade.ClassIdEnum.FirmwareSwitchUpgrade;
            ObjectType = FirmwareSwitchUpgrade.ObjectTypeEnum.FirmwareSwitchUpgrade;
            Status = FirmwareSwitchUpgrade.StatusEnum.NONE;
            UpgradeType = FirmwareSwitchUpgrade.UpgradeTypeEnum.DirectUpgrade;

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

        public FirmwareSwitchUpgrade.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Direct download options in case the upgradeType is direct download based upgrade."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.FirmwareDirectDownload DirectDownload
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a firmwareDistributable resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.FirmwareDistributableRelationship Distributable
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The flag to enable or disable fabric evacuation during the switch firmware upgrade. In case of IMM, it is mandatory to have the Fabric Interconnects associated with domain profile for fabric evacuation to happen."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool EnableFabricEvacuation
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Location of the image in user software repository."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.SoftwarerepositoryFileServer FileServer
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
        /// <para type="description">"An array of relationships to networkElement resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.NetworkElementRelationship> NetworkElements
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Deprecated (Use 'fileServer' property). Network share options in case of the upgradeType is network share based upgrade."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.FirmwareNetworkShare NetworkShare
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareSwitchUpgrade.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a softwarerepositoryRelease resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.SoftwarerepositoryReleaseRelationship Release
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"User has the option to skip the estimate impact calculation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool SkipEstimateImpact
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Status of the upgrade operation.\n* `NONE` - Upgrade status is not populated.\n* `IN_PROGRESS` - The upgrade is in progress.\n* `SUCCESSFUL` - The upgrade successfully completed.\n* `FAILED` - The upgrade shows failed status.\n* `TERMINATED` - The upgrade has been terminated."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareSwitchUpgrade.StatusEnum Status
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
        /// <para type="description">"Desired upgrade mode to choose either direct download based upgrade or network share upgrade.\n* `direct_upgrade` - Upgrade mode is direct download.\n* `network_upgrade` - Upgrade mode is network upgrade."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareSwitchUpgrade.UpgradeTypeEnum UpgradeType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.FirmwareSwitchUpgrade initObject = new Intersight.Model.FirmwareSwitchUpgrade();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("DirectDownload"))
            {
                initObject.DirectDownload = this.DirectDownload;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Distributable"))
            {
                initObject.Distributable = this.Distributable;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EnableFabricEvacuation"))
            {
                initObject.EnableFabricEvacuation = this.EnableFabricEvacuation;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FileServer"))
            {
                initObject.FileServer = this.FileServer;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NetworkElements"))
            {
                initObject.NetworkElements = this.NetworkElements;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NetworkShare"))
            {
                initObject.NetworkShare = this.NetworkShare;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Release"))
            {
                initObject.Release = this.Release;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SkipEstimateImpact"))
            {
                initObject.SkipEstimateImpact = this.SkipEstimateImpact;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Status"))
            {
                initObject.Status = this.Status;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UpgradeType"))
            {
                initObject.UpgradeType = this.UpgradeType;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize FirmwareUnsupportedVersionUpgrade.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightFirmwareUnsupportedVersionUpgrade")]
    public class InitializeIntersightFirmwareUnsupportedVersionUpgrade : PSCmdlet
    {
        public InitializeIntersightFirmwareUnsupportedVersionUpgrade()
        {
            ClassId = FirmwareUnsupportedVersionUpgrade.ClassIdEnum.FirmwareUnsupportedVersionUpgrade;
            ObjectType = FirmwareUnsupportedVersionUpgrade.ObjectTypeEnum.FirmwareUnsupportedVersionUpgrade;
            UpgradeStatus = FirmwareUnsupportedVersionUpgrade.UpgradeStatusEnum.None;

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
        /// <para type="description">"The checksum of the downloaded file as calculated by the download plugin after successfully downloading a file."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.ConnectorFileChecksum Checksum
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareUnsupportedVersionUpgrade.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a firmwareDistributable resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.FirmwareDistributableRelationship Distributable
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Any error encountered. Set to empty when download is in progress or completed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string DownloadError
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The download progress of the file represented as a percentage between 0% and 100%. If progress reporting is not possible, a value of -1 is sent."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long DownloadProgress
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of retries the plugin attempted before succeeding or failing the download."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long DownloadRetries
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

        public FirmwareUnsupportedVersionUpgrade.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a equipmentPhysicalIdentity resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.EquipmentPhysicalIdentityRelationship PhysicalIdentity
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The sha256checksum of the downloaded file as calculated by the download plugin after successfully downloading a file."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public byte[] Sha256checksum
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
        /// <para type="description">"Workflow status of firmware upgrade.\n* `None` - Upgrade status is none when upgrade is in progress.\n* `Completed` - Upgrade completed successfully.\n* `Failed` - Upgrade status is failed when upgrade has failed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareUnsupportedVersionUpgrade.UpgradeStatusEnum UpgradeStatus
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.FirmwareUnsupportedVersionUpgrade initObject = new Intersight.Model.FirmwareUnsupportedVersionUpgrade();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Checksum"))
            {
                initObject.Checksum = this.Checksum;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Distributable"))
            {
                initObject.Distributable = this.Distributable;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DownloadError"))
            {
                initObject.DownloadError = this.DownloadError;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DownloadProgress"))
            {
                initObject.DownloadProgress = this.DownloadProgress;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DownloadRetries"))
            {
                initObject.DownloadRetries = this.DownloadRetries;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("PhysicalIdentity"))
            {
                initObject.PhysicalIdentity = this.PhysicalIdentity;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Sha256checksum"))
            {
                initObject.Sha256checksum = this.Sha256checksum;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UpgradeStatus"))
            {
                initObject.UpgradeStatus = this.UpgradeStatus;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize FirmwareUpgrade.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightFirmwareUpgrade")]
    public class InitializeIntersightFirmwareUpgrade : PSCmdlet
    {
        public InitializeIntersightFirmwareUpgrade()
        {
            ClassId = FirmwareUpgrade.ClassIdEnum.FirmwareUpgrade;
            ObjectType = FirmwareUpgrade.ObjectTypeEnum.FirmwareUpgrade;
            Status = FirmwareUpgrade.StatusEnum.NONE;
            UpgradeTriggerMethod = FirmwareUpgrade.UpgradeTriggerMethodEnum.None;
            UpgradeType = FirmwareUpgrade.UpgradeTypeEnum.DirectUpgrade;

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

        public FirmwareUpgrade.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Direct download options in case the upgradeType is direct download based upgrade."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.FirmwareDirectDownload DirectDownload
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a firmwareDistributable resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.FirmwareDistributableRelationship Distributable
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<FirmwareUpgrade.ExcludeComponentListEnum> ExcludeComponentList
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The components PIDs which are to be excluded for server firmware upgrade."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.FirmwareExcludeComponentPidListType ExcludeComponentPidList
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Location of the image in user software repository."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.SoftwarerepositoryFileServer FileServer
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
        /// <para type="description">"Deprecated (Use 'fileServer' property). Network share options in case of the upgradeType is network share based upgrade."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.FirmwareNetworkShare NetworkShare
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareUpgrade.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a softwarerepositoryRelease resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.SoftwarerepositoryReleaseRelationship Release
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a computePhysical resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.ComputePhysicalRelationship Server
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"User has the option to skip the estimate impact calculation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool SkipEstimateImpact
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Status of the upgrade operation.\n* `NONE` - Upgrade status is not populated.\n* `IN_PROGRESS` - The upgrade is in progress.\n* `SUCCESSFUL` - The upgrade successfully completed.\n* `FAILED` - The upgrade shows failed status.\n* `TERMINATED` - The upgrade has been terminated."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareUpgrade.StatusEnum Status
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
        /// <para type="description">"The source that triggered the upgrade. Either via profile or traditional way.\n* `none` - Upgrade is invoked within the service.\n* `profileTrigger` - Upgrade is invoked from a profile deployment."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareUpgrade.UpgradeTriggerMethodEnum UpgradeTriggerMethod
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Desired upgrade mode to choose either direct download based upgrade or network share upgrade.\n* `direct_upgrade` - Upgrade mode is direct download.\n* `network_upgrade` - Upgrade mode is network upgrade."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareUpgrade.UpgradeTypeEnum UpgradeType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.FirmwareUpgrade initObject = new Intersight.Model.FirmwareUpgrade();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("DirectDownload"))
            {
                initObject.DirectDownload = this.DirectDownload;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Distributable"))
            {
                initObject.Distributable = this.Distributable;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ExcludeComponentList"))
            {
                initObject.ExcludeComponentList = this.ExcludeComponentList;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ExcludeComponentPidList"))
            {
                initObject.ExcludeComponentPidList = this.ExcludeComponentPidList;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FileServer"))
            {
                initObject.FileServer = this.FileServer;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NetworkShare"))
            {
                initObject.NetworkShare = this.NetworkShare;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Release"))
            {
                initObject.Release = this.Release;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Server"))
            {
                initObject.Server = this.Server;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SkipEstimateImpact"))
            {
                initObject.SkipEstimateImpact = this.SkipEstimateImpact;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Status"))
            {
                initObject.Status = this.Status;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UpgradeTriggerMethod"))
            {
                initObject.UpgradeTriggerMethod = this.UpgradeTriggerMethod;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UpgradeType"))
            {
                initObject.UpgradeType = this.UpgradeType;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize FirmwareUpgradeImpact.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightFirmwareUpgradeImpact")]
    public class InitializeIntersightFirmwareUpgradeImpact : PSCmdlet
    {
        public InitializeIntersightFirmwareUpgradeImpact()
        {
            ClassId = FirmwareUpgradeImpact.ClassIdEnum.FirmwareUpgradeImpact;
            ComputationState = FirmwareUpgradeImpact.ComputationStateEnum.Inprogress;
            ObjectType = FirmwareUpgradeImpact.ObjectTypeEnum.FirmwareUpgradeImpact;
            Summary = FirmwareUpgradeImpact.SummaryEnum.Basic;

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
        /// <para type="description">"An array of relationships to equipmentChassis resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.EquipmentChassisRelationship> Chassis
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareUpgradeImpact.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<FirmwareUpgradeImpact.ComponentsEnum> Components
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Captures the status of an upgrade impact calculation. Indicates whether the calculation is complete, in progress or the calculation is impossible due to the absence of the target image on the endpoint.\n* `Inprogress` - Upgrade impact calculation is in progress.\n* `Completed` - Upgrade impact calculation is completed.\n* `Unavailable` - Upgrade impact is not available since image is not present in FI."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareUpgradeImpact.ComputationStateEnum ComputationState
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a firmwareDistributable resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.FirmwareDistributableRelationship Distributable
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<FirmwareUpgradeImpact.ExcludeComponentsEnum> ExcludeComponents
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.FirmwareBaseImpact> Impacts
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
        /// <para type="description">"An array of relationships to networkElement resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.NetworkElementRelationship> NetworkElements
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareUpgradeImpact.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a softwarerepositoryRelease resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.SoftwarerepositoryReleaseRelationship Release
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to computePhysical resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.ComputePhysicalRelationship> Server
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The summary on the component or components getting impacted by the upgrade.\n* `Basic` - Summary of a single instance involved in the upgrade operation.\n* `Detail` - Summary of the collection of single instances for a complex component involved in the upgrade operation. For example, in case of a server upgrade, a detailed summary indicates impact of all the single instances which are part of the server, such as storage controller, drives, and BIOS."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareUpgradeImpact.SummaryEnum Summary
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
            Intersight.Model.FirmwareUpgradeImpact initObject = new Intersight.Model.FirmwareUpgradeImpact();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Chassis"))
            {
                initObject.Chassis = this.Chassis;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Components"))
            {
                initObject.Components = this.Components;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ComputationState"))
            {
                initObject.ComputationState = this.ComputationState;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Distributable"))
            {
                initObject.Distributable = this.Distributable;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ExcludeComponents"))
            {
                initObject.ExcludeComponents = this.ExcludeComponents;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Impacts"))
            {
                initObject.Impacts = this.Impacts;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NetworkElements"))
            {
                initObject.NetworkElements = this.NetworkElements;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Release"))
            {
                initObject.Release = this.Release;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Server"))
            {
                initObject.Server = this.Server;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Summary"))
            {
                initObject.Summary = this.Summary;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize FirmwareUpgradeImpactStatus.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightFirmwareUpgradeImpactStatus")]
    public class InitializeIntersightFirmwareUpgradeImpactStatus : PSCmdlet
    {
        public InitializeIntersightFirmwareUpgradeImpactStatus()
        {
            ClassId = FirmwareUpgradeImpactStatus.ClassIdEnum.FirmwareUpgradeImpactStatus;
            ComputationState = FirmwareUpgradeImpactStatus.ComputationStateEnum.Inprogress;
            ObjectType = FirmwareUpgradeImpactStatus.ObjectTypeEnum.FirmwareUpgradeImpactStatus;
            Summary = FirmwareUpgradeImpactStatus.SummaryEnum.Basic;

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

        public FirmwareUpgradeImpactStatus.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<FirmwareUpgradeImpactStatus.ComponentsEnum> Components
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Captures the status of an upgrade impact calculation. Indicates whether the calculation is complete, in progress or the calculation is impossible due to the absence of the target image on the endpoint.\n* `Inprogress` - Upgrade impact calculation is in progress.\n* `Completed` - Upgrade impact calculation is completed.\n* `Unavailable` - Upgrade impact is not available since image is not present in FI."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareUpgradeImpactStatus.ComputationStateEnum ComputationState
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<FirmwareUpgradeImpactStatus.ExcludeComponentsEnum> ExcludeComponents
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.FirmwareBaseImpact> Impacts
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

        public FirmwareUpgradeImpactStatus.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The summary on the component or components getting impacted by the upgrade.\n* `Basic` - Summary of a single instance involved in the upgrade operation.\n* `Detail` - Summary of the collection of single instances for a complex component involved in the upgrade operation. For example, in case of a server upgrade, a detailed summary indicates impact of all the single instances which are part of the server, such as storage controller, drives, and BIOS."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareUpgradeImpactStatus.SummaryEnum Summary
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
            Intersight.Model.FirmwareUpgradeImpactStatus initObject = new Intersight.Model.FirmwareUpgradeImpactStatus();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Components"))
            {
                initObject.Components = this.Components;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ComputationState"))
            {
                initObject.ComputationState = this.ComputationState;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ExcludeComponents"))
            {
                initObject.ExcludeComponents = this.ExcludeComponents;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Impacts"))
            {
                initObject.Impacts = this.Impacts;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Summary"))
            {
                initObject.Summary = this.Summary;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize FirmwareUpgradeStatus.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightFirmwareUpgradeStatus")]
    public class InitializeIntersightFirmwareUpgradeStatus : PSCmdlet
    {
        public InitializeIntersightFirmwareUpgradeStatus()
        {
            ClassId = FirmwareUpgradeStatus.ClassIdEnum.FirmwareUpgradeStatus;
            EpPowerStatus = FirmwareUpgradeStatus.EpPowerStatusEnum.None;
            InitialPowerStatus = FirmwareUpgradeStatus.InitialPowerStatusEnum.None;
            ObjectType = FirmwareUpgradeStatus.ObjectTypeEnum.FirmwareUpgradeStatus;
            Overallstatus = FirmwareUpgradeStatus.OverallstatusEnum.None;
            PendingType = FirmwareUpgradeStatus.PendingTypeEnum.None;

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
        /// <para type="description">"The checksum of the downloaded file as calculated by the download plugin after successfully downloading a file."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.ConnectorFileChecksum Checksum
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareUpgradeStatus.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Any error encountered. Set to empty when download is in progress or completed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string DownloadError
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The message from the endpoint during the download."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string DownloadMessage
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The percentage of the image downloaded in the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long DownloadPercentage
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The download progress of the file represented as a percentage between 0% and 100%. If progress reporting is not possible, a value of -1 is sent."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long DownloadProgress
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of retries the plugin attempted before succeeding or failing the download."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long DownloadRetries
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The image download stages. Example:downloading, flashing."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string DownloadStage
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The server power status after the upgrade request is submitted in the endpoint.\n* `none` - Server power status is none.\n* `powered on` - Server power status is powered on.\n* `powered off` - Server power status is powered off."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareUpgradeStatus.EpPowerStatusEnum EpPowerStatus
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The server power status before the upgrade request is submitted in the endpoint.\n* `none` - Server power status is none.\n* `powered on` - Server power status is powered on.\n* `powered off` - Server power status is powered off."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareUpgradeStatus.InitialPowerStatusEnum InitialPowerStatus
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

        public FirmwareUpgradeStatus.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The reason for the operation failure."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string OverallError
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The overall percentage of the operation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long OverallPercentage
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The overall status of the operation.\n* `none` - Upgrade stage is no upgrade stage.\n* `started` - Upgrade stage is started.\n* `prepare initiating` - Upgrade configuration is being prepared.\n* `prepare initiated` - Upgrade configuration is initiated.\n* `prepared` - Upgrade configuration is prepared.\n* `download initiating` - Upgrade stage is download initiating.\n* `download initiated` - Upgrade stage is download initiated.\n* `downloading` - Upgrade stage is downloading.\n* `downloaded` - Upgrade stage is downloaded.\n* `upgrade initiating on fabric A` - Upgrade stage is in upgrade initiating when upgrade is being started in endopint.\n* `upgrade initiated on fabric A` - Upgrade stage is in upgrade initiated when the upgrade has started in endpoint.\n* `upgrading fabric A` - Upgrade stage is in upgrading when the upgrade requires reboot to complete.\n* `rebooting fabric A` - Upgrade is in rebooting when the endpoint is being rebooted.\n* `upgraded fabric A` - Upgrade stage is in upgraded when the corresponding endpoint has completed.\n* `upgrade initiating on fabric B` - Upgrade stage is in upgrade initiating when upgrade is being started in endopint.\n* `upgrade initiated on fabric B` - Upgrade stage is in upgrade initiated when upgrade has started in endpoint.\n* `upgrading fabric B` - Upgrade stage is in upgrading when the upgrade requires reboot to complete.\n* `rebooting fabric B` - Upgrade is in rebooting when the endpoint is being rebooted.\n* `upgraded fabric B` - Upgrade stage is in upgraded when the corresponding endpoint has completed.\n* `upgrade initiating` - Upgrade stage is upgrade initiating.\n* `upgrade initiated` - Upgrade stage is upgrade initiated.\n* `upgrading` - Upgrade stage is upgrading.\n* `oob images staging` - Out-of-band component images staging.\n* `oob images staged` - Out-of-band component images staged.\n* `rebooting` - Upgrade is rebooting the endpoint.\n* `upgraded` - Upgrade stage is upgraded.\n* `success` - Upgrade stage is success.\n* `failed` - Upgrade stage is upgrade failed.\n* `terminated` - Upgrade stage is terminated.\n* `pending` - Upgrade stage is pending.\n* `ReadyForCache` - The image is ready to be cached into the Intersight Appliance.\n* `Caching` - The image will be cached into Intersight Appliance or an endpoint cache.\n* `Cached` - The image has been cached into the Intersight Appliance or endpoint cache.\n* `CachingFailed` - The image caching into the Intersight Appliance failed or endpoint cache."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareUpgradeStatus.OverallstatusEnum Overallstatus
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Pending reason for the upgrade waiting.\n* `none` - Upgrade pending reason is none.\n* `pending for next reboot` - Upgrade pending reason is pending for next reboot."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FirmwareUpgradeStatus.PendingTypeEnum PendingType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The error message from the endpoint during the SD card download."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SdCardDownloadError
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The sha256checksum of the downloaded file as calculated by the download plugin after successfully downloading a file."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public byte[] Sha256checksum
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
            Intersight.Model.FirmwareUpgradeStatus initObject = new Intersight.Model.FirmwareUpgradeStatus();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Checksum"))
            {
                initObject.Checksum = this.Checksum;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("DownloadError"))
            {
                initObject.DownloadError = this.DownloadError;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DownloadMessage"))
            {
                initObject.DownloadMessage = this.DownloadMessage;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DownloadPercentage"))
            {
                initObject.DownloadPercentage = this.DownloadPercentage;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DownloadProgress"))
            {
                initObject.DownloadProgress = this.DownloadProgress;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DownloadRetries"))
            {
                initObject.DownloadRetries = this.DownloadRetries;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DownloadStage"))
            {
                initObject.DownloadStage = this.DownloadStage;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EpPowerStatus"))
            {
                initObject.EpPowerStatus = this.EpPowerStatus;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InitialPowerStatus"))
            {
                initObject.InitialPowerStatus = this.InitialPowerStatus;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("OverallError"))
            {
                initObject.OverallError = this.OverallError;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("OverallPercentage"))
            {
                initObject.OverallPercentage = this.OverallPercentage;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Overallstatus"))
            {
                initObject.Overallstatus = this.Overallstatus;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PendingType"))
            {
                initObject.PendingType = this.PendingType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SdCardDownloadError"))
            {
                initObject.SdCardDownloadError = this.SdCardDownloadError;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Sha256checksum"))
            {
                initObject.Sha256checksum = this.Sha256checksum;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize FirmwareUpgradeValidity.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightFirmwareUpgradeValidity")]
    public class InitializeIntersightFirmwareUpgradeValidity : PSCmdlet
    {
        public InitializeIntersightFirmwareUpgradeValidity()
        {
            ClassId = FirmwareUpgradeValidity.ClassIdEnum.FirmwareUpgradeValidity;
            ObjectType = FirmwareUpgradeValidity.ObjectTypeEnum.FirmwareUpgradeValidity;

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

        public FirmwareUpgradeValidity.ClassIdEnum ClassId
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

        public FirmwareUpgradeValidity.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a computePhysical resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.ComputePhysicalRelationship Server
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
            Intersight.Model.FirmwareUpgradeValidity initObject = new Intersight.Model.FirmwareUpgradeValidity();
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Server"))
            {
                initObject.Server = this.Server;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
}