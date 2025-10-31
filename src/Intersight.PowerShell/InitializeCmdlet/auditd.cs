using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize AuditdPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAuditdPolicy")]
    public class InitializeIntersightAuditdPolicy : PSCmdlet
    {
        public InitializeIntersightAuditdPolicy()
        {
            AdminState = AuditdPolicy.AdminStateEnum.Disabled;
            AuditdLogLevel = AuditdPolicy.AuditdLogLevelEnum.Notifications;
            ClassId = AuditdPolicy.ClassIdEnum.AuditdPolicy;
            ObjectType = AuditdPolicy.ObjectTypeEnum.AuditdPolicy;

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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AuditdPolicy.ClassIdEnum ClassId
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AuditdPolicy.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.OrganizationOrganizationRelationship Organization
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to fabricBaseSwitchProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.FabricBaseSwitchProfileRelationship> Profiles
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
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.AuditdPolicy initObject = new Intersight.Model.AuditdPolicy();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdminState"))
            {
                initObject.AdminState = this.AdminState;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AuditdLogLevel"))
            {
                initObject.AuditdLogLevel = this.AuditdLogLevel;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Organization"))
            {
                initObject.Organization = this.Organization;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Profiles"))
            {
                initObject.Profiles = this.Profiles;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
}