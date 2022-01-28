using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize RecoveryConfigParams.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightRecoveryConfigParams")]
    public class InitializeIntersightRecoveryConfigParams:PSCmdlet
	{
		public InitializeIntersightRecoveryConfigParams()
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
        
        public RecoveryConfigParams.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public RecoveryConfigParams.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.RecoveryConfigParams initObject = new Intersight.Model.RecoveryConfigParams();
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
    /// <para type="synopsis">This is the cmdlet to Initialize RecoveryBackupSchedule.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightRecoveryBackupSchedule")]
    public class InitializeIntersightRecoveryBackupSchedule:PSCmdlet
	{
		public InitializeIntersightRecoveryBackupSchedule()
		{
            ClassId = RecoveryBackupSchedule.ClassIdEnum.RecoveryBackupSchedule;
            FrequencyUnit = RecoveryBackupSchedule.FrequencyUnitEnum.Daily;
            Hours = RecoveryBackupSchedule.HoursEnum.NUMBER_8;
            ObjectType = RecoveryBackupSchedule.ObjectTypeEnum.RecoveryBackupSchedule;
            
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
        
        public RecoveryBackupSchedule.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The time at which the backup is to be run on a given day. Applicable when the frequency unit is daily."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public DateTime ExecutionTime {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The frequency at which the backup schedule must run.\n* `Daily` - Allows the user to run the backup daily at a given time.\n* `Periodic` - Allows the user to run the backup after a certain number of hours."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public RecoveryBackupSchedule.FrequencyUnitEnum FrequencyUnit {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The frequency, in hours, at which the backup schedule runs.\n* `8` - The backup interval is 8 hours.\n* `4` - The backup interval is 4 hours.\n* `12` - The backup interval is 12 hours.\n* `16` - The backup interval is 16 hours.\n* `20` - The backup interval is 20 hours."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public RecoveryBackupSchedule.HoursEnum Hours {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public RecoveryBackupSchedule.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.RecoveryBackupSchedule initObject = new Intersight.Model.RecoveryBackupSchedule();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ExecutionTime"))
            {
                initObject.ExecutionTime = this.ExecutionTime;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FrequencyUnit"))
            {
                initObject.FrequencyUnit = this.FrequencyUnit;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Hours"))
            {
                initObject.Hours = this.Hours;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
}