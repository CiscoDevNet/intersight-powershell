using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get KvmTunnel.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightKvmTunnel", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightKvmTunnel:GetCmdletBase
	{
		public GetIntersightKvmTunnel()
		{
			ApiInstance = new KvmApi(Config);
            MethodName = "GetKvmTunnelListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New KvmTunnel.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightKvmTunnel")]
    public class NewIntersightKvmTunnel:NewCmdletBase
	{
		public NewIntersightKvmTunnel()
		{
			ApiInstance = new KvmApi(Config);
            ModelObject = new KvmTunnel();
            MethodName = "CreateKvmTunnelWithHttpInfo";
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
        /// <para type="description">"A reference to a kvmSession resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public KvmSessionRelationship KvmSession {
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
        /// <para type="description">"A reference to a computePhysical resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ComputePhysicalRelationship Server {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The status of the session.\n* `Active` - The session is currently active.\n* `Ended` - The session has ended normally.\n* `Terminated` - The session was terminated by an admin."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public KvmTunnel.StatusEnum Status {
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
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New KvmSession.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightKvmSession")]
    public class NewIntersightKvmSession:NewCmdletBase
	{
		public NewIntersightKvmSession()
		{
			ApiInstance = new KvmApi(Config);
            ModelObject = new KvmSession();
            MethodName = "CreateKvmSessionWithHttpInfo";
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
        /// <para type="description">"Temporary one-time password for vKVM access."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string OneTimePassword {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a computePhysical resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ComputePhysicalRelationship Server {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The status of the session.\n* `Active` - The session is currently active.\n* `Ended` - The session has ended normally.\n* `Terminated` - The session was terminated by an admin."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public KvmSession.StatusEnum Status {
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
        /// <para type="description">"A reference to a kvmTunnel resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public KvmTunnelRelationship Tunnel {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Username used for vKVM access."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Username {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get KvmSession.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightKvmSession", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightKvmSession:GetCmdletBase
	{
		public GetIntersightKvmSession()
		{
			ApiInstance = new KvmApi(Config);
            MethodName = "GetKvmSessionListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set KvmPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightKvmPolicy")]
    public class SetIntersightKvmPolicy:SetCmdletBase
	{
		public SetIntersightKvmPolicy()
		{
			ApiInstance = new KvmApi(Config);
            ModelObject = new KvmPolicy();
            MethodName = "UpdateKvmPolicyWithHttpInfo";
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
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"If enabled, displays KVM session on any monitor attached to the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool EnableLocalServerVideo {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"If enabled, encrypts all video information sent through KVM."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool EnableVideoEncryption {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"State of the vKVM service on the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Enabled {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The maximum number of concurrent KVM sessions allowed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1, 4)]
        public long MaximumSessions {
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to policyAbstractConfigProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<PolicyAbstractConfigProfileRelationship> Profiles {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The port used for KVM communication."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1, 65535)]
        public long RemotePort {
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
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove KvmPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightKvmPolicy")]
    public class RemoveIntersightKvmPolicy:RemoveCmdletBase
	{
		public RemoveIntersightKvmPolicy()
		{
			ApiInstance = new KvmApi(Config);
            MethodName = "DeleteKvmPolicyWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get KvmPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightKvmPolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightKvmPolicy:GetCmdletBase
	{
		public GetIntersightKvmPolicy()
		{
			ApiInstance = new KvmApi(Config);
            MethodName = "GetKvmPolicyListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New KvmPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightKvmPolicy")]
    public class NewIntersightKvmPolicy:NewCmdletBase
	{
		public NewIntersightKvmPolicy()
		{
			ApiInstance = new KvmApi(Config);
            ModelObject = new KvmPolicy();
            MethodName = "CreateKvmPolicyWithHttpInfo";
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
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"If enabled, displays KVM session on any monitor attached to the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool EnableLocalServerVideo {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"If enabled, encrypts all video information sent through KVM."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool EnableVideoEncryption {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"State of the vKVM service on the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Enabled {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The maximum number of concurrent KVM sessions allowed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1, 4)]
        public long MaximumSessions {
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to policyAbstractConfigProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<PolicyAbstractConfigProfileRelationship> Profiles {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The port used for KVM communication."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1, 65535)]
        public long RemotePort {
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
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set KvmSession.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightKvmSession")]
    public class SetIntersightKvmSession:SetCmdletBase
	{
		public SetIntersightKvmSession()
		{
			ApiInstance = new KvmApi(Config);
            ModelObject = new KvmSession();
            MethodName = "UpdateKvmSessionWithHttpInfo";
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
        /// <para type="description">"Temporary one-time password for vKVM access."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string OneTimePassword {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a computePhysical resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ComputePhysicalRelationship Server {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The status of the session.\n* `Active` - The session is currently active.\n* `Ended` - The session has ended normally.\n* `Terminated` - The session was terminated by an admin."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public KvmSession.StatusEnum Status {
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
        /// <para type="description">"A reference to a kvmTunnel resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public KvmTunnelRelationship Tunnel {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Username used for vKVM access."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Username {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get KvmVmConsole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightKvmVmConsole", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightKvmVmConsole:GetCmdletBase
	{
		public GetIntersightKvmVmConsole()
		{
			ApiInstance = new KvmApi(Config);
            MethodName = "GetKvmVmConsoleListWithHttpInfo";
		}
    }
}