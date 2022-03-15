using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiaapiSoftwareRegex.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiaapiSoftwareRegex")]
    public class InitializeIntersightNiaapiSoftwareRegex:PSCmdlet
	{
		public InitializeIntersightNiaapiSoftwareRegex()
		{
            ClassId = NiaapiSoftwareRegex.ClassIdEnum.NiaapiSoftwareRegex;
            ObjectType = NiaapiSoftwareRegex.ObjectTypeEnum.NiaapiSoftwareRegex;
            
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
        
        public NiaapiSoftwareRegex.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiaapiSoftwareRegex.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Regular Expression pattern used to reconginze the version string."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Regex {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Software release. A set of Software releases seperated by comma which can be recongized by according Regex pattern."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SoftwareVersion {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.NiaapiSoftwareRegex initObject = new Intersight.Model.NiaapiSoftwareRegex();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Regex"))
            {
                initObject.Regex = this.Regex;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SoftwareVersion"))
            {
                initObject.SoftwareVersion = this.SoftwareVersion;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiaapiVersionRegexPlatform.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiaapiVersionRegexPlatform")]
    public class InitializeIntersightNiaapiVersionRegexPlatform:PSCmdlet
	{
		public InitializeIntersightNiaapiVersionRegexPlatform()
		{
            ClassId = NiaapiVersionRegexPlatform.ClassIdEnum.NiaapiVersionRegexPlatform;
            ObjectType = NiaapiVersionRegexPlatform.ObjectTypeEnum.NiaapiVersionRegexPlatform;
            
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
        /// <para type="description">"All long live version Regex pattern."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Anyllregex {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiaapiVersionRegexPlatform.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Current long live version Regex pattern."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.NiaapiSoftwareRegex Currentlltrain {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Latest short live version Regex pattern."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.NiaapiSoftwareRegex Latestsltrain {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiaapiVersionRegexPlatform.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Model.NiaapiSoftwareRegex> Sltrain {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Upcoming short live version Regex pattern."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.NiaapiSoftwareRegex Upcominglltrain {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.NiaapiVersionRegexPlatform initObject = new Intersight.Model.NiaapiVersionRegexPlatform();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Anyllregex"))
            {
                initObject.Anyllregex = this.Anyllregex;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Currentlltrain"))
            {
                initObject.Currentlltrain = this.Currentlltrain;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Latestsltrain"))
            {
                initObject.Latestsltrain = this.Latestsltrain;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Sltrain"))
            {
                initObject.Sltrain = this.Sltrain;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Upcominglltrain"))
            {
                initObject.Upcominglltrain = this.Upcominglltrain;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiaapiNewReleaseDetail.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiaapiNewReleaseDetail")]
    public class InitializeIntersightNiaapiNewReleaseDetail:PSCmdlet
	{
		public InitializeIntersightNiaapiNewReleaseDetail()
		{
            ClassId = NiaapiNewReleaseDetail.ClassIdEnum.NiaapiNewReleaseDetail;
            ObjectType = NiaapiNewReleaseDetail.ObjectTypeEnum.NiaapiNewReleaseDetail;
            
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
        
        public NiaapiNewReleaseDetail.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of this new verison release post."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Link of downloading the release file."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Link {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiaapiNewReleaseDetail.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The link used to provide a gateway for customer to review the release note."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ReleaseNoteLink {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The link title used to provide a gateway for customer to review the release note."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ReleaseNoteLinkTitle {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The link used to provide a gateway for customer to download the release."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SoftwareDownloadLink {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The link title used to provide a gateway for customer to download the release."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SoftwareDownloadLinkTitle {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Title of the new verison release post."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Title {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version number Associate with this Post."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Version {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.NiaapiNewReleaseDetail initObject = new Intersight.Model.NiaapiNewReleaseDetail();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Link"))
            {
                initObject.Link = this.Link;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("ReleaseNoteLink"))
            {
                initObject.ReleaseNoteLink = this.ReleaseNoteLink;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ReleaseNoteLinkTitle"))
            {
                initObject.ReleaseNoteLinkTitle = this.ReleaseNoteLinkTitle;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SoftwareDownloadLink"))
            {
                initObject.SoftwareDownloadLink = this.SoftwareDownloadLink;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SoftwareDownloadLinkTitle"))
            {
                initObject.SoftwareDownloadLinkTitle = this.SoftwareDownloadLinkTitle;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Title"))
            {
                initObject.Title = this.Title;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Version"))
            {
                initObject._Version = this.Version;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiaapiDetail.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiaapiDetail")]
    public class InitializeIntersightNiaapiDetail:PSCmdlet
	{
		public InitializeIntersightNiaapiDetail()
		{
            ClassId = NiaapiDetail.ClassIdEnum.NiaapiDetail;
            ObjectType = NiaapiDetail.ObjectTypeEnum.NiaapiDetail;
            
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
        /// <para type="description">"Checksum of this part of Content."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Chksum {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiaapiDetail.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The file name within this Metadata file."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Filename {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of this Content."</para>
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
        
        public NiaapiDetail.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.NiaapiDetail initObject = new Intersight.Model.NiaapiDetail();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Chksum"))
            {
                initObject.Chksum = this.Chksum;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Filename"))
            {
                initObject.Filename = this.Filename;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiaapiRevisionInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiaapiRevisionInfo")]
    public class InitializeIntersightNiaapiRevisionInfo:PSCmdlet
	{
		public InitializeIntersightNiaapiRevisionInfo()
		{
            ClassId = NiaapiRevisionInfo.ClassIdEnum.NiaapiRevisionInfo;
            ObjectType = NiaapiRevisionInfo.ObjectTypeEnum.NiaapiRevisionInfo;
            
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
        
        public NiaapiRevisionInfo.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The date the revision is made."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public DateTime DatePublished {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiaapiRevisionInfo.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The changes made in this revision."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RevisionComment {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Revision No. of this revision."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RevisionNo {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.NiaapiRevisionInfo initObject = new Intersight.Model.NiaapiRevisionInfo();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("DatePublished"))
            {
                initObject.DatePublished = this.DatePublished;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("RevisionComment"))
            {
                initObject.RevisionComment = this.RevisionComment;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RevisionNo"))
            {
                initObject.RevisionNo = this.RevisionNo;
            }
            WriteObject(initObject);
        }

    }
}