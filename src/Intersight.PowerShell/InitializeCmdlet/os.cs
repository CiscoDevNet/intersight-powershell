using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize OsAnswers.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightOsAnswers")]
    public class InitializeIntersightOsAnswers : PSCmdlet
    {
        public InitializeIntersightOsAnswers()
        {
            ClassId = OsAnswers.ClassIdEnum.OsAnswers;
            IpConfigType = OsAnswers.IpConfigTypeEnum.Static;
            ObjectType = OsAnswers.ObjectTypeEnum.OsAnswers;
            Source = OsAnswers.SourceEnum.None;

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

        public List<string> AlternateNameServers
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"If the source of the answers is a static file, the content of the file is stored as value\nin this property.\nThe value is mandatory only when the 'Source' property has been set to 'File'."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string AnswerFile
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public OsAnswers.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Hostname to be configured for the server in the OS."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Hostname
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"IP configuration type. Values are Static or Dynamic configuration of IP.\nIn case of static IP configuration, IP address, gateway and other details need\nto be populated. In case of dynamic the IP configuration is obtained dynamically\nfrom DHCP.\n* `static` - In case of static IP configuraton, provide the details such as IP address, netmask, and gateway.\n* `DHCP` - In case of dynamic IP configuration, the IP address, netmask and gateway detailsare obtained from DHCP."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public OsAnswers.IpConfigTypeEnum IpConfigType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"In case of static IP configuration, IP address, netmask and gateway details are\nprovided."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.OsIpConfiguration IpConfiguration
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Enable to indicate Root Password provided is encrypted."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool IsRootPasswordCrypted
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"IP address of the name server to be configured in the OS."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Nameserver
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Network Device where the IP address must be configured. Network Interface names and MAC address are supported.\nFor SUSE Linux Enterprise Server, Network Interface name is a required input and if provided as a MAC address,\nA persistent interface name is binded to the MAC address and the interface name will be used for network configuration.\nRefer https://documentation.suse.com/sles/15-SP2/html/SLES-all/cha-configuration-installation-options.html#CreateProfile-Network-names."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string NetworkDevice
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public OsAnswers.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The product key to be used for a specific version of Windows installation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ProductKey
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Password configured for the root / administrator user in the OS. You can enter a plain text or an encrypted password.\nIntersight encrypts the plaintext password. Enable the Encrypted Password option to provide an encrypted password.\nFor more details on encrypting passwords, see Help Center."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string RootPassword
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Answer values can be provided from three sources - Embedded in OS image, static file,\nor as placeholder values for an answer file template.\nSource of the answers is given as value, Embedded/File/Template.\n'Embedded' option indicates that the answer file is embedded within the OS Image. 'File'\noption indicates that the answers are provided as a file. 'Template' indicates that the\nplaceholders in the selected os.ConfigurationFile MO are replaced with values provided\nas os.Answers MO.\n* `None` - Indicates that answers is not sent and values must be populated from Install Template.  \n* `Embedded` - Indicates that the answer file is embedded within OS image.\n* `File` - Indicates that the answer file is a static content that has all thevalues populated.\n* `Template` - Indicates that the given answers are used to populate the answer filetemplate. The template allows the users to refer some server specificanswers as fields/placeholders and replace these placeholders with theactual values for each Server during OS installation using 'Answers' and'AdditionalParameters' properties in os.Install MO.The answer file templates can be created by users as os.ConfigurationFile objects."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public OsAnswers.SourceEnum Source
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.OsAnswers initObject = new Intersight.Model.OsAnswers();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AlternateNameServers"))
            {
                initObject.AlternateNameServers = this.AlternateNameServers;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AnswerFile"))
            {
                initObject.AnswerFile = this.AnswerFile;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Hostname"))
            {
                initObject.Hostname = this.Hostname;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IpConfigType"))
            {
                initObject.IpConfigType = this.IpConfigType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IpConfiguration"))
            {
                initObject.IpConfiguration = this.IpConfiguration;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IsRootPasswordCrypted"))
            {
                initObject.IsRootPasswordCrypted = this.IsRootPasswordCrypted;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Nameserver"))
            {
                initObject.Nameserver = this.Nameserver;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NetworkDevice"))
            {
                initObject.NetworkDevice = this.NetworkDevice;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("ProductKey"))
            {
                initObject.ProductKey = this.ProductKey;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RootPassword"))
            {
                initObject.RootPassword = this.RootPassword;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Source"))
            {
                initObject.Source = this.Source;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize OsBulkInstallInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightOsBulkInstallInfo")]
    public class InitializeIntersightOsBulkInstallInfo : PSCmdlet
    {
        public InitializeIntersightOsBulkInstallInfo()
        {
            ClassId = OsBulkInstallInfo.ClassIdEnum.OsBulkInstallInfo;
            ObjectType = OsBulkInstallInfo.ObjectTypeEnum.OsBulkInstallInfo;

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

        public OsBulkInstallInfo.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a osConfigurationFile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.OsConfigurationFileRelationship ConfigurationFile
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The content of the entire CSV file is stored as value. The content can hold complete OS install parameters in two sections.\nThe first section holds generic information about the OS Install like OS Image, SCU Image etc. The second section holds\nparameters which are specific to each server level data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string FileContent
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
        /// <para type="description">"The name of the CSV file, which holds the OS install parameters."</para>
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

        public OsBulkInstallInfo.ObjectTypeEnum ObjectType
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
        /// <para type="description">"A reference to a softwarerepositoryOperatingSystemFile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.SoftwarerepositoryOperatingSystemFileRelationship OsImage
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a firmwareServerConfigurationUtilityDistributable resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.FirmwareServerConfigurationUtilityDistributableRelationship ScuImage
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to computePhysical resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.ComputePhysicalRelationship> Servers
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

        public List<Model.OsValidationInformation> ValidationInfos
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.OsBulkInstallInfo initObject = new Intersight.Model.OsBulkInstallInfo();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ConfigurationFile"))
            {
                initObject.ConfigurationFile = this.ConfigurationFile;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FileContent"))
            {
                initObject.FileContent = this.FileContent;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("OsImage"))
            {
                initObject.OsImage = this.OsImage;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ScuImage"))
            {
                initObject.ScuImage = this.ScuImage;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Servers"))
            {
                initObject.Servers = this.Servers;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ValidationInfos"))
            {
                initObject.ValidationInfos = this.ValidationInfos;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize OsCatalog.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightOsCatalog")]
    public class InitializeIntersightOsCatalog : PSCmdlet
    {
        public InitializeIntersightOsCatalog()
        {
            ClassId = OsCatalog.ClassIdEnum.OsCatalog;
            ObjectType = OsCatalog.ObjectTypeEnum.OsCatalog;

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

        public OsCatalog.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to osConfigurationFile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.OsConfigurationFileRelationship> ConfigurationFiles
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to osDistribution resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.OsDistributionRelationship> Distributions
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
        /// <para type="description">"The catalog name. There will be one for system and one for each user account."</para>
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

        public OsCatalog.ObjectTypeEnum ObjectType
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
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.OsCatalog initObject = new Intersight.Model.OsCatalog();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ConfigurationFiles"))
            {
                initObject.ConfigurationFiles = this.ConfigurationFiles;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Distributions"))
            {
                initObject.Distributions = this.Distributions;
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
    /// <para type="synopsis">This is the cmdlet to Initialize OsConfigurationFile.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightOsConfigurationFile")]
    public class InitializeIntersightOsConfigurationFile : PSCmdlet
    {
        public InitializeIntersightOsConfigurationFile()
        {
            ClassId = OsConfigurationFile.ClassIdEnum.OsConfigurationFile;
            ObjectType = OsConfigurationFile.ObjectTypeEnum.OsConfigurationFile;

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
        /// <para type="description">"A reference to a osCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.OsCatalogRelationship Catalog
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public OsConfigurationFile.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the OS ConfigurationFile."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to hclOperatingSystem resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.HclOperatingSystemRelationship> Distributions
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The content of the entire configuration file is stored as value. The content\ncan either be a static file content or a template content.\nThe template is expected to conform to the golang template syntax. The values\nfrom os.Answers properties will be used to populate this template."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string FileContent
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The internal flag is set to true when configuration file is uploaded from OS Install wizard. Internal Configuration files will not be displayed in Answer Management Page."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Internal
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
        /// <para type="description">"The name of the OS ConfigurationFile that uniquely identifies the configuration file."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9\\._\\-]+$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public OsConfigurationFile.ObjectTypeEnum ObjectType
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
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.OsConfigurationFile initObject = new Intersight.Model.OsConfigurationFile();
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Distributions"))
            {
                initObject.Distributions = this.Distributions;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FileContent"))
            {
                initObject.FileContent = this.FileContent;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Internal"))
            {
                initObject.Internal = this.Internal;
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
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize OsDistribution.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightOsDistribution")]
    public class InitializeIntersightOsDistribution : PSCmdlet
    {
        public InitializeIntersightOsDistribution()
        {
            ClassId = OsDistribution.ClassIdEnum.OsDistribution;
            ObjectType = OsDistribution.ObjectTypeEnum.OsDistribution;

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
        /// <para type="description">"A reference to a osCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.OsCatalogRelationship Catalog
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public OsDistribution.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The label of the OS distribution such as ESXi, CentOS to be displayed."</para>
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
        /// <para type="description">"The name of the OS distribution such as ESXi, CentOS."</para>
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

        public OsDistribution.ObjectTypeEnum ObjectType
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
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.OsDistribution initObject = new Intersight.Model.OsDistribution();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Catalog"))
            {
                initObject.Catalog = this.Catalog;
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
    /// <para type="synopsis">This is the cmdlet to Initialize OsFibreChannelTarget.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightOsFibreChannelTarget")]
    public class InitializeIntersightOsFibreChannelTarget : PSCmdlet
    {
        public InitializeIntersightOsFibreChannelTarget()
        {
            ClassId = OsFibreChannelTarget.ClassIdEnum.OsFibreChannelTarget;
            ObjectType = OsFibreChannelTarget.ObjectTypeEnum.OsFibreChannelTarget;

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

        public OsFibreChannelTarget.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The WWPN Address of the underlying fibre channel interface at initator used for SAN boot. Value must be in hexadecimal format xx:xx:xx:xx:xx:xx:xx:xx.  For example, 20:00:D4:C9:3C:35:02:01."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("(^([0-9a-fA-F]{2}:){7}[0-9a-fA-F]{2}$)")]
        public string InitiatorWwpn
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Logical Unit Number (LUN) of the install target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long LunId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public OsFibreChannelTarget.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The WWPN Address of the underlying fibre channel interface at target used by the SAN boot device. Value must be in hexadecimal format xx:xx:xx:xx:xx:xx:xx:xx.  For example, 51:4F:0C:50:14:1F:AF:01."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("(^([0-9a-fA-F]{2}:){7}[0-9a-fA-F]{2}$)")]
        public string TargetWwpn
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.OsFibreChannelTarget initObject = new Intersight.Model.OsFibreChannelTarget();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("InitiatorWwpn"))
            {
                initObject.InitiatorWwpn = this.InitiatorWwpn;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LunId"))
            {
                initObject.LunId = this.LunId;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("TargetWwpn"))
            {
                initObject.TargetWwpn = this.TargetWwpn;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize OsGlobalConfig.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightOsGlobalConfig")]
    public class InitializeIntersightOsGlobalConfig : PSCmdlet
    {
        public InitializeIntersightOsGlobalConfig()
        {
            ClassId = OsGlobalConfig.ClassIdEnum.OsGlobalConfig;
            ObjectType = OsGlobalConfig.ObjectTypeEnum.OsGlobalConfig;

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

        public OsGlobalConfig.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public OsGlobalConfig.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"ESXi Secure Boot installation is currently not supported. As a workaround, Secure Boot will be disabled before installation and restored after installation is complete. Enable to Override Secure Boot Configuration."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool OverrideSecureBoot
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.OsGlobalConfig initObject = new Intersight.Model.OsGlobalConfig();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("OverrideSecureBoot"))
            {
                initObject.OverrideSecureBoot = this.OverrideSecureBoot;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize OsInstall.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightOsInstall")]
    public class InitializeIntersightOsInstall : PSCmdlet
    {
        public InitializeIntersightOsInstall()
        {
            ClassId = OsInstall.ClassIdEnum.OsInstall;
            InstallMethod = OsInstall.InstallMethodEnum.VMedia;
            ObjectType = OsInstall.ObjectTypeEnum.OsInstall;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.OsPlaceHolder> AdditionalParameters
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
        /// <para type="description">"Answers provided by user for the unattended OS installation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.OsAnswers Answers
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public OsInstall.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a osConfigurationFile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.OsConfigurationFileRelationship ConfigurationFile
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"User provided description about the OS install configuration."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a softwarerepositoryOperatingSystemFile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.SoftwarerepositoryOperatingSystemFileRelationship Image
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The install method to be used for OS installation - vMedia, iPXE. \nOnly vMedia is supported as of now.\n* `vMedia` - OS image is mounted as vMedia in target server for OS installation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public OsInstall.InstallMethodEnum InstallMethod
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Install Target on which Operating system is installed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.OsInstallTarget InstallTarget
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
        /// <para type="description">"The name of the OS install configuration."</para>
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

        public OsInstall.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Parameters specific to selected OS."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.OsOperatingSystemParameters OperatingSystemParameters
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
        /// <para type="description">"A reference to a firmwareServerConfigurationUtilityDistributable resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.FirmwareServerConfigurationUtilityDistributableRelationship OsduImage
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"ESXi Secure Boot installation is currently not supported. As a workaround, Secure Boot will be disabled before installation and restored after installation is complete. Enable to Override Secure Boot Configuration."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool OverrideSecureBoot
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
        /// <para type="description">"A reference to a workflowWorkflowInfo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkflowWorkflowInfoRelationship WorkflowInfo
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.OsInstall initObject = new Intersight.Model.OsInstall();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalParameters"))
            {
                initObject.AdditionalParameters = this.AdditionalParameters;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Answers"))
            {
                initObject.Answers = this.Answers;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ConfigurationFile"))
            {
                initObject.ConfigurationFile = this.ConfigurationFile;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Image"))
            {
                initObject.Image = this.Image;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InstallMethod"))
            {
                initObject.InstallMethod = this.InstallMethod;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InstallTarget"))
            {
                initObject.InstallTarget = this.InstallTarget;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("OperatingSystemParameters"))
            {
                initObject.OperatingSystemParameters = this.OperatingSystemParameters;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Organization"))
            {
                initObject.Organization = this.Organization;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("OsduImage"))
            {
                initObject.OsduImage = this.OsduImage;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("OverrideSecureBoot"))
            {
                initObject.OverrideSecureBoot = this.OverrideSecureBoot;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Server"))
            {
                initObject.Server = this.Server;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("WorkflowInfo"))
            {
                initObject.WorkflowInfo = this.WorkflowInfo;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize OsInstallTarget.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightOsInstallTarget")]
    public class InitializeIntersightOsInstallTarget : PSCmdlet
    {
        public InitializeIntersightOsInstallTarget()
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

        public OsInstallTarget.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public OsInstallTarget.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.OsInstallTarget initObject = new Intersight.Model.OsInstallTarget();
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
    /// <para type="synopsis">This is the cmdlet to Initialize OsInstallTargetResponse.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightOsInstallTargetResponse")]
    public class InitializeIntersightOsInstallTargetResponse : PSCmdlet
    {
        public InitializeIntersightOsInstallTargetResponse()
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

        public OsInstallTargetResponse.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public OsInstallTargetResponse.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Mo Reference of the LUN in CmRf format."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.MoMoRef SourceMo
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.OsInstallTargetResponse initObject = new Intersight.Model.OsInstallTargetResponse();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("SourceMo"))
            {
                initObject.SourceMo = this.SourceMo;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize OsIpConfiguration.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightOsIpConfiguration")]
    public class InitializeIntersightOsIpConfiguration : PSCmdlet
    {
        public InitializeIntersightOsIpConfiguration()
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

        public OsIpConfiguration.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public OsIpConfiguration.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.OsIpConfiguration initObject = new Intersight.Model.OsIpConfiguration();
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
    /// <para type="synopsis">This is the cmdlet to Initialize OsIpv4Configuration.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightOsIpv4Configuration")]
    public class InitializeIntersightOsIpv4Configuration : PSCmdlet
    {
        public InitializeIntersightOsIpv4Configuration()
        {
            ClassId = OsIpv4Configuration.ClassIdEnum.OsIpv4Configuration;
            ObjectType = OsIpv4Configuration.ObjectTypeEnum.OsIpv4Configuration;

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

        public OsIpv4Configuration.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"In case of static IP configuration, IP address, netmask and gateway details are\nprovided."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.CommIpV4Interface IpV4Config
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public OsIpv4Configuration.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.OsIpv4Configuration initObject = new Intersight.Model.OsIpv4Configuration();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("IpV4Config"))
            {
                initObject.IpV4Config = this.IpV4Config;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize OsIpv6Configuration.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightOsIpv6Configuration")]
    public class InitializeIntersightOsIpv6Configuration : PSCmdlet
    {
        public InitializeIntersightOsIpv6Configuration()
        {
            ClassId = OsIpv6Configuration.ClassIdEnum.OsIpv6Configuration;
            ObjectType = OsIpv6Configuration.ObjectTypeEnum.OsIpv6Configuration;

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

        public OsIpv6Configuration.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"In case of static IP configuration, IP address, netmask and gateway details are\nprovided."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.CommIpV6Interface IpV6Config
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public OsIpv6Configuration.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.OsIpv6Configuration initObject = new Intersight.Model.OsIpv6Configuration();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("IpV6Config"))
            {
                initObject.IpV6Config = this.IpV6Config;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize OsIscsiTarget.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightOsIscsiTarget")]
    public class InitializeIntersightOsIscsiTarget : PSCmdlet
    {
        public InitializeIntersightOsIscsiTarget()
        {
            ClassId = OsIscsiTarget.ClassIdEnum.OsIscsiTarget;
            ObjectType = OsIscsiTarget.ObjectTypeEnum.OsIscsiTarget;

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

        public OsIscsiTarget.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Logical Unit Number (LUN) of the install target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long LunId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public OsIscsiTarget.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"IQN (iSCSI qualified name) of Storage iSCSI target.Can be up to 255 characters long and has the following format, iqn.yyyy-mm.naming-authority:unique_name."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^(iqn\\.(\\d{4}-(0[1-9]|1[0-2]))\\.([a-zA-Z0-9]+)([a-zA-Z0-9-.]*)(:)+([^,\\s']+))$")]
        public string TargetIqn
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"MAC address of the VNIC used as iSCSI initiator interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^([0-9A-Fa-f]{2}[:]){5}([0-9A-Fa-f]{2})$")]
        public string VnicMac
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.OsIscsiTarget initObject = new Intersight.Model.OsIscsiTarget();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("LunId"))
            {
                initObject.LunId = this.LunId;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("TargetIqn"))
            {
                initObject.TargetIqn = this.TargetIqn;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VnicMac"))
            {
                initObject.VnicMac = this.VnicMac;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize OsOperatingSystemParameters.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightOsOperatingSystemParameters")]
    public class InitializeIntersightOsOperatingSystemParameters : PSCmdlet
    {
        public InitializeIntersightOsOperatingSystemParameters()
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

        public OsOperatingSystemParameters.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public OsOperatingSystemParameters.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.OsOperatingSystemParameters initObject = new Intersight.Model.OsOperatingSystemParameters();
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
    /// <para type="synopsis">This is the cmdlet to Initialize OsOsSupport.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightOsOsSupport")]
    public class InitializeIntersightOsOsSupport : PSCmdlet
    {
        public InitializeIntersightOsOsSupport()
        {
            ClassId = OsOsSupport.ClassIdEnum.OsOsSupport;
            ObjectType = OsOsSupport.ObjectTypeEnum.OsOsSupport;

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

        public OsOsSupport.ClassIdEnum ClassId
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

        public OsOsSupport.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The version of the Operating System to be validated. The version should be as per HCL."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string OsVersion
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
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.OsOsSupport initObject = new Intersight.Model.OsOsSupport();
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
            if (this.MyInvocation.BoundParameters.ContainsKey("OsVersion"))
            {
                initObject.OsVersion = this.OsVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize OsPhysicalDisk.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightOsPhysicalDisk")]
    public class InitializeIntersightOsPhysicalDisk : PSCmdlet
    {
        public InitializeIntersightOsPhysicalDisk()
        {
            ClassId = OsPhysicalDisk.ClassIdEnum.OsPhysicalDisk;
            ObjectType = OsPhysicalDisk.ObjectTypeEnum.OsPhysicalDisk;

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

        public OsPhysicalDisk.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Physical Disk Name to be used as Install Target."</para>
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

        public OsPhysicalDisk.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Serial Number of the Physical Disk Target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SerialNumber
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The SlotID of the Storage Controller associated to the physical disk."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string StorageControllerSlotId
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.OsPhysicalDisk initObject = new Intersight.Model.OsPhysicalDisk();
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
            if (this.MyInvocation.BoundParameters.ContainsKey("SerialNumber"))
            {
                initObject.SerialNumber = this.SerialNumber;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("StorageControllerSlotId"))
            {
                initObject.StorageControllerSlotId = this.StorageControllerSlotId;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize OsPhysicalDiskResponse.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightOsPhysicalDiskResponse")]
    public class InitializeIntersightOsPhysicalDiskResponse : PSCmdlet
    {
        public InitializeIntersightOsPhysicalDiskResponse()
        {
            ClassId = OsPhysicalDiskResponse.ClassIdEnum.OsPhysicalDiskResponse;
            ObjectType = OsPhysicalDiskResponse.ObjectTypeEnum.OsPhysicalDiskResponse;

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
        /// <para type="description">"Bootable field of the Physical Drive target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Bootable
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public OsPhysicalDiskResponse.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Physical Disk Name to be used as Install Target."</para>
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

        public OsPhysicalDiskResponse.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Serial Number of the Physical Disk Target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SerialNumber
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Mo Reference of the LUN in CmRf format."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.MoMoRef SourceMo
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Storage Controller associated to the physical disk."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string StorageControllerSlotId
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.OsPhysicalDiskResponse initObject = new Intersight.Model.OsPhysicalDiskResponse();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Bootable"))
            {
                initObject.Bootable = this.Bootable;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("SerialNumber"))
            {
                initObject.SerialNumber = this.SerialNumber;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SourceMo"))
            {
                initObject.SourceMo = this.SourceMo;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("StorageControllerSlotId"))
            {
                initObject.StorageControllerSlotId = this.StorageControllerSlotId;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize OsPlaceHolder.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightOsPlaceHolder")]
    public class InitializeIntersightOsPlaceHolder : PSCmdlet
    {
        public InitializeIntersightOsPlaceHolder()
        {
            ClassId = OsPlaceHolder.ClassIdEnum.OsPlaceHolder;
            ObjectType = OsPlaceHolder.ObjectTypeEnum.OsPlaceHolder;

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

        public OsPlaceHolder.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Flag to indicate if value is set. Value will be used to check if any edit."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool IsValueSet
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public OsPlaceHolder.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Definition of place holder."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object Type
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Value for placeholder provided by user."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object Value
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.OsPlaceHolder initObject = new Intersight.Model.OsPlaceHolder();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("IsValueSet"))
            {
                initObject.IsValueSet = this.IsValueSet;
            }
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
    /// <para type="synopsis">This is the cmdlet to Initialize OsServerConfig.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightOsServerConfig")]
    public class InitializeIntersightOsServerConfig : PSCmdlet
    {
        public InitializeIntersightOsServerConfig()
        {
            ClassId = OsServerConfig.ClassIdEnum.OsServerConfig;
            ObjectType = OsServerConfig.ObjectTypeEnum.OsServerConfig;

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

        public OsServerConfig.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public OsServerConfig.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.OsServerConfig initObject = new Intersight.Model.OsServerConfig();
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
    /// <para type="synopsis">This is the cmdlet to Initialize OsSupportedVersion.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightOsSupportedVersion")]
    public class InitializeIntersightOsSupportedVersion : PSCmdlet
    {
        public InitializeIntersightOsSupportedVersion()
        {
            ClassId = OsSupportedVersion.ClassIdEnum.OsSupportedVersion;
            ObjectType = OsSupportedVersion.ObjectTypeEnum.OsSupportedVersion;

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

        public OsSupportedVersion.ClassIdEnum ClassId
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

        public OsSupportedVersion.ObjectTypeEnum ObjectType
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
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.OsSupportedVersion initObject = new Intersight.Model.OsSupportedVersion();
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
    /// <para type="synopsis">This is the cmdlet to Initialize OsTemplateFile.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightOsTemplateFile")]
    public class InitializeIntersightOsTemplateFile : PSCmdlet
    {
        public InitializeIntersightOsTemplateFile()
        {
            ClassId = OsTemplateFile.ClassIdEnum.OsTemplateFile;
            ObjectType = OsTemplateFile.ObjectTypeEnum.OsTemplateFile;

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

        public OsTemplateFile.ClassIdEnum ClassId
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
        /// <para type="description">"The name of the OS Template File that user uploads for unattended installation."</para>
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

        public OsTemplateFile.ObjectTypeEnum ObjectType
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
        /// <para type="description">"The content of the entire template file is stored as value. The content\ncan either be a static file content or a template content.\nThe template is expected to conform to the golang template syntax. \nThe placeholders, if any, would be populated and the values provided would be \nused to populate this template."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string TemplateContent
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.OsTemplateFile initObject = new Intersight.Model.OsTemplateFile();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("TemplateContent"))
            {
                initObject.TemplateContent = this.TemplateContent;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize OsValidInstallTarget.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightOsValidInstallTarget")]
    public class InitializeIntersightOsValidInstallTarget : PSCmdlet
    {
        public InitializeIntersightOsValidInstallTarget()
        {
            ClassId = OsValidInstallTarget.ClassIdEnum.OsValidInstallTarget;
            ObjectType = OsValidInstallTarget.ObjectTypeEnum.OsValidInstallTarget;

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

        public OsValidInstallTarget.ClassIdEnum ClassId
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

        public OsValidInstallTarget.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to computePhysical resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.ComputePhysicalRelationship> Servers
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Flag to denote the source of the request.\nIf the call is from Orchestration UI, only the flat list of Install targets can be sent as response."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Src
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
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.OsValidInstallTarget initObject = new Intersight.Model.OsValidInstallTarget();
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Servers"))
            {
                initObject.Servers = this.Servers;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Src"))
            {
                initObject.Src = this.Src;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize OsValidationInformation.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightOsValidationInformation")]
    public class InitializeIntersightOsValidationInformation : PSCmdlet
    {
        public InitializeIntersightOsValidationInformation()
        {
            ClassId = OsValidationInformation.ClassIdEnum.OsValidationInformation;
            ObjectType = OsValidationInformation.ObjectTypeEnum.OsValidationInformation;

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

        public OsValidationInformation.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public OsValidationInformation.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.OsValidationInformation initObject = new Intersight.Model.OsValidationInformation();
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
    /// <para type="synopsis">This is the cmdlet to Initialize OsVirtualDrive.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightOsVirtualDrive")]
    public class InitializeIntersightOsVirtualDrive : PSCmdlet
    {
        public InitializeIntersightOsVirtualDrive()
        {
            ClassId = OsVirtualDrive.ClassIdEnum.OsVirtualDrive;
            ObjectType = OsVirtualDrive.ObjectTypeEnum.OsVirtualDrive;

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

        public OsVirtualDrive.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Virtual Drive ID to be used as Install Target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Id
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Virtual Drive Name to be used as Install Target."</para>
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

        public OsVirtualDrive.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The SlotID of the Storage Controller associated to the virtual drive."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string StorageControllerSlotId
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.OsVirtualDrive initObject = new Intersight.Model.OsVirtualDrive();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Id"))
            {
                initObject.Id = this.Id;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("StorageControllerSlotId"))
            {
                initObject.StorageControllerSlotId = this.StorageControllerSlotId;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize OsVirtualDriveResponse.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightOsVirtualDriveResponse")]
    public class InitializeIntersightOsVirtualDriveResponse : PSCmdlet
    {
        public InitializeIntersightOsVirtualDriveResponse()
        {
            ClassId = OsVirtualDriveResponse.ClassIdEnum.OsVirtualDriveResponse;
            ObjectType = OsVirtualDriveResponse.ObjectTypeEnum.OsVirtualDriveResponse;

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
        /// <para type="description">"Bootable field of the Virtual Drive target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Bootable
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public OsVirtualDriveResponse.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Virtual Drive ID to be used as Install Target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Id
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Virtual Drive Name to be used as Install Target."</para>
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

        public OsVirtualDriveResponse.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Mo Reference of the LUN in CmRf format."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.MoMoRef SourceMo
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Storage Controller associated to the virtual drive."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string StorageControllerSlotId
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.OsVirtualDriveResponse initObject = new Intersight.Model.OsVirtualDriveResponse();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Bootable"))
            {
                initObject.Bootable = this.Bootable;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Id"))
            {
                initObject.Id = this.Id;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("SourceMo"))
            {
                initObject.SourceMo = this.SourceMo;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("StorageControllerSlotId"))
            {
                initObject.StorageControllerSlotId = this.StorageControllerSlotId;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize OsVmwareParameters.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightOsVmwareParameters")]
    public class InitializeIntersightOsVmwareParameters : PSCmdlet
    {
        public InitializeIntersightOsVmwareParameters()
        {
            ClassId = OsVmwareParameters.ClassIdEnum.OsVmwareParameters;
            ObjectType = OsVmwareParameters.ObjectTypeEnum.OsVmwareParameters;

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

        public OsVmwareParameters.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public OsVmwareParameters.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Specify the VLAN ID in which the ESXi host is turned on. Valid values ranges between 1 – 4095."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 4095)]
        public long Vlanid
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.OsVmwareParameters initObject = new Intersight.Model.OsVmwareParameters();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Vlanid"))
            {
                initObject.Vlanid = this.Vlanid;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize OsWindowsParameters.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightOsWindowsParameters")]
    public class InitializeIntersightOsWindowsParameters : PSCmdlet
    {
        public InitializeIntersightOsWindowsParameters()
        {
            ClassId = OsWindowsParameters.ClassIdEnum.OsWindowsParameters;
            Edition = OsWindowsParameters.EditionEnum.Standard;
            ObjectType = OsWindowsParameters.ObjectTypeEnum.OsWindowsParameters;

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

        public OsWindowsParameters.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Lists all the editions supported for Windows Server installation.\n* `Standard` - Windows Standard Edition ideal for advanced features with limited virtualization.\n* `StandardCore` - Windows Standard Core Edition is a minimal installation option while installing Standard Core that is ideal for advanced features with limited virtualization.\n* `Datacenter` - Windows Standard Core Edition ideal for high requirements on IT workloads with largenumber fo virtual systems.\n* `DatacenterCore` - Windows Datacenter Core Edition is a minimal installation option while installing Datacenter Core that isideal for high requirements on IT workloads with largenumber for virtual systems.\n* `Core` - Microsoft Hyper-V is a native hypervisor to create and run virtual machines."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public OsWindowsParameters.EditionEnum Edition
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public OsWindowsParameters.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.OsWindowsParameters initObject = new Intersight.Model.OsWindowsParameters();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Edition"))
            {
                initObject.Edition = this.Edition;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
}