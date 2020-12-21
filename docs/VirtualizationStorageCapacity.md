# VirtualizationStorageCapacity
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "virtualization.StorageCapacity"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "virtualization.StorageCapacity"]
**Capacity** | **Int64** | The total capacity of the entity (bytes). | [optional] 
**Free** | **Int64** | Free storage space remaining in the entity (bytes) as a point-in-time snapshot. The available space is reported for an entity (such as Host or Cluster) when inventory data is collected for that entity. As part of the inventory data, a snapshot of the free and used storage capacity is also reported. | [optional] 
**Used** | **Int64** | Spaced already used by this entity (bytes), as a point-in-time snapshot. | [optional] 

## Examples

- Prepare the resource
```powershell
$VirtualizationStorageCapacity = Initialize-IntersightVirtualizationStorageCapacity  -ClassId null `
 -ObjectType null `
 -Capacity null `
 -Free null `
 -Used null
```

- Convert the resource to JSON
```powershell
$VirtualizationStorageCapacity | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

