# ConnectorHttpRequestAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "connector.HttpRequest"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "connector.HttpRequest"]
**AssetTargetMoid** | **String** | The Target endpoint Moid which is used to fetch the previously persisted Target information in Intersight to create HTTP request along with any authentication info specifed. | [optional] 
**Body** | [**SystemByte**](SystemByte.md) | Contents of the request body to send for PUT/PATCH/POST requests. | [optional] 
**DialTimeout** | **Int64** | The timeout for establishing the TCP connection to the target host. If not set the request timeout value is used. | [optional] 
**EndpointMoid** | **String** | The MO id of the asset.EndpointConnection this request is directed to. If set plugin will insert connection details into the request, including credentials if defined. | [optional] 
**Header** | [**AnyType**](.md) | Collection of key value pairs to set in the request header. | [optional] 
**Internal** | **Boolean** | The request is for an internal platform API that requires authentication to be inserted by the platform implementation. | [optional] 
**Method** | **String** | Method specifies the HTTP method (GET, POST, PUT, etc.). For client requests an empty string means GET. | [optional] 
**Timeout** | **Int64** | The timeout for the HTTP request to complete, from connection establishment to response body read complete. If not set a default timeout of five minutes is used. | [optional] 
**Url** | [**ConnectorUrl**](ConnectorUrl.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ConnectorHttpRequestAllOf = Initialize-IntersightConnectorHttpRequestAllOf  -ClassId null `
 -ObjectType null `
 -AssetTargetMoid null `
 -Body null `
 -DialTimeout null `
 -EndpointMoid null `
 -Header null `
 -Internal null `
 -Method null `
 -Timeout null `
 -Url null
```

- Convert the resource to JSON
```powershell
$ConnectorHttpRequestAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

