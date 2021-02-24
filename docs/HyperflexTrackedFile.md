# HyperflexTrackedFile
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.TrackedFile"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.TrackedFile"]
**FilePath** | [**HyperflexFilePath**](HyperflexFilePath.md) |  | [optional] 
**FileType** | **String** | File type for the tracked file. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$HyperflexTrackedFile = Initialize-IntersightHyperflexTrackedFile  -ClassId null `
 -ObjectType null `
 -FilePath null `
 -FileType null
```

- Convert the resource to JSON
```powershell
$HyperflexTrackedFile | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

