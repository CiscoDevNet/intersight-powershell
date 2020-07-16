# CommCredentialAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsPasswordSet** | **Boolean** | Indicates whether the value of the &#39;password&#39; property has been set. | [optional] [readonly] 
**Password** | **String** | Password for the Managed Device. | [optional] 
**Username** | **String** | Username for the Managed Device. Format and restrictions are not enforced here but usually follow the ManagedDevice requirements. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightCommCredentialAllOf  -IsPasswordSet null `
 -Password null `
 -Username null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

