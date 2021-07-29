using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NiaapiApicLatestMaintainedRelease.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNiaapiApicLatestMaintainedRelease", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNiaapiApicLatestMaintainedRelease:GetCmdletBase
	{
		public GetIntersightNiaapiApicLatestMaintainedRelease()
		{
			ApiInstance = new NiaapiApi(Config);
            MethodName = "GetNiaapiApicLatestMaintainedReleaseList";
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
            MethodName = "GetNiaapiNiaMetadataList";
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
            MethodName = "GetNiaapiDcnmFieldNoticeList";
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
            MethodName = "GetNiaapiFileDownloaderList";
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
            MethodName = "GetNiaapiApicHweolList";
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
            MethodName = "GetNiaapiApicSweolList";
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
            MethodName = "GetNiaapiNibMetadataList";
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
            MethodName = "GetNiaapiApicCcoPostList";
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
            MethodName = "GetNiaapiDcnmHweolList";
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
            MethodName = "GetNiaapiDcnmReleaseRecommendList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NiaapiDcnmLatestMaintainedRelease.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNiaapiDcnmLatestMaintainedRelease", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNiaapiDcnmLatestMaintainedRelease:GetCmdletBase
	{
		public GetIntersightNiaapiDcnmLatestMaintainedRelease()
		{
			ApiInstance = new NiaapiApi(Config);
            MethodName = "GetNiaapiDcnmLatestMaintainedReleaseList";
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
            MethodName = "GetNiaapiApicReleaseRecommendList";
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
            MethodName = "GetNiaapiNibFileDownloaderList";
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
            MethodName = "GetNiaapiDcnmSweolList";
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
            MethodName = "GetNiaapiDcnmCcoPostList";
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
            MethodName = "GetNiaapiApicFieldNoticeList";
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
            MethodName = "GetNiaapiVersionRegexList";
		}
    }
}