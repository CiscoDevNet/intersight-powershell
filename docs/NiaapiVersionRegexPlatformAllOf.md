# NiaapiVersionRegexPlatformAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Anyllregex** | **String** | All long live version Regex pattern. | [optional] 
**Currentlltrain** | [**NiaapiSoftwareRegex**](NiaapiSoftwareRegex.md) |  | [optional] 
**Latestsltrain** | [**NiaapiSoftwareRegex**](NiaapiSoftwareRegex.md) |  | [optional] 
**Sltrain** | [**NiaapiSoftwareRegex[]**](NiaapiSoftwareRegex.md) |  | [optional] 
**Upcominglltrain** | [**NiaapiSoftwareRegex**](NiaapiSoftwareRegex.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightNiaapiVersionRegexPlatformAllOf  -Anyllregex null `
 -Currentlltrain null `
 -Latestsltrain null `
 -Sltrain null `
 -Upcominglltrain null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

