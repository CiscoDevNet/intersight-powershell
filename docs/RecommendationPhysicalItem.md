# RecommendationPhysicalItem
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "recommendation.PhysicalItem"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "recommendation.PhysicalItem"]
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
**Name** | **String** | The name of the physical device recommended. | [optional] [readonly] 
**Type** | **String** | The type of physical device recommended. * &#x60;Disk&#x60; - The Enum value Disk represents that the item type recommended is a Physical Disk. * &#x60;Node&#x60; - The Enum value Node represents that the item type recommended is a Storage Node. * &#x60;Cluster&#x60; - The Enum value Cluster represents that the item type recommended is a HyperFlex Cluster. | [optional] [readonly] [default to "Disk"]
**Capacity** | **Int64** | Capacity of the physical entity added. | [optional] [readonly] 
**Count** | **Int64** | Count of number of items/devices to be added.For example, number of disks to add on a node PhysicalItem in case of HyperFlex Cluster recommendation. | [optional] [readonly] 
**IsNew** | **Boolean** | If the PhysicalItem is new, this is set to true, else false. | [optional] [readonly] 
**MaxCount** | **Int64** | Maximum number of items/devices which can be added on this PhysicalItem.For example, maximum number of disks allowed on a node PhysicalItem in case of HyperFlex Cluster recommendation. | [optional] [readonly] 
**Model** | **String** | Model of the recommended physical device which is externally identifiable. | [optional] [readonly] 
**SourceMoid** | **String** | Moid of the managed object which represents the existing physical entity. | [optional] [readonly] 
**Unit** | **String** | Unit of the new capacity. * &#x60;TB&#x60; - The Enum value TB represents that the measurement unit is in terabytes. * &#x60;MB&#x60; - The Enum value MB represents that the measurement unit is in megabytes. | [optional] [readonly] [default to "TB"]
**Uuid** | **String** | Uuid of the recommended physical device. | [optional] [readonly] 
**CapacityRunway** | [**RecommendationCapacityRunwayRelationship**](RecommendationCapacityRunwayRelationship.md) |  | [optional] 
**PhysicalItem** | [**RecommendationPhysicalItemRelationship[]**](RecommendationPhysicalItemRelationship.md) | An array of relationships to recommendationPhysicalItem resources. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$RecommendationPhysicalItem = Initialize-IntersightRecommendationPhysicalItem  -ClassId null `
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
 -Name null `
 -Type null `
 -Capacity null `
 -Count null `
 -IsNew null `
 -MaxCount null `
 -Model null `
 -SourceMoid null `
 -Unit null `
 -Uuid null `
 -CapacityRunway null `
 -PhysicalItem null
```

- Convert the resource to JSON
```powershell
$RecommendationPhysicalItem | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

