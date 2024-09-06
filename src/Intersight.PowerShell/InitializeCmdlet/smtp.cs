using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize SmtpPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightSmtpPolicy")]
    public class InitializeIntersightSmtpPolicy : PSCmdlet
    {
        public InitializeIntersightSmtpPolicy()
        {
            ClassId = SmtpPolicy.ClassIdEnum.SmtpPolicy;
            MinSeverity = SmtpPolicy.MinSeverityEnum.Critical;
            ObjectType = SmtpPolicy.ObjectTypeEnum.SmtpPolicy;

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
        /// <para type="description">"A reference to a iamAccount resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IamAccountRelationship ApplianceAccount
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Authorization password for the process."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[\\S+]{0,254}$")]
        public string AuthPassword
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a iamTrustPoint resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IamTrustPointRelationship Certificate
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public SmtpPolicy.ClassIdEnum ClassId
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
        /// <para type="description">"If enabled, lets user input username and password."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool EnableAuth
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"If enabled, lets user input valid CA certificates for authorization."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool EnableTls
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"If enabled, controls the state of the SMTP client service on the managed device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Enabled
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Minimum fault severity level to receive email notifications. Email notifications are sent for all faults whose severity is equal to or greater than the chosen level.\n* `critical` - Minimum severity to report is critical.\n* `condition` - Minimum severity to report is informational.\n* `warning` - Minimum severity to report is warning.\n* `minor` - Minimum severity to report is minor.\n* `major` - Minimum severity to report is major."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public SmtpPolicy.MinSeverityEnum MinSeverity
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

        public SmtpPolicy.ObjectTypeEnum ObjectType
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
        /// <para type="description">"An array of relationships to policyAbstractConfigProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.PolicyAbstractConfigProfileRelationship> Profiles
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The email address entered here will be displayed as the from address (mail received from address) of all the SMTP mail alerts that are received. If not configured, the hostname of the server is used in the from address field."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$")]
        public string SenderEmail
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Port number used by the SMTP server for outgoing SMTP communication."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 65535)]
        public long SmtpPort
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> SmtpRecipients
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"IP address or hostname of the SMTP server. The SMTP server is used by the managed device to send email notifications."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SmtpServer
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
        /// <para type="description">"SMTP username from which email notification is sent."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string UserName
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.SmtpPolicy initObject = new Intersight.Model.SmtpPolicy();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ApplianceAccount"))
            {
                initObject.ApplianceAccount = this.ApplianceAccount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AuthPassword"))
            {
                initObject.AuthPassword = this.AuthPassword;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Certificate"))
            {
                initObject.Certificate = this.Certificate;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EnableAuth"))
            {
                initObject.EnableAuth = this.EnableAuth;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EnableTls"))
            {
                initObject.EnableTls = this.EnableTls;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Enabled"))
            {
                initObject.Enabled = this.Enabled;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MinSeverity"))
            {
                initObject.MinSeverity = this.MinSeverity;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("SenderEmail"))
            {
                initObject.SenderEmail = this.SenderEmail;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SmtpPort"))
            {
                initObject.SmtpPort = this.SmtpPort;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SmtpRecipients"))
            {
                initObject.SmtpRecipients = this.SmtpRecipients;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SmtpServer"))
            {
                initObject.SmtpServer = this.SmtpServer;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UserName"))
            {
                initObject.UserName = this.UserName;
            }
            WriteObject(initObject);
        }

    }
}