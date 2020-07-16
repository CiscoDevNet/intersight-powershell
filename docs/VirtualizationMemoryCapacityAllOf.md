# VirtualizationMemoryCapacityAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Capacity** | **Int64** | The total memory capacity of the entity in bytes. | [optional] 
**Free** | **Int64** | Free memory (bytes) that is unused and available for allocation, as a point-in-time snapshot. The available memory capacity is reported for an entity (such as Host or Cluster) when inventory data is collected for that entity. As part of the inventory data, a snapshot of the free and used memory capacity is also reported. | [optional] 
**Used** | **Int64** | Memory (bytes) that has been already used up, as a point-in-time snapshot. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightVirtualizationMemoryCapacityAllOf  -Capacity null `
 -Free null `
 -Used null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

