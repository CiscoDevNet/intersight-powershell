using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get WorkloadBlueprint.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightWorkloadBlueprint", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightWorkloadBlueprint : GetCmdletBase
    {
        public GetIntersightWorkloadBlueprint()
        {
            ApiInstance = new WorkloadApi(Config);
            MethodName = "GetWorkloadBlueprintListWithHttpInfo";
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
        /// <para type="description">"A reference to a workflowCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public WorkflowCatalogRelationship Catalog
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
        /// <para type="description">"The flag to indicate that this is the default version of the blueprint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool DefaultVersion
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The description for this blueprint which provides information on what are the pre-requisites to deploy the blueprint and what features are supported on the blueprint."</para>
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
        /// <para type="description">"When set to false the blueprint is created for use within internal services."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool ExternalMeta
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"A user friendly short name to identify the blueprint. Name can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-), period (.), colon (:), space ( ) or an underscore (_)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^[a-zA-Z0-9]+[\\sa-zA-Z0-9_.:-]{1,31}$")]
        public string Label
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
        /// <para type="description">"The name for this blueprint. You can have multiple versions of the blueprint with the same name. Name can only contain letters (a-z, A-Z), numbers (0-9), or an underscore (_)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^[a-zA-Z0-9][a-zA-Z0-9_]{0,31}$")]
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
        /// <para type="description">"The Intersight platforms supported by this blueprint.\n* `None` - Default value is none, platform is not mentioned.\n* `UnifiedEdge` - The blueprint is created for Unified Edge platform."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public WorkloadBlueprint.PlatformTypeEnum PlatformType
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
        /// <para type="description">"The version of the blueprint to support multiple versions."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long Version
        {
            get;
            set;
        }



    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get WorkloadDeploymentInput.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightWorkloadDeploymentInput", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightWorkloadDeploymentInput : GetCmdletBase
    {
        public GetIntersightWorkloadDeploymentInput()
        {
            ApiInstance = new WorkloadApi(Config);
            MethodName = "GetWorkloadDeploymentInputListWithHttpInfo";
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
        /// <para type="description">"A sequential number that increments whenever the input changes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long GenNumber
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
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public MoBaseMoRelationship Parent
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
        /// <para type="description">"A reference to a workloadWorkloadDeployment resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public WorkloadWorkloadDeploymentRelationship WorkloadDeployment
        {
            get;
            set;
        }


    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get WorkloadWorkloadDefinition.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightWorkloadWorkloadDefinition", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightWorkloadWorkloadDefinition : GetCmdletBase
    {
        public GetIntersightWorkloadWorkloadDefinition()
        {
            ApiInstance = new WorkloadApi(Config);
            MethodName = "GetWorkloadWorkloadDefinitionListWithHttpInfo";
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
        /// <para type="description">"The description for this workload definition."</para>
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
        /// <para type="description">"The name for this Workload. You can have multiple versions of the Workload with the same name. Name can only contain letters (a-z, A-Z), numbers (0-9), space, hyphen (-), or an underscore (_). A refName is generated from the given name, and that along with the version must be unique within an Organization."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^[a-zA-Z0-9][a-zA-Z0-9- _]{0,31}$")]
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
        /// <para type="description">"The flag to indicate that this is the preferred (default) version of the workload."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool PreferredVersion
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference name is generated by the system based on the given name by replacing spaces and hyphen in name with underscore. This reference name is used internally and cannot be edited by users. It may only contain letters (a–z, A–Z), numbers (0–9), and underscores (_)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^$|^[a-zA-Z0-9][a-zA-Z0-9_]{0,31}$")]
        public string RefName
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
        /// <para type="description">"The status of the definition.\n* `Inactive` - The definition is in an inactive state and there are no workload instances associated with this workload. Changes to input parameters within the workload are allowed in this state.\n* `Active` - The definition is active and associated with one or more workload instances."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public WorkloadWorkloadDefinition.StatusEnum Status
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"The version of the workload to support multiple versions."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long Version
        {
            get;
            set;
        }



    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get WorkloadWorkloadDeployment.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightWorkloadWorkloadDeployment", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightWorkloadWorkloadDeployment : GetCmdletBase
    {
        public GetIntersightWorkloadWorkloadDeployment()
        {
            ApiInstance = new WorkloadApi(Config);
            MethodName = "GetWorkloadWorkloadDeploymentListWithHttpInfo";
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
        /// <para type="description">"The action is performed on the deployment.\n* `None` - No changes have been made.\n* `PrepareToDeploy` - Marks the deployment as ready once the user has completed all changes and the deployment is in a valid state. Once the deployment is marked as PrepareToDeploy, workload instances will be created, but the actual deployment will occur as part of the deploy action.\n* `Deploy` - Initiates the process of pushing workload configuration to the instances based on the configured schedule. Once deployed, the deployment cannot be reverted to draft status.\n* `Suspend` - Suspends the deployment, preventing any further actions until it is resumed. Making changes to deployment configuration will not be pushed out. The deployment will not take any changes from the attached Workload when it is suspended.\n* `Retry` - Retries the deployment for all instances that previously failed.\n* `Resume` - Resumes a suspended deployment. Any changes made to the deployment when it was suspended or any changes made to the attached Workload will now be pushed out based on configured schedules."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public WorkloadWorkloadDeployment.ActionEnum Action
        {
            get;
            set;
        }





        // <summary>
        /// <para type="description">"The conformance status of the deployment.\n* `Ok` - The deployment conforms to the preferred version of the workload.\n* `NonConformant` - The deployment does not conform to the preferred version of the workload."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public WorkloadWorkloadDeployment.ConformanceEnum Conformance
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
        /// <para type="description">"A reference to a workloadDeploymentInput resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public WorkloadDeploymentInputRelationship DeploymentInput
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A brief description of the deployment."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The minimum digit count to format the instance index with leading zeros,  for example if the digit count is 4 and the start index is 1, then the  first instance will have a suffix 0001. If the number of instances created for the deployment exceeds the 9999, then the suffix will become a 5 digit number."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidateRange(1, 4)]
        public long DigitCount
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
        /// <para type="description">"The last action is performed on the deployment.\n* `None` - No changes have been made.\n* `PrepareToDeploy` - Marks the deployment as ready once the user has completed all changes and the deployment is in a valid state. Once the deployment is marked as PrepareToDeploy, workload instances will be created, but the actual deployment will occur as part of the deploy action.\n* `Deploy` - Initiates the process of pushing workload configuration to the instances based on the configured schedule. Once deployed, the deployment cannot be reverted to draft status.\n* `Suspend` - Suspends the deployment, preventing any further actions until it is resumed. Making changes to deployment configuration will not be pushed out. The deployment will not take any changes from the attached Workload when it is suspended.\n* `Retry` - Retries the deployment for all instances that previously failed.\n* `Resume` - Resumes a suspended deployment. Any changes made to the deployment when it was suspended or any changes made to the attached Workload will now be pushed out based on configured schedules."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public WorkloadWorkloadDeployment.LastActionEnum LastAction
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Tracks the last numeric index used for workload instances. The next instance index is derived by incrementing this value."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long LastInstanceIndex
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
        /// <para type="description">"The name for this Deployment. Name can only contain letters (a-z, A-Z), numbers (0-9), space, hyphen (-), or an underscore (_). The name must be unique within the organization."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^[a-zA-Z0-9][a-zA-Z0-9- _]{0,31}$")]
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
        /// <para type="description">"A reference name is generated by the system based on the given name by replacing spaces and hyphen in name with underscore. This reference name is used internally and cannot be edited by users. It may only contain letters (a–z, A–Z), numbers (0–9), and underscores (_)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^$|^[a-zA-Z0-9][a-zA-Z0-9_]{0,31}$")]
        public string RefName
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a resourcepoolPool resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public ResourcepoolPoolRelationship ResourcePool
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a schedulerSchedulePolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public SchedulerSchedulePolicyRelationship SchedulePolicy
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
        /// <para type="description">"The starting index used to generate the suffix for the workload instance name."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long StartIndexForSuffix
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The status of the deployment.\n* `Draft` - The initial state of the deployment, indicating it is still being configured and not ready for deployment.\n* `ReadyToDeploy` - The deployment has passed validation checks and is ready to be deployed to instances.\n* `InProgress` - The initial deployment or changes in the deployment are in progress.\n* `Ok` - All associated instances have been successfully deployed.\n* `Failed` - One or more instances failed during initial deployment or changes in the deployment operations.\n* `ChangesScheduled` - The deployment has changes that need to be pushed to all associated instances.\n* `Suspended` - The deployment is suspended, preventing any further initial deployments or changes to deployment operations."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public WorkloadWorkloadDeployment.StatusEnum Status
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a schedulerTaskSchedule resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public SchedulerTaskScheduleRelationship TaskSchedule
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"A reference to a workloadWorkloadDefinition resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public WorkloadWorkloadDefinitionRelationship WorkloadDefinition
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The prefix to be used for naming workload instances created by this deployment. Prefix can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-), or an underscore (_). This prefix must be unique within the organization."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^[a-zA-Z0-9][a-zA-Z0-9-_]{0,31}$")]
        public string WorkloadInstancePrefix
        {
            get;
            set;
        }


    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get WorkloadWorkloadInstance.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightWorkloadWorkloadInstance", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightWorkloadWorkloadInstance : GetCmdletBase
    {
        public GetIntersightWorkloadWorkloadInstance()
        {
            ApiInstance = new WorkloadApi(Config);
            MethodName = "GetWorkloadWorkloadInstanceListWithHttpInfo";
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
        /// <para type="description">"The action to be performed on the workload instance.\n* `None` - Absence of any action on the workload instance.\n* `Suspend` - Pauses the execution of the workload instance, temporarily stopping its operations without permanently removing it.\n* `Resume` - Restarts a suspended workload instance, allowing it to continue operations from where it left off.\n* `Deploy` - Initiates the deployment of the workload instance, provisioning the necessary resources and starting its execution.\n* `Retry` - Attempts to re-deploy the workload instance, either due to a previous failure or to apply changes made to the instance.\n* `RetryAll` - Attempts to re-deploy all workload instances associated with the same deployment, either due to a previous failure or to apply changes made to the instances.\n* `Attach` - Associates the workload instance with its assigned resources, allowing it to utilize the resources for its operations.\n* `Detach` - Disassociates the workload instance from its assigned resources, preventing it from using the resources for its operations.\n* `UnAssign` - Detaches assigned resources from the workload instance while keeping the instance active."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public WorkloadWorkloadInstance.ActionEnum Action
        {
            get;
            set;
        }





        // <summary>
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public MoBaseMoRelationship ChassisPoolMember
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The conformance status of the deployment.\n* `Ok` - The deployment conforms to the preferred version of the workload.\n* `NonConformant` - The deployment does not conform to the preferred version of the workload."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public WorkloadWorkloadInstance.ConformanceEnum Conformance
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
        /// <para type="description">"A reference to a workloadDeploymentInput resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public WorkloadDeploymentInputRelationship DeploymentInput
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
        /// <para type="description">"The last action performed on the workload instance.\n* `None` - Absence of any action on the workload instance.\n* `Suspend` - Pauses the execution of the workload instance, temporarily stopping its operations without permanently removing it.\n* `Resume` - Restarts a suspended workload instance, allowing it to continue operations from where it left off.\n* `Deploy` - Initiates the deployment of the workload instance, provisioning the necessary resources and starting its execution.\n* `Retry` - Attempts to re-deploy the workload instance, either due to a previous failure or to apply changes made to the instance.\n* `RetryAll` - Attempts to re-deploy all workload instances associated with the same deployment, either due to a previous failure or to apply changes made to the instances.\n* `Attach` - Associates the workload instance with its assigned resources, allowing it to utilize the resources for its operations.\n* `Detach` - Disassociates the workload instance from its assigned resources, preventing it from using the resources for its operations.\n* `UnAssign` - Detaches assigned resources from the workload instance while keeping the instance active."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public WorkloadWorkloadInstance.LastActionEnum LastAction
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a workloadDeploymentInput resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public WorkloadDeploymentInputRelationship LastDeploymentInput
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
        /// <para type="description">"The name for this Workload instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
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
        /// <para type="description">"Intersight provides pre-built workflows, tasks and policies to end users through global catalogs.\nObjects that are made available through global catalogs are said to have a 'shared' ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SharedScope
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The current status of the workload instance.\n* `Staging` - The instance is in the staging phase, awaiting further actions.\n* `ReadyToDeploy` - The instance is fully configured and ready for deployment.\n* `InProgress` - Deployment or modification of the instance is currently in progress.\n* `Ok` - The instance is running successfully without issues.\n* `Failed` - The instance has encountered an error or failure preventing normal operation.\n* `Suspended` - The instance has been temporarily paused and is inactive.\n* `ChangesScheduled` - There is a change in the configuration that needs to be pushed to the instance.\n* `InSufficientResource` - The instance lacks the necessary resources to operate.\n* `OutOfService` - The instance is no longer available or operational.\n* `UnAssigning` - The instance is being unassigned or removed from service."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public WorkloadWorkloadInstance.StatusEnum Status
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The context or justification for the status transition.\n* `None` - No changes have been made.\n* `ResourceDisqualified` - The change in resource status triggered due to the resource being disqualified."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public WorkloadWorkloadInstance.StatusChangeReasonEnum StatusChangeReason
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"A reference to a workloadWorkloadDefinition resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public WorkloadWorkloadDefinitionRelationship WorkloadDefinition
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a workloadWorkloadDeployment resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public WorkloadWorkloadDeploymentRelationship WorkloadDeployment
        {
            get;
            set;
        }


    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New WorkloadBlueprint.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightWorkloadBlueprint")]
    public class NewIntersightWorkloadBlueprint : NewCmdletBase
    {
        public NewIntersightWorkloadBlueprint()
        {
            ApiInstance = new WorkloadApi(Config);
            ModelObject = new WorkloadBlueprint();
            MethodName = "CreateWorkloadBlueprintWithHttpInfo";
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<BlueprintBlueprintDefinitionDependency> BlueprintDependencies
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a workflowCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowCatalogRelationship Catalog
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The flag to indicate that this is the default version of the blueprint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool DefaultVersion
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The description for this blueprint which provides information on what are the pre-requisites to deploy the blueprint and what features are supported on the blueprint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"When set to false the blueprint is created for use within internal services."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool ExternalMeta
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<BlueprintGeneratedObjectMetadata> GeneratedObjectDefinition
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<WorkflowBaseDataType> InputDefinition
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<BlueprintInputOperationType> InputOperationMetadata
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A user friendly short name to identify the blueprint. Name can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-), period (.), colon (:), space ( ) or an underscore (_)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9]+[\\sa-zA-Z0-9_.:-]{1,31}$")]
        public string Label
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
        /// <para type="description">"The name for this blueprint. You can have multiple versions of the blueprint with the same name. Name can only contain letters (a-z, A-Z), numbers (0-9), or an underscore (_)."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9][a-zA-Z0-9_]{0,31}$")]
        public string Name
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"The Intersight platforms supported by this blueprint.\n* `None` - Default value is none, platform is not mentioned.\n* `UnifiedEdge` - The blueprint is created for Unified Edge platform."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkloadBlueprint.PlatformTypeEnum PlatformType
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The resource constraint definition for the blueprint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BlueprintResourceConstraints ResourceDefinition
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<BlueprintServiceItemDefinition> ServiceItems
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
        /// <para type="description">"The version of the blueprint to support multiple versions."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Version
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New WorkloadWorkloadDefinition.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightWorkloadWorkloadDefinition")]
    public class NewIntersightWorkloadWorkloadDefinition : NewCmdletBase
    {
        public NewIntersightWorkloadWorkloadDefinition()
        {
            ApiInstance = new WorkloadApi(Config);
            ModelObject = new WorkloadWorkloadDefinition();
            MethodName = "CreateWorkloadWorkloadDefinitionWithHttpInfo";
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<WorkloadBlueprintReference> Blueprints
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"The description for this workload definition."</para>
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The name for this Workload. You can have multiple versions of the Workload with the same name. Name can only contain letters (a-z, A-Z), numbers (0-9), space, hyphen (-), or an underscore (_). A refName is generated from the given name, and that along with the version must be unique within an Organization."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9][a-zA-Z0-9- _]{0,31}$")]
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

        public List<WorkloadWorkloadDefinition.PlatformTypeEnum> PlatformType
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The flag to indicate that this is the preferred (default) version of the workload."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool PreferredVersion
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The strategy used for rolling out deployment changes when this workload version is marked as the preferred version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkloadRolloutStrategy PreferredVersionRolloutStrategy
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"The status of the definition.\n* `Inactive` - The definition is in an inactive state and there are no workload instances associated with this workload. Changes to input parameters within the workload are allowed in this state.\n* `Active` - The definition is active and associated with one or more workload instances."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkloadWorkloadDefinition.StatusEnum Status
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
        /// <para type="description">"The version of the workload to support multiple versions."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Version
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New WorkloadWorkloadDeployment.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightWorkloadWorkloadDeployment")]
    public class NewIntersightWorkloadWorkloadDeployment : NewCmdletBase
    {
        public NewIntersightWorkloadWorkloadDeployment()
        {
            ApiInstance = new WorkloadApi(Config);
            ModelObject = new WorkloadWorkloadDeployment();
            MethodName = "CreateWorkloadWorkloadDeploymentWithHttpInfo";
        }


        // <summary>
        /// <para type="description">"The action is performed on the deployment.\n* `None` - No changes have been made.\n* `PrepareToDeploy` - Marks the deployment as ready once the user has completed all changes and the deployment is in a valid state. Once the deployment is marked as PrepareToDeploy, workload instances will be created, but the actual deployment will occur as part of the deploy action.\n* `Deploy` - Initiates the process of pushing workload configuration to the instances based on the configured schedule. Once deployed, the deployment cannot be reverted to draft status.\n* `Suspend` - Suspends the deployment, preventing any further actions until it is resumed. Making changes to deployment configuration will not be pushed out. The deployment will not take any changes from the attached Workload when it is suspended.\n* `Retry` - Retries the deployment for all instances that previously failed.\n* `Resume` - Resumes a suspended deployment. Any changes made to the deployment when it was suspended or any changes made to the attached Workload will now be pushed out based on configured schedules."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkloadWorkloadDeployment.ActionEnum Action
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<WorkloadBlueprintInputReference> Blueprints
        {
            get;
            set;
        }






        // <summary>
        /// <para type="description">"A brief description of the deployment."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The minimum digit count to format the instance index with leading zeros,  for example if the digit count is 4 and the start index is 1, then the  first instance will have a suffix 0001. If the number of instances created for the deployment exceeds the 9999, then the suffix will become a 5 digit number."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 4)]
        public long DigitCount
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
        /// <para type="description">"The name for this Deployment. Name can only contain letters (a-z, A-Z), numbers (0-9), space, hyphen (-), or an underscore (_). The name must be unique within the organization."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9][a-zA-Z0-9- _]{0,31}$")]
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

        public List<ResourceResourceQualifier> Qualifiers
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"The strategy used for rolling out deployment changes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkloadRolloutStrategy RolloutStrategy
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a schedulerSchedulePolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public SchedulerSchedulePolicyRelationship SchedulePolicy
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The starting index used to generate the suffix for the workload instance name."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long StartIndexForSuffix
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
        /// <para type="description">"The workload definition associated with this deployment."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkloadDefinitionMapper WorkloadDefinitionReference
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The prefix to be used for naming workload instances created by this deployment. Prefix can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-), or an underscore (_). This prefix must be unique within the organization."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9][a-zA-Z0-9-_]{0,31}$")]
        public string WorkloadInstancePrefix
        {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove WorkloadBlueprint.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightWorkloadBlueprint")]
    public class RemoveIntersightWorkloadBlueprint : RemoveCmdletBase
    {
        public RemoveIntersightWorkloadBlueprint()
        {
            ApiInstance = new WorkloadApi(Config);
            MethodName = "DeleteWorkloadBlueprintWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove WorkloadWorkloadDefinition.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightWorkloadWorkloadDefinition")]
    public class RemoveIntersightWorkloadWorkloadDefinition : RemoveCmdletBase
    {
        public RemoveIntersightWorkloadWorkloadDefinition()
        {
            ApiInstance = new WorkloadApi(Config);
            MethodName = "DeleteWorkloadWorkloadDefinitionWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove WorkloadWorkloadDeployment.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightWorkloadWorkloadDeployment")]
    public class RemoveIntersightWorkloadWorkloadDeployment : RemoveCmdletBase
    {
        public RemoveIntersightWorkloadWorkloadDeployment()
        {
            ApiInstance = new WorkloadApi(Config);
            MethodName = "DeleteWorkloadWorkloadDeploymentWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove WorkloadWorkloadInstance.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightWorkloadWorkloadInstance")]
    public class RemoveIntersightWorkloadWorkloadInstance : RemoveCmdletBase
    {
        public RemoveIntersightWorkloadWorkloadInstance()
        {
            ApiInstance = new WorkloadApi(Config);
            MethodName = "DeleteWorkloadWorkloadInstanceWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set WorkloadBlueprint.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightWorkloadBlueprint")]
    public class SetIntersightWorkloadBlueprint : SetCmdletBase
    {
        public SetIntersightWorkloadBlueprint()
        {
            ApiInstance = new WorkloadApi(Config);
            ModelObject = new WorkloadBlueprint();
            MethodName = "UpdateWorkloadBlueprintWithHttpInfo";
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<BlueprintBlueprintDefinitionDependency> BlueprintDependencies
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a workflowCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowCatalogRelationship Catalog
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The flag to indicate that this is the default version of the blueprint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool DefaultVersion
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The description for this blueprint which provides information on what are the pre-requisites to deploy the blueprint and what features are supported on the blueprint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"When set to false the blueprint is created for use within internal services."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool ExternalMeta
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<BlueprintGeneratedObjectMetadata> GeneratedObjectDefinition
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<WorkflowBaseDataType> InputDefinition
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<BlueprintInputOperationType> InputOperationMetadata
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A user friendly short name to identify the blueprint. Name can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-), period (.), colon (:), space ( ) or an underscore (_)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9]+[\\sa-zA-Z0-9_.:-]{1,31}$")]
        public string Label
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
        /// <para type="description">"The name for this blueprint. You can have multiple versions of the blueprint with the same name. Name can only contain letters (a-z, A-Z), numbers (0-9), or an underscore (_)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9][a-zA-Z0-9_]{0,31}$")]
        public string Name
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"The Intersight platforms supported by this blueprint.\n* `None` - Default value is none, platform is not mentioned.\n* `UnifiedEdge` - The blueprint is created for Unified Edge platform."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkloadBlueprint.PlatformTypeEnum PlatformType
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The resource constraint definition for the blueprint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BlueprintResourceConstraints ResourceDefinition
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<BlueprintServiceItemDefinition> ServiceItems
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
        /// <para type="description">"The version of the blueprint to support multiple versions."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Version
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set WorkloadWorkloadDefinition.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightWorkloadWorkloadDefinition")]
    public class SetIntersightWorkloadWorkloadDefinition : SetCmdletBase
    {
        public SetIntersightWorkloadWorkloadDefinition()
        {
            ApiInstance = new WorkloadApi(Config);
            ModelObject = new WorkloadWorkloadDefinition();
            MethodName = "UpdateWorkloadWorkloadDefinitionWithHttpInfo";
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<WorkloadBlueprintReference> Blueprints
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"The description for this workload definition."</para>
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
        /// <para type="description">"The name for this Workload. You can have multiple versions of the Workload with the same name. Name can only contain letters (a-z, A-Z), numbers (0-9), space, hyphen (-), or an underscore (_). A refName is generated from the given name, and that along with the version must be unique within an Organization."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9][a-zA-Z0-9- _]{0,31}$")]
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

        public List<WorkloadWorkloadDefinition.PlatformTypeEnum> PlatformType
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The flag to indicate that this is the preferred (default) version of the workload."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool PreferredVersion
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The strategy used for rolling out deployment changes when this workload version is marked as the preferred version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkloadRolloutStrategy PreferredVersionRolloutStrategy
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"The status of the definition.\n* `Inactive` - The definition is in an inactive state and there are no workload instances associated with this workload. Changes to input parameters within the workload are allowed in this state.\n* `Active` - The definition is active and associated with one or more workload instances."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkloadWorkloadDefinition.StatusEnum Status
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
        /// <para type="description">"The version of the workload to support multiple versions."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Version
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set WorkloadWorkloadDeployment.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightWorkloadWorkloadDeployment")]
    public class SetIntersightWorkloadWorkloadDeployment : SetCmdletBase
    {
        public SetIntersightWorkloadWorkloadDeployment()
        {
            ApiInstance = new WorkloadApi(Config);
            ModelObject = new WorkloadWorkloadDeployment();
            MethodName = "UpdateWorkloadWorkloadDeploymentWithHttpInfo";
        }


        // <summary>
        /// <para type="description">"The action is performed on the deployment.\n* `None` - No changes have been made.\n* `PrepareToDeploy` - Marks the deployment as ready once the user has completed all changes and the deployment is in a valid state. Once the deployment is marked as PrepareToDeploy, workload instances will be created, but the actual deployment will occur as part of the deploy action.\n* `Deploy` - Initiates the process of pushing workload configuration to the instances based on the configured schedule. Once deployed, the deployment cannot be reverted to draft status.\n* `Suspend` - Suspends the deployment, preventing any further actions until it is resumed. Making changes to deployment configuration will not be pushed out. The deployment will not take any changes from the attached Workload when it is suspended.\n* `Retry` - Retries the deployment for all instances that previously failed.\n* `Resume` - Resumes a suspended deployment. Any changes made to the deployment when it was suspended or any changes made to the attached Workload will now be pushed out based on configured schedules."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkloadWorkloadDeployment.ActionEnum Action
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<WorkloadBlueprintInputReference> Blueprints
        {
            get;
            set;
        }






        // <summary>
        /// <para type="description">"A brief description of the deployment."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The minimum digit count to format the instance index with leading zeros,  for example if the digit count is 4 and the start index is 1, then the  first instance will have a suffix 0001. If the number of instances created for the deployment exceeds the 9999, then the suffix will become a 5 digit number."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 4)]
        public long DigitCount
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
        /// <para type="description">"The name for this Deployment. Name can only contain letters (a-z, A-Z), numbers (0-9), space, hyphen (-), or an underscore (_). The name must be unique within the organization."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9][a-zA-Z0-9- _]{0,31}$")]
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

        public List<ResourceResourceQualifier> Qualifiers
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"The strategy used for rolling out deployment changes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkloadRolloutStrategy RolloutStrategy
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a schedulerSchedulePolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public SchedulerSchedulePolicyRelationship SchedulePolicy
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The starting index used to generate the suffix for the workload instance name."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long StartIndexForSuffix
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
        /// <para type="description">"The workload definition associated with this deployment."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkloadDefinitionMapper WorkloadDefinitionReference
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The prefix to be used for naming workload instances created by this deployment. Prefix can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-), or an underscore (_). This prefix must be unique within the organization."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9][a-zA-Z0-9-_]{0,31}$")]
        public string WorkloadInstancePrefix
        {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set WorkloadWorkloadInstance.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightWorkloadWorkloadInstance")]
    public class SetIntersightWorkloadWorkloadInstance : SetCmdletBase
    {
        public SetIntersightWorkloadWorkloadInstance()
        {
            ApiInstance = new WorkloadApi(Config);
            ModelObject = new WorkloadWorkloadInstance();
            MethodName = "UpdateWorkloadWorkloadInstanceWithHttpInfo";
        }


        // <summary>
        /// <para type="description">"The action to be performed on the workload instance.\n* `None` - Absence of any action on the workload instance.\n* `Suspend` - Pauses the execution of the workload instance, temporarily stopping its operations without permanently removing it.\n* `Resume` - Restarts a suspended workload instance, allowing it to continue operations from where it left off.\n* `Deploy` - Initiates the deployment of the workload instance, provisioning the necessary resources and starting its execution.\n* `Retry` - Attempts to re-deploy the workload instance, either due to a previous failure or to apply changes made to the instance.\n* `RetryAll` - Attempts to re-deploy all workload instances associated with the same deployment, either due to a previous failure or to apply changes made to the instances.\n* `Attach` - Associates the workload instance with its assigned resources, allowing it to utilize the resources for its operations.\n* `Detach` - Disassociates the workload instance from its assigned resources, preventing it from using the resources for its operations.\n* `UnAssign` - Detaches assigned resources from the workload instance while keeping the instance active."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkloadWorkloadInstance.ActionEnum Action
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
        /// <para type="description">"A reference to a workloadDeploymentInput resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkloadDeploymentInputRelationship DeploymentInput
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"A reference to a workloadDeploymentInput resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkloadDeploymentInputRelationship LastDeploymentInput
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
        /// <para type="description">"A reference to a workloadWorkloadDeployment resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkloadWorkloadDeploymentRelationship WorkloadDeployment
        {
            get;
            set;
        }
    }
}