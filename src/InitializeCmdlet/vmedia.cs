using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VmediaMapping.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVmediaMapping")]
    public class InitializeIntersightVmediaMapping:PSCmdlet
	{
		public InitializeIntersightVmediaMapping()
		{
            AuthenticationProtocol = VmediaMapping.AuthenticationProtocolEnum.None;
            ClassId = VmediaMapping.ClassIdEnum.VmediaMapping;
            DeviceType = VmediaMapping.DeviceTypeEnum.Cdd;
            MountProtocol = VmediaMapping.MountProtocolEnum.Nfs;
            ObjectType = VmediaMapping.ObjectTypeEnum.VmediaMapping;
            
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
        /// <para type="description">"Type of Authentication protocol when CIFS is used for communication with the remote server.\n* `none` - No authentication is used.\n* `ntlm` - NT LAN Manager (NTLM) security protocol. Use this option only with Windows 2008 R2 and Windows 2012 R2.\n* `ntlmi` - NTLMi security protocol. Use this option only when you enable Digital Signing in the CIFS Windows server.\n* `ntlmv2` - NTLMv2 security protocol. Use this option only with Samba Linux.\n* `ntlmv2i` - NTLMv2i security protocol. Use this option only with Samba Linux.\n* `ntlmssp` - NT LAN Manager Security Support Provider (NTLMSSP) protocol. Use this option only with Windows 2008 R2 and Windows 2012 R2.\n* `ntlmsspi` - NTLMSSPi protocol. Use this option only when you enable Digital Signing in the CIFS Windows server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VmediaMapping.AuthenticationProtocolEnum AuthenticationProtocol {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VmediaMapping.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of remote Virtual Media device.\n* `cdd` - Uses compact disc drive as the virtual media mount device.\n* `hdd` - Uses hard disk drive as the virtual media mount device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VmediaMapping.DeviceTypeEnum DeviceType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Remote location of image. Preferred format is 'hostname/filePath/fileName'."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string FileLocation {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"IP address or hostname of the remote server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string HostName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Mount options for the Virtual Media mapping. The field can be left blank or filled in a comma separated list with the following options.\\n For NFS, supported options are ro, rw, nolock, noexec, soft, port=VALUE, timeo=VALUE, retry=VALUE.\\n For CIFS, supported options are soft, nounix, noserverino, guest.\\n For CIFS version < 3.0, vers=VALUE is mandatory. e.g. vers=2.0\\n For HTTP/HTTPS, the only supported option is noauto."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string MountOptions {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Protocol to use to communicate with the remote server.\n* `nfs` - NFS protocol for vmedia mount.\n* `cifs` - CIFS protocol for vmedia mount.\n* `http` - HTTP protocol for vmedia mount.\n* `https` - HTTPS protocol for vmedia mount."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VmediaMapping.MountProtocolEnum MountProtocol {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VmediaMapping.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Password associated with the username."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Password {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The remote file location path for the virtual media mapping. Accepted formats are:\nHDD for CIFS/NFS: hostname-or-IP/filePath/fileName.img.\nCDD for CIFS/NFS: hostname-or-IP/filePath/fileName.iso.\nHDD for HTTP/S: http[s]://hostname-or-IP/filePath/fileName.img.\nCDD for HTTP/S: http[s]://hostname-or-IP/filePath/fileName.iso."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[ !#$%\\(\\)\\+,\\-\\.:\\?@\\[\\]_\\{\\}=~a-zA-Z0-9]+$")]
        public string RemoteFile {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"URL path to the location of the image on the remote server. The preferred format is '/path'."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[ !#$%\\(\\)\\+,\\-\\.\\/:\\?@\\[\\]_\\{\\}=~a-zA-Z0-9]+$")]
        public string RemotePath {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Username to log in to the remote server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Username {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Identity of the image for Virtual Media mapping."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[\\-\\.:_a-zA-Z0-9]+$")]
        public string VolumeName {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.VmediaMapping initObject = new Intersight.Model.VmediaMapping();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AuthenticationProtocol"))
            {
                initObject.AuthenticationProtocol = this.AuthenticationProtocol;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("DeviceType"))
            {
                initObject.DeviceType = this.DeviceType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FileLocation"))
            {
                initObject.FileLocation = this.FileLocation;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HostName"))
            {
                initObject.HostName = this.HostName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MountOptions"))
            {
                initObject.MountOptions = this.MountOptions;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MountProtocol"))
            {
                initObject.MountProtocol = this.MountProtocol;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Password"))
            {
                initObject.Password = this.Password;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RemoteFile"))
            {
                initObject.RemoteFile = this.RemoteFile;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RemotePath"))
            {
                initObject.RemotePath = this.RemotePath;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Username"))
            {
                initObject.Username = this.Username;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VolumeName"))
            {
                initObject.VolumeName = this.VolumeName;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VmediaPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVmediaPolicy")]
    public class InitializeIntersightVmediaPolicy:PSCmdlet
	{
		public InitializeIntersightVmediaPolicy()
		{
            ClassId = VmediaPolicy.ClassIdEnum.VmediaPolicy;
            ObjectType = VmediaPolicy.ObjectTypeEnum.VmediaPolicy;
            
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
        
        public VmediaPolicy.ClassIdEnum ClassId {
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
        /// <para type="description">"State of the Virtual Media service on the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Enabled {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"If enabled, allows encryption of all Virtual Media communications. Please note that this is no longer applicable for servers running versions 4.2 and above."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Encryption {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"If enabled, the virtual drives appear on the boot selection menu after mapping the image and rebooting the host."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool LowPowerUsb {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Model.VmediaMapping> Mappings {
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VmediaPolicy.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.OrganizationOrganizationRelationship Organization {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to policyAbstractConfigProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Model.PolicyAbstractConfigProfileRelationship> Profiles {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Model.MoTag> Tags {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.VmediaPolicy initObject = new Intersight.Model.VmediaPolicy();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Enabled"))
            {
                initObject.Enabled = this.Enabled;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Encryption"))
            {
                initObject.Encryption = this.Encryption;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LowPowerUsb"))
            {
                initObject.LowPowerUsb = this.LowPowerUsb;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Mappings"))
            {
                initObject.Mappings = this.Mappings;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
}