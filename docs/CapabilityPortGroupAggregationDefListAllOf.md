# CapabilityPortGroupAggregationDefListAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Count** | **Int32** | The total number of &#39;capability.PortGroupAggregationDef&#39; resources matching the request, accross all pages. The &#39;Count&#39; attribute is included when the HTTP GET request includes the &#39;$inlinecount&#39; parameter. | [optional] 
**Results** | [**CapabilityPortGroupAggregationDef[]**](CapabilityPortGroupAggregationDef.md) | The array of &#39;capability.PortGroupAggregationDef&#39; resources matching the request. | [optional] 

## Examples

- Prepare the resource
```powershell
$CapabilityPortGroupAggregationDefListAllOf = Initialize-IntersightCapabilityPortGroupAggregationDefListAllOf  -Count null `
 -Results null
```

- Convert the resource to JSON
```powershell
$CapabilityPortGroupAggregationDefListAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

