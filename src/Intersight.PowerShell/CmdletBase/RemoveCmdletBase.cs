using Intersight.Client;
using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;
using Intersight.Api;

namespace Intersight.PowerShell
{
    public class RemoveCmdletBase : CmdletBase
    {
        #region Parameter
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true)]
        public string Moid { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false)]
        public SwitchParameter Json { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false)]
        public SwitchParameter WithHttpInfo { get; set; }
        #endregion

        public RemoveCmdletBase()
        {
        }

        protected override void ProcessRecord()
        {
            try
            {
                var methodInfo = GetMethodInfo(MethodName);
                var parameterInfo = methodInfo.GetParameters();
                List<object> argList = new List<object>();
                argList.Add(Moid);
                // Moid is already processed so looping over method parameter from index 1
                for (int i = 1; i < parameterInfo.Length; i++)
                {
                    // convert the paramter of method in pascalcase to match the powershell inuput parameter.
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
                if (Json.IsPresent)
                {
                    StringBuilder requestJson = new StringBuilder();
                    requestJson.Append(string.Format("{{\n\"Moid\" : \"{0}\"\n}}", this.Moid));
                    WriteObject(requestJson.ToString());
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

    }
}
