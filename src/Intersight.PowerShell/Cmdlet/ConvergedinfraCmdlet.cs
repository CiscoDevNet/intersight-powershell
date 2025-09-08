using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get ConvergedinfraAdapterComplianceDetails.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightConvergedinfraAdapterComplianceDetails", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightConvergedinfraAdapterComplianceDetails : GetCmdletBase
    {
        public GetIntersightConvergedinfraAdapterComplianceDetails()
        {
            ApiInstance = new ConvergedinfraApi(Config);
            MethodName = "GetConvergedinfraAdapterComplianceDetailsListWithHttpInfo";
        }

        // <summary>
        /// <para type="description">"The Account ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string AccountMoid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a adapterUnit resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public AdapterUnitRelationship Adapter
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"The time when this managed object was created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime CreateTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The DomainGroup ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string DomainGroupMoid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The driver name (e.g. nenic, nfnic) of the adapter."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string DriverName
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The driver version of the adapter."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string DriverVersion
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The firmware version of the adapter."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Firmware
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The HCL compatibility status for the adapter.\n* `NotEvaluated` - The interoperability compliance for the component has not be checked.\n* `Approved` - The component is valid as per the interoperability compliance check.\n* `NotApproved` - The component is not valid as per the interoperability compliance check.\n* `Incomplete` - The interoperability compliance check could not be completed for the component due to incomplete data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public ConvergedinfraAdapterComplianceDetails.HclStatusEnum HclStatus
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The reason for the HCL status when it is not Approved.\n* `Missing-Os-Driver-Info` - The validation failed becaue the given server has no OS driver information available in the inventory. Either install ucstools vib or use power shell scripts to tag proper OS information.\n* `Incompatible-Server-With-Component` - The validation failed for this component because he server model and component model combination was not found in the HCL.\n* `Incompatible-Processor` - The validation failed because the given processor was not found for the given server PID.\n* `Incompatible-Os-Info` - The validation failed because the given OS vendor and version was not found in HCL for the server PID and processor combination.\n* `Incompatible-Component-Model` - The validation failed because the given Component model was not found in the HCL for the given server PID, processor, server Firmware and OS vendor and version.\n* `Incompatible-Firmware` - The validation failed because the given server firmware or adapter firmware was not found in the HCL for the given server PID, processor, OS vendor and version and component model.\n* `Incompatible-Driver` - The validation failed because the given driver version was not found in the HCL for the given Server PID, processor, OS vendor and version, server firmware and component firmware.\n* `Incompatible-Firmware-Driver` - The validation failed because the given component firmware and driver version was not found in the HCL for the given Server PID, processor, OS vendor and version and server firmware.\n* `Service-Unavailable` - The validation has failed because HCL data service is temporarily not available. The server will be re-evaluated once HCL data service is back online or finished importing new HCL data.\n* `Service-Error` - The validation has failed because the HCL data service has return a service error or unrecognized result.\n* `Unrecognized-Protocol` - The validation has failed for the HCL component because the HCL data service has return a validation reason that is unknown to this service. This reason is used as a default failure reason reason in case we cannot map the error reason received from the HCL data service unto one of the other enum values.\n* `Not-Evaluated` - The validation for the hardware or software HCL status was not yet evaluated because some previous validation had failed. For example if a server's hardware profile fails to validate with HCL, then the server's software status will not be evaluated.\n* `Compatible` - The validation has passed for this server PID, processor, OS vendor and version, component model, component firmware and driver version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public ConvergedinfraAdapterComplianceDetails.HclStatusReasonEnum HclStatusReason
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The time when this managed object was last modified."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime ModTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The model information of the adapter."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Model
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Moid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The name of the component for which the compliance is evaluated."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Name
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public MoBaseMoRelationship Parent
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Reason for the status, when the status is Incomplete or NotApproved. Reason should help to identify the component that is not compliant.\n* `NotEvaluated` - The validation for the HCL or Interop status is yet to be performed.\n* `Missing-Os-Info` - This means the Interop status for the sever cannot be computed because we have missing OS information. Either install ucstools vib or use power shell scripts to tag proper OS information.\n* `Incompatible-Storage-Os` - The validation failed because the given storage name and version combination is not found in Interop matrix.\n* `Incompatible-Os-Info` - The validation failed because the given OS name and version combination is not found in HCL.\n* `Incompatible-Processor` - The validation failed because the given processor is not found for the given server PID in HCL.\n* `Incompatible-Server-Platform` - The validation failed because the given server platform is not found in the Interop matrix.\n* `Incompatible-Server-Model` - The validation failed because the given server model is not found in the Interop matrix.\n* `Incompatible-Adapter-Model` - The validation failed because the given adapter model is not found in the Interop matrix.\n* `Incompatible-Switch-Model` - The validation failed because the given switch model is not found in the Interop matrix.\n* `Incompatible-Server-Firmware` - The validation failed because the given server firmware version is not found in HCL.\n* `Incompatible-Switch-Firmware` - The validation failed because the given switch firmware version is not found in Interop matrix.\n* `Incompatible-Firmware` - The validation failed because the given adapter firmware version is not found in either HCL or Interop matrix.\n* `Incompatible-Driver` - The validation failed because the given driver version is not found in either HCL or Interop matrix.\n* `Incompatible-Firmware-Driver` - The validation failed because the given adapter firmware and driver version is not found in either HCL or Interop matrix.\n* `Missing-Os-Driver-Info` - The validation failed because the given server has no OS driver information available in the inventory. Either install ucstools vib or use power shell scripts to tag proper OS information.\n* `Missing-Os-Or-Driver-Info` - This means the Interop status for the switch or storage array cannot be computed because we have either missing Host OS information or missing required driver information. Either install ucstools vib or use power shell scripts to tag proper OS information or install required drivers.\n* `Incompatible-Components` - The validation failed for the given server because one or more of its components failed validation.\n* `Compatible` - This means the HCL status and Interop status for the component have passed all validations for all of its related components."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public ConvergedinfraAdapterComplianceDetails.ReasonEnum Reason
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a convergedinfraServerComplianceDetails resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public ConvergedinfraServerComplianceDetailsRelationship ServerComplianceDetails
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Intersight provides pre-built workflows, tasks and policies to end users through global catalogs.\nObjects that are made available through global catalogs are said to have a 'shared' ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SharedScope
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Compliance status for the component.\n* `NotEvaluated` - The interoperability compliance for the component has not be checked.\n* `Approved` - The component is valid as per the interoperability compliance check.\n* `NotApproved` - The component is not valid as per the interoperability compliance check.\n* `Incomplete` - The interoperability compliance check could not be completed for the component due to incomplete data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public ConvergedinfraAdapterComplianceDetails.StatusEnum Status
        {
            get;
            set;
        }





    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get ConvergedinfraPod.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightConvergedinfraPod", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightConvergedinfraPod : GetCmdletBase
    {
        public GetIntersightConvergedinfraPod()
        {
            ApiInstance = new ConvergedinfraApi(Config);
            MethodName = "GetConvergedinfraPodListWithHttpInfo";
        }

        // <summary>
        /// <para type="description">"The Account ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string AccountMoid
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"The time when this managed object was created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime CreateTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The deployment type for this integrated system.\n* `FlexPodInfra` - The deployment type for a pod is of Infrastructure.\n* `FlexPodNG` - The deployment type for a pod is of Nextgen type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public ConvergedinfraPod.DeploymentTypeEnum DeploymentType
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Description of the pod. A short note about the nature or purpose of the pod."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The DomainGroup ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string DomainGroupMoid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The interoperability status for this solution pod.\n* `NotEvaluated` - The interoperability compliance for the component has not be checked.\n* `Approved` - The component is valid as per the interoperability compliance check.\n* `NotApproved` - The component is not valid as per the interoperability compliance check.\n* `Incomplete` - The interoperability compliance check could not be completed for the component due to incomplete data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public ConvergedinfraPod.InteropStatusEnum InteropStatus
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The time when this managed object was last modified."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime ModTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Moid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Name of the pod. Concrete pod will be created with this name."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^[a-zA-Z0-9_.-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public OrganizationOrganizationRelationship Organization
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public MoBaseMoRelationship Parent
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a convergedinfraPodComplianceInfo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public ConvergedinfraPodComplianceInfoRelationship PodCompliance
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a resourceGroup resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public ResourceGroupRelationship PodResourceGroup
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a workflowServiceItemInstance resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public WorkflowServiceItemInstanceRelationship ServiceItemInstance
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Intersight provides pre-built workflows, tasks and policies to end users through global catalogs.\nObjects that are made available through global catalogs are said to have a 'shared' ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SharedScope
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"Defines the type of the pod.\n* `FlexPod` - Pod type is FlexPod, an integrated infrastructure solution developed by Cisco and NetApp.\n* `FlashStack` - Pod type is FlashStack, an integrated infrastructure solution developed by Cisco and Pure Storage."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public ConvergedinfraPod.TypeEnum Type
        {
            get;
            set;
        }



    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get ConvergedinfraPodComplianceInfo.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightConvergedinfraPodComplianceInfo", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightConvergedinfraPodComplianceInfo : GetCmdletBase
    {
        public GetIntersightConvergedinfraPodComplianceInfo()
        {
            ApiInstance = new ConvergedinfraApi(Config);
            MethodName = "GetConvergedinfraPodComplianceInfoListWithHttpInfo";
        }

        // <summary>
        /// <para type="description">"The Account ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string AccountMoid
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"The time when this managed object was created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime CreateTime
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The DomainGroup ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string DomainGroupMoid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The time when this managed object was last modified."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime ModTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Moid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The name of the component for which the compliance is evaluated."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Name
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public MoBaseMoRelationship Parent
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a convergedinfraPod resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public ConvergedinfraPodRelationship Pod
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Reason for the status, when the status is Incomplete or NotApproved. Reason should help to identify the component that is not compliant.\n* `NotEvaluated` - The validation for the HCL or Interop status is yet to be performed.\n* `Missing-Os-Info` - This means the Interop status for the sever cannot be computed because we have missing OS information. Either install ucstools vib or use power shell scripts to tag proper OS information.\n* `Incompatible-Storage-Os` - The validation failed because the given storage name and version combination is not found in Interop matrix.\n* `Incompatible-Os-Info` - The validation failed because the given OS name and version combination is not found in HCL.\n* `Incompatible-Processor` - The validation failed because the given processor is not found for the given server PID in HCL.\n* `Incompatible-Server-Platform` - The validation failed because the given server platform is not found in the Interop matrix.\n* `Incompatible-Server-Model` - The validation failed because the given server model is not found in the Interop matrix.\n* `Incompatible-Adapter-Model` - The validation failed because the given adapter model is not found in the Interop matrix.\n* `Incompatible-Switch-Model` - The validation failed because the given switch model is not found in the Interop matrix.\n* `Incompatible-Server-Firmware` - The validation failed because the given server firmware version is not found in HCL.\n* `Incompatible-Switch-Firmware` - The validation failed because the given switch firmware version is not found in Interop matrix.\n* `Incompatible-Firmware` - The validation failed because the given adapter firmware version is not found in either HCL or Interop matrix.\n* `Incompatible-Driver` - The validation failed because the given driver version is not found in either HCL or Interop matrix.\n* `Incompatible-Firmware-Driver` - The validation failed because the given adapter firmware and driver version is not found in either HCL or Interop matrix.\n* `Missing-Os-Driver-Info` - The validation failed because the given server has no OS driver information available in the inventory. Either install ucstools vib or use power shell scripts to tag proper OS information.\n* `Missing-Os-Or-Driver-Info` - This means the Interop status for the switch or storage array cannot be computed because we have either missing Host OS information or missing required driver information. Either install ucstools vib or use power shell scripts to tag proper OS information or install required drivers.\n* `Incompatible-Components` - The validation failed for the given server because one or more of its components failed validation.\n* `Compatible` - This means the HCL status and Interop status for the component have passed all validations for all of its related components."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public ConvergedinfraPodComplianceInfo.ReasonEnum Reason
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Intersight provides pre-built workflows, tasks and policies to end users through global catalogs.\nObjects that are made available through global catalogs are said to have a 'shared' ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SharedScope
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Compliance status for the component.\n* `NotEvaluated` - The interoperability compliance for the component has not be checked.\n* `Approved` - The component is valid as per the interoperability compliance check.\n* `NotApproved` - The component is not valid as per the interoperability compliance check.\n* `Incomplete` - The interoperability compliance check could not be completed for the component due to incomplete data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public ConvergedinfraPodComplianceInfo.StatusEnum Status
        {
            get;
            set;
        }




    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get ConvergedinfraServerComplianceDetails.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightConvergedinfraServerComplianceDetails", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightConvergedinfraServerComplianceDetails : GetCmdletBase
    {
        public GetIntersightConvergedinfraServerComplianceDetails()
        {
            ApiInstance = new ConvergedinfraApi(Config);
            MethodName = "GetConvergedinfraServerComplianceDetailsListWithHttpInfo";
        }

        // <summary>
        /// <para type="description">"The Account ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string AccountMoid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The number of ethernet NIC adapters in the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long AdapterCount
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"The time when this managed object was created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime CreateTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The DomainGroup ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string DomainGroupMoid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The Cisco IMC firmware version of the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Firmware
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The HCL compatibility status of the server.\n* `NotEvaluated` - The interoperability compliance for the component has not be checked.\n* `Approved` - The component is valid as per the interoperability compliance check.\n* `NotApproved` - The component is not valid as per the interoperability compliance check.\n* `Incomplete` - The interoperability compliance check could not be completed for the component due to incomplete data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public ConvergedinfraServerComplianceDetails.HclStatusEnum HclStatus
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The reason for server's HCL status.\n* `Missing-Os-Driver-Info` - The validation failed becaue the given server has no OS driver information available in the inventory. Either install UCS Tools VIB on the host ESXi or use OS Discovery Tool scripts to provide proper OS information.\n* `Incompatible-Server` - The validation failed for this server because the server's model was not listed in the HCL.\n* `Incompatible-Processor` - The validation failed because the given processor was not listed for the given server model.\n* `Incompatible-Os-Info` - The validation failed because the given OS vendor or version was not listed in HCL for the server PID and processor combination.\n* `Incompatible-Firmware` - The validation failed because the given server firmware was not listed in the HCL for the given server PID, processor, OS vendor and version.\n* `Service-Unavailable` - The validation has failed because HCL data service is temporarily not available. The server will be re-evaluated once HCL data service is back online or finished importing new HCL data.\n* `Service-Error` - The validation has failed because the HCL data service has returned a service error or unrecognized result.\n* `Not-Evaluated` - This means the HclStatus for the sever has not been evaluated because it is exempted.\n* `Incompatible-Components` - The validation has failed for this server because one or more components have \"Not-Listed\" status.\n* `Compatible` - The validation has passed for this server's model, processor, OS vendor and version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public ConvergedinfraServerComplianceDetails.HclStatusReasonEnum HclStatusReason
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The time when this managed object was last modified."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime ModTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The model information of the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Model
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Moid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The name of the component for which the compliance is evaluated."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Name
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Details of name and version of the operating system running on the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Os
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public MoBaseMoRelationship Parent
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Details of platform of the server, examples are B-Series, C-Series, X-Series etc."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Platform
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a convergedinfraPodComplianceInfo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public ConvergedinfraPodComplianceInfoRelationship PodCompliance
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The processor information of the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Processor
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Reason for the status, when the status is Incomplete or NotApproved. Reason should help to identify the component that is not compliant.\n* `NotEvaluated` - The validation for the HCL or Interop status is yet to be performed.\n* `Missing-Os-Info` - This means the Interop status for the sever cannot be computed because we have missing OS information. Either install ucstools vib or use power shell scripts to tag proper OS information.\n* `Incompatible-Storage-Os` - The validation failed because the given storage name and version combination is not found in Interop matrix.\n* `Incompatible-Os-Info` - The validation failed because the given OS name and version combination is not found in HCL.\n* `Incompatible-Processor` - The validation failed because the given processor is not found for the given server PID in HCL.\n* `Incompatible-Server-Platform` - The validation failed because the given server platform is not found in the Interop matrix.\n* `Incompatible-Server-Model` - The validation failed because the given server model is not found in the Interop matrix.\n* `Incompatible-Adapter-Model` - The validation failed because the given adapter model is not found in the Interop matrix.\n* `Incompatible-Switch-Model` - The validation failed because the given switch model is not found in the Interop matrix.\n* `Incompatible-Server-Firmware` - The validation failed because the given server firmware version is not found in HCL.\n* `Incompatible-Switch-Firmware` - The validation failed because the given switch firmware version is not found in Interop matrix.\n* `Incompatible-Firmware` - The validation failed because the given adapter firmware version is not found in either HCL or Interop matrix.\n* `Incompatible-Driver` - The validation failed because the given driver version is not found in either HCL or Interop matrix.\n* `Incompatible-Firmware-Driver` - The validation failed because the given adapter firmware and driver version is not found in either HCL or Interop matrix.\n* `Missing-Os-Driver-Info` - The validation failed because the given server has no OS driver information available in the inventory. Either install ucstools vib or use power shell scripts to tag proper OS information.\n* `Missing-Os-Or-Driver-Info` - This means the Interop status for the switch or storage array cannot be computed because we have either missing Host OS information or missing required driver information. Either install ucstools vib or use power shell scripts to tag proper OS information or install required drivers.\n* `Incompatible-Components` - The validation failed for the given server because one or more of its components failed validation.\n* `Compatible` - This means the HCL status and Interop status for the component have passed all validations for all of its related components."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public ConvergedinfraServerComplianceDetails.ReasonEnum Reason
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a computePhysicalSummary resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public ComputePhysicalSummaryRelationship Server
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Intersight provides pre-built workflows, tasks and policies to end users through global catalogs.\nObjects that are made available through global catalogs are said to have a 'shared' ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SharedScope
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Compliance status for the component.\n* `NotEvaluated` - The interoperability compliance for the component has not be checked.\n* `Approved` - The component is valid as per the interoperability compliance check.\n* `NotApproved` - The component is not valid as per the interoperability compliance check.\n* `Incomplete` - The interoperability compliance check could not be completed for the component due to incomplete data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public ConvergedinfraServerComplianceDetails.StatusEnum Status
        {
            get;
            set;
        }




    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get ConvergedinfraStorageComplianceDetails.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightConvergedinfraStorageComplianceDetails", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightConvergedinfraStorageComplianceDetails : GetCmdletBase
    {
        public GetIntersightConvergedinfraStorageComplianceDetails()
        {
            ApiInstance = new ConvergedinfraApi(Config);
            MethodName = "GetConvergedinfraStorageComplianceDetailsListWithHttpInfo";
        }

        // <summary>
        /// <para type="description">"The Account ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string AccountMoid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a convergedinfraAdapterComplianceDetails resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public ConvergedinfraAdapterComplianceDetailsRelationship AdapterCompliance
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"The time when this managed object was created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime CreateTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The DomainGroup ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string DomainGroupMoid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The time when this managed object was last modified."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime ModTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Moid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The name of the component for which the compliance is evaluated."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Name
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The operating system name and version (e.g. NetApp ONTAP 9.10) running on the storage array for which the compliance is getting evaluated."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Os
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public MoBaseMoRelationship Parent
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a convergedinfraPodComplianceInfo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public ConvergedinfraPodComplianceInfoRelationship PodCompliance
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The protocol configured for the communication between the switch and the storage array."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Protocol
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Reason for the status, when the status is Incomplete or NotApproved. Reason should help to identify the component that is not compliant.\n* `NotEvaluated` - The validation for the HCL or Interop status is yet to be performed.\n* `Missing-Os-Info` - This means the Interop status for the sever cannot be computed because we have missing OS information. Either install ucstools vib or use power shell scripts to tag proper OS information.\n* `Incompatible-Storage-Os` - The validation failed because the given storage name and version combination is not found in Interop matrix.\n* `Incompatible-Os-Info` - The validation failed because the given OS name and version combination is not found in HCL.\n* `Incompatible-Processor` - The validation failed because the given processor is not found for the given server PID in HCL.\n* `Incompatible-Server-Platform` - The validation failed because the given server platform is not found in the Interop matrix.\n* `Incompatible-Server-Model` - The validation failed because the given server model is not found in the Interop matrix.\n* `Incompatible-Adapter-Model` - The validation failed because the given adapter model is not found in the Interop matrix.\n* `Incompatible-Switch-Model` - The validation failed because the given switch model is not found in the Interop matrix.\n* `Incompatible-Server-Firmware` - The validation failed because the given server firmware version is not found in HCL.\n* `Incompatible-Switch-Firmware` - The validation failed because the given switch firmware version is not found in Interop matrix.\n* `Incompatible-Firmware` - The validation failed because the given adapter firmware version is not found in either HCL or Interop matrix.\n* `Incompatible-Driver` - The validation failed because the given driver version is not found in either HCL or Interop matrix.\n* `Incompatible-Firmware-Driver` - The validation failed because the given adapter firmware and driver version is not found in either HCL or Interop matrix.\n* `Missing-Os-Driver-Info` - The validation failed because the given server has no OS driver information available in the inventory. Either install ucstools vib or use power shell scripts to tag proper OS information.\n* `Missing-Os-Or-Driver-Info` - This means the Interop status for the switch or storage array cannot be computed because we have either missing Host OS information or missing required driver information. Either install ucstools vib or use power shell scripts to tag proper OS information or install required drivers.\n* `Incompatible-Components` - The validation failed for the given server because one or more of its components failed validation.\n* `Compatible` - This means the HCL status and Interop status for the component have passed all validations for all of its related components."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public ConvergedinfraStorageComplianceDetails.ReasonEnum Reason
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The reference device (e.g. adapter, fabric interconnect) against which the storage compliance is getting evaluated.\n* `Server` - The component type for a server in a converged infrastructure pod.\n* `Adapter` - The component type for an adapter on a server in a converged infrastructure pod.\n* `FabricInterconnect` - The component type for a fabric interconnect in a converged infrastructure pod.\n* `Nexus` - The component type for a nexus switch in a converged infrastructure pod.\n* `Storage` - The component type for a storage array in a converged infrastructure pod."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public ConvergedinfraStorageComplianceDetails.RefDeviceEnum RefDevice
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Intersight provides pre-built workflows, tasks and policies to end users through global catalogs.\nObjects that are made available through global catalogs are said to have a 'shared' ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SharedScope
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Compliance status for the component.\n* `NotEvaluated` - The interoperability compliance for the component has not be checked.\n* `Approved` - The component is valid as per the interoperability compliance check.\n* `NotApproved` - The component is not valid as per the interoperability compliance check.\n* `Incomplete` - The interoperability compliance check could not be completed for the component due to incomplete data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public ConvergedinfraStorageComplianceDetails.StatusEnum Status
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a storageBaseArray resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public StorageBaseArrayRelationship StorageArray
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a convergedinfraSwitchComplianceDetails resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public ConvergedinfraSwitchComplianceDetailsRelationship SwitchCompliance
        {
            get;
            set;
        }




    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get ConvergedinfraSwitchComplianceDetails.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightConvergedinfraSwitchComplianceDetails", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightConvergedinfraSwitchComplianceDetails : GetCmdletBase
    {
        public GetIntersightConvergedinfraSwitchComplianceDetails()
        {
            ApiInstance = new ConvergedinfraApi(Config);
            MethodName = "GetConvergedinfraSwitchComplianceDetailsListWithHttpInfo";
        }

        // <summary>
        /// <para type="description">"The Account ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string AccountMoid
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"The time when this managed object was created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime CreateTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The DomainGroup ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string DomainGroupMoid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The firmware of the switch as received from inventory."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Firmware
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The time when this managed object was last modified."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime ModTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The model information of the switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Model
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Moid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The name of the component for which the compliance is evaluated."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Name
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public MoBaseMoRelationship Parent
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a convergedinfraPodComplianceInfo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public ConvergedinfraPodComplianceInfoRelationship PodCompliance
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Reason for the status, when the status is Incomplete or NotApproved. Reason should help to identify the component that is not compliant.\n* `NotEvaluated` - The validation for the HCL or Interop status is yet to be performed.\n* `Missing-Os-Info` - This means the Interop status for the sever cannot be computed because we have missing OS information. Either install ucstools vib or use power shell scripts to tag proper OS information.\n* `Incompatible-Storage-Os` - The validation failed because the given storage name and version combination is not found in Interop matrix.\n* `Incompatible-Os-Info` - The validation failed because the given OS name and version combination is not found in HCL.\n* `Incompatible-Processor` - The validation failed because the given processor is not found for the given server PID in HCL.\n* `Incompatible-Server-Platform` - The validation failed because the given server platform is not found in the Interop matrix.\n* `Incompatible-Server-Model` - The validation failed because the given server model is not found in the Interop matrix.\n* `Incompatible-Adapter-Model` - The validation failed because the given adapter model is not found in the Interop matrix.\n* `Incompatible-Switch-Model` - The validation failed because the given switch model is not found in the Interop matrix.\n* `Incompatible-Server-Firmware` - The validation failed because the given server firmware version is not found in HCL.\n* `Incompatible-Switch-Firmware` - The validation failed because the given switch firmware version is not found in Interop matrix.\n* `Incompatible-Firmware` - The validation failed because the given adapter firmware version is not found in either HCL or Interop matrix.\n* `Incompatible-Driver` - The validation failed because the given driver version is not found in either HCL or Interop matrix.\n* `Incompatible-Firmware-Driver` - The validation failed because the given adapter firmware and driver version is not found in either HCL or Interop matrix.\n* `Missing-Os-Driver-Info` - The validation failed because the given server has no OS driver information available in the inventory. Either install ucstools vib or use power shell scripts to tag proper OS information.\n* `Missing-Os-Or-Driver-Info` - This means the Interop status for the switch or storage array cannot be computed because we have either missing Host OS information or missing required driver information. Either install ucstools vib or use power shell scripts to tag proper OS information or install required drivers.\n* `Incompatible-Components` - The validation failed for the given server because one or more of its components failed validation.\n* `Compatible` - This means the HCL status and Interop status for the component have passed all validations for all of its related components."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public ConvergedinfraSwitchComplianceDetails.ReasonEnum Reason
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Intersight provides pre-built workflows, tasks and policies to end users through global catalogs.\nObjects that are made available through global catalogs are said to have a 'shared' ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SharedScope
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Compliance status for the component.\n* `NotEvaluated` - The interoperability compliance for the component has not be checked.\n* `Approved` - The component is valid as per the interoperability compliance check.\n* `NotApproved` - The component is not valid as per the interoperability compliance check.\n* `Incomplete` - The interoperability compliance check could not be completed for the component due to incomplete data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public ConvergedinfraSwitchComplianceDetails.StatusEnum Status
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a networkElementSummary resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public NetworkElementSummaryRelationship Switch
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The type of switch component. It must be set to either Fabric Interconnect, Nexus or MDS.\n* `FabricInterconnect` - The default Switch type of UCSM and IMM mode devices.\n* `NexusDevice` - Switch type of Nexus devices.\n* `MDSDevice` - Switch type of Nexus MDS devices.\n* `EdgeChassisManagementController` - Switch type of Edge Chassis Management Controller."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public ConvergedinfraSwitchComplianceDetails.TypeEnum Type
        {
            get;
            set;
        }



    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set ConvergedinfraPod.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightConvergedinfraPod")]
    public class SetIntersightConvergedinfraPod : SetCmdletBase
    {
        public SetIntersightConvergedinfraPod()
        {
            ApiInstance = new ConvergedinfraApi(Config);
            ModelObject = new ConvergedinfraPod();
            MethodName = "UpdateConvergedinfraPodWithHttpInfo";
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
        /// <para type="description">"Description of the pod. A short note about the nature or purpose of the pod."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Name of the pod. Concrete pod will be created with this name."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public OrganizationOrganizationRelationship Organization
        {
            get;
            set;
        }









        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<MoTag> Tags
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Defines the type of the pod.\n* `FlexPod` - Pod type is FlexPod, an integrated infrastructure solution developed by Cisco and NetApp.\n* `FlashStack` - Pod type is FlashStack, an integrated infrastructure solution developed by Cisco and Pure Storage."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ConvergedinfraPod.TypeEnum Type
        {
            get;
            set;
        }

    }
}