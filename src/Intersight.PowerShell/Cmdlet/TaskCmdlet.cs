using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get TaskWorkflowAction.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightTaskWorkflowAction", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightTaskWorkflowAction : GetCmdletBase
    {
        public GetIntersightTaskWorkflowAction()
        {
            ApiInstance = new TaskApi(Config);
            MethodName = "GetTaskWorkflowActionListWithHttpInfo";
        }

        // <summary>
        /// <para type="description">"A reference to a iamAccount resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public IamAccountRelationship Account
        {
            get;
            set;
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
        /// <para type="description">"Action for test workflow.\n* `start` - Start action for the workflow.\n* `stop` - Stop action for the workflow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public TaskWorkflowAction.ActionEnum Action
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
        /// <para type="description">"Json formatted string input parameters to workflow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string InputParams
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"When true, this workflow type will be triggered as a dynamic workflow, if not it will be treated as a static workflow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool IsDynamic
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
        /// <para type="description">"When true, the retry operation can be performed on the workflow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool Retryable
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"This key can be set so that the workflow execution can be sequenced with workflows having the same key. An example usecase is say there are diferent workflows which operate on the server, and are executed at the same time on the same server and the sequence key for all the workflows are same, then workflow engine will enforce that the workflow execution are sequenced and started one after the other, based on timestamp of the arrival of the execution requests."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SequenceKey
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
        /// <para type="description">"When true, the workflow will wait for previous one to complete before starting a new one."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool WaitOnDuplicate
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Json formatted string that has the contents of the workflow context used when starting a workflow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string WorkflowContext
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Returns the workflow info moid of the workflow started by workflow action api. workflowInfoMoid will be an empty sting if an error occurs while starting the workflow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string WorkflowInfoMoid
        {
            get;
            set;
        }


    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New TaskCatalystSdwanScopedInventory.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightTaskCatalystSdwanScopedInventory")]
    public class NewIntersightTaskCatalystSdwanScopedInventory : NewCmdletBase
    {
        public NewIntersightTaskCatalystSdwanScopedInventory()
        {
            ApiInstance = new TaskApi(Config);
            ModelObject = new TaskCatalystSdwanScopedInventory();
            MethodName = "CreateTaskCatalystSdwanScopedInventoryWithHttpInfo";
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
        /// <para type="description">"Device will immediately collect the objects from the platform. If false, the device will wait for any in flight scheduled collections to complete first. Used to ensure that any long running collections do not delay the scoped collection result."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Immediate
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
        /// <para type="description">"A property that uniquely identifies the object to be inventoried as a part of the scoped inventory."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string NamingProperty
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"Set of queries to identify objects to be inventoried as part of this scoped inventory action."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object Queries
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetDeviceRegistrationRelationship RegisteredDevice
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
        /// <para type="description">"Type of the object for which scoped inventory needs to be run."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Type
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> Values
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New TaskFabricMosScopedInventory.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightTaskFabricMosScopedInventory")]
    public class NewIntersightTaskFabricMosScopedInventory : NewCmdletBase
    {
        public NewIntersightTaskFabricMosScopedInventory()
        {
            ApiInstance = new TaskApi(Config);
            ModelObject = new TaskFabricMosScopedInventory();
            MethodName = "CreateTaskFabricMosScopedInventoryWithHttpInfo";
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
        /// <para type="description">"Device will immediately collect the objects from the platform. If false, the device will wait for any in flight scheduled collections to complete first. Used to ensure that any long running collections do not delay the scoped collection result."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Immediate
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
        /// <para type="description">"A property that uniquely identifies the object to be inventoried as a part of the scoped inventory."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string NamingProperty
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"Set of queries to identify objects to be inventoried as part of this scoped inventory action."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object Queries
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetDeviceRegistrationRelationship RegisteredDevice
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
        /// <para type="description">"Type of the object for which scoped inventory needs to be run."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Type
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> Values
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New TaskHciScopedInventory.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightTaskHciScopedInventory")]
    public class NewIntersightTaskHciScopedInventory : NewCmdletBase
    {
        public NewIntersightTaskHciScopedInventory()
        {
            ApiInstance = new TaskApi(Config);
            ModelObject = new TaskHciScopedInventory();
            MethodName = "CreateTaskHciScopedInventoryWithHttpInfo";
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
        /// <para type="description">"Device will immediately collect the objects from the platform. If false, the device will wait for any in flight scheduled collections to complete first. Used to ensure that any long running collections do not delay the scoped collection result."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Immediate
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
        /// <para type="description">"A property that uniquely identifies the object to be inventoried as a part of the scoped inventory."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string NamingProperty
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"Set of queries to identify objects to be inventoried as part of this scoped inventory action."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object Queries
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetDeviceRegistrationRelationship RegisteredDevice
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
        /// <para type="description">"Type of the object for which scoped inventory needs to be run."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Type
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> Values
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New TaskHitachiScopedInventory.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightTaskHitachiScopedInventory")]
    public class NewIntersightTaskHitachiScopedInventory : NewCmdletBase
    {
        public NewIntersightTaskHitachiScopedInventory()
        {
            ApiInstance = new TaskApi(Config);
            ModelObject = new TaskHitachiScopedInventory();
            MethodName = "CreateTaskHitachiScopedInventoryWithHttpInfo";
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
        /// <para type="description">"Device will immediately collect the objects from the platform. If false, the device will wait for any in flight scheduled collections to complete first. Used to ensure that any long running collections do not delay the scoped collection result."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Immediate
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
        /// <para type="description">"A property that uniquely identifies the object to be inventoried as a part of the scoped inventory."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string NamingProperty
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"Set of queries to identify objects to be inventoried as part of this scoped inventory action."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object Queries
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetDeviceRegistrationRelationship RegisteredDevice
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
        /// <para type="description">"Type of the object for which scoped inventory needs to be run."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Type
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> Values
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New TaskHyperFlexManagementScopedInventory.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightTaskHyperFlexManagementScopedInventory")]
    public class NewIntersightTaskHyperFlexManagementScopedInventory : NewCmdletBase
    {
        public NewIntersightTaskHyperFlexManagementScopedInventory()
        {
            ApiInstance = new TaskApi(Config);
            ModelObject = new TaskHyperFlexManagementScopedInventory();
            MethodName = "CreateTaskHyperFlexManagementScopedInventoryWithHttpInfo";
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
        /// <para type="description">"Device will immediately collect the objects from the platform. If false, the device will wait for any in flight scheduled collections to complete first. Used to ensure that any long running collections do not delay the scoped collection result."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Immediate
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
        /// <para type="description">"A property that uniquely identifies the object to be inventoried as a part of the scoped inventory."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string NamingProperty
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"Set of queries to identify objects to be inventoried as part of this scoped inventory action."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object Queries
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetDeviceRegistrationRelationship RegisteredDevice
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
        /// <para type="description">"Type of the object for which scoped inventory needs to be run."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Type
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> Values
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New TaskHyperflexScopedInventory.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightTaskHyperflexScopedInventory")]
    public class NewIntersightTaskHyperflexScopedInventory : NewCmdletBase
    {
        public NewIntersightTaskHyperflexScopedInventory()
        {
            ApiInstance = new TaskApi(Config);
            ModelObject = new TaskHyperflexScopedInventory();
            MethodName = "CreateTaskHyperflexScopedInventoryWithHttpInfo";
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
        /// <para type="description">"Device will immediately collect the objects from the platform. If false, the device will wait for any in flight scheduled collections to complete first. Used to ensure that any long running collections do not delay the scoped collection result."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Immediate
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
        /// <para type="description">"A property that uniquely identifies the object to be inventoried as a part of the scoped inventory."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string NamingProperty
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"Set of queries to identify objects to be inventoried as part of this scoped inventory action."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object Queries
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetDeviceRegistrationRelationship RegisteredDevice
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
        /// <para type="description">"Type of the object for which scoped inventory needs to be run."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Type
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> Values
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New TaskMdsScopedInventory.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightTaskMdsScopedInventory")]
    public class NewIntersightTaskMdsScopedInventory : NewCmdletBase
    {
        public NewIntersightTaskMdsScopedInventory()
        {
            ApiInstance = new TaskApi(Config);
            ModelObject = new TaskMdsScopedInventory();
            MethodName = "CreateTaskMdsScopedInventoryWithHttpInfo";
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
        /// <para type="description">"Device will immediately collect the objects from the platform. If false, the device will wait for any in flight scheduled collections to complete first. Used to ensure that any long running collections do not delay the scoped collection result."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Immediate
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
        /// <para type="description">"A property that uniquely identifies the object to be inventoried as a part of the scoped inventory."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string NamingProperty
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"Set of queries to identify objects to be inventoried as part of this scoped inventory action."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object Queries
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetDeviceRegistrationRelationship RegisteredDevice
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
        /// <para type="description">"Type of the object for which scoped inventory needs to be run."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Type
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> Values
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New TaskMdsSystemScopedInventory.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightTaskMdsSystemScopedInventory")]
    public class NewIntersightTaskMdsSystemScopedInventory : NewCmdletBase
    {
        public NewIntersightTaskMdsSystemScopedInventory()
        {
            ApiInstance = new TaskApi(Config);
            ModelObject = new TaskMdsSystemScopedInventory();
            MethodName = "CreateTaskMdsSystemScopedInventoryWithHttpInfo";
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
        /// <para type="description">"Device will immediately collect the objects from the platform. If false, the device will wait for any in flight scheduled collections to complete first. Used to ensure that any long running collections do not delay the scoped collection result."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Immediate
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
        /// <para type="description">"A property that uniquely identifies the object to be inventoried as a part of the scoped inventory."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string NamingProperty
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"Set of queries to identify objects to be inventoried as part of this scoped inventory action."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object Queries
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetDeviceRegistrationRelationship RegisteredDevice
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
        /// <para type="description">"Type of the object for which scoped inventory needs to be run."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Type
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> Values
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New TaskMerakiScopedInventory.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightTaskMerakiScopedInventory")]
    public class NewIntersightTaskMerakiScopedInventory : NewCmdletBase
    {
        public NewIntersightTaskMerakiScopedInventory()
        {
            ApiInstance = new TaskApi(Config);
            ModelObject = new TaskMerakiScopedInventory();
            MethodName = "CreateTaskMerakiScopedInventoryWithHttpInfo";
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
        /// <para type="description">"Device will immediately collect the objects from the platform. If false, the device will wait for any in flight scheduled collections to complete first. Used to ensure that any long running collections do not delay the scoped collection result."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Immediate
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
        /// <para type="description">"A property that uniquely identifies the object to be inventoried as a part of the scoped inventory."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string NamingProperty
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"Set of queries to identify objects to be inventoried as part of this scoped inventory action."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object Queries
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetDeviceRegistrationRelationship RegisteredDevice
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
        /// <para type="description">"Type of the object for which scoped inventory needs to be run."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Type
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> Values
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New TaskNetAppScopedInventory.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightTaskNetAppScopedInventory")]
    public class NewIntersightTaskNetAppScopedInventory : NewCmdletBase
    {
        public NewIntersightTaskNetAppScopedInventory()
        {
            ApiInstance = new TaskApi(Config);
            ModelObject = new TaskNetAppScopedInventory();
            MethodName = "CreateTaskNetAppScopedInventoryWithHttpInfo";
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
        /// <para type="description">"Device will immediately collect the objects from the platform. If false, the device will wait for any in flight scheduled collections to complete first. Used to ensure that any long running collections do not delay the scoped collection result."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Immediate
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
        /// <para type="description">"A property that uniquely identifies the object to be inventoried as a part of the scoped inventory."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string NamingProperty
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"Set of queries to identify objects to be inventoried as part of this scoped inventory action."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object Queries
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetDeviceRegistrationRelationship RegisteredDevice
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
        /// <para type="description">"Type of the object for which scoped inventory needs to be run."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Type
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> Values
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New TaskNexusScopedInventory.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightTaskNexusScopedInventory")]
    public class NewIntersightTaskNexusScopedInventory : NewCmdletBase
    {
        public NewIntersightTaskNexusScopedInventory()
        {
            ApiInstance = new TaskApi(Config);
            ModelObject = new TaskNexusScopedInventory();
            MethodName = "CreateTaskNexusScopedInventoryWithHttpInfo";
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
        /// <para type="description">"Device will immediately collect the objects from the platform. If false, the device will wait for any in flight scheduled collections to complete first. Used to ensure that any long running collections do not delay the scoped collection result."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Immediate
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
        /// <para type="description">"A property that uniquely identifies the object to be inventoried as a part of the scoped inventory."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string NamingProperty
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"Set of queries to identify objects to be inventoried as part of this scoped inventory action."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object Queries
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetDeviceRegistrationRelationship RegisteredDevice
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
        /// <para type="description">"Type of the object for which scoped inventory needs to be run."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Type
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> Values
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New TaskNexusSystemScopedInventory.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightTaskNexusSystemScopedInventory")]
    public class NewIntersightTaskNexusSystemScopedInventory : NewCmdletBase
    {
        public NewIntersightTaskNexusSystemScopedInventory()
        {
            ApiInstance = new TaskApi(Config);
            ModelObject = new TaskNexusSystemScopedInventory();
            MethodName = "CreateTaskNexusSystemScopedInventoryWithHttpInfo";
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
        /// <para type="description">"Device will immediately collect the objects from the platform. If false, the device will wait for any in flight scheduled collections to complete first. Used to ensure that any long running collections do not delay the scoped collection result."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Immediate
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
        /// <para type="description">"A property that uniquely identifies the object to be inventoried as a part of the scoped inventory."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string NamingProperty
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"Set of queries to identify objects to be inventoried as part of this scoped inventory action."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object Queries
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetDeviceRegistrationRelationship RegisteredDevice
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
        /// <para type="description">"Type of the object for which scoped inventory needs to be run."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Type
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> Values
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New TaskNexusVlanScopedInventory.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightTaskNexusVlanScopedInventory")]
    public class NewIntersightTaskNexusVlanScopedInventory : NewCmdletBase
    {
        public NewIntersightTaskNexusVlanScopedInventory()
        {
            ApiInstance = new TaskApi(Config);
            ModelObject = new TaskNexusVlanScopedInventory();
            MethodName = "CreateTaskNexusVlanScopedInventoryWithHttpInfo";
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
        /// <para type="description">"Device will immediately collect the objects from the platform. If false, the device will wait for any in flight scheduled collections to complete first. Used to ensure that any long running collections do not delay the scoped collection result."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Immediate
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
        /// <para type="description">"A property that uniquely identifies the object to be inventoried as a part of the scoped inventory."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string NamingProperty
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"Set of queries to identify objects to be inventoried as part of this scoped inventory action."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object Queries
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetDeviceRegistrationRelationship RegisteredDevice
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
        /// <para type="description">"Type of the object for which scoped inventory needs to be run."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Type
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> Values
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New TaskPureScopedInventory.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightTaskPureScopedInventory")]
    public class NewIntersightTaskPureScopedInventory : NewCmdletBase
    {
        public NewIntersightTaskPureScopedInventory()
        {
            ApiInstance = new TaskApi(Config);
            ModelObject = new TaskPureScopedInventory();
            MethodName = "CreateTaskPureScopedInventoryWithHttpInfo";
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
        /// <para type="description">"Device will immediately collect the objects from the platform. If false, the device will wait for any in flight scheduled collections to complete first. Used to ensure that any long running collections do not delay the scoped collection result."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Immediate
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
        /// <para type="description">"A property that uniquely identifies the object to be inventoried as a part of the scoped inventory."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string NamingProperty
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"Set of queries to identify objects to be inventoried as part of this scoped inventory action."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object Queries
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetDeviceRegistrationRelationship RegisteredDevice
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
        /// <para type="description">"Type of the object for which scoped inventory needs to be run."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Type
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> Values
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New TaskServerScopedInventory.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightTaskServerScopedInventory")]
    public class NewIntersightTaskServerScopedInventory : NewCmdletBase
    {
        public NewIntersightTaskServerScopedInventory()
        {
            ApiInstance = new TaskApi(Config);
            ModelObject = new TaskServerScopedInventory();
            MethodName = "CreateTaskServerScopedInventoryWithHttpInfo";
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
        /// <para type="description">"Device will immediately collect the objects from the platform. If false, the device will wait for any in flight scheduled collections to complete first. Used to ensure that any long running collections do not delay the scoped collection result."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Immediate
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
        /// <para type="description">"A property that uniquely identifies the object to be inventoried as a part of the scoped inventory."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string NamingProperty
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"Set of queries to identify objects to be inventoried as part of this scoped inventory action."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object Queries
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetDeviceRegistrationRelationship RegisteredDevice
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
        /// <para type="description">"Type of the object for which scoped inventory needs to be run."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Type
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> Values
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New TaskWorkflowAction.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightTaskWorkflowAction")]
    public class NewIntersightTaskWorkflowAction : NewCmdletBase
    {
        public NewIntersightTaskWorkflowAction()
        {
            ApiInstance = new TaskApi(Config);
            ModelObject = new TaskWorkflowAction();
            MethodName = "CreateTaskWorkflowActionWithHttpInfo";
        }



        // <summary>
        /// <para type="description">"Action for test workflow.\n* `start` - Start action for the workflow.\n* `stop` - Stop action for the workflow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public TaskWorkflowAction.ActionEnum Action
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
        /// <para type="description">"Json formatted string input parameters to workflow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string InputParams
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"When true, this workflow type will be triggered as a dynamic workflow, if not it will be treated as a static workflow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool IsDynamic
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
        /// <para type="description">"When true, the retry operation can be performed on the workflow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Retryable
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"This key can be set so that the workflow execution can be sequenced with workflows having the same key. An example usecase is say there are diferent workflows which operate on the server, and are executed at the same time on the same server and the sequence key for all the workflows are same, then workflow engine will enforce that the workflow execution are sequenced and started one after the other, based on timestamp of the arrival of the execution requests."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SequenceKey
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
        /// <para type="description">"When true, the workflow will wait for previous one to complete before starting a new one."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool WaitOnDuplicate
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Json formatted string that has the contents of the workflow context used when starting a workflow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string WorkflowContext
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Path to workflow metadata file that will be published and started."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public TaskFileDownloadInfo WorkflowFile
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set TaskWorkflowAction.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightTaskWorkflowAction")]
    public class SetIntersightTaskWorkflowAction : SetCmdletBase
    {
        public SetIntersightTaskWorkflowAction()
        {
            ApiInstance = new TaskApi(Config);
            ModelObject = new TaskWorkflowAction();
            MethodName = "UpdateTaskWorkflowActionWithHttpInfo";
        }



        // <summary>
        /// <para type="description">"Action for test workflow.\n* `start` - Start action for the workflow.\n* `stop` - Stop action for the workflow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public TaskWorkflowAction.ActionEnum Action
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
        /// <para type="description">"Json formatted string input parameters to workflow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string InputParams
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"When true, this workflow type will be triggered as a dynamic workflow, if not it will be treated as a static workflow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool IsDynamic
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
        /// <para type="description">"When true, the retry operation can be performed on the workflow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Retryable
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"This key can be set so that the workflow execution can be sequenced with workflows having the same key. An example usecase is say there are diferent workflows which operate on the server, and are executed at the same time on the same server and the sequence key for all the workflows are same, then workflow engine will enforce that the workflow execution are sequenced and started one after the other, based on timestamp of the arrival of the execution requests."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SequenceKey
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
        /// <para type="description">"When true, the workflow will wait for previous one to complete before starting a new one."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool WaitOnDuplicate
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Json formatted string that has the contents of the workflow context used when starting a workflow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string WorkflowContext
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Path to workflow metadata file that will be published and started."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public TaskFileDownloadInfo WorkflowFile
        {
            get;
            set;
        }

    }
}