using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationActionInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationActionInfo")]
    public class InitializeIntersightVirtualizationActionInfo : PSCmdlet
    {
        public InitializeIntersightVirtualizationActionInfo()
        {
            ClassId = VirtualizationActionInfo.ClassIdEnum.VirtualizationActionInfo;
            ObjectType = VirtualizationActionInfo.ObjectTypeEnum.VirtualizationActionInfo;

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

        public VirtualizationActionInfo.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationActionInfo.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.VirtualizationActionInfo initObject = new Intersight.Model.VirtualizationActionInfo();
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
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationAwsVmComputeConfiguration.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationAwsVmComputeConfiguration")]
    public class InitializeIntersightVirtualizationAwsVmComputeConfiguration : PSCmdlet
    {
        public InitializeIntersightVirtualizationAwsVmComputeConfiguration()
        {
            ClassId = VirtualizationAwsVmComputeConfiguration.ClassIdEnum.VirtualizationAwsVmComputeConfiguration;
            ObjectType = VirtualizationAwsVmComputeConfiguration.ObjectTypeEnum.VirtualizationAwsVmComputeConfiguration;

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

        public VirtualizationAwsVmComputeConfiguration.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Instance Type used by this VM."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string InstanceTypeId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationAwsVmComputeConfiguration.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.VirtualizationAwsVmComputeConfiguration initObject = new Intersight.Model.VirtualizationAwsVmComputeConfiguration();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("InstanceTypeId"))
            {
                initObject.InstanceTypeId = this.InstanceTypeId;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationAwsVmConfiguration.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationAwsVmConfiguration")]
    public class InitializeIntersightVirtualizationAwsVmConfiguration : PSCmdlet
    {
        public InitializeIntersightVirtualizationAwsVmConfiguration()
        {
            ClassId = VirtualizationAwsVmConfiguration.ClassIdEnum.VirtualizationAwsVmConfiguration;
            ObjectType = VirtualizationAwsVmConfiguration.ObjectTypeEnum.VirtualizationAwsVmConfiguration;

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
        /// <para type="description">"Availability zone for the VM."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string AvailabilityZoneId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationAwsVmConfiguration.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Cloud virtual machine compute specifications."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VirtualizationCloudVmComputeConfiguration Compute
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Virtual machine image used by this VM."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ImageId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Keypair for accessing the VM."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string KeyPairName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Cloud virtual machine network specifications."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VirtualizationCloudVmNetworkConfiguration Network
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationAwsVmConfiguration.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Region where the VM instance is created."</para>
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

        public List<string> SecurityGroups
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Cloud Virtual machine disk information."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VirtualizationCloudVmStorageConfiguration Storage
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Unique Identifier of the cloud VM."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string VmId
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.VirtualizationAwsVmConfiguration initObject = new Intersight.Model.VirtualizationAwsVmConfiguration();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AvailabilityZoneId"))
            {
                initObject.AvailabilityZoneId = this.AvailabilityZoneId;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Compute"))
            {
                initObject.Compute = this.Compute;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ImageId"))
            {
                initObject.ImageId = this.ImageId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("KeyPairName"))
            {
                initObject.KeyPairName = this.KeyPairName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Network"))
            {
                initObject.Network = this.Network;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("RegionId"))
            {
                initObject.RegionId = this.RegionId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SecurityGroups"))
            {
                initObject.SecurityGroups = this.SecurityGroups;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Storage"))
            {
                initObject.Storage = this.Storage;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VmId"))
            {
                initObject.VmId = this.VmId;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationAwsVmNetworkConfiguration.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationAwsVmNetworkConfiguration")]
    public class InitializeIntersightVirtualizationAwsVmNetworkConfiguration : PSCmdlet
    {
        public InitializeIntersightVirtualizationAwsVmNetworkConfiguration()
        {
            ClassId = VirtualizationAwsVmNetworkConfiguration.ClassIdEnum.VirtualizationAwsVmNetworkConfiguration;
            ObjectType = VirtualizationAwsVmNetworkConfiguration.ObjectTypeEnum.VirtualizationAwsVmNetworkConfiguration;

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

        public VirtualizationAwsVmNetworkConfiguration.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.VirtualizationNetworkInterface> Interfaces
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationAwsVmNetworkConfiguration.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Virtual Private Cloud (Amazon VPC) enables you to launch AWS resources into a virtual network that you have defined."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string VpcId
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.VirtualizationAwsVmNetworkConfiguration initObject = new Intersight.Model.VirtualizationAwsVmNetworkConfiguration();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Interfaces"))
            {
                initObject.Interfaces = this.Interfaces;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("VpcId"))
            {
                initObject.VpcId = this.VpcId;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationAwsVmStorageConfiguration.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationAwsVmStorageConfiguration")]
    public class InitializeIntersightVirtualizationAwsVmStorageConfiguration : PSCmdlet
    {
        public InitializeIntersightVirtualizationAwsVmStorageConfiguration()
        {
            ClassId = VirtualizationAwsVmStorageConfiguration.ClassIdEnum.VirtualizationAwsVmStorageConfiguration;
            ObjectType = VirtualizationAwsVmStorageConfiguration.ObjectTypeEnum.VirtualizationAwsVmStorageConfiguration;

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

        public VirtualizationAwsVmStorageConfiguration.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationAwsVmStorageConfiguration.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.VirtualizationVolumeInfo> Volumes
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.VirtualizationAwsVmStorageConfiguration initObject = new Intersight.Model.VirtualizationAwsVmStorageConfiguration();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Volumes"))
            {
                initObject.Volumes = this.Volumes;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationBaseCustomSpec.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationBaseCustomSpec")]
    public class InitializeIntersightVirtualizationBaseCustomSpec : PSCmdlet
    {
        public InitializeIntersightVirtualizationBaseCustomSpec()
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

        public VirtualizationBaseCustomSpec.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationBaseCustomSpec.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.VirtualizationBaseCustomSpec initObject = new Intersight.Model.VirtualizationBaseCustomSpec();
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
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationBaseHostConfiguration.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationBaseHostConfiguration")]
    public class InitializeIntersightVirtualizationBaseHostConfiguration : PSCmdlet
    {
        public InitializeIntersightVirtualizationBaseHostConfiguration()
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

        public VirtualizationBaseHostConfiguration.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationBaseHostConfiguration.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.VirtualizationBaseHostConfiguration initObject = new Intersight.Model.VirtualizationBaseHostConfiguration();
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
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationBaseVmConfiguration.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationBaseVmConfiguration")]
    public class InitializeIntersightVirtualizationBaseVmConfiguration : PSCmdlet
    {
        public InitializeIntersightVirtualizationBaseVmConfiguration()
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

        public VirtualizationBaseVmConfiguration.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationBaseVmConfiguration.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.VirtualizationBaseVmConfiguration initObject = new Intersight.Model.VirtualizationBaseVmConfiguration();
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
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationCloudInitConfig.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationCloudInitConfig")]
    public class InitializeIntersightVirtualizationCloudInitConfig : PSCmdlet
    {
        public InitializeIntersightVirtualizationCloudInitConfig()
        {
            ClassId = VirtualizationCloudInitConfig.ClassIdEnum.VirtualizationCloudInitConfig;
            ObjectType = VirtualizationCloudInitConfig.ObjectTypeEnum.VirtualizationCloudInitConfig;

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

        public VirtualizationCloudInitConfig.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Virtual machine cloud init configuration type.\n* `` - No cloud init specified. Cloud-init configurations are not sent to hypervisor, if none is selected.\n* `NoCloudSource` - Allows the user to provide user-data to the instance without running a network service.\n* `CloudConfigDrive` - Allows the user to provide user-data and network-data from cloud."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationCloudInitConfig.ConfigTypeEnum ConfigType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Network configuration data for a virtual machine."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string NetworkData
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Set to true, if the cloud init network data is in base64 format."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool NetworkDataBase64Encoded
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationCloudInitConfig.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"User configuration data for a virtual machine such as adding user, group etc."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string UserData
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Set to true, if the cloud init user data is in base64 format."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool UserDataBase64Encoded
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.VirtualizationCloudInitConfig initObject = new Intersight.Model.VirtualizationCloudInitConfig();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ConfigType"))
            {
                initObject.ConfigType = this.ConfigType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NetworkData"))
            {
                initObject.NetworkData = this.NetworkData;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NetworkDataBase64Encoded"))
            {
                initObject.NetworkDataBase64Encoded = this.NetworkDataBase64Encoded;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("UserData"))
            {
                initObject.UserData = this.UserData;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UserDataBase64Encoded"))
            {
                initObject.UserDataBase64Encoded = this.UserDataBase64Encoded;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationCloudVmComputeConfiguration.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationCloudVmComputeConfiguration")]
    public class InitializeIntersightVirtualizationCloudVmComputeConfiguration : PSCmdlet
    {
        public InitializeIntersightVirtualizationCloudVmComputeConfiguration()
        {
            ClassId = VirtualizationCloudVmComputeConfiguration.ClassIdEnum.VirtualizationAwsVmComputeConfiguration;
            ObjectType = VirtualizationCloudVmComputeConfiguration.ObjectTypeEnum.VirtualizationAwsVmComputeConfiguration;

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

        public VirtualizationCloudVmComputeConfiguration.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Instance Type used by this VM."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string InstanceTypeId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationCloudVmComputeConfiguration.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.VirtualizationCloudVmComputeConfiguration initObject = new Intersight.Model.VirtualizationCloudVmComputeConfiguration();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("InstanceTypeId"))
            {
                initObject.InstanceTypeId = this.InstanceTypeId;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationCloudVmNetworkConfiguration.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationCloudVmNetworkConfiguration")]
    public class InitializeIntersightVirtualizationCloudVmNetworkConfiguration : PSCmdlet
    {
        public InitializeIntersightVirtualizationCloudVmNetworkConfiguration()
        {
            ClassId = VirtualizationCloudVmNetworkConfiguration.ClassIdEnum.VirtualizationAwsVmNetworkConfiguration;
            ObjectType = VirtualizationCloudVmNetworkConfiguration.ObjectTypeEnum.VirtualizationAwsVmNetworkConfiguration;

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

        public VirtualizationCloudVmNetworkConfiguration.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.VirtualizationNetworkInterface> Interfaces
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationCloudVmNetworkConfiguration.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Virtual Private Cloud (Amazon VPC) enables you to launch AWS resources into a virtual network that you have defined."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string VpcId
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.VirtualizationCloudVmNetworkConfiguration initObject = new Intersight.Model.VirtualizationCloudVmNetworkConfiguration();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Interfaces"))
            {
                initObject.Interfaces = this.Interfaces;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("VpcId"))
            {
                initObject.VpcId = this.VpcId;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationCloudVmStorageConfiguration.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationCloudVmStorageConfiguration")]
    public class InitializeIntersightVirtualizationCloudVmStorageConfiguration : PSCmdlet
    {
        public InitializeIntersightVirtualizationCloudVmStorageConfiguration()
        {
            ClassId = VirtualizationCloudVmStorageConfiguration.ClassIdEnum.VirtualizationAwsVmStorageConfiguration;
            ObjectType = VirtualizationCloudVmStorageConfiguration.ObjectTypeEnum.VirtualizationAwsVmStorageConfiguration;

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

        public VirtualizationCloudVmStorageConfiguration.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationCloudVmStorageConfiguration.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.VirtualizationVolumeInfo> Volumes
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.VirtualizationCloudVmStorageConfiguration initObject = new Intersight.Model.VirtualizationCloudVmStorageConfiguration();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Volumes"))
            {
                initObject.Volumes = this.Volumes;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationComputeCapacity.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationComputeCapacity")]
    public class InitializeIntersightVirtualizationComputeCapacity : PSCmdlet
    {
        public InitializeIntersightVirtualizationComputeCapacity()
        {
            ClassId = VirtualizationComputeCapacity.ClassIdEnum.VirtualizationComputeCapacity;
            ObjectType = VirtualizationComputeCapacity.ObjectTypeEnum.VirtualizationComputeCapacity;

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
        /// <para type="description">"Total capacity of the entity in MHz."</para>
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

        public VirtualizationComputeCapacity.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Free CPU capacity in MHz, as a point-in-time snapshot. The available CPU capacity is reported for an entity (such as Host or Cluster) when inventory data is collected for that entity. As part of the inventory data, a snapshot of the free and used CPU capacity is also reported."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Free
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationComputeCapacity.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Used CPU capacity of the entity in MHz, as a point-in-time snapshot."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Used
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.VirtualizationComputeCapacity initObject = new Intersight.Model.VirtualizationComputeCapacity();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Capacity"))
            {
                initObject.Capacity = this.Capacity;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Free"))
            {
                initObject.Free = this.Free;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Used"))
            {
                initObject.Used = this.Used;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationCpuInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationCpuInfo")]
    public class InitializeIntersightVirtualizationCpuInfo : PSCmdlet
    {
        public InitializeIntersightVirtualizationCpuInfo()
        {
            ClassId = VirtualizationCpuInfo.ClassIdEnum.VirtualizationCpuInfo;
            ObjectType = VirtualizationCpuInfo.ObjectTypeEnum.VirtualizationCpuInfo;

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

        public VirtualizationCpuInfo.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of cores per CPU, as reported by the manufacturer."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Cores
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The vendor provided description of the CPU. For example, Intel Xeon E5-2640 v3 @ 2.60GHz."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationCpuInfo.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of CPU sockets available."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Sockets
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Speed of the CPUs in Hertz. For example, 2593749663."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Speed
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Manufacturer of the CPU . For example, Intel."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Vendor
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.VirtualizationCpuInfo initObject = new Intersight.Model.VirtualizationCpuInfo();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Cores"))
            {
                initObject.Cores = this.Cores;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Sockets"))
            {
                initObject.Sockets = this.Sockets;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Speed"))
            {
                initObject.Speed = this.Speed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Vendor"))
            {
                initObject.Vendor = this.Vendor;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationEsxiCloneCustomSpec.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationEsxiCloneCustomSpec")]
    public class InitializeIntersightVirtualizationEsxiCloneCustomSpec : PSCmdlet
    {
        public InitializeIntersightVirtualizationEsxiCloneCustomSpec()
        {
            ClassId = VirtualizationEsxiCloneCustomSpec.ClassIdEnum.VirtualizationEsxiCloneCustomSpec;
            ObjectType = VirtualizationEsxiCloneCustomSpec.ObjectTypeEnum.VirtualizationEsxiCloneCustomSpec;

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

        public VirtualizationEsxiCloneCustomSpec.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Specify the Extra Config specification which can be configured on virtual machine."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object ExtraConfig
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationEsxiCloneCustomSpec.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Specify the OVA Environment specification which can be configured on virtual machine."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object OvaEnvSpec
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.VirtualizationEsxiCloneCustomSpec initObject = new Intersight.Model.VirtualizationEsxiCloneCustomSpec();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ExtraConfig"))
            {
                initObject.ExtraConfig = this.ExtraConfig;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("OvaEnvSpec"))
            {
                initObject.OvaEnvSpec = this.OvaEnvSpec;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationEsxiConsole.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationEsxiConsole")]
    public class InitializeIntersightVirtualizationEsxiConsole : PSCmdlet
    {
        public InitializeIntersightVirtualizationEsxiConsole()
        {
            ClassId = VirtualizationEsxiConsole.ClassIdEnum.VirtualizationEsxiConsole;
            ObjectType = VirtualizationEsxiConsole.ObjectTypeEnum.VirtualizationEsxiConsole;
            Status = VirtualizationEsxiConsole.StatusEnum.Active;

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

        public VirtualizationEsxiConsole.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.AssetDeviceRegistrationRelationship DeviceRegistration
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a virtualizationVmwareHost resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VirtualizationVmwareHostRelationship Host
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

        public VirtualizationEsxiConsole.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The status of the session.\n* `Active` - The session is currently active.\n* `Ended` - The session has ended normally.\n* `Terminated` - The session was terminated by an admin."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationEsxiConsole.StatusEnum Status
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
            Intersight.Model.VirtualizationEsxiConsole initObject = new Intersight.Model.VirtualizationEsxiConsole();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("DeviceRegistration"))
            {
                initObject.DeviceRegistration = this.DeviceRegistration;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Host"))
            {
                initObject.Host = this.Host;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
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
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationEsxiHostConfiguration.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationEsxiHostConfiguration")]
    public class InitializeIntersightVirtualizationEsxiHostConfiguration : PSCmdlet
    {
        public InitializeIntersightVirtualizationEsxiHostConfiguration()
        {
            ClassId = VirtualizationEsxiHostConfiguration.ClassIdEnum.VirtualizationEsxiHostConfiguration;
            ObjectType = VirtualizationEsxiHostConfiguration.ObjectTypeEnum.VirtualizationEsxiHostConfiguration;

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

        public VirtualizationEsxiHostConfiguration.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Datacenter where host is deployed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Datacenter
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationEsxiHostConfiguration.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.VirtualizationEsxiHostConfiguration initObject = new Intersight.Model.VirtualizationEsxiHostConfiguration();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Datacenter"))
            {
                initObject.Datacenter = this.Datacenter;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationEsxiOvaCustomSpec.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationEsxiOvaCustomSpec")]
    public class InitializeIntersightVirtualizationEsxiOvaCustomSpec : PSCmdlet
    {
        public InitializeIntersightVirtualizationEsxiOvaCustomSpec()
        {
            ClassId = VirtualizationEsxiOvaCustomSpec.ClassIdEnum.VirtualizationEsxiOvaCustomSpec;
            ObjectType = VirtualizationEsxiOvaCustomSpec.ObjectTypeEnum.VirtualizationEsxiOvaCustomSpec;

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

        public VirtualizationEsxiOvaCustomSpec.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Specify the Extra Config specification which can be configured on virtual machine."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object ExtraConfig
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationEsxiOvaCustomSpec.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Specify the OVA Environment specification which can be configured on the virtual machine."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object OvaEnvSpec
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.VirtualizationEsxiOvaCustomSpec initObject = new Intersight.Model.VirtualizationEsxiOvaCustomSpec();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ExtraConfig"))
            {
                initObject.ExtraConfig = this.ExtraConfig;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("OvaEnvSpec"))
            {
                initObject.OvaEnvSpec = this.OvaEnvSpec;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationEsxiVmComputeConfiguration.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationEsxiVmComputeConfiguration")]
    public class InitializeIntersightVirtualizationEsxiVmComputeConfiguration : PSCmdlet
    {
        public InitializeIntersightVirtualizationEsxiVmComputeConfiguration()
        {
            ClassId = VirtualizationEsxiVmComputeConfiguration.ClassIdEnum.VirtualizationEsxiVmComputeConfiguration;
            ObjectType = VirtualizationEsxiVmComputeConfiguration.ObjectTypeEnum.VirtualizationEsxiVmComputeConfiguration;

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

        public VirtualizationEsxiVmComputeConfiguration.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationEsxiVmComputeConfiguration.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"ResourcePool where virtual machine is deployed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ResourcePool
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.VirtualizationEsxiVmComputeConfiguration initObject = new Intersight.Model.VirtualizationEsxiVmComputeConfiguration();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("ResourcePool"))
            {
                initObject.ResourcePool = this.ResourcePool;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationEsxiVmConfiguration.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationEsxiVmConfiguration")]
    public class InitializeIntersightVirtualizationEsxiVmConfiguration : PSCmdlet
    {
        public InitializeIntersightVirtualizationEsxiVmConfiguration()
        {
            ClassId = VirtualizationEsxiVmConfiguration.ClassIdEnum.VirtualizationEsxiVmConfiguration;
            ObjectType = VirtualizationEsxiVmConfiguration.ObjectTypeEnum.VirtualizationEsxiVmConfiguration;

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
        /// <para type="description">"Specify annotation (optional) for the virtual machine."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Annotation
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationEsxiVmConfiguration.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"ESXi virtual machine compute specification."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VirtualizationEsxiVmComputeConfiguration Compute
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"ESXi virtual machine custom specification."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VirtualizationBaseCustomSpec Customspec
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Datacenter where virtual machine is deployed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Datacenter
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Folder where virtual machine is deployed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Folder
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Image path of OVA (The image can be from any location)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Image
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"ESXi virtual machine network specification."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VirtualizationEsxiVmNetworkConfiguration Network
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationEsxiVmConfiguration.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"ESXi virtual machine storage specification."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VirtualizationEsxiVmStorageConfiguration Storage
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Template to be used for clone."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Template
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.VirtualizationEsxiVmConfiguration initObject = new Intersight.Model.VirtualizationEsxiVmConfiguration();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Annotation"))
            {
                initObject.Annotation = this.Annotation;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Compute"))
            {
                initObject.Compute = this.Compute;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Customspec"))
            {
                initObject.Customspec = this.Customspec;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Datacenter"))
            {
                initObject.Datacenter = this.Datacenter;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Folder"))
            {
                initObject.Folder = this.Folder;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Image"))
            {
                initObject.Image = this.Image;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Network"))
            {
                initObject.Network = this.Network;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Storage"))
            {
                initObject.Storage = this.Storage;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Template"))
            {
                initObject.Template = this.Template;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationEsxiVmNetworkConfiguration.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationEsxiVmNetworkConfiguration")]
    public class InitializeIntersightVirtualizationEsxiVmNetworkConfiguration : PSCmdlet
    {
        public InitializeIntersightVirtualizationEsxiVmNetworkConfiguration()
        {
            ClassId = VirtualizationEsxiVmNetworkConfiguration.ClassIdEnum.VirtualizationEsxiVmNetworkConfiguration;
            ObjectType = VirtualizationEsxiVmNetworkConfiguration.ObjectTypeEnum.VirtualizationEsxiVmNetworkConfiguration;

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

        public VirtualizationEsxiVmNetworkConfiguration.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.VirtualizationNetworkInterface> Interfaces
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationEsxiVmNetworkConfiguration.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.VirtualizationEsxiVmNetworkConfiguration initObject = new Intersight.Model.VirtualizationEsxiVmNetworkConfiguration();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Interfaces"))
            {
                initObject.Interfaces = this.Interfaces;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationEsxiVmStorageConfiguration.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationEsxiVmStorageConfiguration")]
    public class InitializeIntersightVirtualizationEsxiVmStorageConfiguration : PSCmdlet
    {
        public InitializeIntersightVirtualizationEsxiVmStorageConfiguration()
        {
            ClassId = VirtualizationEsxiVmStorageConfiguration.ClassIdEnum.VirtualizationEsxiVmStorageConfiguration;
            ObjectType = VirtualizationEsxiVmStorageConfiguration.ObjectTypeEnum.VirtualizationEsxiVmStorageConfiguration;

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

        public VirtualizationEsxiVmStorageConfiguration.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Datastore where virtual machine is deployed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Datastore
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.VirtualizationVmEsxiDisk> Disks
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationEsxiVmStorageConfiguration.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.VirtualizationEsxiVmStorageConfiguration initObject = new Intersight.Model.VirtualizationEsxiVmStorageConfiguration();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Datastore"))
            {
                initObject.Datastore = this.Datastore;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Disks"))
            {
                initObject.Disks = this.Disks;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationGuestInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationGuestInfo")]
    public class InitializeIntersightVirtualizationGuestInfo : PSCmdlet
    {
        public InitializeIntersightVirtualizationGuestInfo()
        {
            ClassId = VirtualizationGuestInfo.ClassIdEnum.VirtualizationGuestInfo;
            ObjectType = VirtualizationGuestInfo.ObjectTypeEnum.VirtualizationGuestInfo;

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

        public VirtualizationGuestInfo.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name provided to the host OS (example, ubuntu6410, test-gateway, etc.)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Hostname
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Primary IP address of the guest os."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string IpAddress
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the guest running on this VM. This may not be the same as the hostname."</para>
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

        public VirtualizationGuestInfo.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the guest OS running on this VM (Cent OS 4/5/6/7)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string OperatingSystem
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.VirtualizationGuestInfo initObject = new Intersight.Model.VirtualizationGuestInfo();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Hostname"))
            {
                initObject.Hostname = this.Hostname;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IpAddress"))
            {
                initObject.IpAddress = this.IpAddress;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("OperatingSystem"))
            {
                initObject.VarOperatingSystem = this.OperatingSystem;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationHost.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationHost")]
    public class InitializeIntersightVirtualizationHost : PSCmdlet
    {
        public InitializeIntersightVirtualizationHost()
        {
            Action = VirtualizationHost.ActionEnum.None;
            ClassId = VirtualizationHost.ClassIdEnum.VirtualizationHost;
            MaintenanceState = VirtualizationHost.MaintenanceStateEnum.None;
            ObjectType = VirtualizationHost.ObjectTypeEnum.VirtualizationHost;

        }
        // <summary>
        /// <para type="description">"Action to be performed on a host (Create, PowerState, Migrate, Clone etc).\n* `None` - A place holder for the default value.\n* `EnterMaintenanceMode` - Put a host into maintenance mode.\n* `ExitMaintenanceMode` - Put a host into active mode.\n* `PowerOffStorageController` - Power off HyperFlex storage controller node running on selected hypervisor host.\n* `PowerOnStorageController` - Power on HyperFlex storage controller node running on selected hypervisor host."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationHost.ActionEnum Action
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

        public VirtualizationHost.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"If true, move powered-off and suspended virtual machines to other hosts in the cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Evacuate
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Virtual machine configuration to provision."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VirtualizationBaseHostConfiguration HostConfig
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Expected state of host. An action on the host (e.g., Enter Maintenance) may cause the host to be put into maintenance mode.\n* `None` - A place holder for the default value.\n* `Enter` - Power action is performed on the virtual machine.\n* `Exit` - The virtual machine will be migrated from existing node to a different node in cluster. The behavior depends on the underlying hypervisor."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationHost.MaintenanceStateEnum MaintenanceState
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

        public VirtualizationHost.ObjectTypeEnum ObjectType
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
            Intersight.Model.VirtualizationHost initObject = new Intersight.Model.VirtualizationHost();
            if (this.MyInvocation.BoundParameters.ContainsKey("Action"))
            {
                initObject.Action = this.Action;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Evacuate"))
            {
                initObject.Evacuate = this.Evacuate;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HostConfig"))
            {
                initObject.HostConfig = this.HostConfig;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaintenanceState"))
            {
                initObject.MaintenanceState = this.MaintenanceState;
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
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationIpAddressInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationIpAddressInfo")]
    public class InitializeIntersightVirtualizationIpAddressInfo : PSCmdlet
    {
        public InitializeIntersightVirtualizationIpAddressInfo()
        {
            ClassId = VirtualizationIpAddressInfo.ClassIdEnum.VirtualizationIpAddressInfo;
            ObjectType = VirtualizationIpAddressInfo.ObjectTypeEnum.VirtualizationIpAddressInfo;

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

        public VirtualizationIpAddressInfo.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"IP address of the device on network which forwards local traffic to other networks."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string GatewayIp
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An IP address is a 32-bit number. It uniquely identifies a host in given network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string IpAddress
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationIpAddressInfo.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A 32 bit number which helps to identify the host and rest of the network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SubnetMask
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.VirtualizationIpAddressInfo initObject = new Intersight.Model.VirtualizationIpAddressInfo();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("GatewayIp"))
            {
                initObject.GatewayIp = this.GatewayIp;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IpAddress"))
            {
                initObject.IpAddress = this.IpAddress;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("SubnetMask"))
            {
                initObject.SubnetMask = this.SubnetMask;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationMemoryCapacity.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationMemoryCapacity")]
    public class InitializeIntersightVirtualizationMemoryCapacity : PSCmdlet
    {
        public InitializeIntersightVirtualizationMemoryCapacity()
        {
            ClassId = VirtualizationMemoryCapacity.ClassIdEnum.VirtualizationMemoryCapacity;
            ObjectType = VirtualizationMemoryCapacity.ObjectTypeEnum.VirtualizationMemoryCapacity;

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
        /// <para type="description">"The total memory capacity of the entity in bytes."</para>
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

        public VirtualizationMemoryCapacity.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Free memory (bytes) that is unused and available for allocation, as a point-in-time snapshot. The available memory capacity is reported for an entity (such as Host or Cluster) when inventory data is collected for that entity. As part of the inventory data, a snapshot of the free and used memory capacity is also reported."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Free
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationMemoryCapacity.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Memory (bytes) that has been already used up, as a point-in-time snapshot."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Used
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.VirtualizationMemoryCapacity initObject = new Intersight.Model.VirtualizationMemoryCapacity();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Capacity"))
            {
                initObject.Capacity = this.Capacity;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Free"))
            {
                initObject.Free = this.Free;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Used"))
            {
                initObject.Used = this.Used;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationNetworkInterface.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationNetworkInterface")]
    public class InitializeIntersightVirtualizationNetworkInterface : PSCmdlet
    {
        public InitializeIntersightVirtualizationNetworkInterface()
        {
            AdaptorType = VirtualizationNetworkInterface.AdaptorTypeEnum.Unknown;
            ClassId = VirtualizationNetworkInterface.ClassIdEnum.VirtualizationNetworkInterface;
            ObjectType = VirtualizationNetworkInterface.ObjectTypeEnum.VirtualizationNetworkInterface;
            PrivateIpAllocationMode = VirtualizationNetworkInterface.PrivateIpAllocationModeEnum.DHCP;

        }
        // <summary>
        /// <para type="description">"Virtual machine network adaptor type.\n* `Unknown` - The type of the network adaptor type is unknown.\n* `E1000` - Emulated version of the Intel 82545EM Gigabit Ethernet NIC.\n* `SRIOV` - Representation of a virtual function (VF) on a physical NIC with SR-IOV support.\n* `VMXNET2` - VMXNET 2 (Enhanced) is available only for some guest operating systems on ESX/ESXi 3.5 and later.\n* `VMXNET3` - VMXNET 3 offers all the features available in VMXNET 2 and adds several new features.\n* `E1000E` - E1000E – emulates a newer real network adapter, the 1 Gbit Intel 82574, and is available for Windows 2012 and later. The E1000E needs virtual machine hardware version 8 or later.\n* `NE2K_PCI` - The Ne2000 network card uses two ring buffers for packet handling. These are circular buffers made of 256-byte pages that the chip's DMA logic will use to store received packets or to get received packets.\n* `PCnet` - The PCnet-PCI II is a PCI network adapter. It has built-in support for CRC checks and can automatically pad short packets to the minimum Ethernet length.\n* `RTL8139` - The RTL8139 is a fast Ethernet card that operates at 10/100 Mbps. It is compliant with PCI version 2.0/2.1 and it is known for reliability and superior performance.\n* `VirtIO` - VirtIO is a standardized interface which allows virtual machines access to simplified \"virtual\" devices, such as block devices, network adapters and consoles. Accessing devices through VirtIO on a guest VM improves performance over more traditional \"emulated\" devices, as VirtIO devices require only the bare minimum setup and configuration needed to send and receive data, while the host machine handles the majority of the setup and maintenance of the actual physical hardware.\n* `` - Default network adaptor type supported by the hypervisor."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationNetworkInterface.AdaptorTypeEnum AdaptorType
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
        /// <para type="description">"Virtual machine network bridge name."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Bridge
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationNetworkInterface.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Connect the adaptor at virtual machine power on."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool ConnectAtPowerOn
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Enable the direct path I/O."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool DirectPathIo
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Set to true, if IP forwarding is enabled on the NIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool IpForwardingEnabled
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Set to true, if IPv6 address should be allocated for the NIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Ipv6Address
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Virtual machine network mac address."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^([0-9A-Fa-f]{2}[:-]){5}([0-9A-Fa-f]{2})$")]
        public string MacAddress
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the network interface. This may be different from guest operating system assigned."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Identity of the network to which this network interface belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string NetworkId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Identity of the network interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string NicId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationNetworkInterface.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Order of the NIC attachment to the VM."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Order
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Allocation mode for NIC addresses e.g. DHCP or static.\n* `DHCP` - Dynamic IP address allocation using DHCP protocol.\n* `STATIC_IP` - Assign fixed / static IPs to resources for use.\n* `IPAM_CALLOUT` - Use callout scripts to query cloud IP allocation tools to assign network parameters.\n* `PREALLOCATE_IP` - Allows the cloud infrastructure IP allocation to be dynamically provided before the server boots up."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationNetworkInterface.PrivateIpAllocationModeEnum PrivateIpAllocationMode
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Set to true, if public IP should be allocated for the NIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool PublicIpAllocate
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> SecurityGroups
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.VirtualizationIpAddressInfo> StaticIpAddress
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Subnet identifier for the NIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SubnetId
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.VirtualizationNetworkInterface initObject = new Intersight.Model.VirtualizationNetworkInterface();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdaptorType"))
            {
                initObject.AdaptorType = this.AdaptorType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Bridge"))
            {
                initObject.Bridge = this.Bridge;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ConnectAtPowerOn"))
            {
                initObject.ConnectAtPowerOn = this.ConnectAtPowerOn;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DirectPathIo"))
            {
                initObject.DirectPathIo = this.DirectPathIo;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IpForwardingEnabled"))
            {
                initObject.IpForwardingEnabled = this.IpForwardingEnabled;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Ipv6Address"))
            {
                initObject.Ipv6Address = this.Ipv6Address;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MacAddress"))
            {
                initObject.MacAddress = this.MacAddress;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NetworkId"))
            {
                initObject.NetworkId = this.NetworkId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NicId"))
            {
                initObject.NicId = this.NicId;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Order"))
            {
                initObject.Order = this.Order;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PrivateIpAllocationMode"))
            {
                initObject.PrivateIpAllocationMode = this.PrivateIpAllocationMode;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PublicIpAllocate"))
            {
                initObject.PublicIpAllocate = this.PublicIpAllocate;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SecurityGroups"))
            {
                initObject.SecurityGroups = this.SecurityGroups;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("StaticIpAddress"))
            {
                initObject.StaticIpAddress = this.StaticIpAddress;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SubnetId"))
            {
                initObject.SubnetId = this.SubnetId;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationProductInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationProductInfo")]
    public class InitializeIntersightVirtualizationProductInfo : PSCmdlet
    {
        public InitializeIntersightVirtualizationProductInfo()
        {
            ClassId = VirtualizationProductInfo.ClassIdEnum.VirtualizationProductInfo;
            ObjectType = VirtualizationProductInfo.ObjectTypeEnum.VirtualizationProductInfo;

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
        /// <para type="description">"The build number of the hypervisor running on this host (e.g., 4541947, 6.3.9600.18692). The build number may indicate some feature support that applications might rely on. The build number may not always be an integer."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Build
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationProductInfo.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationProductInfo.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Commercial product name. For example, VMware ESXi."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ProductName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Product name provided by the vendor. For example, embeddedEsx."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ProductType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Commercial vendor name. For example, VMware Inc."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ProductVendor
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Hypervisor version running on the system."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Version
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.VirtualizationProductInfo initObject = new Intersight.Model.VirtualizationProductInfo();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Build"))
            {
                initObject.Build = this.Build;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("ProductName"))
            {
                initObject.ProductName = this.ProductName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ProductType"))
            {
                initObject.ProductType = this.ProductType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ProductVendor"))
            {
                initObject.ProductVendor = this.ProductVendor;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Version"))
            {
                initObject.VarVersion = this.Version;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationStorageCapacity.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationStorageCapacity")]
    public class InitializeIntersightVirtualizationStorageCapacity : PSCmdlet
    {
        public InitializeIntersightVirtualizationStorageCapacity()
        {
            ClassId = VirtualizationStorageCapacity.ClassIdEnum.VirtualizationStorageCapacity;
            ObjectType = VirtualizationStorageCapacity.ObjectTypeEnum.VirtualizationStorageCapacity;

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
        /// <para type="description">"The total capacity of the entity (bytes)."</para>
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

        public VirtualizationStorageCapacity.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Free storage space remaining in the entity (bytes) as a point-in-time snapshot. The available space is reported for an entity (such as Host or Cluster) when inventory data is collected for that entity. As part of the inventory data, a snapshot of the free and used storage capacity is also reported."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Free
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationStorageCapacity.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Spaced already used by this entity (bytes), as a point-in-time snapshot."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Used
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.VirtualizationStorageCapacity initObject = new Intersight.Model.VirtualizationStorageCapacity();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Capacity"))
            {
                initObject.Capacity = this.Capacity;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Free"))
            {
                initObject.Free = this.Free;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Used"))
            {
                initObject.Used = this.Used;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationVirtualMachine.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationVirtualMachine")]
    public class InitializeIntersightVirtualizationVirtualMachine : PSCmdlet
    {
        public InitializeIntersightVirtualizationVirtualMachine()
        {
            Action = VirtualizationVirtualMachine.ActionEnum.None;
            ClassId = VirtualizationVirtualMachine.ClassIdEnum.VirtualizationVirtualMachine;
            GuestOs = VirtualizationVirtualMachine.GuestOsEnum.Linux;
            ObjectType = VirtualizationVirtualMachine.ObjectTypeEnum.VirtualizationVirtualMachine;
            PowerState = VirtualizationVirtualMachine.PowerStateEnum.PowerOff;
            ProvisionType = VirtualizationVirtualMachine.ProvisionTypeEnum.OVA;

        }
        // <summary>
        /// <para type="description">"Action to be performed on a virtual machine (Create, PowerState, Migrate, Clone etc).\n* `None` - A place holder for the default value.\n* `PowerState` - Power action is performed on the virtual machine.\n* `Migrate` - The virtual machine will be migrated from existing node to a different node in cluster. The behavior depends on the underlying hypervisor.\n* `Create` - The virtual machine will be created on the specified hypervisor. This action is also useful if the virtual machine creation failed during first POST operation on VirtualMachine managed object. User can set this action to retry the virtual machine creation.\n* `Delete` - The virtual machine will be deleted from the specified hypervisor. User can either set this action or can do a DELETE operation on the VirtualMachine managed object.\n* `Resize` - The virtual machine will be resized to the specified instance type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationVirtualMachine.ActionEnum Action
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.InfraMetaData> AffinitySelectors
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.InfraMetaData> AntiAffinitySelectors
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationVirtualMachine.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Cloud init configuration data for virtual machine."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VirtualizationCloudInitConfig CloudInitConfig
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a virtualizationBaseCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VirtualizationBaseClusterRelationship Cluster
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Cluster where virtual machine is deployed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ClusterEsxi
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of vCPUs to be allocated to virtual machine. The upper limit depends on the hypervisor."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Cpu
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.VirtualizationVirtualMachineDisk> Disk
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Normally any virtual machine that is still powered on cannot be deleted. The expected sequence from a user is to first power off the virtual machine and then invoke the delete operation. However, in special circumstances, the owner of the virtual machine may know very well that the virtual machine is no longer needed and just wants to dispose it off. In such situations a delete operation of a virtual machine object is accepted only when this forceDelete attribute is set to true. Under normal circumstances (forceDelete is false), delete operation first confirms that the virtual machine is powered off and then proceeds to delete the virtual machine."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool ForceDelete
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.InfraBaseGpuConfiguration> GpuConfigs
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Guest operating system running on virtual machine.\n* `linux` - A Linux operating system.\n* `windows` - A Windows operating system."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationVirtualMachine.GuestOsEnum GuestOs
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a virtualizationBaseHost resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VirtualizationBaseHostRelationship Host
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Host where virtual machine is deployed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string HostEsxi
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.VirtualizationNetworkInterface> Interfaces
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.InfraMetaData> Labels
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Virtual machine memory in mebi bytes (one mebibyte, 1MiB, is 1048576 bytes, and 1KiB is 1024 bytes). Input must be a whole number and scientific notation is not acceptable. For example, enter 1730 and not 1.73e03. No upper limit is enforced because hypervisors increase the limit in every release."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Memory
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
        /// <para type="description">"Virtual machine name that is unique. Hypervisors enforce platform specific limits and character sets. The name length limit, both min and max, vary among hypervisors. Therefore, the basic limits are set here and proper enforcement is done elsewhere."</para>
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

        public VirtualizationVirtualMachine.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Expected power state of virtual machine (PowerOn, PowerOff, Restart).\n* `PowerOff` - The virtual machine will be powered off if it is already not in powered off state. If it is already powered off, no side-effects are expected.\n* `PowerOn` - The virtual machine will be powered on if it is already not in powered on state. If it is already powered on, no side-effects are expected.\n* `Suspend` - The virtual machine will be put into  a suspended state.\n* `ShutDownGuestOS` - The guest operating system is shut down gracefully.\n* `RestartGuestOS` - It can either act as a reset switch and abruptly reset the guest operating system, or it can send a restart signal to the guest operating system so that it shuts down gracefully and restarts.\n* `Reset` - Resets the virtual machine abruptly, with no consideration for work in progress.\n* `Restart` - The virtual machine will be restarted only if it is in powered on state. If it is powered off, it will not be started up.\n* `Unknown` - Power state of the entity is unknown."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationVirtualMachine.PowerStateEnum PowerState
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Identifies the provision type to create a new virtual machine.\n* `OVA` - Deploy virtual machine using OVA/F file.\n* `Template` - Provision virtual machine using a template file.\n* `Discovered` - A virtual machine was 'discovered' and not created from Intersight. No provisioning information is available."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationVirtualMachine.ProvisionTypeEnum ProvisionType
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
        // <summary>
        /// <para type="description">"Virtual machine configuration to provision."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VirtualizationBaseVmConfiguration VmConfig
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.VirtualizationVirtualMachine initObject = new Intersight.Model.VirtualizationVirtualMachine();
            if (this.MyInvocation.BoundParameters.ContainsKey("Action"))
            {
                initObject.Action = this.Action;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AffinitySelectors"))
            {
                initObject.AffinitySelectors = this.AffinitySelectors;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AntiAffinitySelectors"))
            {
                initObject.AntiAffinitySelectors = this.AntiAffinitySelectors;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("CloudInitConfig"))
            {
                initObject.CloudInitConfig = this.CloudInitConfig;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Cluster"))
            {
                initObject.Cluster = this.Cluster;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ClusterEsxi"))
            {
                initObject.ClusterEsxi = this.ClusterEsxi;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Cpu"))
            {
                initObject.Cpu = this.Cpu;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Disk"))
            {
                initObject.Disk = this.Disk;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ForceDelete"))
            {
                initObject.ForceDelete = this.ForceDelete;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("GpuConfigs"))
            {
                initObject.GpuConfigs = this.GpuConfigs;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("GuestOs"))
            {
                initObject.GuestOs = this.GuestOs;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Host"))
            {
                initObject.Host = this.Host;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HostEsxi"))
            {
                initObject.HostEsxi = this.HostEsxi;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Interfaces"))
            {
                initObject.Interfaces = this.Interfaces;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Labels"))
            {
                initObject.Labels = this.Labels;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Memory"))
            {
                initObject.Memory = this.Memory;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("ProvisionType"))
            {
                initObject.ProvisionType = this.ProvisionType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RegisteredDevice"))
            {
                initObject.RegisteredDevice = this.RegisteredDevice;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VmConfig"))
            {
                initObject.VmConfig = this.VmConfig;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationVirtualMachineDisk.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationVirtualMachineDisk")]
    public class InitializeIntersightVirtualizationVirtualMachineDisk : PSCmdlet
    {
        public InitializeIntersightVirtualizationVirtualMachineDisk()
        {
            Bus = VirtualizationVirtualMachineDisk.BusEnum.Virtio;
            ClassId = VirtualizationVirtualMachineDisk.ClassIdEnum.VirtualizationVirtualMachineDisk;
            ObjectType = VirtualizationVirtualMachineDisk.ObjectTypeEnum.VirtualizationVirtualMachineDisk;
            Type = VirtualizationVirtualMachineDisk.TypeEnum.Hdd;

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
        /// <para type="description">"Disk bus name given for a virtual machine.\n* `virtio` - Disk uses the same paths as a bare-metal system. This simplifies physical-to-virtual and virtual-to-virtual migration.\n* `sata` - Serial ATA (SATA, abbreviated from Serial AT Attachment) is a computer bus interface that connects host bus adapters to mass storage devices such as hard disk drives, optical drives, and solid-state drives.\n* `scsi` - SCSI (Small Computer System Interface) bus used.."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationVirtualMachineDisk.BusEnum Bus
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationVirtualMachineDisk.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Virtual machine network bridge name."</para>
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

        public VirtualizationVirtualMachineDisk.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Priority order of the disk."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Order
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Disk type hdd or cdrom for a virtual machine.\n* `hdd` - Allows the virtual machine to mount disk from hard disk drive (hdd) image.\n* `cdrom` - Allows the virtual machine to mount disk from compact disk (cd) image."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationVirtualMachineDisk.TypeEnum Type
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the existing virtual disk to be attached to the Virtual Machine."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string VirtualDiskReference
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.VirtualizationVirtualMachineDisk initObject = new Intersight.Model.VirtualizationVirtualMachineDisk();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Bus"))
            {
                initObject.Bus = this.Bus;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Order"))
            {
                initObject.Order = this.Order;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Type"))
            {
                initObject.Type = this.Type;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VirtualDiskReference"))
            {
                initObject.VirtualDiskReference = this.VirtualDiskReference;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationVmEsxiDisk.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationVmEsxiDisk")]
    public class InitializeIntersightVirtualizationVmEsxiDisk : PSCmdlet
    {
        public InitializeIntersightVirtualizationVmEsxiDisk()
        {
            ClassId = VirtualizationVmEsxiDisk.ClassIdEnum.VirtualizationVmEsxiDisk;
            ObjectType = VirtualizationVmEsxiDisk.ObjectTypeEnum.VirtualizationVmEsxiDisk;

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
        /// <para type="description">"Disk capacity to be provided with units example - 10Gi."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Capacity
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationVmEsxiDisk.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Datastore of the disk from the space is allocated."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Datastore
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Mode of the disk, like persistent, independent persistent."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Diskmode
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the virtual disk."</para>
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

        public VirtualizationVmEsxiDisk.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Specify the allocation type as thin or thick."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string StorageAllocation
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Controller name of the disk, if not specified uses the default one."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string StorageController
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.VirtualizationVmEsxiDisk initObject = new Intersight.Model.VirtualizationVmEsxiDisk();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Capacity"))
            {
                initObject.Capacity = this.Capacity;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Datastore"))
            {
                initObject.Datastore = this.Datastore;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Diskmode"))
            {
                initObject.Diskmode = this.Diskmode;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("StorageAllocation"))
            {
                initObject.StorageAllocation = this.StorageAllocation;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("StorageController"))
            {
                initObject.StorageController = this.StorageController;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationVmwareCluster.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationVmwareCluster")]
    public class InitializeIntersightVirtualizationVmwareCluster : PSCmdlet
    {
        public InitializeIntersightVirtualizationVmwareCluster()
        {
            ClassId = VirtualizationVmwareCluster.ClassIdEnum.VirtualizationVmwareCluster;
            HypervisorType = VirtualizationVmwareCluster.HypervisorTypeEnum.ESXi;
            ObjectType = VirtualizationVmwareCluster.ObjectTypeEnum.VirtualizationVmwareCluster;

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

        public VirtualizationVmwareCluster.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"CPU over commitment associated with this cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long CpuOverCommitment
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Count of all datastores associated with this cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long DatastoreCount
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Identifies the broad type of the underlying hypervisor.\n* `ESXi` - The hypervisor running on the HyperFlex cluster is a Vmware ESXi hypervisor of any version.\n* `Hyper-V` - The hypervisor running on the HyperFlex cluster is Microsoft Hyper-V.\n* `Unknown` - The hypervisor running on the HyperFlex cluster is not known."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationVmwareCluster.HypervisorTypeEnum HypervisorType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Identifies the version of the hypervisor running on this cluster. Keeping the hypervisor version in the cluster makes it convenient for applications to validate their deployment needs. Defaults to an empty string."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string HypervisorVersion
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The internally generated identity of this cluster. This entity is not manipulated by users."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Identity
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Inventory path of the cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string InventoryPath
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The capacity and usage information for memory on this cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VirtualizationMemoryCapacity MemoryCapacity
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

        public VirtualizationVmwareCluster.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The capacity and usage information for CPU power on this cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VirtualizationComputeCapacity ProcessorCapacity
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
        /// <para type="description">"An array of relationships to storageBaseCluster resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.StorageBaseClusterRelationship> StorageClusters
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
        /// <para type="description">"Total number of CPU cores in this cluster. It is a cumulative number across all hosts in the cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long TotalCores
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.VirtualizationVmwareCluster initObject = new Intersight.Model.VirtualizationVmwareCluster();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("CpuOverCommitment"))
            {
                initObject.CpuOverCommitment = this.CpuOverCommitment;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DatastoreCount"))
            {
                initObject.DatastoreCount = this.DatastoreCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HypervisorType"))
            {
                initObject.HypervisorType = this.HypervisorType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HypervisorVersion"))
            {
                initObject.HypervisorVersion = this.HypervisorVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Identity"))
            {
                initObject.Identity = this.Identity;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InventoryPath"))
            {
                initObject.InventoryPath = this.InventoryPath;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MemoryCapacity"))
            {
                initObject.MemoryCapacity = this.MemoryCapacity;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("ProcessorCapacity"))
            {
                initObject.ProcessorCapacity = this.ProcessorCapacity;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RegisteredDevice"))
            {
                initObject.RegisteredDevice = this.RegisteredDevice;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("StorageClusters"))
            {
                initObject.StorageClusters = this.StorageClusters;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TotalCores"))
            {
                initObject.TotalCores = this.TotalCores;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationVmwareDatacenter.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationVmwareDatacenter")]
    public class InitializeIntersightVirtualizationVmwareDatacenter : PSCmdlet
    {
        public InitializeIntersightVirtualizationVmwareDatacenter()
        {
            ClassId = VirtualizationVmwareDatacenter.ClassIdEnum.VirtualizationVmwareDatacenter;
            ObjectType = VirtualizationVmwareDatacenter.ObjectTypeEnum.VirtualizationVmwareDatacenter;

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

        public VirtualizationVmwareDatacenter.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Count of all distributed networks associated with this datacenter (DC)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long DistributedNetworkCount
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Count of all distributed virtual switches associated with this datacenter (DC)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long DistributedVirtualSwitchCount
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

        public VirtualizationVmwareDatacenter.ObjectTypeEnum ObjectType
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
        /// <para type="description">"Count of all standard networks associated with this datacenter (DC)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long StandardNetworkCount
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
        /// <para type="description">"Count of all virtual machines (VMs) associated with this DC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long VmCount
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.VirtualizationVmwareDatacenter initObject = new Intersight.Model.VirtualizationVmwareDatacenter();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("DistributedNetworkCount"))
            {
                initObject.DistributedNetworkCount = this.DistributedNetworkCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DistributedVirtualSwitchCount"))
            {
                initObject.DistributedVirtualSwitchCount = this.DistributedVirtualSwitchCount;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("StandardNetworkCount"))
            {
                initObject.StandardNetworkCount = this.StandardNetworkCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VmCount"))
            {
                initObject.VmCount = this.VmCount;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationVmwareDatastore.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationVmwareDatastore")]
    public class InitializeIntersightVirtualizationVmwareDatastore : PSCmdlet
    {
        public InitializeIntersightVirtualizationVmwareDatastore()
        {
            ClassId = VirtualizationVmwareDatastore.ClassIdEnum.VirtualizationVmwareDatastore;
            ObjectType = VirtualizationVmwareDatastore.ObjectTypeEnum.VirtualizationVmwareDatastore;
            Status = VirtualizationVmwareDatastore.StatusEnum.Unknown;
            Type = VirtualizationVmwareDatastore.TypeEnum.Unknown;

        }
        // <summary>
        /// <para type="description">"Shows if this datastore is accessible."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Accessible
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
        /// <para type="description">"Storage utilization for this datastore."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VirtualizationStorageCapacity Capacity
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationVmwareDatastore.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a virtualizationVmwareCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VirtualizationVmwareClusterRelationship Cluster
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to virtualizationVmwareCluster resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.VirtualizationVmwareClusterRelationship> Clusters
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a virtualizationVmwareDatastoreCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VirtualizationVmwareDatastoreClusterRelationship DatastoreCluster
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of hosts attached to or supported-by this datastore."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long HostCount
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The internally generated identity of this datastore. This entity is not manipulated by users. It aids in uniquely identifying the datastore object. For VMware, this is a MOR (managed object reference)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Identity
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Inventory path of the Datastore."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string InventoryPath
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Indicates if the datastore is in maintenance mode. Will be set to True, when in maintenance mode."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool MaintenanceMode
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
        /// <para type="description">"Indicates if this datastore is connected to multiple hosts."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool MultipleHostAccess
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of this datastore supplied by user. It is not the identity of the datastore. The name is subject to user manipulations."</para>
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

        public VirtualizationVmwareDatastore.ObjectTypeEnum ObjectType
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
        /// <para type="description">"Datastore health status, as reported by the hypervisor platform.\n* `Unknown` - Entity status is unknown.\n* `Degraded` - State is degraded, and might impact normal operation of the entity.\n* `Critical` - Entity is in a critical state, impacting operations.\n* `Ok` - Entity status is in a stable state, operating normally."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationVmwareDatastore.StatusEnum Status
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
        /// <para type="description">"Indicates if this datastore supports thin provisioning for files."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool ThinProvisioningSupported
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A string indicating the type of the datastore (VMFS, NFS, etc).\n* `Unknown` - The nature of the file system is unknown.\n* `VMFS` - It is a Virtual Machine Filesystem.\n* `NFS` - It is a Network File System.\n* `vSAN` - It is a virtual Storage Area Network file system.\n* `VirtualVolume` - A Virtual Volume datastore represents a storage container in a hypervisor server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationVmwareDatastore.TypeEnum Type
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Space uncommitted in this datastore in bytes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long UnCommitted
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The URL to access this datastore (example - 'ds:///vmfs/volumes/562a4e8a-0eeb5372-dd61-78baf9cb9afa/')."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Url
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of virtual machines relying on (using) this datastore."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long VmCount
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of virtual machine templates relying on (using) this datastore."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long VmTemplateCount
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.VirtualizationVmwareDatastore initObject = new Intersight.Model.VirtualizationVmwareDatastore();
            if (this.MyInvocation.BoundParameters.ContainsKey("Accessible"))
            {
                initObject.Accessible = this.Accessible;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Capacity"))
            {
                initObject.Capacity = this.Capacity;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Cluster"))
            {
                initObject.Cluster = this.Cluster;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Clusters"))
            {
                initObject.Clusters = this.Clusters;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DatastoreCluster"))
            {
                initObject.DatastoreCluster = this.DatastoreCluster;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HostCount"))
            {
                initObject.HostCount = this.HostCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Identity"))
            {
                initObject.Identity = this.Identity;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InventoryPath"))
            {
                initObject.InventoryPath = this.InventoryPath;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaintenanceMode"))
            {
                initObject.MaintenanceMode = this.MaintenanceMode;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MultipleHostAccess"))
            {
                initObject.MultipleHostAccess = this.MultipleHostAccess;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Status"))
            {
                initObject.Status = this.Status;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ThinProvisioningSupported"))
            {
                initObject.ThinProvisioningSupported = this.ThinProvisioningSupported;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Type"))
            {
                initObject.Type = this.Type;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UnCommitted"))
            {
                initObject.UnCommitted = this.UnCommitted;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Url"))
            {
                initObject.Url = this.Url;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VmCount"))
            {
                initObject.VmCount = this.VmCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VmTemplateCount"))
            {
                initObject.VmTemplateCount = this.VmTemplateCount;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationVmwareDatastoreCluster.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationVmwareDatastoreCluster")]
    public class InitializeIntersightVirtualizationVmwareDatastoreCluster : PSCmdlet
    {
        public InitializeIntersightVirtualizationVmwareDatastoreCluster()
        {
            ClassId = VirtualizationVmwareDatastoreCluster.ClassIdEnum.VirtualizationVmwareDatastoreCluster;
            ObjectType = VirtualizationVmwareDatastoreCluster.ObjectTypeEnum.VirtualizationVmwareDatastoreCluster;
            Status = VirtualizationVmwareDatastoreCluster.StatusEnum.Unknown;
            Type = VirtualizationVmwareDatastoreCluster.TypeEnum.Unknown;

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
        /// <para type="description">"The global automation level for all virtual machines in this datastore cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string AutomationLevel
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Storage utilization for this datastore cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VirtualizationStorageCapacity Capacity
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationVmwareDatastoreCluster.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of datastores present in this datastore cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long DatastoreCount
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Minimum level of free space for each datastore that is the threshold for action."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long FreeSpaceThreshold
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of hosts attached to or supported-by this datastore cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long HostCount
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The internally generated identity of this datastore cluster. This entity is not manipulated by users. It aids in uniquely identifying the datastore cluster object. For VMware, this is an MOR (managed object reference)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Identity
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Inventory path of the Datastore Cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string InventoryPath
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Minimum I/O latency for each datastore below which I/O load balancing moves are not considered."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public int IoLatencyThreshold
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Storage DRS behavior when it generates recommendations for correcting I/O load imbalance in a datastore cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string IoLoadBalanceAutomationMode
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Amount of imbalance that Storage DRS should tolerate."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public int IoLoadImbalanceThreshold
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Is I/O Metrics enabled for this datastore cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool IoMetricsEnabled
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Specify how much of an improvement DRS should look for before making a recommendation or performing a migration."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public int MinSpaceUtilizationDifference
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
        /// <para type="description">"Name of the Datastore Cluster."</para>
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

        public VirtualizationVmwareDatastoreCluster.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Storage DRS behavior when it generates recommendations for correcting storage and VM policy violations in a datastore cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string PolicyEnforcementAutomationMode
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
        /// <para type="description">"Storage DRS makes storage migration recommendations if total IOPs reservation of all VMs running on a datastore is higher than the specified threshold."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public int ReservablePercentThreshold
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Storage DRS behavior when it generates recommendations for correcting affinity rule violations in a datastore cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string RuleEnforcementAutomationMode
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Storage DRS behavior when it generates recommendations for correcting space load imbalance in a datastore cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SpaceLoadBalanceAutomationMode
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Runtime thresholds govern when Storage DRS performs or recommends migrations."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SpaceThresholdMode
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Datastore cluster health status, as reported by the hypervisor platform.\n* `Unknown` - Entity status is unknown.\n* `Degraded` - State is degraded, and might impact normal operation of the entity.\n* `Critical` - Entity is in a critical state, impacting operations.\n* `Ok` - Entity status is in a stable state, operating normally."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationVmwareDatastoreCluster.StatusEnum Status
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Is Storage DRS enabled for this datastore cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool StorageDrsEnabled
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
        /// <para type="description">"Type of the Datastore Cluster.\n* `Unknown` - The nature of the file system is unknown.\n* `VMFS` - It is a Virtual Machine Filesystem.\n* `NFS` - It is a Network File System.\n* `vSAN` - It is a virtual Storage Area Network file system.\n* `VirtualVolume` - A Virtual Volume datastore represents a storage container in a hypervisor server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationVmwareDatastoreCluster.TypeEnum Type
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Minimum level of consumed space for each datastore that is the threshold for action."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public int UtilizedSpaceThreshold
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of virtual machines relying on (using) this datastore cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long VmCount
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Storage DRS behavior when it generates recommendations for VM evacuations from datastores in a datastore cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string VmEvacuationAutomationMode
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.VirtualizationVmwareDatastoreCluster initObject = new Intersight.Model.VirtualizationVmwareDatastoreCluster();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AutomationLevel"))
            {
                initObject.AutomationLevel = this.AutomationLevel;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Capacity"))
            {
                initObject.Capacity = this.Capacity;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("DatastoreCount"))
            {
                initObject.DatastoreCount = this.DatastoreCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FreeSpaceThreshold"))
            {
                initObject.FreeSpaceThreshold = this.FreeSpaceThreshold;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HostCount"))
            {
                initObject.HostCount = this.HostCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Identity"))
            {
                initObject.Identity = this.Identity;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InventoryPath"))
            {
                initObject.InventoryPath = this.InventoryPath;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IoLatencyThreshold"))
            {
                initObject.IoLatencyThreshold = this.IoLatencyThreshold;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IoLoadBalanceAutomationMode"))
            {
                initObject.IoLoadBalanceAutomationMode = this.IoLoadBalanceAutomationMode;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IoLoadImbalanceThreshold"))
            {
                initObject.IoLoadImbalanceThreshold = this.IoLoadImbalanceThreshold;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IoMetricsEnabled"))
            {
                initObject.IoMetricsEnabled = this.IoMetricsEnabled;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MinSpaceUtilizationDifference"))
            {
                initObject.MinSpaceUtilizationDifference = this.MinSpaceUtilizationDifference;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("PolicyEnforcementAutomationMode"))
            {
                initObject.PolicyEnforcementAutomationMode = this.PolicyEnforcementAutomationMode;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RegisteredDevice"))
            {
                initObject.RegisteredDevice = this.RegisteredDevice;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ReservablePercentThreshold"))
            {
                initObject.ReservablePercentThreshold = this.ReservablePercentThreshold;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RuleEnforcementAutomationMode"))
            {
                initObject.RuleEnforcementAutomationMode = this.RuleEnforcementAutomationMode;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SpaceLoadBalanceAutomationMode"))
            {
                initObject.SpaceLoadBalanceAutomationMode = this.SpaceLoadBalanceAutomationMode;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SpaceThresholdMode"))
            {
                initObject.SpaceThresholdMode = this.SpaceThresholdMode;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Status"))
            {
                initObject.Status = this.Status;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("StorageDrsEnabled"))
            {
                initObject.StorageDrsEnabled = this.StorageDrsEnabled;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Type"))
            {
                initObject.Type = this.Type;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UtilizedSpaceThreshold"))
            {
                initObject.UtilizedSpaceThreshold = this.UtilizedSpaceThreshold;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VmCount"))
            {
                initObject.VmCount = this.VmCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VmEvacuationAutomationMode"))
            {
                initObject.VmEvacuationAutomationMode = this.VmEvacuationAutomationMode;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationVmwareDiscoveryProtocol.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationVmwareDiscoveryProtocol")]
    public class InitializeIntersightVirtualizationVmwareDiscoveryProtocol : PSCmdlet
    {
        public InitializeIntersightVirtualizationVmwareDiscoveryProtocol()
        {
            ClassId = VirtualizationVmwareDiscoveryProtocol.ClassIdEnum.VirtualizationVmwareDiscoveryProtocol;
            ObjectType = VirtualizationVmwareDiscoveryProtocol.ObjectTypeEnum.VirtualizationVmwareDiscoveryProtocol;

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

        public VirtualizationVmwareDiscoveryProtocol.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationVmwareDiscoveryProtocol.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Operational mode of the ESXI hosts connected to the distributed virtual switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Operation
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Discovery protocol type enabled on the distributed virtual switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Type
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.VirtualizationVmwareDiscoveryProtocol initObject = new Intersight.Model.VirtualizationVmwareDiscoveryProtocol();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Operation"))
            {
                initObject.Operation = this.Operation;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Type"))
            {
                initObject.Type = this.Type;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationVmwareDistributedNetwork.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationVmwareDistributedNetwork")]
    public class InitializeIntersightVirtualizationVmwareDistributedNetwork : PSCmdlet
    {
        public InitializeIntersightVirtualizationVmwareDistributedNetwork()
        {
            ClassId = VirtualizationVmwareDistributedNetwork.ClassIdEnum.VirtualizationVmwareDistributedNetwork;
            ForgedTransmits = VirtualizationVmwareDistributedNetwork.ForgedTransmitsEnum.Reject;
            MacAddressChanges = VirtualizationVmwareDistributedNetwork.MacAddressChangesEnum.Reject;
            ObjectType = VirtualizationVmwareDistributedNetwork.ObjectTypeEnum.VirtualizationVmwareDistributedNetwork;
            PromiscuousMode = VirtualizationVmwareDistributedNetwork.PromiscuousModeEnum.Reject;
            VlanType = VirtualizationVmwareDistributedNetwork.VlanTypeEnum.None;

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

        public VirtualizationVmwareDistributedNetwork.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"If forgedTransmits property value is set to reject, outbound frames with a source MAC address different from the one set on the adapter are dropped. If property value is set to accept, no filtering is performed and all outbound frames are passed.\n* `Reject` - Indicates that the security policy is rejected.\n* `Accept` - Indicates that the security policy is accepted."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationVmwareDistributedNetwork.ForgedTransmitsEnum ForgedTransmits
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
        /// <para type="description">"If macAddressChanges property value is set to reject and the MAC address of the adapter is changed to a value other than the one specified in .vmx configuration file, all inbound frames are dropped. If property value is set to accept and the MAC address is changed, inbound frames to the new MAC address are received.\n* `Reject` - Indicates that the security policy is rejected.\n* `Accept` - Indicates that the security policy is accepted."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationVmwareDistributedNetwork.MacAddressChangesEnum MacAddressChanges
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
        /// <para type="description">"The teams can then either share the load of traffic between physical and virtual networks among some or all of its members, or provide passive failover in the event of a hardware failure or a network outage."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VirtualizationVmwareTeamingAndFailover NicTeamingAndFailover
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The total number of hosts connected to this distributed virtual network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long NumHosts
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The total number of ports in the distributed virtual network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long NumPorts
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationVmwareDistributedNetwork.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"If promiscuousMode property value is set to reject, incoming traffic only targeted to that network will be visible. If property value is set to accept, objects defined within the network can see all incoming traffic on the virtual switch based on the VLAN policy.\n* `Reject` - Indicates that the security policy is rejected.\n* `Accept` - Indicates that the security policy is accepted."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationVmwareDistributedNetwork.PromiscuousModeEnum PromiscuousMode
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
        // <summary>
        /// <para type="description">"Indicates if the distributed virtual network is a uplink."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool UpLink
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.VirtualizationVmwareVlanRange> VlanRange
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"VLAN type of the distributed virtual network. It can be None, VLAN, VLAN Trunking or Private VLAN.\n* `None` - Do not tag traffic with any VLAN Id.\n* `VLAN` - Tag traffic with the Id from the VLAN Id field.\n* `VLAN trunking` - Pass VLAN traffic with Id within the VLAN trunk range to guest operating system.\n* `Private VLAN` - Associate the traffic with a private VLAN created on the distributed switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationVmwareDistributedNetwork.VlanTypeEnum VlanType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.VirtualizationVmwareDistributedNetwork initObject = new Intersight.Model.VirtualizationVmwareDistributedNetwork();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ForgedTransmits"))
            {
                initObject.ForgedTransmits = this.ForgedTransmits;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Identity"))
            {
                initObject.Identity = this.Identity;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MacAddressChanges"))
            {
                initObject.MacAddressChanges = this.MacAddressChanges;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NicTeamingAndFailover"))
            {
                initObject.NicTeamingAndFailover = this.NicTeamingAndFailover;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NumHosts"))
            {
                initObject.NumHosts = this.NumHosts;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NumPorts"))
            {
                initObject.NumPorts = this.NumPorts;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("PromiscuousMode"))
            {
                initObject.PromiscuousMode = this.PromiscuousMode;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RegisteredDevice"))
            {
                initObject.RegisteredDevice = this.RegisteredDevice;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UpLink"))
            {
                initObject.UpLink = this.UpLink;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VlanRange"))
            {
                initObject.VlanRange = this.VlanRange;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VlanType"))
            {
                initObject.VlanType = this.VlanType;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationVmwareDistributedSwitch.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationVmwareDistributedSwitch")]
    public class InitializeIntersightVirtualizationVmwareDistributedSwitch : PSCmdlet
    {
        public InitializeIntersightVirtualizationVmwareDistributedSwitch()
        {
            ClassId = VirtualizationVmwareDistributedSwitch.ClassIdEnum.VirtualizationVmwareDistributedSwitch;
            ObjectType = VirtualizationVmwareDistributedSwitch.ObjectTypeEnum.VirtualizationVmwareDistributedSwitch;

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

        public VirtualizationVmwareDistributedSwitch.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Switch description (user provided), if any."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Discovery protocol helps to determine which port of the physical switch connected to standard switch or distributed switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VirtualizationVmwareDiscoveryProtocol DiscoveryProtocol
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The internally generated identity of this switch. This entity is not manipulated by users. It aids in uniquely identifying the switch object. For VMware, this is MOR (managed object reference)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Identity
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Maximum number of ports allowed on this distributed virtual switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long MaxPort
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
        /// <para type="description">"Maximum transmission unit configured on a distributed virtual switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Mtu
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"User-provided name to identify the switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"If network io control is enabled, will set the value as true."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool NetworkIoControl
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The teams can then either share the load of traffic between physical and virtual networks among some or all of its members, or provide passive failover in the event of a hardware failure or a network outage."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VirtualizationVmwareTeamingAndFailover NicTeamingAndFailover
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The total number of hosts attached to the distributed virtual switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long NumHosts
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The total number of distributed networks in the distributed virtual switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long NumNetworks
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of stand-alone ports in use."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long NumStandAlonePorts
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of uplinks configured in this distributed virtual switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long NumUplinks
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationVmwareDistributedSwitch.ObjectTypeEnum ObjectType
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

        public List<Model.VirtualizationVmwareResourceAllocationSystemTrafficTypes> ResourceAllocationSystemTraffic
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Capacity and consumption information about this distributed virtual switch, if available."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VirtualizationStorageCapacity SwitchCapacity
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
        /// <para type="description">"Universally Unique Id of this distributed virtual switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12}$")]
        public string Uuid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The running config's version details are represented."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Version
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.VirtualizationVmwareDistributedSwitch initObject = new Intersight.Model.VirtualizationVmwareDistributedSwitch();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DiscoveryProtocol"))
            {
                initObject.DiscoveryProtocol = this.DiscoveryProtocol;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Identity"))
            {
                initObject.Identity = this.Identity;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaxPort"))
            {
                initObject.MaxPort = this.MaxPort;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Mtu"))
            {
                initObject.Mtu = this.Mtu;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NetworkIoControl"))
            {
                initObject.NetworkIoControl = this.NetworkIoControl;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NicTeamingAndFailover"))
            {
                initObject.NicTeamingAndFailover = this.NicTeamingAndFailover;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NumHosts"))
            {
                initObject.NumHosts = this.NumHosts;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NumNetworks"))
            {
                initObject.NumNetworks = this.NumNetworks;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NumStandAlonePorts"))
            {
                initObject.NumStandAlonePorts = this.NumStandAlonePorts;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NumUplinks"))
            {
                initObject.NumUplinks = this.NumUplinks;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("RegisteredDevice"))
            {
                initObject.RegisteredDevice = this.RegisteredDevice;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ResourceAllocationSystemTraffic"))
            {
                initObject.ResourceAllocationSystemTraffic = this.ResourceAllocationSystemTraffic;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SwitchCapacity"))
            {
                initObject.SwitchCapacity = this.SwitchCapacity;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Uuid"))
            {
                initObject.Uuid = this.Uuid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Version"))
            {
                initObject.VarVersion = this.Version;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationVmwareFolder.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationVmwareFolder")]
    public class InitializeIntersightVirtualizationVmwareFolder : PSCmdlet
    {
        public InitializeIntersightVirtualizationVmwareFolder()
        {
            ClassId = VirtualizationVmwareFolder.ClassIdEnum.VirtualizationVmwareFolder;
            ObjectType = VirtualizationVmwareFolder.ObjectTypeEnum.VirtualizationVmwareFolder;
            TypeofFolder = VirtualizationVmwareFolder.TypeofFolderEnum.Unknown;

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

        public VirtualizationVmwareFolder.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a virtualizationVmwareVcenter resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VirtualizationVmwareVcenterRelationship HypervisorManager
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The internally generated identity of this folder. This entity is not manipulated by users. It aids in uniquely identifying the folder object. For VMware, this is a MOR (managed object reference)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Identity
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"If a folder is internal, it will be set to true."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Internal
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Inventory path to the folder. Example - /DC/myFolder."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string InventoryPath
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
        /// <para type="description">"Name of the folder as stored in vCenter."</para>
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

        public VirtualizationVmwareFolder.ObjectTypeEnum ObjectType
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
        // <summary>
        /// <para type="description">"Determines the type of folder. e.g. vCenter folder, VM and Templete Folder, StorageFolder, NetworkFolder, Host and Cluster Folder.\n* `Unknown` - The type of the folder is unknown. It may not represent that the folder does not exist but indicates that something might be wrong.\n* `VMTemplateFolder` - The folder contains VMs and VM templates.\n* `StorageFolder` - The folder contains storage devices.\n* `HostClusterFolder` - The folder contains hosts and clusters.\n* `NetworkFolder` - The folder contains network items.\n* `VcenterFolder` - The folder created under a vCenter or vCenter folder."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationVmwareFolder.TypeofFolderEnum TypeofFolder
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a virtualizationVmwareFolder resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VirtualizationVmwareFolderRelationship VmwareFolder
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.VirtualizationVmwareFolder initObject = new Intersight.Model.VirtualizationVmwareFolder();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("HypervisorManager"))
            {
                initObject.HypervisorManager = this.HypervisorManager;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Identity"))
            {
                initObject.Identity = this.Identity;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Internal"))
            {
                initObject.Internal = this.Internal;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InventoryPath"))
            {
                initObject.InventoryPath = this.InventoryPath;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("TypeofFolder"))
            {
                initObject.TypeofFolder = this.TypeofFolder;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VmwareFolder"))
            {
                initObject.VmwareFolder = this.VmwareFolder;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationVmwareHost.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationVmwareHost")]
    public class InitializeIntersightVirtualizationVmwareHost : PSCmdlet
    {
        public InitializeIntersightVirtualizationVmwareHost()
        {
            ClassId = VirtualizationVmwareHost.ClassIdEnum.VirtualizationVmwareHost;
            HwPowerState = VirtualizationVmwareHost.HwPowerStateEnum.Unknown;
            HypervisorType = VirtualizationVmwareHost.HypervisorTypeEnum.ESXi;
            ObjectType = VirtualizationVmwareHost.ObjectTypeEnum.VirtualizationVmwareHost;
            Status = VirtualizationVmwareHost.StatusEnum.Unknown;

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
        /// <para type="description">"The time when this host booted up."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime BootTime
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationVmwareHost.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a virtualizationVmwareCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VirtualizationVmwareClusterRelationship Cluster
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Indicates if the host is connected to the vCenter. Values are connected, not connected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ConnectionState
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Details about the CPUs installed on this host are represented here."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VirtualizationCpuInfo CpuInfo
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"This field stores the inventory path of a datacenter. Used in host maintenance action."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string DcInvPath
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> DnsServers
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The hardware details of this host. It includes capacity, manufacturer, and model information."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.InfraHardwareInfo HardwareInfo
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Is the host Powered-up or Powered-down.\n* `Unknown` - The entity's power state is unknown.\n* `PoweringOn` - The entity is powering on.\n* `PoweredOn` - The entity is powered on.\n* `PoweringOff` - The entity is powering off.\n* `PoweredOff` - The entity is powered down.\n* `StandBy` - The entity is in standby mode.\n* `Paused` - The entity is in pause state.\n* `Rebooting` - The entity reboot is in progress.\n* `` - The entity's power state is not available."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationVmwareHost.HwPowerStateEnum HwPowerState
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Identifies the broad type of the underlying hypervisor.\n* `ESXi` - The hypervisor running on the HyperFlex cluster is a Vmware ESXi hypervisor of any version.\n* `Hyper-V` - The hypervisor running on the HyperFlex cluster is Microsoft Hyper-V.\n* `Unknown` - The hypervisor running on the HyperFlex cluster is not known."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationVmwareHost.HypervisorTypeEnum HypervisorType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The internally generated identity of this host. This entity is not manipulated by users. It aids in uniquely identifying the datacenter object. For VMware, this is an MOR (managed object reference)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Identity
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"True if SSH is enabled in the host, false otherwise."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool IsSshEnabled
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Is this host in maintenance mode. Set to true or false."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool MaintenanceMode
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The memory capacity and usage information on this host."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VirtualizationMemoryCapacity MemoryCapacity
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Commercial model information about this hardware."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Model
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
        /// <para type="description">"Name of this host supplied by user. It is not the identity of the host. The name is subject to user manipulations."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The count of all network adapters attached to this host."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long NetworkAdapterCount
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> NtpServers
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationVmwareHost.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The capacity and usage information for CPU power on this host."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VirtualizationComputeCapacity ProcessorCapacity
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Details of this product, such as vendor, model, etc. are represented here."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VirtualizationProductInfo ProductInfo
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Indicates if the host is in quarantine mode. Will be set to True, when in quarantine mode."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool QuarantineMode
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
        /// <para type="description">"Snapshot of resources (CPU, memory, etc.) consumed by this host."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VirtualizationVmwareResourceConsumption ResourceConsumed
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Serial number of this host (internally generated)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Serial
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Host health status, as reported by the hypervisor platform.\n* `Unknown` - Entity status is unknown.\n* `Degraded` - State is degraded, and might impact normal operation of the entity.\n* `Critical` - Entity is in a critical state, impacting operations.\n* `Ok` - Entity status is in a stable state, operating normally."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationVmwareHost.StatusEnum Status
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The count of all storage adapters attached to this host."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long StorageAdapterCount
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
        /// <para type="description">"Time zone this host is in."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string TimeZone
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The uptime of the host, stored as Duration (from w3c)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string UpTime
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Universally unique identity of this host (example b3d4483b-5560-9342-8309-b486c9236610). Internally generated."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12}$")]
        public string Uuid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The identity of this host within vCenter (optional)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string VcenterHostId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Commercial vendor details of this hardware."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Vendor
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.VirtualizationVmwareHost initObject = new Intersight.Model.VirtualizationVmwareHost();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BootTime"))
            {
                initObject.BootTime = this.BootTime;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Cluster"))
            {
                initObject.Cluster = this.Cluster;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ConnectionState"))
            {
                initObject.ConnectionState = this.ConnectionState;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CpuInfo"))
            {
                initObject.CpuInfo = this.CpuInfo;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DcInvPath"))
            {
                initObject.DcInvPath = this.DcInvPath;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DnsServers"))
            {
                initObject.DnsServers = this.DnsServers;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HardwareInfo"))
            {
                initObject.HardwareInfo = this.HardwareInfo;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HwPowerState"))
            {
                initObject.HwPowerState = this.HwPowerState;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HypervisorType"))
            {
                initObject.HypervisorType = this.HypervisorType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Identity"))
            {
                initObject.Identity = this.Identity;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IsSshEnabled"))
            {
                initObject.IsSshEnabled = this.IsSshEnabled;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaintenanceMode"))
            {
                initObject.MaintenanceMode = this.MaintenanceMode;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MemoryCapacity"))
            {
                initObject.MemoryCapacity = this.MemoryCapacity;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Model"))
            {
                initObject.Model = this.Model;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NetworkAdapterCount"))
            {
                initObject.NetworkAdapterCount = this.NetworkAdapterCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NtpServers"))
            {
                initObject.NtpServers = this.NtpServers;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("ProcessorCapacity"))
            {
                initObject.ProcessorCapacity = this.ProcessorCapacity;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ProductInfo"))
            {
                initObject.ProductInfo = this.ProductInfo;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("QuarantineMode"))
            {
                initObject.QuarantineMode = this.QuarantineMode;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RegisteredDevice"))
            {
                initObject.RegisteredDevice = this.RegisteredDevice;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ResourceConsumed"))
            {
                initObject.ResourceConsumed = this.ResourceConsumed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Serial"))
            {
                initObject.Serial = this.Serial;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Status"))
            {
                initObject.Status = this.Status;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("StorageAdapterCount"))
            {
                initObject.StorageAdapterCount = this.StorageAdapterCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TimeZone"))
            {
                initObject.VarTimeZone = this.TimeZone;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UpTime"))
            {
                initObject.UpTime = this.UpTime;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Uuid"))
            {
                initObject.Uuid = this.Uuid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VcenterHostId"))
            {
                initObject.VcenterHostId = this.VcenterHostId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Vendor"))
            {
                initObject.Vendor = this.Vendor;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationVmwareHostGpu.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationVmwareHostGpu")]
    public class InitializeIntersightVirtualizationVmwareHostGpu : PSCmdlet
    {
        public InitializeIntersightVirtualizationVmwareHostGpu()
        {
            ClassId = VirtualizationVmwareHostGpu.ClassIdEnum.VirtualizationVmwareHostGpu;
            ObjectType = VirtualizationVmwareHostGpu.ObjectTypeEnum.VirtualizationVmwareHostGpu;

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

        public VirtualizationVmwareHostGpu.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a virtualizationBaseCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VirtualizationBaseClusterRelationship Cluster
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The internally generated identity of this PCI device."</para>
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationVmwareHostGpu.ObjectTypeEnum ObjectType
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
            Intersight.Model.VirtualizationVmwareHostGpu initObject = new Intersight.Model.VirtualizationVmwareHostGpu();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Cluster"))
            {
                initObject.Cluster = this.Cluster;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Identity"))
            {
                initObject.Identity = this.Identity;
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
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationVmwareKernelNetwork.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationVmwareKernelNetwork")]
    public class InitializeIntersightVirtualizationVmwareKernelNetwork : PSCmdlet
    {
        public InitializeIntersightVirtualizationVmwareKernelNetwork()
        {
            ClassId = VirtualizationVmwareKernelNetwork.ClassIdEnum.VirtualizationVmwareKernelNetwork;
            ObjectType = VirtualizationVmwareKernelNetwork.ObjectTypeEnum.VirtualizationVmwareKernelNetwork;

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

        public VirtualizationVmwareKernelNetwork.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Indicates that fault tolerance logging is enabled on this kernel network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool FaultToleranceLogging
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> IpAddress
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Standard MAC address assigned to this kernel network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^([0-9A-Fa-f]{2}[:-]){5}([0-9A-Fa-f]{2})$")]
        public string MacAddress
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Indicates that management traffic is enabled on this kernel network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Management
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
        /// <para type="description">"Maximum transmission unit configured on a kernel network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Mtu
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

        public VirtualizationVmwareKernelNetwork.ObjectTypeEnum ObjectType
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
        /// <para type="description">"Subnet mask of the kernel network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SubnetMask
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
        /// <para type="description">"Type of stack for the kernel network. It can be custom, default, vMotion or provisioning."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string TcpIpStack
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Indicates that vmotion is enabled on this kernel network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Vmotion
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Indicates that vsan traffic is enabled on this kernel network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Vsan
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Indicates that vsphere provisioning traffic is enabled on this kernel network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool VsphereProvisioning
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Indicates that vsphere replication is enabled on this kernel network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool VsphereReplication
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Indicates that vsphere replication nfc is enabled on this kernel network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool VsphereReplicationNfc
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.VirtualizationVmwareKernelNetwork initObject = new Intersight.Model.VirtualizationVmwareKernelNetwork();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("FaultToleranceLogging"))
            {
                initObject.FaultToleranceLogging = this.FaultToleranceLogging;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Identity"))
            {
                initObject.Identity = this.Identity;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IpAddress"))
            {
                initObject.IpAddress = this.IpAddress;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MacAddress"))
            {
                initObject.MacAddress = this.MacAddress;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Management"))
            {
                initObject.Management = this.Management;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Mtu"))
            {
                initObject.Mtu = this.Mtu;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("SubnetMask"))
            {
                initObject.SubnetMask = this.SubnetMask;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TcpIpStack"))
            {
                initObject.TcpIpStack = this.TcpIpStack;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Vmotion"))
            {
                initObject.Vmotion = this.Vmotion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Vsan"))
            {
                initObject.Vsan = this.Vsan;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VsphereProvisioning"))
            {
                initObject.VsphereProvisioning = this.VsphereProvisioning;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VsphereReplication"))
            {
                initObject.VsphereReplication = this.VsphereReplication;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VsphereReplicationNfc"))
            {
                initObject.VsphereReplicationNfc = this.VsphereReplicationNfc;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationVmwareNetwork.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationVmwareNetwork")]
    public class InitializeIntersightVirtualizationVmwareNetwork : PSCmdlet
    {
        public InitializeIntersightVirtualizationVmwareNetwork()
        {
            ClassId = VirtualizationVmwareNetwork.ClassIdEnum.VirtualizationVmwareNetwork;
            ForgedTransmits = VirtualizationVmwareNetwork.ForgedTransmitsEnum.Reject;
            MacAddressChanges = VirtualizationVmwareNetwork.MacAddressChangesEnum.Reject;
            ObjectType = VirtualizationVmwareNetwork.ObjectTypeEnum.VirtualizationVmwareNetwork;
            PromiscuousMode = VirtualizationVmwareNetwork.PromiscuousModeEnum.Reject;

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

        public VirtualizationVmwareNetwork.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"If forgedTransmits property value is set to reject, outbound frames with source MAC address different from the one set on the adapter are dropped. If property value is set to accept, no filtering is performed and all outbound frames are passed.\n* `Reject` - Indicates that the security policy is rejected.\n* `Accept` - Indicates that the security policy is accepted."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationVmwareNetwork.ForgedTransmitsEnum ForgedTransmits
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
        /// <para type="description">"If macAddressChanges property value is set to reject and the MAC address of the adapter is changed to a value other than the one specified in .vmx configuration file, all inbound frames are dropped. If property value is set to accept and the MAC address is changed, inbound frames to the new MAC address are received.\n* `Reject` - Indicates that the security policy is rejected.\n* `Accept` - Indicates that the security policy is accepted."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationVmwareNetwork.MacAddressChangesEnum MacAddressChanges
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
        /// <para type="description">"The teams can then either share the load of traffic between physical and virtual networks among some or all of its members, or provide passive failover in the event of a hardware failure or a network outage."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VirtualizationVmwareTeamingAndFailover NicTeamingAndFailover
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationVmwareNetwork.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"If promiscuousMode property value is set to reject, incoming traffic only targeted to that network will be visible. If property value is set to accept, objects defined within the network can see all incoming traffic on the virtual switch based on the VLAN policy.\n* `Reject` - Indicates that the security policy is rejected.\n* `Accept` - Indicates that the security policy is accepted."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationVmwareNetwork.PromiscuousModeEnum PromiscuousMode
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
        // <summary>
        /// <para type="description">"VLAN id with which the network is associated. A value of 0 specifies that port is not associated with a VLAN."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long VlanId
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.VirtualizationVmwareNetwork initObject = new Intersight.Model.VirtualizationVmwareNetwork();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ForgedTransmits"))
            {
                initObject.ForgedTransmits = this.ForgedTransmits;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Identity"))
            {
                initObject.Identity = this.Identity;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MacAddressChanges"))
            {
                initObject.MacAddressChanges = this.MacAddressChanges;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NicTeamingAndFailover"))
            {
                initObject.NicTeamingAndFailover = this.NicTeamingAndFailover;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("PromiscuousMode"))
            {
                initObject.PromiscuousMode = this.PromiscuousMode;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RegisteredDevice"))
            {
                initObject.RegisteredDevice = this.RegisteredDevice;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VlanId"))
            {
                initObject.VlanId = this.VlanId;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationVmwarePhysicalNetworkInterface.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationVmwarePhysicalNetworkInterface")]
    public class InitializeIntersightVirtualizationVmwarePhysicalNetworkInterface : PSCmdlet
    {
        public InitializeIntersightVirtualizationVmwarePhysicalNetworkInterface()
        {
            ClassId = VirtualizationVmwarePhysicalNetworkInterface.ClassIdEnum.VirtualizationVmwarePhysicalNetworkInterface;
            ObjectType = VirtualizationVmwarePhysicalNetworkInterface.ObjectTypeEnum.VirtualizationVmwarePhysicalNetworkInterface;

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

        public VirtualizationVmwarePhysicalNetworkInterface.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Driver type associated with physical network interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Driver
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The internally generated identity of physical network interface. This entity cannot manipulated by users. It aids in uniquely identifying the physical network interface object. For VMware, this is MOR (managed object reference)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Identity
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Link speed of the physical network interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public int LinkSpeed
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Standard MAC address assigned to physical network interface."</para>
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
        /// <para type="description">"User-provided name to identify the physical network interface."</para>
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

        public VirtualizationVmwarePhysicalNetworkInterface.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"PCI info for physical network interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Pci
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
        /// <para type="description">"Switch associated with the physical network interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SwitchName
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
            Intersight.Model.VirtualizationVmwarePhysicalNetworkInterface initObject = new Intersight.Model.VirtualizationVmwarePhysicalNetworkInterface();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Driver"))
            {
                initObject.Driver = this.Driver;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Identity"))
            {
                initObject.Identity = this.Identity;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LinkSpeed"))
            {
                initObject.LinkSpeed = this.LinkSpeed;
            }
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Pci"))
            {
                initObject.Pci = this.Pci;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RegisteredDevice"))
            {
                initObject.RegisteredDevice = this.RegisteredDevice;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SwitchName"))
            {
                initObject.SwitchName = this.SwitchName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationVmwareProactiveHa.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationVmwareProactiveHa")]
    public class InitializeIntersightVirtualizationVmwareProactiveHa : PSCmdlet
    {
        public InitializeIntersightVirtualizationVmwareProactiveHa()
        {
            ClassId = VirtualizationVmwareProactiveHa.ClassIdEnum.VirtualizationVmwareProactiveHa;
            ObjectType = VirtualizationVmwareProactiveHa.ObjectTypeEnum.VirtualizationVmwareProactiveHa;

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

        public VirtualizationVmwareProactiveHa.ClassIdEnum ClassId
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

        public VirtualizationVmwareProactiveHa.ObjectTypeEnum ObjectType
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
            Intersight.Model.VirtualizationVmwareProactiveHa initObject = new Intersight.Model.VirtualizationVmwareProactiveHa();
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
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationVmwareRemoteDisplayInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationVmwareRemoteDisplayInfo")]
    public class InitializeIntersightVirtualizationVmwareRemoteDisplayInfo : PSCmdlet
    {
        public InitializeIntersightVirtualizationVmwareRemoteDisplayInfo()
        {
            ClassId = VirtualizationVmwareRemoteDisplayInfo.ClassIdEnum.VirtualizationVmwareRemoteDisplayInfo;
            ObjectType = VirtualizationVmwareRemoteDisplayInfo.ObjectTypeEnum.VirtualizationVmwareRemoteDisplayInfo;

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

        public VirtualizationVmwareRemoteDisplayInfo.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationVmwareRemoteDisplayInfo.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The password used for remote access. It is stored base64 encoded."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string RemoteDisplayPassword
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The access key for the remote display, potentially a long string."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string RemoteDisplayVncKey
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Applies only when remoteDisplayvnc is enabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long RemoteDisplayVncPort
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.VirtualizationVmwareRemoteDisplayInfo initObject = new Intersight.Model.VirtualizationVmwareRemoteDisplayInfo();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("RemoteDisplayPassword"))
            {
                initObject.RemoteDisplayPassword = this.RemoteDisplayPassword;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RemoteDisplayVncKey"))
            {
                initObject.RemoteDisplayVncKey = this.RemoteDisplayVncKey;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RemoteDisplayVncPort"))
            {
                initObject.RemoteDisplayVncPort = this.RemoteDisplayVncPort;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationVmwareResourceAllocationSystemTrafficTypes.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationVmwareResourceAllocationSystemTrafficTypes")]
    public class InitializeIntersightVirtualizationVmwareResourceAllocationSystemTrafficTypes : PSCmdlet
    {
        public InitializeIntersightVirtualizationVmwareResourceAllocationSystemTrafficTypes()
        {
            ClassId = VirtualizationVmwareResourceAllocationSystemTrafficTypes.ClassIdEnum.VirtualizationVmwareResourceAllocationSystemTrafficTypes;
            ObjectType = VirtualizationVmwareResourceAllocationSystemTrafficTypes.ObjectTypeEnum.VirtualizationVmwareResourceAllocationSystemTrafficTypes;
            Shares = VirtualizationVmwareResourceAllocationSystemTrafficTypes.SharesEnum.Low;

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

        public VirtualizationVmwareResourceAllocationSystemTrafficTypes.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The maximum allowed usage for a traffic class belonging to this resource pool per host physical NIC. The utilization of a traffic class will not exceed the specified limit even if there are available network resources. If this value is unset or set to -1 in an update operation, then there is no limit on the network resource usage (only bounded by available resource and shares). Units are in Mbits/sec."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Limit
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationVmwareResourceAllocationSystemTrafficTypes.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Amount of bandwidth resource that is guaranteed available to the host infrastructure traffic class. If the utilization is less than the reservation, the extra bandwidth is used for other host infrastructure traffic class types."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Reservation
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Network share. The value is used as a relative weight in competing for shared bandwidth, in case of resource contention.\n* `low` - Share of the traffic in the overall flow through a physical adapter.\n* `high` - Share of the traffic in the overall flow through a physical adapter.\n* `normal` - Share of the traffic in the overall flow through a physical adapter.\n* `custom` - Share of the traffic in the overall flow through a physical adapter."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationVmwareResourceAllocationSystemTrafficTypes.SharesEnum Shares
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of shares allocated. Used to determine resource allocation in case of resource contention. Shares value is only set if level is set to custom. If level is not set to custom, this value is ignored. Therefore, only shares with custom values can be compared."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public int SharesValue
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Key of the host infrastructure resource."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string TrafficType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.VirtualizationVmwareResourceAllocationSystemTrafficTypes initObject = new Intersight.Model.VirtualizationVmwareResourceAllocationSystemTrafficTypes();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Limit"))
            {
                initObject.Limit = this.Limit;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Reservation"))
            {
                initObject.Reservation = this.Reservation;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Shares"))
            {
                initObject.Shares = this.Shares;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SharesValue"))
            {
                initObject.SharesValue = this.SharesValue;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TrafficType"))
            {
                initObject.TrafficType = this.TrafficType;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationVmwareResourceConsumption.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationVmwareResourceConsumption")]
    public class InitializeIntersightVirtualizationVmwareResourceConsumption : PSCmdlet
    {
        public InitializeIntersightVirtualizationVmwareResourceConsumption()
        {
            ClassId = VirtualizationVmwareResourceConsumption.ClassIdEnum.VirtualizationVmwareResourceConsumption;
            ObjectType = VirtualizationVmwareResourceConsumption.ObjectTypeEnum.VirtualizationVmwareResourceConsumption;

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

        public VirtualizationVmwareResourceConsumption.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The amount of CPU consumed in Hz."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long CpuConsumed
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Memory consumed by this host in bytes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long MemoryConsumed
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationVmwareResourceConsumption.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.VirtualizationVmwareResourceConsumption initObject = new Intersight.Model.VirtualizationVmwareResourceConsumption();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("CpuConsumed"))
            {
                initObject.CpuConsumed = this.CpuConsumed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MemoryConsumed"))
            {
                initObject.MemoryConsumed = this.MemoryConsumed;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationVmwareSharesInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationVmwareSharesInfo")]
    public class InitializeIntersightVirtualizationVmwareSharesInfo : PSCmdlet
    {
        public InitializeIntersightVirtualizationVmwareSharesInfo()
        {
            ClassId = VirtualizationVmwareSharesInfo.ClassIdEnum.VirtualizationVmwareSharesInfo;
            ObjectType = VirtualizationVmwareSharesInfo.ObjectTypeEnum.VirtualizationVmwareSharesInfo;

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

        public VirtualizationVmwareSharesInfo.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The allocation level. The level is a simplified view of shares. Levels map to a pre-determined set of numeric values for shares. If the shares value does not map to a predefined size, then the level is set as custom."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Level
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationVmwareSharesInfo.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of shares allocated. It is used to determine resource allocation in case of resource contention. Set if level is custom. If level is not set to custom, this value is ignored. Therefore, only shares with custom values can be compared."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Shares
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.VirtualizationVmwareSharesInfo initObject = new Intersight.Model.VirtualizationVmwareSharesInfo();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Level"))
            {
                initObject.Level = this.Level;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Shares"))
            {
                initObject.Shares = this.Shares;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationVmwareTeamingAndFailover.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationVmwareTeamingAndFailover")]
    public class InitializeIntersightVirtualizationVmwareTeamingAndFailover : PSCmdlet
    {
        public InitializeIntersightVirtualizationVmwareTeamingAndFailover()
        {
            ClassId = VirtualizationVmwareTeamingAndFailover.ClassIdEnum.VirtualizationVmwareTeamingAndFailover;
            LoadBalancing = VirtualizationVmwareTeamingAndFailover.LoadBalancingEnum.LoadbalanceIP;
            NetworkFailureDetection = VirtualizationVmwareTeamingAndFailover.NetworkFailureDetectionEnum.LinkStatus;
            ObjectType = VirtualizationVmwareTeamingAndFailover.ObjectTypeEnum.VirtualizationVmwareTeamingAndFailover;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> ActiveAdapters
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

        public VirtualizationVmwareTeamingAndFailover.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"By default, a failback policy is enabled on a NIC team. If a failed physical NIC returns online, the network component sets the NIC back to active by replacing the standby NIC that took over its slot."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Failback
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Determines how network traffic is distributed between the network adapters in a NIC team.\n* `loadbalanceIP` - Load balance based on IP hash.\n* `loadbalanceSrcmac` - Route based on source MAC hash.\n* `loadbalanceSrcid` - Route based on originating virtual port.\n* `failoverExplicit` - Use explicit failover order.\n* `loadbalanceSrcnic` - Route based on physical NIC load."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationVmwareTeamingAndFailover.LoadBalancingEnum LoadBalancing
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the network component, example dvswitch, dvnetwork, vswitch or standard network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Methods used by network component for failover detection.\n* `linkStatus` - This option detects failures such as removed cables and physical switch power failures.\n* `beaconProbing` - Sends out and listens for beacon probes on all NICs in the team, and uses this information, in addition to link status, to determine link failure. ESXi sends beacon packets every second."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationVmwareTeamingAndFailover.NetworkFailureDetectionEnum NetworkFailureDetection
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Determines how network traffic is distributed between the network adapters in a NIC team."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool NotifySwitches
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationVmwareTeamingAndFailover.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> StandbyAdapters
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.VirtualizationVmwareTeamingAndFailover initObject = new Intersight.Model.VirtualizationVmwareTeamingAndFailover();
            if (this.MyInvocation.BoundParameters.ContainsKey("ActiveAdapters"))
            {
                initObject.ActiveAdapters = this.ActiveAdapters;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Failback"))
            {
                initObject.Failback = this.Failback;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LoadBalancing"))
            {
                initObject.LoadBalancing = this.LoadBalancing;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NetworkFailureDetection"))
            {
                initObject.NetworkFailureDetection = this.NetworkFailureDetection;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NotifySwitches"))
            {
                initObject.NotifySwitches = this.NotifySwitches;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("StandbyAdapters"))
            {
                initObject.StandbyAdapters = this.StandbyAdapters;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationVmwareUplinkPort.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationVmwareUplinkPort")]
    public class InitializeIntersightVirtualizationVmwareUplinkPort : PSCmdlet
    {
        public InitializeIntersightVirtualizationVmwareUplinkPort()
        {
            ClassId = VirtualizationVmwareUplinkPort.ClassIdEnum.VirtualizationVmwareUplinkPort;
            ObjectType = VirtualizationVmwareUplinkPort.ObjectTypeEnum.VirtualizationVmwareUplinkPort;

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

        public VirtualizationVmwareUplinkPort.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The VMware managed object reference as a string."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Identity
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The internally assigned key of this uplink port object. This entity is not manipulated by users."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Key
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
        /// <para type="description">"User-provided name to identify the uplink port object."</para>
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

        public VirtualizationVmwareUplinkPort.ObjectTypeEnum ObjectType
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
            Intersight.Model.VirtualizationVmwareUplinkPort initObject = new Intersight.Model.VirtualizationVmwareUplinkPort();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Identity"))
            {
                initObject.Identity = this.Identity;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Key"))
            {
                initObject.Key = this.Key;
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
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationVmwareVcenter.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationVmwareVcenter")]
    public class InitializeIntersightVirtualizationVmwareVcenter : PSCmdlet
    {
        public InitializeIntersightVirtualizationVmwareVcenter()
        {
            ClassId = VirtualizationVmwareVcenter.ClassIdEnum.VirtualizationVmwareVcenter;
            ObjectType = VirtualizationVmwareVcenter.ObjectTypeEnum.VirtualizationVmwareVcenter;

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

        public VirtualizationVmwareVcenter.ClassIdEnum ClassId
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
        /// <para type="description">"The user provided name for the hypervisor manager. For example, vCenterIreland. Usually, this name is subject to manipulation by the user. It is not the identity of the hypervisor."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9]+[\\sa-zA-Z0-9_-]{1,32}$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationVmwareVcenter.ObjectTypeEnum ObjectType
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
            Intersight.Model.VirtualizationVmwareVcenter initObject = new Intersight.Model.VirtualizationVmwareVcenter();
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationVmwareVirtualDisk.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationVmwareVirtualDisk")]
    public class InitializeIntersightVirtualizationVmwareVirtualDisk : PSCmdlet
    {
        public InitializeIntersightVirtualizationVmwareVirtualDisk()
        {
            ClassId = VirtualizationVmwareVirtualDisk.ClassIdEnum.VirtualizationVmwareVirtualDisk;
            CompatibilityMode = VirtualizationVmwareVirtualDisk.CompatibilityModeEnum.NotApplicable;
            DiskMode = VirtualizationVmwareVirtualDisk.DiskModeEnum.Persistent;
            DiskType = VirtualizationVmwareVirtualDisk.DiskTypeEnum.FlatDisk;
            ObjectType = VirtualizationVmwareVirtualDisk.ObjectTypeEnum.VirtualizationVmwareVirtualDisk;
            Sharing = VirtualizationVmwareVirtualDisk.SharingEnum.SharingNone;
            StorageAllocationType = VirtualizationVmwareVirtualDisk.StorageAllocationTypeEnum.NotApplicable;

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

        public VirtualizationVmwareVirtualDisk.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Compatibility mode of the raw disk mapping (RDM).\n* `notApplicable` - Value specified for any disk which is not of raw device mapping type.\n* `physicalMode` - A disk device backed by a physical compatibility mode raw disk mapping cannot use disk modes, and commands are passed straight through to the LUN indicated by the raw disk mapping.\n* `virtualMode` - A disk device backed by a virtual compatibility mode raw disk mapping can use disk modes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationVmwareVirtualDisk.CompatibilityModeEnum CompatibilityMode
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Key of the controller on which the disk is created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long ControllerKey
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Host-specific device the LUN is being accessed through. If the target LUN is not available on the host then it is empty. For example, this could happen if it has accidentally been masked out."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string DeviceName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Persistence mode of the virtual disk. For RDM disks, it is only supported when the raw disk mapping is using virtual compatibility mode.\n* `persistent` - Changes are immediately and permanently written to the virtual disk.\n* `independent_persistent` - Changes are immediately and permanently written to the virtual disk and not affected by snapshots.\n* `independent_nonpersistent` - Changes to virtual disk are made to a redo log and discarded at power off and not affected by snapshots.\n* `nonpersistent` - Changes to virtual disk are made to a redo log and discarded at power off.\n* `undoable` - Changes to virtual disk are made to a redo log and has the option to commit or undo.\n* `append` - Changes are appended to the redo log and can be revoked by removing the undo log."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationVmwareVirtualDisk.DiskModeEnum DiskMode
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Specifies whether the virtual disk is a RDM or a Hard disk.\n* `flatDisk` - Specifies that it is a flat disk.\n* `rdmDisk` - Specifies that it is a raw device mapping disk."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationVmwareVirtualDisk.DiskTypeEnum DiskType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The internally assigned key of this disk. This entity is not manipulated by users."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Key
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The utilization of a virtual machine will not exceed this limit, even if there are available resources. Used to ensure a consistent performance of virtual machines independent of available resources. If set to -1, then there is no fixed limit on resource usage (only bounded by available resources and shares). The unit is number of I/O per second."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Limit
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Unique identifier of the LUN accessed by the raw disk mapping (RDM)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string LunUuid
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

        public VirtualizationVmwareVirtualDisk.ObjectTypeEnum ObjectType
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
        /// <para type="description">"Serial ID of the storage device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Serial
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Disk shares used for resource scheduling."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VirtualizationVmwareSharesInfo Shares
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Sharing mode of the virtual disk.\n* `sharingNone` - The virtual disk is not shared.\n* `sharingMultiWriter` - The virtual disk is shared between multiple virtual machines."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationVmwareVirtualDisk.SharingEnum Sharing
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
        /// <para type="description">"Allocation type for the virtual disk.\n* `notApplicable` - Value specified for a disk for which storage allocation type is not applicable.\n* `thin` - A thin provisioned disk consumes only the space that it needs for its initial operrations, and grows with time according to demand. It is the fastest method to create a virtual disk because it creates a disk with just the header information.\n* `lazyZeroedThick` - A lazy zeroed thick disk has all space allocated at the time of its creation. Data remaining on the physical device is not erased during creation, but is zeroed out on demand later on first write from the virtual machine.\n* `eagerZeroedThick` - An eager zeroed thick disk has all space allocated and wiped clean of any previous contents on the physical media at creation time. Such disks may take longer time during creation compared to other disk formats."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationVmwareVirtualDisk.StorageAllocationTypeEnum StorageAllocationType
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
        /// <para type="description">"Unit number of the disk on its controller."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long UnitNumber
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"UUID assigned by vCenter to every disk."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12}$")]
        public string Uuid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Identity of the virtual disk object as the first class entity."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12}$")]
        public string VdiskId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Vendor of the storage device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Vendor
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Path of the virtual disk."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string VirtualDiskPath
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Identity of the virtual machine where the virtual disk is created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string VmIdentity
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.VirtualizationVmwareVirtualDisk initObject = new Intersight.Model.VirtualizationVmwareVirtualDisk();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("CompatibilityMode"))
            {
                initObject.CompatibilityMode = this.CompatibilityMode;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ControllerKey"))
            {
                initObject.ControllerKey = this.ControllerKey;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DeviceName"))
            {
                initObject.DeviceName = this.DeviceName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DiskMode"))
            {
                initObject.DiskMode = this.DiskMode;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DiskType"))
            {
                initObject.DiskType = this.DiskType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Key"))
            {
                initObject.Key = this.Key;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Limit"))
            {
                initObject.Limit = this.Limit;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LunUuid"))
            {
                initObject.LunUuid = this.LunUuid;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Serial"))
            {
                initObject.Serial = this.Serial;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Shares"))
            {
                initObject.Shares = this.Shares;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Sharing"))
            {
                initObject.Sharing = this.Sharing;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Size"))
            {
                initObject.Size = this.Size;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("StorageAllocationType"))
            {
                initObject.StorageAllocationType = this.StorageAllocationType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UnitNumber"))
            {
                initObject.UnitNumber = this.UnitNumber;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Uuid"))
            {
                initObject.Uuid = this.Uuid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VdiskId"))
            {
                initObject.VdiskId = this.VdiskId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Vendor"))
            {
                initObject.Vendor = this.Vendor;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VirtualDiskPath"))
            {
                initObject.VirtualDiskPath = this.VirtualDiskPath;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VmIdentity"))
            {
                initObject.VmIdentity = this.VmIdentity;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationVmwareVirtualMachine.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationVmwareVirtualMachine")]
    public class InitializeIntersightVirtualizationVmwareVirtualMachine : PSCmdlet
    {
        public InitializeIntersightVirtualizationVmwareVirtualMachine()
        {
            ClassId = VirtualizationVmwareVirtualMachine.ClassIdEnum.VirtualizationVmwareVirtualMachine;
            GuestState = VirtualizationVmwareVirtualMachine.GuestStateEnum.Unknown;
            HypervisorType = VirtualizationVmwareVirtualMachine.HypervisorTypeEnum.ESXi;
            ObjectType = VirtualizationVmwareVirtualMachine.ObjectTypeEnum.VirtualizationVmwareVirtualMachine;
            PowerState = VirtualizationVmwareVirtualMachine.PowerStateEnum.Unknown;
            Provider = VirtualizationVmwareVirtualMachine.ProviderEnum.Unknown;
            State = VirtualizationVmwareVirtualMachine.StateEnum.None;

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
        /// <para type="description">"List of annotations provided to this VM by user. Can be long."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Annotation
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

        public VirtualizationVmwareVirtualMachine.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The configuration name for this VM. This maybe the same as the guest hostname."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ConfigName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Shows if virtual machine is connected to vCenter. Values are Connected, Disconnected, Orphaned, Inaccessible, and Invalid."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ConnectionState
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Indicates if the capability to add CPUs to a running VM is enabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool CpuHotAddEnabled
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Shows the relative importance of a VM and its CPU limits."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VirtualizationVmwareVmCpuShareInfo CpuShares
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Details of CPUs/sockets of this VM."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VirtualizationVmwareVmCpuSocketInfo CpuSocketInfo
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> CustomAttributes
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Indicates how the VM will be powered off (soft, hard etc.)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string DefaultPowerOffType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Shows if DHCP is used for IP/DNS on this VM."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool DhcpEnabled
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Information about the virtual machine's disk commits, sharing and limits."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VirtualizationVmwareVmDiskCommitInfo DiskCommitInfo
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> DnsServerList
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> DnsSuffixList
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The folder name associated with this VM."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Folder
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
        /// <para type="description">"The state of the guest OS running on this VM. Could be running, not running etc.\n* `Unknown` - Indicates that the guest OS state cannot be determined.\n* `NotRunning` - Indicates that the guest OS is not running.\n* `Resetting` - Indicates that the guest OS is resetting.\n* `Running` - Indicates that the guest OS is running normally.\n* `ShuttingDown` - Indicates that the guest OS is shutting down.\n* `Standby` - Indicates that the guest OS is in standby mode."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationVmwareVirtualMachine.GuestStateEnum GuestState
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of hypervisor where the virtual machine is hosted for example ESXi.\n* `ESXi` - The hypervisor running on the HyperFlex cluster is a Vmware ESXi hypervisor of any version.\n* `Hyper-V` - The hypervisor running on the HyperFlex cluster is Microsoft Hyper-V.\n* `Unknown` - The hypervisor running on the HyperFlex cluster is not known."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationVmwareVirtualMachine.HypervisorTypeEnum HypervisorType
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
        /// <para type="description">"UUID assigned by vCenter to every VM."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12}$")]
        public string InstanceUuid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Inventory path to the VM. Example - /DC/vm/folder/VMName."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string InventoryPath
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
        /// <para type="description">"If true, indicates that the entity refers to a template of a virtual machine and not a real virtual machine."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool IsTemplate
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> MacAddress
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Similar to CPU Shares but applicable to memory."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VirtualizationVmwareVmMemoryShareInfo MemShares
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
        /// <para type="description">"Adding memory to a running VM."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool MemoryHotAddEnabled
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
        /// <para type="description">"Indicates how many networks are used by this VM."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long NetworkCount
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationVmwareVirtualMachine.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a virtualizationVmwareFolder resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VirtualizationVmwareFolderRelationship ParentFolder
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> PortGroups
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Power state of the virtual machine.\n* `Unknown` - The entity's power state is unknown.\n* `PoweringOn` - The entity is powering on.\n* `PoweredOn` - The entity is powered on.\n* `PoweringOff` - The entity is powering off.\n* `PoweredOff` - The entity is powered down.\n* `StandBy` - The entity is in standby mode.\n* `Paused` - The entity is in pause state.\n* `Rebooting` - The entity reboot is in progress.\n* `` - The entity's power state is not available."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationVmwareVirtualMachine.PowerStateEnum PowerState
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
        /// <para type="description">"Shows if this is a protected VM. VMs can be in protection groups."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool ProtectedVm
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Cloud platform, where the virtual machine is launched.\n* `Unknown` - Cloud provider is not known.\n* `VMwarevSphere` - Cloud provider named VMware vSphere.\n* `AmazonWebServices` - Cloud provider named Amazon Web Services.\n* `MicrosoftAzure` - Cloud provider named Microsoft Azure.\n* `GoogleCloudPlatform` - Cloud provider named Google Cloud Platform."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationVmwareVirtualMachine.ProviderEnum Provider
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
        /// <para type="description">"Applies only when remoteDisplayvnc is enabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VirtualizationVmwareRemoteDisplayInfo RemoteDisplayInfo
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Shows if support for a remote VNC access is enabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool RemoteDisplayVncEnabled
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the resource pool to which this VM belongs (optional)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ResourcePool
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Who owns the resource pool."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ResourcePoolOwner
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The parent of the current resource pool to which this VM belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ResourcePoolParent
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The current state of the virtual machine. For example, starting, stopped, etc.\n* `None` - A place holder for the default value.\n* `Creating` - Virtual machine creation is in progress.\n* `Pending` - The virtual machine is preparing to enter the started state.\n* `Starting` - The virtual machine is starting.\n* `Started` - The virtual machine is running and ready for use.\n* `Stopping` - The virtual machine is preparing to be stopped.\n* `Stopped` - The virtual machine is shut down and cannot be used. The virtual machine can be started again at any time.\n* `Pausing` - The virtual machine is preparing to be paused.\n* `Paused` - The virtual machine enters into paused state due to low free disk space.\n* `Suspending` - The virtual machine is preparing to be suspended.\n* `Suspended` - Virtual machine is in sleep mode.When a virtual machine is suspended, the current state of theoperating system, and applications is saved, and the virtual machine put into a suspended mode.\n* `Deleting` - The virtual machine is preparing to be terminated.\n* `Terminated` - The virtual machine has been permanently deleted and cannot be started.\n* `Rebooting` - The virtual machine reboot is in progress.\n* `Error` - The deployment of virtual machine is failed.\n* `Warning` - The virtual machine is in warning state."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationVmwareVirtualMachine.StateEnum State
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
        /// <para type="description">"Indicates if guest tools are running on this VM. Could be set to guestToolNotRunning or guestToolsRunning."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ToolRunningStatus
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The version of the guest tools, usually not specified."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ToolsVersion
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
        // <summary>
        /// <para type="description">"Shows the number of disks assigned to this VM."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long VmDiskCount
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The operational state of the VM. Could be Available, Provisioned, Maintenance mode, Deleting, etc."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string VmOverallStatus
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Path to the vmx file of the VM. Example - [datastore3] VCSA-134/VCSA-134.vmx."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string VmPath
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Information about the version of this VM (vmx-09, vmx-11 etc.)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string VmVersion
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"How many vnics are present."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long VmVnicCount
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Information related to the guest info's VNIC virtual device. It is a comma-separated list."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string VnicDeviceConfigId
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.VirtualizationVmwareVirtualMachine initObject = new Intersight.Model.VirtualizationVmwareVirtualMachine();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Annotation"))
            {
                initObject.Annotation = this.Annotation;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("ConfigName"))
            {
                initObject.ConfigName = this.ConfigName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ConnectionState"))
            {
                initObject.ConnectionState = this.ConnectionState;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CpuHotAddEnabled"))
            {
                initObject.CpuHotAddEnabled = this.CpuHotAddEnabled;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CpuShares"))
            {
                initObject.CpuShares = this.CpuShares;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CpuSocketInfo"))
            {
                initObject.CpuSocketInfo = this.CpuSocketInfo;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CpuUtilization"))
            {
                initObject.CpuUtilization = this.CpuUtilization;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CustomAttributes"))
            {
                initObject.CustomAttributes = this.CustomAttributes;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DefaultPowerOffType"))
            {
                initObject.DefaultPowerOffType = this.DefaultPowerOffType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DhcpEnabled"))
            {
                initObject.DhcpEnabled = this.DhcpEnabled;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DiskCommitInfo"))
            {
                initObject.DiskCommitInfo = this.DiskCommitInfo;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DnsServerList"))
            {
                initObject.DnsServerList = this.DnsServerList;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DnsSuffixList"))
            {
                initObject.DnsSuffixList = this.DnsSuffixList;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Folder"))
            {
                initObject.Folder = this.Folder;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("GuestInfo"))
            {
                initObject.GuestInfo = this.GuestInfo;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("GuestState"))
            {
                initObject.GuestState = this.GuestState;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HypervisorType"))
            {
                initObject.HypervisorType = this.HypervisorType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Identity"))
            {
                initObject.Identity = this.Identity;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InstanceUuid"))
            {
                initObject.InstanceUuid = this.InstanceUuid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InventoryPath"))
            {
                initObject.InventoryPath = this.InventoryPath;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IpAddress"))
            {
                initObject.IpAddress = this.IpAddress;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IsTemplate"))
            {
                initObject.IsTemplate = this.IsTemplate;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MacAddress"))
            {
                initObject.MacAddress = this.MacAddress;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MemShares"))
            {
                initObject.MemShares = this.MemShares;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MemoryCapacity"))
            {
                initObject.MemoryCapacity = this.MemoryCapacity;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MemoryHotAddEnabled"))
            {
                initObject.MemoryHotAddEnabled = this.MemoryHotAddEnabled;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("NetworkCount"))
            {
                initObject.NetworkCount = this.NetworkCount;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("ParentFolder"))
            {
                initObject.ParentFolder = this.ParentFolder;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PortGroups"))
            {
                initObject.PortGroups = this.PortGroups;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PowerState"))
            {
                initObject.PowerState = this.PowerState;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ProcessorCapacity"))
            {
                initObject.ProcessorCapacity = this.ProcessorCapacity;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ProtectedVm"))
            {
                initObject.ProtectedVm = this.ProtectedVm;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Provider"))
            {
                initObject.Provider = this.Provider;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RegisteredDevice"))
            {
                initObject.RegisteredDevice = this.RegisteredDevice;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RemoteDisplayInfo"))
            {
                initObject.RemoteDisplayInfo = this.RemoteDisplayInfo;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RemoteDisplayVncEnabled"))
            {
                initObject.RemoteDisplayVncEnabled = this.RemoteDisplayVncEnabled;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ResourcePool"))
            {
                initObject.ResourcePool = this.ResourcePool;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ResourcePoolOwner"))
            {
                initObject.ResourcePoolOwner = this.ResourcePoolOwner;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ResourcePoolParent"))
            {
                initObject.ResourcePoolParent = this.ResourcePoolParent;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("State"))
            {
                initObject.State = this.State;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ToolRunningStatus"))
            {
                initObject.ToolRunningStatus = this.ToolRunningStatus;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ToolsVersion"))
            {
                initObject.ToolsVersion = this.ToolsVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Uuid"))
            {
                initObject.Uuid = this.Uuid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VmCreationTime"))
            {
                initObject.VmCreationTime = this.VmCreationTime;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VmDiskCount"))
            {
                initObject.VmDiskCount = this.VmDiskCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VmOverallStatus"))
            {
                initObject.VmOverallStatus = this.VmOverallStatus;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VmPath"))
            {
                initObject.VmPath = this.VmPath;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VmVersion"))
            {
                initObject.VmVersion = this.VmVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VmVnicCount"))
            {
                initObject.VmVnicCount = this.VmVnicCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VnicDeviceConfigId"))
            {
                initObject.VnicDeviceConfigId = this.VnicDeviceConfigId;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationVmwareVirtualMachineGpu.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationVmwareVirtualMachineGpu")]
    public class InitializeIntersightVirtualizationVmwareVirtualMachineGpu : PSCmdlet
    {
        public InitializeIntersightVirtualizationVmwareVirtualMachineGpu()
        {
            ClassId = VirtualizationVmwareVirtualMachineGpu.ClassIdEnum.VirtualizationVmwareVirtualMachineGpu;
            ObjectType = VirtualizationVmwareVirtualMachineGpu.ObjectTypeEnum.VirtualizationVmwareVirtualMachineGpu;

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

        public VirtualizationVmwareVirtualMachineGpu.ClassIdEnum ClassId
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

        public VirtualizationVmwareVirtualMachineGpu.ObjectTypeEnum ObjectType
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
        // <summary>
        /// <para type="description">"A reference to a virtualizationBaseVirtualMachine resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VirtualizationBaseVirtualMachineRelationship VirtualMachine
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.VirtualizationVmwareVirtualMachineGpu initObject = new Intersight.Model.VirtualizationVmwareVirtualMachineGpu();
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
            if (this.MyInvocation.BoundParameters.ContainsKey("VirtualMachine"))
            {
                initObject.VirtualMachine = this.VirtualMachine;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationVmwareVirtualMachineSnapshot.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationVmwareVirtualMachineSnapshot")]
    public class InitializeIntersightVirtualizationVmwareVirtualMachineSnapshot : PSCmdlet
    {
        public InitializeIntersightVirtualizationVmwareVirtualMachineSnapshot()
        {
            ClassId = VirtualizationVmwareVirtualMachineSnapshot.ClassIdEnum.VirtualizationVmwareVirtualMachineSnapshot;
            ObjectType = VirtualizationVmwareVirtualMachineSnapshot.ObjectTypeEnum.VirtualizationVmwareVirtualMachineSnapshot;

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

        public VirtualizationVmwareVirtualMachineSnapshot.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Snapshot creation time. Time at which snapshot gets created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime CreationTime
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"If yes, it determines it is the latest snapshot of the virtual machine."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool CurrentSnapshot
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"User provided description of the virtual machine snapshot."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"If yes, the virtual machine snapshot cannot be deleted."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Golden
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The internally generated identity of the snapshot. This entity is not manipulated by users. It aids in uniquely identifying the snapshot object. For VMware, this is a MOR (managed object reference)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Identity
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The internally assigned id/key of virtual machine snapshot."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Key
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
        /// <para type="description">"User name provided to identify the snapshot."</para>
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

        public VirtualizationVmwareVirtualMachineSnapshot.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Predecessor id is the id of the parent snapshot."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long PredecessorId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Quiesce pauses all the I/O operations on virtual machine till the snapshot is taken."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Quiesced
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Internally assigned MOR reference value."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string RefValue
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
        /// <para type="description">"Size of the snapshot file created of the virtual machine, stored in bytes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long SnapshotSize
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
            Intersight.Model.VirtualizationVmwareVirtualMachineSnapshot initObject = new Intersight.Model.VirtualizationVmwareVirtualMachineSnapshot();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("CreationTime"))
            {
                initObject.CreationTime = this.CreationTime;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CurrentSnapshot"))
            {
                initObject.CurrentSnapshot = this.CurrentSnapshot;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Golden"))
            {
                initObject.Golden = this.Golden;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Identity"))
            {
                initObject.Identity = this.Identity;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Key"))
            {
                initObject.Key = this.Key;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("PredecessorId"))
            {
                initObject.PredecessorId = this.PredecessorId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Quiesced"))
            {
                initObject.Quiesced = this.Quiesced;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RefValue"))
            {
                initObject.RefValue = this.RefValue;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RegisteredDevice"))
            {
                initObject.RegisteredDevice = this.RegisteredDevice;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SnapshotSize"))
            {
                initObject.SnapshotSize = this.SnapshotSize;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationVmwareVirtualNetworkInterface.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationVmwareVirtualNetworkInterface")]
    public class InitializeIntersightVirtualizationVmwareVirtualNetworkInterface : PSCmdlet
    {
        public InitializeIntersightVirtualizationVmwareVirtualNetworkInterface()
        {
            ClassId = VirtualizationVmwareVirtualNetworkInterface.ClassIdEnum.VirtualizationVmwareVirtualNetworkInterface;
            MacAddressType = VirtualizationVmwareVirtualNetworkInterface.MacAddressTypeEnum.Manual;
            ObjectType = VirtualizationVmwareVirtualNetworkInterface.ObjectTypeEnum.VirtualizationVmwareVirtualNetworkInterface;

        }
        // <summary>
        /// <para type="description">"Type of virtual ethernet adapter for virtual network interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string AdapterType
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

        public VirtualizationVmwareVirtualNetworkInterface.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Connect or not to connect the device when the virtual machine starts."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool ConnectAtPowerOn
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Device is currently connected or not. Valid only while the virtual machine is running."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Connected
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The internally assigned key of this virtual network interface. This entity is not manipulated by users."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Key
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"MAC address assigned to virtual network interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^([0-9A-Fa-f]{2}[:-]){5}([0-9A-Fa-f]{2})$")]
        public string MacAddress
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"MAC address type for the mac address assigned to virtual network interface.\n* `manual` - Statically assigned MAC address.\n* `generated` - Automatically generated MAC address.\n* `assigned` - MAC address assigned by VCenter to the virtual network interface card."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationVmwareVirtualNetworkInterface.MacAddressTypeEnum MacAddressType
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
        /// <para type="description">"Name of the virtual network interface created on a virtual machine."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of network for virtual network interface. It can be either standard or distributed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string NetworkType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationVmwareVirtualNetworkInterface.ObjectTypeEnum ObjectType
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
        // <summary>
        /// <para type="description">"Identity of the virtual machine where the virtual network interface is created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string VmIdentity
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.VirtualizationVmwareVirtualNetworkInterface initObject = new Intersight.Model.VirtualizationVmwareVirtualNetworkInterface();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdapterType"))
            {
                initObject.AdapterType = this.AdapterType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ConnectAtPowerOn"))
            {
                initObject.ConnectAtPowerOn = this.ConnectAtPowerOn;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Connected"))
            {
                initObject.Connected = this.Connected;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Key"))
            {
                initObject.Key = this.Key;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MacAddress"))
            {
                initObject.MacAddress = this.MacAddress;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MacAddressType"))
            {
                initObject.MacAddressType = this.MacAddressType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NetworkType"))
            {
                initObject.NetworkType = this.NetworkType;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("VmIdentity"))
            {
                initObject.VmIdentity = this.VmIdentity;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationVmwareVirtualSwitch.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationVmwareVirtualSwitch")]
    public class InitializeIntersightVirtualizationVmwareVirtualSwitch : PSCmdlet
    {
        public InitializeIntersightVirtualizationVmwareVirtualSwitch()
        {
            ClassId = VirtualizationVmwareVirtualSwitch.ClassIdEnum.VirtualizationVmwareVirtualSwitch;
            ForgedTransmits = VirtualizationVmwareVirtualSwitch.ForgedTransmitsEnum.Reject;
            MacAddressChanges = VirtualizationVmwareVirtualSwitch.MacAddressChangesEnum.Reject;
            ObjectType = VirtualizationVmwareVirtualSwitch.ObjectTypeEnum.VirtualizationVmwareVirtualSwitch;
            PromiscuousMode = VirtualizationVmwareVirtualSwitch.PromiscuousModeEnum.Reject;

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

        public VirtualizationVmwareVirtualSwitch.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"If forgedTransmits property value is set to reject, outbound frames with a source MAC address different from the one set on the adapter are dropped. If property value is set to accept, the switch does not perform filtering and permits all outbound frames.\n* `Reject` - Indicates that the security policy is rejected.\n* `Accept` - Indicates that the security policy is accepted."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationVmwareVirtualSwitch.ForgedTransmitsEnum ForgedTransmits
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The internally generated identity of this switch. This entity is not manipulated by users. It aids in uniquely identifying the switch object. For VMware, this is MOR (managed object reference)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Identity
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"If macAddressChanges property value is set to reject and the MAC address of the adapter is changed to a value other than the one specified in .vmx configuration file, the switch drops all inbound frames to the adapter. If property value is set to accept and the MAC address is changed, the switch allows frames to the new MAC address to pass.\n* `Reject` - Indicates that the security policy is rejected.\n* `Accept` - Indicates that the security policy is accepted."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationVmwareVirtualSwitch.MacAddressChangesEnum MacAddressChanges
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
        /// <para type="description">"Maximum transmission unit configured on a virtual switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Mtu
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"User-provided name to identify the switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The teams can then either share the load of traffic between physical and virtual networks among some or all of its members, or provide passive failover in the event of a hardware failure or a network outage."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VirtualizationVmwareTeamingAndFailover NicTeamingAndFailover
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of networks available on this virtual switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long NumNetworks
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of physical network interfaces connected with this virtual switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long NumPhysicalNetworkInterfaces
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationVmwareVirtualSwitch.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"If promiscuousMode property value is set to reject, the virtual switch forwards only frames that are addressed to the adapter. If property value is set to accept, the virtual switch forwards all frames to the adapter in compliance with the active VLAN policy for the port to which it is connected.\n* `Reject` - Indicates that the security policy is rejected.\n* `Accept` - Indicates that the security policy is accepted."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationVmwareVirtualSwitch.PromiscuousModeEnum PromiscuousMode
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
            Intersight.Model.VirtualizationVmwareVirtualSwitch initObject = new Intersight.Model.VirtualizationVmwareVirtualSwitch();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ForgedTransmits"))
            {
                initObject.ForgedTransmits = this.ForgedTransmits;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Identity"))
            {
                initObject.Identity = this.Identity;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MacAddressChanges"))
            {
                initObject.MacAddressChanges = this.MacAddressChanges;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Mtu"))
            {
                initObject.Mtu = this.Mtu;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NicTeamingAndFailover"))
            {
                initObject.NicTeamingAndFailover = this.NicTeamingAndFailover;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NumNetworks"))
            {
                initObject.NumNetworks = this.NumNetworks;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NumPhysicalNetworkInterfaces"))
            {
                initObject.NumPhysicalNetworkInterfaces = this.NumPhysicalNetworkInterfaces;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("PromiscuousMode"))
            {
                initObject.PromiscuousMode = this.PromiscuousMode;
            }
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
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationVmwareVlanRange.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationVmwareVlanRange")]
    public class InitializeIntersightVirtualizationVmwareVlanRange : PSCmdlet
    {
        public InitializeIntersightVirtualizationVmwareVlanRange()
        {
            ClassId = VirtualizationVmwareVlanRange.ClassIdEnum.VirtualizationVmwareVlanRange;
            ObjectType = VirtualizationVmwareVlanRange.ObjectTypeEnum.VirtualizationVmwareVlanRange;

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

        public VirtualizationVmwareVlanRange.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationVmwareVlanRange.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"End value of VLAN range for the trunk port. The valid range is from 0 to 4094."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long VlanRangeEnd
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Start value of VLAN range for the trunk port. The valid range is from 0 to 4094."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long VlanRangeStart
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.VirtualizationVmwareVlanRange initObject = new Intersight.Model.VirtualizationVmwareVlanRange();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("VlanRangeEnd"))
            {
                initObject.VlanRangeEnd = this.VlanRangeEnd;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VlanRangeStart"))
            {
                initObject.VlanRangeStart = this.VlanRangeStart;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationVmwareVmCpuShareInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationVmwareVmCpuShareInfo")]
    public class InitializeIntersightVirtualizationVmwareVmCpuShareInfo : PSCmdlet
    {
        public InitializeIntersightVirtualizationVmwareVmCpuShareInfo()
        {
            ClassId = VirtualizationVmwareVmCpuShareInfo.ClassIdEnum.VirtualizationVmwareVmCpuShareInfo;
            ObjectType = VirtualizationVmwareVmCpuShareInfo.ObjectTypeEnum.VirtualizationVmwareVmCpuShareInfo;

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

        public VirtualizationVmwareVmCpuShareInfo.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Upper limit on CPU allocation (MHz)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long CpuLimit
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Amount of CPU for virtualization overhead."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long CpuOverheadLimit
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Guaranteed minimum allocation of CPU resource (MHz)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long CpuReservation
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Shows the relative importance of a VM. There is no unit for this value. It is a relative measure based on the settings for other resource pools. For more information, see VMware documentation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long CpuShares
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationVmwareVmCpuShareInfo.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.VirtualizationVmwareVmCpuShareInfo initObject = new Intersight.Model.VirtualizationVmwareVmCpuShareInfo();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("CpuLimit"))
            {
                initObject.CpuLimit = this.CpuLimit;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CpuOverheadLimit"))
            {
                initObject.CpuOverheadLimit = this.CpuOverheadLimit;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CpuReservation"))
            {
                initObject.CpuReservation = this.CpuReservation;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CpuShares"))
            {
                initObject.CpuShares = this.CpuShares;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationVmwareVmCpuSocketInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationVmwareVmCpuSocketInfo")]
    public class InitializeIntersightVirtualizationVmwareVmCpuSocketInfo : PSCmdlet
    {
        public InitializeIntersightVirtualizationVmwareVmCpuSocketInfo()
        {
            ClassId = VirtualizationVmwareVmCpuSocketInfo.ClassIdEnum.VirtualizationVmwareVmCpuSocketInfo;
            ObjectType = VirtualizationVmwareVmCpuSocketInfo.ObjectTypeEnum.VirtualizationVmwareVmCpuSocketInfo;

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

        public VirtualizationVmwareVmCpuSocketInfo.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of core per CPU socket (value may be empty)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long CoresPerSocket
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of CPUs allocated to this VM."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long NumCpus
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of CPU sockets allocated."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long NumSockets
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationVmwareVmCpuSocketInfo.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.VirtualizationVmwareVmCpuSocketInfo initObject = new Intersight.Model.VirtualizationVmwareVmCpuSocketInfo();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("CoresPerSocket"))
            {
                initObject.CoresPerSocket = this.CoresPerSocket;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NumCpus"))
            {
                initObject.NumCpus = this.NumCpus;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NumSockets"))
            {
                initObject.NumSockets = this.NumSockets;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationVmwareVmDiskCommitInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationVmwareVmDiskCommitInfo")]
    public class InitializeIntersightVirtualizationVmwareVmDiskCommitInfo : PSCmdlet
    {
        public InitializeIntersightVirtualizationVmwareVmDiskCommitInfo()
        {
            ClassId = VirtualizationVmwareVmDiskCommitInfo.ClassIdEnum.VirtualizationVmwareVmDiskCommitInfo;
            ObjectType = VirtualizationVmwareVmDiskCommitInfo.ObjectTypeEnum.VirtualizationVmwareVmDiskCommitInfo;

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

        public VirtualizationVmwareVmDiskCommitInfo.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Disk committed in bytes on this virtual machine (disk space used up)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long CommittedDisk
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationVmwareVmDiskCommitInfo.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Total uncommitted disk space that is available for use (in bytes)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long UnCommittedDisk
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Total unshared disk space (in bytes)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long UnsharedDisk
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.VirtualizationVmwareVmDiskCommitInfo initObject = new Intersight.Model.VirtualizationVmwareVmDiskCommitInfo();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("CommittedDisk"))
            {
                initObject.CommittedDisk = this.CommittedDisk;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("UnCommittedDisk"))
            {
                initObject.UnCommittedDisk = this.UnCommittedDisk;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UnsharedDisk"))
            {
                initObject.UnsharedDisk = this.UnsharedDisk;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationVmwareVmMemoryShareInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationVmwareVmMemoryShareInfo")]
    public class InitializeIntersightVirtualizationVmwareVmMemoryShareInfo : PSCmdlet
    {
        public InitializeIntersightVirtualizationVmwareVmMemoryShareInfo()
        {
            ClassId = VirtualizationVmwareVmMemoryShareInfo.ClassIdEnum.VirtualizationVmwareVmMemoryShareInfo;
            ObjectType = VirtualizationVmwareVmMemoryShareInfo.ObjectTypeEnum.VirtualizationVmwareVmMemoryShareInfo;

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

        public VirtualizationVmwareVmMemoryShareInfo.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Limit on the memory sharing imposed (in Mbytes)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long MemLimit
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Limit on memory overhead imposed (in Mbytes)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long MemOverheadLimit
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Similar to CPU reservations (Mbytes)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long MemReservation
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Similar to CPU Shares but applicable to memory. There is no unit for this value. It is a relative measure based on the settings for other resource pools."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long MemShares
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationVmwareVmMemoryShareInfo.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.VirtualizationVmwareVmMemoryShareInfo initObject = new Intersight.Model.VirtualizationVmwareVmMemoryShareInfo();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("MemLimit"))
            {
                initObject.MemLimit = this.MemLimit;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MemOverheadLimit"))
            {
                initObject.MemOverheadLimit = this.MemOverheadLimit;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MemReservation"))
            {
                initObject.MemReservation = this.MemReservation;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MemShares"))
            {
                initObject.MemShares = this.MemShares;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationVolumeInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationVolumeInfo")]
    public class InitializeIntersightVirtualizationVolumeInfo : PSCmdlet
    {
        public InitializeIntersightVirtualizationVolumeInfo()
        {
            ClassId = VirtualizationVolumeInfo.ClassIdEnum.VirtualizationVolumeInfo;
            ObjectType = VirtualizationVolumeInfo.ObjectTypeEnum.VirtualizationVolumeInfo;

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
        /// <para type="description">"Set to true, if the volume should be a root disk."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Bootable
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationVolumeInfo.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Set to true, to delete the volume on termination of the VM the volume is attached to."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool DeleteOnTermination
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Set to true, if the volume should be encrypted."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Encryption
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"IOPS for the volume for applicable volume types."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Iops
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VirtualizationVolumeInfo.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Order of the disk attachment to the VM."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Order
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Throughput for the volume for applicable volume types."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Throughput
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name assigned to the volume created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string VolumeName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Size of the volume created in GB."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long VolumeSize
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Id of the volume or storage type of this volume."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string VolumeType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.VirtualizationVolumeInfo initObject = new Intersight.Model.VirtualizationVolumeInfo();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Bootable"))
            {
                initObject.Bootable = this.Bootable;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("DeleteOnTermination"))
            {
                initObject.DeleteOnTermination = this.DeleteOnTermination;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Encryption"))
            {
                initObject.Encryption = this.Encryption;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Iops"))
            {
                initObject.Iops = this.Iops;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Order"))
            {
                initObject.Order = this.Order;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Throughput"))
            {
                initObject.Throughput = this.Throughput;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VolumeName"))
            {
                initObject.VolumeName = this.VolumeName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VolumeSize"))
            {
                initObject.VolumeSize = this.VolumeSize;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VolumeType"))
            {
                initObject.VolumeType = this.VolumeType;
            }
            WriteObject(initObject);
        }

    }
}