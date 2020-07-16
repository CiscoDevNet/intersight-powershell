# HclCompatibilityStatusAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProfileList** | [**HclHardwareCompatibilityProfile[]**](HclHardwareCompatibilityProfile.md) |  | [optional] 
**RequestType** | **String** | Type of the request to be served. | [optional] [default to "FillSupportedVersions"]

## Examples

- Prepare the resource
```powershell
Initialize-IntersightHclCompatibilityStatusAllOf  -ProfileList null `
 -RequestType null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

