using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize SyslogLocalClientBase.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightSyslogLocalClientBase")]
    public class InitializeIntersightSyslogLocalClientBase:PSCmdlet
	{
		public InitializeIntersightSyslogLocalClientBase()
		{
            ClassId = SyslogLocalClientBase.ClassIdEnum.SyslogLocalFileLoggingClient;
            MinSeverity = SyslogLocalClientBase.MinSeverityEnum.Warning;
            ObjectType = SyslogLocalClientBase.ObjectTypeEnum.SyslogLocalFileLoggingClient;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public SyslogLocalClientBase.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Lowest level of messages to be included in the local log.\n* `warning` - Use logging level warning for logs classified as warning.\n* `emergency` - Use logging level emergency for logs classified as emergency.\n* `alert` - Use logging level alert for logs classified as alert.\n* `critical` - Use logging level critical for logs classified as critical.\n* `error` - Use logging level error for logs classified as error.\n* `notice` - Use logging level notice for logs classified as notice.\n* `informational` - Use logging level informational for logs classified as informational.\n* `debug` - Use logging level debug for logs classified as debug."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public SyslogLocalClientBase.MinSeverityEnum MinSeverity {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public SyslogLocalClientBase.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.SyslogLocalClientBase initObject = new Intersight.Model.SyslogLocalClientBase();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("MinSeverity"))
            {
                initObject.MinSeverity = this.MinSeverity;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize SyslogRemoteLoggingClient.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightSyslogRemoteLoggingClient")]
    public class InitializeIntersightSyslogRemoteLoggingClient:PSCmdlet
	{
		public InitializeIntersightSyslogRemoteLoggingClient()
		{
            ClassId = SyslogRemoteLoggingClient.ClassIdEnum.SyslogRemoteLoggingClient;
            MinSeverity = SyslogRemoteLoggingClient.MinSeverityEnum.Warning;
            ObjectType = SyslogRemoteLoggingClient.ObjectTypeEnum.SyslogRemoteLoggingClient;
            Protocol = SyslogRemoteLoggingClient.ProtocolEnum.Udp;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public SyslogRemoteLoggingClient.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Enables/disables remote logging for the endpoint If enabled, log messages will be sent to the syslog server mentioned in the Hostname/IP Address field."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Enabled {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Hostname or IP Address of the syslog server where log should be stored."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Hostname {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Lowest level of messages to be included in the remote log.\n* `warning` - Use logging level warning for logs classified as warning.\n* `emergency` - Use logging level emergency for logs classified as emergency.\n* `alert` - Use logging level alert for logs classified as alert.\n* `critical` - Use logging level critical for logs classified as critical.\n* `error` - Use logging level error for logs classified as error.\n* `notice` - Use logging level notice for logs classified as notice.\n* `informational` - Use logging level informational for logs classified as informational.\n* `debug` - Use logging level debug for logs classified as debug."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public SyslogRemoteLoggingClient.MinSeverityEnum MinSeverity {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public SyslogRemoteLoggingClient.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Port number used for logging on syslog server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1, 65535)]
        public long Port {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Transport layer protocol for transmission of log messages to syslog server.\n* `udp` - Use User Datagram Protocol (UDP) for syslog remote server connection.\n* `tcp` - Use Transmission Control Protocol (TCP) for syslog remote server connection."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public SyslogRemoteLoggingClient.ProtocolEnum Protocol {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.SyslogRemoteLoggingClient initObject = new Intersight.Model.SyslogRemoteLoggingClient();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Enabled"))
            {
                initObject.Enabled = this.Enabled;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Hostname"))
            {
                initObject.Hostname = this.Hostname;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MinSeverity"))
            {
                initObject.MinSeverity = this.MinSeverity;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Port"))
            {
                initObject.Port = this.Port;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Protocol"))
            {
                initObject.Protocol = this.Protocol;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize SyslogRemoteClientBase.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightSyslogRemoteClientBase")]
    public class InitializeIntersightSyslogRemoteClientBase:PSCmdlet
	{
		public InitializeIntersightSyslogRemoteClientBase()
		{
            ClassId = SyslogRemoteClientBase.ClassIdEnum.SyslogRemoteLoggingClient;
            MinSeverity = SyslogRemoteClientBase.MinSeverityEnum.Warning;
            ObjectType = SyslogRemoteClientBase.ObjectTypeEnum.SyslogRemoteLoggingClient;
            Protocol = SyslogRemoteClientBase.ProtocolEnum.Udp;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public SyslogRemoteClientBase.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Enables/disables remote logging for the endpoint If enabled, log messages will be sent to the syslog server mentioned in the Hostname/IP Address field."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Enabled {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Hostname or IP Address of the syslog server where log should be stored."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Hostname {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Lowest level of messages to be included in the remote log.\n* `warning` - Use logging level warning for logs classified as warning.\n* `emergency` - Use logging level emergency for logs classified as emergency.\n* `alert` - Use logging level alert for logs classified as alert.\n* `critical` - Use logging level critical for logs classified as critical.\n* `error` - Use logging level error for logs classified as error.\n* `notice` - Use logging level notice for logs classified as notice.\n* `informational` - Use logging level informational for logs classified as informational.\n* `debug` - Use logging level debug for logs classified as debug."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public SyslogRemoteClientBase.MinSeverityEnum MinSeverity {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public SyslogRemoteClientBase.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Port number used for logging on syslog server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1, 65535)]
        public long Port {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Transport layer protocol for transmission of log messages to syslog server.\n* `udp` - Use User Datagram Protocol (UDP) for syslog remote server connection.\n* `tcp` - Use Transmission Control Protocol (TCP) for syslog remote server connection."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public SyslogRemoteClientBase.ProtocolEnum Protocol {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.SyslogRemoteClientBase initObject = new Intersight.Model.SyslogRemoteClientBase();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Enabled"))
            {
                initObject.Enabled = this.Enabled;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Hostname"))
            {
                initObject.Hostname = this.Hostname;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MinSeverity"))
            {
                initObject.MinSeverity = this.MinSeverity;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Port"))
            {
                initObject.Port = this.Port;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Protocol"))
            {
                initObject.Protocol = this.Protocol;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize SyslogLocalFileLoggingClient.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightSyslogLocalFileLoggingClient")]
    public class InitializeIntersightSyslogLocalFileLoggingClient:PSCmdlet
	{
		public InitializeIntersightSyslogLocalFileLoggingClient()
		{
            ClassId = SyslogLocalFileLoggingClient.ClassIdEnum.SyslogLocalFileLoggingClient;
            MinSeverity = SyslogLocalFileLoggingClient.MinSeverityEnum.Warning;
            ObjectType = SyslogLocalFileLoggingClient.ObjectTypeEnum.SyslogLocalFileLoggingClient;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public SyslogLocalFileLoggingClient.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Lowest level of messages to be included in the local log.\n* `warning` - Use logging level warning for logs classified as warning.\n* `emergency` - Use logging level emergency for logs classified as emergency.\n* `alert` - Use logging level alert for logs classified as alert.\n* `critical` - Use logging level critical for logs classified as critical.\n* `error` - Use logging level error for logs classified as error.\n* `notice` - Use logging level notice for logs classified as notice.\n* `informational` - Use logging level informational for logs classified as informational.\n* `debug` - Use logging level debug for logs classified as debug."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public SyslogLocalFileLoggingClient.MinSeverityEnum MinSeverity {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public SyslogLocalFileLoggingClient.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.SyslogLocalFileLoggingClient initObject = new Intersight.Model.SyslogLocalFileLoggingClient();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("MinSeverity"))
            {
                initObject.MinSeverity = this.MinSeverity;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
}