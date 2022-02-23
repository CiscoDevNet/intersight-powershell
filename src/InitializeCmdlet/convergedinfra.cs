using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ConvergedinfraComplianceSummary.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightConvergedinfraComplianceSummary")]
    public class InitializeIntersightConvergedinfraComplianceSummary:PSCmdlet
	{
		public InitializeIntersightConvergedinfraComplianceSummary()
		{
            ClassId = ConvergedinfraComplianceSummary.ClassIdEnum.ConvergedinfraComplianceSummary;
            ObjectType = ConvergedinfraComplianceSummary.ObjectTypeEnum.ConvergedinfraComplianceSummary;
            
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
        
        public ConvergedinfraComplianceSummary.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The count of elements where compliance information is not available. eg. For HCL of server, OS information is not available."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Incomplete {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The count of elements where compliance has not been evaluated. e.g. For HCL of server, status has not been evaluated due to lack of information."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long NotEvaluated {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The count of elements where compliance has failed for one or more reason. e.g. For HCL of server, some part of the HCL validation has failed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long NotListed {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ConvergedinfraComplianceSummary.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The count of elements where compliance has passed validation for all components. e.g. For HCL of server, all of the components have passed validation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Validated {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.ConvergedinfraComplianceSummary initObject = new Intersight.Model.ConvergedinfraComplianceSummary();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Incomplete"))
            {
                initObject.Incomplete = this.Incomplete;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NotEvaluated"))
            {
                initObject.NotEvaluated = this.NotEvaluated;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NotListed"))
            {
                initObject.NotListed = this.NotListed;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Validated"))
            {
                initObject.Validated = this.Validated;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ConvergedinfraPodSummary.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightConvergedinfraPodSummary")]
    public class InitializeIntersightConvergedinfraPodSummary:PSCmdlet
	{
		public InitializeIntersightConvergedinfraPodSummary()
		{
            ClassId = ConvergedinfraPodSummary.ClassIdEnum.ConvergedinfraPodSummary;
            ObjectType = ConvergedinfraPodSummary.ObjectTypeEnum.ConvergedinfraPodSummary;
            
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
        
        public ConvergedinfraPodSummary.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ConvergedinfraPodSummary.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.ConvergedinfraPodSummary initObject = new Intersight.Model.ConvergedinfraPodSummary();
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
    /// <para type="synopsis">This is the cmdlet to Initialize ConvergedinfraAlarmSummary.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightConvergedinfraAlarmSummary")]
    public class InitializeIntersightConvergedinfraAlarmSummary:PSCmdlet
	{
		public InitializeIntersightConvergedinfraAlarmSummary()
		{
            ClassId = ConvergedinfraAlarmSummary.ClassIdEnum.ConvergedinfraAlarmSummary;
            ObjectType = ConvergedinfraAlarmSummary.ObjectTypeEnum.ConvergedinfraAlarmSummary;
            
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
        
        public ConvergedinfraAlarmSummary.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The count of alarms that have severity type Critical."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Critical {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ConvergedinfraAlarmSummary.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The count of alarms that have severity type Warning."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Warning {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.ConvergedinfraAlarmSummary initObject = new Intersight.Model.ConvergedinfraAlarmSummary();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Critical"))
            {
                initObject.Critical = this.Critical;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Warning"))
            {
                initObject.Warning = this.Warning;
            }
            WriteObject(initObject);
        }

    }
}