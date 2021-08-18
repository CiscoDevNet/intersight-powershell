using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get CondHclStatus.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightCondHclStatus", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightCondHclStatus:GetCmdletBase
	{
		public GetIntersightCondHclStatus()
		{
			ApiInstance = new CondApi(Config);
            MethodName = "GetCondHclStatusListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get CondHclStatusJob.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightCondHclStatusJob", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightCondHclStatusJob:GetCmdletBase
	{
		public GetIntersightCondHclStatusJob()
		{
			ApiInstance = new CondApi(Config);
            MethodName = "GetCondHclStatusJobListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set CondAlarm.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightCondAlarm")]
    public class SetIntersightCondAlarm:SetCmdletBase
	{
		public SetIntersightCondAlarm()
		{
			ApiInstance = new CondApi(Config);
            ModelObject = new CondAlarm();
            MethodName = "PatchCondAlarmWithHttpInfo";
		}
        // <summary>
        /// <para type="description">"Alarm acknowledgment state. Default value is None.\n* `None` - The Enum value None represents that the alarm is not acknowledged and is included as part of health status and overall alarm count.\n* `Acknowledge` - The Enum value Acknowledge represents that the alarm is acknowledged by user. The alarm will be ignored from the health status and overall alarm count."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public CondAlarm.AcknowledgeEnum Acknowledge {
            get;
            set;
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
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public MoBaseMoRelationship AffectedMo {
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
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetDeviceRegistrationRelationship RegisteredDevice {
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
    /// <para type="synopsis">This is the cmdlet to Get CondAlarm.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightCondAlarm", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightCondAlarm:GetCmdletBase
	{
		public GetIntersightCondAlarm()
		{
			ApiInstance = new CondApi(Config);
            MethodName = "GetCondAlarmListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get CondAlarmAggregation.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightCondAlarmAggregation", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightCondAlarmAggregation:GetCmdletBase
	{
		public GetIntersightCondAlarmAggregation()
		{
			ApiInstance = new CondApi(Config);
            MethodName = "GetCondAlarmAggregationListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get CondHclStatusDetail.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightCondHclStatusDetail", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightCondHclStatusDetail:GetCmdletBase
	{
		public GetIntersightCondHclStatusDetail()
		{
			ApiInstance = new CondApi(Config);
            MethodName = "GetCondHclStatusDetailListWithHttpInfo";
		}
    }
}