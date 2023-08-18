using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ApplianceApiStatus.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightApplianceApiStatus")]
    public class InitializeIntersightApplianceApiStatus : PSCmdlet
    {
        public InitializeIntersightApplianceApiStatus()
        {
            ClassId = ApplianceApiStatus.ClassIdEnum.ApplianceApiStatus;
            ObjectType = ApplianceApiStatus.ObjectTypeEnum.ApplianceApiStatus;

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

        public ApplianceApiStatus.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ApplianceApiStatus.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.ApplianceApiStatus initObject = new Intersight.Model.ApplianceApiStatus();
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
    /// <para type="synopsis">This is the cmdlet to Initialize ApplianceAppOpStatus.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightApplianceAppOpStatus")]
    public class InitializeIntersightApplianceAppOpStatus : PSCmdlet
    {
        public InitializeIntersightApplianceAppOpStatus()
        {
            ClassId = ApplianceAppOpStatus.ClassIdEnum.ApplianceAppOpStatus;
            ObjectType = ApplianceAppOpStatus.ObjectTypeEnum.ApplianceAppOpStatus;

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

        public ApplianceAppOpStatus.ClassIdEnum ClassId
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ApplianceAppOpStatus.ObjectTypeEnum ObjectType
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

        protected override void ProcessRecord()
        {
            Intersight.Model.ApplianceAppOpStatus initObject = new Intersight.Model.ApplianceAppOpStatus();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ApplianceAppStatus.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightApplianceAppStatus")]
    public class InitializeIntersightApplianceAppStatus : PSCmdlet
    {
        public InitializeIntersightApplianceAppStatus()
        {
            ClassId = ApplianceAppStatus.ClassIdEnum.ApplianceAppStatus;
            ObjectType = ApplianceAppStatus.ObjectTypeEnum.ApplianceAppStatus;

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

        public ApplianceAppStatus.ClassIdEnum ClassId
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ApplianceAppStatus.ObjectTypeEnum ObjectType
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

        protected override void ProcessRecord()
        {
            Intersight.Model.ApplianceAppStatus initObject = new Intersight.Model.ApplianceAppStatus();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ApplianceAutoRmaPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightApplianceAutoRmaPolicy")]
    public class InitializeIntersightApplianceAutoRmaPolicy : PSCmdlet
    {
        public InitializeIntersightApplianceAutoRmaPolicy()
        {
            ClassId = ApplianceAutoRmaPolicy.ClassIdEnum.ApplianceAutoRmaPolicy;
            ObjectType = ApplianceAutoRmaPolicy.ObjectTypeEnum.ApplianceAutoRmaPolicy;

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

        public ApplianceAutoRmaPolicy.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Status of the data collection mode. If the value is 'true', then data collection is enabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Enable
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ApplianceAutoRmaPolicy.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.AssetDeviceRegistrationRelationship RegisteredDevice
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

        protected override void ProcessRecord()
        {
            Intersight.Model.ApplianceAutoRmaPolicy initObject = new Intersight.Model.ApplianceAutoRmaPolicy();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Enable"))
            {
                initObject.Enable = this.Enable;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("RegisteredDevice"))
            {
                initObject.RegisteredDevice = this.RegisteredDevice;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ApplianceBackup.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightApplianceBackup")]
    public class InitializeIntersightApplianceBackup : PSCmdlet
    {
        public InitializeIntersightApplianceBackup()
        {
            ClassId = ApplianceBackup.ClassIdEnum.ApplianceBackup;
            ObjectType = ApplianceBackup.ObjectTypeEnum.ApplianceBackup;
            Protocol = ApplianceBackup.ProtocolEnum.Scp;

        }
        // <summary>
        /// <para type="description">"A reference to a iamAccount resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IamAccountRelationship Account
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

        public ApplianceBackup.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Backup filename to backup or restore."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9][a-zA-Z0-9_\\.\\-\\+]*$")]
        public string Filename
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ApplianceBackup.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Password to authenticate the fileserver."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[^`]+$")]
        public string Password
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Communication protocol used by the file server (e.g. scp or sftp).\n* `scp` - Secure Copy Protocol (SCP) to access the file server.\n* `sftp` - SSH File Transfer Protocol (SFTP) to access file server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ApplianceBackup.ProtocolEnum Protocol
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Hostname of the remote file server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string RemoteHost
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"File server directory to copy the file."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^(/[^/ ]*)+/?$")]
        public string RemotePath
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Remote TCP port on the file server (e.g. 22 for scp)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long RemotePort
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
        /// <para type="description">"Username to authenticate the fileserver."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9_][a-zA-Z0-9_\\.\\@\\\\\\-\\+]*$")]
        public string Username
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.ApplianceBackup initObject = new Intersight.Model.ApplianceBackup();
            if (this.MyInvocation.BoundParameters.ContainsKey("Account"))
            {
                initObject.Account = this.Account;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Filename"))
            {
                initObject.Filename = this.Filename;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Password"))
            {
                initObject.Password = this.Password;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Protocol"))
            {
                initObject.Protocol = this.Protocol;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RemoteHost"))
            {
                initObject.RemoteHost = this.RemoteHost;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RemotePath"))
            {
                initObject.RemotePath = this.RemotePath;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RemotePort"))
            {
                initObject.RemotePort = this.RemotePort;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Username"))
            {
                initObject.Username = this.Username;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ApplianceBackupPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightApplianceBackupPolicy")]
    public class InitializeIntersightApplianceBackupPolicy : PSCmdlet
    {
        public InitializeIntersightApplianceBackupPolicy()
        {
            ClassId = ApplianceBackupPolicy.ClassIdEnum.ApplianceBackupPolicy;
            ObjectType = ApplianceBackupPolicy.ObjectTypeEnum.ApplianceBackupPolicy;
            Protocol = ApplianceBackupPolicy.ProtocolEnum.Scp;

        }
        // <summary>
        /// <para type="description">"A reference to a iamAccount resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IamAccountRelationship Account
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

        public ApplianceBackupPolicy.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Backup filename to backup or restore."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9][a-zA-Z0-9_\\.\\-\\+]*$")]
        public string Filename
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Backup mode of the appliance. Automatic backups of the appliance are not initiated if this property is set to 'true' and the backup schedule field is ignored."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool ManualBackup
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ApplianceBackupPolicy.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Password to authenticate the file server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[^`]+$")]
        public string Password
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Communication protocol used by the file server (e.g. scp or sftp).\n* `scp` - Secure Copy Protocol (SCP) to access the file server.\n* `sftp` - SSH File Transfer Protocol (SFTP) to access file server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ApplianceBackupPolicy.ProtocolEnum Protocol
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Hostname of the remote file server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string RemoteHost
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"File server directory to copy the file."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^(/[^/ ]*)+/?$")]
        public string RemotePath
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Remote TCP port on the file server (e.g. 22 for scp)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long RemotePort
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Schedule to create a backup of the Intersight Appliance. Manualbackup field must be set to 'false' for this schedule to be active."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.OnpremSchedule Schedule
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
        /// <para type="description">"Username to authenticate the fileserver."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9_][a-zA-Z0-9_\\.\\@\\\\\\-\\+]*$")]
        public string Username
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.ApplianceBackupPolicy initObject = new Intersight.Model.ApplianceBackupPolicy();
            if (this.MyInvocation.BoundParameters.ContainsKey("Account"))
            {
                initObject.Account = this.Account;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Filename"))
            {
                initObject.Filename = this.Filename;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ManualBackup"))
            {
                initObject.ManualBackup = this.ManualBackup;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Password"))
            {
                initObject.Password = this.Password;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Protocol"))
            {
                initObject.Protocol = this.Protocol;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RemoteHost"))
            {
                initObject.RemoteHost = this.RemoteHost;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RemotePath"))
            {
                initObject.RemotePath = this.RemotePath;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RemotePort"))
            {
                initObject.RemotePort = this.RemotePort;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Schedule"))
            {
                initObject.Schedule = this.Schedule;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Username"))
            {
                initObject.Username = this.Username;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ApplianceCertRenewalPhase.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightApplianceCertRenewalPhase")]
    public class InitializeIntersightApplianceCertRenewalPhase : PSCmdlet
    {
        public InitializeIntersightApplianceCertRenewalPhase()
        {
            ClassId = ApplianceCertRenewalPhase.ClassIdEnum.ApplianceCertRenewalPhase;
            ObjectType = ApplianceCertRenewalPhase.ObjectTypeEnum.ApplianceCertRenewalPhase;

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

        public ApplianceCertRenewalPhase.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ApplianceCertRenewalPhase.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.ApplianceCertRenewalPhase initObject = new Intersight.Model.ApplianceCertRenewalPhase();
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
    /// <para type="synopsis">This is the cmdlet to Initialize ApplianceCertificateSetting.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightApplianceCertificateSetting")]
    public class InitializeIntersightApplianceCertificateSetting : PSCmdlet
    {
        public InitializeIntersightApplianceCertificateSetting()
        {
            ClassId = ApplianceCertificateSetting.ClassIdEnum.ApplianceCertificateSetting;
            ObjectType = ApplianceCertificateSetting.ObjectTypeEnum.ApplianceCertificateSetting;

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
        /// <para type="description">"A reference to a iamCertificate resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IamCertificateRelationship Certificate
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ApplianceCertificateSetting.ClassIdEnum ClassId
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ApplianceCertificateSetting.ObjectTypeEnum ObjectType
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

        protected override void ProcessRecord()
        {
            Intersight.Model.ApplianceCertificateSetting initObject = new Intersight.Model.ApplianceCertificateSetting();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Certificate"))
            {
                initObject.Certificate = this.Certificate;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ApplianceClusterInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightApplianceClusterInfo")]
    public class InitializeIntersightApplianceClusterInfo : PSCmdlet
    {
        public InitializeIntersightApplianceClusterInfo()
        {
            ClassId = ApplianceClusterInfo.ClassIdEnum.ApplianceClusterInfo;
            ObjectType = ApplianceClusterInfo.ObjectTypeEnum.ApplianceClusterInfo;

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

        public ApplianceClusterInfo.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The deployment size of the node requiring to join cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string DeploymentSize
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Default gateway configured on the peer node."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Gateway
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Publicly accessible IP of the peer node."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Hostip
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Publicly accessible FQDN of the peer node."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Hostname
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ApplianceClusterInfo.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The public key of peer host."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Peerkey
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Public key returned to the client."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Responsekey
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Subnet Mask of the peer node."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Subnetmask
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
        /// <para type="description">"The UUID of the peer appliance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Uuid
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.ApplianceClusterInfo initObject = new Intersight.Model.ApplianceClusterInfo();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("DeploymentSize"))
            {
                initObject.DeploymentSize = this.DeploymentSize;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Gateway"))
            {
                initObject.Gateway = this.Gateway;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Hostip"))
            {
                initObject.Hostip = this.Hostip;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Hostname"))
            {
                initObject.Hostname = this.Hostname;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Peerkey"))
            {
                initObject.Peerkey = this.Peerkey;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Responsekey"))
            {
                initObject.Responsekey = this.Responsekey;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Subnetmask"))
            {
                initObject.Subnetmask = this.Subnetmask;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Uuid"))
            {
                initObject.Uuid = this.Uuid;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ApplianceClusterInstall.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightApplianceClusterInstall")]
    public class InitializeIntersightApplianceClusterInstall : PSCmdlet
    {
        public InitializeIntersightApplianceClusterInstall()
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

        public ApplianceClusterInstall.ClassIdEnum ClassId
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ApplianceClusterInstall.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Round robin DNS address, which should be able to resolve the hostnames of all the nodes in the cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string RemoteDns
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Start date of the software install. UI can modify startTime to re-schedule an install."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime StartTime
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

        protected override void ProcessRecord()
        {
            Intersight.Model.ApplianceClusterInstall initObject = new Intersight.Model.ApplianceClusterInstall();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("RemoteDns"))
            {
                initObject.RemoteDns = this.RemoteDns;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("StartTime"))
            {
                initObject.StartTime = this.StartTime;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ApplianceClusterInstallPhase.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightApplianceClusterInstallPhase")]
    public class InitializeIntersightApplianceClusterInstallPhase : PSCmdlet
    {
        public InitializeIntersightApplianceClusterInstallPhase()
        {
            ClassId = ApplianceClusterInstallPhase.ClassIdEnum.ApplianceClusterInstallPhase;
            ObjectType = ApplianceClusterInstallPhase.ObjectTypeEnum.ApplianceClusterInstallPhase;

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

        public ApplianceClusterInstallPhase.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ApplianceClusterInstallPhase.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.ApplianceClusterInstallPhase initObject = new Intersight.Model.ApplianceClusterInstallPhase();
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
    /// <para type="synopsis">This is the cmdlet to Initialize ApplianceClusterReplaceNode.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightApplianceClusterReplaceNode")]
    public class InitializeIntersightApplianceClusterReplaceNode : PSCmdlet
    {
        public InitializeIntersightApplianceClusterReplaceNode()
        {
            ClassId = ApplianceClusterReplaceNode.ClassIdEnum.ApplianceClusterReplaceNode;
            ObjectType = ApplianceClusterReplaceNode.ObjectTypeEnum.ApplianceClusterReplaceNode;

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

        public ApplianceClusterReplaceNode.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Hostname of the node being replaced."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Hostname
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
        /// <para type="description">"Node id of the node being replaced."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long NodeId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ApplianceClusterReplaceNode.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Round robin DNS address, which should be able to resolve the hostnames of all the nodes in the cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string RemoteDns
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Start date of the software install. UI can modify startTime to re-schedule an install."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime StartTime
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

        protected override void ProcessRecord()
        {
            Intersight.Model.ApplianceClusterReplaceNode initObject = new Intersight.Model.ApplianceClusterReplaceNode();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Hostname"))
            {
                initObject.Hostname = this.Hostname;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NodeId"))
            {
                initObject.NodeId = this.NodeId;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("RemoteDns"))
            {
                initObject.RemoteDns = this.RemoteDns;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("StartTime"))
            {
                initObject.StartTime = this.StartTime;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ApplianceDataExportPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightApplianceDataExportPolicy")]
    public class InitializeIntersightApplianceDataExportPolicy : PSCmdlet
    {
        public InitializeIntersightApplianceDataExportPolicy()
        {
            ClassId = ApplianceDataExportPolicy.ClassIdEnum.ApplianceDataExportPolicy;
            ObjectType = ApplianceDataExportPolicy.ObjectTypeEnum.ApplianceDataExportPolicy;

        }
        // <summary>
        /// <para type="description">"A reference to a iamAccount resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IamAccountRelationship Account
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

        public ApplianceDataExportPolicy.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Status of the data collection mode. If the value is 'true', then data collection is enabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Enable
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ApplianceDataExportPolicy.ObjectTypeEnum ObjectType
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

        protected override void ProcessRecord()
        {
            Intersight.Model.ApplianceDataExportPolicy initObject = new Intersight.Model.ApplianceDataExportPolicy();
            if (this.MyInvocation.BoundParameters.ContainsKey("Account"))
            {
                initObject.Account = this.Account;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Enable"))
            {
                initObject.Enable = this.Enable;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ApplianceDeviceCertificate.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightApplianceDeviceCertificate")]
    public class InitializeIntersightApplianceDeviceCertificate : PSCmdlet
    {
        public InitializeIntersightApplianceDeviceCertificate()
        {
            ClassId = ApplianceDeviceCertificate.ClassIdEnum.ApplianceDeviceCertificate;
            ObjectType = ApplianceDeviceCertificate.ObjectTypeEnum.ApplianceDeviceCertificate;

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

        public ApplianceDeviceCertificate.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The operation configuration MOId."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ConfigurationMoId
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ApplianceDeviceCertificate.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Start date of the certificate renewal."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime StartTime
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The status of ca certificate renewal."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Status
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

        protected override void ProcessRecord()
        {
            Intersight.Model.ApplianceDeviceCertificate initObject = new Intersight.Model.ApplianceDeviceCertificate();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ConfigurationMoId"))
            {
                initObject.ConfigurationMoId = this.ConfigurationMoId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("StartTime"))
            {
                initObject.StartTime = this.StartTime;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Status"))
            {
                initObject.Status = this.Status;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ApplianceDeviceClaim.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightApplianceDeviceClaim")]
    public class InitializeIntersightApplianceDeviceClaim : PSCmdlet
    {
        public InitializeIntersightApplianceDeviceClaim()
        {
            ClassId = ApplianceDeviceClaim.ClassIdEnum.ApplianceDeviceClaim;
            ObjectType = ApplianceDeviceClaim.ObjectTypeEnum.ApplianceDeviceClaim;

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

        public ApplianceDeviceClaim.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Hostname or IP address of the endpoint device the user wants to claim."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Hostname
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Tracks if this device is to be claimed or certificate renewal."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool IsRenew
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ApplianceDeviceClaim.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Password to be used to login to the endpoint device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Password
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Platform type of the endpoint device.\n* `` - An unrecognized platform type.\n* `APIC` - A Cisco Application Policy Infrastructure Controller (APIC) cluster.\n* `CAPIC` - A Cisco Cloud Application Policy Infrastructure Controller (Cloud APIC) instance.\n* `DCNM` - A Cisco Data Center Network Manager (DCNM) instance.\n* `UCSFI` - A Cisco UCS Fabric Interconnect that is managed by Cisco UCS Manager (UCSM).\n* `UCSFIISM` - A Cisco UCS Fabric Interconnect that is managed by Cisco Intersight.\n* `IMC` - A standalone Cisco UCS rack server (Deprecated).\n* `IMCM4` - A standalone Cisco UCS C-Series or S-Series M4 server.\n* `IMCM5` - A standalone Cisco UCS C-Series or S-Series M5 server.\n* `IMCRack` - A standalone Cisco UCS C-Series or S-Series M6 or newer server.\n* `UCSIOM` - A Cisco UCS Blade Chassis I/O Module (IOM).\n* `HX` - A Cisco HyperFlex (HX) cluster.\n* `UCSD` - A Cisco UCS Director (UCSD) instance.\n* `IntersightAppliance` - A Cisco Intersight Connected Virtual Appliance instance.\n* `IntersightAssist` - A Cisco Intersight Assist instance.\n* `PureStorageFlashArray` - A Pure Storage FlashArray that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer and storage management features are supported on this device.\n* `NexusDevice` - A Cisco Nexus Network Switch that is managed using Cisco Intersight Assist.\n* `ACISwitch` - A Cisco Nexus Network Switch with the embedded Device Connector and is a part of the Cisco ACI fabric.\n* `NexusSwitch` - A standalone Cisco Nexus Network Switch with the embedded Device Connector.\n* `MDSSwitch` - A Cisco MDS Switch that is managed using the embedded Device Connector.\n* `MDSDevice` - A Cisco MDS Switch that is managed using Cisco Intersight Assist.\n* `UCSC890` - A standalone Cisco UCS C890 server managed using Cisco Intersight Assist.\n* `RedfishServer` - A generic target type for servers that support Redfish APIs and is managed using Cisco Intersight Assist. Support is limited to HPE and Dell Servers.\n* `NetAppOntap` - A Netapp ONTAP Storage system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `NetAppActiveIqUnifiedManager` - A NetApp Active IQ Unified Manager (AIQUM) that is managed using Cisco Intersight Assist.\n* `EmcScaleIo` - An EMC ScaleIO Software Defined Storage system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `EmcVmax` - An EMC VMAX 2 or 3 series enterprise storage array that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `EmcVplex` - An EMC VPLEX virtual storage system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `EmcXtremIo` - An EMC XtremIO SSD storage system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `VmwareVcenter` - A VMware vCenter instance that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer and Virtualization features are supported on this hypervisor.\n* `MicrosoftHyperV` - A Microsoft Hyper-V host that is managed using Cisco Intersight Assist. Optionally, other hosts in the cluster can be discovered through this host. Cisco Intersight Workload Optimizer features are supported on this hypervisor.\n* `AppDynamics` - An AppDynamics controller running in a SaaS or on-prem datacenter. On-prem AppDynamics instance is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this controller.\n* `Dynatrace` - A Dynatrace Server instance running in a SaaS or on-prem datacenter. On-prem Dynatrace instance is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this server.\n* `NewRelic` - A NewRelic user account. The NewRelic instance monitors the application infrastructure. Cisco Intersight Workload Optimizer features are supported on this server.\n* `ServiceNow` - A cloud-based workflow automation platform that enables enterprise organizations to improve operational efficiencies by streamlining and automating routine work tasks.\n* `CloudFoundry` - An open source cloud platform on which developers can build, deploy, run and scale applications.\n* `MicrosoftAzureApplicationInsights` - A feature of Azure Monitor, is an extensible Application Performance Management service for developers and DevOps professionals to monitor their live applications.\n* `OpenStack` - An OpenStack target manages Virtual Machines, Physical Machines, Datacenters and Virtual Datacenters using different OpenStack services as administrative endpoints.\n* `MicrosoftSqlServer` - A Microsoft SQL database server that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this database.\n* `MySqlServer` - A MySQL database server that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this database.\n* `OracleDatabaseServer` - An Oracle database server that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this database.\n* `IBMWebSphereApplicationServer` - An IBM WebSphere Application server that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this application server.\n* `OracleWebLogicServer` - Oracle WebLogic Server is a unified and extensible platform for developing, deploying and running enterprise applications, such as Java, for on-premises and in the cloud. WebLogic Server offers a robust, mature, and scalable implementation of Java Enterprise Edition (EE) and Jakarta EE.\n* `ApacheTomcatServer` - An Apache Tomcat server that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this server.\n* `JavaVirtualMachine` - A JVM Application with JMX configured that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this application.\n* `RedHatJBossApplicationServer` - JBoss Application Server is an open-source, cross-platform Java application server developed by JBoss, a division of Red Hat Inc. It is an open-source implementation of Java 2 Enterprise Edition (J2EE) that is used for implementing Java applications and other Web-based applications and software.\n* `Kubernetes` - A Kubernetes cluster that runs containerized applications, with Kubernetes Collector installed. Cisco Intersight Workload Optimizer features are supported on Kubernetes cluster.\n* `AmazonWebService` - An Amazon Web Service cloud account.  Cisco Intersight Workload Optimizer and Virtualization features are supported on this cloud.\n* `AmazonWebServiceBilling` - An Amazon Web Service cloud billing account used to retrieve billing information stored in S3 bucket.  Cisco Intersight Workload Optimizer features are supported on this cloud.\n* `GoogleCloudPlatform` - A Google Cloud Platform service account with access to one or more projects.  Cisco Intersight Workload Optimizer features are supported on this cloud.\n* `GoogleCloudPlatformBilling` - A Google Cloud Platform service account used to retrieve billing information from BigQuery.  Cisco Intersight Workload Optimizer features are supported on this cloud.\n* `MicrosoftAzureServicePrincipal` - A Microsoft Azure Service Principal account with access to Azure subscriptions.  Cisco Intersight Workload Optimizer features are supported on this cloud.\n* `MicrosoftAzureEnterpriseAgreement` - A Microsoft Azure Enterprise Agreement enrolment used to retrieve pricing and billing information. Cisco Intersight Workload Optimizer features are supported on this cloud.\n* `MicrosoftAzureBilling` - A Microsoft Azure Service Principal account with access to billing information. Cisco Intersight Workload Optimizer features are supported on this cloud.\n* `DellCompellent` - A Dell EMC SC Series (Compellent) storage system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `HPE3Par` - A HPE 3PAR StoreServ system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `RedHatEnterpriseVirtualization` - A Red Hat Enterprise Virtualization Hypervisor system that manages Virtual Machines.\n* `NutanixAcropolis` - A Nutanix Acropolis cluster that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this cluster.\n* `HPEOneView` - A HPE OneView system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this system.\n* `ServiceEngine` - Cisco Application Services Engine. Cisco Application Services Engine is a platform to deploy and manage applications.\n* `HitachiVirtualStoragePlatform` - A Hitachi Virtual Storage Platform (Hitachi VSP) that is managed using Cisco Intersight Assist.\n* `GenericTarget` - A generic third-party target supported only in Partner Integration Appliance. This target type is used for development purposes and will not be supported in production environment.\n* `IMCBlade` - A Cisco UCS blade server managed by Cisco Intersight.\n* `TerraformCloud` - A Terraform Cloud Business Tier account.\n* `TerraformAgent` - A Terraform Cloud Agent that will be deployed on Cisco Intersight Assist. The agent can be used to plan and apply Terraform runs from a Terraform Cloud workspace.\n* `CustomTarget` - CustomTarget is deprecated.  Use HTTPEndpoint type to claim HTTP endpoints.\n* `AnsibleEndpoint` - An external endpoint that is added as a target  which can be accessed through Ansible in Intersight Cloud Orchestrator automation workflows.\n* `HTTPEndpoint` - An HTTP endpoint that can be accessed in Intersight Orchestrator workflows  directly or using Cisco Intersight Assist.  Authentication Schemes supported are Basic and Bearer Token.\n* `SSHEndpoint` - An SSH endpoint that can be accessed in Intersight Orchestrator workflows using Cisco Intersight Assist.\n* `CiscoCatalyst` - A Cisco Catalyst networking switch device.\n* `PowerShellEndpoint` - A Windows operating system server on which PowerShell scripts can be executed using Cisco Intersight Assist."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ApplianceDeviceClaim.PlatformTypeEnum PlatformType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"User defined claim request identifier set by the UI. The RequestId field is not a mandatory. The Intersight Appliance will assign a unique value automatically if the field is not set."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string RequestId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a resourceReservation resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.ResourceReservationRelationship Reservation
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
        /// <para type="description">"Username to log in to the endpoint device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Username
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.ApplianceDeviceClaim initObject = new Intersight.Model.ApplianceDeviceClaim();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Hostname"))
            {
                initObject.Hostname = this.Hostname;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IsRenew"))
            {
                initObject.IsRenew = this.IsRenew;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Password"))
            {
                initObject.Password = this.Password;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PlatformType"))
            {
                initObject.PlatformType = this.PlatformType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RequestId"))
            {
                initObject.RequestId = this.RequestId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Reservation"))
            {
                initObject.Reservation = this.Reservation;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Username"))
            {
                initObject.Username = this.Username;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ApplianceDeviceClusterInstall.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightApplianceDeviceClusterInstall")]
    public class InitializeIntersightApplianceDeviceClusterInstall : PSCmdlet
    {
        public InitializeIntersightApplianceDeviceClusterInstall()
        {
            ClassId = ApplianceDeviceClusterInstall.ClassIdEnum.ApplianceDeviceClusterInstall;
            ObjectType = ApplianceDeviceClusterInstall.ObjectTypeEnum.ApplianceDeviceClusterInstall;

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

        public ApplianceDeviceClusterInstall.ClassIdEnum ClassId
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ApplianceDeviceClusterInstall.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Start date of the software install. UI can modify startTime to re-schedule an install."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime StartTime
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

        protected override void ProcessRecord()
        {
            Intersight.Model.ApplianceDeviceClusterInstall initObject = new Intersight.Model.ApplianceDeviceClusterInstall();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("StartTime"))
            {
                initObject.StartTime = this.StartTime;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ApplianceDeviceUpgradePolicy.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightApplianceDeviceUpgradePolicy")]
    public class InitializeIntersightApplianceDeviceUpgradePolicy : PSCmdlet
    {
        public InitializeIntersightApplianceDeviceUpgradePolicy()
        {
            ClassId = ApplianceDeviceUpgradePolicy.ClassIdEnum.ApplianceDeviceUpgradePolicy;
            ObjectType = ApplianceDeviceUpgradePolicy.ObjectTypeEnum.ApplianceDeviceUpgradePolicy;
            SoftwareDownloadType = ApplianceDeviceUpgradePolicy.SoftwareDownloadTypeEnum.Unknown;

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
        /// <para type="description">"Indicates if the upgrade service is set to automatically start the software upgrade or not. If autoUpgrade is true, then the value of the schedule field is ignored."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool AutoUpgrade
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"If enabled, allows the user to define a blackout period during which the appliance will not be upgraded."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool BlackoutDatesEnabled
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"End date of the black out period."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime BlackoutEndDate
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Start date of the black out period. The appliance will not be upgraded during this period."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime BlackoutStartDate
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ApplianceDeviceUpgradePolicy.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Indicates if the updated metadata files should be synced immediately or at the next upgrade."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool EnableMetaDataSync
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ApplianceDeviceUpgradePolicy.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"User defined schedule for upgrading the Intersight Appliance software."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.OnpremSchedule Schedule
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"UpgradeType is used to indicate the kink of software upload to upgrade.\n* `unknown` - Indicates user setting of upgrade service to unknown.\n* `connected` - Indicates if the upgrade service is set to upload software to latest version automatically.\n* `manual` - Indicates if the upgrade service is set to upload software to user picked verison manually."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ApplianceDeviceUpgradePolicy.SoftwareDownloadTypeEnum SoftwareDownloadType
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

        protected override void ProcessRecord()
        {
            Intersight.Model.ApplianceDeviceUpgradePolicy initObject = new Intersight.Model.ApplianceDeviceUpgradePolicy();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AutoUpgrade"))
            {
                initObject.AutoUpgrade = this.AutoUpgrade;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BlackoutDatesEnabled"))
            {
                initObject.BlackoutDatesEnabled = this.BlackoutDatesEnabled;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BlackoutEndDate"))
            {
                initObject.BlackoutEndDate = this.BlackoutEndDate;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BlackoutStartDate"))
            {
                initObject.BlackoutStartDate = this.BlackoutStartDate;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("EnableMetaDataSync"))
            {
                initObject.EnableMetaDataSync = this.EnableMetaDataSync;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Schedule"))
            {
                initObject.Schedule = this.Schedule;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SoftwareDownloadType"))
            {
                initObject.SoftwareDownloadType = this.SoftwareDownloadType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ApplianceDiagSetting.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightApplianceDiagSetting")]
    public class InitializeIntersightApplianceDiagSetting : PSCmdlet
    {
        public InitializeIntersightApplianceDiagSetting()
        {
            ClassId = ApplianceDiagSetting.ClassIdEnum.ApplianceDiagSetting;
            ObjectType = ApplianceDiagSetting.ObjectTypeEnum.ApplianceDiagSetting;

        }
        // <summary>
        /// <para type="description">"A reference to a iamAccount resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IamAccountRelationship Account
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

        public ApplianceDiagSetting.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Status message of the password change operation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Message
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ApplianceDiagSetting.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Password of the Intersight Appliance's OS diagnostic user account."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Password
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

        protected override void ProcessRecord()
        {
            Intersight.Model.ApplianceDiagSetting initObject = new Intersight.Model.ApplianceDiagSetting();
            if (this.MyInvocation.BoundParameters.ContainsKey("Account"))
            {
                initObject.Account = this.Account;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Message"))
            {
                initObject.Message = this.Message;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Password"))
            {
                initObject.Password = this.Password;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ApplianceExternalSyslogSetting.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightApplianceExternalSyslogSetting")]
    public class InitializeIntersightApplianceExternalSyslogSetting : PSCmdlet
    {
        public InitializeIntersightApplianceExternalSyslogSetting()
        {
            ClassId = ApplianceExternalSyslogSetting.ClassIdEnum.ApplianceExternalSyslogSetting;
            ObjectType = ApplianceExternalSyslogSetting.ObjectTypeEnum.ApplianceExternalSyslogSetting;
            Protocol = ApplianceExternalSyslogSetting.ProtocolEnum.TCP;
            Severity = ApplianceExternalSyslogSetting.SeverityEnum.None;

        }
        // <summary>
        /// <para type="description">"A reference to a iamAccount resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IamAccountRelationship Account
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

        public ApplianceExternalSyslogSetting.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Enable or disable External Syslog Server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Enabled
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"If the flag is set, the alarms reported in Intersight Appliances are exported to external syslog server based on the alarm severity selection."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool ExportAlarms
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Enable or disable exporting of Audit logs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool ExportAudit
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Enable or disable exporting of Web Server access logs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool ExportNginx
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ApplianceExternalSyslogSetting.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"External Syslog Server Port for connection establishment."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 65535)]
        public long Port
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Protocol used to connect to external syslog server.\n* `TCP` - External Syslog messages sent over TCP.\n* `UDP` - External Syslog messages sent over UDP.\n* `TLS` - Secure External Syslog messages sent over TLS."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ApplianceExternalSyslogSetting.ProtocolEnum Protocol
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"External Syslog Server Address, can be IP address or hostname."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Server
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Minimum severity level to report.\n* `None` - The Enum value None represents that there is no severity.\n* `Info` - The Enum value Info represents the Informational level of severity.\n* `Critical` - The Enum value Critical represents the Critical level of severity.\n* `Warning` - The Enum value Warning represents the Warning level of severity.\n* `Cleared` - The Enum value Cleared represents that the alarm severity has been cleared."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ApplianceExternalSyslogSetting.SeverityEnum Severity
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

        protected override void ProcessRecord()
        {
            Intersight.Model.ApplianceExternalSyslogSetting initObject = new Intersight.Model.ApplianceExternalSyslogSetting();
            if (this.MyInvocation.BoundParameters.ContainsKey("Account"))
            {
                initObject.Account = this.Account;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Enabled"))
            {
                initObject.Enabled = this.Enabled;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ExportAlarms"))
            {
                initObject.ExportAlarms = this.ExportAlarms;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ExportAudit"))
            {
                initObject.ExportAudit = this.ExportAudit;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ExportNginx"))
            {
                initObject.ExportNginx = this.ExportNginx;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Server"))
            {
                initObject.Server = this.Server;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Severity"))
            {
                initObject.Severity = this.Severity;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ApplianceFileGateway.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightApplianceFileGateway")]
    public class InitializeIntersightApplianceFileGateway : PSCmdlet
    {
        public InitializeIntersightApplianceFileGateway()
        {
            ClassId = ApplianceFileGateway.ClassIdEnum.ApplianceFileGateway;
            ObjectType = ApplianceFileGateway.ObjectTypeEnum.ApplianceFileGateway;

        }
        // <summary>
        /// <para type="description">"A reference to a iamAccount resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IamAccountRelationship Account
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

        public ApplianceFileGateway.ClassIdEnum ClassId
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ApplianceFileGateway.ObjectTypeEnum ObjectType
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

        protected override void ProcessRecord()
        {
            Intersight.Model.ApplianceFileGateway initObject = new Intersight.Model.ApplianceFileGateway();
            if (this.MyInvocation.BoundParameters.ContainsKey("Account"))
            {
                initObject.Account = this.Account;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ApplianceFileSystemOpStatus.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightApplianceFileSystemOpStatus")]
    public class InitializeIntersightApplianceFileSystemOpStatus : PSCmdlet
    {
        public InitializeIntersightApplianceFileSystemOpStatus()
        {
            ClassId = ApplianceFileSystemOpStatus.ClassIdEnum.ApplianceFileSystemOpStatus;
            ObjectType = ApplianceFileSystemOpStatus.ObjectTypeEnum.ApplianceFileSystemOpStatus;

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

        public ApplianceFileSystemOpStatus.ClassIdEnum ClassId
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ApplianceFileSystemOpStatus.ObjectTypeEnum ObjectType
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

        protected override void ProcessRecord()
        {
            Intersight.Model.ApplianceFileSystemOpStatus initObject = new Intersight.Model.ApplianceFileSystemOpStatus();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ApplianceFileSystemStatus.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightApplianceFileSystemStatus")]
    public class InitializeIntersightApplianceFileSystemStatus : PSCmdlet
    {
        public InitializeIntersightApplianceFileSystemStatus()
        {
            ClassId = ApplianceFileSystemStatus.ClassIdEnum.ApplianceFileSystemStatus;
            ObjectType = ApplianceFileSystemStatus.ObjectTypeEnum.ApplianceFileSystemStatus;

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
        /// <para type="description">"Capacity of the file system in bytes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Capacity
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ApplianceFileSystemStatus.ClassIdEnum ClassId
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ApplianceFileSystemStatus.ObjectTypeEnum ObjectType
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

        protected override void ProcessRecord()
        {
            Intersight.Model.ApplianceFileSystemStatus initObject = new Intersight.Model.ApplianceFileSystemStatus();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Capacity"))
            {
                initObject.Capacity = this.Capacity;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ApplianceGroupOpStatus.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightApplianceGroupOpStatus")]
    public class InitializeIntersightApplianceGroupOpStatus : PSCmdlet
    {
        public InitializeIntersightApplianceGroupOpStatus()
        {
            ClassId = ApplianceGroupOpStatus.ClassIdEnum.ApplianceGroupOpStatus;
            ObjectType = ApplianceGroupOpStatus.ObjectTypeEnum.ApplianceGroupOpStatus;

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

        public ApplianceGroupOpStatus.ClassIdEnum ClassId
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ApplianceGroupOpStatus.ObjectTypeEnum ObjectType
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

        protected override void ProcessRecord()
        {
            Intersight.Model.ApplianceGroupOpStatus initObject = new Intersight.Model.ApplianceGroupOpStatus();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ApplianceGroupStatus.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightApplianceGroupStatus")]
    public class InitializeIntersightApplianceGroupStatus : PSCmdlet
    {
        public InitializeIntersightApplianceGroupStatus()
        {
            ClassId = ApplianceGroupStatus.ClassIdEnum.ApplianceGroupStatus;
            ObjectType = ApplianceGroupStatus.ObjectTypeEnum.ApplianceGroupStatus;

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

        public ApplianceGroupStatus.ClassIdEnum ClassId
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ApplianceGroupStatus.ObjectTypeEnum ObjectType
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

        protected override void ProcessRecord()
        {
            Intersight.Model.ApplianceGroupStatus initObject = new Intersight.Model.ApplianceGroupStatus();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ApplianceImageBundle.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightApplianceImageBundle")]
    public class InitializeIntersightApplianceImageBundle : PSCmdlet
    {
        public InitializeIntersightApplianceImageBundle()
        {
            ClassId = ApplianceImageBundle.ClassIdEnum.ApplianceImageBundle;
            ObjectType = ApplianceImageBundle.ObjectTypeEnum.ApplianceImageBundle;

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

        public ApplianceImageBundle.ClassIdEnum ClassId
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ApplianceImageBundle.ObjectTypeEnum ObjectType
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

        protected override void ProcessRecord()
        {
            Intersight.Model.ApplianceImageBundle initObject = new Intersight.Model.ApplianceImageBundle();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ApplianceKeyValuePair.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightApplianceKeyValuePair")]
    public class InitializeIntersightApplianceKeyValuePair : PSCmdlet
    {
        public InitializeIntersightApplianceKeyValuePair()
        {
            ClassId = ApplianceKeyValuePair.ClassIdEnum.ApplianceKeyValuePair;
            ObjectType = ApplianceKeyValuePair.ObjectTypeEnum.ApplianceKeyValuePair;

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

        public ApplianceKeyValuePair.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ApplianceKeyValuePair.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.ApplianceKeyValuePair initObject = new Intersight.Model.ApplianceKeyValuePair();
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
    /// <para type="synopsis">This is the cmdlet to Initialize ApplianceMetaManifest.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightApplianceMetaManifest")]
    public class InitializeIntersightApplianceMetaManifest : PSCmdlet
    {
        public InitializeIntersightApplianceMetaManifest()
        {
            ClassId = ApplianceMetaManifest.ClassIdEnum.ApplianceMetaManifest;
            ObjectType = ApplianceMetaManifest.ObjectTypeEnum.ApplianceMetaManifest;

        }
        // <summary>
        /// <para type="description">"A reference to a iamAccount resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IamAccountRelationship Account
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

        public ApplianceMetaManifest.ClassIdEnum ClassId
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ApplianceMetaManifest.ObjectTypeEnum ObjectType
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

        protected override void ProcessRecord()
        {
            Intersight.Model.ApplianceMetaManifest initObject = new Intersight.Model.ApplianceMetaManifest();
            if (this.MyInvocation.BoundParameters.ContainsKey("Account"))
            {
                initObject.Account = this.Account;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ApplianceNetworkLinkStatus.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightApplianceNetworkLinkStatus")]
    public class InitializeIntersightApplianceNetworkLinkStatus : PSCmdlet
    {
        public InitializeIntersightApplianceNetworkLinkStatus()
        {
            ClassId = ApplianceNetworkLinkStatus.ClassIdEnum.ApplianceNetworkLinkStatus;
            ObjectType = ApplianceNetworkLinkStatus.ObjectTypeEnum.ApplianceNetworkLinkStatus;

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

        public ApplianceNetworkLinkStatus.ClassIdEnum ClassId
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ApplianceNetworkLinkStatus.ObjectTypeEnum ObjectType
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

        protected override void ProcessRecord()
        {
            Intersight.Model.ApplianceNetworkLinkStatus initObject = new Intersight.Model.ApplianceNetworkLinkStatus();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ApplianceNetworkStatus.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightApplianceNetworkStatus")]
    public class InitializeIntersightApplianceNetworkStatus : PSCmdlet
    {
        public InitializeIntersightApplianceNetworkStatus()
        {
            ClassId = ApplianceNetworkStatus.ClassIdEnum.ApplianceNetworkStatus;
            ObjectType = ApplianceNetworkStatus.ObjectTypeEnum.ApplianceNetworkStatus;

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

        public ApplianceNetworkStatus.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ApplianceNetworkStatus.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.ApplianceNetworkStatus initObject = new Intersight.Model.ApplianceNetworkStatus();
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
    /// <para type="synopsis">This is the cmdlet to Initialize ApplianceNodeInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightApplianceNodeInfo")]
    public class InitializeIntersightApplianceNodeInfo : PSCmdlet
    {
        public InitializeIntersightApplianceNodeInfo()
        {
            ClassId = ApplianceNodeInfo.ClassIdEnum.ApplianceNodeInfo;
            ObjectType = ApplianceNodeInfo.ObjectTypeEnum.ApplianceNodeInfo;

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

        public ApplianceNodeInfo.ClassIdEnum ClassId
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ApplianceNodeInfo.ObjectTypeEnum ObjectType
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

        protected override void ProcessRecord()
        {
            Intersight.Model.ApplianceNodeInfo initObject = new Intersight.Model.ApplianceNodeInfo();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ApplianceNodeIpInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightApplianceNodeIpInfo")]
    public class InitializeIntersightApplianceNodeIpInfo : PSCmdlet
    {
        public InitializeIntersightApplianceNodeIpInfo()
        {
            ClassId = ApplianceNodeIpInfo.ClassIdEnum.ApplianceNodeIpInfo;
            ObjectType = ApplianceNodeIpInfo.ObjectTypeEnum.ApplianceNodeIpInfo;

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

        public ApplianceNodeIpInfo.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ApplianceNodeIpInfo.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.ApplianceNodeIpInfo initObject = new Intersight.Model.ApplianceNodeIpInfo();
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
    /// <para type="synopsis">This is the cmdlet to Initialize ApplianceNodeOpStatus.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightApplianceNodeOpStatus")]
    public class InitializeIntersightApplianceNodeOpStatus : PSCmdlet
    {
        public InitializeIntersightApplianceNodeOpStatus()
        {
            ClassId = ApplianceNodeOpStatus.ClassIdEnum.ApplianceNodeOpStatus;
            ObjectType = ApplianceNodeOpStatus.ObjectTypeEnum.ApplianceNodeOpStatus;

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

        public ApplianceNodeOpStatus.ClassIdEnum ClassId
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ApplianceNodeOpStatus.ObjectTypeEnum ObjectType
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

        protected override void ProcessRecord()
        {
            Intersight.Model.ApplianceNodeOpStatus initObject = new Intersight.Model.ApplianceNodeOpStatus();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ApplianceNodeStatus.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightApplianceNodeStatus")]
    public class InitializeIntersightApplianceNodeStatus : PSCmdlet
    {
        public InitializeIntersightApplianceNodeStatus()
        {
            ClassId = ApplianceNodeStatus.ClassIdEnum.ApplianceNodeStatus;
            ObjectType = ApplianceNodeStatus.ObjectTypeEnum.ApplianceNodeStatus;

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

        public ApplianceNodeStatus.ClassIdEnum ClassId
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ApplianceNodeStatus.ObjectTypeEnum ObjectType
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

        protected override void ProcessRecord()
        {
            Intersight.Model.ApplianceNodeStatus initObject = new Intersight.Model.ApplianceNodeStatus();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ApplianceReleaseNote.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightApplianceReleaseNote")]
    public class InitializeIntersightApplianceReleaseNote : PSCmdlet
    {
        public InitializeIntersightApplianceReleaseNote()
        {
            ClassId = ApplianceReleaseNote.ClassIdEnum.ApplianceReleaseNote;
            ObjectType = ApplianceReleaseNote.ObjectTypeEnum.ApplianceReleaseNote;

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

        public ApplianceReleaseNote.ClassIdEnum ClassId
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ApplianceReleaseNote.ObjectTypeEnum ObjectType
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

        protected override void ProcessRecord()
        {
            Intersight.Model.ApplianceReleaseNote initObject = new Intersight.Model.ApplianceReleaseNote();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ApplianceRemoteFileImport.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightApplianceRemoteFileImport")]
    public class InitializeIntersightApplianceRemoteFileImport : PSCmdlet
    {
        public InitializeIntersightApplianceRemoteFileImport()
        {
            ClassId = ApplianceRemoteFileImport.ClassIdEnum.ApplianceRemoteFileImport;
            ObjectType = ApplianceRemoteFileImport.ObjectTypeEnum.ApplianceRemoteFileImport;
            Protocol = ApplianceRemoteFileImport.ProtocolEnum.Scp;

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

        public ApplianceRemoteFileImport.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the file to be imported."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Filename
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The hostname of the machine where the file is located."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Hostname
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ApplianceRemoteFileImport.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Password for remote requiest."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Password
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The port that should be used for the remote request."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Path
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The port that should be used for the remote request."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Port
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Specifies if this is an scp or sftp request.\n* `scp` - Secure Copy Protocol (SCP) to access the file server.\n* `sftp` - SSH File Transfer Protocol (SFTP) to access file server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ApplianceRemoteFileImport.ProtocolEnum Protocol
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
        /// <para type="description">"The username for the remote request."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Username
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.ApplianceRemoteFileImport initObject = new Intersight.Model.ApplianceRemoteFileImport();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Filename"))
            {
                initObject.Filename = this.Filename;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Hostname"))
            {
                initObject.Hostname = this.Hostname;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Password"))
            {
                initObject.Password = this.Password;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Path"))
            {
                initObject.Path = this.Path;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Port"))
            {
                initObject.Port = this.Port;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Protocol"))
            {
                initObject.Protocol = this.Protocol;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Username"))
            {
                initObject.Username = this.Username;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ApplianceRestore.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightApplianceRestore")]
    public class InitializeIntersightApplianceRestore : PSCmdlet
    {
        public InitializeIntersightApplianceRestore()
        {
            ClassId = ApplianceRestore.ClassIdEnum.ApplianceRestore;
            ObjectType = ApplianceRestore.ObjectTypeEnum.ApplianceRestore;
            Protocol = ApplianceRestore.ProtocolEnum.Scp;

        }
        // <summary>
        /// <para type="description">"A reference to a iamAccount resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IamAccountRelationship Account
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

        public ApplianceRestore.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Backup filename to backup or restore."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9][a-zA-Z0-9_\\.\\-\\+]*$")]
        public string Filename
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> Messages
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ApplianceRestore.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Password for authenticating with the file server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[^`]+$")]
        public string Password
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Communication protocol used by the file server (e.g. scp or sftp).\n* `scp` - Secure Copy Protocol (SCP) to access the file server.\n* `sftp` - SSH File Transfer Protocol (SFTP) to access file server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ApplianceRestore.ProtocolEnum Protocol
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Hostname of the remote file server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string RemoteHost
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"File server directory to copy the file."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^(/[^/ ]*)+/?$")]
        public string RemotePath
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Remote TCP port on the file server (e.g. 22 for scp)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long RemotePort
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
        /// <para type="description">"Username to authenticate the fileserver."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9_][a-zA-Z0-9_\\.\\@\\\\\\-\\+]*$")]
        public string Username
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.ApplianceRestore initObject = new Intersight.Model.ApplianceRestore();
            if (this.MyInvocation.BoundParameters.ContainsKey("Account"))
            {
                initObject.Account = this.Account;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Filename"))
            {
                initObject.Filename = this.Filename;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Messages"))
            {
                initObject.Messages = this.Messages;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Password"))
            {
                initObject.Password = this.Password;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Protocol"))
            {
                initObject.Protocol = this.Protocol;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RemoteHost"))
            {
                initObject.RemoteHost = this.RemoteHost;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RemotePath"))
            {
                initObject.RemotePath = this.RemotePath;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RemotePort"))
            {
                initObject.RemotePort = this.RemotePort;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Username"))
            {
                initObject.Username = this.Username;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ApplianceSetupInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightApplianceSetupInfo")]
    public class InitializeIntersightApplianceSetupInfo : PSCmdlet
    {
        public InitializeIntersightApplianceSetupInfo()
        {
            ClassId = ApplianceSetupInfo.ClassIdEnum.ApplianceSetupInfo;
            ObjectType = ApplianceSetupInfo.ObjectTypeEnum.ApplianceSetupInfo;

        }
        // <summary>
        /// <para type="description">"A reference to a iamAccount resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IamAccountRelationship Account
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

        public ApplianceSetupInfo.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The minimum cpu required of the node in cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long MinCpu
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The minimum ram required of the node in cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long MinRam
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ApplianceSetupInfo.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> SetupStates
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

        protected override void ProcessRecord()
        {
            Intersight.Model.ApplianceSetupInfo initObject = new Intersight.Model.ApplianceSetupInfo();
            if (this.MyInvocation.BoundParameters.ContainsKey("Account"))
            {
                initObject.Account = this.Account;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("MinCpu"))
            {
                initObject.MinCpu = this.MinCpu;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MinRam"))
            {
                initObject.MinRam = this.MinRam;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("SetupStates"))
            {
                initObject.SetupStates = this.SetupStates;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ApplianceStatusCheck.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightApplianceStatusCheck")]
    public class InitializeIntersightApplianceStatusCheck : PSCmdlet
    {
        public InitializeIntersightApplianceStatusCheck()
        {
            ClassId = ApplianceStatusCheck.ClassIdEnum.ApplianceStatusCheck;
            ObjectType = ApplianceStatusCheck.ObjectTypeEnum.ApplianceStatusCheck;
            Result = ApplianceStatusCheck.ResultEnum.OK;

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

        public ApplianceStatusCheck.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Unique identifier of the status check."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Code
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ApplianceStatusCheck.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Result of this status check.\n* `OK` - Result of the check is OK.\n* `Warning` - Result of the check is Warning.\n* `Critical` - Result of the check is Critical.\n* `Info` - Result of the check is low."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ApplianceStatusCheck.ResultEnum Result
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.ApplianceStatusCheck initObject = new Intersight.Model.ApplianceStatusCheck();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Code"))
            {
                initObject.Code = this.Code;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Result"))
            {
                initObject.Result = this.Result;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ApplianceSystemInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightApplianceSystemInfo")]
    public class InitializeIntersightApplianceSystemInfo : PSCmdlet
    {
        public InitializeIntersightApplianceSystemInfo()
        {
            ClassId = ApplianceSystemInfo.ClassIdEnum.ApplianceSystemInfo;
            ObjectType = ApplianceSystemInfo.ObjectTypeEnum.ApplianceSystemInfo;
            TimeZone = ApplianceSystemInfo.TimeZoneEnum.PacificNiue;

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

        public ApplianceSystemInfo.ClassIdEnum ClassId
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ApplianceSystemInfo.ObjectTypeEnum ObjectType
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
        /// <para type="description">"Timezone of the Intersight Appliance.\n* `Pacific/Niue` - \n* `Pacific/Pago_Pago` - \n* `Pacific/Honolulu` - \n* `Pacific/Rarotonga` - \n* `Pacific/Tahiti` - \n* `Pacific/Marquesas` - \n* `America/Anchorage` - \n* `Pacific/Gambier` - \n* `America/Los_Angeles` - \n* `America/Tijuana` - \n* `America/Vancouver` - \n* `America/Whitehorse` - \n* `Pacific/Pitcairn` - \n* `America/Dawson_Creek` - \n* `America/Denver` - \n* `America/Edmonton` - \n* `America/Hermosillo` - \n* `America/Mazatlan` - \n* `America/Phoenix` - \n* `America/Yellowknife` - \n* `America/Belize` - \n* `America/Chicago` - \n* `America/Costa_Rica` - \n* `America/El_Salvador` - \n* `America/Guatemala` - \n* `America/Managua` - \n* `America/Mexico_City` - \n* `America/Regina` - \n* `America/Tegucigalpa` - \n* `America/Winnipeg` - \n* `Pacific/Galapagos` - \n* `America/Bogota` - \n* `America/Cancun` - \n* `America/Cayman` - \n* `America/Guayaquil` - \n* `America/Havana` - \n* `America/Iqaluit` - \n* `America/Jamaica` - \n* `America/Lima` - \n* `America/Nassau` - \n* `America/New_York` - \n* `America/Nuuk` - \n* `America/Panama` - \n* `America/Port-au-Prince` - \n* `America/Rio_Branco` - \n* `America/Toronto` - \n* `Pacific/Easter` - \n* `America/Caracas` - \n* `America/Asuncion` - \n* `America/Barbados` - \n* `America/Boa_Vista` - \n* `America/Campo_Grande` - \n* `America/Cuiaba` - \n* `America/Curacao` - \n* `America/Grand_Turk` - \n* `America/Guyana` - \n* `America/Halifax` - \n* `America/La_Paz` - \n* `America/Manaus` - \n* `America/Martinique` - \n* `America/Port_of_Spain` - \n* `America/Porto_Velho` - \n* `America/Puerto_Rico` - \n* `America/Santo_Domingo` - \n* `America/Thule` - \n* `Atlantic/Bermuda` - \n* `America/St_Johns` - \n* `America/Araguaina` - \n* `America/Argentina/Buenos_Aires` - \n* `America/Bahia` - \n* `America/Belem` - \n* `America/Cayenne` - \n* `America/Fortaleza` - \n* `America/Godthab` - \n* `America/Maceio` - \n* `America/Miquelon` - \n* `America/Montevideo` - \n* `America/Paramaribo` - \n* `America/Recife` - \n* `America/Santiago` - \n* `America/Sao_Paulo` - \n* `Antarctica/Palmer` - \n* `Antarctica/Rothera` - \n* `Atlantic/Stanley` - \n* `America/Noronha` - \n* `Atlantic/South_Georgia` - \n* `America/Scoresbysund` - \n* `Atlantic/Azores` - \n* `Atlantic/Cape_Verde` - \n* `Africa/Abidjan` - \n* `Africa/Accra` - \n* `Africa/Bissau` - \n* `Africa/Casablanca` - \n* `Africa/El_Aaiun` - \n* `Africa/Monrovia` - \n* `America/Danmarkshavn` - \n* `Atlantic/Canary` - \n* `Atlantic/Faroe` - \n* `Atlantic/Reykjavik` - \n* `Etc/GMT` - \n* `Europe/Dublin` - \n* `Europe/Lisbon` - \n* `Europe/London` - \n* `Africa/Algiers` - \n* `Africa/Ceuta` - \n* `Africa/Lagos` - \n* `Africa/Ndjamena` - \n* `Africa/Tunis` - \n* `Africa/Windhoek` - \n* `Europe/Amsterdam` - \n* `Europe/Andorra` - \n* `Europe/Belgrade` - \n* `Europe/Berlin` - \n* `Europe/Brussels` - \n* `Europe/Budapest` - \n* `Europe/Copenhagen` - \n* `Europe/Gibraltar` - \n* `Europe/Luxembourg` - \n* `Europe/Madrid` - \n* `Europe/Malta` - \n* `Europe/Monaco` - \n* `Europe/Oslo` - \n* `Europe/Paris` - \n* `Europe/Prague` - \n* `Europe/Rome` - \n* `Europe/Stockholm` - \n* `Europe/Tirane` - \n* `Europe/Vienna` - \n* `Europe/Warsaw` - \n* `Europe/Zurich` - \n* `Africa/Cairo` - \n* `Africa/Johannesburg` - \n* `Africa/Maputo` - \n* `Africa/Tripoli` - \n* `Asia/Amman` - \n* `Asia/Beirut` - \n* `Asia/Damascus` - \n* `Asia/Gaza` - \n* `Asia/Jerusalem` - \n* `Asia/Nicosia` - \n* `Europe/Athens` - \n* `Europe/Bucharest` - \n* `Europe/Chisinau` - \n* `Europe/Helsinki` - \n* `Europe/Istanbul` - \n* `Europe/Kaliningrad` - \n* `Europe/Kiev` - \n* `Europe/Riga` - \n* `Europe/Sofia` - \n* `Europe/Tallinn` - \n* `Europe/Vilnius` - \n* `Africa/Khartoum` - \n* `Africa/Nairobi` - \n* `Antarctica/Syowa` - \n* `Asia/Baghdad` - \n* `Asia/Qatar` - \n* `Asia/Riyadh` - \n* `Europe/Minsk` - \n* `Europe/Moscow` - \n* `Asia/Tehran` - \n* `Asia/Baku` - \n* `Asia/Dubai` - \n* `Asia/Tbilisi` - \n* `Asia/Yerevan` - \n* `Europe/Samara` - \n* `Indian/Mahe` - \n* `Indian/Mauritius` - \n* `Indian/Reunion` - \n* `Asia/Kabul` - \n* `Antarctica/Mawson` - \n* `Asia/Aqtau` - \n* `Asia/Aqtobe` - \n* `Asia/Ashgabat` - \n* `Asia/Dushanbe` - \n* `Asia/Karachi` - \n* `Asia/Tashkent` - \n* `Asia/Yekaterinburg` - \n* `Indian/Kerguelen` - \n* `Indian/Maldives` - \n* `Asia/Calcutta` - \n* `Asia/Kolkata` - \n* `Asia/Colombo` - \n* `Asia/Kathmandu` - \n* `Asia/Katmandu` - \n* `Antarctica/Vostok` - \n* `Asia/Almaty` - \n* `Asia/Bishkek` - \n* `Asia/Dhaka` - \n* `Asia/Omsk` - \n* `Asia/Thimphu` - \n* `Indian/Chagos` - \n* `Asia/Rangoon` - \n* `Indian/Cocos` - \n* `Antarctica/Davis` - \n* `Asia/Bangkok` - \n* `Asia/Ho_Chi_Minh` - \n* `Asia/Hovd` - \n* `Asia/Jakarta` - \n* `Asia/Krasnoyarsk` - \n* `Asia/Saigon` - \n* `Indian/Christmas` - \n* `Antarctica/Casey` - \n* `Asia/Brunei` - \n* `Asia/Choibalsan` - \n* `Asia/Hong_Kong` - \n* `Asia/Irkutsk` - \n* `Asia/Kuala_Lumpur` - \n* `Asia/Macau` - \n* `Asia/Makassar` - \n* `Asia/Manila` - \n* `Asia/Shanghai` - \n* `Asia/Singapore` - \n* `Asia/Taipei` - \n* `Asia/Ulaanbaatar` - \n* `Australia/Perth` - \n* `Asia/Pyongyang` - \n* `Asia/Dili` - \n* `Asia/Jayapura` - \n* `Asia/Seoul` - \n* `Asia/Tokyo` - \n* `Asia/Yakutsk` - \n* `Asia/Yangon` - \n* `Pacific/Palau` - \n* `Australia/Adelaide` - \n* `Australia/Darwin` - \n* `Antarctica/DumontDUrville` - \n* `Asia/Magadan` - \n* `Asia/Vladivostok` - \n* `Australia/Brisbane` - \n* `Australia/Hobart` - \n* `Australia/Sydney` - \n* `Pacific/Chuuk` - \n* `Pacific/Guam` - \n* `Pacific/Port_Moresby` - \n* `Pacific/Efate` - \n* `Pacific/Guadalcanal` - \n* `Pacific/Kosrae` - \n* `Pacific/Norfolk` - \n* `Pacific/Noumea` - \n* `Pacific/Pohnpei` - \n* `Asia/Kamchatka` - \n* `Pacific/Auckland` - \n* `Pacific/Fiji` - \n* `Pacific/Funafuti` - \n* `Pacific/Kwajalein` - \n* `Pacific/Majuro` - \n* `Pacific/Nauru` - \n* `Pacific/Tarawa` - \n* `Pacific/Wake` - \n* `Pacific/Wallis` - \n* `Pacific/Apia` - \n* `Pacific/Enderbury` - \n* `Pacific/Fakaofo` - \n* `Pacific/Tongatapu` - \n* `Pacific/Kiritimati` - \n* `UTC` -"</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ApplianceSystemInfo.TimeZoneEnum TimeZone
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.ApplianceSystemInfo initObject = new Intersight.Model.ApplianceSystemInfo();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TimeZone"))
            {
                initObject.TimeZone = this.TimeZone;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ApplianceSystemOpStatus.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightApplianceSystemOpStatus")]
    public class InitializeIntersightApplianceSystemOpStatus : PSCmdlet
    {
        public InitializeIntersightApplianceSystemOpStatus()
        {
            ClassId = ApplianceSystemOpStatus.ClassIdEnum.ApplianceSystemOpStatus;
            ObjectType = ApplianceSystemOpStatus.ObjectTypeEnum.ApplianceSystemOpStatus;

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

        public ApplianceSystemOpStatus.ClassIdEnum ClassId
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ApplianceSystemOpStatus.ObjectTypeEnum ObjectType
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

        protected override void ProcessRecord()
        {
            Intersight.Model.ApplianceSystemOpStatus initObject = new Intersight.Model.ApplianceSystemOpStatus();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ApplianceSystemStatus.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightApplianceSystemStatus")]
    public class InitializeIntersightApplianceSystemStatus : PSCmdlet
    {
        public InitializeIntersightApplianceSystemStatus()
        {
            ClassId = ApplianceSystemStatus.ClassIdEnum.ApplianceSystemStatus;
            ObjectType = ApplianceSystemStatus.ObjectTypeEnum.ApplianceSystemStatus;

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

        public ApplianceSystemStatus.ClassIdEnum ClassId
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ApplianceSystemStatus.ObjectTypeEnum ObjectType
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

        protected override void ProcessRecord()
        {
            Intersight.Model.ApplianceSystemStatus initObject = new Intersight.Model.ApplianceSystemStatus();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ApplianceUpgrade.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightApplianceUpgrade")]
    public class InitializeIntersightApplianceUpgrade : PSCmdlet
    {
        public InitializeIntersightApplianceUpgrade()
        {
            ClassId = ApplianceUpgrade.ClassIdEnum.ApplianceUpgrade;
            ObjectType = ApplianceUpgrade.ObjectTypeEnum.ApplianceUpgrade;

        }
        // <summary>
        /// <para type="description">"A reference to a iamAccount resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IamAccountRelationship Account
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

        public ApplianceUpgrade.ClassIdEnum ClassId
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ApplianceUpgrade.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Track if rollback is needed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool RollbackNeeded
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Start date of the software upgrade. UI can modify startTime to re-schedule an upgrade."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime StartTime
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

        protected override void ProcessRecord()
        {
            Intersight.Model.ApplianceUpgrade initObject = new Intersight.Model.ApplianceUpgrade();
            if (this.MyInvocation.BoundParameters.ContainsKey("Account"))
            {
                initObject.Account = this.Account;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("RollbackNeeded"))
            {
                initObject.RollbackNeeded = this.RollbackNeeded;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("StartTime"))
            {
                initObject.StartTime = this.StartTime;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ApplianceUpgradePolicy.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightApplianceUpgradePolicy")]
    public class InitializeIntersightApplianceUpgradePolicy : PSCmdlet
    {
        public InitializeIntersightApplianceUpgradePolicy()
        {
            ClassId = ApplianceUpgradePolicy.ClassIdEnum.ApplianceUpgradePolicy;
            ObjectType = ApplianceUpgradePolicy.ObjectTypeEnum.ApplianceUpgradePolicy;
            SoftwareDownloadType = ApplianceUpgradePolicy.SoftwareDownloadTypeEnum.Unknown;

        }
        // <summary>
        /// <para type="description">"A reference to a iamAccount resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IamAccountRelationship Account
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
        /// <para type="description">"Indicates if the upgrade service is set to automatically start the software upgrade or not. If autoUpgrade is true, then the value of the schedule field is ignored."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool AutoUpgrade
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"If enabled, allows the user to define a blackout period during which the appliance will not be upgraded."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool BlackoutDatesEnabled
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"End date of the black out period."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime BlackoutEndDate
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Start date of the black out period. The appliance will not be upgraded during this period."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime BlackoutStartDate
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ApplianceUpgradePolicy.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Indicates if the updated metadata files should be synced immediately or at the next upgrade."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool EnableMetaDataSync
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Intersight Appliance manual upgrade start time."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime ManualInstallationStartTime
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ApplianceUpgradePolicy.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"User defined schedule for upgrading the Intersight Appliance software."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.OnpremSchedule Schedule
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"SoftwareDownloadType is used to indicate the kind of software download.\n* `unknown` - Indicates user setting of upgrade service to unknown.\n* `connected` - Indicates if the upgrade service is set to upload software to latest version automatically.\n* `manual` - Indicates if the upgrade service is set to upload software to user picked verison manually."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ApplianceUpgradePolicy.SoftwareDownloadTypeEnum SoftwareDownloadType
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

        protected override void ProcessRecord()
        {
            Intersight.Model.ApplianceUpgradePolicy initObject = new Intersight.Model.ApplianceUpgradePolicy();
            if (this.MyInvocation.BoundParameters.ContainsKey("Account"))
            {
                initObject.Account = this.Account;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AutoUpgrade"))
            {
                initObject.AutoUpgrade = this.AutoUpgrade;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BlackoutDatesEnabled"))
            {
                initObject.BlackoutDatesEnabled = this.BlackoutDatesEnabled;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BlackoutEndDate"))
            {
                initObject.BlackoutEndDate = this.BlackoutEndDate;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BlackoutStartDate"))
            {
                initObject.BlackoutStartDate = this.BlackoutStartDate;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("EnableMetaDataSync"))
            {
                initObject.EnableMetaDataSync = this.EnableMetaDataSync;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ManualInstallationStartTime"))
            {
                initObject.ManualInstallationStartTime = this.ManualInstallationStartTime;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Schedule"))
            {
                initObject.Schedule = this.Schedule;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SoftwareDownloadType"))
            {
                initObject.SoftwareDownloadType = this.SoftwareDownloadType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
}