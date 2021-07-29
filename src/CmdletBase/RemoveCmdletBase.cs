using Intersight.Client;
using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;
using Intersight.Api;

namespace Intersight.PowerShell
{
	public class RemoveCmdletBase:CmdletBase
	{
		#region Parameter
		[Parameter(Mandatory = true,ValueFromPipelineByPropertyName = true)]
		public string Moid { get; set; }
		#endregion

		public RemoveCmdletBase()
		{
		}

		protected override void BeginProcessing()
		{
			if (CmdletBase.Config == null || CmdletBase.Config.HttpSigningConfiguration == null)
			{
				throw new Exception("Intersight environment is not configured. Use the cmdlet Set-IntersightConfiguration to configure it.");
			}
		}

		protected override void ProcessRecord()
		{
			try
			{
				var methodInfo = GetMethodInfo(MethodName);
				methodInfo.Invoke(ApiInstance, new object[] { Moid });
			}
			catch(Exception ex)
			{
				throw ex.InnerException ?? ex;
			}
		}

	}
}
