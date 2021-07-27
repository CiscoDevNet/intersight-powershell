using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NtpAuthNtpServer.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNtpAuthNtpServer")]
    public class InitializeIntersightNtpAuthNtpServer:PSCmdlet
	{
		public InitializeIntersightNtpAuthNtpServer()
		{
            ClassId = NtpAuthNtpServer.ClassIdEnum.NtpAuthNtpServer;
            KeyType = NtpAuthNtpServer.KeyTypeEnum.SHA1;
            ObjectType = NtpAuthNtpServer.ObjectTypeEnum.NtpAuthNtpServer;
            
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
        
        public NtpAuthNtpServer.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of symmetric key to use for this server.\n* `SHA1` - Key type used by the authentication is SHA1."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NtpAuthNtpServer.KeyTypeEnum KeyType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NtpAuthNtpServer.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Server hostname or IP address."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ServerName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The key ID is a positive integer that identifies a cryptographic key used to authenticate NTP messages."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long SymKeyId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The value of the symmetric key."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SymKeyValue {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.NtpAuthNtpServer initObject = new Intersight.Model.NtpAuthNtpServer();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("KeyType"))
            {
                initObject.KeyType = this.KeyType;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("ServerName"))
            {
                initObject.ServerName = this.ServerName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SymKeyId"))
            {
                initObject.SymKeyId = this.SymKeyId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SymKeyValue"))
            {
                initObject.SymKeyValue = this.SymKeyValue;
            }
            WriteObject(initObject);
        }

    }
}