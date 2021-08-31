using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove RecoveryScheduleConfigPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightRecoveryScheduleConfigPolicy")]
    public class RemoveIntersightRecoveryScheduleConfigPolicy:RemoveCmdletBase
	{
		public RemoveIntersightRecoveryScheduleConfigPolicy()
		{
			ApiInstance = new RecoveryApi(Config);
            MethodName = "DeleteRecoveryScheduleConfigPolicyWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set RecoveryScheduleConfigPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightRecoveryScheduleConfigPolicy")]
    public class SetIntersightRecoveryScheduleConfigPolicy:SetCmdletBase
	{
		public SetIntersightRecoveryScheduleConfigPolicy()
		{
			ApiInstance = new RecoveryApi(Config);
            ModelObject = new RecoveryScheduleConfigPolicy();
            MethodName = "UpdateRecoveryScheduleConfigPolicyWithHttpInfo";
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
        /// <para type="description">"An array of relationships to recoveryBackupProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<RecoveryBackupProfileRelationship> BackupProfiles {
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
        /// <para type="description">"Schedule to create a backup on the target device. Minimum is 4 hours and Max is 1440 hours (30 Days)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public RecoveryBackupSchedule Schedule {
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
    /// <para type="synopsis">This is the cmdlet to Get RecoveryRestore.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightRecoveryRestore", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightRecoveryRestore:GetCmdletBase
	{
		public GetIntersightRecoveryRestore()
		{
			ApiInstance = new RecoveryApi(Config);
            MethodName = "GetRecoveryRestoreListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New RecoveryRestore.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightRecoveryRestore")]
    public class NewIntersightRecoveryRestore:NewCmdletBase
	{
		public NewIntersightRecoveryRestore()
		{
			ApiInstance = new RecoveryApi(Config);
            ModelObject = new RecoveryRestore();
            MethodName = "CreateRecoveryRestoreWithHttpInfo";
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
        /// <para type="description">"A reference to a recoveryAbstractBackupInfo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public RecoveryAbstractBackupInfoRelationship BackupInfo {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Configuration parameters to be passed into the restore workflow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public RecoveryConfigParams ConfigParams {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetDeviceRegistrationRelationship Device {
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New RecoveryScheduleConfigPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightRecoveryScheduleConfigPolicy")]
    public class NewIntersightRecoveryScheduleConfigPolicy:NewCmdletBase
	{
		public NewIntersightRecoveryScheduleConfigPolicy()
		{
			ApiInstance = new RecoveryApi(Config);
            ModelObject = new RecoveryScheduleConfigPolicy();
            MethodName = "CreateRecoveryScheduleConfigPolicyWithHttpInfo";
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
        /// <para type="description">"An array of relationships to recoveryBackupProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<RecoveryBackupProfileRelationship> BackupProfiles {
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
        /// <para type="description">"Schedule to create a backup on the target device. Minimum is 4 hours and Max is 1440 hours (30 Days)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public RecoveryBackupSchedule Schedule {
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
    /// <para type="synopsis">This is the cmdlet to Get RecoveryScheduleConfigPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightRecoveryScheduleConfigPolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightRecoveryScheduleConfigPolicy:GetCmdletBase
	{
		public GetIntersightRecoveryScheduleConfigPolicy()
		{
			ApiInstance = new RecoveryApi(Config);
            MethodName = "GetRecoveryScheduleConfigPolicyListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New RecoveryBackupProfile.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightRecoveryBackupProfile")]
    public class NewIntersightRecoveryBackupProfile:NewCmdletBase
	{
		public NewIntersightRecoveryBackupProfile()
		{
			ApiInstance = new RecoveryApi(Config);
            ModelObject = new RecoveryBackupProfile();
            MethodName = "CreateRecoveryBackupProfileWithHttpInfo";
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
        /// <para type="description">"A reference to a recoveryBackupConfigPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public RecoveryBackupConfigPolicyRelationship BackupConfig {
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
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetDeviceRegistrationRelationship DeviceId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Enables/Disables the schedule on the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Enabled {
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
        /// <para type="description">"A reference to a recoveryScheduleConfigPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public RecoveryScheduleConfigPolicyRelationship ScheduleConfig {
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
        /// <para type="description">"Defines the type of the profile. Accepted values are instance or template.\n* `instance` - The profile defines the configuration for a specific instance of a target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public RecoveryBackupProfile.TypeEnum Type {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get RecoveryBackupProfile.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightRecoveryBackupProfile", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightRecoveryBackupProfile:GetCmdletBase
	{
		public GetIntersightRecoveryBackupProfile()
		{
			ApiInstance = new RecoveryApi(Config);
            MethodName = "GetRecoveryBackupProfileListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get RecoveryConfigResultEntry.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightRecoveryConfigResultEntry", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightRecoveryConfigResultEntry:GetCmdletBase
	{
		public GetIntersightRecoveryConfigResultEntry()
		{
			ApiInstance = new RecoveryApi(Config);
            MethodName = "GetRecoveryConfigResultEntryListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove RecoveryOnDemandBackup.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightRecoveryOnDemandBackup")]
    public class RemoveIntersightRecoveryOnDemandBackup:RemoveCmdletBase
	{
		public RemoveIntersightRecoveryOnDemandBackup()
		{
			ApiInstance = new RecoveryApi(Config);
            MethodName = "DeleteRecoveryOnDemandBackupWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set RecoveryOnDemandBackup.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightRecoveryOnDemandBackup")]
    public class SetIntersightRecoveryOnDemandBackup:SetCmdletBase
	{
		public SetIntersightRecoveryOnDemandBackup()
		{
			ApiInstance = new RecoveryApi(Config);
            ModelObject = new RecoveryOnDemandBackup();
            MethodName = "UpdateRecoveryOnDemandBackupWithHttpInfo";
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
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetDeviceRegistrationRelationship DeviceId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The file name for the backup image. This name is added as a prefix in the name for the backup image. A unique file name for the backup image is created along with a timestamp. For example: prefix-1572431305418."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string FileNamePrefix {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Specifies whether the backup will be stored locally or remotely.\n* `Network Share` - The backup is stored remotely on a separate server.\n* `Local Storage` - The backup is stored locally on the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public RecoveryOnDemandBackup.LocationTypeEnum LocationType {
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
        /// <para type="description">"Password of Backup server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Password {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The file system path where the backup images must be stored. Include the IP address/hostname of the network share location and the complete file system path. For example: 172.29.109.234/var/backups/."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Path {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Protocol for transferring the backup image to the network share location.\n* `SCP` - Secure Copy Protocol (SCP) to access the file server.\n* `SFTP` - SSH File Transfer Protocol (SFTP) to access file server.\n* `FTP` - File Transfer Protocol (FTP) to access file server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public RecoveryOnDemandBackup.ProtocolEnum Protocol {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of backup copies maintained on the local or remote server. When the created backup files exceed this number, the initial backup files are overwritten in a sequential manner."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1, 365)]
        public long RetentionCount {
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
        /// <para type="description">"Username for the backup server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string UserName {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove RecoveryBackupConfigPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightRecoveryBackupConfigPolicy")]
    public class RemoveIntersightRecoveryBackupConfigPolicy:RemoveCmdletBase
	{
		public RemoveIntersightRecoveryBackupConfigPolicy()
		{
			ApiInstance = new RecoveryApi(Config);
            MethodName = "DeleteRecoveryBackupConfigPolicyWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set RecoveryBackupConfigPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightRecoveryBackupConfigPolicy")]
    public class SetIntersightRecoveryBackupConfigPolicy:SetCmdletBase
	{
		public SetIntersightRecoveryBackupConfigPolicy()
		{
			ApiInstance = new RecoveryApi(Config);
            ModelObject = new RecoveryBackupConfigPolicy();
            MethodName = "UpdateRecoveryBackupConfigPolicyWithHttpInfo";
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
        /// <para type="description">"An array of relationships to recoveryBackupProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<RecoveryBackupProfileRelationship> BackupProfiles {
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
        /// <para type="description">"The file name for the backup image. This name is added as a prefix in the name for the backup image. A unique file name for the backup image is created along with a timestamp. For example: prefix-1572431305418."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string FileNamePrefix {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Specifies whether the backup will be stored locally or remotely.\n* `Network Share` - The backup is stored remotely on a separate server.\n* `Local Storage` - The backup is stored locally on the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public RecoveryBackupConfigPolicy.LocationTypeEnum LocationType {
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
        /// <para type="description">"Password of Backup server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Password {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The file system path where the backup images must be stored. Include the IP address/hostname of the network share location and the complete file system path. For example: 172.29.109.234/var/backups/."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Path {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Protocol for transferring the backup image to the network share location.\n* `SCP` - Secure Copy Protocol (SCP) to access the file server.\n* `SFTP` - SSH File Transfer Protocol (SFTP) to access file server.\n* `FTP` - File Transfer Protocol (FTP) to access file server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public RecoveryBackupConfigPolicy.ProtocolEnum Protocol {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of backup copies maintained on the local or remote server. When the created backup files exceed this number, the initial backup files are overwritten in a sequential manner."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1, 365)]
        public long RetentionCount {
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
        /// <para type="description">"Username for the backup server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string UserName {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New RecoveryOnDemandBackup.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightRecoveryOnDemandBackup")]
    public class NewIntersightRecoveryOnDemandBackup:NewCmdletBase
	{
		public NewIntersightRecoveryOnDemandBackup()
		{
			ApiInstance = new RecoveryApi(Config);
            ModelObject = new RecoveryOnDemandBackup();
            MethodName = "CreateRecoveryOnDemandBackupWithHttpInfo";
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
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetDeviceRegistrationRelationship DeviceId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The file name for the backup image. This name is added as a prefix in the name for the backup image. A unique file name for the backup image is created along with a timestamp. For example: prefix-1572431305418."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string FileNamePrefix {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Specifies whether the backup will be stored locally or remotely.\n* `Network Share` - The backup is stored remotely on a separate server.\n* `Local Storage` - The backup is stored locally on the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public RecoveryOnDemandBackup.LocationTypeEnum LocationType {
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
        /// <para type="description">"Password of Backup server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Password {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The file system path where the backup images must be stored. Include the IP address/hostname of the network share location and the complete file system path. For example: 172.29.109.234/var/backups/."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Path {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Protocol for transferring the backup image to the network share location.\n* `SCP` - Secure Copy Protocol (SCP) to access the file server.\n* `SFTP` - SSH File Transfer Protocol (SFTP) to access file server.\n* `FTP` - File Transfer Protocol (FTP) to access file server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public RecoveryOnDemandBackup.ProtocolEnum Protocol {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of backup copies maintained on the local or remote server. When the created backup files exceed this number, the initial backup files are overwritten in a sequential manner."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1, 365)]
        public long RetentionCount {
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
        /// <para type="description">"Username for the backup server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string UserName {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get RecoveryOnDemandBackup.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightRecoveryOnDemandBackup", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightRecoveryOnDemandBackup:GetCmdletBase
	{
		public GetIntersightRecoveryOnDemandBackup()
		{
			ApiInstance = new RecoveryApi(Config);
            MethodName = "GetRecoveryOnDemandBackupListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get RecoveryConfigResult.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightRecoveryConfigResult", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightRecoveryConfigResult:GetCmdletBase
	{
		public GetIntersightRecoveryConfigResult()
		{
			ApiInstance = new RecoveryApi(Config);
            MethodName = "GetRecoveryConfigResultListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove RecoveryBackupProfile.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightRecoveryBackupProfile")]
    public class RemoveIntersightRecoveryBackupProfile:RemoveCmdletBase
	{
		public RemoveIntersightRecoveryBackupProfile()
		{
			ApiInstance = new RecoveryApi(Config);
            MethodName = "DeleteRecoveryBackupProfileWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set RecoveryBackupProfile.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightRecoveryBackupProfile")]
    public class SetIntersightRecoveryBackupProfile:SetCmdletBase
	{
		public SetIntersightRecoveryBackupProfile()
		{
			ApiInstance = new RecoveryApi(Config);
            ModelObject = new RecoveryBackupProfile();
            MethodName = "UpdateRecoveryBackupProfileWithHttpInfo";
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
        /// <para type="description">"A reference to a recoveryBackupConfigPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public RecoveryBackupConfigPolicyRelationship BackupConfig {
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
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetDeviceRegistrationRelationship DeviceId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Enables/Disables the schedule on the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Enabled {
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
        /// <para type="description">"A reference to a recoveryScheduleConfigPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public RecoveryScheduleConfigPolicyRelationship ScheduleConfig {
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
        /// <para type="description">"Defines the type of the profile. Accepted values are instance or template.\n* `instance` - The profile defines the configuration for a specific instance of a target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public RecoveryBackupProfile.TypeEnum Type {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New RecoveryBackupConfigPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightRecoveryBackupConfigPolicy")]
    public class NewIntersightRecoveryBackupConfigPolicy:NewCmdletBase
	{
		public NewIntersightRecoveryBackupConfigPolicy()
		{
			ApiInstance = new RecoveryApi(Config);
            ModelObject = new RecoveryBackupConfigPolicy();
            MethodName = "CreateRecoveryBackupConfigPolicyWithHttpInfo";
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
        /// <para type="description">"An array of relationships to recoveryBackupProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<RecoveryBackupProfileRelationship> BackupProfiles {
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
        /// <para type="description">"The file name for the backup image. This name is added as a prefix in the name for the backup image. A unique file name for the backup image is created along with a timestamp. For example: prefix-1572431305418."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string FileNamePrefix {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Specifies whether the backup will be stored locally or remotely.\n* `Network Share` - The backup is stored remotely on a separate server.\n* `Local Storage` - The backup is stored locally on the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public RecoveryBackupConfigPolicy.LocationTypeEnum LocationType {
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
        /// <para type="description">"Password of Backup server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Password {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The file system path where the backup images must be stored. Include the IP address/hostname of the network share location and the complete file system path. For example: 172.29.109.234/var/backups/."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Path {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Protocol for transferring the backup image to the network share location.\n* `SCP` - Secure Copy Protocol (SCP) to access the file server.\n* `SFTP` - SSH File Transfer Protocol (SFTP) to access file server.\n* `FTP` - File Transfer Protocol (FTP) to access file server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public RecoveryBackupConfigPolicy.ProtocolEnum Protocol {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of backup copies maintained on the local or remote server. When the created backup files exceed this number, the initial backup files are overwritten in a sequential manner."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1, 365)]
        public long RetentionCount {
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
        /// <para type="description">"Username for the backup server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string UserName {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get RecoveryBackupConfigPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightRecoveryBackupConfigPolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightRecoveryBackupConfigPolicy:GetCmdletBase
	{
		public GetIntersightRecoveryBackupConfigPolicy()
		{
			ApiInstance = new RecoveryApi(Config);
            MethodName = "GetRecoveryBackupConfigPolicyListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove RecoveryRestore.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightRecoveryRestore")]
    public class RemoveIntersightRecoveryRestore:RemoveCmdletBase
	{
		public RemoveIntersightRecoveryRestore()
		{
			ApiInstance = new RecoveryApi(Config);
            MethodName = "DeleteRecoveryRestoreWithHttpInfo";
		}
    }
}