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
        public int? Top { get; set; } = Constants.MaxTop;

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

        private object ActualInstanceResult;

        private object WithHttpInfoResponse;
        #endregion

        public GetCmdletBase()
        {

        }

        protected override void ProcessRecord()
        {
            try
            {
                var methodInfo = GetMethodInfo(MethodName);
                var parameterInfo = methodInfo.GetParameters();
                var argList = new List<object>();

                for (int i = 0; i < parameterInfo.Length; i++)
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
                        if (this.ParameterSetName == Constants.CmdletParam)
                        {
                            if (parameNameInPascalCase == Constants.Top)
                            {
                                argList.Add(Constants.MaxTop);
                            }
                            else if (parameNameInPascalCase == Constants.Filter)
                            {
                                argList.Add(CreateFilterQuery());
                            }
                            else if (parameNameInPascalCase == Constants.InlineCount)
                            {
                                argList.Add("allpages");
                            }
                            else
                            {
                                argList.Add(parameterInfo[i].DefaultValue);
                            }
                        }
                        else
                        {
                            argList.Add(parameterInfo[i].DefaultValue);
                        }
                    }
                    else
                    {
                        argList.Add(null);
                    }
                }

                WriteVerbose(String.Format("Invoking {0}", ApiInstance.GetType().Name));
                var getResult = methodInfo.Invoke(ApiInstance, argList.ToArray());

                // check if either of the switch parameter is specified then return only first 1000 objects.
                if (Json.IsPresent || WithHttpInfo.IsPresent)
                {
                    WithHttpInfoResponse = getResult;
                    return;
                }
                StoreResult(getResult);

                if (this.ParameterSetName != Constants.QueryParam)
                {
                    var TotalObjectCount = GetObjectCount(getResult);
                    WriteVerbose(String.Format("Total Count {0}", TotalObjectCount));
                    var fetchedObjectCount = GetFetchedObjectCount(getResult);
                    WriteVerbose(string.Format("{0} objects fetched", fetchedObjectCount));

                    if (TotalObjectCount > fetchedObjectCount)
                    {
                        getPaginatedResult(methodInfo, argList.ToArray(), TotalObjectCount, fetchedObjectCount);
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
            if (Json.IsPresent || WithHttpInfo.IsPresent)
            {
                if (WithHttpInfo.IsPresent)
                {
                    WriteObject(WithHttpInfoResponse);
                }
                else
                {
                    WriteResponseJson(WithHttpInfoResponse);
                }
                return;
            }

            if (ActualInstanceResult == null)
            {
                return;
            }

            if (this.ParameterSetName == Constants.QueryParam)
            {
                WriteObject(ActualInstanceResult);
            }
            else if (this.ParameterSetName == Constants.CmdletParam)
            {
                var actualResult = ActualInstanceResult.GetType().GetProperty(Constants.Results).GetValue(ActualInstanceResult);
                var collection = new List<Object>((IEnumerable<Object>)actualResult);
                if (collection.Count == 1)
                {
                    WriteObject(collection[0]);
                }
                else
                {
                    WriteObject(collection.ToArray(), true);
                }
            }
        }

        private string CreateFilterQuery()
        {
            StringBuilder queryString = new StringBuilder();
            int i = 0;
            foreach (var item in this.MyInvocation.BoundParameters)
            {

                if (item.Value != null && item.Value.GetType().Name == "SwitchParameter")
                {
                    continue;
                }

                if (i != 0)
                {
                    queryString.Append(" and ");
                }

                if (item.Value != null && item.Value.GetType().Name.EndsWith("Relationship"))
                {
                    var actualInstance = item.Value.GetType().GetProperty("ActualInstance").GetValue(item.Value);
                    if (actualInstance != null)
                    {
                        var moid = actualInstance.GetType().GetProperty("Moid").GetValue(actualInstance);
                        queryString.Append(string.Format("{0}/Moid eq \'{1}\'", item.Key, moid));
                    }

                }
                else if (item.Value != null && item.Value.GetType().Name == "Boolean")
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
                        if (tempList.Length == 2 && int.TryParse(tempList[1], out tempVal))
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

        // Get Paginated result if the total number of object is more than 1000. it can fetched maximum 10000 objects or as per
        // NUMBER_OF_PAGE configured.
        private void getPaginatedResult(MethodInfo methodInfo, object[] argList, int totalObjectCount, int fetchedObjectCount)
        {
            WriteVerbose(string.Format("Fetching  {0} objects out of {1}", Math.Min(Constants.MaxTop * Constants.NUMBER_OF_PAGE, totalObjectCount), totalObjectCount));
            for (int i = 1; i < Constants.NUMBER_OF_PAGE; i++)
            {
                if (fetchedObjectCount >= totalObjectCount)
                {
                    break;
                }

                // set the skip query parameter
                argList[3] = fetchedObjectCount;
                var getResult = methodInfo.Invoke(ApiInstance, argList);
                fetchedObjectCount += GetFetchedObjectCount(getResult);
                StoreResult(getResult);
                WriteVerbose(string.Format("Fetched {0} Objects", fetchedObjectCount));

            }
        }

        // Store the result
        private void StoreResult(object responseObject)
        {
            var tempResult = WriteResponseData(responseObject, false);
            var actualInstancePropInfo = tempResult.GetType().GetProperty(Constants.ActualInstance);
            var actualInstanceVal = actualInstancePropInfo.GetValue(tempResult);
            var objectTypeValue = actualInstanceVal.GetType().GetProperty("ObjectType").GetValue(actualInstanceVal)?.ToString();
            if (objectTypeValue == "mo.DocumentCount")
            {
                ActualInstanceResult = actualInstanceVal;
                return;
            }
            var actualResult = actualInstanceVal.GetType().GetProperty(Constants.Results).GetValue(actualInstanceVal);

            if (ActualInstanceResult != null)
            {
                var resultPropInfo = ActualInstanceResult.GetType().GetProperty(Constants.Results);
                var tempR = resultPropInfo.GetValue(ActualInstanceResult);
                var addMethodInfo = tempR.GetType().GetMethod("AddRange");
                addMethodInfo.Invoke(tempR, new object[] { actualResult });
            }
            else
            {
                ActualInstanceResult = actualInstanceVal;
            }
        }

        // Gets the Count Value from API response
        private int GetObjectCount(object ResponseObject)
        {
            var tempResult = WriteResponseData(ResponseObject, false);
            var actualInstancePropInfo = tempResult.GetType().GetProperty(Constants.ActualInstance);
            if (actualInstancePropInfo != null)
            {
                var actualInstanceVal = actualInstancePropInfo.GetValue(tempResult);
                int count = (int)actualInstanceVal.GetType().GetProperty(Constants.Count).GetValue(actualInstanceVal, null);
                return count;
            }
            return -1;
        }

        // Get the count of actual fetched objects
        private int GetFetchedObjectCount(object ResponseObject)
        {
            var tempResult = WriteResponseData(ResponseObject, false);
            var actualInstancePropInfo = tempResult.GetType().GetProperty(Constants.ActualInstance);
            if (actualInstancePropInfo != null)
            {
                var actualInstanceVal = actualInstancePropInfo.GetValue(tempResult);
                var objectTypeValue = actualInstanceVal.GetType().GetProperty("ObjectType").GetValue(actualInstanceVal)?.ToString();
                if (objectTypeValue == "mo.DocumentCount")
                {
                    return -1;
                }
                var innerResult = actualInstanceVal.GetType().GetProperty(Constants.Results).GetValue(actualInstanceVal, null);
                var collection = new List<Object>((IEnumerable<Object>)innerResult);
                return collection.Count;
            }

            return -1;
        }
    }
}