# MemoryPersistentMemoryUnitRelationship
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The fully-qualified type of this managed object, i.e. the class name. This property is optional. The ObjectType is implied from the URL path. If specified, the value of objectType must match the class name specified in the URL path. | [readonly] 
**Moid** | **String** | The unique identifier of this Managed Object instance. | [optional] 
**Selector** | **String** | An OData $filter expression which describes the REST resource to be referenced. This field may be set instead of &#39;moid&#39; by clients. 1. If &#39;moid&#39; is set this field is ignored. 1. If &#39;selector&#39; is set and &#39;moid&#39; is empty/absent from the request, Intersight determines the Moid of the resource matching the filter expression and populates it in the MoRef that is part of the object instance being inserted/updated to fulfill the REST request. An error is returned if the filter matches zero or more than one REST resource. An example filter string is: Serial eq &#39;3AA8B7T11&#39;. | [optional] [readonly] 
**Link** | **String** | A URL to an instance of the &#39;mo.MoRef&#39; class. | [optional] 
**AccountMoid** | **String** | The Account ID for this managed object. | [optional] [readonly] 
**CreateTime** | **System.DateTime** | The time when this managed object was created. | [optional] [readonly] 
**DomainGroupMoid** | **String** | The DomainGroup ID for this managed object. | [optional] [readonly] 
**ModTime** | **System.DateTime** | The time when this managed object was last modified. | [optional] [readonly] 
**Owners** | **String[]** |  | [optional] 
**SharedScope** | **String** | Intersight provides pre-built workflows, tasks and policies to end users through global catalogs. Objects that are made available through global catalogs are said to have a &#39;shared&#39; ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs. | [optional] [readonly] 
**Tags** | [**MoTag[]**](MoTag.md) |  | [optional] 
**VersionContext** | [**MoVersionContext**](MoVersionContext.md) |  | [optional] 
**Ancestors** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**Parent** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 
**PermissionResources** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**DisplayNames** | [**System.Collections.Hashtable**](Array.md) | a map of display names for a resource. | [optional] [readonly] 
**DeviceMoId** | **String** | The database identifier of the registered device of an object. | [optional] [readonly] 
**Dn** | **String** | The Distinguished Name unambiguously identifies an object in the system. | [optional] [readonly] 
**Rn** | **String** | The Relative Name uniquely identifies an object within a given context. | [optional] [readonly] 
**Model** | **String** | This field identifies the model of the given component. | [optional] [readonly] 
**Revision** | **String** | This field identifies the revision of the given component. | [optional] [readonly] 
**Serial** | **String** | This field identifies the serial of the given component. | [optional] [readonly] 
**Vendor** | **String** | This field identifies the vendor of the given component. | [optional] [readonly] 
**AdminState** | **String** | This represents the administrative state of the memory unit on a server. | [optional] [readonly] 
**ArrayId** | **Int64** | This represents the memory array to which the memory unit belongs to. | [optional] [readonly] 
**Bank** | **Int64** | This represents the memory bank of the memory unit on a server. | [optional] [readonly] 
**Capacity** | **String** | This represents the memory capacity in MiB of the memory unit on a server. | [optional] [readonly] 
**Clock** | **String** | This represents the clock of the memory unit on a server. | [optional] [readonly] 
**FormFactor** | **String** | This represents the form factor of the memory unit on a server. | [optional] [readonly] 
**Latency** | **String** | This represents the latency of the memory unit on a server. | [optional] [readonly] 
**Location** | **String** | This represents the location of the memory unit on a server. | [optional] [readonly] 
**OperPowerState** | **String** | This represents the operational power state of the memory unit on a server. | [optional] [readonly] 
**OperState** | **String** | This represents the operational state of the memory unit on a server. | [optional] [readonly] 
**Operability** | **String** | This represents the operability of the memory unit on a server. | [optional] [readonly] 
**Presence** | **String** | This represents the presence state of the memory unit on a server. | [optional] [readonly] 
**Set** | **Int64** | This represents the set of the memory unit on a server. | [optional] [readonly] 
**Speed** | **String** | This represents the speed of the memory unit on a server. | [optional] [readonly] 
**Thermal** | **String** | This represents the thremal state of the memory unit on a server. | [optional] [readonly] 
**Type** | **String** | This represents the memory type of the memory unit on a server. | [optional] [readonly] 
**Visibility** | **String** | This represents the visibility of the memory unit on a server. | [optional] [readonly] 
**Width** | **String** | This represents the width of the memory unit on a server. | [optional] [readonly] 
**AppDirectCapacity** | **String** | AppDirect capacity in GiB of the Persistent Memory Module on a server. | [optional] [readonly] 
**CountStatus** | **String** | Count status of the Persistent Memory Module on a server. | [optional] [readonly] 
**FirmwareVersion** | **String** | Firmware version of the firware running on the Persistent Memory Module on a server. | [optional] [readonly] 
**FrozenStatus** | **String** | Frozen status of the Persistent Memory Module on a server. | [optional] [readonly] 
**HealthState** | **String** | Health state of the Persistent Memory Module on a server. | [optional] [readonly] 
**LockStatus** | **String** | Lock status of the Persistent Memory Module on a server. | [optional] [readonly] 
**MemoryCapacity** | **String** | Memory capacity in GiB of the Persistent Memory Module on a server. | [optional] [readonly] 
**MemoryId** | **Int64** | ID of the Persistent Memory Module on a server. | [optional] [readonly] 
**PersistentMemoryCapacity** | **String** | Persistent Memory capacity in GiB of the Persistent Memory Module on a server. | [optional] [readonly] 
**ReservedCapacity** | **String** | Reserved capacity in GiB of the Persistent Memory Module on a server. | [optional] [readonly] 
**SecurityStatus** | **String** | Security status of the Persistent Memory Module on a server. | [optional] [readonly] 
**SocketId** | **String** | Socket ID of the Persistent Memory Module on a server. | [optional] [readonly] 
**SocketMemoryId** | **String** | Socket Memory ID of the Persistent Memory Module on a server. | [optional] [readonly] 
**TotalCapacity** | **String** | Total capacity in GiB of the Persistent Memory Module on a server. | [optional] [readonly] 
**Uid** | **String** | UID of the Persistent Memory Module on a server. | [optional] [readonly] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**MemoryArray** | [**MemoryArrayRelationship**](MemoryArrayRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightMemoryPersistentMemoryUnitRelationship  -ClassId null `
 -ObjectType null `
 -Moid null `
 -Selector null `
 -Link null `
 -AccountMoid null `
 -CreateTime null `
 -DomainGroupMoid null `
 -ModTime null `
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
 -Model null `
 -Revision null `
 -Serial null `
 -Vendor null `
 -AdminState null `
 -ArrayId null `
 -Bank null `
 -Capacity null `
 -Clock null `
 -FormFactor null `
 -Latency null `
 -Location null `
 -OperPowerState null `
 -OperState null `
 -Operability null `
 -Presence null `
 -Set null `
 -Speed null `
 -Thermal null `
 -Type null `
 -Visibility null `
 -Width null `
 -AppDirectCapacity null `
 -CountStatus null `
 -FirmwareVersion null `
 -FrozenStatus null `
 -HealthState null `
 -LockStatus null `
 -MemoryCapacity null `
 -MemoryId null `
 -PersistentMemoryCapacity null `
 -ReservedCapacity null `
 -SecurityStatus null `
 -SocketId null `
 -SocketMemoryId null `
 -TotalCapacity null `
 -Uid null `
 -InventoryDeviceInfo null `
 -MemoryArray null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

