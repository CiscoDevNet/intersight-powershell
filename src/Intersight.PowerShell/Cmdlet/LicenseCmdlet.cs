using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get LicenseAccountLicenseData.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightLicenseAccountLicenseData", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightLicenseAccountLicenseData : GetCmdletBase
    {
        public GetIntersightLicenseAccountLicenseData()
        {
            ApiInstance = new LicenseApi(Config);
            MethodName = "GetLicenseAccountLicenseDataListWithHttpInfo";
        }

        // <summary>
        /// <para type="description">"A reference to a iamAccount resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public IamAccountRelationship Account
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Root user's ID of the account."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string AccountId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The Account ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string AccountMoid
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Agent trusted store data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string AgentData
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Authorization expiration time."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string AuthExpireTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Intial authorization time."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string AuthInitialTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Next time for the authorization."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string AuthNextTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Account license data category name."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Category
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The time when this managed object was created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime CreateTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a licenseCustomerOp resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public LicenseCustomerOpRelationship CustomerOp
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Default license tier set by the user.\n* `Base` - Base as a License type. It is default license type.\n* `Essential` - Essential as a License type.\n* `Standard` - Standard as a License type.\n* `Advantage` - Advantage as a License type.\n* `Premier` - Premier as a License type.\n* `IWO-Essential` - IWO-Essential as a License type.\n* `IWO-Advantage` - IWO-Advantage as a License type.\n* `IWO-Premier` - IWO-Premier as a License type.\n* `IKS-Advantage` - IKS-Advantage as a License type.\n* `INC-Premier-1GFixed` - Premier 1G Fixed license tier for Intersight Nexus Cloud.\n* `INC-Premier-10GFixed` - Premier 10G Fixed license tier for Intersight Nexus Cloud.\n* `INC-Premier-100GFixed` - Premier 100G Fixed license tier for Intersight Nexus Cloud.\n* `INC-Premier-Mod4Slot` - Premier Modular 4 slot license tier for Intersight Nexus Cloud.\n* `INC-Premier-Mod8Slot` - Premier Modular 8 slot license tier for Intersight Nexus Cloud.\n* `INC-Premier-D2OpsFixed` - Premier D2Ops fixed license tier for Intersight Nexus Cloud.\n* `INC-Premier-D2OpsMod` - Premier D2Ops modular license tier for Intersight Nexus Cloud.\n* `INC-Premier-CentralizedMod8Slot` - Premier modular license tier of switch type CentralizedMod8Slot for Intersight Nexus Cloud.\n* `INC-Premier-DistributedMod8Slot` - Premier modular license tier of switch type DistributedMod8Slot for Intersight Nexus Cloud.\n* `ERP-Advantage` - Advantage license tier for ERP workflows.\n* `IntersightTrial` - Virtual dummy license type to indicate trial. Used for UI display of trial mode Intersight tiers.\n* `IWOTrial` - Virtual dummy license type to indicate trial. Used for UI display of trial mode IKS tiers.\n* `IKSTrial` - Virtual dummy license type to indicate trial. Used for UI display of trial mode IWO tiers.\n* `INCTrial` - Virtual dummy license type to indicate trial. Used for UI display of trial mode Nexus tiers."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public LicenseAccountLicenseData.DefaultLicenseTypeEnum DefaultLicenseType
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Default license tier for newer model M7+ servers set by the user.\n* `Base` - Base as a License type. It is default license type.\n* `Essential` - Essential as a License type.\n* `Standard` - Standard as a License type.\n* `Advantage` - Advantage as a License type.\n* `Premier` - Premier as a License type.\n* `IWO-Essential` - IWO-Essential as a License type.\n* `IWO-Advantage` - IWO-Advantage as a License type.\n* `IWO-Premier` - IWO-Premier as a License type.\n* `IKS-Advantage` - IKS-Advantage as a License type.\n* `INC-Premier-1GFixed` - Premier 1G Fixed license tier for Intersight Nexus Cloud.\n* `INC-Premier-10GFixed` - Premier 10G Fixed license tier for Intersight Nexus Cloud.\n* `INC-Premier-100GFixed` - Premier 100G Fixed license tier for Intersight Nexus Cloud.\n* `INC-Premier-Mod4Slot` - Premier Modular 4 slot license tier for Intersight Nexus Cloud.\n* `INC-Premier-Mod8Slot` - Premier Modular 8 slot license tier for Intersight Nexus Cloud.\n* `INC-Premier-D2OpsFixed` - Premier D2Ops fixed license tier for Intersight Nexus Cloud.\n* `INC-Premier-D2OpsMod` - Premier D2Ops modular license tier for Intersight Nexus Cloud.\n* `INC-Premier-CentralizedMod8Slot` - Premier modular license tier of switch type CentralizedMod8Slot for Intersight Nexus Cloud.\n* `INC-Premier-DistributedMod8Slot` - Premier modular license tier of switch type DistributedMod8Slot for Intersight Nexus Cloud.\n* `ERP-Advantage` - Advantage license tier for ERP workflows.\n* `IntersightTrial` - Virtual dummy license type to indicate trial. Used for UI display of trial mode Intersight tiers.\n* `IWOTrial` - Virtual dummy license type to indicate trial. Used for UI display of trial mode IKS tiers.\n* `IKSTrial` - Virtual dummy license type to indicate trial. Used for UI display of trial mode IWO tiers.\n* `INCTrial` - Virtual dummy license type to indicate trial. Used for UI display of trial mode Nexus tiers."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public LicenseAccountLicenseData.DefaultLicenseTypeNewerModelsEnum DefaultLicenseTypeNewerModels
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The DomainGroup ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string DomainGroupMoid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a licenseErpCustomerOp resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public LicenseErpCustomerOpRelationship ErpCustomerOp
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a licenseErpLicenseCount resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public LicenseErpLicenseCountRelationship ErpLicenseCount
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The detailed error message when there is any error related to license sync of this account."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string ErrorDesc
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Account license data group name."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Group
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The highest license tier which is in compliant of this account.\n* `Base` - Base as a License type. It is default license type.\n* `Essential` - Essential as a License type.\n* `Standard` - Standard as a License type.\n* `Advantage` - Advantage as a License type.\n* `Premier` - Premier as a License type.\n* `IWO-Essential` - IWO-Essential as a License type.\n* `IWO-Advantage` - IWO-Advantage as a License type.\n* `IWO-Premier` - IWO-Premier as a License type.\n* `IKS-Advantage` - IKS-Advantage as a License type.\n* `INC-Premier-1GFixed` - Premier 1G Fixed license tier for Intersight Nexus Cloud.\n* `INC-Premier-10GFixed` - Premier 10G Fixed license tier for Intersight Nexus Cloud.\n* `INC-Premier-100GFixed` - Premier 100G Fixed license tier for Intersight Nexus Cloud.\n* `INC-Premier-Mod4Slot` - Premier Modular 4 slot license tier for Intersight Nexus Cloud.\n* `INC-Premier-Mod8Slot` - Premier Modular 8 slot license tier for Intersight Nexus Cloud.\n* `INC-Premier-D2OpsFixed` - Premier D2Ops fixed license tier for Intersight Nexus Cloud.\n* `INC-Premier-D2OpsMod` - Premier D2Ops modular license tier for Intersight Nexus Cloud.\n* `INC-Premier-CentralizedMod8Slot` - Premier modular license tier of switch type CentralizedMod8Slot for Intersight Nexus Cloud.\n* `INC-Premier-DistributedMod8Slot` - Premier modular license tier of switch type DistributedMod8Slot for Intersight Nexus Cloud.\n* `ERP-Advantage` - Advantage license tier for ERP workflows.\n* `IntersightTrial` - Virtual dummy license type to indicate trial. Used for UI display of trial mode Intersight tiers.\n* `IWOTrial` - Virtual dummy license type to indicate trial. Used for UI display of trial mode IKS tiers.\n* `IKSTrial` - Virtual dummy license type to indicate trial. Used for UI display of trial mode IWO tiers.\n* `INCTrial` - Virtual dummy license type to indicate trial. Used for UI display of trial mode Nexus tiers."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public LicenseAccountLicenseData.HighestCompliantLicenseTierEnum HighestCompliantLicenseTier
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a licenseIksCustomerOp resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public LicenseIksCustomerOpRelationship IksCustomerOp
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a licenseIksLicenseCount resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public LicenseIksLicenseCountRelationship IksLicenseCount
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a licenseIncCustomerOp resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public LicenseIncCustomerOpRelationship IncCustomerOp
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a licenseIncLicenseCount resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public LicenseIncLicenseCountRelationship IncLicenseCount
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a licenseIwoCustomerOp resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public LicenseIwoCustomerOpRelationship IwoCustomerOp
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a licenseIwoLicenseCount resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public LicenseIwoLicenseCountRelationship IwoLicenseCount
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Specifies last sync time with CSSM."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime LastCssmSync
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Specifies last certificate renew time with SA."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime LastRenew
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Specifies last sync time with SA."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime LastSync
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Record's last update datetime."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime LastUpdatedTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a licenseLicenseInfoView resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public LicenseLicenseInfoViewRelationship LicenseInfoView
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a licenseLicenseRegistrationStatus resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public LicenseLicenseRegistrationStatusRelationship LicenseRegistrationStatus
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Aggregrated mode for the agent."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string LicenseState
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Tech-support info of a smart-agent."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string LicenseTechSupportInfo
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The time when this managed object was last modified."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime ModTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Moid
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public MoBaseMoRelationship Parent
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Registration exipiration time."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string RegisterExpireTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Initial time of registration."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string RegisterInitialTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Next time for the license registration."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string RegisterNextTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Registration status of a smart-agent."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string RegistrationStatus
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"License renewal failure message."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string RenewFailureString
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Intersight provides pre-built workflows, tasks and policies to end users through global catalogs.\nObjects that are made available through global catalogs are said to have a 'shared' ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SharedScope
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Name of the smart account."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SmartAccount
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Domain Name of the smart account."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SmartAccountDomain
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Indicate whether API integration is enabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool SmartApiEnabled
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The detailed error message when there is any smart API sync error related to this account."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SmartApiSyncStatus
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a licenseSmartlicenseToken resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public LicenseSmartlicenseTokenRelationship SmartlicenseToken
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Current sync status for the account."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SyncStatus
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"Name of the virtual account."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string VirtualAccount
        {
            get;
            set;
        }


    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get LicenseCustomerOp.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightLicenseCustomerOp", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightLicenseCustomerOp : GetCmdletBase
    {
        public GetIntersightLicenseCustomerOp()
        {
            ApiInstance = new LicenseApi(Config);
            MethodName = "GetLicenseCustomerOpListWithHttpInfo";
        }

        // <summary>
        /// <para type="description">"A reference to a licenseAccountLicenseData resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public LicenseAccountLicenseDataRelationship AccountLicenseData
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The Account ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string AccountMoid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The license administrative state.\nSet this property to 'true' to activate the license entitlements."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool ActiveAdmin
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Move all licensed devices to default license tier."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool AllDevicesToDefaultTier
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Clear the status of smart API sync."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool ClearApiSyncStatus
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The time when this managed object was created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime CreateTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Trigger de-registration/disable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool DeregisterDevice
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The DomainGroup ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string DomainGroupMoid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Enable trial for Intersight licensing."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool EnableTrial
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The default Trial or Grace period customer is entitled to."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long EvaluationPeriod
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The number of days the trial Trial or Grace period is extended. The trial or grace period can be extended once."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long ExtraEvaluation
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The time when this managed object was last modified."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime ModTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Moid
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public MoBaseMoRelationship Parent
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Trigger renew authorization."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool RenewAuthorization
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Trigger renew registration."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool RenewIdCertificate
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Intersight provides pre-built workflows, tasks and policies to end users through global catalogs.\nObjects that are made available through global catalogs are said to have a 'shared' ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SharedScope
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Trigger show tech support feature."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool ShowAgentTechSupport
        {
            get;
            set;
        }




    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get LicenseErpCustomerOp.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightLicenseErpCustomerOp", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightLicenseErpCustomerOp : GetCmdletBase
    {
        public GetIntersightLicenseErpCustomerOp()
        {
            ApiInstance = new LicenseApi(Config);
            MethodName = "GetLicenseErpCustomerOpListWithHttpInfo";
        }

        // <summary>
        /// <para type="description">"A reference to a licenseAccountLicenseData resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public LicenseAccountLicenseDataRelationship AccountLicenseData
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The Account ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string AccountMoid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The ERP license administrative state.\nSet this property to 'true' to activate the ERP license entitlements."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool ActiveAdmin
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"The time when this managed object was created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime CreateTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The DomainGroup ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string DomainGroupMoid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Enable trial for ERP licensing."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool EnableTrial
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The default Trial or Grace period the customer is entitled to."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long EvaluationPeriod
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The number of days the trial Trial or Grace period is extended. The trial or grace period can be extended once."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long ExtraEvaluation
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The time when this managed object was last modified."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime ModTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Moid
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public MoBaseMoRelationship Parent
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Intersight provides pre-built workflows, tasks and policies to end users through global catalogs.\nObjects that are made available through global catalogs are said to have a 'shared' ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SharedScope
        {
            get;
            set;
        }




    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get LicenseErpLicenseCount.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightLicenseErpLicenseCount", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightLicenseErpLicenseCount : GetCmdletBase
    {
        public GetIntersightLicenseErpLicenseCount()
        {
            ApiInstance = new LicenseApi(Config);
            MethodName = "GetLicenseErpLicenseCountListWithHttpInfo";
        }

        // <summary>
        /// <para type="description">"A reference to a licenseAccountLicenseData resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public LicenseAccountLicenseDataRelationship AccountLicenseData
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The Account ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string AccountMoid
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The total number of devices claimed in the Erp workflow Advantage tier."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long AdvantageCount
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The time when this managed object was created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime CreateTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The DomainGroup ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string DomainGroupMoid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The time when this managed object was last modified."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime ModTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Moid
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public MoBaseMoRelationship Parent
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Intersight provides pre-built workflows, tasks and policies to end users through global catalogs.\nObjects that are made available through global catalogs are said to have a 'shared' ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SharedScope
        {
            get;
            set;
        }




    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get LicenseIksCustomerOp.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightLicenseIksCustomerOp", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightLicenseIksCustomerOp : GetCmdletBase
    {
        public GetIntersightLicenseIksCustomerOp()
        {
            ApiInstance = new LicenseApi(Config);
            MethodName = "GetLicenseIksCustomerOpListWithHttpInfo";
        }

        // <summary>
        /// <para type="description">"A reference to a licenseAccountLicenseData resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public LicenseAccountLicenseDataRelationship AccountLicenseData
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The Account ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string AccountMoid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The Intersight Kubernetes Service license administrative state.\nSet this property to 'true' to activate the IKS license entitlements."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool ActiveAdmin
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"The time when this managed object was created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime CreateTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The DomainGroup ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string DomainGroupMoid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Enable trial for IKS licensing."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool EnableTrial
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The default Trial or Grace period the customer is entitled to."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long EvaluationPeriod
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The number of days the trial Trial or Grace period is extended. The trial or grace period can be extended once."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long ExtraEvaluation
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The time when this managed object was last modified."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime ModTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Moid
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public MoBaseMoRelationship Parent
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Intersight provides pre-built workflows, tasks and policies to end users through global catalogs.\nObjects that are made available through global catalogs are said to have a 'shared' ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SharedScope
        {
            get;
            set;
        }




    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get LicenseIksLicenseCount.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightLicenseIksLicenseCount", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightLicenseIksLicenseCount : GetCmdletBase
    {
        public GetIntersightLicenseIksLicenseCount()
        {
            ApiInstance = new LicenseApi(Config);
            MethodName = "GetLicenseIksLicenseCountListWithHttpInfo";
        }

        // <summary>
        /// <para type="description">"A reference to a licenseAccountLicenseData resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public LicenseAccountLicenseDataRelationship AccountLicenseData
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The Account ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string AccountMoid
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The total number of devices claimed in the IKS Advantage tier."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long AdvantageCount
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The time when this managed object was created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime CreateTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The DomainGroup ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string DomainGroupMoid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The time when this managed object was last modified."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime ModTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Moid
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public MoBaseMoRelationship Parent
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Intersight provides pre-built workflows, tasks and policies to end users through global catalogs.\nObjects that are made available through global catalogs are said to have a 'shared' ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SharedScope
        {
            get;
            set;
        }




    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get LicenseIncCustomerOp.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightLicenseIncCustomerOp", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightLicenseIncCustomerOp : GetCmdletBase
    {
        public GetIntersightLicenseIncCustomerOp()
        {
            ApiInstance = new LicenseApi(Config);
            MethodName = "GetLicenseIncCustomerOpListWithHttpInfo";
        }

        // <summary>
        /// <para type="description">"A reference to a licenseAccountLicenseData resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public LicenseAccountLicenseDataRelationship AccountLicenseData
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The Account ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string AccountMoid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The Nexus Cloud license administrative state.\nSet this property to 'true' to activate the Nexus Cloud license entitlements."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool ActiveAdmin
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"The time when this managed object was created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime CreateTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The DomainGroup ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string DomainGroupMoid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Enable trial for Nexus Cloud licensing."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool EnableTrial
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The default Trial or Grace period the customer is entitled to."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long EvaluationPeriod
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The number of days the trial Trial or Grace period is extended. The trial or grace period can be extended once."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long ExtraEvaluation
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The time when this managed object was last modified."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime ModTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Moid
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public MoBaseMoRelationship Parent
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Intersight provides pre-built workflows, tasks and policies to end users through global catalogs.\nObjects that are made available through global catalogs are said to have a 'shared' ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SharedScope
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Terminate trial mode for Nexus Cloud."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool TerminateTrial
        {
            get;
            set;
        }



    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get LicenseIncLicenseCount.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightLicenseIncLicenseCount", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightLicenseIncLicenseCount : GetCmdletBase
    {
        public GetIntersightLicenseIncLicenseCount()
        {
            ApiInstance = new LicenseApi(Config);
            MethodName = "GetLicenseIncLicenseCountListWithHttpInfo";
        }

        // <summary>
        /// <para type="description">"A reference to a licenseAccountLicenseData resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public LicenseAccountLicenseDataRelationship AccountLicenseData
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The Account ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string AccountMoid
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"The time when this managed object was created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime CreateTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The DomainGroup ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string DomainGroupMoid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The time when this managed object was last modified."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime ModTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Moid
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public MoBaseMoRelationship Parent
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The total number of devices claimed in the premier 100G fixed tier Intersight Nexus Cloud."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long Premier100GfxCount
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The total number of devices claimed in the premier 10G fixed tier Intersight Nexus Cloud."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long Premier10GfxCount
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The total number of devices claimed in the premier 1G fixed tier Intersight Nexus Cloud."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long Premier1GfxCount
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The total number of devices claimed in the CentralizedMod8Slot premier tier Intersight Nexus Cloud."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long PremierCentralizedMod8SlotCount
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The total number of devices claimed in the D2Ops Fixed premier tier Intersight Nexus Cloud."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long PremierD2OpsFixedCount
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The total number of devices claimed in the D2Ops modular premier tier Intersight Nexus Cloud."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long PremierD2OpsModCount
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The total number of devices claimed in the DistributedMod8Slot premier tier Intersight Nexus Cloud."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long PremierDistributedMod8SlotCount
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The total number of devices claimed in the modular 4 slot premier tier Intersight Nexus Cloud."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long PremierMod4SlotCount
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The total number of devices claimed in the modular 8 slot premier tier Intersight Nexus Cloud."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long PremierMod8SlotCount
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Intersight provides pre-built workflows, tasks and policies to end users through global catalogs.\nObjects that are made available through global catalogs are said to have a 'shared' ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SharedScope
        {
            get;
            set;
        }




    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get LicenseIwoCustomerOp.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightLicenseIwoCustomerOp", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightLicenseIwoCustomerOp : GetCmdletBase
    {
        public GetIntersightLicenseIwoCustomerOp()
        {
            ApiInstance = new LicenseApi(Config);
            MethodName = "GetLicenseIwoCustomerOpListWithHttpInfo";
        }

        // <summary>
        /// <para type="description">"A reference to a licenseAccountLicenseData resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public LicenseAccountLicenseDataRelationship AccountLicenseData
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The Account ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string AccountMoid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The workload optimizer license administrative state.\nSet this property to 'true' to activate the workload optimizer license entitlements."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool ActiveAdmin
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Active workload optimizer license tier set by user.\n* `Base` - Base as a License type. It is default license type.\n* `Essential` - Essential as a License type.\n* `Standard` - Standard as a License type.\n* `Advantage` - Advantage as a License type.\n* `Premier` - Premier as a License type.\n* `IWO-Essential` - IWO-Essential as a License type.\n* `IWO-Advantage` - IWO-Advantage as a License type.\n* `IWO-Premier` - IWO-Premier as a License type.\n* `IKS-Advantage` - IKS-Advantage as a License type.\n* `INC-Premier-1GFixed` - Premier 1G Fixed license tier for Intersight Nexus Cloud.\n* `INC-Premier-10GFixed` - Premier 10G Fixed license tier for Intersight Nexus Cloud.\n* `INC-Premier-100GFixed` - Premier 100G Fixed license tier for Intersight Nexus Cloud.\n* `INC-Premier-Mod4Slot` - Premier Modular 4 slot license tier for Intersight Nexus Cloud.\n* `INC-Premier-Mod8Slot` - Premier Modular 8 slot license tier for Intersight Nexus Cloud.\n* `INC-Premier-D2OpsFixed` - Premier D2Ops fixed license tier for Intersight Nexus Cloud.\n* `INC-Premier-D2OpsMod` - Premier D2Ops modular license tier for Intersight Nexus Cloud.\n* `INC-Premier-CentralizedMod8Slot` - Premier modular license tier of switch type CentralizedMod8Slot for Intersight Nexus Cloud.\n* `INC-Premier-DistributedMod8Slot` - Premier modular license tier of switch type DistributedMod8Slot for Intersight Nexus Cloud.\n* `ERP-Advantage` - Advantage license tier for ERP workflows.\n* `IntersightTrial` - Virtual dummy license type to indicate trial. Used for UI display of trial mode Intersight tiers.\n* `IWOTrial` - Virtual dummy license type to indicate trial. Used for UI display of trial mode IKS tiers.\n* `IKSTrial` - Virtual dummy license type to indicate trial. Used for UI display of trial mode IWO tiers.\n* `INCTrial` - Virtual dummy license type to indicate trial. Used for UI display of trial mode Nexus tiers."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public LicenseIwoCustomerOp.ActiveLicenseTypeEnum ActiveLicenseType
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"The time when this managed object was created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime CreateTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The DomainGroup ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string DomainGroupMoid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Enable trial for Intersight licensing."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool EnableTrial
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The default Trial or Grace period customer is entitled to."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long EvaluationPeriod
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The number of days the trial Trial or Grace period is extended. The trial or grace period can be extended once."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long ExtraEvaluation
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The time when this managed object was last modified."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime ModTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Moid
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public MoBaseMoRelationship Parent
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Intersight provides pre-built workflows, tasks and policies to end users through global catalogs.\nObjects that are made available through global catalogs are said to have a 'shared' ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SharedScope
        {
            get;
            set;
        }




    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get LicenseIwoLicenseCount.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightLicenseIwoLicenseCount", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightLicenseIwoLicenseCount : GetCmdletBase
    {
        public GetIntersightLicenseIwoLicenseCount()
        {
            ApiInstance = new LicenseApi(Config);
            MethodName = "GetLicenseIwoLicenseCountListWithHttpInfo";
        }

        // <summary>
        /// <para type="description">"A reference to a licenseAccountLicenseData resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public LicenseAccountLicenseDataRelationship AccountLicenseData
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The Account ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string AccountMoid
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"The time when this managed object was created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime CreateTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The DomainGroup ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string DomainGroupMoid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The time when this managed object was last modified."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime ModTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Moid
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public MoBaseMoRelationship Parent
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Intersight provides pre-built workflows, tasks and policies to end users through global catalogs.\nObjects that are made available through global catalogs are said to have a 'shared' ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SharedScope
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"The total number of devices claimed in the Intersight account."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long VmLicenseCount
        {
            get;
            set;
        }


    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get LicenseLicenseInfo.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightLicenseLicenseInfo", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightLicenseLicenseInfo : GetCmdletBase
    {
        public GetIntersightLicenseLicenseInfo()
        {
            ApiInstance = new LicenseApi(Config);
            MethodName = "GetLicenseLicenseInfoListWithHttpInfo";
        }

        // <summary>
        /// <para type="description">"A reference to a licenseAccountLicenseData resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public LicenseAccountLicenseDataRelationship AccountLicenseData
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The Account ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string AccountMoid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The license administrative state.\nSet this property to 'true' to activate the license entitlements."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool ActiveAdmin
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"The total balance we have for licenses."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long Balance
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The time when this managed object was created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime CreateTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The number of days left for licenseState to stay in TrialPeriod or OutOfCompliance state."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long DaysLeft
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The DomainGroup ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string DomainGroupMoid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The date and time when the trial period expires.\nThe value of the 'endTime' property is set when the account enters the TrialPeriod or OutOfCompliance state."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime EndTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The entitlement mode reported by Cisco Smart Software Manager."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string EnforceMode
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The detailed error message when there is any error related to this licensing entitlement."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string ErrorDesc
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The default Trial or Grace period customer is entitled to."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long EvaluationPeriod
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The date and time when the next expiration time of license subscription."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime ExpireTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The number of days the trial Trial or Grace period is extended.\nThe trial or grace period can be extended once."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long ExtraEvaluation
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The total number of license consumed in the Intersight account."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long LicenseCount
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The total number of license purchased from cisco."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long LicenseCountPurchased
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The license state defined by Intersight.\nThe value may be one of NotLicensed, TrialPeriod, OutOfCompliance, Compliance, GraceExpired, or TrialExpired.\n* `NotLicensed` - The license token is neither activated nor registered.\n* `GraceExpired` - The license grace period has expired.\n* `TrialPeriod` - The 90 days of trial period.\n* `OutOfCompliance` - The license is out of compliance.\n* `Compliance` - The license is in compliance.\n* `TrialExpired` - The trial period of 90 days has expired."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public LicenseLicenseInfo.LicenseStateEnum LicenseState
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The name of the Intersight license entitlement.\nFor example, this property may be set to 'Essential'.\n* `Base` - Base as a License type. It is default license type.\n* `Essential` - Essential as a License type.\n* `Standard` - Standard as a License type.\n* `Advantage` - Advantage as a License type.\n* `Premier` - Premier as a License type.\n* `IWO-Essential` - IWO-Essential as a License type.\n* `IWO-Advantage` - IWO-Advantage as a License type.\n* `IWO-Premier` - IWO-Premier as a License type.\n* `IKS-Advantage` - IKS-Advantage as a License type.\n* `INC-Premier-1GFixed` - Premier 1G Fixed license tier for Intersight Nexus Cloud.\n* `INC-Premier-10GFixed` - Premier 10G Fixed license tier for Intersight Nexus Cloud.\n* `INC-Premier-100GFixed` - Premier 100G Fixed license tier for Intersight Nexus Cloud.\n* `INC-Premier-Mod4Slot` - Premier Modular 4 slot license tier for Intersight Nexus Cloud.\n* `INC-Premier-Mod8Slot` - Premier Modular 8 slot license tier for Intersight Nexus Cloud.\n* `INC-Premier-D2OpsFixed` - Premier D2Ops fixed license tier for Intersight Nexus Cloud.\n* `INC-Premier-D2OpsMod` - Premier D2Ops modular license tier for Intersight Nexus Cloud.\n* `INC-Premier-CentralizedMod8Slot` - Premier modular license tier of switch type CentralizedMod8Slot for Intersight Nexus Cloud.\n* `INC-Premier-DistributedMod8Slot` - Premier modular license tier of switch type DistributedMod8Slot for Intersight Nexus Cloud.\n* `ERP-Advantage` - Advantage license tier for ERP workflows.\n* `IntersightTrial` - Virtual dummy license type to indicate trial. Used for UI display of trial mode Intersight tiers.\n* `IWOTrial` - Virtual dummy license type to indicate trial. Used for UI display of trial mode IKS tiers.\n* `IKSTrial` - Virtual dummy license type to indicate trial. Used for UI display of trial mode IWO tiers.\n* `INCTrial` - Virtual dummy license type to indicate trial. Used for UI display of trial mode Nexus tiers."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public LicenseLicenseInfo.LicenseTypeEnum LicenseType
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The time when this managed object was last modified."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime ModTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Moid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The total number of substituted licenses added or removed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long NetSubstitution
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public MoBaseMoRelationship Parent
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Intersight provides pre-built workflows, tasks and policies to end users through global catalogs.\nObjects that are made available through global catalogs are said to have a 'shared' ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SharedScope
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The date and time when the licenseState entered the TrialPeriod or OutOfCompliance state."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime StartTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The id of license subscription."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SubscriptionId
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"The administrative state of the trial license.\nWhen the LicenseState is set to 'NotLicensed', 'trialAdmin' can be set to true to start the trial period,\ni.e. licenseState is set to be TrialPeriod."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool TrialAdmin
        {
            get;
            set;
        }



    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get LicenseLicenseInfoView.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightLicenseLicenseInfoView", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightLicenseLicenseInfoView : GetCmdletBase
    {
        public GetIntersightLicenseLicenseInfoView()
        {
            ApiInstance = new LicenseApi(Config);
            MethodName = "GetLicenseLicenseInfoViewListWithHttpInfo";
        }

        // <summary>
        /// <para type="description">"A reference to a licenseAccountLicenseData resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public LicenseAccountLicenseDataRelationship AccountLicenseData
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The Account ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string AccountMoid
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"The time when this managed object was created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime CreateTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The DomainGroup ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string DomainGroupMoid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The time when this managed object was last modified."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime ModTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Moid
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public MoBaseMoRelationship Parent
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Intersight provides pre-built workflows, tasks and policies to end users through global catalogs.\nObjects that are made available through global catalogs are said to have a 'shared' ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SharedScope
        {
            get;
            set;
        }




    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get LicenseLicenseRegistrationStatus.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightLicenseLicenseRegistrationStatus", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightLicenseLicenseRegistrationStatus : GetCmdletBase
    {
        public GetIntersightLicenseLicenseRegistrationStatus()
        {
            ApiInstance = new LicenseApi(Config);
            MethodName = "GetLicenseLicenseRegistrationStatusListWithHttpInfo";
        }

        // <summary>
        /// <para type="description">"Stores information on whether account has gone through the registration wizard. True if has not."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool AccountCreationState
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a licenseAccountLicenseData resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public LicenseAccountLicenseDataRelationship AccountLicenseData
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The Account ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string AccountMoid
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"The time when this managed object was created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime CreateTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The DomainGroup ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string DomainGroupMoid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Stores information on whether account is new. This data is used for UI theme upgrade, where existing users will be shown a slightly different screen. True if new."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool IsNewAccount
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Stores information on the current flow of license registration.\n* `RegistrationNotStarted` - The license registration state to chose between trial and registration.\n* `RegistrationStarted` - The license registration state during set up flow.\n* `RegistrationComplete` - The license registration state after completion."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public LicenseLicenseRegistrationStatus.LicenseRegistrationStateEnum LicenseRegistrationState
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The time when this managed object was last modified."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime ModTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Moid
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public MoBaseMoRelationship Parent
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Intersight provides pre-built workflows, tasks and policies to end users through global catalogs.\nObjects that are made available through global catalogs are said to have a 'shared' ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SharedScope
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Stores information on whether trial flow has been completed. True if trial registration finish."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool TrialRegistrationComplete
        {
            get;
            set;
        }



    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get LicenseLicenseReservationOp.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightLicenseLicenseReservationOp", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightLicenseLicenseReservationOp : GetCmdletBase
    {
        public GetIntersightLicenseLicenseReservationOp()
        {
            ApiInstance = new LicenseApi(Config);
            MethodName = "GetLicenseLicenseReservationOpListWithHttpInfo";
        }

        // <summary>
        /// <para type="description">"A reference to a iamAccount resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public IamAccountRelationship Account
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The Account ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string AccountMoid
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"Revervation code used to install the license."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string AuthCode
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Flag to indicate whether authorization code is installed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool AuthCodeInstalled
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Confirm code used to complete the license update on smart license account."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string ConfirmCode
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The time when this managed object was created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime CreateTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The DomainGroup ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string DomainGroupMoid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Trigger the generation of request code for specific license reservation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool GenerateRequestCode
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Trigger the generation of return code for specific license reservation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool GenerateReturnCode
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The time when this managed object was last modified."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime ModTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Moid
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public MoBaseMoRelationship Parent
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Revervation code used to generate authorization code from CSSM."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string RequestCode
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Return code used to return the reserved license to smart license account."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string ReturnCode
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Intersight provides pre-built workflows, tasks and policies to end users through global catalogs.\nObjects that are made available through global catalogs are said to have a 'shared' ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SharedScope
        {
            get;
            set;
        }




    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get LicenseSmartlicenseToken.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightLicenseSmartlicenseToken", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightLicenseSmartlicenseToken : GetCmdletBase
    {
        public GetIntersightLicenseSmartlicenseToken()
        {
            ApiInstance = new LicenseApi(Config);
            MethodName = "GetLicenseSmartlicenseTokenListWithHttpInfo";
        }

        // <summary>
        /// <para type="description">"A reference to a licenseAccountLicenseData resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public LicenseAccountLicenseDataRelationship AccountLicenseData
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The Account ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string AccountMoid
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"The time when this managed object was created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime CreateTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The DomainGroup ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string DomainGroupMoid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The time when this managed object was last modified."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime ModTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Moid
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public MoBaseMoRelationship Parent
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Intersight provides pre-built workflows, tasks and policies to end users through global catalogs.\nObjects that are made available through global catalogs are said to have a 'shared' ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SharedScope
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Smart license registration token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Token
        {
            get;
            set;
        }



    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New LicenseErpLicenseCount.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightLicenseErpLicenseCount")]
    public class NewIntersightLicenseErpLicenseCount : NewCmdletBase
    {
        public NewIntersightLicenseErpLicenseCount()
        {
            ApiInstance = new LicenseApi(Config);
            ModelObject = new LicenseErpLicenseCount();
            MethodName = "CreateLicenseErpLicenseCountWithHttpInfo";
        }

        // <summary>
        /// <para type="description">"A reference to a licenseAccountLicenseData resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public LicenseAccountLicenseDataRelationship AccountLicenseData
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
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }





        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<MoTag> Tags
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New LicenseIksLicenseCount.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightLicenseIksLicenseCount")]
    public class NewIntersightLicenseIksLicenseCount : NewCmdletBase
    {
        public NewIntersightLicenseIksLicenseCount()
        {
            ApiInstance = new LicenseApi(Config);
            ModelObject = new LicenseIksLicenseCount();
            MethodName = "CreateLicenseIksLicenseCountWithHttpInfo";
        }

        // <summary>
        /// <para type="description">"A reference to a licenseAccountLicenseData resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public LicenseAccountLicenseDataRelationship AccountLicenseData
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
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }





        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<MoTag> Tags
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New LicenseIncLicenseCount.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightLicenseIncLicenseCount")]
    public class NewIntersightLicenseIncLicenseCount : NewCmdletBase
    {
        public NewIntersightLicenseIncLicenseCount()
        {
            ApiInstance = new LicenseApi(Config);
            ModelObject = new LicenseIncLicenseCount();
            MethodName = "CreateLicenseIncLicenseCountWithHttpInfo";
        }

        // <summary>
        /// <para type="description">"A reference to a licenseAccountLicenseData resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public LicenseAccountLicenseDataRelationship AccountLicenseData
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
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }














        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<MoTag> Tags
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New LicenseIwoLicenseCount.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightLicenseIwoLicenseCount")]
    public class NewIntersightLicenseIwoLicenseCount : NewCmdletBase
    {
        public NewIntersightLicenseIwoLicenseCount()
        {
            ApiInstance = new LicenseApi(Config);
            ModelObject = new LicenseIwoLicenseCount();
            MethodName = "CreateLicenseIwoLicenseCountWithHttpInfo";
        }

        // <summary>
        /// <para type="description">"A reference to a licenseAccountLicenseData resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public LicenseAccountLicenseDataRelationship AccountLicenseData
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
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }





        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<MoTag> Tags
        {
            get;
            set;
        }


    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New LicenseLicenseInfo.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightLicenseLicenseInfo")]
    public class NewIntersightLicenseLicenseInfo : NewCmdletBase
    {
        public NewIntersightLicenseLicenseInfo()
        {
            ApiInstance = new LicenseApi(Config);
            ModelObject = new LicenseLicenseInfo();
            MethodName = "CreateLicenseLicenseInfoWithHttpInfo";
        }

        // <summary>
        /// <para type="description">"A reference to a licenseAccountLicenseData resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public LicenseAccountLicenseDataRelationship AccountLicenseData
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<MoTag> Tags
        {
            get;
            set;
        }


    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New LicenseLicenseReservationOp.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightLicenseLicenseReservationOp")]
    public class NewIntersightLicenseLicenseReservationOp : NewCmdletBase
    {
        public NewIntersightLicenseLicenseReservationOp()
        {
            ApiInstance = new LicenseApi(Config);
            ModelObject = new LicenseLicenseReservationOp();
            MethodName = "CreateLicenseLicenseReservationOpWithHttpInfo";
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<MoTag> Tags
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set LicenseAccountLicenseData.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightLicenseAccountLicenseData")]
    public class SetIntersightLicenseAccountLicenseData : SetCmdletBase
    {
        public SetIntersightLicenseAccountLicenseData()
        {
            ApiInstance = new LicenseApi(Config);
            ModelObject = new LicenseAccountLicenseData();
            MethodName = "UpdateLicenseAccountLicenseDataWithHttpInfo";
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
        /// <para type="description">"A reference to a licenseCustomerOp resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public LicenseCustomerOpRelationship CustomerOp
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Default license tier set by the user.\n* `Base` - Base as a License type. It is default license type.\n* `Essential` - Essential as a License type.\n* `Standard` - Standard as a License type.\n* `Advantage` - Advantage as a License type.\n* `Premier` - Premier as a License type.\n* `IWO-Essential` - IWO-Essential as a License type.\n* `IWO-Advantage` - IWO-Advantage as a License type.\n* `IWO-Premier` - IWO-Premier as a License type.\n* `IKS-Advantage` - IKS-Advantage as a License type.\n* `INC-Premier-1GFixed` - Premier 1G Fixed license tier for Intersight Nexus Cloud.\n* `INC-Premier-10GFixed` - Premier 10G Fixed license tier for Intersight Nexus Cloud.\n* `INC-Premier-100GFixed` - Premier 100G Fixed license tier for Intersight Nexus Cloud.\n* `INC-Premier-Mod4Slot` - Premier Modular 4 slot license tier for Intersight Nexus Cloud.\n* `INC-Premier-Mod8Slot` - Premier Modular 8 slot license tier for Intersight Nexus Cloud.\n* `INC-Premier-D2OpsFixed` - Premier D2Ops fixed license tier for Intersight Nexus Cloud.\n* `INC-Premier-D2OpsMod` - Premier D2Ops modular license tier for Intersight Nexus Cloud.\n* `INC-Premier-CentralizedMod8Slot` - Premier modular license tier of switch type CentralizedMod8Slot for Intersight Nexus Cloud.\n* `INC-Premier-DistributedMod8Slot` - Premier modular license tier of switch type DistributedMod8Slot for Intersight Nexus Cloud.\n* `ERP-Advantage` - Advantage license tier for ERP workflows.\n* `IntersightTrial` - Virtual dummy license type to indicate trial. Used for UI display of trial mode Intersight tiers.\n* `IWOTrial` - Virtual dummy license type to indicate trial. Used for UI display of trial mode IKS tiers.\n* `IKSTrial` - Virtual dummy license type to indicate trial. Used for UI display of trial mode IWO tiers.\n* `INCTrial` - Virtual dummy license type to indicate trial. Used for UI display of trial mode Nexus tiers."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public LicenseAccountLicenseData.DefaultLicenseTypeEnum DefaultLicenseType
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Default license tier for newer model M7+ servers set by the user.\n* `Base` - Base as a License type. It is default license type.\n* `Essential` - Essential as a License type.\n* `Standard` - Standard as a License type.\n* `Advantage` - Advantage as a License type.\n* `Premier` - Premier as a License type.\n* `IWO-Essential` - IWO-Essential as a License type.\n* `IWO-Advantage` - IWO-Advantage as a License type.\n* `IWO-Premier` - IWO-Premier as a License type.\n* `IKS-Advantage` - IKS-Advantage as a License type.\n* `INC-Premier-1GFixed` - Premier 1G Fixed license tier for Intersight Nexus Cloud.\n* `INC-Premier-10GFixed` - Premier 10G Fixed license tier for Intersight Nexus Cloud.\n* `INC-Premier-100GFixed` - Premier 100G Fixed license tier for Intersight Nexus Cloud.\n* `INC-Premier-Mod4Slot` - Premier Modular 4 slot license tier for Intersight Nexus Cloud.\n* `INC-Premier-Mod8Slot` - Premier Modular 8 slot license tier for Intersight Nexus Cloud.\n* `INC-Premier-D2OpsFixed` - Premier D2Ops fixed license tier for Intersight Nexus Cloud.\n* `INC-Premier-D2OpsMod` - Premier D2Ops modular license tier for Intersight Nexus Cloud.\n* `INC-Premier-CentralizedMod8Slot` - Premier modular license tier of switch type CentralizedMod8Slot for Intersight Nexus Cloud.\n* `INC-Premier-DistributedMod8Slot` - Premier modular license tier of switch type DistributedMod8Slot for Intersight Nexus Cloud.\n* `ERP-Advantage` - Advantage license tier for ERP workflows.\n* `IntersightTrial` - Virtual dummy license type to indicate trial. Used for UI display of trial mode Intersight tiers.\n* `IWOTrial` - Virtual dummy license type to indicate trial. Used for UI display of trial mode IKS tiers.\n* `IKSTrial` - Virtual dummy license type to indicate trial. Used for UI display of trial mode IWO tiers.\n* `INCTrial` - Virtual dummy license type to indicate trial. Used for UI display of trial mode Nexus tiers."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public LicenseAccountLicenseData.DefaultLicenseTypeNewerModelsEnum DefaultLicenseTypeNewerModels
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a licenseErpCustomerOp resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public LicenseErpCustomerOpRelationship ErpCustomerOp
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a licenseErpLicenseCount resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public LicenseErpLicenseCountRelationship ErpLicenseCount
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"A reference to a licenseIksCustomerOp resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public LicenseIksCustomerOpRelationship IksCustomerOp
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a licenseIksLicenseCount resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public LicenseIksLicenseCountRelationship IksLicenseCount
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a licenseIncCustomerOp resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public LicenseIncCustomerOpRelationship IncCustomerOp
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a licenseIncLicenseCount resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public LicenseIncLicenseCountRelationship IncLicenseCount
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a licenseIwoCustomerOp resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public LicenseIwoCustomerOpRelationship IwoCustomerOp
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a licenseIwoLicenseCount resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public LicenseIwoLicenseCountRelationship IwoLicenseCount
        {
            get;
            set;
        }





        // <summary>
        /// <para type="description">"A reference to a licenseLicenseInfoView resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public LicenseLicenseInfoViewRelationship LicenseInfoView
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a licenseLicenseRegistrationStatus resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public LicenseLicenseRegistrationStatusRelationship LicenseRegistrationStatus
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"An array of relationships to licenseLicenseInfo resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<LicenseLicenseInfoRelationship> Licenseinfos
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }














        // <summary>
        /// <para type="description">"A reference to a licenseSmartlicenseToken resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public LicenseSmartlicenseTokenRelationship SmartlicenseToken
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<MoTag> Tags
        {
            get;
            set;
        }


    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set LicenseCustomerOp.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightLicenseCustomerOp")]
    public class SetIntersightLicenseCustomerOp : SetCmdletBase
    {
        public SetIntersightLicenseCustomerOp()
        {
            ApiInstance = new LicenseApi(Config);
            ModelObject = new LicenseCustomerOp();
            MethodName = "UpdateLicenseCustomerOpWithHttpInfo";
        }

        // <summary>
        /// <para type="description">"A reference to a licenseAccountLicenseData resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public LicenseAccountLicenseDataRelationship AccountLicenseData
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
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
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

        public List<MoTag> Tags
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set LicenseErpCustomerOp.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightLicenseErpCustomerOp")]
    public class SetIntersightLicenseErpCustomerOp : SetCmdletBase
    {
        public SetIntersightLicenseErpCustomerOp()
        {
            ApiInstance = new LicenseApi(Config);
            ModelObject = new LicenseErpCustomerOp();
            MethodName = "UpdateLicenseErpCustomerOpWithHttpInfo";
        }

        // <summary>
        /// <para type="description">"A reference to a licenseAccountLicenseData resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public LicenseAccountLicenseDataRelationship AccountLicenseData
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The ERP license administrative state.\nSet this property to 'true' to activate the ERP license entitlements."</para>
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
        /// <para type="description">"Enable trial for ERP licensing."</para>
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
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }





        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<MoTag> Tags
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set LicenseErpLicenseCount.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightLicenseErpLicenseCount")]
    public class SetIntersightLicenseErpLicenseCount : SetCmdletBase
    {
        public SetIntersightLicenseErpLicenseCount()
        {
            ApiInstance = new LicenseApi(Config);
            ModelObject = new LicenseErpLicenseCount();
            MethodName = "UpdateLicenseErpLicenseCountWithHttpInfo";
        }

        // <summary>
        /// <para type="description">"A reference to a licenseAccountLicenseData resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public LicenseAccountLicenseDataRelationship AccountLicenseData
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
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }





        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<MoTag> Tags
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set LicenseIksCustomerOp.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightLicenseIksCustomerOp")]
    public class SetIntersightLicenseIksCustomerOp : SetCmdletBase
    {
        public SetIntersightLicenseIksCustomerOp()
        {
            ApiInstance = new LicenseApi(Config);
            ModelObject = new LicenseIksCustomerOp();
            MethodName = "UpdateLicenseIksCustomerOpWithHttpInfo";
        }

        // <summary>
        /// <para type="description">"A reference to a licenseAccountLicenseData resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public LicenseAccountLicenseDataRelationship AccountLicenseData
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
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }





        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<MoTag> Tags
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set LicenseIksLicenseCount.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightLicenseIksLicenseCount")]
    public class SetIntersightLicenseIksLicenseCount : SetCmdletBase
    {
        public SetIntersightLicenseIksLicenseCount()
        {
            ApiInstance = new LicenseApi(Config);
            ModelObject = new LicenseIksLicenseCount();
            MethodName = "UpdateLicenseIksLicenseCountWithHttpInfo";
        }

        // <summary>
        /// <para type="description">"A reference to a licenseAccountLicenseData resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public LicenseAccountLicenseDataRelationship AccountLicenseData
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
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }





        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<MoTag> Tags
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set LicenseIncCustomerOp.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightLicenseIncCustomerOp")]
    public class SetIntersightLicenseIncCustomerOp : SetCmdletBase
    {
        public SetIntersightLicenseIncCustomerOp()
        {
            ApiInstance = new LicenseApi(Config);
            ModelObject = new LicenseIncCustomerOp();
            MethodName = "UpdateLicenseIncCustomerOpWithHttpInfo";
        }

        // <summary>
        /// <para type="description">"A reference to a licenseAccountLicenseData resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public LicenseAccountLicenseDataRelationship AccountLicenseData
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
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }





        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<MoTag> Tags
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

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set LicenseIncLicenseCount.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightLicenseIncLicenseCount")]
    public class SetIntersightLicenseIncLicenseCount : SetCmdletBase
    {
        public SetIntersightLicenseIncLicenseCount()
        {
            ApiInstance = new LicenseApi(Config);
            ModelObject = new LicenseIncLicenseCount();
            MethodName = "UpdateLicenseIncLicenseCountWithHttpInfo";
        }

        // <summary>
        /// <para type="description">"A reference to a licenseAccountLicenseData resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public LicenseAccountLicenseDataRelationship AccountLicenseData
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
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }














        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<MoTag> Tags
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set LicenseIwoCustomerOp.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightLicenseIwoCustomerOp")]
    public class SetIntersightLicenseIwoCustomerOp : SetCmdletBase
    {
        public SetIntersightLicenseIwoCustomerOp()
        {
            ApiInstance = new LicenseApi(Config);
            ModelObject = new LicenseIwoCustomerOp();
            MethodName = "UpdateLicenseIwoCustomerOpWithHttpInfo";
        }

        // <summary>
        /// <para type="description">"A reference to a licenseAccountLicenseData resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public LicenseAccountLicenseDataRelationship AccountLicenseData
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
        /// <para type="description">"Active workload optimizer license tier set by user.\n* `Base` - Base as a License type. It is default license type.\n* `Essential` - Essential as a License type.\n* `Standard` - Standard as a License type.\n* `Advantage` - Advantage as a License type.\n* `Premier` - Premier as a License type.\n* `IWO-Essential` - IWO-Essential as a License type.\n* `IWO-Advantage` - IWO-Advantage as a License type.\n* `IWO-Premier` - IWO-Premier as a License type.\n* `IKS-Advantage` - IKS-Advantage as a License type.\n* `INC-Premier-1GFixed` - Premier 1G Fixed license tier for Intersight Nexus Cloud.\n* `INC-Premier-10GFixed` - Premier 10G Fixed license tier for Intersight Nexus Cloud.\n* `INC-Premier-100GFixed` - Premier 100G Fixed license tier for Intersight Nexus Cloud.\n* `INC-Premier-Mod4Slot` - Premier Modular 4 slot license tier for Intersight Nexus Cloud.\n* `INC-Premier-Mod8Slot` - Premier Modular 8 slot license tier for Intersight Nexus Cloud.\n* `INC-Premier-D2OpsFixed` - Premier D2Ops fixed license tier for Intersight Nexus Cloud.\n* `INC-Premier-D2OpsMod` - Premier D2Ops modular license tier for Intersight Nexus Cloud.\n* `INC-Premier-CentralizedMod8Slot` - Premier modular license tier of switch type CentralizedMod8Slot for Intersight Nexus Cloud.\n* `INC-Premier-DistributedMod8Slot` - Premier modular license tier of switch type DistributedMod8Slot for Intersight Nexus Cloud.\n* `ERP-Advantage` - Advantage license tier for ERP workflows.\n* `IntersightTrial` - Virtual dummy license type to indicate trial. Used for UI display of trial mode Intersight tiers.\n* `IWOTrial` - Virtual dummy license type to indicate trial. Used for UI display of trial mode IKS tiers.\n* `IKSTrial` - Virtual dummy license type to indicate trial. Used for UI display of trial mode IWO tiers.\n* `INCTrial` - Virtual dummy license type to indicate trial. Used for UI display of trial mode Nexus tiers."</para>
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
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }





        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<MoTag> Tags
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set LicenseIwoLicenseCount.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightLicenseIwoLicenseCount")]
    public class SetIntersightLicenseIwoLicenseCount : SetCmdletBase
    {
        public SetIntersightLicenseIwoLicenseCount()
        {
            ApiInstance = new LicenseApi(Config);
            ModelObject = new LicenseIwoLicenseCount();
            MethodName = "UpdateLicenseIwoLicenseCountWithHttpInfo";
        }

        // <summary>
        /// <para type="description">"A reference to a licenseAccountLicenseData resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public LicenseAccountLicenseDataRelationship AccountLicenseData
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
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }





        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<MoTag> Tags
        {
            get;
            set;
        }


    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set LicenseLicenseInfo.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightLicenseLicenseInfo")]
    public class SetIntersightLicenseLicenseInfo : SetCmdletBase
    {
        public SetIntersightLicenseLicenseInfo()
        {
            ApiInstance = new LicenseApi(Config);
            ModelObject = new LicenseLicenseInfo();
            MethodName = "UpdateLicenseLicenseInfoWithHttpInfo";
        }

        // <summary>
        /// <para type="description">"A reference to a licenseAccountLicenseData resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public LicenseAccountLicenseDataRelationship AccountLicenseData
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
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }









        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<MoTag> Tags
        {
            get;
            set;
        }


    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set LicenseLicenseRegistrationStatus.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightLicenseLicenseRegistrationStatus")]
    public class SetIntersightLicenseLicenseRegistrationStatus : SetCmdletBase
    {
        public SetIntersightLicenseLicenseRegistrationStatus()
        {
            ApiInstance = new LicenseApi(Config);
            ModelObject = new LicenseLicenseRegistrationStatus();
            MethodName = "UpdateLicenseLicenseRegistrationStatusWithHttpInfo";
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

        public LicenseAccountLicenseDataRelationship AccountLicenseData
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
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }





        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<MoTag> Tags
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

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set LicenseLicenseReservationOp.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightLicenseLicenseReservationOp")]
    public class SetIntersightLicenseLicenseReservationOp : SetCmdletBase
    {
        public SetIntersightLicenseLicenseReservationOp()
        {
            ApiInstance = new LicenseApi(Config);
            ModelObject = new LicenseLicenseReservationOp();
            MethodName = "UpdateLicenseLicenseReservationOpWithHttpInfo";
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
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }







        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<MoTag> Tags
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set LicenseSmartlicenseToken.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightLicenseSmartlicenseToken")]
    public class SetIntersightLicenseSmartlicenseToken : SetCmdletBase
    {
        public SetIntersightLicenseSmartlicenseToken()
        {
            ApiInstance = new LicenseApi(Config);
            ModelObject = new LicenseSmartlicenseToken();
            MethodName = "UpdateLicenseSmartlicenseTokenWithHttpInfo";
        }

        // <summary>
        /// <para type="description">"A reference to a licenseAccountLicenseData resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public LicenseAccountLicenseDataRelationship AccountLicenseData
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
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }





        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<MoTag> Tags
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

    }
}