# VnicFlogiSettingsAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Retries** | **Int64** | The number of times that the system tries to log in to the fabric after the first failure. | [optional] 
**Timeout** | **Int64** | The number of milliseconds that the system waits before it tries to log in again. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightVnicFlogiSettingsAllOf  -Retries null `
 -Timeout null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

