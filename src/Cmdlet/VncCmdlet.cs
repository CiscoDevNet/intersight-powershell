using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get VncConsole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightVncConsole", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightVncConsole:GetCmdletBase
	{
		public GetIntersightVncConsole()
		{
			ApiInstance = new VncApi(Config);
            MethodName = "GetVncConsoleListWithHttpInfo";
		}
        
        // <summary>
        /// <para type="description">"The Account ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        
        public string AccountMoid {
            get;
            set;
        }
        
        
        
        // <summary>
        /// <para type="description">"The user agent IP address from which the session is launched."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        
        public string ClientIpAddress {
            get;
            set;
        }
        
        // <summary>
        /// <para type="description">"The multiplexer URL for the client to connect on."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        
        public string ClientUrl {
            get;
            set;
        }
        
        // <summary>
        /// <para type="description">"The time when this managed object was created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        
        public DateTime CreateTime {
            get;
            set;
        }
        
        // <summary>
        /// <para type="description">"The DomainGroup ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        
        public string DomainGroupMoid {
            get;
            set;
        }
        
        // <summary>
        /// <para type="description">"The time at which the session ended."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        
        public DateTime EndTime {
            get;
            set;
        }
        
        // <summary>
        /// <para type="description">"The time when this managed object was last modified."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        
        public DateTime ModTime {
            get;
            set;
        }
        
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        
        public string Moid {
            get;
            set;
        }
        
        
        // <summary>
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false,ValueFromPipeline = true, ParameterSetName = "CmdletParam")]
        
        public MoBaseMoRelationship Parent {
            get;
            set;
        }
        
        
        // <summary>
        /// <para type="description">"Role of the user who launched the session."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        
        public string Role {
            get;
            set;
        }
        
        // <summary>
        /// <para type="description">"A reference to a sessionAbstractSession resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = true, ParameterSetName = "CmdletParam")]
        
        public SessionAbstractSessionRelationship Session {
            get;
            set;
        }
        
        // <summary>
        /// <para type="description">"Intersight provides pre-built workflows, tasks and policies to end users through global catalogs.\nObjects that are made available through global catalogs are said to have a 'shared' ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        
        public string SharedScope {
            get;
            set;
        }
        
        // <summary>
        /// <para type="description">"The status of the session.\n* `Active` - The session is currently active.\n* `Ended` - The session has ended normally.\n* `Terminated` - The session was terminated by an admin."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        
        public VncConsole.StatusEnum Status {
            get;
            set;
        }
        
        
        // <summary>
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = true, ParameterSetName = "CmdletParam")]
        
        public MoBaseMoRelationship Target {
            get;
            set;
        }
        
        // <summary>
        /// <para type="description">"Name of target on which session is initiated."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        
        public string TargetName {
            get;
            set;
        }
        
        // <summary>
        /// <para type="description">"A reference to a iamUser resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = true, ParameterSetName = "CmdletParam")]
        
        public IamUserRelationship User {
            get;
            set;
        }
        
        // <summary>
        /// <para type="description">"User ID or E-mail Address of the user who launched the session."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        
        public string UserIdOrEmail {
            get;
            set;
        }
        
        
        // <summary>
        /// <para type="description">"A reference to a virtualizationIweVirtualMachine resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = true, ParameterSetName = "CmdletParam")]
        
        public VirtualizationIweVirtualMachineRelationship VirtualMachine {
            get;
            set;
        }

        
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New VncConsole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightVncConsole")]
    public class NewIntersightVncConsole:NewCmdletBase
	{
		public NewIntersightVncConsole()
		{
			ApiInstance = new VncApi(Config);
            ModelObject = new VncConsole();
            MethodName = "CreateVncConsoleWithHttpInfo";
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
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        
        
        
        
        
        
        
        // <summary>
        /// <para type="description">"The status of the session.\n* `Active` - The session is currently active.\n* `Ended` - The session has ended normally.\n* `Terminated` - The session was terminated by an admin."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VncConsole.StatusEnum Status {
            get;
            set;
        }
        
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
        
        
        
        
        
        
        // <summary>
        /// <para type="description">"A reference to a virtualizationIweVirtualMachine resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationIweVirtualMachineRelationship VirtualMachine {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set VncConsole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightVncConsole")]
    public class SetIntersightVncConsole:SetCmdletBase
	{
		public SetIntersightVncConsole()
		{
			ApiInstance = new VncApi(Config);
            ModelObject = new VncConsole();
            MethodName = "UpdateVncConsoleWithHttpInfo";
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
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        
        
        
        
        
        
        
        // <summary>
        /// <para type="description">"The status of the session.\n* `Active` - The session is currently active.\n* `Ended` - The session has ended normally.\n* `Terminated` - The session was terminated by an admin."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VncConsole.StatusEnum Status {
            get;
            set;
        }
        
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
        
        
        
        
        
        
        // <summary>
        /// <para type="description">"A reference to a virtualizationIweVirtualMachine resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationIweVirtualMachineRelationship VirtualMachine {
            get;
            set;
        }
    }
}