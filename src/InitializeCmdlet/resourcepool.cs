using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ResourcepoolLease.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightResourcepoolLease")]
    public class InitializeIntersightResourcepoolLease : PSCmdlet
    {
        public InitializeIntersightResourcepoolLease()
        {
            AllocationType = ResourcepoolLease.AllocationTypeEnum.Dynamic;
            ClassId = ResourcepoolLease.ClassIdEnum.ResourcepoolLease;
            ObjectType = ResourcepoolLease.ObjectTypeEnum.ResourcepoolLease;
            ResourceType = ResourcepoolLease.ResourceTypeEnum.None;

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

        public ResourcepoolLease.AllocationTypeEnum AllocationType
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

        public ResourcepoolLease.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.ResourceSelector> Condition
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Lease opertion applied for the feature."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Feature
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
        /// <para type="description">"Indicates whether a lease allocation is exclusive based on the Assigned Entity, if the AssignedEntity holds any lease then not allowed to create new lease later."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool IsExclusiveAtAssignedEntity
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The lease specific parameters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.ResourcepoolLeaseParameters LeaseParameters
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

        public ResourcepoolLease.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a resourcepoolPool resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.ResourcepoolPoolRelationship Pool
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Reference to resource, it maintain the resource detail for static based lease."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.MoBaseMo Resource
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The type of the resource present in the pool, example 'server' its combination of RackUnit and Blade.\n* `None` - The resource cannot consider for Resource Pool.\n* `Server` - Resource Pool holds the server kind of resources, example - RackServer, Blade."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ResourcepoolLease.ResourceTypeEnum ResourceType
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
            Intersight.Model.ResourcepoolLease initObject = new Intersight.Model.ResourcepoolLease();
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
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Condition"))
            {
                initObject.Condition = this.Condition;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Feature"))
            {
                initObject.Feature = this.Feature;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HasDuplicate"))
            {
                initObject.HasDuplicate = this.HasDuplicate;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IsExclusiveAtAssignedEntity"))
            {
                initObject.IsExclusiveAtAssignedEntity = this.IsExclusiveAtAssignedEntity;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LeaseParameters"))
            {
                initObject.LeaseParameters = this.LeaseParameters;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Resource"))
            {
                initObject.Resource = this.Resource;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ResourceType"))
            {
                initObject.ResourceType = this.ResourceType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ResourcepoolLeaseParameters.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightResourcepoolLeaseParameters")]
    public class InitializeIntersightResourcepoolLeaseParameters : PSCmdlet
    {
        public InitializeIntersightResourcepoolLeaseParameters()
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

        public ResourcepoolLeaseParameters.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ResourcepoolLeaseParameters.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.ResourcepoolLeaseParameters initObject = new Intersight.Model.ResourcepoolLeaseParameters();
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
    /// <para type="synopsis">This is the cmdlet to Initialize ResourcepoolLeaseResource.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightResourcepoolLeaseResource")]
    public class InitializeIntersightResourcepoolLeaseResource : PSCmdlet
    {
        public InitializeIntersightResourcepoolLeaseResource()
        {
            ClassId = ResourcepoolLeaseResource.ClassIdEnum.ResourcepoolLeaseResource;
            ObjectType = ResourcepoolLeaseResource.ObjectTypeEnum.ResourcepoolLeaseResource;

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

        public ResourcepoolLeaseResource.ClassIdEnum ClassId
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

        public ResourcepoolLeaseResource.ObjectTypeEnum ObjectType
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
            Intersight.Model.ResourcepoolLeaseResource initObject = new Intersight.Model.ResourcepoolLeaseResource();
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
    /// <para type="synopsis">This is the cmdlet to Initialize ResourcepoolPool.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightResourcepoolPool")]
    public class InitializeIntersightResourcepoolPool : PSCmdlet
    {
        public InitializeIntersightResourcepoolPool()
        {
            AssignmentOrder = ResourcepoolPool.AssignmentOrderEnum.Sequential;
            ClassId = ResourcepoolPool.ClassIdEnum.ResourcepoolPool;
            ObjectType = ResourcepoolPool.ObjectTypeEnum.ResourcepoolPool;
            PoolType = ResourcepoolPool.PoolTypeEnum.Static;
            ResourceType = ResourcepoolPool.ResourceTypeEnum.None;

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

        public ResourcepoolPool.AssignmentOrderEnum AssignmentOrder
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ResourcepoolPool.ClassIdEnum ClassId
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

        public ResourcepoolPool.ObjectTypeEnum ObjectType
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
        /// <para type="description">"The resource management type in the pool, it can be either static or dynamic.\n* `Static` - The resources in the pool will not be changed until user manually update it.\n* `Dynamic` - The resources in the pool will be updated dynamically based on the condition."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ResourcepoolPool.PoolTypeEnum PoolType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The pool specific parameters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.ResourcepoolResourcePoolParameters ResourcePoolParameters
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The type of the resource present in the pool, example 'server' its combination of RackUnit and Blade.\n* `None` - The resource cannot consider for Resource Pool.\n* `Server` - Resource Pool holds the server kind of resources, example - RackServer, Blade."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ResourcepoolPool.ResourceTypeEnum ResourceType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.ResourceSelector> Selectors
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
            Intersight.Model.ResourcepoolPool initObject = new Intersight.Model.ResourcepoolPool();
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
            if (this.MyInvocation.BoundParameters.ContainsKey("PoolType"))
            {
                initObject.PoolType = this.PoolType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ResourcePoolParameters"))
            {
                initObject.ResourcePoolParameters = this.ResourcePoolParameters;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ResourceType"))
            {
                initObject.ResourceType = this.ResourceType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Selectors"))
            {
                initObject.Selectors = this.Selectors;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ResourcepoolPoolMember.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightResourcepoolPoolMember")]
    public class InitializeIntersightResourcepoolPoolMember : PSCmdlet
    {
        public InitializeIntersightResourcepoolPoolMember()
        {
            ClassId = ResourcepoolPoolMember.ClassIdEnum.ResourcepoolPoolMember;
            ObjectType = ResourcepoolPoolMember.ObjectTypeEnum.ResourcepoolPoolMember;

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
        /// <para type="description">"An array of relationships to moBaseMo resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoBaseMoRelationship> AssignedToEntity
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ResourcepoolPoolMember.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> Features
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

        public ResourcepoolPoolMember.ObjectTypeEnum ObjectType
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
            Intersight.Model.ResourcepoolPoolMember initObject = new Intersight.Model.ResourcepoolPoolMember();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Assigned"))
            {
                initObject.Assigned = this.Assigned;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AssignedToEntity"))
            {
                initObject.AssignedToEntity = this.AssignedToEntity;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Features"))
            {
                initObject.Features = this.Features;
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
    /// <para type="synopsis">This is the cmdlet to Initialize ResourcepoolResourcePoolParameters.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightResourcepoolResourcePoolParameters")]
    public class InitializeIntersightResourcepoolResourcePoolParameters : PSCmdlet
    {
        public InitializeIntersightResourcepoolResourcePoolParameters()
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

        public ResourcepoolResourcePoolParameters.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ResourcepoolResourcePoolParameters.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.ResourcepoolResourcePoolParameters initObject = new Intersight.Model.ResourcepoolResourcePoolParameters();
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
    /// <para type="synopsis">This is the cmdlet to Initialize ResourcepoolServerLeaseParameters.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightResourcepoolServerLeaseParameters")]
    public class InitializeIntersightResourcepoolServerLeaseParameters : PSCmdlet
    {
        public InitializeIntersightResourcepoolServerLeaseParameters()
        {
            ClassId = ResourcepoolServerLeaseParameters.ClassIdEnum.ResourcepoolServerLeaseParameters;
            ObjectType = ResourcepoolServerLeaseParameters.ObjectTypeEnum.ResourcepoolServerLeaseParameters;

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

        public ResourcepoolServerLeaseParameters.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<ResourcepoolServerLeaseParameters.LifeCycleStatesEnum> LifeCycleStates
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ResourcepoolServerLeaseParameters.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.ResourcepoolServerLeaseParameters initObject = new Intersight.Model.ResourcepoolServerLeaseParameters();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("LifeCycleStates"))
            {
                initObject.LifeCycleStates = this.LifeCycleStates;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ResourcepoolServerPoolParameters.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightResourcepoolServerPoolParameters")]
    public class InitializeIntersightResourcepoolServerPoolParameters : PSCmdlet
    {
        public InitializeIntersightResourcepoolServerPoolParameters()
        {
            ClassId = ResourcepoolServerPoolParameters.ClassIdEnum.ResourcepoolServerPoolParameters;
            ManagementMode = ResourcepoolServerPoolParameters.ManagementModeEnum.IntersightStandalone;
            ObjectType = ResourcepoolServerPoolParameters.ObjectTypeEnum.ResourcepoolServerPoolParameters;

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

        public ResourcepoolServerPoolParameters.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The platform for which the servers in resource pool are applicable. It can either be a server that is operating in standalone mode or which is attached to a Fabric Interconnect managed by Intersight.\n* `IntersightStandalone` - Intersight Standalone mode of operation.\n* `UCSM` - Unified Computing System Manager mode of operation.\n* `Intersight` - Intersight managed mode of operation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ResourcepoolServerPoolParameters.ManagementModeEnum ManagementMode
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ResourcepoolServerPoolParameters.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.ResourcepoolServerPoolParameters initObject = new Intersight.Model.ResourcepoolServerPoolParameters();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ManagementMode"))
            {
                initObject.ManagementMode = this.ManagementMode;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ResourcepoolUniverse.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightResourcepoolUniverse")]
    public class InitializeIntersightResourcepoolUniverse : PSCmdlet
    {
        public InitializeIntersightResourcepoolUniverse()
        {
            ClassId = ResourcepoolUniverse.ClassIdEnum.ResourcepoolUniverse;
            ObjectType = ResourcepoolUniverse.ObjectTypeEnum.ResourcepoolUniverse;

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

        public ResourcepoolUniverse.ClassIdEnum ClassId
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

        public ResourcepoolUniverse.ObjectTypeEnum ObjectType
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
            Intersight.Model.ResourcepoolUniverse initObject = new Intersight.Model.ResourcepoolUniverse();
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