using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ConnectorFileChecksum.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightConnectorFileChecksum")]
    public class InitializeIntersightConnectorFileChecksum:PSCmdlet
	{
		public InitializeIntersightConnectorFileChecksum()
		{
            ClassId = ConnectorFileChecksum.ClassIdEnum.ConnectorFileChecksum;
            HashAlgorithm = ConnectorFileChecksum.HashAlgorithmEnum.Crc;
            ObjectType = ConnectorFileChecksum.ObjectTypeEnum.ConnectorFileChecksum;
            
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
        
        public ConnectorFileChecksum.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The calculated hash of the contents using the algorithm."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public byte[] Hash {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The hash algorithm used to calculate the checksum.\n* `crc` - A CRC hash as definded by RFC 3385. Generated with the IEEE polynomial.\n* `sha256` - A SHA256 hash as defined by RFC 4634."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ConnectorFileChecksum.HashAlgorithmEnum HashAlgorithm {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ConnectorFileChecksum.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.ConnectorFileChecksum initObject = new Intersight.Model.ConnectorFileChecksum();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Hash"))
            {
                initObject.Hash = this.Hash;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HashAlgorithm"))
            {
                initObject.HashAlgorithm = this.HashAlgorithm;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ConnectorPlatformParamBase.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightConnectorPlatformParamBase")]
    public class InitializeIntersightConnectorPlatformParamBase:PSCmdlet
	{
		public InitializeIntersightConnectorPlatformParamBase()
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
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ConnectorPlatformParamBase.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ConnectorPlatformParamBase.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.ConnectorPlatformParamBase initObject = new Intersight.Model.ConnectorPlatformParamBase();
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