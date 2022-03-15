using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IaasLicenseUtilizationInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIaasLicenseUtilizationInfo")]
    public class InitializeIntersightIaasLicenseUtilizationInfo:PSCmdlet
	{
		public InitializeIntersightIaasLicenseUtilizationInfo()
		{
            ClassId = IaasLicenseUtilizationInfo.ClassIdEnum.IaasLicenseUtilizationInfo;
            ObjectType = IaasLicenseUtilizationInfo.ObjectTypeEnum.IaasLicenseUtilizationInfo;
            
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
        
        public IaasLicenseUtilizationInfo.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IaasLicenseUtilizationInfo.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.IaasLicenseUtilizationInfo initObject = new Intersight.Model.IaasLicenseUtilizationInfo();
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
    /// <para type="synopsis">This is the cmdlet to Initialize IaasWorkflowSteps.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIaasWorkflowSteps")]
    public class InitializeIntersightIaasWorkflowSteps:PSCmdlet
	{
		public InitializeIntersightIaasWorkflowSteps()
		{
            ClassId = IaasWorkflowSteps.ClassIdEnum.IaasWorkflowSteps;
            ObjectType = IaasWorkflowSteps.ObjectTypeEnum.IaasWorkflowSteps;
            
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
        
        public IaasWorkflowSteps.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IaasWorkflowSteps.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.IaasWorkflowSteps initObject = new Intersight.Model.IaasWorkflowSteps();
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
    /// <para type="synopsis">This is the cmdlet to Initialize IaasLicenseKeysInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIaasLicenseKeysInfo")]
    public class InitializeIntersightIaasLicenseKeysInfo:PSCmdlet
	{
		public InitializeIntersightIaasLicenseKeysInfo()
		{
            ClassId = IaasLicenseKeysInfo.ClassIdEnum.IaasLicenseKeysInfo;
            ObjectType = IaasLicenseKeysInfo.ObjectTypeEnum.IaasLicenseKeysInfo;
            
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
        
        public IaasLicenseKeysInfo.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IaasLicenseKeysInfo.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.IaasLicenseKeysInfo initObject = new Intersight.Model.IaasLicenseKeysInfo();
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