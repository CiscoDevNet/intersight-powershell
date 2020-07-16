# NiaapiVersionRegexAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Apic** | [**NiaapiVersionRegexPlatform**](NiaapiVersionRegexPlatform.md) |  | [optional] 
**Dcnm** | [**NiaapiVersionRegexPlatform**](NiaapiVersionRegexPlatform.md) |  | [optional] 
**Version** | **String** | Version number for the Version Regex data, also used as identity. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightNiaapiVersionRegexAllOf  -Apic null `
 -Dcnm null `
 -Version null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

