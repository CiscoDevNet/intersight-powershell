using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ForecastModel.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightForecastModel")]
    public class InitializeIntersightForecastModel:PSCmdlet
	{
		public InitializeIntersightForecastModel()
		{
            ClassId = ForecastModel.ClassIdEnum.ForecastModel;
            ModelType = ForecastModel.ModelTypeEnum.Linear;
            ObjectType = ForecastModel.ObjectTypeEnum.ForecastModel;
            
		}
        // <summary>
        /// <para type="description">"The standard error of the estimate is a measure of the accuracy of predictions from predective modeling."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public float Accuracy {
            get;
            set;
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
        
        public ForecastModel.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<decimal> ModelData {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Model type indicating type of predictive model used for computing forecast.\n* `Linear` - The Enum value Linear represents that the predictive model type used for forecast computation is linear regression."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ForecastModel.ModelTypeEnum ModelType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ForecastModel.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.ForecastModel initObject = new Intersight.Model.ForecastModel();
            if (this.MyInvocation.BoundParameters.ContainsKey("Accuracy"))
            {
                initObject.Accuracy = this.Accuracy;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ModelData"))
            {
                initObject.ModelData = this.ModelData;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ModelType"))
            {
                initObject.ModelType = this.ModelType;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
}