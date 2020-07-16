# PkixDistinguishedNameAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CommonName** | **String** | A required component that identifies a person or an object. | [optional] [readonly] 
**Country** | **String[]** |  | [optional] 
**Locality** | **String[]** |  | [optional] 
**Organization** | **String[]** |  | [optional] 
**OrganizationalUnit** | **String[]** |  | [optional] 
**State** | **String[]** |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightPkixDistinguishedNameAllOf  -CommonName null `
 -Country null `
 -Locality null `
 -Organization null `
 -OrganizationalUnit null `
 -State null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

