using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ImcconnectorWebUiMessage.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightImcconnectorWebUiMessage")]
    public class InitializeIntersightImcconnectorWebUiMessage : PSCmdlet
    {
        public InitializeIntersightImcconnectorWebUiMessage()
        {
            ClassId = ImcconnectorWebUiMessage.ClassIdEnum.ImcconnectorWebUiMessage;
            ObjectType = ImcconnectorWebUiMessage.ObjectTypeEnum.ImcconnectorWebUiMessage;

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

        public ImcconnectorWebUiMessage.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The secure properties that have large text content as value can be encrypted using AES key. In these cases, the AES key needs to be encrypted using the device connector's public key and passed as the value for this property.\nThe secure properties that are encrypted using the AES key are mapped against the property name with prefix 'AES' in SecureProperties dictionary."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string EncryptedAesKey
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The public key that was used to encrypt the values present in SecureProperties dictionary.\nIf the given public key is not the same as device connector's public key, an error response with appropriate error message is thrown back."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string EncryptionKey
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ImcconnectorWebUiMessage.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The platform locale to assign user. A locale defines one or more organizations (domains) the user is allowed access to, and access is limited to the organizations specified in the locale."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string RemoteUserLocale
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The user name passed to the platform for use in platform audit logs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string RemoteUserName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The list of roles to pass to the platform to validate the action against."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string RemoteUserRoles
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The session Id passed to the platform for use in platform's auditing."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string RemoteUserSessionId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A dictionary of encrypted secure values mapped against the secure property name. The values that are encrypted using the AES key must be mapped against the secure property name with an 'AES' prefix\nDevice connector expects the message body to be a golang template and the template can use the secure property names as placeholders."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object SecureProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The body content of the UI HTTP request to send to the BMC platform."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string WebUiRequest
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.ImcconnectorWebUiMessage initObject = new Intersight.Model.ImcconnectorWebUiMessage();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("EncryptedAesKey"))
            {
                initObject.EncryptedAesKey = this.EncryptedAesKey;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EncryptionKey"))
            {
                initObject.EncryptionKey = this.EncryptionKey;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("RemoteUserLocale"))
            {
                initObject.RemoteUserLocale = this.RemoteUserLocale;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RemoteUserName"))
            {
                initObject.RemoteUserName = this.RemoteUserName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RemoteUserRoles"))
            {
                initObject.RemoteUserRoles = this.RemoteUserRoles;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RemoteUserSessionId"))
            {
                initObject.RemoteUserSessionId = this.RemoteUserSessionId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SecureProperties"))
            {
                initObject.SecureProperties = this.SecureProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("WebUiRequest"))
            {
                initObject.WebUiRequest = this.WebUiRequest;
            }
            WriteObject(initObject);
        }

    }
}