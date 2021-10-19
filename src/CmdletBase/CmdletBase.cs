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
		[Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false)]
		public SwitchParameter Json { get; set; }

		[Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false)]
		public SwitchParameter WithHttpInfo { get; set; }
		
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

		protected override void BeginProcessing()
		{
			if (CmdletBase.Config == null || CmdletBase.Config.HttpSigningConfiguration == null)
			{
				throw new Exception("Intersight environment is not configured. Use the cmdlet Set-IntersightConfiguration to configure it.");
			}

			if(this.MyInvocation.BoundParameters.ContainsKey("Json") && this.MyInvocation.BoundParameters.ContainsKey("WithHttpInfo"))
            {
                throw new Exception("Parameter Josn and WithHttpInfo cannot be used together");
            }
			
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

		public void WriteRequestJson() 
		{
			var toJsonMethodInfo = ModelObject.GetType().GetMethod("ToJson");
			if (toJsonMethodInfo != null)
			{
				StringBuilder requestJson = new StringBuilder();
				var jsonData = toJsonMethodInfo.Invoke(ModelObject, null);
				requestJson.Append((string)jsonData);
				WriteObject(requestJson.ToString());
			}
		}

		public void WriteResponseJson(object result)
		{
			if (result == null)
			{
				throw new Exception("Server Response should not be null");
			}
			
			var rawContentPropInfo = result.GetType().GetProperty("RawContent");
			if (rawContentPropInfo != null)
			{
				StringBuilder responseJson = new StringBuilder();
				var rawContent = rawContentPropInfo.GetValue(result);
				responseJson.Append((string)rawContent);
				WriteObject(responseJson.ToString());
			}
		}

		public object WriteResponseData(object result, bool writeToPipeline = true)
		{
			if (result == null)
			{
				throw new Exception("Server Response should not be null");
			}
			var dataPropInfo = result.GetType().GetProperty("Data");
			if (dataPropInfo != null)
			{
				var data = dataPropInfo.GetValue(result);
				if(writeToPipeline)
				{
					WriteObject(data);
				}
				else
				{
					return data;
				}
			}
			return null;
		}
	}
}
