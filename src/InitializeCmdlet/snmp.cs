using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize SnmpPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightSnmpPolicy")]
    public class InitializeIntersightSnmpPolicy : PSCmdlet
    {
        public InitializeIntersightSnmpPolicy()
        {
            ClassId = SnmpPolicy.ClassIdEnum.SnmpPolicy;
            CommunityAccess = SnmpPolicy.CommunityAccessEnum.Disabled;
            ObjectType = SnmpPolicy.ObjectTypeEnum.SnmpPolicy;

        }
        // <summary>
        /// <para type="description">"The default SNMPv1, SNMPv2c community name or SNMPv3 username to include on any trap messages sent to the SNMP host. The name can be 18 characters long."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string AccessCommunityString
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

        public SnmpPolicy.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Controls access to the information in the inventory tables. Applicable only for SNMPv1 and SNMPv2c users.\n* `Disabled` - Blocks access to the information in the inventory tables.\n* `Limited` - Partial access to read the information in the inventory tables.\n* `Full` - Full access to read the information in the inventory tables."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public SnmpPolicy.CommunityAccessEnum CommunityAccess
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
        /// <para type="description">"State of the SNMP Policy on the endpoint. If enabled, the endpoint sends SNMP traps to the designated host."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Enabled
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"User-defined unique identification of the static engine."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[^#!&]*$")]
        public string EngineId
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

        public SnmpPolicy.ObjectTypeEnum ObjectType
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
        /// <para type="description">"Port on which Cisco IMC SNMP agent runs. Enter a value between 1-65535. Reserved ports not allowed (22, 23, 80, 123, 389, 443, 623, 636, 2068, 3268, 3269)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 65535)]
        public long SnmpPort
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.SnmpTrap> SnmpTraps
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.SnmpUser> SnmpUsers
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Contact person responsible for the SNMP implementation. Enter a string up to 64 characters, such as an email address or a name and telephone number."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SysContact
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Location of host on which the SNMP agent (server) runs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SysLocation
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
        /// <para type="description">"SNMP community group used for sending SNMP trap to other devices. Valid only for SNMPv2c users."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string TrapCommunity
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"State of the SNMP v2c on the endpoint. If enabled, the endpoint sends SNMP v2c properties to the designated host."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool V2Enabled
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"State of the SNMP v3 on the endpoint. If enabled, the endpoint sends SNMP v3 properties to the designated host."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool V3Enabled
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.SnmpPolicy initObject = new Intersight.Model.SnmpPolicy();
            if (this.MyInvocation.BoundParameters.ContainsKey("AccessCommunityString"))
            {
                initObject.AccessCommunityString = this.AccessCommunityString;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("CommunityAccess"))
            {
                initObject.CommunityAccess = this.CommunityAccess;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Enabled"))
            {
                initObject.Enabled = this.Enabled;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EngineId"))
            {
                initObject.EngineId = this.EngineId;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("SnmpPort"))
            {
                initObject.SnmpPort = this.SnmpPort;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SnmpTraps"))
            {
                initObject.SnmpTraps = this.SnmpTraps;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SnmpUsers"))
            {
                initObject.SnmpUsers = this.SnmpUsers;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SysContact"))
            {
                initObject.SysContact = this.SysContact;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SysLocation"))
            {
                initObject.SysLocation = this.SysLocation;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TrapCommunity"))
            {
                initObject.TrapCommunity = this.TrapCommunity;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("V2Enabled"))
            {
                initObject.V2Enabled = this.V2Enabled;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("V3Enabled"))
            {
                initObject.V3Enabled = this.V3Enabled;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize SnmpUser.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightSnmpUser")]
    public class InitializeIntersightSnmpUser : PSCmdlet
    {
        public InitializeIntersightSnmpUser()
        {
            AuthType = SnmpUser.AuthTypeEnum.NA;
            ClassId = SnmpUser.ClassIdEnum.SnmpUser;
            ObjectType = SnmpUser.ObjectTypeEnum.SnmpUser;
            PrivacyType = SnmpUser.PrivacyTypeEnum.NA;
            SecurityLevel = SnmpUser.SecurityLevelEnum.AuthPriv;

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
        /// <para type="description">"Authorization password for the user."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string AuthPassword
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Authorization protocol for authenticating the user.\n* `NA` - Authentication protocol is not applicable.\n* `MD5` - MD5 protocol is used to authenticate SNMP user.\n* `SHA` - SHA protocol is used to authenticate SNMP user.\n* `SHA-224` - SHA-224 protocol is used to authenticate SNMP user.\n* `SHA-256` - SHA-256 protocol is used to authenticate SNMP user.\n* `SHA-384` - SHA-384 protocol is used to authenticate SNMP user.\n* `SHA-512` - SHA-512 protocol is used to authenticate SNMP user."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public SnmpUser.AuthTypeEnum AuthType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public SnmpUser.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"SNMP username. Must have a minimum of 1 and and a maximum of 31 characters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public SnmpUser.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Privacy password for the user."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string PrivacyPassword
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Privacy protocol for the user.\n* `NA` - Privacy protocol is not applicable.\n* `DES` - DES privacy protocol is used for SNMP user.\n* `AES` - AES privacy protocol is used for SNMP user."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public SnmpUser.PrivacyTypeEnum PrivacyType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Security mechanism used for communication between agent and manager.\n* `AuthPriv` - The user requires both an authorization password and a privacy password.\n* `NoAuthNoPriv` - The user does not require an authorization or privacy password.\n* `AuthNoPriv` - The user requires an authorization password but not a privacy password."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public SnmpUser.SecurityLevelEnum SecurityLevel
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.SnmpUser initObject = new Intersight.Model.SnmpUser();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AuthPassword"))
            {
                initObject.AuthPassword = this.AuthPassword;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AuthType"))
            {
                initObject.AuthType = this.AuthType;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("PrivacyPassword"))
            {
                initObject.PrivacyPassword = this.PrivacyPassword;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PrivacyType"))
            {
                initObject.PrivacyType = this.PrivacyType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SecurityLevel"))
            {
                initObject.SecurityLevel = this.SecurityLevel;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize SnmpTrap.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightSnmpTrap")]
    public class InitializeIntersightSnmpTrap : PSCmdlet
    {
        public InitializeIntersightSnmpTrap()
        {
            ClassId = SnmpTrap.ClassIdEnum.SnmpTrap;
            ObjectType = SnmpTrap.ObjectTypeEnum.SnmpTrap;
            Type = SnmpTrap.TypeEnum.Trap;
            Version = SnmpTrap.VersionEnum.V3;

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

        public SnmpTrap.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"SNMP community group used for sending SNMP trap to other devices. Applicable only for SNMP v2c."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Community
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Address to which the SNMP trap information is sent."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Destination
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Enables/disables the trap on the server If enabled, trap is active on the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Enabled
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public SnmpTrap.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Port used by the server to communicate with the trap destination. Enter a value between 1-65535. Reserved ports not allowed (22, 23, 80, 123, 389, 443, 623, 636, 2068, 3268, 3269)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 65535)]
        public long Port
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of trap which decides whether to receive a notification when a trap is received at the destination.\n* `Trap` - Do not receive notifications when trap is sent to the destination.\n* `Inform` - Receive notifications when trap is sent to the destination. This option is valid only for V2 users."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public SnmpTrap.TypeEnum Type
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"SNMP user for the trap. Applicable only to SNMPv3."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string User
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"SNMP version used for the trap.\n* `V3` - SNMP v3 trap version notifications.\n* `V2` - SNMP v2 trap version notifications."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public SnmpTrap.VersionEnum Version
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.SnmpTrap initObject = new Intersight.Model.SnmpTrap();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Community"))
            {
                initObject.Community = this.Community;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Destination"))
            {
                initObject.Destination = this.Destination;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Enabled"))
            {
                initObject.Enabled = this.Enabled;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Port"))
            {
                initObject.Port = this.Port;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Type"))
            {
                initObject.Type = this.Type;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("User"))
            {
                initObject.User = this.User;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Version"))
            {
                initObject._Version = this.Version;
            }
            WriteObject(initObject);
        }

    }
}