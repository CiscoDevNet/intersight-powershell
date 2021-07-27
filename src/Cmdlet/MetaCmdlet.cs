using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get MetaDefinition.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightMetaDefinition", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightMetaDefinition:GetCmdletBase
	{
		public GetIntersightMetaDefinition()
		{
			ApiInstance = new MetaApi(Config);
            MethodName = "GetMetaDefinitionList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove MetaDefinition.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightMetaDefinition")]
    public class RemoveIntersightMetaDefinition:RemoveCmdletBase
	{
		public RemoveIntersightMetaDefinition()
		{
			ApiInstance = new MetaApi(Config);
            MethodName = "DeleteMetaDefinition";
		}
    }
}