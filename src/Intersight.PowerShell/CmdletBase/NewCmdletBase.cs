﻿using Intersight.Client;
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
                        if (propName == "Moid" || this.MyInvocation.BoundParameters[propName] == null)
                        {
                            continue;
                        }

                        item.SetValue(ModelObject, this.MyInvocation.BoundParameters[propName]);
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
    }
}
