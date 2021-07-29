using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NiatelemetryMsoContractDetails.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNiatelemetryMsoContractDetails", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNiatelemetryMsoContractDetails:GetCmdletBase
	{
		public GetIntersightNiatelemetryMsoContractDetails()
		{
			ApiInstance = new NiatelemetryApi(Config);
            MethodName = "GetNiatelemetryMsoContractDetailsList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NiatelemetryApicPsuDetails.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNiatelemetryApicPsuDetails", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNiatelemetryApicPsuDetails:GetCmdletBase
	{
		public GetIntersightNiatelemetryApicPsuDetails()
		{
			ApiInstance = new NiatelemetryApi(Config);
            MethodName = "GetNiatelemetryApicPsuDetailsList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NiatelemetryHttpsAclFilterDetails.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNiatelemetryHttpsAclFilterDetails", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNiatelemetryHttpsAclFilterDetails:GetCmdletBase
	{
		public GetIntersightNiatelemetryHttpsAclFilterDetails()
		{
			ApiInstance = new NiatelemetryApi(Config);
            MethodName = "GetNiatelemetryHttpsAclFilterDetailsList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NiatelemetryApicFexDetails.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNiatelemetryApicFexDetails", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNiatelemetryApicFexDetails:GetCmdletBase
	{
		public GetIntersightNiatelemetryApicFexDetails()
		{
			ApiInstance = new NiatelemetryApi(Config);
            MethodName = "GetNiatelemetryApicFexDetailsList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NiatelemetryApicSnmpTrapDetails.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNiatelemetryApicSnmpTrapDetails", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNiatelemetryApicSnmpTrapDetails:GetCmdletBase
	{
		public GetIntersightNiatelemetryApicSnmpTrapDetails()
		{
			ApiInstance = new NiatelemetryApi(Config);
            MethodName = "GetNiatelemetryApicSnmpTrapDetailsList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NiatelemetryFault.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNiatelemetryFault", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNiatelemetryFault:GetCmdletBase
	{
		public GetIntersightNiatelemetryFault()
		{
			ApiInstance = new NiatelemetryApi(Config);
            MethodName = "GetNiatelemetryFaultList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NiatelemetryApicFlashDetails.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNiatelemetryApicFlashDetails", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNiatelemetryApicFlashDetails:GetCmdletBase
	{
		public GetIntersightNiatelemetryApicFlashDetails()
		{
			ApiInstance = new NiatelemetryApi(Config);
            MethodName = "GetNiatelemetryApicFlashDetailsList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NiatelemetryMsoEpgDetails.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNiatelemetryMsoEpgDetails", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNiatelemetryMsoEpgDetails:GetCmdletBase
	{
		public GetIntersightNiatelemetryMsoEpgDetails()
		{
			ApiInstance = new NiatelemetryApi(Config);
            MethodName = "GetNiatelemetryMsoEpgDetailsList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NiatelemetryNiaInventory.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNiatelemetryNiaInventory", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNiatelemetryNiaInventory:GetCmdletBase
	{
		public GetIntersightNiatelemetryNiaInventory()
		{
			ApiInstance = new NiatelemetryApi(Config);
            MethodName = "GetNiatelemetryNiaInventoryList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NiatelemetryApicNtpAuth.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNiatelemetryApicNtpAuth", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNiatelemetryApicNtpAuth:GetCmdletBase
	{
		public GetIntersightNiatelemetryApicNtpAuth()
		{
			ApiInstance = new NiatelemetryApi(Config);
            MethodName = "GetNiatelemetryApicNtpAuthList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NiatelemetryAaaLdapProviderDetails.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNiatelemetryAaaLdapProviderDetails", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNiatelemetryAaaLdapProviderDetails:GetCmdletBase
	{
		public GetIntersightNiatelemetryAaaLdapProviderDetails()
		{
			ApiInstance = new NiatelemetryApi(Config);
            MethodName = "GetNiatelemetryAaaLdapProviderDetailsList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NiatelemetryFabricModuleDetails.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNiatelemetryFabricModuleDetails", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNiatelemetryFabricModuleDetails:GetCmdletBase
	{
		public GetIntersightNiatelemetryFabricModuleDetails()
		{
			ApiInstance = new NiatelemetryApi(Config);
            MethodName = "GetNiatelemetryFabricModuleDetailsList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NiatelemetryNexusDashboardControllerDetails.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNiatelemetryNexusDashboardControllerDetails", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNiatelemetryNexusDashboardControllerDetails:GetCmdletBase
	{
		public GetIntersightNiatelemetryNexusDashboardControllerDetails()
		{
			ApiInstance = new NiatelemetryApi(Config);
            MethodName = "GetNiatelemetryNexusDashboardControllerDetailsList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NiatelemetryDcnmPsuDetails.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNiatelemetryDcnmPsuDetails", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNiatelemetryDcnmPsuDetails:GetCmdletBase
	{
		public GetIntersightNiatelemetryDcnmPsuDetails()
		{
			ApiInstance = new NiatelemetryApi(Config);
            MethodName = "GetNiatelemetryDcnmPsuDetailsList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NiatelemetryApicTransceiverDetails.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNiatelemetryApicTransceiverDetails", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNiatelemetryApicTransceiverDetails:GetCmdletBase
	{
		public GetIntersightNiatelemetryApicTransceiverDetails()
		{
			ApiInstance = new NiatelemetryApi(Config);
            MethodName = "GetNiatelemetryApicTransceiverDetailsList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NiatelemetryMsoTenantDetails.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNiatelemetryMsoTenantDetails", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNiatelemetryMsoTenantDetails:GetCmdletBase
	{
		public GetIntersightNiatelemetryMsoTenantDetails()
		{
			ApiInstance = new NiatelemetryApi(Config);
            MethodName = "GetNiatelemetryMsoTenantDetailsList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NiatelemetryNiaInventoryFabric.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNiatelemetryNiaInventoryFabric", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNiatelemetryNiaInventoryFabric:GetCmdletBase
	{
		public GetIntersightNiatelemetryNiaInventoryFabric()
		{
			ApiInstance = new NiatelemetryApi(Config);
            MethodName = "GetNiatelemetryNiaInventoryFabricList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NiatelemetryAaaTacacsProviderDetails.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNiatelemetryAaaTacacsProviderDetails", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNiatelemetryAaaTacacsProviderDetails:GetCmdletBase
	{
		public GetIntersightNiatelemetryAaaTacacsProviderDetails()
		{
			ApiInstance = new NiatelemetryApi(Config);
            MethodName = "GetNiatelemetryAaaTacacsProviderDetailsList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NiatelemetryLc.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNiatelemetryLc", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNiatelemetryLc:GetCmdletBase
	{
		public GetIntersightNiatelemetryLc()
		{
			ApiInstance = new NiatelemetryApi(Config);
            MethodName = "GetNiatelemetryLcList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NiatelemetryNiaFeatureUsage.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNiatelemetryNiaFeatureUsage", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNiatelemetryNiaFeatureUsage:GetCmdletBase
	{
		public GetIntersightNiatelemetryNiaFeatureUsage()
		{
			ApiInstance = new NiatelemetryApi(Config);
            MethodName = "GetNiatelemetryNiaFeatureUsageList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NiatelemetryMsoSiteDetails.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNiatelemetryMsoSiteDetails", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNiatelemetryMsoSiteDetails:GetCmdletBase
	{
		public GetIntersightNiatelemetryMsoSiteDetails()
		{
			ApiInstance = new NiatelemetryApi(Config);
            MethodName = "GetNiatelemetryMsoSiteDetailsList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NiatelemetryApicSysLogGrp.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNiatelemetryApicSysLogGrp", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNiatelemetryApicSysLogGrp:GetCmdletBase
	{
		public GetIntersightNiatelemetryApicSysLogGrp()
		{
			ApiInstance = new NiatelemetryApi(Config);
            MethodName = "GetNiatelemetryApicSysLogGrpList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NiatelemetryNexusDashboardMemoryDetails.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNiatelemetryNexusDashboardMemoryDetails", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNiatelemetryNexusDashboardMemoryDetails:GetCmdletBase
	{
		public GetIntersightNiatelemetryNexusDashboardMemoryDetails()
		{
			ApiInstance = new NiatelemetryApi(Config);
            MethodName = "GetNiatelemetryNexusDashboardMemoryDetailsList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NiatelemetryAppDetails.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNiatelemetryAppDetails", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNiatelemetryAppDetails:GetCmdletBase
	{
		public GetIntersightNiatelemetryAppDetails()
		{
			ApiInstance = new NiatelemetryApi(Config);
            MethodName = "GetNiatelemetryAppDetailsList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NiatelemetryApicFanDetails.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNiatelemetryApicFanDetails", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNiatelemetryApicFanDetails:GetCmdletBase
	{
		public GetIntersightNiatelemetryApicFanDetails()
		{
			ApiInstance = new NiatelemetryApi(Config);
            MethodName = "GetNiatelemetryApicFanDetailsList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NiatelemetryApicSnmpCommunityAccessDetails.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNiatelemetryApicSnmpCommunityAccessDetails", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNiatelemetryApicSnmpCommunityAccessDetails:GetCmdletBase
	{
		public GetIntersightNiatelemetryApicSnmpCommunityAccessDetails()
		{
			ApiInstance = new NiatelemetryApi(Config);
            MethodName = "GetNiatelemetryApicSnmpCommunityAccessDetailsList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NiatelemetryApicDbgexpRsExportDest.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNiatelemetryApicDbgexpRsExportDest", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNiatelemetryApicDbgexpRsExportDest:GetCmdletBase
	{
		public GetIntersightNiatelemetryApicDbgexpRsExportDest()
		{
			ApiInstance = new NiatelemetryApi(Config);
            MethodName = "GetNiatelemetryApicDbgexpRsExportDestList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NiatelemetryMsoSchemaDetails.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNiatelemetryMsoSchemaDetails", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNiatelemetryMsoSchemaDetails:GetCmdletBase
	{
		public GetIntersightNiatelemetryMsoSchemaDetails()
		{
			ApiInstance = new NiatelemetryApi(Config);
            MethodName = "GetNiatelemetryMsoSchemaDetailsList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NiatelemetryEpg.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNiatelemetryEpg", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNiatelemetryEpg:GetCmdletBase
	{
		public GetIntersightNiatelemetryEpg()
		{
			ApiInstance = new NiatelemetryApi(Config);
            MethodName = "GetNiatelemetryEpgList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NiatelemetryApicSnmpVersionThreeDetails.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNiatelemetryApicSnmpVersionThreeDetails", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNiatelemetryApicSnmpVersionThreeDetails:GetCmdletBase
	{
		public GetIntersightNiatelemetryApicSnmpVersionThreeDetails()
		{
			ApiInstance = new NiatelemetryApi(Config);
            MethodName = "GetNiatelemetryApicSnmpVersionThreeDetailsList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NiatelemetryApicSysLogSrc.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNiatelemetryApicSysLogSrc", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNiatelemetryApicSysLogSrc:GetCmdletBase
	{
		public GetIntersightNiatelemetryApicSysLogSrc()
		{
			ApiInstance = new NiatelemetryApi(Config);
            MethodName = "GetNiatelemetryApicSysLogSrcList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NiatelemetryNexusDashboards.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNiatelemetryNexusDashboards", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNiatelemetryNexusDashboards:GetCmdletBase
	{
		public GetIntersightNiatelemetryNexusDashboards()
		{
			ApiInstance = new NiatelemetryApi(Config);
            MethodName = "GetNiatelemetryNexusDashboardsList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NiatelemetryNiaInventoryDcnm.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNiatelemetryNiaInventoryDcnm", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNiatelemetryNiaInventoryDcnm:GetCmdletBase
	{
		public GetIntersightNiatelemetryNiaInventoryDcnm()
		{
			ApiInstance = new NiatelemetryApi(Config);
            MethodName = "GetNiatelemetryNiaInventoryDcnmList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NiatelemetryApicDbgexpRsTsScheduler.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNiatelemetryApicDbgexpRsTsScheduler", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNiatelemetryApicDbgexpRsTsScheduler:GetCmdletBase
	{
		public GetIntersightNiatelemetryApicDbgexpRsTsScheduler()
		{
			ApiInstance = new NiatelemetryApi(Config);
            MethodName = "GetNiatelemetryApicDbgexpRsTsSchedulerList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NiatelemetryTenant.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNiatelemetryTenant", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNiatelemetryTenant:GetCmdletBase
	{
		public GetIntersightNiatelemetryTenant()
		{
			ApiInstance = new NiatelemetryApi(Config);
            MethodName = "GetNiatelemetryTenantList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NiatelemetryDcnmFexDetails.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNiatelemetryDcnmFexDetails", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNiatelemetryDcnmFexDetails:GetCmdletBase
	{
		public GetIntersightNiatelemetryDcnmFexDetails()
		{
			ApiInstance = new NiatelemetryApi(Config);
            MethodName = "GetNiatelemetryDcnmFexDetailsList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NiatelemetryApicUiPageCounts.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNiatelemetryApicUiPageCounts", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNiatelemetryApicUiPageCounts:GetCmdletBase
	{
		public GetIntersightNiatelemetryApicUiPageCounts()
		{
			ApiInstance = new NiatelemetryApi(Config);
            MethodName = "GetNiatelemetryApicUiPageCountsList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NiatelemetryDcnmModuleDetails.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNiatelemetryDcnmModuleDetails", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNiatelemetryDcnmModuleDetails:GetCmdletBase
	{
		public GetIntersightNiatelemetryDcnmModuleDetails()
		{
			ApiInstance = new NiatelemetryApi(Config);
            MethodName = "GetNiatelemetryDcnmModuleDetailsList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NiatelemetryHttpsAclEpgDetails.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNiatelemetryHttpsAclEpgDetails", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNiatelemetryHttpsAclEpgDetails:GetCmdletBase
	{
		public GetIntersightNiatelemetryHttpsAclEpgDetails()
		{
			ApiInstance = new NiatelemetryApi(Config);
            MethodName = "GetNiatelemetryHttpsAclEpgDetailsList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NiatelemetryNiaLicenseState.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNiatelemetryNiaLicenseState", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNiatelemetryNiaLicenseState:GetCmdletBase
	{
		public GetIntersightNiatelemetryNiaLicenseState()
		{
			ApiInstance = new NiatelemetryApi(Config);
            MethodName = "GetNiatelemetryNiaLicenseStateList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NiatelemetryApicCoreFileDetails.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNiatelemetryApicCoreFileDetails", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNiatelemetryApicCoreFileDetails:GetCmdletBase
	{
		public GetIntersightNiatelemetryApicCoreFileDetails()
		{
			ApiInstance = new NiatelemetryApi(Config);
            MethodName = "GetNiatelemetryApicCoreFileDetailsList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NiatelemetryDcnmTransceiverDetails.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNiatelemetryDcnmTransceiverDetails", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNiatelemetryDcnmTransceiverDetails:GetCmdletBase
	{
		public GetIntersightNiatelemetryDcnmTransceiverDetails()
		{
			ApiInstance = new NiatelemetryApi(Config);
            MethodName = "GetNiatelemetryDcnmTransceiverDetailsList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NiatelemetryDcnmFanDetails.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNiatelemetryDcnmFanDetails", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNiatelemetryDcnmFanDetails:GetCmdletBase
	{
		public GetIntersightNiatelemetryDcnmFanDetails()
		{
			ApiInstance = new NiatelemetryApi(Config);
            MethodName = "GetNiatelemetryDcnmFanDetailsList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NiatelemetryNexusDashboardDetails.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNiatelemetryNexusDashboardDetails", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNiatelemetryNexusDashboardDetails:GetCmdletBase
	{
		public GetIntersightNiatelemetryNexusDashboardDetails()
		{
			ApiInstance = new NiatelemetryApi(Config);
            MethodName = "GetNiatelemetryNexusDashboardDetailsList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NiatelemetryHttpsAclContractDetails.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNiatelemetryHttpsAclContractDetails", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNiatelemetryHttpsAclContractDetails:GetCmdletBase
	{
		public GetIntersightNiatelemetryHttpsAclContractDetails()
		{
			ApiInstance = new NiatelemetryApi(Config);
            MethodName = "GetNiatelemetryHttpsAclContractDetailsList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NiatelemetryAaaRadiusProviderDetails.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNiatelemetryAaaRadiusProviderDetails", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNiatelemetryAaaRadiusProviderDetails:GetCmdletBase
	{
		public GetIntersightNiatelemetryAaaRadiusProviderDetails()
		{
			ApiInstance = new NiatelemetryApi(Config);
            MethodName = "GetNiatelemetryAaaRadiusProviderDetailsList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NiatelemetrySystemControllerDetails.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNiatelemetrySystemControllerDetails", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNiatelemetrySystemControllerDetails:GetCmdletBase
	{
		public GetIntersightNiatelemetrySystemControllerDetails()
		{
			ApiInstance = new NiatelemetryApi(Config);
            MethodName = "GetNiatelemetrySystemControllerDetailsList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NiatelemetryHttpsAclContractFilterMap.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNiatelemetryHttpsAclContractFilterMap", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNiatelemetryHttpsAclContractFilterMap:GetCmdletBase
	{
		public GetIntersightNiatelemetryHttpsAclContractFilterMap()
		{
			ApiInstance = new NiatelemetryApi(Config);
            MethodName = "GetNiatelemetryHttpsAclContractFilterMapList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NiatelemetryPasswordStrengthCheck.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNiatelemetryPasswordStrengthCheck", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNiatelemetryPasswordStrengthCheck:GetCmdletBase
	{
		public GetIntersightNiatelemetryPasswordStrengthCheck()
		{
			ApiInstance = new NiatelemetryApi(Config);
            MethodName = "GetNiatelemetryPasswordStrengthCheckList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NiatelemetryApicRealmDetails.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNiatelemetryApicRealmDetails", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNiatelemetryApicRealmDetails:GetCmdletBase
	{
		public GetIntersightNiatelemetryApicRealmDetails()
		{
			ApiInstance = new NiatelemetryApi(Config);
            MethodName = "GetNiatelemetryApicRealmDetailsList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NiatelemetryHttpsAclEpgContractMap.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNiatelemetryHttpsAclEpgContractMap", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNiatelemetryHttpsAclEpgContractMap:GetCmdletBase
	{
		public GetIntersightNiatelemetryHttpsAclEpgContractMap()
		{
			ApiInstance = new NiatelemetryApi(Config);
            MethodName = "GetNiatelemetryHttpsAclEpgContractMapList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NiatelemetryApicSnmpCommunityDetails.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNiatelemetryApicSnmpCommunityDetails", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNiatelemetryApicSnmpCommunityDetails:GetCmdletBase
	{
		public GetIntersightNiatelemetryApicSnmpCommunityDetails()
		{
			ApiInstance = new NiatelemetryApi(Config);
            MethodName = "GetNiatelemetryApicSnmpCommunityDetailsList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NiatelemetrySupervisorModuleDetails.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNiatelemetrySupervisorModuleDetails", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNiatelemetrySupervisorModuleDetails:GetCmdletBase
	{
		public GetIntersightNiatelemetrySupervisorModuleDetails()
		{
			ApiInstance = new NiatelemetryApi(Config);
            MethodName = "GetNiatelemetrySupervisorModuleDetailsList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NiatelemetrySshVersionTwo.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNiatelemetrySshVersionTwo", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNiatelemetrySshVersionTwo:GetCmdletBase
	{
		public GetIntersightNiatelemetrySshVersionTwo()
		{
			ApiInstance = new NiatelemetryApi(Config);
            MethodName = "GetNiatelemetrySshVersionTwoList";
		}
    }
}