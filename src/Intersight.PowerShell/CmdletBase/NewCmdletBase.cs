using Intersight.Client;
using Intersight.Model;
using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Reflection;
using System.Text;

namespace Intersight.PowerShell
{
    public class NewCmdletBase : CmdletBase
    {
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false)]
        public SwitchParameter Json { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false)]
        public SwitchParameter WithHttpInfo { get; set; }

        public NewCmdletBase()
        {

        }

        protected override void ProcessRecord()
        {
            try
            {
                if (this.ModelObject == null)
                {
                    throw new Exception(string.Format("{0} ModelObject should not be null", this.MyInvocation.InvocationName));
                }

                PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
                var propertyList = this.ModelObject.GetType().GetProperties();

                // Get reserved keyword mapping once before the loop to avoid repeated calls
                var reservedKeywordMapping = PSUtils.GetReservedKeywordMapping(this.ModelObject.GetType());

                foreach (var item in propertyList)
                {
                    var propName = item.Name;
                    if (item.Name.StartsWith("_"))
                    {
                        propName = item.Name.TrimStart('_');
                    }

                    // Get the PowerShell parameter name (JSON name) for this CLR property
                    // For reserved keywords, return the JSON name, otherwise return the CLR property name
                    string boundParamKey = reservedKeywordMapping.TryGetValue(propName, out var jsonName) ? jsonName : propName;

                    if (this.MyInvocation.BoundParameters.ContainsKey(boundParamKey))
                    {
                        if (boundParamKey == "Moid" || this.MyInvocation.BoundParameters[boundParamKey] == null)
                        {
                            continue;
                        }
                        // Handle for DateTime to be always sent in UTC format
                        if (this.MyInvocation.BoundParameters[boundParamKey].GetType() == typeof(DateTime))
                        {
                            DateTime receivedDateTime = (DateTime)this.MyInvocation.BoundParameters[boundParamKey];
                            this.MyInvocation.BoundParameters[boundParamKey] = receivedDateTime.ToUniversalTime();
                        }
                        item.SetValue(ModelObject, this.MyInvocation.BoundParameters[boundParamKey]);
                    }
                    else
                    /*
					 * Ensure that the _flag is set to false for properties that are not configured using cmdlet parameters. 
					 * The following code ensures this by setting it to false if the _flag is set to true for properties that 
					 * are not configured. This fix applies to all New and Set cmdlets. 
					 * The problem was reported as part of the issue : https://github.com/CiscoDevNet/intersight-powershell/issues/101.
					 */
                    {
                        PSUtils.SetSerializeFalgToFalse(item.Name, ModelObject);
                    }
                }

                if (Json.IsPresent)
                {
                    WriteObject(GetRequestJson());
                }

                if (!ShouldProcess(Config.BasePath, string.Format("Create {0} :{1}", ModelObject.GetType().Name, GetRequestJson())))
                {
                    return;
                }

                var methodInfo = GetMethodInfo(MethodName);
                var parameterInfo = methodInfo.GetParameters();
                List<object> argList = new List<object>();
                argList.Add(ModelObject);
                // Model object is already processed so looping over method parameter from index 1
                for (int i = 1; i < parameterInfo.Length; i++)
                {
                    // convert the parameter of method in pascalcase to match the powershell input parameter.
                    var parameterName = parameterInfo[i].Name;
                    var parameNameInPascalCase = char.ToUpper(parameterName[0]) + parameterName.Substring(1);
                    if (this.MyInvocation.BoundParameters.ContainsKey(parameNameInPascalCase))
                    {
                        argList.Add(this.MyInvocation.BoundParameters[parameNameInPascalCase]);
                    }
                    else if (parameterInfo[i].HasDefaultValue)
                    {
                        argList.Add(parameterInfo[i].DefaultValue);
                    }
                    else
                    {
                        argList.Add(null);
                    }
                }
                var result = methodInfo.Invoke(ApiInstance, argList.ToArray());

                // Register TypeData for reserved keyword properties (e.g., Version -> VarVersion)
                // This enables $obj.Version to work on the returned object
                PSUtils.RegisterReservedKeywordTypeData(result.GetType());

                if (Json.IsPresent)
                {
                    WriteResponseJson(result);
                }
                else if (WithHttpInfo.IsPresent)
                {
                    WriteObject(result);
                }
                else
                {
                    WriteResponseData(result);
                }
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }
    }
}
