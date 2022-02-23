using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize SoftwarerepositoryCifsServer.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightSoftwarerepositoryCifsServer")]
    public class InitializeIntersightSoftwarerepositoryCifsServer:PSCmdlet
	{
		public InitializeIntersightSoftwarerepositoryCifsServer()
		{
            ClassId = SoftwarerepositoryCifsServer.ClassIdEnum.SoftwarerepositoryCifsServer;
            ObjectType = SoftwarerepositoryCifsServer.ObjectTypeEnum.SoftwarerepositoryCifsServer;
            
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
        
        public SoftwarerepositoryCifsServer.ClassIdEnum ClassId {
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
        /// <para type="description">"For CIFS, leave the field blank or enter one or more comma seperated options from the following. For Example, \" \" , \" soft \" , \" soft , nounix \" .\n* soft.\n* nounix.\n* noserviceino.\n* guest.\n* USERNAME=VALUE.\n* PASSWORD=VALUE.\n* sec=VALUE (VALUE could be None, Ntlm, Ntlmi, Ntlmssp, Ntlmsspi, Ntlmv2, Ntlmv2i)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string MountOption {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public SoftwarerepositoryCifsServer.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Password configured on the CIFS server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Password {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Username configured on the CIFS server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Username {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.SoftwarerepositoryCifsServer initObject = new Intersight.Model.SoftwarerepositoryCifsServer();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("FileLocation"))
            {
                initObject.FileLocation = this.FileLocation;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MountOption"))
            {
                initObject.MountOption = this.MountOption;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Password"))
            {
                initObject.Password = this.Password;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Username"))
            {
                initObject.Username = this.Username;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize SoftwarerepositoryConstraintModels.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightSoftwarerepositoryConstraintModels")]
    public class InitializeIntersightSoftwarerepositoryConstraintModels:PSCmdlet
	{
		public InitializeIntersightSoftwarerepositoryConstraintModels()
		{
            ClassId = SoftwarerepositoryConstraintModels.ClassIdEnum.SoftwarerepositoryConstraintModels;
            ObjectType = SoftwarerepositoryConstraintModels.ObjectTypeEnum.SoftwarerepositoryConstraintModels;
            
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
        
        public SoftwarerepositoryConstraintModels.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Minimum version of the image."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string MinVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the contraint, used to identify constriant type."</para>
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
        
        public SoftwarerepositoryConstraintModels.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Regular expression of the image name."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string PlatformRegex {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> SupportedModels {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.SoftwarerepositoryConstraintModels initObject = new Intersight.Model.SoftwarerepositoryConstraintModels();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("MinVersion"))
            {
                initObject.MinVersion = this.MinVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("PlatformRegex"))
            {
                initObject.PlatformRegex = this.PlatformRegex;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SupportedModels"))
            {
                initObject.SupportedModels = this.SupportedModels;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize SoftwarerepositoryLocalMachine.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightSoftwarerepositoryLocalMachine")]
    public class InitializeIntersightSoftwarerepositoryLocalMachine:PSCmdlet
	{
		public InitializeIntersightSoftwarerepositoryLocalMachine()
		{
            ClassId = SoftwarerepositoryLocalMachine.ClassIdEnum.SoftwarerepositoryLocalMachine;
            ObjectType = SoftwarerepositoryLocalMachine.ObjectTypeEnum.SoftwarerepositoryLocalMachine;
            
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
        
        public SoftwarerepositoryLocalMachine.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public SoftwarerepositoryLocalMachine.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The chunk size (in bytes) for each part of the file to be uploaded."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long PartSize {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"When the import action in file MO is updated with 'GeneratePreSignedUploadUrl', Intersight shall return a upload Id in this property as part of the PATCH response."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string UploadId {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.SoftwarerepositoryLocalMachine initObject = new Intersight.Model.SoftwarerepositoryLocalMachine();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("PartSize"))
            {
                initObject.PartSize = this.PartSize;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UploadId"))
            {
                initObject.UploadId = this.UploadId;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize SoftwarerepositoryHttpServer.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightSoftwarerepositoryHttpServer")]
    public class InitializeIntersightSoftwarerepositoryHttpServer:PSCmdlet
	{
		public InitializeIntersightSoftwarerepositoryHttpServer()
		{
            ClassId = SoftwarerepositoryHttpServer.ClassIdEnum.SoftwarerepositoryHttpServer;
            ObjectType = SoftwarerepositoryHttpServer.ObjectTypeEnum.SoftwarerepositoryHttpServer;
            
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
        
        public SoftwarerepositoryHttpServer.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"HTTP/HTTPS link to the image. Accepted formats are HTTP[s]://server-hostname/share/image or HTTP[s]://serverip/share/image."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string LocationLink {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public SoftwarerepositoryHttpServer.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Password as configured on the HTTP[S] server for user authentication. It is generally required to authenticate user provided HTTP[S] based software repositories."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Password {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Username as configured on the HTTP[S] server for user authentication. It is generally required to authenticate user provided HTTP[S] based software repositories."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Username {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.SoftwarerepositoryHttpServer initObject = new Intersight.Model.SoftwarerepositoryHttpServer();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("LocationLink"))
            {
                initObject.LocationLink = this.LocationLink;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Password"))
            {
                initObject.Password = this.Password;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Username"))
            {
                initObject.Username = this.Username;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize SoftwarerepositoryNfsServer.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightSoftwarerepositoryNfsServer")]
    public class InitializeIntersightSoftwarerepositoryNfsServer:PSCmdlet
	{
		public InitializeIntersightSoftwarerepositoryNfsServer()
		{
            ClassId = SoftwarerepositoryNfsServer.ClassIdEnum.SoftwarerepositoryNfsServer;
            ObjectType = SoftwarerepositoryNfsServer.ObjectTypeEnum.SoftwarerepositoryNfsServer;
            
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
        
        public SoftwarerepositoryNfsServer.ClassIdEnum ClassId {
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public SoftwarerepositoryNfsServer.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.SoftwarerepositoryNfsServer initObject = new Intersight.Model.SoftwarerepositoryNfsServer();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("FileLocation"))
            {
                initObject.FileLocation = this.FileLocation;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize SoftwarerepositoryImportResult.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightSoftwarerepositoryImportResult")]
    public class InitializeIntersightSoftwarerepositoryImportResult:PSCmdlet
	{
		public InitializeIntersightSoftwarerepositoryImportResult()
		{
            ClassId = SoftwarerepositoryImportResult.ClassIdEnum.SoftwarerepositoryImportResult;
            ObjectType = SoftwarerepositoryImportResult.ObjectTypeEnum.SoftwarerepositoryImportResult;
            
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
        
        public SoftwarerepositoryImportResult.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public SoftwarerepositoryImportResult.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.SoftwarerepositoryImportResult initObject = new Intersight.Model.SoftwarerepositoryImportResult();
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
    /// <para type="synopsis">This is the cmdlet to Initialize SoftwarerepositoryFileServer.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightSoftwarerepositoryFileServer")]
    public class InitializeIntersightSoftwarerepositoryFileServer:PSCmdlet
	{
		public InitializeIntersightSoftwarerepositoryFileServer()
		{
            
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
        
        public SoftwarerepositoryFileServer.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public SoftwarerepositoryFileServer.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.SoftwarerepositoryFileServer initObject = new Intersight.Model.SoftwarerepositoryFileServer();
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
    /// <para type="synopsis">This is the cmdlet to Initialize SoftwarerepositoryApplianceUpload.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightSoftwarerepositoryApplianceUpload")]
    public class InitializeIntersightSoftwarerepositoryApplianceUpload:PSCmdlet
	{
		public InitializeIntersightSoftwarerepositoryApplianceUpload()
		{
            
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
        
        public SoftwarerepositoryApplianceUpload.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public SoftwarerepositoryApplianceUpload.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.SoftwarerepositoryApplianceUpload initObject = new Intersight.Model.SoftwarerepositoryApplianceUpload();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
}