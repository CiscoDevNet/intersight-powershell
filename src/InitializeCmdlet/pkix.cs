using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize PkixRsaAlgorithm.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightPkixRsaAlgorithm")]
    public class InitializeIntersightPkixRsaAlgorithm:PSCmdlet
	{
		public InitializeIntersightPkixRsaAlgorithm()
		{
            ClassId = PkixRsaAlgorithm.ClassIdEnum.PkixRsaAlgorithm;
            Modulus = PkixRsaAlgorithm.ModulusEnum.NUMBER_2048;
            ObjectType = PkixRsaAlgorithm.ObjectTypeEnum.PkixRsaAlgorithm;
            
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
        
        public PkixRsaAlgorithm.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The length of the RSA key, expressed in bits, for both public and private keys.\n* `2048` - A key length of 2048 bits.\n* `2560` - A key length of 2560 bits.\n* `3072` - A key length of 3072 bits.\n* `3584` - A key length of 3584 bits.\n* `4096` - A key length of 4096 bits."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public PkixRsaAlgorithm.ModulusEnum Modulus {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public PkixRsaAlgorithm.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.PkixRsaAlgorithm initObject = new Intersight.Model.PkixRsaAlgorithm();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Modulus"))
            {
                initObject.Modulus = this.Modulus;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize PkixSubjectAlternateName.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightPkixSubjectAlternateName")]
    public class InitializeIntersightPkixSubjectAlternateName:PSCmdlet
	{
		public InitializeIntersightPkixSubjectAlternateName()
		{
            ClassId = PkixSubjectAlternateName.ClassIdEnum.PkixSubjectAlternateName;
            ObjectType = PkixSubjectAlternateName.ObjectTypeEnum.PkixSubjectAlternateName;
            
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
        
        public PkixSubjectAlternateName.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> DnsName {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> EmailAddress {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> IpAddress {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public PkixSubjectAlternateName.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> Uri {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.PkixSubjectAlternateName initObject = new Intersight.Model.PkixSubjectAlternateName();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("DnsName"))
            {
                initObject.DnsName = this.DnsName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EmailAddress"))
            {
                initObject.EmailAddress = this.EmailAddress;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IpAddress"))
            {
                initObject.IpAddress = this.IpAddress;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Uri"))
            {
                initObject.Uri = this.Uri;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize PkixEddsaKeySpec.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightPkixEddsaKeySpec")]
    public class InitializeIntersightPkixEddsaKeySpec:PSCmdlet
	{
		public InitializeIntersightPkixEddsaKeySpec()
		{
            Algorithm = PkixEddsaKeySpec.AlgorithmEnum.Ed25519;
            ClassId = PkixEddsaKeySpec.ClassIdEnum.PkixEddsaKeySpec;
            ObjectType = PkixEddsaKeySpec.ObjectTypeEnum.PkixEddsaKeySpec;
            
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
        /// <para type="description">"The EdDSA algorithm, as defined in RFC 8032.\n* `Ed25519` - The edwards25519 curve, as defined in RFC 8032 section 5.1.\n* `Ed25519ph` - The edwards25519 curve for the PureEdDSA variant.\n* `Ed25519ctx` - The edwards25519 curve for the HashEdDSA variant."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public PkixEddsaKeySpec.AlgorithmEnum Algorithm {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public PkixEddsaKeySpec.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public PkixEddsaKeySpec.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.PkixEddsaKeySpec initObject = new Intersight.Model.PkixEddsaKeySpec();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Algorithm"))
            {
                initObject.Algorithm = this.Algorithm;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize PkixEcdsaKeySpec.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightPkixEcdsaKeySpec")]
    public class InitializeIntersightPkixEcdsaKeySpec:PSCmdlet
	{
		public InitializeIntersightPkixEcdsaKeySpec()
		{
            ClassId = PkixEcdsaKeySpec.ClassIdEnum.PkixEcdsaKeySpec;
            Curve = PkixEcdsaKeySpec.CurveEnum.P256;
            ObjectType = PkixEcdsaKeySpec.ObjectTypeEnum.PkixEcdsaKeySpec;
            
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
        
        public PkixEcdsaKeySpec.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A specific set of Elliptic Curve parameters, as recommended by NIST in FIPS 186-4.\n* `P256` - P256 returns a Curve which implements P-256, as defined in FIPS 186-4, section D.2.3.\n* `P224` - P224 returns a Curve which implements P-224, as defined in FIPS 186-4, section D.2.2.\n* `P384` - P384 returns a Curve which implements P-384, as defined in FIPS 186-4, section D.2.4.\n* `P521` - P521 returns a Curve which implements P-521, as defined in FIPS 186-4, section D.2.5."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public PkixEcdsaKeySpec.CurveEnum Curve {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public PkixEcdsaKeySpec.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.PkixEcdsaKeySpec initObject = new Intersight.Model.PkixEcdsaKeySpec();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Curve"))
            {
                initObject.Curve = this.Curve;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize PkixKeyGenerationSpec.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightPkixKeyGenerationSpec")]
    public class InitializeIntersightPkixKeyGenerationSpec:PSCmdlet
	{
		public InitializeIntersightPkixKeyGenerationSpec()
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
        
        public PkixKeyGenerationSpec.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public PkixKeyGenerationSpec.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.PkixKeyGenerationSpec initObject = new Intersight.Model.PkixKeyGenerationSpec();
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
    /// <para type="synopsis">This is the cmdlet to Initialize PkixDistinguishedName.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightPkixDistinguishedName")]
    public class InitializeIntersightPkixDistinguishedName:PSCmdlet
	{
		public InitializeIntersightPkixDistinguishedName()
		{
            ClassId = PkixDistinguishedName.ClassIdEnum.PkixDistinguishedName;
            ObjectType = PkixDistinguishedName.ObjectTypeEnum.PkixDistinguishedName;
            
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
        
        public PkixDistinguishedName.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> Country {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> Locality {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public PkixDistinguishedName.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> Organization {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> OrganizationalUnit {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> State {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.PkixDistinguishedName initObject = new Intersight.Model.PkixDistinguishedName();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Country"))
            {
                initObject.Country = this.Country;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Locality"))
            {
                initObject.Locality = this.Locality;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Organization"))
            {
                initObject.Organization = this.Organization;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("OrganizationalUnit"))
            {
                initObject.OrganizationalUnit = this.OrganizationalUnit;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("State"))
            {
                initObject.State = this.State;
            }
            WriteObject(initObject);
        }

    }
}