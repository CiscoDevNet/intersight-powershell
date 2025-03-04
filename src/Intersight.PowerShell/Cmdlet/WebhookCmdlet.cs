using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get WebhookEndpoint.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightWebhookEndpoint", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightWebhookEndpoint : GetCmdletBase
    {
        public GetIntersightWebhookEndpoint()
        {
            ApiInstance = new WebhookApi(Config);
            MethodName = "GetWebhookEndpointListWithHttpInfo";
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
        /// <para type="description">"A reference to a iamAppRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public IamAppRegistrationRelationship AppRegistration
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Type of authentication used by the clientApp.\n* `basic` - The client uses basic username/password authentication. The password is expected to be a JWT token.\n* `none` - No authentication method specified by the client.\n* `bearer-token` - The client uses a long-lived bearer token to authenticate.\n* `auth-code` - The client uses OAuth Authorization Grant Flow without PKCE for authentication.\n* `client-credentials` - The client uses OAuth Client Credentials Flow for authentication."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public WebhookEndpoint.AuthTypeEnum AuthType
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
        /// <para type="description">"An action to be performed on the credentials.\n* `none` - No action to be performed.\n* `regenerateCredentials` - Allows for revocation and regeneration of a token. The old token associated with the client application. will not be usable and a new token will be generated."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public WebhookEndpoint.CredentialsActionEnum CredentialsAction
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
        /// <para type="description">"The name of the Endpoint."</para>
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
        /// <para type="description">"Intersight provides pre-built workflows, tasks and policies to end users through global catalogs.\nObjects that are made available through global catalogs are said to have a 'shared' ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SharedScope
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The endpoint URL. The CREATE and UPDATE APIs can cause the change to the value."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Url
        {
            get;
            set;
        }



    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get WebhookSchema.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightWebhookSchema", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightWebhookSchema : GetCmdletBase
    {
        public GetIntersightWebhookSchema()
        {
            ApiInstance = new WebhookApi(Config);
            MethodName = "GetWebhookSchemaListWithHttpInfo";
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
        /// <para type="description">"The actual JSON schema data. The data must be a valid JSON schema string."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Data
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The description of the schema."</para>
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
        /// <para type="description">"The event type of the schema."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string EventType
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
        /// <para type="description">"The source of the schema."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Source
        {
            get;
            set;
        }




    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New WebhookEndpoint.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightWebhookEndpoint")]
    public class NewIntersightWebhookEndpoint : NewCmdletBase
    {
        public NewIntersightWebhookEndpoint()
        {
            ApiInstance = new WebhookApi(Config);
            ModelObject = new WebhookEndpoint();
            MethodName = "CreateWebhookEndpointWithHttpInfo";
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
        /// <para type="description">"Stores the credentials for the specified authentication type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamAppCredentials AppCredentials
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a iamAppRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamAppRegistrationRelationship AppRegistration
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Type of authentication used by the clientApp.\n* `basic` - The client uses basic username/password authentication. The password is expected to be a JWT token.\n* `none` - No authentication method specified by the client.\n* `bearer-token` - The client uses a long-lived bearer token to authenticate.\n* `auth-code` - The client uses OAuth Authorization Grant Flow without PKCE for authentication.\n* `client-credentials` - The client uses OAuth Client Credentials Flow for authentication."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WebhookEndpoint.AuthTypeEnum AuthType
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"An action to be performed on the credentials.\n* `none` - No action to be performed.\n* `regenerateCredentials` - Allows for revocation and regeneration of a token. The old token associated with the client application. will not be usable and a new token will be generated."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WebhookEndpoint.CredentialsActionEnum CredentialsAction
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
        /// <para type="description">"The name of the Endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false)]

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
        /// <para type="description">"An array of relationships to webhookSchema resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<WebhookSchemaRelationship> Schemas
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
    /// <para type="synopsis">This is the cmdlet to New WebhookSchema.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightWebhookSchema")]
    public class NewIntersightWebhookSchema : NewCmdletBase
    {
        public NewIntersightWebhookSchema()
        {
            ApiInstance = new WebhookApi(Config);
            ModelObject = new WebhookSchema();
            MethodName = "CreateWebhookSchemaWithHttpInfo";
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
        /// <para type="description">"The actual JSON schema data. The data must be a valid JSON schema string."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Data
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The description of the schema."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The event type of the schema."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string EventType
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
        /// <para type="description">"The source of the schema."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Source
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
    /// <para type="synopsis">This is the cmdlet to Remove WebhookEndpoint.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightWebhookEndpoint")]
    public class RemoveIntersightWebhookEndpoint : RemoveCmdletBase
    {
        public RemoveIntersightWebhookEndpoint()
        {
            ApiInstance = new WebhookApi(Config);
            MethodName = "DeleteWebhookEndpointWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove WebhookSchema.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightWebhookSchema")]
    public class RemoveIntersightWebhookSchema : RemoveCmdletBase
    {
        public RemoveIntersightWebhookSchema()
        {
            ApiInstance = new WebhookApi(Config);
            MethodName = "DeleteWebhookSchemaWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set WebhookEndpoint.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightWebhookEndpoint")]
    public class SetIntersightWebhookEndpoint : SetCmdletBase
    {
        public SetIntersightWebhookEndpoint()
        {
            ApiInstance = new WebhookApi(Config);
            ModelObject = new WebhookEndpoint();
            MethodName = "UpdateWebhookEndpointWithHttpInfo";
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
        /// <para type="description">"Stores the credentials for the specified authentication type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamAppCredentials AppCredentials
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a iamAppRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamAppRegistrationRelationship AppRegistration
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Type of authentication used by the clientApp.\n* `basic` - The client uses basic username/password authentication. The password is expected to be a JWT token.\n* `none` - No authentication method specified by the client.\n* `bearer-token` - The client uses a long-lived bearer token to authenticate.\n* `auth-code` - The client uses OAuth Authorization Grant Flow without PKCE for authentication.\n* `client-credentials` - The client uses OAuth Client Credentials Flow for authentication."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WebhookEndpoint.AuthTypeEnum AuthType
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"An action to be performed on the credentials.\n* `none` - No action to be performed.\n* `regenerateCredentials` - Allows for revocation and regeneration of a token. The old token associated with the client application. will not be usable and a new token will be generated."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WebhookEndpoint.CredentialsActionEnum CredentialsAction
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
        /// <para type="description">"The name of the Endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

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
        /// <para type="description">"An array of relationships to webhookSchema resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<WebhookSchemaRelationship> Schemas
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
    /// <para type="synopsis">This is the cmdlet to Set WebhookSchema.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightWebhookSchema")]
    public class SetIntersightWebhookSchema : SetCmdletBase
    {
        public SetIntersightWebhookSchema()
        {
            ApiInstance = new WebhookApi(Config);
            ModelObject = new WebhookSchema();
            MethodName = "UpdateWebhookSchemaWithHttpInfo";
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
        /// <para type="description">"The actual JSON schema data. The data must be a valid JSON schema string."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Data
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The description of the schema."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The event type of the schema."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string EventType
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
        /// <para type="description">"The source of the schema."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Source
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