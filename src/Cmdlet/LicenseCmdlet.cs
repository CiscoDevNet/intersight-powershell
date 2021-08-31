using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set LicenseLicenseInfo.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightLicenseLicenseInfo")]
    public class SetIntersightLicenseLicenseInfo:SetCmdletBase
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public LicenseAccountLicenseDataRelationship AccountLicenseData {
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
        /// <para type="description">"The default Trial or Grace period customer is entitled to."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long EvaluationPeriod {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of days the trial Trial or Grace period is extended.\nThe trial or grace period can be extended once."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long ExtraEvaluation {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get LicenseAccountLicenseData.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightLicenseAccountLicenseData", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightLicenseAccountLicenseData:GetCmdletBase
	{
		public GetIntersightLicenseAccountLicenseData()
		{
			ApiInstance = new LicenseApi(Config);
            MethodName = "GetLicenseAccountLicenseDataListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get LicenseIwoLicenseCount.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightLicenseIwoLicenseCount", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightLicenseIwoLicenseCount:GetCmdletBase
	{
		public GetIntersightLicenseIwoLicenseCount()
		{
			ApiInstance = new LicenseApi(Config);
            MethodName = "GetLicenseIwoLicenseCountListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New LicenseIwoLicenseCount.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightLicenseIwoLicenseCount")]
    public class NewIntersightLicenseIwoLicenseCount:NewCmdletBase
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public LicenseAccountLicenseDataRelationship AccountLicenseData {
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
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get LicenseLicenseReservationOp.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightLicenseLicenseReservationOp", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightLicenseLicenseReservationOp:GetCmdletBase
	{
		public GetIntersightLicenseLicenseReservationOp()
		{
			ApiInstance = new LicenseApi(Config);
            MethodName = "GetLicenseLicenseReservationOpListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New LicenseLicenseReservationOp.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightLicenseLicenseReservationOp")]
    public class NewIntersightLicenseLicenseReservationOp:NewCmdletBase
	{
		public NewIntersightLicenseLicenseReservationOp()
		{
			ApiInstance = new LicenseApi(Config);
            ModelObject = new LicenseLicenseReservationOp();
            MethodName = "CreateLicenseLicenseReservationOpWithHttpInfo";
		}
        // <summary>
        /// <para type="description">"A reference to a iamAccount resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamAccountRelationship Account {
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
        /// <para type="description">"Revervation code used to install the license."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string AuthCode {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Trigger the generation of request code for specific license reservation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool GenerateRequestCode {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Trigger the generation of return code for specific license reservation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool GenerateReturnCode {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get LicenseSmartlicenseToken.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightLicenseSmartlicenseToken", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightLicenseSmartlicenseToken:GetCmdletBase
	{
		public GetIntersightLicenseSmartlicenseToken()
		{
			ApiInstance = new LicenseApi(Config);
            MethodName = "GetLicenseSmartlicenseTokenListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get LicenseCustomerOp.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightLicenseCustomerOp", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightLicenseCustomerOp:GetCmdletBase
	{
		public GetIntersightLicenseCustomerOp()
		{
			ApiInstance = new LicenseApi(Config);
            MethodName = "GetLicenseCustomerOpListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set LicenseCustomerOp.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightLicenseCustomerOp")]
    public class SetIntersightLicenseCustomerOp:SetCmdletBase
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public LicenseAccountLicenseDataRelationship AccountLicenseData {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The license administrative state.\nSet this property to 'true' to activate the license entitlements."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool ActiveAdmin {
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
        /// <para type="description">"Move all licensed devices to default license tier."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool AllDevicesToDefaultTier {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Trigger de-registration/disable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool DeregisterDevice {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Enable trial for Intersight licensing."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool EnableTrial {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The default Trial or Grace period customer is entitled to."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long EvaluationPeriod {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of days the trial Trial or Grace period is extended. The trial or grace period can be extended once."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long ExtraEvaluation {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Trigger renew authorization."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool RenewAuthorization {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Trigger renew registration."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool RenewIdCertificate {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Trigger show tech support feature."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool ShowAgentTechSupport {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set LicenseLicenseReservationOp.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightLicenseLicenseReservationOp")]
    public class SetIntersightLicenseLicenseReservationOp:SetCmdletBase
	{
		public SetIntersightLicenseLicenseReservationOp()
		{
			ApiInstance = new LicenseApi(Config);
            ModelObject = new LicenseLicenseReservationOp();
            MethodName = "UpdateLicenseLicenseReservationOpWithHttpInfo";
		}
        // <summary>
        /// <para type="description">"A reference to a iamAccount resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamAccountRelationship Account {
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
        /// <para type="description">"Revervation code used to install the license."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string AuthCode {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Trigger the generation of request code for specific license reservation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool GenerateRequestCode {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Trigger the generation of return code for specific license reservation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool GenerateReturnCode {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set LicenseIwoLicenseCount.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightLicenseIwoLicenseCount")]
    public class SetIntersightLicenseIwoLicenseCount:SetCmdletBase
	{
		public SetIntersightLicenseIwoLicenseCount()
		{
			ApiInstance = new LicenseApi(Config);
            ModelObject = new LicenseIwoLicenseCount();
            MethodName = "PatchLicenseIwoLicenseCountWithHttpInfo";
		}
        // <summary>
        /// <para type="description">"A reference to a licenseAccountLicenseData resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public LicenseAccountLicenseDataRelationship AccountLicenseData {
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
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get LicenseLicenseInfo.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightLicenseLicenseInfo", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightLicenseLicenseInfo:GetCmdletBase
	{
		public GetIntersightLicenseLicenseInfo()
		{
			ApiInstance = new LicenseApi(Config);
            MethodName = "GetLicenseLicenseInfoListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New LicenseLicenseInfo.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightLicenseLicenseInfo")]
    public class NewIntersightLicenseLicenseInfo:NewCmdletBase
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public LicenseAccountLicenseDataRelationship AccountLicenseData {
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
        /// <para type="description">"The default Trial or Grace period customer is entitled to."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long EvaluationPeriod {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of days the trial Trial or Grace period is extended.\nThe trial or grace period can be extended once."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long ExtraEvaluation {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get LicenseIwoCustomerOp.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightLicenseIwoCustomerOp", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightLicenseIwoCustomerOp:GetCmdletBase
	{
		public GetIntersightLicenseIwoCustomerOp()
		{
			ApiInstance = new LicenseApi(Config);
            MethodName = "GetLicenseIwoCustomerOpListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set LicenseAccountLicenseData.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightLicenseAccountLicenseData")]
    public class SetIntersightLicenseAccountLicenseData:SetCmdletBase
	{
		public SetIntersightLicenseAccountLicenseData()
		{
			ApiInstance = new LicenseApi(Config);
            ModelObject = new LicenseAccountLicenseData();
            MethodName = "UpdateLicenseAccountLicenseDataWithHttpInfo";
		}
        // <summary>
        /// <para type="description">"A reference to a iamAccount resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamAccountRelationship Account {
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
        /// <para type="description">"A reference to a licenseCustomerOp resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public LicenseCustomerOpRelationship CustomerOp {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Default license tier set by user.\n* `Base` - Base as a License type. It is default license type.\n* `Essential` - Essential as a License type.\n* `Standard` - Standard as a License type.\n* `Advantage` - Advantage as a License type.\n* `Premier` - Premier as a License type.\n* `IWO-Essential` - IWO-Essential as a License type.\n* `IWO-Advantage` - IWO-Advantage as a License type.\n* `IWO-Premier` - IWO-Premier as a License type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public LicenseAccountLicenseData.DefaultLicenseTypeEnum DefaultLicenseType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a licenseIwoCustomerOp resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public LicenseIwoCustomerOpRelationship IwoCustomerOp {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a licenseIwoLicenseCount resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public LicenseIwoLicenseCountRelationship IwoLicenseCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to licenseLicenseInfo resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<LicenseLicenseInfoRelationship> Licenseinfos {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a licenseSmartlicenseToken resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public LicenseSmartlicenseTokenRelationship SmartlicenseToken {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set LicenseSmartlicenseToken.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightLicenseSmartlicenseToken")]
    public class SetIntersightLicenseSmartlicenseToken:SetCmdletBase
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public LicenseAccountLicenseDataRelationship AccountLicenseData {
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
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Smart license registration token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Token {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set LicenseIwoCustomerOp.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightLicenseIwoCustomerOp")]
    public class SetIntersightLicenseIwoCustomerOp:SetCmdletBase
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public LicenseAccountLicenseDataRelationship AccountLicenseData {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The workload optimizer license administrative state.\nSet this property to 'true' to activate the workload optimizer license entitlements."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool ActiveAdmin {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Active workload optimizer license tier set by user.\n* `Base` - Base as a License type. It is default license type.\n* `Essential` - Essential as a License type.\n* `Standard` - Standard as a License type.\n* `Advantage` - Advantage as a License type.\n* `Premier` - Premier as a License type.\n* `IWO-Essential` - IWO-Essential as a License type.\n* `IWO-Advantage` - IWO-Advantage as a License type.\n* `IWO-Premier` - IWO-Premier as a License type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public LicenseIwoCustomerOp.ActiveLicenseTypeEnum ActiveLicenseType {
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
        /// <para type="description">"Enable trial for Intersight licensing."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool EnableTrial {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The default Trial or Grace period customer is entitled to."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long EvaluationPeriod {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of days the trial Trial or Grace period is extended. The trial or grace period can be extended once."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long ExtraEvaluation {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
}