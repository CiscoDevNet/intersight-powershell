using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IwotenantMaintenanceNotification.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIwotenantMaintenanceNotification")]
    public class InitializeIntersightIwotenantMaintenanceNotification : PSCmdlet
    {
        public InitializeIntersightIwotenantMaintenanceNotification()
        {
            ClassId = IwotenantMaintenanceNotification.ClassIdEnum.IwotenantMaintenanceNotification;
            ObjectType = IwotenantMaintenanceNotification.ObjectTypeEnum.IwotenantMaintenanceNotification;

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

        public IwotenantMaintenanceNotification.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Any i18n (internationalization) key defined the message content. If the key already exists then the  message content will be picked based on the key, otherwise provided message value will be used."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string I18nKey
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The iwoId uniquely identifies a IWO tenant. The iwoId is used as part of namespace, (logical) database names, policies in vault and many others. As of now, accountMoid has to be provided as the iwoId."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string IwoId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The date/time from which the actual maintenance operations will be performed for a Customer's account."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime MaintenanceStartTime
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
        /// <para type="description">"The notification message content is to display in the UI banner after the Customer's login to inform about planned maintenance operations on IWO."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string NtfnMessage
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IwotenantMaintenanceNotification.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The date/time from which the maintenance banner message will be shown to the Customer after login in to  Intersight UI."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime ShowFromTime
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The date/time until which the maintenance banner message will be shown to the Customer after login into  Intersight UI. This will also be the time actual maintenance operation is planned for the finish of a  Customer's account."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime ShowUntilTime
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
            Intersight.Model.IwotenantMaintenanceNotification initObject = new Intersight.Model.IwotenantMaintenanceNotification();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("I18nKey"))
            {
                initObject.I18nKey = this.I18nKey;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IwoId"))
            {
                initObject.IwoId = this.IwoId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaintenanceStartTime"))
            {
                initObject.MaintenanceStartTime = this.MaintenanceStartTime;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NtfnMessage"))
            {
                initObject.NtfnMessage = this.NtfnMessage;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("ShowFromTime"))
            {
                initObject.ShowFromTime = this.ShowFromTime;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ShowUntilTime"))
            {
                initObject.ShowUntilTime = this.ShowUntilTime;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IwotenantTenantStatus.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIwotenantTenantStatus")]
    public class InitializeIntersightIwotenantTenantStatus : PSCmdlet
    {
        public InitializeIntersightIwotenantTenantStatus()
        {
            ClassId = IwotenantTenantStatus.ClassIdEnum.IwotenantTenantStatus;
            ObjectType = IwotenantTenantStatus.ObjectTypeEnum.IwotenantTenantStatus;

        }
        // <summary>
        /// <para type="description">"A reference to a iamAccount resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IamAccountRelationship Account
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IwotenantTenantStatus.ClassIdEnum ClassId
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

        public IwotenantTenantStatus.ObjectTypeEnum ObjectType
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
            Intersight.Model.IwotenantTenantStatus initObject = new Intersight.Model.IwotenantTenantStatus();
            if (this.MyInvocation.BoundParameters.ContainsKey("Account"))
            {
                initObject.Account = this.Account;
            }
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
}