# KvmSessionList
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ObjectType** | **String** | A discriminator value to disambiguate the schema of a HTTP GET response body. | 
**Count** | **Int32** | The total number of &#39;kvm.Session&#39; resources matching the request, accross all pages. The &#39;Count&#39; attribute is included when the HTTP GET request includes the &#39;$inlinecount&#39; parameter. | [optional] 
**Results** | [**KvmSession[]**](KvmSession.md) | The array of &#39;kvm.Session&#39; resources matching the request. | [optional] 

## Examples

- Prepare the resource
```powershell
$KvmSessionList = Initialize-IntersightKvmSessionList  -ObjectType null `
 -Count null `
 -Results null
```

- Convert the resource to JSON
```powershell
$KvmSessionList | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

