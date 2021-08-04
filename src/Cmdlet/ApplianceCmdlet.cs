using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set ApplianceDeviceClaim.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightApplianceDeviceClaim")]
    public class SetIntersightApplianceDeviceClaim:SetCmdletBase
	{
		public SetIntersightApplianceDeviceClaim()
		{
			ApiInstance = new ApplianceApi(Config);
            ModelObject = new ApplianceDeviceClaim();
            MethodName = "UpdateApplianceDeviceClaimWithHttpInfo";
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
        /// <para type="description">"Hostname or IP address of the endpoint device the user wants to claim."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Hostname {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Tracks if this device is to be claimed or certificate renewal."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool IsRenew {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Password to be used to login to the endpoint device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Password {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Platform type of the endpoint device.\n* `` - The device reported an empty or unrecognized platform type.\n* `APIC` - An Application Policy Infrastructure Controller cluster.\n* `DCNM` - A Data Center Network Manager instance. Data Center Network Manager (DCNM) is the network management platform for all NX-OS-enabled deployments, spanning new fabric architectures, IP Fabric for Media, and storage networking deployments for the Cisco Nexus-powered data center.\n* `UCSFI` - A UCS Fabric Interconnect in HA or standalone mode, which is being managed by UCS Manager (UCSM).\n* `UCSFIISM` - A UCS Fabric Interconnect in HA or standalone mode, managed directly by Intersight.\n* `IMC` - A standalone UCS Server Integrated Management Controller.\n* `IMCM4` - A standalone UCS M4 Server.\n* `IMCM5` - A standalone UCS M5 server.\n* `IMCRack` - A standalone UCS M6 and above server.\n* `UCSIOM` - An UCS Chassis IO module.\n* `HX` - A HyperFlex storage controller.\n* `HyperFlexAP` - A HyperFlex Application Platform.\n* `UCSD` - A UCS Director virtual appliance. Cisco UCS Director automates, orchestrates, and manages Cisco and third-party hardware.\n* `IntersightAppliance` - A Cisco Intersight Connected Virtual Appliance.\n* `IntersightAssist` - A Cisco Intersight Assist.\n* `PureStorageFlashArray` - A Pure Storage FlashArray device.\n* `UCSC890` - A standalone Cisco UCSC890 server.\n* `NetAppOntap` - A NetApp ONTAP storage system.\n* `NetAppActiveIqUnifiedManager` - A NetApp Active IQ Unified Manager.\n* `EmcScaleIo` - An EMC ScaleIO storage system.\n* `EmcVmax` - An EMC VMAX storage system.\n* `EmcVplex` - An EMC VPLEX storage system.\n* `EmcXtremIo` - An EMC XtremIO storage system.\n* `VmwareVcenter` - A VMware vCenter device that manages Virtual Machines.\n* `MicrosoftHyperV` - A Microsoft Hyper-V system that manages Virtual Machines.\n* `AppDynamics` - An AppDynamics controller that monitors applications.\n* `Dynatrace` - A software-intelligence monitoring platform that simplifies enterprise cloud complexity and accelerates digital transformation.\n* `ReadHatOpenStack` - An OpenStack target manages Virtual Machines, Physical Machines, Datacenters and Virtual Datacenters using different OpenStack services as administrative endpoints.\n* `CloudFoundry` - An open source cloud platform on which developers can build, deploy, run and scale applications.\n* `MicrosoftAzureApplicationInsights` - A feature of Azure Monitor, is an extensible Application Performance Management service for developers and DevOps professionals to monitor their live applications.\n* `OpenStack` - An OpenStack target manages Virtual Machines, Physical Machines, Datacenters and Virtual Datacenters using different OpenStack services as administrative endpoints.\n* `MicrosoftSqlServer` - A Microsoft SQL database server.\n* `Kubernetes` - A Kubernetes cluster that runs containerized applications.\n* `AmazonWebService` - A Amazon web service target that discovers and monitors different services like EC2. It discovers entities like VMs, Volumes, regions etc. and monitors attributes like Mem, CPU, cost.\n* `AmazonWebServiceBilling` - A Amazon web service billing target to retrieve billing information stored in S3 bucket.\n* `MicrosoftAzureServicePrincipal` - A Microsoft Azure Service Principal target that discovers all the associated Azure subscriptions.\n* `MicrosoftAzureEnterpriseAgreement` - A Microsoft Azure Enterprise Agreement target that discovers cost, billing and RIs.\n* `DellCompellent` - A Dell Compellent storage system.\n* `HPE3Par` - A HPE 3PAR storage system.\n* `RedHatEnterpriseVirtualization` - A Red Hat Enterprise Virtualization Hypervisor system that manages Virtual Machines.\n* `NutanixAcropolis` - A Nutanix Acropolis system that combines servers and storage into a distributed infrastructure platform.\n* `HPEOneView` - A HPE Oneview management system that manages compute, storage, and networking.\n* `ServiceEngine` - Cisco Application Services Engine. Cisco Application Services Engine is a platform to deploy and manage applications.\n* `HitachiVirtualStoragePlatform` - A Hitachi Virtual Storage Platform also referred to as Hitachi VSP. It includes various storage systems designed for data centers.\n* `IMCBlade` - An Intersight managed UCS Blade Server.\n* `TerraformCloud` - A Terraform Cloud account.\n* `TerraformAgent` - A Terraform Cloud Agent that Intersight will deploy in datacenter. The agent will execute Terraform plan for Terraform Cloud workspace configured to use the agent.\n* `CustomTarget` - An external endpoint added as Target that can be accessed through its HTTP API interface in Intersight Orchestrator automation workflow.Standard HTTP authentication scheme supported: Basic.\n* `HTTPEndpoint` - An external endpoint added as Target that can be accessed through its HTTP API interface in Intersight Orchestrator automation workflow.Standard HTTP authentication scheme supported: Basic.\n* `CiscoCatalyst` - A Cisco Catalyst networking switch device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ApplianceDeviceClaim.PlatformTypeEnum PlatformType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"User defined claim request identifier set by the UI. The RequestId field is not a mandatory. The Intersight Appliance will assign a unique value automatically if the field is not set."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RequestId {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Username to log in to the endpoint device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Username {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get ApplianceDeviceCertificate.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightApplianceDeviceCertificate", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightApplianceDeviceCertificate:GetCmdletBase
	{
		public GetIntersightApplianceDeviceCertificate()
		{
			ApiInstance = new ApplianceApi(Config);
            MethodName = "GetApplianceDeviceCertificateListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set ApplianceDiagSetting.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightApplianceDiagSetting")]
    public class SetIntersightApplianceDiagSetting:SetCmdletBase
	{
		public SetIntersightApplianceDiagSetting()
		{
			ApiInstance = new ApplianceApi(Config);
            ModelObject = new ApplianceDiagSetting();
            MethodName = "UpdateApplianceDiagSettingWithHttpInfo";
		}
        // <summary>
        /// <para type="description">"A reference to a iamAccount resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamAccountRelationship Account {
            get;
            set;
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
        /// <para type="description">"Status message of the password change operation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Message {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Password of the Intersight Appliance's OS diagnostic user account."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Password {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set ApplianceUpgradePolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightApplianceUpgradePolicy")]
    public class SetIntersightApplianceUpgradePolicy:SetCmdletBase
	{
		public SetIntersightApplianceUpgradePolicy()
		{
			ApiInstance = new ApplianceApi(Config);
            ModelObject = new ApplianceUpgradePolicy();
            MethodName = "UpdateApplianceUpgradePolicyWithHttpInfo";
		}
        // <summary>
        /// <para type="description">"A reference to a iamAccount resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamAccountRelationship Account {
            get;
            set;
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
        /// <para type="description">"Indicates if the upgrade service is set to automatically start the software upgrade or not. If autoUpgrade is true, then the value of the schedule field is ignored."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool AutoUpgrade {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"If enabled, allows the user to define a blackout period during which the appliance will not be upgraded."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool BlackoutDatesEnabled {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"End date of the black out period."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public DateTime BlackoutEndDate {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Start date of the black out period. The appliance will not be upgraded during this period."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public DateTime BlackoutStartDate {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Indicates if the updated metadata files should be synced immediately or at the next upgrade."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool EnableMetaDataSync {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"User defined schedule for upgrading the Intersight Appliance software."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OnpremSchedule Schedule {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New ApplianceRemoteFileImport.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightApplianceRemoteFileImport")]
    public class NewIntersightApplianceRemoteFileImport:NewCmdletBase
	{
		public NewIntersightApplianceRemoteFileImport()
		{
			ApiInstance = new ApplianceApi(Config);
            ModelObject = new ApplianceRemoteFileImport();
            MethodName = "CreateApplianceRemoteFileImportWithHttpInfo";
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
        /// <para type="description">"The name of the file to be imported."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Filename {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The hostname of the machine where the file is located."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Hostname {
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
        /// <para type="description">"Password for remote requiest."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Password {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The port that should be used for the remote request."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Path {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The port that should be used for the remote request."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Port {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Protocol for the remote request.\n* `scp` - Secure Copy Protocol (SCP) to access the file server.\n* `sftp` - SSH File Transfer Protocol (SFTP) to access file server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ApplianceRemoteFileImport.ProtocolEnum Protocol {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The username for the remote request."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Username {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get ApplianceRemoteFileImport.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightApplianceRemoteFileImport", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightApplianceRemoteFileImport:GetCmdletBase
	{
		public GetIntersightApplianceRemoteFileImport()
		{
			ApiInstance = new ApplianceApi(Config);
            MethodName = "GetApplianceRemoteFileImportListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get ApplianceRestore.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightApplianceRestore", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightApplianceRestore:GetCmdletBase
	{
		public GetIntersightApplianceRestore()
		{
			ApiInstance = new ApplianceApi(Config);
            MethodName = "GetApplianceRestoreListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New ApplianceRestore.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightApplianceRestore")]
    public class NewIntersightApplianceRestore:NewCmdletBase
	{
		public NewIntersightApplianceRestore()
		{
			ApiInstance = new ApplianceApi(Config);
            ModelObject = new ApplianceRestore();
            MethodName = "CreateApplianceRestoreWithHttpInfo";
		}
        // <summary>
        /// <para type="description">"A reference to a iamAccount resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamAccountRelationship Account {
            get;
            set;
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
        /// <para type="description">"Backup filename to backup or restore."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9][a-zA-Z0-9_\\.\\-\\+]*$")]
        public string Filename {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> Messages {
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
        /// <para type="description">"Password for authenticating with the file server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[^`]+$")]
        public string Password {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Communication protocol used by the file server (e.g. scp or sftp).\n* `scp` - Secure Copy Protocol (SCP) to access the file server.\n* `sftp` - SSH File Transfer Protocol (SFTP) to access file server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ApplianceRestore.ProtocolEnum Protocol {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Hostname of the remote file server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RemoteHost {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"File server directory to copy the file."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^(/[^/ ]*)+/?$")]
        public string RemotePath {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Remote TCP port on the file server (e.g. 22 for scp)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long RemotePort {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Username to authenticate the fileserver."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9_][a-zA-Z0-9_\\.\\-\\+]*$")]
        public string Username {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove ApplianceBackup.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightApplianceBackup")]
    public class RemoveIntersightApplianceBackup:RemoveCmdletBase
	{
		public RemoveIntersightApplianceBackup()
		{
			ApiInstance = new ApplianceApi(Config);
            MethodName = "DeleteApplianceBackupWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set ApplianceDataExportPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightApplianceDataExportPolicy")]
    public class SetIntersightApplianceDataExportPolicy:SetCmdletBase
	{
		public SetIntersightApplianceDataExportPolicy()
		{
			ApiInstance = new ApplianceApi(Config);
            ModelObject = new ApplianceDataExportPolicy();
            MethodName = "UpdateApplianceDataExportPolicyWithHttpInfo";
		}
        // <summary>
        /// <para type="description">"A reference to a iamAccount resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamAccountRelationship Account {
            get;
            set;
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
        /// <para type="description">"Status of the data collection mode. If the value is 'true', then data collection is enabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Enable {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get ApplianceNodeStatus.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightApplianceNodeStatus", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightApplianceNodeStatus:GetCmdletBase
	{
		public GetIntersightApplianceNodeStatus()
		{
			ApiInstance = new ApplianceApi(Config);
            MethodName = "GetApplianceNodeStatusListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get ApplianceUpgrade.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightApplianceUpgrade", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightApplianceUpgrade:GetCmdletBase
	{
		public GetIntersightApplianceUpgrade()
		{
			ApiInstance = new ApplianceApi(Config);
            MethodName = "GetApplianceUpgradeListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get ApplianceCertificateSetting.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightApplianceCertificateSetting", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightApplianceCertificateSetting:GetCmdletBase
	{
		public GetIntersightApplianceCertificateSetting()
		{
			ApiInstance = new ApplianceApi(Config);
            MethodName = "GetApplianceCertificateSettingListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get ApplianceDataExportPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightApplianceDataExportPolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightApplianceDataExportPolicy:GetCmdletBase
	{
		public GetIntersightApplianceDataExportPolicy()
		{
			ApiInstance = new ApplianceApi(Config);
            MethodName = "GetApplianceDataExportPolicyListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New ApplianceDataExportPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightApplianceDataExportPolicy")]
    public class NewIntersightApplianceDataExportPolicy:NewCmdletBase
	{
		public NewIntersightApplianceDataExportPolicy()
		{
			ApiInstance = new ApplianceApi(Config);
            ModelObject = new ApplianceDataExportPolicy();
            MethodName = "CreateApplianceDataExportPolicyWithHttpInfo";
		}
        // <summary>
        /// <para type="description">"A reference to a iamAccount resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamAccountRelationship Account {
            get;
            set;
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
        /// <para type="description">"Status of the data collection mode. If the value is 'true', then data collection is enabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Enable {
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get ApplianceFileSystemStatus.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightApplianceFileSystemStatus", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightApplianceFileSystemStatus:GetCmdletBase
	{
		public GetIntersightApplianceFileSystemStatus()
		{
			ApiInstance = new ApplianceApi(Config);
            MethodName = "GetApplianceFileSystemStatusListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get ApplianceSystemStatus.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightApplianceSystemStatus", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightApplianceSystemStatus:GetCmdletBase
	{
		public GetIntersightApplianceSystemStatus()
		{
			ApiInstance = new ApplianceApi(Config);
            MethodName = "GetApplianceSystemStatusListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get ApplianceAppStatus.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightApplianceAppStatus", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightApplianceAppStatus:GetCmdletBase
	{
		public GetIntersightApplianceAppStatus()
		{
			ApiInstance = new ApplianceApi(Config);
            MethodName = "GetApplianceAppStatusListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set ApplianceUpgrade.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightApplianceUpgrade")]
    public class SetIntersightApplianceUpgrade:SetCmdletBase
	{
		public SetIntersightApplianceUpgrade()
		{
			ApiInstance = new ApplianceApi(Config);
            ModelObject = new ApplianceUpgrade();
            MethodName = "PatchApplianceUpgradeWithHttpInfo";
		}
        // <summary>
        /// <para type="description">"A reference to a iamAccount resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamAccountRelationship Account {
            get;
            set;
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<OnpremUpgradePhase> CompletedPhases {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> Messages {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Track if rollback is needed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool RollbackNeeded {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<OnpremUpgradePhase> RollbackPhases {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> Services {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Start date of the software upgrade. UI can modify startTime to re-schedule an upgrade."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public DateTime StartTime {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> UiPackages {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set ApplianceExternalSyslogSetting.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightApplianceExternalSyslogSetting")]
    public class SetIntersightApplianceExternalSyslogSetting:SetCmdletBase
	{
		public SetIntersightApplianceExternalSyslogSetting()
		{
			ApiInstance = new ApplianceApi(Config);
            ModelObject = new ApplianceExternalSyslogSetting();
            MethodName = "UpdateApplianceExternalSyslogSettingWithHttpInfo";
		}
        // <summary>
        /// <para type="description">"A reference to a iamAccount resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamAccountRelationship Account {
            get;
            set;
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
        /// <para type="description">"Enable or disable External Syslog Server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Enabled {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Enable or disable exporting of Web Server access logs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool ExportNginx {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"External Syslog Server Port for connection establishment."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1, 65535)]
        public long Port {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Protocol used to connect to external syslog server.\n* `TCP` - External Syslog messages sent over TCP.\n* `UDP` - External Syslog messages sent over UDP.\n* `TLS` - Secure External Syslog messages sent over TLS."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ApplianceExternalSyslogSetting.ProtocolEnum Protocol {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"External Syslog Server Address, can be IP address or hostname."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Server {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get ApplianceBackup.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightApplianceBackup", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightApplianceBackup:GetCmdletBase
	{
		public GetIntersightApplianceBackup()
		{
			ApiInstance = new ApplianceApi(Config);
            MethodName = "GetApplianceBackupListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New ApplianceBackup.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightApplianceBackup")]
    public class NewIntersightApplianceBackup:NewCmdletBase
	{
		public NewIntersightApplianceBackup()
		{
			ApiInstance = new ApplianceApi(Config);
            ModelObject = new ApplianceBackup();
            MethodName = "CreateApplianceBackupWithHttpInfo";
		}
        // <summary>
        /// <para type="description">"A reference to a iamAccount resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamAccountRelationship Account {
            get;
            set;
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
        /// <para type="description">"Backup filename to backup or restore."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9][a-zA-Z0-9_\\.\\-\\+]*$")]
        public string Filename {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> Messages {
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
        /// <para type="description">"Password to authenticate the fileserver."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[^`]+$")]
        public string Password {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Communication protocol used by the file server (e.g. scp or sftp).\n* `scp` - Secure Copy Protocol (SCP) to access the file server.\n* `sftp` - SSH File Transfer Protocol (SFTP) to access file server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ApplianceBackup.ProtocolEnum Protocol {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Hostname of the remote file server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RemoteHost {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"File server directory to copy the file."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^(/[^/ ]*)+/?$")]
        public string RemotePath {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Remote TCP port on the file server (e.g. 22 for scp)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long RemotePort {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Username to authenticate the fileserver."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9_][a-zA-Z0-9_\\.\\-\\+]*$")]
        public string Username {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get ApplianceDeviceClaim.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightApplianceDeviceClaim", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightApplianceDeviceClaim:GetCmdletBase
	{
		public GetIntersightApplianceDeviceClaim()
		{
			ApiInstance = new ApplianceApi(Config);
            MethodName = "GetApplianceDeviceClaimListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New ApplianceDeviceClaim.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightApplianceDeviceClaim")]
    public class NewIntersightApplianceDeviceClaim:NewCmdletBase
	{
		public NewIntersightApplianceDeviceClaim()
		{
			ApiInstance = new ApplianceApi(Config);
            ModelObject = new ApplianceDeviceClaim();
            MethodName = "CreateApplianceDeviceClaimWithHttpInfo";
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
        /// <para type="description">"Hostname or IP address of the endpoint device the user wants to claim."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Hostname {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Tracks if this device is to be claimed or certificate renewal."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool IsRenew {
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
        /// <para type="description">"Password to be used to login to the endpoint device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Password {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Platform type of the endpoint device.\n* `` - The device reported an empty or unrecognized platform type.\n* `APIC` - An Application Policy Infrastructure Controller cluster.\n* `DCNM` - A Data Center Network Manager instance. Data Center Network Manager (DCNM) is the network management platform for all NX-OS-enabled deployments, spanning new fabric architectures, IP Fabric for Media, and storage networking deployments for the Cisco Nexus-powered data center.\n* `UCSFI` - A UCS Fabric Interconnect in HA or standalone mode, which is being managed by UCS Manager (UCSM).\n* `UCSFIISM` - A UCS Fabric Interconnect in HA or standalone mode, managed directly by Intersight.\n* `IMC` - A standalone UCS Server Integrated Management Controller.\n* `IMCM4` - A standalone UCS M4 Server.\n* `IMCM5` - A standalone UCS M5 server.\n* `IMCRack` - A standalone UCS M6 and above server.\n* `UCSIOM` - An UCS Chassis IO module.\n* `HX` - A HyperFlex storage controller.\n* `HyperFlexAP` - A HyperFlex Application Platform.\n* `UCSD` - A UCS Director virtual appliance. Cisco UCS Director automates, orchestrates, and manages Cisco and third-party hardware.\n* `IntersightAppliance` - A Cisco Intersight Connected Virtual Appliance.\n* `IntersightAssist` - A Cisco Intersight Assist.\n* `PureStorageFlashArray` - A Pure Storage FlashArray device.\n* `UCSC890` - A standalone Cisco UCSC890 server.\n* `NetAppOntap` - A NetApp ONTAP storage system.\n* `NetAppActiveIqUnifiedManager` - A NetApp Active IQ Unified Manager.\n* `EmcScaleIo` - An EMC ScaleIO storage system.\n* `EmcVmax` - An EMC VMAX storage system.\n* `EmcVplex` - An EMC VPLEX storage system.\n* `EmcXtremIo` - An EMC XtremIO storage system.\n* `VmwareVcenter` - A VMware vCenter device that manages Virtual Machines.\n* `MicrosoftHyperV` - A Microsoft Hyper-V system that manages Virtual Machines.\n* `AppDynamics` - An AppDynamics controller that monitors applications.\n* `Dynatrace` - A software-intelligence monitoring platform that simplifies enterprise cloud complexity and accelerates digital transformation.\n* `ReadHatOpenStack` - An OpenStack target manages Virtual Machines, Physical Machines, Datacenters and Virtual Datacenters using different OpenStack services as administrative endpoints.\n* `CloudFoundry` - An open source cloud platform on which developers can build, deploy, run and scale applications.\n* `MicrosoftAzureApplicationInsights` - A feature of Azure Monitor, is an extensible Application Performance Management service for developers and DevOps professionals to monitor their live applications.\n* `OpenStack` - An OpenStack target manages Virtual Machines, Physical Machines, Datacenters and Virtual Datacenters using different OpenStack services as administrative endpoints.\n* `MicrosoftSqlServer` - A Microsoft SQL database server.\n* `Kubernetes` - A Kubernetes cluster that runs containerized applications.\n* `AmazonWebService` - A Amazon web service target that discovers and monitors different services like EC2. It discovers entities like VMs, Volumes, regions etc. and monitors attributes like Mem, CPU, cost.\n* `AmazonWebServiceBilling` - A Amazon web service billing target to retrieve billing information stored in S3 bucket.\n* `MicrosoftAzureServicePrincipal` - A Microsoft Azure Service Principal target that discovers all the associated Azure subscriptions.\n* `MicrosoftAzureEnterpriseAgreement` - A Microsoft Azure Enterprise Agreement target that discovers cost, billing and RIs.\n* `DellCompellent` - A Dell Compellent storage system.\n* `HPE3Par` - A HPE 3PAR storage system.\n* `RedHatEnterpriseVirtualization` - A Red Hat Enterprise Virtualization Hypervisor system that manages Virtual Machines.\n* `NutanixAcropolis` - A Nutanix Acropolis system that combines servers and storage into a distributed infrastructure platform.\n* `HPEOneView` - A HPE Oneview management system that manages compute, storage, and networking.\n* `ServiceEngine` - Cisco Application Services Engine. Cisco Application Services Engine is a platform to deploy and manage applications.\n* `HitachiVirtualStoragePlatform` - A Hitachi Virtual Storage Platform also referred to as Hitachi VSP. It includes various storage systems designed for data centers.\n* `IMCBlade` - An Intersight managed UCS Blade Server.\n* `TerraformCloud` - A Terraform Cloud account.\n* `TerraformAgent` - A Terraform Cloud Agent that Intersight will deploy in datacenter. The agent will execute Terraform plan for Terraform Cloud workspace configured to use the agent.\n* `CustomTarget` - An external endpoint added as Target that can be accessed through its HTTP API interface in Intersight Orchestrator automation workflow.Standard HTTP authentication scheme supported: Basic.\n* `HTTPEndpoint` - An external endpoint added as Target that can be accessed through its HTTP API interface in Intersight Orchestrator automation workflow.Standard HTTP authentication scheme supported: Basic.\n* `CiscoCatalyst` - A Cisco Catalyst networking switch device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ApplianceDeviceClaim.PlatformTypeEnum PlatformType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"User defined claim request identifier set by the UI. The RequestId field is not a mandatory. The Intersight Appliance will assign a unique value automatically if the field is not set."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RequestId {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Username to log in to the endpoint device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Username {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get ApplianceBackupPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightApplianceBackupPolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightApplianceBackupPolicy:GetCmdletBase
	{
		public GetIntersightApplianceBackupPolicy()
		{
			ApiInstance = new ApplianceApi(Config);
            MethodName = "GetApplianceBackupPolicyListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New ApplianceBackupPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightApplianceBackupPolicy")]
    public class NewIntersightApplianceBackupPolicy:NewCmdletBase
	{
		public NewIntersightApplianceBackupPolicy()
		{
			ApiInstance = new ApplianceApi(Config);
            ModelObject = new ApplianceBackupPolicy();
            MethodName = "CreateApplianceBackupPolicyWithHttpInfo";
		}
        // <summary>
        /// <para type="description">"A reference to a iamAccount resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamAccountRelationship Account {
            get;
            set;
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
        /// <para type="description">"Backup filename to backup or restore."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9][a-zA-Z0-9_\\.\\-\\+]*$")]
        public string Filename {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Backup mode of the appliance. Automatic backups of the appliance are not initiated if this property is set to 'true' and the backup schedule field is ignored."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool ManualBackup {
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
        /// <para type="description">"Password to authenticate the file server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[^`]+$")]
        public string Password {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Communication protocol used by the file server (e.g. scp or sftp).\n* `scp` - Secure Copy Protocol (SCP) to access the file server.\n* `sftp` - SSH File Transfer Protocol (SFTP) to access file server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ApplianceBackupPolicy.ProtocolEnum Protocol {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Hostname of the remote file server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RemoteHost {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"File server directory to copy the file."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^(/[^/ ]*)+/?$")]
        public string RemotePath {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Remote TCP port on the file server (e.g. 22 for scp)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long RemotePort {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Schedule to create a backup of the Intersight Appliance. Manualbackup field must be set to 'false' for this schedule to be active."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OnpremSchedule Schedule {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Username to authenticate the fileserver."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9_][a-zA-Z0-9_\\.\\-\\+]*$")]
        public string Username {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set ApplianceBackupPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightApplianceBackupPolicy")]
    public class SetIntersightApplianceBackupPolicy:SetCmdletBase
	{
		public SetIntersightApplianceBackupPolicy()
		{
			ApiInstance = new ApplianceApi(Config);
            ModelObject = new ApplianceBackupPolicy();
            MethodName = "UpdateApplianceBackupPolicyWithHttpInfo";
		}
        // <summary>
        /// <para type="description">"A reference to a iamAccount resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamAccountRelationship Account {
            get;
            set;
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
        /// <para type="description">"Backup filename to backup or restore."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9][a-zA-Z0-9_\\.\\-\\+]*$")]
        public string Filename {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Backup mode of the appliance. Automatic backups of the appliance are not initiated if this property is set to 'true' and the backup schedule field is ignored."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool ManualBackup {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Password to authenticate the file server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[^`]+$")]
        public string Password {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Communication protocol used by the file server (e.g. scp or sftp).\n* `scp` - Secure Copy Protocol (SCP) to access the file server.\n* `sftp` - SSH File Transfer Protocol (SFTP) to access file server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ApplianceBackupPolicy.ProtocolEnum Protocol {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Hostname of the remote file server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RemoteHost {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"File server directory to copy the file."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^(/[^/ ]*)+/?$")]
        public string RemotePath {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Remote TCP port on the file server (e.g. 22 for scp)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long RemotePort {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Schedule to create a backup of the Intersight Appliance. Manualbackup field must be set to 'false' for this schedule to be active."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OnpremSchedule Schedule {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Username to authenticate the fileserver."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9_][a-zA-Z0-9_\\.\\-\\+]*$")]
        public string Username {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set ApplianceSetupInfo.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightApplianceSetupInfo")]
    public class SetIntersightApplianceSetupInfo:SetCmdletBase
	{
		public SetIntersightApplianceSetupInfo()
		{
			ApiInstance = new ApplianceApi(Config);
            ModelObject = new ApplianceSetupInfo();
            MethodName = "UpdateApplianceSetupInfoWithHttpInfo";
		}
        // <summary>
        /// <para type="description">"A reference to a iamAccount resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamAccountRelationship Account {
            get;
            set;
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<ApplianceKeyValuePair> Capabilities {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> SetupStates {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New ApplianceDiagSetting.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightApplianceDiagSetting")]
    public class NewIntersightApplianceDiagSetting:NewCmdletBase
	{
		public NewIntersightApplianceDiagSetting()
		{
			ApiInstance = new ApplianceApi(Config);
            ModelObject = new ApplianceDiagSetting();
            MethodName = "CreateApplianceDiagSettingWithHttpInfo";
		}
        // <summary>
        /// <para type="description">"A reference to a iamAccount resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamAccountRelationship Account {
            get;
            set;
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
        /// <para type="description">"Status message of the password change operation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Message {
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
        /// <para type="description">"Password of the Intersight Appliance's OS diagnostic user account."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Password {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get ApplianceDiagSetting.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightApplianceDiagSetting", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightApplianceDiagSetting:GetCmdletBase
	{
		public GetIntersightApplianceDiagSetting()
		{
			ApiInstance = new ApplianceApi(Config);
            MethodName = "GetApplianceDiagSettingListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set ApplianceCertificateSetting.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightApplianceCertificateSetting")]
    public class SetIntersightApplianceCertificateSetting:SetCmdletBase
	{
		public SetIntersightApplianceCertificateSetting()
		{
			ApiInstance = new ApplianceApi(Config);
            ModelObject = new ApplianceCertificateSetting();
            MethodName = "UpdateApplianceCertificateSettingWithHttpInfo";
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
        /// <para type="description">"A reference to a iamCertificate resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamCertificateRelationship Certificate {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get ApplianceSystemInfo.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightApplianceSystemInfo", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightApplianceSystemInfo:GetCmdletBase
	{
		public GetIntersightApplianceSystemInfo()
		{
			ApiInstance = new ApplianceApi(Config);
            MethodName = "GetApplianceSystemInfoListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get ApplianceGroupStatus.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightApplianceGroupStatus", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightApplianceGroupStatus:GetCmdletBase
	{
		public GetIntersightApplianceGroupStatus()
		{
			ApiInstance = new ApplianceApi(Config);
            MethodName = "GetApplianceGroupStatusListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove ApplianceRestore.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightApplianceRestore")]
    public class RemoveIntersightApplianceRestore:RemoveCmdletBase
	{
		public RemoveIntersightApplianceRestore()
		{
			ApiInstance = new ApplianceApi(Config);
            MethodName = "DeleteApplianceRestoreWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get ApplianceExternalSyslogSetting.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightApplianceExternalSyslogSetting", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightApplianceExternalSyslogSetting:GetCmdletBase
	{
		public GetIntersightApplianceExternalSyslogSetting()
		{
			ApiInstance = new ApplianceApi(Config);
            MethodName = "GetApplianceExternalSyslogSettingListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get ApplianceSetupInfo.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightApplianceSetupInfo", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightApplianceSetupInfo:GetCmdletBase
	{
		public GetIntersightApplianceSetupInfo()
		{
			ApiInstance = new ApplianceApi(Config);
            MethodName = "GetApplianceSetupInfoListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set ApplianceAutoRmaPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightApplianceAutoRmaPolicy")]
    public class SetIntersightApplianceAutoRmaPolicy:SetCmdletBase
	{
		public SetIntersightApplianceAutoRmaPolicy()
		{
			ApiInstance = new ApplianceApi(Config);
            ModelObject = new ApplianceAutoRmaPolicy();
            MethodName = "UpdateApplianceAutoRmaPolicyWithHttpInfo";
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
        /// <para type="description">"Status of the data collection mode. If the value is 'true', then data collection is enabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Enable {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetDeviceRegistrationRelationship RegisteredDevice {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get ApplianceAutoRmaPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightApplianceAutoRmaPolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightApplianceAutoRmaPolicy:GetCmdletBase
	{
		public GetIntersightApplianceAutoRmaPolicy()
		{
			ApiInstance = new ApplianceApi(Config);
            MethodName = "GetApplianceAutoRmaPolicyListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New ApplianceAutoRmaPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightApplianceAutoRmaPolicy")]
    public class NewIntersightApplianceAutoRmaPolicy:NewCmdletBase
	{
		public NewIntersightApplianceAutoRmaPolicy()
		{
			ApiInstance = new ApplianceApi(Config);
            ModelObject = new ApplianceAutoRmaPolicy();
            MethodName = "CreateApplianceAutoRmaPolicyWithHttpInfo";
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
        /// <para type="description">"Status of the data collection mode. If the value is 'true', then data collection is enabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Enable {
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
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetDeviceRegistrationRelationship RegisteredDevice {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get ApplianceNodeInfo.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightApplianceNodeInfo", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightApplianceNodeInfo:GetCmdletBase
	{
		public GetIntersightApplianceNodeInfo()
		{
			ApiInstance = new ApplianceApi(Config);
            MethodName = "GetApplianceNodeInfoListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get ApplianceUpgradePolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightApplianceUpgradePolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightApplianceUpgradePolicy:GetCmdletBase
	{
		public GetIntersightApplianceUpgradePolicy()
		{
			ApiInstance = new ApplianceApi(Config);
            MethodName = "GetApplianceUpgradePolicyListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get ApplianceImageBundle.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightApplianceImageBundle", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightApplianceImageBundle:GetCmdletBase
	{
		public GetIntersightApplianceImageBundle()
		{
			ApiInstance = new ApplianceApi(Config);
            MethodName = "GetApplianceImageBundleListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get ApplianceReleaseNote.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightApplianceReleaseNote", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightApplianceReleaseNote:GetCmdletBase
	{
		public GetIntersightApplianceReleaseNote()
		{
			ApiInstance = new ApplianceApi(Config);
            MethodName = "GetApplianceReleaseNoteListWithHttpInfo";
		}
    }
}