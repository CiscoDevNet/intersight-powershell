# ConnectorExpectPromptAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Expect** | **String** | The regex of the expect prompt of the interactive command. | [optional] 
**ExpectTimeout** | **Int64** | The timeout for the expect prompt while executing interactive command. If timeout is not set a default of 60 seconds will be used. | [optional] 
**Send** | **String** | The answer string to the expect prompt. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightConnectorExpectPromptAllOf  -Expect null `
 -ExpectTimeout null `
 -Send null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

