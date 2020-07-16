# VirtualizationComputeCapacityAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Capacity** | **Int64** | Total capacity of the entity in MHz. | [optional] 
**Free** | **Int64** | Free CPU capacity in MHz, as a point-in-time snapshot. The available CPU capacity is reported for an entity (such as Host or Cluster) when inventory data is collected for that entity. As part of the inventory data, a snapshot of the free and used CPU capacity is also reported. | [optional] 
**Used** | **Int64** | Used CPU capacity of the entity in MHz, as a point-in-time snapshot. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightVirtualizationComputeCapacityAllOf  -Capacity null `
 -Free null `
 -Used null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

