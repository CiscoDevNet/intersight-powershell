using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NiatelemetryEpg.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNiatelemetryEpg", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNiatelemetryEpg:GetCmdletBase
	{
		public GetIntersightNiatelemetryEpg()
		{
			ApiInstance = new NiatelemetryApi(Config);
            MethodName = "GetNiatelemetryEpgListWithHttpInfo";
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
            MethodName = "GetNiatelemetryApicSnmpCommunityDetailsListWithHttpInfo";
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
            MethodName = "GetNiatelemetryApicSysLogSrcListWithHttpInfo";
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
            MethodName = "GetNiatelemetryDcnmModuleDetailsListWithHttpInfo";
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
            MethodName = "GetNiatelemetryFabricModuleDetailsListWithHttpInfo";
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
            MethodName = "GetNiatelemetryMsoEpgDetailsListWithHttpInfo";
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
            MethodName = "GetNiatelemetryNiaFeatureUsageListWithHttpInfo";
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
            MethodName = "GetNiatelemetryNexusDashboardDetailsListWithHttpInfo";
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
            MethodName = "GetNiatelemetryNiaInventoryListWithHttpInfo";
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
            MethodName = "GetNiatelemetryApicCoreFileDetailsListWithHttpInfo";
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
            MethodName = "GetNiatelemetryDcnmFexDetailsListWithHttpInfo";
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
            MethodName = "GetNiatelemetryMsoSchemaDetailsListWithHttpInfo";
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
            MethodName = "GetNiatelemetryApicFexDetailsListWithHttpInfo";
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
            MethodName = "GetNiatelemetryApicFlashDetailsListWithHttpInfo";
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
            MethodName = "GetNiatelemetryAaaRadiusProviderDetailsListWithHttpInfo";
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
            MethodName = "GetNiatelemetryApicSysLogGrpListWithHttpInfo";
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
            MethodName = "GetNiatelemetryHttpsAclContractDetailsListWithHttpInfo";
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
            MethodName = "GetNiatelemetryApicUiPageCountsListWithHttpInfo";
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
            MethodName = "GetNiatelemetryApicSnmpTrapDetailsListWithHttpInfo";
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
            MethodName = "GetNiatelemetryApicSnmpCommunityAccessDetailsListWithHttpInfo";
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
            MethodName = "GetNiatelemetryAppDetailsListWithHttpInfo";
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
            MethodName = "GetNiatelemetryHttpsAclContractFilterMapListWithHttpInfo";
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
            MethodName = "GetNiatelemetryHttpsAclEpgDetailsListWithHttpInfo";
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
            MethodName = "GetNiatelemetryDcnmFanDetailsListWithHttpInfo";
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
            MethodName = "GetNiatelemetryApicDbgexpRsExportDestListWithHttpInfo";
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
            MethodName = "GetNiatelemetryNexusDashboardsListWithHttpInfo";
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
            MethodName = "GetNiatelemetrySupervisorModuleDetailsListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NiatelemetryMsoContractDetails.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNiatelemetryMsoContractDetails", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNiatelemetryMsoContractDetails:GetCmdletBase
	{
		public GetIntersightNiatelemetryMsoContractDetails()
		{
			ApiInstance = new NiatelemetryApi(Config);
            MethodName = "GetNiatelemetryMsoContractDetailsListWithHttpInfo";
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
            MethodName = "GetNiatelemetryApicFanDetailsListWithHttpInfo";
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
            MethodName = "GetNiatelemetryHttpsAclEpgContractMapListWithHttpInfo";
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
            MethodName = "GetNiatelemetryMsoTenantDetailsListWithHttpInfo";
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
            MethodName = "GetNiatelemetryFaultListWithHttpInfo";
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
            MethodName = "GetNiatelemetryNexusDashboardMemoryDetailsListWithHttpInfo";
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
            MethodName = "GetNiatelemetryNiaInventoryFabricListWithHttpInfo";
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
            MethodName = "GetNiatelemetryTenantListWithHttpInfo";
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
            MethodName = "GetNiatelemetryApicRealmDetailsListWithHttpInfo";
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
            MethodName = "GetNiatelemetryNiaInventoryDcnmListWithHttpInfo";
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
            MethodName = "GetNiatelemetryDcnmPsuDetailsListWithHttpInfo";
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
            MethodName = "GetNiatelemetrySshVersionTwoListWithHttpInfo";
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
            MethodName = "GetNiatelemetryAaaLdapProviderDetailsListWithHttpInfo";
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
            MethodName = "GetNiatelemetryApicSnmpVersionThreeDetailsListWithHttpInfo";
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
            MethodName = "GetNiatelemetrySystemControllerDetailsListWithHttpInfo";
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
            MethodName = "GetNiatelemetryPasswordStrengthCheckListWithHttpInfo";
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
            MethodName = "GetNiatelemetryMsoSiteDetailsListWithHttpInfo";
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
            MethodName = "GetNiatelemetryLcListWithHttpInfo";
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
            MethodName = "GetNiatelemetryNexusDashboardControllerDetailsListWithHttpInfo";
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
            MethodName = "GetNiatelemetryApicNtpAuthListWithHttpInfo";
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
            MethodName = "GetNiatelemetryHttpsAclFilterDetailsListWithHttpInfo";
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
            MethodName = "GetNiatelemetryAaaTacacsProviderDetailsListWithHttpInfo";
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
            MethodName = "GetNiatelemetryDcnmTransceiverDetailsListWithHttpInfo";
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
            MethodName = "GetNiatelemetryApicPsuDetailsListWithHttpInfo";
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
            MethodName = "GetNiatelemetryApicDbgexpRsTsSchedulerListWithHttpInfo";
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
            MethodName = "GetNiatelemetryNiaLicenseStateListWithHttpInfo";
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
            MethodName = "GetNiatelemetryApicTransceiverDetailsListWithHttpInfo";
		}
    }
}