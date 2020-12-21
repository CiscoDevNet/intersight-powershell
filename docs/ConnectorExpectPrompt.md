# ConnectorExpectPrompt
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "connector.ExpectPrompt"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "connector.ExpectPrompt"]
**Expect** | **String** | The regex of the expect prompt of the interactive command. | [optional] 
**ExpectTimeout** | **Int64** | The timeout for the expect prompt while executing interactive command. If timeout is not set a default of 60 seconds will be used. | [optional] 
**Send** | **String** | The answer string to the expect prompt. | [optional] 

## Examples

- Prepare the resource
```powershell
$ConnectorExpectPrompt = Initialize-IntersightConnectorExpectPrompt  -ClassId null `
 -ObjectType null `
 -Expect null `
 -ExpectTimeout null `
 -Send null
```

- Convert the resource to JSON
```powershell
$ConnectorExpectPrompt | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

