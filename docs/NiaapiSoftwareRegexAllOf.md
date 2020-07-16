# NiaapiSoftwareRegexAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Regex** | **String** | Regular Expression pattern used to reconginze the version string. | [optional] 
**SoftwareVersion** | **String** | Software release. A set of Software releases seperated by comma which can be recongized by according Regex pattern. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightNiaapiSoftwareRegexAllOf  -Regex null `
 -SoftwareVersion null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

