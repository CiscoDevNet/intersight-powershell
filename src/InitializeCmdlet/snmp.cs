using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize SnmpTrap.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightSnmpTrap")]
    public class InitializeIntersightSnmpTrap:PSCmdlet
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public SnmpTrap.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"SNMP community group used for sending SNMP trap to other devices. Applicable only for SNMP v2c."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Community {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Address to which the SNMP trap information is sent."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Destination {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Enables/disables the trap on the server If enabled, trap is active on the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Enabled {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public SnmpTrap.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Port used by the server to communicate with the trap destination. Enter a value between 1-65535. Reserved ports not allowed (22, 23, 80, 123, 389, 443, 623, 636, 2068, 3268, 3269)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1, 65535)]
        public long Port {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of trap which decides whether to receive a notification when a trap is received at the destination.\n* `Trap` - Do not receive notifications when trap is sent to the destination.\n* `Inform` - Receive notifications when trap is sent to the destination. This option is valid only for V2 users."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public SnmpTrap.TypeEnum Type {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"SNMP user for the trap. Applicable only to SNMPv3."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string User {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"SNMP version used for the trap.\n* `V3` - SNMP v3 trap version notifications.\n* `V2` - SNMP v2 trap version notifications."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public SnmpTrap.VersionEnum Version {
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
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize SnmpUser.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightSnmpUser")]
    public class InitializeIntersightSnmpUser:PSCmdlet
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Authorization password for the user."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string AuthPassword {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Authorization protocol for authenticating the user.\n* `NA` - Authentication protocol is not applicable.\n* `MD5` - MD5 protocol is used to authenticate SNMP user.\n* `SHA` - SHA protocol is used to authenticate SNMP user.\n* `SHA-224` - SHA-224 protocol is used to authenticate SNMP user.\n* `SHA-256` - SHA-256 protocol is used to authenticate SNMP user.\n* `SHA-384` - SHA-384 protocol is used to authenticate SNMP user.\n* `SHA-512` - SHA-512 protocol is used to authenticate SNMP user."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public SnmpUser.AuthTypeEnum AuthType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public SnmpUser.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"SNMP username. Must have a minimum of 1 and and a maximum of 31 characters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public SnmpUser.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Privacy password for the user."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string PrivacyPassword {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Privacy protocol for the user.\n* `NA` - Privacy protocol is not applicable.\n* `DES` - DES privacy protocol is used for SNMP user.\n* `AES` - AES privacy protocol is used for SNMP user."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public SnmpUser.PrivacyTypeEnum PrivacyType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Security mechanism used for communication between agent and manager.\n* `AuthPriv` - The user requires both an authorization password and a privacy password.\n* `NoAuthNoPriv` - The user does not require an authorization or privacy password.\n* `AuthNoPriv` - The user requires an authorization password but not a privacy password."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public SnmpUser.SecurityLevelEnum SecurityLevel {
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
}