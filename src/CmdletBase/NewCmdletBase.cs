using Intersight.Client;
using Intersight.Model;
using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Reflection;
using System.Text;

namespace Intersight.PowerShell
{
	public class NewCmdletBase:CmdletBase
	{
		public NewCmdletBase()
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
				if(this.ModelObject == null)
				{
					throw new Exception(string.Format("{0} ModelObject should not be null", this.MyInvocation.InvocationName));
				}

				ProcessRelationshipParam();	

				var propertyList = this.ModelObject.GetType().GetProperties();
				foreach(var item in propertyList)
				{
					if (this.MyInvocation.BoundParameters.ContainsKey(item.Name))
					{
						item.SetValue(ModelObject, this.MyInvocation.BoundParameters[item.Name]);
					}
				}

				var methodInfo = GetMethodInfo(MethodName);
				Object[] argList = new[] { ModelObject,default(string),default(string) };
				var result = methodInfo.Invoke(ApiInstance, argList);
				WriteObject(result);
			}
			catch(Exception ex)
			{
				throw ex.InnerException;
			}
		}

		internal void ProcessRelationshipParam()
		{
			foreach (var item in this.MyInvocation.BoundParameters)
			{
				var itemValue = item.Value;
				if (itemValue.GetType().Name.EndsWith("Relationship"))
				{
					var actualInstance = itemValue.GetType().GetProperty("ActualInstance").GetValue(itemValue);
					if (actualInstance.GetType().Name != "MoMoRef")
					{
						string jsonStr = "{{\"ClassId\" : \"mo.MoRef\",\"Moid\" : \"{0}\", \"ObjectType\" :\"{1}\"}}";
						var moid = actualInstance.GetType().GetProperty("Moid").GetValue(actualInstance);
						var objectType = actualInstance.GetType().GetProperty("ObjectType",BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance).GetValue(actualInstance);
						var moRefStr = string.Format(jsonStr, moid,objectType);
						var fromJsonMethod = itemValue.GetType().GetMethod("FromJson");
						if (fromJsonMethod != null)
						{
							object[] argList = new[] { moRefStr };
							var moRefInstance = fromJsonMethod.Invoke(null, argList);
							this.MyInvocation.BoundParameters[item.Key] = moRefInstance;
						}
				}	}
			
			}
		}
	}
}
