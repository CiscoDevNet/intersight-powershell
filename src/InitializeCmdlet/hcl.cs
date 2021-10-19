using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HclHardwareCompatibilityProfile.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHclHardwareCompatibilityProfile")]
    public class InitializeIntersightHclHardwareCompatibilityProfile:PSCmdlet
	{
		public InitializeIntersightHclHardwareCompatibilityProfile()
		{
            ClassId = HclHardwareCompatibilityProfile.ClassIdEnum.HclHardwareCompatibilityProfile;
            ObjectType = HclHardwareCompatibilityProfile.ObjectTypeEnum.HclHardwareCompatibilityProfile;
            VersionType = HclHardwareCompatibilityProfile.VersionTypeEnum.UCSM;
            
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
        
        public HclHardwareCompatibilityProfile.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Url for the ISO with the drivers supported for the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string DriverIsoUrl {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Identifier of the hardware compatibility profile."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Id {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HclHardwareCompatibilityProfile.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Vendor of the Operating System running on the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string OsVendor {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version of the Operating System running on the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string OsVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Model of the processor present in the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ProcessorModel {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Model.HclProduct> Products {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Model of the server as returned by UCSM/CIMC XML API."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ServerModel {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Revision of the server model."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ServerRevision {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version of the UCS software."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string UcsVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of the UCS version indicating whether it is a UCSM release vesion or a IMC release.\n* `UCSM` - The server is managed by UCS Manager.\n* `IMC` - The server is standalone managed by CIMC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HclHardwareCompatibilityProfile.VersionTypeEnum VersionType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.HclHardwareCompatibilityProfile initObject = new Intersight.Model.HclHardwareCompatibilityProfile();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("DriverIsoUrl"))
            {
                initObject.DriverIsoUrl = this.DriverIsoUrl;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Id"))
            {
                initObject.Id = this.Id;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("OsVendor"))
            {
                initObject.OsVendor = this.OsVendor;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("OsVersion"))
            {
                initObject.OsVersion = this.OsVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ProcessorModel"))
            {
                initObject.ProcessorModel = this.ProcessorModel;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Products"))
            {
                initObject.Products = this.Products;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ServerModel"))
            {
                initObject.ServerModel = this.ServerModel;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ServerRevision"))
            {
                initObject.ServerRevision = this.ServerRevision;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UcsVersion"))
            {
                initObject.UcsVersion = this.UcsVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VersionType"))
            {
                initObject.VersionType = this.VersionType;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HclProduct.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHclProduct")]
    public class InitializeIntersightHclProduct:PSCmdlet
	{
		public InitializeIntersightHclProduct()
		{
            ClassId = HclProduct.ClassIdEnum.HclProduct;
            ObjectType = HclProduct.ObjectTypeEnum.HclProduct;
            
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
        
        public HclProduct.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> DriverNames {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Model.HclFirmware> Firmwares {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Identifier of the product."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Id {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Model/PID of the product/adapter."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Model {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HclProduct.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Revision of the adapter model."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Revision {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of the product/adapter say OCP, PT, GPU.\n* `` - Default type of the Product.\n* `Adapter` - Represents network adapter cards.\n* `StorageController` - Represents storage controllers.\n* `GPU` - Represents graphics cards."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HclProduct.TypeEnum Type {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Vendor of the product or adapter."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Vendor {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.HclProduct initObject = new Intersight.Model.HclProduct();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("DriverNames"))
            {
                initObject.DriverNames = this.DriverNames;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Firmwares"))
            {
                initObject.Firmwares = this.Firmwares;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Id"))
            {
                initObject.Id = this.Id;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Model"))
            {
                initObject.Model = this.Model;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Revision"))
            {
                initObject.Revision = this.Revision;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Type"))
            {
                initObject.Type = this.Type;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Vendor"))
            {
                initObject.Vendor = this.Vendor;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HclConstraint.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHclConstraint")]
    public class InitializeIntersightHclConstraint:PSCmdlet
	{
		public InitializeIntersightHclConstraint()
		{
            ClassId = HclConstraint.ClassIdEnum.HclConstraint;
            ObjectType = HclConstraint.ObjectTypeEnum.HclConstraint;
            
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
        
        public HclConstraint.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name or key of the applicable compatibility constraint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ConstraintName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Value of the applicable compatibility constraint. Could either be a string value or a regex."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ConstraintValue {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HclConstraint.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.HclConstraint initObject = new Intersight.Model.HclConstraint();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ConstraintName"))
            {
                initObject.ConstraintName = this.ConstraintName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ConstraintValue"))
            {
                initObject.ConstraintValue = this.ConstraintValue;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HclFirmware.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHclFirmware")]
    public class InitializeIntersightHclFirmware:PSCmdlet
	{
		public InitializeIntersightHclFirmware()
		{
            ClassId = HclFirmware.ClassIdEnum.HclFirmware;
            ObjectType = HclFirmware.ObjectTypeEnum.HclFirmware;
            
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
        
        public HclFirmware.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Protocol for which the driver is provided. E.g.  enic, fnic, lsi_mr3."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string DriverName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version of the Driver supported."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string DriverVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Firmware version of the product/adapter supported."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string FirmwareVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Identifier of the firmware."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Id {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HclFirmware.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.HclFirmware initObject = new Intersight.Model.HclFirmware();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("DriverName"))
            {
                initObject.DriverName = this.DriverName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DriverVersion"))
            {
                initObject.DriverVersion = this.DriverVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FirmwareVersion"))
            {
                initObject.FirmwareVersion = this.FirmwareVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Id"))
            {
                initObject.Id = this.Id;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
}