using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ApplianceKeyValuePair.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightApplianceKeyValuePair")]
    public class InitializeIntersightApplianceKeyValuePair:PSCmdlet
	{
		public InitializeIntersightApplianceKeyValuePair()
		{
            ClassId = ApplianceKeyValuePair.ClassIdEnum.ApplianceKeyValuePair;
            ObjectType = ApplianceKeyValuePair.ObjectTypeEnum.ApplianceKeyValuePair;
            
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
        
        public ApplianceKeyValuePair.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ApplianceKeyValuePair.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.ApplianceKeyValuePair initObject = new Intersight.Model.ApplianceKeyValuePair();
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
    /// <para type="synopsis">This is the cmdlet to Initialize ApplianceStatusCheck.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightApplianceStatusCheck")]
    public class InitializeIntersightApplianceStatusCheck:PSCmdlet
	{
		public InitializeIntersightApplianceStatusCheck()
		{
            ClassId = ApplianceStatusCheck.ClassIdEnum.ApplianceStatusCheck;
            ObjectType = ApplianceStatusCheck.ObjectTypeEnum.ApplianceStatusCheck;
            Result = ApplianceStatusCheck.ResultEnum.OK;
            
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
        
        public ApplianceStatusCheck.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Unique identifier of the status check."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Code {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ApplianceStatusCheck.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Result of this status check.\n* `OK` - Result of the check is OK.\n* `Warning` - Result of the check is Warning.\n* `Critical` - Result of the check is Critical.\n* `Info` - Result of the check is low."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ApplianceStatusCheck.ResultEnum Result {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.ApplianceStatusCheck initObject = new Intersight.Model.ApplianceStatusCheck();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Code"))
            {
                initObject.Code = this.Code;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Result"))
            {
                initObject.Result = this.Result;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ApplianceApiStatus.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightApplianceApiStatus")]
    public class InitializeIntersightApplianceApiStatus:PSCmdlet
	{
		public InitializeIntersightApplianceApiStatus()
		{
            ClassId = ApplianceApiStatus.ClassIdEnum.ApplianceApiStatus;
            ObjectType = ApplianceApiStatus.ObjectTypeEnum.ApplianceApiStatus;
            
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
        
        public ApplianceApiStatus.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ApplianceApiStatus.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.ApplianceApiStatus initObject = new Intersight.Model.ApplianceApiStatus();
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
    /// <para type="synopsis">This is the cmdlet to Initialize ApplianceCertRenewalPhase.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightApplianceCertRenewalPhase")]
    public class InitializeIntersightApplianceCertRenewalPhase:PSCmdlet
	{
		public InitializeIntersightApplianceCertRenewalPhase()
		{
            ClassId = ApplianceCertRenewalPhase.ClassIdEnum.ApplianceCertRenewalPhase;
            ObjectType = ApplianceCertRenewalPhase.ObjectTypeEnum.ApplianceCertRenewalPhase;
            
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
        
        public ApplianceCertRenewalPhase.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ApplianceCertRenewalPhase.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.ApplianceCertRenewalPhase initObject = new Intersight.Model.ApplianceCertRenewalPhase();
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