# BiosPolicyListAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Count** | **Int32** | The total number of &#39;bios.Policy&#39; resources matching the request, accross all pages. The &#39;Count&#39; attribute is included when the HTTP GET request includes the &#39;$inlinecount&#39; parameter. | [optional] 
**Results** | [**BiosPolicy[]**](BiosPolicy.md) | The array of &#39;bios.Policy&#39; resources matching the request. | [optional] 

## Examples

- Prepare the resource
```powershell
$BiosPolicyListAllOf = Initialize-IntersightBiosPolicyListAllOf  -Count null `
 -Results null
```

- Convert the resource to JSON
```powershell
$BiosPolicyListAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

