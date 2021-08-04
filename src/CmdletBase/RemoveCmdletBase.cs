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
				var result = methodInfo.Invoke(ApiInstance, new object[] { Moid });
				if (Json.IsPresent)
				{
					StringBuilder requestJson = new StringBuilder();
					requestJson.Append(">>>>>>>>>>>>>>>>>>(Request)>>>>>>>>>>>>>>>>>>\n");
					requestJson.Append(string.Format("{{\n\"Moid\" : \"{0}\"\n}}",this.Moid));
					WriteObject(requestJson.ToString());
					WriteResponseJson(result);
				}
				else
				{
					WriteResponseData(result);
				}
			}
			catch(Exception ex)
			{
				throw ex.InnerException ?? ex;
			}
		}

	}
}
