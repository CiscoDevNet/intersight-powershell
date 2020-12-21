# HyperflexHealthListAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Count** | **Int32** | The total number of &#39;hyperflex.Health&#39; resources matching the request, accross all pages. The &#39;Count&#39; attribute is included when the HTTP GET request includes the &#39;$inlinecount&#39; parameter. | [optional] 
**Results** | [**HyperflexHealth[]**](HyperflexHealth.md) | The array of &#39;hyperflex.Health&#39; resources matching the request. | [optional] 

## Examples

- Prepare the resource
```powershell
$HyperflexHealthListAllOf = Initialize-IntersightHyperflexHealthListAllOf  -Count null `
 -Results null
```

- Convert the resource to JSON
```powershell
$HyperflexHealthListAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

