using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize CondAlarmSummary.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCondAlarmSummary")]
    public class InitializeIntersightCondAlarmSummary : PSCmdlet
    {
        public InitializeIntersightCondAlarmSummary()
        {
            ClassId = CondAlarmSummary.ClassIdEnum.CondAlarmSummary;
            ObjectType = CondAlarmSummary.ObjectTypeEnum.CondAlarmSummary;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CondAlarmSummary.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The count of alarms that have severity type Critical."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Critical
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CondAlarmSummary.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The count of alarms that have severity type Warning."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Warning
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.CondAlarmSummary initObject = new Intersight.Model.CondAlarmSummary();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Critical"))
            {
                initObject.Critical = this.Critical;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Warning"))
            {
                initObject.Warning = this.Warning;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize CondHclStatusDetail.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCondHclStatusDetail")]
    public class InitializeIntersightCondHclStatusDetail : PSCmdlet
    {
        public InitializeIntersightCondHclStatusDetail()
        {
            ClassId = CondHclStatusDetail.ClassIdEnum.CondHclStatusDetail;
            HardwareStatus = CondHclStatusDetail.HardwareStatusEnum.MissingOsDriverInfo;
            ObjectType = CondHclStatusDetail.ObjectTypeEnum.CondHclStatusDetail;
            Reason = CondHclStatusDetail.ReasonEnum.MissingOsDriverInfo;
            SoftwareStatus = CondHclStatusDetail.SoftwareStatusEnum.MissingOsDriverInfo;
            Status = CondHclStatusDetail.StatusEnum.Incomplete;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CondHclStatusDetail.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The model is considered as part of the hardware profile for the component. This will provide the HCL validation status for the hardware profile. The reasons can be one of the following \"Incompatible-Server-With-Component\" - the server model and component combination is not listed in HCL \"Incompatible-Firmware\" - The server's firmware is not listed for this component's hardware profile \"Incompatible-Component\" - the component's model is not listed in the HCL \"Service-Unavailable\" - HCL data service is unavailable at the moment (try again later). This could be due to HCL data updating \"Not-Evaluated\" - the hardware profile was not evaulated for the component because the server's hw/sw status is not listed or server is exempted. \"Compatible\" - this component's hardware profile is listed in the HCL.\n* `Missing-Os-Driver-Info` - The validation failed becaue the given server has no OS driver information available in the inventory. Either install ucstools vib or use power shell scripts to tag proper OS information.\n* `Incompatible-Server-With-Component` - The validation failed for this component because he server model and component model combination was not found in the HCL.\n* `Incompatible-Processor` - The validation failed because the given processor was not found for the given server PID.\n* `Incompatible-Os-Info` - The validation failed because the given OS vendor and version was not found in HCL for the server PID and processor combination.\n* `Incompatible-Component-Model` - The validation failed because the given Component model was not found in the HCL for the given server PID, processor, server Firmware and OS vendor and version.\n* `Incompatible-Firmware` - The validation failed because the given server firmware or adapter firmware was not found in the HCL for the given server PID, processor, OS vendor and version and component model.\n* `Incompatible-Driver` - The validation failed because the given driver version was not found in the HCL for the given Server PID, processor, OS vendor and version, server firmware and component firmware.\n* `Incompatible-Firmware-Driver` - The validation failed because the given component firmware and driver version was not found in the HCL for the given Server PID, processor, OS vendor and version and server firmware.\n* `Service-Unavailable` - The validation has failed because HCL data service is temporarily not available. The server will be re-evaluated once HCL data service is back online or finished importing new HCL data.\n* `Service-Error` - The validation has failed because the HCL data service has return a service error or unrecognized result.\n* `Unrecognized-Protocol` - The validation has failed for the HCL component because the HCL data service has return a validation reason that is unknown to this service. This reason is used as a default failure reason reason in case we cannot map the error reason received from the HCL data service unto one of the other enum values.\n* `Not-Evaluated` - The validation for the hardware or software HCL status was not yet evaluated because some previous validation had failed. For example if a server's hardware profile fails to validate with HCL, then the server's software status will not be evaluated.\n* `Compatible` - The validation has passed for this server PID, processor, OS vendor and version, component model, component firmware and driver version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CondHclStatusDetail.HardwareStatusEnum HardwareStatus
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The current CIMC version for the server normalized for querying HCL data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string HclCimcVersion
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The current driver name of the component we are validating normalized for querying HCL data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string HclDriverName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The current driver version of the component we are validating normalized for querying HCL data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string HclDriverVersion
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The current firmware version of the component model normalized for querying HCL data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string HclFirmwareVersion
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The component model we are trying to validate normalized for querying HCL data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string HclModel
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The current CIMC version for the server as received from inventory."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string InvCimcVersion
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The current driver name of the component we are validating as received from inventory."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string InvDriverName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The current driver version of the component we are validating as received from inventory."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string InvDriverVersion
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The current firmware version of the component model as received from inventory."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string InvFirmwareVersion
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The component model we are trying to validate as received from inventory."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string InvModel
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CondHclStatusDetail.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The reason for the status. The reason can be one of \"Incompatible-Server-With-Component\" - HCL validation has failed because the server model is not validated with this component \"Incompatible-Processor\" - HCL validation has failed because the processor is not validated with this server \"Incompatible-Os-Info\" - HCL validation has failed because the os vendor and version is not validated with this server \"Incompatible-Component-Model\" - HCL validation has failed because the component model is not validated \"Incompatible-Firmware\" - HCL validation has failed because the component or server firmware version is not validated \"Incompatible-Driver\" - HCL validation has failed because the driver version is not validated \"Incompatible-Firmware-Driver\" - HCL validation has failed because the firmware version and driver version is not validated \"Missing-Os-Driver-Info\" - HCL validation was not performed because we are missing os driver information form the inventory \"Service-Unavailable\" - HCL data service is unavailable at the moment (try again later). This could be due to HCL data updating \"Service-Error\" - HCL data service is available but an error occured when making the request or parsing the response \"Unrecognized-Protocol\" - This service does not recognize the reason code in the response from the HCL data service \"Compatible\" - this component's inventory data has \"Validated\" status with the HCL. \"Not-Evaluated\" - The component is not evaluated against the HCL because the server is exempted.\n* `Missing-Os-Driver-Info` - The validation failed becaue the given server has no OS driver information available in the inventory. Either install ucstools vib or use power shell scripts to tag proper OS information.\n* `Incompatible-Server-With-Component` - The validation failed for this component because he server model and component model combination was not found in the HCL.\n* `Incompatible-Processor` - The validation failed because the given processor was not found for the given server PID.\n* `Incompatible-Os-Info` - The validation failed because the given OS vendor and version was not found in HCL for the server PID and processor combination.\n* `Incompatible-Component-Model` - The validation failed because the given Component model was not found in the HCL for the given server PID, processor, server Firmware and OS vendor and version.\n* `Incompatible-Firmware` - The validation failed because the given server firmware or adapter firmware was not found in the HCL for the given server PID, processor, OS vendor and version and component model.\n* `Incompatible-Driver` - The validation failed because the given driver version was not found in the HCL for the given Server PID, processor, OS vendor and version, server firmware and component firmware.\n* `Incompatible-Firmware-Driver` - The validation failed because the given component firmware and driver version was not found in the HCL for the given Server PID, processor, OS vendor and version and server firmware.\n* `Service-Unavailable` - The validation has failed because HCL data service is temporarily not available. The server will be re-evaluated once HCL data service is back online or finished importing new HCL data.\n* `Service-Error` - The validation has failed because the HCL data service has return a service error or unrecognized result.\n* `Unrecognized-Protocol` - The validation has failed for the HCL component because the HCL data service has return a validation reason that is unknown to this service. This reason is used as a default failure reason reason in case we cannot map the error reason received from the HCL data service unto one of the other enum values.\n* `Not-Evaluated` - The validation for the hardware or software HCL status was not yet evaluated because some previous validation had failed. For example if a server's hardware profile fails to validate with HCL, then the server's software status will not be evaluated.\n* `Compatible` - The validation has passed for this server PID, processor, OS vendor and version, component model, component firmware and driver version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CondHclStatusDetail.ReasonEnum Reason
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The firmware, driver name and driver version are considered as part of the software profile for the component. This will provide the HCL validation status for the software profile. The reasons can be one of the following \"Incompatible-Firmware\" - the component's firmware is not listed under the server's hardware and software profile and the component's hardware profile \"Incompatible-Driver\" - the component's driver is not listed under the server's hardware and software profile and the component's hardware profile \"Incompatible-Firmware-Driver\" - the component's firmware and driver are not listed under the server's hardware and software profile and the component's hardware profile \"Service-Unavailable\" - HCL data service is unavailable at the moment (try again later). This could be due to HCL data updating \"Not-Evaluated\" - the component's hardware status was not evaluated because the server's hardware or software profile is not listed or server is exempted. \"Compatible\" - this component's hardware profile is listed in the HCL.\n* `Missing-Os-Driver-Info` - The validation failed becaue the given server has no OS driver information available in the inventory. Either install ucstools vib or use power shell scripts to tag proper OS information.\n* `Incompatible-Server-With-Component` - The validation failed for this component because he server model and component model combination was not found in the HCL.\n* `Incompatible-Processor` - The validation failed because the given processor was not found for the given server PID.\n* `Incompatible-Os-Info` - The validation failed because the given OS vendor and version was not found in HCL for the server PID and processor combination.\n* `Incompatible-Component-Model` - The validation failed because the given Component model was not found in the HCL for the given server PID, processor, server Firmware and OS vendor and version.\n* `Incompatible-Firmware` - The validation failed because the given server firmware or adapter firmware was not found in the HCL for the given server PID, processor, OS vendor and version and component model.\n* `Incompatible-Driver` - The validation failed because the given driver version was not found in the HCL for the given Server PID, processor, OS vendor and version, server firmware and component firmware.\n* `Incompatible-Firmware-Driver` - The validation failed because the given component firmware and driver version was not found in the HCL for the given Server PID, processor, OS vendor and version and server firmware.\n* `Service-Unavailable` - The validation has failed because HCL data service is temporarily not available. The server will be re-evaluated once HCL data service is back online or finished importing new HCL data.\n* `Service-Error` - The validation has failed because the HCL data service has return a service error or unrecognized result.\n* `Unrecognized-Protocol` - The validation has failed for the HCL component because the HCL data service has return a validation reason that is unknown to this service. This reason is used as a default failure reason reason in case we cannot map the error reason received from the HCL data service unto one of the other enum values.\n* `Not-Evaluated` - The validation for the hardware or software HCL status was not yet evaluated because some previous validation had failed. For example if a server's hardware profile fails to validate with HCL, then the server's software status will not be evaluated.\n* `Compatible` - The validation has passed for this server PID, processor, OS vendor and version, component model, component firmware and driver version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CondHclStatusDetail.SoftwareStatusEnum SoftwareStatus
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The status for the component model, firmware version, driver name, and driver version after validating against the HCL. The status can be one of the following \"Unknown\" - we do not have enough information to evaluate against the HCL data \"Validated\" - we have validated this component against the HCL and it has \"Validated\" status \"Not-Validated\" - we have validated this component against the HCL and it has \"Not-Validated\" status. \"Not-Evaluated\" - The component is not evaluated against the HCL because the server is exempted.\n* `Incomplete` - This means we do not have os information in Intersight for this server. Either install ucstools vib or use power shell scripts to tag proper OS information.\n* `Not-Found` - At HclStatus level, this means that one of the components has failed validation. At HclStatusDetail level, this means that his component's hardware or software profile was not found in the HCL.\n* `Not-Listed` - At the HclStatus level, this means that some part of the HCL validation has failed. This could be that either the server's hardware or software profile was not listed in the HCL or one of the components' hardware or software profile was not found in the HCL.\n* `Validated` - At the HclStatus level, this means that all of the components have passed validation. At HclStatusDetail level, this means that the component's hardware or software profile was found in the HCL.\n* `Not-Evaluated` - At the HclStatus level this means that this means that SW or Component status has not been evaluated as the previous evaluation step has not passed yet. At the HclStatusDetail level this means that either HW or SW status has not been evaluted because a previous evaluation step has not passed yet."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CondHclStatusDetail.StatusEnum Status
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.CondHclStatusDetail initObject = new Intersight.Model.CondHclStatusDetail();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("HardwareStatus"))
            {
                initObject.HardwareStatus = this.HardwareStatus;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HclCimcVersion"))
            {
                initObject.HclCimcVersion = this.HclCimcVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HclDriverName"))
            {
                initObject.HclDriverName = this.HclDriverName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HclDriverVersion"))
            {
                initObject.HclDriverVersion = this.HclDriverVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HclFirmwareVersion"))
            {
                initObject.HclFirmwareVersion = this.HclFirmwareVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HclModel"))
            {
                initObject.HclModel = this.HclModel;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InvCimcVersion"))
            {
                initObject.InvCimcVersion = this.InvCimcVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InvDriverName"))
            {
                initObject.InvDriverName = this.InvDriverName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InvDriverVersion"))
            {
                initObject.InvDriverVersion = this.InvDriverVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InvFirmwareVersion"))
            {
                initObject.InvFirmwareVersion = this.InvFirmwareVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InvModel"))
            {
                initObject.InvModel = this.InvModel;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Reason"))
            {
                initObject.Reason = this.Reason;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SoftwareStatus"))
            {
                initObject.SoftwareStatus = this.SoftwareStatus;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Status"))
            {
                initObject.Status = this.Status;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize CondAlarmAggregation.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCondAlarmAggregation")]
    public class InitializeIntersightCondAlarmAggregation : PSCmdlet
    {
        public InitializeIntersightCondAlarmAggregation()
        {
            ClassId = CondAlarmAggregation.ClassIdEnum.CondAlarmAggregation;
            Health = CondAlarmAggregation.HealthEnum.None;
            ObjectType = CondAlarmAggregation.ObjectTypeEnum.CondAlarmAggregation;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The summary of alarm counts based on the severity types (Critical or Warning)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.CondAlarmSummary AlarmSummary
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CondAlarmAggregation.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Count of all alarms with severity Critical, irrespective of acknowledgement status."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long CriticalAlarmsCount
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Health of the managed end point. The highest severity computed from alarmSummary property is set as the health.\n* `None` - The Enum value None represents that there is no severity.\n* `Info` - The Enum value Info represents the Informational level of severity.\n* `Critical` - The Enum value Critical represents the Critical level of severity.\n* `Warning` - The Enum value Warning represents the Warning level of severity.\n* `Cleared` - The Enum value Cleared represents that the alarm severity has been cleared."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CondAlarmAggregation.HealthEnum Health
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Count of all alarms with severity Info, irrespective of acknowledgement status."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long InfoAlarmsCount
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Managed object type. For example, FI managed object type will be network.Element."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string MoType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CondAlarmAggregation.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Count of all alarms with severity Warning, irrespective of acknowledgement status."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long WarningAlarmsCount
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.CondAlarmAggregation initObject = new Intersight.Model.CondAlarmAggregation();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AlarmSummary"))
            {
                initObject.AlarmSummary = this.AlarmSummary;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("CriticalAlarmsCount"))
            {
                initObject.CriticalAlarmsCount = this.CriticalAlarmsCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Health"))
            {
                initObject.Health = this.Health;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InfoAlarmsCount"))
            {
                initObject.InfoAlarmsCount = this.InfoAlarmsCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MoType"))
            {
                initObject.MoType = this.MoType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("WarningAlarmsCount"))
            {
                initObject.WarningAlarmsCount = this.WarningAlarmsCount;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize CondHclStatusJob.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCondHclStatusJob")]
    public class InitializeIntersightCondHclStatusJob : PSCmdlet
    {
        public InitializeIntersightCondHclStatusJob()
        {
            ClassId = CondHclStatusJob.ClassIdEnum.CondHclStatusJob;
            ObjectType = CondHclStatusJob.ObjectTypeEnum.CondHclStatusJob;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CondHclStatusJob.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CondHclStatusJob.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.CondHclStatusJob initObject = new Intersight.Model.CondHclStatusJob();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize CondAlarm.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCondAlarm")]
    public class InitializeIntersightCondAlarm : PSCmdlet
    {
        public InitializeIntersightCondAlarm()
        {
            Acknowledge = CondAlarm.AcknowledgeEnum.None;
            ClassId = CondAlarm.ClassIdEnum.CondAlarm;
            ObjectType = CondAlarm.ObjectTypeEnum.CondAlarm;

        }
        // <summary>
        /// <para type="description">"Alarm acknowledgment state. Default value is None.\n* `None` - The Enum value None represents that the alarm is not acknowledged and is included as part of health status and overall alarm count.\n* `Acknowledge` - The Enum value Acknowledge represents that the alarm is acknowledged by user. The alarm will be ignored from the health status and overall alarm count."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CondAlarm.AcknowledgeEnum Acknowledge
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.MoBaseMoRelationship AffectedMo
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CondAlarm.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CondAlarm.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.AssetDeviceRegistrationRelationship RegisteredDevice
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.CondAlarm initObject = new Intersight.Model.CondAlarm();
            if (this.MyInvocation.BoundParameters.ContainsKey("Acknowledge"))
            {
                initObject.Acknowledge = this.Acknowledge;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AffectedMo"))
            {
                initObject.AffectedMo = this.AffectedMo;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("RegisteredDevice"))
            {
                initObject.RegisteredDevice = this.RegisteredDevice;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize CondHclStatus.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCondHclStatus")]
    public class InitializeIntersightCondHclStatus : PSCmdlet
    {
        public InitializeIntersightCondHclStatus()
        {
            ClassId = CondHclStatus.ClassIdEnum.CondHclStatus;
            ComponentStatus = CondHclStatus.ComponentStatusEnum.Incomplete;
            HardwareStatus = CondHclStatus.HardwareStatusEnum.Incomplete;
            ObjectType = CondHclStatus.ObjectTypeEnum.CondHclStatus;
            Reason = CondHclStatus.ReasonEnum.MissingOsInfo;
            ServerReason = CondHclStatus.ServerReasonEnum.MissingOsDriverInfo;
            SoftwareStatus = CondHclStatus.SoftwareStatusEnum.Incomplete;
            Status = CondHclStatus.StatusEnum.Incomplete;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CondHclStatus.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The overall status for the components found in the HCL. This will provide the HCL validation status for all the components. It can be one of the following. \"Validated\" - all the components hardware/software profiles are listed in the HCL. \"Not-Listed\" - one or more components hardware/software profiles are not listed in the HCL \"Incomplete\" - the components are not evaluated as the server's software/hardware profiles are not listed in the HCL. \"Not-Evaluated\" - The components are not evaluated against the HCL because it is exempted.\n* `Incomplete` - This means we do not have os information in Intersight for this server. Either install ucstools vib or use power shell scripts to tag proper OS information.\n* `Not-Found` - At HclStatus level, this means that one of the components has failed validation. At HclStatusDetail level, this means that his component's hardware or software profile was not found in the HCL.\n* `Not-Listed` - At the HclStatus level, this means that some part of the HCL validation has failed. This could be that either the server's hardware or software profile was not listed in the HCL or one of the components' hardware or software profile was not found in the HCL.\n* `Validated` - At the HclStatus level, this means that all of the components have passed validation. At HclStatusDetail level, this means that the component's hardware or software profile was found in the HCL.\n* `Not-Evaluated` - At the HclStatus level this means that this means that SW or Component status has not been evaluated as the previous evaluation step has not passed yet. At the HclStatusDetail level this means that either HW or SW status has not been evaluted because a previous evaluation step has not passed yet."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CondHclStatus.ComponentStatusEnum ComponentStatus
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The server model, processor and firmware are considered as part of the hardware profile for the server. This will provide the HCL validation status for the hardware profile. For the failure reason see the serverReason property. The status can be one of the following \"Validated\" - The server model, processor and firmware combination is listed in the HCL \"Not-Listed\" - The server model, processor and firmware combination is not listed in the HCL. \"Not-Evaluated\" - The server is not evaluated against the HCL because it is exempted.\n* `Incomplete` - This means we do not have os information in Intersight for this server. Either install ucstools vib or use power shell scripts to tag proper OS information.\n* `Not-Found` - At HclStatus level, this means that one of the components has failed validation. At HclStatusDetail level, this means that his component's hardware or software profile was not found in the HCL.\n* `Not-Listed` - At the HclStatus level, this means that some part of the HCL validation has failed. This could be that either the server's hardware or software profile was not listed in the HCL or one of the components' hardware or software profile was not found in the HCL.\n* `Validated` - At the HclStatus level, this means that all of the components have passed validation. At HclStatusDetail level, this means that the component's hardware or software profile was found in the HCL.\n* `Not-Evaluated` - At the HclStatus level this means that this means that SW or Component status has not been evaluated as the previous evaluation step has not passed yet. At the HclStatusDetail level this means that either HW or SW status has not been evaluted because a previous evaluation step has not passed yet."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CondHclStatus.HardwareStatusEnum HardwareStatus
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The current CIMC version for the server normalized for querying HCL data. It is empty if we are missing this information."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string HclFirmwareVersion
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The managed object's model to validate normalized for querying HCL data. It is empty if we are missing this information."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string HclModel
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The OS Vendor for the managed object to validate normalized for querying HCL data. It is empty if we are missing this information."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string HclOsVendor
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The OS Version for the managed object to validate normalized for querying HCL data. It is empty if we are missing this information."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string HclOsVersion
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The managed object's processor to validate if applicable normalized for querying HCL data. It is empty if we are missing this information."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string HclProcessor
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The current CIMC version for the server as received from inventory. It is empty if we are missing this information."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string InvFirmwareVersion
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The managed object's model to validate as received from the inventory. It is empty if we are missing this information."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string InvModel
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The OS Vendor for the managed object to validate as received from inventory. It is empty if we are missing this information."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string InvOsVendor
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The OS Version for the managed object to validate as received from inventory. It is empty if we are missing this information."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string InvOsVersion
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The managed object's processor to validate if applicable as received from inventory. It is empty if we are missing this information."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string InvProcessor
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CondHclStatus.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The reason for the HCL status. It will be one of the following \"Missing-Os-Info\" - we are missing os information in the inventory from the device connector \"Incompatible-Components\" - we have 1 or more components with \"Not-Validated\" status \"Compatible\" - all the components have \"Validated\" status. \"Not-Evaluated\" - The server is not evaluated against the HCL because it is exempted.\n* `Missing-Os-Info` - This means the HclStatus for the sever failed HCL validation because we have missing os information. Either install ucstools vib or use power shell scripts to tag proper OS information.\n* `Incompatible-Components` - This means the HclStatus for the sever failed HCL validation because one or more of its components failed validation. To see why components failed check the related HclStatusDetails.\n* `Compatible` - This means the HclStatus for the sever has passed HCL validation for all of its related components.\n* `Not-Evaluated` - This means the HclStatus for the sever has not been evaluated because it is exempted."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CondHclStatus.ReasonEnum Reason
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The reason generated by the server's HCL validation. For HCL the evaluation can be seen in three logical stages 1. Evaluate the server's hardware status 2. Evaluate the server's software status 3. Evaluate the server's components (each component has its own hardware/software evaluation) The evaluation does not proceed to the next stage until the previous stage is evaluated. Therefore there can be only one validation reason. \"Incompatible-Server\" - the server model is not listed in the HCL. \"Incompatible-Processor\" - the server model and processor combination is not listed in HCL. \"Incompatible-Firmware\" - the server model, processor and server firmware is not listed in HCL. \"Missing-Os-Info\" - the os vendor and version is not listed in HCL with the HW profile. \"Incompatible-Os-Info\" - the os vendor and version is not listed in HCL with the HW profile. \"Incompatible-Components\" - there is one or more components with \"Not-Validated\" status \"Service-Unavailable\" - HCL data service is unavailable at the moment (try again later). \"Compatible\" - the server and all its components are validated. \"Not-Evaluated\" - The server is not evaluated against the HCL because it is exempted.\n* `Missing-Os-Driver-Info` - The validation failed becaue the given server has no OS driver information available in the inventory. Either install UCS Tools VIB on the host ESXi or use OS Discovery Tool scripts to provide proper OS information.\n* `Incompatible-Server` - The validation failed for this server because the server's model was not listed in the HCL.\n* `Incompatible-Processor` - The validation failed because the given processor was not listed for the given server model.\n* `Incompatible-Os-Info` - The validation failed because the given OS vendor or version was not listed in HCL for the server PID and processor combination.\n* `Incompatible-Firmware` - The validation failed because the given server firmware was not listed in the HCL for the given server PID, processor, OS vendor and version.\n* `Service-Unavailable` - The validation has failed because HCL data service is temporarily not available. The server will be re-evaluated once HCL data service is back online or finished importing new HCL data.\n* `Service-Error` - The validation has failed because the HCL data service has returned a service error or unrecognized result.\n* `Not-Evaluated` - This means the HclStatus for the sever has not been evaluated because it is exempted.\n* `Incompatible-Components` - The validation has failed for this server because one or more components have \"Not-Listed\" status.\n* `Compatible` - The validation has passed for this server's model, processor, OS vendor and version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CondHclStatus.ServerReasonEnum ServerReason
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The OS vendor and version are considered part of the software profile for the server. This will provide the HCL validation status for the software profile. For the failure reason see the serverReason property. The status can be be one of the following \"Validated\" - The os vendor/version is listed in the HCL for the server model, processor and firmware \"Not-Listed\" - The os vendor/version is not listed in the HCL for the server model, processor and firmware \"Incomplete\" - The inventory is missing os vendor/version and HCL validation was not performed. \"Not-Evaluated\" - The server is not evaluated against the HCL because it is exempted.\n* `Incomplete` - This means we do not have os information in Intersight for this server. Either install ucstools vib or use power shell scripts to tag proper OS information.\n* `Not-Found` - At HclStatus level, this means that one of the components has failed validation. At HclStatusDetail level, this means that his component's hardware or software profile was not found in the HCL.\n* `Not-Listed` - At the HclStatus level, this means that some part of the HCL validation has failed. This could be that either the server's hardware or software profile was not listed in the HCL or one of the components' hardware or software profile was not found in the HCL.\n* `Validated` - At the HclStatus level, this means that all of the components have passed validation. At HclStatusDetail level, this means that the component's hardware or software profile was found in the HCL.\n* `Not-Evaluated` - At the HclStatus level this means that this means that SW or Component status has not been evaluated as the previous evaluation step has not passed yet. At the HclStatusDetail level this means that either HW or SW status has not been evaluted because a previous evaluation step has not passed yet."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CondHclStatus.SoftwareStatusEnum SoftwareStatus
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The HCL compatibility status of the managed object. The status can be one of the following \"Incomplete\" - there is no enough information to evaluate against the HCL data \"Validated\" - all components have been evaluated against the HCL and they all have \"Validated\" status \"Not-Listed\" - all components have been evaluated against the HCL and one or more have \"Not-Listed\" status. \"Not-Evaluated\" - server is not evaluated against the HCL because it is exempted.\n* `Incomplete` - This means we do not have os information in Intersight for this server. Either install ucstools vib or use power shell scripts to tag proper OS information.\n* `Not-Found` - At HclStatus level, this means that one of the components has failed validation. At HclStatusDetail level, this means that his component's hardware or software profile was not found in the HCL.\n* `Not-Listed` - At the HclStatus level, this means that some part of the HCL validation has failed. This could be that either the server's hardware or software profile was not listed in the HCL or one of the components' hardware or software profile was not found in the HCL.\n* `Validated` - At the HclStatus level, this means that all of the components have passed validation. At HclStatusDetail level, this means that the component's hardware or software profile was found in the HCL.\n* `Not-Evaluated` - At the HclStatus level this means that this means that SW or Component status has not been evaluated as the previous evaluation step has not passed yet. At the HclStatusDetail level this means that either HW or SW status has not been evaluted because a previous evaluation step has not passed yet."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CondHclStatus.StatusEnum Status
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.CondHclStatus initObject = new Intersight.Model.CondHclStatus();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ComponentStatus"))
            {
                initObject.ComponentStatus = this.ComponentStatus;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HardwareStatus"))
            {
                initObject.HardwareStatus = this.HardwareStatus;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HclFirmwareVersion"))
            {
                initObject.HclFirmwareVersion = this.HclFirmwareVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HclModel"))
            {
                initObject.HclModel = this.HclModel;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HclOsVendor"))
            {
                initObject.HclOsVendor = this.HclOsVendor;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HclOsVersion"))
            {
                initObject.HclOsVersion = this.HclOsVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HclProcessor"))
            {
                initObject.HclProcessor = this.HclProcessor;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InvFirmwareVersion"))
            {
                initObject.InvFirmwareVersion = this.InvFirmwareVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InvModel"))
            {
                initObject.InvModel = this.InvModel;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InvOsVendor"))
            {
                initObject.InvOsVendor = this.InvOsVendor;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InvOsVersion"))
            {
                initObject.InvOsVersion = this.InvOsVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InvProcessor"))
            {
                initObject.InvProcessor = this.InvProcessor;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Reason"))
            {
                initObject.Reason = this.Reason;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ServerReason"))
            {
                initObject.ServerReason = this.ServerReason;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SoftwareStatus"))
            {
                initObject.SoftwareStatus = this.SoftwareStatus;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Status"))
            {
                initObject.Status = this.Status;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
}