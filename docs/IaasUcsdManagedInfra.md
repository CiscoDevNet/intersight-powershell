# IaasUcsdManagedInfra
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "iaas.UcsdManagedInfra"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "iaas.UcsdManagedInfra"]
**AccountMoid** | **String** | The Account ID for this managed object. | [optional] [readonly] 
**CreateTime** | **System.DateTime** | The time when this managed object was created. | [optional] [readonly] 
**DomainGroupMoid** | **String** | The DomainGroup ID for this managed object. | [optional] [readonly] 
**ModTime** | **System.DateTime** | The time when this managed object was last modified. | [optional] [readonly] 
**Moid** | **String** | The unique identifier of this Managed Object instance. | [optional] 
**Owners** | **String[]** |  | [optional] 
**SharedScope** | **String** | Intersight provides pre-built workflows, tasks and policies to end users through global catalogs. Objects that are made available through global catalogs are said to have a &#39;shared&#39; ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs. | [optional] [readonly] 
**Tags** | [**MoTag[]**](MoTag.md) |  | [optional] 
**VersionContext** | [**MoVersionContext**](MoVersionContext.md) |  | [optional] 
**Var0ClusterReplicationNetworkPolicy** | [**HyperflexClusterReplicationNetworkPolicyRelationship**](HyperflexClusterReplicationNetworkPolicyRelationship.md) |  | [optional] 
**Ancestors** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**Parent** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 
**PermissionResources** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**DisplayNames** | [**System.Collections.Hashtable**](Array.md) | A set of display names for the MO resource. These names are calculated based on other properties of the MO and potentially properties of Ancestor MOs. Displaynames are intended as a way to provide a normalized user appropriate name for an MO, especially for MOs which do not have a &#39;Name&#39; property, which is the case for much of the inventory discovered from managed targets. There are a limited number of keys, currently &#39;short&#39; and &#39;hierarchical&#39;. The value is an array and clients should use the first element of the array. | [optional] [readonly] 
**AdvancedCatalogCount** | **Int64** | Total advanced catalogs in UCSD. | [optional] [readonly] 
**BmCatalogCount** | **Int64** | Total bare metal catalogs in UCSD. | [optional] [readonly] 
**ContainerCatalogCount** | **Int64** | Total service container catalogs in UCSD. | [optional] [readonly] 
**EsxiHostCount** | **Int64** | Total ESXi hosts in UCSD. | [optional] [readonly] 
**ExternalGroupCount** | **Int64** | Total external (Ldap) groups in UCSD. | [optional] [readonly] 
**HypervHostCount** | **Int64** | Total HyperV hosts in UCSD. | [optional] [readonly] 
**LocalGroupCount** | **Int64** | Total local groups in UCSD. | [optional] [readonly] 
**StandardCatalogCount** | **Int64** | Total standard catalogs in UCSD. | [optional] [readonly] 
**UserCount** | **Int64** | Total user accounts in UCSD. | [optional] [readonly] 
**VdcCount** | **Int64** | Total virtual datacenters in UCSD. | [optional] [readonly] 
**VmCount** | **Int64** | Total Virtual machines in UCSD. | [optional] [readonly] 
**Guid** | [**IaasUcsdInfoRelationship**](IaasUcsdInfoRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$IaasUcsdManagedInfra = Initialize-IntersightIaasUcsdManagedInfra  -ClassId null `
 -ObjectType null `
 -AccountMoid null `
 -CreateTime null `
 -DomainGroupMoid null `
 -ModTime null `
 -Moid null `
 -Owners null `
 -SharedScope null `
 -Tags null `
 -VersionContext null `
 -Var0ClusterReplicationNetworkPolicy null `
 -Ancestors null `
 -Parent null `
 -PermissionResources null `
 -DisplayNames null `
 -AdvancedCatalogCount null `
 -BmCatalogCount null `
 -ContainerCatalogCount null `
 -EsxiHostCount null `
 -ExternalGroupCount null `
 -HypervHostCount null `
 -LocalGroupCount null `
 -StandardCatalogCount null `
 -UserCount null `
 -VdcCount null `
 -VmCount null `
 -Guid null
```

- Convert the resource to JSON
```powershell
$IaasUcsdManagedInfra | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

