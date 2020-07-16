# ConnectorHttpRequestAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Body** | [**SystemByte**](SystemByte.md) | Contents of the request body to send for PUT/PATCH/POST requests. | [optional] 
**DialTimeout** | **Int64** | The timeout for establishing the TCP connection to the target host. If not set the request timeout value is used. | [optional] 
**Header** | [**AnyType**](.md) | Collection of key value pairs to set in the request header. | [optional] 
**Internal** | **Boolean** | The request is for an internal platform API that requires authentication to be inserted by the platform implementation. | [optional] 
**Method** | **String** | Method specifies the HTTP method (GET, POST, PUT, etc.). For client requests an empty string means GET. | [optional] 
**Timeout** | **Int64** | The timeout for the HTTP request to complete, from connection establishment to response body read complete. If not set a default timeout of five minutes is used. | [optional] 
**Url** | [**ConnectorUrl**](ConnectorUrl.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightConnectorHttpRequestAllOf  -Body null `
 -DialTimeout null `
 -Header null `
 -Internal null `
 -Method null `
 -Timeout null `
 -Url null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

