# HyperflexTrackedDisk
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.TrackedDisk"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.TrackedDisk"]
**DiskFiles** | [**HyperflexTrackedFile[]**](HyperflexTrackedFile.md) |  | [optional] 
**DiskType** | **String** | Disk type for a vm virtual disk. * &#x60;NONE&#x60; - The disk type for this VM is None. * &#x60;NATIVE&#x60; - The disk type for this VM is Native. * &#x60;NONNATIVE&#x60; - The disk type for this VM is Non-Native. | [optional] [readonly] [default to "NONE"]

## Examples

- Prepare the resource
```powershell
$HyperflexTrackedDisk = Initialize-IntersightHyperflexTrackedDisk  -ClassId null `
 -ObjectType null `
 -DiskFiles null `
 -DiskType null
```

- Convert the resource to JSON
```powershell
$HyperflexTrackedDisk | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

