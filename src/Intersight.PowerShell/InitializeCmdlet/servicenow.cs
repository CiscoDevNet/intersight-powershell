using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ServicenowChangeRequest.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightServicenowChangeRequest")]
    public class InitializeIntersightServicenowChangeRequest : PSCmdlet
    {
        public InitializeIntersightServicenowChangeRequest()
        {
            ClassId = ServicenowChangeRequest.ClassIdEnum.ServicenowChangeRequest;
            ObjectType = ServicenowChangeRequest.ObjectTypeEnum.ServicenowChangeRequest;

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
        /// <para type="description">"The approver of Change Request."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Approval
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Assigned to value for Change Request."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string AssignedTo
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Assigned to display value for Change Request."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string AssignedToDisplayValue
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Change Model for Change Request."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ChangeModel
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Change Model display value for Change Request."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ChangeModelDisplayValue
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number for Change Request."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ChangeRequestNumber
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ServicenowChangeRequest.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Comments on Change Request."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Comments
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Creator of Change Request."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string CreatedBy
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description for Change Request."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Due date for Change Request."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string DueDate
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"End date for Change Request."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string EndDate
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Impact for Change Request."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Impact
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Impact display value for Change Request."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ImpactDisplayValue
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

        public ServicenowChangeRequest.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Priority for Change Request."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Priority
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Priority display value for Change Request."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string PriorityDisplayValue
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The risk for Change Request."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Risk
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Short Description for Change Request."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ShortDescription
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Start date for Change Request."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string StartDate
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Sys Id for Change Request."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SysId
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
        /// <para type="description">"The type for Change Request."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Type
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Last update Change Request."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string UpdatedBy
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.ServicenowChangeRequest initObject = new Intersight.Model.ServicenowChangeRequest();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Approval"))
            {
                initObject.Approval = this.Approval;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AssignedTo"))
            {
                initObject.AssignedTo = this.AssignedTo;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AssignedToDisplayValue"))
            {
                initObject.AssignedToDisplayValue = this.AssignedToDisplayValue;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ChangeModel"))
            {
                initObject.ChangeModel = this.ChangeModel;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ChangeModelDisplayValue"))
            {
                initObject.ChangeModelDisplayValue = this.ChangeModelDisplayValue;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ChangeRequestNumber"))
            {
                initObject.ChangeRequestNumber = this.ChangeRequestNumber;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Comments"))
            {
                initObject.Comments = this.Comments;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CreatedBy"))
            {
                initObject.CreatedBy = this.CreatedBy;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DueDate"))
            {
                initObject.DueDate = this.DueDate;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EndDate"))
            {
                initObject.EndDate = this.EndDate;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Impact"))
            {
                initObject.Impact = this.Impact;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ImpactDisplayValue"))
            {
                initObject.ImpactDisplayValue = this.ImpactDisplayValue;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Priority"))
            {
                initObject.Priority = this.Priority;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PriorityDisplayValue"))
            {
                initObject.PriorityDisplayValue = this.PriorityDisplayValue;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Risk"))
            {
                initObject.Risk = this.Risk;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ShortDescription"))
            {
                initObject.ShortDescription = this.ShortDescription;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("StartDate"))
            {
                initObject.StartDate = this.StartDate;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SysId"))
            {
                initObject.SysId = this.SysId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Type"))
            {
                initObject.Type = this.Type;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UpdatedBy"))
            {
                initObject.UpdatedBy = this.UpdatedBy;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ServicenowIncident.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightServicenowIncident")]
    public class InitializeIntersightServicenowIncident : PSCmdlet
    {
        public InitializeIntersightServicenowIncident()
        {
            ClassId = ServicenowIncident.ClassIdEnum.ServicenowIncident;
            ObjectType = ServicenowIncident.ObjectTypeEnum.ServicenowIncident;

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
        /// <para type="description">"The approver property of Incident."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Approval
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Category property for Incident."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Category
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ServicenowIncident.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Comments property on Incident."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Comments
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Creator property of Incident."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string CreatedBy
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Incident create date property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string CreatedOn
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description for Incident."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Due date property for Incident."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string DueDate
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Expected start date for Incident."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ExpectedStart
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Impact property for Incident."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Impact
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"State property of the Incident."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string IncidentState
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

        public ServicenowIncident.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Assigned to value for Incident."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string OpenedBy
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Priority property for Incident."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Priority
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The risk property for Incident."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Risk
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Severity property of the Incident."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Severity
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Short Description for Incident."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ShortDescription
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"System Id property for Incident."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SysId
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
        /// <para type="description">"Task Effective Number for Incident."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string TaskEffectiveNumber
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Last update by on Incident."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string UpdatedBy
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Urgency property of the Incident."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Urgency
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Work end date for Incident."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string WorkEnd
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Work start date for Incident."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string WorkStart
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.ServicenowIncident initObject = new Intersight.Model.ServicenowIncident();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Approval"))
            {
                initObject.Approval = this.Approval;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Category"))
            {
                initObject.Category = this.Category;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Comments"))
            {
                initObject.Comments = this.Comments;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CreatedBy"))
            {
                initObject.CreatedBy = this.CreatedBy;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CreatedOn"))
            {
                initObject.CreatedOn = this.CreatedOn;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DueDate"))
            {
                initObject.DueDate = this.DueDate;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ExpectedStart"))
            {
                initObject.ExpectedStart = this.ExpectedStart;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Impact"))
            {
                initObject.Impact = this.Impact;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IncidentState"))
            {
                initObject.IncidentState = this.IncidentState;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("OpenedBy"))
            {
                initObject.OpenedBy = this.OpenedBy;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Priority"))
            {
                initObject.Priority = this.Priority;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Risk"))
            {
                initObject.Risk = this.Risk;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Severity"))
            {
                initObject.Severity = this.Severity;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ShortDescription"))
            {
                initObject.ShortDescription = this.ShortDescription;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SysId"))
            {
                initObject.SysId = this.SysId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TaskEffectiveNumber"))
            {
                initObject.TaskEffectiveNumber = this.TaskEffectiveNumber;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UpdatedBy"))
            {
                initObject.UpdatedBy = this.UpdatedBy;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Urgency"))
            {
                initObject.Urgency = this.Urgency;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("WorkEnd"))
            {
                initObject.WorkEnd = this.WorkEnd;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("WorkStart"))
            {
                initObject.WorkStart = this.WorkStart;
            }
            WriteObject(initObject);
        }

    }
}