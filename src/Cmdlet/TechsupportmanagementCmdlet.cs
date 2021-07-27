using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get TechsupportmanagementDownload.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightTechsupportmanagementDownload", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightTechsupportmanagementDownload:GetCmdletBase
	{
		public GetIntersightTechsupportmanagementDownload()
		{
			ApiInstance = new TechsupportmanagementApi(Config);
            MethodName = "GetTechsupportmanagementDownloadList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get TechsupportmanagementTechSupportBundle.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightTechsupportmanagementTechSupportBundle", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightTechsupportmanagementTechSupportBundle:GetCmdletBase
	{
		public GetIntersightTechsupportmanagementTechSupportBundle()
		{
			ApiInstance = new TechsupportmanagementApi(Config);
            MethodName = "GetTechsupportmanagementTechSupportBundleList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New TechsupportmanagementTechSupportBundle.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightTechsupportmanagementTechSupportBundle")]
    public class NewIntersightTechsupportmanagementTechSupportBundle:NewCmdletBase
	{
		public NewIntersightTechsupportmanagementTechSupportBundle()
		{
			ApiInstance = new TechsupportmanagementApi(Config);
            ModelObject = new TechsupportmanagementTechSupportBundle();
            MethodName = "CreateTechsupportmanagementTechSupportBundle";
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
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Product identification of the device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Pid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A platform specific data payload."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ConnectorPlatformParamBase PlatformParam {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The platform type of the device.\n* `` - The device reported an empty or unrecognized platform type.\n* `APIC` - An Application Policy Infrastructure Controller cluster.\n* `DCNM` - A Data Center Network Manager instance. Data Center Network Manager (DCNM) is the network management platform for all NX-OS-enabled deployments, spanning new fabric architectures, IP Fabric for Media, and storage networking deployments for the Cisco Nexus-powered data center.\n* `UCSFI` - A UCS Fabric Interconnect in HA or standalone mode, which is being managed by UCS Manager (UCSM).\n* `UCSFIISM` - A UCS Fabric Interconnect in HA or standalone mode, managed directly by Intersight.\n* `IMC` - A standalone UCS Server Integrated Management Controller.\n* `IMCM4` - A standalone UCS M4 Server.\n* `IMCM5` - A standalone UCS M5 server.\n* `IMCRack` - A standalone UCS M6 and above server.\n* `UCSIOM` - An UCS Chassis IO module.\n* `HX` - A HyperFlex storage controller.\n* `HyperFlexAP` - A HyperFlex Application Platform.\n* `UCSD` - A UCS Director virtual appliance. Cisco UCS Director automates, orchestrates, and manages Cisco and third-party hardware.\n* `IntersightAppliance` - A Cisco Intersight Connected Virtual Appliance.\n* `IntersightAssist` - A Cisco Intersight Assist.\n* `PureStorageFlashArray` - A Pure Storage FlashArray device.\n* `NetAppOntap` - A NetApp ONTAP storage system.\n* `NetAppActiveIqUnifiedManager` - A NetApp Active IQ Unified Manager.\n* `EmcScaleIo` - An EMC ScaleIO storage system.\n* `EmcVmax` - An EMC VMAX storage system.\n* `EmcVplex` - An EMC VPLEX storage system.\n* `EmcXtremIo` - An EMC XtremIO storage system.\n* `VmwareVcenter` - A VMware vCenter device that manages Virtual Machines.\n* `MicrosoftHyperV` - A Microsoft Hyper-V system that manages Virtual Machines.\n* `AppDynamics` - An AppDynamics controller that monitors applications.\n* `Dynatrace` - A software-intelligence monitoring platform that simplifies enterprise cloud complexity and accelerates digital transformation.\n* `ReadHatOpenStack` - An OpenStack target manages Virtual Machines, Physical Machines, Datacenters and Virtual Datacenters using different OpenStack services as administrative endpoints.\n* `CloudFoundry` - An open source cloud platform on which developers can build, deploy, run and scale applications.\n* `MicrosoftAzureApplicationInsights` - A feature of Azure Monitor, is an extensible Application Performance Management service for developers and DevOps professionals to monitor their live applications.\n* `OpenStack` - An OpenStack target manages Virtual Machines, Physical Machines, Datacenters and Virtual Datacenters using different OpenStack services as administrative endpoints.\n* `MicrosoftSqlServer` - A Microsoft SQL database server.\n* `Kubernetes` - A Kubernetes cluster that runs containerized applications.\n* `AmazonWebService` - A Amazon web service target that discovers and monitors different services like EC2. It discovers entities like VMs, Volumes, regions etc. and monitors attributes like Mem, CPU, cost.\n* `AmazonWebServiceBilling` - A Amazon web service billing target to retrieve billing information stored in S3 bucket.\n* `MicrosoftAzureServicePrincipal` - A Microsoft Azure Service Principal target that discovers all the associated Azure subscriptions.\n* `MicrosoftAzureEnterpriseAgreement` - A Microsoft Azure Enterprise Agreement target that discovers cost, billing and RIs.\n* `DellCompellent` - A Dell Compellent storage system.\n* `HPE3Par` - A HPE 3PAR storage system.\n* `RedHatEnterpriseVirtualization` - A Red Hat Enterprise Virtualization Hypervisor system that manages Virtual Machines.\n* `NutanixAcropolis` - A Nutanix Acropolis system that combines servers and storage into a distributed infrastructure platform.\n* `HPEOneView` - A HPE Oneview management system that manages compute, storage, and networking.\n* `ServiceEngine` - Cisco Application Services Engine. Cisco Application Services Engine is a platform to deploy and manage applications.\n* `HitachiVirtualStoragePlatform` - A Hitachi Virtual Storage Platform also referred to as Hitachi VSP. It includes various storage systems designed for data centers.\n* `IMCBlade` - An Intersight managed UCS Blade Server.\n* `TerraformCloud` - A Terraform Cloud account.\n* `TerraformAgent` - A Terraform Cloud Agent that Intersight will deploy in datacenter. The agent will execute Terraform plan for Terraform Cloud workspace configured to use the agent.\n* `CustomTarget` - An external endpoint added as Target that can be accessed through its HTTP API interface in Intersight Orchestrator automation workflow.Standard HTTP authentication scheme supported: Basic.\n* `HTTPEndpoint` - An external endpoint added as Target that can be accessed through its HTTP API interface in Intersight Orchestrator automation workflow.Standard HTTP authentication scheme supported: Basic.\n* `CiscoCatalyst` - A Cisco Catalyst networking switch device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public TechsupportmanagementTechSupportBundle.PlatformTypeEnum PlatformType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Serial number of the device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Serial {
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
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public MoBaseMoRelationship TargetResource {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove TechsupportmanagementTechSupportBundle.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightTechsupportmanagementTechSupportBundle")]
    public class RemoveIntersightTechsupportmanagementTechSupportBundle:RemoveCmdletBase
	{
		public RemoveIntersightTechsupportmanagementTechSupportBundle()
		{
			ApiInstance = new TechsupportmanagementApi(Config);
            MethodName = "DeleteTechsupportmanagementTechSupportBundle";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get TechsupportmanagementTechSupportStatus.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightTechsupportmanagementTechSupportStatus", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightTechsupportmanagementTechSupportStatus:GetCmdletBase
	{
		public GetIntersightTechsupportmanagementTechSupportStatus()
		{
			ApiInstance = new TechsupportmanagementApi(Config);
            MethodName = "GetTechsupportmanagementTechSupportStatusList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get TechsupportmanagementCollectionControlPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightTechsupportmanagementCollectionControlPolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightTechsupportmanagementCollectionControlPolicy:GetCmdletBase
	{
		public GetIntersightTechsupportmanagementCollectionControlPolicy()
		{
			ApiInstance = new TechsupportmanagementApi(Config);
            MethodName = "GetTechsupportmanagementCollectionControlPolicyList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New TechsupportmanagementCollectionControlPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightTechsupportmanagementCollectionControlPolicy")]
    public class NewIntersightTechsupportmanagementCollectionControlPolicy:NewCmdletBase
	{
		public NewIntersightTechsupportmanagementCollectionControlPolicy()
		{
			ApiInstance = new TechsupportmanagementApi(Config);
            ModelObject = new TechsupportmanagementCollectionControlPolicy();
            MethodName = "CreateTechsupportmanagementCollectionControlPolicy";
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
        // <summary>
        /// <para type="description">"Enable or Disable techsupport collection for a specific account.\n* `Enable` - Enable techsupport collection.\n* `Disable` - Disable techsupport collection."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public TechsupportmanagementCollectionControlPolicy.TechSupportCollectionEnum TechSupportCollection {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove TechsupportmanagementCollectionControlPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightTechsupportmanagementCollectionControlPolicy")]
    public class RemoveIntersightTechsupportmanagementCollectionControlPolicy:RemoveCmdletBase
	{
		public RemoveIntersightTechsupportmanagementCollectionControlPolicy()
		{
			ApiInstance = new TechsupportmanagementApi(Config);
            MethodName = "DeleteTechsupportmanagementCollectionControlPolicy";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set TechsupportmanagementCollectionControlPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightTechsupportmanagementCollectionControlPolicy")]
    public class SetIntersightTechsupportmanagementCollectionControlPolicy:SetCmdletBase
	{
		public SetIntersightTechsupportmanagementCollectionControlPolicy()
		{
			ApiInstance = new TechsupportmanagementApi(Config);
            ModelObject = new TechsupportmanagementCollectionControlPolicy();
            MethodName = "UpdateTechsupportmanagementCollectionControlPolicy";
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
        // <summary>
        /// <para type="description">"Enable or Disable techsupport collection for a specific account.\n* `Enable` - Enable techsupport collection.\n* `Disable` - Disable techsupport collection."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public TechsupportmanagementCollectionControlPolicy.TechSupportCollectionEnum TechSupportCollection {
            get;
            set;
        }
    }
}