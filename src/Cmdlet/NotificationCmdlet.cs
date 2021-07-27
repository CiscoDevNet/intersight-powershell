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
    public class GetIntersightNotificationAccountSubscription:GetCmdletBase
	{
		public GetIntersightNotificationAccountSubscription()
		{
			ApiInstance = new NotificationApi(Config);
            MethodName = "GetNotificationAccountSubscriptionList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New NotificationAccountSubscription.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightNotificationAccountSubscription")]
    public class NewIntersightNotificationAccountSubscription:NewCmdletBase
	{
		public NewIntersightNotificationAccountSubscription()
		{
			ApiInstance = new NotificationApi(Config);
            ModelObject = new NotificationAccountSubscription();
            MethodName = "CreateNotificationAccountSubscription";
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<NotificationAction> Actions {
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<NotificationAbstractCondition> Conditions {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Subscription can be switched on/off with out necessity to change the subscription\nsettings: notification methods, conditions etc.\nEx.: Subscription MO can be configured, but switched off."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Enabled {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The subscription name."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false)]
        
        public string Name {
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
    /// <para type="synopsis">This is the cmdlet to Set NotificationAccountSubscription.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightNotificationAccountSubscription")]
    public class SetIntersightNotificationAccountSubscription:SetCmdletBase
	{
		public SetIntersightNotificationAccountSubscription()
		{
			ApiInstance = new NotificationApi(Config);
            ModelObject = new NotificationAccountSubscription();
            MethodName = "PatchNotificationAccountSubscription";
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<NotificationAction> Actions {
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<NotificationAbstractCondition> Conditions {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Subscription can be switched on/off with out necessity to change the subscription\nsettings: notification methods, conditions etc.\nEx.: Subscription MO can be configured, but switched off."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Enabled {
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
        /// <para type="description">"The subscription name."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Name {
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
    /// <para type="synopsis">This is the cmdlet to Remove NotificationAccountSubscription.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightNotificationAccountSubscription")]
    public class RemoveIntersightNotificationAccountSubscription:RemoveCmdletBase
	{
		public RemoveIntersightNotificationAccountSubscription()
		{
			ApiInstance = new NotificationApi(Config);
            MethodName = "DeleteNotificationAccountSubscription";
		}
    }
}