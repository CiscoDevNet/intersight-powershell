using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IppoolBlockLease.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIppoolBlockLease")]
    public class InitializeIntersightIppoolBlockLease : PSCmdlet
    {
        public InitializeIntersightIppoolBlockLease()
        {
            ClassId = IppoolBlockLease.ClassIdEnum.IppoolBlockLease;
            IpType = IppoolBlockLease.IpTypeEnum.IPv4;
            ObjectType = IppoolBlockLease.ObjectTypeEnum.IppoolBlockLease;

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
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.MoBaseMoRelationship AssignedToEntity
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IppoolBlockLease.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Count of number of leases requested."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Count
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to ippoolIpLease resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.IppoolIpLeaseRelationship> IpLeases
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of the IP address requested.\n* `IPv4` - IP V4 address type requested.\n* `IPv6` - IP V6 address type requested."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IppoolBlockLease.IpTypeEnum IpType
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

        public IppoolBlockLease.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a ippoolPool resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IppoolPoolRelationship Pool
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
        /// <para type="description">"A reference to a vrfVrf resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VrfVrfRelationship Vrf
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.IppoolBlockLease initObject = new Intersight.Model.IppoolBlockLease();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AssignedToEntity"))
            {
                initObject.AssignedToEntity = this.AssignedToEntity;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Count"))
            {
                initObject.Count = this.Count;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IpLeases"))
            {
                initObject.IpLeases = this.IpLeases;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IpType"))
            {
                initObject.IpType = this.IpType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Pool"))
            {
                initObject.Pool = this.Pool;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Vrf"))
            {
                initObject.Vrf = this.Vrf;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IppoolIpLease.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIppoolIpLease")]
    public class InitializeIntersightIppoolIpLease : PSCmdlet
    {
        public InitializeIntersightIppoolIpLease()
        {
            AllocationType = IppoolIpLease.AllocationTypeEnum.Dynamic;
            ClassId = IppoolIpLease.ClassIdEnum.IppoolIpLease;
            IpType = IppoolIpLease.IpTypeEnum.IPv4;
            ObjectType = IppoolIpLease.ObjectTypeEnum.IppoolIpLease;

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
        /// <para type="description">"Type of the lease allocation either static or dynamic (i.e via pool).\n* `dynamic` - Identifiers to be allocated by system.\n* `static` - Identifiers are assigned by the user."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IppoolIpLease.AllocationTypeEnum AllocationType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.MoBaseMoRelationship AssignedToEntity
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a ippoolBlockLease resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IppoolBlockLeaseRelationship BlockLease
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IppoolIpLease.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"HasDuplicate represents if there are other pools in which this id exists."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool HasDuplicate
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of the IP address requested.\n* `IPv4` - IP V4 address type requested.\n* `IPv6` - IP V6 address type requested."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IppoolIpLease.IpTypeEnum IpType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"IPv4 Address given as a lease to an external entity like server profiles."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string IpV4Address
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Netmask, Gateway and DNS settings for IPv4 addresses."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IppoolIpV4Config IpV4Config
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"IPv6 Address given as a lease to an external entity like server profiles."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^(([0-9A-Fa-f]{1,4}:([0-9A-Fa-f]{1,4}:([0-9A-Fa-f]{1,4}:([0-9A-Fa-f]{1,4}:([0-9A-Fa-f]{1,4}:[0-9A-Fa-f]{0,4}|:[0-9A-Fa-f]{1,4})?|(:[0-9A-Fa-f]{1,4}){0,2})|(:[0-9A-Fa-f]{1,4}){0,3})|(:[0-9A-Fa-f]{1,4}){0,4})|:(:[0-9A-Fa-f]{1,4}){0,5})((:[0-9A-Fa-f]{1,4}){2}|:(25[0-5]|(2[0-4]|1[0-9]|[1-9])?[0-9])(\\.(25[0-5]|(2[0-4]|1[0-9]|[1-9])?[0-9])){3})|(([0-9A-Fa-f]{1,4}:){1,6}|:):[0-9A-Fa-f]{0,4}|([0-9A-Fa-f]{1,4}:){7}:)$")]
        public string IpV6Address
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Netmask, Gateway and DNS settings for IPv6 addresses."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IppoolIpV6Config IpV6Config
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

        public IppoolIpLease.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a ippoolPool resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IppoolPoolRelationship Pool
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The holder of a reference to reservation Moid and the specific details on lease condition for this reservation. Specified to allocate already reserved identities."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IppoolReservationReference Reservation
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
        /// <para type="description">"A reference to a vrfVrf resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.VrfVrfRelationship Vrf
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.IppoolIpLease initObject = new Intersight.Model.IppoolIpLease();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AllocationType"))
            {
                initObject.AllocationType = this.AllocationType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AssignedToEntity"))
            {
                initObject.AssignedToEntity = this.AssignedToEntity;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BlockLease"))
            {
                initObject.BlockLease = this.BlockLease;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("HasDuplicate"))
            {
                initObject.HasDuplicate = this.HasDuplicate;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IpType"))
            {
                initObject.IpType = this.IpType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IpV4Address"))
            {
                initObject.IpV4Address = this.IpV4Address;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IpV4Config"))
            {
                initObject.IpV4Config = this.IpV4Config;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IpV6Address"))
            {
                initObject.IpV6Address = this.IpV6Address;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IpV6Config"))
            {
                initObject.IpV6Config = this.IpV6Config;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Pool"))
            {
                initObject.Pool = this.Pool;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Reservation"))
            {
                initObject.Reservation = this.Reservation;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Vrf"))
            {
                initObject.Vrf = this.Vrf;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IppoolIpV4Block.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIppoolIpV4Block")]
    public class InitializeIntersightIppoolIpV4Block : PSCmdlet
    {
        public InitializeIntersightIppoolIpV4Block()
        {
            ClassId = IppoolIpV4Block.ClassIdEnum.IppoolIpV4Block;
            ObjectType = IppoolIpV4Block.ObjectTypeEnum.IppoolIpV4Block;

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

        public IppoolIpV4Block.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"First IPv4 address of the block."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string From
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Netmask, Gateway and DNS settings for IPv4 addresses."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IppoolIpV4Config IpV4Config
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IppoolIpV4Block.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of identifiers this block can hold."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 1024)]
        public long Size
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Last IPv4 address of the block."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string To
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.IppoolIpV4Block initObject = new Intersight.Model.IppoolIpV4Block();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("From"))
            {
                initObject.From = this.From;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IpV4Config"))
            {
                initObject.IpV4Config = this.IpV4Config;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Size"))
            {
                initObject.Size = this.Size;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("To"))
            {
                initObject.To = this.To;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IppoolIpV4Config.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIppoolIpV4Config")]
    public class InitializeIntersightIppoolIpV4Config : PSCmdlet
    {
        public InitializeIntersightIppoolIpV4Config()
        {
            ClassId = IppoolIpV4Config.ClassIdEnum.IppoolIpV4Config;
            ObjectType = IppoolIpV4Config.ObjectTypeEnum.IppoolIpV4Config;

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

        public IppoolIpV4Config.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"IP address of the default IPv4 gateway."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string Gateway
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A subnet mask is a 32-bit number that masks an IP address and divides the IP address into network address and host address."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^(((255\\.){3}(255|254|252|248|240|224|192|128|0+))|((255\\.){2}(255|254|252|248|240|224|192|128|0+)\\.0)|((255\\.)(255|254|252|248|240|224|192|128|0+)(\\.0+){2})|((255|254|252|248|240|224|192|128|0+)(\\.0+){3}))$")]
        public string Netmask
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IppoolIpV4Config.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"IP Address of the primary Domain Name System (DNS) server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string PrimaryDns
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"IP Address of the secondary Domain Name System (DNS) server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string SecondaryDns
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.IppoolIpV4Config initObject = new Intersight.Model.IppoolIpV4Config();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Gateway"))
            {
                initObject.Gateway = this.Gateway;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Netmask"))
            {
                initObject.Netmask = this.Netmask;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("PrimaryDns"))
            {
                initObject.PrimaryDns = this.PrimaryDns;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SecondaryDns"))
            {
                initObject.SecondaryDns = this.SecondaryDns;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IppoolIpV6Block.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIppoolIpV6Block")]
    public class InitializeIntersightIppoolIpV6Block : PSCmdlet
    {
        public InitializeIntersightIppoolIpV6Block()
        {
            ClassId = IppoolIpV6Block.ClassIdEnum.IppoolIpV6Block;
            ObjectType = IppoolIpV6Block.ObjectTypeEnum.IppoolIpV6Block;

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

        public IppoolIpV6Block.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"First IPv6 address of the block."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^(([0-9A-Fa-f]{1,4}:([0-9A-Fa-f]{1,4}:([0-9A-Fa-f]{1,4}:([0-9A-Fa-f]{1,4}:([0-9A-Fa-f]{1,4}:[0-9A-Fa-f]{0,4}|:[0-9A-Fa-f]{1,4})?|(:[0-9A-Fa-f]{1,4}){0,2})|(:[0-9A-Fa-f]{1,4}){0,3})|(:[0-9A-Fa-f]{1,4}){0,4})|:(:[0-9A-Fa-f]{1,4}){0,5})((:[0-9A-Fa-f]{1,4}){2}|:(25[0-5]|(2[0-4]|1[0-9]|[1-9])?[0-9])(\\.(25[0-5]|(2[0-4]|1[0-9]|[1-9])?[0-9])){3})|(([0-9A-Fa-f]{1,4}:){1,6}|:):[0-9A-Fa-f]{0,4}|([0-9A-Fa-f]{1,4}:){7}:)$")]
        public string From
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Netmask, Gateway and DNS settings for IPv6 addresses."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IppoolIpV6Config IpV6Config
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IppoolIpV6Block.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of identifiers this block can hold."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 1024)]
        public long Size
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Last IPv6 address of the block."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^(([0-9A-Fa-f]{1,4}:([0-9A-Fa-f]{1,4}:([0-9A-Fa-f]{1,4}:([0-9A-Fa-f]{1,4}:([0-9A-Fa-f]{1,4}:[0-9A-Fa-f]{0,4}|:[0-9A-Fa-f]{1,4})?|(:[0-9A-Fa-f]{1,4}){0,2})|(:[0-9A-Fa-f]{1,4}){0,3})|(:[0-9A-Fa-f]{1,4}){0,4})|:(:[0-9A-Fa-f]{1,4}){0,5})((:[0-9A-Fa-f]{1,4}){2}|:(25[0-5]|(2[0-4]|1[0-9]|[1-9])?[0-9])(\\.(25[0-5]|(2[0-4]|1[0-9]|[1-9])?[0-9])){3})|(([0-9A-Fa-f]{1,4}:){1,6}|:):[0-9A-Fa-f]{0,4}|([0-9A-Fa-f]{1,4}:){7}:)$")]
        public string To
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.IppoolIpV6Block initObject = new Intersight.Model.IppoolIpV6Block();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("From"))
            {
                initObject.From = this.From;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IpV6Config"))
            {
                initObject.IpV6Config = this.IpV6Config;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Size"))
            {
                initObject.Size = this.Size;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("To"))
            {
                initObject.To = this.To;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IppoolIpV6Config.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIppoolIpV6Config")]
    public class InitializeIntersightIppoolIpV6Config : PSCmdlet
    {
        public InitializeIntersightIppoolIpV6Config()
        {
            ClassId = IppoolIpV6Config.ClassIdEnum.IppoolIpV6Config;
            ObjectType = IppoolIpV6Config.ObjectTypeEnum.IppoolIpV6Config;

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

        public IppoolIpV6Config.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"IP address of the default IPv6 gateway."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^(([0-9A-Fa-f]{1,4}:([0-9A-Fa-f]{1,4}:([0-9A-Fa-f]{1,4}:([0-9A-Fa-f]{1,4}:([0-9A-Fa-f]{1,4}:[0-9A-Fa-f]{0,4}|:[0-9A-Fa-f]{1,4})?|(:[0-9A-Fa-f]{1,4}){0,2})|(:[0-9A-Fa-f]{1,4}){0,3})|(:[0-9A-Fa-f]{1,4}){0,4})|:(:[0-9A-Fa-f]{1,4}){0,5})((:[0-9A-Fa-f]{1,4}){2}|:(25[0-5]|(2[0-4]|1[0-9]|[1-9])?[0-9])(\\.(25[0-5]|(2[0-4]|1[0-9]|[1-9])?[0-9])){3})|(([0-9A-Fa-f]{1,4}:){1,6}|:):[0-9A-Fa-f]{0,4}|([0-9A-Fa-f]{1,4}:){7}:)$")]
        public string Gateway
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IppoolIpV6Config.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A prefix length which masks the  IP address and divides the IP address into network address and host address."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Prefix
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"IP Address of the primary Domain Name System (DNS) server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^(([0-9A-Fa-f]{1,4}:([0-9A-Fa-f]{1,4}:([0-9A-Fa-f]{1,4}:([0-9A-Fa-f]{1,4}:([0-9A-Fa-f]{1,4}:[0-9A-Fa-f]{0,4}|:[0-9A-Fa-f]{1,4})?|(:[0-9A-Fa-f]{1,4}){0,2})|(:[0-9A-Fa-f]{1,4}){0,3})|(:[0-9A-Fa-f]{1,4}){0,4})|:(:[0-9A-Fa-f]{1,4}){0,5})((:[0-9A-Fa-f]{1,4}){2}|:(25[0-5]|(2[0-4]|1[0-9]|[1-9])?[0-9])(\\.(25[0-5]|(2[0-4]|1[0-9]|[1-9])?[0-9])){3})|(([0-9A-Fa-f]{1,4}:){1,6}|:):[0-9A-Fa-f]{0,4}|([0-9A-Fa-f]{1,4}:){7}:)$")]
        public string PrimaryDns
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"IP Address of the secondary Domain Name System (DNS) server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^(([0-9A-Fa-f]{1,4}:([0-9A-Fa-f]{1,4}:([0-9A-Fa-f]{1,4}:([0-9A-Fa-f]{1,4}:([0-9A-Fa-f]{1,4}:[0-9A-Fa-f]{0,4}|:[0-9A-Fa-f]{1,4})?|(:[0-9A-Fa-f]{1,4}){0,2})|(:[0-9A-Fa-f]{1,4}){0,3})|(:[0-9A-Fa-f]{1,4}){0,4})|:(:[0-9A-Fa-f]{1,4}){0,5})((:[0-9A-Fa-f]{1,4}){2}|:(25[0-5]|(2[0-4]|1[0-9]|[1-9])?[0-9])(\\.(25[0-5]|(2[0-4]|1[0-9]|[1-9])?[0-9])){3})|(([0-9A-Fa-f]{1,4}:){1,6}|:):[0-9A-Fa-f]{0,4}|([0-9A-Fa-f]{1,4}:){7}:)$")]
        public string SecondaryDns
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.IppoolIpV6Config initObject = new Intersight.Model.IppoolIpV6Config();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Gateway"))
            {
                initObject.Gateway = this.Gateway;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Prefix"))
            {
                initObject.Prefix = this.Prefix;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PrimaryDns"))
            {
                initObject.PrimaryDns = this.PrimaryDns;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SecondaryDns"))
            {
                initObject.SecondaryDns = this.SecondaryDns;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IppoolPool.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIppoolPool")]
    public class InitializeIntersightIppoolPool : PSCmdlet
    {
        public InitializeIntersightIppoolPool()
        {
            AssignmentOrder = IppoolPool.AssignmentOrderEnum.Sequential;
            ClassId = IppoolPool.ClassIdEnum.IppoolPool;
            ObjectType = IppoolPool.ObjectTypeEnum.IppoolPool;

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
        /// <para type="description">"Assignment order decides the order in which the next identifier is allocated.\n* `sequential` - Identifiers are assigned in a sequential order.\n* `default` - Assignment order is decided by the system."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IppoolPool.AssignmentOrderEnum AssignmentOrder
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IppoolPool.ClassIdEnum ClassId
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
        /// <para type="description">"Enables subnet configuration at the block level."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool EnableBlockLevelSubnetConfig
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.IppoolIpV4Block> IpV4Blocks
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Netmask, Gateway and DNS settings for IPv4 addresses."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IppoolIpV4Config IpV4Config
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.IppoolIpV6Block> IpV6Blocks
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Netmask, Gateway and DNS settings for IPv6 addresses."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IppoolIpV6Config IpV6Config
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

        public IppoolPool.ObjectTypeEnum ObjectType
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
        /// <para type="description">"An array of relationships to ippoolReservation resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.IppoolReservationRelationship> Reservations
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
            Intersight.Model.IppoolPool initObject = new Intersight.Model.IppoolPool();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AssignmentOrder"))
            {
                initObject.AssignmentOrder = this.AssignmentOrder;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EnableBlockLevelSubnetConfig"))
            {
                initObject.EnableBlockLevelSubnetConfig = this.EnableBlockLevelSubnetConfig;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IpV4Blocks"))
            {
                initObject.IpV4Blocks = this.IpV4Blocks;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IpV4Config"))
            {
                initObject.IpV4Config = this.IpV4Config;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IpV6Blocks"))
            {
                initObject.IpV6Blocks = this.IpV6Blocks;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IpV6Config"))
            {
                initObject.IpV6Config = this.IpV6Config;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Reservations"))
            {
                initObject.Reservations = this.Reservations;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IppoolPoolMember.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIppoolPoolMember")]
    public class InitializeIntersightIppoolPoolMember : PSCmdlet
    {
        public InitializeIntersightIppoolPoolMember()
        {
            ClassId = IppoolPoolMember.ClassIdEnum.IppoolPoolMember;
            ObjectType = IppoolPoolMember.ObjectTypeEnum.IppoolPoolMember;

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
        /// <para type="description">"Boolean to represent whether the ID is in use."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Assigned
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Boolean to represent whether the ID is used either statically or by another pool."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool AssignedByAnother
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.MoBaseMoRelationship AssignedToEntity
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IppoolPoolMember.ClassIdEnum ClassId
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

        public IppoolPoolMember.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Boolean to represent whether the ID is reserved."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Reserved
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
            Intersight.Model.IppoolPoolMember initObject = new Intersight.Model.IppoolPoolMember();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Assigned"))
            {
                initObject.Assigned = this.Assigned;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AssignedByAnother"))
            {
                initObject.AssignedByAnother = this.AssignedByAnother;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AssignedToEntity"))
            {
                initObject.AssignedToEntity = this.AssignedToEntity;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Reserved"))
            {
                initObject.Reserved = this.Reserved;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IppoolReservation.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIppoolReservation")]
    public class InitializeIntersightIppoolReservation : PSCmdlet
    {
        public InitializeIntersightIppoolReservation()
        {
            AllocationType = IppoolReservation.AllocationTypeEnum.Dynamic;
            ClassId = IppoolReservation.ClassIdEnum.IppoolReservation;
            IpType = IppoolReservation.IpTypeEnum.IPv4;
            ObjectType = IppoolReservation.ObjectTypeEnum.IppoolReservation;

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
        /// <para type="description">"Type of the allocation for the identity in the reservation either static or dynamic (i.e. via pool).\n* `dynamic` - Identifiers to be allocated by system.\n* `static` - Identifiers are assigned by the user."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IppoolReservation.AllocationTypeEnum AllocationType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IppoolReservation.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"IP identity to be reserved."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Identity
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of the IP address that needs to be reserved.\n* `IPv4` - IP V4 address type requested.\n* `IPv6` - IP V6 address type requested."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IppoolReservation.IpTypeEnum IpType
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

        public IppoolReservation.ObjectTypeEnum ObjectType
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
        /// <para type="description">"A reference to a ippoolPool resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IppoolPoolRelationship Pool
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
        /// <para type="description">"The moid of the Virtual Routing and Forwarding MO."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string VrfMoid
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.IppoolReservation initObject = new Intersight.Model.IppoolReservation();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AllocationType"))
            {
                initObject.AllocationType = this.AllocationType;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Identity"))
            {
                initObject.Identity = this.Identity;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IpType"))
            {
                initObject.IpType = this.IpType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Organization"))
            {
                initObject.Organization = this.Organization;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Pool"))
            {
                initObject.Pool = this.Pool;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VrfMoid"))
            {
                initObject.VrfMoid = this.VrfMoid;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IppoolReservationReference.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIppoolReservationReference")]
    public class InitializeIntersightIppoolReservationReference : PSCmdlet
    {
        public InitializeIntersightIppoolReservationReference()
        {
            ClassId = IppoolReservationReference.ClassIdEnum.IppoolReservationReference;
            ConsumerType = IppoolReservationReference.ConsumerTypeEnum.OutofbandIpv4Access;
            ObjectType = IppoolReservationReference.ObjectTypeEnum.IppoolReservationReference;

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

        public IppoolReservationReference.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The consumer name for which the reserved IP would be used."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ConsumerName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The consumer type for which the reserved IP would be used.\n* `OutofbandIpv4-Access` - IP reservation would be used for out of band management.\n* `InbandIpv4-Access` - IP reservation would be used for inband management.\n* `InbandIpv6-Access` - IP reservation would be used for inband management.\n* `ISCSI` - IP reservation would be used for ISCSI management."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IppoolReservationReference.ConsumerTypeEnum ConsumerType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IppoolReservationReference.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The moid of the reservation object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ReservationMoid
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.IppoolReservationReference initObject = new Intersight.Model.IppoolReservationReference();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ConsumerName"))
            {
                initObject.ConsumerName = this.ConsumerName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ConsumerType"))
            {
                initObject.ConsumerType = this.ConsumerType;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("ReservationMoid"))
            {
                initObject.ReservationMoid = this.ReservationMoid;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IppoolShadowBlock.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIppoolShadowBlock")]
    public class InitializeIntersightIppoolShadowBlock : PSCmdlet
    {
        public InitializeIntersightIppoolShadowBlock()
        {
            ClassId = IppoolShadowBlock.ClassIdEnum.IppoolShadowBlock;
            IpType = IppoolShadowBlock.IpTypeEnum.IPv4;
            ObjectType = IppoolShadowBlock.ObjectTypeEnum.IppoolShadowBlock;

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

        public IppoolShadowBlock.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of this IP addresses blocks.\n* `IPv4` - IP V4 address type requested.\n* `IPv6` - IP V6 address type requested."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IppoolShadowBlock.IpTypeEnum IpType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A Block of IPv4 addresses."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IppoolIpV4Block IpV4Block
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A Block of IPv6 addresses."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IppoolIpV6Block IpV6Block
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

        public IppoolShadowBlock.ObjectTypeEnum ObjectType
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
            Intersight.Model.IppoolShadowBlock initObject = new Intersight.Model.IppoolShadowBlock();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("IpType"))
            {
                initObject.IpType = this.IpType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IpV4Block"))
            {
                initObject.IpV4Block = this.IpV4Block;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IpV6Block"))
            {
                initObject.IpV6Block = this.IpV6Block;
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
    /// <para type="synopsis">This is the cmdlet to Initialize IppoolShadowPool.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIppoolShadowPool")]
    public class InitializeIntersightIppoolShadowPool : PSCmdlet
    {
        public InitializeIntersightIppoolShadowPool()
        {
            AssignmentOrder = IppoolShadowPool.AssignmentOrderEnum.Sequential;
            ClassId = IppoolShadowPool.ClassIdEnum.IppoolShadowPool;
            ObjectType = IppoolShadowPool.ObjectTypeEnum.IppoolShadowPool;

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
        /// <para type="description">"Assignment order decides the order in which the next identifier is allocated.\n* `sequential` - Identifiers are assigned in a sequential order.\n* `default` - Assignment order is decided by the system."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IppoolShadowPool.AssignmentOrderEnum AssignmentOrder
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IppoolShadowPool.ClassIdEnum ClassId
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.IppoolIpV4Block> IpV4Blocks
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Netmask, Gateway and DNS settings for IPv4 addresses."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IppoolIpV4Config IpV4Config
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.IppoolIpV6Block> IpV6Blocks
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Netmask, Gateway and DNS settings for IPv6 addresses."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IppoolIpV6Config IpV6Config
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

        public IppoolShadowPool.ObjectTypeEnum ObjectType
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
            Intersight.Model.IppoolShadowPool initObject = new Intersight.Model.IppoolShadowPool();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AssignmentOrder"))
            {
                initObject.AssignmentOrder = this.AssignmentOrder;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IpV4Blocks"))
            {
                initObject.IpV4Blocks = this.IpV4Blocks;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IpV4Config"))
            {
                initObject.IpV4Config = this.IpV4Config;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IpV6Blocks"))
            {
                initObject.IpV6Blocks = this.IpV6Blocks;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IpV6Config"))
            {
                initObject.IpV6Config = this.IpV6Config;
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
    /// <para type="synopsis">This is the cmdlet to Initialize IppoolUniverse.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIppoolUniverse")]
    public class InitializeIntersightIppoolUniverse : PSCmdlet
    {
        public InitializeIntersightIppoolUniverse()
        {
            ClassId = IppoolUniverse.ClassIdEnum.IppoolUniverse;
            ObjectType = IppoolUniverse.ObjectTypeEnum.IppoolUniverse;

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

        public IppoolUniverse.ClassIdEnum ClassId
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

        public IppoolUniverse.ObjectTypeEnum ObjectType
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
            Intersight.Model.IppoolUniverse initObject = new Intersight.Model.IppoolUniverse();
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
}