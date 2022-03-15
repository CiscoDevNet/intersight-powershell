using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize InfraMetaData.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightInfraMetaData")]
    public class InitializeIntersightInfraMetaData:PSCmdlet
	{
		public InitializeIntersightInfraMetaData()
		{
            ClassId = InfraMetaData.ClassIdEnum.InfraMetaData;
            ObjectType = InfraMetaData.ObjectTypeEnum.InfraMetaData;
            
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
        
        public InfraMetaData.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public InfraMetaData.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.InfraMetaData initObject = new Intersight.Model.InfraMetaData();
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
    /// <para type="synopsis">This is the cmdlet to Initialize InfraHardwareInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightInfraHardwareInfo")]
    public class InitializeIntersightInfraHardwareInfo:PSCmdlet
	{
		public InitializeIntersightInfraHardwareInfo()
		{
            ClassId = InfraHardwareInfo.ClassIdEnum.InfraHardwareInfo;
            ObjectType = InfraHardwareInfo.ObjectTypeEnum.InfraHardwareInfo;
            
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
        
        public InfraHardwareInfo.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of cpu cores on this hardware platform."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long CpuCores {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Speed of cpu in MHz. Usually cpu speeds are reported for modern cpus in GHz but MHz makes it more precise."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long CpuSpeed {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The amount of memory allocated (bytes) to this hardware platform."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long MemorySize {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public InfraHardwareInfo.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.InfraHardwareInfo initObject = new Intersight.Model.InfraHardwareInfo();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("CpuCores"))
            {
                initObject.CpuCores = this.CpuCores;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CpuSpeed"))
            {
                initObject.CpuSpeed = this.CpuSpeed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MemorySize"))
            {
                initObject.MemorySize = this.MemorySize;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
}