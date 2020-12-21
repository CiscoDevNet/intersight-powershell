# MetaDefinitionAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "meta.Definition"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "meta.Definition"]
**AccessPrivileges** | [**MetaAccessPrivilege[]**](MetaAccessPrivilege.md) |  | [optional] 
**AncestorClasses** | **String[]** |  | [optional] 
**DisplayNameMetas** | [**MetaDisplayNameDefinition[]**](MetaDisplayNameDefinition.md) |  | [optional] 
**IsConcrete** | **Boolean** | Boolean flag to specify whether the meta class is a concrete class or not. | [optional] [readonly] 
**MetaType** | **String** | Indicates whether the meta class is a complex type or managed object. * &#x60;ManagedObject&#x60; - The meta.Definition object describes a managed object. * &#x60;ComplexType&#x60; - The meta.Definition object describes a nested complex type within a managed object. | [optional] [readonly] [default to "ManagedObject"]
**Name** | **String** | The fully-qualified class name of the Managed Object or complex type. For example, &quot;&quot;compute:Blade&quot;&quot; where the Managed Object is &quot;&quot;Blade&quot;&quot; and the package is &#39;compute&#39;. | [optional] [readonly] 
**Namespace** | **String** | The namespace of the meta. | [optional] [readonly] 
**ParentClass** | **String** | The fully-qualified name of the parent metaclass in the class inheritance hierarchy. | [optional] [readonly] 
**PermissionSupported** | **Boolean** | Boolean flag to specify whether instances of this class type can be specified in permissions for instance based access control. Permissions can be created for entire Intersight account or to a subset of resources (instance based access control). In the first release, permissions are supported for entire account or for a subset of organizations. | [optional] [readonly] 
**Properties** | [**MetaPropDefinition[]**](MetaPropDefinition.md) |  | [optional] 
**RbacResource** | **Boolean** | Boolean flag to specify whether instances of this class type can be assigned to resource groups that are part of an organization for access control. Inventoried physical/logical objects which needs access control should have rbacResource&#x3D;yes. These objects are not part of any organization by default like device registrations and should be assigned to organizations for access control. Profiles, policies, workflow definitions which are created by specifying organization need not have this flag set. | [optional] [readonly] 
**Relationships** | [**MetaRelationshipDefinition[]**](MetaRelationshipDefinition.md) |  | [optional] 
**RestPath** | **String** | Restful URL path for the meta. | [optional] [readonly] 
**Version** | **String** | The version of the service that defines the meta-data. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$MetaDefinitionAllOf = Initialize-IntersightMetaDefinitionAllOf  -ClassId null `
 -ObjectType null `
 -AccessPrivileges null `
 -AncestorClasses null `
 -DisplayNameMetas null `
 -IsConcrete null `
 -MetaType null `
 -Name null `
 -Namespace null `
 -ParentClass null `
 -PermissionSupported null `
 -Properties null `
 -RbacResource null `
 -Relationships null `
 -RestPath null `
 -Version null
```

- Convert the resource to JSON
```powershell
$MetaDefinitionAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

