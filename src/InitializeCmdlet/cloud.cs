using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize CloudAvailabilityZone.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCloudAvailabilityZone")]
    public class InitializeIntersightCloudAvailabilityZone : PSCmdlet
    {
        public InitializeIntersightCloudAvailabilityZone()
        {
            ClassId = CloudAvailabilityZone.ClassIdEnum.CloudAvailabilityZone;
            ObjectType = CloudAvailabilityZone.ObjectTypeEnum.CloudAvailabilityZone;

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

        public CloudAvailabilityZone.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CloudAvailabilityZone.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.CloudAvailabilityZone initObject = new Intersight.Model.CloudAvailabilityZone();
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
    /// <para type="synopsis">This is the cmdlet to Initialize CloudAwsBillingUnit.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCloudAwsBillingUnit")]
    public class InitializeIntersightCloudAwsBillingUnit : PSCmdlet
    {
        public InitializeIntersightCloudAwsBillingUnit()
        {
            ClassId = CloudAwsBillingUnit.ClassIdEnum.CloudAwsBillingUnit;
            ObjectType = CloudAwsBillingUnit.ObjectTypeEnum.CloudAwsBillingUnit;

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

        public CloudAwsBillingUnit.ClassIdEnum ClassId
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

        public CloudAwsBillingUnit.ObjectTypeEnum ObjectType
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
            Intersight.Model.CloudAwsBillingUnit initObject = new Intersight.Model.CloudAwsBillingUnit();
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
    /// <para type="synopsis">This is the cmdlet to Initialize CloudAwsKeyPair.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCloudAwsKeyPair")]
    public class InitializeIntersightCloudAwsKeyPair : PSCmdlet
    {
        public InitializeIntersightCloudAwsKeyPair()
        {
            ClassId = CloudAwsKeyPair.ClassIdEnum.CloudAwsKeyPair;
            ObjectType = CloudAwsKeyPair.ObjectTypeEnum.CloudAwsKeyPair;

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

        public CloudAwsKeyPair.ClassIdEnum ClassId
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

        public CloudAwsKeyPair.ObjectTypeEnum ObjectType
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
            Intersight.Model.CloudAwsKeyPair initObject = new Intersight.Model.CloudAwsKeyPair();
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
    /// <para type="synopsis">This is the cmdlet to Initialize CloudAwsNetworkInterface.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCloudAwsNetworkInterface")]
    public class InitializeIntersightCloudAwsNetworkInterface : PSCmdlet
    {
        public InitializeIntersightCloudAwsNetworkInterface()
        {
            AdapterType = CloudAwsNetworkInterface.AdapterTypeEnum.Unknown;
            ClassId = CloudAwsNetworkInterface.ClassIdEnum.CloudAwsNetworkInterface;
            ObjectType = CloudAwsNetworkInterface.ObjectTypeEnum.CloudAwsNetworkInterface;

        }
        // <summary>
        /// <para type="description">"Type or model of the virtual network interface card.\n* `Unknown` - The type of the network adaptor type is unknown.\n* `E1000` - Emulated version of the Intel 82545EM Gigabit Ethernet NIC.\n* `SRIOV` - Representation of a virtual function (VF) on a physical NIC with SR-IOV support.\n* `VMXNET2` - VMXNET 2 (Enhanced) is available only for some guest operating systems on ESX/ESXi 3.5 and later.\n* `VMXNET3` - VMXNET 3 offers all the features available in VMXNET 2 and adds several new features.\n* `E1000E` - E1000E – emulates a newer real network adapter, the 1 Gbit Intel 82574, and is available for Windows 2012 and later. The E1000E needs virtual machine hardware version 8 or later.\n* `NE2K_PCI` - The Ne2000 network card uses two ring buffers for packet handling. These are circular buffers made of 256-byte pages that the chip's DMA logic will use to store received packets or to get received packets.\n* `PCnet` - The PCnet-PCI II is a PCI network adapter. It has built-in support for CRC checks and can automatically pad short packets to the minimum Ethernet length.\n* `RTL8139` - The RTL8139 is a fast Ethernet card that operates at 10/100 Mbps. It is compliant with PCI version 2.0/2.1 and it is known for reliability and superior performance.\n* `VirtIO` - VirtIO is a standardized interface which allows virtual machines access to simplified \"virtual\" devices, such as block devices, network adapters and consoles. Accessing devices through VirtIO on a guest VM improves performance over more traditional \"emulated\" devices, as VirtIO devices require only the bare minimum setup and configuration needed to send and receive data, while the host machine handles the majority of the setup and maintenance of the actual physical hardware.\n* `` - Default network adaptor type supported by the hypervisor."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CloudAwsNetworkInterface.AdapterTypeEnum AdapterType
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

        public CloudAwsNetworkInterface.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"MAC address assigned to the virtual network interface card."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^([0-9A-Fa-f]{2}[:-]){5}([0-9A-Fa-f]{2})$")]
        public string MacAddress
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
        /// <para type="description">"Name of the virtual network interface card."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CloudAwsNetworkInterface.ObjectTypeEnum ObjectType
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
            Intersight.Model.CloudAwsNetworkInterface initObject = new Intersight.Model.CloudAwsNetworkInterface();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdapterType"))
            {
                initObject.AdapterType = this.AdapterType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("MacAddress"))
            {
                initObject.MacAddress = this.MacAddress;
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
    /// <para type="synopsis">This is the cmdlet to Initialize CloudAwsOrganizationalUnit.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCloudAwsOrganizationalUnit")]
    public class InitializeIntersightCloudAwsOrganizationalUnit : PSCmdlet
    {
        public InitializeIntersightCloudAwsOrganizationalUnit()
        {
            ClassId = CloudAwsOrganizationalUnit.ClassIdEnum.CloudAwsOrganizationalUnit;
            ObjectType = CloudAwsOrganizationalUnit.ObjectTypeEnum.CloudAwsOrganizationalUnit;

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

        public CloudAwsOrganizationalUnit.ClassIdEnum ClassId
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

        public CloudAwsOrganizationalUnit.ObjectTypeEnum ObjectType
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
            Intersight.Model.CloudAwsOrganizationalUnit initObject = new Intersight.Model.CloudAwsOrganizationalUnit();
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
    /// <para type="synopsis">This is the cmdlet to Initialize CloudAwsSecurityGroup.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCloudAwsSecurityGroup")]
    public class InitializeIntersightCloudAwsSecurityGroup : PSCmdlet
    {
        public InitializeIntersightCloudAwsSecurityGroup()
        {
            ClassId = CloudAwsSecurityGroup.ClassIdEnum.CloudAwsSecurityGroup;
            ObjectType = CloudAwsSecurityGroup.ObjectTypeEnum.CloudAwsSecurityGroup;

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

        public CloudAwsSecurityGroup.ClassIdEnum ClassId
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

        public CloudAwsSecurityGroup.ObjectTypeEnum ObjectType
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
            Intersight.Model.CloudAwsSecurityGroup initObject = new Intersight.Model.CloudAwsSecurityGroup();
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
    /// <para type="synopsis">This is the cmdlet to Initialize CloudAwsSubnet.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCloudAwsSubnet")]
    public class InitializeIntersightCloudAwsSubnet : PSCmdlet
    {
        public InitializeIntersightCloudAwsSubnet()
        {
            ClassId = CloudAwsSubnet.ClassIdEnum.CloudAwsSubnet;
            ObjectType = CloudAwsSubnet.ObjectTypeEnum.CloudAwsSubnet;

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

        public CloudAwsSubnet.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The internally generated identity of network. This entity cannot manipulated by users. It aids in uniquely identifying the network object. For VMware, this is MOR (managed object reference)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Identity
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
        /// <para type="description">"User-provided name to identify the portgroup."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CloudAwsSubnet.ObjectTypeEnum ObjectType
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
            Intersight.Model.CloudAwsSubnet initObject = new Intersight.Model.CloudAwsSubnet();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Identity"))
            {
                initObject.Identity = this.Identity;
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
    /// <para type="synopsis">This is the cmdlet to Initialize CloudAwsVirtualMachine.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCloudAwsVirtualMachine")]
    public class InitializeIntersightCloudAwsVirtualMachine : PSCmdlet
    {
        public InitializeIntersightCloudAwsVirtualMachine()
        {
            ClassId = CloudAwsVirtualMachine.ClassIdEnum.CloudAwsVirtualMachine;
            HypervisorType = CloudAwsVirtualMachine.HypervisorTypeEnum.ESXi;
            ObjectType = CloudAwsVirtualMachine.ObjectTypeEnum.CloudAwsVirtualMachine;
            PowerState = CloudAwsVirtualMachine.PowerStateEnum.Unknown;
            Provider = CloudAwsVirtualMachine.ProviderEnum.Unknown;
            State = CloudAwsVirtualMachine.StateEnum.None;

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
        /// <para type="description">"Time when this VM booted up."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime BootTime
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Provisioned CPU and memory information for this virtual machine."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.InfraHardwareInfo Capacity
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CloudAwsVirtualMachine.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Average CPU utilization percentage derived as a ratio of CPU used to CPU allocated. The value is calculated whenever inventory is performed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public float CpuUtilization
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Guest operating system details running on this machine."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VirtualizationGuestInfo GuestInfo
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of hypervisor where the virtual machine is hosted for example ESXi.\n* `ESXi` - The hypervisor running on the HyperFlex cluster is a Vmware ESXi hypervisor of any version.\n* `Hyper-V` - The hypervisor running on the HyperFlex cluster is Microsoft Hyper-V.\n* `Unknown` - The hypervisor running on the HyperFlex cluster is not known."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CloudAwsVirtualMachine.HypervisorTypeEnum HypervisorType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The internally generated identity of this VM. This entity is not manipulated by users. It aids in uniquely identifying the virtual machine object. For VMware, this is MOR (managed object reference)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Identity
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> IpAddress
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The capacity and usage information for memory on this virtual machine."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VirtualizationMemoryCapacity MemoryCapacity
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Average memory utilization percentage derived as a ratio of memory used to available memory. The value is calculated whenever inventory is performed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public float MemoryUtilization
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
        /// <para type="description">"User-provided name to identify the virtual machine."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CloudAwsVirtualMachine.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Power state of the virtual machine.\n* `Unknown` - The entity's power state is unknown.\n* `PoweringOn` - The entity is powering on.\n* `PoweredOn` - The entity is powered on.\n* `PoweringOff` - The entity is powering off.\n* `PoweredOff` - The entity is powered down.\n* `StandBy` - The entity is in standby mode.\n* `Paused` - The entity is in pause state.\n* `Rebooting` - The entity reboot is in progress.\n* `` - The entity's power state is not available."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CloudAwsVirtualMachine.PowerStateEnum PowerState
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The capacity and usage information for CPU power on this virtual machine."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VirtualizationComputeCapacity ProcessorCapacity
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Cloud platform, where the virtual machine is launched.\n* `Unknown` - Cloud provider is not known.\n* `VMwarevSphere` - Cloud provider named VMware vSphere.\n* `AmazonWebServices` - Cloud provider named Amazon Web Services.\n* `MicrosoftAzure` - Cloud provider named Microsoft Azure.\n* `GoogleCloudPlatform` - Cloud provider named Google Cloud Platform."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CloudAwsVirtualMachine.ProviderEnum Provider
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
        /// <para type="description">"The current state of the virtual machine. For example, starting, stopped, etc.\n* `None` - A place holder for the default value.\n* `Creating` - Virtual machine creation is in progress.\n* `Pending` - The virtual machine is preparing to enter the started state.\n* `Starting` - The virtual machine is starting.\n* `Started` - The virtual machine is running and ready for use.\n* `Stopping` - The virtual machine is preparing to be stopped.\n* `Stopped` - The virtual machine is shut down and cannot be used. The virtual machine can be started again at any time.\n* `Pausing` - The virtual machine is preparing to be paused.\n* `Paused` - The virtual machine enters into paused state due to low free disk space.\n* `Suspending` - The virtual machine is preparing to be suspended.\n* `Suspended` - Virtual machine is in sleep mode.When a virtual machine is suspended, the current state of theoperating system, and applications is saved, and the virtual machine put into a suspended mode.\n* `Deleting` - The virtual machine is preparing to be terminated.\n* `Terminated` - The virtual machine has been permanently deleted and cannot be started.\n* `Rebooting` - The virtual machine reboot is in progress.\n* `Error` - The deployment of virtual machine is failed.\n* `Warning` - The virtual machine is in warning state."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CloudAwsVirtualMachine.StateEnum State
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
        /// <para type="description">"The uuid of this virtual machine. The uuid is internally generated and not user specified."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12}$")]
        public string Uuid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Time when this virtualmachine is created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime VmCreationTime
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.CloudAwsVirtualMachine initObject = new Intersight.Model.CloudAwsVirtualMachine();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BootTime"))
            {
                initObject.BootTime = this.BootTime;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Capacity"))
            {
                initObject.Capacity = this.Capacity;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("CpuUtilization"))
            {
                initObject.CpuUtilization = this.CpuUtilization;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("GuestInfo"))
            {
                initObject.GuestInfo = this.GuestInfo;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HypervisorType"))
            {
                initObject.HypervisorType = this.HypervisorType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Identity"))
            {
                initObject.Identity = this.Identity;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IpAddress"))
            {
                initObject.IpAddress = this.IpAddress;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MemoryCapacity"))
            {
                initObject.MemoryCapacity = this.MemoryCapacity;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MemoryUtilization"))
            {
                initObject.MemoryUtilization = this.MemoryUtilization;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("PowerState"))
            {
                initObject.PowerState = this.PowerState;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ProcessorCapacity"))
            {
                initObject.ProcessorCapacity = this.ProcessorCapacity;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Provider"))
            {
                initObject.Provider = this.Provider;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RegisteredDevice"))
            {
                initObject.RegisteredDevice = this.RegisteredDevice;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("State"))
            {
                initObject.State = this.State;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Uuid"))
            {
                initObject.Uuid = this.Uuid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VmCreationTime"))
            {
                initObject.VmCreationTime = this.VmCreationTime;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize CloudAwsVolume.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCloudAwsVolume")]
    public class InitializeIntersightCloudAwsVolume : PSCmdlet
    {
        public InitializeIntersightCloudAwsVolume()
        {
            ClassId = CloudAwsVolume.ClassIdEnum.CloudAwsVolume;
            ObjectType = CloudAwsVolume.ObjectTypeEnum.CloudAwsVolume;

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

        public CloudAwsVolume.ClassIdEnum ClassId
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
        /// <para type="description">"Name of the storage disk. Name must be unique within a Datastore."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CloudAwsVolume.ObjectTypeEnum ObjectType
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
        /// <para type="description">"Disk size represented in bytes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Size
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
            Intersight.Model.CloudAwsVolume initObject = new Intersight.Model.CloudAwsVolume();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("RegisteredDevice"))
            {
                initObject.RegisteredDevice = this.RegisteredDevice;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Size"))
            {
                initObject.Size = this.Size;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize CloudAwsVpc.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCloudAwsVpc")]
    public class InitializeIntersightCloudAwsVpc : PSCmdlet
    {
        public InitializeIntersightCloudAwsVpc()
        {
            ClassId = CloudAwsVpc.ClassIdEnum.CloudAwsVpc;
            ObjectType = CloudAwsVpc.ObjectTypeEnum.CloudAwsVpc;

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

        public CloudAwsVpc.ClassIdEnum ClassId
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

        public CloudAwsVpc.ObjectTypeEnum ObjectType
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
            Intersight.Model.CloudAwsVpc initObject = new Intersight.Model.CloudAwsVpc();
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
    /// <para type="synopsis">This is the cmdlet to Initialize CloudBillingUnit.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCloudBillingUnit")]
    public class InitializeIntersightCloudBillingUnit : PSCmdlet
    {
        public InitializeIntersightCloudBillingUnit()
        {
            ClassId = CloudBillingUnit.ClassIdEnum.CloudBillingUnit;
            ObjectType = CloudBillingUnit.ObjectTypeEnum.CloudBillingUnit;

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

        public CloudBillingUnit.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CloudBillingUnit.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.CloudBillingUnit initObject = new Intersight.Model.CloudBillingUnit();
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
    /// <para type="synopsis">This is the cmdlet to Initialize CloudCloudRegion.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCloudCloudRegion")]
    public class InitializeIntersightCloudCloudRegion : PSCmdlet
    {
        public InitializeIntersightCloudCloudRegion()
        {
            ClassId = CloudCloudRegion.ClassIdEnum.CloudCloudRegion;
            ObjectType = CloudCloudRegion.ObjectTypeEnum.CloudCloudRegion;

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

        public CloudCloudRegion.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CloudCloudRegion.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.CloudCloudRegion initObject = new Intersight.Model.CloudCloudRegion();
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
    /// <para type="synopsis">This is the cmdlet to Initialize CloudCloudTag.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCloudCloudTag")]
    public class InitializeIntersightCloudCloudTag : PSCmdlet
    {
        public InitializeIntersightCloudCloudTag()
        {
            ClassId = CloudCloudTag.ClassIdEnum.CloudCloudTag;
            ObjectType = CloudCloudTag.ObjectTypeEnum.CloudCloudTag;

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

        public CloudCloudTag.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CloudCloudTag.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.CloudCloudTag initObject = new Intersight.Model.CloudCloudTag();
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
    /// <para type="synopsis">This is the cmdlet to Initialize CloudCollectInventory.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCloudCollectInventory")]
    public class InitializeIntersightCloudCollectInventory : PSCmdlet
    {
        public InitializeIntersightCloudCollectInventory()
        {
            ClassId = CloudCollectInventory.ClassIdEnum.CloudCollectInventory;
            ObjectType = CloudCollectInventory.ObjectTypeEnum.CloudCollectInventory;

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

        public CloudCollectInventory.ClassIdEnum ClassId
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

        public CloudCollectInventory.ObjectTypeEnum ObjectType
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
        /// <para type="description">"A reference to a assetTarget resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.AssetTargetRelationship Target
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The id of the new Terraform cloud asset which was created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string TargetId
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.CloudCollectInventory initObject = new Intersight.Model.CloudCollectInventory();
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Target"))
            {
                initObject.Target = this.Target;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TargetId"))
            {
                initObject.TargetId = this.TargetId;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize CloudCustomAttributes.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCloudCustomAttributes")]
    public class InitializeIntersightCloudCustomAttributes : PSCmdlet
    {
        public InitializeIntersightCloudCustomAttributes()
        {
            ClassId = CloudCustomAttributes.ClassIdEnum.CloudCustomAttributes;
            ObjectType = CloudCustomAttributes.ObjectTypeEnum.CloudCustomAttributes;

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
        /// <para type="description">"The name of an attribute. If used as a key-value pair then this field represents the key."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string AttributeName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The data type for attributeValue. For e.g. string, int, float."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string AttributeType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The attribute value. If used as a key-value pair then this field represents the value."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string AttributeValue
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CloudCustomAttributes.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CloudCustomAttributes.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.CloudCustomAttributes initObject = new Intersight.Model.CloudCustomAttributes();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AttributeName"))
            {
                initObject.AttributeName = this.AttributeName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AttributeType"))
            {
                initObject.AttributeType = this.AttributeType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AttributeValue"))
            {
                initObject.AttributeValue = this.AttributeValue;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize CloudImageReference.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCloudImageReference")]
    public class InitializeIntersightCloudImageReference : PSCmdlet
    {
        public InitializeIntersightCloudImageReference()
        {
            ClassId = CloudImageReference.ClassIdEnum.CloudImageReference;
            ObjectType = CloudImageReference.ObjectTypeEnum.CloudImageReference;

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

        public CloudImageReference.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CloudImageReference.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.CloudImageReference initObject = new Intersight.Model.CloudImageReference();
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
    /// <para type="synopsis">This is the cmdlet to Initialize CloudInstanceType.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCloudInstanceType")]
    public class InitializeIntersightCloudInstanceType : PSCmdlet
    {
        public InitializeIntersightCloudInstanceType()
        {
            ClassId = CloudInstanceType.ClassIdEnum.CloudInstanceType;
            ObjectType = CloudInstanceType.ObjectTypeEnum.CloudInstanceType;

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

        public CloudInstanceType.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CloudInstanceType.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.CloudInstanceType initObject = new Intersight.Model.CloudInstanceType();
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
    /// <para type="synopsis">This is the cmdlet to Initialize CloudNetworkAccessConfig.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCloudNetworkAccessConfig")]
    public class InitializeIntersightCloudNetworkAccessConfig : PSCmdlet
    {
        public InitializeIntersightCloudNetworkAccessConfig()
        {
            ClassId = CloudNetworkAccessConfig.ClassIdEnum.CloudNetworkAccessConfig;
            ObjectType = CloudNetworkAccessConfig.ObjectTypeEnum.CloudNetworkAccessConfig;

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

        public CloudNetworkAccessConfig.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CloudNetworkAccessConfig.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.CloudNetworkAccessConfig initObject = new Intersight.Model.CloudNetworkAccessConfig();
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
    /// <para type="synopsis">This is the cmdlet to Initialize CloudNetworkAddress.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCloudNetworkAddress")]
    public class InitializeIntersightCloudNetworkAddress : PSCmdlet
    {
        public InitializeIntersightCloudNetworkAddress()
        {
            ClassId = CloudNetworkAddress.ClassIdEnum.CloudNetworkAddress;
            ObjectType = CloudNetworkAddress.ObjectTypeEnum.CloudNetworkAddress;

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

        public CloudNetworkAddress.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CloudNetworkAddress.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.CloudNetworkAddress initObject = new Intersight.Model.CloudNetworkAddress();
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
    /// <para type="synopsis">This is the cmdlet to Initialize CloudNetworkInstanceAttachment.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCloudNetworkInstanceAttachment")]
    public class InitializeIntersightCloudNetworkInstanceAttachment : PSCmdlet
    {
        public InitializeIntersightCloudNetworkInstanceAttachment()
        {
            ClassId = CloudNetworkInstanceAttachment.ClassIdEnum.CloudNetworkInstanceAttachment;
            ObjectType = CloudNetworkInstanceAttachment.ObjectTypeEnum.CloudNetworkInstanceAttachment;

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

        public CloudNetworkInstanceAttachment.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CloudNetworkInstanceAttachment.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.CloudNetworkInstanceAttachment initObject = new Intersight.Model.CloudNetworkInstanceAttachment();
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
    /// <para type="synopsis">This is the cmdlet to Initialize CloudNetworkInterfaceAttachment.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCloudNetworkInterfaceAttachment")]
    public class InitializeIntersightCloudNetworkInterfaceAttachment : PSCmdlet
    {
        public InitializeIntersightCloudNetworkInterfaceAttachment()
        {
            ClassId = CloudNetworkInterfaceAttachment.ClassIdEnum.CloudNetworkInterfaceAttachment;
            ObjectType = CloudNetworkInterfaceAttachment.ObjectTypeEnum.CloudNetworkInterfaceAttachment;

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

        public CloudNetworkInterfaceAttachment.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CloudNetworkInterfaceAttachment.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.CloudNetworkInterfaceAttachment initObject = new Intersight.Model.CloudNetworkInterfaceAttachment();
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
    /// <para type="synopsis">This is the cmdlet to Initialize CloudRegions.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCloudRegions")]
    public class InitializeIntersightCloudRegions : PSCmdlet
    {
        public InitializeIntersightCloudRegions()
        {
            ClassId = CloudRegions.ClassIdEnum.CloudRegions;
            ObjectType = CloudRegions.ObjectTypeEnum.CloudRegions;

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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> AlternateNames
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CloudRegions.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The default zone for this region."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string DefaultZone
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Property to identify regions in same category which shares credentials. For e.g. AWS Govcloud Vs AWS Global Vs AWS China."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Group
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Flag to indicate of this region is active or not."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool IsActive
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Property to pick regions for orchestration."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool IsBillingOnly
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
        /// <para type="description">"The display name of the region."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CloudRegions.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The platform type for this region. For e.g. AmazonWebService.\n* `` - An unrecognized platform type.\n* `APIC` - A Cisco Application Policy Infrastructure Controller (APIC) cluster.\n* `CAPIC` - A Cisco Cloud Application Policy Infrastructure Controller (Cloud APIC) instance.\n* `DCNM` - A Cisco Data Center Network Manager (DCNM) instance.\n* `UCSFI` - A Cisco UCS Fabric Interconnect that is managed by Cisco UCS Manager (UCSM).\n* `UCSFIISM` - A Cisco UCS Fabric Interconnect that is managed by Cisco Intersight.\n* `IMC` - A standalone Cisco UCS rack server (Deprecated).\n* `IMCM4` - A standalone Cisco UCS C-Series or S-Series M4 server.\n* `IMCM5` - A standalone Cisco UCS C-Series or S-Series M5 server.\n* `IMCRack` - A standalone Cisco UCS C-Series or S-Series M6 or newer server.\n* `UCSIOM` - A Cisco UCS Blade Chassis I/O Module (IOM).\n* `HX` - A Cisco HyperFlex (HX) cluster.\n* `UCSD` - A Cisco UCS Director (UCSD) instance.\n* `IntersightAppliance` - A Cisco Intersight Connected Virtual Appliance instance.\n* `IntersightAssist` - A Cisco Intersight Assist instance.\n* `PureStorageFlashArray` - A Pure Storage FlashArray that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer and storage management features are supported on this device.\n* `NexusDevice` - A Cisco Nexus Network Switch that is managed using Cisco Intersight Assist.\n* `ACISwitch` - A Cisco Nexus Network Switch with the embedded Device Connector and is a part of the Cisco ACI fabric.\n* `NexusSwitch` - A standalone Cisco Nexus Network Switch with the embedded Device Connector.\n* `MDSSwitch` - A Cisco MDS Switch that is managed using the embedded Device Connector.\n* `MDSDevice` - A Cisco MDS Switch that is managed using Cisco Intersight Assist.\n* `UCSC890` - A standalone Cisco UCS C890 server managed using Cisco Intersight Assist.\n* `RedfishServer` - A generic target type for servers that support Redfish APIs and is managed using Cisco Intersight Assist. Support is limited to HPE and Dell Servers.\n* `NetAppOntap` - A Netapp ONTAP Storage system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `NetAppActiveIqUnifiedManager` - A NetApp Active IQ Unified Manager (AIQUM) that is managed using Cisco Intersight Assist.\n* `EmcScaleIo` - An EMC ScaleIO Software Defined Storage system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `EmcVmax` - An EMC VMAX 2 or 3 series enterprise storage array that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `EmcVplex` - An EMC VPLEX virtual storage system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `EmcXtremIo` - An EMC XtremIO SSD storage system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `VmwareVcenter` - A VMware vCenter instance that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer and Virtualization features are supported on this hypervisor.\n* `MicrosoftHyperV` - A Microsoft Hyper-V host that is managed using Cisco Intersight Assist. Optionally, other hosts in the cluster can be discovered through this host. Cisco Intersight Workload Optimizer features are supported on this hypervisor.\n* `AppDynamics` - An AppDynamics controller running in a SaaS or on-prem datacenter. On-prem AppDynamics instance is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this controller.\n* `Dynatrace` - A Dynatrace Server instance running in a SaaS or on-prem datacenter. On-prem Dynatrace instance is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this server.\n* `NewRelic` - A NewRelic user account. The NewRelic instance monitors the application infrastructure. Cisco Intersight Workload Optimizer features are supported on this server.\n* `ServiceNow` - A cloud-based workflow automation platform that enables enterprise organizations to improve operational efficiencies by streamlining and automating routine work tasks.\n* `CloudFoundry` - An open source cloud platform on which developers can build, deploy, run and scale applications.\n* `MicrosoftAzureApplicationInsights` - A feature of Azure Monitor, is an extensible Application Performance Management service for developers and DevOps professionals to monitor their live applications.\n* `OpenStack` - An OpenStack target manages Virtual Machines, Physical Machines, Datacenters and Virtual Datacenters using different OpenStack services as administrative endpoints.\n* `MicrosoftSqlServer` - A Microsoft SQL database server that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this database.\n* `MySqlServer` - A MySQL database server that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this database.\n* `OracleDatabaseServer` - An Oracle database server that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this database.\n* `IBMWebSphereApplicationServer` - An IBM WebSphere Application server that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this application server.\n* `OracleWebLogicServer` - Oracle WebLogic Server is a unified and extensible platform for developing, deploying and running enterprise applications, such as Java, for on-premises and in the cloud. WebLogic Server offers a robust, mature, and scalable implementation of Java Enterprise Edition (EE) and Jakarta EE.\n* `ApacheTomcatServer` - An Apache Tomcat server that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this server.\n* `JavaVirtualMachine` - A JVM Application with JMX configured that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this application.\n* `RedHatJBossApplicationServer` - JBoss Application Server is an open-source, cross-platform Java application server developed by JBoss, a division of Red Hat Inc. It is an open-source implementation of Java 2 Enterprise Edition (J2EE) that is used for implementing Java applications and other Web-based applications and software.\n* `Kubernetes` - A Kubernetes cluster that runs containerized applications, with Kubernetes Collector installed. Cisco Intersight Workload Optimizer features are supported on Kubernetes cluster.\n* `AmazonWebService` - An Amazon Web Service cloud account.  Cisco Intersight Workload Optimizer and Virtualization features are supported on this cloud.\n* `AmazonWebServiceBilling` - An Amazon Web Service cloud billing account used to retrieve billing information stored in S3 bucket.  Cisco Intersight Workload Optimizer features are supported on this cloud.\n* `GoogleCloudPlatform` - A Google Cloud Platform service account with access to one or more projects.  Cisco Intersight Workload Optimizer features are supported on this cloud.\n* `GoogleCloudPlatformBilling` - A Google Cloud Platform service account used to retrieve billing information from BigQuery.  Cisco Intersight Workload Optimizer features are supported on this cloud.\n* `MicrosoftAzureServicePrincipal` - A Microsoft Azure Service Principal account with access to Azure subscriptions.  Cisco Intersight Workload Optimizer features are supported on this cloud.\n* `MicrosoftAzureEnterpriseAgreement` - A Microsoft Azure Enterprise Agreement enrolment used to retrieve pricing and billing information. Cisco Intersight Workload Optimizer features are supported on this cloud.\n* `MicrosoftAzureBilling` - A Microsoft Azure Service Principal account with access to billing information. Cisco Intersight Workload Optimizer features are supported on this cloud.\n* `DellCompellent` - A Dell EMC SC Series (Compellent) storage system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `HPE3Par` - A HPE 3PAR StoreServ system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `RedHatEnterpriseVirtualization` - A Red Hat Enterprise Virtualization Hypervisor system that manages Virtual Machines.\n* `NutanixAcropolis` - A Nutanix Acropolis cluster that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this cluster.\n* `HPEOneView` - A HPE OneView system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this system.\n* `ServiceEngine` - Cisco Application Services Engine. Cisco Application Services Engine is a platform to deploy and manage applications.\n* `HitachiVirtualStoragePlatform` - A Hitachi Virtual Storage Platform (Hitachi VSP) that is managed using Cisco Intersight Assist.\n* `GenericTarget` - A generic third-party target supported only in Partner Integration Appliance. This target type is used for development purposes and will not be supported in production environment.\n* `IMCBlade` - A Cisco UCS blade server managed by Cisco Intersight.\n* `TerraformCloud` - A Terraform Cloud Business Tier account.\n* `TerraformAgent` - A Terraform Cloud Agent that will be deployed on Cisco Intersight Assist. The agent can be used to plan and apply Terraform runs from a Terraform Cloud workspace.\n* `CustomTarget` - CustomTarget is deprecated.  Use HTTPEndpoint type to claim HTTP endpoints.\n* `AnsibleEndpoint` - An external endpoint that is added as a target  which can be accessed through Ansible in Intersight Cloud Orchestrator automation workflows.\n* `HTTPEndpoint` - An HTTP endpoint that can be accessed in Intersight Orchestrator workflows  directly or using Cisco Intersight Assist.  Authentication Schemes supported are Basic and Bearer Token.\n* `SSHEndpoint` - An SSH endpoint that can be accessed in Intersight Orchestrator workflows using Cisco Intersight Assist.\n* `CiscoCatalyst` - A Cisco Catalyst networking switch device.\n* `PowerShellEndpoint` - A Windows operating system server on which PowerShell scripts can be executed using Cisco Intersight Assist."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CloudRegions.PlatformTypeEnum PlatformType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"HTTP endpoint of the region. For example https://ec2.us-east-2.amazonaws.com."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string RegionEndPoint
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The region Id which is assigned by the cloud provider. For e.g. us-east-1."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string RegionId
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
        /// <para type="description">"A reference to a assetTarget resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.AssetTargetRelationship Target
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> Zones
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.CloudRegions initObject = new Intersight.Model.CloudRegions();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AlternateNames"))
            {
                initObject.AlternateNames = this.AlternateNames;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("DefaultZone"))
            {
                initObject.DefaultZone = this.DefaultZone;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Group"))
            {
                initObject.Group = this.Group;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IsActive"))
            {
                initObject.IsActive = this.IsActive;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IsBillingOnly"))
            {
                initObject.IsBillingOnly = this.IsBillingOnly;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("PlatformType"))
            {
                initObject.PlatformType = this.PlatformType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RegionEndPoint"))
            {
                initObject.RegionEndPoint = this.RegionEndPoint;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RegionId"))
            {
                initObject.RegionId = this.RegionId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Target"))
            {
                initObject.Target = this.Target;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Zones"))
            {
                initObject.Zones = this.Zones;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize CloudSecurityGroupRule.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCloudSecurityGroupRule")]
    public class InitializeIntersightCloudSecurityGroupRule : PSCmdlet
    {
        public InitializeIntersightCloudSecurityGroupRule()
        {
            ClassId = CloudSecurityGroupRule.ClassIdEnum.CloudSecurityGroupRule;
            ObjectType = CloudSecurityGroupRule.ObjectTypeEnum.CloudSecurityGroupRule;

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

        public CloudSecurityGroupRule.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CloudSecurityGroupRule.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.CloudSecurityGroupRule initObject = new Intersight.Model.CloudSecurityGroupRule();
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
    /// <para type="synopsis">This is the cmdlet to Initialize CloudSkuContainerType.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCloudSkuContainerType")]
    public class InitializeIntersightCloudSkuContainerType : PSCmdlet
    {
        public InitializeIntersightCloudSkuContainerType()
        {
            ClassId = CloudSkuContainerType.ClassIdEnum.CloudSkuContainerType;
            CpuUnit = CloudSkuContainerType.CpuUnitEnum.VIRTUALCPU;
            Currency = CloudSkuContainerType.CurrencyEnum.USD;
            ObjectType = CloudSkuContainerType.ObjectTypeEnum.CloudSkuContainerType;
            ServiceCategory = CloudSkuContainerType.ServiceCategoryEnum.Compute;

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
        /// <para type="description">"The cost per hour for running a Linux instance for the SKU. Cost can be higher for Windows or other licensed OS."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public float BasePrice
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CloudSkuContainerType.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The CpuUnit. Will be MILLI_CPU for containers.\n* `VIRTUAL_CPU` - The CPU unit used for virtual machines.\n* `MILLI_CPU` - The CPU unit used by containers."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CloudSkuContainerType.CpuUnitEnum CpuUnit
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The currency code used for the price. For e.g. USD or EUR.\n* `USD` - The currency code for United states dollar.\n* `EUR` - The currency code for European Union."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CloudSkuContainerType.CurrencyEnum Currency
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.CloudCustomAttributes> CustomAttributes
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Any additional description for the instance type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Flag to indicate if this SKU is active or not."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool IsActive
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Flag to indicate if SKU is discovered during inventory collection."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool IsAutoDiscovered
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
        /// <para type="description">"The display name for instance type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of CPUs in this instance type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long NumOfCpus
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CloudSkuContainerType.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The platformType for this SKU.\n* `` - An unrecognized platform type.\n* `APIC` - A Cisco Application Policy Infrastructure Controller (APIC) cluster.\n* `CAPIC` - A Cisco Cloud Application Policy Infrastructure Controller (Cloud APIC) instance.\n* `DCNM` - A Cisco Data Center Network Manager (DCNM) instance.\n* `UCSFI` - A Cisco UCS Fabric Interconnect that is managed by Cisco UCS Manager (UCSM).\n* `UCSFIISM` - A Cisco UCS Fabric Interconnect that is managed by Cisco Intersight.\n* `IMC` - A standalone Cisco UCS rack server (Deprecated).\n* `IMCM4` - A standalone Cisco UCS C-Series or S-Series M4 server.\n* `IMCM5` - A standalone Cisco UCS C-Series or S-Series M5 server.\n* `IMCRack` - A standalone Cisco UCS C-Series or S-Series M6 or newer server.\n* `UCSIOM` - A Cisco UCS Blade Chassis I/O Module (IOM).\n* `HX` - A Cisco HyperFlex (HX) cluster.\n* `UCSD` - A Cisco UCS Director (UCSD) instance.\n* `IntersightAppliance` - A Cisco Intersight Connected Virtual Appliance instance.\n* `IntersightAssist` - A Cisco Intersight Assist instance.\n* `PureStorageFlashArray` - A Pure Storage FlashArray that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer and storage management features are supported on this device.\n* `NexusDevice` - A Cisco Nexus Network Switch that is managed using Cisco Intersight Assist.\n* `ACISwitch` - A Cisco Nexus Network Switch with the embedded Device Connector and is a part of the Cisco ACI fabric.\n* `NexusSwitch` - A standalone Cisco Nexus Network Switch with the embedded Device Connector.\n* `MDSSwitch` - A Cisco MDS Switch that is managed using the embedded Device Connector.\n* `MDSDevice` - A Cisco MDS Switch that is managed using Cisco Intersight Assist.\n* `UCSC890` - A standalone Cisco UCS C890 server managed using Cisco Intersight Assist.\n* `RedfishServer` - A generic target type for servers that support Redfish APIs and is managed using Cisco Intersight Assist. Support is limited to HPE and Dell Servers.\n* `NetAppOntap` - A Netapp ONTAP Storage system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `NetAppActiveIqUnifiedManager` - A NetApp Active IQ Unified Manager (AIQUM) that is managed using Cisco Intersight Assist.\n* `EmcScaleIo` - An EMC ScaleIO Software Defined Storage system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `EmcVmax` - An EMC VMAX 2 or 3 series enterprise storage array that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `EmcVplex` - An EMC VPLEX virtual storage system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `EmcXtremIo` - An EMC XtremIO SSD storage system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `VmwareVcenter` - A VMware vCenter instance that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer and Virtualization features are supported on this hypervisor.\n* `MicrosoftHyperV` - A Microsoft Hyper-V host that is managed using Cisco Intersight Assist. Optionally, other hosts in the cluster can be discovered through this host. Cisco Intersight Workload Optimizer features are supported on this hypervisor.\n* `AppDynamics` - An AppDynamics controller running in a SaaS or on-prem datacenter. On-prem AppDynamics instance is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this controller.\n* `Dynatrace` - A Dynatrace Server instance running in a SaaS or on-prem datacenter. On-prem Dynatrace instance is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this server.\n* `NewRelic` - A NewRelic user account. The NewRelic instance monitors the application infrastructure. Cisco Intersight Workload Optimizer features are supported on this server.\n* `ServiceNow` - A cloud-based workflow automation platform that enables enterprise organizations to improve operational efficiencies by streamlining and automating routine work tasks.\n* `CloudFoundry` - An open source cloud platform on which developers can build, deploy, run and scale applications.\n* `MicrosoftAzureApplicationInsights` - A feature of Azure Monitor, is an extensible Application Performance Management service for developers and DevOps professionals to monitor their live applications.\n* `OpenStack` - An OpenStack target manages Virtual Machines, Physical Machines, Datacenters and Virtual Datacenters using different OpenStack services as administrative endpoints.\n* `MicrosoftSqlServer` - A Microsoft SQL database server that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this database.\n* `MySqlServer` - A MySQL database server that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this database.\n* `OracleDatabaseServer` - An Oracle database server that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this database.\n* `IBMWebSphereApplicationServer` - An IBM WebSphere Application server that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this application server.\n* `OracleWebLogicServer` - Oracle WebLogic Server is a unified and extensible platform for developing, deploying and running enterprise applications, such as Java, for on-premises and in the cloud. WebLogic Server offers a robust, mature, and scalable implementation of Java Enterprise Edition (EE) and Jakarta EE.\n* `ApacheTomcatServer` - An Apache Tomcat server that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this server.\n* `JavaVirtualMachine` - A JVM Application with JMX configured that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this application.\n* `RedHatJBossApplicationServer` - JBoss Application Server is an open-source, cross-platform Java application server developed by JBoss, a division of Red Hat Inc. It is an open-source implementation of Java 2 Enterprise Edition (J2EE) that is used for implementing Java applications and other Web-based applications and software.\n* `Kubernetes` - A Kubernetes cluster that runs containerized applications, with Kubernetes Collector installed. Cisco Intersight Workload Optimizer features are supported on Kubernetes cluster.\n* `AmazonWebService` - An Amazon Web Service cloud account.  Cisco Intersight Workload Optimizer and Virtualization features are supported on this cloud.\n* `AmazonWebServiceBilling` - An Amazon Web Service cloud billing account used to retrieve billing information stored in S3 bucket.  Cisco Intersight Workload Optimizer features are supported on this cloud.\n* `GoogleCloudPlatform` - A Google Cloud Platform service account with access to one or more projects.  Cisco Intersight Workload Optimizer features are supported on this cloud.\n* `GoogleCloudPlatformBilling` - A Google Cloud Platform service account used to retrieve billing information from BigQuery.  Cisco Intersight Workload Optimizer features are supported on this cloud.\n* `MicrosoftAzureServicePrincipal` - A Microsoft Azure Service Principal account with access to Azure subscriptions.  Cisco Intersight Workload Optimizer features are supported on this cloud.\n* `MicrosoftAzureEnterpriseAgreement` - A Microsoft Azure Enterprise Agreement enrolment used to retrieve pricing and billing information. Cisco Intersight Workload Optimizer features are supported on this cloud.\n* `MicrosoftAzureBilling` - A Microsoft Azure Service Principal account with access to billing information. Cisco Intersight Workload Optimizer features are supported on this cloud.\n* `DellCompellent` - A Dell EMC SC Series (Compellent) storage system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `HPE3Par` - A HPE 3PAR StoreServ system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `RedHatEnterpriseVirtualization` - A Red Hat Enterprise Virtualization Hypervisor system that manages Virtual Machines.\n* `NutanixAcropolis` - A Nutanix Acropolis cluster that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this cluster.\n* `HPEOneView` - A HPE OneView system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this system.\n* `ServiceEngine` - Cisco Application Services Engine. Cisco Application Services Engine is a platform to deploy and manage applications.\n* `HitachiVirtualStoragePlatform` - A Hitachi Virtual Storage Platform (Hitachi VSP) that is managed using Cisco Intersight Assist.\n* `GenericTarget` - A generic third-party target supported only in Partner Integration Appliance. This target type is used for development purposes and will not be supported in production environment.\n* `IMCBlade` - A Cisco UCS blade server managed by Cisco Intersight.\n* `TerraformCloud` - A Terraform Cloud Business Tier account.\n* `TerraformAgent` - A Terraform Cloud Agent that will be deployed on Cisco Intersight Assist. The agent can be used to plan and apply Terraform runs from a Terraform Cloud workspace.\n* `CustomTarget` - CustomTarget is deprecated.  Use HTTPEndpoint type to claim HTTP endpoints.\n* `AnsibleEndpoint` - An external endpoint that is added as a target  which can be accessed through Ansible in Intersight Cloud Orchestrator automation workflows.\n* `HTTPEndpoint` - An HTTP endpoint that can be accessed in Intersight Orchestrator workflows  directly or using Cisco Intersight Assist.  Authentication Schemes supported are Basic and Bearer Token.\n* `SSHEndpoint` - An SSH endpoint that can be accessed in Intersight Orchestrator workflows using Cisco Intersight Assist.\n* `CiscoCatalyst` - A Cisco Catalyst networking switch device.\n* `PowerShellEndpoint` - A Windows operating system server on which PowerShell scripts can be executed using Cisco Intersight Assist."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CloudSkuContainerType.PlatformTypeEnum PlatformType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a cloudRegions resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.CloudRegionsRelationship Region
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The region to which this Sku belongs to."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string RegionId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Indicates if this sku belongs to Compute, Storage, Database or Network category.\n* `Compute` - Compute service offered by cloud provider.\n* `Storage` - Storage service offered by cloud provider.\n* `Database` - Database service offered by cloud provider.\n* `Network` - Network service offered by cloud provider."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CloudSkuContainerType.ServiceCategoryEnum ServiceCategory
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Property to identify the family of service that the sku belongs to."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ServiceFamily
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Any display name for the ServiceCategory if available."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ServiceName
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
        /// <para type="description">"A reference to a assetTarget resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.AssetTargetRelationship Target
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The pricing associated with this Sku. Can be hourly, per minute."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Unit
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.CloudSkuContainerType initObject = new Intersight.Model.CloudSkuContainerType();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BasePrice"))
            {
                initObject.BasePrice = this.BasePrice;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("CpuUnit"))
            {
                initObject.CpuUnit = this.CpuUnit;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Currency"))
            {
                initObject.Currency = this.Currency;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CustomAttributes"))
            {
                initObject.CustomAttributes = this.CustomAttributes;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IsActive"))
            {
                initObject.IsActive = this.IsActive;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IsAutoDiscovered"))
            {
                initObject.IsAutoDiscovered = this.IsAutoDiscovered;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NumOfCpus"))
            {
                initObject.NumOfCpus = this.NumOfCpus;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("PlatformType"))
            {
                initObject.PlatformType = this.PlatformType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Region"))
            {
                initObject.Region = this.Region;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RegionId"))
            {
                initObject.RegionId = this.RegionId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ServiceCategory"))
            {
                initObject.ServiceCategory = this.ServiceCategory;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ServiceFamily"))
            {
                initObject.ServiceFamily = this.ServiceFamily;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ServiceName"))
            {
                initObject.ServiceName = this.ServiceName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Target"))
            {
                initObject.Target = this.Target;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Unit"))
            {
                initObject.Unit = this.Unit;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize CloudSkuDatabaseType.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCloudSkuDatabaseType")]
    public class InitializeIntersightCloudSkuDatabaseType : PSCmdlet
    {
        public InitializeIntersightCloudSkuDatabaseType()
        {
            ClassId = CloudSkuDatabaseType.ClassIdEnum.CloudSkuDatabaseType;
            Currency = CloudSkuDatabaseType.CurrencyEnum.USD;
            ObjectType = CloudSkuDatabaseType.ObjectTypeEnum.CloudSkuDatabaseType;
            ServiceCategory = CloudSkuDatabaseType.ServiceCategoryEnum.Compute;

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
        /// <para type="description">"The cost per hour for running a Linux instance for the SKU. Cost can be higher for Windows or other licensed OS."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public float BasePrice
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CloudSkuDatabaseType.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The currency code used for the price. For e.g. USD or EUR.\n* `USD` - The currency code for United states dollar.\n* `EUR` - The currency code for European Union."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CloudSkuDatabaseType.CurrencyEnum Currency
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.CloudCustomAttributes> CustomAttributes
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The database edition. For e.g. standard or enterprise."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string DatabaseEdition
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The database engine. For e.g. SQL Server, Oracle, PostgreSQL."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string DatabaseEngine
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Any additional description for the instance type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Flag to indicate if this SKU is active or not."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool IsActive
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Flag to indicate if SKU is discovered during inventory collection."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool IsAutoDiscovered
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The licensing option for the database. For e.g. license required or not."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string LicenseModel
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
        /// <para type="description">"The display name for instance type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Network performance of this instance type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string NetworkPerformance
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CloudSkuDatabaseType.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The platformType for this SKU.\n* `` - An unrecognized platform type.\n* `APIC` - A Cisco Application Policy Infrastructure Controller (APIC) cluster.\n* `CAPIC` - A Cisco Cloud Application Policy Infrastructure Controller (Cloud APIC) instance.\n* `DCNM` - A Cisco Data Center Network Manager (DCNM) instance.\n* `UCSFI` - A Cisco UCS Fabric Interconnect that is managed by Cisco UCS Manager (UCSM).\n* `UCSFIISM` - A Cisco UCS Fabric Interconnect that is managed by Cisco Intersight.\n* `IMC` - A standalone Cisco UCS rack server (Deprecated).\n* `IMCM4` - A standalone Cisco UCS C-Series or S-Series M4 server.\n* `IMCM5` - A standalone Cisco UCS C-Series or S-Series M5 server.\n* `IMCRack` - A standalone Cisco UCS C-Series or S-Series M6 or newer server.\n* `UCSIOM` - A Cisco UCS Blade Chassis I/O Module (IOM).\n* `HX` - A Cisco HyperFlex (HX) cluster.\n* `UCSD` - A Cisco UCS Director (UCSD) instance.\n* `IntersightAppliance` - A Cisco Intersight Connected Virtual Appliance instance.\n* `IntersightAssist` - A Cisco Intersight Assist instance.\n* `PureStorageFlashArray` - A Pure Storage FlashArray that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer and storage management features are supported on this device.\n* `NexusDevice` - A Cisco Nexus Network Switch that is managed using Cisco Intersight Assist.\n* `ACISwitch` - A Cisco Nexus Network Switch with the embedded Device Connector and is a part of the Cisco ACI fabric.\n* `NexusSwitch` - A standalone Cisco Nexus Network Switch with the embedded Device Connector.\n* `MDSSwitch` - A Cisco MDS Switch that is managed using the embedded Device Connector.\n* `MDSDevice` - A Cisco MDS Switch that is managed using Cisco Intersight Assist.\n* `UCSC890` - A standalone Cisco UCS C890 server managed using Cisco Intersight Assist.\n* `RedfishServer` - A generic target type for servers that support Redfish APIs and is managed using Cisco Intersight Assist. Support is limited to HPE and Dell Servers.\n* `NetAppOntap` - A Netapp ONTAP Storage system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `NetAppActiveIqUnifiedManager` - A NetApp Active IQ Unified Manager (AIQUM) that is managed using Cisco Intersight Assist.\n* `EmcScaleIo` - An EMC ScaleIO Software Defined Storage system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `EmcVmax` - An EMC VMAX 2 or 3 series enterprise storage array that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `EmcVplex` - An EMC VPLEX virtual storage system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `EmcXtremIo` - An EMC XtremIO SSD storage system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `VmwareVcenter` - A VMware vCenter instance that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer and Virtualization features are supported on this hypervisor.\n* `MicrosoftHyperV` - A Microsoft Hyper-V host that is managed using Cisco Intersight Assist. Optionally, other hosts in the cluster can be discovered through this host. Cisco Intersight Workload Optimizer features are supported on this hypervisor.\n* `AppDynamics` - An AppDynamics controller running in a SaaS or on-prem datacenter. On-prem AppDynamics instance is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this controller.\n* `Dynatrace` - A Dynatrace Server instance running in a SaaS or on-prem datacenter. On-prem Dynatrace instance is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this server.\n* `NewRelic` - A NewRelic user account. The NewRelic instance monitors the application infrastructure. Cisco Intersight Workload Optimizer features are supported on this server.\n* `ServiceNow` - A cloud-based workflow automation platform that enables enterprise organizations to improve operational efficiencies by streamlining and automating routine work tasks.\n* `CloudFoundry` - An open source cloud platform on which developers can build, deploy, run and scale applications.\n* `MicrosoftAzureApplicationInsights` - A feature of Azure Monitor, is an extensible Application Performance Management service for developers and DevOps professionals to monitor their live applications.\n* `OpenStack` - An OpenStack target manages Virtual Machines, Physical Machines, Datacenters and Virtual Datacenters using different OpenStack services as administrative endpoints.\n* `MicrosoftSqlServer` - A Microsoft SQL database server that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this database.\n* `MySqlServer` - A MySQL database server that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this database.\n* `OracleDatabaseServer` - An Oracle database server that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this database.\n* `IBMWebSphereApplicationServer` - An IBM WebSphere Application server that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this application server.\n* `OracleWebLogicServer` - Oracle WebLogic Server is a unified and extensible platform for developing, deploying and running enterprise applications, such as Java, for on-premises and in the cloud. WebLogic Server offers a robust, mature, and scalable implementation of Java Enterprise Edition (EE) and Jakarta EE.\n* `ApacheTomcatServer` - An Apache Tomcat server that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this server.\n* `JavaVirtualMachine` - A JVM Application with JMX configured that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this application.\n* `RedHatJBossApplicationServer` - JBoss Application Server is an open-source, cross-platform Java application server developed by JBoss, a division of Red Hat Inc. It is an open-source implementation of Java 2 Enterprise Edition (J2EE) that is used for implementing Java applications and other Web-based applications and software.\n* `Kubernetes` - A Kubernetes cluster that runs containerized applications, with Kubernetes Collector installed. Cisco Intersight Workload Optimizer features are supported on Kubernetes cluster.\n* `AmazonWebService` - An Amazon Web Service cloud account.  Cisco Intersight Workload Optimizer and Virtualization features are supported on this cloud.\n* `AmazonWebServiceBilling` - An Amazon Web Service cloud billing account used to retrieve billing information stored in S3 bucket.  Cisco Intersight Workload Optimizer features are supported on this cloud.\n* `GoogleCloudPlatform` - A Google Cloud Platform service account with access to one or more projects.  Cisco Intersight Workload Optimizer features are supported on this cloud.\n* `GoogleCloudPlatformBilling` - A Google Cloud Platform service account used to retrieve billing information from BigQuery.  Cisco Intersight Workload Optimizer features are supported on this cloud.\n* `MicrosoftAzureServicePrincipal` - A Microsoft Azure Service Principal account with access to Azure subscriptions.  Cisco Intersight Workload Optimizer features are supported on this cloud.\n* `MicrosoftAzureEnterpriseAgreement` - A Microsoft Azure Enterprise Agreement enrolment used to retrieve pricing and billing information. Cisco Intersight Workload Optimizer features are supported on this cloud.\n* `MicrosoftAzureBilling` - A Microsoft Azure Service Principal account with access to billing information. Cisco Intersight Workload Optimizer features are supported on this cloud.\n* `DellCompellent` - A Dell EMC SC Series (Compellent) storage system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `HPE3Par` - A HPE 3PAR StoreServ system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `RedHatEnterpriseVirtualization` - A Red Hat Enterprise Virtualization Hypervisor system that manages Virtual Machines.\n* `NutanixAcropolis` - A Nutanix Acropolis cluster that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this cluster.\n* `HPEOneView` - A HPE OneView system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this system.\n* `ServiceEngine` - Cisco Application Services Engine. Cisco Application Services Engine is a platform to deploy and manage applications.\n* `HitachiVirtualStoragePlatform` - A Hitachi Virtual Storage Platform (Hitachi VSP) that is managed using Cisco Intersight Assist.\n* `GenericTarget` - A generic third-party target supported only in Partner Integration Appliance. This target type is used for development purposes and will not be supported in production environment.\n* `IMCBlade` - A Cisco UCS blade server managed by Cisco Intersight.\n* `TerraformCloud` - A Terraform Cloud Business Tier account.\n* `TerraformAgent` - A Terraform Cloud Agent that will be deployed on Cisco Intersight Assist. The agent can be used to plan and apply Terraform runs from a Terraform Cloud workspace.\n* `CustomTarget` - CustomTarget is deprecated.  Use HTTPEndpoint type to claim HTTP endpoints.\n* `AnsibleEndpoint` - An external endpoint that is added as a target  which can be accessed through Ansible in Intersight Cloud Orchestrator automation workflows.\n* `HTTPEndpoint` - An HTTP endpoint that can be accessed in Intersight Orchestrator workflows  directly or using Cisco Intersight Assist.  Authentication Schemes supported are Basic and Bearer Token.\n* `SSHEndpoint` - An SSH endpoint that can be accessed in Intersight Orchestrator workflows using Cisco Intersight Assist.\n* `CiscoCatalyst` - A Cisco Catalyst networking switch device.\n* `PowerShellEndpoint` - A Windows operating system server on which PowerShell scripts can be executed using Cisco Intersight Assist."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CloudSkuDatabaseType.PlatformTypeEnum PlatformType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a cloudRegions resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.CloudRegionsRelationship Region
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The region to which this Sku belongs to."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string RegionId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Indicates if this sku belongs to Compute, Storage, Database or Network category.\n* `Compute` - Compute service offered by cloud provider.\n* `Storage` - Storage service offered by cloud provider.\n* `Database` - Database service offered by cloud provider.\n* `Network` - Network service offered by cloud provider."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CloudSkuDatabaseType.ServiceCategoryEnum ServiceCategory
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Property to identify the family of service that the sku belongs to."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ServiceFamily
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Any display name for the ServiceCategory if available."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ServiceName
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
        /// <para type="description">"A reference to a assetTarget resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.AssetTargetRelationship Target
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The pricing associated with this Sku. Can be hourly, per minute."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Unit
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.CloudSkuDatabaseType initObject = new Intersight.Model.CloudSkuDatabaseType();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BasePrice"))
            {
                initObject.BasePrice = this.BasePrice;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Currency"))
            {
                initObject.Currency = this.Currency;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CustomAttributes"))
            {
                initObject.CustomAttributes = this.CustomAttributes;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DatabaseEdition"))
            {
                initObject.DatabaseEdition = this.DatabaseEdition;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DatabaseEngine"))
            {
                initObject.DatabaseEngine = this.DatabaseEngine;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IsActive"))
            {
                initObject.IsActive = this.IsActive;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IsAutoDiscovered"))
            {
                initObject.IsAutoDiscovered = this.IsAutoDiscovered;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LicenseModel"))
            {
                initObject.LicenseModel = this.LicenseModel;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NetworkPerformance"))
            {
                initObject.NetworkPerformance = this.NetworkPerformance;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("PlatformType"))
            {
                initObject.PlatformType = this.PlatformType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Region"))
            {
                initObject.Region = this.Region;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RegionId"))
            {
                initObject.RegionId = this.RegionId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ServiceCategory"))
            {
                initObject.ServiceCategory = this.ServiceCategory;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ServiceFamily"))
            {
                initObject.ServiceFamily = this.ServiceFamily;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ServiceName"))
            {
                initObject.ServiceName = this.ServiceName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Target"))
            {
                initObject.Target = this.Target;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Unit"))
            {
                initObject.Unit = this.Unit;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize CloudSkuInstanceType.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCloudSkuInstanceType")]
    public class InitializeIntersightCloudSkuInstanceType : PSCmdlet
    {
        public InitializeIntersightCloudSkuInstanceType()
        {
            ArchitectureType = CloudSkuInstanceType.ArchitectureTypeEnum._64Bit;
            ClassId = CloudSkuInstanceType.ClassIdEnum.CloudSkuInstanceType;
            CpuUnit = CloudSkuInstanceType.CpuUnitEnum.VIRTUALCPU;
            Currency = CloudSkuInstanceType.CurrencyEnum.USD;
            LocalStorageSizeUnit = CloudSkuInstanceType.LocalStorageSizeUnitEnum.MB;
            MemorySizeUnit = CloudSkuInstanceType.MemorySizeUnitEnum.MB;
            ObjectType = CloudSkuInstanceType.ObjectTypeEnum.CloudSkuInstanceType;
            ServiceCategory = CloudSkuInstanceType.ServiceCategoryEnum.Compute;

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
        /// <para type="description">"Indicates if the instance type supports 32 or 64 bit or both.\n* `64Bit` - Enum to indicate that the instance type suppports only 64 bit architecture.\n* `32Bit` - Enum to indicate that the instance type supports only 32 bit architecture.\n* `both` - Enum to indicate that the instance type supports both 32 and 64 bit architecture."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CloudSkuInstanceType.ArchitectureTypeEnum ArchitectureType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The cost per hour for running a Linux instance for the SKU. Cost can be higher for Windows or other licensed OS."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public float BasePrice
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CloudSkuInstanceType.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The cpu unit for this instance type.\n* `VIRTUAL_CPU` - The CPU unit used for virtual machines.\n* `MILLI_CPU` - The CPU unit used by containers."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CloudSkuInstanceType.CpuUnitEnum CpuUnit
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Does the instanceType support CUDA architecture."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool CudaSupport
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The currency code used for the price. For e.g. USD or EUR.\n* `USD` - The currency code for United states dollar.\n* `EUR` - The currency code for European Union."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CloudSkuInstanceType.CurrencyEnum Currency
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.CloudCustomAttributes> CustomAttributes
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Any additional description for the instance type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Flag to indicate if this SKU is active or not."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool IsActive
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Flag to indicate if SKU is discovered during inventory collection."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool IsAutoDiscovered
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Total size of local storage for this instance type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public float LocalStorageSize
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The units for this storage. For e.g. MB or GB or TB.\n* `MB` - Enum to represent mega byte storage unit.\n* `GB` - Enum to represent Giga byte storage unit.\n* `TB` - Enum to represent Tera byte storage unit."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CloudSkuInstanceType.LocalStorageSizeUnitEnum LocalStorageSizeUnit
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The RAM size for this instance type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public float MemorySize
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Units to represent memory, for e.g. MB or GB.\n* `MB` - Enum to represent mega byte storage unit.\n* `GB` - Enum to represent Giga byte storage unit.\n* `TB` - Enum to represent Tera byte storage unit."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CloudSkuInstanceType.MemorySizeUnitEnum MemorySizeUnit
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
        /// <para type="description">"The display name for instance type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Network performance of this instance type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string NetworkPerformance
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of CPUs in this instance type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long NumOfCpus
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Maximum number of NICs supported by this instance type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long NumOfNics
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CloudSkuInstanceType.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The platformType for this SKU.\n* `` - An unrecognized platform type.\n* `APIC` - A Cisco Application Policy Infrastructure Controller (APIC) cluster.\n* `CAPIC` - A Cisco Cloud Application Policy Infrastructure Controller (Cloud APIC) instance.\n* `DCNM` - A Cisco Data Center Network Manager (DCNM) instance.\n* `UCSFI` - A Cisco UCS Fabric Interconnect that is managed by Cisco UCS Manager (UCSM).\n* `UCSFIISM` - A Cisco UCS Fabric Interconnect that is managed by Cisco Intersight.\n* `IMC` - A standalone Cisco UCS rack server (Deprecated).\n* `IMCM4` - A standalone Cisco UCS C-Series or S-Series M4 server.\n* `IMCM5` - A standalone Cisco UCS C-Series or S-Series M5 server.\n* `IMCRack` - A standalone Cisco UCS C-Series or S-Series M6 or newer server.\n* `UCSIOM` - A Cisco UCS Blade Chassis I/O Module (IOM).\n* `HX` - A Cisco HyperFlex (HX) cluster.\n* `UCSD` - A Cisco UCS Director (UCSD) instance.\n* `IntersightAppliance` - A Cisco Intersight Connected Virtual Appliance instance.\n* `IntersightAssist` - A Cisco Intersight Assist instance.\n* `PureStorageFlashArray` - A Pure Storage FlashArray that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer and storage management features are supported on this device.\n* `NexusDevice` - A Cisco Nexus Network Switch that is managed using Cisco Intersight Assist.\n* `ACISwitch` - A Cisco Nexus Network Switch with the embedded Device Connector and is a part of the Cisco ACI fabric.\n* `NexusSwitch` - A standalone Cisco Nexus Network Switch with the embedded Device Connector.\n* `MDSSwitch` - A Cisco MDS Switch that is managed using the embedded Device Connector.\n* `MDSDevice` - A Cisco MDS Switch that is managed using Cisco Intersight Assist.\n* `UCSC890` - A standalone Cisco UCS C890 server managed using Cisco Intersight Assist.\n* `RedfishServer` - A generic target type for servers that support Redfish APIs and is managed using Cisco Intersight Assist. Support is limited to HPE and Dell Servers.\n* `NetAppOntap` - A Netapp ONTAP Storage system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `NetAppActiveIqUnifiedManager` - A NetApp Active IQ Unified Manager (AIQUM) that is managed using Cisco Intersight Assist.\n* `EmcScaleIo` - An EMC ScaleIO Software Defined Storage system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `EmcVmax` - An EMC VMAX 2 or 3 series enterprise storage array that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `EmcVplex` - An EMC VPLEX virtual storage system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `EmcXtremIo` - An EMC XtremIO SSD storage system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `VmwareVcenter` - A VMware vCenter instance that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer and Virtualization features are supported on this hypervisor.\n* `MicrosoftHyperV` - A Microsoft Hyper-V host that is managed using Cisco Intersight Assist. Optionally, other hosts in the cluster can be discovered through this host. Cisco Intersight Workload Optimizer features are supported on this hypervisor.\n* `AppDynamics` - An AppDynamics controller running in a SaaS or on-prem datacenter. On-prem AppDynamics instance is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this controller.\n* `Dynatrace` - A Dynatrace Server instance running in a SaaS or on-prem datacenter. On-prem Dynatrace instance is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this server.\n* `NewRelic` - A NewRelic user account. The NewRelic instance monitors the application infrastructure. Cisco Intersight Workload Optimizer features are supported on this server.\n* `ServiceNow` - A cloud-based workflow automation platform that enables enterprise organizations to improve operational efficiencies by streamlining and automating routine work tasks.\n* `CloudFoundry` - An open source cloud platform on which developers can build, deploy, run and scale applications.\n* `MicrosoftAzureApplicationInsights` - A feature of Azure Monitor, is an extensible Application Performance Management service for developers and DevOps professionals to monitor their live applications.\n* `OpenStack` - An OpenStack target manages Virtual Machines, Physical Machines, Datacenters and Virtual Datacenters using different OpenStack services as administrative endpoints.\n* `MicrosoftSqlServer` - A Microsoft SQL database server that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this database.\n* `MySqlServer` - A MySQL database server that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this database.\n* `OracleDatabaseServer` - An Oracle database server that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this database.\n* `IBMWebSphereApplicationServer` - An IBM WebSphere Application server that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this application server.\n* `OracleWebLogicServer` - Oracle WebLogic Server is a unified and extensible platform for developing, deploying and running enterprise applications, such as Java, for on-premises and in the cloud. WebLogic Server offers a robust, mature, and scalable implementation of Java Enterprise Edition (EE) and Jakarta EE.\n* `ApacheTomcatServer` - An Apache Tomcat server that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this server.\n* `JavaVirtualMachine` - A JVM Application with JMX configured that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this application.\n* `RedHatJBossApplicationServer` - JBoss Application Server is an open-source, cross-platform Java application server developed by JBoss, a division of Red Hat Inc. It is an open-source implementation of Java 2 Enterprise Edition (J2EE) that is used for implementing Java applications and other Web-based applications and software.\n* `Kubernetes` - A Kubernetes cluster that runs containerized applications, with Kubernetes Collector installed. Cisco Intersight Workload Optimizer features are supported on Kubernetes cluster.\n* `AmazonWebService` - An Amazon Web Service cloud account.  Cisco Intersight Workload Optimizer and Virtualization features are supported on this cloud.\n* `AmazonWebServiceBilling` - An Amazon Web Service cloud billing account used to retrieve billing information stored in S3 bucket.  Cisco Intersight Workload Optimizer features are supported on this cloud.\n* `GoogleCloudPlatform` - A Google Cloud Platform service account with access to one or more projects.  Cisco Intersight Workload Optimizer features are supported on this cloud.\n* `GoogleCloudPlatformBilling` - A Google Cloud Platform service account used to retrieve billing information from BigQuery.  Cisco Intersight Workload Optimizer features are supported on this cloud.\n* `MicrosoftAzureServicePrincipal` - A Microsoft Azure Service Principal account with access to Azure subscriptions.  Cisco Intersight Workload Optimizer features are supported on this cloud.\n* `MicrosoftAzureEnterpriseAgreement` - A Microsoft Azure Enterprise Agreement enrolment used to retrieve pricing and billing information. Cisco Intersight Workload Optimizer features are supported on this cloud.\n* `MicrosoftAzureBilling` - A Microsoft Azure Service Principal account with access to billing information. Cisco Intersight Workload Optimizer features are supported on this cloud.\n* `DellCompellent` - A Dell EMC SC Series (Compellent) storage system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `HPE3Par` - A HPE 3PAR StoreServ system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `RedHatEnterpriseVirtualization` - A Red Hat Enterprise Virtualization Hypervisor system that manages Virtual Machines.\n* `NutanixAcropolis` - A Nutanix Acropolis cluster that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this cluster.\n* `HPEOneView` - A HPE OneView system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this system.\n* `ServiceEngine` - Cisco Application Services Engine. Cisco Application Services Engine is a platform to deploy and manage applications.\n* `HitachiVirtualStoragePlatform` - A Hitachi Virtual Storage Platform (Hitachi VSP) that is managed using Cisco Intersight Assist.\n* `GenericTarget` - A generic third-party target supported only in Partner Integration Appliance. This target type is used for development purposes and will not be supported in production environment.\n* `IMCBlade` - A Cisco UCS blade server managed by Cisco Intersight.\n* `TerraformCloud` - A Terraform Cloud Business Tier account.\n* `TerraformAgent` - A Terraform Cloud Agent that will be deployed on Cisco Intersight Assist. The agent can be used to plan and apply Terraform runs from a Terraform Cloud workspace.\n* `CustomTarget` - CustomTarget is deprecated.  Use HTTPEndpoint type to claim HTTP endpoints.\n* `AnsibleEndpoint` - An external endpoint that is added as a target  which can be accessed through Ansible in Intersight Cloud Orchestrator automation workflows.\n* `HTTPEndpoint` - An HTTP endpoint that can be accessed in Intersight Orchestrator workflows  directly or using Cisco Intersight Assist.  Authentication Schemes supported are Basic and Bearer Token.\n* `SSHEndpoint` - An SSH endpoint that can be accessed in Intersight Orchestrator workflows using Cisco Intersight Assist.\n* `CiscoCatalyst` - A Cisco Catalyst networking switch device.\n* `PowerShellEndpoint` - A Windows operating system server on which PowerShell scripts can be executed using Cisco Intersight Assist."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CloudSkuInstanceType.PlatformTypeEnum PlatformType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a cloudRegions resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.CloudRegionsRelationship Region
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The region to which this Sku belongs to."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string RegionId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Indicates if this sku belongs to Compute, Storage, Database or Network category.\n* `Compute` - Compute service offered by cloud provider.\n* `Storage` - Storage service offered by cloud provider.\n* `Database` - Database service offered by cloud provider.\n* `Network` - Network service offered by cloud provider."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CloudSkuInstanceType.ServiceCategoryEnum ServiceCategory
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Property to identify the family of service that the sku belongs to."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ServiceFamily
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Any display name for the ServiceCategory if available."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ServiceName
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
        /// <para type="description">"A reference to a assetTarget resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.AssetTargetRelationship Target
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The pricing associated with this Sku. Can be hourly, per minute."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Unit
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.CloudSkuInstanceType initObject = new Intersight.Model.CloudSkuInstanceType();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ArchitectureType"))
            {
                initObject.ArchitectureType = this.ArchitectureType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BasePrice"))
            {
                initObject.BasePrice = this.BasePrice;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("CpuUnit"))
            {
                initObject.CpuUnit = this.CpuUnit;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CudaSupport"))
            {
                initObject.CudaSupport = this.CudaSupport;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Currency"))
            {
                initObject.Currency = this.Currency;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CustomAttributes"))
            {
                initObject.CustomAttributes = this.CustomAttributes;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IsActive"))
            {
                initObject.IsActive = this.IsActive;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IsAutoDiscovered"))
            {
                initObject.IsAutoDiscovered = this.IsAutoDiscovered;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LocalStorageSize"))
            {
                initObject.LocalStorageSize = this.LocalStorageSize;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LocalStorageSizeUnit"))
            {
                initObject.LocalStorageSizeUnit = this.LocalStorageSizeUnit;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MemorySize"))
            {
                initObject.MemorySize = this.MemorySize;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MemorySizeUnit"))
            {
                initObject.MemorySizeUnit = this.MemorySizeUnit;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NetworkPerformance"))
            {
                initObject.NetworkPerformance = this.NetworkPerformance;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NumOfCpus"))
            {
                initObject.NumOfCpus = this.NumOfCpus;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NumOfNics"))
            {
                initObject.NumOfNics = this.NumOfNics;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("PlatformType"))
            {
                initObject.PlatformType = this.PlatformType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Region"))
            {
                initObject.Region = this.Region;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RegionId"))
            {
                initObject.RegionId = this.RegionId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ServiceCategory"))
            {
                initObject.ServiceCategory = this.ServiceCategory;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ServiceFamily"))
            {
                initObject.ServiceFamily = this.ServiceFamily;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ServiceName"))
            {
                initObject.ServiceName = this.ServiceName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Target"))
            {
                initObject.Target = this.Target;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Unit"))
            {
                initObject.Unit = this.Unit;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize CloudSkuNetworkType.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCloudSkuNetworkType")]
    public class InitializeIntersightCloudSkuNetworkType : PSCmdlet
    {
        public InitializeIntersightCloudSkuNetworkType()
        {
            Currency = CloudSkuNetworkType.CurrencyEnum.USD;
            ServiceCategory = CloudSkuNetworkType.ServiceCategoryEnum.Compute;

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
        /// <para type="description">"The cost per hour for running a Linux instance for the SKU. Cost can be higher for Windows or other licensed OS."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public float BasePrice
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CloudSkuNetworkType.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The currency code used for the price. For e.g. USD or EUR.\n* `USD` - The currency code for United states dollar.\n* `EUR` - The currency code for European Union."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CloudSkuNetworkType.CurrencyEnum Currency
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.CloudCustomAttributes> CustomAttributes
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Any additional description for the instance type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Flag to indicate if this SKU is active or not."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool IsActive
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Flag to indicate if SKU is discovered during inventory collection."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool IsAutoDiscovered
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
        /// <para type="description">"The display name for instance type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CloudSkuNetworkType.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The platformType for this SKU.\n* `` - An unrecognized platform type.\n* `APIC` - A Cisco Application Policy Infrastructure Controller (APIC) cluster.\n* `CAPIC` - A Cisco Cloud Application Policy Infrastructure Controller (Cloud APIC) instance.\n* `DCNM` - A Cisco Data Center Network Manager (DCNM) instance.\n* `UCSFI` - A Cisco UCS Fabric Interconnect that is managed by Cisco UCS Manager (UCSM).\n* `UCSFIISM` - A Cisco UCS Fabric Interconnect that is managed by Cisco Intersight.\n* `IMC` - A standalone Cisco UCS rack server (Deprecated).\n* `IMCM4` - A standalone Cisco UCS C-Series or S-Series M4 server.\n* `IMCM5` - A standalone Cisco UCS C-Series or S-Series M5 server.\n* `IMCRack` - A standalone Cisco UCS C-Series or S-Series M6 or newer server.\n* `UCSIOM` - A Cisco UCS Blade Chassis I/O Module (IOM).\n* `HX` - A Cisco HyperFlex (HX) cluster.\n* `UCSD` - A Cisco UCS Director (UCSD) instance.\n* `IntersightAppliance` - A Cisco Intersight Connected Virtual Appliance instance.\n* `IntersightAssist` - A Cisco Intersight Assist instance.\n* `PureStorageFlashArray` - A Pure Storage FlashArray that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer and storage management features are supported on this device.\n* `NexusDevice` - A Cisco Nexus Network Switch that is managed using Cisco Intersight Assist.\n* `ACISwitch` - A Cisco Nexus Network Switch with the embedded Device Connector and is a part of the Cisco ACI fabric.\n* `NexusSwitch` - A standalone Cisco Nexus Network Switch with the embedded Device Connector.\n* `MDSSwitch` - A Cisco MDS Switch that is managed using the embedded Device Connector.\n* `MDSDevice` - A Cisco MDS Switch that is managed using Cisco Intersight Assist.\n* `UCSC890` - A standalone Cisco UCS C890 server managed using Cisco Intersight Assist.\n* `RedfishServer` - A generic target type for servers that support Redfish APIs and is managed using Cisco Intersight Assist. Support is limited to HPE and Dell Servers.\n* `NetAppOntap` - A Netapp ONTAP Storage system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `NetAppActiveIqUnifiedManager` - A NetApp Active IQ Unified Manager (AIQUM) that is managed using Cisco Intersight Assist.\n* `EmcScaleIo` - An EMC ScaleIO Software Defined Storage system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `EmcVmax` - An EMC VMAX 2 or 3 series enterprise storage array that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `EmcVplex` - An EMC VPLEX virtual storage system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `EmcXtremIo` - An EMC XtremIO SSD storage system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `VmwareVcenter` - A VMware vCenter instance that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer and Virtualization features are supported on this hypervisor.\n* `MicrosoftHyperV` - A Microsoft Hyper-V host that is managed using Cisco Intersight Assist. Optionally, other hosts in the cluster can be discovered through this host. Cisco Intersight Workload Optimizer features are supported on this hypervisor.\n* `AppDynamics` - An AppDynamics controller running in a SaaS or on-prem datacenter. On-prem AppDynamics instance is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this controller.\n* `Dynatrace` - A Dynatrace Server instance running in a SaaS or on-prem datacenter. On-prem Dynatrace instance is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this server.\n* `NewRelic` - A NewRelic user account. The NewRelic instance monitors the application infrastructure. Cisco Intersight Workload Optimizer features are supported on this server.\n* `ServiceNow` - A cloud-based workflow automation platform that enables enterprise organizations to improve operational efficiencies by streamlining and automating routine work tasks.\n* `CloudFoundry` - An open source cloud platform on which developers can build, deploy, run and scale applications.\n* `MicrosoftAzureApplicationInsights` - A feature of Azure Monitor, is an extensible Application Performance Management service for developers and DevOps professionals to monitor their live applications.\n* `OpenStack` - An OpenStack target manages Virtual Machines, Physical Machines, Datacenters and Virtual Datacenters using different OpenStack services as administrative endpoints.\n* `MicrosoftSqlServer` - A Microsoft SQL database server that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this database.\n* `MySqlServer` - A MySQL database server that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this database.\n* `OracleDatabaseServer` - An Oracle database server that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this database.\n* `IBMWebSphereApplicationServer` - An IBM WebSphere Application server that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this application server.\n* `OracleWebLogicServer` - Oracle WebLogic Server is a unified and extensible platform for developing, deploying and running enterprise applications, such as Java, for on-premises and in the cloud. WebLogic Server offers a robust, mature, and scalable implementation of Java Enterprise Edition (EE) and Jakarta EE.\n* `ApacheTomcatServer` - An Apache Tomcat server that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this server.\n* `JavaVirtualMachine` - A JVM Application with JMX configured that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this application.\n* `RedHatJBossApplicationServer` - JBoss Application Server is an open-source, cross-platform Java application server developed by JBoss, a division of Red Hat Inc. It is an open-source implementation of Java 2 Enterprise Edition (J2EE) that is used for implementing Java applications and other Web-based applications and software.\n* `Kubernetes` - A Kubernetes cluster that runs containerized applications, with Kubernetes Collector installed. Cisco Intersight Workload Optimizer features are supported on Kubernetes cluster.\n* `AmazonWebService` - An Amazon Web Service cloud account.  Cisco Intersight Workload Optimizer and Virtualization features are supported on this cloud.\n* `AmazonWebServiceBilling` - An Amazon Web Service cloud billing account used to retrieve billing information stored in S3 bucket.  Cisco Intersight Workload Optimizer features are supported on this cloud.\n* `GoogleCloudPlatform` - A Google Cloud Platform service account with access to one or more projects.  Cisco Intersight Workload Optimizer features are supported on this cloud.\n* `GoogleCloudPlatformBilling` - A Google Cloud Platform service account used to retrieve billing information from BigQuery.  Cisco Intersight Workload Optimizer features are supported on this cloud.\n* `MicrosoftAzureServicePrincipal` - A Microsoft Azure Service Principal account with access to Azure subscriptions.  Cisco Intersight Workload Optimizer features are supported on this cloud.\n* `MicrosoftAzureEnterpriseAgreement` - A Microsoft Azure Enterprise Agreement enrolment used to retrieve pricing and billing information. Cisco Intersight Workload Optimizer features are supported on this cloud.\n* `MicrosoftAzureBilling` - A Microsoft Azure Service Principal account with access to billing information. Cisco Intersight Workload Optimizer features are supported on this cloud.\n* `DellCompellent` - A Dell EMC SC Series (Compellent) storage system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `HPE3Par` - A HPE 3PAR StoreServ system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `RedHatEnterpriseVirtualization` - A Red Hat Enterprise Virtualization Hypervisor system that manages Virtual Machines.\n* `NutanixAcropolis` - A Nutanix Acropolis cluster that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this cluster.\n* `HPEOneView` - A HPE OneView system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this system.\n* `ServiceEngine` - Cisco Application Services Engine. Cisco Application Services Engine is a platform to deploy and manage applications.\n* `HitachiVirtualStoragePlatform` - A Hitachi Virtual Storage Platform (Hitachi VSP) that is managed using Cisco Intersight Assist.\n* `GenericTarget` - A generic third-party target supported only in Partner Integration Appliance. This target type is used for development purposes and will not be supported in production environment.\n* `IMCBlade` - A Cisco UCS blade server managed by Cisco Intersight.\n* `TerraformCloud` - A Terraform Cloud Business Tier account.\n* `TerraformAgent` - A Terraform Cloud Agent that will be deployed on Cisco Intersight Assist. The agent can be used to plan and apply Terraform runs from a Terraform Cloud workspace.\n* `CustomTarget` - CustomTarget is deprecated.  Use HTTPEndpoint type to claim HTTP endpoints.\n* `AnsibleEndpoint` - An external endpoint that is added as a target  which can be accessed through Ansible in Intersight Cloud Orchestrator automation workflows.\n* `HTTPEndpoint` - An HTTP endpoint that can be accessed in Intersight Orchestrator workflows  directly or using Cisco Intersight Assist.  Authentication Schemes supported are Basic and Bearer Token.\n* `SSHEndpoint` - An SSH endpoint that can be accessed in Intersight Orchestrator workflows using Cisco Intersight Assist.\n* `CiscoCatalyst` - A Cisco Catalyst networking switch device.\n* `PowerShellEndpoint` - A Windows operating system server on which PowerShell scripts can be executed using Cisco Intersight Assist."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CloudSkuNetworkType.PlatformTypeEnum PlatformType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a cloudRegions resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.CloudRegionsRelationship Region
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The region to which this Sku belongs to."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string RegionId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Indicates if this sku belongs to Compute, Storage, Database or Network category.\n* `Compute` - Compute service offered by cloud provider.\n* `Storage` - Storage service offered by cloud provider.\n* `Database` - Database service offered by cloud provider.\n* `Network` - Network service offered by cloud provider."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CloudSkuNetworkType.ServiceCategoryEnum ServiceCategory
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Property to identify the family of service that the sku belongs to."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ServiceFamily
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Any display name for the ServiceCategory if available."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ServiceName
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
        /// <para type="description">"A reference to a assetTarget resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.AssetTargetRelationship Target
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The pricing associated with this Sku. Can be hourly, per minute."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Unit
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.CloudSkuNetworkType initObject = new Intersight.Model.CloudSkuNetworkType();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BasePrice"))
            {
                initObject.BasePrice = this.BasePrice;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Currency"))
            {
                initObject.Currency = this.Currency;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CustomAttributes"))
            {
                initObject.CustomAttributes = this.CustomAttributes;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IsActive"))
            {
                initObject.IsActive = this.IsActive;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IsAutoDiscovered"))
            {
                initObject.IsAutoDiscovered = this.IsAutoDiscovered;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("PlatformType"))
            {
                initObject.PlatformType = this.PlatformType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Region"))
            {
                initObject.Region = this.Region;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RegionId"))
            {
                initObject.RegionId = this.RegionId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ServiceCategory"))
            {
                initObject.ServiceCategory = this.ServiceCategory;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ServiceFamily"))
            {
                initObject.ServiceFamily = this.ServiceFamily;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ServiceName"))
            {
                initObject.ServiceName = this.ServiceName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Target"))
            {
                initObject.Target = this.Target;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Unit"))
            {
                initObject.Unit = this.Unit;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize CloudSkuRegionRateCards.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCloudSkuRegionRateCards")]
    public class InitializeIntersightCloudSkuRegionRateCards : PSCmdlet
    {
        public InitializeIntersightCloudSkuRegionRateCards()
        {
            ClassId = CloudSkuRegionRateCards.ClassIdEnum.CloudSkuRegionRateCards;
            Currency = CloudSkuRegionRateCards.CurrencyEnum.USD;
            ObjectType = CloudSkuRegionRateCards.ObjectTypeEnum.CloudSkuRegionRateCards;
            ServiceCategory = CloudSkuRegionRateCards.ServiceCategoryEnum.Compute;

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

        public CloudSkuRegionRateCards.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The currency code used for the price. For e.g. USD or EUR.\n* `USD` - The currency code for United states dollar.\n* `EUR` - The currency code for European Union."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CloudSkuRegionRateCards.CurrencyEnum Currency
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.CloudCustomAttributes> CustomAttributes
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The OS distribution running on this instance type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string DistributionType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Applicable for private cloud where price is set by the user."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool IsUserDefined
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

        public CloudSkuRegionRateCards.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The platformType for this SKU.\n* `` - An unrecognized platform type.\n* `APIC` - A Cisco Application Policy Infrastructure Controller (APIC) cluster.\n* `CAPIC` - A Cisco Cloud Application Policy Infrastructure Controller (Cloud APIC) instance.\n* `DCNM` - A Cisco Data Center Network Manager (DCNM) instance.\n* `UCSFI` - A Cisco UCS Fabric Interconnect that is managed by Cisco UCS Manager (UCSM).\n* `UCSFIISM` - A Cisco UCS Fabric Interconnect that is managed by Cisco Intersight.\n* `IMC` - A standalone Cisco UCS rack server (Deprecated).\n* `IMCM4` - A standalone Cisco UCS C-Series or S-Series M4 server.\n* `IMCM5` - A standalone Cisco UCS C-Series or S-Series M5 server.\n* `IMCRack` - A standalone Cisco UCS C-Series or S-Series M6 or newer server.\n* `UCSIOM` - A Cisco UCS Blade Chassis I/O Module (IOM).\n* `HX` - A Cisco HyperFlex (HX) cluster.\n* `UCSD` - A Cisco UCS Director (UCSD) instance.\n* `IntersightAppliance` - A Cisco Intersight Connected Virtual Appliance instance.\n* `IntersightAssist` - A Cisco Intersight Assist instance.\n* `PureStorageFlashArray` - A Pure Storage FlashArray that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer and storage management features are supported on this device.\n* `NexusDevice` - A Cisco Nexus Network Switch that is managed using Cisco Intersight Assist.\n* `ACISwitch` - A Cisco Nexus Network Switch with the embedded Device Connector and is a part of the Cisco ACI fabric.\n* `NexusSwitch` - A standalone Cisco Nexus Network Switch with the embedded Device Connector.\n* `MDSSwitch` - A Cisco MDS Switch that is managed using the embedded Device Connector.\n* `MDSDevice` - A Cisco MDS Switch that is managed using Cisco Intersight Assist.\n* `UCSC890` - A standalone Cisco UCS C890 server managed using Cisco Intersight Assist.\n* `RedfishServer` - A generic target type for servers that support Redfish APIs and is managed using Cisco Intersight Assist. Support is limited to HPE and Dell Servers.\n* `NetAppOntap` - A Netapp ONTAP Storage system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `NetAppActiveIqUnifiedManager` - A NetApp Active IQ Unified Manager (AIQUM) that is managed using Cisco Intersight Assist.\n* `EmcScaleIo` - An EMC ScaleIO Software Defined Storage system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `EmcVmax` - An EMC VMAX 2 or 3 series enterprise storage array that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `EmcVplex` - An EMC VPLEX virtual storage system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `EmcXtremIo` - An EMC XtremIO SSD storage system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `VmwareVcenter` - A VMware vCenter instance that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer and Virtualization features are supported on this hypervisor.\n* `MicrosoftHyperV` - A Microsoft Hyper-V host that is managed using Cisco Intersight Assist. Optionally, other hosts in the cluster can be discovered through this host. Cisco Intersight Workload Optimizer features are supported on this hypervisor.\n* `AppDynamics` - An AppDynamics controller running in a SaaS or on-prem datacenter. On-prem AppDynamics instance is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this controller.\n* `Dynatrace` - A Dynatrace Server instance running in a SaaS or on-prem datacenter. On-prem Dynatrace instance is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this server.\n* `NewRelic` - A NewRelic user account. The NewRelic instance monitors the application infrastructure. Cisco Intersight Workload Optimizer features are supported on this server.\n* `ServiceNow` - A cloud-based workflow automation platform that enables enterprise organizations to improve operational efficiencies by streamlining and automating routine work tasks.\n* `CloudFoundry` - An open source cloud platform on which developers can build, deploy, run and scale applications.\n* `MicrosoftAzureApplicationInsights` - A feature of Azure Monitor, is an extensible Application Performance Management service for developers and DevOps professionals to monitor their live applications.\n* `OpenStack` - An OpenStack target manages Virtual Machines, Physical Machines, Datacenters and Virtual Datacenters using different OpenStack services as administrative endpoints.\n* `MicrosoftSqlServer` - A Microsoft SQL database server that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this database.\n* `MySqlServer` - A MySQL database server that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this database.\n* `OracleDatabaseServer` - An Oracle database server that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this database.\n* `IBMWebSphereApplicationServer` - An IBM WebSphere Application server that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this application server.\n* `OracleWebLogicServer` - Oracle WebLogic Server is a unified and extensible platform for developing, deploying and running enterprise applications, such as Java, for on-premises and in the cloud. WebLogic Server offers a robust, mature, and scalable implementation of Java Enterprise Edition (EE) and Jakarta EE.\n* `ApacheTomcatServer` - An Apache Tomcat server that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this server.\n* `JavaVirtualMachine` - A JVM Application with JMX configured that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this application.\n* `RedHatJBossApplicationServer` - JBoss Application Server is an open-source, cross-platform Java application server developed by JBoss, a division of Red Hat Inc. It is an open-source implementation of Java 2 Enterprise Edition (J2EE) that is used for implementing Java applications and other Web-based applications and software.\n* `Kubernetes` - A Kubernetes cluster that runs containerized applications, with Kubernetes Collector installed. Cisco Intersight Workload Optimizer features are supported on Kubernetes cluster.\n* `AmazonWebService` - An Amazon Web Service cloud account.  Cisco Intersight Workload Optimizer and Virtualization features are supported on this cloud.\n* `AmazonWebServiceBilling` - An Amazon Web Service cloud billing account used to retrieve billing information stored in S3 bucket.  Cisco Intersight Workload Optimizer features are supported on this cloud.\n* `GoogleCloudPlatform` - A Google Cloud Platform service account with access to one or more projects.  Cisco Intersight Workload Optimizer features are supported on this cloud.\n* `GoogleCloudPlatformBilling` - A Google Cloud Platform service account used to retrieve billing information from BigQuery.  Cisco Intersight Workload Optimizer features are supported on this cloud.\n* `MicrosoftAzureServicePrincipal` - A Microsoft Azure Service Principal account with access to Azure subscriptions.  Cisco Intersight Workload Optimizer features are supported on this cloud.\n* `MicrosoftAzureEnterpriseAgreement` - A Microsoft Azure Enterprise Agreement enrolment used to retrieve pricing and billing information. Cisco Intersight Workload Optimizer features are supported on this cloud.\n* `MicrosoftAzureBilling` - A Microsoft Azure Service Principal account with access to billing information. Cisco Intersight Workload Optimizer features are supported on this cloud.\n* `DellCompellent` - A Dell EMC SC Series (Compellent) storage system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `HPE3Par` - A HPE 3PAR StoreServ system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `RedHatEnterpriseVirtualization` - A Red Hat Enterprise Virtualization Hypervisor system that manages Virtual Machines.\n* `NutanixAcropolis` - A Nutanix Acropolis cluster that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this cluster.\n* `HPEOneView` - A HPE OneView system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this system.\n* `ServiceEngine` - Cisco Application Services Engine. Cisco Application Services Engine is a platform to deploy and manage applications.\n* `HitachiVirtualStoragePlatform` - A Hitachi Virtual Storage Platform (Hitachi VSP) that is managed using Cisco Intersight Assist.\n* `GenericTarget` - A generic third-party target supported only in Partner Integration Appliance. This target type is used for development purposes and will not be supported in production environment.\n* `IMCBlade` - A Cisco UCS blade server managed by Cisco Intersight.\n* `TerraformCloud` - A Terraform Cloud Business Tier account.\n* `TerraformAgent` - A Terraform Cloud Agent that will be deployed on Cisco Intersight Assist. The agent can be used to plan and apply Terraform runs from a Terraform Cloud workspace.\n* `CustomTarget` - CustomTarget is deprecated.  Use HTTPEndpoint type to claim HTTP endpoints.\n* `AnsibleEndpoint` - An external endpoint that is added as a target  which can be accessed through Ansible in Intersight Cloud Orchestrator automation workflows.\n* `HTTPEndpoint` - An HTTP endpoint that can be accessed in Intersight Orchestrator workflows  directly or using Cisco Intersight Assist.  Authentication Schemes supported are Basic and Bearer Token.\n* `SSHEndpoint` - An SSH endpoint that can be accessed in Intersight Orchestrator workflows using Cisco Intersight Assist.\n* `CiscoCatalyst` - A Cisco Catalyst networking switch device.\n* `PowerShellEndpoint` - A Windows operating system server on which PowerShell scripts can be executed using Cisco Intersight Assist."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CloudSkuRegionRateCards.PlatformTypeEnum PlatformType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Price of the instance type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public float Price
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a cloudRegions resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.CloudRegionsRelationship Region
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The regionId associated with this rate card."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string RegionId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Indicates if this sku belongs to Compute, Storage, Database or Network category.\n* `Compute` - Compute service offered by cloud provider.\n* `Storage` - Storage service offered by cloud provider.\n* `Database` - Database service offered by cloud provider.\n* `Network` - Network service offered by cloud provider."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CloudSkuRegionRateCards.ServiceCategoryEnum ServiceCategory
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a cloudBaseSku resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.CloudBaseSkuRelationship Sku
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The sku name associated with this rate card."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SkuName
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
        /// <para type="description">"The billing unit to use for computing the price. For e.g. when serviceCategory is Compute the unit will be \"Hrs\", for Storage it will be \"GB-Mo\"."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Unit
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The epoch start time from which the price will be applied."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long ValidFrom
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The epoch end time of the current price."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long ValidTo
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.CloudSkuRegionRateCards initObject = new Intersight.Model.CloudSkuRegionRateCards();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Currency"))
            {
                initObject.Currency = this.Currency;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CustomAttributes"))
            {
                initObject.CustomAttributes = this.CustomAttributes;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DistributionType"))
            {
                initObject.DistributionType = this.DistributionType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IsUserDefined"))
            {
                initObject.IsUserDefined = this.IsUserDefined;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("PlatformType"))
            {
                initObject.PlatformType = this.PlatformType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Price"))
            {
                initObject.Price = this.Price;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Region"))
            {
                initObject.Region = this.Region;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RegionId"))
            {
                initObject.RegionId = this.RegionId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ServiceCategory"))
            {
                initObject.ServiceCategory = this.ServiceCategory;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Sku"))
            {
                initObject.Sku = this.Sku;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SkuName"))
            {
                initObject.SkuName = this.SkuName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Unit"))
            {
                initObject.Unit = this.Unit;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ValidFrom"))
            {
                initObject.ValidFrom = this.ValidFrom;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ValidTo"))
            {
                initObject.ValidTo = this.ValidTo;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize CloudSkuVolumeType.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCloudSkuVolumeType")]
    public class InitializeIntersightCloudSkuVolumeType : PSCmdlet
    {
        public InitializeIntersightCloudSkuVolumeType()
        {
            ClassId = CloudSkuVolumeType.ClassIdEnum.CloudSkuVolumeType;
            Currency = CloudSkuVolumeType.CurrencyEnum.USD;
            ObjectType = CloudSkuVolumeType.ObjectTypeEnum.CloudSkuVolumeType;
            ServiceCategory = CloudSkuVolumeType.ServiceCategoryEnum.Compute;

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
        /// <para type="description">"The cost per hour for running a Linux instance for the SKU. Cost can be higher for Windows or other licensed OS."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public float BasePrice
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CloudSkuVolumeType.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The currency code used for the price. For e.g. USD or EUR.\n* `USD` - The currency code for United states dollar.\n* `EUR` - The currency code for European Union."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CloudSkuVolumeType.CurrencyEnum Currency
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.CloudCustomAttributes> CustomAttributes
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Any additional description for the instance type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The units to measure IOPS."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string IopsUnit
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Flag to indicate if this SKU is active or not."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool IsActive
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Flag to indicate if SKU is discovered during inventory collection."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool IsAutoDiscovered
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Indicates if this volume can be used as a boot volume."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool IsBootable
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Flag to indicate if this is a default volume. Default volumes will be used when an instance type is launched unless another volume type is specified."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool IsDefault
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Indicates if this volume type supports provisioned IOPS."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool IsProvisionedIops
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The max I/O operations per second that this volume type supports. Read or write numbers does not go beyond this value."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public double MaxIops
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The maximum read IOPS that this volume type supports."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public double MaxReadIops
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The maximum read throughput limit for this volume type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public double MaxReadThroughput
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The maximum throughput limit for this volume type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public double MaxThroughput
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The maximum storage size that this volume type supports."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public double MaxVolumeSize
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The maximum write IOPS that this volume type supports."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public double MaxWriteIops
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The maximum write throughput limit for this volume type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public double MaxWriteThroughput
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The minimum storage size that this volume type supports."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public double MinVolumeSize
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
        /// <para type="description">"The display name for instance type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CloudSkuVolumeType.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The platformType for this SKU.\n* `` - An unrecognized platform type.\n* `APIC` - A Cisco Application Policy Infrastructure Controller (APIC) cluster.\n* `CAPIC` - A Cisco Cloud Application Policy Infrastructure Controller (Cloud APIC) instance.\n* `DCNM` - A Cisco Data Center Network Manager (DCNM) instance.\n* `UCSFI` - A Cisco UCS Fabric Interconnect that is managed by Cisco UCS Manager (UCSM).\n* `UCSFIISM` - A Cisco UCS Fabric Interconnect that is managed by Cisco Intersight.\n* `IMC` - A standalone Cisco UCS rack server (Deprecated).\n* `IMCM4` - A standalone Cisco UCS C-Series or S-Series M4 server.\n* `IMCM5` - A standalone Cisco UCS C-Series or S-Series M5 server.\n* `IMCRack` - A standalone Cisco UCS C-Series or S-Series M6 or newer server.\n* `UCSIOM` - A Cisco UCS Blade Chassis I/O Module (IOM).\n* `HX` - A Cisco HyperFlex (HX) cluster.\n* `UCSD` - A Cisco UCS Director (UCSD) instance.\n* `IntersightAppliance` - A Cisco Intersight Connected Virtual Appliance instance.\n* `IntersightAssist` - A Cisco Intersight Assist instance.\n* `PureStorageFlashArray` - A Pure Storage FlashArray that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer and storage management features are supported on this device.\n* `NexusDevice` - A Cisco Nexus Network Switch that is managed using Cisco Intersight Assist.\n* `ACISwitch` - A Cisco Nexus Network Switch with the embedded Device Connector and is a part of the Cisco ACI fabric.\n* `NexusSwitch` - A standalone Cisco Nexus Network Switch with the embedded Device Connector.\n* `MDSSwitch` - A Cisco MDS Switch that is managed using the embedded Device Connector.\n* `MDSDevice` - A Cisco MDS Switch that is managed using Cisco Intersight Assist.\n* `UCSC890` - A standalone Cisco UCS C890 server managed using Cisco Intersight Assist.\n* `RedfishServer` - A generic target type for servers that support Redfish APIs and is managed using Cisco Intersight Assist. Support is limited to HPE and Dell Servers.\n* `NetAppOntap` - A Netapp ONTAP Storage system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `NetAppActiveIqUnifiedManager` - A NetApp Active IQ Unified Manager (AIQUM) that is managed using Cisco Intersight Assist.\n* `EmcScaleIo` - An EMC ScaleIO Software Defined Storage system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `EmcVmax` - An EMC VMAX 2 or 3 series enterprise storage array that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `EmcVplex` - An EMC VPLEX virtual storage system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `EmcXtremIo` - An EMC XtremIO SSD storage system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `VmwareVcenter` - A VMware vCenter instance that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer and Virtualization features are supported on this hypervisor.\n* `MicrosoftHyperV` - A Microsoft Hyper-V host that is managed using Cisco Intersight Assist. Optionally, other hosts in the cluster can be discovered through this host. Cisco Intersight Workload Optimizer features are supported on this hypervisor.\n* `AppDynamics` - An AppDynamics controller running in a SaaS or on-prem datacenter. On-prem AppDynamics instance is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this controller.\n* `Dynatrace` - A Dynatrace Server instance running in a SaaS or on-prem datacenter. On-prem Dynatrace instance is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this server.\n* `NewRelic` - A NewRelic user account. The NewRelic instance monitors the application infrastructure. Cisco Intersight Workload Optimizer features are supported on this server.\n* `ServiceNow` - A cloud-based workflow automation platform that enables enterprise organizations to improve operational efficiencies by streamlining and automating routine work tasks.\n* `CloudFoundry` - An open source cloud platform on which developers can build, deploy, run and scale applications.\n* `MicrosoftAzureApplicationInsights` - A feature of Azure Monitor, is an extensible Application Performance Management service for developers and DevOps professionals to monitor their live applications.\n* `OpenStack` - An OpenStack target manages Virtual Machines, Physical Machines, Datacenters and Virtual Datacenters using different OpenStack services as administrative endpoints.\n* `MicrosoftSqlServer` - A Microsoft SQL database server that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this database.\n* `MySqlServer` - A MySQL database server that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this database.\n* `OracleDatabaseServer` - An Oracle database server that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this database.\n* `IBMWebSphereApplicationServer` - An IBM WebSphere Application server that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this application server.\n* `OracleWebLogicServer` - Oracle WebLogic Server is a unified and extensible platform for developing, deploying and running enterprise applications, such as Java, for on-premises and in the cloud. WebLogic Server offers a robust, mature, and scalable implementation of Java Enterprise Edition (EE) and Jakarta EE.\n* `ApacheTomcatServer` - An Apache Tomcat server that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this server.\n* `JavaVirtualMachine` - A JVM Application with JMX configured that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this application.\n* `RedHatJBossApplicationServer` - JBoss Application Server is an open-source, cross-platform Java application server developed by JBoss, a division of Red Hat Inc. It is an open-source implementation of Java 2 Enterprise Edition (J2EE) that is used for implementing Java applications and other Web-based applications and software.\n* `Kubernetes` - A Kubernetes cluster that runs containerized applications, with Kubernetes Collector installed. Cisco Intersight Workload Optimizer features are supported on Kubernetes cluster.\n* `AmazonWebService` - An Amazon Web Service cloud account.  Cisco Intersight Workload Optimizer and Virtualization features are supported on this cloud.\n* `AmazonWebServiceBilling` - An Amazon Web Service cloud billing account used to retrieve billing information stored in S3 bucket.  Cisco Intersight Workload Optimizer features are supported on this cloud.\n* `GoogleCloudPlatform` - A Google Cloud Platform service account with access to one or more projects.  Cisco Intersight Workload Optimizer features are supported on this cloud.\n* `GoogleCloudPlatformBilling` - A Google Cloud Platform service account used to retrieve billing information from BigQuery.  Cisco Intersight Workload Optimizer features are supported on this cloud.\n* `MicrosoftAzureServicePrincipal` - A Microsoft Azure Service Principal account with access to Azure subscriptions.  Cisco Intersight Workload Optimizer features are supported on this cloud.\n* `MicrosoftAzureEnterpriseAgreement` - A Microsoft Azure Enterprise Agreement enrolment used to retrieve pricing and billing information. Cisco Intersight Workload Optimizer features are supported on this cloud.\n* `MicrosoftAzureBilling` - A Microsoft Azure Service Principal account with access to billing information. Cisco Intersight Workload Optimizer features are supported on this cloud.\n* `DellCompellent` - A Dell EMC SC Series (Compellent) storage system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `HPE3Par` - A HPE 3PAR StoreServ system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `RedHatEnterpriseVirtualization` - A Red Hat Enterprise Virtualization Hypervisor system that manages Virtual Machines.\n* `NutanixAcropolis` - A Nutanix Acropolis cluster that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this cluster.\n* `HPEOneView` - A HPE OneView system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this system.\n* `ServiceEngine` - Cisco Application Services Engine. Cisco Application Services Engine is a platform to deploy and manage applications.\n* `HitachiVirtualStoragePlatform` - A Hitachi Virtual Storage Platform (Hitachi VSP) that is managed using Cisco Intersight Assist.\n* `GenericTarget` - A generic third-party target supported only in Partner Integration Appliance. This target type is used for development purposes and will not be supported in production environment.\n* `IMCBlade` - A Cisco UCS blade server managed by Cisco Intersight.\n* `TerraformCloud` - A Terraform Cloud Business Tier account.\n* `TerraformAgent` - A Terraform Cloud Agent that will be deployed on Cisco Intersight Assist. The agent can be used to plan and apply Terraform runs from a Terraform Cloud workspace.\n* `CustomTarget` - CustomTarget is deprecated.  Use HTTPEndpoint type to claim HTTP endpoints.\n* `AnsibleEndpoint` - An external endpoint that is added as a target  which can be accessed through Ansible in Intersight Cloud Orchestrator automation workflows.\n* `HTTPEndpoint` - An HTTP endpoint that can be accessed in Intersight Orchestrator workflows  directly or using Cisco Intersight Assist.  Authentication Schemes supported are Basic and Bearer Token.\n* `SSHEndpoint` - An SSH endpoint that can be accessed in Intersight Orchestrator workflows using Cisco Intersight Assist.\n* `CiscoCatalyst` - A Cisco Catalyst networking switch device.\n* `PowerShellEndpoint` - A Windows operating system server on which PowerShell scripts can be executed using Cisco Intersight Assist."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CloudSkuVolumeType.PlatformTypeEnum PlatformType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a cloudRegions resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.CloudRegionsRelationship Region
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The region to which this Sku belongs to."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string RegionId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Indicates if this sku belongs to Compute, Storage, Database or Network category.\n* `Compute` - Compute service offered by cloud provider.\n* `Storage` - Storage service offered by cloud provider.\n* `Database` - Database service offered by cloud provider.\n* `Network` - Network service offered by cloud provider."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CloudSkuVolumeType.ServiceCategoryEnum ServiceCategory
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Property to identify the family of service that the sku belongs to."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ServiceFamily
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Any display name for the ServiceCategory if available."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ServiceName
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
        /// <para type="description">"A reference to a assetTarget resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.AssetTargetRelationship Target
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The units for measuring throughput."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ThroughputUnit
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The volume type like gp2 or st1."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Type
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The pricing associated with this Sku. Can be hourly, per minute."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Unit
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The units for measuring volume size."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string VolumeSizeUnit
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.CloudSkuVolumeType initObject = new Intersight.Model.CloudSkuVolumeType();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BasePrice"))
            {
                initObject.BasePrice = this.BasePrice;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Currency"))
            {
                initObject.Currency = this.Currency;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CustomAttributes"))
            {
                initObject.CustomAttributes = this.CustomAttributes;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IopsUnit"))
            {
                initObject.IopsUnit = this.IopsUnit;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IsActive"))
            {
                initObject.IsActive = this.IsActive;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IsAutoDiscovered"))
            {
                initObject.IsAutoDiscovered = this.IsAutoDiscovered;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IsBootable"))
            {
                initObject.IsBootable = this.IsBootable;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IsDefault"))
            {
                initObject.IsDefault = this.IsDefault;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IsProvisionedIops"))
            {
                initObject.IsProvisionedIops = this.IsProvisionedIops;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaxIops"))
            {
                initObject.MaxIops = this.MaxIops;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaxReadIops"))
            {
                initObject.MaxReadIops = this.MaxReadIops;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaxReadThroughput"))
            {
                initObject.MaxReadThroughput = this.MaxReadThroughput;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaxThroughput"))
            {
                initObject.MaxThroughput = this.MaxThroughput;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaxVolumeSize"))
            {
                initObject.MaxVolumeSize = this.MaxVolumeSize;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaxWriteIops"))
            {
                initObject.MaxWriteIops = this.MaxWriteIops;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaxWriteThroughput"))
            {
                initObject.MaxWriteThroughput = this.MaxWriteThroughput;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MinVolumeSize"))
            {
                initObject.MinVolumeSize = this.MinVolumeSize;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("PlatformType"))
            {
                initObject.PlatformType = this.PlatformType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Region"))
            {
                initObject.Region = this.Region;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RegionId"))
            {
                initObject.RegionId = this.RegionId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ServiceCategory"))
            {
                initObject.ServiceCategory = this.ServiceCategory;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ServiceFamily"))
            {
                initObject.ServiceFamily = this.ServiceFamily;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ServiceName"))
            {
                initObject.ServiceName = this.ServiceName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Target"))
            {
                initObject.Target = this.Target;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ThroughputUnit"))
            {
                initObject.ThroughputUnit = this.ThroughputUnit;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Type"))
            {
                initObject.Type = this.Type;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Unit"))
            {
                initObject.Unit = this.Unit;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VolumeSizeUnit"))
            {
                initObject.VolumeSizeUnit = this.VolumeSizeUnit;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize CloudTfcAgentpool.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCloudTfcAgentpool")]
    public class InitializeIntersightCloudTfcAgentpool : PSCmdlet
    {
        public InitializeIntersightCloudTfcAgentpool()
        {
            ClassId = CloudTfcAgentpool.ClassIdEnum.CloudTfcAgentpool;
            ObjectType = CloudTfcAgentpool.ObjectTypeEnum.CloudTfcAgentpool;

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

        public CloudTfcAgentpool.ClassIdEnum ClassId
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

        public CloudTfcAgentpool.ObjectTypeEnum ObjectType
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
            Intersight.Model.CloudTfcAgentpool initObject = new Intersight.Model.CloudTfcAgentpool();
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
    /// <para type="synopsis">This is the cmdlet to Initialize CloudTfcOrganization.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCloudTfcOrganization")]
    public class InitializeIntersightCloudTfcOrganization : PSCmdlet
    {
        public InitializeIntersightCloudTfcOrganization()
        {
            ClassId = CloudTfcOrganization.ClassIdEnum.CloudTfcOrganization;
            ObjectType = CloudTfcOrganization.ObjectTypeEnum.CloudTfcOrganization;

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

        public CloudTfcOrganization.ClassIdEnum ClassId
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

        public CloudTfcOrganization.ObjectTypeEnum ObjectType
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
            Intersight.Model.CloudTfcOrganization initObject = new Intersight.Model.CloudTfcOrganization();
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
    /// <para type="synopsis">This is the cmdlet to Initialize CloudTfcWorkspace.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCloudTfcWorkspace")]
    public class InitializeIntersightCloudTfcWorkspace : PSCmdlet
    {
        public InitializeIntersightCloudTfcWorkspace()
        {
            ClassId = CloudTfcWorkspace.ClassIdEnum.CloudTfcWorkspace;
            ObjectType = CloudTfcWorkspace.ObjectTypeEnum.CloudTfcWorkspace;

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

        public CloudTfcWorkspace.ClassIdEnum ClassId
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

        public CloudTfcWorkspace.ObjectTypeEnum ObjectType
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.CloudTfcWorkspaceVariables> WorkspaceVariables
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.CloudTfcWorkspace initObject = new Intersight.Model.CloudTfcWorkspace();
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
            if (this.MyInvocation.BoundParameters.ContainsKey("WorkspaceVariables"))
            {
                initObject.WorkspaceVariables = this.WorkspaceVariables;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize CloudTfcWorkspaceVariables.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCloudTfcWorkspaceVariables")]
    public class InitializeIntersightCloudTfcWorkspaceVariables : PSCmdlet
    {
        public InitializeIntersightCloudTfcWorkspaceVariables()
        {
            ClassId = CloudTfcWorkspaceVariables.ClassIdEnum.CloudTfcWorkspaceVariables;
            ObjectType = CloudTfcWorkspaceVariables.ObjectTypeEnum.CloudTfcWorkspaceVariables;

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
        /// <para type="description">"Whether this is a Terraform environment variable. Valid values are \"terraform\" or \"env\"."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Category
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CloudTfcWorkspaceVariables.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The description of the variable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Whether to evaluate the value of the variable as a string of HCL code. Has no effect for environment variables."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Hcl
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier for this variable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Identity
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the variables."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Key
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CloudTfcWorkspaceVariables.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Whether the value is sensitive. If true then variable is written once and not visible thereafter."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Sensitive
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The value of the variables."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Value
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.CloudTfcWorkspaceVariables initObject = new Intersight.Model.CloudTfcWorkspaceVariables();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Category"))
            {
                initObject.Category = this.Category;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Hcl"))
            {
                initObject.Hcl = this.Hcl;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Identity"))
            {
                initObject.Identity = this.Identity;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Key"))
            {
                initObject.Key = this.Key;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Sensitive"))
            {
                initObject.Sensitive = this.Sensitive;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Value"))
            {
                initObject.Value = this.Value;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize CloudVolumeAttachment.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCloudVolumeAttachment")]
    public class InitializeIntersightCloudVolumeAttachment : PSCmdlet
    {
        public InitializeIntersightCloudVolumeAttachment()
        {
            ClassId = CloudVolumeAttachment.ClassIdEnum.CloudVolumeAttachment;
            ObjectType = CloudVolumeAttachment.ObjectTypeEnum.CloudVolumeAttachment;

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

        public CloudVolumeAttachment.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The internally generated identity of this volume."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Identity
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CloudVolumeAttachment.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.CloudVolumeAttachment initObject = new Intersight.Model.CloudVolumeAttachment();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Identity"))
            {
                initObject.Identity = this.Identity;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize CloudVolumeInstanceAttachment.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCloudVolumeInstanceAttachment")]
    public class InitializeIntersightCloudVolumeInstanceAttachment : PSCmdlet
    {
        public InitializeIntersightCloudVolumeInstanceAttachment()
        {
            ClassId = CloudVolumeInstanceAttachment.ClassIdEnum.CloudVolumeInstanceAttachment;
            ObjectType = CloudVolumeInstanceAttachment.ObjectTypeEnum.CloudVolumeInstanceAttachment;

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

        public CloudVolumeInstanceAttachment.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CloudVolumeInstanceAttachment.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.CloudVolumeInstanceAttachment initObject = new Intersight.Model.CloudVolumeInstanceAttachment();
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
    /// <para type="synopsis">This is the cmdlet to Initialize CloudVolumeIopsInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCloudVolumeIopsInfo")]
    public class InitializeIntersightCloudVolumeIopsInfo : PSCmdlet
    {
        public InitializeIntersightCloudVolumeIopsInfo()
        {
            ClassId = CloudVolumeIopsInfo.ClassIdEnum.CloudVolumeIopsInfo;
            ObjectType = CloudVolumeIopsInfo.ObjectTypeEnum.CloudVolumeIopsInfo;

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

        public CloudVolumeIopsInfo.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CloudVolumeIopsInfo.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.CloudVolumeIopsInfo initObject = new Intersight.Model.CloudVolumeIopsInfo();
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
    /// <para type="synopsis">This is the cmdlet to Initialize CloudVolumeType.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCloudVolumeType")]
    public class InitializeIntersightCloudVolumeType : PSCmdlet
    {
        public InitializeIntersightCloudVolumeType()
        {
            ClassId = CloudVolumeType.ClassIdEnum.CloudVolumeType;
            ObjectType = CloudVolumeType.ObjectTypeEnum.CloudVolumeType;

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

        public CloudVolumeType.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CloudVolumeType.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.CloudVolumeType initObject = new Intersight.Model.CloudVolumeType();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
}