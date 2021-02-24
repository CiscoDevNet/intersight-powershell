# HyperflexMapUuidToTrackedDisk
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.MapUuidToTrackedDisk"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.MapUuidToTrackedDisk"]
**TrackedDisk** | [**HyperflexTrackedDisk**](HyperflexTrackedDisk.md) |  | [optional] 
**Uuid** | **String** | Disk unique id for a snapshot. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$HyperflexMapUuidToTrackedDisk = Initialize-IntersightHyperflexMapUuidToTrackedDisk  -ClassId null `
 -ObjectType null `
 -TrackedDisk null `
 -Uuid null
```

- Convert the resource to JSON
```powershell
$HyperflexMapUuidToTrackedDisk | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

