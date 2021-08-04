using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get AaaAuditRecord.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightAaaAuditRecord", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightAaaAuditRecord:GetCmdletBase
	{
		public GetIntersightAaaAuditRecord()
		{
			ApiInstance = new AaaApi(Config);
            MethodName = "GetAaaAuditRecordListWithHttpInfo";
		}
    }
}