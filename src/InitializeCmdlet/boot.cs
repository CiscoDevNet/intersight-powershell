using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize BootIscsi.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightBootIscsi")]
    public class InitializeIntersightBootIscsi:PSCmdlet
	{
		public InitializeIntersightBootIscsi()
		{
            ClassId = BootIscsi.ClassIdEnum.BootIscsi;
            ObjectType = BootIscsi.ObjectTypeEnum.BootIscsi;
            
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
        /// <para type="description">"Details of the bootloader to be used during iSCSI boot."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.BootBootloader Bootloader {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public BootIscsi.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Specifies if the boot device is enabled or disabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Enabled {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the underlying virtual ethernet interface used by the iSCSI boot device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9-._:]*$")]
        public string InterfaceName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A name that helps identify a boot device. It can be any string that adheres to the following constraints. It should start and end with an alphanumeric character. It can have underscores and hyphens. It cannot be more than 30 characters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("((^[a-zA-Z0-9]$){1,30}|(^(([a-zA-Z0-9])([a-zA-Z0-9_\\-]{0,28})([a-zA-Z0-9]))$))")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public BootIscsi.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Port ID of the ISCSI boot device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Port {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The slot id of the device. Supported values are (1 - 255, \"MLOM\", \"L\", \"L1\", \"L2\", \"OCP\")."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5]|L|MLOM|L1|L2|OCP)$")]
        public string Slot {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.BootIscsi initObject = new Intersight.Model.BootIscsi();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Bootloader"))
            {
                initObject.Bootloader = this.Bootloader;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Enabled"))
            {
                initObject.Enabled = this.Enabled;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InterfaceName"))
            {
                initObject.InterfaceName = this.InterfaceName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Port"))
            {
                initObject.Port = this.Port;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Slot"))
            {
                initObject.Slot = this.Slot;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize BootPxe.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightBootPxe")]
    public class InitializeIntersightBootPxe:PSCmdlet
	{
		public InitializeIntersightBootPxe()
		{
            ClassId = BootPxe.ClassIdEnum.BootPxe;
            InterfaceSource = BootPxe.InterfaceSourceEnum.Name;
            IpType = BootPxe.IpTypeEnum.None;
            ObjectType = BootPxe.ObjectTypeEnum.BootPxe;
            
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
        
        public BootPxe.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Specifies if the boot device is enabled or disabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Enabled {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the underlying virtual ethernet interface used by the PXE boot device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9-._:]*$")]
        public string InterfaceName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Lists the supported Interface Source for PXE device. Supported values are \"name\" and \"mac\".\n* `name` - Use interface name to select virtual ethernet interface.\n* `mac` - Use MAC address to select virtual ethernet interface.\n* `port` - Use port to select virtual ethernet interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public BootPxe.InterfaceSourceEnum InterfaceSource {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The IP Address family type to use during the PXE Boot process.\n* `None` - Default value if IpType is not specified.\n* `IPv4` - The IPv4 address family type.\n* `IPv6` - The IPv6 address family type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public BootPxe.IpTypeEnum IpType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The MAC Address of the underlying virtual ethernet interface used by the PXE boot device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^(((\\d|([a-f]|[A-F])){2}:){5}(\\d|([a-f]|[A-F])){2})$")]
        public string MacAddress {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A name that helps identify a boot device. It can be any string that adheres to the following constraints. It should start and end with an alphanumeric character. It can have underscores and hyphens. It cannot be more than 30 characters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("((^[a-zA-Z0-9]$){1,30}|(^(([a-zA-Z0-9])([a-zA-Z0-9_\\-]{0,28})([a-zA-Z0-9]))$))")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public BootPxe.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Port ID of the adapter on which the underlying virtual ethernet interface is present. If no port is specified, the default value is -1. Supported values are -1 to 255."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(-1, 255)]
        public long Port {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The slot ID of the adapter on which the underlying virtual ethernet interface is present. Supported values are ( 1 - 255, \"MLOM\", \"L\", \"L1\", \"L2\", \"OCP\")."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5]|L|MLOM|L1|L2|OCP)$")]
        public string Slot {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.BootPxe initObject = new Intersight.Model.BootPxe();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Enabled"))
            {
                initObject.Enabled = this.Enabled;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InterfaceName"))
            {
                initObject.InterfaceName = this.InterfaceName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InterfaceSource"))
            {
                initObject.InterfaceSource = this.InterfaceSource;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IpType"))
            {
                initObject.IpType = this.IpType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MacAddress"))
            {
                initObject.MacAddress = this.MacAddress;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Port"))
            {
                initObject.Port = this.Port;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Slot"))
            {
                initObject.Slot = this.Slot;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize BootUefiShell.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightBootUefiShell")]
    public class InitializeIntersightBootUefiShell:PSCmdlet
	{
		public InitializeIntersightBootUefiShell()
		{
            
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
        
        public BootUefiShell.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Specifies if the boot device is enabled or disabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Enabled {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A name that helps identify a boot device. It can be any string that adheres to the following constraints. It should start and end with an alphanumeric character. It can have underscores and hyphens. It cannot be more than 30 characters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("((^[a-zA-Z0-9]$){1,30}|(^(([a-zA-Z0-9])([a-zA-Z0-9_\\-]{0,28})([a-zA-Z0-9]))$))")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public BootUefiShell.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.BootUefiShell initObject = new Intersight.Model.BootUefiShell();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Enabled"))
            {
                initObject.Enabled = this.Enabled;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize BootLocalCdd.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightBootLocalCdd")]
    public class InitializeIntersightBootLocalCdd:PSCmdlet
	{
		public InitializeIntersightBootLocalCdd()
		{
            
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
        
        public BootLocalCdd.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Specifies if the boot device is enabled or disabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Enabled {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A name that helps identify a boot device. It can be any string that adheres to the following constraints. It should start and end with an alphanumeric character. It can have underscores and hyphens. It cannot be more than 30 characters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("((^[a-zA-Z0-9]$){1,30}|(^(([a-zA-Z0-9])([a-zA-Z0-9_\\-]{0,28})([a-zA-Z0-9]))$))")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public BootLocalCdd.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.BootLocalCdd initObject = new Intersight.Model.BootLocalCdd();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Enabled"))
            {
                initObject.Enabled = this.Enabled;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize BootVirtualMedia.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightBootVirtualMedia")]
    public class InitializeIntersightBootVirtualMedia:PSCmdlet
	{
		public InitializeIntersightBootVirtualMedia()
		{
            ClassId = BootVirtualMedia.ClassIdEnum.BootVirtualMedia;
            ObjectType = BootVirtualMedia.ObjectTypeEnum.BootVirtualMedia;
            Subtype = BootVirtualMedia.SubtypeEnum.None;
            
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
        
        public BootVirtualMedia.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Specifies if the boot device is enabled or disabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Enabled {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A name that helps identify a boot device. It can be any string that adheres to the following constraints. It should start and end with an alphanumeric character. It can have underscores and hyphens. It cannot be more than 30 characters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("((^[a-zA-Z0-9]$){1,30}|(^(([a-zA-Z0-9])([a-zA-Z0-9_\\-]{0,28})([a-zA-Z0-9]))$))")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public BootVirtualMedia.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The subtype for the selected device type.\n* `None` - No sub type for virtual media.\n* `cimc-mapped-dvd` - The virtual media device is mapped to a virtual DVD device.\n* `cimc-mapped-hdd` - The virtual media device is mapped to a virtual HDD device.\n* `kvm-mapped-dvd` - A KVM mapped DVD virtual media device.\n* `kvm-mapped-hdd` - A KVM mapped HDD virtual media device.\n* `kvm-mapped-fdd` - A KVM mapped FDD virtual media device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public BootVirtualMedia.SubtypeEnum Subtype {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.BootVirtualMedia initObject = new Intersight.Model.BootVirtualMedia();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Enabled"))
            {
                initObject.Enabled = this.Enabled;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Subtype"))
            {
                initObject.Subtype = this.Subtype;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize BootPchStorage.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightBootPchStorage")]
    public class InitializeIntersightBootPchStorage:PSCmdlet
	{
		public InitializeIntersightBootPchStorage()
		{
            ClassId = BootPchStorage.ClassIdEnum.BootPchStorage;
            ObjectType = BootPchStorage.ObjectTypeEnum.BootPchStorage;
            
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
        /// <para type="description">"Details of the bootloader to be used during PCH Storage boot."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.BootBootloader Bootloader {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public BootPchStorage.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Specifies if the boot device is enabled or disabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Enabled {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Logical Unit Number (LUN) of the device. It is the Virtual Drive number for Cisco UCS C-Series Servers. Virtual Drive number is found in storage inventory."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Lun {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A name that helps identify a boot device. It can be any string that adheres to the following constraints. It should start and end with an alphanumeric character. It can have underscores and hyphens. It cannot be more than 30 characters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("((^[a-zA-Z0-9]$){1,30}|(^(([a-zA-Z0-9])([a-zA-Z0-9_\\-]{0,28})([a-zA-Z0-9]))$))")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public BootPchStorage.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.BootPchStorage initObject = new Intersight.Model.BootPchStorage();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Bootloader"))
            {
                initObject.Bootloader = this.Bootloader;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Enabled"))
            {
                initObject.Enabled = this.Enabled;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Lun"))
            {
                initObject.Lun = this.Lun;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize BootSan.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightBootSan")]
    public class InitializeIntersightBootSan:PSCmdlet
	{
		public InitializeIntersightBootSan()
		{
            ClassId = BootSan.ClassIdEnum.BootSan;
            ObjectType = BootSan.ObjectTypeEnum.BootSan;
            
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
        /// <para type="description">"Details of the bootloader to be used during SAN boot."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.BootBootloader Bootloader {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public BootSan.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Specifies if the boot device is enabled or disabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Enabled {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the underlying vHBA interface to be used by the SAN boot device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9-._:]*$")]
        public string InterfaceName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Logical Unit Number (LUN) of the device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Lun {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A name that helps identify a boot device. It can be any string that adheres to the following constraints. It should start and end with an alphanumeric character. It can have underscores and hyphens. It cannot be more than 30 characters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("((^[a-zA-Z0-9]$){1,30}|(^(([a-zA-Z0-9])([a-zA-Z0-9_\\-]{0,28})([a-zA-Z0-9]))$))")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public BootSan.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Slot ID of the device. Supported values are ( 1 - 255, \"MLOM\", \"L1\", \"L2\" )."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5]|MLOM|L1|L2)$")]
        public string Slot {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The WWPN Address of the underlying fiber channel interface used by the SAN boot device. Value must be in hexadecimal format xx:xx:xx:xx:xx:xx:xx:xx."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|(^([0-9a-fA-F]{2}:){7}[0-9a-fA-F]{2}$)")]
        public string Wwpn {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.BootSan initObject = new Intersight.Model.BootSan();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Bootloader"))
            {
                initObject.Bootloader = this.Bootloader;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Enabled"))
            {
                initObject.Enabled = this.Enabled;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InterfaceName"))
            {
                initObject.InterfaceName = this.InterfaceName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Lun"))
            {
                initObject.Lun = this.Lun;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Slot"))
            {
                initObject.Slot = this.Slot;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Wwpn"))
            {
                initObject.Wwpn = this.Wwpn;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize BootBootloader.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightBootBootloader")]
    public class InitializeIntersightBootBootloader:PSCmdlet
	{
		public InitializeIntersightBootBootloader()
		{
            ClassId = BootBootloader.ClassIdEnum.BootBootloader;
            ObjectType = BootBootloader.ObjectTypeEnum.BootBootloader;
            
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
        
        public BootBootloader.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Carries more information about the bootloader."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the bootloader image."</para>
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
        
        public BootBootloader.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Path to the bootloader image."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Path {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.BootBootloader initObject = new Intersight.Model.BootBootloader();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Path"))
            {
                initObject.Path = this.Path;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize BootLocalDisk.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightBootLocalDisk")]
    public class InitializeIntersightBootLocalDisk:PSCmdlet
	{
		public InitializeIntersightBootLocalDisk()
		{
            ClassId = BootLocalDisk.ClassIdEnum.BootLocalDisk;
            ObjectType = BootLocalDisk.ObjectTypeEnum.BootLocalDisk;
            
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
        /// <para type="description">"Details of the bootloader to be used during boot from local disk."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.BootBootloader Bootloader {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public BootLocalDisk.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Specifies if the boot device is enabled or disabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Enabled {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A name that helps identify a boot device. It can be any string that adheres to the following constraints. It should start and end with an alphanumeric character. It can have underscores and hyphens. It cannot be more than 30 characters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("((^[a-zA-Z0-9]$){1,30}|(^(([a-zA-Z0-9])([a-zA-Z0-9_\\-]{0,28})([a-zA-Z0-9]))$))")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public BootLocalDisk.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The slot id of the local disk device. Supported values for Standalone Rack servers are (1-205, \"M\", \"HBA\", \"SAS\", \"RAID\", \"MRAID\", \"MRAID1\", \"MRAID2\", \"MSTOR-RAID\"). Supported values for FI-attached servers are (1-205, \"MRAID\", \"FMEZZ1-SAS\", \"MRAID1\", \"MRAID2\", \"MSTOR-RAID\", \"MSTOR-RAID-1\", \"MSTOR-RAID-2\")."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|20[0-5]|M|HBA|SAS|MRAID|RAID|MRAID1|MRAID2|MSTOR-RAID|FMEZZ1-SAS|MSTOR-RAID-1|MSTOR-RAID-2)$")]
        public string Slot {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.BootLocalDisk initObject = new Intersight.Model.BootLocalDisk();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Bootloader"))
            {
                initObject.Bootloader = this.Bootloader;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Enabled"))
            {
                initObject.Enabled = this.Enabled;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Slot"))
            {
                initObject.Slot = this.Slot;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize BootNvme.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightBootNvme")]
    public class InitializeIntersightBootNvme:PSCmdlet
	{
		public InitializeIntersightBootNvme()
		{
            ClassId = BootNvme.ClassIdEnum.BootNvme;
            ObjectType = BootNvme.ObjectTypeEnum.BootNvme;
            
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
        /// <para type="description">"Details of the bootloader to be used during NVME boot."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.BootBootloader Bootloader {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public BootNvme.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Specifies if the boot device is enabled or disabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Enabled {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A name that helps identify a boot device. It can be any string that adheres to the following constraints. It should start and end with an alphanumeric character. It can have underscores and hyphens. It cannot be more than 30 characters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("((^[a-zA-Z0-9]$){1,30}|(^(([a-zA-Z0-9])([a-zA-Z0-9_\\-]{0,28})([a-zA-Z0-9]))$))")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public BootNvme.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.BootNvme initObject = new Intersight.Model.BootNvme();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Bootloader"))
            {
                initObject.Bootloader = this.Bootloader;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Enabled"))
            {
                initObject.Enabled = this.Enabled;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize BootSdCard.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightBootSdCard")]
    public class InitializeIntersightBootSdCard:PSCmdlet
	{
		public InitializeIntersightBootSdCard()
		{
            ClassId = BootSdCard.ClassIdEnum.BootSdCard;
            ObjectType = BootSdCard.ObjectTypeEnum.BootSdCard;
            Subtype = BootSdCard.SubtypeEnum.None;
            
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
        /// <para type="description">"Details of the bootloader to be used during SD card boot."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.BootBootloader Bootloader {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public BootSdCard.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Specifies if the boot device is enabled or disabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Enabled {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Logical Unit Number (LUN) of the device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Lun {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A name that helps identify a boot device. It can be any string that adheres to the following constraints. It should start and end with an alphanumeric character. It can have underscores and hyphens. It cannot be more than 30 characters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("((^[a-zA-Z0-9]$){1,30}|(^(([a-zA-Z0-9])([a-zA-Z0-9_\\-]{0,28})([a-zA-Z0-9]))$))")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public BootSdCard.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The subtype for the selected device type.\n* `None` - No sub type for SD card boot device.\n* `flex-util` - Use of FlexUtil (microSD) card as sub type for SD card boot device.\n* `flex-flash` - Use of FlexFlash (SD) card as sub type for SD card boot device.\n* `SDCARD` - Use of SD card as sub type for the SD Card boot device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public BootSdCard.SubtypeEnum Subtype {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.BootSdCard initObject = new Intersight.Model.BootSdCard();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Bootloader"))
            {
                initObject.Bootloader = this.Bootloader;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Enabled"))
            {
                initObject.Enabled = this.Enabled;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Lun"))
            {
                initObject.Lun = this.Lun;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Subtype"))
            {
                initObject.Subtype = this.Subtype;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize BootUsb.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightBootUsb")]
    public class InitializeIntersightBootUsb:PSCmdlet
	{
		public InitializeIntersightBootUsb()
		{
            ClassId = BootUsb.ClassIdEnum.BootUsb;
            ObjectType = BootUsb.ObjectTypeEnum.BootUsb;
            Subtype = BootUsb.SubtypeEnum.None;
            
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
        
        public BootUsb.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Specifies if the boot device is enabled or disabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Enabled {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A name that helps identify a boot device. It can be any string that adheres to the following constraints. It should start and end with an alphanumeric character. It can have underscores and hyphens. It cannot be more than 30 characters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("((^[a-zA-Z0-9]$){1,30}|(^(([a-zA-Z0-9])([a-zA-Z0-9_\\-]{0,28})([a-zA-Z0-9]))$))")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public BootUsb.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The subtype for the selected device type.\n* `None` - No sub type for USB boot device.\n* `usb-cd` - Use of Compact Disk (CD) as sub-type for the USB boot device.\n* `usb-fdd` - Use of Floppy Disk Drive (FDD) as sub-type for the USB boot device.\n* `usb-hdd` - Use of Hard Disk Drive (HDD) as sub-type for the USB boot device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public BootUsb.SubtypeEnum Subtype {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.BootUsb initObject = new Intersight.Model.BootUsb();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Enabled"))
            {
                initObject.Enabled = this.Enabled;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Subtype"))
            {
                initObject.Subtype = this.Subtype;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize BootDeviceBase.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightBootDeviceBase")]
    public class InitializeIntersightBootDeviceBase:PSCmdlet
	{
		public InitializeIntersightBootDeviceBase()
		{
            
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
        
        public BootDeviceBase.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Specifies if the boot device is enabled or disabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Enabled {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A name that helps identify a boot device. It can be any string that adheres to the following constraints. It should start and end with an alphanumeric character. It can have underscores and hyphens. It cannot be more than 30 characters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("((^[a-zA-Z0-9]$){1,30}|(^(([a-zA-Z0-9])([a-zA-Z0-9_\\-]{0,28})([a-zA-Z0-9]))$))")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public BootDeviceBase.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.BootDeviceBase initObject = new Intersight.Model.BootDeviceBase();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Enabled"))
            {
                initObject.Enabled = this.Enabled;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
}