using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetrySmartLicense.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetrySmartLicense")]
    public class InitializeIntersightNiatelemetrySmartLicense:PSCmdlet
	{
		public InitializeIntersightNiatelemetrySmartLicense()
		{
            ClassId = NiatelemetrySmartLicense.ClassIdEnum.NiatelemetrySmartLicense;
            ObjectType = NiatelemetrySmartLicense.ObjectTypeEnum.NiatelemetrySmartLicense;
            
		}
        // <summary>
        /// <para type="description">"Indicate the mode smart license is curerntly running."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ActiveMode {
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
        /// <para type="description">"Authorization status of the smart license."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string AuthStatus {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetrySmartLicense.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"License Udi of the smart license."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string LicenseUdi {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetrySmartLicense.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Smart licensing account name in CSSM and is retrieved from CSSM after regsitration."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SmartAccount {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.NiatelemetrySmartLicense initObject = new Intersight.Model.NiatelemetrySmartLicense();
            if (this.MyInvocation.BoundParameters.ContainsKey("ActiveMode"))
            {
                initObject.ActiveMode = this.ActiveMode;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AuthStatus"))
            {
                initObject.AuthStatus = this.AuthStatus;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("LicenseUdi"))
            {
                initObject.LicenseUdi = this.LicenseUdi;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("SmartAccount"))
            {
                initObject.SmartAccount = this.SmartAccount;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryInterfaceElement.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryInterfaceElement")]
    public class InitializeIntersightNiatelemetryInterfaceElement:PSCmdlet
	{
		public InitializeIntersightNiatelemetryInterfaceElement()
		{
            ClassId = NiatelemetryInterfaceElement.ClassIdEnum.NiatelemetryInterfaceElement;
            ObjectType = NiatelemetryInterfaceElement.ObjectTypeEnum.NiatelemetryInterfaceElement;
            
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
        
        public NiatelemetryInterfaceElement.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Return value of name of the port."</para>
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
        
        public NiatelemetryInterfaceElement.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Return value of operState attribute."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string OperState {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Return whether sfp is present or not."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string XcvrPresent {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.NiatelemetryInterfaceElement initObject = new Intersight.Model.NiatelemetryInterfaceElement();
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
            if (this.MyInvocation.BoundParameters.ContainsKey("OperState"))
            {
                initObject.OperState = this.OperState;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("XcvrPresent"))
            {
                initObject.XcvrPresent = this.XcvrPresent;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryNveVni.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryNveVni")]
    public class InitializeIntersightNiatelemetryNveVni:PSCmdlet
	{
		public InitializeIntersightNiatelemetryNveVni()
		{
            ClassId = NiatelemetryNveVni.ClassIdEnum.NiatelemetryNveVni;
            ObjectType = NiatelemetryNveVni.ObjectTypeEnum.NiatelemetryNveVni;
            
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
        
        public NiatelemetryNveVni.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Return value of cp vni count."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long CpVniCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Return value of cp vni down count."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long CpVniDown {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Return value of cp vni up count."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long CpVniUp {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Return value of dp vni count."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long DpVniCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Return value of cp vni down count."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long DpVniDown {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Return value of cp vni up count."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long DpVniUp {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryNveVni.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.NiatelemetryNveVni initObject = new Intersight.Model.NiatelemetryNveVni();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("CpVniCount"))
            {
                initObject.CpVniCount = this.CpVniCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CpVniDown"))
            {
                initObject.CpVniDown = this.CpVniDown;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CpVniUp"))
            {
                initObject.CpVniUp = this.CpVniUp;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DpVniCount"))
            {
                initObject.DpVniCount = this.DpVniCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DpVniDown"))
            {
                initObject.DpVniDown = this.DpVniDown;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DpVniUp"))
            {
                initObject.DpVniUp = this.DpVniUp;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryDiskinfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryDiskinfo")]
    public class InitializeIntersightNiatelemetryDiskinfo:PSCmdlet
	{
		public InitializeIntersightNiatelemetryDiskinfo()
		{
            ClassId = NiatelemetryDiskinfo.ClassIdEnum.NiatelemetryDiskinfo;
            ObjectType = NiatelemetryDiskinfo.ObjectTypeEnum.NiatelemetryDiskinfo;
            
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
        
        public NiatelemetryDiskinfo.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The free disk capacity, currently the type of this field is set to integer. This determines how much memory is free in Bytes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Free {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Disk Name used to identified the disk usage record. This determines the name of the disk partition that is inventoried."</para>
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
        
        public NiatelemetryDiskinfo.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The total disk capacity, it should be the sum of free and used, currently the type of this field is set to integer. This determines the total memory for this partition."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Total {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The used disk capacity, currently the type of this field is set to integer. This determines how much memory is used in Bytes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Used {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.NiatelemetryDiskinfo initObject = new Intersight.Model.NiatelemetryDiskinfo();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Free"))
            {
                initObject.Free = this.Free;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Total"))
            {
                initObject.Total = this.Total;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Used"))
            {
                initObject.Used = this.Used;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryBootflashDetails.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryBootflashDetails")]
    public class InitializeIntersightNiatelemetryBootflashDetails:PSCmdlet
	{
		public InitializeIntersightNiatelemetryBootflashDetails()
		{
            ClassId = NiatelemetryBootflashDetails.ClassIdEnum.NiatelemetryBootflashDetails;
            ObjectType = NiatelemetryBootflashDetails.ObjectTypeEnum.NiatelemetryBootflashDetails;
            
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
        
        public NiatelemetryBootflashDetails.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Return firmware revision in boot flash details."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string FwRev {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Return model type in boot flash details."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ModelType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryBootflashDetails.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Return serial id in boot flash details."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Serial {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.NiatelemetryBootflashDetails initObject = new Intersight.Model.NiatelemetryBootflashDetails();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("FwRev"))
            {
                initObject.FwRev = this.FwRev;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ModelType"))
            {
                initObject.ModelType = this.ModelType;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Serial"))
            {
                initObject.Serial = this.Serial;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryNxosBgpMvpn.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryNxosBgpMvpn")]
    public class InitializeIntersightNiatelemetryNxosBgpMvpn:PSCmdlet
	{
		public InitializeIntersightNiatelemetryNxosBgpMvpn()
		{
            ClassId = NiatelemetryNxosBgpMvpn.ClassIdEnum.NiatelemetryNxosBgpMvpn;
            ObjectType = NiatelemetryNxosBgpMvpn.ObjectTypeEnum.NiatelemetryNxosBgpMvpn;
            
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
        /// <para type="description">"Return count of BGP MVPN table capable peers."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long CapablePeers {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryNxosBgpMvpn.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Return count of BGP MVPN configured peers."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long ConfiguredPeers {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Return value of BGP MVPN memory used."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long MemoryUsed {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Return value of BGP MVPN cluster list."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long NumberOfClusterLists {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Return count of BGP MVPN communities."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long NumberOfCommunities {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryNxosBgpMvpn.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Return value of BGP MVPN table version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long TableVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Return count of BGP MVPN networks."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long TotalNetworks {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Return count of BGP MVPN paths."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long TotalPaths {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.NiatelemetryNxosBgpMvpn initObject = new Intersight.Model.NiatelemetryNxosBgpMvpn();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CapablePeers"))
            {
                initObject.CapablePeers = this.CapablePeers;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ConfiguredPeers"))
            {
                initObject.ConfiguredPeers = this.ConfiguredPeers;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MemoryUsed"))
            {
                initObject.MemoryUsed = this.MemoryUsed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NumberOfClusterLists"))
            {
                initObject.NumberOfClusterLists = this.NumberOfClusterLists;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NumberOfCommunities"))
            {
                initObject.NumberOfCommunities = this.NumberOfCommunities;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("TableVersion"))
            {
                initObject.TableVersion = this.TableVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TotalNetworks"))
            {
                initObject.TotalNetworks = this.TotalNetworks;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TotalPaths"))
            {
                initObject.TotalPaths = this.TotalPaths;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryLogicalLink.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryLogicalLink")]
    public class InitializeIntersightNiatelemetryLogicalLink:PSCmdlet
	{
		public InitializeIntersightNiatelemetryLogicalLink()
		{
            ClassId = NiatelemetryLogicalLink.ClassIdEnum.NiatelemetryLogicalLink;
            ObjectType = NiatelemetryLogicalLink.ObjectTypeEnum.NiatelemetryLogicalLink;
            
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
        
        public NiatelemetryLogicalLink.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Return value of dbId attribute."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long DbId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Return value of isPresent attribute."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool IsPresent {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Return value of linkAddr1 attribute."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string LinkAddr1 {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Return value of linkAddr2 attribute."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string LinkAddr2 {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Return value of linkState attribute."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string LinkState {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Return value of linkType attribute."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string LinkType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryLogicalLink.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Return value of uptime attribute."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Uptime {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.NiatelemetryLogicalLink initObject = new Intersight.Model.NiatelemetryLogicalLink();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("DbId"))
            {
                initObject.DbId = this.DbId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IsPresent"))
            {
                initObject.IsPresent = this.IsPresent;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LinkAddr1"))
            {
                initObject.LinkAddr1 = this.LinkAddr1;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LinkAddr2"))
            {
                initObject.LinkAddr2 = this.LinkAddr2;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LinkState"))
            {
                initObject.LinkState = this.LinkState;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LinkType"))
            {
                initObject.LinkType = this.LinkType;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Uptime"))
            {
                initObject.Uptime = this.Uptime;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryNvePacketCounters.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryNvePacketCounters")]
    public class InitializeIntersightNiatelemetryNvePacketCounters:PSCmdlet
	{
		public InitializeIntersightNiatelemetryNvePacketCounters()
		{
            ClassId = NiatelemetryNvePacketCounters.ClassIdEnum.NiatelemetryNvePacketCounters;
            ObjectType = NiatelemetryNvePacketCounters.ObjectTypeEnum.NiatelemetryNvePacketCounters;
            
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
        
        public NiatelemetryNvePacketCounters.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Return mcast in packet count."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long McastInpkts {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Return mcast outbytes count."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long McastOutbytes {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryNvePacketCounters.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Return ucast in packet count."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long UcastInpkts {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Return ucast out packet count."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long UcastOutpkts {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.NiatelemetryNvePacketCounters initObject = new Intersight.Model.NiatelemetryNvePacketCounters();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("McastInpkts"))
            {
                initObject.McastInpkts = this.McastInpkts;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("McastOutbytes"))
            {
                initObject.McastOutbytes = this.McastOutbytes;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("UcastInpkts"))
            {
                initObject.UcastInpkts = this.UcastInpkts;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UcastOutpkts"))
            {
                initObject.UcastOutpkts = this.UcastOutpkts;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryNxosVtp.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryNxosVtp")]
    public class InitializeIntersightNiatelemetryNxosVtp:PSCmdlet
	{
		public InitializeIntersightNiatelemetryNxosVtp()
		{
            ClassId = NiatelemetryNxosVtp.ClassIdEnum.NiatelemetryNxosVtp;
            ObjectType = NiatelemetryNxosVtp.ObjectTypeEnum.NiatelemetryNxosVtp;
            
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
        
        public NiatelemetryNxosVtp.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryNxosVtp.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns the status of operational mode of vtp."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string OperMode {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns the status pruning mode of vtp."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string PruningMode {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns the running version of vtp."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RunningVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns the status of trap in vtp."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string TrapEnabled {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns the status of v2 mode of vtp."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string V2Mode {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns version of vtp running."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Version {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.NiatelemetryNxosVtp initObject = new Intersight.Model.NiatelemetryNxosVtp();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("OperMode"))
            {
                initObject.OperMode = this.OperMode;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PruningMode"))
            {
                initObject.PruningMode = this.PruningMode;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RunningVersion"))
            {
                initObject.RunningVersion = this.RunningVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TrapEnabled"))
            {
                initObject.TrapEnabled = this.TrapEnabled;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("V2Mode"))
            {
                initObject.V2Mode = this.V2Mode;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Version"))
            {
                initObject._Version = this.Version;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryInterface.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryInterface")]
    public class InitializeIntersightNiatelemetryInterface:PSCmdlet
	{
		public InitializeIntersightNiatelemetryInterface()
		{
            ClassId = NiatelemetryInterface.ClassIdEnum.NiatelemetryInterface;
            ObjectType = NiatelemetryInterface.ObjectTypeEnum.NiatelemetryInterface;
            
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
        
        public NiatelemetryInterface.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Return value of number of interafces down."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long InterfaceDownCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Return value of number of interafces up."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long InterfaceUpCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryInterface.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.NiatelemetryInterface initObject = new Intersight.Model.NiatelemetryInterface();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("InterfaceDownCount"))
            {
                initObject.InterfaceDownCount = this.InterfaceDownCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InterfaceUpCount"))
            {
                initObject.InterfaceUpCount = this.InterfaceUpCount;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
}