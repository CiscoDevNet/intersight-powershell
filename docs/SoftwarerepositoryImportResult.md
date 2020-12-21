# SoftwarerepositoryImportResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "softwarerepository.ImportResult"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "softwarerepository.ImportResult"]
**ErrorMessage** | **String** | The reason for the failure of an import operation, if applicable. | [optional] [readonly] 
**Progress** | **Int64** | The progress percentage for the import operation. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$SoftwarerepositoryImportResult = Initialize-IntersightSoftwarerepositoryImportResult  -ClassId null `
 -ObjectType null `
 -ErrorMessage null `
 -Progress null
```

- Convert the resource to JSON
```powershell
$SoftwarerepositoryImportResult | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

