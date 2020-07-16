# UcsdconnectorRestClientMessageAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Body** | **String** | Payload which is sent along with the request. Most applicable to POST methods. | [optional] 
**Header** | [**AnyType**](.md) | Headers to be passed with the HTTP rest request. | [optional] 
**Method** | **String** | REST Method, should be set to one of [HTTP.MethodGet, HTTP.MethodPost]. | [optional] 
**RestUrl** | **String** | REST URL endpoint to which the HTTP request is sent. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightUcsdconnectorRestClientMessageAllOf  -Body null `
 -Header null `
 -Method null `
 -RestUrl null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

