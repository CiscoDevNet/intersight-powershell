# StorageFlexUtilPhysicalDrive
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "storage.FlexUtilPhysicalDrive"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "storage.FlexUtilPhysicalDrive"]
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
**DeviceMoId** | **String** | The database identifier of the registered device of an object. | [optional] [readonly] 
**Dn** | **String** | The Distinguished Name unambiguously identifies an object in the system. | [optional] [readonly] 
**Rn** | **String** | The Relative Name uniquely identifies an object within a given context. | [optional] [readonly] 
**Model** | **String** | This field identifies the model of the given component. | [optional] [readonly] 
**Revision** | **String** | This field identifies the revision of the given component. | [optional] [readonly] 
**Serial** | **String** | This field identifies the serial of the given component. | [optional] [readonly] 
**Vendor** | **String** | This field identifies the vendor of the given component. | [optional] [readonly] 
**BlockSize** | **String** | Block size of the FlexUtil Physical drive. | [optional] 
**Capacity** | **String** | Capacity of the FlexUtil Physical drive. | [optional] 
**Controller** | **String** | Type of the Physical Drive Controller. | [optional] 
**DrivesEnabled** | **String** | The number of drives enabled in the FlexUtil Physical Drive. | [optional] 
**Health** | **String** | Health of the FlexUtil Physical drive. | [optional] 
**ManufacturerDate** | **String** | Manufacturing date of the FlexUtil Physical Drive. | [optional] 
**ManufacturerId** | **String** | Manufacturer identity of the FlexUtil Physical Drive. | [optional] 
**OemId** | **String** | The OEM Identifier of the FlexUtil physical drive. | [optional] 
**PartitionCount** | **String** | The number of partitions present on the FlexUtil Physical Drive. | [optional] 
**PdStatus** | **String** | Status of the FlexUtil Physical Drive. | [optional] 
**PhysicalDrive** | **String** | The type of physical drive. Example - microSD. | [optional] 
**ProductName** | **String** | Product name of the FlexUtil Physical Drive. | [optional] 
**ProductRevision** | **String** | Product revision of the FlexUtil Physical Drive. | [optional] 
**ReadErrorCount** | **String** | Read error count of the FlexUtil Physical Drive. | [optional] 
**ReadErrorThreshold** | **String** | Read error threshold for FlexUtil Physical Drive. | [optional] 
**WriteEnabled** | **String** | Write access state of the FlexUtil Physical Drive. | [optional] 
**WriteErrorCount** | **String** | Write error count of the FlexUtil Physical Drive. | [optional] 
**WriteErrorThreshold** | **String** | Write error threshold for FlexUtil Physical Drive. | [optional] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**StorageFlexUtilController** | [**StorageFlexUtilControllerRelationship**](StorageFlexUtilControllerRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$StorageFlexUtilPhysicalDrive = Initialize-IntersightStorageFlexUtilPhysicalDrive  -ClassId null `
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
 -DeviceMoId null `
 -Dn null `
 -Rn null `
 -Model null `
 -Revision null `
 -Serial null `
 -Vendor null `
 -BlockSize null `
 -Capacity null `
 -Controller null `
 -DrivesEnabled null `
 -Health null `
 -ManufacturerDate null `
 -ManufacturerId null `
 -OemId null `
 -PartitionCount null `
 -PdStatus null `
 -PhysicalDrive null `
 -ProductName null `
 -ProductRevision null `
 -ReadErrorCount null `
 -ReadErrorThreshold null `
 -WriteEnabled null `
 -WriteErrorCount null `
 -WriteErrorThreshold null `
 -InventoryDeviceInfo null `
 -RegisteredDevice null `
 -StorageFlexUtilController null
```

- Convert the resource to JSON
```powershell
$StorageFlexUtilPhysicalDrive | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

