using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryImageDetail.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryImageDetail")]
    public class InitializeIntersightNiatelemetryImageDetail:PSCmdlet
	{
		public InitializeIntersightNiatelemetryImageDetail()
		{
            ClassId = NiatelemetryImageDetail.ClassIdEnum.NiatelemetryImageDetail;
            ObjectType = NiatelemetryImageDetail.ObjectTypeEnum.NiatelemetryImageDetail;
            
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
        
        public NiatelemetryImageDetail.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns name of the image on controller."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ImageName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns name of the image on controller."</para>
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
        
        public NiatelemetryImageDetail.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns version of the image on controller."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Version {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.NiatelemetryImageDetail initObject = new Intersight.Model.NiatelemetryImageDetail();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ImageName"))
            {
                initObject.ImageName = this.ImageName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
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
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryFabricNodeControlDetails.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryFabricNodeControlDetails")]
    public class InitializeIntersightNiatelemetryFabricNodeControlDetails:PSCmdlet
	{
		public InitializeIntersightNiatelemetryFabricNodeControlDetails()
		{
            ClassId = NiatelemetryFabricNodeControlDetails.ClassIdEnum.NiatelemetryFabricNodeControlDetails;
            ObjectType = NiatelemetryFabricNodeControlDetails.ObjectTypeEnum.NiatelemetryFabricNodeControlDetails;
            
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
        
        public NiatelemetryFabricNodeControlDetails.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Dn for each fabric node control in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Dn {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Fetaure sel for each fabric node control in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string FeatureSel {
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryFabricNodeControlDetails.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of record DCNM / APIC / SE. This determines the type of platform where inventory was collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version of record being pushed. This determines what was the API version for data available from the device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the APIC site from which this data is being collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SiteName {
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
             Intersight.Model.NiatelemetryFabricNodeControlDetails initObject = new Intersight.Model.NiatelemetryFabricNodeControlDetails();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Dn"))
            {
                initObject.Dn = this.Dn;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FeatureSel"))
            {
                initObject.FeatureSel = this.FeatureSel;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordType"))
            {
                initObject.RecordType = this.RecordType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordVersion"))
            {
                initObject.RecordVersion = this.RecordVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SiteName"))
            {
                initObject.SiteName = this.SiteName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryHttpsAclEpgContractMap.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryHttpsAclEpgContractMap")]
    public class InitializeIntersightNiatelemetryHttpsAclEpgContractMap:PSCmdlet
	{
		public InitializeIntersightNiatelemetryHttpsAclEpgContractMap()
		{
            ClassId = NiatelemetryHttpsAclEpgContractMap.ClassIdEnum.NiatelemetryHttpsAclEpgContractMap;
            ObjectType = NiatelemetryHttpsAclEpgContractMap.ObjectTypeEnum.NiatelemetryHttpsAclEpgContractMap;
            
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
        
        public NiatelemetryHttpsAclEpgContractMap.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of HTTPS ACL contract for APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ContractName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Dn of the HTTPS ACL contract provider for APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Dn {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of EPGs of the HTTPS ACL contract for APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string EpgName {
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryHttpsAclEpgContractMap.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of record DCNM / APIC / SE. This determines the type of platform where inventory was collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version of record being pushed. This determines what was the API version for data available from the device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the APIC site from which this data is being collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SiteName {
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
        // <summary>
        /// <para type="description">"TDn of the HTTPS ACL contract provider for APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string TargetDn {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.NiatelemetryHttpsAclEpgContractMap initObject = new Intersight.Model.NiatelemetryHttpsAclEpgContractMap();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ContractName"))
            {
                initObject.ContractName = this.ContractName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Dn"))
            {
                initObject.Dn = this.Dn;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EpgName"))
            {
                initObject.EpgName = this.EpgName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordType"))
            {
                initObject.RecordType = this.RecordType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordVersion"))
            {
                initObject.RecordVersion = this.RecordVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SiteName"))
            {
                initObject.SiteName = this.SiteName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TargetDn"))
            {
                initObject.TargetDn = this.TargetDn;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryAaaRadiusProviderDetails.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryAaaRadiusProviderDetails")]
    public class InitializeIntersightNiatelemetryAaaRadiusProviderDetails:PSCmdlet
	{
		public InitializeIntersightNiatelemetryAaaRadiusProviderDetails()
		{
            ClassId = NiatelemetryAaaRadiusProviderDetails.ClassIdEnum.NiatelemetryAaaRadiusProviderDetails;
            ObjectType = NiatelemetryAaaRadiusProviderDetails.ObjectTypeEnum.NiatelemetryAaaRadiusProviderDetails;
            
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
        
        public NiatelemetryAaaRadiusProviderDetails.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Dn of the AAA radius provider in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Dn {
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryAaaRadiusProviderDetails.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Owner Key of the AAA radius provider in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string OwnerKey {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of record DCNM / APIC / SE. This determines the type of platform where inventory was collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version of record being pushed. This determines what was the API version for data available from the device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the APIC site from which this data is being collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SiteName {
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
             Intersight.Model.NiatelemetryAaaRadiusProviderDetails initObject = new Intersight.Model.NiatelemetryAaaRadiusProviderDetails();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Dn"))
            {
                initObject.Dn = this.Dn;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("OwnerKey"))
            {
                initObject.OwnerKey = this.OwnerKey;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordType"))
            {
                initObject.RecordType = this.RecordType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordVersion"))
            {
                initObject.RecordVersion = this.RecordVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SiteName"))
            {
                initObject.SiteName = this.SiteName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryApicDbgexpRsTsScheduler.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryApicDbgexpRsTsScheduler")]
    public class InitializeIntersightNiatelemetryApicDbgexpRsTsScheduler:PSCmdlet
	{
		public InitializeIntersightNiatelemetryApicDbgexpRsTsScheduler()
		{
            ClassId = NiatelemetryApicDbgexpRsTsScheduler.ClassIdEnum.NiatelemetryApicDbgexpRsTsScheduler;
            ObjectType = NiatelemetryApicDbgexpRsTsScheduler.ObjectTypeEnum.NiatelemetryApicDbgexpRsTsScheduler;
            
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
        
        public NiatelemetryApicDbgexpRsTsScheduler.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Dn of the  Rs Ts scheduler in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Dn {
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryApicDbgexpRsTsScheduler.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of record DCNM / APIC / SE. This determines the type of platform where inventory was collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version of record being pushed. This determines what was the API version for data available from the device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the APIC site from which this data is being collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SiteName {
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
             Intersight.Model.NiatelemetryApicDbgexpRsTsScheduler initObject = new Intersight.Model.NiatelemetryApicDbgexpRsTsScheduler();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Dn"))
            {
                initObject.Dn = this.Dn;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordType"))
            {
                initObject.RecordType = this.RecordType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordVersion"))
            {
                initObject.RecordVersion = this.RecordVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SiteName"))
            {
                initObject.SiteName = this.SiteName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryJobDetail.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryJobDetail")]
    public class InitializeIntersightNiatelemetryJobDetail:PSCmdlet
	{
		public InitializeIntersightNiatelemetryJobDetail()
		{
            ClassId = NiatelemetryJobDetail.ClassIdEnum.NiatelemetryJobDetail;
            ObjectType = NiatelemetryJobDetail.ObjectTypeEnum.NiatelemetryJobDetail;
            
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
        
        public NiatelemetryJobDetail.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns the id of the job."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long JobId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryJobDetail.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns the status of the job."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string UpgStatus {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.NiatelemetryJobDetail initObject = new Intersight.Model.NiatelemetryJobDetail();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("JobId"))
            {
                initObject.JobId = this.JobId;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("UpgStatus"))
            {
                initObject.UpgStatus = this.UpgStatus;
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
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetrySystemControllerDetails.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetrySystemControllerDetails")]
    public class InitializeIntersightNiatelemetrySystemControllerDetails:PSCmdlet
	{
		public InitializeIntersightNiatelemetrySystemControllerDetails()
		{
            ClassId = NiatelemetrySystemControllerDetails.ClassIdEnum.NiatelemetrySystemControllerDetails;
            ObjectType = NiatelemetrySystemControllerDetails.ObjectTypeEnum.NiatelemetrySystemControllerDetails;
            
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
        
        public NiatelemetrySystemControllerDetails.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Dn of the supervisor module in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Dn {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Hardware version of system controller."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string HwVer {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Model of the system controller."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Model {
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetrySystemControllerDetails.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of record DCNM / APIC / SE. This determines the type of platform where inventory was collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version of record being pushed. This determines what was the API version for data available from the device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Serial number of the system controller."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Serial {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the APIC site from which this data is being collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SiteName {
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
             Intersight.Model.NiatelemetrySystemControllerDetails initObject = new Intersight.Model.NiatelemetrySystemControllerDetails();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Dn"))
            {
                initObject.Dn = this.Dn;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HwVer"))
            {
                initObject.HwVer = this.HwVer;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Model"))
            {
                initObject.Model = this.Model;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordType"))
            {
                initObject.RecordType = this.RecordType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordVersion"))
            {
                initObject.RecordVersion = this.RecordVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Serial"))
            {
                initObject.Serial = this.Serial;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SiteName"))
            {
                initObject.SiteName = this.SiteName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryDcnmFexDetails.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryDcnmFexDetails")]
    public class InitializeIntersightNiatelemetryDcnmFexDetails:PSCmdlet
	{
		public InitializeIntersightNiatelemetryDcnmFexDetails()
		{
            ClassId = NiatelemetryDcnmFexDetails.ClassIdEnum.NiatelemetryDcnmFexDetails;
            ObjectType = NiatelemetryDcnmFexDetails.ObjectTypeEnum.NiatelemetryDcnmFexDetails;
            
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
        
        public NiatelemetryDcnmFexDetails.ClassIdEnum ClassId {
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
        /// <para type="description">"Name of the fex in the fabric inventory."</para>
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
        
        public NiatelemetryDcnmFexDetails.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Product ID of the fex in the fabric inventory."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ProductId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of record DCNM / APIC / SE. This determines the type of platform where inventory was collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version of record being pushed. This determines what was the API version for data available from the device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Serial number of the fex in the fabric inventory."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SerialNumber {
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
        // <summary>
        /// <para type="description">"Vendor Id of the fex in the fabric inventory."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string VendorId {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.NiatelemetryDcnmFexDetails initObject = new Intersight.Model.NiatelemetryDcnmFexDetails();
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
            if (this.MyInvocation.BoundParameters.ContainsKey("ProductId"))
            {
                initObject.ProductId = this.ProductId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordType"))
            {
                initObject.RecordType = this.RecordType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordVersion"))
            {
                initObject.RecordVersion = this.RecordVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SerialNumber"))
            {
                initObject.SerialNumber = this.SerialNumber;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VendorId"))
            {
                initObject.VendorId = this.VendorId;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryVpcDetails.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryVpcDetails")]
    public class InitializeIntersightNiatelemetryVpcDetails:PSCmdlet
	{
		public InitializeIntersightNiatelemetryVpcDetails()
		{
            ClassId = NiatelemetryVpcDetails.ClassIdEnum.NiatelemetryVpcDetails;
            ObjectType = NiatelemetryVpcDetails.ObjectTypeEnum.NiatelemetryVpcDetails;
            
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
        
        public NiatelemetryVpcDetails.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns boolean if VPC is configured on switch or not."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool IsVpcConfigured {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryVpcDetails.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns peer switch id if VPC configured."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long PeerSwitchDbId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns the switch id of the switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long SwitchDbId {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.NiatelemetryVpcDetails initObject = new Intersight.Model.NiatelemetryVpcDetails();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("IsVpcConfigured"))
            {
                initObject.IsVpcConfigured = this.IsVpcConfigured;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("PeerSwitchDbId"))
            {
                initObject.PeerSwitchDbId = this.PeerSwitchDbId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SwitchDbId"))
            {
                initObject.SwitchDbId = this.SwitchDbId;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryPodTimeServerPolicies.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryPodTimeServerPolicies")]
    public class InitializeIntersightNiatelemetryPodTimeServerPolicies:PSCmdlet
	{
		public InitializeIntersightNiatelemetryPodTimeServerPolicies()
		{
            ClassId = NiatelemetryPodTimeServerPolicies.ClassIdEnum.NiatelemetryPodTimeServerPolicies;
            ObjectType = NiatelemetryPodTimeServerPolicies.ObjectTypeEnum.NiatelemetryPodTimeServerPolicies;
            
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
        
        public NiatelemetryPodTimeServerPolicies.ClassIdEnum ClassId {
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryPodTimeServerPolicies.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Dn of the Time server Pol in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string PolDn {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of record DCNM / APIC / SE. This determines the type of platform where inventory was collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version of record being pushed. This determines what was the API version for data available from the device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the APIC site from which this data is being collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SiteName {
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
        // <summary>
        /// <para type="description">"Admin State of the time server Pol in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string TimeServerEnableSt {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Time server of the time server Pol in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string TimeServers {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.NiatelemetryPodTimeServerPolicies initObject = new Intersight.Model.NiatelemetryPodTimeServerPolicies();
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
            if (this.MyInvocation.BoundParameters.ContainsKey("PolDn"))
            {
                initObject.PolDn = this.PolDn;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordType"))
            {
                initObject.RecordType = this.RecordType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordVersion"))
            {
                initObject.RecordVersion = this.RecordVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SiteName"))
            {
                initObject.SiteName = this.SiteName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TimeServerEnableSt"))
            {
                initObject.TimeServerEnableSt = this.TimeServerEnableSt;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TimeServers"))
            {
                initObject.TimeServers = this.TimeServers;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryNiaFeatureUsage.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryNiaFeatureUsage")]
    public class InitializeIntersightNiatelemetryNiaFeatureUsage:PSCmdlet
	{
		public InitializeIntersightNiatelemetryNiaFeatureUsage()
		{
            ClassId = NiatelemetryNiaFeatureUsage.ClassIdEnum.NiatelemetryNiaFeatureUsage;
            ObjectType = NiatelemetryNiaFeatureUsage.ObjectTypeEnum.NiatelemetryNiaFeatureUsage;
            
		}
        // <summary>
        /// <para type="description">"Returns the total number of AAA Ldap Providers."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long AaaLdapProviderCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns the total number of AAA Radius Providers."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long AaaRadiusProviderCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns the total number of AAA Tacacs Providers."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long AaaTacacsProviderCount {
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
        /// <para type="description">"Number of APIC controllers. This determines the value of controllers for the fabric."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long ApicCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns if telnet is enabled on APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool ApicIsTelnetEnabled {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Count of NTP servers configured on APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long ApicNtpCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of SNMP communities configured on APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long ApicSnmpCommunityCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of logging groups configured on APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long ApicSysLogGrpCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of logging sources configured on APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long ApicSysLogSrcCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"ACI APPs feature usage scale."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long AppCenterCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"AVE feature usage. This determines if ACI virtual edge feature is enabled or disabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Ave {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of BDs. This determines the total number of Broadcast Domains across the fabric."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long BdCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of call home smart monitoring policies on the fabric."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long CallhomeSmartGroupCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryNiaFeatureUsage.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of Cloudsec SA peers."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long CloudSecPeerCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of compute hypervisors on the fabric."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long CompHvCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of system backup configure export policies on the fabric."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long ConfigExportpCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of system backup configure jobs on the fabric."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long ConfigJobCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Consistency checker application usage. This determines if the fabric has Consistency checker application installed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ConsistencyCheckerApp {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of contracts. This determines the total number of Contracts configured across the fabric."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long ContractCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"DNS feature usage. This determines the total number of DNS configurations across the fabric."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long DnsCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Eigrp feature usage. This determines the total number of EIGRP sessions across the fabric."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long EigrpCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of End Point Groups. This determines the total number of End Point Groups across the fabric."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long EpgCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns the total number of fabric module slots."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long FabricModuleCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of Multi-Pods per fabric."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long FabricSetuppCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Total number of FCoE N-Port for DOM, VSAn, and VLAN."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long FcoeNportCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of FCoE N-Port DOM."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long FcoeNportDomCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of FCoE N-Port VLAN."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long FcoeNportVlanCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of FCoE N-Port VSAN."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long FcoeNportVsanCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of Internet Protocol Service Level Agreements Monitoring policy objects for object tracking."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long FvSlaDefCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Hsrp feature usage. This determines the total number of HSRP sessions across the fabric."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long HsrpCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Ibgp feature usage. This determines the total number of BGP sessions across the fabric."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long IbgpCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"IGMP Access List feature usage. This determines the total number of IGMP access lists configured across the fabric."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long IgmpAccessListCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"IGMP Snooping feature usage. This determines if this feature is enabled or disabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string IgmpSnoop {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of IP based End Point Groups. This determines the total number of IP End Point Groups across the fabric."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long IpEpgCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"BGP route reflector usage on APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool IsBgpRouteReflectorsFeatureUsed {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Brodge domains feature usage on APIC controller."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool IsBridgeDomainsFeatureUsed {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns value of isCommonLocalUserName field."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool IsCommonLocalUserName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Contracts feature usage on APIC controller."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool IsContractsFeatureUsed {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"EPG feature usage on APIC controller."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool IsEpgFeatureUsed {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Filters feature usage on APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool IsFiltersFeatureUsed {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns if HTTP is configured."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool IsHttpConfigured {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns if HTTPS is configured."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool IsHttpsConfigured {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"NTP feature usage on APIC controller."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool IsNtpFeatureUsed {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Ptp feature usage on APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool IsPtpFeatureUsed {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Synce feature usage on APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool IsSynceFeatureUsed {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Status of techsupport collection."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string IsTechSupportCollected {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Tenants feature usage on APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool IsTenantsFeatureUsed {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"VRF feature usage on APIC controller."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool IsVrfsFeatureUsed {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Isis feature usage. This determines the total number of ISIS sessions across the fabric."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long IsisCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"L2Multicast feature usage. This determines if this Layer 2 Multicast feature is being enabled / disabled on the fabric."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string L2Multicast {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns the Latency ptp mode for the controller."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string LatencyPtpMode {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of Leafs. This determines the total number of Leaf switches in the fabric."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long LeafCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns count of local users."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long LocalUsernameCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns login block duration value."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long LoginBlockDuration {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns the maximum failed attempts on login."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long LoginMaxFailedAttempts {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns the maximum failed attempt windows on login."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long LoginMaxFailedAttemptsWindow {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Maintenance Mode feature usage. This determines the number of switches that are currently in maintenance mode."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long MaintenanceModeCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Management over IPv6 feature usage. This determines the total number of IPv6 configurtaions in the fabric."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long ManagementOverV6Count {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of Microsoft microsegmentation VmmEpPD objects. Ensures that Microsoft was configured."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long MicrosoftUsegVmmEpPdCount {
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
        /// <para type="description">"Number of Netflow monitor policies."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long NetFlowCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"NIR application usage. This determines if the fabric has NIR application installed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Nir {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryNiaFeatureUsage.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Open stack feature usage."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string OpenStack {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Opflex for Kubernetes feature usage. This determines the total number of VMM sessions of type kubernetes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long OpflexKubernetesCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Ospf feature usage. This determines the total number of OSPF sessions across the fabric."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long OspfCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns count of passwords."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long PasswordHistoryCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns if the password is strong or not."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string PasswordStrengthCheck {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns the number of password strength profile."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long PasswordStrengthProfileCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"POE feature usage. This determines the total number of POE configurations across the fabric."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long PoeCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of objects with Port Security enabled. Non-Zero value indicates the object as enabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long PortSecurityCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"QinVniTunnel feature usage. This determines if the qinVniTunnel feature is being used on the fabric and the scale of it."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long QinVniTunnelCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of Quality Of Service congestion class."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long QosCongCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of Quality Of Service class."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long QosPfcPolCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns the value of count of realms."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long RealmCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of record DCNM / APIC / SE. This determines the type of platform where inventory was collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version of record being pushed. This determines what was the API version for data available from the device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of remote Leafs. This determines the total number of remote leaf switches in the fabric."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long RemoteLeafCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"SCVMM feature usage. This determines the total number of SCVMM configurations in the fabric."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long ScvmmCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"SharedL3Out feature usage. This determines the total number of Shared L3 out configured across the fabric."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long SharedL3OutCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Site name represents an APIC cluster. Service Engine can onboard multiple APIC clusters / sites. There will be a feature usage object per site in Multi site scenario. In multi-site scenario the site name is available in all the requests being made."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SiteName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Smart callhome feature usage. This determines if this feature is being enabled or disabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SmartCallHome {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Details of smart license."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.NiatelemetrySmartLicense SmartLicense {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns count of snapshots."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long SnapshotCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"SNMP feature usage. This determines if this feature is enabled or disabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Snmp {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns count of SNMP Community Access."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long SnmpCommunityAccessCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of SNMP monitoring policies on the fabric."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long SnmpGroupCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns count of SNMP trap."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long SnmpTrapCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns count of SNMP V3 on the fabric."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long SnmpV3Count {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of Span Sources and Destinations."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long SpanCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of Span Destinations with valid state."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long SpanDstCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of Span Sources with valid state."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long SpanSrcCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of Spines. This determines the total number of spine switches in the fabric."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long SpineCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Ssh over IPv6 feature usage. This determines the total number of IPv6 configurtaions in the fabric."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long SshOverV6Count {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns count of ssh V2 on the fabric."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long SshV2Count {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns the total number of supervisor module slots."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long SupervisorModuleCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of syslog monitoring policies on the fabric."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long SyslogGroupCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Syslog over IPv6 feature usage. This determines the total number of IPv6 configurtaions in the fabric."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long SyslogOverV6Count {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns the total number of system controller slots."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long SystemControllerCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of tacacs monitoring policies on the fabric."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long TacacsGroupCount {
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
        // <summary>
        /// <para type="description">"Number of tenants. This determines the total number of tenants configured across the fabric."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long TenantCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of tier 2 Leafs. This determines the total number of tier 2 Leaf switches in the fabric."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long TierTwoLeafCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns the total number of critical faults."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long TotalCriticalFaults {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"TWAMP feature usage. This determines if this feature is enabled or disabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Twamp {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"VMM uSegmentation feature usage. This determines if microsegmentation feature is enabled or disabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Useg {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of objects with VmWare vCenter 6.5 support. Checks the controller revision value."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long VmWareVdsCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of Virtual Machine Monitor controller policy objects for VMware vCenter."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long VmmCtrlrpCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of Virtual Machine Monitor domain policy model objects for VMware vCenter."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long VmmDompCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Microsegmentation Distributed Virtual Switch feature usage. Gets the number of objects associated to VMware vCenter."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long VmmEpPdCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of objects with L4-L7 Device Package Import enabled. Checks for the vendor and the model."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long VnsmDevCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Virtual pod feature usage. This determines the total number of virtual POD configurations in the fabrics."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long VpodCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Timeout for web token in seconds."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long WebtokenTimeoutSeconds {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.NiatelemetryNiaFeatureUsage initObject = new Intersight.Model.NiatelemetryNiaFeatureUsage();
            if (this.MyInvocation.BoundParameters.ContainsKey("AaaLdapProviderCount"))
            {
                initObject.AaaLdapProviderCount = this.AaaLdapProviderCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AaaRadiusProviderCount"))
            {
                initObject.AaaRadiusProviderCount = this.AaaRadiusProviderCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AaaTacacsProviderCount"))
            {
                initObject.AaaTacacsProviderCount = this.AaaTacacsProviderCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ApicCount"))
            {
                initObject.ApicCount = this.ApicCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ApicIsTelnetEnabled"))
            {
                initObject.ApicIsTelnetEnabled = this.ApicIsTelnetEnabled;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ApicNtpCount"))
            {
                initObject.ApicNtpCount = this.ApicNtpCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ApicSnmpCommunityCount"))
            {
                initObject.ApicSnmpCommunityCount = this.ApicSnmpCommunityCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ApicSysLogGrpCount"))
            {
                initObject.ApicSysLogGrpCount = this.ApicSysLogGrpCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ApicSysLogSrcCount"))
            {
                initObject.ApicSysLogSrcCount = this.ApicSysLogSrcCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AppCenterCount"))
            {
                initObject.AppCenterCount = this.AppCenterCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Ave"))
            {
                initObject.Ave = this.Ave;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BdCount"))
            {
                initObject.BdCount = this.BdCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CallhomeSmartGroupCount"))
            {
                initObject.CallhomeSmartGroupCount = this.CallhomeSmartGroupCount;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("CloudSecPeerCount"))
            {
                initObject.CloudSecPeerCount = this.CloudSecPeerCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CompHvCount"))
            {
                initObject.CompHvCount = this.CompHvCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ConfigExportpCount"))
            {
                initObject.ConfigExportpCount = this.ConfigExportpCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ConfigJobCount"))
            {
                initObject.ConfigJobCount = this.ConfigJobCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ConsistencyCheckerApp"))
            {
                initObject.ConsistencyCheckerApp = this.ConsistencyCheckerApp;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ContractCount"))
            {
                initObject.ContractCount = this.ContractCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DnsCount"))
            {
                initObject.DnsCount = this.DnsCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EigrpCount"))
            {
                initObject.EigrpCount = this.EigrpCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EpgCount"))
            {
                initObject.EpgCount = this.EpgCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FabricModuleCount"))
            {
                initObject.FabricModuleCount = this.FabricModuleCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FabricSetuppCount"))
            {
                initObject.FabricSetuppCount = this.FabricSetuppCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FcoeNportCount"))
            {
                initObject.FcoeNportCount = this.FcoeNportCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FcoeNportDomCount"))
            {
                initObject.FcoeNportDomCount = this.FcoeNportDomCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FcoeNportVlanCount"))
            {
                initObject.FcoeNportVlanCount = this.FcoeNportVlanCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FcoeNportVsanCount"))
            {
                initObject.FcoeNportVsanCount = this.FcoeNportVsanCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FvSlaDefCount"))
            {
                initObject.FvSlaDefCount = this.FvSlaDefCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HsrpCount"))
            {
                initObject.HsrpCount = this.HsrpCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IbgpCount"))
            {
                initObject.IbgpCount = this.IbgpCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IgmpAccessListCount"))
            {
                initObject.IgmpAccessListCount = this.IgmpAccessListCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IgmpSnoop"))
            {
                initObject.IgmpSnoop = this.IgmpSnoop;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IpEpgCount"))
            {
                initObject.IpEpgCount = this.IpEpgCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IsBgpRouteReflectorsFeatureUsed"))
            {
                initObject.IsBgpRouteReflectorsFeatureUsed = this.IsBgpRouteReflectorsFeatureUsed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IsBridgeDomainsFeatureUsed"))
            {
                initObject.IsBridgeDomainsFeatureUsed = this.IsBridgeDomainsFeatureUsed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IsCommonLocalUserName"))
            {
                initObject.IsCommonLocalUserName = this.IsCommonLocalUserName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IsContractsFeatureUsed"))
            {
                initObject.IsContractsFeatureUsed = this.IsContractsFeatureUsed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IsEpgFeatureUsed"))
            {
                initObject.IsEpgFeatureUsed = this.IsEpgFeatureUsed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IsFiltersFeatureUsed"))
            {
                initObject.IsFiltersFeatureUsed = this.IsFiltersFeatureUsed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IsHttpConfigured"))
            {
                initObject.IsHttpConfigured = this.IsHttpConfigured;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IsHttpsConfigured"))
            {
                initObject.IsHttpsConfigured = this.IsHttpsConfigured;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IsNtpFeatureUsed"))
            {
                initObject.IsNtpFeatureUsed = this.IsNtpFeatureUsed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IsPtpFeatureUsed"))
            {
                initObject.IsPtpFeatureUsed = this.IsPtpFeatureUsed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IsSynceFeatureUsed"))
            {
                initObject.IsSynceFeatureUsed = this.IsSynceFeatureUsed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IsTechSupportCollected"))
            {
                initObject.IsTechSupportCollected = this.IsTechSupportCollected;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IsTenantsFeatureUsed"))
            {
                initObject.IsTenantsFeatureUsed = this.IsTenantsFeatureUsed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IsVrfsFeatureUsed"))
            {
                initObject.IsVrfsFeatureUsed = this.IsVrfsFeatureUsed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IsisCount"))
            {
                initObject.IsisCount = this.IsisCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("L2Multicast"))
            {
                initObject.L2Multicast = this.L2Multicast;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LatencyPtpMode"))
            {
                initObject.LatencyPtpMode = this.LatencyPtpMode;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LeafCount"))
            {
                initObject.LeafCount = this.LeafCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LocalUsernameCount"))
            {
                initObject.LocalUsernameCount = this.LocalUsernameCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LoginBlockDuration"))
            {
                initObject.LoginBlockDuration = this.LoginBlockDuration;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LoginMaxFailedAttempts"))
            {
                initObject.LoginMaxFailedAttempts = this.LoginMaxFailedAttempts;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LoginMaxFailedAttemptsWindow"))
            {
                initObject.LoginMaxFailedAttemptsWindow = this.LoginMaxFailedAttemptsWindow;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaintenanceModeCount"))
            {
                initObject.MaintenanceModeCount = this.MaintenanceModeCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ManagementOverV6Count"))
            {
                initObject.ManagementOverV6Count = this.ManagementOverV6Count;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MicrosoftUsegVmmEpPdCount"))
            {
                initObject.MicrosoftUsegVmmEpPdCount = this.MicrosoftUsegVmmEpPdCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NetFlowCount"))
            {
                initObject.NetFlowCount = this.NetFlowCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Nir"))
            {
                initObject.Nir = this.Nir;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("OpenStack"))
            {
                initObject.OpenStack = this.OpenStack;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("OpflexKubernetesCount"))
            {
                initObject.OpflexKubernetesCount = this.OpflexKubernetesCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("OspfCount"))
            {
                initObject.OspfCount = this.OspfCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PasswordHistoryCount"))
            {
                initObject.PasswordHistoryCount = this.PasswordHistoryCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PasswordStrengthCheck"))
            {
                initObject.PasswordStrengthCheck = this.PasswordStrengthCheck;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PasswordStrengthProfileCount"))
            {
                initObject.PasswordStrengthProfileCount = this.PasswordStrengthProfileCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PoeCount"))
            {
                initObject.PoeCount = this.PoeCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PortSecurityCount"))
            {
                initObject.PortSecurityCount = this.PortSecurityCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("QinVniTunnelCount"))
            {
                initObject.QinVniTunnelCount = this.QinVniTunnelCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("QosCongCount"))
            {
                initObject.QosCongCount = this.QosCongCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("QosPfcPolCount"))
            {
                initObject.QosPfcPolCount = this.QosPfcPolCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RealmCount"))
            {
                initObject.RealmCount = this.RealmCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordType"))
            {
                initObject.RecordType = this.RecordType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordVersion"))
            {
                initObject.RecordVersion = this.RecordVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RemoteLeafCount"))
            {
                initObject.RemoteLeafCount = this.RemoteLeafCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ScvmmCount"))
            {
                initObject.ScvmmCount = this.ScvmmCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SharedL3OutCount"))
            {
                initObject.SharedL3OutCount = this.SharedL3OutCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SiteName"))
            {
                initObject.SiteName = this.SiteName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SmartCallHome"))
            {
                initObject.SmartCallHome = this.SmartCallHome;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SmartLicense"))
            {
                initObject.SmartLicense = this.SmartLicense;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SnapshotCount"))
            {
                initObject.SnapshotCount = this.SnapshotCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Snmp"))
            {
                initObject.Snmp = this.Snmp;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SnmpCommunityAccessCount"))
            {
                initObject.SnmpCommunityAccessCount = this.SnmpCommunityAccessCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SnmpGroupCount"))
            {
                initObject.SnmpGroupCount = this.SnmpGroupCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SnmpTrapCount"))
            {
                initObject.SnmpTrapCount = this.SnmpTrapCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SnmpV3Count"))
            {
                initObject.SnmpV3Count = this.SnmpV3Count;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SpanCount"))
            {
                initObject.SpanCount = this.SpanCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SpanDstCount"))
            {
                initObject.SpanDstCount = this.SpanDstCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SpanSrcCount"))
            {
                initObject.SpanSrcCount = this.SpanSrcCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SpineCount"))
            {
                initObject.SpineCount = this.SpineCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SshOverV6Count"))
            {
                initObject.SshOverV6Count = this.SshOverV6Count;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SshV2Count"))
            {
                initObject.SshV2Count = this.SshV2Count;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SupervisorModuleCount"))
            {
                initObject.SupervisorModuleCount = this.SupervisorModuleCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SyslogGroupCount"))
            {
                initObject.SyslogGroupCount = this.SyslogGroupCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SyslogOverV6Count"))
            {
                initObject.SyslogOverV6Count = this.SyslogOverV6Count;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SystemControllerCount"))
            {
                initObject.SystemControllerCount = this.SystemControllerCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TacacsGroupCount"))
            {
                initObject.TacacsGroupCount = this.TacacsGroupCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TenantCount"))
            {
                initObject.TenantCount = this.TenantCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TierTwoLeafCount"))
            {
                initObject.TierTwoLeafCount = this.TierTwoLeafCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TotalCriticalFaults"))
            {
                initObject.TotalCriticalFaults = this.TotalCriticalFaults;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Twamp"))
            {
                initObject.Twamp = this.Twamp;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Useg"))
            {
                initObject.Useg = this.Useg;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VmWareVdsCount"))
            {
                initObject.VmWareVdsCount = this.VmWareVdsCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VmmCtrlrpCount"))
            {
                initObject.VmmCtrlrpCount = this.VmmCtrlrpCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VmmDompCount"))
            {
                initObject.VmmDompCount = this.VmmDompCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VmmEpPdCount"))
            {
                initObject.VmmEpPdCount = this.VmmEpPdCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VnsmDevCount"))
            {
                initObject.VnsmDevCount = this.VnsmDevCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VpodCount"))
            {
                initObject.VpodCount = this.VpodCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("WebtokenTimeoutSeconds"))
            {
                initObject.WebtokenTimeoutSeconds = this.WebtokenTimeoutSeconds;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryNiaInventoryDcnm.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryNiaInventoryDcnm")]
    public class InitializeIntersightNiatelemetryNiaInventoryDcnm:PSCmdlet
	{
		public InitializeIntersightNiatelemetryNiaInventoryDcnm()
		{
            ClassId = NiatelemetryNiaInventoryDcnm.ClassIdEnum.NiatelemetryNiaInventoryDcnm;
            ObjectType = NiatelemetryNiaInventoryDcnm.ObjectTypeEnum.NiatelemetryNiaInventoryDcnm;
            
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
        
        public NiatelemetryNiaInventoryDcnm.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Health of controller on DCNM."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long ControllerHealth {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns the value of the dev Field."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Dev {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of EPLD images uploaded to DCNM."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long EpldImageCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Model.NiatelemetryImageDetail> GoldenImageDetails {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns the value of the haEnabled field."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool HaEnabled {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns the value of the haReplicationStatus field."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string HaReplicationStatus {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns the value of the install field."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Install {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Installation type of controller on DCNM."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string InstallationType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Installation type description of controller on DCNM."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string InstallationTypeDescription {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns true if ISN is configured."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool IsIsnConfigured {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns the value of the isMediaController field."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool IsMediaController {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns true if the Smart license is enabled and is in use."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool IsSmartLicenseEnabled {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Mode of controller on DCNM."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Mode {
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
        /// <para type="description">"Installation type description of controller on DCNM."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.NiatelemetryNetworkInfo NetworkInfo {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns total number of fabrics in DCNM set-up."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long NumFabrics {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns the number of fabrics in msd."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long NumFabricsInMsd {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns the number of fabrics that have ingress replication type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long NumIngressReplicationFabrics {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns the number of local users other than admin user."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long NumLocalUsers {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns the number of MSD fabrics."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long NumMsd {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns the number of svi interfaces configured for VRF vlans."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long NumSviVrfCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns the number of links where TRM is enabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long NumTrmEnabledCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of users who have upgrade privileges excluding the admin."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long NumUpgUsers {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of NXOS images uploaded to DCNM."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long NxosImageCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryNiaInventoryDcnm.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Out of band IP of controller on DCNM."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string OutofbandIp {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Serial number of device being inventoried. The serial number is unique per device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Serial {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of fabric domain of the controller."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SiteName {
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
        // <summary>
        /// <para type="description">"Returns the number of underlay peering active links."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long UnderlayPeeringActiveLinksCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of upgrade jobs configured on DCNM."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long UpgJobCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Model.NiatelemetryJobDetail> UpgStatus {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns the value of the version field."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Version {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.NiatelemetryNiaInventoryDcnm initObject = new Intersight.Model.NiatelemetryNiaInventoryDcnm();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ControllerHealth"))
            {
                initObject.ControllerHealth = this.ControllerHealth;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Dev"))
            {
                initObject.Dev = this.Dev;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EpldImageCount"))
            {
                initObject.EpldImageCount = this.EpldImageCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("GoldenImageDetails"))
            {
                initObject.GoldenImageDetails = this.GoldenImageDetails;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HaEnabled"))
            {
                initObject.HaEnabled = this.HaEnabled;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HaReplicationStatus"))
            {
                initObject.HaReplicationStatus = this.HaReplicationStatus;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Install"))
            {
                initObject.Install = this.Install;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InstallationType"))
            {
                initObject.InstallationType = this.InstallationType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InstallationTypeDescription"))
            {
                initObject.InstallationTypeDescription = this.InstallationTypeDescription;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IsIsnConfigured"))
            {
                initObject.IsIsnConfigured = this.IsIsnConfigured;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IsMediaController"))
            {
                initObject.IsMediaController = this.IsMediaController;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IsSmartLicenseEnabled"))
            {
                initObject.IsSmartLicenseEnabled = this.IsSmartLicenseEnabled;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Mode"))
            {
                initObject.Mode = this.Mode;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NetworkInfo"))
            {
                initObject.NetworkInfo = this.NetworkInfo;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NumFabrics"))
            {
                initObject.NumFabrics = this.NumFabrics;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NumFabricsInMsd"))
            {
                initObject.NumFabricsInMsd = this.NumFabricsInMsd;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NumIngressReplicationFabrics"))
            {
                initObject.NumIngressReplicationFabrics = this.NumIngressReplicationFabrics;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NumLocalUsers"))
            {
                initObject.NumLocalUsers = this.NumLocalUsers;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NumMsd"))
            {
                initObject.NumMsd = this.NumMsd;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NumSviVrfCount"))
            {
                initObject.NumSviVrfCount = this.NumSviVrfCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NumTrmEnabledCount"))
            {
                initObject.NumTrmEnabledCount = this.NumTrmEnabledCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NumUpgUsers"))
            {
                initObject.NumUpgUsers = this.NumUpgUsers;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NxosImageCount"))
            {
                initObject.NxosImageCount = this.NxosImageCount;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("OutofbandIp"))
            {
                initObject.OutofbandIp = this.OutofbandIp;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Serial"))
            {
                initObject.Serial = this.Serial;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SiteName"))
            {
                initObject.SiteName = this.SiteName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UnderlayPeeringActiveLinksCount"))
            {
                initObject.UnderlayPeeringActiveLinksCount = this.UnderlayPeeringActiveLinksCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UpgJobCount"))
            {
                initObject.UpgJobCount = this.UpgJobCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UpgStatus"))
            {
                initObject.UpgStatus = this.UpgStatus;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Version"))
            {
                initObject._Version = this.Version;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryPasswordStrengthCheck.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryPasswordStrengthCheck")]
    public class InitializeIntersightNiatelemetryPasswordStrengthCheck:PSCmdlet
	{
		public InitializeIntersightNiatelemetryPasswordStrengthCheck()
		{
            ClassId = NiatelemetryPasswordStrengthCheck.ClassIdEnum.NiatelemetryPasswordStrengthCheck;
            ObjectType = NiatelemetryPasswordStrengthCheck.ObjectTypeEnum.NiatelemetryPasswordStrengthCheck;
            
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
        
        public NiatelemetryPasswordStrengthCheck.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Dn for each registering user in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Dn {
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryPasswordStrengthCheck.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Check for password strength per user."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string PwdStrengthCheck {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of record DCNM / APIC / SE. This determines the type of platform where inventory was collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version of record being pushed. This determines what was the API version for data available from the device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the APIC site from which this data is being collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SiteName {
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
             Intersight.Model.NiatelemetryPasswordStrengthCheck initObject = new Intersight.Model.NiatelemetryPasswordStrengthCheck();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Dn"))
            {
                initObject.Dn = this.Dn;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("PwdStrengthCheck"))
            {
                initObject.PwdStrengthCheck = this.PwdStrengthCheck;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordType"))
            {
                initObject.RecordType = this.RecordType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordVersion"))
            {
                initObject.RecordVersion = this.RecordVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SiteName"))
            {
                initObject.SiteName = this.SiteName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryApicCoreFileDetails.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryApicCoreFileDetails")]
    public class InitializeIntersightNiatelemetryApicCoreFileDetails:PSCmdlet
	{
		public InitializeIntersightNiatelemetryApicCoreFileDetails()
		{
            ClassId = NiatelemetryApicCoreFileDetails.ClassIdEnum.NiatelemetryApicCoreFileDetails;
            ObjectType = NiatelemetryApicCoreFileDetails.ObjectTypeEnum.NiatelemetryApicCoreFileDetails;
            
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
        /// <para type="description">"Annotation of the Core file in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Annotation {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Child action of the Core file in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ChildAction {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryApicCoreFileDetails.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Collection Time of the Core file in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string CollectionTime {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Data type of the Core file in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string DataType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Dn for the Core file in the inventory."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Dn {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Export file URI of the Core file in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ExportFileUri {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Export status of the Core file in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ExportStatus {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Export status str of the Core file in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long ExportStatusStr {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Export tech Sup file URI of the Core file in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ExportTechSupFileUri {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Return if file is exported To Controller or not in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ExportedToController {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Ext Mngd By of the Core file in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ExtMngdBy {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"File size of the Core file in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long FileSize {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Host Name of the Core file in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string HostName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Lc owner of the Core file in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string LcOwn {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Mod Ts of the Core file in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long ModTs {
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
        /// <para type="description">"Node Id of the Core file in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string NodeId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryApicCoreFileDetails.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Pol Name of the Core file in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string PolName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of record DCNM / APIC / SE. This determines the type of platform where inventory was collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version of record being pushed. This determines what was the API version for data available from the device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the APIC site from which this data is being collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SiteName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Status of the Core file in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Status {
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
        // <summary>
        /// <para type="description">"UId of the Core file in the APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Uid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"User dom of the Core file in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Userdom {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.NiatelemetryApicCoreFileDetails initObject = new Intersight.Model.NiatelemetryApicCoreFileDetails();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Annotation"))
            {
                initObject.Annotation = this.Annotation;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ChildAction"))
            {
                initObject.ChildAction = this.ChildAction;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("CollectionTime"))
            {
                initObject.CollectionTime = this.CollectionTime;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DataType"))
            {
                initObject.DataType = this.DataType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Dn"))
            {
                initObject.Dn = this.Dn;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ExportFileUri"))
            {
                initObject.ExportFileUri = this.ExportFileUri;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ExportStatus"))
            {
                initObject.ExportStatus = this.ExportStatus;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ExportStatusStr"))
            {
                initObject.ExportStatusStr = this.ExportStatusStr;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ExportTechSupFileUri"))
            {
                initObject.ExportTechSupFileUri = this.ExportTechSupFileUri;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ExportedToController"))
            {
                initObject.ExportedToController = this.ExportedToController;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ExtMngdBy"))
            {
                initObject.ExtMngdBy = this.ExtMngdBy;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FileSize"))
            {
                initObject.FileSize = this.FileSize;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HostName"))
            {
                initObject.HostName = this.HostName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LcOwn"))
            {
                initObject.LcOwn = this.LcOwn;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ModTs"))
            {
                initObject.ModTs = this.ModTs;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("PolName"))
            {
                initObject.PolName = this.PolName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordType"))
            {
                initObject.RecordType = this.RecordType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordVersion"))
            {
                initObject.RecordVersion = this.RecordVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SiteName"))
            {
                initObject.SiteName = this.SiteName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Status"))
            {
                initObject.Status = this.Status;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Uid"))
            {
                initObject.Uid = this.Uid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Userdom"))
            {
                initObject.Userdom = this.Userdom;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetrySyslogSysMsg.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetrySyslogSysMsg")]
    public class InitializeIntersightNiatelemetrySyslogSysMsg:PSCmdlet
	{
		public InitializeIntersightNiatelemetrySyslogSysMsg()
		{
            ClassId = NiatelemetrySyslogSysMsg.ClassIdEnum.NiatelemetrySyslogSysMsg;
            ObjectType = NiatelemetrySyslogSysMsg.ObjectTypeEnum.NiatelemetrySyslogSysMsg;
            
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
        
        public NiatelemetrySyslogSysMsg.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Parent common policy for syslog msg in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string CommonPolicy {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Dn of the Syslog System msg in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Dn {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"List of Facility filter DN of the Syslog System msg in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string FacilityFilter {
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetrySyslogSysMsg.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of record DCNM / APIC / SE. This determines the type of platform where inventory was collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version of record being pushed. This determines what was the API version for data available from the device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the APIC site from which this data is being collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SiteName {
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
             Intersight.Model.NiatelemetrySyslogSysMsg initObject = new Intersight.Model.NiatelemetrySyslogSysMsg();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("CommonPolicy"))
            {
                initObject.CommonPolicy = this.CommonPolicy;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Dn"))
            {
                initObject.Dn = this.Dn;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FacilityFilter"))
            {
                initObject.FacilityFilter = this.FacilityFilter;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordType"))
            {
                initObject.RecordType = this.RecordType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordVersion"))
            {
                initObject.RecordVersion = this.RecordVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SiteName"))
            {
                initObject.SiteName = this.SiteName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryHttpsAclContractDetails.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryHttpsAclContractDetails")]
    public class InitializeIntersightNiatelemetryHttpsAclContractDetails:PSCmdlet
	{
		public InitializeIntersightNiatelemetryHttpsAclContractDetails()
		{
            ClassId = NiatelemetryHttpsAclContractDetails.ClassIdEnum.NiatelemetryHttpsAclContractDetails;
            ObjectType = NiatelemetryHttpsAclContractDetails.ObjectTypeEnum.NiatelemetryHttpsAclContractDetails;
            
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
        
        public NiatelemetryHttpsAclContractDetails.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Consumer Dn of the HTTPS ACL contract children MOs for APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ConsumerDn {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of HTTPS ACL contract for APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ContractName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Mgmt Inst Dn of the HTTPS ACL contract children MOs for APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string MgmtInstpDn {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Mgmt subnet address of the HTTPS ACL contract children MOs for APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string MgmtSubnetAddresses {
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryHttpsAclContractDetails.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Provider dn of the HTTPS ACL contract children MOs for APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ProviderDn {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of record DCNM / APIC / SE. This determines the type of platform where inventory was collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version of record being pushed. This determines what was the API version for data available from the device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the APIC site from which this data is being collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SiteName {
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
             Intersight.Model.NiatelemetryHttpsAclContractDetails initObject = new Intersight.Model.NiatelemetryHttpsAclContractDetails();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ConsumerDn"))
            {
                initObject.ConsumerDn = this.ConsumerDn;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ContractName"))
            {
                initObject.ContractName = this.ContractName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MgmtInstpDn"))
            {
                initObject.MgmtInstpDn = this.MgmtInstpDn;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MgmtSubnetAddresses"))
            {
                initObject.MgmtSubnetAddresses = this.MgmtSubnetAddresses;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("ProviderDn"))
            {
                initObject.ProviderDn = this.ProviderDn;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordType"))
            {
                initObject.RecordType = this.RecordType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordVersion"))
            {
                initObject.RecordVersion = this.RecordVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SiteName"))
            {
                initObject.SiteName = this.SiteName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryInsightGroupDetails.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryInsightGroupDetails")]
    public class InitializeIntersightNiatelemetryInsightGroupDetails:PSCmdlet
	{
		public InitializeIntersightNiatelemetryInsightGroupDetails()
		{
            ClassId = NiatelemetryInsightGroupDetails.ClassIdEnum.NiatelemetryInsightGroupDetails;
            ObjectType = NiatelemetryInsightGroupDetails.ObjectTypeEnum.NiatelemetryInsightGroupDetails;
            
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
        /// <para type="description">"Alert rules count of the Insight group."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long AlertRulesCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Analysis setting status of the Insight group."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string AnalysisSettingsStatus {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Bug scan settings status of the Insight group."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string BugScanSettingsStatus {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryInsightGroupDetails.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Delta analysis job count of the Insight group."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long DeltaAnalysisJobCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Email settings count of the Insight group."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long EmailSettingsCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Flow setting count of the Insight group."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long FlowSettingsCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the Insight group."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string GroupName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Kafka settings count of the Insight group."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long KafkaSettingsCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Microburst setting status of the Insight group."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string MicroBurstSettingsStatus {
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryInsightGroupDetails.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Prechange analysis count of the Insight group."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long PrechangeAnalysisCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"TAC collection config count of the Insight group."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long TacCollectionConfigCount {
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
             Intersight.Model.NiatelemetryInsightGroupDetails initObject = new Intersight.Model.NiatelemetryInsightGroupDetails();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AlertRulesCount"))
            {
                initObject.AlertRulesCount = this.AlertRulesCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AnalysisSettingsStatus"))
            {
                initObject.AnalysisSettingsStatus = this.AnalysisSettingsStatus;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BugScanSettingsStatus"))
            {
                initObject.BugScanSettingsStatus = this.BugScanSettingsStatus;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("DeltaAnalysisJobCount"))
            {
                initObject.DeltaAnalysisJobCount = this.DeltaAnalysisJobCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EmailSettingsCount"))
            {
                initObject.EmailSettingsCount = this.EmailSettingsCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FlowSettingsCount"))
            {
                initObject.FlowSettingsCount = this.FlowSettingsCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("GroupName"))
            {
                initObject.GroupName = this.GroupName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("KafkaSettingsCount"))
            {
                initObject.KafkaSettingsCount = this.KafkaSettingsCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MicroBurstSettingsStatus"))
            {
                initObject.MicroBurstSettingsStatus = this.MicroBurstSettingsStatus;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("PrechangeAnalysisCount"))
            {
                initObject.PrechangeAnalysisCount = this.PrechangeAnalysisCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TacCollectionConfigCount"))
            {
                initObject.TacCollectionConfigCount = this.TacCollectionConfigCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryPodSnmpPolicies.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryPodSnmpPolicies")]
    public class InitializeIntersightNiatelemetryPodSnmpPolicies:PSCmdlet
	{
		public InitializeIntersightNiatelemetryPodSnmpPolicies()
		{
            ClassId = NiatelemetryPodSnmpPolicies.ClassIdEnum.NiatelemetryPodSnmpPolicies;
            ObjectType = NiatelemetryPodSnmpPolicies.ObjectTypeEnum.NiatelemetryPodSnmpPolicies;
            
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
        /// <para type="description">"Admin State of the Snmp Pol in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string AdminSt {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryPodSnmpPolicies.ClassIdEnum ClassId {
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryPodSnmpPolicies.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Dn of the Snmp Pol in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string PolDn {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of record DCNM / APIC / SE. This determines the type of platform where inventory was collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version of record being pushed. This determines what was the API version for data available from the device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the APIC site from which this data is being collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SiteName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"List of Dn of the SNMP Client grp in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SnmpClientGrp {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"List of Dn of the SNMP Community in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SnmpCommunity {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"List of Dn of the SNMP Trap Fwd Server in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SnmpTrapFwdServer {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"List of Dn of the SNMP user in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SnmpUser {
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
             Intersight.Model.NiatelemetryPodSnmpPolicies initObject = new Intersight.Model.NiatelemetryPodSnmpPolicies();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdminSt"))
            {
                initObject.AdminSt = this.AdminSt;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("PolDn"))
            {
                initObject.PolDn = this.PolDn;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordType"))
            {
                initObject.RecordType = this.RecordType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordVersion"))
            {
                initObject.RecordVersion = this.RecordVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SiteName"))
            {
                initObject.SiteName = this.SiteName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SnmpClientGrp"))
            {
                initObject.SnmpClientGrp = this.SnmpClientGrp;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SnmpCommunity"))
            {
                initObject.SnmpCommunity = this.SnmpCommunity;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SnmpTrapFwdServer"))
            {
                initObject.SnmpTrapFwdServer = this.SnmpTrapFwdServer;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SnmpUser"))
            {
                initObject.SnmpUser = this.SnmpUser;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryDcnmTransceiverDetails.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryDcnmTransceiverDetails")]
    public class InitializeIntersightNiatelemetryDcnmTransceiverDetails:PSCmdlet
	{
		public InitializeIntersightNiatelemetryDcnmTransceiverDetails()
		{
            ClassId = NiatelemetryDcnmTransceiverDetails.ClassIdEnum.NiatelemetryDcnmTransceiverDetails;
            ObjectType = NiatelemetryDcnmTransceiverDetails.ObjectTypeEnum.NiatelemetryDcnmTransceiverDetails;
            
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
        
        public NiatelemetryDcnmTransceiverDetails.ClassIdEnum ClassId {
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryDcnmTransceiverDetails.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Part number of the transceiver in the fabric inventory."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string PartNumber {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Product Id of the transceiver in the fabric inventory."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ProductId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of record DCNM / APIC / SE. This determines the type of platform where inventory was collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version of record being pushed. This determines what was the API version for data available from the device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Serial number of the transceiver in the fabric inventory."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SerialNumber {
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
        // <summary>
        /// <para type="description">"Vendor Id of the transceiver in the fabric inventory."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string VendorId {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.NiatelemetryDcnmTransceiverDetails initObject = new Intersight.Model.NiatelemetryDcnmTransceiverDetails();
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
            if (this.MyInvocation.BoundParameters.ContainsKey("PartNumber"))
            {
                initObject.PartNumber = this.PartNumber;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ProductId"))
            {
                initObject.ProductId = this.ProductId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordType"))
            {
                initObject.RecordType = this.RecordType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordVersion"))
            {
                initObject.RecordVersion = this.RecordVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SerialNumber"))
            {
                initObject.SerialNumber = this.SerialNumber;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VendorId"))
            {
                initObject.VendorId = this.VendorId;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryMsoTenantDetails.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryMsoTenantDetails")]
    public class InitializeIntersightNiatelemetryMsoTenantDetails:PSCmdlet
	{
		public InitializeIntersightNiatelemetryMsoTenantDetails()
		{
            ClassId = NiatelemetryMsoTenantDetails.ClassIdEnum.NiatelemetryMsoTenantDetails;
            ObjectType = NiatelemetryMsoTenantDetails.ObjectTypeEnum.NiatelemetryMsoTenantDetails;
            
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
        
        public NiatelemetryMsoTenantDetails.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Site IDs to which this tenant is deployed to."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string DeployedSites {
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
        /// <para type="description">"Number of schemas assigned to each tenant in Multi-Site Orchestrator."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long NumberOfSchemasAssignedPerTenantInMso {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryMsoTenantDetails.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of sites each tenant is deployed to."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long SitesEachTenantIsDeployedToInMso {
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
        // <summary>
        /// <para type="description">"ID of tenant in Multi-Site Orchestrator."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string TenantId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the tenant in Multi-Site Orchestrator."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string TenantName {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.NiatelemetryMsoTenantDetails initObject = new Intersight.Model.NiatelemetryMsoTenantDetails();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("DeployedSites"))
            {
                initObject.DeployedSites = this.DeployedSites;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NumberOfSchemasAssignedPerTenantInMso"))
            {
                initObject.NumberOfSchemasAssignedPerTenantInMso = this.NumberOfSchemasAssignedPerTenantInMso;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("SitesEachTenantIsDeployedToInMso"))
            {
                initObject.SitesEachTenantIsDeployedToInMso = this.SitesEachTenantIsDeployedToInMso;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TenantId"))
            {
                initObject.TenantId = this.TenantId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TenantName"))
            {
                initObject.TenantName = this.TenantName;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryApicNtpAuth.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryApicNtpAuth")]
    public class InitializeIntersightNiatelemetryApicNtpAuth:PSCmdlet
	{
		public InitializeIntersightNiatelemetryApicNtpAuth()
		{
            ClassId = NiatelemetryApicNtpAuth.ClassIdEnum.NiatelemetryApicNtpAuth;
            ObjectType = NiatelemetryApicNtpAuth.ObjectTypeEnum.NiatelemetryApicNtpAuth;
            
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
        /// <para type="description">"Authentication state of NTP policy in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string AuthSt {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryApicNtpAuth.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Dn of the NTP Auth in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Dn {
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryApicNtpAuth.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of record DCNM / APIC / SE. This determines the type of platform where inventory was collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version of record being pushed. This determines what was the API version for data available from the device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the APIC site from which this data is being collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SiteName {
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
             Intersight.Model.NiatelemetryApicNtpAuth initObject = new Intersight.Model.NiatelemetryApicNtpAuth();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AuthSt"))
            {
                initObject.AuthSt = this.AuthSt;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Dn"))
            {
                initObject.Dn = this.Dn;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordType"))
            {
                initObject.RecordType = this.RecordType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordVersion"))
            {
                initObject.RecordVersion = this.RecordVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SiteName"))
            {
                initObject.SiteName = this.SiteName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryApicTransceiverDetails.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryApicTransceiverDetails")]
    public class InitializeIntersightNiatelemetryApicTransceiverDetails:PSCmdlet
	{
		public InitializeIntersightNiatelemetryApicTransceiverDetails()
		{
            ClassId = NiatelemetryApicTransceiverDetails.ClassIdEnum.NiatelemetryApicTransceiverDetails;
            ObjectType = NiatelemetryApicTransceiverDetails.ObjectTypeEnum.NiatelemetryApicTransceiverDetails;
            
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
        
        public NiatelemetryApicTransceiverDetails.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Dn of the Transceiver in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Dn {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Model of the Transceiver in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Model {
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryApicTransceiverDetails.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Part Number of the Transceiver in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string PartNumber {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of record DCNM / APIC / SE. This determines the type of platform where inventory was collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version of record being pushed. This determines what was the API version for data available from the device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Serial number of the Transceiver in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SerialNumber {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the APIC site from which this data is being collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SiteName {
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
        // <summary>
        /// <para type="description">"Vendor of the Transceiver in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Vendor {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.NiatelemetryApicTransceiverDetails initObject = new Intersight.Model.NiatelemetryApicTransceiverDetails();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Dn"))
            {
                initObject.Dn = this.Dn;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Model"))
            {
                initObject.Model = this.Model;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("PartNumber"))
            {
                initObject.PartNumber = this.PartNumber;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordType"))
            {
                initObject.RecordType = this.RecordType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordVersion"))
            {
                initObject.RecordVersion = this.RecordVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SerialNumber"))
            {
                initObject.SerialNumber = this.SerialNumber;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SiteName"))
            {
                initObject.SiteName = this.SiteName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Vendor"))
            {
                initObject.Vendor = this.Vendor;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryHttpsAclEpgDetails.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryHttpsAclEpgDetails")]
    public class InitializeIntersightNiatelemetryHttpsAclEpgDetails:PSCmdlet
	{
		public InitializeIntersightNiatelemetryHttpsAclEpgDetails()
		{
            ClassId = NiatelemetryHttpsAclEpgDetails.ClassIdEnum.NiatelemetryHttpsAclEpgDetails;
            ObjectType = NiatelemetryHttpsAclEpgDetails.ObjectTypeEnum.NiatelemetryHttpsAclEpgDetails;
            
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
        
        public NiatelemetryHttpsAclEpgDetails.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Dn of the HTTPS ACL EPG for APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Dn {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of EPGs of the HTTPS ACL EPG for APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string EpgName {
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryHttpsAclEpgDetails.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of record DCNM / APIC / SE. This determines the type of platform where inventory was collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version of record being pushed. This determines what was the API version for data available from the device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the APIC site from which this data is being collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SiteName {
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
             Intersight.Model.NiatelemetryHttpsAclEpgDetails initObject = new Intersight.Model.NiatelemetryHttpsAclEpgDetails();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Dn"))
            {
                initObject.Dn = this.Dn;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EpgName"))
            {
                initObject.EpgName = this.EpgName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordType"))
            {
                initObject.RecordType = this.RecordType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordVersion"))
            {
                initObject.RecordVersion = this.RecordVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SiteName"))
            {
                initObject.SiteName = this.SiteName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryAaaTacacsProviderDetails.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryAaaTacacsProviderDetails")]
    public class InitializeIntersightNiatelemetryAaaTacacsProviderDetails:PSCmdlet
	{
		public InitializeIntersightNiatelemetryAaaTacacsProviderDetails()
		{
            ClassId = NiatelemetryAaaTacacsProviderDetails.ClassIdEnum.NiatelemetryAaaTacacsProviderDetails;
            ObjectType = NiatelemetryAaaTacacsProviderDetails.ObjectTypeEnum.NiatelemetryAaaTacacsProviderDetails;
            
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
        
        public NiatelemetryAaaTacacsProviderDetails.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Dn of the AAA tacacs provider in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Dn {
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryAaaTacacsProviderDetails.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Owner Key of the AAA tacacs provider in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string OwnerKey {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of record DCNM / APIC / SE. This determines the type of platform where inventory was collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version of record being pushed. This determines what was the API version for data available from the device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the APIC site from which this data is being collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SiteName {
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
             Intersight.Model.NiatelemetryAaaTacacsProviderDetails initObject = new Intersight.Model.NiatelemetryAaaTacacsProviderDetails();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Dn"))
            {
                initObject.Dn = this.Dn;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("OwnerKey"))
            {
                initObject.OwnerKey = this.OwnerKey;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordType"))
            {
                initObject.RecordType = this.RecordType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordVersion"))
            {
                initObject.RecordVersion = this.RecordVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SiteName"))
            {
                initObject.SiteName = this.SiteName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryEpg.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryEpg")]
    public class InitializeIntersightNiatelemetryEpg:PSCmdlet
	{
		public InitializeIntersightNiatelemetryEpg()
		{
            ClassId = NiatelemetryEpg.ClassIdEnum.NiatelemetryEpg;
            ObjectType = NiatelemetryEpg.ObjectTypeEnum.NiatelemetryEpg;
            
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
        /// <para type="description">"Azure Pack NAT with ASA feature usage."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long AzurePackCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryEpg.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Dn value for the End Point Groups present."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Dn {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of  objects with delimiter value present in EPG Delimiter attribute."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long EpgDelimiterCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of ports with FC path attribute of type FC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long FcNpvCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of FCoE per End Point Group."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long FcoeCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of FvRsDomAtt objects per End Point Group with VMware configuration."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long FvRsDomAttCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Intra End Point Group Contract for Distributed Virtual Switch and BM feature usage."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long IntraEpgDvsBmCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Intra EPG Isolation for Hyper-V, enabled if pcEnfPref attribute is set to enforced."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string IntraEpgHyperv {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Gets the state of End Point Groups with isAttrBasedEPg value as configured."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string IsAttrBased {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Gets the state of End Point Groups where microsegmentation is present."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Microsegmentation {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of FvRsDomAtt objects per End Point Group with Microsoft configuration."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long MicrosoftUsegCount {
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
        /// <para type="description">"Name value for the End Point Groups present."</para>
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
        
        public NiatelemetryEpg.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of objects with Simplified Service Graph Integration with Windows Azure Pack."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long OrchslDevVipCfgCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of record DCNM / APIC / SE. This determines the type of platform where inventory was collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version of record being pushed. This determines what was the API version for data available from the device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Site name represents an APIC cluster. Service Engine can onboard multiple APIC clusters / sites."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SiteName {
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
        // <summary>
        /// <para type="description">"Logical Operators for attribute based microsegmentation in a hypervisor."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long UsegHypervCount {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.NiatelemetryEpg initObject = new Intersight.Model.NiatelemetryEpg();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AzurePackCount"))
            {
                initObject.AzurePackCount = this.AzurePackCount;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Dn"))
            {
                initObject.Dn = this.Dn;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EpgDelimiterCount"))
            {
                initObject.EpgDelimiterCount = this.EpgDelimiterCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FcNpvCount"))
            {
                initObject.FcNpvCount = this.FcNpvCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FcoeCount"))
            {
                initObject.FcoeCount = this.FcoeCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FvRsDomAttCount"))
            {
                initObject.FvRsDomAttCount = this.FvRsDomAttCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IntraEpgDvsBmCount"))
            {
                initObject.IntraEpgDvsBmCount = this.IntraEpgDvsBmCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IntraEpgHyperv"))
            {
                initObject.IntraEpgHyperv = this.IntraEpgHyperv;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IsAttrBased"))
            {
                initObject.IsAttrBased = this.IsAttrBased;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Microsegmentation"))
            {
                initObject.Microsegmentation = this.Microsegmentation;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MicrosoftUsegCount"))
            {
                initObject.MicrosoftUsegCount = this.MicrosoftUsegCount;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("OrchslDevVipCfgCount"))
            {
                initObject.OrchslDevVipCfgCount = this.OrchslDevVipCfgCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordType"))
            {
                initObject.RecordType = this.RecordType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordVersion"))
            {
                initObject.RecordVersion = this.RecordVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SiteName"))
            {
                initObject.SiteName = this.SiteName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UsegHypervCount"))
            {
                initObject.UsegHypervCount = this.UsegHypervCount;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryCommonPolicies.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryCommonPolicies")]
    public class InitializeIntersightNiatelemetryCommonPolicies:PSCmdlet
	{
		public InitializeIntersightNiatelemetryCommonPolicies()
		{
            ClassId = NiatelemetryCommonPolicies.ClassIdEnum.NiatelemetryCommonPolicies;
            ObjectType = NiatelemetryCommonPolicies.ObjectTypeEnum.NiatelemetryCommonPolicies;
            
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
        
        public NiatelemetryCommonPolicies.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Dn of the Common Policy in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Dn {
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryCommonPolicies.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of record DCNM / APIC / SE. This determines the type of platform where inventory was collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version of record being pushed. This determines what was the API version for data available from the device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the APIC site from which this data is being collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SiteName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"List of Dn of SNMP Src for the above common pol."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SnmpSrc {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"List of Dn of Syslog Src for the above common pol."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SyslogSrc {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"List of Dn of Syslog Sys Msg the above common pol."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SyslogSysMsg {
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
             Intersight.Model.NiatelemetryCommonPolicies initObject = new Intersight.Model.NiatelemetryCommonPolicies();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Dn"))
            {
                initObject.Dn = this.Dn;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordType"))
            {
                initObject.RecordType = this.RecordType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordVersion"))
            {
                initObject.RecordVersion = this.RecordVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SiteName"))
            {
                initObject.SiteName = this.SiteName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SnmpSrc"))
            {
                initObject.SnmpSrc = this.SnmpSrc;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SyslogSrc"))
            {
                initObject.SyslogSrc = this.SyslogSrc;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SyslogSysMsg"))
            {
                initObject.SyslogSysMsg = this.SyslogSysMsg;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetrySshVersionTwo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetrySshVersionTwo")]
    public class InitializeIntersightNiatelemetrySshVersionTwo:PSCmdlet
	{
		public InitializeIntersightNiatelemetrySshVersionTwo()
		{
            ClassId = NiatelemetrySshVersionTwo.ClassIdEnum.NiatelemetrySshVersionTwo;
            ObjectType = NiatelemetrySshVersionTwo.ObjectTypeEnum.NiatelemetrySshVersionTwo;
            
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
        /// <para type="description">"Admin state of SSH V2 in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string AdminSt {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetrySshVersionTwo.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Dn of SSH V2 attribute in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Dn {
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetrySshVersionTwo.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Password auth for SSH V2 in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string PasswordAuth {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of record DCNM / APIC / SE. This determines the type of platform where inventory was collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version of record being pushed. This determines what was the API version for data available from the device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the APIC site from which this data is being collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SiteName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"SSH Ciphers for SSH V2 in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SshCiphers {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"SSH MACS for SSH V2 in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SshMacs {
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
             Intersight.Model.NiatelemetrySshVersionTwo initObject = new Intersight.Model.NiatelemetrySshVersionTwo();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdminSt"))
            {
                initObject.AdminSt = this.AdminSt;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Dn"))
            {
                initObject.Dn = this.Dn;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("PasswordAuth"))
            {
                initObject.PasswordAuth = this.PasswordAuth;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordType"))
            {
                initObject.RecordType = this.RecordType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordVersion"))
            {
                initObject.RecordVersion = this.RecordVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SiteName"))
            {
                initObject.SiteName = this.SiteName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SshCiphers"))
            {
                initObject.SshCiphers = this.SshCiphers;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SshMacs"))
            {
                initObject.SshMacs = this.SshMacs;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetrySyslogSysMsgFacFilter.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetrySyslogSysMsgFacFilter")]
    public class InitializeIntersightNiatelemetrySyslogSysMsgFacFilter:PSCmdlet
	{
		public InitializeIntersightNiatelemetrySyslogSysMsgFacFilter()
		{
            ClassId = NiatelemetrySyslogSysMsgFacFilter.ClassIdEnum.NiatelemetrySyslogSysMsgFacFilter;
            ObjectType = NiatelemetrySyslogSysMsgFacFilter.ObjectTypeEnum.NiatelemetrySyslogSysMsgFacFilter;
            
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
        
        public NiatelemetrySyslogSysMsgFacFilter.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Parent common policy for syslog system msg in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string CommonPolicy {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Dn of the Syslog System msg facility filter in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Dn {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Facility of Syslog System msg facility filter in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Facility {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Minimum severity of Syslog System msg facility filter in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string MinSev {
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetrySyslogSysMsgFacFilter.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of record DCNM / APIC / SE. This determines the type of platform where inventory was collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version of record being pushed. This determines what was the API version for data available from the device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the APIC site from which this data is being collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SiteName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Parent syslog msg for syslog sys msg facility filter in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SyslogSysMsg {
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
             Intersight.Model.NiatelemetrySyslogSysMsgFacFilter initObject = new Intersight.Model.NiatelemetrySyslogSysMsgFacFilter();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("CommonPolicy"))
            {
                initObject.CommonPolicy = this.CommonPolicy;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Dn"))
            {
                initObject.Dn = this.Dn;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Facility"))
            {
                initObject.Facility = this.Facility;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MinSev"))
            {
                initObject.MinSev = this.MinSev;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordType"))
            {
                initObject.RecordType = this.RecordType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordVersion"))
            {
                initObject.RecordVersion = this.RecordVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SiteName"))
            {
                initObject.SiteName = this.SiteName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SyslogSysMsg"))
            {
                initObject.SyslogSysMsg = this.SyslogSysMsg;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryDcnmPsuDetails.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryDcnmPsuDetails")]
    public class InitializeIntersightNiatelemetryDcnmPsuDetails:PSCmdlet
	{
		public InitializeIntersightNiatelemetryDcnmPsuDetails()
		{
            ClassId = NiatelemetryDcnmPsuDetails.ClassIdEnum.NiatelemetryDcnmPsuDetails;
            ObjectType = NiatelemetryDcnmPsuDetails.ObjectTypeEnum.NiatelemetryDcnmPsuDetails;
            
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
        
        public NiatelemetryDcnmPsuDetails.ClassIdEnum ClassId {
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
        /// <para type="description">"Name of the power supply unit."</para>
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
        
        public NiatelemetryDcnmPsuDetails.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Product ID of the power supply."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ProductId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of record DCNM / APIC / SE. This determines the type of platform where inventory was collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version of record being pushed. This determines what was the API version for data available from the device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Serial number of the power supply unit."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SerialNumber {
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
        // <summary>
        /// <para type="description">"Vendor Id of the power supply unit."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string VendorId {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.NiatelemetryDcnmPsuDetails initObject = new Intersight.Model.NiatelemetryDcnmPsuDetails();
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
            if (this.MyInvocation.BoundParameters.ContainsKey("ProductId"))
            {
                initObject.ProductId = this.ProductId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordType"))
            {
                initObject.RecordType = this.RecordType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordVersion"))
            {
                initObject.RecordVersion = this.RecordVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SerialNumber"))
            {
                initObject.SerialNumber = this.SerialNumber;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VendorId"))
            {
                initObject.VendorId = this.VendorId;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetrySnmpSrc.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetrySnmpSrc")]
    public class InitializeIntersightNiatelemetrySnmpSrc:PSCmdlet
	{
		public InitializeIntersightNiatelemetrySnmpSrc()
		{
            ClassId = NiatelemetrySnmpSrc.ClassIdEnum.NiatelemetrySnmpSrc;
            ObjectType = NiatelemetrySnmpSrc.ObjectTypeEnum.NiatelemetrySnmpSrc;
            
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
        
        public NiatelemetrySnmpSrc.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Parent common policy for SNMP Source in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string CommonPolicy {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Dn of the SNMP Source in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Dn {
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetrySnmpSrc.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of record DCNM / APIC / SE. This determines the type of platform where inventory was collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version of record being pushed. This determines what was the API version for data available from the device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the APIC site from which this data is being collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SiteName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"List of SNMP trap destination for the above src."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SnmpTrapDest {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"SNMP trap destination group for the above src."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SnmpTrapDestGrp {
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
             Intersight.Model.NiatelemetrySnmpSrc initObject = new Intersight.Model.NiatelemetrySnmpSrc();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("CommonPolicy"))
            {
                initObject.CommonPolicy = this.CommonPolicy;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Dn"))
            {
                initObject.Dn = this.Dn;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordType"))
            {
                initObject.RecordType = this.RecordType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordVersion"))
            {
                initObject.RecordVersion = this.RecordVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SiteName"))
            {
                initObject.SiteName = this.SiteName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SnmpTrapDest"))
            {
                initObject.SnmpTrapDest = this.SnmpTrapDest;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SnmpTrapDestGrp"))
            {
                initObject.SnmpTrapDestGrp = this.SnmpTrapDestGrp;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryApicAppPluginDetails.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryApicAppPluginDetails")]
    public class InitializeIntersightNiatelemetryApicAppPluginDetails:PSCmdlet
	{
		public InitializeIntersightNiatelemetryApicAppPluginDetails()
		{
            ClassId = NiatelemetryApicAppPluginDetails.ClassIdEnum.NiatelemetryApicAppPluginDetails;
            ObjectType = NiatelemetryApicAppPluginDetails.ObjectTypeEnum.NiatelemetryApicAppPluginDetails;
            
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
        /// <para type="description">"App Id of the plugin in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string AppId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryApicAppPluginDetails.ClassIdEnum ClassId {
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryApicAppPluginDetails.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Permissions to the app plugin in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Permission {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Permission Level of the app plugin in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string PermissionLevel {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of record DCNM / APIC / SE. This determines the type of platform where inventory was collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version of record being pushed. This determines what was the API version for data available from the device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the APIC site from which this data is being collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SiteName {
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
             Intersight.Model.NiatelemetryApicAppPluginDetails initObject = new Intersight.Model.NiatelemetryApicAppPluginDetails();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AppId"))
            {
                initObject.AppId = this.AppId;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Permission"))
            {
                initObject.Permission = this.Permission;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PermissionLevel"))
            {
                initObject.PermissionLevel = this.PermissionLevel;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordType"))
            {
                initObject.RecordType = this.RecordType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordVersion"))
            {
                initObject.RecordVersion = this.RecordVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SiteName"))
            {
                initObject.SiteName = this.SiteName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryNexusDashboardDetails.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryNexusDashboardDetails")]
    public class InitializeIntersightNiatelemetryNexusDashboardDetails:PSCmdlet
	{
		public InitializeIntersightNiatelemetryNexusDashboardDetails()
		{
            ClassId = NiatelemetryNexusDashboardDetails.ClassIdEnum.NiatelemetryNexusDashboardDetails;
            ObjectType = NiatelemetryNexusDashboardDetails.ObjectTypeEnum.NiatelemetryNexusDashboardDetails;
            
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
        
        public NiatelemetryNexusDashboardDetails.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the nexus dashboard cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ClusterName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Model of the nexus dashboard cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string DeviceModel {
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
        /// <para type="description">"Name of the NexusDashboard."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string NexusDashboardName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Serial number of NexusDashboard."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string NexusDashboardSerialNumber {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryNexusDashboardDetails.ObjectTypeEnum ObjectType {
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
        // <summary>
        /// <para type="description">"Node type of the nexus dashboard cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Type {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.NiatelemetryNexusDashboardDetails initObject = new Intersight.Model.NiatelemetryNexusDashboardDetails();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ClusterName"))
            {
                initObject.ClusterName = this.ClusterName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DeviceModel"))
            {
                initObject.DeviceModel = this.DeviceModel;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NexusDashboardName"))
            {
                initObject.NexusDashboardName = this.NexusDashboardName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NexusDashboardSerialNumber"))
            {
                initObject.NexusDashboardSerialNumber = this.NexusDashboardSerialNumber;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Type"))
            {
                initObject.Type = this.Type;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryApicFlashDetails.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryApicFlashDetails")]
    public class InitializeIntersightNiatelemetryApicFlashDetails:PSCmdlet
	{
		public InitializeIntersightNiatelemetryApicFlashDetails()
		{
            ClassId = NiatelemetryApicFlashDetails.ClassIdEnum.NiatelemetryApicFlashDetails;
            ObjectType = NiatelemetryApicFlashDetails.ObjectTypeEnum.NiatelemetryApicFlashDetails;
            
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
        
        public NiatelemetryApicFlashDetails.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Dn for the flash in the inventory."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Dn {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Model number of the flash in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ModelNumber {
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryApicFlashDetails.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of record DCNM / APIC / SE. This determines the type of platform where inventory was collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version of record being pushed. This determines what was the API version for data available from the device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Revision of the flash Mo in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Revision {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Serial number of the flash in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SerialNumber {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the APIC site from which this data is being collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SiteName {
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
             Intersight.Model.NiatelemetryApicFlashDetails initObject = new Intersight.Model.NiatelemetryApicFlashDetails();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Dn"))
            {
                initObject.Dn = this.Dn;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ModelNumber"))
            {
                initObject.ModelNumber = this.ModelNumber;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordType"))
            {
                initObject.RecordType = this.RecordType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordVersion"))
            {
                initObject.RecordVersion = this.RecordVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Revision"))
            {
                initObject.Revision = this.Revision;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SerialNumber"))
            {
                initObject.SerialNumber = this.SerialNumber;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SiteName"))
            {
                initObject.SiteName = this.SiteName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
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
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetrySupervisorModuleDetails.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetrySupervisorModuleDetails")]
    public class InitializeIntersightNiatelemetrySupervisorModuleDetails:PSCmdlet
	{
		public InitializeIntersightNiatelemetrySupervisorModuleDetails()
		{
            ClassId = NiatelemetrySupervisorModuleDetails.ClassIdEnum.NiatelemetrySupervisorModuleDetails;
            ObjectType = NiatelemetrySupervisorModuleDetails.ObjectTypeEnum.NiatelemetrySupervisorModuleDetails;
            
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
        
        public NiatelemetrySupervisorModuleDetails.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Dn of the supervisor module in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Dn {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Hardware version of supervisor module."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string HwVer {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Model of the supervisor module."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Model {
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetrySupervisorModuleDetails.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of record DCNM / APIC / SE. This determines the type of platform where inventory was collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version of record being pushed. This determines what was the API version for data available from the device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Serial number of the supervisor module."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Serial {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the APIC site from which this data is being collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SiteName {
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
             Intersight.Model.NiatelemetrySupervisorModuleDetails initObject = new Intersight.Model.NiatelemetrySupervisorModuleDetails();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Dn"))
            {
                initObject.Dn = this.Dn;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HwVer"))
            {
                initObject.HwVer = this.HwVer;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Model"))
            {
                initObject.Model = this.Model;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordType"))
            {
                initObject.RecordType = this.RecordType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordVersion"))
            {
                initObject.RecordVersion = this.RecordVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Serial"))
            {
                initObject.Serial = this.Serial;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SiteName"))
            {
                initObject.SiteName = this.SiteName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryApicRealmDetails.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryApicRealmDetails")]
    public class InitializeIntersightNiatelemetryApicRealmDetails:PSCmdlet
	{
		public InitializeIntersightNiatelemetryApicRealmDetails()
		{
            ClassId = NiatelemetryApicRealmDetails.ClassIdEnum.NiatelemetryApicRealmDetails;
            ObjectType = NiatelemetryApicRealmDetails.ObjectTypeEnum.NiatelemetryApicRealmDetails;
            
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
        
        public NiatelemetryApicRealmDetails.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Dn of the Realm Details in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Dn {
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryApicRealmDetails.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Realm value in Realm Details in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Realm {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of record DCNM / APIC / SE. This determines the type of platform where inventory was collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version of record being pushed. This determines what was the API version for data available from the device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the APIC site from which this data is being collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SiteName {
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
             Intersight.Model.NiatelemetryApicRealmDetails initObject = new Intersight.Model.NiatelemetryApicRealmDetails();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Dn"))
            {
                initObject.Dn = this.Dn;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Realm"))
            {
                initObject.Realm = this.Realm;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordType"))
            {
                initObject.RecordType = this.RecordType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordVersion"))
            {
                initObject.RecordVersion = this.RecordVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SiteName"))
            {
                initObject.SiteName = this.SiteName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryApicSnmpClientGrpDetails.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryApicSnmpClientGrpDetails")]
    public class InitializeIntersightNiatelemetryApicSnmpClientGrpDetails:PSCmdlet
	{
		public InitializeIntersightNiatelemetryApicSnmpClientGrpDetails()
		{
            ClassId = NiatelemetryApicSnmpClientGrpDetails.ClassIdEnum.NiatelemetryApicSnmpClientGrpDetails;
            ObjectType = NiatelemetryApicSnmpClientGrpDetails.ObjectTypeEnum.NiatelemetryApicSnmpClientGrpDetails;
            
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
        
        public NiatelemetryApicSnmpClientGrpDetails.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Dn of the SNMP community in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Dn {
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
        /// <para type="description">"Name of SNMP client grp in APIC."</para>
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
        
        public NiatelemetryApicSnmpClientGrpDetails.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Dn of the parent SNMP Policy in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string PolDn {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of record DCNM / APIC / SE. This determines the type of platform where inventory was collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version of record being pushed. This determines what was the API version for data available from the device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"List of address of restricted clients for particular client grp."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RestrictedClients {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the APIC site from which this data is being collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SiteName {
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
             Intersight.Model.NiatelemetryApicSnmpClientGrpDetails initObject = new Intersight.Model.NiatelemetryApicSnmpClientGrpDetails();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Dn"))
            {
                initObject.Dn = this.Dn;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("PolDn"))
            {
                initObject.PolDn = this.PolDn;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordType"))
            {
                initObject.RecordType = this.RecordType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordVersion"))
            {
                initObject.RecordVersion = this.RecordVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RestrictedClients"))
            {
                initObject.RestrictedClients = this.RestrictedClients;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SiteName"))
            {
                initObject.SiteName = this.SiteName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryFabricPodSs.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryFabricPodSs")]
    public class InitializeIntersightNiatelemetryFabricPodSs:PSCmdlet
	{
		public InitializeIntersightNiatelemetryFabricPodSs()
		{
            ClassId = NiatelemetryFabricPodSs.ClassIdEnum.NiatelemetryFabricPodSs;
            ObjectType = NiatelemetryFabricPodSs.ObjectTypeEnum.NiatelemetryFabricPodSs;
            
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
        
        public NiatelemetryFabricPodSs.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Dn of the Fabric podS for APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Dn {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Parent PodP of the Fabric podS for APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string FabricPodProf {
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryFabricPodSs.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Pod Block for the above Fabric PodS."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string PodBlk {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Policy Group for the above Fabric PodS."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string PodPolGrp {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"List of Dn of CommPols, SnmpPols and TimePols."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string PolList {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of record DCNM / APIC / SE. This determines the type of platform where inventory was collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version of record being pushed. This determines what was the API version for data available from the device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the APIC site from which this data is being collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SiteName {
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
             Intersight.Model.NiatelemetryFabricPodSs initObject = new Intersight.Model.NiatelemetryFabricPodSs();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Dn"))
            {
                initObject.Dn = this.Dn;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FabricPodProf"))
            {
                initObject.FabricPodProf = this.FabricPodProf;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("PodBlk"))
            {
                initObject.PodBlk = this.PodBlk;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PodPolGrp"))
            {
                initObject.PodPolGrp = this.PodPolGrp;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PolList"))
            {
                initObject.PolList = this.PolList;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordType"))
            {
                initObject.RecordType = this.RecordType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordVersion"))
            {
                initObject.RecordVersion = this.RecordVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SiteName"))
            {
                initObject.SiteName = this.SiteName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryApicSysLogSrc.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryApicSysLogSrc")]
    public class InitializeIntersightNiatelemetryApicSysLogSrc:PSCmdlet
	{
		public InitializeIntersightNiatelemetryApicSysLogSrc()
		{
            ClassId = NiatelemetryApicSysLogSrc.ClassIdEnum.NiatelemetryApicSysLogSrc;
            ObjectType = NiatelemetryApicSysLogSrc.ObjectTypeEnum.NiatelemetryApicSysLogSrc;
            
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
        
        public NiatelemetryApicSysLogSrc.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Dn of the SysLogSrc in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Dn {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Minimum sevirity on SysLogSrc MO in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string MinSev {
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryApicSysLogSrc.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of record DCNM / APIC / SE. This determines the type of platform where inventory was collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version of record being pushed. This determines what was the API version for data available from the device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the APIC site from which this data is being collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SiteName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"List of Syslog remote destination for SyslogSrc in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SyslogRemoteDest {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Syslog destination grp for SysLogSrc in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SyslogRsDestGrp {
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
             Intersight.Model.NiatelemetryApicSysLogSrc initObject = new Intersight.Model.NiatelemetryApicSysLogSrc();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Dn"))
            {
                initObject.Dn = this.Dn;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MinSev"))
            {
                initObject.MinSev = this.MinSev;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordType"))
            {
                initObject.RecordType = this.RecordType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordVersion"))
            {
                initObject.RecordVersion = this.RecordVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SiteName"))
            {
                initObject.SiteName = this.SiteName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SyslogRemoteDest"))
            {
                initObject.SyslogRemoteDest = this.SyslogRemoteDest;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SyslogRsDestGrp"))
            {
                initObject.SyslogRsDestGrp = this.SyslogRsDestGrp;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryMsoSiteDetails.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryMsoSiteDetails")]
    public class InitializeIntersightNiatelemetryMsoSiteDetails:PSCmdlet
	{
		public InitializeIntersightNiatelemetryMsoSiteDetails()
		{
            ClassId = NiatelemetryMsoSiteDetails.ClassIdEnum.NiatelemetryMsoSiteDetails;
            ObjectType = NiatelemetryMsoSiteDetails.ObjectTypeEnum.NiatelemetryMsoSiteDetails;
            
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
        
        public NiatelemetryMsoSiteDetails.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Status of cloudSec on Multi-Site Orchestrator site."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string IsCloudSecEnabled {
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
        /// <para type="description">"Number of leafs per site in Multi-Site Orchestrator."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long NumberOfLeafsPerSiteInMso {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of pods per site in Multi-Site Orchestrator."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long NumberOfPodsPerSiteInMso {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of spines per site in Multi-Site Orchestrator."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long NumberOfSpinesPerSiteInMso {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryMsoSiteDetails.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of record DCNM / APIC / SE. This determines the type of platform where inventory was collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"ID of site in Multi-Site Orchestrator."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SiteId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the site in Multi-Site Orchestrator."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SiteName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version of the controller in the site."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SiteVersion {
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
             Intersight.Model.NiatelemetryMsoSiteDetails initObject = new Intersight.Model.NiatelemetryMsoSiteDetails();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("IsCloudSecEnabled"))
            {
                initObject.IsCloudSecEnabled = this.IsCloudSecEnabled;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NumberOfLeafsPerSiteInMso"))
            {
                initObject.NumberOfLeafsPerSiteInMso = this.NumberOfLeafsPerSiteInMso;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NumberOfPodsPerSiteInMso"))
            {
                initObject.NumberOfPodsPerSiteInMso = this.NumberOfPodsPerSiteInMso;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NumberOfSpinesPerSiteInMso"))
            {
                initObject.NumberOfSpinesPerSiteInMso = this.NumberOfSpinesPerSiteInMso;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordType"))
            {
                initObject.RecordType = this.RecordType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SiteId"))
            {
                initObject.SiteId = this.SiteId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SiteName"))
            {
                initObject.SiteName = this.SiteName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SiteVersion"))
            {
                initObject.SiteVersion = this.SiteVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
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
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryNiaInventory.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryNiaInventory")]
    public class InitializeIntersightNiatelemetryNiaInventory:PSCmdlet
	{
		public InitializeIntersightNiatelemetryNiaInventory()
		{
            ClassId = NiatelemetryNiaInventory.ClassIdEnum.NiatelemetryNiaInventory;
            ObjectType = NiatelemetryNiaInventory.ObjectTypeEnum.NiatelemetryNiaInventory;
            
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
        
        public NiatelemetryNiaInventory.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns controller's IP address details."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ControllerIpAddress {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"CPU usage of device being inventoried. This determines the percentage of CPU resources used."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public float Cpu {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Last crash reset reason of device being inventoried. This determines the last reason for a device's restart due to crash of the system."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string CrashResetLogs {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns the value of the customerDeviceConnector field."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string CustomerDeviceConnector {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns the License state of the device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string DcnmLicenseState {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns the value of the deviceDiscovery field."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string DeviceDiscovery {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns the device health."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long DeviceHealth {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns the value of the deviceId field."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string DeviceId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of device being inventoried. The name the user assigns to the device is inventoried here."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string DeviceName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of device being inventoried. This determines whether the device is a controller, leaf or spine."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string DeviceType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns the device up time."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long DeviceUpTime {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Disk Usage of device being inventoried. This determines the amount of disk usage."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.NiatelemetryDiskinfo Disk {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Dn for the inventories present."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Dn {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the fabric of the device being inventoried."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string FabricName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of fabric extendors utilized."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long FexCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of appliances as physical device that are wired into the cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long InfraWiNodeCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Model.NiatelemetryInterfaceElement> Interface {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The IP address of the device being inventoried."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string IpAddress {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Flag to specify if the node is virtual."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string IsVirtualNode {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns the last reboot Time of the device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string LastRebootTime {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns the last reset reason of the device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string LastResetReason {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a niatelemetryNiaLicenseState resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.NiatelemetryNiaLicenseStateRelationship LicenseState {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns the License type of the device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string LicenseType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Last log in time device being inventoried. This determines the last login time on the device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string LogInTime {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Last log out time of device being inventoried. This determines the last logout time on the device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string LogOutTime {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of Macsec configured interfaces on a TOR."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long MacSecCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of Macsec configured interfaces on a Spine."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long MacSecFabCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of total Macsec configured interfaces for all nodes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long MacsecTotalCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Memory usage of device being inventoried. This determines the percentage of memory resources used."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Memory {
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
        /// <para type="description">"The ID of the device being inventoried."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string NodeId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns Nxos EVPN BGP details."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.NiatelemetryNxosBgpEvpn NxosBgpEvpn {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns the value of the nxosTrmConfigs field."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.NiatelemetryNxosBgpMvpn NxosBgpMvpn {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns the value of the nxosBootflashDetails field."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.NiatelemetryBootflashDetails NxosBootflashDetails {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns the status of dci interface configured."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string NxosDciInterfaceStatus {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns the value of the nxosInterfaceBrief field."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.NiatelemetryInterface NxosInterfaceBrief {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns the value of the nxosNveInterface field."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string NxosNveInterfaceStatus {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns the value of the nxosNvePacketCounters field."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.NiatelemetryNvePacketCounters NxosNvePacketCounters {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns the value of the nxosNveVni field."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.NiatelemetryNveVni NxosNveVni {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Total number of ospf neighbors per switch in DCNM."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long NxosOspfNeighbors {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Total number of pim neighbors per switch in DCNM."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string NxosPimNeighbors {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns the value of the nxosTelnet field."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string NxosTelnet {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Total number of routes configured in the DCNM."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long NxosTotalRoutes {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns the value of the nxosVtpStatus field."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.NiatelemetryNxosVtp NxosVtp {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryNiaInventory.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of record DCNM / APIC / SE. This determines the type of platform where inventory was collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version of record being pushed. This determines what was the API version for data available from the device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Total nuumber of v4 and v6 routes per node."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long RoutePrefixCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of v4 routes per node."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long RoutePrefixV4Count {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of v6 routes per node."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long RoutePrefixV6Count {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Serial number of device being invetoried. The serial number is unique per device and will be used as the key."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Serial {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of fabric domain of the controller."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SiteName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns the value of the smartAccountId/CustomerId field."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long SmartAccountId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Last software downloaded of device being inventoried. This determines if software download API was used."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SoftwareDownload {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The amount of time that the device being inventoried been up."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SystemUpTime {
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
        // <summary>
        /// <para type="description">"Software version of device being inventoried. The various software version values for each device are available on cisco.com."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Version {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Model.NiatelemetryVniStatus> VniStatus {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.NiatelemetryNiaInventory initObject = new Intersight.Model.NiatelemetryNiaInventory();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ControllerIpAddress"))
            {
                initObject.ControllerIpAddress = this.ControllerIpAddress;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Cpu"))
            {
                initObject.Cpu = this.Cpu;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CrashResetLogs"))
            {
                initObject.CrashResetLogs = this.CrashResetLogs;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CustomerDeviceConnector"))
            {
                initObject.CustomerDeviceConnector = this.CustomerDeviceConnector;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DcnmLicenseState"))
            {
                initObject.DcnmLicenseState = this.DcnmLicenseState;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DeviceDiscovery"))
            {
                initObject.DeviceDiscovery = this.DeviceDiscovery;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DeviceHealth"))
            {
                initObject.DeviceHealth = this.DeviceHealth;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DeviceId"))
            {
                initObject.DeviceId = this.DeviceId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DeviceName"))
            {
                initObject.DeviceName = this.DeviceName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DeviceType"))
            {
                initObject.DeviceType = this.DeviceType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DeviceUpTime"))
            {
                initObject.DeviceUpTime = this.DeviceUpTime;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Disk"))
            {
                initObject.Disk = this.Disk;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Dn"))
            {
                initObject.Dn = this.Dn;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FabricName"))
            {
                initObject.FabricName = this.FabricName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FexCount"))
            {
                initObject.FexCount = this.FexCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InfraWiNodeCount"))
            {
                initObject.InfraWiNodeCount = this.InfraWiNodeCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Interface"))
            {
                initObject.Interface = this.Interface;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IpAddress"))
            {
                initObject.IpAddress = this.IpAddress;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IsVirtualNode"))
            {
                initObject.IsVirtualNode = this.IsVirtualNode;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LastRebootTime"))
            {
                initObject.LastRebootTime = this.LastRebootTime;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LastResetReason"))
            {
                initObject.LastResetReason = this.LastResetReason;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LicenseState"))
            {
                initObject.LicenseState = this.LicenseState;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LicenseType"))
            {
                initObject.LicenseType = this.LicenseType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LogInTime"))
            {
                initObject.LogInTime = this.LogInTime;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LogOutTime"))
            {
                initObject.LogOutTime = this.LogOutTime;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MacSecCount"))
            {
                initObject.MacSecCount = this.MacSecCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MacSecFabCount"))
            {
                initObject.MacSecFabCount = this.MacSecFabCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MacsecTotalCount"))
            {
                initObject.MacsecTotalCount = this.MacsecTotalCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Memory"))
            {
                initObject.Memory = this.Memory;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NodeId"))
            {
                initObject.NodeId = this.NodeId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NxosBgpEvpn"))
            {
                initObject.NxosBgpEvpn = this.NxosBgpEvpn;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NxosBgpMvpn"))
            {
                initObject.NxosBgpMvpn = this.NxosBgpMvpn;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NxosBootflashDetails"))
            {
                initObject.NxosBootflashDetails = this.NxosBootflashDetails;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NxosDciInterfaceStatus"))
            {
                initObject.NxosDciInterfaceStatus = this.NxosDciInterfaceStatus;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NxosInterfaceBrief"))
            {
                initObject.NxosInterfaceBrief = this.NxosInterfaceBrief;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NxosNveInterfaceStatus"))
            {
                initObject.NxosNveInterfaceStatus = this.NxosNveInterfaceStatus;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NxosNvePacketCounters"))
            {
                initObject.NxosNvePacketCounters = this.NxosNvePacketCounters;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NxosNveVni"))
            {
                initObject.NxosNveVni = this.NxosNveVni;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NxosOspfNeighbors"))
            {
                initObject.NxosOspfNeighbors = this.NxosOspfNeighbors;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NxosPimNeighbors"))
            {
                initObject.NxosPimNeighbors = this.NxosPimNeighbors;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NxosTelnet"))
            {
                initObject.NxosTelnet = this.NxosTelnet;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NxosTotalRoutes"))
            {
                initObject.NxosTotalRoutes = this.NxosTotalRoutes;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NxosVtp"))
            {
                initObject.NxosVtp = this.NxosVtp;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordType"))
            {
                initObject.RecordType = this.RecordType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordVersion"))
            {
                initObject.RecordVersion = this.RecordVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RoutePrefixCount"))
            {
                initObject.RoutePrefixCount = this.RoutePrefixCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RoutePrefixV4Count"))
            {
                initObject.RoutePrefixV4Count = this.RoutePrefixV4Count;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RoutePrefixV6Count"))
            {
                initObject.RoutePrefixV6Count = this.RoutePrefixV6Count;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Serial"))
            {
                initObject.Serial = this.Serial;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SiteName"))
            {
                initObject.SiteName = this.SiteName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SmartAccountId"))
            {
                initObject.SmartAccountId = this.SmartAccountId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SoftwareDownload"))
            {
                initObject.SoftwareDownload = this.SoftwareDownload;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SystemUpTime"))
            {
                initObject.SystemUpTime = this.SystemUpTime;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Version"))
            {
                initObject._Version = this.Version;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VniStatus"))
            {
                initObject.VniStatus = this.VniStatus;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryNiaInventoryFabric.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryNiaInventoryFabric")]
    public class InitializeIntersightNiatelemetryNiaInventoryFabric:PSCmdlet
	{
		public InitializeIntersightNiatelemetryNiaInventoryFabric()
		{
            ClassId = NiatelemetryNiaInventoryFabric.ClassIdEnum.NiatelemetryNiaInventoryFabric;
            ObjectType = NiatelemetryNiaInventoryFabric.ObjectTypeEnum.NiatelemetryNiaInventoryFabric;
            
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
        /// <para type="description">"Returns the aycast gateway mac."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string AnycastGwMac {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Counts the number of BGP interfaces that are in established state."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long BgpEstablishedInterfaceCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Count number of active interfaces on border gateways."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long BgwInterfaceUpCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Count number of border gateway spines in the fabric inventory."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long BorderGatewaySpineCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Count number of border leafs in the fabric inventory."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long BorderLeafCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryNiaInventoryFabric.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Cloudsec autoconfig details on the fabric."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool CloudsecAutoconfig {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns the dci subnet range."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string DciSubnetRange {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns the dci subnet target mask."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string DciSubnetTargetMask {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns the value of the dcnmtrackerEnabled field."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool DcnmtrackerEnabled {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Count number of ebgp evpn active interfaces."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long EbgpEvpnLinkUpCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Uniquely identifies a fabric."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string FabricId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns the value of the Name of a fabric."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string FabricName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Parent of the fabric on DCNM."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string FabricParent {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Fabric Technology details on the fabric."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string FabricTechnology {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"PTP feature details on the fabric."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool FeaturePtp {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Checks if border gateway is present in the fabric inventory."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool IsBgwPresent {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Check if NXAPI HTTP is enable or not on the fabric."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool IsEnableNxapiHttp {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Check if real time backup is enable or not on the fabric."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool IsEnableRealTimeBackup {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns if ngoam is enabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool IsNgoamEnabled {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns if the scheduled backup is enabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool IsScheduledBackUpEnabled {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns total number of leafs in the fabric."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long LeafCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Link state routing details on the fabric."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string LinkStateRouting {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Model.NiatelemetryLogicalLink> LogicalLinks {
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
        /// <para type="description">"No of networks deployed on a fabric."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long NetworkDeploymentCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Model.NiatelemetryDeploymentStatus> NetworkDeploymentStatus {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"NTP server IP List on the fabric."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string NtpServerIpList {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns the count of vnis between sites."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long NxosVniBwSitesCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns the count of vrfs between sites."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long NxosVrfBwSitesCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns the value of the nxosVrfCount field."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long NxosVrfCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryNiaInventoryFabric.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Replication mode details on the fabric."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ReplicationMode {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"RP Mode details on the fabric."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RpMode {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Serial number of device being inventoried. The serial number is unique per device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Serial {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of fabric domain of the controller."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SiteName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Software image details on the fabric."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SoftwareImage {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns total number of spines in the fabric."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long SpineCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Syslog server IP list on DCNM."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SyslogServerIpList {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Syslog sev details on the fabric."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SyslogSev {
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
        // <summary>
        /// <para type="description">"Template name of the fabric on DCNM."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string TemplateName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"VLAN to VNI mappings configured in the DCNM."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string VlanVniMappings {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Count number of IP addresses configured in the DCNM networks."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long VniIpCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Model.NiatelemetryVpcDetails> VpcDetails {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"No of vrfs deployed on a fabric."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long VrfDeploymentCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Model.NiatelemetryDeploymentStatus> VrfDeploymentStatus {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.NiatelemetryNiaInventoryFabric initObject = new Intersight.Model.NiatelemetryNiaInventoryFabric();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AnycastGwMac"))
            {
                initObject.AnycastGwMac = this.AnycastGwMac;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BgpEstablishedInterfaceCount"))
            {
                initObject.BgpEstablishedInterfaceCount = this.BgpEstablishedInterfaceCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BgwInterfaceUpCount"))
            {
                initObject.BgwInterfaceUpCount = this.BgwInterfaceUpCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BorderGatewaySpineCount"))
            {
                initObject.BorderGatewaySpineCount = this.BorderGatewaySpineCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BorderLeafCount"))
            {
                initObject.BorderLeafCount = this.BorderLeafCount;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("CloudsecAutoconfig"))
            {
                initObject.CloudsecAutoconfig = this.CloudsecAutoconfig;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DciSubnetRange"))
            {
                initObject.DciSubnetRange = this.DciSubnetRange;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DciSubnetTargetMask"))
            {
                initObject.DciSubnetTargetMask = this.DciSubnetTargetMask;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DcnmtrackerEnabled"))
            {
                initObject.DcnmtrackerEnabled = this.DcnmtrackerEnabled;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EbgpEvpnLinkUpCount"))
            {
                initObject.EbgpEvpnLinkUpCount = this.EbgpEvpnLinkUpCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FabricId"))
            {
                initObject.FabricId = this.FabricId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FabricName"))
            {
                initObject.FabricName = this.FabricName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FabricParent"))
            {
                initObject.FabricParent = this.FabricParent;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FabricTechnology"))
            {
                initObject.FabricTechnology = this.FabricTechnology;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FeaturePtp"))
            {
                initObject.FeaturePtp = this.FeaturePtp;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IsBgwPresent"))
            {
                initObject.IsBgwPresent = this.IsBgwPresent;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IsEnableNxapiHttp"))
            {
                initObject.IsEnableNxapiHttp = this.IsEnableNxapiHttp;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IsEnableRealTimeBackup"))
            {
                initObject.IsEnableRealTimeBackup = this.IsEnableRealTimeBackup;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IsNgoamEnabled"))
            {
                initObject.IsNgoamEnabled = this.IsNgoamEnabled;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IsScheduledBackUpEnabled"))
            {
                initObject.IsScheduledBackUpEnabled = this.IsScheduledBackUpEnabled;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LeafCount"))
            {
                initObject.LeafCount = this.LeafCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LinkStateRouting"))
            {
                initObject.LinkStateRouting = this.LinkStateRouting;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LogicalLinks"))
            {
                initObject.LogicalLinks = this.LogicalLinks;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NetworkDeploymentCount"))
            {
                initObject.NetworkDeploymentCount = this.NetworkDeploymentCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NetworkDeploymentStatus"))
            {
                initObject.NetworkDeploymentStatus = this.NetworkDeploymentStatus;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NtpServerIpList"))
            {
                initObject.NtpServerIpList = this.NtpServerIpList;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NxosVniBwSitesCount"))
            {
                initObject.NxosVniBwSitesCount = this.NxosVniBwSitesCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NxosVrfBwSitesCount"))
            {
                initObject.NxosVrfBwSitesCount = this.NxosVrfBwSitesCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NxosVrfCount"))
            {
                initObject.NxosVrfCount = this.NxosVrfCount;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("ReplicationMode"))
            {
                initObject.ReplicationMode = this.ReplicationMode;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RpMode"))
            {
                initObject.RpMode = this.RpMode;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Serial"))
            {
                initObject.Serial = this.Serial;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SiteName"))
            {
                initObject.SiteName = this.SiteName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SoftwareImage"))
            {
                initObject.SoftwareImage = this.SoftwareImage;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SpineCount"))
            {
                initObject.SpineCount = this.SpineCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SyslogServerIpList"))
            {
                initObject.SyslogServerIpList = this.SyslogServerIpList;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SyslogSev"))
            {
                initObject.SyslogSev = this.SyslogSev;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TemplateName"))
            {
                initObject.TemplateName = this.TemplateName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VlanVniMappings"))
            {
                initObject.VlanVniMappings = this.VlanVniMappings;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VniIpCount"))
            {
                initObject.VniIpCount = this.VniIpCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VpcDetails"))
            {
                initObject.VpcDetails = this.VpcDetails;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VrfDeploymentCount"))
            {
                initObject.VrfDeploymentCount = this.VrfDeploymentCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VrfDeploymentStatus"))
            {
                initObject.VrfDeploymentStatus = this.VrfDeploymentStatus;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryNexusDashboards.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryNexusDashboards")]
    public class InitializeIntersightNiatelemetryNexusDashboards:PSCmdlet
	{
		public InitializeIntersightNiatelemetryNexusDashboards()
		{
            ClassId = NiatelemetryNexusDashboards.ClassIdEnum.NiatelemetryNexusDashboards;
            ObjectType = NiatelemetryNexusDashboards.ObjectTypeEnum.NiatelemetryNexusDashboards;
            
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
        
        public NiatelemetryNexusDashboards.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Nexus Dashboard can onboard multiple APIC clusters/sites."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ClusterName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"UUID of the Nexus Dashboard cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ClusterUuid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Dn of the objects present for Nexus Dashboard devices."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Dn {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Health of Nexus Dashboard cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string IsClusterHealthy {
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
        /// <para type="description">"Number of nodes in Nexus Dashboard cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long NdClusterSize {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Node type in Nexus Dashboard cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string NdType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version running on Nexus Dashboard."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string NdVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of applications installed in the Nexus Dashboard."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long NumberOfApps {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of total insight groups in ND."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long NumberOfInsightGroups {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of total NIR dashboards in ND."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long NumberOfNirDashboards {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of total schemas in Multi-Site Orchestrator."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long NumberOfSchemasInMso {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of sites in Multi-Site Orchestrator."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long NumberOfSitesInMso {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of sites serviced by ND."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long NumberOfSitesServiced {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of total tenants in Multi-Site Orchestrator."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long NumberOfTenantsInMso {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryNexusDashboards.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of record DCNM / APIC / SE. This determines the type of platform where inventory was collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordType {
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
        // <summary>
        /// <para type="description">"Type of site added to Multi-Site Orchestrator."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string TypeOfSiteInMso {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.NiatelemetryNexusDashboards initObject = new Intersight.Model.NiatelemetryNexusDashboards();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ClusterName"))
            {
                initObject.ClusterName = this.ClusterName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ClusterUuid"))
            {
                initObject.ClusterUuid = this.ClusterUuid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Dn"))
            {
                initObject.Dn = this.Dn;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IsClusterHealthy"))
            {
                initObject.IsClusterHealthy = this.IsClusterHealthy;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NdClusterSize"))
            {
                initObject.NdClusterSize = this.NdClusterSize;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NdType"))
            {
                initObject.NdType = this.NdType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NdVersion"))
            {
                initObject.NdVersion = this.NdVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NumberOfApps"))
            {
                initObject.NumberOfApps = this.NumberOfApps;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NumberOfInsightGroups"))
            {
                initObject.NumberOfInsightGroups = this.NumberOfInsightGroups;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NumberOfNirDashboards"))
            {
                initObject.NumberOfNirDashboards = this.NumberOfNirDashboards;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NumberOfSchemasInMso"))
            {
                initObject.NumberOfSchemasInMso = this.NumberOfSchemasInMso;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NumberOfSitesInMso"))
            {
                initObject.NumberOfSitesInMso = this.NumberOfSitesInMso;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NumberOfSitesServiced"))
            {
                initObject.NumberOfSitesServiced = this.NumberOfSitesServiced;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NumberOfTenantsInMso"))
            {
                initObject.NumberOfTenantsInMso = this.NumberOfTenantsInMso;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordType"))
            {
                initObject.RecordType = this.RecordType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TypeOfSiteInMso"))
            {
                initObject.TypeOfSiteInMso = this.TypeOfSiteInMso;
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
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryNode.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryNode")]
    public class InitializeIntersightNiatelemetryNode:PSCmdlet
	{
		public InitializeIntersightNiatelemetryNode()
		{
            ClassId = NiatelemetryNode.ClassIdEnum.NiatelemetryNode;
            ObjectType = NiatelemetryNode.ObjectTypeEnum.NiatelemetryNode;
            
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
        
        public NiatelemetryNode.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns hostname of the node."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Hostname {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns management IP of the node."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ManagementtIp {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryNode.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns out of band IP of the node."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string OutofbandIp {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.NiatelemetryNode initObject = new Intersight.Model.NiatelemetryNode();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Hostname"))
            {
                initObject.Hostname = this.Hostname;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ManagementtIp"))
            {
                initObject.ManagementtIp = this.ManagementtIp;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("OutofbandIp"))
            {
                initObject.OutofbandIp = this.OutofbandIp;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryApicSnmpCommunityDetails.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryApicSnmpCommunityDetails")]
    public class InitializeIntersightNiatelemetryApicSnmpCommunityDetails:PSCmdlet
	{
		public InitializeIntersightNiatelemetryApicSnmpCommunityDetails()
		{
            ClassId = NiatelemetryApicSnmpCommunityDetails.ClassIdEnum.NiatelemetryApicSnmpCommunityDetails;
            ObjectType = NiatelemetryApicSnmpCommunityDetails.ObjectTypeEnum.NiatelemetryApicSnmpCommunityDetails;
            
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
        
        public NiatelemetryApicSnmpCommunityDetails.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Dn of the SNMP community in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Dn {
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
        /// <para type="description">"Name of SNMP community in APIC."</para>
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
        
        public NiatelemetryApicSnmpCommunityDetails.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of record DCNM / APIC / SE. This determines the type of platform where inventory was collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version of record being pushed. This determines what was the API version for data available from the device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the APIC site from which this data is being collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SiteName {
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
             Intersight.Model.NiatelemetryApicSnmpCommunityDetails initObject = new Intersight.Model.NiatelemetryApicSnmpCommunityDetails();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Dn"))
            {
                initObject.Dn = this.Dn;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordType"))
            {
                initObject.RecordType = this.RecordType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordVersion"))
            {
                initObject.RecordVersion = this.RecordVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SiteName"))
            {
                initObject.SiteName = this.SiteName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryPodCommPolicies.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryPodCommPolicies")]
    public class InitializeIntersightNiatelemetryPodCommPolicies:PSCmdlet
	{
		public InitializeIntersightNiatelemetryPodCommPolicies()
		{
            ClassId = NiatelemetryPodCommPolicies.ClassIdEnum.NiatelemetryPodCommPolicies;
            ObjectType = NiatelemetryPodCommPolicies.ObjectTypeEnum.NiatelemetryPodCommPolicies;
            
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
        
        public NiatelemetryPodCommPolicies.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Comm Http Admin State of the Comm Pol in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string CommHttpAdminSt {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Comm Https Admin State of the Comm Pol in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string CommHttpsAdminSt {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Comm Ssh Admin State of the Comm Pol in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string CommSshAdminSt {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Comm Telnet Admin State of the Comm Pol in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string CommTelnetAdminSt {
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryPodCommPolicies.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Dn of the Comm Pol in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string PolDn {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of record DCNM / APIC / SE. This determines the type of platform where inventory was collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version of record being pushed. This determines what was the API version for data available from the device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the APIC site from which this data is being collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SiteName {
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
             Intersight.Model.NiatelemetryPodCommPolicies initObject = new Intersight.Model.NiatelemetryPodCommPolicies();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("CommHttpAdminSt"))
            {
                initObject.CommHttpAdminSt = this.CommHttpAdminSt;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CommHttpsAdminSt"))
            {
                initObject.CommHttpsAdminSt = this.CommHttpsAdminSt;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CommSshAdminSt"))
            {
                initObject.CommSshAdminSt = this.CommSshAdminSt;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CommTelnetAdminSt"))
            {
                initObject.CommTelnetAdminSt = this.CommTelnetAdminSt;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("PolDn"))
            {
                initObject.PolDn = this.PolDn;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordType"))
            {
                initObject.RecordType = this.RecordType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordVersion"))
            {
                initObject.RecordVersion = this.RecordVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SiteName"))
            {
                initObject.SiteName = this.SiteName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryFault.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryFault")]
    public class InitializeIntersightNiatelemetryFault:PSCmdlet
	{
		public InitializeIntersightNiatelemetryFault()
		{
            ClassId = NiatelemetryFault.ClassIdEnum.NiatelemetryFault;
            ObjectType = NiatelemetryFault.ObjectTypeEnum.NiatelemetryFault;
            
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
        /// <para type="description">"Cause of the fault present."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Cause {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryFault.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Code of the fault present."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Code {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Created time of the fault present."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string CreatedTime {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the fault present."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Dn value for the fault present."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Dn {
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryFault.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of record DCNM / APIC / SE. This determines the type of platform where inventory was collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version of record being pushed. This determines what was the API version for data available from the device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Severity of the fault present."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Severity {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Site name represents an APIC cluster. Service Engine can onboard multiple APIC clusters/sites."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SiteName {
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
        // <summary>
        /// <para type="description">"Type of the fault present."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Type {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.NiatelemetryFault initObject = new Intersight.Model.NiatelemetryFault();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Cause"))
            {
                initObject.Cause = this.Cause;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Code"))
            {
                initObject.Code = this.Code;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CreatedTime"))
            {
                initObject.CreatedTime = this.CreatedTime;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Dn"))
            {
                initObject.Dn = this.Dn;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordType"))
            {
                initObject.RecordType = this.RecordType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordVersion"))
            {
                initObject.RecordVersion = this.RecordVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Severity"))
            {
                initObject.Severity = this.Severity;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SiteName"))
            {
                initObject.SiteName = this.SiteName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Type"))
            {
                initObject.Type = this.Type;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryApicSnmpTrapDetails.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryApicSnmpTrapDetails")]
    public class InitializeIntersightNiatelemetryApicSnmpTrapDetails:PSCmdlet
	{
		public InitializeIntersightNiatelemetryApicSnmpTrapDetails()
		{
            ClassId = NiatelemetryApicSnmpTrapDetails.ClassIdEnum.NiatelemetryApicSnmpTrapDetails;
            ObjectType = NiatelemetryApicSnmpTrapDetails.ObjectTypeEnum.NiatelemetryApicSnmpTrapDetails;
            
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
        
        public NiatelemetryApicSnmpTrapDetails.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Dn of SNMP Trap attribute in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Dn {
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryApicSnmpTrapDetails.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of record DCNM / APIC / SE. This determines the type of platform where inventory was collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version of record being pushed. This determines what was the API version for data available from the device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the APIC site from which this data is being collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SiteName {
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
        // <summary>
        /// <para type="description">"V3SecLevel of SNMP Trap in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string V3SecLevel {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version of SNMP Trap in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Ver {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.NiatelemetryApicSnmpTrapDetails initObject = new Intersight.Model.NiatelemetryApicSnmpTrapDetails();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Dn"))
            {
                initObject.Dn = this.Dn;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordType"))
            {
                initObject.RecordType = this.RecordType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordVersion"))
            {
                initObject.RecordVersion = this.RecordVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SiteName"))
            {
                initObject.SiteName = this.SiteName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("V3SecLevel"))
            {
                initObject.V3SecLevel = this.V3SecLevel;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Ver"))
            {
                initObject.Ver = this.Ver;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryApicDbgexpRsExportDest.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryApicDbgexpRsExportDest")]
    public class InitializeIntersightNiatelemetryApicDbgexpRsExportDest:PSCmdlet
	{
		public InitializeIntersightNiatelemetryApicDbgexpRsExportDest()
		{
            ClassId = NiatelemetryApicDbgexpRsExportDest.ClassIdEnum.NiatelemetryApicDbgexpRsExportDest;
            ObjectType = NiatelemetryApicDbgexpRsExportDest.ObjectTypeEnum.NiatelemetryApicDbgexpRsExportDest;
            
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
        
        public NiatelemetryApicDbgexpRsExportDest.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Dn of the Rs export dest in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Dn {
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryApicDbgexpRsExportDest.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of record DCNM / APIC / SE. This determines the type of platform where inventory was collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version of record being pushed. This determines what was the API version for data available from the device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the APIC site from which this data is being collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SiteName {
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
             Intersight.Model.NiatelemetryApicDbgexpRsExportDest initObject = new Intersight.Model.NiatelemetryApicDbgexpRsExportDest();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Dn"))
            {
                initObject.Dn = this.Dn;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordType"))
            {
                initObject.RecordType = this.RecordType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordVersion"))
            {
                initObject.RecordVersion = this.RecordVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SiteName"))
            {
                initObject.SiteName = this.SiteName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryLc.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryLc")]
    public class InitializeIntersightNiatelemetryLc:PSCmdlet
	{
		public InitializeIntersightNiatelemetryLc()
		{
            ClassId = NiatelemetryLc.ClassIdEnum.NiatelemetryLc;
            ObjectType = NiatelemetryLc.ObjectTypeEnum.NiatelemetryLc;
            
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
        
        public NiatelemetryLc.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the line cards present."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Dn value for the line cards present."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Dn {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Hardware version of the line cards present."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string HardwareVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Model of the line cards present."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Model {
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
        /// <para type="description">"Node Id of the line card present."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long NodeId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryLc.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Opretaional state of the line cards present."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string OperationalState {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Power state of the line cards present."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string PowerState {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of record DCNM / APIC / SE. This determines the type of platform where inventory was collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version of record being pushed. This determines what was the API version for data available from the device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Redundancy state of the line cards present."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RedundancyState {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Serial number of the line card present."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SerialNumber {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Site name represents an APIC cluster. Service Engine can onboard multiple APIC clusters / sites."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SiteName {
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
        // <summary>
        /// <para type="description">"VID for the line card in the inventory."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Vid {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.NiatelemetryLc initObject = new Intersight.Model.NiatelemetryLc();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Dn"))
            {
                initObject.Dn = this.Dn;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HardwareVersion"))
            {
                initObject.HardwareVersion = this.HardwareVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Model"))
            {
                initObject.Model = this.Model;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("OperationalState"))
            {
                initObject.OperationalState = this.OperationalState;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PowerState"))
            {
                initObject.PowerState = this.PowerState;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordType"))
            {
                initObject.RecordType = this.RecordType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordVersion"))
            {
                initObject.RecordVersion = this.RecordVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RedundancyState"))
            {
                initObject.RedundancyState = this.RedundancyState;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SerialNumber"))
            {
                initObject.SerialNumber = this.SerialNumber;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SiteName"))
            {
                initObject.SiteName = this.SiteName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Vid"))
            {
                initObject.Vid = this.Vid;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryApicSnmpTrapFwdServerDetails.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryApicSnmpTrapFwdServerDetails")]
    public class InitializeIntersightNiatelemetryApicSnmpTrapFwdServerDetails:PSCmdlet
	{
		public InitializeIntersightNiatelemetryApicSnmpTrapFwdServerDetails()
		{
            ClassId = NiatelemetryApicSnmpTrapFwdServerDetails.ClassIdEnum.NiatelemetryApicSnmpTrapFwdServerDetails;
            ObjectType = NiatelemetryApicSnmpTrapFwdServerDetails.ObjectTypeEnum.NiatelemetryApicSnmpTrapFwdServerDetails;
            
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
        /// <para type="description">"Address of SNMP Trap Fwd Server in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Address {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryApicSnmpTrapFwdServerDetails.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Dn of the SNMP Trap Fwd Server details in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Dn {
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryApicSnmpTrapFwdServerDetails.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Dn of the parent SNMP Policy in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string PolDn {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of record DCNM / APIC / SE. This determines the type of platform where inventory was collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version of record being pushed. This determines what was the API version for data available from the device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the APIC site from which this data is being collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SiteName {
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
             Intersight.Model.NiatelemetryApicSnmpTrapFwdServerDetails initObject = new Intersight.Model.NiatelemetryApicSnmpTrapFwdServerDetails();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Address"))
            {
                initObject.Address = this.Address;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Dn"))
            {
                initObject.Dn = this.Dn;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("PolDn"))
            {
                initObject.PolDn = this.PolDn;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordType"))
            {
                initObject.RecordType = this.RecordType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordVersion"))
            {
                initObject.RecordVersion = this.RecordVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SiteName"))
            {
                initObject.SiteName = this.SiteName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
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
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryVniStatus.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryVniStatus")]
    public class InitializeIntersightNiatelemetryVniStatus:PSCmdlet
	{
		public InitializeIntersightNiatelemetryVniStatus()
		{
            ClassId = NiatelemetryVniStatus.ClassIdEnum.NiatelemetryVniStatus;
            ObjectType = NiatelemetryVniStatus.ObjectTypeEnum.NiatelemetryVniStatus;
            
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
        
        public NiatelemetryVniStatus.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryVniStatus.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns the vni id of the vni."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Vni {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns the vni state of the vni."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string VniState {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns the vni type of the vni."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string VniType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.NiatelemetryVniStatus initObject = new Intersight.Model.NiatelemetryVniStatus();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Vni"))
            {
                initObject.Vni = this.Vni;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VniState"))
            {
                initObject.VniState = this.VniState;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VniType"))
            {
                initObject.VniType = this.VniType;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryMsoSchemaDetails.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryMsoSchemaDetails")]
    public class InitializeIntersightNiatelemetryMsoSchemaDetails:PSCmdlet
	{
		public InitializeIntersightNiatelemetryMsoSchemaDetails()
		{
            ClassId = NiatelemetryMsoSchemaDetails.ClassIdEnum.NiatelemetryMsoSchemaDetails;
            ObjectType = NiatelemetryMsoSchemaDetails.ObjectTypeEnum.NiatelemetryMsoSchemaDetails;
            
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
        
        public NiatelemetryMsoSchemaDetails.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Site IDs to which this schema is deployed to."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string DeployedSites {
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
        /// <para type="description">"Number of policy objects per schema."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long NumberOfPolicyObjectsPerSchema {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of tenants assigned per schema in Multi-Site Orchestrator."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long NumberOfTemplatesPerSchema {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryMsoSchemaDetails.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of record DCNM / APIC / SE. This determines the type of platform where inventory was collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Schema ID in Multi-Site Orchestrator."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SchemaId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Schema name in Multi-Site Orchestrator."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SchemaName {
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
             Intersight.Model.NiatelemetryMsoSchemaDetails initObject = new Intersight.Model.NiatelemetryMsoSchemaDetails();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("DeployedSites"))
            {
                initObject.DeployedSites = this.DeployedSites;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NumberOfPolicyObjectsPerSchema"))
            {
                initObject.NumberOfPolicyObjectsPerSchema = this.NumberOfPolicyObjectsPerSchema;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NumberOfTemplatesPerSchema"))
            {
                initObject.NumberOfTemplatesPerSchema = this.NumberOfTemplatesPerSchema;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordType"))
            {
                initObject.RecordType = this.RecordType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SchemaId"))
            {
                initObject.SchemaId = this.SchemaId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SchemaName"))
            {
                initObject.SchemaName = this.SchemaName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryApicFanDetails.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryApicFanDetails")]
    public class InitializeIntersightNiatelemetryApicFanDetails:PSCmdlet
	{
		public InitializeIntersightNiatelemetryApicFanDetails()
		{
            ClassId = NiatelemetryApicFanDetails.ClassIdEnum.NiatelemetryApicFanDetails;
            ObjectType = NiatelemetryApicFanDetails.ObjectTypeEnum.NiatelemetryApicFanDetails;
            
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
        
        public NiatelemetryApicFanDetails.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Dn for the fan in the inventory."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Dn {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Model number of the fan in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ModelNumber {
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
        /// <para type="description">"Node id for the fan in the inventory."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long NodeId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryApicFanDetails.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of record DCNM / APIC / SE. This determines the type of platform where inventory was collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version of record being pushed. This determines what was the API version for data available from the device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Serial number of the fan in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SerialNumber {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the APIC site from which this data is being collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SiteName {
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
        // <summary>
        /// <para type="description">"Vendor name of the fan in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string VendorName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"VID for the fan in the inventory."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Vid {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.NiatelemetryApicFanDetails initObject = new Intersight.Model.NiatelemetryApicFanDetails();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Dn"))
            {
                initObject.Dn = this.Dn;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ModelNumber"))
            {
                initObject.ModelNumber = this.ModelNumber;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordType"))
            {
                initObject.RecordType = this.RecordType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordVersion"))
            {
                initObject.RecordVersion = this.RecordVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SerialNumber"))
            {
                initObject.SerialNumber = this.SerialNumber;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SiteName"))
            {
                initObject.SiteName = this.SiteName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VendorName"))
            {
                initObject.VendorName = this.VendorName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Vid"))
            {
                initObject.Vid = this.Vid;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryHttpsAclFilterDetails.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryHttpsAclFilterDetails")]
    public class InitializeIntersightNiatelemetryHttpsAclFilterDetails:PSCmdlet
	{
		public InitializeIntersightNiatelemetryHttpsAclFilterDetails()
		{
            ClassId = NiatelemetryHttpsAclFilterDetails.ClassIdEnum.NiatelemetryHttpsAclFilterDetails;
            ObjectType = NiatelemetryHttpsAclFilterDetails.ObjectTypeEnum.NiatelemetryHttpsAclFilterDetails;
            
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
        
        public NiatelemetryHttpsAclFilterDetails.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Destination From Port HTTPS ACL EPGs filter MO for APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string DestFromPort {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Destination To Port HTTPS ACL EPGs filter MO for APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string DestToPort {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Dn of the HTTPS ACL EPGs filter MO for APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Dn {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of HTTPS ACL filter for APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string FilterName {
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryHttpsAclFilterDetails.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Prot of the HTTPS ACL EPGs filter MO for APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Prot {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of record DCNM / APIC / SE. This determines the type of platform where inventory was collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version of record being pushed. This determines what was the API version for data available from the device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the APIC site from which this data is being collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SiteName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Source From Port HTTPS ACL EPGs filter MO for APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SrcFromPort {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Source To Port HTTPS ACL EPGs filter MO for APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SrcToPort {
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
             Intersight.Model.NiatelemetryHttpsAclFilterDetails initObject = new Intersight.Model.NiatelemetryHttpsAclFilterDetails();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("DestFromPort"))
            {
                initObject.DestFromPort = this.DestFromPort;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DestToPort"))
            {
                initObject.DestToPort = this.DestToPort;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Dn"))
            {
                initObject.Dn = this.Dn;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FilterName"))
            {
                initObject.FilterName = this.FilterName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Prot"))
            {
                initObject.Prot = this.Prot;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordType"))
            {
                initObject.RecordType = this.RecordType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordVersion"))
            {
                initObject.RecordVersion = this.RecordVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SiteName"))
            {
                initObject.SiteName = this.SiteName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SrcFromPort"))
            {
                initObject.SrcFromPort = this.SrcFromPort;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SrcToPort"))
            {
                initObject.SrcToPort = this.SrcToPort;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryNexusDashboardMemoryDetails.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryNexusDashboardMemoryDetails")]
    public class InitializeIntersightNiatelemetryNexusDashboardMemoryDetails:PSCmdlet
	{
		public InitializeIntersightNiatelemetryNexusDashboardMemoryDetails()
		{
            ClassId = NiatelemetryNexusDashboardMemoryDetails.ClassIdEnum.NiatelemetryNexusDashboardMemoryDetails;
            ObjectType = NiatelemetryNexusDashboardMemoryDetails.ObjectTypeEnum.NiatelemetryNexusDashboardMemoryDetails;
            
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
        
        public NiatelemetryNexusDashboardMemoryDetails.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the node in Nexus Dashboard cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string DeviceName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Memory capacity of a node in Nexus Dashboard."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long MemoryCapacity {
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryNexusDashboardMemoryDetails.ObjectTypeEnum ObjectType {
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
             Intersight.Model.NiatelemetryNexusDashboardMemoryDetails initObject = new Intersight.Model.NiatelemetryNexusDashboardMemoryDetails();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("DeviceName"))
            {
                initObject.DeviceName = this.DeviceName;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
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
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryTenant.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryTenant")]
    public class InitializeIntersightNiatelemetryTenant:PSCmdlet
	{
		public InitializeIntersightNiatelemetryTenant()
		{
            ClassId = NiatelemetryTenant.ClassIdEnum.NiatelemetryTenant;
            ObjectType = NiatelemetryTenant.ObjectTypeEnum.NiatelemetryTenant;
            
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
        /// <para type="description">"Number of Bidirectional Forwarding Detection bfdIfPol Model Objects."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long BfdIfPolCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of objects with Bidirectional Forwarding Detection Interface Policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long BfdIfpCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryTenant.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of tenants with Dynamic Host Configuration Protocol enabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long DhcpRsProvCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Dn for the tenants present."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Dn {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of objects with First hop security. Checks for presence of IP source gaurd, dynamic arp inspection."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long FhsBdPolCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of application profiles per tenant."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long FvApCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of bridge domains with hardware proxy enabled per tenant."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long FvBdCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of bridge domain subnets per tenant."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long FvBdSubnetCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of bridge domains with ARP flodding disabled per tenant."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long FvBdnoArpCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Count of number of endpoints per tenant."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long FvCepCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of objects with First hop security. Checks for presence of IP source gaurd, dynamic arp inspection."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long FvRsBdToFhsCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of bridge domains connected to layer 3 out per tenant."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long FvRsBdToOutCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of Multi-Site objects."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long FvSiteConnpCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of subnets per tenant."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long FvSubnetCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of IP static routes per tenant."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long IpStaticRouteCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of layer 3 multicasts."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long L3MulticastCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of layer 3 multicast CtxP."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long L3MulticastCtxCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of layer 3 multicast IfP."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long L3MulticastIfCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of L3 out objects for the tenants present."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long L3outCount {
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryTenant.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of Quality Of Service Custom Policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long QosCustomPolCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of record DCNM / APIC / SE. This determines the type of platform where inventory was collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version of record being pushed. This determines what was the API version for data available from the device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Site name represents an APIC cluster. Service Engine can onboard multiple APIC clusters / sites."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SiteName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"SSM property feature usage."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Ssm {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of context-level ssm translate policies per tenant."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long SsmCount {
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
        // <summary>
        /// <para type="description">"Number of TCAM optimization enabled per tenant."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long TcamOptCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of ITrace route endpoint per tenant."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long TraceRouteEpCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of ITrace endpoint external routes per tenant."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long TraceRouteEpExtCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of ITrace external endpoint routes per tenant."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long TraceRouteExtEpCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of ITrace external routes per tenant."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long TraceRouteExtExtCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of objects with L4 to L7 Services graph."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long VnsAbsGraphCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of objects with Policy Based Routing standby Node. Checks the Policy Based Routing backup policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long VnsBackupPolCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of objects with Policy Based Routing standby Node. Policy based redirect requires a destination to redirect traffic."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long VnsRedirectDestCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of Policy Based Routing and Policy Based Service Insertion objects. Includes without L4-L7 package."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long VnsSvcRedirectPolCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of Vrfs per tenant."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long VrfCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of Zoning Policy per tenant."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long VzBrCpCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of Client Contract between End Point Groups per tenant."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long VzRtConsCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of Client Contract between End Point Groups per tenant."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long VzRtProvCount {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.NiatelemetryTenant initObject = new Intersight.Model.NiatelemetryTenant();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BfdIfPolCount"))
            {
                initObject.BfdIfPolCount = this.BfdIfPolCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BfdIfpCount"))
            {
                initObject.BfdIfpCount = this.BfdIfpCount;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("DhcpRsProvCount"))
            {
                initObject.DhcpRsProvCount = this.DhcpRsProvCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Dn"))
            {
                initObject.Dn = this.Dn;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FhsBdPolCount"))
            {
                initObject.FhsBdPolCount = this.FhsBdPolCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FvApCount"))
            {
                initObject.FvApCount = this.FvApCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FvBdCount"))
            {
                initObject.FvBdCount = this.FvBdCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FvBdSubnetCount"))
            {
                initObject.FvBdSubnetCount = this.FvBdSubnetCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FvBdnoArpCount"))
            {
                initObject.FvBdnoArpCount = this.FvBdnoArpCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FvCepCount"))
            {
                initObject.FvCepCount = this.FvCepCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FvRsBdToFhsCount"))
            {
                initObject.FvRsBdToFhsCount = this.FvRsBdToFhsCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FvRsBdToOutCount"))
            {
                initObject.FvRsBdToOutCount = this.FvRsBdToOutCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FvSiteConnpCount"))
            {
                initObject.FvSiteConnpCount = this.FvSiteConnpCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FvSubnetCount"))
            {
                initObject.FvSubnetCount = this.FvSubnetCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IpStaticRouteCount"))
            {
                initObject.IpStaticRouteCount = this.IpStaticRouteCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("L3MulticastCount"))
            {
                initObject.L3MulticastCount = this.L3MulticastCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("L3MulticastCtxCount"))
            {
                initObject.L3MulticastCtxCount = this.L3MulticastCtxCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("L3MulticastIfCount"))
            {
                initObject.L3MulticastIfCount = this.L3MulticastIfCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("L3outCount"))
            {
                initObject.L3outCount = this.L3outCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("QosCustomPolCount"))
            {
                initObject.QosCustomPolCount = this.QosCustomPolCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordType"))
            {
                initObject.RecordType = this.RecordType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordVersion"))
            {
                initObject.RecordVersion = this.RecordVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SiteName"))
            {
                initObject.SiteName = this.SiteName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Ssm"))
            {
                initObject.Ssm = this.Ssm;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SsmCount"))
            {
                initObject.SsmCount = this.SsmCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TcamOptCount"))
            {
                initObject.TcamOptCount = this.TcamOptCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TraceRouteEpCount"))
            {
                initObject.TraceRouteEpCount = this.TraceRouteEpCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TraceRouteEpExtCount"))
            {
                initObject.TraceRouteEpExtCount = this.TraceRouteEpExtCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TraceRouteExtEpCount"))
            {
                initObject.TraceRouteExtEpCount = this.TraceRouteExtEpCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TraceRouteExtExtCount"))
            {
                initObject.TraceRouteExtExtCount = this.TraceRouteExtExtCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VnsAbsGraphCount"))
            {
                initObject.VnsAbsGraphCount = this.VnsAbsGraphCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VnsBackupPolCount"))
            {
                initObject.VnsBackupPolCount = this.VnsBackupPolCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VnsRedirectDestCount"))
            {
                initObject.VnsRedirectDestCount = this.VnsRedirectDestCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VnsSvcRedirectPolCount"))
            {
                initObject.VnsSvcRedirectPolCount = this.VnsSvcRedirectPolCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VrfCount"))
            {
                initObject.VrfCount = this.VrfCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VzBrCpCount"))
            {
                initObject.VzBrCpCount = this.VzBrCpCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VzRtConsCount"))
            {
                initObject.VzRtConsCount = this.VzRtConsCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VzRtProvCount"))
            {
                initObject.VzRtProvCount = this.VzRtProvCount;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryNetworkInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryNetworkInfo")]
    public class InitializeIntersightNiatelemetryNetworkInfo:PSCmdlet
	{
		public InitializeIntersightNiatelemetryNetworkInfo()
		{
            ClassId = NiatelemetryNetworkInfo.ClassIdEnum.NiatelemetryNetworkInfo;
            ObjectType = NiatelemetryNetworkInfo.ObjectTypeEnum.NiatelemetryNetworkInfo;
            
		}
        // <summary>
        /// <para type="description">"Returns details of active node."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.NiatelemetryNode ActiveNode {
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryNetworkInfo.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns hostname of the network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Hostname {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns management IP of the network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ManagementtIp {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryNetworkInfo.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns out of band IP of the network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string OutofbandIp {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns details of standby node."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.NiatelemetryNode StandbyNode {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.NiatelemetryNetworkInfo initObject = new Intersight.Model.NiatelemetryNetworkInfo();
            if (this.MyInvocation.BoundParameters.ContainsKey("ActiveNode"))
            {
                initObject.ActiveNode = this.ActiveNode;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Hostname"))
            {
                initObject.Hostname = this.Hostname;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ManagementtIp"))
            {
                initObject.ManagementtIp = this.ManagementtIp;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("OutofbandIp"))
            {
                initObject.OutofbandIp = this.OutofbandIp;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("StandbyNode"))
            {
                initObject.StandbyNode = this.StandbyNode;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryMsoContractDetails.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryMsoContractDetails")]
    public class InitializeIntersightNiatelemetryMsoContractDetails:PSCmdlet
	{
		public InitializeIntersightNiatelemetryMsoContractDetails()
		{
            ClassId = NiatelemetryMsoContractDetails.ClassIdEnum.NiatelemetryMsoContractDetails;
            ObjectType = NiatelemetryMsoContractDetails.ObjectTypeEnum.NiatelemetryMsoContractDetails;
            
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
        
        public NiatelemetryMsoContractDetails.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of contract in Multi-Site Orchestrator."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ContractName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Site Ids to which this contract is deployed to."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string DeployedSites {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Is the contract local to the Multi-Site Orchestrator."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string IsLocal {
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryMsoContractDetails.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Unique reference for the contract in the Multi-Site Orchestrator."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Reference {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Schema ID in Multi-Site Orchestrator."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SchemaId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Schema name this contract belongs to in Multi-Site Orchestrator."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SchemaName {
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
        // <summary>
        /// <para type="description">"Template name this contract belongs to in Multi-Site Orchestrator."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string TemplateName {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.NiatelemetryMsoContractDetails initObject = new Intersight.Model.NiatelemetryMsoContractDetails();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ContractName"))
            {
                initObject.ContractName = this.ContractName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DeployedSites"))
            {
                initObject.DeployedSites = this.DeployedSites;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IsLocal"))
            {
                initObject.IsLocal = this.IsLocal;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Reference"))
            {
                initObject.Reference = this.Reference;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SchemaId"))
            {
                initObject.SchemaId = this.SchemaId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SchemaName"))
            {
                initObject.SchemaName = this.SchemaName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TemplateName"))
            {
                initObject.TemplateName = this.TemplateName;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetrySiteInventory.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetrySiteInventory")]
    public class InitializeIntersightNiatelemetrySiteInventory:PSCmdlet
	{
		public InitializeIntersightNiatelemetrySiteInventory()
		{
            ClassId = NiatelemetrySiteInventory.ClassIdEnum.NiatelemetrySiteInventory;
            ObjectType = NiatelemetrySiteInventory.ObjectTypeEnum.NiatelemetrySiteInventory;
            
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
        
        public List<string> Apps {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetrySiteInventory.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version of the specified site."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string FirmwareVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Fine-grained type DCNM either SAN or LAN."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string InstallType {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> IpAddress {
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
        /// <para type="description">"Name of the APIC / DCNM site onboarded."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of ND on which site has been onboarded."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string NexusDashboard {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of nodes the site contains."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Nodes {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetrySiteInventory.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Specifies whether Site object is DCNM or APIC or ND."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordType {
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
        // <summary>
        /// <para type="description">"Type of site onboarded either APIC or DCNM."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Type {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.NiatelemetrySiteInventory initObject = new Intersight.Model.NiatelemetrySiteInventory();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Apps"))
            {
                initObject.Apps = this.Apps;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("FirmwareVersion"))
            {
                initObject.FirmwareVersion = this.FirmwareVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InstallType"))
            {
                initObject.InstallType = this.InstallType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IpAddress"))
            {
                initObject.IpAddress = this.IpAddress;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NexusDashboard"))
            {
                initObject.NexusDashboard = this.NexusDashboard;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Nodes"))
            {
                initObject.Nodes = this.Nodes;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordType"))
            {
                initObject.RecordType = this.RecordType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Type"))
            {
                initObject.Type = this.Type;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryDcnmFanDetails.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryDcnmFanDetails")]
    public class InitializeIntersightNiatelemetryDcnmFanDetails:PSCmdlet
	{
		public InitializeIntersightNiatelemetryDcnmFanDetails()
		{
            ClassId = NiatelemetryDcnmFanDetails.ClassIdEnum.NiatelemetryDcnmFanDetails;
            ObjectType = NiatelemetryDcnmFanDetails.ObjectTypeEnum.NiatelemetryDcnmFanDetails;
            
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
        
        public NiatelemetryDcnmFanDetails.ClassIdEnum ClassId {
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
        /// <para type="description">"Name of the fan used in the switch."</para>
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
        
        public NiatelemetryDcnmFanDetails.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Product ID of the fan used in the switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ProductId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of record. This determines the type of platform where inventory was collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version of record being pushed. This determines what was the API version for data available from the device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Serial number of the fan used in the switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SerialNumber {
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
        // <summary>
        /// <para type="description">"Vendor Id of the fan used in the switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string VendorId {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.NiatelemetryDcnmFanDetails initObject = new Intersight.Model.NiatelemetryDcnmFanDetails();
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
            if (this.MyInvocation.BoundParameters.ContainsKey("ProductId"))
            {
                initObject.ProductId = this.ProductId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordType"))
            {
                initObject.RecordType = this.RecordType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordVersion"))
            {
                initObject.RecordVersion = this.RecordVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SerialNumber"))
            {
                initObject.SerialNumber = this.SerialNumber;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VendorId"))
            {
                initObject.VendorId = this.VendorId;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryFabricPodProfile.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryFabricPodProfile")]
    public class InitializeIntersightNiatelemetryFabricPodProfile:PSCmdlet
	{
		public InitializeIntersightNiatelemetryFabricPodProfile()
		{
            ClassId = NiatelemetryFabricPodProfile.ClassIdEnum.NiatelemetryFabricPodProfile;
            ObjectType = NiatelemetryFabricPodProfile.ObjectTypeEnum.NiatelemetryFabricPodProfile;
            
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
        
        public NiatelemetryFabricPodProfile.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Dn of the Fabric pod profile for APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Dn {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Dn of the Children PodS for the above Pod Profile ."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string FabricPodsList {
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
        /// <para type="description">"Name of the Fabric pod profile for APIC."</para>
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
        
        public NiatelemetryFabricPodProfile.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of record DCNM / APIC / SE. This determines the type of platform where inventory was collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version of record being pushed. This determines what was the API version for data available from the device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the APIC site from which this data is being collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SiteName {
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
             Intersight.Model.NiatelemetryFabricPodProfile initObject = new Intersight.Model.NiatelemetryFabricPodProfile();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Dn"))
            {
                initObject.Dn = this.Dn;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FabricPodsList"))
            {
                initObject.FabricPodsList = this.FabricPodsList;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordType"))
            {
                initObject.RecordType = this.RecordType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordVersion"))
            {
                initObject.RecordVersion = this.RecordVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SiteName"))
            {
                initObject.SiteName = this.SiteName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
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
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryApicUiPageCounts.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryApicUiPageCounts")]
    public class InitializeIntersightNiatelemetryApicUiPageCounts:PSCmdlet
	{
		public InitializeIntersightNiatelemetryApicUiPageCounts()
		{
            ClassId = NiatelemetryApicUiPageCounts.ClassIdEnum.NiatelemetryApicUiPageCounts;
            ObjectType = NiatelemetryApicUiPageCounts.ObjectTypeEnum.NiatelemetryApicUiPageCounts;
            
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
        
        public NiatelemetryApicUiPageCounts.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Dn of the page opened by the user."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Dn {
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryApicUiPageCounts.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of times that the user has opened this page."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long PageCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the page for which page count is recorded."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string PageName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of record DCNM / APIC / SE. This determines the type of platform where inventory was collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version of record being pushed. This determines what was the API version for data available from the device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the APIC site from which this data is being collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SiteName {
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
             Intersight.Model.NiatelemetryApicUiPageCounts initObject = new Intersight.Model.NiatelemetryApicUiPageCounts();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Dn"))
            {
                initObject.Dn = this.Dn;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("PageCount"))
            {
                initObject.PageCount = this.PageCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PageName"))
            {
                initObject.PageName = this.PageName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordType"))
            {
                initObject.RecordType = this.RecordType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordVersion"))
            {
                initObject.RecordVersion = this.RecordVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SiteName"))
            {
                initObject.SiteName = this.SiteName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryNxosBgpEvpn.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryNxosBgpEvpn")]
    public class InitializeIntersightNiatelemetryNxosBgpEvpn:PSCmdlet
	{
		public InitializeIntersightNiatelemetryNxosBgpEvpn()
		{
            ClassId = NiatelemetryNxosBgpEvpn.ClassIdEnum.NiatelemetryNxosBgpEvpn;
            ObjectType = NiatelemetryNxosBgpEvpn.ObjectTypeEnum.NiatelemetryNxosBgpEvpn;
            
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
        
        public NiatelemetryNxosBgpEvpn.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns the EVPN mac count."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string NxosEvpnMacCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryNxosBgpEvpn.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns the BGP EVPN total networks."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long TotalNetworks {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns the BGP EVPN total paths."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long TotalPaths {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.NiatelemetryNxosBgpEvpn initObject = new Intersight.Model.NiatelemetryNxosBgpEvpn();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("NxosEvpnMacCount"))
            {
                initObject.NxosEvpnMacCount = this.NxosEvpnMacCount;
            }
            initObject.ObjectType = this.ObjectType;
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
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryMsoEpgDetails.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryMsoEpgDetails")]
    public class InitializeIntersightNiatelemetryMsoEpgDetails:PSCmdlet
	{
		public InitializeIntersightNiatelemetryMsoEpgDetails()
		{
            ClassId = NiatelemetryMsoEpgDetails.ClassIdEnum.NiatelemetryMsoEpgDetails;
            ObjectType = NiatelemetryMsoEpgDetails.ObjectTypeEnum.NiatelemetryMsoEpgDetails;
            
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
        
        public NiatelemetryMsoEpgDetails.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Site Ids to which this EPG is deployed to."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string DeployedSites {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of EPG in Multi-Site Orchestrator."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string EpgName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Is the EPG local to the Multi-Site Orchestrator."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string IsLocal {
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryMsoEpgDetails.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Unique reference for the EPG in the Multi-Site Orchestrator."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Reference {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Schema ID in Multi-Site Orchestrator."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SchemaId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Schema name in Multi-Site Orchestrator."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SchemaName {
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
        // <summary>
        /// <para type="description">"Template name in Multi-Site Orchestrator."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string TemplateName {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.NiatelemetryMsoEpgDetails initObject = new Intersight.Model.NiatelemetryMsoEpgDetails();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("DeployedSites"))
            {
                initObject.DeployedSites = this.DeployedSites;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EpgName"))
            {
                initObject.EpgName = this.EpgName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IsLocal"))
            {
                initObject.IsLocal = this.IsLocal;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Reference"))
            {
                initObject.Reference = this.Reference;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SchemaId"))
            {
                initObject.SchemaId = this.SchemaId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SchemaName"))
            {
                initObject.SchemaName = this.SchemaName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TemplateName"))
            {
                initObject.TemplateName = this.TemplateName;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryApicSnmpCommunityAccessDetails.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryApicSnmpCommunityAccessDetails")]
    public class InitializeIntersightNiatelemetryApicSnmpCommunityAccessDetails:PSCmdlet
	{
		public InitializeIntersightNiatelemetryApicSnmpCommunityAccessDetails()
		{
            ClassId = NiatelemetryApicSnmpCommunityAccessDetails.ClassIdEnum.NiatelemetryApicSnmpCommunityAccessDetails;
            ObjectType = NiatelemetryApicSnmpCommunityAccessDetails.ObjectTypeEnum.NiatelemetryApicSnmpCommunityAccessDetails;
            
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
        /// <para type="description">"Address of SNMP community access in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Addr {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryApicSnmpCommunityAccessDetails.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Dn of SNMP Community access  in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Dn {
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryApicSnmpCommunityAccessDetails.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of record DCNM / APIC / SE. This determines the type of platform where inventory was collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version of record being pushed. This determines what was the API version for data available from the device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the APIC site from which this data is being collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SiteName {
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
             Intersight.Model.NiatelemetryApicSnmpCommunityAccessDetails initObject = new Intersight.Model.NiatelemetryApicSnmpCommunityAccessDetails();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Addr"))
            {
                initObject.Addr = this.Addr;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Dn"))
            {
                initObject.Dn = this.Dn;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordType"))
            {
                initObject.RecordType = this.RecordType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordVersion"))
            {
                initObject.RecordVersion = this.RecordVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SiteName"))
            {
                initObject.SiteName = this.SiteName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
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
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryFabricModuleDetails.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryFabricModuleDetails")]
    public class InitializeIntersightNiatelemetryFabricModuleDetails:PSCmdlet
	{
		public InitializeIntersightNiatelemetryFabricModuleDetails()
		{
            ClassId = NiatelemetryFabricModuleDetails.ClassIdEnum.NiatelemetryFabricModuleDetails;
            ObjectType = NiatelemetryFabricModuleDetails.ObjectTypeEnum.NiatelemetryFabricModuleDetails;
            
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
        
        public NiatelemetryFabricModuleDetails.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Dn of the fabric module in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Dn {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Hardware version of fabric module."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string HwVer {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Model of the fabric module."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Model {
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryFabricModuleDetails.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of record DCNM / APIC / SE. This determines the type of platform where inventory was collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version of record being pushed. This determines what was the API version for data available from the device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Revision of the fabric module."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Revision {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Serial number of the fabric module."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Serial {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the APIC site from which this data is being collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SiteName {
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
        // <summary>
        /// <para type="description">"Type of the fabric module."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Type {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.NiatelemetryFabricModuleDetails initObject = new Intersight.Model.NiatelemetryFabricModuleDetails();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Dn"))
            {
                initObject.Dn = this.Dn;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HwVer"))
            {
                initObject.HwVer = this.HwVer;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Model"))
            {
                initObject.Model = this.Model;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordType"))
            {
                initObject.RecordType = this.RecordType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordVersion"))
            {
                initObject.RecordVersion = this.RecordVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Revision"))
            {
                initObject.Revision = this.Revision;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Serial"))
            {
                initObject.Serial = this.Serial;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SiteName"))
            {
                initObject.SiteName = this.SiteName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Type"))
            {
                initObject.Type = this.Type;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryAppDetails.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryAppDetails")]
    public class InitializeIntersightNiatelemetryAppDetails:PSCmdlet
	{
		public InitializeIntersightNiatelemetryAppDetails()
		{
            ClassId = NiatelemetryAppDetails.ClassIdEnum.NiatelemetryAppDetails;
            ObjectType = NiatelemetryAppDetails.ObjectTypeEnum.NiatelemetryAppDetails;
            
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
        /// <para type="description">"Names of apps running on ND."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string AppName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Status of apps running on ND."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string AppStatus {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Versions of apps running on ND."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string AppVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryAppDetails.ClassIdEnum ClassId {
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
        /// <para type="description">"Clustername on which apps are running on ND."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string NexusDashboard {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of sites on which particular app installed on ND."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long NumberOfSitesOnboarded {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryAppDetails.ObjectTypeEnum ObjectType {
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
        // <summary>
        /// <para type="description">"Type of apps running on ND."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Type {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.NiatelemetryAppDetails initObject = new Intersight.Model.NiatelemetryAppDetails();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AppName"))
            {
                initObject.AppName = this.AppName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AppStatus"))
            {
                initObject.AppStatus = this.AppStatus;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AppVersion"))
            {
                initObject.AppVersion = this.AppVersion;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NexusDashboard"))
            {
                initObject.NexusDashboard = this.NexusDashboard;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NumberOfSitesOnboarded"))
            {
                initObject.NumberOfSitesOnboarded = this.NumberOfSitesOnboarded;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Type"))
            {
                initObject.Type = this.Type;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryDcnmModuleDetails.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryDcnmModuleDetails")]
    public class InitializeIntersightNiatelemetryDcnmModuleDetails:PSCmdlet
	{
		public InitializeIntersightNiatelemetryDcnmModuleDetails()
		{
            ClassId = NiatelemetryDcnmModuleDetails.ClassIdEnum.NiatelemetryDcnmModuleDetails;
            ObjectType = NiatelemetryDcnmModuleDetails.ObjectTypeEnum.NiatelemetryDcnmModuleDetails;
            
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
        
        public NiatelemetryDcnmModuleDetails.ClassIdEnum ClassId {
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
        /// <para type="description">"Name of the hardware module in the fabric inventory."</para>
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
        
        public NiatelemetryDcnmModuleDetails.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Product ID of the hardware module in the fabric inventory."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ProductId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of record DCNM / APIC / SE. This determines the type of platform where inventory was collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version of record being pushed. This determines what was the API version for data available from the device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Serial number of the hardware module in the fabric inventory."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SerialNumber {
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
        // <summary>
        /// <para type="description">"Vendor Id of the hardware module in the fabric inventory."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string VendorId {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.NiatelemetryDcnmModuleDetails initObject = new Intersight.Model.NiatelemetryDcnmModuleDetails();
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
            if (this.MyInvocation.BoundParameters.ContainsKey("ProductId"))
            {
                initObject.ProductId = this.ProductId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordType"))
            {
                initObject.RecordType = this.RecordType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordVersion"))
            {
                initObject.RecordVersion = this.RecordVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SerialNumber"))
            {
                initObject.SerialNumber = this.SerialNumber;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VendorId"))
            {
                initObject.VendorId = this.VendorId;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryAaaLdapProviderDetails.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryAaaLdapProviderDetails")]
    public class InitializeIntersightNiatelemetryAaaLdapProviderDetails:PSCmdlet
	{
		public InitializeIntersightNiatelemetryAaaLdapProviderDetails()
		{
            ClassId = NiatelemetryAaaLdapProviderDetails.ClassIdEnum.NiatelemetryAaaLdapProviderDetails;
            ObjectType = NiatelemetryAaaLdapProviderDetails.ObjectTypeEnum.NiatelemetryAaaLdapProviderDetails;
            
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
        /// <para type="description">"Base dn of the AAA ldap provider in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string BaseDn {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryAaaLdapProviderDetails.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Dn of the AAA ldap provider in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Dn {
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryAaaLdapProviderDetails.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Port of the AAA ldap provider in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Port {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of record DCNM / APIC / SE. This determines the type of platform where inventory was collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version of record being pushed. This determines what was the API version for data available from the device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Root dn of the AAA ldap provider in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RootDn {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the APIC site from which this data is being collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SiteName {
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
             Intersight.Model.NiatelemetryAaaLdapProviderDetails initObject = new Intersight.Model.NiatelemetryAaaLdapProviderDetails();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BaseDn"))
            {
                initObject.BaseDn = this.BaseDn;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Dn"))
            {
                initObject.Dn = this.Dn;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordType"))
            {
                initObject.RecordType = this.RecordType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordVersion"))
            {
                initObject.RecordVersion = this.RecordVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RootDn"))
            {
                initObject.RootDn = this.RootDn;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SiteName"))
            {
                initObject.SiteName = this.SiteName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryApicSnmpVersionThreeDetails.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryApicSnmpVersionThreeDetails")]
    public class InitializeIntersightNiatelemetryApicSnmpVersionThreeDetails:PSCmdlet
	{
		public InitializeIntersightNiatelemetryApicSnmpVersionThreeDetails()
		{
            ClassId = NiatelemetryApicSnmpVersionThreeDetails.ClassIdEnum.NiatelemetryApicSnmpVersionThreeDetails;
            ObjectType = NiatelemetryApicSnmpVersionThreeDetails.ObjectTypeEnum.NiatelemetryApicSnmpVersionThreeDetails;
            
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
        /// <para type="description">"AuthType of SNMP V3 in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string AuthType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryApicSnmpVersionThreeDetails.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Dn of SNMP V3 attribute in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Dn {
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
        /// <para type="description">"Name of SNMP V3 attribute in APIC."</para>
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
        
        public NiatelemetryApicSnmpVersionThreeDetails.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"PrivType of SNMP V3 in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string PrivType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of record DCNM / APIC / SE. This determines the type of platform where inventory was collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version of record being pushed. This determines what was the API version for data available from the device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the APIC site from which this data is being collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SiteName {
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
             Intersight.Model.NiatelemetryApicSnmpVersionThreeDetails initObject = new Intersight.Model.NiatelemetryApicSnmpVersionThreeDetails();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AuthType"))
            {
                initObject.AuthType = this.AuthType;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Dn"))
            {
                initObject.Dn = this.Dn;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("PrivType"))
            {
                initObject.PrivType = this.PrivType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordType"))
            {
                initObject.RecordType = this.RecordType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordVersion"))
            {
                initObject.RecordVersion = this.RecordVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SiteName"))
            {
                initObject.SiteName = this.SiteName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryApicFexDetails.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryApicFexDetails")]
    public class InitializeIntersightNiatelemetryApicFexDetails:PSCmdlet
	{
		public InitializeIntersightNiatelemetryApicFexDetails()
		{
            ClassId = NiatelemetryApicFexDetails.ClassIdEnum.NiatelemetryApicFexDetails;
            ObjectType = NiatelemetryApicFexDetails.ObjectTypeEnum.NiatelemetryApicFexDetails;
            
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
        
        public NiatelemetryApicFexDetails.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Dn for the FEX in the inventory."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Dn {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Model number of the FEX in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ModelNumber {
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
        /// <para type="description">"Node id for the FEX in the inventory."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long NodeId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryApicFexDetails.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of record DCNM / APIC / SE. This determines the type of platform where inventory was collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version of record being pushed. This determines what was the API version for data available from the device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Serial number of the FEX in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SerialNumber {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the APIC site from which this data is being collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SiteName {
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
        // <summary>
        /// <para type="description">"Vendor name of the FEX in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string VendorName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"VID for the FEX in the inventory."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Vid {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.NiatelemetryApicFexDetails initObject = new Intersight.Model.NiatelemetryApicFexDetails();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Dn"))
            {
                initObject.Dn = this.Dn;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ModelNumber"))
            {
                initObject.ModelNumber = this.ModelNumber;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordType"))
            {
                initObject.RecordType = this.RecordType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordVersion"))
            {
                initObject.RecordVersion = this.RecordVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SerialNumber"))
            {
                initObject.SerialNumber = this.SerialNumber;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SiteName"))
            {
                initObject.SiteName = this.SiteName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VendorName"))
            {
                initObject.VendorName = this.VendorName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Vid"))
            {
                initObject.Vid = this.Vid;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryApicSysLogGrp.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryApicSysLogGrp")]
    public class InitializeIntersightNiatelemetryApicSysLogGrp:PSCmdlet
	{
		public InitializeIntersightNiatelemetryApicSysLogGrp()
		{
            ClassId = NiatelemetryApicSysLogGrp.ClassIdEnum.NiatelemetryApicSysLogGrp;
            ObjectType = NiatelemetryApicSysLogGrp.ObjectTypeEnum.NiatelemetryApicSysLogGrp;
            
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
        
        public NiatelemetryApicSysLogGrp.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Dn of the SysLogGroup in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Dn {
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryApicSysLogGrp.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of record DCNM / APIC / SE. This determines the type of platform where inventory was collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version of record being pushed. This determines what was the API version for data available from the device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Count of remote destinations configured."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long RemoteDestCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the APIC site from which this data is being collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SiteName {
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
             Intersight.Model.NiatelemetryApicSysLogGrp initObject = new Intersight.Model.NiatelemetryApicSysLogGrp();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Dn"))
            {
                initObject.Dn = this.Dn;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordType"))
            {
                initObject.RecordType = this.RecordType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordVersion"))
            {
                initObject.RecordVersion = this.RecordVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RemoteDestCount"))
            {
                initObject.RemoteDestCount = this.RemoteDestCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SiteName"))
            {
                initObject.SiteName = this.SiteName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetrySyslogRemoteDest.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetrySyslogRemoteDest")]
    public class InitializeIntersightNiatelemetrySyslogRemoteDest:PSCmdlet
	{
		public InitializeIntersightNiatelemetrySyslogRemoteDest()
		{
            ClassId = NiatelemetrySyslogRemoteDest.ClassIdEnum.NiatelemetrySyslogRemoteDest;
            ObjectType = NiatelemetrySyslogRemoteDest.ObjectTypeEnum.NiatelemetrySyslogRemoteDest;
            
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
        /// <para type="description">"Admin state of Syslog remote dest in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string AdminState {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetrySyslogRemoteDest.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Parent common policy for syslog src in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string CommonPolicy {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Dn of the Syslog remote dest in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Dn {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Host of Syslog remote dest in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Host {
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetrySyslogRemoteDest.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of record DCNM / APIC / SE. This determines the type of platform where inventory was collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version of record being pushed. This determines what was the API version for data available from the device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the APIC site from which this data is being collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SiteName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Dn of sys log src dest grp in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SyslogRsDestGrp {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Dn of parent syslog src for the syslog dest grp in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SyslogSrc {
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
             Intersight.Model.NiatelemetrySyslogRemoteDest initObject = new Intersight.Model.NiatelemetrySyslogRemoteDest();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdminState"))
            {
                initObject.AdminState = this.AdminState;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("CommonPolicy"))
            {
                initObject.CommonPolicy = this.CommonPolicy;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Dn"))
            {
                initObject.Dn = this.Dn;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordType"))
            {
                initObject.RecordType = this.RecordType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordVersion"))
            {
                initObject.RecordVersion = this.RecordVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SiteName"))
            {
                initObject.SiteName = this.SiteName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SyslogRsDestGrp"))
            {
                initObject.SyslogRsDestGrp = this.SyslogRsDestGrp;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SyslogSrc"))
            {
                initObject.SyslogSrc = this.SyslogSrc;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryApicPsuDetails.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryApicPsuDetails")]
    public class InitializeIntersightNiatelemetryApicPsuDetails:PSCmdlet
	{
		public InitializeIntersightNiatelemetryApicPsuDetails()
		{
            ClassId = NiatelemetryApicPsuDetails.ClassIdEnum.NiatelemetryApicPsuDetails;
            ObjectType = NiatelemetryApicPsuDetails.ObjectTypeEnum.NiatelemetryApicPsuDetails;
            
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
        
        public NiatelemetryApicPsuDetails.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Dn for the PSU in the inventory."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Dn {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Model number of the PSU in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ModelNumber {
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
        /// <para type="description">"Node id for the PSU in the inventory."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long NodeId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryApicPsuDetails.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of record DCNM / APIC / SE. This determines the type of platform where inventory was collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version of record being pushed. This determines what was the API version for data available from the device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Serial number of the PSU in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SerialNumber {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the APIC site from which this data is being collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SiteName {
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
        // <summary>
        /// <para type="description">"Vendor name of the PSU in APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string VendorName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"VID for the PSU in the inventory."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Vid {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.NiatelemetryApicPsuDetails initObject = new Intersight.Model.NiatelemetryApicPsuDetails();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Dn"))
            {
                initObject.Dn = this.Dn;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ModelNumber"))
            {
                initObject.ModelNumber = this.ModelNumber;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordType"))
            {
                initObject.RecordType = this.RecordType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordVersion"))
            {
                initObject.RecordVersion = this.RecordVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SerialNumber"))
            {
                initObject.SerialNumber = this.SerialNumber;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SiteName"))
            {
                initObject.SiteName = this.SiteName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VendorName"))
            {
                initObject.VendorName = this.VendorName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Vid"))
            {
                initObject.Vid = this.Vid;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryDeploymentStatus.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryDeploymentStatus")]
    public class InitializeIntersightNiatelemetryDeploymentStatus:PSCmdlet
	{
		public InitializeIntersightNiatelemetryDeploymentStatus()
		{
            ClassId = NiatelemetryDeploymentStatus.ClassIdEnum.NiatelemetryDeploymentStatus;
            ObjectType = NiatelemetryDeploymentStatus.ObjectTypeEnum.NiatelemetryDeploymentStatus;
            
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
        
        public NiatelemetryDeploymentStatus.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns the id of network/vrf."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Id {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns the name of network/vrf."</para>
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
        
        public NiatelemetryDeploymentStatus.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Returns the deployment status of network/vrf."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Status {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.NiatelemetryDeploymentStatus initObject = new Intersight.Model.NiatelemetryDeploymentStatus();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Id"))
            {
                initObject.Id = this.Id;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Status"))
            {
                initObject.Status = this.Status;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryHttpsAclContractFilterMap.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryHttpsAclContractFilterMap")]
    public class InitializeIntersightNiatelemetryHttpsAclContractFilterMap:PSCmdlet
	{
		public InitializeIntersightNiatelemetryHttpsAclContractFilterMap()
		{
            ClassId = NiatelemetryHttpsAclContractFilterMap.ClassIdEnum.NiatelemetryHttpsAclContractFilterMap;
            ObjectType = NiatelemetryHttpsAclContractFilterMap.ObjectTypeEnum.NiatelemetryHttpsAclContractFilterMap;
            
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
        
        public NiatelemetryHttpsAclContractFilterMap.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of HTTPS ACL contract for APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ContractName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Dn of the HTTPS ACL EPGs subject filter relation MO for APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Dn {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of HTTPS ACL filter for APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string FilterName {
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryHttpsAclContractFilterMap.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of record DCNM / APIC / SE. This determines the type of platform where inventory was collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version of record being pushed. This determines what was the API version for data available from the device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the APIC site from which this data is being collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SiteName {
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
             Intersight.Model.NiatelemetryHttpsAclContractFilterMap initObject = new Intersight.Model.NiatelemetryHttpsAclContractFilterMap();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ContractName"))
            {
                initObject.ContractName = this.ContractName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Dn"))
            {
                initObject.Dn = this.Dn;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FilterName"))
            {
                initObject.FilterName = this.FilterName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordType"))
            {
                initObject.RecordType = this.RecordType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordVersion"))
            {
                initObject.RecordVersion = this.RecordVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SiteName"))
            {
                initObject.SiteName = this.SiteName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryNexusDashboardControllerDetails.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryNexusDashboardControllerDetails")]
    public class InitializeIntersightNiatelemetryNexusDashboardControllerDetails:PSCmdlet
	{
		public InitializeIntersightNiatelemetryNexusDashboardControllerDetails()
		{
            ClassId = NiatelemetryNexusDashboardControllerDetails.ClassIdEnum.NiatelemetryNexusDashboardControllerDetails;
            ObjectType = NiatelemetryNexusDashboardControllerDetails.ObjectTypeEnum.NiatelemetryNexusDashboardControllerDetails;
            
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
        
        public NiatelemetryNexusDashboardControllerDetails.ClassIdEnum ClassId {
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryNexusDashboardControllerDetails.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Health of the site serviced by ND."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long SiteHealth {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of fabric domain of the controller."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SiteName {
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
        // <summary>
        /// <para type="description">"Version of the controller serviced by ND."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string VersionOfController {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.NiatelemetryNexusDashboardControllerDetails initObject = new Intersight.Model.NiatelemetryNexusDashboardControllerDetails();
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
            if (this.MyInvocation.BoundParameters.ContainsKey("SiteHealth"))
            {
                initObject.SiteHealth = this.SiteHealth;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SiteName"))
            {
                initObject.SiteName = this.SiteName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VersionOfController"))
            {
                initObject.VersionOfController = this.VersionOfController;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NiatelemetryNiaLicenseState.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNiatelemetryNiaLicenseState")]
    public class InitializeIntersightNiatelemetryNiaLicenseState:PSCmdlet
	{
		public InitializeIntersightNiatelemetryNiaLicenseState()
		{
            ClassId = NiatelemetryNiaLicenseState.ClassIdEnum.NiatelemetryNiaLicenseState;
            ObjectType = NiatelemetryNiaLicenseState.ObjectTypeEnum.NiatelemetryNiaLicenseState;
            
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
        
        public NiatelemetryNiaLicenseState.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a niatelemetryNiaInventory resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.NiatelemetryNiaInventoryRelationship Device {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Features activated on device being inventoried. This determines which features are currently enabled on the device that the license API can check."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string FeatureActivated {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Licenses activated on device being inventoried. This determines which lienceses are currently enabled on the device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string LicenseActivated {
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NiatelemetryNiaLicenseState.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"PID of device being inventoried. This determines the hardware model type of the device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string PidType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of record DCNM / APIC / SE. This determines the type of platform where inventory was collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version of record being pushed. This determines what was the API version for data available from the device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecordVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Serial number of device being inventoried. The serial number is unique per device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Serial {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of fabric domain of the controller."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SiteName {
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
             Intersight.Model.NiatelemetryNiaLicenseState initObject = new Intersight.Model.NiatelemetryNiaLicenseState();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Device"))
            {
                initObject.Device = this.Device;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FeatureActivated"))
            {
                initObject.FeatureActivated = this.FeatureActivated;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LicenseActivated"))
            {
                initObject.LicenseActivated = this.LicenseActivated;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("PidType"))
            {
                initObject.PidType = this.PidType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordType"))
            {
                initObject.RecordType = this.RecordType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RecordVersion"))
            {
                initObject.RecordVersion = this.RecordVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Serial"))
            {
                initObject.Serial = this.Serial;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SiteName"))
            {
                initObject.SiteName = this.SiteName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
}