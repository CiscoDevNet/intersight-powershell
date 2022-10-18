using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize TechsupportmanagementApplianceParam.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightTechsupportmanagementApplianceParam")]
    public class InitializeIntersightTechsupportmanagementApplianceParam : PSCmdlet
    {
        public InitializeIntersightTechsupportmanagementApplianceParam()
        {
            ClassId = TechsupportmanagementApplianceParam.ClassIdEnum.TechsupportmanagementApplianceParam;
            ObjectType = TechsupportmanagementApplianceParam.ObjectTypeEnum.TechsupportmanagementApplianceParam;

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

        public TechsupportmanagementApplianceParam.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Specifies whether the techsupport request is from the cloud or by the appliance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool IsApplianceRequest
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public TechsupportmanagementApplianceParam.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.TechsupportmanagementApplianceParam initObject = new Intersight.Model.TechsupportmanagementApplianceParam();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("IsApplianceRequest"))
            {
                initObject.IsApplianceRequest = this.IsApplianceRequest;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize TechsupportmanagementCollectionControlPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightTechsupportmanagementCollectionControlPolicy")]
    public class InitializeIntersightTechsupportmanagementCollectionControlPolicy : PSCmdlet
    {
        public InitializeIntersightTechsupportmanagementCollectionControlPolicy()
        {
            ClassId = TechsupportmanagementCollectionControlPolicy.ClassIdEnum.TechsupportmanagementCollectionControlPolicy;
            ObjectType = TechsupportmanagementCollectionControlPolicy.ObjectTypeEnum.TechsupportmanagementCollectionControlPolicy;
            TechSupportCollection = TechsupportmanagementCollectionControlPolicy.TechSupportCollectionEnum.Enable;

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

        public TechsupportmanagementCollectionControlPolicy.ClassIdEnum ClassId
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

        public TechsupportmanagementCollectionControlPolicy.ObjectTypeEnum ObjectType
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
        /// <para type="description">"Enable or Disable techsupport collection for a specific account.\n* `Enable` - Enable techsupport collection.\n* `Disable` - Disable techsupport collection."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public TechsupportmanagementCollectionControlPolicy.TechSupportCollectionEnum TechSupportCollection
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.TechsupportmanagementCollectionControlPolicy initObject = new Intersight.Model.TechsupportmanagementCollectionControlPolicy();
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
            if (this.MyInvocation.BoundParameters.ContainsKey("TechSupportCollection"))
            {
                initObject.TechSupportCollection = this.TechSupportCollection;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize TechsupportmanagementDownload.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightTechsupportmanagementDownload")]
    public class InitializeIntersightTechsupportmanagementDownload : PSCmdlet
    {
        public InitializeIntersightTechsupportmanagementDownload()
        {
            ClassId = TechsupportmanagementDownload.ClassIdEnum.TechsupportmanagementDownload;
            ObjectType = TechsupportmanagementDownload.ObjectTypeEnum.TechsupportmanagementDownload;

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

        public TechsupportmanagementDownload.ClassIdEnum ClassId
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

        public TechsupportmanagementDownload.ObjectTypeEnum ObjectType
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
        /// <para type="description">"A reference to a techsupportmanagementTechSupportStatus resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.TechsupportmanagementTechSupportStatusRelationship TechSupportStatus
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.TechsupportmanagementDownload initObject = new Intersight.Model.TechsupportmanagementDownload();
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
            if (this.MyInvocation.BoundParameters.ContainsKey("TechSupportStatus"))
            {
                initObject.TechSupportStatus = this.TechSupportStatus;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize TechsupportmanagementNiaParam.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightTechsupportmanagementNiaParam")]
    public class InitializeIntersightTechsupportmanagementNiaParam : PSCmdlet
    {
        public InitializeIntersightTechsupportmanagementNiaParam()
        {
            ClassId = TechsupportmanagementNiaParam.ClassIdEnum.TechsupportmanagementNiaParam;
            CollectionLevel = TechsupportmanagementNiaParam.CollectionLevelEnum.NUMBER_1;
            ObjectType = TechsupportmanagementNiaParam.ObjectTypeEnum.TechsupportmanagementNiaParam;

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

        public TechsupportmanagementNiaParam.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"CollectionLevel controls the size / depth of the tech support files collected.\n* `1` - Use cached data in the returned collection.\n* `2` - Use current data in the returned collection."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public TechsupportmanagementNiaParam.CollectionLevelEnum CollectionLevel
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Filename specifies an individual filename to collect from the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Filename
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"ForceFresh controls whether to return pre-collected files or force the collection of new files."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool ForceFresh
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public TechsupportmanagementNiaParam.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> Pids
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> SerialNumbers
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.TechsupportmanagementNiaParam initObject = new Intersight.Model.TechsupportmanagementNiaParam();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("CollectionLevel"))
            {
                initObject.CollectionLevel = this.CollectionLevel;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Filename"))
            {
                initObject.Filename = this.Filename;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ForceFresh"))
            {
                initObject.ForceFresh = this.ForceFresh;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Pids"))
            {
                initObject.Pids = this.Pids;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SerialNumbers"))
            {
                initObject.SerialNumbers = this.SerialNumbers;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize TechsupportmanagementPlatformParam.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightTechsupportmanagementPlatformParam")]
    public class InitializeIntersightTechsupportmanagementPlatformParam : PSCmdlet
    {
        public InitializeIntersightTechsupportmanagementPlatformParam()
        {
            ClassId = TechsupportmanagementPlatformParam.ClassIdEnum.TechsupportmanagementPlatformParam;
            CollectionType = TechsupportmanagementPlatformParam.CollectionTypeEnum.NUMBER_1;
            ObjectType = TechsupportmanagementPlatformParam.ObjectTypeEnum.TechsupportmanagementPlatformParam;

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

        public TechsupportmanagementPlatformParam.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"CollectionType specifies if basic or detailed techsupport needs to be collected.\n* `1` - Collect basic techsupport.\n* `2` - Collect detailed techsupport."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public TechsupportmanagementPlatformParam.CollectionTypeEnum CollectionType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Controls whether to include core file in the techsupport bundle."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool IncludeCore
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public TechsupportmanagementPlatformParam.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.TechsupportmanagementPlatformParam initObject = new Intersight.Model.TechsupportmanagementPlatformParam();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("CollectionType"))
            {
                initObject.CollectionType = this.CollectionType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IncludeCore"))
            {
                initObject.IncludeCore = this.IncludeCore;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize TechsupportmanagementTechSupportBundle.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightTechsupportmanagementTechSupportBundle")]
    public class InitializeIntersightTechsupportmanagementTechSupportBundle : PSCmdlet
    {
        public InitializeIntersightTechsupportmanagementTechSupportBundle()
        {
            ClassId = TechsupportmanagementTechSupportBundle.ClassIdEnum.TechsupportmanagementTechSupportBundle;
            ObjectType = TechsupportmanagementTechSupportBundle.ObjectTypeEnum.TechsupportmanagementTechSupportBundle;

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

        public TechsupportmanagementTechSupportBundle.ClassIdEnum ClassId
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

        public TechsupportmanagementTechSupportBundle.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Product identification of the device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Pid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A platform specific data payload."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.ConnectorPlatformParamBase PlatformParam
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The platform type of the device.\n* `` - The device reported an empty or unrecognized platform type.\n* `APIC` - An Application Policy Infrastructure Controller cluster.\n* `CAPIC` - A Cloud Application Policy Infrastructure Controller instance.\n* `DCNM` - A Data Center Network Manager instance. Data Center Network Manager (DCNM) is the network management platform for all NX-OS-enabled deployments, spanning new fabric architectures, IP Fabric for Media, and storage networking deployments for the Cisco Nexus-powered data center.\n* `UCSFI` - A UCS Fabric Interconnect in HA or standalone mode, which is being managed by UCS Manager (UCSM).\n* `UCSFIISM` - A UCS Fabric Interconnect in HA or standalone mode, managed directly by Intersight.\n* `IMC` - A standalone UCS Server Integrated Management Controller.\n* `IMCM4` - A standalone UCS M4 Server.\n* `IMCM5` - A standalone UCS M5 server.\n* `IMCRack` - A standalone UCS M6 and above server.\n* `UCSIOM` - An UCS Chassis IO module.\n* `HX` - A HyperFlex storage controller.\n* `HyperFlexAP` - A HyperFlex Application Platform.\n* `IWE` - An Intersight Workload Engine.\n* `UCSD` - A UCS Director virtual appliance. Cisco UCS Director automates, orchestrates, and manages Cisco and third-party hardware.\n* `IntersightAppliance` - A Cisco Intersight Connected Virtual Appliance.\n* `IntersightAssist` - A Cisco Intersight Assist.\n* `PureStorageFlashArray` - A Pure Storage FlashArray device.\n* `NexusDevice` - A generic platform type to support Nexus Network Device. This can also be extended to support all network devices later on.\n* `ACISwitch` - A platform type to support ACI Switches.\n* `NexusSwitch` - A platform type to support Cisco Nexus Switches.\n* `MDSSwitch` - A platform type to support Cisco MDS Switches.\n* `MDSDevice` - A platform type to support MDS devices.\n* `UCSC890` - A standalone Cisco UCSC890 server.\n* `RedfishServer` - A generic target type for servers that support Redfish. Current support is limited to managing HPE and Dell servers on Intersight.\n* `NetAppOntap` - A NetApp ONTAP storage system.\n* `NetAppActiveIqUnifiedManager` - A NetApp Active IQ Unified Manager.\n* `EmcScaleIo` - An EMC ScaleIO storage system.\n* `EmcVmax` - An EMC VMAX storage system.\n* `EmcVplex` - An EMC VPLEX storage system.\n* `EmcXtremIo` - An EMC XtremIO storage system.\n* `VmwareVcenter` - A VMware vCenter device that manages Virtual Machines.\n* `MicrosoftHyperV` - A Microsoft Hyper-V system that manages Virtual Machines.\n* `AppDynamics` - An AppDynamics controller that monitors applications.\n* `Dynatrace` - A software-intelligence monitoring platform that simplifies enterprise cloud complexity and accelerates digital transformation.\n* `NewRelic` - A software-intelligence monitoring platform that simplifies enterprise cloud complexity and accelerates digital transformation.\n* `ServiceNow` - A cloud-based workflow automation platform that enables enterprise organizations to improve operational efficiencies by streamlining and automating routine work tasks.\n* `ReadHatOpenStack` - An OpenStack target manages Virtual Machines, Physical Machines, Datacenters and Virtual Datacenters using different OpenStack services as administrative endpoints.\n* `CloudFoundry` - An open source cloud platform on which developers can build, deploy, run and scale applications.\n* `MicrosoftAzureApplicationInsights` - A feature of Azure Monitor, is an extensible Application Performance Management service for developers and DevOps professionals to monitor their live applications.\n* `OpenStack` - An OpenStack target manages Virtual Machines, Physical Machines, Datacenters and Virtual Datacenters using different OpenStack services as administrative endpoints.\n* `MicrosoftSqlServer` - A Microsoft SQL database server.\n* `MySqlServer` - An instance of either Oracle MySQL Database or the open source MariaDB.\n* `OracleDatabaseServer` - The Oracle Server is a relational database management system that provides an open, comprehensive, and integrated approach to information management.\n* `IBMWebSphereApplicationServer` - WebSphere Application Server (WAS) is a software product that performs the role of a web application server. More specifically it is a software framework and middleware that hosts Java based web applications.\n* `OracleWebLogicServer` - Oracle WebLogic Server is a unified and extensible platform for developing, deploying and running enterprise applications, such as Java, for on-premises and in the cloud. WebLogic Server offers a robust, mature, and scalable implementation of Java Enterprise Edition (EE) and Jakarta EE.\n* `ApacheTomcatServer` - Apache Tomcat is a web container. It allows the users to run Servlet and JAVA Server Pages that are based on the web-applications.\n* `JavaVirtualMachine` - The Java Virtual Machine (JVM) is the runtime engine of the Java Platform, which allows any program written in Java or other language compiled into Java bytecode to run on any computer that has a native JVM.\n* `RedHatJBossApplicationServer` - JBoss Application Server is an open-source, cross-platform Java application server developed by JBoss, a division of Red Hat Inc. It is an open-source implementation of Java 2 Enterprise Edition (J2EE) that is used for implementing Java applications and other Web-based applications and software.\n* `Kubernetes` - A Kubernetes cluster that runs containerized applications.\n* `AmazonWebService` - An Amazon web service target that discovers and monitors different services like EC2. It discovers entities like VMs, Volumes, regions etc. and monitors attributes like Mem, CPU, cost.\n* `AmazonWebServiceBilling` - An Amazon web service billing target to retrieve billing information stored in S3 bucket.\n* `GoogleCloudPlatform` - Google Cloud Platform (GCP), offered by Google, is a suite of cloud computing services that runs on the same infrastructure that Google uses internally for its end-user products, such as Google Search, Gmail, Google Drive, and YouTube. Alongside a set of management tools, it provides a series of modular cloud services including computing, data storage, data analytics and machine learning. Google Cloud Platform provides infrastructure as a service, platform as a service, and serverless computing environments.\n* `GoogleCloudPlatformBilling` - Google Cloud Platform (GCP) offers flexible ways to set up and manage billing for your resources. A billing account is how a user pays for the resources being consumed. A billing account is associated with a method of payment and access is established using Cloud IAM roles. For a resource to be deployed in a project, the project has to be associated with a billing account. More than one project can be associated with a billing account.\n* `MicrosoftAzureServicePrincipal` - A Microsoft Azure Service Principal target that discovers all the associated Azure subscriptions.\n* `MicrosoftAzureEnterpriseAgreement` - A Microsoft Azure Enterprise Agreement target that discovers cost, billing and RIs.\n* `DellCompellent` - A Dell Compellent storage system.\n* `HPE3Par` - A HPE 3PAR storage system.\n* `RedHatEnterpriseVirtualization` - A Red Hat Enterprise Virtualization Hypervisor system that manages Virtual Machines.\n* `NutanixAcropolis` - A Nutanix Acropolis system that combines servers and storage into a distributed infrastructure platform.\n* `HPEOneView` - A HPE Oneview management system that manages compute, storage, and networking.\n* `ServiceEngine` - Cisco Application Services Engine. Cisco Application Services Engine is a platform to deploy and manage applications.\n* `HitachiVirtualStoragePlatform` - A Hitachi Virtual Storage Platform also referred to as Hitachi VSP. It includes various storage systems designed for data centers.\n* `IMCBlade` - An Intersight managed UCS Blade Server.\n* `TerraformCloud` - A Terraform Cloud account.\n* `TerraformAgent` - A Terraform Cloud Agent that Intersight will deploy in datacenter. The agent will execute Terraform plan for Terraform Cloud workspace configured to use the agent.\n* `CustomTarget` - An external endpoint added as Target that can be accessed through its HTTP API interface in Intersight Orchestrator automation workflow.Standard HTTP authentication scheme supported: Basic.\n* `AnsibleEndpoint` - An external endpoint added as Target that can be accessed through Ansible in Intersight Cloud Orchestrator automation workflow.\n* `HTTPEndpoint` - An external endpoint added as Target that can be accessed through its HTTP API interface in Intersight Orchestrator automation workflow.Standard HTTP authentication scheme supported: Basic, Bearer Token.\n* `SSHEndpoint` - An external endpoint added as Target that can be accessed through SSH in Intersight Cloud Orchestrator automation workflow.\n* `CiscoCatalyst` - A Cisco Catalyst networking switch device.\n* `PowerShellEndpoint` - A Windows machine on which PowerShell scripts can be executed remotely."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public TechsupportmanagementTechSupportBundle.PlatformTypeEnum PlatformType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Serial number of the device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Serial
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

        public Model.MoBaseMoRelationship TargetResource
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.TechsupportmanagementTechSupportBundle initObject = new Intersight.Model.TechsupportmanagementTechSupportBundle();
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Pid"))
            {
                initObject.Pid = this.Pid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PlatformParam"))
            {
                initObject.PlatformParam = this.PlatformParam;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PlatformType"))
            {
                initObject.PlatformType = this.PlatformType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Serial"))
            {
                initObject.Serial = this.Serial;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TargetResource"))
            {
                initObject.TargetResource = this.TargetResource;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize TechsupportmanagementTechSupportStatus.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightTechsupportmanagementTechSupportStatus")]
    public class InitializeIntersightTechsupportmanagementTechSupportStatus : PSCmdlet
    {
        public InitializeIntersightTechsupportmanagementTechSupportStatus()
        {
            ClassId = TechsupportmanagementTechSupportStatus.ClassIdEnum.TechsupportmanagementTechSupportStatus;
            ObjectType = TechsupportmanagementTechSupportStatus.ObjectTypeEnum.TechsupportmanagementTechSupportStatus;

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

        public TechsupportmanagementTechSupportStatus.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a assetClusterMember resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.AssetClusterMemberRelationship ClusterMember
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.AssetDeviceRegistrationRelationship DeviceRegistration
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the Techsupport bundle file."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string FileName
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

        public TechsupportmanagementTechSupportStatus.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.MoBaseMoRelationship OriginResource
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Reason for techsupport failure, if any."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Reason
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The time at which the techsupport request was initiated."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime RequestTs
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Status of techsupport collection. Valid values are Pending, CollectionInProgress, CollectionFailed, CollectionComplete, UploadPending, UploadInProgress, UploadPartsComplete, UploadFailed and Completed. The final status will be either CollectionFailed or UploadFailed if there is a failure and Completed if the request completed successfully and the file was uploaded to Intersight Storage Service. All the remaining status values indicates the progress of techsupport collection."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Status
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
        /// <para type="description">"The Url to download the techsupport file."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string TechsupportDownloadUrl
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.TechsupportmanagementTechSupportStatus initObject = new Intersight.Model.TechsupportmanagementTechSupportStatus();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ClusterMember"))
            {
                initObject.ClusterMember = this.ClusterMember;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DeviceRegistration"))
            {
                initObject.DeviceRegistration = this.DeviceRegistration;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FileName"))
            {
                initObject.FileName = this.FileName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("OriginResource"))
            {
                initObject.OriginResource = this.OriginResource;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Reason"))
            {
                initObject.Reason = this.Reason;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RequestTs"))
            {
                initObject.RequestTs = this.RequestTs;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Status"))
            {
                initObject.Status = this.Status;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TechsupportDownloadUrl"))
            {
                initObject.TechsupportDownloadUrl = this.TechsupportDownloadUrl;
            }
            WriteObject(initObject);
        }

    }
}