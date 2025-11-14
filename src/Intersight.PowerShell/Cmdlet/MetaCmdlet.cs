using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get MetaDefinition.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightMetaDefinition", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightMetaDefinition : GetCmdletBase
    {
        public GetIntersightMetaDefinition()
        {
            ApiInstance = new MetaApi(Config);
            MethodName = "GetMetaDefinitionListWithHttpInfo";
        }


        // <summary>
        /// <para type="description">"The Account ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string AccountMoid
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"The time when this managed object was created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime CreateTime
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The DomainGroup ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string DomainGroupMoid
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Boolean flag to specify whether the meta class is a concrete class or not."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool IsConcrete
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Indicates whether the meta class is a complex type or managed object.\n* `ManagedObject` - The meta.Definition object describes a managed object.\n* `ComplexType` - The meta.Definition object describes a nested complex type within a managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public MetaDefinition.MetaTypeEnum MetaType
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The time when this managed object was last modified."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime ModTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Moid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The fully-qualified class name of the Managed Object or complex type. For example, \"compute:Blade\" where the Managed Object is \"Blade\" and the package is 'compute'."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Name
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The namespace of the meta."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Namespace
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A value describing the owner for a given Managed Object, such as Account or Organization.\n* `System` - Any Managed Object with OwnerType as System is root for objects common to all accounts. Any object which inherits permissions from this object has owners as system and is common to all accounts. Objects with owner as system can only be read by user and modification is not allowed by user.\n* `Yes` - Any Managed Object with OwnerType as Yes is root for objects which need security filtering. Currently objects with owner yes are account and device registration. Any object with owner ''yes'' has self moid in owners and any objects which inherits permissions from this object has root object moid as owners. In user context, account filtering is enforced by providing access to objects with owner as account moid. In device context, device filtering is enforced by providing access to objects with owner as device moid.\n* `No` - Any Managed Object with OwnerType as No inherits base mo properties like owners, domain group moid, account moid, permission resources from inherit permission relation. Inherit permission relation could be with an object whose owner is system/organization/yes/no.\n* `Internal` - Any Managed Object with OwnerType as Internal is internal to system. Such Managed Objects cannot be accessed using REST APIs and can be created, updated or deleted in any security context.\n* `Organization` - Any Managed Object with OwnerType as Organization is contained under an organization like profiles, policies, user defined workflows. Implicitly an organization on-peer-delete relation is added in this object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public MetaDefinition.OwnerEnum Owner
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public MoBaseMoRelationship Parent
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The fully-qualified name of the parent metaclass in the class inheritance hierarchy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string ParentClass
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Boolean flag to specify whether instances of this class type can be specified in permissions for instance based access control. Permissions can be created for entire Intersight account or to a subset of resources (instance based access control). In the first release, permissions are supported for entire account or for a subset of organizations."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool PermissionSupported
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Boolean flag to specify whether instances of this class type can be assigned to resource groups that are part of an organization for access control. Inventoried physical/logical objects which needs access control should have rbacResource=true. These objects are not part of any organization by default like device registrations and should be assigned to organizations for access control. Profiles, policies, workflow definitions which are created by specifying organization need not have this flag set."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool RbacResource
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"Restful URL path for the meta."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string RestPath
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Intersight provides pre-built workflows, tasks and policies to end users through global catalogs.\nObjects that are made available through global catalogs are said to have a 'shared' ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SharedScope
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The version of the service that defines the meta-data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Version
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">The $inlinecount query option allows clients to request an inline count of the matching resources included with the resources in the response.</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "QueryParam")]
        [ValidateSet("allpages", "none")]
        public String Inlinecount
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">The 'tags' parameter is used to request a summary of the Tag utilization for this resource. When the 'tags' parameter is specified, the response provides a list of tag keys, the number of times the key has been used across all documents, and the tag values that have been assigned to the tag key.</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "QueryParam")]

        public String Tags
        {
            get;
            set;
        }


    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove MetaDefinition.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightMetaDefinition")]
    public class RemoveIntersightMetaDefinition : RemoveCmdletBase
    {
        public RemoveIntersightMetaDefinition()
        {
            ApiInstance = new MetaApi(Config);
            MethodName = "DeleteMetaDefinitionWithHttpInfo";
        }
    }
}