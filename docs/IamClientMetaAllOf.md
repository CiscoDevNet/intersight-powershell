# IamClientMetaAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "iam.ClientMeta"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "iam.ClientMeta"]
**DeviceModel** | **String** | Parsed device model from raw User-Agent. | [optional] 
**UserAgent** | **String** | The value of the &quot;&quot;User-Agent&quot;&quot; HTTP header, as sent by the HTTP client when it initiate a session to Intersight. This can be used to identify the client operating system, browser type and browser version. Example - Mozilla/5.0 (Macintosh; Intel Mac OS X 10_14_5) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/75.0.3770.100 Safari/537.36 It is set when User successfully passed OAuth login flow and receives Access Token. | [optional] 

## Examples

- Prepare the resource
```powershell
$IamClientMetaAllOf = Initialize-IntersightIamClientMetaAllOf  -ClassId null `
 -ObjectType null `
 -DeviceModel null `
 -UserAgent null
```

- Convert the resource to JSON
```powershell
$IamClientMetaAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

