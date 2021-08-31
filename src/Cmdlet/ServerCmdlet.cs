using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get ServerConfigResult.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightServerConfigResult", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightServerConfigResult:GetCmdletBase
	{
		public GetIntersightServerConfigResult()
		{
			ApiInstance = new ServerApi(Config);
            MethodName = "GetServerConfigResultListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set ServerProfileTemplate.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightServerProfileTemplate")]
    public class SetIntersightServerProfileTemplate:SetCmdletBase
	{
		public SetIntersightServerProfileTemplate()
		{
			ApiInstance = new ServerApi(Config);
            ModelObject = new ServerProfileTemplate();
            MethodName = "UpdateServerProfileTemplateWithHttpInfo";
		}
        // <summary>
        /// <para type="description">"User initiated action. Each profile type has its own supported actions. For HyperFlex cluster profile, the supported actions are -- Validate, Deploy, Continue, Retry, Abort, Unassign For server profile, the support actions are -- Deploy, Unassign."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Action {
            get;
            set;
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
        /// <para type="description">"The configuration state and results of the last configuration operation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public PolicyConfigContext ConfigContext {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the profile."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
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
        /// <para type="description">"Name of the profile instance or profile template."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.-]{1,64}$")]
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
        /// <para type="description">"An array of relationships to policyAbstractPolicy resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<PolicyAbstractPolicyRelationship> PolicyBucket {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a policyAbstractProfile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public PolicyAbstractProfileRelationship SrcTemplate {
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
        /// <para type="description">"The platform for which the server profile is applicable. It can either be a server that is operating in standalone mode or which is attached to a Fabric Interconnect managed by Intersight.\n* `Standalone` - Servers which are operating in standalone mode i.e. not connected to a Fabric Interconnected.\n* `FIAttached` - Servers which are connected to a Fabric Interconnect that is managed by Intersight."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ServerProfileTemplate.TargetPlatformEnum TargetPlatform {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Defines the type of the profile. Accepted values are instance or template.\n* `instance` - The profile defines the configuration for a specific instance of a target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ServerProfileTemplate.TypeEnum Type {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove ServerProfileTemplate.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightServerProfileTemplate")]
    public class RemoveIntersightServerProfileTemplate:RemoveCmdletBase
	{
		public RemoveIntersightServerProfileTemplate()
		{
			ApiInstance = new ServerApi(Config);
            MethodName = "DeleteServerProfileTemplateWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get ServerProfileTemplate.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightServerProfileTemplate", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightServerProfileTemplate:GetCmdletBase
	{
		public GetIntersightServerProfileTemplate()
		{
			ApiInstance = new ServerApi(Config);
            MethodName = "GetServerProfileTemplateListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New ServerProfileTemplate.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightServerProfileTemplate")]
    public class NewIntersightServerProfileTemplate:NewCmdletBase
	{
		public NewIntersightServerProfileTemplate()
		{
			ApiInstance = new ServerApi(Config);
            ModelObject = new ServerProfileTemplate();
            MethodName = "CreateServerProfileTemplateWithHttpInfo";
		}
        // <summary>
        /// <para type="description">"User initiated action. Each profile type has its own supported actions. For HyperFlex cluster profile, the supported actions are -- Validate, Deploy, Continue, Retry, Abort, Unassign For server profile, the support actions are -- Deploy, Unassign."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Action {
            get;
            set;
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
        /// <para type="description">"The configuration state and results of the last configuration operation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public PolicyConfigContext ConfigContext {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the profile."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
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
        /// <para type="description">"Name of the profile instance or profile template."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.-]{1,64}$")]
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
        /// <para type="description">"An array of relationships to policyAbstractPolicy resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<PolicyAbstractPolicyRelationship> PolicyBucket {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a policyAbstractProfile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public PolicyAbstractProfileRelationship SrcTemplate {
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
        /// <para type="description">"The platform for which the server profile is applicable. It can either be a server that is operating in standalone mode or which is attached to a Fabric Interconnect managed by Intersight.\n* `Standalone` - Servers which are operating in standalone mode i.e. not connected to a Fabric Interconnected.\n* `FIAttached` - Servers which are connected to a Fabric Interconnect that is managed by Intersight."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ServerProfileTemplate.TargetPlatformEnum TargetPlatform {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Defines the type of the profile. Accepted values are instance or template.\n* `instance` - The profile defines the configuration for a specific instance of a target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ServerProfileTemplate.TypeEnum Type {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get ServerConfigResultEntry.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightServerConfigResultEntry", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightServerConfigResultEntry:GetCmdletBase
	{
		public GetIntersightServerConfigResultEntry()
		{
			ApiInstance = new ServerApi(Config);
            MethodName = "GetServerConfigResultEntryListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get ServerProfile.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightServerProfile", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightServerProfile:GetCmdletBase
	{
		public GetIntersightServerProfile()
		{
			ApiInstance = new ServerApi(Config);
            MethodName = "GetServerProfileListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New ServerProfile.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightServerProfile")]
    public class NewIntersightServerProfile:NewCmdletBase
	{
		public NewIntersightServerProfile()
		{
			ApiInstance = new ServerApi(Config);
            ModelObject = new ServerProfile();
            MethodName = "CreateServerProfileWithHttpInfo";
		}
        // <summary>
        /// <para type="description">"User initiated action. Each profile type has its own supported actions. For HyperFlex cluster profile, the supported actions are -- Validate, Deploy, Continue, Retry, Abort, Unassign For server profile, the support actions are -- Deploy, Unassign."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Action {
            get;
            set;
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
        /// <para type="description">"A reference to a computePhysical resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ComputePhysicalRelationship AssignedServer {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Pending configuration changes at the summary level. Detail changes are saved in configChangeDetails as a separate object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public PolicyConfigChange ConfigChanges {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The configuration state and results of the last configuration operation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public PolicyConfigContext ConfigContext {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the profile."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
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
        /// <para type="description">"Name of the profile instance or profile template."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.-]{1,64}$")]
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
        /// <para type="description">"Secure passphrase that is already deployed on all the Persistent Memory Modules on the server. This deployed passphrase is required during deploy of server profile if secure passphrase is changed or security is disabled in the attached persistent memory policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string PmcDeployedSecurePassphrase {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to policyAbstractPolicy resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<PolicyAbstractPolicyRelationship> PolicyBucket {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a policyAbstractProfile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public PolicyAbstractProfileRelationship SrcTemplate {
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
        /// <para type="description">"The platform for which the server profile is applicable. It can either be a server that is operating in standalone mode or which is attached to a Fabric Interconnect managed by Intersight.\n* `Standalone` - Servers which are operating in standalone mode i.e. not connected to a Fabric Interconnected.\n* `FIAttached` - Servers which are connected to a Fabric Interconnect that is managed by Intersight."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ServerProfile.TargetPlatformEnum TargetPlatform {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Defines the type of the profile. Accepted values are instance or template.\n* `instance` - The profile defines the configuration for a specific instance of a target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ServerProfile.TypeEnum Type {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get ServerConfigImport.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightServerConfigImport", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightServerConfigImport:GetCmdletBase
	{
		public GetIntersightServerConfigImport()
		{
			ApiInstance = new ServerApi(Config);
            MethodName = "GetServerConfigImportListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New ServerConfigImport.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightServerConfigImport")]
    public class NewIntersightServerConfigImport:NewCmdletBase
	{
		public NewIntersightServerConfigImport()
		{
			ApiInstance = new ServerApi(Config);
            ModelObject = new ServerConfigImport();
            MethodName = "CreateServerConfigImportWithHttpInfo";
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
        /// <para type="description">"Description of the imported profile."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
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
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Policy prefix for the policies of the imported server profile."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,32}$")]
        public string PolicyPrefix {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> PolicyTypes {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Profile name for the imported server profile."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.-]{1,64}$")]
        public string ProfileName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a computeRackUnit resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ComputeRackUnitRelationship Server {
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
    /// <para type="synopsis">This is the cmdlet to Get ServerConfigChangeDetail.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightServerConfigChangeDetail", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightServerConfigChangeDetail:GetCmdletBase
	{
		public GetIntersightServerConfigChangeDetail()
		{
			ApiInstance = new ServerApi(Config);
            MethodName = "GetServerConfigChangeDetailListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set ServerProfile.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightServerProfile")]
    public class SetIntersightServerProfile:SetCmdletBase
	{
		public SetIntersightServerProfile()
		{
			ApiInstance = new ServerApi(Config);
            ModelObject = new ServerProfile();
            MethodName = "UpdateServerProfileWithHttpInfo";
		}
        // <summary>
        /// <para type="description">"User initiated action. Each profile type has its own supported actions. For HyperFlex cluster profile, the supported actions are -- Validate, Deploy, Continue, Retry, Abort, Unassign For server profile, the support actions are -- Deploy, Unassign."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Action {
            get;
            set;
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
        /// <para type="description">"A reference to a computePhysical resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ComputePhysicalRelationship AssignedServer {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Pending configuration changes at the summary level. Detail changes are saved in configChangeDetails as a separate object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public PolicyConfigChange ConfigChanges {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The configuration state and results of the last configuration operation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public PolicyConfigContext ConfigContext {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the profile."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
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
        /// <para type="description">"Name of the profile instance or profile template."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.-]{1,64}$")]
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
        /// <para type="description">"Secure passphrase that is already deployed on all the Persistent Memory Modules on the server. This deployed passphrase is required during deploy of server profile if secure passphrase is changed or security is disabled in the attached persistent memory policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string PmcDeployedSecurePassphrase {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to policyAbstractPolicy resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<PolicyAbstractPolicyRelationship> PolicyBucket {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a policyAbstractProfile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public PolicyAbstractProfileRelationship SrcTemplate {
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
        /// <para type="description">"The platform for which the server profile is applicable. It can either be a server that is operating in standalone mode or which is attached to a Fabric Interconnect managed by Intersight.\n* `Standalone` - Servers which are operating in standalone mode i.e. not connected to a Fabric Interconnected.\n* `FIAttached` - Servers which are connected to a Fabric Interconnect that is managed by Intersight."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ServerProfile.TargetPlatformEnum TargetPlatform {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Defines the type of the profile. Accepted values are instance or template.\n* `instance` - The profile defines the configuration for a specific instance of a target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ServerProfile.TypeEnum Type {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove ServerProfile.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightServerProfile")]
    public class RemoveIntersightServerProfile:RemoveCmdletBase
	{
		public RemoveIntersightServerProfile()
		{
			ApiInstance = new ServerApi(Config);
            MethodName = "DeleteServerProfileWithHttpInfo";
		}
    }
}