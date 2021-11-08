using Intersight.Client;
using Intersight.Model;
using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;
using System.Reflection;
using System.Runtime.Serialization;


namespace Intersight.PowerShell
{
    public class GetCmdletBase : CmdletBase
    {
        #region
        
        [Parameter(Mandatory = false, ParameterSetName = "QueryParam")]
        public bool? Count { get; set; } = null;

        [Parameter(Mandatory = false, ParameterSetName = "QueryParam")]
        [ValidateSet("allpages", "none")]
        public string InlineCount { get; set; } = null;

        [Parameter(Mandatory = false, ParameterSetName = "QueryParam")]
        public string Select { get; set; } = null;

        [Parameter(Mandatory = false, ParameterSetName = "QueryParam")]
        public string Filter { get; set; } = null;

        [Parameter(Mandatory = false, ParameterSetName = "QueryParam")]
        public string Expand { get; set; } = null;

        [Parameter(Mandatory = false, ParameterSetName = "QueryParam")]
        public int? Skip { get; set; } = null;

        [Parameter(Mandatory = false, ParameterSetName = "QueryParam")]
        public int? Top { get; set; } = null;

        [Parameter(Mandatory = false, ParameterSetName = "QueryParam")]
        public string At { get; set; } = null;

        [Parameter(Mandatory = false, ParameterSetName = "QueryParam")]
        public string Orderby { get; set; } = null;

        [Parameter(Mandatory = false, ParameterSetName = "QueryParam")]
        public string Apply { get; set; } = null;

        [Parameter(Mandatory = false, ParameterSetName = "QueryParam")]
        public string Tag { get; set; } = null;

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false)]
		public SwitchParameter Json { get; set; }

		[Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false)]
		public SwitchParameter WithHttpInfo { get; set; }

        private List<object> result;
        #endregion

        public GetCmdletBase()
        {
            result = new List<object>();
        }

        protected override void ProcessRecord()
        {
            try
            {
                var methodInfo = GetMethodInfo(MethodName);
                Object[] argList = null;
                if (this.ParameterSetName.Equals("CmdletParam", StringComparison.OrdinalIgnoreCase))
                {
                    var queryString = CreateFilterQuery();
                    argList = new object[] { queryString, null, null, null, null, null, null, null, null, null, null };

                }
                else if (this.ParameterSetName.Equals("QueryParam", StringComparison.OrdinalIgnoreCase))
                {
                    argList = new object[] { Filter, Orderby, Top, Skip, Select, Expand, Apply, Count, InlineCount, At, Tag };
                }
                
                var methodResult = methodInfo.Invoke(ApiInstance, argList);
                
                if (Json.IsPresent)
                {
                    WriteResponseJson(methodResult);
                }
                else if(WithHttpInfo.IsPresent)
				{
					WriteObject(methodResult);
				}
                else
                {
                    methodResult = WriteResponseData(methodResult, false);
                    var propertyInfo = methodResult.GetType().GetProperty("ActualInstance");
                    Object actualInstanceVal = propertyInfo.GetValue(methodResult);

                    if (this.ParameterSetName.Equals("QueryParam", StringComparison.OrdinalIgnoreCase))
                    {
                        WriteObject(actualInstanceVal);
                    }
                    else
                    {
                        var actualResult = actualInstanceVal.GetType().GetProperty("Results").GetValue(actualInstanceVal);
                        List<Object> collection = new List<Object>((IEnumerable<Object>)actualResult);
                        if (result != null)
                        {
                            result.AddRange(collection);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex.InnerException ?? ex;
            }
        }

        protected override void EndProcessing()
        {
            if (result != null && result.Count > 0)
            {
                if (result.Count == 1)
                {
                    WriteObject(result[0]);
                }
                else
                {
                    WriteObject(result.ToArray(), true);
                }
            }
        }

        private string CreateFilterQuery()
        {
            StringBuilder queryString = new StringBuilder();
            int i = 0;
            foreach(var item in  this.MyInvocation.BoundParameters)
            {
                
                if(item.Value != null && item.Value.GetType().Name == "SwitchParameter")
                {
                    continue;
                }

                if (i != 0)
                {
                    queryString.Append(" and ");
                }

                if (item.Value != null &&  item.Value.GetType().Name.EndsWith("Relationship"))
                {
                    var actualInstance = item.Value.GetType().GetProperty("ActualInstance").GetValue(item.Value);
                    if (actualInstance != null)
                    {
                        var moid = actualInstance.GetType().GetProperty("Moid").GetValue(actualInstance);
                        queryString.Append(string.Format("{0}/Moid eq \'{1}\'", item.Key, moid));
                    }

                }
                else if (item.Value != null &&  item.Value.GetType().Name == "Boolean")
                {
                    queryString.Append(string.Format("{0} eq {1}", item.Key, item.Value.ToString().ToLower()));
                }
                else if (item.Value != null && item.Value.GetType().Name.EndsWith("Enum"))
                {
                    string enumValue = item.Value.ToString();
                    if (item.Value.ToString().StartsWith("NUMBER_"))
                    {
                        var tempList = item.Value.ToString().Split("_");
                        int tempVal;
                        if(tempList.Length == 2 && int.TryParse(tempList[1],out tempVal))
                        {
                            enumValue = tempList[1];
                            queryString.Append(string.Format("{0} eq {1}", item.Key, enumValue));
                        }
                        else
                        {
                            queryString.Append(string.Format("{0} eq \'{1}\'", item.Key, enumValue));
                        }
                        
                    }
                    else
                    {
                        FieldInfo info = item.Value.GetType().GetField(item.Value.ToString());
                        EnumMemberAttribute[] attributes = (EnumMemberAttribute[])info.GetCustomAttributes(typeof(EnumMemberAttribute), false);
                        if (attributes != null && attributes.Length > 0)
                        {
                            enumValue = attributes[0].Value;
                        }
                        queryString.Append(string.Format("{0} eq \'{1}\'", item.Key, enumValue));
                    }
                }
                else if (item.Value != null && item.Value.GetType().Name == "DateTime")
                {
                    var tempDate = (DateTime)item.Value;
                    queryString.Append(string.Format("{0} eq {1}", item.Key, tempDate.ToUniversalTime().ToString("o")));
                }
                else if (item.Value != null && item.Value.GetType().Name == "String")
                {
                    queryString.Append(string.Format("{0} eq \'{1}\'", item.Key, item.Value));
                }
                else
                {
                    queryString.Append(string.Format("{0} eq {1}", item.Key, item.Value));
                }
                              
                i++;
            }
            return queryString.ToString();
        }
    }
}
