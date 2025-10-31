using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get AuditdPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightAuditdPolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightAuditdPolicy : GetCmdletBase
    {
        public GetIntersightAuditdPolicy()
        {
            ApiInstance = new AuditdApi(Config);
            MethodName = "GetAuditdPolicyListWithHttpInfo";
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
        /// <para type="description">"Admin state for the AuditD feature.\n* `Disabled` - Admin configured Disabled State.\n* `Enabled` - Admin configured Enabled State."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public AuditdPolicy.AdminStateEnum AdminState
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The log level for the AuditD feature. The default value is \"notifications\".\n* `notifications` - Generated logs are of Notification level, providing information about normal but significant system events requiring awareness.\n* `emergencies` - Generated logs will be of Emergency log level, indicating a critical and unstable system state.\n* `alerts` - Generated logs are of Alert level, indicating critical issues needing immediate attention to prevent system disruption.\n* `critical` - Generated logs are of Critical level, signaling severe issues that may cause system failure if not addressed immediately.\n* `errors` - Generated logs are of Error level, indicating significant problems that affect functionality but do not cause system failure.\n* `warnings` - Generated logs are of Warning level, highlighting potential issues that require attention but do not yet impact functionality.\n* `information` - Generated logs are of Information level, detailing routine operational messages without indicating any issues or errors.\n* `debugging` - Generated logs are of Debugging level, providing detailed information to help diagnose and troubleshoot system issues."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public AuditdPolicy.AuditdLogLevelEnum AuditdLogLevel
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
    /// <para type="synopsis">This is the cmdlet to New AuditdPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightAuditdPolicy")]
    public class NewIntersightAuditdPolicy : NewCmdletBase
    {
        public NewIntersightAuditdPolicy()
        {
            ApiInstance = new AuditdApi(Config);
            ModelObject = new AuditdPolicy();
            MethodName = "CreateAuditdPolicyWithHttpInfo";
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
        /// <para type="description">"Admin state for the AuditD feature.\n* `Disabled` - Admin configured Disabled State.\n* `Enabled` - Admin configured Enabled State."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AuditdPolicy.AdminStateEnum AdminState
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The log level for the AuditD feature. The default value is \"notifications\".\n* `notifications` - Generated logs are of Notification level, providing information about normal but significant system events requiring awareness.\n* `emergencies` - Generated logs will be of Emergency log level, indicating a critical and unstable system state.\n* `alerts` - Generated logs are of Alert level, indicating critical issues needing immediate attention to prevent system disruption.\n* `critical` - Generated logs are of Critical level, signaling severe issues that may cause system failure if not addressed immediately.\n* `errors` - Generated logs are of Error level, indicating significant problems that affect functionality but do not cause system failure.\n* `warnings` - Generated logs are of Warning level, highlighting potential issues that require attention but do not yet impact functionality.\n* `information` - Generated logs are of Information level, detailing routine operational messages without indicating any issues or errors.\n* `debugging` - Generated logs are of Debugging level, providing detailed information to help diagnose and troubleshoot system issues."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AuditdPolicy.AuditdLogLevelEnum AuditdLogLevel
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
        /// <para type="description">"An array of relationships to fabricBaseSwitchProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<FabricBaseSwitchProfileRelationship> Profiles
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
    /// <para type="synopsis">This is the cmdlet to Remove AuditdPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightAuditdPolicy")]
    public class RemoveIntersightAuditdPolicy : RemoveCmdletBase
    {
        public RemoveIntersightAuditdPolicy()
        {
            ApiInstance = new AuditdApi(Config);
            MethodName = "DeleteAuditdPolicyWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set AuditdPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightAuditdPolicy")]
    public class SetIntersightAuditdPolicy : SetCmdletBase
    {
        public SetIntersightAuditdPolicy()
        {
            ApiInstance = new AuditdApi(Config);
            ModelObject = new AuditdPolicy();
            MethodName = "UpdateAuditdPolicyWithHttpInfo";
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
        /// <para type="description">"Admin state for the AuditD feature.\n* `Disabled` - Admin configured Disabled State.\n* `Enabled` - Admin configured Enabled State."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AuditdPolicy.AdminStateEnum AdminState
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The log level for the AuditD feature. The default value is \"notifications\".\n* `notifications` - Generated logs are of Notification level, providing information about normal but significant system events requiring awareness.\n* `emergencies` - Generated logs will be of Emergency log level, indicating a critical and unstable system state.\n* `alerts` - Generated logs are of Alert level, indicating critical issues needing immediate attention to prevent system disruption.\n* `critical` - Generated logs are of Critical level, signaling severe issues that may cause system failure if not addressed immediately.\n* `errors` - Generated logs are of Error level, indicating significant problems that affect functionality but do not cause system failure.\n* `warnings` - Generated logs are of Warning level, highlighting potential issues that require attention but do not yet impact functionality.\n* `information` - Generated logs are of Information level, detailing routine operational messages without indicating any issues or errors.\n* `debugging` - Generated logs are of Debugging level, providing detailed information to help diagnose and troubleshoot system issues."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AuditdPolicy.AuditdLogLevelEnum AuditdLogLevel
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
        /// <para type="description">"An array of relationships to fabricBaseSwitchProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<FabricBaseSwitchProfileRelationship> Profiles
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