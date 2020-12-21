# ImcconnectorWebUiMessageAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "imcconnector.WebUiMessage"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "imcconnector.WebUiMessage"]
**WebUiRequest** | **String** | The body content of the UI HTTP request to send to the BMC platform. | [optional] 

## Examples

- Prepare the resource
```powershell
$ImcconnectorWebUiMessageAllOf = Initialize-IntersightImcconnectorWebUiMessageAllOf  -ClassId null `
 -ObjectType null `
 -WebUiRequest null
```

- Convert the resource to JSON
```powershell
$ImcconnectorWebUiMessageAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

