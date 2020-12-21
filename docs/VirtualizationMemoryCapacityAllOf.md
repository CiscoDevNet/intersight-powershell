# VirtualizationMemoryCapacityAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "virtualization.MemoryCapacity"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "virtualization.MemoryCapacity"]
**Capacity** | **Int64** | The total memory capacity of the entity in bytes. | [optional] 
**Free** | **Int64** | Free memory (bytes) that is unused and available for allocation, as a point-in-time snapshot. The available memory capacity is reported for an entity (such as Host or Cluster) when inventory data is collected for that entity. As part of the inventory data, a snapshot of the free and used memory capacity is also reported. | [optional] 
**Used** | **Int64** | Memory (bytes) that has been already used up, as a point-in-time snapshot. | [optional] 

## Examples

- Prepare the resource
```powershell
$VirtualizationMemoryCapacityAllOf = Initialize-IntersightVirtualizationMemoryCapacityAllOf  -ClassId null `
 -ObjectType null `
 -Capacity null `
 -Free null `
 -Used null
```

- Convert the resource to JSON
```powershell
$VirtualizationMemoryCapacityAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

