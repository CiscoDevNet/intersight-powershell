using Intersight.Client;
using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;
using System.Reflection;
using System.Linq;

namespace Intersight.PowerShell
{
    public class SetCmdletBase : CmdletBase
    {
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false)]
        public SwitchParameter Json { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false)]
        public SwitchParameter WithHttpInfo { get; set; }

        public SetCmdletBase()
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

                if (!this.MyInvocation.BoundParameters.ContainsKey("Moid"))
                {
                    throw new Exception("Moid cannot be empty or null.");
                }

                ProcessRelationshipParam();
                var changedProperties = GetChangedProperty();
                var propertyInfos = this.ModelObject.GetType().GetProperties();
                foreach (var propertyInfo in propertyInfos)
                {
                    if (changedProperties.ContainsKey(propertyInfo.Name))
                    {
                        propertyInfo.SetValue(this.ModelObject, this.MyInvocation.BoundParameters[propertyInfo.Name]);
                    }
                    else
                    /*
					 * Ensure that the _flag is set to false for properties that are not configured using cmdlet parameters. 
					 * The following code ensures this by setting it to false if the _flag is set to true for properties that 
					 * are not configured. This fix applies to all New and Set cmdlets. 
					 * The problem was reported as part of the issue : https://github.com/CiscoDevNet/intersight-powershell/issues/101.
					 */
                    {
                        PSUtils.SetSerializeFalgToFalse(propertyInfo.Name, ModelObject);
                    }
                }

                if (Json.IsPresent)
                {
                    WriteRequestJson();
                }

                var methodInfo = GetMethodInfo(MethodName);
                var moidVal = ModelObject.GetType().GetProperty("Moid").GetValue(ModelObject);
                var parameterInfo = methodInfo.GetParameters();
                List<object> argList = new List<object>();
                argList.Add(moidVal);
                argList.Add(ModelObject);
                for (int i = 2; i < parameterInfo.Length; i++)
                {
                    if (parameterInfo[i].HasDefaultValue)
                    {
                        argList.Add(parameterInfo[i].DefaultValue);
                    }
                }
                var result = methodInfo.Invoke(ApiInstance, argList.ToArray());
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
                throw ex.InnerException ?? ex;
            }
        }

        private object GetMoByMoid(object moid)
        {
            string methodName = string.Format("{0}ByMoid", this.MyInvocation.MyCommand.Name.Replace("Set-Intersight", "Get"));
            var getMethodInfo = this.ApiInstance.GetType().GetMethod(methodName);
            if (getMethodInfo != null)
            {
                object[] argList = new[] { moid, 0 };
                var result = getMethodInfo.Invoke(ApiInstance, argList);
                return result;
            }
            return ModelObject;
        }

        private Dictionary<string, object> GetChangedProperty()
        {
            var changedProperties = new Dictionary<string, object>();
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                changedProperties.Add("Moid", this.MyInvocation.BoundParameters["Moid"]);
            }

            var getObject = GetMoByMoid(this.MyInvocation.BoundParameters["Moid"]);

            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                changedProperties.Add("Name", this.MyInvocation.BoundParameters["Name"]);
            }
            else if (getObject != null)
            {
                var nameInfo = getObject.GetType().GetProperty("Name");
                if (nameInfo != null)
                {
                    var nameValue = nameInfo.GetValue(getObject);
                    changedProperties.Add("Name", nameValue);
                    this.MyInvocation.BoundParameters.Add("Name", nameValue);
                }
            }

            foreach (var propName in this.MyInvocation.BoundParameters)
            {
                if (propName.Key == "Moid" || propName.Key == "Name")
                {
                    continue;
                }

                var getPropertyInfo = getObject.GetType().GetProperty(propName.Key);
                if (getPropertyInfo != null)
                {
                    var getVal = getPropertyInfo.GetValue(getObject);
                    if (getVal == null)
                    {
                        if (getVal != propName.Value)
                        {
                            changedProperties.Add(propName.Key, propName.Value);
                        }
                        continue;
                    }

                    if (propName.Value == null)
                    {
                        if (getVal != propName.Value)
                        {
                            changedProperties.Add(propName.Key, propName.Value);
                        }
                        continue;
                    }

                    if ((getVal.GetType().Name == "String" || getVal.GetType().IsPrimitive))
                    {
                        if (!(getVal.Equals(propName.Value)))
                        {
                            changedProperties.Add(propName.Key, propName.Value);
                        }
                    }
                    else if (getVal.GetType().Name == "List`1")
                    {
                        if (!(PSUtils.CompareList(getVal, propName.Value, CommandRuntime)))
                        {
                            changedProperties.Add(propName.Key, propName.Value);
                        }
                    }
                    else if (getVal.GetType().Name == "Dictionary`2")
                    {
                        if (!PSUtils.CompareDictionary(getVal, propName.Value, CommandRuntime))
                        {
                            changedProperties.Add(propName.Key, propName.Value);
                        }
                    }
                    else if (getVal.GetType().IsEnum)
                    {
                        if (getVal.ToString() != propName.Value.ToString())
                        {
                            changedProperties.Add(propName.Key, propName.Value);
                        }
                    }
                    else
                    {
                        if (!PSUtils.CompareIntersightObject(getVal, propName.Value, CommandRuntime))
                        {
                            changedProperties.Add(propName.Key, propName.Value);
                        }
                    }
                }
            }

            return changedProperties;
        }
    }
}
