using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexAlarm.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexAlarm", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexAlarm : GetCmdletBase
    {
        public GetIntersightHyperflexAlarm()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexAlarmListWithHttpInfo";
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
        /// <para type="description">"The acknowledgement state of the alarm. It is 'true' when the alarm is acknowledged and false otherwise."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool Acknowledged
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The username of the user who acknowledged the alarm."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string AcknowledgedBy
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The time when the alarm was acknowledged, represented as a Unix timestamp."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long AcknowledgedTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The time when the alarm was acknowledged in ISO 6801 format."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string AcknowledgedTimeAsUtc
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"A reference to a hyperflexCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexClusterRelationship Cluster
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
        /// <para type="description">"The description of the alarm which includes information about the fault that triggered the alarm."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

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
        /// <para type="description">"The data pertaining to this entity."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string EntityData
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The name of entity which triggered the alarm."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string EntityName
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The type of entity which triggered the alarm. For example, this can be the cluster, a node, or VM running on the cluster.\n* `UNKNOWN` - The type of entity is not known.\n* `DISK` - The entity is a physical storage device.\n* `NODE` - The entity is a HyperFlex cluster node.\n* `CLUSTER` - The entity is the HyperFlex cluster itself.\n* `DATASTORE` - The entity is a logical datastore configured on the HyperFlex cluster.\n* `ZONE` - The entity is a logical or physical zone configured on the HyperFlex cluster.\n* `VIRTUALMACHINE` - The entity is a virtual machine running on the HyperFlex cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexAlarm.EntityTypeEnum EntityType
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The unique identifier of the entity which triggered the alarm."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string EntityUuId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The localized message displayed to the user which describes the alarm."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Message
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
        /// <para type="description">"The name of the alarm. This name identifies the type of alarm that was triggered."</para>
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
        /// <para type="description">"Intersight provides pre-built workflows, tasks and policies to end users through global catalogs.\nObjects that are made available through global catalogs are said to have a 'shared' ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SharedScope
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The severity of the alarm.\n* `UNKNOWN` - The alarm status is not known.\n* `CLEARED` - The event that triggered the alarm has been remedied and no longer requires the user's attention.\n* `INFO` - The alarm represents a message that does not require the user's immediate attention.\n* `WARNING` - The alarm represents a moderate fault.\n* `CRITICAL` - The alarm represents a critical fault."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexAlarm.StatusEnum Status
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The time when alarm was triggered as a Unix timestamp."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long TriggeredTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The time when alarm was triggered in ISO 6801 UTC format."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string TriggeredTimeAsUtc
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The unique identifier for this alarm instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Uuid
        {
            get;
            set;
        }



    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexAppCatalog.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexAppCatalog", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexAppCatalog : GetCmdletBase
    {
        public GetIntersightHyperflexAppCatalog()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexAppCatalogListWithHttpInfo";
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
        /// <para type="description">"A reference to a hyperflexFeatureLimitExternal resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexFeatureLimitExternalRelationship FeatureLimitExternal
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a hyperflexFeatureLimitInternal resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexFeatureLimitInternalRelationship FeatureLimitInternal
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
        /// <para type="description">"A reference to a hyperflexServerFirmwareVersion resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexServerFirmwareVersionRelationship ServerFirmwareVersion
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a hyperflexServerModel resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexServerModelRelationship ServerModel
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
        /// <para type="description">"The catalog version used in HyperFlex cluster configuration service."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Version
        {
            get;
            set;
        }



    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexAutoSupportPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexAutoSupportPolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexAutoSupportPolicy : GetCmdletBase
    {
        public GetIntersightHyperflexAutoSupportPolicy()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexAutoSupportPolicyListWithHttpInfo";
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
        /// <para type="description">"Enable or disable Auto-Support."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool AdminState
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
        /// <para type="description">"Description of the policy."</para>
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
        /// <para type="description">"Name of the concrete policy."</para>
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
        /// <para type="description">"The recipient email address for support tickets."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^$|^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$")]
        public string ServiceTicketReceipient
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




    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexBackupCluster.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexBackupCluster", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexBackupCluster : GetCmdletBase
    {
        public GetIntersightHyperflexBackupCluster()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexBackupClusterListWithHttpInfo";
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
        /// <para type="description">"Defines the backup source cluster and its references."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string BackupDataStore
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
        /// <para type="description">"A reference to a hyperflexCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexClusterRelationship SrcCluster
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"UUID for the cluster to allow lookups across unclaim/reclaim."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SrcClusterUuid
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a hyperflexCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexClusterRelationship TgtCluster
        {
            get;
            set;
        }



    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexCapabilityInfo.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexCapabilityInfo", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexCapabilityInfo : GetCmdletBase
    {
        public GetIntersightHyperflexCapabilityInfo()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexCapabilityInfoListWithHttpInfo";
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
        /// <para type="description">"A reference to a hyperflexAppCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexAppCatalogRelationship AppCatalog
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
        /// <para type="description">"Name of the capability or feature set consisting of a collection of constraint rules and value."</para>
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
        /// <para type="description">"Intersight provides pre-built workflows, tasks and policies to end users through global catalogs.\nObjects that are made available through global catalogs are said to have a 'shared' ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SharedScope
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Capability Value which is valid only iff all specified constraints match."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Value
        {
            get;
            set;
        }



    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexCluster.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexCluster", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexCluster : GetCmdletBase
    {
        public GetIntersightHyperflexCluster()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexClusterListWithHttpInfo";
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
        /// <para type="description">"A reference to a policyAbstractProfile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public PolicyAbstractProfileRelationship AssociatedProfile
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The number of days remaining before the cluster's storage utilization reaches the recommended capacity limit of 76%.\nDefault value is math.MaxInt32 to indicate that the capacity runway is \"Unknown\" for a cluster that is not connected or with not sufficient data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long CapacityRunway
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The name of this HyperFlex cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string ClusterName
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"This can be a Storage or Compute cluster. A storage cluster contains storage nodes that are used to persist data. A compute cluster contains compute nodes that are used for executing business logic.\n* `Storage` - Cluster of storage nodes used to persist data.\n* `Compute` - Cluster of compute nodes used to execute business logic.\n* `Unknown` - This cluster type is Unknown. Expect Compute or Storage as valid values."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexCluster.ClusterPurposeEnum ClusterPurpose
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The storage type of this cluster (All Flash or Hybrid)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long ClusterType
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The unique identifier for this HyperFlex cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string ClusterUuid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The number of compute nodes that belong to this cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long ComputeNodeCount
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The number of converged nodes that belong to this cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long ConvergedNodeCount
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
        /// <para type="description">"The deployment type of the HyperFlex cluster.\nThe cluster can have one of the following configurations:\n1. Datacenter: The HyperFlex cluster consists of UCS Fabric Interconnect-attached nodes on a single site.\n2. Stretched Cluster: The HyperFlex cluster consists of UCS Fabric Interconnect-attached nodes distributed across multiple sites.\n3. Edge: The HyperFlex cluster consists of 2-4 standalone nodes.\nIf the cluster is running a HyperFlex Data Platform version less than 4.0 or if the deployment type cannot be determined,\nthe deployment type is set as 'NA' (not available).\n* `NA` - The deployment type of the HyperFlex cluster is not available.\n* `Datacenter` - The deployment type of a HyperFlex cluster consisting of UCS Fabric Interconnect-attached nodes on the same site.\n* `Stretched Cluster` - The deployment type of a HyperFlex cluster consisting of UCS Fabric Interconnect-attached nodes across different sites.\n* `Edge` - The deployment type of a HyperFlex cluster consisting of 2 or more standalone nodes.\n* `DC-No-FI` - The deployment type of a HyperFlex cluster consisting of 3 or more standalone nodes with the required Datacenter license."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexCluster.DeploymentTypeEnum DeploymentType
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The unique identifier of the device registration that represents this HyperFlex cluster's connection to Intersight."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string DeviceId
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
        /// <para type="description">"The type of the drives used for storage in this cluster.\n* `NA` - The drive type of the cluster is not available.\n* `All-Flash` - Indicates that this cluster contains flash drives only.\n* `Hybrid` - Indicates that this cluster contains both flash and hard disk drives."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexCluster.DriveTypeEnum DriveType
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a hyperflexEncryption resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexEncryptionRelationship Encryption
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"This captures the encryption status for a HyperFlex cluster.\nCurrently it will have the status if HXA-CLU-0020 alarm is raised. In the future it can capture other details."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string EncryptionStatus
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The number of yellow (warning) and red (critical) alarms stored as an aggregate.\nThe first 16 bits indicate the number of red alarms, and the last 16 bits contain the number of yellow alarms."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long FltAggr
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a hyperflexHealth resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexHealthRelationship Health
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The HyperFlex Data or Application Platform version of this cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string HxVersion
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The version and build number of the HyperFlex Data Platform for this cluster.\nAfter a cluster upgrade, this version string will be updated on the next inventory cycle to reflect\nthe newly installed version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string HxdpBuildVersion
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Identifies the broad type of the underlying hypervisor.\n* `ESXi` - The hypervisor running on the HyperFlex cluster is a Vmware ESXi hypervisor of any version.\n* `Hyper-V` - The hypervisor running on the HyperFlex cluster is Microsoft Hyper-V.\n* `Unknown` - The hypervisor running on the HyperFlex cluster is not known."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexCluster.HypervisorTypeEnum HypervisorType
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The version of hypervisor running on this cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string HypervisorVersion
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The internally generated identity of this cluster. \nThis entity is not manipulated by users. It aids in uniquely identifying \nthe cluster object. In case of VMware, this is a MOR (managed object reference)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Identity
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a hyperflexLicense resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexLicenseRelationship License
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
        /// <para type="description">"The user-provided name for this cluster to facilitate identification."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^[a-zA-Z0-9]+[\\sa-zA-Z0-9_-]{1,32}$")]
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
        /// <para type="description">"A reference to a computeBaseCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public ComputeBaseClusterRelationship ParentCluster
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public AssetDeviceRegistrationRelationship RegisteredDevice
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
        /// <para type="description">"Cluster health status as reported by the hypervisor platform.\n* `Unknown` - Entity status is unknown.\n* `Degraded` - State is degraded, and might impact normal operation of the entity.\n* `Critical` - Entity is in a critical state, impacting operations.\n* `Ok` - Entity status is in a stable state, operating normally."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexCluster.StatusEnum Status
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The storage capacity in this cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long StorageCapacity
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a vrfVrf resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public VrfVrfRelationship StorageClientVrf
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The number of storage nodes that belong to this cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long StorageNodeCount
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The storage utilization is computed based on total capacity and current capacity utilization."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public float StorageUtilization
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"The upgrade status of the HyperFlex cluster.\n* `Unknown` - The upgrade status of the HyperFlex cluster could not be determined.\n* `Ok` - The upgrade of the HyperFlex cluster is complete.\n* `InProgress` - The upgrade of the HyperFlex cluster is in-progress.\n* `Failed` - The upgrade of the HyperFlex cluster has failed.\n* `Waiting` - The upgrade of the HyperFlex cluster is waiting to continue execution."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexCluster.UpgradeStatusEnum UpgradeStatus
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The uplink speed information of the HyperFlex cluster.\n* `Unknown` - The uplink speed could not be determined. The physical servers are potentially not claimed.\n* `10G` - The uplink speed is 10G.\n* `1G` - The uplink speed is 1G."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexCluster.UplinkSpeedEnum UplinkSpeed
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The storage utilization percentage is computed based on total capacity and current capacity utilization."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public float UtilizationPercentage
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The storage utilization trend percentage represents the trend in percentage computed using the first and last point from historical data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public float UtilizationTrendPercentage
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"The number of virtual machines present on this cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long VmCount
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The type of availability zone used by the cluster. Physical zones are always used in HyperFlex\nStretched Clusters. Logical zones may be used if a cluster has Logical Availability Zones (LAZ)\nenabled.\n* `UNKNOWN` - The type of zone configured on the HyperFlex cluster is not known.\n* `NOT_CONFIGURED` - The zone type is not configured.\n* `LOGICAL` - The zone is a logical zone created when the logical availability zones (LAZ) feature is enabled on the HyperFlex cluster.\n* `PHYSICAL` - The zone is a physical zone configured on a stretched HyperFlex cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexCluster.ZoneTypeEnum ZoneType
        {
            get;
            set;
        }


    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexClusterBackupPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexClusterBackupPolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexClusterBackupPolicy : GetCmdletBase
    {
        public GetIntersightHyperflexClusterBackupPolicy()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexClusterBackupPolicyListWithHttpInfo";
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
        /// <para type="description">"Backup datastore name prefix used during the auto creation of the datastore. All VMs created in this datastore will be automatically backed up."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string BackupDataStoreName
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Replication data store size in backupDataStoreSizeUnit."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long BackupDataStoreSize
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Replication data store size."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string BackupDataStoreSizeUnit
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a hyperflexCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexClusterRelationship BackupTarget
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
        /// <para type="description">"Whether the datastore is encrypted or not."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool DataStoreEncryptionEnabled
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Description of the policy."</para>
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
        /// <para type="description">"Number of snapshots that will be retained as part of the Multi Point in Time support."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidateRange(1, 30)]
        public long LocalSnapshotRetentionCount
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
        /// <para type="description">"Name of the concrete policy."</para>
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
        /// <para type="description">"Replication cluster pairing name prefix."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string ReplicationPairNamePrefix
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
        /// <para type="description">"Number of snapshots that will be retained as part of the Multi Point in Time support."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidateRange(1, 30)]
        public long SnapshotRetentionCount
        {
            get;
            set;
        }




    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexClusterBackupPolicyDeployment.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexClusterBackupPolicyDeployment", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexClusterBackupPolicyDeployment : GetCmdletBase
    {
        public GetIntersightHyperflexClusterBackupPolicyDeployment()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexClusterBackupPolicyDeploymentListWithHttpInfo";
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
        /// <para type="description">"Backup data store name used during the auto creation of the datastore. All VMs created in this data store will be automatically backed up."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string BackupDataStoreName
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Replication data store size in backupDataStoreSizeUnit."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long BackupDataStoreSize
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Replication data store size."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string BackupDataStoreSizeUnit
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a hyperflexCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexClusterRelationship BackupTarget
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
        /// <para type="description">"Whether the datastore is encrypted or not."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool DataStoreEncryptionEnabled
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Description from corresponding ClusterBackupPolicy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Description
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"True if record created by discovery on HyperFlex cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool Discovered
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
        /// <para type="description">"Number of snapshots that will be retained as part of the Multi Point in Time support."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidateRange(1, 30)]
        public long LocalSnapshotRetentionCount
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
        /// <para type="description">"Name from corresponding ClusterBackupPolicy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

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
        /// <para type="description">"Deployed cluster policy moid."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string PolicyMoid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Deployed cluster profile moid."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string ProfileMoid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Replication cluster pairing name prefix."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string ReplicationPairNamePrefix
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
        /// <para type="description">"Number of snapshots that will be retained as part of the Multi Point in Time support."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidateRange(1, 30)]
        public long SnapshotRetentionCount
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a hyperflexCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexClusterRelationship SourceCluster
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"True if policy was detached from source Hyperflex Cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool SourceDetached
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Unique source cluster request ID allowing retry of the same logical request following a transient communication failure."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SourceRequestId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Uuid of the source Hyperflex Cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SourceUuid
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"True if policy was detached from target Hyperflex Cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool TargetDetached
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Unique target cluster request ID allowing retry of the same logical request following a transient communication failure."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string TargetRequestId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Uuid of the target Hyperflex Cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string TargetUuid
        {
            get;
            set;
        }



    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexClusterBackupPolicyInventory.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexClusterBackupPolicyInventory", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexClusterBackupPolicyInventory : GetCmdletBase
    {
        public GetIntersightHyperflexClusterBackupPolicyInventory()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexClusterBackupPolicyInventoryListWithHttpInfo";
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
        /// <para type="description">"Validate, Deploy, Prepare, Commit, or Abort the Backup Policy. Allowed values are \"VALIDATE\", \"DEPLOY\", \"PREPARE\", \"COMMIT\", \"ABORT\".\n* `VALIDATE` - Check for problems in policy request without deploying.\n* `DEPLOY` - Remove the policy.  Only allowed when cleanup field is true.\n* `PREPARE` - Prepare the policy for subsequent \"COMMIT\" or \"ABORT\".  Only allowed when cleanup field is false.\n* `COMMIT` - Commit the prepared policy.  Only allowed when cleanup field is false.\n* `ABORT` - Abort the prepared policy.  Only allowed when cleanup field is false."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexClusterBackupPolicyInventory.ActionEnum Action
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"If true, remove the policy. Otherwise proceed with the specified policy action."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool Cleanup
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
        /// <para type="description">"Indicates if the HyperFlex Cluster is the source cluster or the target cluster. When set to true, the HyperFlex Cluster is the source for VM backups. When set to false, the HyperFlex Cluster is the target cluster where VM backups are saved."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool IsSource
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Details from associated HyperFlex job execution."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string JobDetails
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Job Exception message from associated HyperFlex job execution."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string JobExceptionMessage
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Job ID of associated HyperFlex job."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string JobId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"State of the associated HyperFlex job. When present possible values are \"RUNNING\", \"COMPLETED\" or \"EXCEPTION\".\n* `RUNNING` - HyperFlex policy job is currently \"RUNNING\".\n* `COMPLETED` - HyperFlex policy job completed successfully.\n* `EXCEPTION` - HyperFlex policy job failed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexClusterBackupPolicyInventory.JobStateEnum JobState
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
        /// <para type="description">"Intersight HyperFlex Cluster Backup Policy MOID."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string PolicyMoid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Unique request ID allowing retry of the same logical request following a transient communication failure."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string RequestId
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
        /// <para type="description">"UUID of the source HyperFlex Cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SourceUuid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a hyperflexCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexClusterRelationship SrcCluster
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"UUID of the target HyperFlex Cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string TargetUuid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a hyperflexCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexClusterRelationship TgtCluster
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Version of the Backup Policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long Version
        {
            get;
            set;
        }



    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexClusterHealthCheckExecutionSnapshot.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexClusterHealthCheckExecutionSnapshot", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexClusterHealthCheckExecutionSnapshot : GetCmdletBase
    {
        public GetIntersightHyperflexClusterHealthCheckExecutionSnapshot()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexClusterHealthCheckExecutionSnapshotListWithHttpInfo";
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
        /// <para type="description">"The execution context of the HyperFlex health checks.\n* `UNKNOWN` - The current context of HyperFlex health check execution is unknown.\n* `WORKFLOW` - The HyperFlex health check execution is initiated through an orchestration workflow.\n* `SCHEDULED` - The HyperFlex health check execution is through a scheduled run."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexClusterHealthCheckExecutionSnapshot.ExecutionContextEnum ExecutionContext
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a hyperflexCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexClusterRelationship HxCluster
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
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public AssetDeviceRegistrationRelationship RegisteredDevice
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
        /// <para type="description">"Timestamp of the last health check execution on the HyperFlex cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime Timestamp
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a workflowWorkflowInfo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public WorkflowWorkflowInfoRelationship Workflow
        {
            get;
            set;
        }


    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexClusterNetworkPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexClusterNetworkPolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexClusterNetworkPolicy : GetCmdletBase
    {
        public GetIntersightHyperflexClusterNetworkPolicy()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexClusterNetworkPolicyListWithHttpInfo";
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
        /// <para type="description">"The mode configured on the CIMC management interface.\n* `OutOfBand` - The server uses out-of-band management, i.e. management traffic traverses through the management interfaces on the UCS Fabric Interconnects.\n* `InBand` - The server uses in-band management, i.e. management traffic traverses through the data uplink ports on the UCS Fabric Interconnects."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexClusterNetworkPolicy.CimcManagementModeEnum CimcManagementMode
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
        /// <para type="description">"Description of the policy."</para>
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
        /// <para type="description">"Enable or disable Jumbo Frames (MTU=9000). Jumbo Frames are used by Storage Network, VM Migration Network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool JumboFrame
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
        /// <para type="description">"Name of the concrete policy."</para>
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
        /// <para type="description">"Link speed of the server adapter port to the upstream switch. When the policy is attached to a cluster profile with EDGE management platform, the uplink speed can be '1G' or '10G+'. Use '10G+' for link speeds of 10G or above. When the policy is attached to a cluster profile with Fabric Interconnect management platform, the uplink speed can be 'default' only.\n* `default` - Current default value set on the hardware platform.\n* `1G` - A link speed of 1 gigabit per second.\n* `10G` - A link speed of 10 gigabits per second or above."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexClusterNetworkPolicy.UplinkSpeedEnum UplinkSpeed
        {
            get;
            set;
        }





    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexClusterProfile.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexClusterProfile", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexClusterProfile : GetCmdletBase
    {
        public GetIntersightHyperflexClusterProfile()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexClusterProfileListWithHttpInfo";
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
        /// <para type="description">"User initiated action. Each profile type has its own supported actions. For HyperFlex cluster profile, the supported actions are -- Validate, Deploy, Continue, Retry, Abort, Unassign For server profile, the support actions are -- Deploy, Unassign."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Action
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"A reference to a hyperflexCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexClusterRelationship AssociatedCluster
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a hyperflexAutoSupportPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexAutoSupportPolicyRelationship AutoSupport
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a hyperflexClusterNetworkPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexClusterNetworkPolicyRelationship ClusterNetwork
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a hyperflexClusterStoragePolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexClusterStoragePolicyRelationship ClusterStorage
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a hyperflexConfigResult resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexConfigResultRelationship ConfigResult
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
        /// <para type="description">"The storage data IP address for the HyperFlex cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string DataIpAddress
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Description of the profile."</para>
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
        /// <para type="description">"A reference to a hyperflexExtFcStoragePolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexExtFcStoragePolicyRelationship ExtFcStorage
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a hyperflexExtIscsiStoragePolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexExtIscsiStoragePolicyRelationship ExtIscsiStorage
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The node name prefix that is used to automatically generate the default hostname for each server.\nA dash (-) will be appended to the prefix followed by the node number to form a hostname.\nThis default naming scheme can be manually overridden in the node configuration.\nThe maximum length of a prefix is 60, must only contain alphanumeric characters or dash (-), and must\nstart with an alphanumeric character."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^$|^[a-zA-Z0-9][a-zA-Z0-9-]{1,59}$")]
        public string HostNamePrefix
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a commHttpProxyPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public CommHttpProxyPolicyRelationship Httpproxypolicy
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The hypervisor control virtual IP address for the HyperFlex compute cluster that is used for node/pod management."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string HypervisorControlIpAddress
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The hypervisor type for the HyperFlex cluster.\n* `ESXi` - The hypervisor running on the HyperFlex cluster is a Vmware ESXi hypervisor of any version.\n* `Hyper-V` - The hypervisor running on the HyperFlex cluster is Microsoft Hyper-V.\n* `Unknown` - The hypervisor running on the HyperFlex cluster is not known."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexClusterProfile.HypervisorTypeEnum HypervisorType
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The NIC based setup being set/unset determined by inventory."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool IsNicBased
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a hyperflexLocalCredentialPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexLocalCredentialPolicyRelationship LocalCredential
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The MAC address prefix in the form of 00:25:B5:XX."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^$|^00:25:B5:[0-9a-fA-F]{2}$")]
        public string MacAddressPrefix
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The management IP address for the HyperFlex cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string MgmtIpAddress
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The management platform for the HyperFlex cluster.\n* `FI` - The host servers used in the cluster deployment are managed by a UCS Fabric Interconnect.\n* `EDGE` - The host servers used in the cluster deployment are standalone severs.\n* `DC-No-FI` - The host servers used in the cluster deployment are standalone servers with the DC Advantage license."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexClusterProfile.MgmtPlatformEnum MgmtPlatform
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
        /// <para type="description">"Name of the profile instance or profile template."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^[a-zA-Z0-9_.-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a hyperflexNodeConfigPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexNodeConfigPolicyRelationship NodeConfig
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
        /// <para type="description">"A reference to a hyperflexProxySettingPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexProxySettingPolicyRelationship ProxySetting
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The number of copies of each data block written."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long Replication
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
        /// <para type="description">"A reference to a hyperflexSoftwareVersionPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexSoftwareVersionPolicyRelationship SoftwareVersion
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a policyAbstractProfile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public PolicyAbstractProfileRelationship SrcTemplate
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The storage data IP address for the HyperFlex cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string StorageClientIpAddress
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The netmask for the Storage client network IP address."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string StorageClientNetmask
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The auxiliary storage IP address for the HyperFlex cluster. For two node clusters, this is the IP address of the auxiliary ZK controller."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string StorageClusterAuxiliaryIp
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The storage type used for the HyperFlex cluster (HyperFlex Storage or 3rd party).\n* `HyperFlexDp` - The type of storage is HyperFlex Data Platform.\n* `ThirdParty` - The type of storage is 3rd Party Storage (PureStorage, etc..)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexClusterProfile.StorageTypeEnum StorageType
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a hyperflexSysConfigPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexSysConfigPolicyRelationship SysConfig
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Defines the type of the profile. Accepted values are instance or template.\n* `instance` - The profile defines the configuration for a specific instance of a target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexClusterProfile.TypeEnum Type
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a hyperflexUcsmConfigPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexUcsmConfigPolicyRelationship UcsmConfig
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a hyperflexVcenterConfigPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexVcenterConfigPolicyRelationship VcenterConfig
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The WWxN prefix in the form of 20:00:00:25:B5:XX."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^$|^20:00:00:25:B5:[0-9a-fA-F]{2}$")]
        public string WwxnPrefix
        {
            get;
            set;
        }


    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexClusterReplicationNetworkPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexClusterReplicationNetworkPolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexClusterReplicationNetworkPolicy : GetCmdletBase
    {
        public GetIntersightHyperflexClusterReplicationNetworkPolicy()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexClusterReplicationNetworkPolicyListWithHttpInfo";
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
        /// <para type="description">"Description of the policy."</para>
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
        /// <para type="description">"Name of the concrete policy."</para>
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
        /// <para type="description">"Bandwidth for the Replication network in Mbps."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long ReplicationBandwidthMbps
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"MTU for the Replication network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidateRange(1024, 1500)]
        public long ReplicationMtu
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




    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexClusterReplicationNetworkPolicyDeployment.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexClusterReplicationNetworkPolicyDeployment", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexClusterReplicationNetworkPolicyDeployment : GetCmdletBase
    {
        public GetIntersightHyperflexClusterReplicationNetworkPolicyDeployment()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexClusterReplicationNetworkPolicyDeploymentListWithHttpInfo";
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
        /// <para type="description">"A reference to a hyperflexCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexClusterRelationship Cluster
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Uuid of the HyperFlex cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string ClusterUuid
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
        /// <para type="description">"Description from corresponding ClusterReplicationNetworkPolicy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Description
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"True if record created by discovery on HyperFlex cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool Discovered
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
        /// <para type="description">"Name from corresponding ClusterReplicationNetworkPolicy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

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
        /// <para type="description">"Deployed network policy moid."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string PolicyMoid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Deployed cluster profile moid."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string ProfileMoid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Bandwidth for the Replication network in Mbps."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long ReplicationBandwidthMbps
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"MTU for the Replication network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidateRange(1024, 1500)]
        public long ReplicationMtu
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Unique request ID allowing retry of the same logical request following a transient communication failure."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string RequestId
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




    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexClusterStoragePolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexClusterStoragePolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexClusterStoragePolicy : GetCmdletBase
    {
        public GetIntersightHyperflexClusterStoragePolicy()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexClusterStoragePolicyListWithHttpInfo";
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
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"If enabled, formats existing disk partitions (destroys all user data)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool DiskPartitionCleanup
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
        /// <para type="description">"Name of the concrete policy."</para>
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
        /// <para type="description">"Enable or disable VDI optimization (hybrid HyperFlex systems only)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool VdiOptimization
        {
            get;
            set;
        }



    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexConfigResult.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexConfigResult", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexConfigResult : GetCmdletBase
    {
        public GetIntersightHyperflexConfigResult()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexConfigResultListWithHttpInfo";
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
        /// <para type="description">"A reference to a hyperflexClusterProfile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexClusterProfileRelationship ClusterProfile
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The progress percentage of the running configuration or workflow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string ConfigProgress
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The current running stage of the configuration or workflow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string ConfigStage
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Indicates overall configuration state for applying the configuration to the end point. Values  -- Ok, Ok-with-warning, Errored."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string ConfigState
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
        /// <para type="description">"The duration of the running configuration or workflow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Duration
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
        /// <para type="description">"The start time of the configuration or workflow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string StartTime
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Indicates overall state for logical model validation. Values  -- Ok, Ok-with-warning, Errored."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string ValidationState
        {
            get;
            set;
        }



    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexConfigResultEntry.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexConfigResultEntry", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexConfigResultEntry : GetCmdletBase
    {
        public GetIntersightHyperflexConfigResultEntry()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexConfigResultEntryListWithHttpInfo";
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
        /// <para type="description">"The completed time of the task in installer."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string CompletedTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a hyperflexConfigResult resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexConfigResultRelationship ConfigResult
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
        /// <para type="description">"Localized message based on the locale setting of the user's context."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Message
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
        /// <para type="description">"The identifier of the object that owns the result message.\nThe owner ID is used to correlate a given result entry to a task or entity. For example, a config result\nentry that describes the result of a workflow task may have the task's instance ID as the owner."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string OwnerId
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
        /// <para type="description">"Values  -- Ok, Ok-with-warning, Errored."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string State
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Indicates if the result is reported during the logical model validation/resource allocation phase. or the configuration applying phase. Values -- validation, config."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Type
        {
            get;
            set;
        }



    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexDataProtectionPeer.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexDataProtectionPeer", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexDataProtectionPeer : GetCmdletBase
    {
        public GetIntersightHyperflexDataProtectionPeer()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexDataProtectionPeerListWithHttpInfo";
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
        /// <para type="description">"A reference to a hyperflexCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexClusterRelationship SrcCluster
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a hyperflexCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexClusterRelationship TgtCluster
        {
            get;
            set;
        }



    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexDatastoreStatistic.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexDatastoreStatistic", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexDatastoreStatistic : GetCmdletBase
    {
        public GetIntersightHyperflexDatastoreStatistic()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexDatastoreStatisticListWithHttpInfo";
        }

        // <summary>
        /// <para type="description">"HyperFlex datastore accessibility summary.\n* `ACCESSIBLE` - The HyperFlex Accessibility Summary is Accessible.\n* `NOT_ACCESSIBLE` - The HyperFlex Accessibility Summary is Not Accessible.\n* `PARTIALLY_ACCESSIBLE` - The HyperFlex Accessibility Summary is Partially Accessible."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexDatastoreStatistic.AccessibilitySummaryEnum AccessibilitySummary
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
        /// <para type="description">"The time when this managed object was created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime CreateTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Timestamp the datastore object was created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string CreationTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a hyperflexDataProtectionPeer resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexDataProtectionPeerRelationship DataProtectionPeer
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"HyperFlex Datastore Kind.\n* `UNKNOWN` - HyperFlex datastore kind is unknown.\n* `USER_CREATED` - HyperFlex datastore kind is user created.\n* `INTERNAL` - HyperFlex datastore kind is internal."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexDatastoreStatistic.DatastoreKindEnum DatastoreKind
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"HyperFlex datastore status.\n* `NORMAL` - The HyperFlex datastore status is normal.\n* `ALERT` - The HyperFlex datastore status is alert.\n* `FAILED` - The HyperFlex datastore status is failed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexDatastoreStatistic.DatastoreStatusEnum DatastoreStatus
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
        /// <para type="description">"Free capacity of the datastore in bytes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long FreeCapacityInBytes
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Indicates if the datastore is encrypted or un-encrypted."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool IsEncrypted
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Timestamp the datastore object was last accessed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string LastAccessTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Timestamp the datastore object was last modified."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string LastModifiedTime
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
        /// <para type="description">"HyperFlex datastore mount summary.\n* `MOUNTED` - The HyperFlex mount summary is mounted.\n* `UNMOUNTED` - The HyperFlex mount summary is unmounted.\n* `MOUNT_FAILURE` - The HyperFlex mount summary is mount failure.\n* `UNMOUNT_FAILURE` - The HyperFlex mount summary is unmount failure."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexDatastoreStatistic.MountSummaryEnum MountSummary
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
        /// <para type="description">"UUID of the parent datastore object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string ParentUuid
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
        /// <para type="description">"A reference to a hyperflexCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexClusterRelationship SrcCluster
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a hyperflexCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexClusterRelationship TgtCluster
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Total capacity of the datastore object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long TotalCapacityInBytes
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Number of uncompressed used bytes in the datastore."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long UnCompressedUsedBytes
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Unshared used capacity of the datastore in bytes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long UnsharedUsedBytes
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"UUID for the datastore object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Uuid
        {
            get;
            set;
        }



    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexDevicePackageDownloadState.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexDevicePackageDownloadState", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexDevicePackageDownloadState : GetCmdletBase
    {
        public GetIntersightHyperflexDevicePackageDownloadState()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexDevicePackageDownloadStateListWithHttpInfo";
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
        /// <para type="description">"Checksum of HyperFlex health check Debian package installed on the HyperFlex Device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Checksum
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
        /// <para type="description">"HyperFlex Device Name for which the package download state is tracked."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string HxDeviceName
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
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public AssetDeviceRegistrationRelationship RegisteredDevice
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
        /// <para type="description">"Timestamp of the last health check Debian package installation on the HyperFlex Device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime Timestamp
        {
            get;
            set;
        }



    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexDrive.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexDrive", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexDrive : GetCmdletBase
    {
        public GetIntersightHyperflexDrive()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexDriveListWithHttpInfo";
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
        /// <para type="description">"Provisioned capacity of the drive in bytes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long Capacity
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
        /// <para type="description">"Disk inventory state. Should be one of values defined in enum.\n* `UNKNOWN` - The use state of the disk is unknown.\n* `USED` - The use state of the disk is used.\n* `NOTUSED` - The use state of the disk is unused.\n* `EMPTY` - The use state of the disk is empty."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexDrive.DiskUseStateEnum DiskUseState
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
        /// <para type="description">"Host Name."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string HostName
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The unique identifier of the drive's host."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string HostUuid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a equipmentLocatorLed resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public EquipmentLocatorLedRelationship LocatorLed
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
        /// <para type="description">"The model number of the disk or SSD."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string ModelNumber
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
        /// <para type="description">"A reference to a hyperflexNode resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexNodeRelationship Node
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The unique identifier of the Hyperflex Node to which the disk is attached."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string NodeUuid
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
        /// <para type="description">"Device path for the drive."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Path
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Disk Protocol - SATA, NVME, SAS.\n* `Unknown` - Disk protocol is unknown.\n* `SAS` - Serial Attached SCSI protocol (SAS) used in disk.\n* `NVMe` - Non-volatile memory express (NVMe) protocol used in disk.\n* `SATA` - Serial Advanced Technology Attachment (SATA) used in disk."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexDrive.ProtocolEnum Protocol
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Serial number of the Hyperflex drive."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SerialNumber
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
        /// <para type="description">"The SCSI slot number of the drive."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SlotNumber
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Disk inventory state as determined by storfs inventory module.\nShould be one of values defined in enum.\n* `UNKNOWN` - The state of the disk is unknown.\n* `CLAIMED` - The state of the disk is claimed by storfs and has a valid storfs format.\n* `AVAILABLE` - The disk is available but not claimed by storfs.\n* `IGNORED` - The disk ash been ignored by storfs.\n* `BLACKLISTED` - The deprecated value for 'Blocked'. It is included to maintain backwards compatibility with clusters running a HyperFlex Data Platform version older than 5.0(1a).\n* `SECUREERASED` - The disk has been secure erased.\n* `BLOCKED` - The disk has been blocked by storfs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexDrive.StatusEnum Status
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Type of disk - UNKNOWN, HDD, SSD.\n* `Unknown` - Default unknown disk type.\n* `SSD` - Storage disk with Solid state disk.\n* `HDD` - Storage disk with Hard disk drive.\n* `NVRAM` - Storage disk with Non-volatile random-access memory type.\n* `SATA` - Disk drive implementation with Serial Advanced Technology Attachment (SATA).\n* `BSAS` - Bridged SAS-SATA disks with added hardware to enable them to be plugged into a SAS-connected storage shelf.\n* `FC` - Storage disk with Fiber Channel.\n* `FSAS` - Near Line SAS. NL-SAS drives are enterprise SATA drives with a SAS interface, head, media, androtational speed of traditional enterprise-class SATA drives with the fully capable SAS interfacetypical for classic SAS drives.\n* `LUN` - Logical Unit Number refers to a logical disk.\n* `MSATA` - SATA disk in multi-disk carrier storage shelf.\n* `SAS` - Storage disk with serial attached SCSI.\n* `VMDISK` - Virtual machine Data Disk."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexDrive.TypeEnum Type
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Specifies what the disk is used for. Should be one of\nvalues defined in enum.\n* `UNKNOWN` - The usage of the disk is unknown.\n* `PERSISTENCE` - The usage of the disk is for generic data storage.\n* `SYSTEM` - The usage of the disk is related to system storage.\n* `CACHING` - The usage of the disk is for caching."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexDrive.UsageEnum Usage
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Used Capacity of the drive in Bytes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long UsedCapacity
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The unique identifier of the Hyperflex drive."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Uuid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The firmware version of the Hyperflex drive."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Version
        {
            get;
            set;
        }



    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexEncryption.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexEncryption", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexEncryption : GetCmdletBase
    {
        public GetIntersightHyperflexEncryption()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexEncryptionListWithHttpInfo";
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
        /// <para type="description">"A reference to a hyperflexCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexClusterRelationship Cluster
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
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public MoBaseMoRelationship Parent
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public AssetDeviceRegistrationRelationship RegisteredDevice
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexEncryption.StateEnum State
        {
            get;
            set;
        }




    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexExtFcStoragePolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexExtFcStoragePolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexExtFcStoragePolicy : GetCmdletBase
    {
        public GetIntersightHyperflexExtFcStoragePolicy()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexExtFcStoragePolicyListWithHttpInfo";
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
        /// <para type="description">"Enables or disables external FC storage configuration."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool AdminState
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
        /// <para type="description">"Description of the policy."</para>
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
        /// <para type="description">"Name of the concrete policy."</para>
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





    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexExtIscsiStoragePolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexExtIscsiStoragePolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexExtIscsiStoragePolicy : GetCmdletBase
    {
        public GetIntersightHyperflexExtIscsiStoragePolicy()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexExtIscsiStoragePolicyListWithHttpInfo";
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
        /// <para type="description">"Enable or disable external iSCSI storage configuration."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool AdminState
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
        /// <para type="description">"Description of the policy."</para>
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
        /// <para type="description">"Name of the concrete policy."</para>
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




    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexFeatureLimitExternal.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexFeatureLimitExternal", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexFeatureLimitExternal : GetCmdletBase
    {
        public GetIntersightHyperflexFeatureLimitExternal()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexFeatureLimitExternalListWithHttpInfo";
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
        /// <para type="description">"A reference to a hyperflexAppCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexAppCatalogRelationship AppCatalog
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




    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexFeatureLimitInternal.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexFeatureLimitInternal", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexFeatureLimitInternal : GetCmdletBase
    {
        public GetIntersightHyperflexFeatureLimitInternal()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexFeatureLimitInternalListWithHttpInfo";
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
        /// <para type="description">"A reference to a hyperflexAppCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexAppCatalogRelationship AppCatalog
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




    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexHealth.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexHealth", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexHealth : GetCmdletBase
    {
        public GetIntersightHyperflexHealth()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexHealthListWithHttpInfo";
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
        /// <para type="description">"The status of the HyperFlex cluster's connection to the Intersight arbitration service. The arbitration service state is only applicable to 2-node edge clusters.\n* `NOT_AVAILABLE` - The cluster does not require a connection to the arbitration service.\n* `UNKNOWN` - The cluster's connection state to the arbitration service cannot be determined.\n* `ONLINE` - The cluster is connected to the arbitration service.\n* `OFFLINE` - The cluster is disconnected from the arbitration service."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexHealth.ArbitrationServiceStateEnum ArbitrationServiceState
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a hyperflexCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexClusterRelationship Cluster
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
        /// <para type="description">"The HyperFlex cluster's compliance to the configured replication factor. It indicates that the compliance has degraded if the number of copies of data is reduced.\n* `UNKNOWN` - The replication compliance of the HyperFlex cluster is not known.\n* `COMPLIANT` - The HyperFlex cluster is compliant with the replication policy. All data on the cluster is replicated according to the configured replication factor.\n* `NON_COMPLIANT` - The HyperFlex cluster is not compliant with the replication policy. Some data on the cluster is not replicated in accordance with the configured replication factor."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexHealth.DataReplicationComplianceEnum DataReplicationCompliance
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
        /// <para type="description">"The operational status of the HyperFlex cluster.\n* `UNKNOWN` - The operational status of the cluster cannot be determined.\n* `ONLINE` - The HyperFlex cluster is online and is performing IO operations.\n* `OFFLINE` - The HyperFlex cluster is offline and is not ready to perform IO operations.\n* `ENOSPACE` - The HyperFlex cluster is out of available storage capacity and cannot perform write transactions.\n* `READONLY` - The HyperFlex cluster is not accepting write transactions, but can still display static cluster information."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexHealth.StateEnum State
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The unique identifier for the cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Uuid
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The health status of the HyperFlex cluster's zookeeper ensemble.\n* `NOT_AVAILABLE` - The operational status of the ZK ensemble is not provided by the HyperFlex cluster.\n* `UNKNOWN` - The operational status of the ZK ensemble cannot be determined.\n* `ONLINE` - The ZK ensemble is online and operational.\n* `OFFLINE` - The ZK ensemble is offline and not operational."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexHealth.ZkHealthEnum ZkHealth
        {
            get;
            set;
        }



    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexHealthCheckDefinition.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexHealthCheckDefinition", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexHealthCheckDefinition : GetCmdletBase
    {
        public GetIntersightHyperflexHealthCheckDefinition()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexHealthCheckDefinitionListWithHttpInfo";
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
        /// <para type="description">"Category that the health check belongs to."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Category
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Static information detailing the common causes for the health check failure."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string CommonCauses
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Execution configuration fo the health check script."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Configuration
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
        /// <para type="description">"Description of the health check definition."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

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
        /// <para type="description">"Static information detailing the health impact of the health check failure."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string HealthImpact
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Internal name of the health check definition."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string InternalName
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Minimum HyperFlex version that the check is supported on. Defaults to version 3.0.1."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string MinimumHyperFlexVersion
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
        /// <para type="description">"Name of the health check definition."</para>
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
        /// <para type="description">"Static information containing additional reference for the health check."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Reference
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Static information detailing the possible remediation actions that can be taken to remedy the health check failure."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Resolution
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Execution mode of the health script on the HyperFlex cluster.\n* `ON_DEMAND` - Execute the health check on-demand.\n* `SCHEDULED` - Execute the health check on a scheduled interval."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexHealthCheckDefinition.ScriptExecutionModeEnum ScriptExecutionMode
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Indicates if the script needs to be executed on HyperFlex compute nodes. |\nTypically, scripts are only executed on the storage Nodes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool ScriptExecutionOnComputeNodes
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
        /// <para type="description">"Hypervisor type that the Health Check is supported on (All, if it is hypervisor agnostic).\n* `All` - The Health Check is hypervisor-agnostic.\n* `ESXi` - The Health Check is supported only on Vmware ESXi hypervisor of any version.\n* `HyperV` - The Health Check is supported only on Microsoft HyperV hypervisor."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexHealthCheckDefinition.SupportedHypervisorTypeEnum SupportedHypervisorType
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Indicates whether the health check is executed only on the leader node, or on all nodes in the HyperFlex cluster.\n* `EXECUTE_ON_LEADER_NODE` - Execute the health check script only on the HyperFlex cluster's leader node.\n* `EXECUTE_ON_ALL_NODES` - Execute health check on all nodes and aggregate the results.\n* `EXECUTE_ON_ALL_NODES_AND_AGGREGATE` - Execute the health check on all Nodes and perform custom aggregation.\n* `EXECUTE_ON_CURRENT_NODE` - The HyperFlex health check is executed on the node which receives the request."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexHealthCheckDefinition.TargetExecutionTypeEnum TargetExecutionType
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Health check script execution timeout."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long Timeout
        {
            get;
            set;
        }




    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexHealthCheckExecution.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexHealthCheckExecution", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexHealthCheckExecution : GetCmdletBase
    {
        public GetIntersightHyperflexHealthCheckExecution()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexHealthCheckExecutionListWithHttpInfo";
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
        /// <para type="description">"Category that the HyperFlex health check Definition belongs to."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Category
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Information detailing the possible cause of the healthcheck failure, if the check fails."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Cause
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Health check execution completion time."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime CompletionTime
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
        /// <para type="description">"A reference to a hyperflexHealthCheckDefinition resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexHealthCheckDefinitionRelationship HealthCheckDefinition
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Details of the health check execution result."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string HealthCheckDetails
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Error details of a script execution failure."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string HealthCheckExecutionErrorDetails
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Error summary of a script execution failure."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string HealthCheckExecutionErrorSummary
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Status of the health check execution.\n* `UNKNOWN` - Indicates that the health heck execution results are unknown.\n* `SUCCEEDED` - Indicates that the health check execution succeeded.\n* `FAILED` - Indicates that the health check execution failed.\n* `TIMED_OUT` - Indicates that the health check execution timed out before completion."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexHealthCheckExecution.HealthCheckExecutionStatusEnum HealthCheckExecutionStatus
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Health check execution result. Valid only if HealthCheckExecutionStatus is SUCCEEDED.\n* `UNKNOWN` - Indicates that the health check results could not be determined.\n* `PASS` - Indicates that the health check passed.\n* `FAIL` - Indicates that the health check failed.\n* `WARN` - Indicates that the health check completed with a warning.\n* `NOT_APPLICABLE` - Indicates that the health check is either unsupported, or not applicable on the Cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexHealthCheckExecution.HealthCheckResultEnum HealthCheckResult
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A brief summary of health check results."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string HealthCheckSummary
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"IP Address of the vCenter."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string HealthCheckVcenterIp
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a hyperflexCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexClusterRelationship HxCluster
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"HyperFlex Device Name where the healthcheck is executed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string HxDeviceName
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
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public AssetDeviceRegistrationRelationship RegisteredDevice
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
        /// <para type="description">"Information detailing a suggested resolution for the healthcheck failure, if the check fails."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SuggestedResolution
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"UUID of an instance of health check execution."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Uuid
        {
            get;
            set;
        }



    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexHealthCheckExecutionSnapshot.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexHealthCheckExecutionSnapshot", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexHealthCheckExecutionSnapshot : GetCmdletBase
    {
        public GetIntersightHyperflexHealthCheckExecutionSnapshot()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexHealthCheckExecutionSnapshotListWithHttpInfo";
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
        /// <para type="description">"Category that the HyperFlex health check Definition belongs to."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Category
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Information detailing the possible cause of the healthcheck failure, if the check fails."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Cause
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Health check execution completion time."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime CompletionTime
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
        /// <para type="description">"A reference to a hyperflexHealthCheckDefinition resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexHealthCheckDefinitionRelationship HealthCheckDefinition
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Details of the health check execution result."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string HealthCheckDetails
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Error details of a script execution failure."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string HealthCheckExecutionErrorDetails
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Error summary of a script execution failure."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string HealthCheckExecutionErrorSummary
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Status of the health check execution.\n* `UNKNOWN` - Indicates that the health heck execution results are unknown.\n* `SUCCEEDED` - Indicates that the health check execution succeeded.\n* `FAILED` - Indicates that the health check execution failed.\n* `TIMED_OUT` - Indicates that the health check execution timed out before completion."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexHealthCheckExecutionSnapshot.HealthCheckExecutionStatusEnum HealthCheckExecutionStatus
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Health check execution result. Valid only if HealthCheckExecutionStatus is SUCCEEDED.\n* `UNKNOWN` - Indicates that the health check results could not be determined.\n* `PASS` - Indicates that the health check passed.\n* `FAIL` - Indicates that the health check failed.\n* `WARN` - Indicates that the health check completed with a warning.\n* `NOT_APPLICABLE` - Indicates that the health check is either unsupported, or not applicable on the Cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexHealthCheckExecutionSnapshot.HealthCheckResultEnum HealthCheckResult
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A brief summary of health check results."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string HealthCheckSummary
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"IP Address of the vCenter."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string HealthCheckVcenterIp
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a hyperflexCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexClusterRelationship HxCluster
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"HyperFlex Device Name where the healthcheck is executed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string HxDeviceName
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
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public AssetDeviceRegistrationRelationship RegisteredDevice
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
        /// <para type="description">"Information detailing a suggegsted resolution for the healthcheck failure, if the check fails."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SuggestedResolution
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"A reference to a workflowWorkflowInfo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public WorkflowWorkflowInfoRelationship Workflow
        {
            get;
            set;
        }


    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexHealthCheckPackageChecksum.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexHealthCheckPackageChecksum", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexHealthCheckPackageChecksum : GetCmdletBase
    {
        public GetIntersightHyperflexHealthCheckPackageChecksum()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexHealthCheckPackageChecksumListWithHttpInfo";
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
        /// <para type="description">"SHA512 checksum of the health check package."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Checksum
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
        /// <para type="description">"Name of the health check Debian package."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Name
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"HyperFlex health check Debian package file name."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string PackageName
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
        /// <para type="description">"Timestamp of last update of HyperFlex health check package checksum."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime Timestamp
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"HyperFlex health check Debian Package Version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Version
        {
            get;
            set;
        }



    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexHealthCheckSchedulePolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexHealthCheckSchedulePolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexHealthCheckSchedulePolicy : GetCmdletBase
    {
        public GetIntersightHyperflexHealthCheckSchedulePolicy()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexHealthCheckSchedulePolicyListWithHttpInfo";
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
        /// <para type="description">"The date and time when this HealthCheck Policy was last enabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime LastScheduledOn
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The date and time when this HealthCheck Policy was last disabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime LastUnscheduledOn
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
        /// <para type="description">"The date and time when the next health check execution is expected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime NextExpectedExecution
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
        /// <para type="description">"Indicates whether HealthCheck schedule policy is enabled on the HyperFlex cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool PolicyEnabled
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public AssetDeviceRegistrationRelationship RegisteredDevice
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The frequency at which the health checks are run on the HyperFlex cluster.\n* `86400` - Execute the health check every 24 hours.\n* `43200` - Execute the health check every 12 hours.\n* `21600` - Execute the health check every 6 hours.\n* `10800` - Execute the health check every 3 hours.\n* `3600` - Execute the health check every 1 hours.\n* `300` - Execute the health check every 5 minutes.\n* `0` - Disable the continuous health check."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexHealthCheckSchedulePolicy.ScheduleIntervalEnum ScheduleInterval
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
        /// <para type="description">"The unique identifier of the health check policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Uuid
        {
            get;
            set;
        }



    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexHwCatalog.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexHwCatalog", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexHwCatalog : GetCmdletBase
    {
        public GetIntersightHyperflexHwCatalog()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexHwCatalogListWithHttpInfo";
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
        /// <para type="description">"Hardware catalog version for HyperFlex hardware catalog."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Version
        {
            get;
            set;
        }



    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexHxdpVersion.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexHxdpVersion", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexHxdpVersion : GetCmdletBase
    {
        public GetIntersightHyperflexHxdpVersion()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexHxdpVersionListWithHttpInfo";
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
        /// <para type="description">"A reference to a hyperflexAppCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexAppCatalogRelationship AppCatalog
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
        /// <para type="description">"The HyperFlex Data Platform version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Version
        {
            get;
            set;
        }



    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexHypervisorHost.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexHypervisorHost", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexHypervisorHost : GetCmdletBase
    {
        public GetIntersightHyperflexHypervisorHost()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexHypervisorHostListWithHttpInfo";
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
        /// <para type="description">"A reference to a hyperflexCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexClusterRelationship Cluster
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Memory configured for controller virtual machine."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long ConfiguredMemory
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The display version of HyperFlex software running on the controller VM."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string ControllerVmDisplayVersion
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Platform storage software product display version running on controller VM."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string ControllerVmHxdpDisplayVersion
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Platform storage software product version running on controller VM."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string ControllerVmHxdpVersion
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The UUID of the controller VM which belongs to this host."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string ControllerVmUuid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The version of HyperFlex software running on the controller VM."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string ControllerVmVersion
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
        /// <para type="description">"The status of the HyperFlex host.\n* `UNKNOWN` - Current status of the HyperFlex host is unknown.\n* `ONLINE` - The HyperFlex host is online.\n* `OFFLINE` - The HyperFlex host is offline.\n* `INMAINTENANCE` - The HyperFlex host is in maintenance mode.\n* `DEGRADED` - Current status of the HyperFlex virtual machine is degraded."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexHypervisorHost.HostStatusEnum HostStatus
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The hypervisor type of the host."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Hypervisor
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Identifies the broad type of the underlying hypervisor.\n* `ESXi` - The hypervisor running on the HyperFlex cluster is a Vmware ESXi hypervisor of any version.\n* `Hyper-V` - The hypervisor running on the HyperFlex cluster is Microsoft Hyper-V.\n* `Unknown` - The hypervisor running on the HyperFlex cluster is not known."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexHypervisorHost.HypervisorTypeEnum HypervisorType
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The internally generated identity of this host. This entity is not manipulated by users. It aids in uniquely identifying the datacenter object. For VMware, this is an MOR (managed object reference)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Identity
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Flag indicating whether the HyperFlex host is in lockdown mode."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool Lockdown
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Is this host in maintenance mode. Set to true or false."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool MaintenanceMode
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
        /// <para type="description">"Commercial model information about this hardware."</para>
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
        /// <para type="description">"Name of this host supplied by user. It is not the identity of the host. The name is subject to user manipulations."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Name
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a hyperflexNode resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexNodeRelationship Node
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The operation system version of the controller VM."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string OsVersion
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
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public AssetDeviceRegistrationRelationship RegisteredDevice
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The role of the HyperFlex host.\n* `UNKNOWN` - The role of the HyperFlex host is unknown.\n* `STORAGE` - The HyperFlex host's role is storage.\n* `COMPUTE` - The HyperFlex host's role is compute."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexHypervisorHost.RoleEnum Role
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Serial number of this host (internally generated)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Serial
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
        /// <para type="description">"Host health status, as reported by the hypervisor platform.\n* `Unknown` - Entity status is unknown.\n* `Degraded` - State is degraded, and might impact normal operation of the entity.\n* `Critical` - Entity is in a critical state, impacting operations.\n* `Ok` - Entity status is in a stable state, operating normally."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexHypervisorHost.StatusEnum Status
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The controller virtual machine template version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string TemplateVersion
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The uptime of the host, stored as Duration (from w3c)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string UpTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Universally unique identity of this host (example b3d4483b-5560-9342-8309-b486c9236610). Internally generated."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^$|^[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12}$")]
        public string Uuid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Commercial vendor details of this hardware."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Vendor
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Configured number of virtual CPUs for Controller virtual machine."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public int VirtualCpus
        {
            get;
            set;
        }


    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexHypervisorVirtualMachine.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexHypervisorVirtualMachine", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexHypervisorVirtualMachine : GetCmdletBase
    {
        public GetIntersightHyperflexHypervisorVirtualMachine()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexHypervisorVirtualMachineListWithHttpInfo";
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
        /// <para type="description">"Time when this VM booted up."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime BootTime
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a hyperflexCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexClusterRelationship Cluster
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The connectivity state of the HyperFlex virtual machine."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string ConnectionState
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Average CPU utilization percentage derived as a ratio of CPU used to CPU allocated. The value is calculated whenever inventory is performed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public float CpuUtilization
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
        /// <para type="description">"Guest operating system state of the HyperFlex virtual machine."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string GuestOsState
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a hyperflexHypervisorHost resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexHypervisorHostRelationship Host
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Host UUID of the HyperFlex virtual machine."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string HostUuid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Type of hypervisor where the virtual machine is hosted for example ESXi.\n* `ESXi` - The hypervisor running on the HyperFlex cluster is a Vmware ESXi hypervisor of any version.\n* `Hyper-V` - The hypervisor running on the HyperFlex cluster is Microsoft Hyper-V.\n* `Unknown` - The hypervisor running on the HyperFlex cluster is not known."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexHypervisorVirtualMachine.HypervisorTypeEnum HypervisorType
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The internally generated identity of this VM. This entity is not manipulated by users. It aids in uniquely identifying the virtual machine object. For VMware, this is MOR (managed object reference)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Identity
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"Average memory utilization percentage derived as a ratio of memory used to available memory. The value is calculated whenever inventory is performed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public float MemoryUtilization
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
        /// <para type="description">"User-provided name to identify the virtual machine."</para>
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
        /// <para type="description">"Directory path where virtual machine is stored."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Path
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The instance id of platform which a virtual machine is running on."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string PlatformInstanceId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Power state of the virtual machine.\n* `Unknown` - The entity's power state is unknown.\n* `PoweringOn` - The entity is powering on.\n* `PoweredOn` - The entity is powered on.\n* `PoweringOff` - The entity is powering off.\n* `PoweredOff` - The entity is powered down.\n* `StandBy` - The entity is in standby mode.\n* `Paused` - The entity is in pause state.\n* `Rebooting` - The entity reboot is in progress.\n* `` - The entity's power state is not available."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexHypervisorVirtualMachine.PowerStateEnum PowerState
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Cloud platform, where the virtual machine is launched.\n* `Unknown` - Cloud provider is not known.\n* `VMwarevSphere` - Cloud provider named VMware vSphere.\n* `AmazonWebServices` - Cloud provider named Amazon Web Services.\n* `MicrosoftAzure` - Cloud provider named Microsoft Azure.\n* `GoogleCloudPlatform` - Cloud provider named Google Cloud Platform."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexHypervisorVirtualMachine.ProviderEnum Provider
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public AssetDeviceRegistrationRelationship RegisteredDevice
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
        /// <para type="description">"The current state of the virtual machine. For example, starting, stopped, etc.\n* `None` - A place holder for the default value.\n* `Creating` - Virtual machine creation is in progress.\n* `Pending` - The virtual machine is preparing to enter the started state.\n* `Starting` - The virtual machine is starting.\n* `Started` - The virtual machine is running and ready for use.\n* `Stopping` - The virtual machine is preparing to be stopped.\n* `Stopped` - The virtual machine is shut down and cannot be used. The virtual machine can be started again at any time.\n* `Pausing` - The virtual machine is preparing to be paused.\n* `Paused` - The virtual machine enters into paused state due to low free disk space.\n* `Suspending` - The virtual machine is preparing to be suspended.\n* `Suspended` - Virtual machine is in sleep mode.When a virtual machine is suspended, the current state of theoperating system, and applications is saved, and the virtual machine put into a suspended mode.\n* `Deleting` - The virtual machine is preparing to be terminated.\n* `Terminated` - The virtual machine has been permanently deleted and cannot be started.\n* `Rebooting` - The virtual machine reboot is in progress.\n* `Error` - The deployment of virtual machine is failed.\n* `Warning` - The virtual machine is in warning state."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexHypervisorVirtualMachine.StateEnum State
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Total provisioned storage to the HyperFlex virtual machine in bytes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long StorageProvisionedInBytes
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Storage used by HyperFlex virtual machine in bytes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long StorageUsedInBytes
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Flag indicating whether or not this virtual machine is a template. Apply to the ESXi platform only."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool Template
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The uuid of this virtual machine. The uuid is internally generated and not user specified."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^$|^[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12}$")]
        public string Uuid
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Time when this virtualmachine is created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime VmCreationTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The instance UUID of a virtual machine."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string VmInstanceUuid
        {
            get;
            set;
        }


    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexInitiatorGroup.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexInitiatorGroup", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexInitiatorGroup : GetCmdletBase
    {
        public GetIntersightHyperflexInitiatorGroup()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexInitiatorGroupListWithHttpInfo";
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
        /// <para type="description">"A reference to a hyperflexCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexClusterRelationship Cluster
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
        /// <para type="description">"Short description about the host group."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

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
        /// <para type="description">"Count of initiators in the iSCSI initiator group."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long InitiatorCount
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The source of the iSCSI initiator group inventory.\n* `NOT_APPLICABLE` - The source of the HyperFlex inventory is not applicable.\n* `ONLINE` - The source of the HyperFlex inventory is online.\n* `OFFLINE` - The source of the HyperFlex inventory is offline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexInitiatorGroup.InventorySourceEnum InventorySource
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
        /// <para type="description">"Name of the host group in storage array."</para>
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
        /// <para type="description">"Intersight provides pre-built workflows, tasks and policies to end users through global catalogs.\nObjects that are made available through global catalogs are said to have a 'shared' ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SharedScope
        {
            get;
            set;
        }





        // <summary>
        /// <para type="description">"UUID of the HyperFlex iSCSI initiator group."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Uuid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Version of the iSCSI initiator group."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long Version
        {
            get;
            set;
        }



    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexIscsiNetwork.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexIscsiNetwork", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexIscsiNetwork : GetCmdletBase
    {
        public GetIntersightHyperflexIscsiNetwork()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexIscsiNetworkListWithHttpInfo";
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
        /// <para type="description">"A reference to a hyperflexCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexClusterRelationship Cluster
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
        /// <para type="description">"The gateway of the HyperFlex iSCSI network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Gateway
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Source of this inventory object.\n* `NOT_APPLICABLE` - The source of the HyperFlex inventory is not applicable.\n* `ONLINE` - The source of the HyperFlex inventory is online.\n* `OFFLINE` - The source of the HyperFlex inventory is offline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexIscsiNetwork.InventorySourceEnum InventorySource
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"An IP within the iSCSI IP Address Range which is CIP for iSCSI network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string IscsiCip
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
        /// <para type="description">"The maximum transmission unit of the HyperFlex iSCSI network.\n* `UNKNOWN` - The maximum transmission unit of the HyperFlex iSCSI network is unknown.\n* `MTU_1500` - The maximum transmission unit of the HyperFlex iSCSI network is 1500 bytes.\n* `MTU_9000` - The maximum transmission unit of the HyperFlex iSCSI network is 9000 bytes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexIscsiNetwork.MtuEnum Mtu
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Name of the HyperFlex iSCSI network configuration."</para>
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
        /// <para type="description">"Intersight provides pre-built workflows, tasks and policies to end users through global catalogs.\nObjects that are made available through global catalogs are said to have a 'shared' ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SharedScope
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Subnet of the HyperFlex iSCSI network. Subnet is in a.b.c.d/e notation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Subnet
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"UCS Manager Host IP or FQDN."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string UcsHost
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"UUID of the HyperFlex iSCSI network configuration."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Uuid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Version of Network configuration in Inventory."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long Version
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The Virtual local area network (VLAN) name of the HyperFlex iSCSI network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string VlanName
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The VLAN ID of the HyperFlex iSCSI network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long Vlanid
        {
            get;
            set;
        }


    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexKeyEncryptionKey.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexKeyEncryptionKey", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexKeyEncryptionKey : GetCmdletBase
    {
        public GetIntersightHyperflexKeyEncryptionKey()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexKeyEncryptionKeyListWithHttpInfo";
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
        /// <para type="description">"A reference to a hyperflexClusterProfile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexClusterProfileRelationship ClusterProfile
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
        /// <para type="description">"This defines whether we need to operate in an account recovery scenario or not. If yes, then most of the parameters will be populated from an internal MO. So, some of the input parameters MAY be ignored, if this value is set to true."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool IsAccountRecovery
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Indicates whether the value of the 'kek' property has been set."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool IsKekSet
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Indicates whether the value of the 'passphrase' property has been set."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool IsPassphraseSet
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Number of iterations we want the hash to be run."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long Iteration
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Key encryption key used to encrypt the DEK's on the HyperFlex cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Kek
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Resource id + time of creation used for retrieving the KEK."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string KeyId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Last known Key encryption key state for this Key.\n* `NEW` - Key Encryption key is newly created.\n* `ACTIVE` - Key Encryption key is deployed on active resource.\n* `INACTIVE` - Key Encryption key is inactive and not used.\n* `INPROGRESS` - Key Encryption key is in a state where it was used on Intersight but did not receive confirmation from platform of success/failure."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexKeyEncryptionKey.KeyStateEnum KeyState
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
        /// <para type="description">"Initial passphrase for the encryption policy, password must contain a minimum of 12 characters, with at least 1 lowercase, 1 uppercase, 1 numeric."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Passphrase
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public MoBaseMoRelationship ResourceMo
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Resource type on which this key will be applied.\n* `CLUSTER` - Encryption is per HyperFlex cluster.\n* `DATASTORE` - Encryption is per dataStore on the HyperFlex cluster.\n* `DRIVE` - Encryption is per drive on the HyperFlex cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexKeyEncryptionKey.ResourceTypeEnum ResourceType
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
        /// <para type="description">"Copy of Key encryption key, which is used for sending the key over to the remote device endpoint. It is not persisited anywhere."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string TransitKek
        {
            get;
            set;
        }



    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexLicense.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexLicense", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexLicense : GetCmdletBase
    {
        public GetIntersightHyperflexLicense()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexLicenseListWithHttpInfo";
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
        /// <para type="description">"A reference to a hyperflexCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexClusterRelationship Cluster
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Is the cluster complaint with the license entitlements?"</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string ComplianceState
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
        /// <para type="description">"Out of compliance date of the cluster"</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string GetOutOfComplianceStartAt
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Is the cluster in evalution period?"</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool InEvaluation
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"The type of license applied on the cluster"</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string LicenseType
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
        /// <para type="description">"Is reservation enabled for the cluster?"</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool PlrEnabled
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public AssetDeviceRegistrationRelationship RegisteredDevice
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
        /// <para type="description">"Is Smart Licensing Enabled for this cluster?"</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool SmartLicensingEnabled
        {
            get;
            set;
        }




    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexLocalCredentialPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexLocalCredentialPolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexLocalCredentialPolicy : GetCmdletBase
    {
        public GetIntersightHyperflexLocalCredentialPolicy()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexLocalCredentialPolicyListWithHttpInfo";
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
        /// <para type="description">"Description of the policy."</para>
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
        /// <para type="description">"Indicates if Hypervisor password is the factory set default password. For HyperFlex Data Platform versions 3.0 or higher, enable this if the default password was not changed on the Hypervisor. It is required to supply a new custom Hypervisor password that will be applied to the Hypervisor during deployment. For HyperFlex Data Platform versions prior to 3.0 release, this setting has no effect and the default password will be used for initial install. The Hypervisor password should be changed after deployment."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool FactoryHypervisorPassword
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"HyperFlex storage controller VM password must contain a minimum of 10 characters, with at least 1 lowercase, 1 uppercase, 1 numeric, and 1 of these -_@#$%^&*! special characters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^[a-zA-Z0-9!@#$%^&*_-]{10,}$")]
        public string HxdpRootPwd
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Hypervisor administrator username must contain only alphanumeric characters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^[a-zA-Z0-9]{1,}$")]
        public string HypervisorAdmin
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The Hypervisor root password. For HyperFlex Data Platform 3.0 or later, if the factory default password was not manually changed, you must set a new custom password. If the password was manually changed, you must not enable the factory default password property and provide the current hypervisor password. Note - All HyperFlex nodes require the same hypervisor password for installation. For HyperFlex Data Platform prior to 3.0, use the default password \"Cisco123\" for newly manufactured HyperFlex servers. A custom password should only be entered if hypervisor credentials were manually changed prior to deployment."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^.{7,40}$")]
        public string HypervisorAdminPwd
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Indicates whether the value of the 'deploymentPrivateKey' property has been set."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool IsDeploymentPrivateKeySet
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Indicates whether the value of the 'hxdpRootPwd' property has been set."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool IsHxdpRootPwdSet
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Indicates whether the value of the 'hypervisorAdminPwd' property has been set."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool IsHypervisorAdminPwdSet
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
        /// <para type="description">"Name of the concrete policy."</para>
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




    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexLun.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexLun", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexLun : GetCmdletBase
    {
        public GetIntersightHyperflexLun()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexLunListWithHttpInfo";
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
        /// <para type="description">"The description of iSCSI LUN."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

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
        /// <para type="description">"The datastore capacity in bytes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long DsCapacityInBytes
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The HyperFlex datastore name."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string DsName
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The HyperFlex datastore UUID."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string DsUuid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Logical unit number (LUN) by which hosts address specified volume. Hlu is a decimal representation of the LUN from the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long Hlu
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Name of the host associated with LUN."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string HostName
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Source of the lun inventory.\n* `NOT_APPLICABLE` - The source of the HyperFlex inventory is not applicable.\n* `ONLINE` - The source of the HyperFlex inventory is online.\n* `OFFLINE` - The source of the HyperFlex inventory is offline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexLun.InventorySourceEnum InventorySource
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Indicates if the datastore on which LUN resides is encrypted or un-encrypted."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool IsEncrypted
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The identity of HyperFlex iSCSI LUN."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string LunId
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
        /// <para type="description">"Name of the HyperFlex iSCSI LUN."</para>
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
        /// <para type="description">"Serial number of HyperFlex iSCSI LUN."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SerialNo
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
        /// <para type="description">"A reference to a hyperflexTarget resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexTargetRelationship Target
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Total capacity of iSCSI LUN in bytes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long TotalCapacityInBytes
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"HyperFlex iSCSI Target associated with the HyperFlex iSCSI LUN."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Tuuid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Used capacity of iSCSI LUN in bytes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long UsedCapacityInBytes
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"UUID of the HyperFlex iSCSI LUN."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Uuid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Version of the HyperFlex iSCSI lun."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long Version
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Name of the storage volume associated with LUN."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string VolumeName
        {
            get;
            set;
        }


    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexNode.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexNode", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexNode : GetCmdletBase
    {
        public GetIntersightHyperflexNode()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexNodeListWithHttpInfo";
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
        /// <para type="description">"The build number of the hypervisor running on the host."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string BuildNumber
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a hyperflexCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexClusterRelationship Cluster
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a assetClusterMember resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public AssetClusterMemberRelationship ClusterMember
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
        /// <para type="description">"The user-friendly string representation of the hypervisor version of the host."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string DisplayVersion
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
        /// <para type="description">"The hostname configured for the hypervisor running on the host."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string HostName
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"The type of hypervisor running on the host."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Hypervisor
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"The admin state of lockdown mode on the host. If 'true', lockdown mode is enabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool Lockdown
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
        /// <para type="description">"The model of the host server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string ModelNumber
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
        /// <para type="description">"The status of maintenance mode on the HyperFlex node.\n* `Unknown` - The maintenance mode status could not be determined.\n* `InMaintenanceMode` - The node has maintenance mode enabled. The node has been temporarily been relinquished from the cluster to allow for maintenance operations.\n* `NotInMaintenanceMode` - The node does not have maintenance mode enabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexNode.NodeMaintenanceModeEnum NodeMaintenanceMode
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The operational status of the HyperFlex node.\n* `Unknown` - The default operational status of a HyperFlex node.\n* `Invalid` - The status of the node cannot be determined by the storage platform.\n* `Ready` - The platform node has been acknowledged by the cluster.\n* `Unpublished` - The node is not yet added to the storage cluster.\n* `Deleted` - The node has been removed from the cluster.\n* `Blocked` - The node is blocked from being added to the cluster.\n* `Blacklisted` - The deprecated value for 'Blocked'. It is included to maintain backwards compatibility with clusters running a HyperFlex Data Platform version older than 5.0(1a).\n* `Allowed` - The node is allowed to be added to the cluster.\n* `Whitelisted` - The deprecated value for 'Allowed'. It is included to maintain backwards compatibility with clusters running a HyperFlex Data Platform version older than 5.0(1a).\n* `InMaintenance` - The node is in maintenance mode. It has been temporarily relinquished from the cluster to allow for maintenance operations such as software upgrades.\n* `Online` - The node is participating in the storage cluster and is available for storage operations.\n* `Offline` - The node is part of the storage cluster, but is not available for storage operations."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexNode.NodeStatusEnum NodeStatus
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The unique identifier of the HyperFlex node."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string NodeUuid
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
        /// <para type="description">"A reference to a computePhysical resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public ComputePhysicalRelationship PhysicalServer
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The role of the host in the HyperFlex cluster. Specifies whether this host is used for compute or for both compute and storage.\n* `UNKNOWN` - The role of the HyperFlex cluster node is not known.\n* `STORAGE` - The HyperFlex cluster node provides both storage and compute resources for the cluster.\n* `COMPUTE` - The HyperFlex cluster node provides compute resources for the cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexNode.RoleEnum Role
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The serial of the host server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SerialNumber
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
        /// <para type="description">"The status of the host. Indicates whether the hypervisor is online.\n* `UNKNOWN` - The host status cannot be determined.\n* `ONLINE` - The host is online and operational.\n* `OFFLINE` - The host is offline and is currently not participating in the HyperFlex cluster.\n* `INMAINTENANCE` - The host is not participating in the HyperFlex cluster because of a maintenance operation, such as firmware or data platform upgrade.\n* `DEGRADED` - The host is degraded and may not be performing in its full operational capacity."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexNode.StatusEnum Status
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The version of the hypervisor running on the host."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Version
        {
            get;
            set;
        }



    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexNodeConfigPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexNodeConfigPolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexNodeConfigPolicy : GetCmdletBase
    {
        public GetIntersightHyperflexNodeConfigPolicy()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexNodeConfigPolicyListWithHttpInfo";
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
        /// <para type="description">"Description of the policy."</para>
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The node name prefix that is used to automatically generate the default hostname for each server.\nA dash (-) will be appended to the prefix followed by the node number to form a hostname.\nThis default naming scheme can be manually overridden in the node configuration.\nThe maximum length of a prefix is 60, must only contain alphanumeric characters or dash (-), and must\nstart with an alphanumeric character."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^$|^[a-zA-Z0-9][a-zA-Z0-9-]{1,59}$")]
        public string NodeNamePrefix
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




    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexNodeProfile.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexNodeProfile", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexNodeProfile : GetCmdletBase
    {
        public GetIntersightHyperflexNodeProfile()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexNodeProfileListWithHttpInfo";
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
        /// <para type="description">"User initiated action. Each profile type has its own supported actions. For HyperFlex cluster profile, the supported actions are -- Validate, Deploy, Continue, Retry, Abort, Unassign For server profile, the support actions are -- Deploy, Unassign."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Action
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"A reference to a computePhysical resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public ComputePhysicalRelationship AssignedServer
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a hyperflexClusterProfile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexClusterProfileRelationship ClusterProfile
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
        /// <para type="description">"Description of the profile."</para>
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
        /// <para type="description">"IP address for storage data network (Controller VM interface)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string HxdpDataIp
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"IP address for HyperFlex management network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string HxdpMgmtIp
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"IP address for storage client network (Controller VM interface)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string HxdpStorageClientIp
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"IP address for hypervisor control such as VM migration or pod management."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string HypervisorControlIp
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"IP address for storage data network (Hypervisor interface)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string HypervisorDataIp
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"IP address for Hypervisor management network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string HypervisorMgmtIp
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
        /// <para type="description">"Name of the profile instance or profile template."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^[a-zA-Z0-9_.-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a hyperflexNode resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexNodeRelationship Node
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The role that this node performs in the HyperFlex cluster.\n* `Unknown` - The node role is not available.\n* `Storage` - The node persists data and contributes to the storage capacity of a cluster.\n* `Compute` - The node contributes to the compute capacity of a cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexNodeProfile.NodeRoleEnum NodeRole
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
        /// <para type="description">"A reference to a policyAbstractProfile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public PolicyAbstractProfileRelationship SrcTemplate
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Defines the type of the profile. Accepted values are instance or template.\n* `instance` - The profile defines the configuration for a specific instance of a target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexNodeProfile.TypeEnum Type
        {
            get;
            set;
        }



    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexProtectedCluster.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexProtectedCluster", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexProtectedCluster : GetCmdletBase
    {
        public GetIntersightHyperflexProtectedCluster()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexProtectedClusterListWithHttpInfo";
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
        /// <para type="description">"A reference to a hyperflexClusterBackupPolicyInventory resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexClusterBackupPolicyInventoryRelationship BackupPolicy
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
        /// <para type="description">"A reference to a hyperflexDatastoreStatistic resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexDatastoreStatisticRelationship DatastoreStatistic
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
        /// <para type="description">"Version of the Hyperflex cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string HxVersion
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The version of hypervisor running on this cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string HypervisorVersion
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
        /// <para type="description">"Name of the protected datastore."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string ProtectedDatastoreName
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Number of VMs protected on this cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long ProtectedVmsCount
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
        /// <para type="description">"Name of the source cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SourceClusterName
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a hyperflexCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexClusterRelationship SrcCluster
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Name of the target cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string TargetClusterName
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Name of the target datastore."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string TargetDatastoreName
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Percent usage of the datastore."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public float TargetDatastoreUtilization
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a hyperflexCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexClusterRelationship TgtCluster
        {
            get;
            set;
        }



    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexProxySettingPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexProxySettingPolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexProxySettingPolicy : GetCmdletBase
    {
        public GetIntersightHyperflexProxySettingPolicy()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexProxySettingPolicyListWithHttpInfo";
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
        /// <para type="description">"Description of the policy."</para>
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
        /// <para type="description">"HTTP Proxy server FQDN or IP."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^[A-Za-z]([A-Za-z0-9-]*[A-Za-z0-9])?$|^[A-Za-z0-9]([A-Za-z0-9-]*[A-Za-z0-9])?(\\.[A-Za-z0-9]([A-Za-z0-9-]*[A-Za-z0-9])?)*(\\.[A-Za-z]([A-Za-z0-9-]*[A-Za-z0-9])?)$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string Hostname
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Indicates whether the value of the 'password' property has been set."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool IsPasswordSet
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
        /// <para type="description">"Name of the concrete policy."</para>
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
        /// <para type="description">"The password for the HTTP Proxy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Password
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The HTTP Proxy port number.\nThe port number of the HTTP proxy must be between 1 and 65535, inclusive."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidateRange(1, 65535)]
        public long Port
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
        /// <para type="description">"The username for the HTTP Proxy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Username
        {
            get;
            set;
        }



    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexReduceReSync.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexReduceReSync", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexReduceReSync : GetCmdletBase
    {
        public GetIntersightHyperflexReduceReSync()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexReduceReSyncListWithHttpInfo";
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
        /// <para type="description">"A reference to a hyperflexCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexClusterRelationship Cluster
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The HyperFlex reduce re-sync script execution completion status."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool CompletionStatus
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
        /// <para type="description">"The execution output of the script."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string ExecutionOutput
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




    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexServerFirmwareVersion.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexServerFirmwareVersion", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexServerFirmwareVersion : GetCmdletBase
    {
        public GetIntersightHyperflexServerFirmwareVersion()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexServerFirmwareVersionListWithHttpInfo";
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
        /// <para type="description">"A reference to a hyperflexAppCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexAppCatalogRelationship AppCatalog
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




    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexServerFirmwareVersionEntry.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexServerFirmwareVersionEntry", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexServerFirmwareVersionEntry : GetCmdletBase
    {
        public GetIntersightHyperflexServerFirmwareVersionEntry()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexServerFirmwareVersionEntryListWithHttpInfo";
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
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public MoBaseMoRelationship Parent
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a hyperflexServerFirmwareVersion resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexServerFirmwareVersionRelationship ServerFirmwareVersion
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The server platform type that is applicable for the server firmware bundle version.\n* `M5` - M5 generation of UCS server.\n* `M3` - M3 generation of UCS server.\n* `M4` - M4 generation of UCS server.\n* `M6` - M6 generation of UCS server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexServerFirmwareVersionEntry.ServerPlatformEnum ServerPlatform
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
        /// <para type="description">"The server firmware bundle version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("(^3\\.[1-9]\\([1-9][a-z]\\)$|^[4-9]\\.[0-9]\\([1-9][a-z]\\)$)")]
        public string Version
        {
            get;
            set;
        }



    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexServerModel.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexServerModel", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexServerModel : GetCmdletBase
    {
        public GetIntersightHyperflexServerModel()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexServerModelListWithHttpInfo";
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
        /// <para type="description">"A reference to a hyperflexAppCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexAppCatalogRelationship AppCatalog
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




    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexServiceAuthToken.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexServiceAuthToken", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexServiceAuthToken : GetCmdletBase
    {
        public GetIntersightHyperflexServiceAuthToken()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexServiceAuthTokenListWithHttpInfo";
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
        /// <para type="description">"Client Id or tenant Id of the entity that uses the service auth token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string ClientId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a hyperflexCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexClusterRelationship Cluster
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
        /// <para type="description">"Version of Container Storage Interface (CSI) that the tokenOwner is associated with."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string CsiVersion
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
        /// <para type="description">"Service auth token that has been created by HyperFlex cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string ServiceAuthToken
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
        /// <para type="description">"Represents status of ervice auth claim or revocation.\n* `Unknown` - Unknown claim state of the service auth token.\n* `Claiming` - The service auth token claim is in progress.\n* `Claimed` - The service auth token has been successfully claimed.\n* `FailedToClaim` - Cannot claim the service auth token on the underlying HyperFlex cluster.\n* `Revoking` - The service auth token revocation is in progress.\n* `Revoked` - The service auth token revocation has been successfully revoked.\n* `FailedToRevoke` - Cannot revoke the service auth token on the underlying HyperFlex cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexServiceAuthToken.StatusEnum Status
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public MoBaseMoRelationship TokenOwner
        {
            get;
            set;
        }



    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexSoftwareDistributionComponent.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexSoftwareDistributionComponent", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexSoftwareDistributionComponent : GetCmdletBase
    {
        public GetIntersightHyperflexSoftwareDistributionComponent()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexSoftwareDistributionComponentListWithHttpInfo";
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
        /// <para type="description">"The bucket name where the files are present, if source is external cloud store."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string BucketName
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The HyperFlex Software Distribution Component Identifier."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string ComponentId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The HyperFlex Software Distribution Component Name."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string ComponentName
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
        /// <para type="description">"File location on the cloud storage."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string FilePath
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
        /// <para type="description">"A reference to a hyperflexSoftwareDistributionVersion resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexSoftwareDistributionVersionRelationship SoftwareDistributionVersion
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The HyperFlex Software Distribution Component Version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Version
        {
            get;
            set;
        }



    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexSoftwareDistributionEntry.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexSoftwareDistributionEntry", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexSoftwareDistributionEntry : GetCmdletBase
    {
        public GetIntersightHyperflexSoftwareDistributionEntry()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexSoftwareDistributionEntryListWithHttpInfo";
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
        /// <para type="description">"A reference to a hyperflexAppCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexAppCatalogRelationship AppCatalog
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
        /// <para type="description">"The HyperFlex Software Distribution type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string DistributionType
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




    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexSoftwareDistributionVersion.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexSoftwareDistributionVersion", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexSoftwareDistributionVersion : GetCmdletBase
    {
        public GetIntersightHyperflexSoftwareDistributionVersion()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexSoftwareDistributionVersionListWithHttpInfo";
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
        /// <para type="description">"A reference to a hyperflexSoftwareDistributionEntry resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexSoftwareDistributionEntryRelationship SoftwareDistributionEntry
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The HyperFlex Software Distribution version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Version
        {
            get;
            set;
        }



    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexSoftwareVersionPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexSoftwareVersionPolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexSoftwareVersionPolicy : GetCmdletBase
    {
        public GetIntersightHyperflexSoftwareVersionPolicy()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexSoftwareVersionPolicyListWithHttpInfo";
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
        /// <para type="description">"Description of the policy."</para>
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
        /// <para type="description">"Desired HyperFlex Data Platform software version to apply on the HyperFlex cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string HxdpVersion
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a softwareHyperflexDistributable resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public SoftwareHyperflexDistributableRelationship HxdpVersionInfo
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Desired  hypervisor version to apply for all the nodes on the HyperFlex cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string HypervisorVersion
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a softwareHyperflexDistributable resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public SoftwareHyperflexDistributableRelationship HypervisorVersionInfo
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
        /// <para type="description">"Name of the concrete policy."</para>
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
        /// <para type="description">"Desired server firmware version to apply on the HyperFlex Cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^$|(^3\\.[0-9]\\([1-9][a-z]\\)$|^[4-9]\\.[1-9]\\([1-9][a-z]\\)$|^4\\.0\\([1-3][a-z]\\)$|^4\\.0\\(4[d-z]\\)$|4\\.0\\([5-9][a-z]\\)$|^[4-9]\\.[0-9]\\([0-9](\\.[0-9]+|[a-z]).*\\)$)")]
        public string ServerFirmwareVersion
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a firmwareDistributable resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public FirmwareDistributableRelationship ServerFirmwareVersionInfo
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





    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexStartReduceReSync.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexStartReduceReSync", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexStartReduceReSync : GetCmdletBase
    {
        public GetIntersightHyperflexStartReduceReSync()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexStartReduceReSyncListWithHttpInfo";
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
        /// <para type="description">"The cleanup operation to perform.\n* `NoOp` - Does not perform any operation when the API is called.\n* `StartReduceResync` - Start the execution of reduce re-sync and stale mirror cleanup for the HyperFlex clusters associated with the account."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexStartReduceReSync.OperationEnum Operation
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




    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexStorageContainer.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexStorageContainer", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexStorageContainer : GetCmdletBase
    {
        public GetIntersightHyperflexStorageContainer()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexStorageContainerListWithHttpInfo";
        }

        // <summary>
        /// <para type="description">"Storage container accessibility summary.\n* `NOT_APPLICABLE` - The HyperFlex storage container accessibility summary is not applicable.\n* `ACCESSIBLE` - The HyperFlex storage container is accessible.\n* `NOT_ACCESSIBLE` - The HyperFlex storage container is not accessible.\n* `PARTIALLY_ACCESSIBLE` - The HyperFlex storage container is partially accessible."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexStorageContainer.AccessibilitySummaryEnum AccessibilitySummary
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
        /// <para type="description">"A reference to a hyperflexCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexClusterRelationship Cluster
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
        /// <para type="description">"Storage container's creation time."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime CreatedTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Storage container data block size in bytes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long DataBlockSize
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
        /// <para type="description">"Indicate if encryption is enabled on this storage container."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool EncryptionEnabled
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Indicates whether the storage container has volumes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool InUse
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Indicates whether the storage container was user-created, or system-created.\n* `UNKNOWN` - The storage container creator is unknown.\n* `USER_CREATED` - The storage container was created by a user action.\n* `INTERNAL` - The storage container was created by the system."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexStorageContainer.KindEnum Kind
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Storage container's last access time."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime LastAccessTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Storage container's last modified time."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime LastModifiedTime
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
        /// <para type="description">"Storage container mount status. Applicable only for NFS type.\n* `NOT_APPLICABLE` - The HyperFlex storage container mount status is not applicable.\n* `NORMAL` - The HyperFlex storage container mount status is normal.\n* `ALERT` - The HyperFlex storage container mount status is alert.\n* `FAILED` - The HyperFlex storage container mount status is failed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexStorageContainer.MountStatusEnum MountStatus
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Storage container mount summary. Applicable only for NFS type.\n* `NOT_APPLICABLE` - The mount summary is not applicable for this HyperFlex storage container.\n* `MOUNTED` - The HyperFlex storage container is mounted.\n* `UNMOUNTED` - The HyperFlex storage container is unmounted.\n* `MOUNT_FAILURE` - The HyperFlex storage container mount summary is failure.\n* `UNMOUNT_FAILURE` - The HyperFlex storage container unmount summary is failure."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexStorageContainer.MountSummaryEnum MountSummary
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Name of the storage container."</para>
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
        /// <para type="description">"Provisioned capacity of the storage container in bytes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long ProvisionedCapacity
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Provisioned capacity utilization of all volumes associated with the storage container."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public float ProvisionedVolumeCapacityUtilization
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
        /// <para type="description">"Storage container type (SMB/NFS/iSCSI).\n* `NFS` - Storage container created/accesed through NFS protocol.\n* `SMB` - Storage container created/accessed through SMB protocol.\n* `iSCSI` - Storage container created/accessed through iSCSI protocol."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexStorageContainer.TypeEnum Type
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Uncompressed bytes on storage container."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long UnCompressedUsedBytes
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"UUID of the datastore/storage container."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Uuid
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Number of volumes associated with the storage container."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long VolumeCount
        {
            get;
            set;
        }



    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexSysConfigPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexSysConfigPolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexSysConfigPolicy : GetCmdletBase
    {
        public GetIntersightHyperflexSysConfigPolicy()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexSysConfigPolicyListWithHttpInfo";
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
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The DNS Search Domain Name. This setting applies to HyperFlex Data Platform 3.0 or later only."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^$|^([a-zA-Z0-9]([a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?\\.)*[a-zA-Z]{2,63}$")]
        public string DnsDomainName
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
        /// <para type="description">"Name of the concrete policy."</para>
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
        /// <para type="description">"The timezone of the HyperFlex cluster's system clock.\n* `Pacific/Niue` - \n* `Pacific/Pago_Pago` - \n* `Pacific/Honolulu` - \n* `Pacific/Rarotonga` - \n* `Pacific/Tahiti` - \n* `Pacific/Marquesas` - \n* `America/Anchorage` - \n* `Pacific/Gambier` - \n* `America/Los_Angeles` - \n* `America/Tijuana` - \n* `America/Vancouver` - \n* `America/Whitehorse` - \n* `Pacific/Pitcairn` - \n* `America/Dawson_Creek` - \n* `America/Denver` - \n* `America/Edmonton` - \n* `America/Hermosillo` - \n* `America/Mazatlan` - \n* `America/Phoenix` - \n* `America/Yellowknife` - \n* `America/Belize` - \n* `America/Chicago` - \n* `America/Costa_Rica` - \n* `America/El_Salvador` - \n* `America/Guatemala` - \n* `America/Managua` - \n* `America/Mexico_City` - \n* `America/Regina` - \n* `America/Tegucigalpa` - \n* `America/Winnipeg` - \n* `Pacific/Galapagos` - \n* `America/Bogota` - \n* `America/Cancun` - \n* `America/Cayman` - \n* `America/Guayaquil` - \n* `America/Havana` - \n* `America/Iqaluit` - \n* `America/Jamaica` - \n* `America/Lima` - \n* `America/Nassau` - \n* `America/New_York` - \n* `America/Nuuk` - \n* `America/Panama` - \n* `America/Port-au-Prince` - \n* `America/Rio_Branco` - \n* `America/Toronto` - \n* `Pacific/Easter` - \n* `America/Caracas` - \n* `America/Asuncion` - \n* `America/Barbados` - \n* `America/Boa_Vista` - \n* `America/Campo_Grande` - \n* `America/Cuiaba` - \n* `America/Curacao` - \n* `America/Grand_Turk` - \n* `America/Guyana` - \n* `America/Halifax` - \n* `America/La_Paz` - \n* `America/Manaus` - \n* `America/Martinique` - \n* `America/Port_of_Spain` - \n* `America/Porto_Velho` - \n* `America/Puerto_Rico` - \n* `America/Santo_Domingo` - \n* `America/Thule` - \n* `Atlantic/Bermuda` - \n* `America/St_Johns` - \n* `America/Araguaina` - \n* `America/Argentina/Buenos_Aires` - \n* `America/Bahia` - \n* `America/Belem` - \n* `America/Cayenne` - \n* `America/Fortaleza` - \n* `America/Godthab` - \n* `America/Maceio` - \n* `America/Miquelon` - \n* `America/Montevideo` - \n* `America/Paramaribo` - \n* `America/Recife` - \n* `America/Santiago` - \n* `America/Sao_Paulo` - \n* `Antarctica/Palmer` - \n* `Antarctica/Rothera` - \n* `Atlantic/Stanley` - \n* `America/Noronha` - \n* `Atlantic/South_Georgia` - \n* `America/Scoresbysund` - \n* `Atlantic/Azores` - \n* `Atlantic/Cape_Verde` - \n* `Africa/Abidjan` - \n* `Africa/Accra` - \n* `Africa/Bissau` - \n* `Africa/Casablanca` - \n* `Africa/El_Aaiun` - \n* `Africa/Monrovia` - \n* `America/Danmarkshavn` - \n* `Atlantic/Canary` - \n* `Atlantic/Faroe` - \n* `Atlantic/Reykjavik` - \n* `Etc/GMT` - \n* `Europe/Dublin` - \n* `Europe/Lisbon` - \n* `Europe/London` - \n* `Africa/Algiers` - \n* `Africa/Ceuta` - \n* `Africa/Lagos` - \n* `Africa/Ndjamena` - \n* `Africa/Tunis` - \n* `Africa/Windhoek` - \n* `Europe/Amsterdam` - \n* `Europe/Andorra` - \n* `Europe/Belgrade` - \n* `Europe/Berlin` - \n* `Europe/Brussels` - \n* `Europe/Budapest` - \n* `Europe/Copenhagen` - \n* `Europe/Gibraltar` - \n* `Europe/Luxembourg` - \n* `Europe/Madrid` - \n* `Europe/Malta` - \n* `Europe/Monaco` - \n* `Europe/Oslo` - \n* `Europe/Paris` - \n* `Europe/Prague` - \n* `Europe/Rome` - \n* `Europe/Stockholm` - \n* `Europe/Tirane` - \n* `Europe/Vienna` - \n* `Europe/Warsaw` - \n* `Europe/Zurich` - \n* `Africa/Cairo` - \n* `Africa/Johannesburg` - \n* `Africa/Maputo` - \n* `Africa/Tripoli` - \n* `Asia/Amman` - \n* `Asia/Beirut` - \n* `Asia/Damascus` - \n* `Asia/Gaza` - \n* `Asia/Jerusalem` - \n* `Asia/Nicosia` - \n* `Europe/Athens` - \n* `Europe/Bucharest` - \n* `Europe/Chisinau` - \n* `Europe/Helsinki` - \n* `Europe/Istanbul` - \n* `Europe/Kaliningrad` - \n* `Europe/Kiev` - \n* `Europe/Riga` - \n* `Europe/Sofia` - \n* `Europe/Tallinn` - \n* `Europe/Vilnius` - \n* `Africa/Khartoum` - \n* `Africa/Nairobi` - \n* `Antarctica/Syowa` - \n* `Asia/Baghdad` - \n* `Asia/Qatar` - \n* `Asia/Riyadh` - \n* `Europe/Minsk` - \n* `Europe/Moscow` - \n* `Asia/Tehran` - \n* `Asia/Baku` - \n* `Asia/Dubai` - \n* `Asia/Tbilisi` - \n* `Asia/Yerevan` - \n* `Europe/Samara` - \n* `Indian/Mahe` - \n* `Indian/Mauritius` - \n* `Indian/Reunion` - \n* `Asia/Kabul` - \n* `Antarctica/Mawson` - \n* `Asia/Aqtau` - \n* `Asia/Aqtobe` - \n* `Asia/Ashgabat` - \n* `Asia/Dushanbe` - \n* `Asia/Karachi` - \n* `Asia/Tashkent` - \n* `Asia/Yekaterinburg` - \n* `Indian/Kerguelen` - \n* `Indian/Maldives` - \n* `Asia/Calcutta` - \n* `Asia/Kolkata` - \n* `Asia/Colombo` - \n* `Asia/Kathmandu` - \n* `Asia/Katmandu` - \n* `Antarctica/Vostok` - \n* `Asia/Almaty` - \n* `Asia/Bishkek` - \n* `Asia/Dhaka` - \n* `Asia/Omsk` - \n* `Asia/Thimphu` - \n* `Indian/Chagos` - \n* `Asia/Rangoon` - \n* `Indian/Cocos` - \n* `Antarctica/Davis` - \n* `Asia/Bangkok` - \n* `Asia/Ho_Chi_Minh` - \n* `Asia/Hovd` - \n* `Asia/Jakarta` - \n* `Asia/Krasnoyarsk` - \n* `Asia/Saigon` - \n* `Indian/Christmas` - \n* `Antarctica/Casey` - \n* `Asia/Brunei` - \n* `Asia/Choibalsan` - \n* `Asia/Hong_Kong` - \n* `Asia/Irkutsk` - \n* `Asia/Kuala_Lumpur` - \n* `Asia/Macau` - \n* `Asia/Makassar` - \n* `Asia/Manila` - \n* `Asia/Shanghai` - \n* `Asia/Singapore` - \n* `Asia/Taipei` - \n* `Asia/Ulaanbaatar` - \n* `Australia/Perth` - \n* `Asia/Pyongyang` - \n* `Asia/Dili` - \n* `Asia/Jayapura` - \n* `Asia/Seoul` - \n* `Asia/Tokyo` - \n* `Asia/Yakutsk` - \n* `Asia/Yangon` - \n* `Pacific/Palau` - \n* `Australia/Adelaide` - \n* `Australia/Darwin` - \n* `Antarctica/DumontDUrville` - \n* `Asia/Magadan` - \n* `Asia/Vladivostok` - \n* `Australia/Brisbane` - \n* `Australia/Hobart` - \n* `Australia/Sydney` - \n* `Pacific/Chuuk` - \n* `Pacific/Guam` - \n* `Pacific/Port_Moresby` - \n* `Pacific/Efate` - \n* `Pacific/Guadalcanal` - \n* `Pacific/Kosrae` - \n* `Pacific/Norfolk` - \n* `Pacific/Noumea` - \n* `Pacific/Pohnpei` - \n* `Asia/Kamchatka` - \n* `Pacific/Auckland` - \n* `Pacific/Fiji` - \n* `Pacific/Funafuti` - \n* `Pacific/Kwajalein` - \n* `Pacific/Majuro` - \n* `Pacific/Nauru` - \n* `Pacific/Tarawa` - \n* `Pacific/Wake` - \n* `Pacific/Wallis` - \n* `Pacific/Apia` - \n* `Pacific/Enderbury` - \n* `Pacific/Fakaofo` - \n* `Pacific/Tongatapu` - \n* `Pacific/Kiritimati` - \n* `UTC` -"</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexSysConfigPolicy.TimezoneEnum Timezone
        {
            get;
            set;
        }



    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexTarget.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexTarget", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexTarget : GetCmdletBase
    {
        public GetIntersightHyperflexTarget()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexTargetListWithHttpInfo";
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
        /// <para type="description">"Auth method of the target inventory.\n* `NOT_APPLICABLE` - Authorization method of the HyperFlex iSCSI target is not applicable.\n* `CHAP` - Authorization method of the HyperFlex iSCSI target is CHAP.\n* `NONE` - Authorization method of the HyperFlex iSCSI target is none."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexTarget.AuthMethodEnum AuthMethod
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a hyperflexCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexClusterRelationship Cluster
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
        /// <para type="description">"Short description about the target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

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
        /// <para type="description">"Source of the target inventory.\n* `NOT_APPLICABLE` - The source of the HyperFlex inventory is not applicable.\n* `ONLINE` - The source of the HyperFlex inventory is online.\n* `OFFLINE` - The source of the HyperFlex inventory is offline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexTarget.InventorySourceEnum InventorySource
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The iSCSI qualified name (IQN) of target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Iqn
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
        /// <para type="description">"Name of the target in storage array."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Name
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Number of active initiators in the initiator group."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long NumActiveInitiators
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
        /// <para type="description">"UUID of the HyperFlex iSCSI target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Uuid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Version of the Initiator Group."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long Version
        {
            get;
            set;
        }



    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexUcsmConfigPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexUcsmConfigPolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexUcsmConfigPolicy : GetCmdletBase
    {
        public GetIntersightHyperflexUcsmConfigPolicy()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexUcsmConfigPolicyListWithHttpInfo";
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
        /// <para type="description">"Description of the policy."</para>
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
        /// <para type="description">"Name of the concrete policy."</para>
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
        /// <para type="description">"The server firmware bundle version used for server components such as CIMC, adapters, BIOS, etc."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("(^3\\.[1-9]\\([1-9][a-z]\\)$|^[4-9]\\.[0-9]\\([1-9][a-z]\\)$)")]
        public string ServerFirmwareVersion
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




    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexVcenterConfigPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexVcenterConfigPolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexVcenterConfigPolicy : GetCmdletBase
    {
        public GetIntersightHyperflexVcenterConfigPolicy()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexVcenterConfigPolicyListWithHttpInfo";
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
        /// <para type="description">"The vCenter datacenter name."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^[a-zA-Z0-9~!@#$%&*()-_][a-zA-Z0-9~!@#$%&* ()-_]{0,79}$")]
        public string DataCenter
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Description of the policy."</para>
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
        /// <para type="description">"The vCenter server FQDN or IP."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^[A-Za-z]([A-Za-z0-9-]*[A-Za-z0-9])?$|^[A-Za-z0-9]([A-Za-z0-9-]*[A-Za-z0-9])?(\\.[A-Za-z0-9]([A-Za-z0-9-]*[A-Za-z0-9])?)*(\\.[A-Za-z]([A-Za-z0-9-]*[A-Za-z0-9])?)$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string Hostname
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Indicates whether the value of the 'password' property has been set."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool IsPasswordSet
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
        /// <para type="description">"Name of the concrete policy."</para>
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
        /// <para type="description">"The password for authenticating with vCenter. Follow the corresponding password policy governed by vCenter."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Password
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
        /// <para type="description">"Overrides the default vCenter Single Sign-On URL. Do not specify unless instructed by Cisco TAC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SsoUrl
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The vCenter username (e.g. administrator@vsphere.local)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^$|^([a-zA-Z0-9._-]+)@([a-zA-Z0-9._-]+)$")]
        public string Username
        {
            get;
            set;
        }



    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexVmBackupInfo.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexVmBackupInfo", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexVmBackupInfo : GetCmdletBase
    {
        public GetIntersightHyperflexVmBackupInfo()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexVmBackupInfoListWithHttpInfo";
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
        /// <para type="description">"Description of the backup status of this VmBackupInfo.\n* `InitializingProtection` - Protection has started, but not completed.\n* `Protected` - Protection has completed successfully.\n* `ExceedsInterval` - Protection has not completed successfully in over two times the backup interval."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexVmBackupInfo.BackupStatusEnum BackupStatus
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
        /// <para type="description">"Retention count from backup policy for local snapshots."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long LocalSnapshotRetentionCount
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
        /// <para type="description">"The power state of the Virtual Machine."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool PowerOn
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Description of the protection status of this VmBackupInfo.\n* `PREPARE_FAILOVER_STARTED` - The protection status is prepare failover started.\n* `PREPARE_FAILOVER_FAILED` - The protection status is prepare failover failed.\n* `PREPARE_FAILOVER_COMPLETED` - The protection status is prepaire failover completed.\n* `FAILOVER_STARTED` - The protection status is failover started.\n* `FAILOVER_FAILED` - The protection status is failover failed.\n* `FAILOVER_COMPLETED` - The protection status is failover completed.\n* `PREPARE_REVERSEPROTECT_STARTED` - The protection status is prepare reverse protect started.\n* `PREPARE_REVERSEPROTECT_FAILED` - The protection status is prepare reverse protect failed.\n* `PREPARE_REVERSEPROTECT_COMPLETED` - The protection status is prepair reverse protect completed.\n* `REVERSEPROTECT_STARTED` - The protection status is reverse protect started.\n* `REVERSEPROTECT_FAILED` - The protection status is reverse protect failed.\n* `ACTIVE` - The protection status is active.\n* `CREATION_IN_PROGRESS` - The protection status is failover in progress.\n* `CREATION_FAILED` - The protection status is creation failed.\n* `LOCAL_RESTORE_STARTED` - The protection status is local restore started.\n* `LOCAL_RESTORE_FAILED` - The protection status is local restore failed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexVmBackupInfo.ProtectionStatusEnum ProtectionStatus
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
        /// <para type="description">"Retention count from backup policy for remote snapshots."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long SnapshotRetentionCount
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a hyperflexBackupCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexBackupClusterRelationship SrcBackupCluster
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a hyperflexCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexClusterRelationship SrcCluster
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Name for the source cluster this Virtual Machine is residing on."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SrcClusterName
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a hyperflexCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexClusterRelationship TgtCluster
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Name for the target cluster this Virtual Machine is residing on."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string TgtClusterName
        {
            get;
            set;
        }





    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexVmImportOperation.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexVmImportOperation", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexVmImportOperation : GetCmdletBase
    {
        public GetIntersightHyperflexVmImportOperation()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexVmImportOperationListWithHttpInfo";
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
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public AssetDeviceRegistrationRelationship DeviceMoid
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




    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexVmRestoreOperation.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexVmRestoreOperation", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexVmRestoreOperation : GetCmdletBase
    {
        public GetIntersightHyperflexVmRestoreOperation()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexVmRestoreOperationListWithHttpInfo";
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
        /// <para type="description">"New name for the Virtual Machine after recovery."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string NewName
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
        /// <para type="description">"Power on the Virtual Machine after recovery."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool PowerOn
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a hyperflexCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexClusterRelationship RestoreEdgeClusterMoid
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
        /// <para type="description">"Start time for the replication."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long StartTime
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"A reference to a hyperflexVmBackupInfo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexVmBackupInfoRelationship VmBackupInfoMoid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a hyperflexVmSnapshotInfo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexVmSnapshotInfoRelationship VmSnapshotInfoMoid
        {
            get;
            set;
        }


    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexVmSnapshotInfo.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexVmSnapshotInfo", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexVmSnapshotInfo : GetCmdletBase
    {
        public GetIntersightHyperflexVmSnapshotInfo()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexVmSnapshotInfoListWithHttpInfo";
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
        /// <para type="description">"Combined status code from replication and snapshot status to display in the Intersight UI.\n* `NONE` - Snapshot replication state is none.\n* `SUCCESS` - Snapshot completed successfully.\n* `FAILED` - Snapshot failed replication status code.\n* `PAUSED` - Snapshot replication paused status code.\n* `IN_USE` - Snapshot replica in use status code.\n* `STARTING` - Snapshot replication starting.\n* `REPLICATING` - Snapshot replication in progress."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexVmSnapshotInfo.DisplayStatusEnum DisplayStatus
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
        /// <para type="description">"The name of the Virtual Machine and the time stamp of the snapshot."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

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
        /// <para type="description">"Quiesce Mode for snapshot taken on Hyperflex cluster.\n* `NONE` - The snapshot quiesce mode is none.\n* `CRASH` - The snapshot quiesce mode is crash.\n* `VMTOOLS` - The snapshot quiesce mode is VMTOOLS.\n* `APP_CONSISTENT` - The snapshot quiesce mode is app consistent."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexVmSnapshotInfo.ModeEnum Mode
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
        /// <para type="description">"Replication status of the least successful target cluster.\n* `NONE` - Snapshot replication state is none.\n* `SUCCESS` - Snapshot completed successfully.\n* `FAILED` - Snapshot failed replication status code.\n* `PAUSED` - Snapshot replication paused status code.\n* `IN_USE` - Snapshot replica in use status code.\n* `STARTING` - Snapshot replication starting.\n* `REPLICATING` - Snapshot replication in progress."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexVmSnapshotInfo.ReplicationStatusEnum ReplicationStatus
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
        /// <para type="description">"Error message from snapshot creation or replcation if any exist."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SnapshotErrorMsg
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Snapshot status of the source cluster.\n* `SUCCESS` - This snapshot status code is success.\n* `FAILED` - This snapshot status code is failed.\n* `IN_PROGRESS` - This snapshot status code is in progress.\n* `DELETING` - This snapshot status code is deleting.\n* `DELETED` - This snapshot status code is deleted.\n* `NONE` - This snapshot status code is none.\n* `INIT` - This snapshot status code is initializing."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexVmSnapshotInfo.SnapshotStatusEnum SnapshotStatus
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Timestamp the snapshot was created on the source cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long SourceTimestamp
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a hyperflexCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexClusterRelationship SrcCluster
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Name of the cluster this snapshot resides on."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SrcClusterName
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Timestamp the snapshot was finished replicating on the target cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long TargetCompletionTimestamp
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a hyperflexCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexClusterRelationship TgtCluster
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Name of the cluster this snapshot is replicated to."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string TgtClusterName
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a hyperflexVmBackupInfo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexVmBackupInfoRelationship VmBackupInfo
        {
            get;
            set;
        }




    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexVolume.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexVolume", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexVolume : GetCmdletBase
    {
        public GetIntersightHyperflexVolume()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexVolumeListWithHttpInfo";
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
        /// <para type="description">"Provisioned Capacity of the volume in bytes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long Capacity
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Client (tenant) ID to which the volume belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string ClientId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a hyperflexCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexClusterRelationship Cluster
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
        /// <para type="description">"Short description about the volume."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

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
        /// <para type="description">"Last modified time as UTC of the volume."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime LastModifiedTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"UUID of LUN associated with the volume."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string LunUuid
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
        /// <para type="description">"NAA id of volume. It is a significant number to identify corresponding lun path in hypervisor."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string NaaId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Named entity of the volume."</para>
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
        /// <para type="description">"Serial number of the volume."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SerialNumber
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
        /// <para type="description">"User provisioned volume size. It is the size exposed to host."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long Size
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a hyperflexStorageContainer resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexStorageContainerRelationship StorageContainer
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"The unique identifier for this volume."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Uuid
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Access Mode of the volume.\n* `ReadWriteOnce` - Read write permisisons to a Virtual disk by a single virtual machine.\n* `ReadWriteMany` - Read write permisisons to a Virtual disk by multiple virtual machines.\n* `ReadOnlyMany` - Read only permisisons to a Virtual disk by multiple virtual machines.\n* `` - Unknown disk access mode."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexVolume.VolumeAccessModeEnum VolumeAccessMode
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Volume creation time in UTC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime VolumeCreateTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The mode of the HyperFlex volume.\n* `Block` - It is a Block virtual disk.\n* `Filesystem` - It is a File system virtual disk.\n* `` - Disk mode is either unknown or not supported."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public HyperflexVolume.VolumeModeEnum VolumeMode
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The type of the HyperFlex volume."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string VolumeType
        {
            get;
            set;
        }


    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexWitnessConfiguration.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexWitnessConfiguration", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexWitnessConfiguration : GetCmdletBase
    {
        public GetIntersightHyperflexWitnessConfiguration()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexWitnessConfigurationListWithHttpInfo";
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
        /// <para type="description">"A reference to a hyperflexCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public HyperflexClusterRelationship Cluster
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The detailed connection error to the external witness. Empty if status is connected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string ConnectionError
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
        /// <para type="description">"Custom witness has been configured by user."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool CustomWitnessEnabled
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
        /// <para type="description">"The fingerprint of the witness server, identifies the revision of the witness servers database. Only applicable if custom witness has been enabled in the cluster, otherwise value is always empty."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Fingerprint
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
        /// <para type="description">"Status of the devices connection to the witness. Device will report status as either 'Connected' or 'NotConnected'."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Status
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The version of the custom witness server. Only applicable if custom witness has been enabled in the cluster, otherwise value is always empty."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Version
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"URL of the witness endpoint, including IP/host and path. Only applicable if custom witness has been enabled in the cluster, otherwise value is always empty."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string WitnessUrl
        {
            get;
            set;
        }


    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New HyperflexAppCatalog.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightHyperflexAppCatalog")]
    public class NewIntersightHyperflexAppCatalog : NewCmdletBase
    {
        public NewIntersightHyperflexAppCatalog()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexAppCatalog();
            MethodName = "CreateHyperflexAppCatalogWithHttpInfo";
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
        /// <para type="description">"A reference to a hyperflexFeatureLimitExternal resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexFeatureLimitExternalRelationship FeatureLimitExternal
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a hyperflexFeatureLimitInternal resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexFeatureLimitInternalRelationship FeatureLimitInternal
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"An array of relationships to hyperflexHxdpVersion resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<HyperflexHxdpVersionRelationship> HxdpVersions
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"An array of relationships to hyperflexCapabilityInfo resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<HyperflexCapabilityInfoRelationship> HyperflexCapabilityInfos
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"An array of relationships to hclHyperflexSoftwareCompatibilityInfo resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<HclHyperflexSoftwareCompatibilityInfoRelationship> HyperflexSoftwareCompatibilityInfos
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
        /// <para type="description">"A reference to a hyperflexServerFirmwareVersion resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexServerFirmwareVersionRelationship ServerFirmwareVersion
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a hyperflexServerModel resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexServerModelRelationship ServerModel
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"An array of relationships to hyperflexSoftwareDistributionEntry resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<HyperflexSoftwareDistributionEntryRelationship> SoftwareDistributions
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
        /// <para type="description">"The catalog version used in HyperFlex cluster configuration service."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Version
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New HyperflexAutoSupportPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightHyperflexAutoSupportPolicy")]
    public class NewIntersightHyperflexAutoSupportPolicy : NewCmdletBase
    {
        public NewIntersightHyperflexAutoSupportPolicy()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexAutoSupportPolicy();
            MethodName = "CreateHyperflexAutoSupportPolicyWithHttpInfo";
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
        /// <para type="description">"Enable or disable Auto-Support."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool AdminState
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"An array of relationships to hyperflexClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<HyperflexClusterProfileRelationship> ClusterProfiles
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Description of the policy."</para>
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
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
        /// <para type="description">"The recipient email address for support tickets."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$")]
        public string ServiceTicketReceipient
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

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New HyperflexCapabilityInfo.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightHyperflexCapabilityInfo")]
    public class NewIntersightHyperflexCapabilityInfo : NewCmdletBase
    {
        public NewIntersightHyperflexCapabilityInfo()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexCapabilityInfo();
            MethodName = "CreateHyperflexCapabilityInfoWithHttpInfo";
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
        /// <para type="description">"A reference to a hyperflexAppCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexAppCatalogRelationship AppCatalog
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<HclConstraint> CapabilityConstraints
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
        /// <para type="description">"Name of the capability or feature set consisting of a collection of constraint rules and value."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false)]

        public string Name
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


    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New HyperflexClusterBackupPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightHyperflexClusterBackupPolicy")]
    public class NewIntersightHyperflexClusterBackupPolicy : NewCmdletBase
    {
        public NewIntersightHyperflexClusterBackupPolicy()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexClusterBackupPolicy();
            MethodName = "CreateHyperflexClusterBackupPolicyWithHttpInfo";
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
        /// <para type="description">"Backup datastore name prefix used during the auto creation of the datastore. All VMs created in this datastore will be automatically backed up."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string BackupDataStoreName
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Replication data store size in backupDataStoreSizeUnit."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long BackupDataStoreSize
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Replication data store size."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string BackupDataStoreSizeUnit
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a hyperflexCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexClusterRelationship BackupTarget
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"An array of relationships to hyperflexClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<HyperflexClusterProfileRelationship> ClusterProfiles
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Whether the datastore is encrypted or not."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool DataStoreEncryptionEnabled
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Number of snapshots that will be retained as part of the Multi Point in Time support."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 30)]
        public long LocalSnapshotRetentionCount
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
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
        /// <para type="description">"Replication cluster pairing name prefix."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ReplicationPairNamePrefix
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Backup policy replication schedule."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexReplicationSchedule ReplicationSchedule
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Number of snapshots that will be retained as part of the Multi Point in Time support."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 30)]
        public long SnapshotRetentionCount
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

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New HyperflexClusterBackupPolicyDeployment.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightHyperflexClusterBackupPolicyDeployment")]
    public class NewIntersightHyperflexClusterBackupPolicyDeployment : NewCmdletBase
    {
        public NewIntersightHyperflexClusterBackupPolicyDeployment()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexClusterBackupPolicyDeployment();
            MethodName = "CreateHyperflexClusterBackupPolicyDeploymentWithHttpInfo";
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
        /// <para type="description">"A reference to a hyperflexCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexClusterRelationship BackupTarget
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"True if record created by discovery on HyperFlex cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Discovered
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
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public OrganizationOrganizationRelationship Organization
        {
            get;
            set;
        }










        // <summary>
        /// <para type="description">"A reference to a hyperflexCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexClusterRelationship SourceCluster
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"True if policy was detached from source Hyperflex Cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool SourceDetached
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
        /// <para type="description">"True if policy was detached from target Hyperflex Cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool TargetDetached
        {
            get;
            set;
        }



    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New HyperflexClusterNetworkPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightHyperflexClusterNetworkPolicy")]
    public class NewIntersightHyperflexClusterNetworkPolicy : NewCmdletBase
    {
        public NewIntersightHyperflexClusterNetworkPolicy()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexClusterNetworkPolicy();
            MethodName = "CreateHyperflexClusterNetworkPolicyWithHttpInfo";
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
        /// <para type="description">"An array of relationships to hyperflexClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<HyperflexClusterProfileRelationship> ClusterProfiles
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Enable or disable Jumbo Frames (MTU=9000). Jumbo Frames are used by Storage Network, VM Migration Network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool JumboFrame
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The Out-of-band KVM IP range.\nConfigures the service profiles to use IP addresses within this range for setting the KVM IP of a server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexIpAddrRange KvmIpRange
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The MAC address prefix range for configuring vNICs.\nConfigures the service profiles to use MAC address prefixes within this range for setting the MAC address of server vNICs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexMacAddrPrefixRange MacPrefixRange
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The VLAN for the management network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexNamedVlan MgmtVlan
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
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
        /// <para type="description">"Link speed of the server adapter port to the upstream switch. When the policy is attached to a cluster profile with EDGE management platform, the uplink speed can be '1G' or '10G+'. Use '10G+' for link speeds of 10G or above. When the policy is attached to a cluster profile with Fabric Interconnect management platform, the uplink speed can be 'default' only.\n* `default` - Current default value set on the hardware platform.\n* `1G` - A link speed of 1 gigabit per second.\n* `10G` - A link speed of 10 gigabits per second or above."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexClusterNetworkPolicy.UplinkSpeedEnum UplinkSpeed
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The VM migration VLAN.\nThis VLAN is used for transfering VMs from one host to another during operations such a cluster upgrade.\nFor HyperFlex Application Platform clusters, this VLAN is also used for hypervisor control traffic such as\nnode to node communication, pod-to-pod communication, etc."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexNamedVlan VmMigrationVlan
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<HyperflexNamedVlan> VmNetworkVlans
        {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New HyperflexClusterProfile.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightHyperflexClusterProfile")]
    public class NewIntersightHyperflexClusterProfile : NewCmdletBase
    {
        public NewIntersightHyperflexClusterProfile()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexClusterProfile();
            MethodName = "CreateHyperflexClusterProfileWithHttpInfo";
        }


        // <summary>
        /// <para type="description">"User initiated action. Each profile type has its own supported actions. For HyperFlex cluster profile, the supported actions are -- Validate, Deploy, Continue, Retry, Abort, Unassign For server profile, the support actions are -- Deploy, Unassign."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Action
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<PolicyActionParam> ActionParams
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
        /// <para type="description">"A reference to a hyperflexCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexClusterRelationship AssociatedCluster
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a hyperflexAutoSupportPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexAutoSupportPolicyRelationship AutoSupport
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A CIDR subnet for the cluster internal network. This applies to Intersight Workload Engine clusters only."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CommIpV4Interface ClusterInternalSubnet
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a hyperflexClusterNetworkPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexClusterNetworkPolicyRelationship ClusterNetwork
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a hyperflexClusterStoragePolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexClusterStoragePolicyRelationship ClusterStorage
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The configuration state and results of the last configuration operation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public PolicyConfigContext ConfigContext
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"The storage data IP address for the HyperFlex cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string DataIpAddress
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Description of the profile."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a hyperflexExtFcStoragePolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexExtFcStoragePolicyRelationship ExtFcStorage
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a hyperflexExtIscsiStoragePolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexExtIscsiStoragePolicyRelationship ExtIscsiStorage
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The node name prefix that is used to automatically generate the default hostname for each server.\nA dash (-) will be appended to the prefix followed by the node number to form a hostname.\nThis default naming scheme can be manually overridden in the node configuration.\nThe maximum length of a prefix is 60, must only contain alphanumeric characters or dash (-), and must\nstart with an alphanumeric character."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9][a-zA-Z0-9-]{1,59}$")]
        public string HostNamePrefix
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a commHttpProxyPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CommHttpProxyPolicyRelationship Httpproxypolicy
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The hypervisor control virtual IP address for the HyperFlex compute cluster that is used for node/pod management."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string HypervisorControlIpAddress
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The hypervisor type for the HyperFlex cluster.\n* `ESXi` - The hypervisor running on the HyperFlex cluster is a Vmware ESXi hypervisor of any version.\n* `Hyper-V` - The hypervisor running on the HyperFlex cluster is Microsoft Hyper-V.\n* `Unknown` - The hypervisor running on the HyperFlex cluster is not known."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexClusterProfile.HypervisorTypeEnum HypervisorType
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a hyperflexLocalCredentialPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexLocalCredentialPolicyRelationship LocalCredential
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The MAC address prefix in the form of 00:25:B5:XX."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^00:25:B5:[0-9a-fA-F]{2}$")]
        public string MacAddressPrefix
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The management IP address for the HyperFlex cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string MgmtIpAddress
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The management platform for the HyperFlex cluster.\n* `FI` - The host servers used in the cluster deployment are managed by a UCS Fabric Interconnect.\n* `EDGE` - The host servers used in the cluster deployment are standalone severs.\n* `DC-No-FI` - The host servers used in the cluster deployment are standalone servers with the DC Advantage license."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexClusterProfile.MgmtPlatformEnum MgmtPlatform
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
        /// <para type="description">"Name of the profile instance or profile template."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a hyperflexNodeConfigPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexNodeConfigPolicyRelationship NodeConfig
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"An array of relationships to hyperflexNodeProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<HyperflexNodeProfileRelationship> NodeProfileConfig
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
        /// <para type="description">"An array of relationships to policyAbstractPolicy resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<PolicyAbstractPolicyRelationship> PolicyBucket
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a hyperflexProxySettingPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexProxySettingPolicyRelationship ProxySetting
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The number of copies of each data block written."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Replication
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<PolicyScheduledAction> ScheduledActions
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a hyperflexSoftwareVersionPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexSoftwareVersionPolicyRelationship SoftwareVersion
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a policyAbstractProfile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public PolicyAbstractProfileRelationship SrcTemplate
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The storage data IP address for the HyperFlex cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string StorageClientIpAddress
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The netmask for the Storage client network IP address."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string StorageClientNetmask
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The named VLAN associated with this cluster's storage client network. This applies to Intersight Workload Engine clusters only."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexNamedVlan StorageClientVlan
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The auxiliary storage IP address for the HyperFlex cluster. For two node clusters, this is the IP address of the auxiliary ZK controller."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string StorageClusterAuxiliaryIp
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The VLAN for the HyperFlex storage data traffic."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexNamedVlan StorageDataVlan
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The storage type used for the HyperFlex cluster (HyperFlex Storage or 3rd party).\n* `HyperFlexDp` - The type of storage is HyperFlex Data Platform.\n* `ThirdParty` - The type of storage is 3rd Party Storage (PureStorage, etc..)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexClusterProfile.StorageTypeEnum StorageType
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a hyperflexSysConfigPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexSysConfigPolicyRelationship SysConfig
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
        /// <para type="description">"Defines the type of the profile. Accepted values are instance or template.\n* `instance` - The profile defines the configuration for a specific instance of a target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexClusterProfile.TypeEnum Type
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a hyperflexUcsmConfigPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexUcsmConfigPolicyRelationship UcsmConfig
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a hyperflexVcenterConfigPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexVcenterConfigPolicyRelationship VcenterConfig
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The WWxN prefix in the form of 20:00:00:25:B5:XX."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^20:00:00:25:B5:[0-9a-fA-F]{2}$")]
        public string WwxnPrefix
        {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New HyperflexClusterReplicationNetworkPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightHyperflexClusterReplicationNetworkPolicy")]
    public class NewIntersightHyperflexClusterReplicationNetworkPolicy : NewCmdletBase
    {
        public NewIntersightHyperflexClusterReplicationNetworkPolicy()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexClusterReplicationNetworkPolicy();
            MethodName = "CreateHyperflexClusterReplicationNetworkPolicyWithHttpInfo";
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
        /// <para type="description">"An array of relationships to hyperflexClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<HyperflexClusterProfileRelationship> ClusterProfiles
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Description of the policy."</para>
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
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
        /// <para type="description">"Bandwidth for the Replication network in Mbps."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long ReplicationBandwidthMbps
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<HyperflexIpAddrRange> ReplicationIpranges
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"MTU for the Replication network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1024, 1500)]
        public long ReplicationMtu
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"VLAN for the Replication network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexNamedVlan ReplicationVlan
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

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New HyperflexClusterReplicationNetworkPolicyDeployment.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightHyperflexClusterReplicationNetworkPolicyDeployment")]
    public class NewIntersightHyperflexClusterReplicationNetworkPolicyDeployment : NewCmdletBase
    {
        public NewIntersightHyperflexClusterReplicationNetworkPolicyDeployment()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexClusterReplicationNetworkPolicyDeployment();
            MethodName = "CreateHyperflexClusterReplicationNetworkPolicyDeploymentWithHttpInfo";
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
        /// <para type="description">"A reference to a hyperflexCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexClusterRelationship Cluster
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"True if record created by discovery on HyperFlex cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Discovered
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

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New HyperflexClusterStoragePolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightHyperflexClusterStoragePolicy")]
    public class NewIntersightHyperflexClusterStoragePolicy : NewCmdletBase
    {
        public NewIntersightHyperflexClusterStoragePolicy()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexClusterStoragePolicy();
            MethodName = "CreateHyperflexClusterStoragePolicyWithHttpInfo";
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
        /// <para type="description">"An array of relationships to hyperflexClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<HyperflexClusterProfileRelationship> ClusterProfiles
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"If enabled, formats existing disk partitions (destroys all user data)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool DiskPartitionCleanup
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Enable or disable Logical Availability Zones (LAZ). If enabled, HyperFlex Data Platform automatically selects and groups nodes into different availability zones. For HyperFlex Data Platform versions prior to 3.0 release, this setting does not apply. For HyperFlex Data Platform versions 3.0 or higher, this setting is only applicable to HyperFlex systems with 8 or more converged nodes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexLogicalAvailabilityZone LogicalAvalabilityZoneConfig
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
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
        /// <para type="description">"Enable or disable VDI optimization (hybrid HyperFlex systems only)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool VdiOptimization
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New HyperflexExtFcStoragePolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightHyperflexExtFcStoragePolicy")]
    public class NewIntersightHyperflexExtFcStoragePolicy : NewCmdletBase
    {
        public NewIntersightHyperflexExtFcStoragePolicy()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexExtFcStoragePolicy();
            MethodName = "CreateHyperflexExtFcStoragePolicyWithHttpInfo";
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
        /// <para type="description">"Enables or disables external FC storage configuration."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool AdminState
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"An array of relationships to hyperflexClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<HyperflexClusterProfileRelationship> ClusterProfiles
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"VSAN for the primary Fabric Interconnect external FC storage traffic."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexNamedVsan ExtaTraffic
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"VSAN for the secondary Fabric Interconnect external FC storage traffic."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexNamedVsan ExtbTraffic
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
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
        /// <para type="description">"The range of WWxN addresses to use for the FC storage configuration."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexWwxnPrefixRange WwxnPrefixRange
        {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New HyperflexExtIscsiStoragePolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightHyperflexExtIscsiStoragePolicy")]
    public class NewIntersightHyperflexExtIscsiStoragePolicy : NewCmdletBase
    {
        public NewIntersightHyperflexExtIscsiStoragePolicy()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexExtIscsiStoragePolicy();
            MethodName = "CreateHyperflexExtIscsiStoragePolicyWithHttpInfo";
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
        /// <para type="description">"Enable or disable external iSCSI storage configuration."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool AdminState
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"An array of relationships to hyperflexClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<HyperflexClusterProfileRelationship> ClusterProfiles
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"VLAN for the primary Fabric Interconnect external iSCSI storage traffic."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexNamedVlan ExtaTraffic
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"VLAN for the secondary Fabric Interconnect external iSCSI storage traffic."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexNamedVlan ExtbTraffic
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
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

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New HyperflexFeatureLimitExternal.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightHyperflexFeatureLimitExternal")]
    public class NewIntersightHyperflexFeatureLimitExternal : NewCmdletBase
    {
        public NewIntersightHyperflexFeatureLimitExternal()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexFeatureLimitExternal();
            MethodName = "CreateHyperflexFeatureLimitExternalWithHttpInfo";
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
        /// <para type="description">"A reference to a hyperflexAppCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexAppCatalogRelationship AppCatalog
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<HyperflexFeatureLimitEntry> FeatureLimitEntries
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<MoTag> Tags
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New HyperflexFeatureLimitInternal.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightHyperflexFeatureLimitInternal")]
    public class NewIntersightHyperflexFeatureLimitInternal : NewCmdletBase
    {
        public NewIntersightHyperflexFeatureLimitInternal()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexFeatureLimitInternal();
            MethodName = "CreateHyperflexFeatureLimitInternalWithHttpInfo";
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
        /// <para type="description">"A reference to a hyperflexAppCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexAppCatalogRelationship AppCatalog
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<HyperflexFeatureLimitEntry> FeatureLimitEntries
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<MoTag> Tags
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New HyperflexHealthCheckDefinition.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightHyperflexHealthCheckDefinition")]
    public class NewIntersightHyperflexHealthCheckDefinition : NewCmdletBase
    {
        public NewIntersightHyperflexHealthCheckDefinition()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexHealthCheckDefinition();
            MethodName = "CreateHyperflexHealthCheckDefinitionWithHttpInfo";
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
        /// <para type="description">"Category that the health check belongs to."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Category
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Static information detailing the common causes for the health check failure."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string CommonCauses
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Execution configuration fo the health check script."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Configuration
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"Description of the health check definition."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"Static information detailing the health impact of the health check failure."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string HealthImpact
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Internal name of the health check definition."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string InternalName
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Minimum HyperFlex version that the check is supported on. Defaults to version 3.0.1."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string MinimumHyperFlexVersion
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
        /// <para type="description">"Name of the health check definition."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"Static information containing additional reference for the health check."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Reference
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Static information detailing the possible remediation actions that can be taken to remedy the health check failure."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Resolution
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Execution mode of the health script on the HyperFlex cluster.\n* `ON_DEMAND` - Execute the health check on-demand.\n* `SCHEDULED` - Execute the health check on a scheduled interval."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexHealthCheckDefinition.ScriptExecutionModeEnum ScriptExecutionMode
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Indicates if the script needs to be executed on HyperFlex compute nodes. |\nTypically, scripts are only executed on the storage Nodes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool ScriptExecutionOnComputeNodes
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
        /// <para type="description">"Indicates whether the health check is executed only on the leader node, or on all nodes in the HyperFlex cluster.\n* `EXECUTE_ON_LEADER_NODE` - Execute the health check script only on the HyperFlex cluster's leader node.\n* `EXECUTE_ON_ALL_NODES` - Execute health check on all nodes and aggregate the results.\n* `EXECUTE_ON_ALL_NODES_AND_AGGREGATE` - Execute the health check on all Nodes and perform custom aggregation.\n* `EXECUTE_ON_CURRENT_NODE` - The HyperFlex health check is executed on the node which receives the request."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexHealthCheckDefinition.TargetExecutionTypeEnum TargetExecutionType
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Health check script execution timeout."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Timeout
        {
            get;
            set;
        }


    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New HyperflexHealthCheckPackageChecksum.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightHyperflexHealthCheckPackageChecksum")]
    public class NewIntersightHyperflexHealthCheckPackageChecksum : NewCmdletBase
    {
        public NewIntersightHyperflexHealthCheckPackageChecksum()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexHealthCheckPackageChecksum();
            MethodName = "CreateHyperflexHealthCheckPackageChecksumWithHttpInfo";
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
        /// <para type="description">"SHA512 checksum of the health check package."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Checksum
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
        /// <para type="description">"Name of the health check Debian package."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"HyperFlex health check Debian package file name."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string PackageName
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
        /// <para type="description">"Timestamp of last update of HyperFlex health check package checksum."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime Timestamp
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"HyperFlex health check Debian Package Version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Version
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New HyperflexHxdpVersion.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightHyperflexHxdpVersion")]
    public class NewIntersightHyperflexHxdpVersion : NewCmdletBase
    {
        public NewIntersightHyperflexHxdpVersion()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexHxdpVersion();
            MethodName = "CreateHyperflexHxdpVersionWithHttpInfo";
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
        /// <para type="description">"A reference to a hyperflexAppCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexAppCatalogRelationship AppCatalog
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<MoTag> Tags
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The HyperFlex Data Platform version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Version
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New HyperflexKeyEncryptionKey.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightHyperflexKeyEncryptionKey")]
    public class NewIntersightHyperflexKeyEncryptionKey : NewCmdletBase
    {
        public NewIntersightHyperflexKeyEncryptionKey()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexKeyEncryptionKey();
            MethodName = "CreateHyperflexKeyEncryptionKeyWithHttpInfo";
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
        /// <para type="description">"A reference to a hyperflexClusterProfile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexClusterProfileRelationship ClusterProfile
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"This defines whether we need to operate in an account recovery scenario or not. If yes, then most of the parameters will be populated from an internal MO. So, some of the input parameters MAY be ignored, if this value is set to true."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool IsAccountRecovery
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"Number of iterations we want the hash to be run."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Iteration
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Key encryption key used to encrypt the DEK's on the HyperFlex cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Kek
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Resource id + time of creation used for retrieving the KEK."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string KeyId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Last known Key encryption key state for this Key.\n* `NEW` - Key Encryption key is newly created.\n* `ACTIVE` - Key Encryption key is deployed on active resource.\n* `INACTIVE` - Key Encryption key is inactive and not used.\n* `INPROGRESS` - Key Encryption key is in a state where it was used on Intersight but did not receive confirmation from platform of success/failure."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexKeyEncryptionKey.KeyStateEnum KeyState
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
        /// <para type="description">"Initial passphrase for the encryption policy, password must contain a minimum of 12 characters, with at least 1 lowercase, 1 uppercase, 1 numeric."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Passphrase
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public MoBaseMoRelationship ResourceMo
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Resource type on which this key will be applied.\n* `CLUSTER` - Encryption is per HyperFlex cluster.\n* `DATASTORE` - Encryption is per dataStore on the HyperFlex cluster.\n* `DRIVE` - Encryption is per drive on the HyperFlex cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexKeyEncryptionKey.ResourceTypeEnum ResourceType
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
        /// <para type="description">"Copy of Key encryption key, which is used for sending the key over to the remote device endpoint. It is not persisited anywhere."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string TransitKek
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New HyperflexLocalCredentialPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightHyperflexLocalCredentialPolicy")]
    public class NewIntersightHyperflexLocalCredentialPolicy : NewCmdletBase
    {
        public NewIntersightHyperflexLocalCredentialPolicy()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexLocalCredentialPolicy();
            MethodName = "CreateHyperflexLocalCredentialPolicyWithHttpInfo";
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
        /// <para type="description">"An array of relationships to hyperflexClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<HyperflexClusterProfileRelationship> ClusterProfiles
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Indicates if Hypervisor password is the factory set default password. For HyperFlex Data Platform versions 3.0 or higher, enable this if the default password was not changed on the Hypervisor. It is required to supply a new custom Hypervisor password that will be applied to the Hypervisor during deployment. For HyperFlex Data Platform versions prior to 3.0 release, this setting has no effect and the default password will be used for initial install. The Hypervisor password should be changed after deployment."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool FactoryHypervisorPassword
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"HyperFlex storage controller VM password must contain a minimum of 10 characters, with at least 1 lowercase, 1 uppercase, 1 numeric, and 1 of these -_@#$%^&*! special characters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9!@#$%^&*_-]{10,}$")]
        public string HxdpRootPwd
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Hypervisor administrator username must contain only alphanumeric characters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9]{1,}$")]
        public string HypervisorAdmin
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The Hypervisor root password. For HyperFlex Data Platform 3.0 or later, if the factory default password was not manually changed, you must set a new custom password. If the password was manually changed, you must not enable the factory default password property and provide the current hypervisor password. Note - All HyperFlex nodes require the same hypervisor password for installation. For HyperFlex Data Platform prior to 3.0, use the default password \"Cisco123\" for newly manufactured HyperFlex servers. A custom password should only be entered if hypervisor credentials were manually changed prior to deployment."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^.{7,40}$")]
        public string HypervisorAdminPwd
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
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

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New HyperflexNodeConfigPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightHyperflexNodeConfigPolicy")]
    public class NewIntersightHyperflexNodeConfigPolicy : NewCmdletBase
    {
        public NewIntersightHyperflexNodeConfigPolicy()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexNodeConfigPolicy();
            MethodName = "CreateHyperflexNodeConfigPolicyWithHttpInfo";
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
        /// <para type="description">"An array of relationships to hyperflexClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<HyperflexClusterProfileRelationship> ClusterProfiles
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The range of storage data IPs to be assigned to the nodes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexIpAddrRange DataIpRange
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The range of storage management IPs to be assigned to the nodes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexIpAddrRange HxdpIpRange
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The range of IPs to be assigned to each hypervisor node for VM migration and hypervior control."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexIpAddrRange HypervisorControlIpRange
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The range of management IPs to be assigned to the nodes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexIpAddrRange MgmtIpRange
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The node name prefix that is used to automatically generate the default hostname for each server.\nA dash (-) will be appended to the prefix followed by the node number to form a hostname.\nThis default naming scheme can be manually overridden in the node configuration.\nThe maximum length of a prefix is 60, must only contain alphanumeric characters or dash (-), and must\nstart with an alphanumeric character."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9][a-zA-Z0-9-]{1,59}$")]
        public string NodeNamePrefix
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

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New HyperflexNodeProfile.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightHyperflexNodeProfile")]
    public class NewIntersightHyperflexNodeProfile : NewCmdletBase
    {
        public NewIntersightHyperflexNodeProfile()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexNodeProfile();
            MethodName = "CreateHyperflexNodeProfileWithHttpInfo";
        }


        // <summary>
        /// <para type="description">"User initiated action. Each profile type has its own supported actions. For HyperFlex cluster profile, the supported actions are -- Validate, Deploy, Continue, Retry, Abort, Unassign For server profile, the support actions are -- Deploy, Unassign."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Action
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<PolicyActionParam> ActionParams
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
        /// <para type="description">"A reference to a computePhysical resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ComputePhysicalRelationship AssignedServer
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a hyperflexClusterProfile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexClusterProfileRelationship ClusterProfile
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The configuration state and results of the last configuration operation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public PolicyConfigContext ConfigContext
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Description of the profile."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"IP address for storage data network (Controller VM interface)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string HxdpDataIp
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"IP address for HyperFlex management network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string HxdpMgmtIp
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"IP address for storage client network (Controller VM interface)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string HxdpStorageClientIp
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"IP address for hypervisor control such as VM migration or pod management."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string HypervisorControlIp
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"IP address for storage data network (Hypervisor interface)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string HypervisorDataIp
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"IP address for Hypervisor management network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string HypervisorMgmtIp
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
        /// <para type="description">"Name of the profile instance or profile template."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The role that this node performs in the HyperFlex cluster.\n* `Unknown` - The node role is not available.\n* `Storage` - The node persists data and contributes to the storage capacity of a cluster.\n* `Compute` - The node contributes to the compute capacity of a cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexNodeProfile.NodeRoleEnum NodeRole
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"An array of relationships to policyAbstractPolicy resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<PolicyAbstractPolicyRelationship> PolicyBucket
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<PolicyScheduledAction> ScheduledActions
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a policyAbstractProfile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public PolicyAbstractProfileRelationship SrcTemplate
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
        /// <para type="description">"Defines the type of the profile. Accepted values are instance or template.\n* `instance` - The profile defines the configuration for a specific instance of a target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexNodeProfile.TypeEnum Type
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New HyperflexProxySettingPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightHyperflexProxySettingPolicy")]
    public class NewIntersightHyperflexProxySettingPolicy : NewCmdletBase
    {
        public NewIntersightHyperflexProxySettingPolicy()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexProxySettingPolicy();
            MethodName = "CreateHyperflexProxySettingPolicyWithHttpInfo";
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
        /// <para type="description">"An array of relationships to hyperflexClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<HyperflexClusterProfileRelationship> ClusterProfiles
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"HTTP Proxy server FQDN or IP."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[A-Za-z]([A-Za-z0-9-]*[A-Za-z0-9])?$|^[A-Za-z0-9]([A-Za-z0-9-]*[A-Za-z0-9])?(\\.[A-Za-z0-9]([A-Za-z0-9-]*[A-Za-z0-9])?)*(\\.[A-Za-z]([A-Za-z0-9-]*[A-Za-z0-9])?)$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string Hostname
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
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
        /// <para type="description">"The password for the HTTP Proxy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Password
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The HTTP Proxy port number.\nThe port number of the HTTP proxy must be between 1 and 65535, inclusive."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 65535)]
        public long Port
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
        /// <para type="description">"The username for the HTTP Proxy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Username
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New HyperflexReduceReSync.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightHyperflexReduceReSync")]
    public class NewIntersightHyperflexReduceReSync : NewCmdletBase
    {
        public NewIntersightHyperflexReduceReSync()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexReduceReSync();
            MethodName = "CreateHyperflexReduceReSyncWithHttpInfo";
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
        /// <para type="description">"The HyperFlex reduce re-sync script execution completion status."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool CompletionStatus
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<MoTag> Tags
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New HyperflexServerFirmwareVersion.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightHyperflexServerFirmwareVersion")]
    public class NewIntersightHyperflexServerFirmwareVersion : NewCmdletBase
    {
        public NewIntersightHyperflexServerFirmwareVersion()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexServerFirmwareVersion();
            MethodName = "CreateHyperflexServerFirmwareVersionWithHttpInfo";
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
        /// <para type="description">"A reference to a hyperflexAppCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexAppCatalogRelationship AppCatalog
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
        /// <para type="description">"An array of relationships to hyperflexServerFirmwareVersionEntry resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<HyperflexServerFirmwareVersionEntryRelationship> ServerFirmwareVersionEntries
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

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New HyperflexServerFirmwareVersionEntry.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightHyperflexServerFirmwareVersionEntry")]
    public class NewIntersightHyperflexServerFirmwareVersionEntry : NewCmdletBase
    {
        public NewIntersightHyperflexServerFirmwareVersionEntry()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexServerFirmwareVersionEntry();
            MethodName = "CreateHyperflexServerFirmwareVersionEntryWithHttpInfo";
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
        /// <para type="description">"The conditions that must be satisfied before applying the AppSetting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexAppSettingConstraint Constraint
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
        /// <para type="description">"A reference to a hyperflexServerFirmwareVersion resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexServerFirmwareVersionRelationship ServerFirmwareVersion
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The server platform type that is applicable for the server firmware bundle version.\n* `M5` - M5 generation of UCS server.\n* `M3` - M3 generation of UCS server.\n* `M4` - M4 generation of UCS server.\n* `M6` - M6 generation of UCS server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexServerFirmwareVersionEntry.ServerPlatformEnum ServerPlatform
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
        /// <para type="description">"The server firmware bundle version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("(^3\\.[1-9]\\([1-9][a-z]\\)$|^[4-9]\\.[0-9]\\([1-9][a-z]\\)$)")]
        public string Version
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New HyperflexServerModel.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightHyperflexServerModel")]
    public class NewIntersightHyperflexServerModel : NewCmdletBase
    {
        public NewIntersightHyperflexServerModel()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexServerModel();
            MethodName = "CreateHyperflexServerModelWithHttpInfo";
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
        /// <para type="description">"A reference to a hyperflexAppCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexAppCatalogRelationship AppCatalog
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<HyperflexServerModelEntry> ServerModelEntries
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

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New HyperflexServiceAuthToken.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightHyperflexServiceAuthToken")]
    public class NewIntersightHyperflexServiceAuthToken : NewCmdletBase
    {
        public NewIntersightHyperflexServiceAuthToken()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexServiceAuthToken();
            MethodName = "CreateHyperflexServiceAuthTokenWithHttpInfo";
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
        /// <para type="description">"Client Id or tenant Id of the entity that uses the service auth token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ClientId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a hyperflexCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexClusterRelationship Cluster
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Version of Container Storage Interface (CSI) that the tokenOwner is associated with."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string CsiVersion
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
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public MoBaseMoRelationship TokenOwner
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New HyperflexSoftwareDistributionComponent.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightHyperflexSoftwareDistributionComponent")]
    public class NewIntersightHyperflexSoftwareDistributionComponent : NewCmdletBase
    {
        public NewIntersightHyperflexSoftwareDistributionComponent()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexSoftwareDistributionComponent();
            MethodName = "CreateHyperflexSoftwareDistributionComponentWithHttpInfo";
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
        /// <para type="description">"The bucket name where the files are present, if source is external cloud store."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string BucketName
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The HyperFlex Software Distribution Component Identifier."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ComponentId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The HyperFlex Software Distribution Component Name."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ComponentName
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"File location on the cloud storage."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string FilePath
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> FilesToDownload
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
        /// <para type="description">"A reference to a hyperflexSoftwareDistributionVersion resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexSoftwareDistributionVersionRelationship SoftwareDistributionVersion
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
        /// <para type="description">"The HyperFlex Software Distribution Component Version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Version
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New HyperflexSoftwareDistributionEntry.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightHyperflexSoftwareDistributionEntry")]
    public class NewIntersightHyperflexSoftwareDistributionEntry : NewCmdletBase
    {
        public NewIntersightHyperflexSoftwareDistributionEntry()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexSoftwareDistributionEntry();
            MethodName = "CreateHyperflexSoftwareDistributionEntryWithHttpInfo";
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
        /// <para type="description">"A reference to a hyperflexAppCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexAppCatalogRelationship AppCatalog
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The HyperFlex Software Distribution type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string DistributionType
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"An array of relationships to hyperflexSoftwareDistributionVersion resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<HyperflexSoftwareDistributionVersionRelationship> DistributionVersions
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<MoTag> Tags
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New HyperflexSoftwareDistributionVersion.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightHyperflexSoftwareDistributionVersion")]
    public class NewIntersightHyperflexSoftwareDistributionVersion : NewCmdletBase
    {
        public NewIntersightHyperflexSoftwareDistributionVersion()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexSoftwareDistributionVersion();
            MethodName = "CreateHyperflexSoftwareDistributionVersionWithHttpInfo";
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
        /// <para type="description">"An array of relationships to hyperflexSoftwareDistributionComponent resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<HyperflexSoftwareDistributionComponentRelationship> DistributionComponents
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
        /// <para type="description">"A reference to a hyperflexSoftwareDistributionEntry resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexSoftwareDistributionEntryRelationship SoftwareDistributionEntry
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
        /// <para type="description">"The HyperFlex Software Distribution version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Version
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New HyperflexSoftwareVersionPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightHyperflexSoftwareVersionPolicy")]
    public class NewIntersightHyperflexSoftwareVersionPolicy : NewCmdletBase
    {
        public NewIntersightHyperflexSoftwareVersionPolicy()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexSoftwareVersionPolicy();
            MethodName = "CreateHyperflexSoftwareVersionPolicyWithHttpInfo";
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
        /// <para type="description">"An array of relationships to hyperflexClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<HyperflexClusterProfileRelationship> ClusterProfiles
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Desired HyperFlex Data Platform software version to apply on the HyperFlex cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string HxdpVersion
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Desired  hypervisor version to apply for all the nodes on the HyperFlex cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string HypervisorVersion
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
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
        /// <para type="description">"Desired server firmware version to apply on the HyperFlex Cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|(^3\\.[0-9]\\([1-9][a-z]\\)$|^[4-9]\\.[1-9]\\([1-9][a-z]\\)$|^4\\.0\\([1-3][a-z]\\)$|^4\\.0\\(4[d-z]\\)$|4\\.0\\([5-9][a-z]\\)$|^[4-9]\\.[0-9]\\([0-9](\\.[0-9]+|[a-z]).*\\)$)")]
        public string ServerFirmwareVersion
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<HyperflexServerFirmwareVersionInfo> ServerFirmwareVersions
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<HyperflexSoftwareVersionPolicy.UpgradeTypesEnum> UpgradeTypes
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New HyperflexStartReduceReSync.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightHyperflexStartReduceReSync")]
    public class NewIntersightHyperflexStartReduceReSync : NewCmdletBase
    {
        public NewIntersightHyperflexStartReduceReSync()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexStartReduceReSync();
            MethodName = "CreateHyperflexStartReduceReSyncWithHttpInfo";
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
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The cleanup operation to perform.\n* `NoOp` - Does not perform any operation when the API is called.\n* `StartReduceResync` - Start the execution of reduce re-sync and stale mirror cleanup for the HyperFlex clusters associated with the account."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexStartReduceReSync.OperationEnum Operation
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

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New HyperflexSysConfigPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightHyperflexSysConfigPolicy")]
    public class NewIntersightHyperflexSysConfigPolicy : NewCmdletBase
    {
        public NewIntersightHyperflexSysConfigPolicy()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexSysConfigPolicy();
            MethodName = "CreateHyperflexSysConfigPolicyWithHttpInfo";
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
        /// <para type="description">"An array of relationships to hyperflexClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<HyperflexClusterProfileRelationship> ClusterProfiles
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The DNS Search Domain Name. This setting applies to HyperFlex Data Platform 3.0 or later only."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^([a-zA-Z0-9]([a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?\\.)*[a-zA-Z]{2,63}$")]
        public string DnsDomainName
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> DnsServers
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> NtpServers
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
        /// <para type="description">"The timezone of the HyperFlex cluster's system clock.\n* `Pacific/Niue` - \n* `Pacific/Pago_Pago` - \n* `Pacific/Honolulu` - \n* `Pacific/Rarotonga` - \n* `Pacific/Tahiti` - \n* `Pacific/Marquesas` - \n* `America/Anchorage` - \n* `Pacific/Gambier` - \n* `America/Los_Angeles` - \n* `America/Tijuana` - \n* `America/Vancouver` - \n* `America/Whitehorse` - \n* `Pacific/Pitcairn` - \n* `America/Dawson_Creek` - \n* `America/Denver` - \n* `America/Edmonton` - \n* `America/Hermosillo` - \n* `America/Mazatlan` - \n* `America/Phoenix` - \n* `America/Yellowknife` - \n* `America/Belize` - \n* `America/Chicago` - \n* `America/Costa_Rica` - \n* `America/El_Salvador` - \n* `America/Guatemala` - \n* `America/Managua` - \n* `America/Mexico_City` - \n* `America/Regina` - \n* `America/Tegucigalpa` - \n* `America/Winnipeg` - \n* `Pacific/Galapagos` - \n* `America/Bogota` - \n* `America/Cancun` - \n* `America/Cayman` - \n* `America/Guayaquil` - \n* `America/Havana` - \n* `America/Iqaluit` - \n* `America/Jamaica` - \n* `America/Lima` - \n* `America/Nassau` - \n* `America/New_York` - \n* `America/Nuuk` - \n* `America/Panama` - \n* `America/Port-au-Prince` - \n* `America/Rio_Branco` - \n* `America/Toronto` - \n* `Pacific/Easter` - \n* `America/Caracas` - \n* `America/Asuncion` - \n* `America/Barbados` - \n* `America/Boa_Vista` - \n* `America/Campo_Grande` - \n* `America/Cuiaba` - \n* `America/Curacao` - \n* `America/Grand_Turk` - \n* `America/Guyana` - \n* `America/Halifax` - \n* `America/La_Paz` - \n* `America/Manaus` - \n* `America/Martinique` - \n* `America/Port_of_Spain` - \n* `America/Porto_Velho` - \n* `America/Puerto_Rico` - \n* `America/Santo_Domingo` - \n* `America/Thule` - \n* `Atlantic/Bermuda` - \n* `America/St_Johns` - \n* `America/Araguaina` - \n* `America/Argentina/Buenos_Aires` - \n* `America/Bahia` - \n* `America/Belem` - \n* `America/Cayenne` - \n* `America/Fortaleza` - \n* `America/Godthab` - \n* `America/Maceio` - \n* `America/Miquelon` - \n* `America/Montevideo` - \n* `America/Paramaribo` - \n* `America/Recife` - \n* `America/Santiago` - \n* `America/Sao_Paulo` - \n* `Antarctica/Palmer` - \n* `Antarctica/Rothera` - \n* `Atlantic/Stanley` - \n* `America/Noronha` - \n* `Atlantic/South_Georgia` - \n* `America/Scoresbysund` - \n* `Atlantic/Azores` - \n* `Atlantic/Cape_Verde` - \n* `Africa/Abidjan` - \n* `Africa/Accra` - \n* `Africa/Bissau` - \n* `Africa/Casablanca` - \n* `Africa/El_Aaiun` - \n* `Africa/Monrovia` - \n* `America/Danmarkshavn` - \n* `Atlantic/Canary` - \n* `Atlantic/Faroe` - \n* `Atlantic/Reykjavik` - \n* `Etc/GMT` - \n* `Europe/Dublin` - \n* `Europe/Lisbon` - \n* `Europe/London` - \n* `Africa/Algiers` - \n* `Africa/Ceuta` - \n* `Africa/Lagos` - \n* `Africa/Ndjamena` - \n* `Africa/Tunis` - \n* `Africa/Windhoek` - \n* `Europe/Amsterdam` - \n* `Europe/Andorra` - \n* `Europe/Belgrade` - \n* `Europe/Berlin` - \n* `Europe/Brussels` - \n* `Europe/Budapest` - \n* `Europe/Copenhagen` - \n* `Europe/Gibraltar` - \n* `Europe/Luxembourg` - \n* `Europe/Madrid` - \n* `Europe/Malta` - \n* `Europe/Monaco` - \n* `Europe/Oslo` - \n* `Europe/Paris` - \n* `Europe/Prague` - \n* `Europe/Rome` - \n* `Europe/Stockholm` - \n* `Europe/Tirane` - \n* `Europe/Vienna` - \n* `Europe/Warsaw` - \n* `Europe/Zurich` - \n* `Africa/Cairo` - \n* `Africa/Johannesburg` - \n* `Africa/Maputo` - \n* `Africa/Tripoli` - \n* `Asia/Amman` - \n* `Asia/Beirut` - \n* `Asia/Damascus` - \n* `Asia/Gaza` - \n* `Asia/Jerusalem` - \n* `Asia/Nicosia` - \n* `Europe/Athens` - \n* `Europe/Bucharest` - \n* `Europe/Chisinau` - \n* `Europe/Helsinki` - \n* `Europe/Istanbul` - \n* `Europe/Kaliningrad` - \n* `Europe/Kiev` - \n* `Europe/Riga` - \n* `Europe/Sofia` - \n* `Europe/Tallinn` - \n* `Europe/Vilnius` - \n* `Africa/Khartoum` - \n* `Africa/Nairobi` - \n* `Antarctica/Syowa` - \n* `Asia/Baghdad` - \n* `Asia/Qatar` - \n* `Asia/Riyadh` - \n* `Europe/Minsk` - \n* `Europe/Moscow` - \n* `Asia/Tehran` - \n* `Asia/Baku` - \n* `Asia/Dubai` - \n* `Asia/Tbilisi` - \n* `Asia/Yerevan` - \n* `Europe/Samara` - \n* `Indian/Mahe` - \n* `Indian/Mauritius` - \n* `Indian/Reunion` - \n* `Asia/Kabul` - \n* `Antarctica/Mawson` - \n* `Asia/Aqtau` - \n* `Asia/Aqtobe` - \n* `Asia/Ashgabat` - \n* `Asia/Dushanbe` - \n* `Asia/Karachi` - \n* `Asia/Tashkent` - \n* `Asia/Yekaterinburg` - \n* `Indian/Kerguelen` - \n* `Indian/Maldives` - \n* `Asia/Calcutta` - \n* `Asia/Kolkata` - \n* `Asia/Colombo` - \n* `Asia/Kathmandu` - \n* `Asia/Katmandu` - \n* `Antarctica/Vostok` - \n* `Asia/Almaty` - \n* `Asia/Bishkek` - \n* `Asia/Dhaka` - \n* `Asia/Omsk` - \n* `Asia/Thimphu` - \n* `Indian/Chagos` - \n* `Asia/Rangoon` - \n* `Indian/Cocos` - \n* `Antarctica/Davis` - \n* `Asia/Bangkok` - \n* `Asia/Ho_Chi_Minh` - \n* `Asia/Hovd` - \n* `Asia/Jakarta` - \n* `Asia/Krasnoyarsk` - \n* `Asia/Saigon` - \n* `Indian/Christmas` - \n* `Antarctica/Casey` - \n* `Asia/Brunei` - \n* `Asia/Choibalsan` - \n* `Asia/Hong_Kong` - \n* `Asia/Irkutsk` - \n* `Asia/Kuala_Lumpur` - \n* `Asia/Macau` - \n* `Asia/Makassar` - \n* `Asia/Manila` - \n* `Asia/Shanghai` - \n* `Asia/Singapore` - \n* `Asia/Taipei` - \n* `Asia/Ulaanbaatar` - \n* `Australia/Perth` - \n* `Asia/Pyongyang` - \n* `Asia/Dili` - \n* `Asia/Jayapura` - \n* `Asia/Seoul` - \n* `Asia/Tokyo` - \n* `Asia/Yakutsk` - \n* `Asia/Yangon` - \n* `Pacific/Palau` - \n* `Australia/Adelaide` - \n* `Australia/Darwin` - \n* `Antarctica/DumontDUrville` - \n* `Asia/Magadan` - \n* `Asia/Vladivostok` - \n* `Australia/Brisbane` - \n* `Australia/Hobart` - \n* `Australia/Sydney` - \n* `Pacific/Chuuk` - \n* `Pacific/Guam` - \n* `Pacific/Port_Moresby` - \n* `Pacific/Efate` - \n* `Pacific/Guadalcanal` - \n* `Pacific/Kosrae` - \n* `Pacific/Norfolk` - \n* `Pacific/Noumea` - \n* `Pacific/Pohnpei` - \n* `Asia/Kamchatka` - \n* `Pacific/Auckland` - \n* `Pacific/Fiji` - \n* `Pacific/Funafuti` - \n* `Pacific/Kwajalein` - \n* `Pacific/Majuro` - \n* `Pacific/Nauru` - \n* `Pacific/Tarawa` - \n* `Pacific/Wake` - \n* `Pacific/Wallis` - \n* `Pacific/Apia` - \n* `Pacific/Enderbury` - \n* `Pacific/Fakaofo` - \n* `Pacific/Tongatapu` - \n* `Pacific/Kiritimati` - \n* `UTC` -"</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexSysConfigPolicy.TimezoneEnum Timezone
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New HyperflexUcsmConfigPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightHyperflexUcsmConfigPolicy")]
    public class NewIntersightHyperflexUcsmConfigPolicy : NewCmdletBase
    {
        public NewIntersightHyperflexUcsmConfigPolicy()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexUcsmConfigPolicy();
            MethodName = "CreateHyperflexUcsmConfigPolicyWithHttpInfo";
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
        /// <para type="description">"An array of relationships to hyperflexClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<HyperflexClusterProfileRelationship> ClusterProfiles
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The Out-of-band KVM IP range.\nConfigures the service profiles to use IP addresses within this range for setting the KVM IP of a server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexIpAddrRange KvmIpRange
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The MAC address prefix range for configuring vNICs.\nConfigures the service profiles to use MAC address prefixes within this range for setting the MAC address of server vNICs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexMacAddrPrefixRange MacPrefixRange
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
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
        /// <para type="description">"The server firmware bundle version used for server components such as CIMC, adapters, BIOS, etc."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("(^3\\.[1-9]\\([1-9][a-z]\\)$|^[4-9]\\.[0-9]\\([1-9][a-z]\\)$)")]
        public string ServerFirmwareVersion
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

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New HyperflexVcenterConfigPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightHyperflexVcenterConfigPolicy")]
    public class NewIntersightHyperflexVcenterConfigPolicy : NewCmdletBase
    {
        public NewIntersightHyperflexVcenterConfigPolicy()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexVcenterConfigPolicy();
            MethodName = "CreateHyperflexVcenterConfigPolicyWithHttpInfo";
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
        /// <para type="description">"An array of relationships to hyperflexClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<HyperflexClusterProfileRelationship> ClusterProfiles
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The vCenter datacenter name."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9~!@#$%&*()-_][a-zA-Z0-9~!@#$%&* ()-_]{0,79}$")]
        public string DataCenter
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The vCenter server FQDN or IP."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[A-Za-z]([A-Za-z0-9-]*[A-Za-z0-9])?$|^[A-Za-z0-9]([A-Za-z0-9-]*[A-Za-z0-9])?(\\.[A-Za-z0-9]([A-Za-z0-9-]*[A-Za-z0-9])?)*(\\.[A-Za-z]([A-Za-z0-9-]*[A-Za-z0-9])?)$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string Hostname
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
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
        /// <para type="description">"The password for authenticating with vCenter. Follow the corresponding password policy governed by vCenter."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Password
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"Overrides the default vCenter Single Sign-On URL. Do not specify unless instructed by Cisco TAC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SsoUrl
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
        /// <para type="description">"The vCenter username (e.g. administrator@vsphere.local)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^([a-zA-Z0-9._-]+)@([a-zA-Z0-9._-]+)$")]
        public string Username
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New HyperflexVmImportOperation.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightHyperflexVmImportOperation")]
    public class NewIntersightHyperflexVmImportOperation : NewCmdletBase
    {
        public NewIntersightHyperflexVmImportOperation()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexVmImportOperation();
            MethodName = "CreateHyperflexVmImportOperationWithHttpInfo";
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
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetDeviceRegistrationRelationship DeviceMoid
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

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New HyperflexVmRestoreOperation.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightHyperflexVmRestoreOperation")]
    public class NewIntersightHyperflexVmRestoreOperation : NewCmdletBase
    {
        public NewIntersightHyperflexVmRestoreOperation()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexVmRestoreOperation();
            MethodName = "CreateHyperflexVmRestoreOperationWithHttpInfo";
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
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"New name for the Virtual Machine after recovery."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string NewName
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
        /// <para type="description">"Power on the Virtual Machine after recovery."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool PowerOn
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a hyperflexCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexClusterRelationship RestoreEdgeClusterMoid
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Start time for the replication."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long StartTime
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
        /// <para type="description">"A reference to a hyperflexVmBackupInfo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexVmBackupInfoRelationship VmBackupInfoMoid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a hyperflexVmSnapshotInfo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexVmSnapshotInfoRelationship VmSnapshotInfoMoid
        {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexAppCatalog.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexAppCatalog")]
    public class RemoveIntersightHyperflexAppCatalog : RemoveCmdletBase
    {
        public RemoveIntersightHyperflexAppCatalog()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexAppCatalogWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexAutoSupportPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexAutoSupportPolicy")]
    public class RemoveIntersightHyperflexAutoSupportPolicy : RemoveCmdletBase
    {
        public RemoveIntersightHyperflexAutoSupportPolicy()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexAutoSupportPolicyWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexBackupCluster.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexBackupCluster")]
    public class RemoveIntersightHyperflexBackupCluster : RemoveCmdletBase
    {
        public RemoveIntersightHyperflexBackupCluster()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexBackupClusterWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexCapabilityInfo.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexCapabilityInfo")]
    public class RemoveIntersightHyperflexCapabilityInfo : RemoveCmdletBase
    {
        public RemoveIntersightHyperflexCapabilityInfo()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexCapabilityInfoWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexClusterBackupPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexClusterBackupPolicy")]
    public class RemoveIntersightHyperflexClusterBackupPolicy : RemoveCmdletBase
    {
        public RemoveIntersightHyperflexClusterBackupPolicy()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexClusterBackupPolicyWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexClusterBackupPolicyDeployment.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexClusterBackupPolicyDeployment")]
    public class RemoveIntersightHyperflexClusterBackupPolicyDeployment : RemoveCmdletBase
    {
        public RemoveIntersightHyperflexClusterBackupPolicyDeployment()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexClusterBackupPolicyDeploymentWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexClusterBackupPolicyInventory.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexClusterBackupPolicyInventory")]
    public class RemoveIntersightHyperflexClusterBackupPolicyInventory : RemoveCmdletBase
    {
        public RemoveIntersightHyperflexClusterBackupPolicyInventory()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexClusterBackupPolicyInventoryWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexClusterNetworkPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexClusterNetworkPolicy")]
    public class RemoveIntersightHyperflexClusterNetworkPolicy : RemoveCmdletBase
    {
        public RemoveIntersightHyperflexClusterNetworkPolicy()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexClusterNetworkPolicyWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexClusterProfile.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexClusterProfile")]
    public class RemoveIntersightHyperflexClusterProfile : RemoveCmdletBase
    {
        public RemoveIntersightHyperflexClusterProfile()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexClusterProfileWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexClusterReplicationNetworkPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexClusterReplicationNetworkPolicy")]
    public class RemoveIntersightHyperflexClusterReplicationNetworkPolicy : RemoveCmdletBase
    {
        public RemoveIntersightHyperflexClusterReplicationNetworkPolicy()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexClusterReplicationNetworkPolicyWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexClusterReplicationNetworkPolicyDeployment.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexClusterReplicationNetworkPolicyDeployment")]
    public class RemoveIntersightHyperflexClusterReplicationNetworkPolicyDeployment : RemoveCmdletBase
    {
        public RemoveIntersightHyperflexClusterReplicationNetworkPolicyDeployment()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexClusterReplicationNetworkPolicyDeploymentWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexClusterStoragePolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexClusterStoragePolicy")]
    public class RemoveIntersightHyperflexClusterStoragePolicy : RemoveCmdletBase
    {
        public RemoveIntersightHyperflexClusterStoragePolicy()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexClusterStoragePolicyWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexExtFcStoragePolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexExtFcStoragePolicy")]
    public class RemoveIntersightHyperflexExtFcStoragePolicy : RemoveCmdletBase
    {
        public RemoveIntersightHyperflexExtFcStoragePolicy()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexExtFcStoragePolicyWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexExtIscsiStoragePolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexExtIscsiStoragePolicy")]
    public class RemoveIntersightHyperflexExtIscsiStoragePolicy : RemoveCmdletBase
    {
        public RemoveIntersightHyperflexExtIscsiStoragePolicy()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexExtIscsiStoragePolicyWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexFeatureLimitExternal.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexFeatureLimitExternal")]
    public class RemoveIntersightHyperflexFeatureLimitExternal : RemoveCmdletBase
    {
        public RemoveIntersightHyperflexFeatureLimitExternal()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexFeatureLimitExternalWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexFeatureLimitInternal.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexFeatureLimitInternal")]
    public class RemoveIntersightHyperflexFeatureLimitInternal : RemoveCmdletBase
    {
        public RemoveIntersightHyperflexFeatureLimitInternal()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexFeatureLimitInternalWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexHealthCheckDefinition.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexHealthCheckDefinition")]
    public class RemoveIntersightHyperflexHealthCheckDefinition : RemoveCmdletBase
    {
        public RemoveIntersightHyperflexHealthCheckDefinition()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexHealthCheckDefinitionWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexHealthCheckPackageChecksum.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexHealthCheckPackageChecksum")]
    public class RemoveIntersightHyperflexHealthCheckPackageChecksum : RemoveCmdletBase
    {
        public RemoveIntersightHyperflexHealthCheckPackageChecksum()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexHealthCheckPackageChecksumWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexHxdpVersion.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexHxdpVersion")]
    public class RemoveIntersightHyperflexHxdpVersion : RemoveCmdletBase
    {
        public RemoveIntersightHyperflexHxdpVersion()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexHxdpVersionWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexKeyEncryptionKey.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexKeyEncryptionKey")]
    public class RemoveIntersightHyperflexKeyEncryptionKey : RemoveCmdletBase
    {
        public RemoveIntersightHyperflexKeyEncryptionKey()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexKeyEncryptionKeyWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexLocalCredentialPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexLocalCredentialPolicy")]
    public class RemoveIntersightHyperflexLocalCredentialPolicy : RemoveCmdletBase
    {
        public RemoveIntersightHyperflexLocalCredentialPolicy()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexLocalCredentialPolicyWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexNodeConfigPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexNodeConfigPolicy")]
    public class RemoveIntersightHyperflexNodeConfigPolicy : RemoveCmdletBase
    {
        public RemoveIntersightHyperflexNodeConfigPolicy()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexNodeConfigPolicyWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexNodeProfile.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexNodeProfile")]
    public class RemoveIntersightHyperflexNodeProfile : RemoveCmdletBase
    {
        public RemoveIntersightHyperflexNodeProfile()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexNodeProfileWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexProxySettingPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexProxySettingPolicy")]
    public class RemoveIntersightHyperflexProxySettingPolicy : RemoveCmdletBase
    {
        public RemoveIntersightHyperflexProxySettingPolicy()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexProxySettingPolicyWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexReduceReSync.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexReduceReSync")]
    public class RemoveIntersightHyperflexReduceReSync : RemoveCmdletBase
    {
        public RemoveIntersightHyperflexReduceReSync()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexReduceReSyncWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexServerFirmwareVersion.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexServerFirmwareVersion")]
    public class RemoveIntersightHyperflexServerFirmwareVersion : RemoveCmdletBase
    {
        public RemoveIntersightHyperflexServerFirmwareVersion()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexServerFirmwareVersionWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexServerFirmwareVersionEntry.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexServerFirmwareVersionEntry")]
    public class RemoveIntersightHyperflexServerFirmwareVersionEntry : RemoveCmdletBase
    {
        public RemoveIntersightHyperflexServerFirmwareVersionEntry()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexServerFirmwareVersionEntryWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexServerModel.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexServerModel")]
    public class RemoveIntersightHyperflexServerModel : RemoveCmdletBase
    {
        public RemoveIntersightHyperflexServerModel()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexServerModelWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexServiceAuthToken.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexServiceAuthToken")]
    public class RemoveIntersightHyperflexServiceAuthToken : RemoveCmdletBase
    {
        public RemoveIntersightHyperflexServiceAuthToken()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexServiceAuthTokenWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexSoftwareDistributionComponent.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexSoftwareDistributionComponent")]
    public class RemoveIntersightHyperflexSoftwareDistributionComponent : RemoveCmdletBase
    {
        public RemoveIntersightHyperflexSoftwareDistributionComponent()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexSoftwareDistributionComponentWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexSoftwareDistributionEntry.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexSoftwareDistributionEntry")]
    public class RemoveIntersightHyperflexSoftwareDistributionEntry : RemoveCmdletBase
    {
        public RemoveIntersightHyperflexSoftwareDistributionEntry()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexSoftwareDistributionEntryWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexSoftwareDistributionVersion.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexSoftwareDistributionVersion")]
    public class RemoveIntersightHyperflexSoftwareDistributionVersion : RemoveCmdletBase
    {
        public RemoveIntersightHyperflexSoftwareDistributionVersion()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexSoftwareDistributionVersionWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexSoftwareVersionPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexSoftwareVersionPolicy")]
    public class RemoveIntersightHyperflexSoftwareVersionPolicy : RemoveCmdletBase
    {
        public RemoveIntersightHyperflexSoftwareVersionPolicy()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexSoftwareVersionPolicyWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexSysConfigPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexSysConfigPolicy")]
    public class RemoveIntersightHyperflexSysConfigPolicy : RemoveCmdletBase
    {
        public RemoveIntersightHyperflexSysConfigPolicy()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexSysConfigPolicyWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexUcsmConfigPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexUcsmConfigPolicy")]
    public class RemoveIntersightHyperflexUcsmConfigPolicy : RemoveCmdletBase
    {
        public RemoveIntersightHyperflexUcsmConfigPolicy()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexUcsmConfigPolicyWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexVcenterConfigPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexVcenterConfigPolicy")]
    public class RemoveIntersightHyperflexVcenterConfigPolicy : RemoveCmdletBase
    {
        public RemoveIntersightHyperflexVcenterConfigPolicy()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexVcenterConfigPolicyWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexVmBackupInfo.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexVmBackupInfo")]
    public class RemoveIntersightHyperflexVmBackupInfo : RemoveCmdletBase
    {
        public RemoveIntersightHyperflexVmBackupInfo()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexVmBackupInfoWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexVmImportOperation.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexVmImportOperation")]
    public class RemoveIntersightHyperflexVmImportOperation : RemoveCmdletBase
    {
        public RemoveIntersightHyperflexVmImportOperation()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexVmImportOperationWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexVmRestoreOperation.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexVmRestoreOperation")]
    public class RemoveIntersightHyperflexVmRestoreOperation : RemoveCmdletBase
    {
        public RemoveIntersightHyperflexVmRestoreOperation()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexVmRestoreOperationWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexVmSnapshotInfo.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexVmSnapshotInfo")]
    public class RemoveIntersightHyperflexVmSnapshotInfo : RemoveCmdletBase
    {
        public RemoveIntersightHyperflexVmSnapshotInfo()
        {
            ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexVmSnapshotInfoWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set HyperflexAppCatalog.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexAppCatalog")]
    public class SetIntersightHyperflexAppCatalog : SetCmdletBase
    {
        public SetIntersightHyperflexAppCatalog()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexAppCatalog();
            MethodName = "UpdateHyperflexAppCatalogWithHttpInfo";
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
        /// <para type="description">"A reference to a hyperflexFeatureLimitExternal resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexFeatureLimitExternalRelationship FeatureLimitExternal
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a hyperflexFeatureLimitInternal resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexFeatureLimitInternalRelationship FeatureLimitInternal
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"An array of relationships to hyperflexHxdpVersion resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<HyperflexHxdpVersionRelationship> HxdpVersions
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"An array of relationships to hyperflexCapabilityInfo resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<HyperflexCapabilityInfoRelationship> HyperflexCapabilityInfos
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"An array of relationships to hclHyperflexSoftwareCompatibilityInfo resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<HclHyperflexSoftwareCompatibilityInfoRelationship> HyperflexSoftwareCompatibilityInfos
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
        /// <para type="description">"A reference to a hyperflexServerFirmwareVersion resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexServerFirmwareVersionRelationship ServerFirmwareVersion
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a hyperflexServerModel resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexServerModelRelationship ServerModel
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"An array of relationships to hyperflexSoftwareDistributionEntry resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<HyperflexSoftwareDistributionEntryRelationship> SoftwareDistributions
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
        /// <para type="description">"The catalog version used in HyperFlex cluster configuration service."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Version
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set HyperflexAutoSupportPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexAutoSupportPolicy")]
    public class SetIntersightHyperflexAutoSupportPolicy : SetCmdletBase
    {
        public SetIntersightHyperflexAutoSupportPolicy()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexAutoSupportPolicy();
            MethodName = "UpdateHyperflexAutoSupportPolicyWithHttpInfo";
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
        /// <para type="description">"Enable or disable Auto-Support."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool AdminState
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"An array of relationships to hyperflexClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<HyperflexClusterProfileRelationship> ClusterProfiles
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Description of the policy."</para>
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
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
        /// <para type="description">"The recipient email address for support tickets."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$")]
        public string ServiceTicketReceipient
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

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set HyperflexCapabilityInfo.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexCapabilityInfo")]
    public class SetIntersightHyperflexCapabilityInfo : SetCmdletBase
    {
        public SetIntersightHyperflexCapabilityInfo()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexCapabilityInfo();
            MethodName = "UpdateHyperflexCapabilityInfoWithHttpInfo";
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
        /// <para type="description">"A reference to a hyperflexAppCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexAppCatalogRelationship AppCatalog
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<HclConstraint> CapabilityConstraints
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
        /// <para type="description">"Name of the capability or feature set consisting of a collection of constraint rules and value."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
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


    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set HyperflexCluster.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexCluster")]
    public class SetIntersightHyperflexCluster : SetCmdletBase
    {
        public SetIntersightHyperflexCluster()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexCluster();
            MethodName = "UpdateHyperflexClusterWithHttpInfo";
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
        /// <para type="description">"A reference to a policyAbstractProfile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public PolicyAbstractProfileRelationship AssociatedProfile
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"An array of relationships to hyperflexBaseCluster resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<HyperflexBaseClusterRelationship> ChildClusters
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"This can be a Storage or Compute cluster. A storage cluster contains storage nodes that are used to persist data. A compute cluster contains compute nodes that are used for executing business logic.\n* `Storage` - Cluster of storage nodes used to persist data.\n* `Compute` - Cluster of compute nodes used to execute business logic.\n* `Unknown` - This cluster type is Unknown. Expect Compute or Storage as valid values."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexCluster.ClusterPurposeEnum ClusterPurpose
        {
            get;
            set;
        }












        // <summary>
        /// <para type="description">"This captures the encryption status for a HyperFlex cluster.\nCurrently it will have the status if HXA-CLU-0020 alarm is raised. In the future it can capture other details."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string EncryptionStatus
        {
            get;
            set;
        }





        // <summary>
        /// <para type="description">"Identifies the broad type of the underlying hypervisor.\n* `ESXi` - The hypervisor running on the HyperFlex cluster is a Vmware ESXi hypervisor of any version.\n* `Hyper-V` - The hypervisor running on the HyperFlex cluster is Microsoft Hyper-V.\n* `Unknown` - The hypervisor running on the HyperFlex cluster is not known."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexCluster.HypervisorTypeEnum HypervisorType
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
        /// <para type="description">"A reference to a computeBaseCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ComputeBaseClusterRelationship ParentCluster
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









    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set HyperflexClusterBackupPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexClusterBackupPolicy")]
    public class SetIntersightHyperflexClusterBackupPolicy : SetCmdletBase
    {
        public SetIntersightHyperflexClusterBackupPolicy()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexClusterBackupPolicy();
            MethodName = "UpdateHyperflexClusterBackupPolicyWithHttpInfo";
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
        /// <para type="description">"Backup datastore name prefix used during the auto creation of the datastore. All VMs created in this datastore will be automatically backed up."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string BackupDataStoreName
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Replication data store size in backupDataStoreSizeUnit."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long BackupDataStoreSize
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Replication data store size."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string BackupDataStoreSizeUnit
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a hyperflexCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexClusterRelationship BackupTarget
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"An array of relationships to hyperflexClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<HyperflexClusterProfileRelationship> ClusterProfiles
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Whether the datastore is encrypted or not."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool DataStoreEncryptionEnabled
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Number of snapshots that will be retained as part of the Multi Point in Time support."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 30)]
        public long LocalSnapshotRetentionCount
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
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
        /// <para type="description">"Replication cluster pairing name prefix."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ReplicationPairNamePrefix
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Backup policy replication schedule."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexReplicationSchedule ReplicationSchedule
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Number of snapshots that will be retained as part of the Multi Point in Time support."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 30)]
        public long SnapshotRetentionCount
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

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set HyperflexClusterBackupPolicyDeployment.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexClusterBackupPolicyDeployment")]
    public class SetIntersightHyperflexClusterBackupPolicyDeployment : SetCmdletBase
    {
        public SetIntersightHyperflexClusterBackupPolicyDeployment()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexClusterBackupPolicyDeployment();
            MethodName = "UpdateHyperflexClusterBackupPolicyDeploymentWithHttpInfo";
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
        /// <para type="description">"A reference to a hyperflexCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexClusterRelationship BackupTarget
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"True if record created by discovery on HyperFlex cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Discovered
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
        /// <para type="description">"A reference to a hyperflexCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexClusterRelationship SourceCluster
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"True if policy was detached from source Hyperflex Cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool SourceDetached
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
        /// <para type="description">"True if policy was detached from target Hyperflex Cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool TargetDetached
        {
            get;
            set;
        }



    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set HyperflexClusterNetworkPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexClusterNetworkPolicy")]
    public class SetIntersightHyperflexClusterNetworkPolicy : SetCmdletBase
    {
        public SetIntersightHyperflexClusterNetworkPolicy()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexClusterNetworkPolicy();
            MethodName = "UpdateHyperflexClusterNetworkPolicyWithHttpInfo";
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
        /// <para type="description">"An array of relationships to hyperflexClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<HyperflexClusterProfileRelationship> ClusterProfiles
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Enable or disable Jumbo Frames (MTU=9000). Jumbo Frames are used by Storage Network, VM Migration Network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool JumboFrame
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The Out-of-band KVM IP range.\nConfigures the service profiles to use IP addresses within this range for setting the KVM IP of a server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexIpAddrRange KvmIpRange
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The MAC address prefix range for configuring vNICs.\nConfigures the service profiles to use MAC address prefixes within this range for setting the MAC address of server vNICs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexMacAddrPrefixRange MacPrefixRange
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The VLAN for the management network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexNamedVlan MgmtVlan
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
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
        /// <para type="description">"Link speed of the server adapter port to the upstream switch. When the policy is attached to a cluster profile with EDGE management platform, the uplink speed can be '1G' or '10G+'. Use '10G+' for link speeds of 10G or above. When the policy is attached to a cluster profile with Fabric Interconnect management platform, the uplink speed can be 'default' only.\n* `default` - Current default value set on the hardware platform.\n* `1G` - A link speed of 1 gigabit per second.\n* `10G` - A link speed of 10 gigabits per second or above."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexClusterNetworkPolicy.UplinkSpeedEnum UplinkSpeed
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The VM migration VLAN.\nThis VLAN is used for transfering VMs from one host to another during operations such a cluster upgrade.\nFor HyperFlex Application Platform clusters, this VLAN is also used for hypervisor control traffic such as\nnode to node communication, pod-to-pod communication, etc."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexNamedVlan VmMigrationVlan
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<HyperflexNamedVlan> VmNetworkVlans
        {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set HyperflexClusterProfile.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexClusterProfile")]
    public class SetIntersightHyperflexClusterProfile : SetCmdletBase
    {
        public SetIntersightHyperflexClusterProfile()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexClusterProfile();
            MethodName = "UpdateHyperflexClusterProfileWithHttpInfo";
        }


        // <summary>
        /// <para type="description">"User initiated action. Each profile type has its own supported actions. For HyperFlex cluster profile, the supported actions are -- Validate, Deploy, Continue, Retry, Abort, Unassign For server profile, the support actions are -- Deploy, Unassign."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Action
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<PolicyActionParam> ActionParams
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
        /// <para type="description">"A reference to a hyperflexCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexClusterRelationship AssociatedCluster
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a hyperflexAutoSupportPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexAutoSupportPolicyRelationship AutoSupport
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A CIDR subnet for the cluster internal network. This applies to Intersight Workload Engine clusters only."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CommIpV4Interface ClusterInternalSubnet
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a hyperflexClusterNetworkPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexClusterNetworkPolicyRelationship ClusterNetwork
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a hyperflexClusterStoragePolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexClusterStoragePolicyRelationship ClusterStorage
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The configuration state and results of the last configuration operation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public PolicyConfigContext ConfigContext
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"The storage data IP address for the HyperFlex cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string DataIpAddress
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Description of the profile."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a hyperflexExtFcStoragePolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexExtFcStoragePolicyRelationship ExtFcStorage
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a hyperflexExtIscsiStoragePolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexExtIscsiStoragePolicyRelationship ExtIscsiStorage
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The node name prefix that is used to automatically generate the default hostname for each server.\nA dash (-) will be appended to the prefix followed by the node number to form a hostname.\nThis default naming scheme can be manually overridden in the node configuration.\nThe maximum length of a prefix is 60, must only contain alphanumeric characters or dash (-), and must\nstart with an alphanumeric character."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9][a-zA-Z0-9-]{1,59}$")]
        public string HostNamePrefix
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a commHttpProxyPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CommHttpProxyPolicyRelationship Httpproxypolicy
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The hypervisor control virtual IP address for the HyperFlex compute cluster that is used for node/pod management."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string HypervisorControlIpAddress
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The hypervisor type for the HyperFlex cluster.\n* `ESXi` - The hypervisor running on the HyperFlex cluster is a Vmware ESXi hypervisor of any version.\n* `Hyper-V` - The hypervisor running on the HyperFlex cluster is Microsoft Hyper-V.\n* `Unknown` - The hypervisor running on the HyperFlex cluster is not known."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexClusterProfile.HypervisorTypeEnum HypervisorType
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a hyperflexLocalCredentialPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexLocalCredentialPolicyRelationship LocalCredential
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The MAC address prefix in the form of 00:25:B5:XX."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^00:25:B5:[0-9a-fA-F]{2}$")]
        public string MacAddressPrefix
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The management IP address for the HyperFlex cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string MgmtIpAddress
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The management platform for the HyperFlex cluster.\n* `FI` - The host servers used in the cluster deployment are managed by a UCS Fabric Interconnect.\n* `EDGE` - The host servers used in the cluster deployment are standalone severs.\n* `DC-No-FI` - The host servers used in the cluster deployment are standalone servers with the DC Advantage license."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexClusterProfile.MgmtPlatformEnum MgmtPlatform
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
        /// <para type="description">"Name of the profile instance or profile template."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a hyperflexNodeConfigPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexNodeConfigPolicyRelationship NodeConfig
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"An array of relationships to hyperflexNodeProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<HyperflexNodeProfileRelationship> NodeProfileConfig
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
        /// <para type="description">"An array of relationships to policyAbstractPolicy resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<PolicyAbstractPolicyRelationship> PolicyBucket
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a hyperflexProxySettingPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexProxySettingPolicyRelationship ProxySetting
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The number of copies of each data block written."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Replication
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<PolicyScheduledAction> ScheduledActions
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a hyperflexSoftwareVersionPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexSoftwareVersionPolicyRelationship SoftwareVersion
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a policyAbstractProfile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public PolicyAbstractProfileRelationship SrcTemplate
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The storage data IP address for the HyperFlex cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string StorageClientIpAddress
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The netmask for the Storage client network IP address."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string StorageClientNetmask
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The named VLAN associated with this cluster's storage client network. This applies to Intersight Workload Engine clusters only."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexNamedVlan StorageClientVlan
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The auxiliary storage IP address for the HyperFlex cluster. For two node clusters, this is the IP address of the auxiliary ZK controller."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string StorageClusterAuxiliaryIp
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The VLAN for the HyperFlex storage data traffic."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexNamedVlan StorageDataVlan
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The storage type used for the HyperFlex cluster (HyperFlex Storage or 3rd party).\n* `HyperFlexDp` - The type of storage is HyperFlex Data Platform.\n* `ThirdParty` - The type of storage is 3rd Party Storage (PureStorage, etc..)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexClusterProfile.StorageTypeEnum StorageType
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a hyperflexSysConfigPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexSysConfigPolicyRelationship SysConfig
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
        /// <para type="description">"Defines the type of the profile. Accepted values are instance or template.\n* `instance` - The profile defines the configuration for a specific instance of a target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexClusterProfile.TypeEnum Type
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a hyperflexUcsmConfigPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexUcsmConfigPolicyRelationship UcsmConfig
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a hyperflexVcenterConfigPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexVcenterConfigPolicyRelationship VcenterConfig
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The WWxN prefix in the form of 20:00:00:25:B5:XX."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^20:00:00:25:B5:[0-9a-fA-F]{2}$")]
        public string WwxnPrefix
        {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set HyperflexClusterReplicationNetworkPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexClusterReplicationNetworkPolicy")]
    public class SetIntersightHyperflexClusterReplicationNetworkPolicy : SetCmdletBase
    {
        public SetIntersightHyperflexClusterReplicationNetworkPolicy()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexClusterReplicationNetworkPolicy();
            MethodName = "UpdateHyperflexClusterReplicationNetworkPolicyWithHttpInfo";
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
        /// <para type="description">"An array of relationships to hyperflexClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<HyperflexClusterProfileRelationship> ClusterProfiles
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Description of the policy."</para>
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
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
        /// <para type="description">"Bandwidth for the Replication network in Mbps."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long ReplicationBandwidthMbps
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<HyperflexIpAddrRange> ReplicationIpranges
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"MTU for the Replication network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1024, 1500)]
        public long ReplicationMtu
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"VLAN for the Replication network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexNamedVlan ReplicationVlan
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

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set HyperflexClusterReplicationNetworkPolicyDeployment.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexClusterReplicationNetworkPolicyDeployment")]
    public class SetIntersightHyperflexClusterReplicationNetworkPolicyDeployment : SetCmdletBase
    {
        public SetIntersightHyperflexClusterReplicationNetworkPolicyDeployment()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexClusterReplicationNetworkPolicyDeployment();
            MethodName = "UpdateHyperflexClusterReplicationNetworkPolicyDeploymentWithHttpInfo";
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
        /// <para type="description">"A reference to a hyperflexCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexClusterRelationship Cluster
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"True if record created by discovery on HyperFlex cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Discovered
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

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set HyperflexClusterStoragePolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexClusterStoragePolicy")]
    public class SetIntersightHyperflexClusterStoragePolicy : SetCmdletBase
    {
        public SetIntersightHyperflexClusterStoragePolicy()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexClusterStoragePolicy();
            MethodName = "UpdateHyperflexClusterStoragePolicyWithHttpInfo";
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
        /// <para type="description">"An array of relationships to hyperflexClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<HyperflexClusterProfileRelationship> ClusterProfiles
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"If enabled, formats existing disk partitions (destroys all user data)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool DiskPartitionCleanup
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Enable or disable Logical Availability Zones (LAZ). If enabled, HyperFlex Data Platform automatically selects and groups nodes into different availability zones. For HyperFlex Data Platform versions prior to 3.0 release, this setting does not apply. For HyperFlex Data Platform versions 3.0 or higher, this setting is only applicable to HyperFlex systems with 8 or more converged nodes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexLogicalAvailabilityZone LogicalAvalabilityZoneConfig
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
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
        /// <para type="description">"Enable or disable VDI optimization (hybrid HyperFlex systems only)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool VdiOptimization
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set HyperflexDrive.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexDrive")]
    public class SetIntersightHyperflexDrive : SetCmdletBase
    {
        public SetIntersightHyperflexDrive()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexDrive();
            MethodName = "UpdateHyperflexDriveWithHttpInfo";
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
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
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






    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set HyperflexExtFcStoragePolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexExtFcStoragePolicy")]
    public class SetIntersightHyperflexExtFcStoragePolicy : SetCmdletBase
    {
        public SetIntersightHyperflexExtFcStoragePolicy()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexExtFcStoragePolicy();
            MethodName = "UpdateHyperflexExtFcStoragePolicyWithHttpInfo";
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
        /// <para type="description">"Enables or disables external FC storage configuration."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool AdminState
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"An array of relationships to hyperflexClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<HyperflexClusterProfileRelationship> ClusterProfiles
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"VSAN for the primary Fabric Interconnect external FC storage traffic."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexNamedVsan ExtaTraffic
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"VSAN for the secondary Fabric Interconnect external FC storage traffic."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexNamedVsan ExtbTraffic
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
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
        /// <para type="description">"The range of WWxN addresses to use for the FC storage configuration."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexWwxnPrefixRange WwxnPrefixRange
        {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set HyperflexExtIscsiStoragePolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexExtIscsiStoragePolicy")]
    public class SetIntersightHyperflexExtIscsiStoragePolicy : SetCmdletBase
    {
        public SetIntersightHyperflexExtIscsiStoragePolicy()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexExtIscsiStoragePolicy();
            MethodName = "UpdateHyperflexExtIscsiStoragePolicyWithHttpInfo";
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
        /// <para type="description">"Enable or disable external iSCSI storage configuration."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool AdminState
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"An array of relationships to hyperflexClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<HyperflexClusterProfileRelationship> ClusterProfiles
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"VLAN for the primary Fabric Interconnect external iSCSI storage traffic."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexNamedVlan ExtaTraffic
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"VLAN for the secondary Fabric Interconnect external iSCSI storage traffic."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexNamedVlan ExtbTraffic
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
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

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set HyperflexFeatureLimitExternal.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexFeatureLimitExternal")]
    public class SetIntersightHyperflexFeatureLimitExternal : SetCmdletBase
    {
        public SetIntersightHyperflexFeatureLimitExternal()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexFeatureLimitExternal();
            MethodName = "UpdateHyperflexFeatureLimitExternalWithHttpInfo";
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
        /// <para type="description">"A reference to a hyperflexAppCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexAppCatalogRelationship AppCatalog
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<HyperflexFeatureLimitEntry> FeatureLimitEntries
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<MoTag> Tags
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set HyperflexFeatureLimitInternal.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexFeatureLimitInternal")]
    public class SetIntersightHyperflexFeatureLimitInternal : SetCmdletBase
    {
        public SetIntersightHyperflexFeatureLimitInternal()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexFeatureLimitInternal();
            MethodName = "UpdateHyperflexFeatureLimitInternalWithHttpInfo";
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
        /// <para type="description">"A reference to a hyperflexAppCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexAppCatalogRelationship AppCatalog
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<HyperflexFeatureLimitEntry> FeatureLimitEntries
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<MoTag> Tags
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set HyperflexHealthCheckDefinition.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexHealthCheckDefinition")]
    public class SetIntersightHyperflexHealthCheckDefinition : SetCmdletBase
    {
        public SetIntersightHyperflexHealthCheckDefinition()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexHealthCheckDefinition();
            MethodName = "UpdateHyperflexHealthCheckDefinitionWithHttpInfo";
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
        /// <para type="description">"Category that the health check belongs to."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Category
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Static information detailing the common causes for the health check failure."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string CommonCauses
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Execution configuration fo the health check script."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Configuration
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"Description of the health check definition."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"Static information detailing the health impact of the health check failure."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string HealthImpact
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Internal name of the health check definition."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string InternalName
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Minimum HyperFlex version that the check is supported on. Defaults to version 3.0.1."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string MinimumHyperFlexVersion
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
        /// <para type="description">"Name of the health check definition."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"Static information containing additional reference for the health check."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Reference
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Static information detailing the possible remediation actions that can be taken to remedy the health check failure."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Resolution
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Execution mode of the health script on the HyperFlex cluster.\n* `ON_DEMAND` - Execute the health check on-demand.\n* `SCHEDULED` - Execute the health check on a scheduled interval."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexHealthCheckDefinition.ScriptExecutionModeEnum ScriptExecutionMode
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Indicates if the script needs to be executed on HyperFlex compute nodes. |\nTypically, scripts are only executed on the storage Nodes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool ScriptExecutionOnComputeNodes
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
        /// <para type="description">"Indicates whether the health check is executed only on the leader node, or on all nodes in the HyperFlex cluster.\n* `EXECUTE_ON_LEADER_NODE` - Execute the health check script only on the HyperFlex cluster's leader node.\n* `EXECUTE_ON_ALL_NODES` - Execute health check on all nodes and aggregate the results.\n* `EXECUTE_ON_ALL_NODES_AND_AGGREGATE` - Execute the health check on all Nodes and perform custom aggregation.\n* `EXECUTE_ON_CURRENT_NODE` - The HyperFlex health check is executed on the node which receives the request."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexHealthCheckDefinition.TargetExecutionTypeEnum TargetExecutionType
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Health check script execution timeout."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Timeout
        {
            get;
            set;
        }


    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set HyperflexHealthCheckPackageChecksum.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexHealthCheckPackageChecksum")]
    public class SetIntersightHyperflexHealthCheckPackageChecksum : SetCmdletBase
    {
        public SetIntersightHyperflexHealthCheckPackageChecksum()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexHealthCheckPackageChecksum();
            MethodName = "UpdateHyperflexHealthCheckPackageChecksumWithHttpInfo";
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
        /// <para type="description">"SHA512 checksum of the health check package."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Checksum
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
        /// <para type="description">"Name of the health check Debian package."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"HyperFlex health check Debian package file name."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string PackageName
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
        /// <para type="description">"Timestamp of last update of HyperFlex health check package checksum."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime Timestamp
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"HyperFlex health check Debian Package Version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Version
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set HyperflexHxdpVersion.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexHxdpVersion")]
    public class SetIntersightHyperflexHxdpVersion : SetCmdletBase
    {
        public SetIntersightHyperflexHxdpVersion()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexHxdpVersion();
            MethodName = "UpdateHyperflexHxdpVersionWithHttpInfo";
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
        /// <para type="description">"A reference to a hyperflexAppCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexAppCatalogRelationship AppCatalog
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<MoTag> Tags
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The HyperFlex Data Platform version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Version
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set HyperflexHypervisorHost.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexHypervisorHost")]
    public class SetIntersightHyperflexHypervisorHost : SetCmdletBase
    {
        public SetIntersightHyperflexHypervisorHost()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexHypervisorHost();
            MethodName = "UpdateHyperflexHypervisorHostWithHttpInfo";
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
        /// <para type="description">"Details about the CPUs installed on this host are represented here."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationCpuInfo CpuInfo
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"The hardware details of this host. It includes capacity, manufacturer, and model information."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public InfraHardwareInfo HardwareInfo
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"Identifies the broad type of the underlying hypervisor.\n* `ESXi` - The hypervisor running on the HyperFlex cluster is a Vmware ESXi hypervisor of any version.\n* `Hyper-V` - The hypervisor running on the HyperFlex cluster is Microsoft Hyper-V.\n* `Unknown` - The hypervisor running on the HyperFlex cluster is not known."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexHypervisorHost.HypervisorTypeEnum HypervisorType
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The internally generated identity of this host. This entity is not manipulated by users. It aids in uniquely identifying the datacenter object. For VMware, this is an MOR (managed object reference)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Identity
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"Is this host in maintenance mode. Set to true or false."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool MaintenanceMode
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The memory capacity and usage information on this host."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationMemoryCapacity MemoryCapacity
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"Commercial model information about this hardware."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Model
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
        /// <para type="description">"Name of this host supplied by user. It is not the identity of the host. The name is subject to user manipulations."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }






        // <summary>
        /// <para type="description">"The capacity and usage information for CPU power on this host."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationComputeCapacity ProcessorCapacity
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Details of this product, such as vendor, model, etc. are represented here."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationProductInfo ProductInfo
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
        /// <para type="description">"Serial number of this host (internally generated)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Serial
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Host health status, as reported by the hypervisor platform.\n* `Unknown` - Entity status is unknown.\n* `Degraded` - State is degraded, and might impact normal operation of the entity.\n* `Critical` - Entity is in a critical state, impacting operations.\n* `Ok` - Entity status is in a stable state, operating normally."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexHypervisorHost.StatusEnum Status
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
        /// <para type="description">"The uptime of the host, stored as Duration (from w3c)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string UpTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Universally unique identity of this host (example b3d4483b-5560-9342-8309-b486c9236610). Internally generated."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12}$")]
        public string Uuid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Commercial vendor details of this hardware."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Vendor
        {
            get;
            set;
        }


    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set HyperflexHypervisorVirtualMachine.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexHypervisorVirtualMachine")]
    public class SetIntersightHyperflexHypervisorVirtualMachine : SetCmdletBase
    {
        public SetIntersightHyperflexHypervisorVirtualMachine()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexHypervisorVirtualMachine();
            MethodName = "UpdateHyperflexHypervisorVirtualMachineWithHttpInfo";
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
        /// <para type="description">"Time when this VM booted up."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime BootTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Provisioned CPU and memory information for this virtual machine."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public InfraHardwareInfo Capacity
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"Average CPU utilization percentage derived as a ratio of CPU used to CPU allocated. The value is calculated whenever inventory is performed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public float CpuUtilization
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"Guest operating system details running on this machine."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationGuestInfo GuestInfo
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"Type of hypervisor where the virtual machine is hosted for example ESXi.\n* `ESXi` - The hypervisor running on the HyperFlex cluster is a Vmware ESXi hypervisor of any version.\n* `Hyper-V` - The hypervisor running on the HyperFlex cluster is Microsoft Hyper-V.\n* `Unknown` - The hypervisor running on the HyperFlex cluster is not known."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexHypervisorVirtualMachine.HypervisorTypeEnum HypervisorType
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The internally generated identity of this VM. This entity is not manipulated by users. It aids in uniquely identifying the virtual machine object. For VMware, this is MOR (managed object reference)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Identity
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> IpAddress
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The capacity and usage information for memory on this virtual machine."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationMemoryCapacity MemoryCapacity
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Average memory utilization percentage derived as a ratio of memory used to available memory. The value is calculated whenever inventory is performed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public float MemoryUtilization
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
        /// <para type="description">"User-provided name to identify the virtual machine."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }






        // <summary>
        /// <para type="description">"Power state of the virtual machine.\n* `Unknown` - The entity's power state is unknown.\n* `PoweringOn` - The entity is powering on.\n* `PoweredOn` - The entity is powered on.\n* `PoweringOff` - The entity is powering off.\n* `PoweredOff` - The entity is powered down.\n* `StandBy` - The entity is in standby mode.\n* `Paused` - The entity is in pause state.\n* `Rebooting` - The entity reboot is in progress.\n* `` - The entity's power state is not available."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexHypervisorVirtualMachine.PowerStateEnum PowerState
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The capacity and usage information for CPU power on this virtual machine."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationComputeCapacity ProcessorCapacity
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Cloud platform, where the virtual machine is launched.\n* `Unknown` - Cloud provider is not known.\n* `VMwarevSphere` - Cloud provider named VMware vSphere.\n* `AmazonWebServices` - Cloud provider named Amazon Web Services.\n* `MicrosoftAzure` - Cloud provider named Microsoft Azure.\n* `GoogleCloudPlatform` - Cloud provider named Google Cloud Platform."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexHypervisorVirtualMachine.ProviderEnum Provider
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
        /// <para type="description">"The current state of the virtual machine. For example, starting, stopped, etc.\n* `None` - A place holder for the default value.\n* `Creating` - Virtual machine creation is in progress.\n* `Pending` - The virtual machine is preparing to enter the started state.\n* `Starting` - The virtual machine is starting.\n* `Started` - The virtual machine is running and ready for use.\n* `Stopping` - The virtual machine is preparing to be stopped.\n* `Stopped` - The virtual machine is shut down and cannot be used. The virtual machine can be started again at any time.\n* `Pausing` - The virtual machine is preparing to be paused.\n* `Paused` - The virtual machine enters into paused state due to low free disk space.\n* `Suspending` - The virtual machine is preparing to be suspended.\n* `Suspended` - Virtual machine is in sleep mode.When a virtual machine is suspended, the current state of theoperating system, and applications is saved, and the virtual machine put into a suspended mode.\n* `Deleting` - The virtual machine is preparing to be terminated.\n* `Terminated` - The virtual machine has been permanently deleted and cannot be started.\n* `Rebooting` - The virtual machine reboot is in progress.\n* `Error` - The deployment of virtual machine is failed.\n* `Warning` - The virtual machine is in warning state."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexHypervisorVirtualMachine.StateEnum State
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
        /// <para type="description">"The uuid of this virtual machine. The uuid is internally generated and not user specified."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12}$")]
        public string Uuid
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Time when this virtualmachine is created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime VmCreationTime
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set HyperflexInitiatorGroup.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexInitiatorGroup")]
    public class SetIntersightHyperflexInitiatorGroup : SetCmdletBase
    {
        public SetIntersightHyperflexInitiatorGroup()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexInitiatorGroup();
            MethodName = "UpdateHyperflexInitiatorGroupWithHttpInfo";
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
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
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





    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set HyperflexIscsiNetwork.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexIscsiNetwork")]
    public class SetIntersightHyperflexIscsiNetwork : SetCmdletBase
    {
        public SetIntersightHyperflexIscsiNetwork()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexIscsiNetwork();
            MethodName = "UpdateHyperflexIscsiNetworkWithHttpInfo";
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
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
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






    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set HyperflexKeyEncryptionKey.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexKeyEncryptionKey")]
    public class SetIntersightHyperflexKeyEncryptionKey : SetCmdletBase
    {
        public SetIntersightHyperflexKeyEncryptionKey()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexKeyEncryptionKey();
            MethodName = "UpdateHyperflexKeyEncryptionKeyWithHttpInfo";
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
        /// <para type="description">"A reference to a hyperflexClusterProfile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexClusterProfileRelationship ClusterProfile
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"This defines whether we need to operate in an account recovery scenario or not. If yes, then most of the parameters will be populated from an internal MO. So, some of the input parameters MAY be ignored, if this value is set to true."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool IsAccountRecovery
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"Number of iterations we want the hash to be run."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Iteration
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Key encryption key used to encrypt the DEK's on the HyperFlex cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Kek
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Resource id + time of creation used for retrieving the KEK."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string KeyId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Last known Key encryption key state for this Key.\n* `NEW` - Key Encryption key is newly created.\n* `ACTIVE` - Key Encryption key is deployed on active resource.\n* `INACTIVE` - Key Encryption key is inactive and not used.\n* `INPROGRESS` - Key Encryption key is in a state where it was used on Intersight but did not receive confirmation from platform of success/failure."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexKeyEncryptionKey.KeyStateEnum KeyState
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
        /// <para type="description">"Initial passphrase for the encryption policy, password must contain a minimum of 12 characters, with at least 1 lowercase, 1 uppercase, 1 numeric."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Passphrase
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public MoBaseMoRelationship ResourceMo
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Resource type on which this key will be applied.\n* `CLUSTER` - Encryption is per HyperFlex cluster.\n* `DATASTORE` - Encryption is per dataStore on the HyperFlex cluster.\n* `DRIVE` - Encryption is per drive on the HyperFlex cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexKeyEncryptionKey.ResourceTypeEnum ResourceType
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
        /// <para type="description">"Copy of Key encryption key, which is used for sending the key over to the remote device endpoint. It is not persisited anywhere."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string TransitKek
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set HyperflexLocalCredentialPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexLocalCredentialPolicy")]
    public class SetIntersightHyperflexLocalCredentialPolicy : SetCmdletBase
    {
        public SetIntersightHyperflexLocalCredentialPolicy()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexLocalCredentialPolicy();
            MethodName = "UpdateHyperflexLocalCredentialPolicyWithHttpInfo";
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
        /// <para type="description">"An array of relationships to hyperflexClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<HyperflexClusterProfileRelationship> ClusterProfiles
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Indicates if Hypervisor password is the factory set default password. For HyperFlex Data Platform versions 3.0 or higher, enable this if the default password was not changed on the Hypervisor. It is required to supply a new custom Hypervisor password that will be applied to the Hypervisor during deployment. For HyperFlex Data Platform versions prior to 3.0 release, this setting has no effect and the default password will be used for initial install. The Hypervisor password should be changed after deployment."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool FactoryHypervisorPassword
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"HyperFlex storage controller VM password must contain a minimum of 10 characters, with at least 1 lowercase, 1 uppercase, 1 numeric, and 1 of these -_@#$%^&*! special characters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9!@#$%^&*_-]{10,}$")]
        public string HxdpRootPwd
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Hypervisor administrator username must contain only alphanumeric characters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9]{1,}$")]
        public string HypervisorAdmin
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The Hypervisor root password. For HyperFlex Data Platform 3.0 or later, if the factory default password was not manually changed, you must set a new custom password. If the password was manually changed, you must not enable the factory default password property and provide the current hypervisor password. Note - All HyperFlex nodes require the same hypervisor password for installation. For HyperFlex Data Platform prior to 3.0, use the default password \"Cisco123\" for newly manufactured HyperFlex servers. A custom password should only be entered if hypervisor credentials were manually changed prior to deployment."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^.{7,40}$")]
        public string HypervisorAdminPwd
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
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

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set HyperflexLun.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexLun")]
    public class SetIntersightHyperflexLun : SetCmdletBase
    {
        public SetIntersightHyperflexLun()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexLun();
            MethodName = "UpdateHyperflexLunWithHttpInfo";
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
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
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








    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set HyperflexNodeConfigPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexNodeConfigPolicy")]
    public class SetIntersightHyperflexNodeConfigPolicy : SetCmdletBase
    {
        public SetIntersightHyperflexNodeConfigPolicy()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexNodeConfigPolicy();
            MethodName = "UpdateHyperflexNodeConfigPolicyWithHttpInfo";
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
        /// <para type="description">"An array of relationships to hyperflexClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<HyperflexClusterProfileRelationship> ClusterProfiles
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The range of storage data IPs to be assigned to the nodes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexIpAddrRange DataIpRange
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The range of storage management IPs to be assigned to the nodes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexIpAddrRange HxdpIpRange
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The range of IPs to be assigned to each hypervisor node for VM migration and hypervior control."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexIpAddrRange HypervisorControlIpRange
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The range of management IPs to be assigned to the nodes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexIpAddrRange MgmtIpRange
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The node name prefix that is used to automatically generate the default hostname for each server.\nA dash (-) will be appended to the prefix followed by the node number to form a hostname.\nThis default naming scheme can be manually overridden in the node configuration.\nThe maximum length of a prefix is 60, must only contain alphanumeric characters or dash (-), and must\nstart with an alphanumeric character."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9][a-zA-Z0-9-]{1,59}$")]
        public string NodeNamePrefix
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

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set HyperflexNodeProfile.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexNodeProfile")]
    public class SetIntersightHyperflexNodeProfile : SetCmdletBase
    {
        public SetIntersightHyperflexNodeProfile()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexNodeProfile();
            MethodName = "UpdateHyperflexNodeProfileWithHttpInfo";
        }


        // <summary>
        /// <para type="description">"User initiated action. Each profile type has its own supported actions. For HyperFlex cluster profile, the supported actions are -- Validate, Deploy, Continue, Retry, Abort, Unassign For server profile, the support actions are -- Deploy, Unassign."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Action
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<PolicyActionParam> ActionParams
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
        /// <para type="description">"A reference to a computePhysical resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ComputePhysicalRelationship AssignedServer
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a hyperflexClusterProfile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexClusterProfileRelationship ClusterProfile
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The configuration state and results of the last configuration operation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public PolicyConfigContext ConfigContext
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Description of the profile."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"IP address for storage data network (Controller VM interface)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string HxdpDataIp
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"IP address for HyperFlex management network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string HxdpMgmtIp
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"IP address for storage client network (Controller VM interface)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string HxdpStorageClientIp
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"IP address for hypervisor control such as VM migration or pod management."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string HypervisorControlIp
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"IP address for storage data network (Hypervisor interface)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string HypervisorDataIp
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"IP address for Hypervisor management network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string HypervisorMgmtIp
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
        /// <para type="description">"Name of the profile instance or profile template."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The role that this node performs in the HyperFlex cluster.\n* `Unknown` - The node role is not available.\n* `Storage` - The node persists data and contributes to the storage capacity of a cluster.\n* `Compute` - The node contributes to the compute capacity of a cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexNodeProfile.NodeRoleEnum NodeRole
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"An array of relationships to policyAbstractPolicy resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<PolicyAbstractPolicyRelationship> PolicyBucket
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<PolicyScheduledAction> ScheduledActions
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a policyAbstractProfile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public PolicyAbstractProfileRelationship SrcTemplate
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
        /// <para type="description">"Defines the type of the profile. Accepted values are instance or template.\n* `instance` - The profile defines the configuration for a specific instance of a target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexNodeProfile.TypeEnum Type
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set HyperflexProxySettingPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexProxySettingPolicy")]
    public class SetIntersightHyperflexProxySettingPolicy : SetCmdletBase
    {
        public SetIntersightHyperflexProxySettingPolicy()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexProxySettingPolicy();
            MethodName = "UpdateHyperflexProxySettingPolicyWithHttpInfo";
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
        /// <para type="description">"An array of relationships to hyperflexClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<HyperflexClusterProfileRelationship> ClusterProfiles
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"HTTP Proxy server FQDN or IP."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[A-Za-z]([A-Za-z0-9-]*[A-Za-z0-9])?$|^[A-Za-z0-9]([A-Za-z0-9-]*[A-Za-z0-9])?(\\.[A-Za-z0-9]([A-Za-z0-9-]*[A-Za-z0-9])?)*(\\.[A-Za-z]([A-Za-z0-9-]*[A-Za-z0-9])?)$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string Hostname
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
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
        /// <para type="description">"The password for the HTTP Proxy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Password
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The HTTP Proxy port number.\nThe port number of the HTTP proxy must be between 1 and 65535, inclusive."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 65535)]
        public long Port
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
        /// <para type="description">"The username for the HTTP Proxy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Username
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set HyperflexReduceReSync.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexReduceReSync")]
    public class SetIntersightHyperflexReduceReSync : SetCmdletBase
    {
        public SetIntersightHyperflexReduceReSync()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexReduceReSync();
            MethodName = "UpdateHyperflexReduceReSyncWithHttpInfo";
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
        /// <para type="description">"The HyperFlex reduce re-sync script execution completion status."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool CompletionStatus
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<MoTag> Tags
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set HyperflexServerFirmwareVersion.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexServerFirmwareVersion")]
    public class SetIntersightHyperflexServerFirmwareVersion : SetCmdletBase
    {
        public SetIntersightHyperflexServerFirmwareVersion()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexServerFirmwareVersion();
            MethodName = "UpdateHyperflexServerFirmwareVersionWithHttpInfo";
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
        /// <para type="description">"A reference to a hyperflexAppCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexAppCatalogRelationship AppCatalog
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
        /// <para type="description">"An array of relationships to hyperflexServerFirmwareVersionEntry resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<HyperflexServerFirmwareVersionEntryRelationship> ServerFirmwareVersionEntries
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

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set HyperflexServerFirmwareVersionEntry.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexServerFirmwareVersionEntry")]
    public class SetIntersightHyperflexServerFirmwareVersionEntry : SetCmdletBase
    {
        public SetIntersightHyperflexServerFirmwareVersionEntry()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexServerFirmwareVersionEntry();
            MethodName = "UpdateHyperflexServerFirmwareVersionEntryWithHttpInfo";
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
        /// <para type="description">"The conditions that must be satisfied before applying the AppSetting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexAppSettingConstraint Constraint
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
        /// <para type="description">"A reference to a hyperflexServerFirmwareVersion resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexServerFirmwareVersionRelationship ServerFirmwareVersion
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The server platform type that is applicable for the server firmware bundle version.\n* `M5` - M5 generation of UCS server.\n* `M3` - M3 generation of UCS server.\n* `M4` - M4 generation of UCS server.\n* `M6` - M6 generation of UCS server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexServerFirmwareVersionEntry.ServerPlatformEnum ServerPlatform
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
        /// <para type="description">"The server firmware bundle version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("(^3\\.[1-9]\\([1-9][a-z]\\)$|^[4-9]\\.[0-9]\\([1-9][a-z]\\)$)")]
        public string Version
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set HyperflexServerModel.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexServerModel")]
    public class SetIntersightHyperflexServerModel : SetCmdletBase
    {
        public SetIntersightHyperflexServerModel()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexServerModel();
            MethodName = "UpdateHyperflexServerModelWithHttpInfo";
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
        /// <para type="description">"A reference to a hyperflexAppCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexAppCatalogRelationship AppCatalog
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<HyperflexServerModelEntry> ServerModelEntries
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

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set HyperflexServiceAuthToken.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexServiceAuthToken")]
    public class SetIntersightHyperflexServiceAuthToken : SetCmdletBase
    {
        public SetIntersightHyperflexServiceAuthToken()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexServiceAuthToken();
            MethodName = "UpdateHyperflexServiceAuthTokenWithHttpInfo";
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
        /// <para type="description">"Client Id or tenant Id of the entity that uses the service auth token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ClientId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a hyperflexCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexClusterRelationship Cluster
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Version of Container Storage Interface (CSI) that the tokenOwner is associated with."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string CsiVersion
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
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public MoBaseMoRelationship TokenOwner
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set HyperflexSoftwareDistributionComponent.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexSoftwareDistributionComponent")]
    public class SetIntersightHyperflexSoftwareDistributionComponent : SetCmdletBase
    {
        public SetIntersightHyperflexSoftwareDistributionComponent()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexSoftwareDistributionComponent();
            MethodName = "UpdateHyperflexSoftwareDistributionComponentWithHttpInfo";
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
        /// <para type="description">"The bucket name where the files are present, if source is external cloud store."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string BucketName
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The HyperFlex Software Distribution Component Identifier."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ComponentId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The HyperFlex Software Distribution Component Name."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ComponentName
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"File location on the cloud storage."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string FilePath
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> FilesToDownload
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
        /// <para type="description">"A reference to a hyperflexSoftwareDistributionVersion resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexSoftwareDistributionVersionRelationship SoftwareDistributionVersion
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
        /// <para type="description">"The HyperFlex Software Distribution Component Version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Version
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set HyperflexSoftwareDistributionEntry.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexSoftwareDistributionEntry")]
    public class SetIntersightHyperflexSoftwareDistributionEntry : SetCmdletBase
    {
        public SetIntersightHyperflexSoftwareDistributionEntry()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexSoftwareDistributionEntry();
            MethodName = "UpdateHyperflexSoftwareDistributionEntryWithHttpInfo";
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
        /// <para type="description">"A reference to a hyperflexAppCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexAppCatalogRelationship AppCatalog
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The HyperFlex Software Distribution type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string DistributionType
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"An array of relationships to hyperflexSoftwareDistributionVersion resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<HyperflexSoftwareDistributionVersionRelationship> DistributionVersions
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<MoTag> Tags
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set HyperflexSoftwareDistributionVersion.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexSoftwareDistributionVersion")]
    public class SetIntersightHyperflexSoftwareDistributionVersion : SetCmdletBase
    {
        public SetIntersightHyperflexSoftwareDistributionVersion()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexSoftwareDistributionVersion();
            MethodName = "UpdateHyperflexSoftwareDistributionVersionWithHttpInfo";
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
        /// <para type="description">"An array of relationships to hyperflexSoftwareDistributionComponent resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<HyperflexSoftwareDistributionComponentRelationship> DistributionComponents
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
        /// <para type="description">"A reference to a hyperflexSoftwareDistributionEntry resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexSoftwareDistributionEntryRelationship SoftwareDistributionEntry
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
        /// <para type="description">"The HyperFlex Software Distribution version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Version
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set HyperflexSoftwareVersionPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexSoftwareVersionPolicy")]
    public class SetIntersightHyperflexSoftwareVersionPolicy : SetCmdletBase
    {
        public SetIntersightHyperflexSoftwareVersionPolicy()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexSoftwareVersionPolicy();
            MethodName = "UpdateHyperflexSoftwareVersionPolicyWithHttpInfo";
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
        /// <para type="description">"An array of relationships to hyperflexClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<HyperflexClusterProfileRelationship> ClusterProfiles
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Desired HyperFlex Data Platform software version to apply on the HyperFlex cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string HxdpVersion
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Desired  hypervisor version to apply for all the nodes on the HyperFlex cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string HypervisorVersion
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
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
        /// <para type="description">"Desired server firmware version to apply on the HyperFlex Cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|(^3\\.[0-9]\\([1-9][a-z]\\)$|^[4-9]\\.[1-9]\\([1-9][a-z]\\)$|^4\\.0\\([1-3][a-z]\\)$|^4\\.0\\(4[d-z]\\)$|4\\.0\\([5-9][a-z]\\)$|^[4-9]\\.[0-9]\\([0-9](\\.[0-9]+|[a-z]).*\\)$)")]
        public string ServerFirmwareVersion
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<HyperflexServerFirmwareVersionInfo> ServerFirmwareVersions
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<HyperflexSoftwareVersionPolicy.UpgradeTypesEnum> UpgradeTypes
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set HyperflexStorageContainer.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexStorageContainer")]
    public class SetIntersightHyperflexStorageContainer : SetCmdletBase
    {
        public SetIntersightHyperflexStorageContainer()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexStorageContainer();
            MethodName = "UpdateHyperflexStorageContainerWithHttpInfo";
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
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
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






    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set HyperflexSysConfigPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexSysConfigPolicy")]
    public class SetIntersightHyperflexSysConfigPolicy : SetCmdletBase
    {
        public SetIntersightHyperflexSysConfigPolicy()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexSysConfigPolicy();
            MethodName = "UpdateHyperflexSysConfigPolicyWithHttpInfo";
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
        /// <para type="description">"An array of relationships to hyperflexClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<HyperflexClusterProfileRelationship> ClusterProfiles
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The DNS Search Domain Name. This setting applies to HyperFlex Data Platform 3.0 or later only."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^([a-zA-Z0-9]([a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?\\.)*[a-zA-Z]{2,63}$")]
        public string DnsDomainName
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> DnsServers
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> NtpServers
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
        /// <para type="description">"The timezone of the HyperFlex cluster's system clock.\n* `Pacific/Niue` - \n* `Pacific/Pago_Pago` - \n* `Pacific/Honolulu` - \n* `Pacific/Rarotonga` - \n* `Pacific/Tahiti` - \n* `Pacific/Marquesas` - \n* `America/Anchorage` - \n* `Pacific/Gambier` - \n* `America/Los_Angeles` - \n* `America/Tijuana` - \n* `America/Vancouver` - \n* `America/Whitehorse` - \n* `Pacific/Pitcairn` - \n* `America/Dawson_Creek` - \n* `America/Denver` - \n* `America/Edmonton` - \n* `America/Hermosillo` - \n* `America/Mazatlan` - \n* `America/Phoenix` - \n* `America/Yellowknife` - \n* `America/Belize` - \n* `America/Chicago` - \n* `America/Costa_Rica` - \n* `America/El_Salvador` - \n* `America/Guatemala` - \n* `America/Managua` - \n* `America/Mexico_City` - \n* `America/Regina` - \n* `America/Tegucigalpa` - \n* `America/Winnipeg` - \n* `Pacific/Galapagos` - \n* `America/Bogota` - \n* `America/Cancun` - \n* `America/Cayman` - \n* `America/Guayaquil` - \n* `America/Havana` - \n* `America/Iqaluit` - \n* `America/Jamaica` - \n* `America/Lima` - \n* `America/Nassau` - \n* `America/New_York` - \n* `America/Nuuk` - \n* `America/Panama` - \n* `America/Port-au-Prince` - \n* `America/Rio_Branco` - \n* `America/Toronto` - \n* `Pacific/Easter` - \n* `America/Caracas` - \n* `America/Asuncion` - \n* `America/Barbados` - \n* `America/Boa_Vista` - \n* `America/Campo_Grande` - \n* `America/Cuiaba` - \n* `America/Curacao` - \n* `America/Grand_Turk` - \n* `America/Guyana` - \n* `America/Halifax` - \n* `America/La_Paz` - \n* `America/Manaus` - \n* `America/Martinique` - \n* `America/Port_of_Spain` - \n* `America/Porto_Velho` - \n* `America/Puerto_Rico` - \n* `America/Santo_Domingo` - \n* `America/Thule` - \n* `Atlantic/Bermuda` - \n* `America/St_Johns` - \n* `America/Araguaina` - \n* `America/Argentina/Buenos_Aires` - \n* `America/Bahia` - \n* `America/Belem` - \n* `America/Cayenne` - \n* `America/Fortaleza` - \n* `America/Godthab` - \n* `America/Maceio` - \n* `America/Miquelon` - \n* `America/Montevideo` - \n* `America/Paramaribo` - \n* `America/Recife` - \n* `America/Santiago` - \n* `America/Sao_Paulo` - \n* `Antarctica/Palmer` - \n* `Antarctica/Rothera` - \n* `Atlantic/Stanley` - \n* `America/Noronha` - \n* `Atlantic/South_Georgia` - \n* `America/Scoresbysund` - \n* `Atlantic/Azores` - \n* `Atlantic/Cape_Verde` - \n* `Africa/Abidjan` - \n* `Africa/Accra` - \n* `Africa/Bissau` - \n* `Africa/Casablanca` - \n* `Africa/El_Aaiun` - \n* `Africa/Monrovia` - \n* `America/Danmarkshavn` - \n* `Atlantic/Canary` - \n* `Atlantic/Faroe` - \n* `Atlantic/Reykjavik` - \n* `Etc/GMT` - \n* `Europe/Dublin` - \n* `Europe/Lisbon` - \n* `Europe/London` - \n* `Africa/Algiers` - \n* `Africa/Ceuta` - \n* `Africa/Lagos` - \n* `Africa/Ndjamena` - \n* `Africa/Tunis` - \n* `Africa/Windhoek` - \n* `Europe/Amsterdam` - \n* `Europe/Andorra` - \n* `Europe/Belgrade` - \n* `Europe/Berlin` - \n* `Europe/Brussels` - \n* `Europe/Budapest` - \n* `Europe/Copenhagen` - \n* `Europe/Gibraltar` - \n* `Europe/Luxembourg` - \n* `Europe/Madrid` - \n* `Europe/Malta` - \n* `Europe/Monaco` - \n* `Europe/Oslo` - \n* `Europe/Paris` - \n* `Europe/Prague` - \n* `Europe/Rome` - \n* `Europe/Stockholm` - \n* `Europe/Tirane` - \n* `Europe/Vienna` - \n* `Europe/Warsaw` - \n* `Europe/Zurich` - \n* `Africa/Cairo` - \n* `Africa/Johannesburg` - \n* `Africa/Maputo` - \n* `Africa/Tripoli` - \n* `Asia/Amman` - \n* `Asia/Beirut` - \n* `Asia/Damascus` - \n* `Asia/Gaza` - \n* `Asia/Jerusalem` - \n* `Asia/Nicosia` - \n* `Europe/Athens` - \n* `Europe/Bucharest` - \n* `Europe/Chisinau` - \n* `Europe/Helsinki` - \n* `Europe/Istanbul` - \n* `Europe/Kaliningrad` - \n* `Europe/Kiev` - \n* `Europe/Riga` - \n* `Europe/Sofia` - \n* `Europe/Tallinn` - \n* `Europe/Vilnius` - \n* `Africa/Khartoum` - \n* `Africa/Nairobi` - \n* `Antarctica/Syowa` - \n* `Asia/Baghdad` - \n* `Asia/Qatar` - \n* `Asia/Riyadh` - \n* `Europe/Minsk` - \n* `Europe/Moscow` - \n* `Asia/Tehran` - \n* `Asia/Baku` - \n* `Asia/Dubai` - \n* `Asia/Tbilisi` - \n* `Asia/Yerevan` - \n* `Europe/Samara` - \n* `Indian/Mahe` - \n* `Indian/Mauritius` - \n* `Indian/Reunion` - \n* `Asia/Kabul` - \n* `Antarctica/Mawson` - \n* `Asia/Aqtau` - \n* `Asia/Aqtobe` - \n* `Asia/Ashgabat` - \n* `Asia/Dushanbe` - \n* `Asia/Karachi` - \n* `Asia/Tashkent` - \n* `Asia/Yekaterinburg` - \n* `Indian/Kerguelen` - \n* `Indian/Maldives` - \n* `Asia/Calcutta` - \n* `Asia/Kolkata` - \n* `Asia/Colombo` - \n* `Asia/Kathmandu` - \n* `Asia/Katmandu` - \n* `Antarctica/Vostok` - \n* `Asia/Almaty` - \n* `Asia/Bishkek` - \n* `Asia/Dhaka` - \n* `Asia/Omsk` - \n* `Asia/Thimphu` - \n* `Indian/Chagos` - \n* `Asia/Rangoon` - \n* `Indian/Cocos` - \n* `Antarctica/Davis` - \n* `Asia/Bangkok` - \n* `Asia/Ho_Chi_Minh` - \n* `Asia/Hovd` - \n* `Asia/Jakarta` - \n* `Asia/Krasnoyarsk` - \n* `Asia/Saigon` - \n* `Indian/Christmas` - \n* `Antarctica/Casey` - \n* `Asia/Brunei` - \n* `Asia/Choibalsan` - \n* `Asia/Hong_Kong` - \n* `Asia/Irkutsk` - \n* `Asia/Kuala_Lumpur` - \n* `Asia/Macau` - \n* `Asia/Makassar` - \n* `Asia/Manila` - \n* `Asia/Shanghai` - \n* `Asia/Singapore` - \n* `Asia/Taipei` - \n* `Asia/Ulaanbaatar` - \n* `Australia/Perth` - \n* `Asia/Pyongyang` - \n* `Asia/Dili` - \n* `Asia/Jayapura` - \n* `Asia/Seoul` - \n* `Asia/Tokyo` - \n* `Asia/Yakutsk` - \n* `Asia/Yangon` - \n* `Pacific/Palau` - \n* `Australia/Adelaide` - \n* `Australia/Darwin` - \n* `Antarctica/DumontDUrville` - \n* `Asia/Magadan` - \n* `Asia/Vladivostok` - \n* `Australia/Brisbane` - \n* `Australia/Hobart` - \n* `Australia/Sydney` - \n* `Pacific/Chuuk` - \n* `Pacific/Guam` - \n* `Pacific/Port_Moresby` - \n* `Pacific/Efate` - \n* `Pacific/Guadalcanal` - \n* `Pacific/Kosrae` - \n* `Pacific/Norfolk` - \n* `Pacific/Noumea` - \n* `Pacific/Pohnpei` - \n* `Asia/Kamchatka` - \n* `Pacific/Auckland` - \n* `Pacific/Fiji` - \n* `Pacific/Funafuti` - \n* `Pacific/Kwajalein` - \n* `Pacific/Majuro` - \n* `Pacific/Nauru` - \n* `Pacific/Tarawa` - \n* `Pacific/Wake` - \n* `Pacific/Wallis` - \n* `Pacific/Apia` - \n* `Pacific/Enderbury` - \n* `Pacific/Fakaofo` - \n* `Pacific/Tongatapu` - \n* `Pacific/Kiritimati` - \n* `UTC` -"</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexSysConfigPolicy.TimezoneEnum Timezone
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set HyperflexTarget.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexTarget")]
    public class SetIntersightHyperflexTarget : SetCmdletBase
    {
        public SetIntersightHyperflexTarget()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexTarget();
            MethodName = "UpdateHyperflexTargetWithHttpInfo";
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
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
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



    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set HyperflexUcsmConfigPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexUcsmConfigPolicy")]
    public class SetIntersightHyperflexUcsmConfigPolicy : SetCmdletBase
    {
        public SetIntersightHyperflexUcsmConfigPolicy()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexUcsmConfigPolicy();
            MethodName = "UpdateHyperflexUcsmConfigPolicyWithHttpInfo";
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
        /// <para type="description">"An array of relationships to hyperflexClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<HyperflexClusterProfileRelationship> ClusterProfiles
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The Out-of-band KVM IP range.\nConfigures the service profiles to use IP addresses within this range for setting the KVM IP of a server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexIpAddrRange KvmIpRange
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The MAC address prefix range for configuring vNICs.\nConfigures the service profiles to use MAC address prefixes within this range for setting the MAC address of server vNICs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public HyperflexMacAddrPrefixRange MacPrefixRange
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
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
        /// <para type="description">"The server firmware bundle version used for server components such as CIMC, adapters, BIOS, etc."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("(^3\\.[1-9]\\([1-9][a-z]\\)$|^[4-9]\\.[0-9]\\([1-9][a-z]\\)$)")]
        public string ServerFirmwareVersion
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

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set HyperflexVcenterConfigPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexVcenterConfigPolicy")]
    public class SetIntersightHyperflexVcenterConfigPolicy : SetCmdletBase
    {
        public SetIntersightHyperflexVcenterConfigPolicy()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexVcenterConfigPolicy();
            MethodName = "UpdateHyperflexVcenterConfigPolicyWithHttpInfo";
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
        /// <para type="description">"An array of relationships to hyperflexClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<HyperflexClusterProfileRelationship> ClusterProfiles
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The vCenter datacenter name."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9~!@#$%&*()-_][a-zA-Z0-9~!@#$%&* ()-_]{0,79}$")]
        public string DataCenter
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The vCenter server FQDN or IP."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[A-Za-z]([A-Za-z0-9-]*[A-Za-z0-9])?$|^[A-Za-z0-9]([A-Za-z0-9-]*[A-Za-z0-9])?(\\.[A-Za-z0-9]([A-Za-z0-9-]*[A-Za-z0-9])?)*(\\.[A-Za-z]([A-Za-z0-9-]*[A-Za-z0-9])?)$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string Hostname
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
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
        /// <para type="description">"The password for authenticating with vCenter. Follow the corresponding password policy governed by vCenter."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Password
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"Overrides the default vCenter Single Sign-On URL. Do not specify unless instructed by Cisco TAC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SsoUrl
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
        /// <para type="description">"The vCenter username (e.g. administrator@vsphere.local)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^([a-zA-Z0-9._-]+)@([a-zA-Z0-9._-]+)$")]
        public string Username
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set HyperflexVolume.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexVolume")]
    public class SetIntersightHyperflexVolume : SetCmdletBase
    {
        public SetIntersightHyperflexVolume()
        {
            ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexVolume();
            MethodName = "UpdateHyperflexVolumeWithHttpInfo";
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
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
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






    }
}