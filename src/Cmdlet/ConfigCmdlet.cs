using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get ConfigExportedItem.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightConfigExportedItem", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightConfigExportedItem:GetCmdletBase
	{
		public GetIntersightConfigExportedItem()
		{
			ApiInstance = new ConfigApi(Config);
            MethodName = "GetConfigExportedItemList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get ConfigImportedItem.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightConfigImportedItem", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightConfigImportedItem:GetCmdletBase
	{
		public GetIntersightConfigImportedItem()
		{
			ApiInstance = new ConfigApi(Config);
            MethodName = "GetConfigImportedItemList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove ConfigImporter.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightConfigImporter")]
    public class RemoveIntersightConfigImporter:RemoveCmdletBase
	{
		public RemoveIntersightConfigImporter()
		{
			ApiInstance = new ConfigApi(Config);
            MethodName = "DeleteConfigImporter";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get ConfigImporter.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightConfigImporter", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightConfigImporter:GetCmdletBase
	{
		public GetIntersightConfigImporter()
		{
			ApiInstance = new ConfigApi(Config);
            MethodName = "GetConfigImporterList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New ConfigImporter.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightConfigImporter")]
    public class NewIntersightConfigImporter:NewCmdletBase
	{
		public NewIntersightConfigImporter()
		{
			ApiInstance = new ConfigApi(Config);
            ModelObject = new ConfigImporter();
            MethodName = "CreateConfigImporter";
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
        /// <para type="description">"The path to the archive in Intersight storage that has all the MOs\nto be imported."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ImportPath {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The source of the archive in Intersight storage that has all the MOs\nto be imported.\n* `ImageRepo` - The 'ImageRepo' source if the source of exporter archive is image repository.\n* `URL` - The 'URL' source if the source of exported archive is a URL."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ConfigImporter.ImportSourceEnum ImportSource {
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
        /// <para type="description">"An identifier for the importer instance."</para>
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
        /// <para type="description">"Specifies whether integrity checks must be skipped."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool SkipIntegrityChecks {
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
    /// <para type="synopsis">This is the cmdlet to Get ConfigExporter.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightConfigExporter", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightConfigExporter:GetCmdletBase
	{
		public GetIntersightConfigExporter()
		{
			ApiInstance = new ConfigApi(Config);
            MethodName = "GetConfigExporterList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New ConfigExporter.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightConfigExporter")]
    public class NewIntersightConfigExporter:NewCmdletBase
	{
		public NewIntersightConfigExporter()
		{
			ApiInstance = new ConfigApi(Config);
            ModelObject = new ConfigExporter();
            MethodName = "CreateConfigExporter";
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
        
        public List<ConfigMoRef> Items {
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
        /// <para type="description">"An identifier for the exporter instance."</para>
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove ConfigExporter.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightConfigExporter")]
    public class RemoveIntersightConfigExporter:RemoveCmdletBase
	{
		public RemoveIntersightConfigExporter()
		{
			ApiInstance = new ConfigApi(Config);
            MethodName = "DeleteConfigExporter";
		}
    }
}