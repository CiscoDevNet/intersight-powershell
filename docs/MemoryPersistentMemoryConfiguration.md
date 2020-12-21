# MemoryPersistentMemoryConfiguration
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "memory.PersistentMemoryConfiguration"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "memory.PersistentMemoryConfiguration"]
**AccountMoid** | **String** | The Account ID for this managed object. | [optional] [readonly] 
**CreateTime** | **System.DateTime** | The time when this managed object was created. | [optional] [readonly] 
**DomainGroupMoid** | **String** | The DomainGroup ID for this managed object. | [optional] [readonly] 
**ModTime** | **System.DateTime** | The time when this managed object was last modified. | [optional] [readonly] 
**Moid** | **String** | The unique identifier of this Managed Object instance. | [optional] 
**Owners** | **String[]** |  | [optional] 
**SharedScope** | **String** | Intersight provides pre-built workflows, tasks and policies to end users through global catalogs. Objects that are made available through global catalogs are said to have a &#39;shared&#39; ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs. | [optional] [readonly] 
**Tags** | [**MoTag[]**](MoTag.md) |  | [optional] 
**VersionContext** | [**MoVersionContext**](MoVersionContext.md) |  | [optional] 
**Ancestors** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**Parent** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 
**PermissionResources** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**DisplayNames** | [**System.Collections.Hashtable**](Array.md) | A set of display names for the MO resource. These names are calculated based on other properties of the MO and potentially properties of Ancestor MOs. Displaynames are intended as a way to provide a normalized user appropriate name for an MO, especially for MOs which do not have a &#39;Name&#39; property, which is the case for much of the inventory discovered from managed targets. There are a limited number of keys, currently &#39;short&#39; and &#39;hierarchical&#39;. The value is an array and clients should use the first element of the array. | [optional] [readonly] 
**DeviceMoId** | **String** | The database identifier of the registered device of an object. | [optional] [readonly] 
**Dn** | **String** | The Distinguished Name unambiguously identifies an object in the system. | [optional] [readonly] 
**Rn** | **String** | The Relative Name uniquely identifies an object within a given context. | [optional] [readonly] 
**MemoryCapacity** | **String** | Memory capacity in GiB of a Persistent Memory configuration on a server. | [optional] [readonly] 
**NumOfModules** | **String** | Number of Persistent Memory Modules on a server. | [optional] [readonly] 
**NumOfRegions** | **String** | Number of Persistent Memory Regions on a server. | [optional] [readonly] 
**PersistentMemoryCapacity** | **String** | Persistent memory capacity in GiB of a Persistent Memory configuration on a server. | [optional] [readonly] 
**ReservedCapacity** | **String** | Reserved capacity in GiB of a Persistent Memory configuration on a server. | [optional] [readonly] 
**SecurityState** | **String** | Collective security state of all Persistent Memory modules on a server. | [optional] [readonly] 
**TotalCapacity** | **String** | Total capacity in GiB of a Persistent Memory configuration on a server. | [optional] [readonly] 
**ComputeBoard** | [**ComputeBoardRelationship**](ComputeBoardRelationship.md) |  | [optional] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**PersistentMemoryConfigResult** | [**MemoryPersistentMemoryConfigResultRelationship**](MemoryPersistentMemoryConfigResultRelationship.md) |  | [optional] 
**PersistentMemoryRegions** | [**MemoryPersistentMemoryRegionRelationship[]**](MemoryPersistentMemoryRegionRelationship.md) | An array of relationships to memoryPersistentMemoryRegion resources. | [optional] [readonly] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$MemoryPersistentMemoryConfiguration = Initialize-IntersightMemoryPersistentMemoryConfiguration  -ClassId null `
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
 -Ancestors null `
 -Parent null `
 -PermissionResources null `
 -DisplayNames null `
 -DeviceMoId null `
 -Dn null `
 -Rn null `
 -MemoryCapacity null `
 -NumOfModules null `
 -NumOfRegions null `
 -PersistentMemoryCapacity null `
 -ReservedCapacity null `
 -SecurityState null `
 -TotalCapacity null `
 -ComputeBoard null `
 -InventoryDeviceInfo null `
 -PersistentMemoryConfigResult null `
 -PersistentMemoryRegions null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$MemoryPersistentMemoryConfiguration | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

