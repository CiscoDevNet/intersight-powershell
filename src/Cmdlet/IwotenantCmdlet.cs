using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get IwotenantTenantStatus.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightIwotenantTenantStatus", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightIwotenantTenantStatus:GetCmdletBase
	{
		public GetIntersightIwotenantTenantStatus()
		{
			ApiInstance = new IwotenantApi(Config);
            MethodName = "GetIwotenantTenantStatusListWithHttpInfo";
		}
    }
}