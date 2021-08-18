using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get BootNvmeDevice.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightBootNvmeDevice", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightBootNvmeDevice:GetCmdletBase
	{
		public GetIntersightBootNvmeDevice()
		{
			ApiInstance = new BootApi(Config);
            MethodName = "GetBootNvmeDeviceListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set BootDeviceBootMode.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightBootDeviceBootMode")]
    public class SetIntersightBootDeviceBootMode:SetCmdletBase
	{
		public SetIntersightBootDeviceBootMode()
		{
			ApiInstance = new BootApi(Config);
            ModelObject = new BootDeviceBootMode();
            MethodName = "UpdateBootDeviceBootModeWithHttpInfo";
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
        /// <para type="description">"The user desired BIOS boot mode as configured in the boot policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ConfiguredBootMode {
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get BootSdDevice.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightBootSdDevice", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightBootSdDevice:GetCmdletBase
	{
		public GetIntersightBootSdDevice()
		{
			ApiInstance = new BootApi(Config);
            MethodName = "GetBootSdDeviceListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get BootHddDevice.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightBootHddDevice", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightBootHddDevice:GetCmdletBase
	{
		public GetIntersightBootHddDevice()
		{
			ApiInstance = new BootApi(Config);
            MethodName = "GetBootHddDeviceListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set BootNvmeDevice.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightBootNvmeDevice")]
    public class SetIntersightBootNvmeDevice:SetCmdletBase
	{
		public SetIntersightBootNvmeDevice()
		{
			ApiInstance = new BootApi(Config);
            ModelObject = new BootNvmeDevice();
            MethodName = "UpdateBootNvmeDeviceWithHttpInfo";
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
        
        public ComputePhysicalRelationship ComputePhysical {
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
        /// <para type="description">"The name of the boot device configured in the boot policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The order of the boot device configured in the boot policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Order {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a equipmentFru resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public EquipmentFruRelationship PreviousFru {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The state of the boot device configured in the boot policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string State {
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
        /// <para type="description">"The type of the boot device configured in the boot policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Type {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get BootPchStorageDevice.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightBootPchStorageDevice", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightBootPchStorageDevice:GetCmdletBase
	{
		public GetIntersightBootPchStorageDevice()
		{
			ApiInstance = new BootApi(Config);
            MethodName = "GetBootPchStorageDeviceListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get BootDeviceBootMode.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightBootDeviceBootMode", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightBootDeviceBootMode:GetCmdletBase
	{
		public GetIntersightBootDeviceBootMode()
		{
			ApiInstance = new BootApi(Config);
            MethodName = "GetBootDeviceBootModeListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set BootPchStorageDevice.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightBootPchStorageDevice")]
    public class SetIntersightBootPchStorageDevice:SetCmdletBase
	{
		public SetIntersightBootPchStorageDevice()
		{
			ApiInstance = new BootApi(Config);
            ModelObject = new BootPchStorageDevice();
            MethodName = "UpdateBootPchStorageDeviceWithHttpInfo";
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
        
        public ComputePhysicalRelationship ComputePhysical {
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
        /// <para type="description">"The name of the boot device configured in the boot policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The order of the boot device configured in the boot policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Order {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a equipmentFru resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public EquipmentFruRelationship PreviousFru {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The state of the boot device configured in the boot policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string State {
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
        /// <para type="description">"The type of the boot device configured in the boot policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Type {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get BootVmediaDevice.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightBootVmediaDevice", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightBootVmediaDevice:GetCmdletBase
	{
		public GetIntersightBootVmediaDevice()
		{
			ApiInstance = new BootApi(Config);
            MethodName = "GetBootVmediaDeviceListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set BootHddDevice.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightBootHddDevice")]
    public class SetIntersightBootHddDevice:SetCmdletBase
	{
		public SetIntersightBootHddDevice()
		{
			ApiInstance = new BootApi(Config);
            ModelObject = new BootHddDevice();
            MethodName = "UpdateBootHddDeviceWithHttpInfo";
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
        
        public ComputePhysicalRelationship ComputePhysical {
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
        /// <para type="description">"The name of the boot device configured in the boot policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The order of the boot device configured in the boot policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Order {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a equipmentFru resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public EquipmentFruRelationship PreviousFru {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The state of the boot device configured in the boot policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string State {
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
        /// <para type="description">"The type of the boot device configured in the boot policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Type {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get BootUsbDevice.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightBootUsbDevice", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightBootUsbDevice:GetCmdletBase
	{
		public GetIntersightBootUsbDevice()
		{
			ApiInstance = new BootApi(Config);
            MethodName = "GetBootUsbDeviceListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get BootCddDevice.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightBootCddDevice", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightBootCddDevice:GetCmdletBase
	{
		public GetIntersightBootCddDevice()
		{
			ApiInstance = new BootApi(Config);
            MethodName = "GetBootCddDeviceListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get BootDeviceBootSecurity.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightBootDeviceBootSecurity", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightBootDeviceBootSecurity:GetCmdletBase
	{
		public GetIntersightBootDeviceBootSecurity()
		{
			ApiInstance = new BootApi(Config);
            MethodName = "GetBootDeviceBootSecurityListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get BootSanDevice.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightBootSanDevice", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightBootSanDevice:GetCmdletBase
	{
		public GetIntersightBootSanDevice()
		{
			ApiInstance = new BootApi(Config);
            MethodName = "GetBootSanDeviceListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set BootPxeDevice.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightBootPxeDevice")]
    public class SetIntersightBootPxeDevice:SetCmdletBase
	{
		public SetIntersightBootPxeDevice()
		{
			ApiInstance = new BootApi(Config);
            ModelObject = new BootPxeDevice();
            MethodName = "UpdateBootPxeDeviceWithHttpInfo";
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
        
        public ComputePhysicalRelationship ComputePhysical {
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
        /// <para type="description">"The name of the boot device configured in the boot policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The order of the boot device configured in the boot policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Order {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a equipmentFru resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public EquipmentFruRelationship PreviousFru {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The state of the boot device configured in the boot policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string State {
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
        /// <para type="description">"The type of the boot device configured in the boot policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Type {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set BootPrecisionPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightBootPrecisionPolicy")]
    public class SetIntersightBootPrecisionPolicy:SetCmdletBase
	{
		public SetIntersightBootPrecisionPolicy()
		{
			ApiInstance = new BootApi(Config);
            ModelObject = new BootPrecisionPolicy();
            MethodName = "UpdateBootPrecisionPolicyWithHttpInfo";
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<BootDeviceBase> BootDevices {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Sets the BIOS boot mode. UEFI uses the GUID Partition Table (GPT) whereas Legacy mode uses the Master Boot Record (MBR) partitioning scheme. To apply this setting, Please reboot the server.\n* `Legacy` - Legacy mode refers to the traditional process of booting from BIOS. Legacy mode uses the Master Boot Record (MBR) to locate the bootloader.\n* `Uefi` - UEFI mode uses the GUID Partition Table (GPT) to locate EFI Service Partitions to boot from."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public BootPrecisionPolicy.ConfiguredBootModeEnum ConfiguredBootMode {
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
        /// <para type="description">"If UEFI secure boot is enabled, the boot mode is set to UEFI by default. Secure boot enforces that device boots using only software that is trusted by the Original Equipment Manufacturer (OEM)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool EnforceUefiSecureBoot {
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove BootPrecisionPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightBootPrecisionPolicy")]
    public class RemoveIntersightBootPrecisionPolicy:RemoveCmdletBase
	{
		public RemoveIntersightBootPrecisionPolicy()
		{
			ApiInstance = new BootApi(Config);
            MethodName = "DeleteBootPrecisionPolicyWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set BootSdDevice.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightBootSdDevice")]
    public class SetIntersightBootSdDevice:SetCmdletBase
	{
		public SetIntersightBootSdDevice()
		{
			ApiInstance = new BootApi(Config);
            ModelObject = new BootSdDevice();
            MethodName = "UpdateBootSdDeviceWithHttpInfo";
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
        
        public ComputePhysicalRelationship ComputePhysical {
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
        /// <para type="description">"The name of the boot device configured in the boot policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The order of the boot device configured in the boot policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Order {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a equipmentFru resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public EquipmentFruRelationship PreviousFru {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The state of the boot device configured in the boot policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string State {
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
        /// <para type="description">"The type of the boot device configured in the boot policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Type {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get BootPrecisionPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightBootPrecisionPolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightBootPrecisionPolicy:GetCmdletBase
	{
		public GetIntersightBootPrecisionPolicy()
		{
			ApiInstance = new BootApi(Config);
            MethodName = "GetBootPrecisionPolicyListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New BootPrecisionPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightBootPrecisionPolicy")]
    public class NewIntersightBootPrecisionPolicy:NewCmdletBase
	{
		public NewIntersightBootPrecisionPolicy()
		{
			ApiInstance = new BootApi(Config);
            ModelObject = new BootPrecisionPolicy();
            MethodName = "CreateBootPrecisionPolicyWithHttpInfo";
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<BootDeviceBase> BootDevices {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Sets the BIOS boot mode. UEFI uses the GUID Partition Table (GPT) whereas Legacy mode uses the Master Boot Record (MBR) partitioning scheme. To apply this setting, Please reboot the server.\n* `Legacy` - Legacy mode refers to the traditional process of booting from BIOS. Legacy mode uses the Master Boot Record (MBR) to locate the bootloader.\n* `Uefi` - UEFI mode uses the GUID Partition Table (GPT) to locate EFI Service Partitions to boot from."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public BootPrecisionPolicy.ConfiguredBootModeEnum ConfiguredBootMode {
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
        /// <para type="description">"If UEFI secure boot is enabled, the boot mode is set to UEFI by default. Secure boot enforces that device boots using only software that is trusted by the Original Equipment Manufacturer (OEM)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool EnforceUefiSecureBoot {
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get BootIscsiDevice.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightBootIscsiDevice", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightBootIscsiDevice:GetCmdletBase
	{
		public GetIntersightBootIscsiDevice()
		{
			ApiInstance = new BootApi(Config);
            MethodName = "GetBootIscsiDeviceListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set BootCddDevice.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightBootCddDevice")]
    public class SetIntersightBootCddDevice:SetCmdletBase
	{
		public SetIntersightBootCddDevice()
		{
			ApiInstance = new BootApi(Config);
            ModelObject = new BootCddDevice();
            MethodName = "UpdateBootCddDeviceWithHttpInfo";
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
        
        public ComputePhysicalRelationship ComputePhysical {
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
        /// <para type="description">"The name of the boot device configured in the boot policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The order of the boot device configured in the boot policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Order {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a equipmentFru resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public EquipmentFruRelationship PreviousFru {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The state of the boot device configured in the boot policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string State {
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
        /// <para type="description">"The type of the boot device configured in the boot policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Type {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set BootVmediaDevice.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightBootVmediaDevice")]
    public class SetIntersightBootVmediaDevice:SetCmdletBase
	{
		public SetIntersightBootVmediaDevice()
		{
			ApiInstance = new BootApi(Config);
            ModelObject = new BootVmediaDevice();
            MethodName = "UpdateBootVmediaDeviceWithHttpInfo";
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
        
        public ComputePhysicalRelationship ComputePhysical {
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
        /// <para type="description">"The name of the boot device configured in the boot policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The order of the boot device configured in the boot policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Order {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a equipmentFru resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public EquipmentFruRelationship PreviousFru {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The state of the boot device configured in the boot policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string State {
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
        /// <para type="description">"The type of the boot device configured in the boot policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Type {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get BootUefiShellDevice.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightBootUefiShellDevice", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightBootUefiShellDevice:GetCmdletBase
	{
		public GetIntersightBootUefiShellDevice()
		{
			ApiInstance = new BootApi(Config);
            MethodName = "GetBootUefiShellDeviceListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set BootIscsiDevice.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightBootIscsiDevice")]
    public class SetIntersightBootIscsiDevice:SetCmdletBase
	{
		public SetIntersightBootIscsiDevice()
		{
			ApiInstance = new BootApi(Config);
            ModelObject = new BootIscsiDevice();
            MethodName = "UpdateBootIscsiDeviceWithHttpInfo";
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
        
        public ComputePhysicalRelationship ComputePhysical {
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
        /// <para type="description">"The name of the boot device configured in the boot policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The order of the boot device configured in the boot policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Order {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a equipmentFru resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public EquipmentFruRelationship PreviousFru {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The state of the boot device configured in the boot policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string State {
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
        /// <para type="description">"The type of the boot device configured in the boot policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Type {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set BootUsbDevice.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightBootUsbDevice")]
    public class SetIntersightBootUsbDevice:SetCmdletBase
	{
		public SetIntersightBootUsbDevice()
		{
			ApiInstance = new BootApi(Config);
            ModelObject = new BootUsbDevice();
            MethodName = "PatchBootUsbDeviceWithHttpInfo";
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
        
        public ComputePhysicalRelationship ComputePhysical {
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
        /// <para type="description">"The name of the boot device configured in the boot policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The order of the boot device configured in the boot policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Order {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a equipmentFru resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public EquipmentFruRelationship PreviousFru {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The state of the boot device configured in the boot policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string State {
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
        /// <para type="description">"The type of the boot device configured in the boot policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Type {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set BootSanDevice.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightBootSanDevice")]
    public class SetIntersightBootSanDevice:SetCmdletBase
	{
		public SetIntersightBootSanDevice()
		{
			ApiInstance = new BootApi(Config);
            ModelObject = new BootSanDevice();
            MethodName = "UpdateBootSanDeviceWithHttpInfo";
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
        
        public ComputePhysicalRelationship ComputePhysical {
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
        /// <para type="description">"The name of the boot device configured in the boot policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The order of the boot device configured in the boot policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Order {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a equipmentFru resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public EquipmentFruRelationship PreviousFru {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The state of the boot device configured in the boot policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string State {
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
        /// <para type="description">"The type of the boot device configured in the boot policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Type {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set BootUefiShellDevice.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightBootUefiShellDevice")]
    public class SetIntersightBootUefiShellDevice:SetCmdletBase
	{
		public SetIntersightBootUefiShellDevice()
		{
			ApiInstance = new BootApi(Config);
            ModelObject = new BootUefiShellDevice();
            MethodName = "UpdateBootUefiShellDeviceWithHttpInfo";
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
        
        public ComputePhysicalRelationship ComputePhysical {
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
        /// <para type="description">"The name of the boot device configured in the boot policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The order of the boot device configured in the boot policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Order {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a equipmentFru resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public EquipmentFruRelationship PreviousFru {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The state of the boot device configured in the boot policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string State {
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
        /// <para type="description">"The type of the boot device configured in the boot policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Type {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set BootDeviceBootSecurity.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightBootDeviceBootSecurity")]
    public class SetIntersightBootDeviceBootSecurity:SetCmdletBase
	{
		public SetIntersightBootDeviceBootSecurity()
		{
			ApiInstance = new BootApi(Config);
            ModelObject = new BootDeviceBootSecurity();
            MethodName = "UpdateBootDeviceBootSecurityWithHttpInfo";
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
        
        public ComputePhysicalRelationship ComputePhysical {
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get BootPxeDevice.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightBootPxeDevice", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightBootPxeDevice:GetCmdletBase
	{
		public GetIntersightBootPxeDevice()
		{
			ApiInstance = new BootApi(Config);
            MethodName = "GetBootPxeDeviceListWithHttpInfo";
		}
    }
}