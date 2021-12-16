using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize AdapterDceInterfaceSettings.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAdapterDceInterfaceSettings")]
    public class InitializeIntersightAdapterDceInterfaceSettings:PSCmdlet
	{
		public InitializeIntersightAdapterDceInterfaceSettings()
		{
            ClassId = AdapterDceInterfaceSettings.ClassIdEnum.AdapterDceInterfaceSettings;
            FecMode = AdapterDceInterfaceSettings.FecModeEnum.Cl91;
            ObjectType = AdapterDceInterfaceSettings.ObjectTypeEnum.AdapterDceInterfaceSettings;
            
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
        
        public AdapterDceInterfaceSettings.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Forward Error Correction (FEC) mode setting for the DCE interfaces of the adapter. FEC mode setting is supported only for Cisco VIC 14xx adapters. FEC mode 'cl74' is unsupported for Cisco VIC 1495/1497. This setting will be ignored for unsupported adapters and for unavailable DCE interfaces.\n* `cl91` - Use cl91 standard as FEC mode setting. 'Clause 91' aka RS-FEC ('ReedSolomon' FEC) offers better error protection against bursty and random errors but adds latency.\n* `cl74` - Use cl74 standard as FEC mode setting. 'Clause 74' aka FC-FEC ('FireCode' FEC) offers simple, low-latency protection against 1 burst/sparse bit error, but it is not good for random errors.\n* `Off` - Disable FEC mode on the DCE Interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AdapterDceInterfaceSettings.FecModeEnum FecMode {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"DCE interface id on which settings needs to be configured. Supported values are (0-3)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long InterfaceId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AdapterDceInterfaceSettings.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.AdapterDceInterfaceSettings initObject = new Intersight.Model.AdapterDceInterfaceSettings();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("FecMode"))
            {
                initObject.FecMode = this.FecMode;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InterfaceId"))
            {
                initObject.InterfaceId = this.InterfaceId;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize AdapterEthSettings.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAdapterEthSettings")]
    public class InitializeIntersightAdapterEthSettings:PSCmdlet
	{
		public InitializeIntersightAdapterEthSettings()
		{
            ClassId = AdapterEthSettings.ClassIdEnum.AdapterEthSettings;
            ObjectType = AdapterEthSettings.ObjectTypeEnum.AdapterEthSettings;
            
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
        
        public AdapterEthSettings.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Status of LLDP protocol on the adapter interfaces."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool LldpEnabled {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AdapterEthSettings.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.AdapterEthSettings initObject = new Intersight.Model.AdapterEthSettings();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("LldpEnabled"))
            {
                initObject.LldpEnabled = this.LldpEnabled;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize AdapterFcSettings.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAdapterFcSettings")]
    public class InitializeIntersightAdapterFcSettings:PSCmdlet
	{
		public InitializeIntersightAdapterFcSettings()
		{
            ClassId = AdapterFcSettings.ClassIdEnum.AdapterFcSettings;
            ObjectType = AdapterFcSettings.ObjectTypeEnum.AdapterFcSettings;
            
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
        
        public AdapterFcSettings.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Status of FIP protocol on the adapter interfaces."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool FipEnabled {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AdapterFcSettings.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.AdapterFcSettings initObject = new Intersight.Model.AdapterFcSettings();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("FipEnabled"))
            {
                initObject.FipEnabled = this.FipEnabled;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize AdapterPortChannelSettings.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAdapterPortChannelSettings")]
    public class InitializeIntersightAdapterPortChannelSettings:PSCmdlet
	{
		public InitializeIntersightAdapterPortChannelSettings()
		{
            ClassId = AdapterPortChannelSettings.ClassIdEnum.AdapterPortChannelSettings;
            ObjectType = AdapterPortChannelSettings.ObjectTypeEnum.AdapterPortChannelSettings;
            
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
        
        public AdapterPortChannelSettings.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"When Port Channel is enabled, two vNICs and two vHBAs are available for use on the adapter card. When disabled, four vNICs and four vHBAs are available for use on the adapter card. Disabling port channel reboots the server. Port Channel is supported only for Cisco VIC 1455/1457 adapters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Enabled {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AdapterPortChannelSettings.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.AdapterPortChannelSettings initObject = new Intersight.Model.AdapterPortChannelSettings();
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
    /// <para type="synopsis">This is the cmdlet to Initialize AdapterAdapterConfig.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAdapterAdapterConfig")]
    public class InitializeIntersightAdapterAdapterConfig:PSCmdlet
	{
		public InitializeIntersightAdapterAdapterConfig()
		{
            ClassId = AdapterAdapterConfig.ClassIdEnum.AdapterAdapterConfig;
            ObjectType = AdapterAdapterConfig.ObjectTypeEnum.AdapterAdapterConfig;
            
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
        
        public AdapterAdapterConfig.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Model.AdapterDceInterfaceSettings> DceInterfaceSettings {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Global Ethernet settings for this adapter."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.AdapterEthSettings EthSettings {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Global Fibre Channel settings for this adapter."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.AdapterFcSettings FcSettings {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AdapterAdapterConfig.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Port Channel settings for this adapter."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.AdapterPortChannelSettings PortChannelSettings {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"PCIe slot where the VIC adapter is installed. Supported values are (1-15) and MLOM."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^([1-9]|1[0-5]|MLOM)$")]
        public string SlotId {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.AdapterAdapterConfig initObject = new Intersight.Model.AdapterAdapterConfig();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("DceInterfaceSettings"))
            {
                initObject.DceInterfaceSettings = this.DceInterfaceSettings;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EthSettings"))
            {
                initObject.EthSettings = this.EthSettings;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FcSettings"))
            {
                initObject.FcSettings = this.FcSettings;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("PortChannelSettings"))
            {
                initObject.PortChannelSettings = this.PortChannelSettings;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotId"))
            {
                initObject.SlotId = this.SlotId;
            }
            WriteObject(initObject);
        }

    }
}