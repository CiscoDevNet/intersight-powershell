using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NotificationAccountSubscription.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNotificationAccountSubscription", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNotificationAccountSubscription : GetCmdletBase
    {
        public GetIntersightNotificationAccountSubscription()
        {
            ApiInstance = new NotificationApi(Config);
            MethodName = "GetNotificationAccountSubscriptionListWithHttpInfo";
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
        /// <para type="description">"Subscription can be switched on/off without necessity to change the subscription\nsettings: notification methods, conditions, etc.\nEx.: Subscription MO can be configured, but switched off."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool Enabled
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
        /// <para type="description">"The name of the subscription."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^[a-zA-Z0-9_.-]{1,64}$")]
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
        /// <para type="description">"The chosen subscription type imposes it is own validation rules.\nWhen 'email' type is chosen, actions array can contain only one entry and it is entry should be of can\nbe only notification.SendEmail; conditions can contain only notification.AlarmMoCondition and condition\ntypes should be unique.\nWhen the 'webhook' type is chosen, the actions array can contain only one entry and it is entry should be of can\nbe only notification.TriggerWebhook; conditions can contain up to a limited amount of entries and all of them\nshould be of type notification.MoCondition.\nWhen the 'workflow' type is chosen, the actions array can contain only one entry and it is entry should \nbe of type notification.TriggerWorkflow notification.TriggerWorkflow; conditions can contain up to a \nlimited amount of entries and all of them should be of type notification.WebhookEventMoCondition.\n* `email` - Email type requires usage of notification.SendEmail complex types for actionsand notification.AlarmMoCondition complex types for conditions.\n* `webhook` - Webhook type requires usage of notification.TriggerWebhook complex types for actionsand notification.MoCondition complex types for conditions.\n* `workflow` - Workflow type requires usage of notification.TriggerWorkflow complex types for actionsand notification.WebhookEventMoCondition complex types for conditions."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public NotificationAccountSubscription.TypeEnum Type
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Used to verify the actions of the Subscription MO. For a 'webhook' type Ping event is sent to verify\nthat the webhook server is accessible. For an 'email' type there will be a verification email sent.\n* `none` - No actions will be verified. Default value.\n* `all` - All actions will be re-verified. The previous state of the verification will be preserved."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public NotificationAccountSubscription.VerifyEnum Verify
        {
            get;
            set;
        }



    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New NotificationAccountSubscription.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightNotificationAccountSubscription")]
    public class NewIntersightNotificationAccountSubscription : NewCmdletBase
    {
        public NewIntersightNotificationAccountSubscription()
        {
            ApiInstance = new NotificationApi(Config);
            ModelObject = new NotificationAccountSubscription();
            MethodName = "CreateNotificationAccountSubscriptionWithHttpInfo";
        }



        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<NotificationAction> Actions
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

        public List<NotificationAbstractCondition> Conditions
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"Subscription can be switched on/off without necessity to change the subscription\nsettings: notification methods, conditions, etc.\nEx.: Subscription MO can be configured, but switched off."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Enabled
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
        /// <para type="description">"The name of the subscription."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.-]{1,64}$")]
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

        // <summary>
        /// <para type="description">"The chosen subscription type imposes it is own validation rules.\nWhen 'email' type is chosen, actions array can contain only one entry and it is entry should be of can\nbe only notification.SendEmail; conditions can contain only notification.AlarmMoCondition and condition\ntypes should be unique.\nWhen the 'webhook' type is chosen, the actions array can contain only one entry and it is entry should be of can\nbe only notification.TriggerWebhook; conditions can contain up to a limited amount of entries and all of them\nshould be of type notification.MoCondition.\nWhen the 'workflow' type is chosen, the actions array can contain only one entry and it is entry should \nbe of type notification.TriggerWorkflow notification.TriggerWorkflow; conditions can contain up to a \nlimited amount of entries and all of them should be of type notification.WebhookEventMoCondition.\n* `email` - Email type requires usage of notification.SendEmail complex types for actionsand notification.AlarmMoCondition complex types for conditions.\n* `webhook` - Webhook type requires usage of notification.TriggerWebhook complex types for actionsand notification.MoCondition complex types for conditions.\n* `workflow` - Workflow type requires usage of notification.TriggerWorkflow complex types for actionsand notification.WebhookEventMoCondition complex types for conditions."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public NotificationAccountSubscription.TypeEnum Type
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Used to verify the actions of the Subscription MO. For a 'webhook' type Ping event is sent to verify\nthat the webhook server is accessible. For an 'email' type there will be a verification email sent.\n* `none` - No actions will be verified. Default value.\n* `all` - All actions will be re-verified. The previous state of the verification will be preserved."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public NotificationAccountSubscription.VerifyEnum Verify
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove NotificationAccountSubscription.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightNotificationAccountSubscription")]
    public class RemoveIntersightNotificationAccountSubscription : RemoveCmdletBase
    {
        public RemoveIntersightNotificationAccountSubscription()
        {
            ApiInstance = new NotificationApi(Config);
            MethodName = "DeleteNotificationAccountSubscriptionWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set NotificationAccountSubscription.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightNotificationAccountSubscription")]
    public class SetIntersightNotificationAccountSubscription : SetCmdletBase
    {
        public SetIntersightNotificationAccountSubscription()
        {
            ApiInstance = new NotificationApi(Config);
            ModelObject = new NotificationAccountSubscription();
            MethodName = "UpdateNotificationAccountSubscriptionWithHttpInfo";
        }



        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<NotificationAction> Actions
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

        public List<NotificationAbstractCondition> Conditions
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"Subscription can be switched on/off without necessity to change the subscription\nsettings: notification methods, conditions, etc.\nEx.: Subscription MO can be configured, but switched off."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Enabled
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
        /// <para type="description">"The name of the subscription."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.-]{1,64}$")]
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

        // <summary>
        /// <para type="description">"The chosen subscription type imposes it is own validation rules.\nWhen 'email' type is chosen, actions array can contain only one entry and it is entry should be of can\nbe only notification.SendEmail; conditions can contain only notification.AlarmMoCondition and condition\ntypes should be unique.\nWhen the 'webhook' type is chosen, the actions array can contain only one entry and it is entry should be of can\nbe only notification.TriggerWebhook; conditions can contain up to a limited amount of entries and all of them\nshould be of type notification.MoCondition.\nWhen the 'workflow' type is chosen, the actions array can contain only one entry and it is entry should \nbe of type notification.TriggerWorkflow notification.TriggerWorkflow; conditions can contain up to a \nlimited amount of entries and all of them should be of type notification.WebhookEventMoCondition.\n* `email` - Email type requires usage of notification.SendEmail complex types for actionsand notification.AlarmMoCondition complex types for conditions.\n* `webhook` - Webhook type requires usage of notification.TriggerWebhook complex types for actionsand notification.MoCondition complex types for conditions.\n* `workflow` - Workflow type requires usage of notification.TriggerWorkflow complex types for actionsand notification.WebhookEventMoCondition complex types for conditions."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public NotificationAccountSubscription.TypeEnum Type
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Used to verify the actions of the Subscription MO. For a 'webhook' type Ping event is sent to verify\nthat the webhook server is accessible. For an 'email' type there will be a verification email sent.\n* `none` - No actions will be verified. Default value.\n* `all` - All actions will be re-verified. The previous state of the verification will be preserved."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public NotificationAccountSubscription.VerifyEnum Verify
        {
            get;
            set;
        }

    }
}