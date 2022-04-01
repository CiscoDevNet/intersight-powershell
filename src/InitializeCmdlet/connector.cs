using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ConnectorCommandControlMessage.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightConnectorCommandControlMessage")]
    public class InitializeIntersightConnectorCommandControlMessage : PSCmdlet
    {
        public InitializeIntersightConnectorCommandControlMessage()
        {
            ClassId = ConnectorCommandControlMessage.ClassIdEnum.ConnectorCommandControlMessage;
            ObjectType = ConnectorCommandControlMessage.ObjectTypeEnum.ConnectorCommandControlMessage;

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

        public ConnectorCommandControlMessage.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The working directory of the command. If empty command is executed in the same directory the device connector process was called."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Dir
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The secure properties that have large text content as value can be encrypted using AES key. In these cases, the AES key needs to be encrypted using the device connector public key and passed as the value for this property.\nThe secure properties that are encrypted using the AES key are mapped against the property name with prefix 'AES' in SecureProperties dictionary."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string EncryptedAesKey
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The public key that was used to encrypt the values present in SecureProperties dictionary.\nIf the given public key is not same as device connector's public key, an error reponse with appropriate error message is thrown back."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string EncryptionKey
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Message carrying the operation to perform."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string MsgType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ConnectorCommandControlMessage.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The platform locale to assign user. A locale defines one or more organizations (domains) the user is allowed access, and access is limited to the organizations specified in the locale."</para>
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
        /// <para type="description">"The session Id passed to the platform for use in platforms auditing."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string RemoteUserSessionId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A dictionary of encrypted secure values mapped against the secure property name. The values that are encrypted using AES key must be mapped against the secure property name with a 'AES' prefix\nDevice connector expects the message body to be a golang template and the template can use the secure property names as placeholders."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object SecureProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The command to execute. Commands must be whitelisted by platform implementation, if a command does not match any whitelisted command patterns an error will be returned to the requesting service on command start."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public byte[] Stream
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Indicates that a pseudo terminal should be attached to the command. Used for interactive commands. e.g A cross launch cli."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Terminal
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The timeout for the command to complete and exit after starting or receiving input. If timeout is not set a default of 10 minutes will be used. If there is input to the command stream the timeout is extended."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Timeout
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.ConnectorCommandControlMessage initObject = new Intersight.Model.ConnectorCommandControlMessage();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Dir"))
            {
                initObject.Dir = this.Dir;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EncryptedAesKey"))
            {
                initObject.EncryptedAesKey = this.EncryptedAesKey;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EncryptionKey"))
            {
                initObject.EncryptionKey = this.EncryptionKey;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MsgType"))
            {
                initObject.MsgType = this.MsgType;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Stream"))
            {
                initObject.Stream = this.Stream;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Terminal"))
            {
                initObject.Terminal = this.Terminal;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Timeout"))
            {
                initObject.Timeout = this.Timeout;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ConnectorExpectPrompt.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightConnectorExpectPrompt")]
    public class InitializeIntersightConnectorExpectPrompt : PSCmdlet
    {
        public InitializeIntersightConnectorExpectPrompt()
        {
            ClassId = ConnectorExpectPrompt.ClassIdEnum.ConnectorExpectPrompt;
            ObjectType = ConnectorExpectPrompt.ObjectTypeEnum.ConnectorExpectPrompt;

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

        public ConnectorExpectPrompt.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The regex of the expect prompt of the interactive command."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Expect
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The timeout for the expect prompt while executing interactive command. If timeout is not set a default of 60 seconds will be used."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long ExpectTimeout
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ConnectorExpectPrompt.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The answer string to the expect prompt."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Send
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.ConnectorExpectPrompt initObject = new Intersight.Model.ConnectorExpectPrompt();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Expect"))
            {
                initObject.Expect = this.Expect;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ExpectTimeout"))
            {
                initObject.ExpectTimeout = this.ExpectTimeout;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Send"))
            {
                initObject.Send = this.Send;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ConnectorFetchStreamMessage.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightConnectorFetchStreamMessage")]
    public class InitializeIntersightConnectorFetchStreamMessage : PSCmdlet
    {
        public InitializeIntersightConnectorFetchStreamMessage()
        {
            ClassId = ConnectorFetchStreamMessage.ClassIdEnum.ConnectorFetchStreamMessage;
            ObjectType = ConnectorFetchStreamMessage.ObjectTypeEnum.ConnectorFetchStreamMessage;

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

        public ConnectorFetchStreamMessage.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The secure properties that have large text content as value can be encrypted using AES key. In these cases, the AES key needs to be encrypted using the device connector public key and passed as the value for this property.\nThe secure properties that are encrypted using the AES key are mapped against the property name with prefix 'AES' in SecureProperties dictionary."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string EncryptedAesKey
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The public key that was used to encrypt the values present in SecureProperties dictionary.\nIf the given public key is not same as device connector's public key, an error reponse with appropriate error message is thrown back."</para>
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

        public ConnectorFetchStreamMessage.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A dictionary of encrypted secure values mapped against the secure property name. The values that are encrypted using AES key must be mapped against the secure property name with a 'AES' prefix\nDevice connector expects the message body to be a golang template and the template can use the secure property names as placeholders."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object SecureProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<long> Sequences
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The requested stream name. Stream names are unique per device endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string StreamName
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.ConnectorFetchStreamMessage initObject = new Intersight.Model.ConnectorFetchStreamMessage();
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
            if (this.MyInvocation.BoundParameters.ContainsKey("SecureProperties"))
            {
                initObject.SecureProperties = this.SecureProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Sequences"))
            {
                initObject.Sequences = this.Sequences;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("StreamName"))
            {
                initObject.StreamName = this.StreamName;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ConnectorPlatformParamBase.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightConnectorPlatformParamBase")]
    public class InitializeIntersightConnectorPlatformParamBase : PSCmdlet
    {
        public InitializeIntersightConnectorPlatformParamBase()
        {

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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ConnectorPlatformParamBase.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ConnectorPlatformParamBase.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.ConnectorPlatformParamBase initObject = new Intersight.Model.ConnectorPlatformParamBase();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ConnectorSshConfig.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightConnectorSshConfig")]
    public class InitializeIntersightConnectorSshConfig : PSCmdlet
    {
        public InitializeIntersightConnectorSshConfig()
        {
            ClassId = ConnectorSshConfig.ClassIdEnum.ConnectorSshConfig;
            ObjectType = ConnectorSshConfig.ObjectTypeEnum.ConnectorSshConfig;

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

        public ConnectorSshConfig.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The secure properties that have large text content as value can be encrypted using AES key. In these cases, the AES key needs to be encrypted using the device connector public key and passed as the value for this property.\nThe secure properties that are encrypted using the AES key are mapped against the property name with prefix 'AES' in SecureProperties dictionary."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string EncryptedAesKey
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The public key that was used to encrypt the values present in SecureProperties dictionary.\nIf the given public key is not same as device connector's public key, an error reponse with appropriate error message is thrown back."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string EncryptionKey
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A jump host for establishing a connection to a server. Plugin will first establish a connection to this server, then create a tunneled connection to the target host."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string JumpHost
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ConnectorSshConfig.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Optional passphrase if provided while creating the private key."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Passphrase
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Password to use in the connection credentials (If empty the private key will be used)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Password
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The private key to use in the connection credentials (Optional if password is given)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public byte[] Pkey
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The private key to use in the connection credentials in string format."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string PkeyString
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A dictionary of encrypted secure values mapped against the secure property name. The values that are encrypted using AES key must be mapped against the secure property name with a 'AES' prefix\nDevice connector expects the message body to be a golang template and the template can use the secure property names as placeholders."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object SecureProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The remote server to connect to."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Target
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Username for the remote connection."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string User
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.ConnectorSshConfig initObject = new Intersight.Model.ConnectorSshConfig();
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
            if (this.MyInvocation.BoundParameters.ContainsKey("JumpHost"))
            {
                initObject.JumpHost = this.JumpHost;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Passphrase"))
            {
                initObject.Passphrase = this.Passphrase;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Password"))
            {
                initObject.Password = this.Password;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Pkey"))
            {
                initObject.Pkey = this.Pkey;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PkeyString"))
            {
                initObject.PkeyString = this.PkeyString;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SecureProperties"))
            {
                initObject.SecureProperties = this.SecureProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Target"))
            {
                initObject.Target = this.Target;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("User"))
            {
                initObject.User = this.User;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ConnectorWinrmRequest.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightConnectorWinrmRequest")]
    public class InitializeIntersightConnectorWinrmRequest : PSCmdlet
    {
        public InitializeIntersightConnectorWinrmRequest()
        {
            ClassId = ConnectorWinrmRequest.ClassIdEnum.ConnectorWinrmRequest;
            ObjectType = ConnectorWinrmRequest.ObjectTypeEnum.ConnectorWinrmRequest;
            OpType = ConnectorWinrmRequest.OpTypeEnum.ExecuteScript;

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
        /// <para type="description">"The Target endpoint Moid which is used to fetch the previously persisted Target information in Intersight."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string AssetTargetMoid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Contains the file content to be copied or the script to be executed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public byte[] Body
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ConnectorWinrmRequest.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The secure properties that have large text content as value can be encrypted using AES key. In these cases, the AES key needs to be encrypted using the device connector public key and passed as the value for this property.\nThe secure properties that are encrypted using the AES key are mapped against the property name with prefix 'AES' in SecureProperties dictionary."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string EncryptedAesKey
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The public key that was used to encrypt the values present in SecureProperties dictionary.\nIf the given public key is not same as device connector's public key, an error reponse with appropriate error message is thrown back."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string EncryptionKey
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The absolute filename to which body is to be written to.\nThis field is ignored if the opType is ExecuteScript."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Filename
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ConnectorWinrmRequest.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The type of operation to be performed on the endpoint.\nFile copy and script execution are the possible options.\nOnly script execution is supported for now.\n* `ExecuteScript` - Executes the given script on the target windows machine.\n* `CopyToFile` - The plugin copies the body of the incoming message to the given location."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ConnectorWinrmRequest.OpTypeEnum OpType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A dictionary of encrypted secure values mapped against the secure property name. The values that are encrypted using AES key must be mapped against the secure property name with a 'AES' prefix\nDevice connector expects the message body to be a golang template and the template can use the secure property names as placeholders."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object SecureProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A unique id to track long running script executions.\nEvery execution request is identified by a unique session id. Scripts that have longer execution\ntimes can be tracked to completion by using their unique session id."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SessionId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The time within which the script execution must be completed.\nIf the script execution exceeds the given time limit an appropriate response is sent back\nto the calling service."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Timeout
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.ConnectorWinrmRequest initObject = new Intersight.Model.ConnectorWinrmRequest();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AssetTargetMoid"))
            {
                initObject.AssetTargetMoid = this.AssetTargetMoid;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Filename"))
            {
                initObject.Filename = this.Filename;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("OpType"))
            {
                initObject.OpType = this.OpType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SecureProperties"))
            {
                initObject.SecureProperties = this.SecureProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SessionId"))
            {
                initObject.SessionId = this.SessionId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Timeout"))
            {
                initObject.Timeout = this.Timeout;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ConnectorStreamAcknowledge.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightConnectorStreamAcknowledge")]
    public class InitializeIntersightConnectorStreamAcknowledge : PSCmdlet
    {
        public InitializeIntersightConnectorStreamAcknowledge()
        {
            ClassId = ConnectorStreamAcknowledge.ClassIdEnum.ConnectorStreamAcknowledge;
            ObjectType = ConnectorStreamAcknowledge.ObjectTypeEnum.ConnectorStreamAcknowledge;

        }
        // <summary>
        /// <para type="description">"The latest message sequence processed in the cloud. Device connector will drop all messages up to this sequence from its cache."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long AckSequence
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

        public ConnectorStreamAcknowledge.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The secure properties that have large text content as value can be encrypted using AES key. In these cases, the AES key needs to be encrypted using the device connector public key and passed as the value for this property.\nThe secure properties that are encrypted using the AES key are mapped against the property name with prefix 'AES' in SecureProperties dictionary."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string EncryptedAesKey
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The public key that was used to encrypt the values present in SecureProperties dictionary.\nIf the given public key is not same as device connector's public key, an error reponse with appropriate error message is thrown back."</para>
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

        public ConnectorStreamAcknowledge.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A dictionary of encrypted secure values mapped against the secure property name. The values that are encrypted using AES key must be mapped against the secure property name with a 'AES' prefix\nDevice connector expects the message body to be a golang template and the template can use the secure property names as placeholders."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object SecureProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The requested stream name. Stream names are unique per device endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string StreamName
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.ConnectorStreamAcknowledge initObject = new Intersight.Model.ConnectorStreamAcknowledge();
            if (this.MyInvocation.BoundParameters.ContainsKey("AckSequence"))
            {
                initObject.AckSequence = this.AckSequence;
            }
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
            if (this.MyInvocation.BoundParameters.ContainsKey("SecureProperties"))
            {
                initObject.SecureProperties = this.SecureProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("StreamName"))
            {
                initObject.StreamName = this.StreamName;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ConnectorUrl.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightConnectorUrl")]
    public class InitializeIntersightConnectorUrl : PSCmdlet
    {
        public InitializeIntersightConnectorUrl()
        {
            ClassId = ConnectorUrl.ClassIdEnum.ConnectorUrl;
            ObjectType = ConnectorUrl.ObjectTypeEnum.ConnectorUrl;

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

        public ConnectorUrl.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Flag to append a query to the url even if rawQuery is empty."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool ForceQuery
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fragment identifier component of a URI allows indirect identification of a secondary resource by reference to a primary resource and additional identifying information. The identified secondary resource may be some portion or subset of the primary resource, some view on representations of the primary resource, or some other resource defined or described by those representations. A fragment identifier component is indicated by the presence of a number sign (\"#\") character and terminated by the end of the URI."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Fragment
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The host name identifies the host that holds the resource. The host can be an IP or a hostname that is resolvable by the dns server configured on the platform."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Host
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ConnectorUrl.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A URI is opaque if, and only if, it is absolute and its scheme-specific part does not begin with a slash character ('/'). An opaque URI has a scheme, a scheme-specific part, and possibly a fragment; all other components are undefined."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Opaque
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The path identifies the specific resource in the host that the web client wants to access. Value is the decoded form of the path. e.g. '/foo/bar'."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Path
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The URI encoded form of the path property. e.g. '%2Fapi%2Fv1%2F'."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string RawPath
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The query component, as defined in RFC 3986, contains non-hierarchical data that, along with data in the path component, serves to identify a resource within the scope of the URI's scheme and naming authority (if any). The query component is indicated by the first question mark character and terminated by a number sign character or by the end of the URI.\nThe rawQuery contains the URIs encoded query component, excluding the ? character."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string RawQuery
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The scheme identifies the protocol to be used to access the resource on the Internet. It can be HTTP (without SSL) or HTTPS (with SSL)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Scheme
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.ConnectorUrl initObject = new Intersight.Model.ConnectorUrl();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ForceQuery"))
            {
                initObject.ForceQuery = this.ForceQuery;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Fragment"))
            {
                initObject.Fragment = this.Fragment;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Host"))
            {
                initObject.Host = this.Host;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Opaque"))
            {
                initObject.Opaque = this.Opaque;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Path"))
            {
                initObject.Path = this.Path;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RawPath"))
            {
                initObject.RawPath = this.RawPath;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RawQuery"))
            {
                initObject.RawQuery = this.RawQuery;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Scheme"))
            {
                initObject.Scheme = this.Scheme;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ConnectorTargetChangeMessage.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightConnectorTargetChangeMessage")]
    public class InitializeIntersightConnectorTargetChangeMessage : PSCmdlet
    {
        public InitializeIntersightConnectorTargetChangeMessage()
        {
            ClassId = ConnectorTargetChangeMessage.ClassIdEnum.ConnectorTargetChangeMessage;
            ModStatus = ConnectorTargetChangeMessage.ModStatusEnum.None;
            ObjectType = ConnectorTargetChangeMessage.ObjectTypeEnum.ConnectorTargetChangeMessage;

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

        public ConnectorTargetChangeMessage.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The secure properties that have large text content as value can be encrypted using AES key. In these cases, the AES key needs to be encrypted using the device connector public key and passed as the value for this property.\nThe secure properties that are encrypted using the AES key are mapped against the property name with prefix 'AES' in SecureProperties dictionary."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string EncryptedAesKey
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The public key that was used to encrypt the values present in SecureProperties dictionary.\nIf the given public key is not same as device connector's public key, an error reponse with appropriate error message is thrown back."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string EncryptionKey
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"ModStatus indicates if the change message conveys a creation, modification or deletion of an Target instance.\n* `None` - The 'none' operation/state.Indicates a configuration profile has been deployed, and the desired configuration matches the actual device configuration.\n* `Created` - The 'create' operation/state.Indicates a configuration profile has been created and associated with a device, but the configuration specified in the profilehas not been applied yet. For example, this could happen when the user creates a server profile and has not deployed the profile yet.\n* `Modified` - The 'update' operation/state.Indicates some of the desired configuration changes specified in a profile have not been been applied to the associated device.This happens when the user has made changes to a profile and has not deployed the changes yet, or when the workflow to applythe configuration changes has not completed succesfully.\n* `Deleted` - The 'delete' operation/state.Indicates a configuration profile has been been disassociated from a device and the user has not undeployed these changes yet."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ConnectorTargetChangeMessage.ModStatusEnum ModStatus
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ConnectorTargetChangeMessage.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A dictionary of encrypted secure values mapped against the secure property name. The values that are encrypted using AES key must be mapped against the secure property name with a 'AES' prefix\nDevice connector expects the message body to be a golang template and the template can use the secure property names as placeholders."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object SecureProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A Json-serialized representation of the 'configuration' portion of the Target instance. Ie the representation contains configuration properties like the target's connectivity information but not operation status. The representation include credential information, encrypted with the RSA public key of the Appliance device connector. Appliance device connector is the sole maintainer of the RSA private key and the only system component which is capable of interpreting the credential."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object TargetDetails
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Moid identifying the Target instance being created, modified or deleted."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string TargetMoid
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.ConnectorTargetChangeMessage initObject = new Intersight.Model.ConnectorTargetChangeMessage();
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
            if (this.MyInvocation.BoundParameters.ContainsKey("ModStatus"))
            {
                initObject.ModStatus = this.ModStatus;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("SecureProperties"))
            {
                initObject.SecureProperties = this.SecureProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TargetDetails"))
            {
                initObject.TargetDetails = this.TargetDetails;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TargetMoid"))
            {
                initObject.TargetMoid = this.TargetMoid;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ConnectorFileMessage.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightConnectorFileMessage")]
    public class InitializeIntersightConnectorFileMessage : PSCmdlet
    {
        public InitializeIntersightConnectorFileMessage()
        {
            ClassId = ConnectorFileMessage.ClassIdEnum.ConnectorFileMessage;
            MsgType = ConnectorFileMessage.MsgTypeEnum.OpenFile;
            ObjectType = ConnectorFileMessage.ObjectTypeEnum.ConnectorFileMessage;

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

        public ConnectorFileMessage.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The secure properties that have large text content as value can be encrypted using AES key. In these cases, the AES key needs to be encrypted using the device connector public key and passed as the value for this property.\nThe secure properties that are encrypted using the AES key are mapped against the property name with prefix 'AES' in SecureProperties dictionary."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string EncryptedAesKey
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The public key that was used to encrypt the values present in SecureProperties dictionary.\nIf the given public key is not same as device connector's public key, an error reponse with appropriate error message is thrown back."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string EncryptionKey
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Message type carrying the file operation to perform.\n* `OpenFile` - Open a file for write to on the platforms file system. Must be the first message sent to the plugin when writing files, attempting to write to or close a file that has not been opened will return error. If file does not exist file will be created, if it does exist file will be truncated. If the files parent directory does not exist an error will be returned.\n* `FileContent` - Carries content to write to an open file. The complete file content can be buffered across many FileContent messages, with each subsequent message received appending to the end of the file. If the total size of FileContent messages exceeds the file size limit of 5MB the plugin will return error and remove the opened file.\n* `CloseFile` - Close the file. Close message must be sent at the end of file transfer. If no close is sent and no input is received after a timeout of 10 minutes the file will be removed. After a CloseFile is received no further FileContent messages will be accepted and will return error.\n* `DeleteFile` - Delete a file from the filesystem. If the file does not exist operation is a no-op and no error is returned. File must be within one of the platforms allowed writable directories.\n* `ListDir` - Open a directory and return a list of files in the directory. Does not recursively walk subdirectories, returns only the top level files in the directory. Output will be a list of json encoded FileInfos.\n* `` - Open a file and read the contents into a response message. The response message body is the entire contents of the file with no encoding or compression. If the file does not exist an error will be returned. If the size of the file exceeds 500KB an error will be returned without reading any file contents.\n* `PopulateRemoteTemplateFile` - Populates data driven template file with input values to generate textual output. Inputs are - the path of the template file on the device and values to populate. An error will be returned if the file does not exist or if there is an error while executing the templates.\n* `GetFreeSpace` - Check the disk space availability of folder and returns the free disk space in percentage. Output will be a list of encoded FileInfos."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ConnectorFileMessage.MsgTypeEnum MsgType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ConnectorFileMessage.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The absolute path of the file to open on the platforms file system. Must be a sub-directory of a directory defined within the platform configurations WriteableDirectories. The file system device to write to must also have sufficient free space to write to (<75% full). Must be set for each message that is sent."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Path
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A dictionary of encrypted secure values mapped against the secure property name. The values that are encrypted using AES key must be mapped against the secure property name with a 'AES' prefix\nDevice connector expects the message body to be a golang template and the template can use the secure property names as placeholders."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object SecureProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The stream of bytes to write to file when message type is FileContent. Ignored for OpenFile and CloseFile messages. This field holds the input values (key-value pairs) to be populated in the template file when message type is PopulateTemplateFile."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public byte[] Stream
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.ConnectorFileMessage initObject = new Intersight.Model.ConnectorFileMessage();
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
            if (this.MyInvocation.BoundParameters.ContainsKey("MsgType"))
            {
                initObject.MsgType = this.MsgType;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Path"))
            {
                initObject.Path = this.Path;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SecureProperties"))
            {
                initObject.SecureProperties = this.SecureProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Stream"))
            {
                initObject.Stream = this.Stream;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ConnectorCommandTerminalStream.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightConnectorCommandTerminalStream")]
    public class InitializeIntersightConnectorCommandTerminalStream : PSCmdlet
    {
        public InitializeIntersightConnectorCommandTerminalStream()
        {
            ClassId = ConnectorCommandTerminalStream.ClassIdEnum.ConnectorCommandTerminalStream;
            ObjectType = ConnectorCommandTerminalStream.ObjectTypeEnum.ConnectorCommandTerminalStream;

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

        public ConnectorCommandTerminalStream.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The secure properties that have large text content as value can be encrypted using AES key. In these cases, the AES key needs to be encrypted using the device connector public key and passed as the value for this property.\nThe secure properties that are encrypted using the AES key are mapped against the property name with prefix 'AES' in SecureProperties dictionary."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string EncryptedAesKey
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The public key that was used to encrypt the values present in SecureProperties dictionary.\nIf the given public key is not same as device connector's public key, an error reponse with appropriate error message is thrown back."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string EncryptionKey
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The type of data this message contains."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string MsgType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ConnectorCommandTerminalStream.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A dictionary of encrypted secure values mapped against the secure property name. The values that are encrypted using AES key must be mapped against the secure property name with a 'AES' prefix\nDevice connector expects the message body to be a golang template and the template can use the secure property names as placeholders."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object SecureProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Sequence of the message within a session to handle out-of-order delivery."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Sequence
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The input/output payload to/from the pseudo terminal session. When sent from the cloud service if the msgType is CommandInput stream is piped to stdin of the command or a resize message if msgType is CommandResize. From the device connector value is always the combined output of stdout & stderr."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public byte[] Stream
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.ConnectorCommandTerminalStream initObject = new Intersight.Model.ConnectorCommandTerminalStream();
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
            if (this.MyInvocation.BoundParameters.ContainsKey("MsgType"))
            {
                initObject.MsgType = this.MsgType;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("SecureProperties"))
            {
                initObject.SecureProperties = this.SecureProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Sequence"))
            {
                initObject.Sequence = this.Sequence;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Stream"))
            {
                initObject.Stream = this.Stream;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ConnectorCloseStreamMessage.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightConnectorCloseStreamMessage")]
    public class InitializeIntersightConnectorCloseStreamMessage : PSCmdlet
    {
        public InitializeIntersightConnectorCloseStreamMessage()
        {

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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ConnectorCloseStreamMessage.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The secure properties that have large text content as value can be encrypted using AES key. In these cases, the AES key needs to be encrypted using the device connector public key and passed as the value for this property.\nThe secure properties that are encrypted using the AES key are mapped against the property name with prefix 'AES' in SecureProperties dictionary."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string EncryptedAesKey
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The public key that was used to encrypt the values present in SecureProperties dictionary.\nIf the given public key is not same as device connector's public key, an error reponse with appropriate error message is thrown back."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string EncryptionKey
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ConnectorCloseStreamMessage.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A dictionary of encrypted secure values mapped against the secure property name. The values that are encrypted using AES key must be mapped against the secure property name with a 'AES' prefix\nDevice connector expects the message body to be a golang template and the template can use the secure property names as placeholders."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object SecureProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The requested stream name. Stream names are unique per device endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string StreamName
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.ConnectorCloseStreamMessage initObject = new Intersight.Model.ConnectorCloseStreamMessage();
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
            if (this.MyInvocation.BoundParameters.ContainsKey("SecureProperties"))
            {
                initObject.SecureProperties = this.SecureProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("StreamName"))
            {
                initObject.StreamName = this.StreamName;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ConnectorFileChecksum.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightConnectorFileChecksum")]
    public class InitializeIntersightConnectorFileChecksum : PSCmdlet
    {
        public InitializeIntersightConnectorFileChecksum()
        {
            ClassId = ConnectorFileChecksum.ClassIdEnum.ConnectorFileChecksum;
            HashAlgorithm = ConnectorFileChecksum.HashAlgorithmEnum.Crc;
            ObjectType = ConnectorFileChecksum.ObjectTypeEnum.ConnectorFileChecksum;

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

        public ConnectorFileChecksum.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The calculated hash of the contents using the algorithm."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public byte[] Hash
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The hash algorithm used to calculate the checksum.\n* `crc` - A CRC hash as definded by RFC 3385. Generated with the IEEE polynomial.\n* `sha256` - A SHA256 hash as defined by RFC 4634."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ConnectorFileChecksum.HashAlgorithmEnum HashAlgorithm
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ConnectorFileChecksum.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.ConnectorFileChecksum initObject = new Intersight.Model.ConnectorFileChecksum();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Hash"))
            {
                initObject.Hash = this.Hash;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HashAlgorithm"))
            {
                initObject.HashAlgorithm = this.HashAlgorithm;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ConnectorHttpRequest.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightConnectorHttpRequest")]
    public class InitializeIntersightConnectorHttpRequest : PSCmdlet
    {
        public InitializeIntersightConnectorHttpRequest()
        {
            ClassId = ConnectorHttpRequest.ClassIdEnum.ConnectorHttpRequest;
            ObjectType = ConnectorHttpRequest.ObjectTypeEnum.ConnectorHttpRequest;

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
        /// <para type="description">"The Target endpoint Moid which is used to fetch the previously persisted Target information in Intersight to create HTTP request along with any authentication info specifed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string AssetTargetMoid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Contents of the request body to send for PUT/PATCH/POST requests."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public byte[] Body
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ConnectorHttpRequest.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The timeout for establishing the TCP connection to the target host. If not set the request timeout value is used."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long DialTimeout
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The secure properties that have large text content as value can be encrypted using AES key. In these cases, the AES key needs to be encrypted using the device connector public key and passed as the value for this property.\nThe secure properties that are encrypted using the AES key are mapped against the property name with prefix 'AES' in SecureProperties dictionary."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string EncryptedAesKey
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The public key that was used to encrypt the values present in SecureProperties dictionary.\nIf the given public key is not same as device connector's public key, an error reponse with appropriate error message is thrown back."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string EncryptionKey
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The MO id of the asset.EndpointConnection this request is directed to. If set plugin will insert connection details into the request, including credentials if defined."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string EndpointMoid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Collection of key value pairs to set in the request header."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object Header
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The request is for an internal platform API that requires authentication to be inserted by the platform implementation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Internal
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Method specifies the HTTP method (GET, POST, PUT, etc.). For client requests an empty string means GET."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Method
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ConnectorHttpRequest.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A dictionary of encrypted secure values mapped against the secure property name. The values that are encrypted using AES key must be mapped against the secure property name with a 'AES' prefix\nDevice connector expects the message body to be a golang template and the template can use the secure property names as placeholders."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object SecureProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The timeout for the HTTP request to complete, from connection establishment to response body read complete. If not set a default timeout of five minutes is used."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Timeout
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The URL detailing the request and remote server to proxy the request to."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.ConnectorUrl Url
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.ConnectorHttpRequest initObject = new Intersight.Model.ConnectorHttpRequest();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AssetTargetMoid"))
            {
                initObject.AssetTargetMoid = this.AssetTargetMoid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Body"))
            {
                initObject.Body = this.Body;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("DialTimeout"))
            {
                initObject.DialTimeout = this.DialTimeout;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EncryptedAesKey"))
            {
                initObject.EncryptedAesKey = this.EncryptedAesKey;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EncryptionKey"))
            {
                initObject.EncryptionKey = this.EncryptionKey;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EndpointMoid"))
            {
                initObject.EndpointMoid = this.EndpointMoid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Header"))
            {
                initObject.Header = this.Header;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Internal"))
            {
                initObject.Internal = this.Internal;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Method"))
            {
                initObject.Method = this.Method;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("SecureProperties"))
            {
                initObject.SecureProperties = this.SecureProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Timeout"))
            {
                initObject.Timeout = this.Timeout;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Url"))
            {
                initObject.Url = this.Url;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ConnectorSshMessage.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightConnectorSshMessage")]
    public class InitializeIntersightConnectorSshMessage : PSCmdlet
    {
        public InitializeIntersightConnectorSshMessage()
        {
            ClassId = ConnectorSshMessage.ClassIdEnum.ConnectorSshMessage;
            ObjectType = ConnectorSshMessage.ObjectTypeEnum.ConnectorSshMessage;

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

        public ConnectorSshMessage.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The secure properties that have large text content as value can be encrypted using AES key. In these cases, the AES key needs to be encrypted using the device connector public key and passed as the value for this property.\nThe secure properties that are encrypted using the AES key are mapped against the property name with prefix 'AES' in SecureProperties dictionary."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string EncryptedAesKey
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The public key that was used to encrypt the values present in SecureProperties dictionary.\nIf the given public key is not same as device connector's public key, an error reponse with appropriate error message is thrown back."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string EncryptionKey
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.ConnectorExpectPrompt> ExpectPrompts
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The operation to execute on a new or existing session."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long MsgType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ConnectorSshMessage.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A dictionary of encrypted secure values mapped against the secure property name. The values that are encrypted using AES key must be mapped against the secure property name with a 'AES' prefix\nDevice connector expects the message body to be a golang template and the template can use the secure property names as placeholders."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object SecureProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Unique id of session to route messages to."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SessionId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The regex of the secure shell prompt."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ShellPrompt
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Input to the SSH operation to be executed. e.g. file contents to write."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public byte[] Stream
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The timeout for the ssh command to complete and exit after starting or receiving input. If timeout is not set a default of 10 minutes will be used."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Timeout
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.ConnectorSshMessage initObject = new Intersight.Model.ConnectorSshMessage();
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
            if (this.MyInvocation.BoundParameters.ContainsKey("ExpectPrompts"))
            {
                initObject.ExpectPrompts = this.ExpectPrompts;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MsgType"))
            {
                initObject.MsgType = this.MsgType;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("SecureProperties"))
            {
                initObject.SecureProperties = this.SecureProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SessionId"))
            {
                initObject.SessionId = this.SessionId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ShellPrompt"))
            {
                initObject.ShellPrompt = this.ShellPrompt;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Stream"))
            {
                initObject.Stream = this.Stream;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Timeout"))
            {
                initObject.Timeout = this.Timeout;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ConnectorXmlApiMessage.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightConnectorXmlApiMessage")]
    public class InitializeIntersightConnectorXmlApiMessage : PSCmdlet
    {
        public InitializeIntersightConnectorXmlApiMessage()
        {
            ClassId = ConnectorXmlApiMessage.ClassIdEnum.ConnectorXmlApiMessage;
            ObjectType = ConnectorXmlApiMessage.ObjectTypeEnum.ConnectorXmlApiMessage;

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

        public ConnectorXmlApiMessage.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The secure properties that have large text content as value can be encrypted using AES key. In these cases, the AES key needs to be encrypted using the device connector public key and passed as the value for this property.\nThe secure properties that are encrypted using the AES key are mapped against the property name with prefix 'AES' in SecureProperties dictionary."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string EncryptedAesKey
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The public key that was used to encrypt the values present in SecureProperties dictionary.\nIf the given public key is not same as device connector's public key, an error reponse with appropriate error message is thrown back."</para>
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

        public ConnectorXmlApiMessage.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The platform locale to assign user. A locale defines one or more organizations (domains) the user is allowed access, and access is limited to the organizations specified in the locale."</para>
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
        /// <para type="description">"The session Id passed to the platform for use in platforms auditing."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string RemoteUserSessionId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A dictionary of encrypted secure values mapped against the secure property name. The values that are encrypted using AES key must be mapped against the secure property name with a 'AES' prefix\nDevice connector expects the message body to be a golang template and the template can use the secure property names as placeholders."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object SecureProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Flag to disable authentication bypassing. If set to true it is expected a valid cookie/login is provided within the XML API request body."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool WithAuth
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The XML request body to proxy to the platform."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string XmlRequest
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.ConnectorXmlApiMessage initObject = new Intersight.Model.ConnectorXmlApiMessage();
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
            if (this.MyInvocation.BoundParameters.ContainsKey("WithAuth"))
            {
                initObject.WithAuth = this.WithAuth;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("XmlRequest"))
            {
                initObject.XmlRequest = this.XmlRequest;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ConnectorStartStreamFromDevice.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightConnectorStartStreamFromDevice")]
    public class InitializeIntersightConnectorStartStreamFromDevice : PSCmdlet
    {
        public InitializeIntersightConnectorStartStreamFromDevice()
        {
            ClassId = ConnectorStartStreamFromDevice.ClassIdEnum.ConnectorStartStreamFromDevice;
            ObjectType = ConnectorStartStreamFromDevice.ObjectTypeEnum.ConnectorStartStreamFromDevice;

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

        public ConnectorStartStreamFromDevice.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The secure properties that have large text content as value can be encrypted using AES key. In these cases, the AES key needs to be encrypted using the device connector public key and passed as the value for this property.\nThe secure properties that are encrypted using the AES key are mapped against the property name with prefix 'AES' in SecureProperties dictionary."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string EncryptedAesKey
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The public key that was used to encrypt the values present in SecureProperties dictionary.\nIf the given public key is not same as device connector's public key, an error reponse with appropriate error message is thrown back."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string EncryptionKey
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The asset.ClusterMember member identity that is opening this stream."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string MemberId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The stream is to be started against the cluster member."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool MemberStream
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ConnectorStartStreamFromDevice.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A dictionary of encrypted secure values mapped against the secure property name. The values that are encrypted using AES key must be mapped against the secure property name with a 'AES' prefix\nDevice connector expects the message body to be a golang template and the template can use the secure property names as placeholders."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object SecureProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Any extra configuration needed to open/identify a stream."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object StreamConfig
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The requested stream name. Stream names are unique per device endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string StreamName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Identifies the type of stream to open to the device. The Intersight service will validate that the device should open a stream of this type and if so build a stream configuration and send it down to the device. The streamType should identify a unique stream to open to a device, that is if the device sends a stream open message and a stream of that type is already open in the cloud the existing stream should be re-used."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string StreamType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The topic the device should send the stream open message to."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Topic
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.ConnectorStartStreamFromDevice initObject = new Intersight.Model.ConnectorStartStreamFromDevice();
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
            if (this.MyInvocation.BoundParameters.ContainsKey("MemberId"))
            {
                initObject.MemberId = this.MemberId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MemberStream"))
            {
                initObject.MemberStream = this.MemberStream;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("SecureProperties"))
            {
                initObject.SecureProperties = this.SecureProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("StreamConfig"))
            {
                initObject.StreamConfig = this.StreamConfig;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("StreamName"))
            {
                initObject.StreamName = this.StreamName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("StreamType"))
            {
                initObject.StreamType = this.StreamType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Topic"))
            {
                initObject.Topic = this.Topic;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ConnectorStreamInput.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightConnectorStreamInput")]
    public class InitializeIntersightConnectorStreamInput : PSCmdlet
    {
        public InitializeIntersightConnectorStreamInput()
        {
            ClassId = ConnectorStreamInput.ClassIdEnum.ConnectorStreamInput;
            ObjectType = ConnectorStreamInput.ObjectTypeEnum.ConnectorStreamInput;

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

        public ConnectorStreamInput.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The secure properties that have large text content as value can be encrypted using AES key. In these cases, the AES key needs to be encrypted using the device connector public key and passed as the value for this property.\nThe secure properties that are encrypted using the AES key are mapped against the property name with prefix 'AES' in SecureProperties dictionary."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string EncryptedAesKey
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The public key that was used to encrypt the values present in SecureProperties dictionary.\nIf the given public key is not same as device connector's public key, an error reponse with appropriate error message is thrown back."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string EncryptionKey
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The input to write to the stream plugin."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public byte[] Input
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ConnectorStreamInput.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A dictionary of encrypted secure values mapped against the secure property name. The values that are encrypted using AES key must be mapped against the secure property name with a 'AES' prefix\nDevice connector expects the message body to be a golang template and the template can use the secure property names as placeholders."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object SecureProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The requested stream name. Stream names are unique per device endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string StreamName
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.ConnectorStreamInput initObject = new Intersight.Model.ConnectorStreamInput();
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Input"))
            {
                initObject.Input = this.Input;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("SecureProperties"))
            {
                initObject.SecureProperties = this.SecureProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("StreamName"))
            {
                initObject.StreamName = this.StreamName;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ConnectorStartStream.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightConnectorStartStream")]
    public class InitializeIntersightConnectorStartStream : PSCmdlet
    {
        public InitializeIntersightConnectorStartStream()
        {
            ClassId = ConnectorStartStream.ClassIdEnum.ConnectorStartStream;
            ObjectType = ConnectorStartStream.ObjectTypeEnum.ConnectorStartStream;

        }
        // <summary>
        /// <para type="description">"The number of messages the service will process before sending an acknowledgment to the device. Device will expect an acknowledgment after this number of messages before sending further output. Before receiving the acknowledgment the stream will be in a paused state with messages accumulating and deduplicated if possible. A zero value indicates device should not wait on cloud acknowledgment to send updates."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long AckRate
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
        /// <para type="description">"The number of outputs from a plugin to collect into a single message. Applicable only to streams that involve polling plugins and plugins which support emitting batchable data. Default value of zero indicates no batching."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long BatchSize
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ConnectorStartStream.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The secure properties that have large text content as value can be encrypted using AES key. In these cases, the AES key needs to be encrypted using the device connector public key and passed as the value for this property.\nThe secure properties that are encrypted using the AES key are mapped against the property name with prefix 'AES' in SecureProperties dictionary."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string EncryptedAesKey
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The public key that was used to encrypt the values present in SecureProperties dictionary.\nIf the given public key is not same as device connector's public key, an error reponse with appropriate error message is thrown back."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string EncryptionKey
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Flag to force a rebuild of an existing stream. To be used if a stream is unable to recover itself in response to dropped messages."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool ForceRebuild
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Input to the plugin to start the start the stream or collect stream messages."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public byte[] Input
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Interval at which device should emit a keepalive message for this stream. Device will also expect a keepalive response from the cloud within the interval. If zero, no keepalive is required and stream should not timeout."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long KeepAliveInterval
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ConnectorStartStream.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The plugin to run the stream on."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string PluginName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The desired interval to emit messages from this stream. The stream plugin will poll plugins at this interval to create a stream event."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long PollInterval
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The priority level to apply to messages emitted by this stream."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Priority
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The version of the device connector stream protocol. Used to change behavior of the device connector stream plugin based on the version of the Intersight service. Allows for multiple versions of Intersight services to interact with the stream plugin of devices."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long ProtocolVersion
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The topic for the device connector to publish messages to."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ResponseTopic
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A dictionary of encrypted secure values mapped against the secure property name. The values that are encrypted using AES key must be mapped against the secure property name with a 'AES' prefix\nDevice connector expects the message body to be a golang template and the template can use the secure property names as placeholders."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object SecureProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The requested stream name. Stream names are unique per device endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string StreamName
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.ConnectorStartStream initObject = new Intersight.Model.ConnectorStartStream();
            if (this.MyInvocation.BoundParameters.ContainsKey("AckRate"))
            {
                initObject.AckRate = this.AckRate;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BatchSize"))
            {
                initObject.BatchSize = this.BatchSize;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("ForceRebuild"))
            {
                initObject.ForceRebuild = this.ForceRebuild;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Input"))
            {
                initObject.Input = this.Input;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("KeepAliveInterval"))
            {
                initObject.KeepAliveInterval = this.KeepAliveInterval;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("PluginName"))
            {
                initObject.PluginName = this.PluginName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PollInterval"))
            {
                initObject.PollInterval = this.PollInterval;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Priority"))
            {
                initObject.Priority = this.Priority;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ProtocolVersion"))
            {
                initObject.ProtocolVersion = this.ProtocolVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ResponseTopic"))
            {
                initObject.ResponseTopic = this.ResponseTopic;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SecureProperties"))
            {
                initObject.SecureProperties = this.SecureProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("StreamName"))
            {
                initObject.StreamName = this.StreamName;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ConnectorStreamKeepalive.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightConnectorStreamKeepalive")]
    public class InitializeIntersightConnectorStreamKeepalive : PSCmdlet
    {
        public InitializeIntersightConnectorStreamKeepalive()
        {
            ClassId = ConnectorStreamKeepalive.ClassIdEnum.ConnectorStreamKeepalive;
            ObjectType = ConnectorStreamKeepalive.ObjectTypeEnum.ConnectorStreamKeepalive;

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

        public ConnectorStreamKeepalive.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The secure properties that have large text content as value can be encrypted using AES key. In these cases, the AES key needs to be encrypted using the device connector public key and passed as the value for this property.\nThe secure properties that are encrypted using the AES key are mapped against the property name with prefix 'AES' in SecureProperties dictionary."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string EncryptedAesKey
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The public key that was used to encrypt the values present in SecureProperties dictionary.\nIf the given public key is not same as device connector's public key, an error reponse with appropriate error message is thrown back."</para>
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

        public ConnectorStreamKeepalive.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Stream has been paused and is not actively sending outputs to cloud. Device will pause streams when it does not receive an acknowledgment of messages after sending number messages cloud has configured in the stream acknowledge rate (set in StartStream.ackRate field on stream start). If cloud receives a keepalive messages with paused set it will attempt to acknowledge the latest messages processed from the device in order to unpause the stream."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Paused
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A dictionary of encrypted secure values mapped against the secure property name. The values that are encrypted using AES key must be mapped against the secure property name with a 'AES' prefix\nDevice connector expects the message body to be a golang template and the template can use the secure property names as placeholders."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object SecureProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The requested stream name. Stream names are unique per device endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string StreamName
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.ConnectorStreamKeepalive initObject = new Intersight.Model.ConnectorStreamKeepalive();
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Paused"))
            {
                initObject.Paused = this.Paused;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SecureProperties"))
            {
                initObject.SecureProperties = this.SecureProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("StreamName"))
            {
                initObject.StreamName = this.StreamName;
            }
            WriteObject(initObject);
        }

    }
}