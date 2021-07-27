using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove UcsdBackupInfo.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightUcsdBackupInfo")]
    public class RemoveIntersightUcsdBackupInfo:RemoveCmdletBase
	{
		public RemoveIntersightUcsdBackupInfo()
		{
			ApiInstance = new UcsdApi(Config);
            MethodName = "DeleteUcsdBackupInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get UcsdBackupInfo.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightUcsdBackupInfo", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightUcsdBackupInfo:GetCmdletBase
	{
		public GetIntersightUcsdBackupInfo()
		{
			ApiInstance = new UcsdApi(Config);
            MethodName = "GetUcsdBackupInfoList";
		}
    }
}