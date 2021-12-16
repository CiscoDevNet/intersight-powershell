using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize FirmwareHttpServer.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightFirmwareHttpServer")]
    public class InitializeIntersightFirmwareHttpServer:PSCmdlet
	{
		public InitializeIntersightFirmwareHttpServer()
		{
            ClassId = FirmwareHttpServer.ClassIdEnum.FirmwareHttpServer;
            ObjectType = FirmwareHttpServer.ObjectTypeEnum.FirmwareHttpServer;
            
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
        
        public FirmwareHttpServer.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"HTTP/HTTPS link to the image. Accepted formats HTTP[s]://server-hostname/share/image or HTTP[s]://serverip/share/image. For a successful upgrade, the remote share server must have network connectivity with the CIMC of the selected devices."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string LocationLink {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Mount option as configured on the HTTP server. Empty if nothing is configured."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string MountOptions {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareHttpServer.ObjectTypeEnum ObjectType {
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
    /// <para type="synopsis">This is the cmdlet to Initialize FirmwareChassisUpgradeImpact.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightFirmwareChassisUpgradeImpact")]
    public class InitializeIntersightFirmwareChassisUpgradeImpact:PSCmdlet
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareChassisUpgradeImpact.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Details for the error that occurred during the reboot validation analysis."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ComputationError {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The computation status of the estimate operation for a component.\n* `Inprogress` - Upgrade impact calculation is in progress.\n* `Completed` - Upgrade impact calculation is completed.\n* `Unavailable` - Upgrade impact is not available since the image is not present in the Fabric Interconnect.\n* `Failed` - Upgrade impact is not available due to an unknown error."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareChassisUpgradeImpact.ComputationStatusDetailEnum ComputationStatusDetail {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The endpoint type or name."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string DomainName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a REST resource, uniquely identified by object type and MOID."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string EndPoint {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The current firmware version of the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string FirmwareVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Model.FirmwareComponentImpact> ImpactDetail {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The impact type of the endpoint, whether a reboot is required or not.\n* `NoReboot` - A reboot is not required for the endpoint after upgrade.\n* `Reboot` - A reboot is required to the endpoint after upgrade."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareChassisUpgradeImpact.ImpactTypeEnum ImpactType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The model details of the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Model {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the chassis that will be affected by the upgrade."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareChassisUpgradeImpact.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The target firmware version of the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string TargetFirmwareVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Details for the chassis that will be impacted by the upgrade."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string UserLabel {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The change of version impact for the endpoint.\n* `None` - No change in version for the component.\n* `Upgrade` - The component will be upgraded.\n* `Downgrade` - The component will be downgraded."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareChassisUpgradeImpact.VersionImpactEnum VersionImpact {
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
    /// <para type="synopsis">This is the cmdlet to Initialize FirmwareIncludeComponentListType.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightFirmwareIncludeComponentListType")]
    public class InitializeIntersightFirmwareIncludeComponentListType:PSCmdlet
	{
		public InitializeIntersightFirmwareIncludeComponentListType()
		{
            ClassId = FirmwareIncludeComponentListType.ClassIdEnum.FirmwareIncludeComponentListType;
            ObjectType = FirmwareIncludeComponentListType.ObjectTypeEnum.FirmwareIncludeComponentListType;
            
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
        
        public FirmwareIncludeComponentListType.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> IncludeLocalDiskList {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> IncludeStorageControllerList {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareIncludeComponentListType.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.FirmwareIncludeComponentListType initObject = new Intersight.Model.FirmwareIncludeComponentListType();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("IncludeLocalDiskList"))
            {
                initObject.IncludeLocalDiskList = this.IncludeLocalDiskList;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IncludeStorageControllerList"))
            {
                initObject.IncludeStorageControllerList = this.IncludeStorageControllerList;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize FirmwareFirmwareInventory.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightFirmwareFirmwareInventory")]
    public class InitializeIntersightFirmwareFirmwareInventory:PSCmdlet
	{
		public InitializeIntersightFirmwareFirmwareInventory()
		{
            ClassId = FirmwareFirmwareInventory.ClassIdEnum.FirmwareFirmwareInventory;
            ObjectType = FirmwareFirmwareInventory.ObjectTypeEnum.FirmwareFirmwareInventory;
            
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
        /// <para type="description">"Component category. For example, MRAID is under storage controller, CIMC is under management controller."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Category {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareFirmwareInventory.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the component to reflect on UI."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Label {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Model deatils of component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Model {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareFirmwareInventory.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The redfish URI to get the firmware inventory of server components."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string UpdateUri {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The vendor of the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Vendor {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The firmware running version on the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Version {
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
    /// <para type="synopsis">This is the cmdlet to Initialize FirmwareDirectDownload.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightFirmwareDirectDownload")]
    public class InitializeIntersightFirmwareDirectDownload:PSCmdlet
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareDirectDownload.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"HTTP Server option when the image source is a local HTTPS server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.FirmwareHttpServer HttpServer {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Source type referring the image to be downloaded from CCO or from a local HTTPS server.\n* `cisco` - Image to be downloaded from Cisco software repository.\n* `localHttp` - Image to be downloaded from a https server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareDirectDownload.ImageSourceEnum ImageSource {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareDirectDownload.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Password as configured on the local https server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Password {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Option to control the upgrade, e.g., sd_upgrade_mount_only - download the image into sd and upgrade wait for the server on-next boot.\n* `sd_upgrade_mount_only` - Direct upgrade SD upgrade mount only.\n* `sd_download_only` - Direct upgrade SD download only.\n* `sd_upgrade_only` - Direct upgrade SD upgrade only.\n* `sd_upgrade_full` - Direct upgrade SD upgrade full.\n* `download_only` - Direct upgrade image download only.\n* `upgrade_full` - The upgrade downloads or mounts the image, and reboots immediately for an upgrade.\n* `upgrade_mount_only` - The upgrade downloads or mounts the image. The upgrade happens in next reboot.\n* `chassis_upgrade_full` - Direct upgrade chassis upgrade full."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareDirectDownload.UpgradeoptionEnum Upgradeoption {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Username as configured on the local https server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Username {
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
    /// <para type="synopsis">This is the cmdlet to Initialize FirmwareBaseImpact.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightFirmwareBaseImpact")]
    public class InitializeIntersightFirmwareBaseImpact:PSCmdlet
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareBaseImpact.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Details for the error that occurred during the reboot validation analysis."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ComputationError {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The computation status of the estimate operation for a component.\n* `Inprogress` - Upgrade impact calculation is in progress.\n* `Completed` - Upgrade impact calculation is completed.\n* `Unavailable` - Upgrade impact is not available since the image is not present in the Fabric Interconnect.\n* `Failed` - Upgrade impact is not available due to an unknown error."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareBaseImpact.ComputationStatusDetailEnum ComputationStatusDetail {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The endpoint type or name."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string DomainName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a REST resource, uniquely identified by object type and MOID."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string EndPoint {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The current firmware version of the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string FirmwareVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The impact type of the endpoint, whether a reboot is required or not.\n* `NoReboot` - A reboot is not required for the endpoint after upgrade.\n* `Reboot` - A reboot is required to the endpoint after upgrade."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareBaseImpact.ImpactTypeEnum ImpactType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The model details of the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Model {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareBaseImpact.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The target firmware version of the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string TargetFirmwareVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The change of version impact for the endpoint.\n* `None` - No change in version for the component.\n* `Upgrade` - The component will be upgraded.\n* `Downgrade` - The component will be downgraded."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareBaseImpact.VersionImpactEnum VersionImpact {
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
    /// <para type="synopsis">This is the cmdlet to Initialize FirmwareFabricUpgradeImpact.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightFirmwareFabricUpgradeImpact")]
    public class InitializeIntersightFirmwareFabricUpgradeImpact:PSCmdlet
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareFabricUpgradeImpact.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Details for the error that occurred during the reboot validation analysis."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ComputationError {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The computation status of the estimate operation for a component.\n* `Inprogress` - Upgrade impact calculation is in progress.\n* `Completed` - Upgrade impact calculation is completed.\n* `Unavailable` - Upgrade impact is not available since the image is not present in the Fabric Interconnect.\n* `Failed` - Upgrade impact is not available due to an unknown error."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareFabricUpgradeImpact.ComputationStatusDetailEnum ComputationStatusDetail {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The endpoint type or name."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string DomainName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a REST resource, uniquely identified by object type and MOID."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string EndPoint {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The current firmware version of the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string FirmwareVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Model.FirmwareComponentImpact> ImpactDetail {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The impact type of the endpoint, whether a reboot is required or not.\n* `NoReboot` - A reboot is not required for the endpoint after upgrade.\n* `Reboot` - A reboot is required to the endpoint after upgrade."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareFabricUpgradeImpact.ImpactTypeEnum ImpactType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The model details of the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Model {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareFabricUpgradeImpact.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Details for the Fabric Interconnect that will be impacted by the upgrade."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Serial {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The target firmware version of the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string TargetFirmwareVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The change of version impact for the endpoint.\n* `None` - No change in version for the component.\n* `Upgrade` - The component will be upgraded.\n* `Downgrade` - The component will be downgraded."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareFabricUpgradeImpact.VersionImpactEnum VersionImpact {
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
    /// <para type="synopsis">This is the cmdlet to Initialize FirmwareServerUpgradeImpact.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightFirmwareServerUpgradeImpact")]
    public class InitializeIntersightFirmwareServerUpgradeImpact:PSCmdlet
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareServerUpgradeImpact.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Details for the error that occurred during the reboot validation analysis."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ComputationError {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The computation status of the estimate operation for a component.\n* `Inprogress` - Upgrade impact calculation is in progress.\n* `Completed` - Upgrade impact calculation is completed.\n* `Unavailable` - Upgrade impact is not available since the image is not present in the Fabric Interconnect.\n* `Failed` - Upgrade impact is not available due to an unknown error."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareServerUpgradeImpact.ComputationStatusDetailEnum ComputationStatusDetail {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The endpoint type or name."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string DomainName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a REST resource, uniquely identified by object type and MOID."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string EndPoint {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The current firmware version of the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string FirmwareVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Model.FirmwareComponentImpact> ImpactDetail {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The impact type of the endpoint, whether a reboot is required or not.\n* `NoReboot` - A reboot is not required for the endpoint after upgrade.\n* `Reboot` - A reboot is required to the endpoint after upgrade."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareServerUpgradeImpact.ImpactTypeEnum ImpactType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The model details of the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Model {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the server impacted by the upgrade."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareServerUpgradeImpact.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The target firmware version of the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string TargetFirmwareVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Details about the server which will be impacted by the upgrade."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string UserLabel {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The change of version impact for the endpoint.\n* `None` - No change in version for the component.\n* `Upgrade` - The component will be upgraded.\n* `Downgrade` - The component will be downgraded."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareServerUpgradeImpact.VersionImpactEnum VersionImpact {
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
    /// <para type="synopsis">This is the cmdlet to Initialize FirmwareComponentMeta.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightFirmwareComponentMeta")]
    public class InitializeIntersightFirmwareComponentMeta:PSCmdlet
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareComponentMeta.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the component in the compressed HSU bundle."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ComponentLabel {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The type of component image within the distributable.\n* `ALL` - This represents all the components.\n* `ALL,HDD` - This represents all the components plus the HDDs.\n* `Drive-U.2` - This represents the U.2 drives that are SFF/LFF drives (mostly all the drives will fall under this category).\n* `Storage` - This represents the storage controller components.\n* `None` - This represents none of the components.\n* `NXOS` - This represents NXOS components.\n* `IOM` - This represents IOM components.\n* `PSU` - This represents PSU components.\n* `CIMC` - This represents CIMC components.\n* `BIOS` - This represents BIOS components.\n* `PCIE` - This represents PCIE components.\n* `Drive` - This represents Drive components.\n* `DIMM` - This represents DIMM components.\n* `BoardController` - This represents Board Controller components.\n* `StorageController` - This represents Storage Controller components.\n* `Storage-Sasexpander` - This represents Storage Sas-Expander components.\n* `Storage-U.2` - This represents U2 Storage Controller components.\n* `HBA` - This represents HBA components.\n* `GPU` - This represents GPU components.\n* `SasExpander` - This represents SasExpander components.\n* `MSwitch` - This represents mSwitch components.\n* `CMC` - This represents CMC components."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareComponentMeta.ComponentTypeEnum ComponentType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"This shows the description of component image within the distributable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The type of disruption on each component. For example, host reboot, automatic power cycle, and manual power cycle.\n* `None` - Indicates that the component did not receive a disruption request.\n* `HostReboot` - Indicates that the component received a host reboot request.\n* `EndpointReboot` - Indicates that the component received an end point reboot request.\n* `ManualPowerCycle` - Indicates that the component received a manual power cycle request.\n* `AutomaticPowerCycle` - Indicates that the component received an automatic power cycle request."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareComponentMeta.DisruptionEnum Disruption {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"This shows the path of component image within the distributable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ImagePath {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"If set, the component can be updated through out-of-band management, else, is updated through host service utility boot."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool IsOobSupported {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The model of the component image in the distributable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Model {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareComponentMeta.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<FirmwareComponentMeta.OobManageabilityEnum> OobManageability {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The image version of components packaged in the distributable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string PackedVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The redfish target for each component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RedfishUrl {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The version of component image in the distributable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Vendor {
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
    /// <para type="synopsis">This is the cmdlet to Initialize FirmwareNetworkShare.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightFirmwareNetworkShare")]
    public class InitializeIntersightFirmwareNetworkShare:PSCmdlet
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"CIFS file server option for network share upgrade."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.FirmwareCifsServer CifsServer {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareNetworkShare.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"HTTP (for WWW) file server option for network share upgrade."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.FirmwareHttpServer HttpServer {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"File server protocols such as CIFS, NFS, WWW for HTTP (S) that hosts the image.\n* `nfs` - File server protocol used is NFS.\n* `cifs` - File server protocol used is CIFS.\n* `www` - File server protocol used is WWW."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareNetworkShare.MapTypeEnum MapType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"NFS file server option for network share upgrade."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.FirmwareNfsServer NfsServer {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareNetworkShare.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Password as configured on the file server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Password {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Option to control the upgrade operation. Some examples, 1) nw_upgrade_mount_only - mount the image from a file server and run the upgrade on the next server boot and 2) nw_upgrade_full - mount the image and immediately run the upgrade.\n* `nw_upgrade_full` - Network upgrade option for full upgrade.\n* `nw_upgrade_mount_only` - Network upgrade mount only."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareNetworkShare.UpgradeoptionEnum Upgradeoption {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Username as configured on the file server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Username {
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
    /// <para type="synopsis">This is the cmdlet to Initialize FirmwareComponentImpact.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightFirmwareComponentImpact")]
    public class InitializeIntersightFirmwareComponentImpact:PSCmdlet
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareComponentImpact.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Impact on the component after the upgrade.\n* `ALL` - This represents all the components.\n* `ALL,HDD` - This represents all the components plus the HDDs.\n* `Drive-U.2` - This represents the U.2 drives that are SFF/LFF drives (mostly all the drives will fall under this category).\n* `Storage` - This represents the storage controller components.\n* `None` - This represents none of the components.\n* `NXOS` - This represents NXOS components.\n* `IOM` - This represents IOM components.\n* `PSU` - This represents PSU components.\n* `CIMC` - This represents CIMC components.\n* `BIOS` - This represents BIOS components.\n* `PCIE` - This represents PCIE components.\n* `Drive` - This represents Drive components.\n* `DIMM` - This represents DIMM components.\n* `BoardController` - This represents Board Controller components.\n* `StorageController` - This represents Storage Controller components.\n* `Storage-Sasexpander` - This represents Storage Sas-Expander components.\n* `Storage-U.2` - This represents U2 Storage Controller components.\n* `HBA` - This represents HBA components.\n* `GPU` - This represents GPU components.\n* `SasExpander` - This represents SasExpander components.\n* `MSwitch` - This represents mSwitch components.\n* `CMC` - This represents CMC components."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareComponentImpact.ComponentEnum Component {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Details for the error that occurred during the reboot validation analysis."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ComputationError {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The computation status of the estimate operation for a component.\n* `Inprogress` - Upgrade impact calculation is in progress.\n* `Completed` - Upgrade impact calculation is completed.\n* `Unavailable` - Upgrade impact is not available since the image is not present in the Fabric Interconnect.\n* `Failed` - Upgrade impact is not available due to an unknown error."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareComponentImpact.ComputationStatusDetailEnum ComputationStatusDetail {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The endpoint type or name."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string DomainName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a REST resource, uniquely identified by object type and MOID."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string EndPoint {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The current firmware version of the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string FirmwareVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The impact type of the endpoint, whether a reboot is required or not.\n* `NoReboot` - A reboot is not required for the endpoint after upgrade.\n* `Reboot` - A reboot is required to the endpoint after upgrade."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareComponentImpact.ImpactTypeEnum ImpactType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The model details of the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Model {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareComponentImpact.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The target firmware version of the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string TargetFirmwareVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The change of version impact for the endpoint.\n* `None` - No change in version for the component.\n* `Upgrade` - The component will be upgraded.\n* `Downgrade` - The component will be downgraded."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareComponentImpact.VersionImpactEnum VersionImpact {
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
    /// <para type="synopsis">This is the cmdlet to Initialize FirmwareCifsServer.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightFirmwareCifsServer")]
    public class InitializeIntersightFirmwareCifsServer:PSCmdlet
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareCifsServer.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The location to the image file. The accepted format is IP-or-hostname/folder1/folder2/.../imageFile."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string FileLocation {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Mount option (Authentication Protocol) as configured on the CIFS Server. Example:ntlmv2.\n* `none` - The default authentication protocol is decided by the endpoint.\n* `ntlm` - The external CIFS server is configured with ntlm as the authentication protocol.\n* `ntlmi` - Mount options of CIFS file server is ntlmi.\n* `ntlmv2` - Mount options of CIFS file server is ntlmv2.\n* `ntlmv2i` - Mount options of CIFS file server is ntlmv2i.\n* `ntlmssp` - Mount options of CIFS file server is ntlmssp.\n* `ntlmsspi` - Mount options of CIFS file server is ntlmsspi."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareCifsServer.MountOptionsEnum MountOptions {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareCifsServer.ObjectTypeEnum ObjectType {
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
    /// <para type="synopsis">This is the cmdlet to Initialize FirmwareNfsServer.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightFirmwareNfsServer")]
    public class InitializeIntersightFirmwareNfsServer:PSCmdlet
	{
		public InitializeIntersightFirmwareNfsServer()
		{
            ClassId = FirmwareNfsServer.ClassIdEnum.FirmwareNfsServer;
            ObjectType = FirmwareNfsServer.ObjectTypeEnum.FirmwareNfsServer;
            
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
        
        public FirmwareNfsServer.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The location to the image file. The accepted format is IP-or-hostname/folder1/folder2/.../imageFile."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string FileLocation {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Mount option as configured on the NFS Server. For example:nolock."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string MountOptions {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareNfsServer.ObjectTypeEnum ObjectType {
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
}