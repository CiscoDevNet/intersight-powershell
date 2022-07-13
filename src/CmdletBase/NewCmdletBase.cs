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

                ProcessRelationshipParam();

                var propertyList = this.ModelObject.GetType().GetProperties();
                foreach (var item in propertyList)
                {
                    var propName = item.Name;
                    if (item.Name.StartsWith("_"))
                    {
                        propName = item.Name.TrimStart('_');
                    }

                    if (this.MyInvocation.BoundParameters.ContainsKey(propName))
                    {
                        item.SetValue(ModelObject, this.MyInvocation.BoundParameters[propName]);
                    }
                }

                if (Json.IsPresent)
                {
                    WriteRequestJson();
                }

                var methodInfo = GetMethodInfo(MethodName);
                Object[] argList = new[] { ModelObject, default(string), default(string), 0 };
                var result = methodInfo.Invoke(ApiInstance, argList);
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
                        var objectType = actualInstance.GetType().GetProperty("ObjectType", BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance).GetValue(actualInstance);
                        var moRefStr = string.Format(jsonStr, moid, objectType);
                        var fromJsonMethod = itemValue.GetType().GetMethod("FromJson");
                        if (fromJsonMethod != null)
                        {
                            object[] argList = new[] { moRefStr };
                            var moRefInstance = fromJsonMethod.Invoke(null, argList);
                            this.MyInvocation.BoundParameters[item.Key] = moRefInstance;
                        }
                    }
                }

            }
        }
    }
}
