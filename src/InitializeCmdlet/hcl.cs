using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HclCompatibilityStatus.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHclCompatibilityStatus")]
    public class InitializeIntersightHclCompatibilityStatus : PSCmdlet
    {
        public InitializeIntersightHclCompatibilityStatus()
        {
            ClassId = HclCompatibilityStatus.ClassIdEnum.HclCompatibilityStatus;
            ObjectType = HclCompatibilityStatus.ObjectTypeEnum.HclCompatibilityStatus;
            RequestType = HclCompatibilityStatus.RequestTypeEnum.FillSupportedVersions;

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

        public HclCompatibilityStatus.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HclCompatibilityStatus.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.HclHardwareCompatibilityProfile> ProfileList
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of the request to be served.\n* `FillSupportedVersions` - Responds with the supported firmware and driver versions. The API doesn't expect firmware and driver versions to be passed in the request and ignores if passed.\n* `CheckCompatibility` - Checks the compatibility for the given firmware and driver versions. This request type expects the firmware and driver versions to filled and the service validates the values and responds back with the error codes.\n* `GetRecommendedDrivers` - Responds with the supported drivers. The API expects firmware version to be filled. The API populates driver ISO url for the given server model. Today the link is same for all servers managed by UCSM whereas it depends on the model for Standalone servers."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HclCompatibilityStatus.RequestTypeEnum RequestType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HclCompatibilityStatus initObject = new Intersight.Model.HclCompatibilityStatus();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("ProfileList"))
            {
                initObject.ProfileList = this.ProfileList;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RequestType"))
            {
                initObject.RequestType = this.RequestType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HclConstraint.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHclConstraint")]
    public class InitializeIntersightHclConstraint : PSCmdlet
    {
        public InitializeIntersightHclConstraint()
        {
            ClassId = HclConstraint.ClassIdEnum.HclConstraint;
            ObjectType = HclConstraint.ObjectTypeEnum.HclConstraint;

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

        public HclConstraint.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name or key of the applicable compatibility constraint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ConstraintName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Value of the applicable compatibility constraint. Could either be a string value or a regex."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ConstraintValue
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HclConstraint.ObjectTypeEnum ObjectType
        {
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
    /// <para type="synopsis">This is the cmdlet to Initialize HclDriverImage.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHclDriverImage")]
    public class InitializeIntersightHclDriverImage : PSCmdlet
    {
        public InitializeIntersightHclDriverImage()
        {
            ClassId = HclDriverImage.ClassIdEnum.HclDriverImage;
            ManagementType = HclDriverImage.ManagementTypeEnum.UCSM;
            ObjectType = HclDriverImage.ObjectTypeEnum.HclDriverImage;

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

        public HclDriverImage.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"URL of the driver ISO images."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string DriverIsoUrl
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of the UCS version indicating whether it is a UCSM release vesion or a IMC release.\n* `UCSM` - The server is managed by UCS Manager.\n* `IMC` - The server is standalone managed by CIMC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HclDriverImage.ManagementTypeEnum ManagementType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HclDriverImage.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Three part ID representing the server model as returned by UCSM/CIMC XML APIs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ServerPid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HclDriverImage initObject = new Intersight.Model.HclDriverImage();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("DriverIsoUrl"))
            {
                initObject.DriverIsoUrl = this.DriverIsoUrl;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ManagementType"))
            {
                initObject.ManagementType = this.ManagementType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("ServerPid"))
            {
                initObject.ServerPid = this.ServerPid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HclExemptedCatalog.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHclExemptedCatalog")]
    public class InitializeIntersightHclExemptedCatalog : PSCmdlet
    {
        public InitializeIntersightHclExemptedCatalog()
        {
            ClassId = HclExemptedCatalog.ClassIdEnum.HclExemptedCatalog;
            ObjectType = HclExemptedCatalog.ObjectTypeEnum.HclExemptedCatalog;

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

        public HclExemptedCatalog.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Reason for the exemption."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Comments
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A unique descriptive name of the exemption."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HclExemptedCatalog.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Vendor of the Operating System."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string OsVendor
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version of the Operating system."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string OsVersion
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the processor supported for the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ProcessorName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> ProductModels
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of the product/adapter say GPU for graphic cards.\n* `` - Default type of the Product.\n* `Adapter` - Represents network adapter cards.\n* `StorageController` - Represents storage controllers.\n* `GPU` - Represents graphics cards."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HclExemptedCatalog.ProductTypeEnum ProductType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Three part ID representing the server model as returned by UCSM/CIMC XML APIs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ServerPid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version of the UCS software."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string UcsVersion
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of the UCS version indicating whether it is a UCSM release vesion or a IMC release."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string VersionType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HclExemptedCatalog initObject = new Intersight.Model.HclExemptedCatalog();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Comments"))
            {
                initObject.Comments = this.Comments;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("ProcessorName"))
            {
                initObject.ProcessorName = this.ProcessorName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ProductModels"))
            {
                initObject.ProductModels = this.ProductModels;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ProductType"))
            {
                initObject.ProductType = this.ProductType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ServerPid"))
            {
                initObject.ServerPid = this.ServerPid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
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
    /// <para type="synopsis">This is the cmdlet to Initialize HclFirmware.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHclFirmware")]
    public class InitializeIntersightHclFirmware : PSCmdlet
    {
        public InitializeIntersightHclFirmware()
        {
            ClassId = HclFirmware.ClassIdEnum.HclFirmware;
            ObjectType = HclFirmware.ObjectTypeEnum.HclFirmware;

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

        public HclFirmware.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Protocol for which the driver is provided. E.g.  enic, fnic, lsi_mr3."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string DriverName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version of the Driver supported."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string DriverVersion
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Firmware version of the product/adapter supported."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string FirmwareVersion
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Identifier of the firmware."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Id
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HclFirmware.ObjectTypeEnum ObjectType
        {
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
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HclHardwareCompatibilityProfile.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHclHardwareCompatibilityProfile")]
    public class InitializeIntersightHclHardwareCompatibilityProfile : PSCmdlet
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

        public HclHardwareCompatibilityProfile.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Url for the ISO with the drivers supported for the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string DriverIsoUrl
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Identifier of the hardware compatibility profile."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Id
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HclHardwareCompatibilityProfile.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Vendor of the Operating System running on the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string OsVendor
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version of the Operating System running on the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string OsVersion
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Personality indicating the personality with the which the sever is used in a Hyperflex environment."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Personality
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Model of the processor present in the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ProcessorModel
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.HclProduct> Products
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Model of the server as returned by UCSM/CIMC XML API."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ServerModel
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Revision of the server model."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ServerRevision
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version of the UCS software."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string UcsVersion
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of the UCS version indicating whether it is a UCSM release vesion or a IMC release.\n* `UCSM` - The server is managed by UCS Manager.\n* `IMC` - The server is standalone managed by CIMC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HclHardwareCompatibilityProfile.VersionTypeEnum VersionType
        {
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Personality"))
            {
                initObject.Personality = this.Personality;
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
    /// <para type="synopsis">This is the cmdlet to Initialize HclHwCatalogInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHclHwCatalogInfo")]
    public class InitializeIntersightHclHwCatalogInfo : PSCmdlet
    {
        public InitializeIntersightHclHwCatalogInfo()
        {
            ClassId = HclHwCatalogInfo.ClassIdEnum.HclHwCatalogInfo;
            ObjectType = HclHwCatalogInfo.ObjectTypeEnum.HclHwCatalogInfo;

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

        public HclHwCatalogInfo.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HclHwCatalogInfo.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to hclServerHwCatalogInfo resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.HclServerHwCatalogInfoRelationship> ServerHwCatalogInfo
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Server model information for HyperFlex servers."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ServerModel
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Server type of the server hardware. For example, server type AF is for an all-flash server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ServerType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HclHwCatalogInfo initObject = new Intersight.Model.HclHwCatalogInfo();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("ServerHwCatalogInfo"))
            {
                initObject.ServerHwCatalogInfo = this.ServerHwCatalogInfo;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ServerModel"))
            {
                initObject.ServerModel = this.ServerModel;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ServerType"))
            {
                initObject.ServerType = this.ServerType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HclHyperflexSoftwareCompatibilityInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHclHyperflexSoftwareCompatibilityInfo")]
    public class InitializeIntersightHclHyperflexSoftwareCompatibilityInfo : PSCmdlet
    {
        public InitializeIntersightHclHyperflexSoftwareCompatibilityInfo()
        {
            ClassId = HclHyperflexSoftwareCompatibilityInfo.ClassIdEnum.HclHyperflexSoftwareCompatibilityInfo;
            HypervisorType = HclHyperflexSoftwareCompatibilityInfo.HypervisorTypeEnum.ESXi;
            ObjectType = HclHyperflexSoftwareCompatibilityInfo.ObjectTypeEnum.HclHyperflexSoftwareCompatibilityInfo;

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
        /// <para type="description">"A reference to a hyperflexAppCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.HyperflexAppCatalogRelationship AppCatalog
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HclHyperflexSoftwareCompatibilityInfo.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.HclConstraint> Constraints
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"HXDP component software version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string HxdpVersion
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type fo Hypervisor the HyperFlex components versions are compatible with. For example ESX, Hyperv or KVM.\n* `ESXi` - The hypervisor running on the HyperFlex cluster is a Vmware ESXi hypervisor of any version.\n* `Hyper-V` - The hypervisor running on the HyperFlex cluster is Microsoft Hyper-V.\n* `Unknown` - The hypervisor running on the HyperFlex cluster is not known."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HclHyperflexSoftwareCompatibilityInfo.HypervisorTypeEnum HypervisorType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Hypervisor component software version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string HypervisorVersion
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of the HXDP bundle mgmt or full."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string IsMgmtBuild
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Maximum supported HyperFlex Data Platform build version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string MaxMgmtVersion
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Minimum supported HyperFlex Data Platform build version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string MinMgmtVersion
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HclHyperflexSoftwareCompatibilityInfo.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"UCS Server Firmware component software version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ServerFwVersion
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HclHyperflexSoftwareCompatibilityInfo initObject = new Intersight.Model.HclHyperflexSoftwareCompatibilityInfo();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AppCatalog"))
            {
                initObject.AppCatalog = this.AppCatalog;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Constraints"))
            {
                initObject.Constraints = this.Constraints;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HxdpVersion"))
            {
                initObject.HxdpVersion = this.HxdpVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HypervisorType"))
            {
                initObject.HypervisorType = this.HypervisorType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HypervisorVersion"))
            {
                initObject.HypervisorVersion = this.HypervisorVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IsMgmtBuild"))
            {
                initObject.IsMgmtBuild = this.IsMgmtBuild;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaxMgmtVersion"))
            {
                initObject.MaxMgmtVersion = this.MaxMgmtVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MinMgmtVersion"))
            {
                initObject.MinMgmtVersion = this.MinMgmtVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("ServerFwVersion"))
            {
                initObject.ServerFwVersion = this.ServerFwVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HclOperatingSystem.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHclOperatingSystem")]
    public class InitializeIntersightHclOperatingSystem : PSCmdlet
    {
        public InitializeIntersightHclOperatingSystem()
        {
            ClassId = HclOperatingSystem.ClassIdEnum.HclOperatingSystem;
            ObjectType = HclOperatingSystem.ObjectTypeEnum.HclOperatingSystem;

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

        public HclOperatingSystem.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HclOperatingSystem.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a hclOperatingSystemVendor resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.HclOperatingSystemVendorRelationship Vendor
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version of the Operating System."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Version
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HclOperatingSystem initObject = new Intersight.Model.HclOperatingSystem();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Vendor"))
            {
                initObject.Vendor = this.Vendor;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Version"))
            {
                initObject.VarVersion = this.Version;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HclOperatingSystemVendor.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHclOperatingSystemVendor")]
    public class InitializeIntersightHclOperatingSystemVendor : PSCmdlet
    {
        public InitializeIntersightHclOperatingSystemVendor()
        {
            ClassId = HclOperatingSystemVendor.ClassIdEnum.HclOperatingSystemVendor;
            ObjectType = HclOperatingSystemVendor.ObjectTypeEnum.HclOperatingSystemVendor;

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

        public HclOperatingSystemVendor.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the vendor of the operating system."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HclOperatingSystemVendor.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HclOperatingSystemVendor initObject = new Intersight.Model.HclOperatingSystemVendor();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HclProduct.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHclProduct")]
    public class InitializeIntersightHclProduct : PSCmdlet
    {
        public InitializeIntersightHclProduct()
        {
            ClassId = HclProduct.ClassIdEnum.HclProduct;
            ObjectType = HclProduct.ObjectTypeEnum.HclProduct;

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

        public HclProduct.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> DriverNames
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.HclFirmware> Firmwares
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Identifier of the product."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Id
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Model/PID of the product/adapter."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Model
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HclProduct.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Revision of the adapter model."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Revision
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of the product/adapter say OCP, PT, GPU.\n* `` - Default type of the Product.\n* `Adapter` - Represents network adapter cards.\n* `StorageController` - Represents storage controllers.\n* `GPU` - Represents graphics cards."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HclProduct.TypeEnum Type
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Vendor of the product or adapter."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Vendor
        {
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
    /// <para type="synopsis">This is the cmdlet to Initialize HclServerHwCatalogInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHclServerHwCatalogInfo")]
    public class InitializeIntersightHclServerHwCatalogInfo : PSCmdlet
    {
        public InitializeIntersightHclServerHwCatalogInfo()
        {
            ClassId = HclServerHwCatalogInfo.ClassIdEnum.HclServerHwCatalogInfo;
            ObjectType = HclServerHwCatalogInfo.ObjectTypeEnum.HclServerHwCatalogInfo;

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

        public HclServerHwCatalogInfo.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.HclConstraint> Constraints
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Display model of the server hardware. In many cases, the model string used in the catalog will be the hardware Cisco PID and the Intersight model string is a more user-friendly string with vendor information in it. This will be the user-friendly modal string to be used in Intersight."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string DisplayModel
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Identifier of specific tag."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ExtId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Model of the server hardware from the catalog file."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Model
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HclServerHwCatalogInfo.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of specific tag, required to choose the correct datatype while reading the value."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Type
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Value of specific tag, having type as json."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object Value
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HclServerHwCatalogInfo initObject = new Intersight.Model.HclServerHwCatalogInfo();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Constraints"))
            {
                initObject.Constraints = this.Constraints;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DisplayModel"))
            {
                initObject.DisplayModel = this.DisplayModel;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ExtId"))
            {
                initObject.ExtId = this.ExtId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Model"))
            {
                initObject.Model = this.Model;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Type"))
            {
                initObject.Type = this.Type;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Value"))
            {
                initObject.Value = this.Value;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HclSupportedDriverName.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHclSupportedDriverName")]
    public class InitializeIntersightHclSupportedDriverName : PSCmdlet
    {
        public InitializeIntersightHclSupportedDriverName()
        {
            ClassId = HclSupportedDriverName.ClassIdEnum.HclSupportedDriverName;
            ObjectType = HclSupportedDriverName.ObjectTypeEnum.HclSupportedDriverName;

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

        public HclSupportedDriverName.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HclSupportedDriverName.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Vendor distributing the Operating System."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string OsVendor
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version of the Operating System."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string OsVersion
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.HclProduct> ProductList
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.HclSupportedDriverName initObject = new Intersight.Model.HclSupportedDriverName();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("ProductList"))
            {
                initObject.ProductList = this.ProductList;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
}