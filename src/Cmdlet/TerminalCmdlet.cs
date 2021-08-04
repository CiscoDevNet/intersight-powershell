using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get TerminalAuditLog.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightTerminalAuditLog", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightTerminalAuditLog:GetCmdletBase
	{
		public GetIntersightTerminalAuditLog()
		{
			ApiInstance = new TerminalApi(Config);
            MethodName = "GetTerminalAuditLogListWithHttpInfo";
		}
    }
}