using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ServiceitemHealthCheckErrorElement.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightServiceitemHealthCheckErrorElement")]
    public class InitializeIntersightServiceitemHealthCheckErrorElement : PSCmdlet
    {
        public InitializeIntersightServiceitemHealthCheckErrorElement()
        {
            ClassId = ServiceitemHealthCheckErrorElement.ClassIdEnum.ServiceitemHealthCheckErrorElement;
            ObjectType = ServiceitemHealthCheckErrorElement.ObjectTypeEnum.ServiceitemHealthCheckErrorElement;

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

        public ServiceitemHealthCheckErrorElement.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of the element of the service item. Examples are Server, Storage, UCS Fabric Interconnect etc."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ElementType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoMoRef> Elements
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ServiceitemHealthCheckErrorElement.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.ServiceitemHealthCheckErrorElement initObject = new Intersight.Model.ServiceitemHealthCheckErrorElement();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ElementType"))
            {
                initObject.ElementType = this.ElementType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Elements"))
            {
                initObject.Elements = this.Elements;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
}