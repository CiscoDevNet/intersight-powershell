using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize CertificatemanagementImc.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCertificatemanagementImc")]
    public class InitializeIntersightCertificatemanagementImc:PSCmdlet
	{
		public InitializeIntersightCertificatemanagementImc()
		{
            ClassId = CertificatemanagementImc.ClassIdEnum.CertificatemanagementImc;
            ObjectType = CertificatemanagementImc.ObjectTypeEnum.CertificatemanagementImc;
            
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
        /// <para type="description">"Certificate that is used for verifying the authorization."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.X509Certificate Certificate {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public CertificatemanagementImc.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Enable/Disable the certificate in Certificate Management policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Enabled {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public CertificatemanagementImc.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Private Key which is used to validate the certificate."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Privatekey {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.CertificatemanagementImc initObject = new Intersight.Model.CertificatemanagementImc();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Certificate"))
            {
                initObject.Certificate = this.Certificate;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Enabled"))
            {
                initObject.Enabled = this.Enabled;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Privatekey"))
            {
                initObject.Privatekey = this.Privatekey;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize CertificatemanagementCertificateBase.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCertificatemanagementCertificateBase")]
    public class InitializeIntersightCertificatemanagementCertificateBase:PSCmdlet
	{
		public InitializeIntersightCertificatemanagementCertificateBase()
		{
            ClassId = CertificatemanagementCertificateBase.ClassIdEnum.CertificatemanagementImc;
            ObjectType = CertificatemanagementCertificateBase.ObjectTypeEnum.CertificatemanagementImc;
            
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
        /// <para type="description">"Certificate that is used for verifying the authorization."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.X509Certificate Certificate {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public CertificatemanagementCertificateBase.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Enable/Disable the certificate in Certificate Management policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Enabled {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public CertificatemanagementCertificateBase.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Private Key which is used to validate the certificate."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Privatekey {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.CertificatemanagementCertificateBase initObject = new Intersight.Model.CertificatemanagementCertificateBase();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Certificate"))
            {
                initObject.Certificate = this.Certificate;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Enabled"))
            {
                initObject.Enabled = this.Enabled;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Privatekey"))
            {
                initObject.Privatekey = this.Privatekey;
            }
            WriteObject(initObject);
        }

    }
}