using Intersight.Client;
using Intersight.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Management.Automation;
using System.Reflection;
using System.Text;

namespace Intersight.PowerShell
{
    public class CmdletBase : PSCmdlet
    {
        public static Configuration Config { get; set; }

        public static bool SkipCertificateCheck { get; set; }

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

            if (this.MyInvocation.BoundParameters.ContainsKey("Json") && this.MyInvocation.BoundParameters.ContainsKey("WithHttpInfo"))
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
                if (writeToPipeline)
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

        /// <summary>
        /// Process Relationship parameter and convert non MoMoRef object
        /// to MoMoRef.
        /// </summary>
        protected void ProcessRelationshipParam()
        {
            foreach (var item in this.MyInvocation.BoundParameters)
            {
                if (item.Value == null)
                    continue;

                var itemValue = item.Value;
                var valueType = itemValue.GetType();

                if (valueType.Name == "List`1")
                {
                    var listTypes = valueType.GetGenericArguments();
                    if (listTypes != null && listTypes.Length > 0 && !listTypes[0].Name.EndsWith("Relationship"))
                    {
                        continue;
                    }

                    var processedList = new List<object>();
                    foreach (var innerItem in (IList)itemValue)
                    {
                        ConvertManagedObjectToMoRef(innerItem);
                    }
                }
                else if (valueType.Name.EndsWith("Relationship"))
                {
                    ConvertManagedObjectToMoRef(itemValue);
                }
            }
        }

        /// <summary>
        /// Convert Non MoMoRef object to MoMoRef object for a relationship object. 
        /// </summary>
        /// <param name="managedObject"></param>
        public void ConvertManagedObjectToMoRef(object managedObject)
        {
            var valueTypeName = managedObject.GetType().Name;
            if (!valueTypeName.EndsWith("Relationship"))
            {
                return;
            }

            object actualInstance = null;
            var actualInstanceInfo = managedObject.GetType().GetProperty("ActualInstance");

            if (actualInstanceInfo != null)
            {
                actualInstance = actualInstanceInfo.GetValue(managedObject);
            }

            if (actualInstance.GetType() == typeof(MoMoRef))
            {
                return;
            }

            if (actualInstance is MoBaseMo)
            {
                var moBase = actualInstance as MoBaseMo;
                var objectType = actualInstance.GetType().GetProperty("ObjectType", BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance).GetValue(actualInstance);
                var moMoRef = new MoMoRef()
                {
                    Moid = moBase.Moid,
                    ObjectType = (MoMoRef.ObjectTypeEnum)Enum.Parse(typeof(MoMoRef.ObjectTypeEnum), objectType.ToString()),
                    ClassId = MoMoRef.ClassIdEnum.MoMoRef,
                };
                managedObject.GetType().GetProperty("ActualInstance").SetValue(managedObject, moMoRef);
            }
        }
    }
}
