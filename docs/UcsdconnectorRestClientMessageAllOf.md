# UcsdconnectorRestClientMessageAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "ucsdconnector.RestClientMessage"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "ucsdconnector.RestClientMessage"]
**Body** | **String** | Payload which is sent along with the request. Most applicable to POST methods. | [optional] 
**Header** | [**AnyType**](.md) | Headers to be passed with the HTTP rest request. | [optional] 
**Method** | **String** | REST Method, should be set to one of [HTTP.MethodGet, HTTP.MethodPost]. | [optional] 
**RestUrl** | **String** | REST URL endpoint to which the HTTP request is sent. | [optional] 

## Examples

- Prepare the resource
```powershell
$UcsdconnectorRestClientMessageAllOf = Initialize-IntersightUcsdconnectorRestClientMessageAllOf  -ClassId null `
 -ObjectType null `
 -Body null `
 -Header null `
 -Method null `
 -RestUrl null
```

- Convert the resource to JSON
```powershell
$UcsdconnectorRestClientMessageAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

