using Intersight.Client;
using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Reflection;
using System.Text;

namespace Intersight.PowerShell
{
	public class CmdletBase:PSCmdlet
	{
		public static Configuration Config { get; set; }

		public Object ApiInstance { get; set; }

		public Object ModelObject { get; set; }

		public string MethodName { get; set; } 

		static CmdletBase()
		{
			Config = new Configuration();
		}

		public CmdletBase()
		{
			
		}

		public MethodInfo GetMethodInfo(String methodName)
		{
			if (ApiInstance == null)
			{
				throw new Exception("Api instance should not be null.");
			}
			var methodInfo = this.ApiInstance.GetType().GetMethod(methodName);
			return methodInfo;
		}
	}
}
