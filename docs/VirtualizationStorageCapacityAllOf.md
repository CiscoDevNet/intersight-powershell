# VirtualizationStorageCapacityAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Capacity** | **Int64** | The total capacity of the entity (bytes). | [optional] 
**Free** | **Int64** | Free storage space remaining in the entity (bytes) as a point-in-time snapshot. The available space is reported for an entity (such as Host or Cluster) when inventory data is collected for that entity. As part of the inventory data, a snapshot of the free and used storage capacity is also reported. | [optional] 
**Used** | **Int64** | Spaced already used by this entity (bytes), as a point-in-time snapshot. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightVirtualizationStorageCapacityAllOf  -Capacity null `
 -Free null `
 -Used null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

