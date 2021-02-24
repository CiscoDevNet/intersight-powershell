# HyperflexFilePathAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.FilePath"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.FilePath"]
**DsInfo** | [**HyperflexDatastoreInfo**](HyperflexDatastoreInfo.md) |  | [optional] 
**RelativeFilePath** | **String** | Relative file path within the datastore. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$HyperflexFilePathAllOf = Initialize-IntersightHyperflexFilePathAllOf  -ClassId null `
 -ObjectType null `
 -DsInfo null `
 -RelativeFilePath null
```

- Convert the resource to JSON
```powershell
$HyperflexFilePathAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

