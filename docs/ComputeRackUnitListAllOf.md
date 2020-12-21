# ComputeRackUnitListAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Count** | **Int32** | The total number of &#39;compute.RackUnit&#39; resources matching the request, accross all pages. The &#39;Count&#39; attribute is included when the HTTP GET request includes the &#39;$inlinecount&#39; parameter. | [optional] 
**Results** | [**ComputeRackUnit[]**](ComputeRackUnit.md) | The array of &#39;compute.RackUnit&#39; resources matching the request. | [optional] 

## Examples

- Prepare the resource
```powershell
$ComputeRackUnitListAllOf = Initialize-IntersightComputeRackUnitListAllOf  -Count null `
 -Results null
```

- Convert the resource to JSON
```powershell
$ComputeRackUnitListAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

