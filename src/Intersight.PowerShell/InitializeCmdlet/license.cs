using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize LicenseAccountLicenseData.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightLicenseAccountLicenseData")]
    public class InitializeIntersightLicenseAccountLicenseData : PSCmdlet
    {
        public InitializeIntersightLicenseAccountLicenseData()
        {
            ClassId = LicenseAccountLicenseData.ClassIdEnum.LicenseAccountLicenseData;
            DefaultLicenseType = LicenseAccountLicenseData.DefaultLicenseTypeEnum.Base;
            DefaultLicenseTypeNewerModels = LicenseAccountLicenseData.DefaultLicenseTypeNewerModelsEnum.Base;
            ObjectType = LicenseAccountLicenseData.ObjectTypeEnum.LicenseAccountLicenseData;

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

        public LicenseAccountLicenseData.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a licenseCustomerOp resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.LicenseCustomerOpRelationship CustomerOp
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Default license tier set by the user.\n* `Base` - Base as a License type. It is default license type.\n* `Essential` - Essential as a License type.\n* `Standard` - Standard as a License type.\n* `Advantage` - Advantage as a License type.\n* `Premier` - Premier as a License type.\n* `IWO-Essential` - IWO-Essential as a License type.\n* `IWO-Advantage` - IWO-Advantage as a License type.\n* `IWO-Premier` - IWO-Premier as a License type.\n* `IKS-Advantage` - IKS-Advantage as a License type.\n* `INC-Premier-1GFixed` - Premier 1G Fixed license tier for Intersight Nexus Cloud.\n* `INC-Premier-10GFixed` - Premier 10G Fixed license tier for Intersight Nexus Cloud.\n* `INC-Premier-100GFixed` - Premier 100G Fixed license tier for Intersight Nexus Cloud.\n* `INC-Premier-Mod4Slot` - Premier Modular 4 slot license tier for Intersight Nexus Cloud.\n* `INC-Premier-Mod8Slot` - Premier Modular 8 slot license tier for Intersight Nexus Cloud.\n* `INC-Premier-D2OpsFixed` - Premier D2Ops fixed license tier for Intersight Nexus Cloud.\n* `INC-Premier-D2OpsMod` - Premier D2Ops modular license tier for Intersight Nexus Cloud.\n* `INC-Premier-CentralizedMod8Slot` - Premier modular license tier of switch type CentralizedMod8Slot for Intersight Nexus Cloud.\n* `INC-Premier-DistributedMod8Slot` - Premier modular license tier of switch type DistributedMod8Slot for Intersight Nexus Cloud.\n* `IntersightTrial` - Virtual dummy license type to indicate trial. Used for UI display of trial mode Intersight tiers.\n* `IWOTrial` - Virtual dummy license type to indicate trial. Used for UI display of trial mode IKS tiers.\n* `IKSTrial` - Virtual dummy license type to indicate trial. Used for UI display of trial mode IWO tiers.\n* `INCTrial` - Virtual dummy license type to indicate trial. Used for UI display of trial mode Nexus tiers."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public LicenseAccountLicenseData.DefaultLicenseTypeEnum DefaultLicenseType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Default license tier for newer model M7+ servers set by the user.\n* `Base` - Base as a License type. It is default license type.\n* `Essential` - Essential as a License type.\n* `Standard` - Standard as a License type.\n* `Advantage` - Advantage as a License type.\n* `Premier` - Premier as a License type.\n* `IWO-Essential` - IWO-Essential as a License type.\n* `IWO-Advantage` - IWO-Advantage as a License type.\n* `IWO-Premier` - IWO-Premier as a License type.\n* `IKS-Advantage` - IKS-Advantage as a License type.\n* `INC-Premier-1GFixed` - Premier 1G Fixed license tier for Intersight Nexus Cloud.\n* `INC-Premier-10GFixed` - Premier 10G Fixed license tier for Intersight Nexus Cloud.\n* `INC-Premier-100GFixed` - Premier 100G Fixed license tier for Intersight Nexus Cloud.\n* `INC-Premier-Mod4Slot` - Premier Modular 4 slot license tier for Intersight Nexus Cloud.\n* `INC-Premier-Mod8Slot` - Premier Modular 8 slot license tier for Intersight Nexus Cloud.\n* `INC-Premier-D2OpsFixed` - Premier D2Ops fixed license tier for Intersight Nexus Cloud.\n* `INC-Premier-D2OpsMod` - Premier D2Ops modular license tier for Intersight Nexus Cloud.\n* `INC-Premier-CentralizedMod8Slot` - Premier modular license tier of switch type CentralizedMod8Slot for Intersight Nexus Cloud.\n* `INC-Premier-DistributedMod8Slot` - Premier modular license tier of switch type DistributedMod8Slot for Intersight Nexus Cloud.\n* `IntersightTrial` - Virtual dummy license type to indicate trial. Used for UI display of trial mode Intersight tiers.\n* `IWOTrial` - Virtual dummy license type to indicate trial. Used for UI display of trial mode IKS tiers.\n* `IKSTrial` - Virtual dummy license type to indicate trial. Used for UI display of trial mode IWO tiers.\n* `INCTrial` - Virtual dummy license type to indicate trial. Used for UI display of trial mode Nexus tiers."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public LicenseAccountLicenseData.DefaultLicenseTypeNewerModelsEnum DefaultLicenseTypeNewerModels
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a licenseIksCustomerOp resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.LicenseIksCustomerOpRelationship IksCustomerOp
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a licenseIksLicenseCount resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.LicenseIksLicenseCountRelationship IksLicenseCount
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a licenseIncCustomerOp resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.LicenseIncCustomerOpRelationship IncCustomerOp
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a licenseIncLicenseCount resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.LicenseIncLicenseCountRelationship IncLicenseCount
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a licenseIwoCustomerOp resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.LicenseIwoCustomerOpRelationship IwoCustomerOp
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a licenseIwoLicenseCount resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.LicenseIwoLicenseCountRelationship IwoLicenseCount
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a licenseLicenseInfoView resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.LicenseLicenseInfoViewRelationship LicenseInfoView
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a licenseLicenseRegistrationStatus resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.LicenseLicenseRegistrationStatusRelationship LicenseRegistrationStatus
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to licenseLicenseInfo resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.LicenseLicenseInfoRelationship> Licenseinfos
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

        public LicenseAccountLicenseData.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a licenseSmartlicenseToken resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.LicenseSmartlicenseTokenRelationship SmartlicenseToken
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
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.LicenseAccountLicenseData initObject = new Intersight.Model.LicenseAccountLicenseData();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("CustomerOp"))
            {
                initObject.CustomerOp = this.CustomerOp;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DefaultLicenseType"))
            {
                initObject.DefaultLicenseType = this.DefaultLicenseType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DefaultLicenseTypeNewerModels"))
            {
                initObject.DefaultLicenseTypeNewerModels = this.DefaultLicenseTypeNewerModels;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IksCustomerOp"))
            {
                initObject.IksCustomerOp = this.IksCustomerOp;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IksLicenseCount"))
            {
                initObject.IksLicenseCount = this.IksLicenseCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IncCustomerOp"))
            {
                initObject.IncCustomerOp = this.IncCustomerOp;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IncLicenseCount"))
            {
                initObject.IncLicenseCount = this.IncLicenseCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IwoCustomerOp"))
            {
                initObject.IwoCustomerOp = this.IwoCustomerOp;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IwoLicenseCount"))
            {
                initObject.IwoLicenseCount = this.IwoLicenseCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LicenseInfoView"))
            {
                initObject.LicenseInfoView = this.LicenseInfoView;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LicenseRegistrationStatus"))
            {
                initObject.LicenseRegistrationStatus = this.LicenseRegistrationStatus;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Licenseinfos"))
            {
                initObject.Licenseinfos = this.Licenseinfos;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("SmartlicenseToken"))
            {
                initObject.SmartlicenseToken = this.SmartlicenseToken;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize LicenseCustomerOp.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightLicenseCustomerOp")]
    public class InitializeIntersightLicenseCustomerOp : PSCmdlet
    {
        public InitializeIntersightLicenseCustomerOp()
        {
            ClassId = LicenseCustomerOp.ClassIdEnum.LicenseCustomerOp;
            ObjectType = LicenseCustomerOp.ObjectTypeEnum.LicenseCustomerOp;

        }
        // <summary>
        /// <para type="description">"A reference to a licenseAccountLicenseData resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.LicenseAccountLicenseDataRelationship AccountLicenseData
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The license administrative state.\nSet this property to 'true' to activate the license entitlements."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool ActiveAdmin
        {
            get;
            set;
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
        /// <para type="description">"Move all licensed devices to default license tier."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool AllDevicesToDefaultTier
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public LicenseCustomerOp.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Clear the status of smart API sync."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool ClearApiSyncStatus
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Trigger de-registration/disable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool DeregisterDevice
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Enable trial for Intersight licensing."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool EnableTrial
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The default Trial or Grace period customer is entitled to."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long EvaluationPeriod
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of days the trial Trial or Grace period is extended. The trial or grace period can be extended once."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long ExtraEvaluation
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

        public LicenseCustomerOp.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Trigger renew authorization."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool RenewAuthorization
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Trigger renew registration."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool RenewIdCertificate
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Trigger show tech support feature."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool ShowAgentTechSupport
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
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.LicenseCustomerOp initObject = new Intersight.Model.LicenseCustomerOp();
            if (this.MyInvocation.BoundParameters.ContainsKey("AccountLicenseData"))
            {
                initObject.AccountLicenseData = this.AccountLicenseData;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ActiveAdmin"))
            {
                initObject.ActiveAdmin = this.ActiveAdmin;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AllDevicesToDefaultTier"))
            {
                initObject.AllDevicesToDefaultTier = this.AllDevicesToDefaultTier;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ClearApiSyncStatus"))
            {
                initObject.ClearApiSyncStatus = this.ClearApiSyncStatus;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DeregisterDevice"))
            {
                initObject.DeregisterDevice = this.DeregisterDevice;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EnableTrial"))
            {
                initObject.EnableTrial = this.EnableTrial;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EvaluationPeriod"))
            {
                initObject.EvaluationPeriod = this.EvaluationPeriod;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ExtraEvaluation"))
            {
                initObject.ExtraEvaluation = this.ExtraEvaluation;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("RenewAuthorization"))
            {
                initObject.RenewAuthorization = this.RenewAuthorization;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RenewIdCertificate"))
            {
                initObject.RenewIdCertificate = this.RenewIdCertificate;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ShowAgentTechSupport"))
            {
                initObject.ShowAgentTechSupport = this.ShowAgentTechSupport;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize LicenseIksCustomerOp.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightLicenseIksCustomerOp")]
    public class InitializeIntersightLicenseIksCustomerOp : PSCmdlet
    {
        public InitializeIntersightLicenseIksCustomerOp()
        {
            ClassId = LicenseIksCustomerOp.ClassIdEnum.LicenseIksCustomerOp;
            ObjectType = LicenseIksCustomerOp.ObjectTypeEnum.LicenseIksCustomerOp;

        }
        // <summary>
        /// <para type="description">"A reference to a licenseAccountLicenseData resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.LicenseAccountLicenseDataRelationship AccountLicenseData
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Intersight Kubernetes Service license administrative state.\nSet this property to 'true' to activate the IKS license entitlements."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool ActiveAdmin
        {
            get;
            set;
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

        public LicenseIksCustomerOp.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Enable trial for IKS licensing."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool EnableTrial
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The default Trial or Grace period the customer is entitled to."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long EvaluationPeriod
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of days the trial Trial or Grace period is extended. The trial or grace period can be extended once."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long ExtraEvaluation
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

        public LicenseIksCustomerOp.ObjectTypeEnum ObjectType
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
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.LicenseIksCustomerOp initObject = new Intersight.Model.LicenseIksCustomerOp();
            if (this.MyInvocation.BoundParameters.ContainsKey("AccountLicenseData"))
            {
                initObject.AccountLicenseData = this.AccountLicenseData;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ActiveAdmin"))
            {
                initObject.ActiveAdmin = this.ActiveAdmin;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("EnableTrial"))
            {
                initObject.EnableTrial = this.EnableTrial;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EvaluationPeriod"))
            {
                initObject.EvaluationPeriod = this.EvaluationPeriod;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ExtraEvaluation"))
            {
                initObject.ExtraEvaluation = this.ExtraEvaluation;
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
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize LicenseIksLicenseCount.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightLicenseIksLicenseCount")]
    public class InitializeIntersightLicenseIksLicenseCount : PSCmdlet
    {
        public InitializeIntersightLicenseIksLicenseCount()
        {
            ClassId = LicenseIksLicenseCount.ClassIdEnum.LicenseIksLicenseCount;
            ObjectType = LicenseIksLicenseCount.ObjectTypeEnum.LicenseIksLicenseCount;

        }
        // <summary>
        /// <para type="description">"A reference to a licenseAccountLicenseData resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.LicenseAccountLicenseDataRelationship AccountLicenseData
        {
            get;
            set;
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

        public LicenseIksLicenseCount.ClassIdEnum ClassId
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

        public LicenseIksLicenseCount.ObjectTypeEnum ObjectType
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
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.LicenseIksLicenseCount initObject = new Intersight.Model.LicenseIksLicenseCount();
            if (this.MyInvocation.BoundParameters.ContainsKey("AccountLicenseData"))
            {
                initObject.AccountLicenseData = this.AccountLicenseData;
            }
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
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize LicenseIncCustomerOp.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightLicenseIncCustomerOp")]
    public class InitializeIntersightLicenseIncCustomerOp : PSCmdlet
    {
        public InitializeIntersightLicenseIncCustomerOp()
        {
            ClassId = LicenseIncCustomerOp.ClassIdEnum.LicenseIncCustomerOp;
            ObjectType = LicenseIncCustomerOp.ObjectTypeEnum.LicenseIncCustomerOp;

        }
        // <summary>
        /// <para type="description">"A reference to a licenseAccountLicenseData resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.LicenseAccountLicenseDataRelationship AccountLicenseData
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Nexus Cloud license administrative state.\nSet this property to 'true' to activate the Nexus Cloud license entitlements."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool ActiveAdmin
        {
            get;
            set;
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

        public LicenseIncCustomerOp.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Enable trial for Nexus Cloud licensing."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool EnableTrial
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The default Trial or Grace period the customer is entitled to."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long EvaluationPeriod
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of days the trial Trial or Grace period is extended. The trial or grace period can be extended once."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long ExtraEvaluation
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

        public LicenseIncCustomerOp.ObjectTypeEnum ObjectType
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
        /// <para type="description">"Terminate trial mode for Nexus Cloud."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool TerminateTrial
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.LicenseIncCustomerOp initObject = new Intersight.Model.LicenseIncCustomerOp();
            if (this.MyInvocation.BoundParameters.ContainsKey("AccountLicenseData"))
            {
                initObject.AccountLicenseData = this.AccountLicenseData;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ActiveAdmin"))
            {
                initObject.ActiveAdmin = this.ActiveAdmin;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("EnableTrial"))
            {
                initObject.EnableTrial = this.EnableTrial;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EvaluationPeriod"))
            {
                initObject.EvaluationPeriod = this.EvaluationPeriod;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ExtraEvaluation"))
            {
                initObject.ExtraEvaluation = this.ExtraEvaluation;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("TerminateTrial"))
            {
                initObject.TerminateTrial = this.TerminateTrial;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize LicenseIncLicenseCount.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightLicenseIncLicenseCount")]
    public class InitializeIntersightLicenseIncLicenseCount : PSCmdlet
    {
        public InitializeIntersightLicenseIncLicenseCount()
        {
            ClassId = LicenseIncLicenseCount.ClassIdEnum.LicenseIncLicenseCount;
            ObjectType = LicenseIncLicenseCount.ObjectTypeEnum.LicenseIncLicenseCount;

        }
        // <summary>
        /// <para type="description">"A reference to a licenseAccountLicenseData resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.LicenseAccountLicenseDataRelationship AccountLicenseData
        {
            get;
            set;
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

        public LicenseIncLicenseCount.ClassIdEnum ClassId
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

        public LicenseIncLicenseCount.ObjectTypeEnum ObjectType
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
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.LicenseIncLicenseCount initObject = new Intersight.Model.LicenseIncLicenseCount();
            if (this.MyInvocation.BoundParameters.ContainsKey("AccountLicenseData"))
            {
                initObject.AccountLicenseData = this.AccountLicenseData;
            }
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
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize LicenseIwoCustomerOp.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightLicenseIwoCustomerOp")]
    public class InitializeIntersightLicenseIwoCustomerOp : PSCmdlet
    {
        public InitializeIntersightLicenseIwoCustomerOp()
        {
            ActiveLicenseType = LicenseIwoCustomerOp.ActiveLicenseTypeEnum.Base;
            ClassId = LicenseIwoCustomerOp.ClassIdEnum.LicenseIwoCustomerOp;
            ObjectType = LicenseIwoCustomerOp.ObjectTypeEnum.LicenseIwoCustomerOp;

        }
        // <summary>
        /// <para type="description">"A reference to a licenseAccountLicenseData resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.LicenseAccountLicenseDataRelationship AccountLicenseData
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The workload optimizer license administrative state.\nSet this property to 'true' to activate the workload optimizer license entitlements."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool ActiveAdmin
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Active workload optimizer license tier set by user.\n* `Base` - Base as a License type. It is default license type.\n* `Essential` - Essential as a License type.\n* `Standard` - Standard as a License type.\n* `Advantage` - Advantage as a License type.\n* `Premier` - Premier as a License type.\n* `IWO-Essential` - IWO-Essential as a License type.\n* `IWO-Advantage` - IWO-Advantage as a License type.\n* `IWO-Premier` - IWO-Premier as a License type.\n* `IKS-Advantage` - IKS-Advantage as a License type.\n* `INC-Premier-1GFixed` - Premier 1G Fixed license tier for Intersight Nexus Cloud.\n* `INC-Premier-10GFixed` - Premier 10G Fixed license tier for Intersight Nexus Cloud.\n* `INC-Premier-100GFixed` - Premier 100G Fixed license tier for Intersight Nexus Cloud.\n* `INC-Premier-Mod4Slot` - Premier Modular 4 slot license tier for Intersight Nexus Cloud.\n* `INC-Premier-Mod8Slot` - Premier Modular 8 slot license tier for Intersight Nexus Cloud.\n* `INC-Premier-D2OpsFixed` - Premier D2Ops fixed license tier for Intersight Nexus Cloud.\n* `INC-Premier-D2OpsMod` - Premier D2Ops modular license tier for Intersight Nexus Cloud.\n* `INC-Premier-CentralizedMod8Slot` - Premier modular license tier of switch type CentralizedMod8Slot for Intersight Nexus Cloud.\n* `INC-Premier-DistributedMod8Slot` - Premier modular license tier of switch type DistributedMod8Slot for Intersight Nexus Cloud.\n* `IntersightTrial` - Virtual dummy license type to indicate trial. Used for UI display of trial mode Intersight tiers.\n* `IWOTrial` - Virtual dummy license type to indicate trial. Used for UI display of trial mode IKS tiers.\n* `IKSTrial` - Virtual dummy license type to indicate trial. Used for UI display of trial mode IWO tiers.\n* `INCTrial` - Virtual dummy license type to indicate trial. Used for UI display of trial mode Nexus tiers."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public LicenseIwoCustomerOp.ActiveLicenseTypeEnum ActiveLicenseType
        {
            get;
            set;
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

        public LicenseIwoCustomerOp.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Enable trial for Intersight licensing."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool EnableTrial
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The default Trial or Grace period customer is entitled to."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long EvaluationPeriod
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of days the trial Trial or Grace period is extended. The trial or grace period can be extended once."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long ExtraEvaluation
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

        public LicenseIwoCustomerOp.ObjectTypeEnum ObjectType
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
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.LicenseIwoCustomerOp initObject = new Intersight.Model.LicenseIwoCustomerOp();
            if (this.MyInvocation.BoundParameters.ContainsKey("AccountLicenseData"))
            {
                initObject.AccountLicenseData = this.AccountLicenseData;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ActiveAdmin"))
            {
                initObject.ActiveAdmin = this.ActiveAdmin;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ActiveLicenseType"))
            {
                initObject.ActiveLicenseType = this.ActiveLicenseType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("EnableTrial"))
            {
                initObject.EnableTrial = this.EnableTrial;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EvaluationPeriod"))
            {
                initObject.EvaluationPeriod = this.EvaluationPeriod;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ExtraEvaluation"))
            {
                initObject.ExtraEvaluation = this.ExtraEvaluation;
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
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize LicenseIwoLicenseCount.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightLicenseIwoLicenseCount")]
    public class InitializeIntersightLicenseIwoLicenseCount : PSCmdlet
    {
        public InitializeIntersightLicenseIwoLicenseCount()
        {
            ClassId = LicenseIwoLicenseCount.ClassIdEnum.LicenseIwoLicenseCount;
            ObjectType = LicenseIwoLicenseCount.ObjectTypeEnum.LicenseIwoLicenseCount;

        }
        // <summary>
        /// <para type="description">"A reference to a licenseAccountLicenseData resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.LicenseAccountLicenseDataRelationship AccountLicenseData
        {
            get;
            set;
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

        public LicenseIwoLicenseCount.ClassIdEnum ClassId
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

        public LicenseIwoLicenseCount.ObjectTypeEnum ObjectType
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
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.LicenseIwoLicenseCount initObject = new Intersight.Model.LicenseIwoLicenseCount();
            if (this.MyInvocation.BoundParameters.ContainsKey("AccountLicenseData"))
            {
                initObject.AccountLicenseData = this.AccountLicenseData;
            }
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
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize LicenseLicenseInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightLicenseLicenseInfo")]
    public class InitializeIntersightLicenseLicenseInfo : PSCmdlet
    {
        public InitializeIntersightLicenseLicenseInfo()
        {
            ClassId = LicenseLicenseInfo.ClassIdEnum.LicenseLicenseInfo;
            ObjectType = LicenseLicenseInfo.ObjectTypeEnum.LicenseLicenseInfo;

        }
        // <summary>
        /// <para type="description">"A reference to a licenseAccountLicenseData resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.LicenseAccountLicenseDataRelationship AccountLicenseData
        {
            get;
            set;
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

        public LicenseLicenseInfo.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The default Trial or Grace period customer is entitled to."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long EvaluationPeriod
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of days the trial Trial or Grace period is extended.\nThe trial or grace period can be extended once."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long ExtraEvaluation
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

        public LicenseLicenseInfo.ObjectTypeEnum ObjectType
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
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.LicenseLicenseInfo initObject = new Intersight.Model.LicenseLicenseInfo();
            if (this.MyInvocation.BoundParameters.ContainsKey("AccountLicenseData"))
            {
                initObject.AccountLicenseData = this.AccountLicenseData;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("EvaluationPeriod"))
            {
                initObject.EvaluationPeriod = this.EvaluationPeriod;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ExtraEvaluation"))
            {
                initObject.ExtraEvaluation = this.ExtraEvaluation;
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
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize LicenseLicenseInfoView.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightLicenseLicenseInfoView")]
    public class InitializeIntersightLicenseLicenseInfoView : PSCmdlet
    {
        public InitializeIntersightLicenseLicenseInfoView()
        {
            ClassId = LicenseLicenseInfoView.ClassIdEnum.LicenseLicenseInfoView;
            ObjectType = LicenseLicenseInfoView.ObjectTypeEnum.LicenseLicenseInfoView;

        }
        // <summary>
        /// <para type="description">"A reference to a licenseAccountLicenseData resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.LicenseAccountLicenseDataRelationship AccountLicenseData
        {
            get;
            set;
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

        public LicenseLicenseInfoView.ClassIdEnum ClassId
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

        public LicenseLicenseInfoView.ObjectTypeEnum ObjectType
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
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.LicenseLicenseInfoView initObject = new Intersight.Model.LicenseLicenseInfoView();
            if (this.MyInvocation.BoundParameters.ContainsKey("AccountLicenseData"))
            {
                initObject.AccountLicenseData = this.AccountLicenseData;
            }
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
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize LicenseLicenseRegistrationStatus.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightLicenseLicenseRegistrationStatus")]
    public class InitializeIntersightLicenseLicenseRegistrationStatus : PSCmdlet
    {
        public InitializeIntersightLicenseLicenseRegistrationStatus()
        {
            ClassId = LicenseLicenseRegistrationStatus.ClassIdEnum.LicenseLicenseRegistrationStatus;
            LicenseRegistrationState = LicenseLicenseRegistrationStatus.LicenseRegistrationStateEnum.RegistrationNotStarted;
            ObjectType = LicenseLicenseRegistrationStatus.ObjectTypeEnum.LicenseLicenseRegistrationStatus;

        }
        // <summary>
        /// <para type="description">"Stores information on whether account has gone through the registration wizard. True if has not."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool AccountCreationState
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a licenseAccountLicenseData resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.LicenseAccountLicenseDataRelationship AccountLicenseData
        {
            get;
            set;
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

        public LicenseLicenseRegistrationStatus.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Stores information on the current flow of license registration.\n* `RegistrationNotStarted` - The license registration state to chose between trial and registration.\n* `RegistrationStarted` - The license registration state during set up flow.\n* `RegistrationComplete` - The license registration state after completion."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public LicenseLicenseRegistrationStatus.LicenseRegistrationStateEnum LicenseRegistrationState
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

        public LicenseLicenseRegistrationStatus.ObjectTypeEnum ObjectType
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
        /// <para type="description">"Stores information on whether trial flow has been completed. True if trial registration finish."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool TrialRegistrationComplete
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.LicenseLicenseRegistrationStatus initObject = new Intersight.Model.LicenseLicenseRegistrationStatus();
            if (this.MyInvocation.BoundParameters.ContainsKey("AccountCreationState"))
            {
                initObject.AccountCreationState = this.AccountCreationState;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AccountLicenseData"))
            {
                initObject.AccountLicenseData = this.AccountLicenseData;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("LicenseRegistrationState"))
            {
                initObject.LicenseRegistrationState = this.LicenseRegistrationState;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("TrialRegistrationComplete"))
            {
                initObject.TrialRegistrationComplete = this.TrialRegistrationComplete;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize LicenseLicenseReservationOp.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightLicenseLicenseReservationOp")]
    public class InitializeIntersightLicenseLicenseReservationOp : PSCmdlet
    {
        public InitializeIntersightLicenseLicenseReservationOp()
        {
            ClassId = LicenseLicenseReservationOp.ClassIdEnum.LicenseLicenseReservationOp;
            ObjectType = LicenseLicenseReservationOp.ObjectTypeEnum.LicenseLicenseReservationOp;

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
        /// <para type="description">"Revervation code used to install the license."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string AuthCode
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public LicenseLicenseReservationOp.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Trigger the generation of request code for specific license reservation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool GenerateRequestCode
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Trigger the generation of return code for specific license reservation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool GenerateReturnCode
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

        public LicenseLicenseReservationOp.ObjectTypeEnum ObjectType
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
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.LicenseLicenseReservationOp initObject = new Intersight.Model.LicenseLicenseReservationOp();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AuthCode"))
            {
                initObject.AuthCode = this.AuthCode;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("GenerateRequestCode"))
            {
                initObject.GenerateRequestCode = this.GenerateRequestCode;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("GenerateReturnCode"))
            {
                initObject.GenerateReturnCode = this.GenerateReturnCode;
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
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize LicenseSmartlicenseToken.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightLicenseSmartlicenseToken")]
    public class InitializeIntersightLicenseSmartlicenseToken : PSCmdlet
    {
        public InitializeIntersightLicenseSmartlicenseToken()
        {
            ClassId = LicenseSmartlicenseToken.ClassIdEnum.LicenseSmartlicenseToken;
            ObjectType = LicenseSmartlicenseToken.ObjectTypeEnum.LicenseSmartlicenseToken;

        }
        // <summary>
        /// <para type="description">"A reference to a licenseAccountLicenseData resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.LicenseAccountLicenseDataRelationship AccountLicenseData
        {
            get;
            set;
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

        public LicenseSmartlicenseToken.ClassIdEnum ClassId
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

        public LicenseSmartlicenseToken.ObjectTypeEnum ObjectType
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
        /// <para type="description">"Smart license registration token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Token
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.LicenseSmartlicenseToken initObject = new Intersight.Model.LicenseSmartlicenseToken();
            if (this.MyInvocation.BoundParameters.ContainsKey("AccountLicenseData"))
            {
                initObject.AccountLicenseData = this.AccountLicenseData;
            }
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Token"))
            {
                initObject.Token = this.Token;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize LicenseSubstituteLicense.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightLicenseSubstituteLicense")]
    public class InitializeIntersightLicenseSubstituteLicense : PSCmdlet
    {
        public InitializeIntersightLicenseSubstituteLicense()
        {
            ClassId = LicenseSubstituteLicense.ClassIdEnum.LicenseSubstituteLicense;
            ObjectType = LicenseSubstituteLicense.ObjectTypeEnum.LicenseSubstituteLicense;

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

        public LicenseSubstituteLicense.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public LicenseSubstituteLicense.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.LicenseSubstituteLicense initObject = new Intersight.Model.LicenseSubstituteLicense();
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