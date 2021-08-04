using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get IaasUcsdInfo.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightIaasUcsdInfo", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightIaasUcsdInfo:GetCmdletBase
	{
		public GetIntersightIaasUcsdInfo()
		{
			ApiInstance = new IaasApi(Config);
            MethodName = "GetIaasUcsdInfoListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get IaasLicenseInfo.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightIaasLicenseInfo", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightIaasLicenseInfo:GetCmdletBase
	{
		public GetIntersightIaasLicenseInfo()
		{
			ApiInstance = new IaasApi(Config);
            MethodName = "GetIaasLicenseInfoListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get IaasConnectorPack.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightIaasConnectorPack", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightIaasConnectorPack:GetCmdletBase
	{
		public GetIntersightIaasConnectorPack()
		{
			ApiInstance = new IaasApi(Config);
            MethodName = "GetIaasConnectorPackListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get IaasServiceRequest.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightIaasServiceRequest", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightIaasServiceRequest:GetCmdletBase
	{
		public GetIntersightIaasServiceRequest()
		{
			ApiInstance = new IaasApi(Config);
            MethodName = "GetIaasServiceRequestListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get IaasMostRunTasks.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightIaasMostRunTasks", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightIaasMostRunTasks:GetCmdletBase
	{
		public GetIntersightIaasMostRunTasks()
		{
			ApiInstance = new IaasApi(Config);
            MethodName = "GetIaasMostRunTasksListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get IaasUcsdManagedInfra.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightIaasUcsdManagedInfra", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightIaasUcsdManagedInfra:GetCmdletBase
	{
		public GetIntersightIaasUcsdManagedInfra()
		{
			ApiInstance = new IaasApi(Config);
            MethodName = "GetIaasUcsdManagedInfraListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get IaasDiagnosticMessages.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightIaasDiagnosticMessages", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightIaasDiagnosticMessages:GetCmdletBase
	{
		public GetIntersightIaasDiagnosticMessages()
		{
			ApiInstance = new IaasApi(Config);
            MethodName = "GetIaasDiagnosticMessagesListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set IaasUcsdInfo.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightIaasUcsdInfo")]
    public class SetIntersightIaasUcsdInfo:SetCmdletBase
	{
		public SetIntersightIaasUcsdInfo()
		{
			ApiInstance = new IaasApi(Config);
            ModelObject = new IaasUcsdInfo();
            MethodName = "UpdateIaasUcsdInfoWithHttpInfo";
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove IaasUcsdInfo.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightIaasUcsdInfo")]
    public class RemoveIntersightIaasUcsdInfo:RemoveCmdletBase
	{
		public RemoveIntersightIaasUcsdInfo()
		{
			ApiInstance = new IaasApi(Config);
            MethodName = "DeleteIaasUcsdInfoWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get IaasDeviceStatus.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightIaasDeviceStatus", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightIaasDeviceStatus:GetCmdletBase
	{
		public GetIntersightIaasDeviceStatus()
		{
			ApiInstance = new IaasApi(Config);
            MethodName = "GetIaasDeviceStatusListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get IaasUcsdMessages.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightIaasUcsdMessages", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightIaasUcsdMessages:GetCmdletBase
	{
		public GetIntersightIaasUcsdMessages()
		{
			ApiInstance = new IaasApi(Config);
            MethodName = "GetIaasUcsdMessagesListWithHttpInfo";
		}
    }
}