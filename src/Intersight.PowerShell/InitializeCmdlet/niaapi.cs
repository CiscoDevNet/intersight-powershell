using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiaapiApicCcoPost.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiaapiApicCcoPost")]
    public class InitializeIntersightNiaapiApicCcoPost : PSCmdlet
    {
        public InitializeIntersightNiaapiApicCcoPost()
        {
            ClassId = NiaapiApicCcoPost.ClassIdEnum.NiaapiApicCcoPost;
            ObjectType = NiaapiApicCcoPost.ObjectTypeEnum.NiaapiApicCcoPost;

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

        public NiaapiApicCcoPost.ClassIdEnum ClassId
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public NiaapiApicCcoPost.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The date when this new release notice is posted."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime PostDate
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Detail of this post including the content and the date it was posted."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.NiaapiNewReleaseDetail PostDetail
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The document type of this post."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string PostType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Identificator of this inbox post."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Postid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Revision number of this notice."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Revision
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
            Intersight.Model.NiaapiApicCcoPost initObject = new Intersight.Model.NiaapiApicCcoPost();
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
            if (this.MyInvocation.BoundParameters.ContainsKey("PostDate"))
            {
                initObject.PostDate = this.PostDate;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PostDetail"))
            {
                initObject.PostDetail = this.PostDetail;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PostType"))
            {
                initObject.PostType = this.PostType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Postid"))
            {
                initObject.Postid = this.Postid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Revision"))
            {
                initObject.Revision = this.Revision;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiaapiApicFieldNotice.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiaapiApicFieldNotice")]
    public class InitializeIntersightNiaapiApicFieldNotice : PSCmdlet
    {
        public InitializeIntersightNiaapiApicFieldNotice()
        {
            ClassId = NiaapiApicFieldNotice.ClassIdEnum.NiaapiApicFieldNotice;
            ObjectType = NiaapiApicFieldNotice.ObjectTypeEnum.NiaapiApicFieldNotice;

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
        /// <para type="description">"Bug Id associated with this notice."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Bugid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public NiaapiApicFieldNotice.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Field notice Description."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string FieldNoticeDesc
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Fieldnotice Id of this notice."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string FieldNoticeId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Field notice URL link to the notice webpage."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string FieldNoticeUrl
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The headline of this field notice."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Headline
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Hardware PID for affected models."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Hwpid
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public NiaapiApicFieldNotice.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.NiaapiRevisionInfo> RevisionInfo
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Software Release number for affected versions."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SwRelease
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
        /// <para type="description">"URL of workaround of this notice."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string WorkaroundUrl
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.NiaapiApicFieldNotice initObject = new Intersight.Model.NiaapiApicFieldNotice();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Bugid"))
            {
                initObject.Bugid = this.Bugid;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("FieldNoticeDesc"))
            {
                initObject.FieldNoticeDesc = this.FieldNoticeDesc;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FieldNoticeId"))
            {
                initObject.FieldNoticeId = this.FieldNoticeId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FieldNoticeUrl"))
            {
                initObject.FieldNoticeUrl = this.FieldNoticeUrl;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Headline"))
            {
                initObject.Headline = this.Headline;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Hwpid"))
            {
                initObject.Hwpid = this.Hwpid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("RevisionInfo"))
            {
                initObject.RevisionInfo = this.RevisionInfo;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SwRelease"))
            {
                initObject.SwRelease = this.SwRelease;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("WorkaroundUrl"))
            {
                initObject.WorkaroundUrl = this.WorkaroundUrl;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiaapiApicHweol.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiaapiApicHweol")]
    public class InitializeIntersightNiaapiApicHweol : PSCmdlet
    {
        public InitializeIntersightNiaapiApicHweol()
        {
            ClassId = NiaapiApicHweol.ClassIdEnum.NiaapiApicHweol;
            ObjectType = NiaapiApicHweol.ObjectTypeEnum.NiaapiApicHweol;

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
        /// <para type="description">"String contains the PID of hardwares affected by this notice, seperated by comma."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string AffectedPids
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"When this notice is announced."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime AnnouncementDate
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Epoch time of Announcement Date."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long AnnouncementDateEpoch
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The bulletinno of this hardware end of life notice."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string BulletinNo
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public NiaapiApicHweol.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The description of this hardware end of life notice."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Date time of end of new services attachment  ."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime EndofNewServiceAttachmentDate
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Epoch time of New service attachment Date ."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long EndofNewServiceAttachmentDateEpoch
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Date time of end of routinefailure analysis."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime EndofRoutineFailureAnalysisDate
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Epoch time of End of Routine Failure Analysis Date."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long EndofRoutineFailureAnalysisDateEpoch
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"When this hardware will end sale."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime EndofSaleDate
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Epoch time of End of Sale Date."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long EndofSaleDateEpoch
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Date time of end of security support ."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime EndofSecuritySupport
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Epoch time of End of Security Support Date ."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long EndofSecuritySupportEpoch
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Date time of end of service contract renew ."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime EndofServiceContractRenewalDate
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Epoch time of End of Renewal service contract."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long EndofServiceContractRenewalDateEpoch
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The date of end of maintainance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime EndofSwMaintenanceDate
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Epoch time of End of maintenance Date."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long EndofSwMaintenanceDateEpoch
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Hardware end of sale URL link to the notice webpage."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string HardwareEolUrl
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The title of this hardware end of life notice."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Headline
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Date time of end of support ."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime LastDateofSupport
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Epoch time of last date of support ."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long LastDateofSupportEpoch
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Date time of Lastship Date."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime LastShipDate
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Epoch time of last ship Date."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long LastShipDateEpoch
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The URL of this migration notice."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string MigrationUrl
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public NiaapiApicHweol.ObjectTypeEnum ObjectType
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
            Intersight.Model.NiaapiApicHweol initObject = new Intersight.Model.NiaapiApicHweol();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AffectedPids"))
            {
                initObject.AffectedPids = this.AffectedPids;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AnnouncementDate"))
            {
                initObject.AnnouncementDate = this.AnnouncementDate;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AnnouncementDateEpoch"))
            {
                initObject.AnnouncementDateEpoch = this.AnnouncementDateEpoch;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BulletinNo"))
            {
                initObject.BulletinNo = this.BulletinNo;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EndofNewServiceAttachmentDate"))
            {
                initObject.EndofNewServiceAttachmentDate = this.EndofNewServiceAttachmentDate;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EndofNewServiceAttachmentDateEpoch"))
            {
                initObject.EndofNewServiceAttachmentDateEpoch = this.EndofNewServiceAttachmentDateEpoch;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EndofRoutineFailureAnalysisDate"))
            {
                initObject.EndofRoutineFailureAnalysisDate = this.EndofRoutineFailureAnalysisDate;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EndofRoutineFailureAnalysisDateEpoch"))
            {
                initObject.EndofRoutineFailureAnalysisDateEpoch = this.EndofRoutineFailureAnalysisDateEpoch;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EndofSaleDate"))
            {
                initObject.EndofSaleDate = this.EndofSaleDate;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EndofSaleDateEpoch"))
            {
                initObject.EndofSaleDateEpoch = this.EndofSaleDateEpoch;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EndofSecuritySupport"))
            {
                initObject.EndofSecuritySupport = this.EndofSecuritySupport;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EndofSecuritySupportEpoch"))
            {
                initObject.EndofSecuritySupportEpoch = this.EndofSecuritySupportEpoch;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EndofServiceContractRenewalDate"))
            {
                initObject.EndofServiceContractRenewalDate = this.EndofServiceContractRenewalDate;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EndofServiceContractRenewalDateEpoch"))
            {
                initObject.EndofServiceContractRenewalDateEpoch = this.EndofServiceContractRenewalDateEpoch;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EndofSwMaintenanceDate"))
            {
                initObject.EndofSwMaintenanceDate = this.EndofSwMaintenanceDate;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EndofSwMaintenanceDateEpoch"))
            {
                initObject.EndofSwMaintenanceDateEpoch = this.EndofSwMaintenanceDateEpoch;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HardwareEolUrl"))
            {
                initObject.HardwareEolUrl = this.HardwareEolUrl;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Headline"))
            {
                initObject.Headline = this.Headline;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LastDateofSupport"))
            {
                initObject.LastDateofSupport = this.LastDateofSupport;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LastDateofSupportEpoch"))
            {
                initObject.LastDateofSupportEpoch = this.LastDateofSupportEpoch;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LastShipDate"))
            {
                initObject.LastShipDate = this.LastShipDate;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LastShipDateEpoch"))
            {
                initObject.LastShipDateEpoch = this.LastShipDateEpoch;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MigrationUrl"))
            {
                initObject.MigrationUrl = this.MigrationUrl;
            }
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
    /// <para type="synopsis">This is the cmdlet to Initialize NiaapiApicLatestMaintainedRelease.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiaapiApicLatestMaintainedRelease")]
    public class InitializeIntersightNiaapiApicLatestMaintainedRelease : PSCmdlet
    {
        public InitializeIntersightNiaapiApicLatestMaintainedRelease()
        {
            ClassId = NiaapiApicLatestMaintainedRelease.ClassIdEnum.NiaapiApicLatestMaintainedRelease;
            ObjectType = NiaapiApicLatestMaintainedRelease.ObjectTypeEnum.NiaapiApicLatestMaintainedRelease;

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

        public NiaapiApicLatestMaintainedRelease.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Lastest maintained release."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string MaintainedRelease
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public NiaapiApicLatestMaintainedRelease.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Software release version string."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SoftwareRelease
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
        /// <para type="description">"Long lived version or short lived version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string VersionTag
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.NiaapiApicLatestMaintainedRelease initObject = new Intersight.Model.NiaapiApicLatestMaintainedRelease();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("MaintainedRelease"))
            {
                initObject.MaintainedRelease = this.MaintainedRelease;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("SoftwareRelease"))
            {
                initObject.SoftwareRelease = this.SoftwareRelease;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VersionTag"))
            {
                initObject.VersionTag = this.VersionTag;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiaapiApicReleaseRecommend.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiaapiApicReleaseRecommend")]
    public class InitializeIntersightNiaapiApicReleaseRecommend : PSCmdlet
    {
        public InitializeIntersightNiaapiApicReleaseRecommend()
        {
            ClassId = NiaapiApicReleaseRecommend.ClassIdEnum.NiaapiApicReleaseRecommend;
            ObjectType = NiaapiApicReleaseRecommend.ObjectTypeEnum.NiaapiApicReleaseRecommend;

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

        public NiaapiApicReleaseRecommend.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Current long-lived release."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Cll
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Customer recommended releases."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Crr
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public NiaapiApicReleaseRecommend.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Hardware model identificator."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Pid
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
        /// <para type="description">"Upcoming long-lived release."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Ull
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.NiaapiApicReleaseRecommend initObject = new Intersight.Model.NiaapiApicReleaseRecommend();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Cll"))
            {
                initObject.Cll = this.Cll;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Crr"))
            {
                initObject.Crr = this.Crr;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Pid"))
            {
                initObject.Pid = this.Pid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Ull"))
            {
                initObject.Ull = this.Ull;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiaapiApicSweol.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiaapiApicSweol")]
    public class InitializeIntersightNiaapiApicSweol : PSCmdlet
    {
        public InitializeIntersightNiaapiApicSweol()
        {
            ClassId = NiaapiApicSweol.ClassIdEnum.NiaapiApicSweol;
            ObjectType = NiaapiApicSweol.ObjectTypeEnum.NiaapiApicSweol;

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
        /// <para type="description">"String contains the Release versions affected by this notice, seperated by comma."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string AffectedVersions
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Date time of this notice Announced."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime AnnouncementDate
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Epoch time of this notice Announced."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long AnnouncementDateEpoch
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The bulletinno of this software release end of life notice."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string BulletinNo
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public NiaapiApicSweol.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The description of this software release end of life notice."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Date time of End of New service attachment ."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime EndofNewServiceAttachmentDate
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Epoch time of End of New service attachment ."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long EndofNewServiceAttachmentDateEpoch
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Date time of End of Renewal of service contract ."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime EndofServiceContractRenewalDate
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Epoch time of End of Renewal of service contract ."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long EndofServiceContractRenewalDateEpoch
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Date time of End of Maintenance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime EndofSwMaintenanceDate
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Epoch time of End of Maintenance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long EndofSwMaintenanceDateEpoch
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The title of this software release end of life notice."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Headline
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Date time of Last day of Support ."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime LastDateofSupport
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Epoch time of Last day of Support ."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long LastDateofSupportEpoch
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Date time of Lastship Date."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime LastShipDate
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Epoch time of Lastship Date."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long LastShipDateEpoch
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The URL of this migration notice."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string MigrationUrl
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public NiaapiApicSweol.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Software end of life notice URL link to the notice webpage."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SoftwareEolUrl
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
            Intersight.Model.NiaapiApicSweol initObject = new Intersight.Model.NiaapiApicSweol();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AffectedVersions"))
            {
                initObject.AffectedVersions = this.AffectedVersions;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AnnouncementDate"))
            {
                initObject.AnnouncementDate = this.AnnouncementDate;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AnnouncementDateEpoch"))
            {
                initObject.AnnouncementDateEpoch = this.AnnouncementDateEpoch;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BulletinNo"))
            {
                initObject.BulletinNo = this.BulletinNo;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EndofNewServiceAttachmentDate"))
            {
                initObject.EndofNewServiceAttachmentDate = this.EndofNewServiceAttachmentDate;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EndofNewServiceAttachmentDateEpoch"))
            {
                initObject.EndofNewServiceAttachmentDateEpoch = this.EndofNewServiceAttachmentDateEpoch;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EndofServiceContractRenewalDate"))
            {
                initObject.EndofServiceContractRenewalDate = this.EndofServiceContractRenewalDate;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EndofServiceContractRenewalDateEpoch"))
            {
                initObject.EndofServiceContractRenewalDateEpoch = this.EndofServiceContractRenewalDateEpoch;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EndofSwMaintenanceDate"))
            {
                initObject.EndofSwMaintenanceDate = this.EndofSwMaintenanceDate;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EndofSwMaintenanceDateEpoch"))
            {
                initObject.EndofSwMaintenanceDateEpoch = this.EndofSwMaintenanceDateEpoch;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Headline"))
            {
                initObject.Headline = this.Headline;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LastDateofSupport"))
            {
                initObject.LastDateofSupport = this.LastDateofSupport;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LastDateofSupportEpoch"))
            {
                initObject.LastDateofSupportEpoch = this.LastDateofSupportEpoch;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LastShipDate"))
            {
                initObject.LastShipDate = this.LastShipDate;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LastShipDateEpoch"))
            {
                initObject.LastShipDateEpoch = this.LastShipDateEpoch;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MigrationUrl"))
            {
                initObject.MigrationUrl = this.MigrationUrl;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("SoftwareEolUrl"))
            {
                initObject.SoftwareEolUrl = this.SoftwareEolUrl;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiaapiDcnmCcoPost.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiaapiDcnmCcoPost")]
    public class InitializeIntersightNiaapiDcnmCcoPost : PSCmdlet
    {
        public InitializeIntersightNiaapiDcnmCcoPost()
        {
            ClassId = NiaapiDcnmCcoPost.ClassIdEnum.NiaapiDcnmCcoPost;
            ObjectType = NiaapiDcnmCcoPost.ObjectTypeEnum.NiaapiDcnmCcoPost;

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

        public NiaapiDcnmCcoPost.ClassIdEnum ClassId
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public NiaapiDcnmCcoPost.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The date when this new release notice is posted."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime PostDate
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Detail of this post including the content and the date it was posted."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.NiaapiNewReleaseDetail PostDetail
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The document type of this post."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string PostType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Identificator of this inbox post."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Postid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Revision number of this notice."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Revision
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
            Intersight.Model.NiaapiDcnmCcoPost initObject = new Intersight.Model.NiaapiDcnmCcoPost();
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
            if (this.MyInvocation.BoundParameters.ContainsKey("PostDate"))
            {
                initObject.PostDate = this.PostDate;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PostDetail"))
            {
                initObject.PostDetail = this.PostDetail;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PostType"))
            {
                initObject.PostType = this.PostType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Postid"))
            {
                initObject.Postid = this.Postid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Revision"))
            {
                initObject.Revision = this.Revision;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiaapiDcnmFieldNotice.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiaapiDcnmFieldNotice")]
    public class InitializeIntersightNiaapiDcnmFieldNotice : PSCmdlet
    {
        public InitializeIntersightNiaapiDcnmFieldNotice()
        {
            ClassId = NiaapiDcnmFieldNotice.ClassIdEnum.NiaapiDcnmFieldNotice;
            ObjectType = NiaapiDcnmFieldNotice.ObjectTypeEnum.NiaapiDcnmFieldNotice;

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
        /// <para type="description">"Bug Id associated with this notice."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Bugid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public NiaapiDcnmFieldNotice.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Field notice Description."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string FieldNoticeDesc
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Fieldnotice Id of this notice."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string FieldNoticeId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Field notice URL link to the notice webpage."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string FieldNoticeUrl
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The headline of this field notice."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Headline
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Hardware PID for affected models."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Hwpid
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public NiaapiDcnmFieldNotice.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.NiaapiRevisionInfo> RevisionInfo
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Software Release number for affected versions."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SwRelease
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
        /// <para type="description">"URL of workaround of this notice."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string WorkaroundUrl
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.NiaapiDcnmFieldNotice initObject = new Intersight.Model.NiaapiDcnmFieldNotice();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Bugid"))
            {
                initObject.Bugid = this.Bugid;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("FieldNoticeDesc"))
            {
                initObject.FieldNoticeDesc = this.FieldNoticeDesc;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FieldNoticeId"))
            {
                initObject.FieldNoticeId = this.FieldNoticeId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FieldNoticeUrl"))
            {
                initObject.FieldNoticeUrl = this.FieldNoticeUrl;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Headline"))
            {
                initObject.Headline = this.Headline;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Hwpid"))
            {
                initObject.Hwpid = this.Hwpid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("RevisionInfo"))
            {
                initObject.RevisionInfo = this.RevisionInfo;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SwRelease"))
            {
                initObject.SwRelease = this.SwRelease;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("WorkaroundUrl"))
            {
                initObject.WorkaroundUrl = this.WorkaroundUrl;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiaapiDcnmHweol.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiaapiDcnmHweol")]
    public class InitializeIntersightNiaapiDcnmHweol : PSCmdlet
    {
        public InitializeIntersightNiaapiDcnmHweol()
        {
            ClassId = NiaapiDcnmHweol.ClassIdEnum.NiaapiDcnmHweol;
            ObjectType = NiaapiDcnmHweol.ObjectTypeEnum.NiaapiDcnmHweol;

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
        /// <para type="description">"String contains the PID of hardwares affected by this notice, seperated by comma."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string AffectedPids
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"When this notice is announced."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime AnnouncementDate
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Epoch time of Announcement Date."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long AnnouncementDateEpoch
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The bulletinno of this hardware end of life notice."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string BulletinNo
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public NiaapiDcnmHweol.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The description of this hardware end of life notice."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Date time of end of new services attachment  ."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime EndofNewServiceAttachmentDate
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Epoch time of New service attachment Date ."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long EndofNewServiceAttachmentDateEpoch
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Date time of end of routinefailure analysis."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime EndofRoutineFailureAnalysisDate
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Epoch time of End of Routine Failure Analysis Date."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long EndofRoutineFailureAnalysisDateEpoch
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"When this hardware will end sale."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime EndofSaleDate
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Epoch time of End of Sale Date."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long EndofSaleDateEpoch
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Date time of end of security support ."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime EndofSecuritySupport
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Epoch time of End of Security Support Date ."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long EndofSecuritySupportEpoch
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Date time of end of service contract renew ."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime EndofServiceContractRenewalDate
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Epoch time of End of Renewal service contract."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long EndofServiceContractRenewalDateEpoch
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The date of end of maintainance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime EndofSwMaintenanceDate
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Epoch time of End of maintenance Date."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long EndofSwMaintenanceDateEpoch
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Hardware end of sale URL link to the notice webpage."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string HardwareEolUrl
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The title of this hardware end of life notice."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Headline
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Date time of end of support ."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime LastDateofSupport
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Epoch time of last date of support ."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long LastDateofSupportEpoch
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Date time of Lastship Date."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime LastShipDate
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Epoch time of last ship Date."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long LastShipDateEpoch
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The URL of this migration notice."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string MigrationUrl
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public NiaapiDcnmHweol.ObjectTypeEnum ObjectType
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
            Intersight.Model.NiaapiDcnmHweol initObject = new Intersight.Model.NiaapiDcnmHweol();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AffectedPids"))
            {
                initObject.AffectedPids = this.AffectedPids;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AnnouncementDate"))
            {
                initObject.AnnouncementDate = this.AnnouncementDate;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AnnouncementDateEpoch"))
            {
                initObject.AnnouncementDateEpoch = this.AnnouncementDateEpoch;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BulletinNo"))
            {
                initObject.BulletinNo = this.BulletinNo;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EndofNewServiceAttachmentDate"))
            {
                initObject.EndofNewServiceAttachmentDate = this.EndofNewServiceAttachmentDate;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EndofNewServiceAttachmentDateEpoch"))
            {
                initObject.EndofNewServiceAttachmentDateEpoch = this.EndofNewServiceAttachmentDateEpoch;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EndofRoutineFailureAnalysisDate"))
            {
                initObject.EndofRoutineFailureAnalysisDate = this.EndofRoutineFailureAnalysisDate;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EndofRoutineFailureAnalysisDateEpoch"))
            {
                initObject.EndofRoutineFailureAnalysisDateEpoch = this.EndofRoutineFailureAnalysisDateEpoch;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EndofSaleDate"))
            {
                initObject.EndofSaleDate = this.EndofSaleDate;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EndofSaleDateEpoch"))
            {
                initObject.EndofSaleDateEpoch = this.EndofSaleDateEpoch;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EndofSecuritySupport"))
            {
                initObject.EndofSecuritySupport = this.EndofSecuritySupport;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EndofSecuritySupportEpoch"))
            {
                initObject.EndofSecuritySupportEpoch = this.EndofSecuritySupportEpoch;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EndofServiceContractRenewalDate"))
            {
                initObject.EndofServiceContractRenewalDate = this.EndofServiceContractRenewalDate;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EndofServiceContractRenewalDateEpoch"))
            {
                initObject.EndofServiceContractRenewalDateEpoch = this.EndofServiceContractRenewalDateEpoch;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EndofSwMaintenanceDate"))
            {
                initObject.EndofSwMaintenanceDate = this.EndofSwMaintenanceDate;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EndofSwMaintenanceDateEpoch"))
            {
                initObject.EndofSwMaintenanceDateEpoch = this.EndofSwMaintenanceDateEpoch;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HardwareEolUrl"))
            {
                initObject.HardwareEolUrl = this.HardwareEolUrl;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Headline"))
            {
                initObject.Headline = this.Headline;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LastDateofSupport"))
            {
                initObject.LastDateofSupport = this.LastDateofSupport;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LastDateofSupportEpoch"))
            {
                initObject.LastDateofSupportEpoch = this.LastDateofSupportEpoch;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LastShipDate"))
            {
                initObject.LastShipDate = this.LastShipDate;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LastShipDateEpoch"))
            {
                initObject.LastShipDateEpoch = this.LastShipDateEpoch;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MigrationUrl"))
            {
                initObject.MigrationUrl = this.MigrationUrl;
            }
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
    /// <para type="synopsis">This is the cmdlet to Initialize NiaapiDcnmLatestMaintainedRelease.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiaapiDcnmLatestMaintainedRelease")]
    public class InitializeIntersightNiaapiDcnmLatestMaintainedRelease : PSCmdlet
    {
        public InitializeIntersightNiaapiDcnmLatestMaintainedRelease()
        {
            ClassId = NiaapiDcnmLatestMaintainedRelease.ClassIdEnum.NiaapiDcnmLatestMaintainedRelease;
            ObjectType = NiaapiDcnmLatestMaintainedRelease.ObjectTypeEnum.NiaapiDcnmLatestMaintainedRelease;

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

        public NiaapiDcnmLatestMaintainedRelease.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Lastest maintained release."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string MaintainedRelease
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public NiaapiDcnmLatestMaintainedRelease.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Software release version string."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SoftwareRelease
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
        /// <para type="description">"Long lived version or short lived version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string VersionTag
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.NiaapiDcnmLatestMaintainedRelease initObject = new Intersight.Model.NiaapiDcnmLatestMaintainedRelease();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("MaintainedRelease"))
            {
                initObject.MaintainedRelease = this.MaintainedRelease;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("SoftwareRelease"))
            {
                initObject.SoftwareRelease = this.SoftwareRelease;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VersionTag"))
            {
                initObject.VersionTag = this.VersionTag;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiaapiDcnmReleaseRecommend.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiaapiDcnmReleaseRecommend")]
    public class InitializeIntersightNiaapiDcnmReleaseRecommend : PSCmdlet
    {
        public InitializeIntersightNiaapiDcnmReleaseRecommend()
        {
            ClassId = NiaapiDcnmReleaseRecommend.ClassIdEnum.NiaapiDcnmReleaseRecommend;
            ObjectType = NiaapiDcnmReleaseRecommend.ObjectTypeEnum.NiaapiDcnmReleaseRecommend;

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

        public NiaapiDcnmReleaseRecommend.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Current long-lived release."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Cll
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Customer recommended releases."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Crr
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public NiaapiDcnmReleaseRecommend.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Hardware model identificator."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Pid
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
        /// <para type="description">"Upcoming long-lived release."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Ull
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.NiaapiDcnmReleaseRecommend initObject = new Intersight.Model.NiaapiDcnmReleaseRecommend();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Cll"))
            {
                initObject.Cll = this.Cll;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Crr"))
            {
                initObject.Crr = this.Crr;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Pid"))
            {
                initObject.Pid = this.Pid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Ull"))
            {
                initObject.Ull = this.Ull;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiaapiDcnmSweol.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiaapiDcnmSweol")]
    public class InitializeIntersightNiaapiDcnmSweol : PSCmdlet
    {
        public InitializeIntersightNiaapiDcnmSweol()
        {
            ClassId = NiaapiDcnmSweol.ClassIdEnum.NiaapiDcnmSweol;
            ObjectType = NiaapiDcnmSweol.ObjectTypeEnum.NiaapiDcnmSweol;

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
        /// <para type="description">"String contains the Release versions affected by this notice, seperated by comma."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string AffectedVersions
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Date time of this notice Announced."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime AnnouncementDate
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Epoch time of this notice Announced."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long AnnouncementDateEpoch
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The bulletinno of this software release end of life notice."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string BulletinNo
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public NiaapiDcnmSweol.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The description of this software release end of life notice."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Date time of End of New service attachment ."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime EndofNewServiceAttachmentDate
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Epoch time of End of New service attachment ."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long EndofNewServiceAttachmentDateEpoch
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Date time of End of Renewal of service contract ."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime EndofServiceContractRenewalDate
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Epoch time of End of Renewal of service contract ."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long EndofServiceContractRenewalDateEpoch
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Date time of End of Maintenance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime EndofSwMaintenanceDate
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Epoch time of End of Maintenance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long EndofSwMaintenanceDateEpoch
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The title of this software release end of life notice."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Headline
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Date time of Last day of Support ."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime LastDateofSupport
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Epoch time of Last day of Support ."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long LastDateofSupportEpoch
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Date time of Lastship Date."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime LastShipDate
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Epoch time of Lastship Date."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long LastShipDateEpoch
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The URL of this migration notice."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string MigrationUrl
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public NiaapiDcnmSweol.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Software end of life notice URL link to the notice webpage."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SoftwareEolUrl
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
            Intersight.Model.NiaapiDcnmSweol initObject = new Intersight.Model.NiaapiDcnmSweol();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AffectedVersions"))
            {
                initObject.AffectedVersions = this.AffectedVersions;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AnnouncementDate"))
            {
                initObject.AnnouncementDate = this.AnnouncementDate;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AnnouncementDateEpoch"))
            {
                initObject.AnnouncementDateEpoch = this.AnnouncementDateEpoch;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BulletinNo"))
            {
                initObject.BulletinNo = this.BulletinNo;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EndofNewServiceAttachmentDate"))
            {
                initObject.EndofNewServiceAttachmentDate = this.EndofNewServiceAttachmentDate;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EndofNewServiceAttachmentDateEpoch"))
            {
                initObject.EndofNewServiceAttachmentDateEpoch = this.EndofNewServiceAttachmentDateEpoch;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EndofServiceContractRenewalDate"))
            {
                initObject.EndofServiceContractRenewalDate = this.EndofServiceContractRenewalDate;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EndofServiceContractRenewalDateEpoch"))
            {
                initObject.EndofServiceContractRenewalDateEpoch = this.EndofServiceContractRenewalDateEpoch;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EndofSwMaintenanceDate"))
            {
                initObject.EndofSwMaintenanceDate = this.EndofSwMaintenanceDate;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EndofSwMaintenanceDateEpoch"))
            {
                initObject.EndofSwMaintenanceDateEpoch = this.EndofSwMaintenanceDateEpoch;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Headline"))
            {
                initObject.Headline = this.Headline;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LastDateofSupport"))
            {
                initObject.LastDateofSupport = this.LastDateofSupport;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LastDateofSupportEpoch"))
            {
                initObject.LastDateofSupportEpoch = this.LastDateofSupportEpoch;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LastShipDate"))
            {
                initObject.LastShipDate = this.LastShipDate;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LastShipDateEpoch"))
            {
                initObject.LastShipDateEpoch = this.LastShipDateEpoch;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MigrationUrl"))
            {
                initObject.MigrationUrl = this.MigrationUrl;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("SoftwareEolUrl"))
            {
                initObject.SoftwareEolUrl = this.SoftwareEolUrl;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiaapiDetail.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiaapiDetail")]
    public class InitializeIntersightNiaapiDetail : PSCmdlet
    {
        public InitializeIntersightNiaapiDetail()
        {
            ClassId = NiaapiDetail.ClassIdEnum.NiaapiDetail;
            ObjectType = NiaapiDetail.ObjectTypeEnum.NiaapiDetail;

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
        /// <para type="description">"Checksum of this part of Content."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Chksum
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public NiaapiDetail.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The file name within this Metadata file."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Filename
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of this Content."</para>
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

        public NiaapiDetail.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
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
    /// <para type="synopsis">This is the cmdlet to Initialize NiaapiFileDownloader.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiaapiFileDownloader")]
    public class InitializeIntersightNiaapiFileDownloader : PSCmdlet
    {
        public InitializeIntersightNiaapiFileDownloader()
        {
            ClassId = NiaapiFileDownloader.ClassIdEnum.NiaapiFileDownloader;
            ObjectType = NiaapiFileDownloader.ObjectTypeEnum.NiaapiFileDownloader;

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

        public NiaapiFileDownloader.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Filename of this Metadata package file, folder will be handled by api."</para>
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

        public NiaapiFileDownloader.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The presigned URL from server to download this file."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string PresignedUrl
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
            Intersight.Model.NiaapiFileDownloader initObject = new Intersight.Model.NiaapiFileDownloader();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("FileName"))
            {
                initObject.FileName = this.FileName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("PresignedUrl"))
            {
                initObject.PresignedUrl = this.PresignedUrl;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiaapiNdMetadata.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiaapiNdMetadata")]
    public class InitializeIntersightNiaapiNdMetadata : PSCmdlet
    {
        public InitializeIntersightNiaapiNdMetadata()
        {
            ClassId = NiaapiNdMetadata.ClassIdEnum.NiaapiNdMetadata;
            ObjectType = NiaapiNdMetadata.ObjectTypeEnum.NiaapiNdMetadata;

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

        public NiaapiNdMetadata.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.NiaapiDetail> Content
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The date when this package is generated."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime Date
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Chksum used to check the integrity of the Metadata file downloaded."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string MetadataChksum
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Filename of this Metadata package."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string MetadataFilename
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

        public NiaapiNdMetadata.ObjectTypeEnum ObjectType
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
        /// <para type="description">"The version number of the Metadata package."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Version
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.NiaapiNdMetadata initObject = new Intersight.Model.NiaapiNdMetadata();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Content"))
            {
                initObject.Content = this.Content;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Date"))
            {
                initObject.Date = this.Date;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MetadataChksum"))
            {
                initObject.MetadataChksum = this.MetadataChksum;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MetadataFilename"))
            {
                initObject.MetadataFilename = this.MetadataFilename;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
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
    /// <para type="synopsis">This is the cmdlet to Initialize NiaapiNdMetadataFileDownloader.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiaapiNdMetadataFileDownloader")]
    public class InitializeIntersightNiaapiNdMetadataFileDownloader : PSCmdlet
    {
        public InitializeIntersightNiaapiNdMetadataFileDownloader()
        {
            ClassId = NiaapiNdMetadataFileDownloader.ClassIdEnum.NiaapiNdMetadataFileDownloader;
            ObjectType = NiaapiNdMetadataFileDownloader.ObjectTypeEnum.NiaapiNdMetadataFileDownloader;

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

        public NiaapiNdMetadataFileDownloader.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Filename of this Metadata package file, folder will be handled by api."</para>
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

        public NiaapiNdMetadataFileDownloader.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The presigned URL from server to download this file."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string PresignedUrl
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
            Intersight.Model.NiaapiNdMetadataFileDownloader initObject = new Intersight.Model.NiaapiNdMetadataFileDownloader();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("FileName"))
            {
                initObject.FileName = this.FileName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("PresignedUrl"))
            {
                initObject.PresignedUrl = this.PresignedUrl;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiaapiNewReleaseDetail.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiaapiNewReleaseDetail")]
    public class InitializeIntersightNiaapiNewReleaseDetail : PSCmdlet
    {
        public InitializeIntersightNiaapiNewReleaseDetail()
        {
            ClassId = NiaapiNewReleaseDetail.ClassIdEnum.NiaapiNewReleaseDetail;
            ObjectType = NiaapiNewReleaseDetail.ObjectTypeEnum.NiaapiNewReleaseDetail;

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

        public NiaapiNewReleaseDetail.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of this new verison release post."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Link of downloading the release file."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Link
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public NiaapiNewReleaseDetail.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The link used to provide a gateway for customer to review the release note."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ReleaseNoteLink
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The link title used to provide a gateway for customer to review the release note."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ReleaseNoteLinkTitle
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The link used to provide a gateway for customer to download the release."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SoftwareDownloadLink
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The link title used to provide a gateway for customer to download the release."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SoftwareDownloadLinkTitle
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Title of the new verison release post."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Title
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version number Associate with this Post."</para>
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
                initObject.VarVersion = this.Version;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiaapiNiaMetadata.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiaapiNiaMetadata")]
    public class InitializeIntersightNiaapiNiaMetadata : PSCmdlet
    {
        public InitializeIntersightNiaapiNiaMetadata()
        {
            ClassId = NiaapiNiaMetadata.ClassIdEnum.NiaapiNiaMetadata;
            ObjectType = NiaapiNiaMetadata.ObjectTypeEnum.NiaapiNiaMetadata;

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

        public NiaapiNiaMetadata.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.NiaapiDetail> Content
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The date when this package is generated."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime Date
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Chksum used to check the integrity of the Metadata file downloaded."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string MetadataChksum
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Filename of this Metadata package."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string MetadataFilename
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

        public NiaapiNiaMetadata.ObjectTypeEnum ObjectType
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
        /// <para type="description">"The version number of the Metadata package."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Version
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.NiaapiNiaMetadata initObject = new Intersight.Model.NiaapiNiaMetadata();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Content"))
            {
                initObject.Content = this.Content;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Date"))
            {
                initObject.Date = this.Date;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MetadataChksum"))
            {
                initObject.MetadataChksum = this.MetadataChksum;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MetadataFilename"))
            {
                initObject.MetadataFilename = this.MetadataFilename;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
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
    /// <para type="synopsis">This is the cmdlet to Initialize NiaapiNibFileDownloader.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiaapiNibFileDownloader")]
    public class InitializeIntersightNiaapiNibFileDownloader : PSCmdlet
    {
        public InitializeIntersightNiaapiNibFileDownloader()
        {
            ClassId = NiaapiNibFileDownloader.ClassIdEnum.NiaapiNibFileDownloader;
            ObjectType = NiaapiNibFileDownloader.ObjectTypeEnum.NiaapiNibFileDownloader;

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

        public NiaapiNibFileDownloader.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Filename of this Metadata package file, folder will be handled by api."</para>
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

        public NiaapiNibFileDownloader.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The presigned URL from server to download this file."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string PresignedUrl
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
            Intersight.Model.NiaapiNibFileDownloader initObject = new Intersight.Model.NiaapiNibFileDownloader();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("FileName"))
            {
                initObject.FileName = this.FileName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("PresignedUrl"))
            {
                initObject.PresignedUrl = this.PresignedUrl;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiaapiNibMetadata.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiaapiNibMetadata")]
    public class InitializeIntersightNiaapiNibMetadata : PSCmdlet
    {
        public InitializeIntersightNiaapiNibMetadata()
        {
            ClassId = NiaapiNibMetadata.ClassIdEnum.NiaapiNibMetadata;
            ObjectType = NiaapiNibMetadata.ObjectTypeEnum.NiaapiNibMetadata;

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

        public NiaapiNibMetadata.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.NiaapiDetail> Content
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The date when the package was generated."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime Date
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Chksum used to check the integrity of the metadata file downloaded."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string MetadataChksum
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The filename of the metadata package."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string MetadataFilename
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

        public NiaapiNibMetadata.ObjectTypeEnum ObjectType
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
        /// <para type="description">"The version number of the metadata package."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Version
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.NiaapiNibMetadata initObject = new Intersight.Model.NiaapiNibMetadata();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Content"))
            {
                initObject.Content = this.Content;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Date"))
            {
                initObject.Date = this.Date;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MetadataChksum"))
            {
                initObject.MetadataChksum = this.MetadataChksum;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MetadataFilename"))
            {
                initObject.MetadataFilename = this.MetadataFilename;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
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
    /// <para type="synopsis">This is the cmdlet to Initialize NiaapiPuvScriptDownloader.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiaapiPuvScriptDownloader")]
    public class InitializeIntersightNiaapiPuvScriptDownloader : PSCmdlet
    {
        public InitializeIntersightNiaapiPuvScriptDownloader()
        {
            ClassId = NiaapiPuvScriptDownloader.ClassIdEnum.NiaapiPuvScriptDownloader;
            ObjectType = NiaapiPuvScriptDownloader.ObjectTypeEnum.NiaapiPuvScriptDownloader;

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

        public NiaapiPuvScriptDownloader.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Filename of this Metadata script file, folder will be handled by api."</para>
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

        public NiaapiPuvScriptDownloader.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The presigned URL from server to download this script."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string PresignedUrl
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
            Intersight.Model.NiaapiPuvScriptDownloader initObject = new Intersight.Model.NiaapiPuvScriptDownloader();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("FileName"))
            {
                initObject.FileName = this.FileName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("PresignedUrl"))
            {
                initObject.PresignedUrl = this.PresignedUrl;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiaapiRevisionInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiaapiRevisionInfo")]
    public class InitializeIntersightNiaapiRevisionInfo : PSCmdlet
    {
        public InitializeIntersightNiaapiRevisionInfo()
        {
            ClassId = NiaapiRevisionInfo.ClassIdEnum.NiaapiRevisionInfo;
            ObjectType = NiaapiRevisionInfo.ObjectTypeEnum.NiaapiRevisionInfo;

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

        public NiaapiRevisionInfo.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The date the revision is made."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime DatePublished
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public NiaapiRevisionInfo.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The changes made in this revision."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string RevisionComment
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Revision No. of this revision."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string RevisionNo
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
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
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiaapiSnValidatorMetadata.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiaapiSnValidatorMetadata")]
    public class InitializeIntersightNiaapiSnValidatorMetadata : PSCmdlet
    {
        public InitializeIntersightNiaapiSnValidatorMetadata()
        {
            ClassId = NiaapiSnValidatorMetadata.ClassIdEnum.NiaapiSnValidatorMetadata;
            ObjectType = NiaapiSnValidatorMetadata.ObjectTypeEnum.NiaapiSnValidatorMetadata;

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
        /// <para type="description">"Checksum of SnValidatorData file."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Checksum
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public NiaapiSnValidatorMetadata.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The filename of sn metadata file."</para>
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

        public NiaapiSnValidatorMetadata.ObjectTypeEnum ObjectType
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
        /// <para type="description">"The version number of the SerialNumber Metadata."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Version
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.NiaapiSnValidatorMetadata initObject = new Intersight.Model.NiaapiSnValidatorMetadata();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Checksum"))
            {
                initObject.Checksum = this.Checksum;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("FileName"))
            {
                initObject.FileName = this.FileName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
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
    /// <para type="synopsis">This is the cmdlet to Initialize NiaapiSoftwareRegex.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiaapiSoftwareRegex")]
    public class InitializeIntersightNiaapiSoftwareRegex : PSCmdlet
    {
        public InitializeIntersightNiaapiSoftwareRegex()
        {
            ClassId = NiaapiSoftwareRegex.ClassIdEnum.NiaapiSoftwareRegex;
            ObjectType = NiaapiSoftwareRegex.ObjectTypeEnum.NiaapiSoftwareRegex;

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

        public NiaapiSoftwareRegex.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public NiaapiSoftwareRegex.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Regular Expression pattern used to reconginze the version string."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Regex
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Software release. A set of Software releases seperated by comma which can be recongized by according Regex pattern."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SoftwareVersion
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
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
    /// <para type="synopsis">This is the cmdlet to Initialize NiaapiUpgradeAssistFile.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiaapiUpgradeAssistFile")]
    public class InitializeIntersightNiaapiUpgradeAssistFile : PSCmdlet
    {
        public InitializeIntersightNiaapiUpgradeAssistFile()
        {
            ClassId = NiaapiUpgradeAssistFile.ClassIdEnum.NiaapiUpgradeAssistFile;
            ObjectType = NiaapiUpgradeAssistFile.ObjectTypeEnum.NiaapiUpgradeAssistFile;

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

        public NiaapiUpgradeAssistFile.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Filename of desired controller file, folder will be handled by api and query filtering."</para>
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

        public NiaapiUpgradeAssistFile.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The presigned URL from server to download this file."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string PresignedUrl
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
            Intersight.Model.NiaapiUpgradeAssistFile initObject = new Intersight.Model.NiaapiUpgradeAssistFile();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("FileName"))
            {
                initObject.FileName = this.FileName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("PresignedUrl"))
            {
                initObject.PresignedUrl = this.PresignedUrl;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiaapiVersionRegex.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiaapiVersionRegex")]
    public class InitializeIntersightNiaapiVersionRegex : PSCmdlet
    {
        public InitializeIntersightNiaapiVersionRegex()
        {
            ClassId = NiaapiVersionRegex.ClassIdEnum.NiaapiVersionRegex;
            ObjectType = NiaapiVersionRegex.ObjectTypeEnum.NiaapiVersionRegex;

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
        /// <para type="description">"Version Regex mapping for APIC platform."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.NiaapiVersionRegexPlatform Apic
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public NiaapiVersionRegex.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version Regex mapping for DCNM platform."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.NiaapiVersionRegexPlatform Dcnm
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

        public NiaapiVersionRegex.ObjectTypeEnum ObjectType
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
        /// <para type="description">"Version number for the Version Regex data, also used as identity."</para>
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
            Intersight.Model.NiaapiVersionRegex initObject = new Intersight.Model.NiaapiVersionRegex();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Apic"))
            {
                initObject.Apic = this.Apic;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Dcnm"))
            {
                initObject.Dcnm = this.Dcnm;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
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
    /// <para type="synopsis">This is the cmdlet to Initialize NiaapiVersionRegexPlatform.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiaapiVersionRegexPlatform")]
    public class InitializeIntersightNiaapiVersionRegexPlatform : PSCmdlet
    {
        public InitializeIntersightNiaapiVersionRegexPlatform()
        {
            ClassId = NiaapiVersionRegexPlatform.ClassIdEnum.NiaapiVersionRegexPlatform;
            ObjectType = NiaapiVersionRegexPlatform.ObjectTypeEnum.NiaapiVersionRegexPlatform;

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
        /// <para type="description">"All long live version Regex pattern."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Anyllregex
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public NiaapiVersionRegexPlatform.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Current long live version Regex pattern."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.NiaapiSoftwareRegex Currentlltrain
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Latest short live version Regex pattern."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.NiaapiSoftwareRegex Latestsltrain
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public NiaapiVersionRegexPlatform.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.NiaapiSoftwareRegex> Sltrain
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Upcoming short live version Regex pattern."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.NiaapiSoftwareRegex Upcominglltrain
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
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
}