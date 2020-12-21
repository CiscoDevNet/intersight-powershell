# VirtualizationComputeCapacityAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "virtualization.ComputeCapacity"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "virtualization.ComputeCapacity"]
**Capacity** | **Int64** | Total capacity of the entity in MHz. | [optional] 
**Free** | **Int64** | Free CPU capacity in MHz, as a point-in-time snapshot. The available CPU capacity is reported for an entity (such as Host or Cluster) when inventory data is collected for that entity. As part of the inventory data, a snapshot of the free and used CPU capacity is also reported. | [optional] 
**Used** | **Int64** | Used CPU capacity of the entity in MHz, as a point-in-time snapshot. | [optional] 

## Examples

- Prepare the resource
```powershell
$VirtualizationComputeCapacityAllOf = Initialize-IntersightVirtualizationComputeCapacityAllOf  -ClassId null `
 -ObjectType null `
 -Capacity null `
 -Free null `
 -Used null
```

- Convert the resource to JSON
```powershell
$VirtualizationComputeCapacityAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

