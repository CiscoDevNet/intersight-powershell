using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize UcsdconnectorRestClientMessage.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightUcsdconnectorRestClientMessage")]
    public class InitializeIntersightUcsdconnectorRestClientMessage:PSCmdlet
	{
		public InitializeIntersightUcsdconnectorRestClientMessage()
		{
            ClassId = UcsdconnectorRestClientMessage.ClassIdEnum.UcsdconnectorRestClientMessage;
            ObjectType = UcsdconnectorRestClientMessage.ObjectTypeEnum.UcsdconnectorRestClientMessage;
            
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
        /// <para type="description">"Payload which is sent along with the request. Most applicable to POST methods."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Body {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public UcsdconnectorRestClientMessage.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The secure properties that have large text content as value can be encrypted using AES key. In these cases, the AES key needs to be encrypted using the device connector public key and passed as the value for this property.\nThe secure properties that are encrypted using the AES key are mapped against the property name with prefix 'AES' in SecureProperties dictionary."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string EncryptedAesKey {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The public key that was used to encrypt the values present in SecureProperties dictionary.\nIf the given public key is not same as device connector's public key, an error reponse with appropriate error message is thrown back."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string EncryptionKey {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Headers to be passed with the HTTP rest request."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public object Header {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"REST Method, should be set to one of [HTTP.MethodGet, HTTP.MethodPost]."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Method {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public UcsdconnectorRestClientMessage.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The platform locale to assign user. A locale defines one or more organizations (domains) the user is allowed access, and access is limited to the organizations specified in the locale."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RemoteUserLocale {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The user name passed to the platform for use in platform audit logs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RemoteUserName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The list of roles to pass to the platform to validate the action against."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RemoteUserRoles {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The session Id passed to the platform for use in platforms auditing."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RemoteUserSessionId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"REST URL endpoint to which the HTTP request is sent."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RestUrl {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A dictionary of encrypted secure values mapped against the secure property name. The values that are encrypted using AES key must be mapped against the secure property name with a 'AES' prefix\nDevice connector expects the message body to be a golang template and the template can use the secure property names as placeholders."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public object SecureProperties {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.UcsdconnectorRestClientMessage initObject = new Intersight.Model.UcsdconnectorRestClientMessage();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Body"))
            {
                initObject.Body = this.Body;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Header"))
            {
                initObject.Header = this.Header;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Method"))
            {
                initObject.Method = this.Method;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("RestUrl"))
            {
                initObject.RestUrl = this.RestUrl;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SecureProperties"))
            {
                initObject.SecureProperties = this.SecureProperties;
            }
            WriteObject(initObject);
        }

    }
}