using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New OsTemplateFile.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightOsTemplateFile")]
    public class NewIntersightOsTemplateFile:NewCmdletBase
	{
		public NewIntersightOsTemplateFile()
		{
			ApiInstance = new OsApi(Config);
            ModelObject = new OsTemplateFile();
            MethodName = "CreateOsTemplateFileWithHttpInfo";
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
        /// <para type="description">"The name of the OS Template File that user uploads for unattended installation."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> Placeholders {
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
        /// <para type="description">"The content of the entire template file is stored as value. The content\ncan either be a static file content or a template content.\nThe template is expected to conform to the golang template syntax. \nThe placeholders, if any, would be populated and the values provided would be \nused to populate this template."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string TemplateContent {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get OsConfigurationFile.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightOsConfigurationFile", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightOsConfigurationFile:GetCmdletBase
	{
		public GetIntersightOsConfigurationFile()
		{
			ApiInstance = new OsApi(Config);
            MethodName = "GetOsConfigurationFileListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New OsConfigurationFile.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightOsConfigurationFile")]
    public class NewIntersightOsConfigurationFile:NewCmdletBase
	{
		public NewIntersightOsConfigurationFile()
		{
			ApiInstance = new OsApi(Config);
            ModelObject = new OsConfigurationFile();
            MethodName = "CreateOsConfigurationFileWithHttpInfo";
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
        /// <para type="description">"A reference to a osCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OsCatalogRelationship Catalog {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the OS ConfigurationFile."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to hclOperatingSystem resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<HclOperatingSystemRelationship> Distributions {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The content of the entire configuration file is stored as value. The content\ncan either be a static file content or a template content.\nThe template is expected to conform to the golang template syntax. The values\nfrom os.Answers properties will be used to populate this template."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string FileContent {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The internal flag is set to true when configuration file is uploaded from OS Install wizard. Internal Configuration files will not be displayed in Answer Management Page."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Internal {
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
        /// <para type="description">"The name of the OS ConfigurationFile that uniquely identifies the configuration file."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9\\._\\-]+$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<OsPlaceHolder> Placeholders {
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
    /// <para type="synopsis">This is the cmdlet to Remove OsConfigurationFile.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightOsConfigurationFile")]
    public class RemoveIntersightOsConfigurationFile:RemoveCmdletBase
	{
		public RemoveIntersightOsConfigurationFile()
		{
			ApiInstance = new OsApi(Config);
            MethodName = "DeleteOsConfigurationFileWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set OsConfigurationFile.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightOsConfigurationFile")]
    public class SetIntersightOsConfigurationFile:SetCmdletBase
	{
		public SetIntersightOsConfigurationFile()
		{
			ApiInstance = new OsApi(Config);
            ModelObject = new OsConfigurationFile();
            MethodName = "UpdateOsConfigurationFileWithHttpInfo";
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
        /// <para type="description">"A reference to a osCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OsCatalogRelationship Catalog {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the OS ConfigurationFile."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to hclOperatingSystem resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<HclOperatingSystemRelationship> Distributions {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The content of the entire configuration file is stored as value. The content\ncan either be a static file content or a template content.\nThe template is expected to conform to the golang template syntax. The values\nfrom os.Answers properties will be used to populate this template."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string FileContent {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The internal flag is set to true when configuration file is uploaded from OS Install wizard. Internal Configuration files will not be displayed in Answer Management Page."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Internal {
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
        /// <para type="description">"The name of the OS ConfigurationFile that uniquely identifies the configuration file."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9\\._\\-]+$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<OsPlaceHolder> Placeholders {
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
    /// <para type="synopsis">This is the cmdlet to Get OsDistribution.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightOsDistribution", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightOsDistribution:GetCmdletBase
	{
		public GetIntersightOsDistribution()
		{
			ApiInstance = new OsApi(Config);
            MethodName = "GetOsDistributionListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get OsCatalog.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightOsCatalog", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightOsCatalog:GetCmdletBase
	{
		public GetIntersightOsCatalog()
		{
			ApiInstance = new OsApi(Config);
            MethodName = "GetOsCatalogListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get OsBulkInstallInfo.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightOsBulkInstallInfo", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightOsBulkInstallInfo:GetCmdletBase
	{
		public GetIntersightOsBulkInstallInfo()
		{
			ApiInstance = new OsApi(Config);
            MethodName = "GetOsBulkInstallInfoListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New OsBulkInstallInfo.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightOsBulkInstallInfo")]
    public class NewIntersightOsBulkInstallInfo:NewCmdletBase
	{
		public NewIntersightOsBulkInstallInfo()
		{
			ApiInstance = new OsApi(Config);
            ModelObject = new OsBulkInstallInfo();
            MethodName = "CreateOsBulkInstallInfoWithHttpInfo";
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
        /// <para type="description">"A reference to a osConfigurationFile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OsConfigurationFileRelationship ConfigurationFile {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The content of the entire CSV file is stored as value. The content can hold complete OS install parameters in two sections.\nThe first section holds generic information about the OS Install like OS Image, SCU Image etc. The second section holds\nparameters which are specific to each server level data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string FileContent {
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
        /// <para type="description">"The name of the CSV file, which holds the OS install parameters."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a softwarerepositoryOperatingSystemFile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public SoftwarerepositoryOperatingSystemFileRelationship OsImage {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a firmwareServerConfigurationUtilityDistributable resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareServerConfigurationUtilityDistributableRelationship ScuImage {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<OsServerConfig> ServerConfigs {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to computePhysical resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<ComputePhysicalRelationship> Servers {
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
        
        public List<OsValidationInformation> ValidationInfos {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get OsInstall.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightOsInstall", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightOsInstall:GetCmdletBase
	{
		public GetIntersightOsInstall()
		{
			ApiInstance = new OsApi(Config);
            MethodName = "GetOsInstallListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New OsInstall.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightOsInstall")]
    public class NewIntersightOsInstall:NewCmdletBase
	{
		public NewIntersightOsInstall()
		{
			ApiInstance = new OsApi(Config);
            ModelObject = new OsInstall();
            MethodName = "CreateOsInstallWithHttpInfo";
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<OsPlaceHolder> AdditionalParameters {
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
        /// <para type="description">"Answers provided by user for the unattended OS installation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OsAnswers Answers {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a osConfigurationFile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OsConfigurationFileRelationship ConfigurationFile {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"User provided description about the OS install configuration."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a softwarerepositoryOperatingSystemFile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public SoftwarerepositoryOperatingSystemFileRelationship Image {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The install method to be used for OS installation - vMedia, iPXE. \nOnly vMedia is supported as of now.\n* `vMedia` - OS image is mounted as vMedia in target server for OS installation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OsInstall.InstallMethodEnum InstallMethod {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Install Target on which Operating system is installed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OsInstallTarget InstallTarget {
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
        /// <para type="description">"The name of the OS install configuration."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Parameters specific to selected OS."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OsOperatingSystemParameters OperatingSystemParameters {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a firmwareServerConfigurationUtilityDistributable resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareServerConfigurationUtilityDistributableRelationship OsduImage {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a computePhysical resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ComputePhysicalRelationship Server {
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
        /// <para type="description">"A reference to a workflowWorkflowInfo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowWorkflowInfoRelationship WorkflowInfo {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New OsOsSupport.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightOsOsSupport")]
    public class NewIntersightOsOsSupport:NewCmdletBase
	{
		public NewIntersightOsOsSupport()
		{
			ApiInstance = new OsApi(Config);
            ModelObject = new OsOsSupport();
            MethodName = "CreateOsOsSupportWithHttpInfo";
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
        /// <para type="description">"The version of the Operating System to be validated. The version should be as per HCL."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string OsVersion {
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
    /// <para type="synopsis">This is the cmdlet to Get OsSupportedVersion.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightOsSupportedVersion", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightOsSupportedVersion:GetCmdletBase
	{
		public GetIntersightOsSupportedVersion()
		{
			ApiInstance = new OsApi(Config);
            MethodName = "GetOsSupportedVersionListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New OsValidInstallTarget.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightOsValidInstallTarget")]
    public class NewIntersightOsValidInstallTarget:NewCmdletBase
	{
		public NewIntersightOsValidInstallTarget()
		{
			ApiInstance = new OsApi(Config);
            ModelObject = new OsValidInstallTarget();
            MethodName = "CreateOsValidInstallTargetWithHttpInfo";
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
        
        public List<OsInstallTargetResponse> InstallTargets {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<OsPhysicalDiskResponse> M2Jbod {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<OsVirtualDriveResponse> M2VirtualDrives {
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
        
        public List<OsPhysicalDiskResponse> MraidJbod {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<OsVirtualDriveResponse> MraidVirtualDrives {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to computePhysical resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<ComputePhysicalRelationship> Servers {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Flag to denote the source of the request.\nIf the call is from Orchestration UI, only the flat list of Install targets can be sent as response."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Src {
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
}