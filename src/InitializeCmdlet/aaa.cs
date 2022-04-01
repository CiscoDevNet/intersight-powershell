using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize AaaRetentionConfig.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAaaRetentionConfig")]
    public class InitializeIntersightAaaRetentionConfig : PSCmdlet
    {
        public InitializeIntersightAaaRetentionConfig()
        {
            ClassId = AaaRetentionConfig.ClassIdEnum.AaaRetentionConfig;
            ObjectType = AaaRetentionConfig.ObjectTypeEnum.AaaRetentionConfig;

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

        public AaaRetentionConfig.ClassIdEnum ClassId
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

        public AaaRetentionConfig.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The default retention period in months for audit log retention for accounts without a retention policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(6, 48)]
        public long RetentionPeriod
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
            Intersight.Model.AaaRetentionConfig initObject = new Intersight.Model.AaaRetentionConfig();
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
            if (this.MyInvocation.BoundParameters.ContainsKey("RetentionPeriod"))
            {
                initObject.RetentionPeriod = this.RetentionPeriod;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize AaaRetentionPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAaaRetentionPolicy")]
    public class InitializeIntersightAaaRetentionPolicy : PSCmdlet
    {
        public InitializeIntersightAaaRetentionPolicy()
        {
            ClassId = AaaRetentionPolicy.ClassIdEnum.AaaRetentionPolicy;
            ObjectType = AaaRetentionPolicy.ObjectTypeEnum.AaaRetentionPolicy;

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

        public AaaRetentionPolicy.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AaaRetentionPolicy.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The time period in months for audit log retention. Audit logs beyond this period will be automatically deleted."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long RetentionPeriod
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
            Intersight.Model.AaaRetentionPolicy initObject = new Intersight.Model.AaaRetentionPolicy();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("RetentionPeriod"))
            {
                initObject.RetentionPeriod = this.RetentionPeriod;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize AaaAuditRecord.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAaaAuditRecord")]
    public class InitializeIntersightAaaAuditRecord : PSCmdlet
    {
        public InitializeIntersightAaaAuditRecord()
        {
            ClassId = AaaAuditRecord.ClassIdEnum.AaaAuditRecord;
            ObjectType = AaaAuditRecord.ObjectTypeEnum.AaaAuditRecord;

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

        public AaaAuditRecord.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The email of the associated user that made the change.  In case the user is later deleted, we still have some reference to the information."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$")]
        public string Email
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The operation that was performed on this Managed Object.\nThe event is a compound string that includes the CRUD operation such as Create, Modify, Delete, and a string representing the Managed Object type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Event
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The instance id of AuditRecordLocal, which is used to identify if the comming AuditRecordLocal was already processed before."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string InstId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The user-friendly names of the changed MO."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object MoDisplayNames
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The object type of the REST resource that was created, modified or deleted."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string MoType
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
        /// <para type="description">"The Moid of the REST resource that was created, modified or deleted."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ObjectMoid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AaaAuditRecord.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The body of the REST request that was received from a client to create or modify a REST resource, represented as a JSON document."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object Request
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The sessionId in which the user made the change. In case that the session is later deleted, we still have some reference to the information."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SessionId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The source IP of the client."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SourceIp
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
        /// <para type="description">"The trace id of the request that was used to create, modify or delete a REST resource.\nA trace id is a unique identifier for one particular REST request. It may be used for troubleshooting purpose\nby the Intersight technical support team."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string TraceId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The userId or the email of the associated user that made the change. In case that user is later deleted, we still have some reference to the information."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string UserIdOrEmail
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.AaaAuditRecord initObject = new Intersight.Model.AaaAuditRecord();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Email"))
            {
                initObject.Email = this.Email;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Event"))
            {
                initObject.Event = this.Event;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InstId"))
            {
                initObject.InstId = this.InstId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MoDisplayNames"))
            {
                initObject.MoDisplayNames = this.MoDisplayNames;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MoType"))
            {
                initObject.MoType = this.MoType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ObjectMoid"))
            {
                initObject.ObjectMoid = this.ObjectMoid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Request"))
            {
                initObject.Request = this.Request;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SessionId"))
            {
                initObject.SessionId = this.SessionId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SourceIp"))
            {
                initObject.SourceIp = this.SourceIp;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TraceId"))
            {
                initObject.TraceId = this.TraceId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UserIdOrEmail"))
            {
                initObject.UserIdOrEmail = this.UserIdOrEmail;
            }
            WriteObject(initObject);
        }

    }
}