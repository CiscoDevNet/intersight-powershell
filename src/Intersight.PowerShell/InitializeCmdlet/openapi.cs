using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize OpenapiApiInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightOpenapiApiInfo")]
    public class InitializeIntersightOpenapiApiInfo : PSCmdlet
    {
        public InitializeIntersightOpenapiApiInfo()
        {
            ClassId = OpenapiApiInfo.ClassIdEnum.OpenapiApiInfo;
            Method = OpenapiApiInfo.MethodEnum.GET;
            ObjectType = OpenapiApiInfo.ObjectTypeEnum.OpenapiApiInfo;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Unique identifier for the ApiMethod object that holds more information about this API."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.MoMoRef ApiPathObjectIdentifier
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public OpenapiApiInfo.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A detailed description of the API."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Display name of the selected API endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string DisplayLabel
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Method Type of the selected API.\n* `GET` - Method type which indicates it is a GET API call.\n* `POST` - Method type which indicates it is a POST API call.\n* `PUT` - Method type which indicates it is a PUT API call.\n* `PATCH` - Method type which indicates it is a PATCH API call.\n* `DELETE` - Method type which indicates it is a DELETE API call."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public OpenapiApiInfo.MethodEnum Method
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the selected API endpoint."</para>
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

        public OpenapiApiInfo.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"API Path of the selected API endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Path
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.OpenapiApiInfo initObject = new Intersight.Model.OpenapiApiInfo();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ApiPathObjectIdentifier"))
            {
                initObject.ApiPathObjectIdentifier = this.ApiPathObjectIdentifier;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DisplayLabel"))
            {
                initObject.DisplayLabel = this.DisplayLabel;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Method"))
            {
                initObject.Method = this.Method;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Path"))
            {
                initObject.Path = this.Path;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize OpenapiApiMethodMeta.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightOpenapiApiMethodMeta")]
    public class InitializeIntersightOpenapiApiMethodMeta : PSCmdlet
    {
        public InitializeIntersightOpenapiApiMethodMeta()
        {
            ClassId = OpenapiApiMethodMeta.ClassIdEnum.OpenapiApiMethodMeta;
            ObjectType = OpenapiApiMethodMeta.ObjectTypeEnum.OpenapiApiMethodMeta;

        }
        // <summary>
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

        public OpenapiApiMethodMeta.ClassIdEnum ClassId
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

        public OpenapiApiMethodMeta.ObjectTypeEnum ObjectType
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
            Intersight.Model.OpenapiApiMethodMeta initObject = new Intersight.Model.OpenapiApiMethodMeta();
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
    /// <para type="synopsis">This is the cmdlet to Initialize OpenapiFailedTask.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightOpenapiFailedTask")]
    public class InitializeIntersightOpenapiFailedTask : PSCmdlet
    {
        public InitializeIntersightOpenapiFailedTask()
        {
            ClassId = OpenapiFailedTask.ClassIdEnum.OpenapiFailedTask;
            ObjectType = OpenapiFailedTask.ObjectTypeEnum.OpenapiFailedTask;

        }
        // <summary>
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

        public OpenapiFailedTask.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the task."</para>
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

        public OpenapiFailedTask.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"REST API path of the task."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Path
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Indicates the reason for task creation failure."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Reason
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.OpenapiFailedTask initObject = new Intersight.Model.OpenapiFailedTask();
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Path"))
            {
                initObject.Path = this.Path;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Reason"))
            {
                initObject.Reason = this.Reason;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize OpenapiKeyValuePair.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightOpenapiKeyValuePair")]
    public class InitializeIntersightOpenapiKeyValuePair : PSCmdlet
    {
        public InitializeIntersightOpenapiKeyValuePair()
        {
            ClassId = OpenapiKeyValuePair.ClassIdEnum.OpenapiKeyValuePair;
            ObjectType = OpenapiKeyValuePair.ObjectTypeEnum.OpenapiKeyValuePair;

        }
        // <summary>
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

        public OpenapiKeyValuePair.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the key variable."</para>
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

        public OpenapiKeyValuePair.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Value of the key variable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Value
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.OpenapiKeyValuePair initObject = new Intersight.Model.OpenapiKeyValuePair();
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
    /// <para type="synopsis">This is the cmdlet to Initialize OpenapiOpenApiSpecification.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightOpenapiOpenApiSpecification")]
    public class InitializeIntersightOpenapiOpenApiSpecification : PSCmdlet
    {
        public InitializeIntersightOpenapiOpenApiSpecification()
        {
            ClassId = OpenapiOpenApiSpecification.ClassIdEnum.OpenapiOpenApiSpecification;
            ImportAction = OpenapiOpenApiSpecification.ImportActionEnum.None;
            ObjectType = OpenapiOpenApiSpecification.ObjectTypeEnum.OpenapiOpenApiSpecification;

        }
        // <summary>
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

        public OpenapiOpenApiSpecification.ClassIdEnum ClassId
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
        /// <para type="description">"The action to be performed on the imported file. If 'PreCache' is set, the image will be cached in Appliance. Applicable in Intersight appliance deployment. If 'Evict' is set, the cached file will be removed. Applicable in Intersight appliance deployment. If 'GeneratePreSignedUploadUrl' is set, generates pre signed URL (s) for the file to be imported into the repository. Applicable for local machine source. The URL (s) will be populated under LocalMachine file server. If 'CompleteImportProcess' is set, the ImportState is marked as 'Imported'. Applicable for local machine source. If 'Cancel' is set, the ImportState is marked as 'Failed'. Applicable for local machine source.\n* `None` - No action should be taken on the imported file.\n* `GeneratePreSignedUploadUrl` - Generate pre signed URL of file for importing into the repository.\n* `GeneratePreSignedDownloadUrl` - Generate pre signed URL of file in the repository to download.\n* `CompleteImportProcess` - Mark that the import process of the file into the repository is complete.\n* `MarkImportFailed` - Mark to indicate that the import process of the file into the repository failed.\n* `PreCache` - Cache the file into the Intersight Appliance.\n* `Cancel` - The cancel import process for the file into the repository.\n* `Extract` - The action to extract the file in the external repository.\n* `Evict` - Evict the cached file from the Intersight Appliance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public OpenapiOpenApiSpecification.ImportActionEnum ImportAction
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

        public OpenapiOpenApiSpecification.ObjectTypeEnum ObjectType
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
        /// <para type="description">"The date on which the file was released or distributed by its vendor."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime ReleaseDate
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

        public List<Model.MoTag> Tags
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
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.OpenapiOpenApiSpecification initObject = new Intersight.Model.OpenapiOpenApiSpecification();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("ReleaseDate"))
            {
                initObject.ReleaseDate = this.ReleaseDate;
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
    /// <para type="synopsis">This is the cmdlet to Initialize OpenapiProcessFile.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightOpenapiProcessFile")]
    public class InitializeIntersightOpenapiProcessFile : PSCmdlet
    {
        public InitializeIntersightOpenapiProcessFile()
        {
            ClassId = OpenapiProcessFile.ClassIdEnum.OpenapiProcessFile;
            ObjectType = OpenapiProcessFile.ObjectTypeEnum.OpenapiProcessFile;

        }
        // <summary>
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

        public OpenapiProcessFile.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a openapiOpenApiSpecification resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.OpenapiOpenApiSpecificationRelationship FileInfo
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

        public OpenapiProcessFile.ObjectTypeEnum ObjectType
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
        /// <para type="description">"The location of the previously uploaded OpenAPI specification file."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SpecFilePath
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
            Intersight.Model.OpenapiProcessFile initObject = new Intersight.Model.OpenapiProcessFile();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("FileInfo"))
            {
                initObject.FileInfo = this.FileInfo;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("SpecFilePath"))
            {
                initObject.SpecFilePath = this.SpecFilePath;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize OpenapiTaskGenerationRequest.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightOpenapiTaskGenerationRequest")]
    public class InitializeIntersightOpenapiTaskGenerationRequest : PSCmdlet
    {
        public InitializeIntersightOpenapiTaskGenerationRequest()
        {
            ClassId = OpenapiTaskGenerationRequest.ClassIdEnum.OpenapiTaskGenerationRequest;
            EndpointType = OpenapiTaskGenerationRequest.EndpointTypeEnum.External;
            ObjectType = OpenapiTaskGenerationRequest.ObjectTypeEnum.OpenapiTaskGenerationRequest;
            Protocol = OpenapiTaskGenerationRequest.ProtocolEnum.HTTPS;

        }
        // <summary>
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

        public OpenapiTaskGenerationRequest.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Indicates if target endpoint is external or internal. An endpoint is internal if the target is an Intersight resource. For instance, configuring an intersight object using a Task.\n* `External` - Denotes that the target endpoint is an external API endpoint.\n* `Internal` - Denotes that the target endpoint is a Intersight API endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public OpenapiTaskGenerationRequest.EndpointTypeEnum EndpointType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.OpenapiKeyValuePair> HeaderParameters
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"When this value is set to true, the task name validations happen and provides the task validation status against each of the selected API on the property selectedApis When this value is set to false, an internal workflow to generate the tasks is submitted,  conflicting task names are created with an incremented version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool IsValidateRequest
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

        public OpenapiTaskGenerationRequest.ObjectTypeEnum ObjectType
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
        /// <para type="description">"Specifies the REST API protocol being used, which can be one of HTTP or HTTPS.\n* `HTTPS` - Denotes that the API call uses the HTTPS protocol type\n* `HTTP` - Denotes that the API call uses the HTTP protocol type"</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public OpenapiTaskGenerationRequest.ProtocolEnum Protocol
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.OpenapiKeyValuePair> QueryParameters
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.OpenapiApiInfo> SelectedApis
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a openapiProcessFile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.OpenapiProcessFileRelationship Source
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
        /// <para type="description">"Optional string that can be prefixed to the name of created tasks."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string TaskPrefix
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.OpenapiKeyValuePair> TaskTags
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Specifies the URL of the endpoint that the created task communicates with. It is defaulted to intersight.com for internal endpoints."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Url
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.OpenapiTaskGenerationRequest initObject = new Intersight.Model.OpenapiTaskGenerationRequest();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("EndpointType"))
            {
                initObject.EndpointType = this.EndpointType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HeaderParameters"))
            {
                initObject.HeaderParameters = this.HeaderParameters;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IsValidateRequest"))
            {
                initObject.IsValidateRequest = this.IsValidateRequest;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Protocol"))
            {
                initObject.Protocol = this.Protocol;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("QueryParameters"))
            {
                initObject.QueryParameters = this.QueryParameters;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SelectedApis"))
            {
                initObject.SelectedApis = this.SelectedApis;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Source"))
            {
                initObject.Source = this.Source;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TaskPrefix"))
            {
                initObject.TaskPrefix = this.TaskPrefix;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TaskTags"))
            {
                initObject.TaskTags = this.TaskTags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Url"))
            {
                initObject.Url = this.Url;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize OpenapiTaskGenerationResult.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightOpenapiTaskGenerationResult")]
    public class InitializeIntersightOpenapiTaskGenerationResult : PSCmdlet
    {
        public InitializeIntersightOpenapiTaskGenerationResult()
        {
            ClassId = OpenapiTaskGenerationResult.ClassIdEnum.OpenapiTaskGenerationResult;
            ObjectType = OpenapiTaskGenerationResult.ObjectTypeEnum.OpenapiTaskGenerationResult;

        }
        // <summary>
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

        public OpenapiTaskGenerationResult.ClassIdEnum ClassId
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

        public OpenapiTaskGenerationResult.ObjectTypeEnum ObjectType
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
            Intersight.Model.OpenapiTaskGenerationResult initObject = new Intersight.Model.OpenapiTaskGenerationResult();
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
}