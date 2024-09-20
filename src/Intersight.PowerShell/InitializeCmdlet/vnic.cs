using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VnicArfsSettings.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicArfsSettings")]
    public class InitializeIntersightVnicArfsSettings : PSCmdlet
    {
        public InitializeIntersightVnicArfsSettings()
        {
            ClassId = VnicArfsSettings.ClassIdEnum.VnicArfsSettings;
            ObjectType = VnicArfsSettings.ObjectTypeEnum.VnicArfsSettings;

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

        public VnicArfsSettings.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Status of Accelerated Receive Flow Steering on the virtual ethernet interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Enabled
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicArfsSettings.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.VnicArfsSettings initObject = new Intersight.Model.VnicArfsSettings();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Enabled"))
            {
                initObject.Enabled = this.Enabled;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VnicCdn.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicCdn")]
    public class InitializeIntersightVnicCdn : PSCmdlet
    {
        public InitializeIntersightVnicCdn()
        {
            ClassId = VnicCdn.ClassIdEnum.VnicCdn;
            ObjectType = VnicCdn.ObjectTypeEnum.VnicCdn;
            Source = VnicCdn.SourceEnum.Vnic;

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

        public VnicCdn.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicCdn.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Source of the CDN. It can either be user specified or be the same as the vNIC name.\n* `vnic` - Source of the CDN is the same as the vNIC name.\n* `user` - Source of the CDN is specified by the user."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicCdn.SourceEnum Source
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The CDN value entered in case of user defined mode."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9\\-\\._:]*$")]
        public string Value
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.VnicCdn initObject = new Intersight.Model.VnicCdn();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Source"))
            {
                initObject.Source = this.Source;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Value"))
            {
                initObject.Value = this.Value;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VnicCompletionQueueSettings.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicCompletionQueueSettings")]
    public class InitializeIntersightVnicCompletionQueueSettings : PSCmdlet
    {
        public InitializeIntersightVnicCompletionQueueSettings()
        {
            ClassId = VnicCompletionQueueSettings.ClassIdEnum.VnicCompletionQueueSettings;
            ObjectType = VnicCompletionQueueSettings.ObjectTypeEnum.VnicCompletionQueueSettings;

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

        public VnicCompletionQueueSettings.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of completion queue resources to allocate. In general, the number of completion queue resources to allocate is equal to the number of transmit queue resources plus the number of receive queue resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 2000)]
        public long Count
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicCompletionQueueSettings.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of descriptors in each completion queue."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 256)]
        public long RingSize
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.VnicCompletionQueueSettings initObject = new Intersight.Model.VnicCompletionQueueSettings();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Count"))
            {
                initObject.Count = this.Count;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("RingSize"))
            {
                initObject.RingSize = this.RingSize;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VnicEthAdapterPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicEthAdapterPolicy")]
    public class InitializeIntersightVnicEthAdapterPolicy : PSCmdlet
    {
        public InitializeIntersightVnicEthAdapterPolicy()
        {
            ClassId = VnicEthAdapterPolicy.ClassIdEnum.VnicEthAdapterPolicy;
            ObjectType = VnicEthAdapterPolicy.ObjectTypeEnum.VnicEthAdapterPolicy;

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
        /// <para type="description">"Enables advanced filtering on the interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool AdvancedFilter
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Settings for Accelerated Receive Flow Steering to reduce the network latency and increase CPU cache efficiency."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VnicArfsSettings ArfsSettings
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicEthAdapterPolicy.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Completion Queue resource settings."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VnicCompletionQueueSettings CompletionQueueSettings
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"GENEVE offload protocol allows you to create logical networks that span physical network boundaries by allowing any information to be encoded in a packet and passed between tunnel endpoints."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool GeneveEnabled
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Enables Interrupt Scaling on the interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool InterruptScaling
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Interrupt Settings for the virtual ethernet interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VnicEthInterruptSettings InterruptSettings
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Network Virtualization using Generic Routing Encapsulation Settings."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VnicNvgreSettings NvgreSettings
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicEthAdapterPolicy.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.OrganizationOrganizationRelationship Organization
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Settings for Precision Time Protocol which can provide precise time of day information and time-stampted inputs, as well as scheduled and/or synchronized outputs for a variety of systems."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VnicPtpSettings PtpSettings
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Settings for RDMA over Converged Ethernet."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VnicRoceSettings RoceSettings
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Receive Side Scaling allows the incoming traffic to be spread across multiple CPU cores."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VnicRssHashSettings RssHashSettings
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Receive Side Scaling allows the incoming traffic to be spread across multiple CPU cores."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool RssSettings
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Receive Queue resouce settings."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VnicEthRxQueueSettings RxQueueSettings
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
        /// <para type="description">"The TCP offload settings decide whether to offload the TCP related network functions from the CPU to the network hardware or not."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VnicTcpOffloadSettings TcpOffloadSettings
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Transmit Queue resource settings."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VnicEthTxQueueSettings TxQueueSettings
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Uplink Failback Timeout in seconds when uplink failover is enabled for a vNIC. After a vNIC has started using its secondary interface, this setting controls how long the primary interface must be available before the system resumes using the primary interface for the vNIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long UplinkFailbackTimeout
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Virtual Extensible LAN Protocol Settings."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VnicVxlanSettings VxlanSettings
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.VnicEthAdapterPolicy initObject = new Intersight.Model.VnicEthAdapterPolicy();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdvancedFilter"))
            {
                initObject.AdvancedFilter = this.AdvancedFilter;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ArfsSettings"))
            {
                initObject.ArfsSettings = this.ArfsSettings;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("CompletionQueueSettings"))
            {
                initObject.CompletionQueueSettings = this.CompletionQueueSettings;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("GeneveEnabled"))
            {
                initObject.GeneveEnabled = this.GeneveEnabled;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InterruptScaling"))
            {
                initObject.InterruptScaling = this.InterruptScaling;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InterruptSettings"))
            {
                initObject.InterruptSettings = this.InterruptSettings;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NvgreSettings"))
            {
                initObject.NvgreSettings = this.NvgreSettings;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Organization"))
            {
                initObject.Organization = this.Organization;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PtpSettings"))
            {
                initObject.PtpSettings = this.PtpSettings;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RoceSettings"))
            {
                initObject.RoceSettings = this.RoceSettings;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RssHashSettings"))
            {
                initObject.RssHashSettings = this.RssHashSettings;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RssSettings"))
            {
                initObject.RssSettings = this.RssSettings;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RxQueueSettings"))
            {
                initObject.RxQueueSettings = this.RxQueueSettings;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TcpOffloadSettings"))
            {
                initObject.TcpOffloadSettings = this.TcpOffloadSettings;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TxQueueSettings"))
            {
                initObject.TxQueueSettings = this.TxQueueSettings;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UplinkFailbackTimeout"))
            {
                initObject.UplinkFailbackTimeout = this.UplinkFailbackTimeout;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VxlanSettings"))
            {
                initObject.VxlanSettings = this.VxlanSettings;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VnicEthAdapterPolicyInventory.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicEthAdapterPolicyInventory")]
    public class InitializeIntersightVnicEthAdapterPolicyInventory : PSCmdlet
    {
        public InitializeIntersightVnicEthAdapterPolicyInventory()
        {
            ClassId = VnicEthAdapterPolicyInventory.ClassIdEnum.VnicEthAdapterPolicyInventory;
            ObjectType = VnicEthAdapterPolicyInventory.ObjectTypeEnum.VnicEthAdapterPolicyInventory;

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

        public VnicEthAdapterPolicyInventory.ClassIdEnum ClassId
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

        public VnicEthAdapterPolicyInventory.ObjectTypeEnum ObjectType
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
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.VnicEthAdapterPolicyInventory initObject = new Intersight.Model.VnicEthAdapterPolicyInventory();
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
    /// <para type="synopsis">This is the cmdlet to Initialize VnicEthIf.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicEthIf")]
    public class InitializeIntersightVnicEthIf : PSCmdlet
    {
        public InitializeIntersightVnicEthIf()
        {
            ClassId = VnicEthIf.ClassIdEnum.VnicEthIf;
            MacAddressType = VnicEthIf.MacAddressTypeEnum.POOL;
            ObjectType = VnicEthIf.ObjectTypeEnum.VnicEthIf;

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
        /// <para type="description">"Consistent Device Naming configuration for the virtual NIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VnicCdn Cdn
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicEthIf.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a vnicEthAdapterPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VnicEthAdapterPolicyRelationship EthAdapterPolicy
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a vnicEthNetworkPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VnicEthNetworkPolicyRelationship EthNetworkPolicy
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a vnicEthQosPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VnicEthQosPolicyRelationship EthQosPolicy
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a fabricEthNetworkControlPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.FabricEthNetworkControlPolicyRelationship FabricEthNetworkControlPolicy
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to fabricEthNetworkGroupPolicy resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.FabricEthNetworkGroupPolicyRelationship> FabricEthNetworkGroupPolicy
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Enabling failover ensures that traffic from the vNIC automatically fails over to the secondary Fabric Interconnect, in case the specified Fabric Interconnect path goes down. Failover applies only to Cisco VICs that are connected to a Fabric Interconnect cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool FailoverEnabled
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a ippoolIpLease resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IppoolIpLeaseRelationship IpLease
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a vnicIscsiBootPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VnicIscsiBootPolicyRelationship IscsiBootPolicy
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a vnicLanConnectivityPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VnicLanConnectivityPolicyRelationship LanConnectivityPolicy
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of allocation selected to assign a MAC address for the vnic.\n* `POOL` - The user selects a pool from which the mac/wwn address will be leased for the Virtual Interface.\n* `STATIC` - The user assigns a static mac/wwn address for the Virtual Interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicEthIf.MacAddressTypeEnum MacAddressType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a macpoolLease resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.MacpoolLeaseRelationship MacLease
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a macpoolPool resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.MacpoolPoolRelationship MacPool
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
        /// <para type="description">"Name of the virtual ethernet interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9-._:]+$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicEthIf.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The order in which the virtual interface is brought up. The order assigned to an interface should be unique for all the Ethernet and Fibre-Channel interfaces on each PCI link on a VIC adapter. The order should start from zero with no overlaps. The maximum value of PCI order is limited by the number of virtual interfaces (Ethernet and Fibre-Channel) on each PCI link on a VIC adapter. All VIC adapters have a single PCI link except VIC 1340, VIC 1380 and VIC 1385 which have two."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Order
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Pingroup name associated to vNIC for static pinning. LCP deploy will resolve pingroup name and fetches the correspoding uplink port/port channel to pin the vNIC traffic."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9_.:-]{1,64}$")]
        public string PinGroupName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Placement Settings for the virtual interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VnicPlacementSettings Placement
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a policyAbstractConfigProfile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.PolicyAbstractConfigProfileRelationship Profile
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a vnicVnicTemplate resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VnicVnicTemplateRelationship SrcTemplate
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Single Root Input Output Virtualization (SR-IOV) Settings that enable one physical ethernet socket to appear as multiple NICs to the hypervisor."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VnicSriovSettings SriovSettings
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The MAC address must be in hexadecimal format xx:xx:xx:xx:xx:xx.\nTo ensure uniqueness of MACs in the LAN fabric, you are strongly encouraged to use the\nfollowing MAC prefix 00:25:B5:xx:xx:xx."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string StaticMacAddress
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

        public List<Model.MotemplateActionEntry> TemplateActions
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"User Space NIC Settings that enable low-latency and higher throughput by bypassing the kernel layer when sending/receiving packets."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VnicUsnicSettings UsnicSettings
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Virtual Machine Queue Settings for the virtual interface that allow efficient transfer of network traffic to the guest OS."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VnicVmqSettings VmqSettings
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.VnicEthIf initObject = new Intersight.Model.VnicEthIf();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Cdn"))
            {
                initObject.Cdn = this.Cdn;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("EthAdapterPolicy"))
            {
                initObject.EthAdapterPolicy = this.EthAdapterPolicy;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EthNetworkPolicy"))
            {
                initObject.EthNetworkPolicy = this.EthNetworkPolicy;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EthQosPolicy"))
            {
                initObject.EthQosPolicy = this.EthQosPolicy;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FabricEthNetworkControlPolicy"))
            {
                initObject.FabricEthNetworkControlPolicy = this.FabricEthNetworkControlPolicy;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FabricEthNetworkGroupPolicy"))
            {
                initObject.FabricEthNetworkGroupPolicy = this.FabricEthNetworkGroupPolicy;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FailoverEnabled"))
            {
                initObject.FailoverEnabled = this.FailoverEnabled;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IpLease"))
            {
                initObject.IpLease = this.IpLease;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IscsiBootPolicy"))
            {
                initObject.IscsiBootPolicy = this.IscsiBootPolicy;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LanConnectivityPolicy"))
            {
                initObject.LanConnectivityPolicy = this.LanConnectivityPolicy;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MacAddressType"))
            {
                initObject.MacAddressType = this.MacAddressType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MacLease"))
            {
                initObject.MacLease = this.MacLease;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MacPool"))
            {
                initObject.MacPool = this.MacPool;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Order"))
            {
                initObject.Order = this.Order;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PinGroupName"))
            {
                initObject.PinGroupName = this.PinGroupName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Placement"))
            {
                initObject.Placement = this.Placement;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Profile"))
            {
                initObject.Profile = this.Profile;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SrcTemplate"))
            {
                initObject.SrcTemplate = this.SrcTemplate;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SriovSettings"))
            {
                initObject.SriovSettings = this.SriovSettings;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("StaticMacAddress"))
            {
                initObject.StaticMacAddress = this.StaticMacAddress;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TemplateActions"))
            {
                initObject.TemplateActions = this.TemplateActions;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UsnicSettings"))
            {
                initObject.UsnicSettings = this.UsnicSettings;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VmqSettings"))
            {
                initObject.VmqSettings = this.VmqSettings;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VnicEthIfInventory.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicEthIfInventory")]
    public class InitializeIntersightVnicEthIfInventory : PSCmdlet
    {
        public InitializeIntersightVnicEthIfInventory()
        {
            ClassId = VnicEthIfInventory.ClassIdEnum.VnicEthIfInventory;
            ObjectType = VnicEthIfInventory.ObjectTypeEnum.VnicEthIfInventory;

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

        public VnicEthIfInventory.ClassIdEnum ClassId
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

        public VnicEthIfInventory.ObjectTypeEnum ObjectType
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
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.VnicEthIfInventory initObject = new Intersight.Model.VnicEthIfInventory();
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
    /// <para type="synopsis">This is the cmdlet to Initialize VnicEthInterruptSettings.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicEthInterruptSettings")]
    public class InitializeIntersightVnicEthInterruptSettings : PSCmdlet
    {
        public InitializeIntersightVnicEthInterruptSettings()
        {
            ClassId = VnicEthInterruptSettings.ClassIdEnum.VnicEthInterruptSettings;
            CoalescingType = VnicEthInterruptSettings.CoalescingTypeEnum.MIN;
            Mode = VnicEthInterruptSettings.ModeEnum.MSIx;
            ObjectType = VnicEthInterruptSettings.ObjectTypeEnum.VnicEthInterruptSettings;

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

        public VnicEthInterruptSettings.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The time to wait between interrupts or the idle period that must be encountered before an interrupt is sent. To turn off interrupt coalescing, enter 0 (zero) in this field."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long CoalescingTime
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Interrupt Coalescing Type. This can be one of the following:- MIN  - The system waits for the time specified in the Coalescing Time field before sending another interrupt event IDLE - The system does not send an interrupt until there is a period of no activity lasting as least as long as the time specified in the Coalescing Time field.\n* `MIN` - The system waits for the time specified in the Coalescing Time field before sending another interrupt event.\n* `IDLE` - The system does not send an interrupt until there is a period of no activity lasting as least as long as the time specified in the Coalescing Time field."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicEthInterruptSettings.CoalescingTypeEnum CoalescingType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of interrupt resources to allocate. Typical value is be equal to the number of completion queue resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 1024)]
        public long Count
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Preferred driver interrupt mode. This can be one of the following:- MSIx - Message Signaled Interrupts (MSI) with the optional extension. MSI  - MSI only. INTx - PCI INTx interrupts. MSIx is the recommended option.\n* `MSIx` - Message Signaled Interrupt (MSI) mechanism with the optional extension (MSIx). MSIx is the recommended and default option.\n* `MSI` - Message Signaled Interrupt (MSI) mechanism that treats messages as interrupts.\n* `INTx` - Line-based interrupt (INTx) mechanism similar to the one used in Legacy systems."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicEthInterruptSettings.ModeEnum Mode
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicEthInterruptSettings.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.VnicEthInterruptSettings initObject = new Intersight.Model.VnicEthInterruptSettings();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("CoalescingTime"))
            {
                initObject.CoalescingTime = this.CoalescingTime;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CoalescingType"))
            {
                initObject.CoalescingType = this.CoalescingType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Count"))
            {
                initObject.Count = this.Count;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Mode"))
            {
                initObject.Mode = this.Mode;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VnicEthNetworkPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicEthNetworkPolicy")]
    public class InitializeIntersightVnicEthNetworkPolicy : PSCmdlet
    {
        public InitializeIntersightVnicEthNetworkPolicy()
        {
            ClassId = VnicEthNetworkPolicy.ClassIdEnum.VnicEthNetworkPolicy;
            ObjectType = VnicEthNetworkPolicy.ObjectTypeEnum.VnicEthNetworkPolicy;
            TargetPlatform = VnicEthNetworkPolicy.TargetPlatformEnum.Standalone;

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

        public VnicEthNetworkPolicy.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicEthNetworkPolicy.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.OrganizationOrganizationRelationship Organization
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
        /// <para type="description">"The platform for which the server profile is applicable. It can either be a server that is operating in standalone mode or which is attached to a Fabric Interconnect managed by Intersight.\n* `Standalone` - Servers which are operating in standalone mode i.e. not connected to a Fabric Interconnected.\n* `FIAttached` - Servers which are connected to a Fabric Interconnect that is managed by Intersight."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicEthNetworkPolicy.TargetPlatformEnum TargetPlatform
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"VLAN configuration for the virtual interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VnicVlanSettings VlanSettings
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.VnicEthNetworkPolicy initObject = new Intersight.Model.VnicEthNetworkPolicy();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TargetPlatform"))
            {
                initObject.TargetPlatform = this.TargetPlatform;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VlanSettings"))
            {
                initObject.VlanSettings = this.VlanSettings;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VnicEthNetworkPolicyInventory.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicEthNetworkPolicyInventory")]
    public class InitializeIntersightVnicEthNetworkPolicyInventory : PSCmdlet
    {
        public InitializeIntersightVnicEthNetworkPolicyInventory()
        {
            ClassId = VnicEthNetworkPolicyInventory.ClassIdEnum.VnicEthNetworkPolicyInventory;
            ObjectType = VnicEthNetworkPolicyInventory.ObjectTypeEnum.VnicEthNetworkPolicyInventory;

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

        public VnicEthNetworkPolicyInventory.ClassIdEnum ClassId
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

        public VnicEthNetworkPolicyInventory.ObjectTypeEnum ObjectType
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
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.VnicEthNetworkPolicyInventory initObject = new Intersight.Model.VnicEthNetworkPolicyInventory();
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
    /// <para type="synopsis">This is the cmdlet to Initialize VnicEthQosPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicEthQosPolicy")]
    public class InitializeIntersightVnicEthQosPolicy : PSCmdlet
    {
        public InitializeIntersightVnicEthQosPolicy()
        {
            ClassId = VnicEthQosPolicy.ClassIdEnum.VnicEthQosPolicy;
            ObjectType = VnicEthQosPolicy.ObjectTypeEnum.VnicEthQosPolicy;
            Priority = VnicEthQosPolicy.PriorityEnum.BestEffort;

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
        /// <para type="description">"The burst traffic, in bytes, allowed on the vNIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 1e+06)]
        public long Burst
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicEthQosPolicy.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Class of Service to be associated to the traffic on the virtual interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Cos
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
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
        /// <para type="description">"The Maximum Transmission Unit (MTU) or packet size that the virtual interface accepts."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1500, 9000)]
        public long Mtu
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicEthQosPolicy.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.OrganizationOrganizationRelationship Organization
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The priority matching the System QoS specified in the fabric profile.\n* `Best Effort` - QoS Priority for Best-effort traffic.\n* `FC` - QoS Priority for FC traffic.\n* `Platinum` - QoS Priority for Platinum traffic.\n* `Gold` - QoS Priority for Gold traffic.\n* `Silver` - QoS Priority for Silver traffic.\n* `Bronze` - QoS Priority for Bronze traffic."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicEthQosPolicy.PriorityEnum Priority
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The value in Mbps (0-10G/40G/100G depending on Adapter Model) to use for limiting the data rate on the virtual interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long RateLimit
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
        /// <para type="description">"Enables usage of the Class of Service provided by the operating system."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool TrustHostCos
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.VnicEthQosPolicy initObject = new Intersight.Model.VnicEthQosPolicy();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Burst"))
            {
                initObject.Burst = this.Burst;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Cos"))
            {
                initObject.Cos = this.Cos;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Organization"))
            {
                initObject.Organization = this.Organization;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Priority"))
            {
                initObject.Priority = this.Priority;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RateLimit"))
            {
                initObject.RateLimit = this.RateLimit;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TrustHostCos"))
            {
                initObject.TrustHostCos = this.TrustHostCos;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VnicEthQosPolicyInventory.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicEthQosPolicyInventory")]
    public class InitializeIntersightVnicEthQosPolicyInventory : PSCmdlet
    {
        public InitializeIntersightVnicEthQosPolicyInventory()
        {
            ClassId = VnicEthQosPolicyInventory.ClassIdEnum.VnicEthQosPolicyInventory;
            ObjectType = VnicEthQosPolicyInventory.ObjectTypeEnum.VnicEthQosPolicyInventory;

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

        public VnicEthQosPolicyInventory.ClassIdEnum ClassId
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

        public VnicEthQosPolicyInventory.ObjectTypeEnum ObjectType
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
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.VnicEthQosPolicyInventory initObject = new Intersight.Model.VnicEthQosPolicyInventory();
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
    /// <para type="synopsis">This is the cmdlet to Initialize VnicEthRxQueueSettings.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicEthRxQueueSettings")]
    public class InitializeIntersightVnicEthRxQueueSettings : PSCmdlet
    {
        public InitializeIntersightVnicEthRxQueueSettings()
        {
            ClassId = VnicEthRxQueueSettings.ClassIdEnum.VnicEthRxQueueSettings;
            ObjectType = VnicEthRxQueueSettings.ObjectTypeEnum.VnicEthRxQueueSettings;

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

        public VnicEthRxQueueSettings.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of queue resources to allocate."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 1000)]
        public long Count
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicEthRxQueueSettings.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of descriptors in each queue."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(64, 16384)]
        public long RingSize
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.VnicEthRxQueueSettings initObject = new Intersight.Model.VnicEthRxQueueSettings();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Count"))
            {
                initObject.Count = this.Count;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("RingSize"))
            {
                initObject.RingSize = this.RingSize;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VnicEthTxQueueSettings.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicEthTxQueueSettings")]
    public class InitializeIntersightVnicEthTxQueueSettings : PSCmdlet
    {
        public InitializeIntersightVnicEthTxQueueSettings()
        {
            ClassId = VnicEthTxQueueSettings.ClassIdEnum.VnicEthTxQueueSettings;
            ObjectType = VnicEthTxQueueSettings.ObjectTypeEnum.VnicEthTxQueueSettings;

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

        public VnicEthTxQueueSettings.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of queue resources to allocate."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 1000)]
        public long Count
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicEthTxQueueSettings.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of descriptors in each queue."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(64, 16384)]
        public long RingSize
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.VnicEthTxQueueSettings initObject = new Intersight.Model.VnicEthTxQueueSettings();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Count"))
            {
                initObject.Count = this.Count;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("RingSize"))
            {
                initObject.RingSize = this.RingSize;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VnicEthVethInventory.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicEthVethInventory")]
    public class InitializeIntersightVnicEthVethInventory : PSCmdlet
    {
        public InitializeIntersightVnicEthVethInventory()
        {
            ClassId = VnicEthVethInventory.ClassIdEnum.VnicEthVethInventory;
            ObjectType = VnicEthVethInventory.ObjectTypeEnum.VnicEthVethInventory;

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
        /// <para type="description">"The burst traffic, in bytes, allowed on the vNIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1024, 1e+06)]
        public long Burst
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicEthVethInventory.ClassIdEnum ClassId
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

        public VnicEthVethInventory.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The value in Mbps (0-10G/40G/100G depending on Adapter Model) to use for limiting the data rate on the virtual interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long RateLimit
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
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.VnicEthVethInventory initObject = new Intersight.Model.VnicEthVethInventory();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Burst"))
            {
                initObject.Burst = this.Burst;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("RateLimit"))
            {
                initObject.RateLimit = this.RateLimit;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VnicEthVnicInventory.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicEthVnicInventory")]
    public class InitializeIntersightVnicEthVnicInventory : PSCmdlet
    {
        public InitializeIntersightVnicEthVnicInventory()
        {
            ClassId = VnicEthVnicInventory.ClassIdEnum.VnicEthVnicInventory;
            ObjectType = VnicEthVnicInventory.ObjectTypeEnum.VnicEthVnicInventory;

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

        public VnicEthVnicInventory.ClassIdEnum ClassId
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

        public VnicEthVnicInventory.ObjectTypeEnum ObjectType
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
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.VnicEthVnicInventory initObject = new Intersight.Model.VnicEthVnicInventory();
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
    /// <para type="synopsis">This is the cmdlet to Initialize VnicFcAdapterPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicFcAdapterPolicy")]
    public class InitializeIntersightVnicFcAdapterPolicy : PSCmdlet
    {
        public InitializeIntersightVnicFcAdapterPolicy()
        {
            ClassId = VnicFcAdapterPolicy.ClassIdEnum.VnicFcAdapterPolicy;
            ObjectType = VnicFcAdapterPolicy.ObjectTypeEnum.VnicFcAdapterPolicy;

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

        public VnicFcAdapterPolicy.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Error Detection Timeout, also referred to as EDTOV, is the number of milliseconds to wait before the system assumes that an error has occurred."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1000, 100000)]
        public long ErrorDetectionTimeout
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Fibre Channel Error Recovery Settings."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VnicFcErrorRecoverySettings ErrorRecoverySettings
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Fibre Channel Flogi Settings."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VnicFlogiSettings FlogiSettings
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Interrupt Settings for the virtual fibre channel interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VnicFcInterruptSettings InterruptSettings
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The maximum number of data or control I/O operations that can be pending for the virtual interface at one time. If this value is exceeded, the additional I/O operations wait in the queue until the number of pending I/O operations decreases and the additional operations can be processed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 1024)]
        public long IoThrottleCount
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The maximum number of LUNs that the Fibre Channel driver will export or show. The maximum number of LUNs is usually controlled by the operating system running on the server. Lun Count value can exceed 1024 only for vHBA of type 'FC Initiator' and on servers having supported firmware version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 4096)]
        public long LunCount
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of commands that the HBA can send and receive in a single transmission per LUN."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 254)]
        public long LunQueueDepth
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicFcAdapterPolicy.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.OrganizationOrganizationRelationship Organization
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Fibre Channel Plogi Settings."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VnicPlogiSettings PlogiSettings
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Resource Allocation Timeout, also referred to as RATOV, is the number of milliseconds to wait before the system assumes that a resource cannot be properly allocated."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(5000, 100000)]
        public long ResourceAllocationTimeout
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Fibre Channel Receive Queue Settings."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VnicFcQueueSettings RxQueueSettings
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"SCSI Input/Output Queue Settings."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VnicScsiQueueSettings ScsiQueueSettings
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
        /// <para type="description">"Fibre Channel Transmit Queue Settings."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VnicFcQueueSettings TxQueueSettings
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.VnicFcAdapterPolicy initObject = new Intersight.Model.VnicFcAdapterPolicy();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ErrorDetectionTimeout"))
            {
                initObject.ErrorDetectionTimeout = this.ErrorDetectionTimeout;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ErrorRecoverySettings"))
            {
                initObject.ErrorRecoverySettings = this.ErrorRecoverySettings;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FlogiSettings"))
            {
                initObject.FlogiSettings = this.FlogiSettings;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InterruptSettings"))
            {
                initObject.InterruptSettings = this.InterruptSettings;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IoThrottleCount"))
            {
                initObject.IoThrottleCount = this.IoThrottleCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LunCount"))
            {
                initObject.LunCount = this.LunCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LunQueueDepth"))
            {
                initObject.LunQueueDepth = this.LunQueueDepth;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("PlogiSettings"))
            {
                initObject.PlogiSettings = this.PlogiSettings;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ResourceAllocationTimeout"))
            {
                initObject.ResourceAllocationTimeout = this.ResourceAllocationTimeout;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RxQueueSettings"))
            {
                initObject.RxQueueSettings = this.RxQueueSettings;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ScsiQueueSettings"))
            {
                initObject.ScsiQueueSettings = this.ScsiQueueSettings;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TxQueueSettings"))
            {
                initObject.TxQueueSettings = this.TxQueueSettings;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VnicFcAdapterPolicyInventory.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicFcAdapterPolicyInventory")]
    public class InitializeIntersightVnicFcAdapterPolicyInventory : PSCmdlet
    {
        public InitializeIntersightVnicFcAdapterPolicyInventory()
        {
            ClassId = VnicFcAdapterPolicyInventory.ClassIdEnum.VnicFcAdapterPolicyInventory;
            ObjectType = VnicFcAdapterPolicyInventory.ObjectTypeEnum.VnicFcAdapterPolicyInventory;

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

        public VnicFcAdapterPolicyInventory.ClassIdEnum ClassId
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

        public VnicFcAdapterPolicyInventory.ObjectTypeEnum ObjectType
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
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.VnicFcAdapterPolicyInventory initObject = new Intersight.Model.VnicFcAdapterPolicyInventory();
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
    /// <para type="synopsis">This is the cmdlet to Initialize VnicFcErrorRecoverySettings.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicFcErrorRecoverySettings")]
    public class InitializeIntersightVnicFcErrorRecoverySettings : PSCmdlet
    {
        public InitializeIntersightVnicFcErrorRecoverySettings()
        {
            ClassId = VnicFcErrorRecoverySettings.ClassIdEnum.VnicFcErrorRecoverySettings;
            ObjectType = VnicFcErrorRecoverySettings.ObjectTypeEnum.VnicFcErrorRecoverySettings;

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

        public VnicFcErrorRecoverySettings.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Enables Fibre Channel Error recovery."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Enabled
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of times an I/O request to a port is retried because the port is busy before the system decides the port is unavailable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long IoRetryCount
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of seconds the adapter waits before aborting the pending command and resending the same IO request."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 59)]
        public long IoRetryTimeout
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of milliseconds the port should actually be down before it is marked down and fabric connectivity is lost."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long LinkDownTimeout
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicFcErrorRecoverySettings.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of milliseconds a remote Fibre Channel port should be offline before informing the SCSI upper layer that the port is unavailable. For a server with a VIC adapter running ESXi, the recommended value is 10000. For a server with a port used to boot a Windows OS from the SAN, the recommended value is 5000 milliseconds."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long PortDownTimeout
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.VnicFcErrorRecoverySettings initObject = new Intersight.Model.VnicFcErrorRecoverySettings();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Enabled"))
            {
                initObject.Enabled = this.Enabled;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IoRetryCount"))
            {
                initObject.IoRetryCount = this.IoRetryCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IoRetryTimeout"))
            {
                initObject.IoRetryTimeout = this.IoRetryTimeout;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LinkDownTimeout"))
            {
                initObject.LinkDownTimeout = this.LinkDownTimeout;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("PortDownTimeout"))
            {
                initObject.PortDownTimeout = this.PortDownTimeout;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VnicFcIf.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicFcIf")]
    public class InitializeIntersightVnicFcIf : PSCmdlet
    {
        public InitializeIntersightVnicFcIf()
        {
            ClassId = VnicFcIf.ClassIdEnum.VnicFcIf;
            ObjectType = VnicFcIf.ObjectTypeEnum.VnicFcIf;
            Type = VnicFcIf.TypeEnum.FcInitiator;
            WwpnAddressType = VnicFcIf.WwpnAddressTypeEnum.POOL;

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

        public VnicFcIf.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a vnicFcAdapterPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VnicFcAdapterPolicyRelationship FcAdapterPolicy
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a vnicFcNetworkPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VnicFcNetworkPolicyRelationship FcNetworkPolicy
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a vnicFcQosPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VnicFcQosPolicyRelationship FcQosPolicy
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to fabricFcZonePolicy resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.FabricFcZonePolicyRelationship> FcZonePolicies
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
        /// <para type="description">"Name of the virtual fibre channel interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9\\-\\._:]+$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicFcIf.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The order in which the virtual interface is brought up. The order assigned to an interface should be unique for all the Ethernet and Fibre-Channel interfaces on each PCI link on a VIC adapter. The order should start from zero with no overlaps. The maximum value of PCI order is limited by the number of virtual interfaces (Ethernet and Fibre-Channel) on each PCI link on a VIC adapter. All VIC adapters have a single PCI link except VIC 1340, VIC 1380 and VIC 1385 which have two."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Order
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Enables retention of LUN ID associations in memory until they are manually cleared."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool PersistentBindings
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Pingroup name associated to vfc for static pinning. SCP deploy will resolve pingroup name and fetches the correspoding uplink port/port channel to pin the vfc traffic."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9_.:-]{1,64}$")]
        public string PinGroupName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Placement Settings for the virtual interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VnicPlacementSettings Placement
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a policyAbstractConfigProfile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.PolicyAbstractConfigProfileRelationship Profile
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a vnicSanConnectivityPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VnicSanConnectivityPolicyRelationship SanConnectivityPolicy
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a vnicVhbaTemplate resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VnicVhbaTemplateRelationship SrcTemplate
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The WWPN address must be in hexadecimal format xx:xx:xx:xx:xx:xx:xx:xx.\nAllowed ranges are 20:00:00:00:00:00:00:00 to 20:FF:FF:FF:FF:FF:FF:FF or from 50:00:00:00:00:00:00:00 to 5F:FF:FF:FF:FF:FF:FF:FF.\nTo ensure uniqueness of WWN's in the SAN fabric, you are strongly encouraged to use the WWN prefix - 20:00:00:25:B5:xx:xx:xx."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|((^20|5[0-9a-fA-F]{1}):([0-9a-fA-F]{2}:){6}([0-9a-fA-F]{2})$)")]
        public string StaticWwpnAddress
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

        public List<Model.MotemplateActionEntry> TemplateActions
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"VHBA Type configuration for SAN Connectivity Policy. This configuration is supported only on Cisco VIC 14XX series and higher series of adapters.\n* `fc-initiator` - The default value set for vHBA Type Configuration. Fc-initiator specifies vHBA as a consumer of storage. Enables SCSI commands to transfer data and status information between host and target storage systems.\n* `fc-nvme-initiator` - Fc-nvme-initiator specifies vHBA as a consumer of storage. Enables NVMe-based message commands to transfer data and status information between host and target storage systems.\n* `fc-nvme-target` - Fc-nvme-target specifies vHBA as a provider of storage volumes to initiators. Enables NVMe-based message commands to transfer data and status information between host and target storage systems. Currently tech-preview, only enabled with an asynchronous driver.\n* `fc-target` - Fc-target specifies vHBA as a provider of storage volumes to initiators. Enables SCSI commands to transfer data and status information between host and target storage systems. fc-target is enabled only with an asynchronous driver."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicFcIf.TypeEnum Type
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of allocation selected to assign a WWPN address to the vhba.\n* `POOL` - The user selects a pool from which the mac/wwn address will be leased for the Virtual Interface.\n* `STATIC` - The user assigns a static mac/wwn address for the Virtual Interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicFcIf.WwpnAddressTypeEnum WwpnAddressType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a fcpoolLease resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.FcpoolLeaseRelationship WwpnLease
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a fcpoolPool resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.FcpoolPoolRelationship WwpnPool
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.VnicFcIf initObject = new Intersight.Model.VnicFcIf();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("FcAdapterPolicy"))
            {
                initObject.FcAdapterPolicy = this.FcAdapterPolicy;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FcNetworkPolicy"))
            {
                initObject.FcNetworkPolicy = this.FcNetworkPolicy;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FcQosPolicy"))
            {
                initObject.FcQosPolicy = this.FcQosPolicy;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FcZonePolicies"))
            {
                initObject.FcZonePolicies = this.FcZonePolicies;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Order"))
            {
                initObject.Order = this.Order;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PersistentBindings"))
            {
                initObject.PersistentBindings = this.PersistentBindings;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PinGroupName"))
            {
                initObject.PinGroupName = this.PinGroupName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Placement"))
            {
                initObject.Placement = this.Placement;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Profile"))
            {
                initObject.Profile = this.Profile;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SanConnectivityPolicy"))
            {
                initObject.SanConnectivityPolicy = this.SanConnectivityPolicy;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SrcTemplate"))
            {
                initObject.SrcTemplate = this.SrcTemplate;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("StaticWwpnAddress"))
            {
                initObject.StaticWwpnAddress = this.StaticWwpnAddress;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TemplateActions"))
            {
                initObject.TemplateActions = this.TemplateActions;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Type"))
            {
                initObject.Type = this.Type;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("WwpnAddressType"))
            {
                initObject.WwpnAddressType = this.WwpnAddressType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("WwpnLease"))
            {
                initObject.WwpnLease = this.WwpnLease;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("WwpnPool"))
            {
                initObject.WwpnPool = this.WwpnPool;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VnicFcIfInventory.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicFcIfInventory")]
    public class InitializeIntersightVnicFcIfInventory : PSCmdlet
    {
        public InitializeIntersightVnicFcIfInventory()
        {
            ClassId = VnicFcIfInventory.ClassIdEnum.VnicFcIfInventory;
            ObjectType = VnicFcIfInventory.ObjectTypeEnum.VnicFcIfInventory;

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

        public VnicFcIfInventory.ClassIdEnum ClassId
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

        public VnicFcIfInventory.ObjectTypeEnum ObjectType
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
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.VnicFcIfInventory initObject = new Intersight.Model.VnicFcIfInventory();
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
    /// <para type="synopsis">This is the cmdlet to Initialize VnicFcInterruptSettings.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicFcInterruptSettings")]
    public class InitializeIntersightVnicFcInterruptSettings : PSCmdlet
    {
        public InitializeIntersightVnicFcInterruptSettings()
        {
            ClassId = VnicFcInterruptSettings.ClassIdEnum.VnicFcInterruptSettings;
            Mode = VnicFcInterruptSettings.ModeEnum.MSIx;
            ObjectType = VnicFcInterruptSettings.ObjectTypeEnum.VnicFcInterruptSettings;

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

        public VnicFcInterruptSettings.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The preferred driver interrupt mode. This can be one of the following:- MSIx - Message Signaled Interrupts (MSI) with the optional extension. MSI  - MSI only. INTx - PCI INTx interrupts. MSIx is the recommended option.\n* `MSIx` - Message Signaled Interrupt (MSI) mechanism with the optional extension (MSIx). MSIx is the recommended and default option.\n* `MSI` - Message Signaled Interrupt (MSI) mechanism that treats messages as interrupts.\n* `INTx` - Line-based interrupt (INTx) mechanism similar to the one used in Legacy systems."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicFcInterruptSettings.ModeEnum Mode
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicFcInterruptSettings.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.VnicFcInterruptSettings initObject = new Intersight.Model.VnicFcInterruptSettings();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Mode"))
            {
                initObject.Mode = this.Mode;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VnicFcNetworkPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicFcNetworkPolicy")]
    public class InitializeIntersightVnicFcNetworkPolicy : PSCmdlet
    {
        public InitializeIntersightVnicFcNetworkPolicy()
        {
            ClassId = VnicFcNetworkPolicy.ClassIdEnum.VnicFcNetworkPolicy;
            ObjectType = VnicFcNetworkPolicy.ObjectTypeEnum.VnicFcNetworkPolicy;

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

        public VnicFcNetworkPolicy.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicFcNetworkPolicy.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.OrganizationOrganizationRelationship Organization
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
        /// <para type="description">"Configuration of vSAN for the virtual interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VnicVsanSettings VsanSettings
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.VnicFcNetworkPolicy initObject = new Intersight.Model.VnicFcNetworkPolicy();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VsanSettings"))
            {
                initObject.VsanSettings = this.VsanSettings;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VnicFcNetworkPolicyInventory.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicFcNetworkPolicyInventory")]
    public class InitializeIntersightVnicFcNetworkPolicyInventory : PSCmdlet
    {
        public InitializeIntersightVnicFcNetworkPolicyInventory()
        {
            ClassId = VnicFcNetworkPolicyInventory.ClassIdEnum.VnicFcNetworkPolicyInventory;
            ObjectType = VnicFcNetworkPolicyInventory.ObjectTypeEnum.VnicFcNetworkPolicyInventory;

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

        public VnicFcNetworkPolicyInventory.ClassIdEnum ClassId
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

        public VnicFcNetworkPolicyInventory.ObjectTypeEnum ObjectType
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
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.VnicFcNetworkPolicyInventory initObject = new Intersight.Model.VnicFcNetworkPolicyInventory();
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
    /// <para type="synopsis">This is the cmdlet to Initialize VnicFcQosPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicFcQosPolicy")]
    public class InitializeIntersightVnicFcQosPolicy : PSCmdlet
    {
        public InitializeIntersightVnicFcQosPolicy()
        {
            ClassId = VnicFcQosPolicy.ClassIdEnum.VnicFcQosPolicy;
            ObjectType = VnicFcQosPolicy.ObjectTypeEnum.VnicFcQosPolicy;

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
        /// <para type="description">"The burst traffic, in bytes, allowed on the vHBA."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 1e+06)]
        public long Burst
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicFcQosPolicy.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Class of Service to be associated to the traffic on the virtual interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Cos
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The maximum size of the Fibre Channel frame payload bytes that the virtual interface supports."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(256, 2112)]
        public long MaxDataFieldSize
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicFcQosPolicy.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.OrganizationOrganizationRelationship Organization
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The value in Mbps to use for limiting the data rate on the virtual interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long RateLimit
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
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.VnicFcQosPolicy initObject = new Intersight.Model.VnicFcQosPolicy();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Burst"))
            {
                initObject.Burst = this.Burst;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Cos"))
            {
                initObject.Cos = this.Cos;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaxDataFieldSize"))
            {
                initObject.MaxDataFieldSize = this.MaxDataFieldSize;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("RateLimit"))
            {
                initObject.RateLimit = this.RateLimit;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VnicFcQosPolicyInventory.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicFcQosPolicyInventory")]
    public class InitializeIntersightVnicFcQosPolicyInventory : PSCmdlet
    {
        public InitializeIntersightVnicFcQosPolicyInventory()
        {
            ClassId = VnicFcQosPolicyInventory.ClassIdEnum.VnicFcQosPolicyInventory;
            ObjectType = VnicFcQosPolicyInventory.ObjectTypeEnum.VnicFcQosPolicyInventory;

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

        public VnicFcQosPolicyInventory.ClassIdEnum ClassId
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

        public VnicFcQosPolicyInventory.ObjectTypeEnum ObjectType
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
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.VnicFcQosPolicyInventory initObject = new Intersight.Model.VnicFcQosPolicyInventory();
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
    /// <para type="synopsis">This is the cmdlet to Initialize VnicFcQueueSettings.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicFcQueueSettings")]
    public class InitializeIntersightVnicFcQueueSettings : PSCmdlet
    {
        public InitializeIntersightVnicFcQueueSettings()
        {
            ClassId = VnicFcQueueSettings.ClassIdEnum.VnicFcQueueSettings;
            ObjectType = VnicFcQueueSettings.ObjectTypeEnum.VnicFcQueueSettings;

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

        public VnicFcQueueSettings.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicFcQueueSettings.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of descriptors in each queue. The maximum value for Transmit queue is 128 and for Receive queue is 2048."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long RingSize
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.VnicFcQueueSettings initObject = new Intersight.Model.VnicFcQueueSettings();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("RingSize"))
            {
                initObject.RingSize = this.RingSize;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VnicFcVethInventory.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicFcVethInventory")]
    public class InitializeIntersightVnicFcVethInventory : PSCmdlet
    {
        public InitializeIntersightVnicFcVethInventory()
        {
            ClassId = VnicFcVethInventory.ClassIdEnum.VnicFcVethInventory;
            ObjectType = VnicFcVethInventory.ObjectTypeEnum.VnicFcVethInventory;

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
        /// <para type="description">"The burst traffic, in bytes, allowed on the vNIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1024, 1e+06)]
        public long Burst
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicFcVethInventory.ClassIdEnum ClassId
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
        /// <para type="description">"Name of the virtual FC interface."</para>
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

        public VnicFcVethInventory.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The value in Mbps to use for limiting the data rate on the virtual interface. Setting this to zero will turn rate limiting off."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long RateLimit
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
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.VnicFcVethInventory initObject = new Intersight.Model.VnicFcVethInventory();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Burst"))
            {
                initObject.Burst = this.Burst;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("RateLimit"))
            {
                initObject.RateLimit = this.RateLimit;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VnicFcVhbaPolicyInventory.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicFcVhbaPolicyInventory")]
    public class InitializeIntersightVnicFcVhbaPolicyInventory : PSCmdlet
    {
        public InitializeIntersightVnicFcVhbaPolicyInventory()
        {
            ClassId = VnicFcVhbaPolicyInventory.ClassIdEnum.VnicFcVhbaPolicyInventory;
            ObjectType = VnicFcVhbaPolicyInventory.ObjectTypeEnum.VnicFcVhbaPolicyInventory;

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

        public VnicFcVhbaPolicyInventory.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Class of Service to be associated to the traffic on the virtual interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Cos
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The maximum size of the Fibre Channel frame payload bytes that the virtual interface supports."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(256, 2112)]
        public long MaxDataFieldSize
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
        /// <para type="description">"Name of the virtual HBA interface."</para>
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

        public VnicFcVhbaPolicyInventory.ObjectTypeEnum ObjectType
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
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.VnicFcVhbaPolicyInventory initObject = new Intersight.Model.VnicFcVhbaPolicyInventory();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Cos"))
            {
                initObject.Cos = this.Cos;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaxDataFieldSize"))
            {
                initObject.MaxDataFieldSize = this.MaxDataFieldSize;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VnicFlogiSettings.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicFlogiSettings")]
    public class InitializeIntersightVnicFlogiSettings : PSCmdlet
    {
        public InitializeIntersightVnicFlogiSettings()
        {
            ClassId = VnicFlogiSettings.ClassIdEnum.VnicFlogiSettings;
            ObjectType = VnicFlogiSettings.ObjectTypeEnum.VnicFlogiSettings;

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

        public VnicFlogiSettings.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicFlogiSettings.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of times that the system tries to log in to the fabric after the first failure. Allowed range is 0-4294967295."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Retries
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of milliseconds that the system waits before it tries to log in again."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1000, 255000)]
        public long Timeout
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.VnicFlogiSettings initObject = new Intersight.Model.VnicFlogiSettings();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Retries"))
            {
                initObject.Retries = this.Retries;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Timeout"))
            {
                initObject.Timeout = this.Timeout;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VnicIscsiAdapterPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicIscsiAdapterPolicy")]
    public class InitializeIntersightVnicIscsiAdapterPolicy : PSCmdlet
    {
        public InitializeIntersightVnicIscsiAdapterPolicy()
        {
            ClassId = VnicIscsiAdapterPolicy.ClassIdEnum.VnicIscsiAdapterPolicy;
            ObjectType = VnicIscsiAdapterPolicy.ObjectTypeEnum.VnicIscsiAdapterPolicy;

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

        public VnicIscsiAdapterPolicy.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of seconds to wait until Cisco UCS assumes that the initial login has failed and the iSCSI adapter is unavailable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long ConnectionTimeOut
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of seconds to wait before the initiator assumes that the DHCP server is unavailable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(60, 300)]
        public long DhcpTimeout
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of times to retry the connection in case of a failure during iSCSI LUN discovery."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long LunBusyRetryCount
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicIscsiAdapterPolicy.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.OrganizationOrganizationRelationship Organization
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
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.VnicIscsiAdapterPolicy initObject = new Intersight.Model.VnicIscsiAdapterPolicy();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ConnectionTimeOut"))
            {
                initObject.ConnectionTimeOut = this.ConnectionTimeOut;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DhcpTimeout"))
            {
                initObject.DhcpTimeout = this.DhcpTimeout;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LunBusyRetryCount"))
            {
                initObject.LunBusyRetryCount = this.LunBusyRetryCount;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VnicIscsiAdapterPolicyInventory.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicIscsiAdapterPolicyInventory")]
    public class InitializeIntersightVnicIscsiAdapterPolicyInventory : PSCmdlet
    {
        public InitializeIntersightVnicIscsiAdapterPolicyInventory()
        {
            ClassId = VnicIscsiAdapterPolicyInventory.ClassIdEnum.VnicIscsiAdapterPolicyInventory;
            ObjectType = VnicIscsiAdapterPolicyInventory.ObjectTypeEnum.VnicIscsiAdapterPolicyInventory;

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

        public VnicIscsiAdapterPolicyInventory.ClassIdEnum ClassId
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

        public VnicIscsiAdapterPolicyInventory.ObjectTypeEnum ObjectType
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
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.VnicIscsiAdapterPolicyInventory initObject = new Intersight.Model.VnicIscsiAdapterPolicyInventory();
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
    /// <para type="synopsis">This is the cmdlet to Initialize VnicIscsiAuthProfile.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicIscsiAuthProfile")]
    public class InitializeIntersightVnicIscsiAuthProfile : PSCmdlet
    {
        public InitializeIntersightVnicIscsiAuthProfile()
        {
            ClassId = VnicIscsiAuthProfile.ClassIdEnum.VnicIscsiAuthProfile;
            ObjectType = VnicIscsiAuthProfile.ObjectTypeEnum.VnicIscsiAuthProfile;

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

        public VnicIscsiAuthProfile.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicIscsiAuthProfile.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Password of Initiator/Target Interface. Enter between 12 and 16 characters, including special characters except spaces, tabs, line breaks."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[\\S+]{12,16}$")]
        public string Password
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"User Id of Initiator/Target Interface. Enter between 1 and 128 characters, spaces, or special characters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^.{1,128}$")]
        public string UserId
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.VnicIscsiAuthProfile initObject = new Intersight.Model.VnicIscsiAuthProfile();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Password"))
            {
                initObject.Password = this.Password;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UserId"))
            {
                initObject.UserId = this.UserId;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VnicIscsiBootPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicIscsiBootPolicy")]
    public class InitializeIntersightVnicIscsiBootPolicy : PSCmdlet
    {
        public InitializeIntersightVnicIscsiBootPolicy()
        {
            ClassId = VnicIscsiBootPolicy.ClassIdEnum.VnicIscsiBootPolicy;
            InitiatorIpSource = VnicIscsiBootPolicy.InitiatorIpSourceEnum.DHCP;
            ObjectType = VnicIscsiBootPolicy.ObjectTypeEnum.VnicIscsiBootPolicy;
            TargetSourceType = VnicIscsiBootPolicy.TargetSourceTypeEnum.Static;

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
        /// <para type="description">"Auto target interface that is represented via the Initiator name or the DHCP vendor ID. The vendor ID can be up to 32 alphanumeric characters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string AutoTargetvendorName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"CHAP authentication parameters for iSCSI Target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VnicIscsiAuthProfile Chap
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicIscsiBootPolicy.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a ippoolPool resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IppoolPoolRelationship InitiatorIpPool
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Source Type of Initiator IP Address - Auto/Static/Pool.\n* `DHCP` - The IP address is assigned using DHCP, if available.\n* `Static` - Static IPv4 address is assigned to the iSCSI boot interface based on the information entered in this area.\n* `Pool` - An IPv4 address is assigned to the iSCSI boot interface from the management IP address pool."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicIscsiBootPolicy.InitiatorIpSourceEnum InitiatorIpSource
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Static IP address provided for iSCSI Initiator."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string InitiatorStaticIpV4Address
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"IPV4 configurations such as Netmask, Gateway and DNS for iSCSI Initiator."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IppoolIpV4Config InitiatorStaticIpV4Config
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a vnicIscsiAdapterPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VnicIscsiAdapterPolicyRelationship IscsiAdapterPolicy
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
        /// <para type="description">"Mutual CHAP authentication parameters for iSCSI Initiator. Two-way CHAP mechanism."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VnicIscsiAuthProfile MutualChap
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicIscsiBootPolicy.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.OrganizationOrganizationRelationship Organization
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a vnicIscsiStaticTargetPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VnicIscsiStaticTargetPolicyRelationship PrimaryTargetPolicy
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a vnicIscsiStaticTargetPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VnicIscsiStaticTargetPolicyRelationship SecondaryTargetPolicy
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
        /// <para type="description">"Source Type of Targets - Auto/Static.\n* `Static` - Type indicates that static target interface is assigned to iSCSI boot.\n* `Auto` - Type indicates that the system selects the target interface automatically during iSCSI boot."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicIscsiBootPolicy.TargetSourceTypeEnum TargetSourceType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.VnicIscsiBootPolicy initObject = new Intersight.Model.VnicIscsiBootPolicy();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AutoTargetvendorName"))
            {
                initObject.AutoTargetvendorName = this.AutoTargetvendorName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Chap"))
            {
                initObject.Chap = this.Chap;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InitiatorIpPool"))
            {
                initObject.InitiatorIpPool = this.InitiatorIpPool;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InitiatorIpSource"))
            {
                initObject.InitiatorIpSource = this.InitiatorIpSource;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InitiatorStaticIpV4Address"))
            {
                initObject.InitiatorStaticIpV4Address = this.InitiatorStaticIpV4Address;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InitiatorStaticIpV4Config"))
            {
                initObject.InitiatorStaticIpV4Config = this.InitiatorStaticIpV4Config;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IscsiAdapterPolicy"))
            {
                initObject.IscsiAdapterPolicy = this.IscsiAdapterPolicy;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MutualChap"))
            {
                initObject.MutualChap = this.MutualChap;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("PrimaryTargetPolicy"))
            {
                initObject.PrimaryTargetPolicy = this.PrimaryTargetPolicy;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SecondaryTargetPolicy"))
            {
                initObject.SecondaryTargetPolicy = this.SecondaryTargetPolicy;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TargetSourceType"))
            {
                initObject.TargetSourceType = this.TargetSourceType;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VnicIscsiBootPolicyInventory.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicIscsiBootPolicyInventory")]
    public class InitializeIntersightVnicIscsiBootPolicyInventory : PSCmdlet
    {
        public InitializeIntersightVnicIscsiBootPolicyInventory()
        {
            ClassId = VnicIscsiBootPolicyInventory.ClassIdEnum.VnicIscsiBootPolicyInventory;
            ObjectType = VnicIscsiBootPolicyInventory.ObjectTypeEnum.VnicIscsiBootPolicyInventory;

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

        public VnicIscsiBootPolicyInventory.ClassIdEnum ClassId
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

        public VnicIscsiBootPolicyInventory.ObjectTypeEnum ObjectType
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
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.VnicIscsiBootPolicyInventory initObject = new Intersight.Model.VnicIscsiBootPolicyInventory();
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
    /// <para type="synopsis">This is the cmdlet to Initialize VnicIscsiStaticTargetPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicIscsiStaticTargetPolicy")]
    public class InitializeIntersightVnicIscsiStaticTargetPolicy : PSCmdlet
    {
        public InitializeIntersightVnicIscsiStaticTargetPolicy()
        {
            ClassId = VnicIscsiStaticTargetPolicy.ClassIdEnum.VnicIscsiStaticTargetPolicy;
            ObjectType = VnicIscsiStaticTargetPolicy.ObjectTypeEnum.VnicIscsiStaticTargetPolicy;

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

        public VnicIscsiStaticTargetPolicy.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The IPv4 address assigned to the iSCSI target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$")]
        public string IpAddress
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The LUN parameters associated with an iSCSI target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VnicLun Lun
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicIscsiStaticTargetPolicy.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.OrganizationOrganizationRelationship Organization
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The port associated with the iSCSI target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 65535)]
        public long Port
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
        /// <para type="description">"Qualified Name (IQN) or Extended Unique Identifier (EUI) name of the iSCSI target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^(?:iqn\\.[0-9]{4}-[0-9]{2}(?:\\.[A-Za-z](?:[A-Za-z0-9\\-]*[A-Za-z0-9])?)+(?::.*)?|eui\\.[0-9A-Fa-f]{16})")]
        public string TargetName
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.VnicIscsiStaticTargetPolicy initObject = new Intersight.Model.VnicIscsiStaticTargetPolicy();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IpAddress"))
            {
                initObject.IpAddress = this.IpAddress;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Lun"))
            {
                initObject.Lun = this.Lun;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Port"))
            {
                initObject.Port = this.Port;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TargetName"))
            {
                initObject.TargetName = this.TargetName;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VnicIscsiStaticTargetPolicyInventory.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicIscsiStaticTargetPolicyInventory")]
    public class InitializeIntersightVnicIscsiStaticTargetPolicyInventory : PSCmdlet
    {
        public InitializeIntersightVnicIscsiStaticTargetPolicyInventory()
        {
            ClassId = VnicIscsiStaticTargetPolicyInventory.ClassIdEnum.VnicIscsiStaticTargetPolicyInventory;
            ObjectType = VnicIscsiStaticTargetPolicyInventory.ObjectTypeEnum.VnicIscsiStaticTargetPolicyInventory;

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

        public VnicIscsiStaticTargetPolicyInventory.ClassIdEnum ClassId
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

        public VnicIscsiStaticTargetPolicyInventory.ObjectTypeEnum ObjectType
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
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.VnicIscsiStaticTargetPolicyInventory initObject = new Intersight.Model.VnicIscsiStaticTargetPolicyInventory();
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
    /// <para type="synopsis">This is the cmdlet to Initialize VnicLanConnectivityPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicLanConnectivityPolicy")]
    public class InitializeIntersightVnicLanConnectivityPolicy : PSCmdlet
    {
        public InitializeIntersightVnicLanConnectivityPolicy()
        {
            ClassId = VnicLanConnectivityPolicy.ClassIdEnum.VnicLanConnectivityPolicy;
            IqnAllocationType = VnicLanConnectivityPolicy.IqnAllocationTypeEnum.None;
            ObjectType = VnicLanConnectivityPolicy.ObjectTypeEnum.VnicLanConnectivityPolicy;
            PlacementMode = VnicLanConnectivityPolicy.PlacementModeEnum.Custom;
            TargetPlatform = VnicLanConnectivityPolicy.TargetPlatformEnum.Standalone;

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
        /// <para type="description">"Enabling AzureStack-Host QoS on an adapter allows the user to carve out traffic classes for RDMA traffic which ensures that a desired portion of the bandwidth is allocated to it."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool AzureQosEnabled
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicLanConnectivityPolicy.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to vnicEthIf resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.VnicEthIfRelationship> EthIfs
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Allocation Type of iSCSI Qualified Name - Static/Pool/None.\n* `None` - Type indicates that there is no IQN associated to an interface.\n* `Static` - Type represents that static IQN is associated to an interface.\n* `Pool` - Type indicates that IQN value is sourced from an associated pool."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicLanConnectivityPolicy.IqnAllocationTypeEnum IqnAllocationType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a iqnpoolPool resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IqnpoolPoolRelationship IqnPool
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicLanConnectivityPolicy.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.OrganizationOrganizationRelationship Organization
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The mode used for placement of vNICs on network adapters. It can either be Auto or Custom.\n* `custom` - The placement of the vNICs / vHBAs on network adapters is manually chosen by the user.\n* `auto` - The placement of the vNICs / vHBAs on network adapters is automatically determined by the system."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicLanConnectivityPolicy.PlacementModeEnum PlacementMode
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to policyAbstractConfigProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.PolicyAbstractConfigProfileRelationship> Profiles
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"User provided static iSCSI Qualified Name (IQN) for use as initiator identifiers by iSCSI vNICs in a Fabric Interconnect domain."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^(?:iqn\\.[0-9]{4}-[0-9]{2}(?:\\.[A-Za-z](?:[A-Za-z0-9\\-]*[A-Za-z0-9])?)+(?::.*)?|eui\\.[0-9A-Fa-f]{16})")]
        public string StaticIqnName
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
        /// <para type="description">"The platform for which the server profile is applicable. It can either be a server that is operating in standalone mode or which is attached to a Fabric Interconnect managed by Intersight.\n* `Standalone` - Servers which are operating in standalone mode i.e. not connected to a Fabric Interconnected.\n* `FIAttached` - Servers which are connected to a Fabric Interconnect that is managed by Intersight."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicLanConnectivityPolicy.TargetPlatformEnum TargetPlatform
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.VnicLanConnectivityPolicy initObject = new Intersight.Model.VnicLanConnectivityPolicy();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AzureQosEnabled"))
            {
                initObject.AzureQosEnabled = this.AzureQosEnabled;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EthIfs"))
            {
                initObject.EthIfs = this.EthIfs;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IqnAllocationType"))
            {
                initObject.IqnAllocationType = this.IqnAllocationType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IqnPool"))
            {
                initObject.IqnPool = this.IqnPool;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("PlacementMode"))
            {
                initObject.PlacementMode = this.PlacementMode;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Profiles"))
            {
                initObject.Profiles = this.Profiles;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("StaticIqnName"))
            {
                initObject.StaticIqnName = this.StaticIqnName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TargetPlatform"))
            {
                initObject.TargetPlatform = this.TargetPlatform;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VnicLanConnectivityPolicyInventory.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicLanConnectivityPolicyInventory")]
    public class InitializeIntersightVnicLanConnectivityPolicyInventory : PSCmdlet
    {
        public InitializeIntersightVnicLanConnectivityPolicyInventory()
        {
            ClassId = VnicLanConnectivityPolicyInventory.ClassIdEnum.VnicLanConnectivityPolicyInventory;
            ObjectType = VnicLanConnectivityPolicyInventory.ObjectTypeEnum.VnicLanConnectivityPolicyInventory;

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

        public VnicLanConnectivityPolicyInventory.ClassIdEnum ClassId
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

        public VnicLanConnectivityPolicyInventory.ObjectTypeEnum ObjectType
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
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.VnicLanConnectivityPolicyInventory initObject = new Intersight.Model.VnicLanConnectivityPolicyInventory();
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
    /// <para type="synopsis">This is the cmdlet to Initialize VnicLcpStatus.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicLcpStatus")]
    public class InitializeIntersightVnicLcpStatus : PSCmdlet
    {
        public InitializeIntersightVnicLcpStatus()
        {
            ClassId = VnicLcpStatus.ClassIdEnum.VnicLcpStatus;
            ObjectType = VnicLcpStatus.ObjectTypeEnum.VnicLcpStatus;
            Status = VnicLcpStatus.StatusEnum.Ok;

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

        public VnicLcpStatus.ClassIdEnum ClassId
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

        public VnicLcpStatus.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a policyAbstractConfigProfile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.PolicyAbstractConfigProfileRelationship Profile
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The reason for the status - it will be empty if status is ok or validating. If error, it will have the appropriate message indicating the reason for failure."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Reason
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Indicates if the LCP is ready for Deploy or not.\n* `ok` - No issues with the LCP/SCP/VIF.\n* `error` - The LCP/SCP/VIF cannot be deployed due to error.\n* `validating` - Validation in progress for the LCP."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicLcpStatus.StatusEnum Status
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

        public List<Model.VnicVifStatus> VnicInfo
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.VnicLcpStatus initObject = new Intersight.Model.VnicLcpStatus();
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Profile"))
            {
                initObject.Profile = this.Profile;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Reason"))
            {
                initObject.Reason = this.Reason;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Status"))
            {
                initObject.Status = this.Status;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VnicInfo"))
            {
                initObject.VnicInfo = this.VnicInfo;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VnicLun.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicLun")]
    public class InitializeIntersightVnicLun : PSCmdlet
    {
        public InitializeIntersightVnicLun()
        {
            ClassId = VnicLun.ClassIdEnum.VnicLun;
            ObjectType = VnicLun.ObjectTypeEnum.VnicLun;

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
        /// <para type="description">"Specifies LUN is bootable."</para>
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

        public VnicLun.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Identifier of the LUN."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long LunId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicLun.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.VnicLun initObject = new Intersight.Model.VnicLun();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Bootable"))
            {
                initObject.Bootable = this.Bootable;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("LunId"))
            {
                initObject.LunId = this.LunId;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VnicNvgreSettings.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicNvgreSettings")]
    public class InitializeIntersightVnicNvgreSettings : PSCmdlet
    {
        public InitializeIntersightVnicNvgreSettings()
        {
            ClassId = VnicNvgreSettings.ClassIdEnum.VnicNvgreSettings;
            ObjectType = VnicNvgreSettings.ObjectTypeEnum.VnicNvgreSettings;

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

        public VnicNvgreSettings.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Status of the Network Virtualization using Generic Routing Encapsulation on the virtual ethernet interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Enabled
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicNvgreSettings.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.VnicNvgreSettings initObject = new Intersight.Model.VnicNvgreSettings();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Enabled"))
            {
                initObject.Enabled = this.Enabled;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VnicPlacementSettings.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicPlacementSettings")]
    public class InitializeIntersightVnicPlacementSettings : PSCmdlet
    {
        public InitializeIntersightVnicPlacementSettings()
        {
            ClassId = VnicPlacementSettings.ClassIdEnum.VnicPlacementSettings;
            ObjectType = VnicPlacementSettings.ObjectTypeEnum.VnicPlacementSettings;
            PciLinkAssignmentMode = VnicPlacementSettings.PciLinkAssignmentModeEnum.Custom;
            SwitchId = VnicPlacementSettings.SwitchIdEnum.None;

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
        /// <para type="description">"Enable or disable automatic assignment of the PCI Link in a dual-link adapter. This option applies only to 13xx series VICs that support dual-link. If enabled, the system determines the placement of the vNIC/vHBA on either of the PCI Links."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool AutoPciLink
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Enable or disable automatic assignment of the VIC slot ID. If enabled and the server has only one VIC, the same VIC is chosen for all the vNICs. If enabled and the server has multiple VICs, the vNIC/vHBA are deployed on the first VIC. The Slot ID determines the first VIC. MLOM is the first Slot ID and the ID increments to 2, 3, and so on."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool AutoSlotId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicPlacementSettings.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"PCIe Slot where the VIC adapter is installed. Supported values are (1-15) and MLOM."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|1[0-5]|MLOM)$")]
        public string Id
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicPlacementSettings.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The PCI Link used as transport for the virtual interface. PCI Link is only applicable for select Cisco UCS VIC 1300 models (UCSC-PCIE-C40Q-03, UCSB-MLOM-40G-03, UCSB-VIC-M83-8P) that support two PCI links. The value, if specified, for any other VIC model will be ignored."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long PciLink
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"If the autoPciLink is disabled, the user can either choose to place the vNICs manually or based on a policy.If the autoPciLink is enabled, it will be set to None.\n* `Custom` - The user needs to specify the PCI Link manually.\n* `Load-Balanced` - The system will uniformly distribute the interfaces across the PCI Links.\n* `None` - Assignment is not applicable and will be set when the AutoPciLink is set to true."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicPlacementSettings.PciLinkAssignmentModeEnum PciLinkAssignmentMode
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fabric port to which the vNICs will be associated.\n* `None` - Fabric Id is not set to either A or B for the standalone case where the server is not connected to Fabric Interconnects. The value 'None' should be used.\n* `A` - Fabric A of the FI cluster.\n* `B` - Fabric B of the FI cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicPlacementSettings.SwitchIdEnum SwitchId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Adapter port on which the virtual interface will be created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Uplink
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.VnicPlacementSettings initObject = new Intersight.Model.VnicPlacementSettings();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AutoPciLink"))
            {
                initObject.AutoPciLink = this.AutoPciLink;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AutoSlotId"))
            {
                initObject.AutoSlotId = this.AutoSlotId;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Id"))
            {
                initObject.Id = this.Id;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("PciLink"))
            {
                initObject.PciLink = this.PciLink;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PciLinkAssignmentMode"))
            {
                initObject.PciLinkAssignmentMode = this.PciLinkAssignmentMode;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SwitchId"))
            {
                initObject.SwitchId = this.SwitchId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Uplink"))
            {
                initObject.Uplink = this.Uplink;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VnicPlogiSettings.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicPlogiSettings")]
    public class InitializeIntersightVnicPlogiSettings : PSCmdlet
    {
        public InitializeIntersightVnicPlogiSettings()
        {
            ClassId = VnicPlogiSettings.ClassIdEnum.VnicPlogiSettings;
            ObjectType = VnicPlogiSettings.ObjectTypeEnum.VnicPlogiSettings;

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

        public VnicPlogiSettings.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicPlogiSettings.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of times that the system tries to log in to a port after the first failure."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Retries
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of milliseconds that the system waits before it tries to log in again."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1000, 255000)]
        public long Timeout
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.VnicPlogiSettings initObject = new Intersight.Model.VnicPlogiSettings();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Retries"))
            {
                initObject.Retries = this.Retries;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Timeout"))
            {
                initObject.Timeout = this.Timeout;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VnicPtpSettings.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicPtpSettings")]
    public class InitializeIntersightVnicPtpSettings : PSCmdlet
    {
        public InitializeIntersightVnicPtpSettings()
        {
            ClassId = VnicPtpSettings.ClassIdEnum.VnicPtpSettings;
            ObjectType = VnicPtpSettings.ObjectTypeEnum.VnicPtpSettings;

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

        public VnicPtpSettings.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Status of Precision Time Protocol (PTP) on the virtual ethernet interface. PTP can be enabled only on one vNIC on an adapter."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Enabled
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicPtpSettings.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.VnicPtpSettings initObject = new Intersight.Model.VnicPtpSettings();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Enabled"))
            {
                initObject.Enabled = this.Enabled;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VnicRoceSettings.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicRoceSettings")]
    public class InitializeIntersightVnicRoceSettings : PSCmdlet
    {
        public InitializeIntersightVnicRoceSettings()
        {
            ClassId = VnicRoceSettings.ClassIdEnum.VnicRoceSettings;
            ClassOfService = VnicRoceSettings.ClassOfServiceEnum.NUMBER_5;
            ObjectType = VnicRoceSettings.ObjectTypeEnum.VnicRoceSettings;
            Version = VnicRoceSettings.VarVersionEnum.NUMBER_1;

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

        public VnicRoceSettings.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Class of Service for RoCE on this virtual interface.\n* `5` - RDMA CoS Service Level 5.\n* `1` - RDMA CoS Service Level 1.\n* `2` - RDMA CoS Service Level 2.\n* `4` - RDMA CoS Service Level 4.\n* `6` - RDMA CoS Service Level 6."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicRoceSettings.ClassOfServiceEnum ClassOfService
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"If enabled sets RDMA over Converged Ethernet (RoCE) on this virtual interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Enabled
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of memory regions per adapter. Recommended value = integer power of 2."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long MemoryRegions
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicRoceSettings.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of queue pairs per adapter. Recommended value = integer power of 2."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long QueuePairs
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of resource groups per adapter. Recommended value = be an integer power of 2 greater than or equal to the number of CPU cores on the system for optimum performance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long ResourceGroups
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Configure RDMA over Converged Ethernet (RoCE) version on the virtual interface. Only RoCEv1 is supported on Cisco VIC 13xx series adapters and only RoCEv2 is supported on Cisco VIC 14xx series adapters.\n* `1` - RDMA over Converged Ethernet Protocol Version 1.\n* `2` - RDMA over Converged Ethernet Protocol Version 2."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicRoceSettings.VarVersionEnum Version
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.VnicRoceSettings initObject = new Intersight.Model.VnicRoceSettings();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ClassOfService"))
            {
                initObject.ClassOfService = this.ClassOfService;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Enabled"))
            {
                initObject.Enabled = this.Enabled;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MemoryRegions"))
            {
                initObject.MemoryRegions = this.MemoryRegions;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("QueuePairs"))
            {
                initObject.QueuePairs = this.QueuePairs;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ResourceGroups"))
            {
                initObject.ResourceGroups = this.ResourceGroups;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Version"))
            {
                initObject.VarVersion = this.Version;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VnicRssHashSettings.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicRssHashSettings")]
    public class InitializeIntersightVnicRssHashSettings : PSCmdlet
    {
        public InitializeIntersightVnicRssHashSettings()
        {
            ClassId = VnicRssHashSettings.ClassIdEnum.VnicRssHashSettings;
            ObjectType = VnicRssHashSettings.ObjectTypeEnum.VnicRssHashSettings;

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

        public VnicRssHashSettings.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"When enabled, the IPv4 address is used for traffic distribution."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Ipv4Hash
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"When enabled, the IPv6 extensions are used for traffic distribution."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Ipv6ExtHash
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"When enabled, the IPv6 address is used for traffic distribution."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Ipv6Hash
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicRssHashSettings.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"When enabled, both the IPv4 address and TCP port number are used for traffic distribution."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool TcpIpv4Hash
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"When enabled, both the IPv6 extensions and TCP port number are used for traffic distribution."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool TcpIpv6ExtHash
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"When enabled, both the IPv6 address and TCP port number are used for traffic distribution."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool TcpIpv6Hash
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"When enabled, both the IPv4 address and UDP port number are used for traffic distribution."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool UdpIpv4Hash
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"When enabled, both the IPv6 address and UDP port number are used for traffic distribution."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool UdpIpv6Hash
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.VnicRssHashSettings initObject = new Intersight.Model.VnicRssHashSettings();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Ipv4Hash"))
            {
                initObject.Ipv4Hash = this.Ipv4Hash;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Ipv6ExtHash"))
            {
                initObject.Ipv6ExtHash = this.Ipv6ExtHash;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Ipv6Hash"))
            {
                initObject.Ipv6Hash = this.Ipv6Hash;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("TcpIpv4Hash"))
            {
                initObject.TcpIpv4Hash = this.TcpIpv4Hash;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TcpIpv6ExtHash"))
            {
                initObject.TcpIpv6ExtHash = this.TcpIpv6ExtHash;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TcpIpv6Hash"))
            {
                initObject.TcpIpv6Hash = this.TcpIpv6Hash;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UdpIpv4Hash"))
            {
                initObject.UdpIpv4Hash = this.UdpIpv4Hash;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UdpIpv6Hash"))
            {
                initObject.UdpIpv6Hash = this.UdpIpv6Hash;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VnicSanConnectivityPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicSanConnectivityPolicy")]
    public class InitializeIntersightVnicSanConnectivityPolicy : PSCmdlet
    {
        public InitializeIntersightVnicSanConnectivityPolicy()
        {
            ClassId = VnicSanConnectivityPolicy.ClassIdEnum.VnicSanConnectivityPolicy;
            ObjectType = VnicSanConnectivityPolicy.ObjectTypeEnum.VnicSanConnectivityPolicy;
            PlacementMode = VnicSanConnectivityPolicy.PlacementModeEnum.Custom;
            TargetPlatform = VnicSanConnectivityPolicy.TargetPlatformEnum.Standalone;
            WwnnAddressType = VnicSanConnectivityPolicy.WwnnAddressTypeEnum.POOL;

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

        public VnicSanConnectivityPolicy.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to vnicFcIf resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.VnicFcIfRelationship> FcIfs
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicSanConnectivityPolicy.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.OrganizationOrganizationRelationship Organization
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The mode used for placement of vNICs on network adapters. It can either be Auto or Custom.\n* `custom` - The placement of the vNICs / vHBAs on network adapters is manually chosen by the user.\n* `auto` - The placement of the vNICs / vHBAs on network adapters is automatically determined by the system."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicSanConnectivityPolicy.PlacementModeEnum PlacementMode
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to policyAbstractConfigProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.PolicyAbstractConfigProfileRelationship> Profiles
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The WWNN address for the server node must be in hexadecimal format xx:xx:xx:xx:xx:xx:xx:xx.\nAllowed ranges are 20:00:00:00:00:00:00:00 to 20:FF:FF:FF:FF:FF:FF:FF or from 50:00:00:00:00:00:00:00 to 5F:FF:FF:FF:FF:FF:FF:FF.\nTo ensure uniqueness of WWN's in the SAN fabric, you are strongly encouraged to use the WWN prefix - 20:00:00:25:B5:xx:xx:xx."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|((^20|5[0-9a-fA-F]{1}):([0-9a-fA-F]{2}:){6}([0-9a-fA-F]{2})$)")]
        public string StaticWwnnAddress
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
        /// <para type="description">"The platform for which the server profile is applicable. It can either be a server that is operating in standalone mode or which is attached to a Fabric Interconnect managed by Intersight.\n* `Standalone` - Servers which are operating in standalone mode i.e. not connected to a Fabric Interconnected.\n* `FIAttached` - Servers which are connected to a Fabric Interconnect that is managed by Intersight."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicSanConnectivityPolicy.TargetPlatformEnum TargetPlatform
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of allocation selected to assign a WWNN address for the server node.\n* `POOL` - The user selects a pool from which the mac/wwn address will be leased for the Virtual Interface.\n* `STATIC` - The user assigns a static mac/wwn address for the Virtual Interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicSanConnectivityPolicy.WwnnAddressTypeEnum WwnnAddressType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a fcpoolPool resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.FcpoolPoolRelationship WwnnPool
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.VnicSanConnectivityPolicy initObject = new Intersight.Model.VnicSanConnectivityPolicy();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FcIfs"))
            {
                initObject.FcIfs = this.FcIfs;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("PlacementMode"))
            {
                initObject.PlacementMode = this.PlacementMode;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Profiles"))
            {
                initObject.Profiles = this.Profiles;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("StaticWwnnAddress"))
            {
                initObject.StaticWwnnAddress = this.StaticWwnnAddress;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TargetPlatform"))
            {
                initObject.TargetPlatform = this.TargetPlatform;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("WwnnAddressType"))
            {
                initObject.WwnnAddressType = this.WwnnAddressType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("WwnnPool"))
            {
                initObject.WwnnPool = this.WwnnPool;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VnicSanConnectivityPolicyInventory.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicSanConnectivityPolicyInventory")]
    public class InitializeIntersightVnicSanConnectivityPolicyInventory : PSCmdlet
    {
        public InitializeIntersightVnicSanConnectivityPolicyInventory()
        {
            ClassId = VnicSanConnectivityPolicyInventory.ClassIdEnum.VnicSanConnectivityPolicyInventory;
            ObjectType = VnicSanConnectivityPolicyInventory.ObjectTypeEnum.VnicSanConnectivityPolicyInventory;

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

        public VnicSanConnectivityPolicyInventory.ClassIdEnum ClassId
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

        public VnicSanConnectivityPolicyInventory.ObjectTypeEnum ObjectType
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
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.VnicSanConnectivityPolicyInventory initObject = new Intersight.Model.VnicSanConnectivityPolicyInventory();
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
    /// <para type="synopsis">This is the cmdlet to Initialize VnicScpStatus.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicScpStatus")]
    public class InitializeIntersightVnicScpStatus : PSCmdlet
    {
        public InitializeIntersightVnicScpStatus()
        {
            ClassId = VnicScpStatus.ClassIdEnum.VnicScpStatus;
            ObjectType = VnicScpStatus.ObjectTypeEnum.VnicScpStatus;
            Status = VnicScpStatus.StatusEnum.Ok;

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

        public VnicScpStatus.ClassIdEnum ClassId
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

        public VnicScpStatus.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a policyAbstractConfigProfile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.PolicyAbstractConfigProfileRelationship Profile
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The reason for the status - it will be empty if status is ok or validating. If error, it will have the appropriate message indicating the reason for failure."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Reason
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Indicates if the LCP is ready for Deploy or not.\n* `ok` - No issues with the LCP/SCP/VIF.\n* `error` - The LCP/SCP/VIF cannot be deployed due to error.\n* `validating` - Validation in progress for the LCP."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicScpStatus.StatusEnum Status
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

        public List<Model.VnicVifStatus> VhbaInfo
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.VnicScpStatus initObject = new Intersight.Model.VnicScpStatus();
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Profile"))
            {
                initObject.Profile = this.Profile;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Reason"))
            {
                initObject.Reason = this.Reason;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Status"))
            {
                initObject.Status = this.Status;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VhbaInfo"))
            {
                initObject.VhbaInfo = this.VhbaInfo;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VnicScsiQueueSettings.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicScsiQueueSettings")]
    public class InitializeIntersightVnicScsiQueueSettings : PSCmdlet
    {
        public InitializeIntersightVnicScsiQueueSettings()
        {
            ClassId = VnicScsiQueueSettings.ClassIdEnum.VnicScsiQueueSettings;
            ObjectType = VnicScsiQueueSettings.ObjectTypeEnum.VnicScsiQueueSettings;

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

        public VnicScsiQueueSettings.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of SCSI I/O queue resources the system should allocate."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 245)]
        public long Count
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicScsiQueueSettings.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of descriptors in each SCSI I/O queue."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(64, 512)]
        public long RingSize
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.VnicScsiQueueSettings initObject = new Intersight.Model.VnicScsiQueueSettings();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Count"))
            {
                initObject.Count = this.Count;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("RingSize"))
            {
                initObject.RingSize = this.RingSize;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VnicSriovSettings.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicSriovSettings")]
    public class InitializeIntersightVnicSriovSettings : PSCmdlet
    {
        public InitializeIntersightVnicSriovSettings()
        {
            ClassId = VnicSriovSettings.ClassIdEnum.VnicSriovSettings;
            ObjectType = VnicSriovSettings.ObjectTypeEnum.VnicSriovSettings;

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

        public VnicSriovSettings.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Completion Queue resources per Virtual Function (VF)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 16)]
        public long CompCountPerVf
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"If enabled, sets Single Root Input Output Virtualization (SR-IOV) on this vNIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Enabled
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Interrupt Count resources per Virtual Function (VF)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 16)]
        public long IntCountPerVf
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicSriovSettings.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Receive Queue resources per Virtual Function (VF)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 8)]
        public long RxCountPerVf
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Transmit Queue resources per Virtual Function (VF)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 8)]
        public long TxCountPerVf
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of Virtual Functions (VF) to be created for this vNIC. Valid values are 1 to 64 when SR-IOV is enabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 64)]
        public long VfCount
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.VnicSriovSettings initObject = new Intersight.Model.VnicSriovSettings();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("CompCountPerVf"))
            {
                initObject.CompCountPerVf = this.CompCountPerVf;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Enabled"))
            {
                initObject.Enabled = this.Enabled;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IntCountPerVf"))
            {
                initObject.IntCountPerVf = this.IntCountPerVf;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("RxCountPerVf"))
            {
                initObject.RxCountPerVf = this.RxCountPerVf;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TxCountPerVf"))
            {
                initObject.TxCountPerVf = this.TxCountPerVf;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VfCount"))
            {
                initObject.VfCount = this.VfCount;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VnicTcpOffloadSettings.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicTcpOffloadSettings")]
    public class InitializeIntersightVnicTcpOffloadSettings : PSCmdlet
    {
        public InitializeIntersightVnicTcpOffloadSettings()
        {
            ClassId = VnicTcpOffloadSettings.ClassIdEnum.VnicTcpOffloadSettings;
            ObjectType = VnicTcpOffloadSettings.ObjectTypeEnum.VnicTcpOffloadSettings;

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

        public VnicTcpOffloadSettings.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Enables the reassembly of segmented packets in hardware before sending them to the CPU."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool LargeReceive
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Enables the CPU to send large packets to the hardware for segmentation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool LargeSend
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicTcpOffloadSettings.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"When enabled, the CPU sends all packet checksums to the hardware for validation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool RxChecksum
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"When enabled, the CPU sends all packets to the hardware so that the checksum can be calculated."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool TxChecksum
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.VnicTcpOffloadSettings initObject = new Intersight.Model.VnicTcpOffloadSettings();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("LargeReceive"))
            {
                initObject.LargeReceive = this.LargeReceive;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LargeSend"))
            {
                initObject.LargeSend = this.LargeSend;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("RxChecksum"))
            {
                initObject.RxChecksum = this.RxChecksum;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TxChecksum"))
            {
                initObject.TxChecksum = this.TxChecksum;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VnicUsnicSettings.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicUsnicSettings")]
    public class InitializeIntersightVnicUsnicSettings : PSCmdlet
    {
        public InitializeIntersightVnicUsnicSettings()
        {
            ClassId = VnicUsnicSettings.ClassIdEnum.VnicUsnicSettings;
            ObjectType = VnicUsnicSettings.ObjectTypeEnum.VnicUsnicSettings;

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

        public VnicUsnicSettings.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Class of Service to be used for traffic on the usNIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Cos
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of usNIC interfaces to be created. When usNIC is enabled, the valid values are from 1 to 225. When usNIC is disabled, the default value is 0."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Count
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicUsnicSettings.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Ethernet Adapter policy to be associated with the usNICs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string UsnicAdapterPolicy
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.VnicUsnicSettings initObject = new Intersight.Model.VnicUsnicSettings();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Cos"))
            {
                initObject.Cos = this.Cos;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Count"))
            {
                initObject.Count = this.Count;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("UsnicAdapterPolicy"))
            {
                initObject.UsnicAdapterPolicy = this.UsnicAdapterPolicy;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VnicVhbaTemplate.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicVhbaTemplate")]
    public class InitializeIntersightVnicVhbaTemplate : PSCmdlet
    {
        public InitializeIntersightVnicVhbaTemplate()
        {
            ClassId = VnicVhbaTemplate.ClassIdEnum.VnicVhbaTemplate;
            ObjectType = VnicVhbaTemplate.ObjectTypeEnum.VnicVhbaTemplate;
            SwitchId = VnicVhbaTemplate.SwitchIdEnum.None;
            Type = VnicVhbaTemplate.TypeEnum.FcInitiator;

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

        public VnicVhbaTemplate.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the vHBA template."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"When enabled, the configuration of the derived instances may override the template configuration."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool EnableOverride
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a vnicFcAdapterPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VnicFcAdapterPolicyRelationship FcAdapterPolicy
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a vnicFcNetworkPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VnicFcNetworkPolicyRelationship FcNetworkPolicy
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a vnicFcQosPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VnicFcQosPolicyRelationship FcQosPolicy
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to fabricFcZonePolicy resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.FabricFcZonePolicyRelationship> FcZonePolicies
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
        /// <para type="description">"Name of the vHBA template."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9-._:]+$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicVhbaTemplate.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.OrganizationOrganizationRelationship Organization
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the peer vHBA which belongs to the peer FI."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string PeerVhbaName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Enables retention of LUN ID associations in memory until they are manually cleared."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool PersistentBindings
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Pingroup name associated to vfc for static pinning. SCP deploy will resolve pingroup name and fetches the correspoding uplink port/port channel to pin the vfc traffic."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9_.:-]{1,64}$")]
        public string PinGroupName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fabric port to which the vHBAs will be associated.\n* `None` - Fabric Id is not set to either A or B for the standalone case where the server is not connected to Fabric Interconnects. The value 'None' should be used.\n* `A` - Fabric A of the FI cluster.\n* `B` - Fabric B of the FI cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicVhbaTemplate.SwitchIdEnum SwitchId
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

        public List<Model.MotemplateActionEntry> TemplateActions
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"VHBA Type configuration for SAN Connectivity Policy. This configuration is supported only on Cisco VIC 14XX series and higher series of adapters.\n* `fc-initiator` - The default value set for vHBA Type Configuration. Fc-initiator specifies vHBA as a consumer of storage. Enables SCSI commands to transfer data and status information between host and target storage systems.\n* `fc-nvme-initiator` - Fc-nvme-initiator specifies vHBA as a consumer of storage. Enables NVMe-based message commands to transfer data and status information between host and target storage systems.\n* `fc-nvme-target` - Fc-nvme-target specifies vHBA as a provider of storage volumes to initiators. Enables NVMe-based message commands to transfer data and status information between host and target storage systems. Currently tech-preview, only enabled with an asynchronous driver.\n* `fc-target` - Fc-target specifies vHBA as a provider of storage volumes to initiators. Enables SCSI commands to transfer data and status information between host and target storage systems. fc-target is enabled only with an asynchronous driver."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicVhbaTemplate.TypeEnum Type
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a fcpoolPool resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.FcpoolPoolRelationship WwpnPool
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.VnicVhbaTemplate initObject = new Intersight.Model.VnicVhbaTemplate();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EnableOverride"))
            {
                initObject.EnableOverride = this.EnableOverride;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FcAdapterPolicy"))
            {
                initObject.FcAdapterPolicy = this.FcAdapterPolicy;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FcNetworkPolicy"))
            {
                initObject.FcNetworkPolicy = this.FcNetworkPolicy;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FcQosPolicy"))
            {
                initObject.FcQosPolicy = this.FcQosPolicy;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FcZonePolicies"))
            {
                initObject.FcZonePolicies = this.FcZonePolicies;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("PeerVhbaName"))
            {
                initObject.PeerVhbaName = this.PeerVhbaName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PersistentBindings"))
            {
                initObject.PersistentBindings = this.PersistentBindings;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PinGroupName"))
            {
                initObject.PinGroupName = this.PinGroupName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SwitchId"))
            {
                initObject.SwitchId = this.SwitchId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TemplateActions"))
            {
                initObject.TemplateActions = this.TemplateActions;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Type"))
            {
                initObject.Type = this.Type;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("WwpnPool"))
            {
                initObject.WwpnPool = this.WwpnPool;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VnicVifStatus.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicVifStatus")]
    public class InitializeIntersightVnicVifStatus : PSCmdlet
    {
        public InitializeIntersightVnicVifStatus()
        {
            ClassId = VnicVifStatus.ClassIdEnum.VnicVifStatus;
            ObjectType = VnicVifStatus.ObjectTypeEnum.VnicVifStatus;
            Status = VnicVifStatus.StatusEnum.Ok;

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

        public VnicVifStatus.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the vNIC for which the status is reported."</para>
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

        public VnicVifStatus.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The reason for the status - it will be empty if status is ok or validating. If error, it will have the appropriate message indicating the reason for failure."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Reason
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Indicates if the vNIC / vHBA is ready for deploy or not.\n* `ok` - No issues with the LCP/SCP/VIF.\n* `error` - The LCP/SCP/VIF cannot be deployed due to error.\n* `validating` - Validation in progress for the LCP."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicVifStatus.StatusEnum Status
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.VnicVifStatus initObject = new Intersight.Model.VnicVifStatus();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Reason"))
            {
                initObject.Reason = this.Reason;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Status"))
            {
                initObject.Status = this.Status;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VnicVlanSettings.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicVlanSettings")]
    public class InitializeIntersightVnicVlanSettings : PSCmdlet
    {
        public InitializeIntersightVnicVlanSettings()
        {
            ClassId = VnicVlanSettings.ClassIdEnum.VnicVlanSettings;
            Mode = VnicVlanSettings.ModeEnum.ACCESS;
            ObjectType = VnicVlanSettings.ObjectTypeEnum.VnicVlanSettings;

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
        /// <para type="description">"Allowed VLAN IDs of the virtual interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^((\\d+\\-\\d+)|(\\d+))(,((\\d+\\-\\d+)|(\\d+)))*$")]
        public string AllowedVlans
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicVlanSettings.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Native VLAN ID of the virtual interface or the corresponding vethernet on the peer Fabric Interconnect to which the virtual interface is connected. Setting the ID to 0 will not associate any native VLAN to the traffic on the virtual interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long DefaultVlan
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Option to determine if the port can carry single VLAN (Access) or multiple VLANs (Trunk) traffic.\n* `ACCESS` - An access port carries traffic only for a single VLAN on the interface.\n* `TRUNK` - A trunk port can have two or more VLANs configured on the interface. It can carry traffic for several VLANs simultaneously."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicVlanSettings.ModeEnum Mode
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicVlanSettings.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Enable QinQ (802.1Q-in-802.1Q) Tunneling on the vNIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool QinqEnabled
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"When activating VIC QinQ (802.1Q-in-802.1Q) Tunneling, a particular VLAN ID is set. In Access VLAN mode, this QinQ VLAN ID is established as the default VLAN."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(2, 4093)]
        public long QinqVlan
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.VnicVlanSettings initObject = new Intersight.Model.VnicVlanSettings();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AllowedVlans"))
            {
                initObject.AllowedVlans = this.AllowedVlans;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("DefaultVlan"))
            {
                initObject.DefaultVlan = this.DefaultVlan;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Mode"))
            {
                initObject.Mode = this.Mode;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("QinqEnabled"))
            {
                initObject.QinqEnabled = this.QinqEnabled;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("QinqVlan"))
            {
                initObject.QinqVlan = this.QinqVlan;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VnicVmqSettings.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicVmqSettings")]
    public class InitializeIntersightVnicVmqSettings : PSCmdlet
    {
        public InitializeIntersightVnicVmqSettings()
        {
            ClassId = VnicVmqSettings.ClassIdEnum.VnicVmqSettings;
            ObjectType = VnicVmqSettings.ObjectTypeEnum.VnicVmqSettings;

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

        public VnicVmqSettings.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Enables VMQ feature on the virtual interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Enabled
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Enables Virtual Machine Multi-Queue feature on the virtual interface. VMMQ allows configuration of multiple I/O queues for a single VM and thus distributes traffic across multiple CPU cores in a VM."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool MultiQueueSupport
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of interrupt resources to be allocated. Recommended value is the number of CPU threads or logical processors available in the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 514)]
        public long NumInterrupts
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of sub vNICs to be created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long NumSubVnics
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of hardware Virtual Machine Queues to be allocated. The number of VMQs per adapter must be one more than the maximum number of VM NICs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 128)]
        public long NumVmqs
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicVmqSettings.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Ethernet Adapter policy to be associated with the Sub vNICs. The Transmit Queue and Receive Queue resource value of VMMQ adapter policy should be greater than or equal to the configured number of sub vNICs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string VmmqAdapterPolicy
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.VnicVmqSettings initObject = new Intersight.Model.VnicVmqSettings();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Enabled"))
            {
                initObject.Enabled = this.Enabled;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MultiQueueSupport"))
            {
                initObject.MultiQueueSupport = this.MultiQueueSupport;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NumInterrupts"))
            {
                initObject.NumInterrupts = this.NumInterrupts;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NumSubVnics"))
            {
                initObject.NumSubVnics = this.NumSubVnics;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NumVmqs"))
            {
                initObject.NumVmqs = this.NumVmqs;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("VmmqAdapterPolicy"))
            {
                initObject.VmmqAdapterPolicy = this.VmmqAdapterPolicy;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VnicVnicTemplate.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicVnicTemplate")]
    public class InitializeIntersightVnicVnicTemplate : PSCmdlet
    {
        public InitializeIntersightVnicVnicTemplate()
        {
            ClassId = VnicVnicTemplate.ClassIdEnum.VnicVnicTemplate;
            ObjectType = VnicVnicTemplate.ObjectTypeEnum.VnicVnicTemplate;
            SwitchId = VnicVnicTemplate.SwitchIdEnum.None;

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
        /// <para type="description">"Consistent Device Naming configuration for the virtual NIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VnicCdn Cdn
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicVnicTemplate.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the vNIC template."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"When enabled, the configuration of the derived instances may override the template configuration."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool EnableOverride
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a vnicEthAdapterPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VnicEthAdapterPolicyRelationship EthAdapterPolicy
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a vnicEthNetworkPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VnicEthNetworkPolicyRelationship EthNetworkPolicy
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a vnicEthQosPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VnicEthQosPolicyRelationship EthQosPolicy
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a fabricEthNetworkControlPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.FabricEthNetworkControlPolicyRelationship FabricEthNetworkControlPolicy
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to fabricEthNetworkGroupPolicy resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.FabricEthNetworkGroupPolicyRelationship> FabricEthNetworkGroupPolicy
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Enabling failover ensures that traffic from the vNIC automatically fails over to the secondary Fabric Interconnect, in case the specified Fabric Interconnect path goes down. Failover applies only to Cisco VICs that are connected to a Fabric Interconnect cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool FailoverEnabled
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a vnicIscsiBootPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VnicIscsiBootPolicyRelationship IscsiBootPolicy
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a macpoolPool resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.MacpoolPoolRelationship MacPool
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
        /// <para type="description">"Name of the vNIC template."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9-._:]+$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicVnicTemplate.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.OrganizationOrganizationRelationship Organization
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the peer vNIC which belongs to the peer FI."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string PeerVnicName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Pingroup name associated to vNIC for static pinning. LCP deploy will resolve pingroup name and fetches the correspoding uplink port/port channel to pin the vNIC traffic."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9_.:-]{1,64}$")]
        public string PinGroupName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Single Root Input Output Virtualization (SR-IOV) Settings that enable one physical ethernet socket to appear as multiple NICs to the hypervisor."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VnicSriovSettings SriovSettings
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fabric port to which the vNICs will be associated.\n* `None` - Fabric Id is not set to either A or B for the standalone case where the server is not connected to Fabric Interconnects. The value 'None' should be used.\n* `A` - Fabric A of the FI cluster.\n* `B` - Fabric B of the FI cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicVnicTemplate.SwitchIdEnum SwitchId
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

        public List<Model.MotemplateActionEntry> TemplateActions
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"User Space NIC Settings that enable low-latency and higher throughput by bypassing the kernel layer when sending/receiving packets."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VnicUsnicSettings UsnicSettings
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Virtual Machine Queue Settings for the virtual interface that allow efficient transfer of network traffic to the guest OS."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VnicVmqSettings VmqSettings
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.VnicVnicTemplate initObject = new Intersight.Model.VnicVnicTemplate();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Cdn"))
            {
                initObject.Cdn = this.Cdn;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EnableOverride"))
            {
                initObject.EnableOverride = this.EnableOverride;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EthAdapterPolicy"))
            {
                initObject.EthAdapterPolicy = this.EthAdapterPolicy;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EthNetworkPolicy"))
            {
                initObject.EthNetworkPolicy = this.EthNetworkPolicy;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EthQosPolicy"))
            {
                initObject.EthQosPolicy = this.EthQosPolicy;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FabricEthNetworkControlPolicy"))
            {
                initObject.FabricEthNetworkControlPolicy = this.FabricEthNetworkControlPolicy;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FabricEthNetworkGroupPolicy"))
            {
                initObject.FabricEthNetworkGroupPolicy = this.FabricEthNetworkGroupPolicy;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FailoverEnabled"))
            {
                initObject.FailoverEnabled = this.FailoverEnabled;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IscsiBootPolicy"))
            {
                initObject.IscsiBootPolicy = this.IscsiBootPolicy;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MacPool"))
            {
                initObject.MacPool = this.MacPool;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("PeerVnicName"))
            {
                initObject.PeerVnicName = this.PeerVnicName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PinGroupName"))
            {
                initObject.PinGroupName = this.PinGroupName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SriovSettings"))
            {
                initObject.SriovSettings = this.SriovSettings;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SwitchId"))
            {
                initObject.SwitchId = this.SwitchId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TemplateActions"))
            {
                initObject.TemplateActions = this.TemplateActions;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UsnicSettings"))
            {
                initObject.UsnicSettings = this.UsnicSettings;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VmqSettings"))
            {
                initObject.VmqSettings = this.VmqSettings;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VnicVsanSettings.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicVsanSettings")]
    public class InitializeIntersightVnicVsanSettings : PSCmdlet
    {
        public InitializeIntersightVnicVsanSettings()
        {
            ClassId = VnicVsanSettings.ClassIdEnum.VnicVsanSettings;
            ObjectType = VnicVsanSettings.ObjectTypeEnum.VnicVsanSettings;

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

        public VnicVsanSettings.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Default VLAN of the virtual interface in Standalone Rack server. Setting the value to 0 is equivalent to None and will not associate any Default VLAN to the traffic on the virtual interface (0-4094)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long DefaultVlanId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"VSAN ID of the virtual interface in FI attached server (1-4094)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 4094)]
        public long Id
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicVsanSettings.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.VnicVsanSettings initObject = new Intersight.Model.VnicVsanSettings();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("DefaultVlanId"))
            {
                initObject.DefaultVlanId = this.DefaultVlanId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Id"))
            {
                initObject.Id = this.Id;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VnicVxlanSettings.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicVxlanSettings")]
    public class InitializeIntersightVnicVxlanSettings : PSCmdlet
    {
        public InitializeIntersightVnicVxlanSettings()
        {
            ClassId = VnicVxlanSettings.ClassIdEnum.VnicVxlanSettings;
            ObjectType = VnicVxlanSettings.ObjectTypeEnum.VnicVxlanSettings;

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

        public VnicVxlanSettings.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Status of the Virtual Extensible LAN Protocol on the virtual ethernet interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Enabled
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicVxlanSettings.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.VnicVxlanSettings initObject = new Intersight.Model.VnicVxlanSettings();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Enabled"))
            {
                initObject.Enabled = this.Enabled;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
}