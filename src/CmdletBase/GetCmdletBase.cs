using Intersight.Client;
using Intersight.Model;
using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;

namespace Intersight.PowerShell
{
    public class GetCmdletBase : CmdletBase
    {
        #region
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ParameterSetName = "CmdletParam")]
        public string Name { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]
        public OrganizationOrganizationRelationship Organization { get; set; }

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

        private List<object> result;
        #endregion

        public GetCmdletBase()
        {
        }

        protected override void BeginProcessing()
        {
            if (CmdletBase.Config == null || CmdletBase.Config.HttpSigningConfiguration == null)
            {
                throw new Exception("Intersight environment is not configured. Use the cmdlet Set-IntersightConfiguration to configure the Intersight environment it.");
            }
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
                    string queryString = null;
                    if (!string.IsNullOrEmpty(Name))
                    {
                        queryString += string.Format("Name eq \'{0}\'", Name);
                    }
                    else if (Organization != null)
                    {
                        if (Organization.ActualInstance is OrganizationOrganization)
                        {
                            OrganizationOrganization organization = Organization.ActualInstance as OrganizationOrganization;
                            queryString += string.Format("Organization/Moid eq \'{0}\'", organization.Moid);
                        }
                        else if (Organization.ActualInstance is MoMoRef)
                        {
                            MoMoRef organizationRef = Organization.ActualInstance as MoMoRef;
                            queryString += string.Format("Organization/Moid eq \'{0}\'", organizationRef.Moid);
                        }

                    }

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
    }
}
