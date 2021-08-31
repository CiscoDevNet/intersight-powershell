using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NiaapiDcnmLatestMaintainedRelease.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNiaapiDcnmLatestMaintainedRelease", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNiaapiDcnmLatestMaintainedRelease:GetCmdletBase
	{
		public GetIntersightNiaapiDcnmLatestMaintainedRelease()
		{
			ApiInstance = new NiaapiApi(Config);
            MethodName = "GetNiaapiDcnmLatestMaintainedReleaseListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NiaapiDcnmSweol.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNiaapiDcnmSweol", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNiaapiDcnmSweol:GetCmdletBase
	{
		public GetIntersightNiaapiDcnmSweol()
		{
			ApiInstance = new NiaapiApi(Config);
            MethodName = "GetNiaapiDcnmSweolListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NiaapiDcnmReleaseRecommend.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNiaapiDcnmReleaseRecommend", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNiaapiDcnmReleaseRecommend:GetCmdletBase
	{
		public GetIntersightNiaapiDcnmReleaseRecommend()
		{
			ApiInstance = new NiaapiApi(Config);
            MethodName = "GetNiaapiDcnmReleaseRecommendListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NiaapiApicReleaseRecommend.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNiaapiApicReleaseRecommend", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNiaapiApicReleaseRecommend:GetCmdletBase
	{
		public GetIntersightNiaapiApicReleaseRecommend()
		{
			ApiInstance = new NiaapiApi(Config);
            MethodName = "GetNiaapiApicReleaseRecommendListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NiaapiApicFieldNotice.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNiaapiApicFieldNotice", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNiaapiApicFieldNotice:GetCmdletBase
	{
		public GetIntersightNiaapiApicFieldNotice()
		{
			ApiInstance = new NiaapiApi(Config);
            MethodName = "GetNiaapiApicFieldNoticeListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NiaapiDcnmHweol.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNiaapiDcnmHweol", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNiaapiDcnmHweol:GetCmdletBase
	{
		public GetIntersightNiaapiDcnmHweol()
		{
			ApiInstance = new NiaapiApi(Config);
            MethodName = "GetNiaapiDcnmHweolListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NiaapiNibFileDownloader.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNiaapiNibFileDownloader", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNiaapiNibFileDownloader:GetCmdletBase
	{
		public GetIntersightNiaapiNibFileDownloader()
		{
			ApiInstance = new NiaapiApi(Config);
            MethodName = "GetNiaapiNibFileDownloaderListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NiaapiDcnmCcoPost.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNiaapiDcnmCcoPost", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNiaapiDcnmCcoPost:GetCmdletBase
	{
		public GetIntersightNiaapiDcnmCcoPost()
		{
			ApiInstance = new NiaapiApi(Config);
            MethodName = "GetNiaapiDcnmCcoPostListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NiaapiDcnmFieldNotice.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNiaapiDcnmFieldNotice", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNiaapiDcnmFieldNotice:GetCmdletBase
	{
		public GetIntersightNiaapiDcnmFieldNotice()
		{
			ApiInstance = new NiaapiApi(Config);
            MethodName = "GetNiaapiDcnmFieldNoticeListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NiaapiNibMetadata.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNiaapiNibMetadata", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNiaapiNibMetadata:GetCmdletBase
	{
		public GetIntersightNiaapiNibMetadata()
		{
			ApiInstance = new NiaapiApi(Config);
            MethodName = "GetNiaapiNibMetadataListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NiaapiApicLatestMaintainedRelease.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNiaapiApicLatestMaintainedRelease", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNiaapiApicLatestMaintainedRelease:GetCmdletBase
	{
		public GetIntersightNiaapiApicLatestMaintainedRelease()
		{
			ApiInstance = new NiaapiApi(Config);
            MethodName = "GetNiaapiApicLatestMaintainedReleaseListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NiaapiVersionRegex.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNiaapiVersionRegex", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNiaapiVersionRegex:GetCmdletBase
	{
		public GetIntersightNiaapiVersionRegex()
		{
			ApiInstance = new NiaapiApi(Config);
            MethodName = "GetNiaapiVersionRegexListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NiaapiApicHweol.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNiaapiApicHweol", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNiaapiApicHweol:GetCmdletBase
	{
		public GetIntersightNiaapiApicHweol()
		{
			ApiInstance = new NiaapiApi(Config);
            MethodName = "GetNiaapiApicHweolListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NiaapiApicSweol.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNiaapiApicSweol", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNiaapiApicSweol:GetCmdletBase
	{
		public GetIntersightNiaapiApicSweol()
		{
			ApiInstance = new NiaapiApi(Config);
            MethodName = "GetNiaapiApicSweolListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NiaapiApicCcoPost.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNiaapiApicCcoPost", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNiaapiApicCcoPost:GetCmdletBase
	{
		public GetIntersightNiaapiApicCcoPost()
		{
			ApiInstance = new NiaapiApi(Config);
            MethodName = "GetNiaapiApicCcoPostListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NiaapiNiaMetadata.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNiaapiNiaMetadata", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNiaapiNiaMetadata:GetCmdletBase
	{
		public GetIntersightNiaapiNiaMetadata()
		{
			ApiInstance = new NiaapiApi(Config);
            MethodName = "GetNiaapiNiaMetadataListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NiaapiFileDownloader.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNiaapiFileDownloader", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNiaapiFileDownloader:GetCmdletBase
	{
		public GetIntersightNiaapiFileDownloader()
		{
			ApiInstance = new NiaapiApi(Config);
            MethodName = "GetNiaapiFileDownloaderListWithHttpInfo";
		}
    }
}