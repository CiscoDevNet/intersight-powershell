# TelemetryDruidFilter
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **String** | The filter type. | 
**ExtractionFn** | [**SystemCollectionsHashtable**](.md) | All filters except the &quot;&quot;spatial&quot;&quot; filter support extraction functions. An extraction function is defined by setting the &quot;&quot;extractionFn&quot;&quot; field on a filter. See Extraction function for more details on extraction functions. If specified, the extraction function will be used to transform input values before the filter is applied. The example below shows a selector filter combined with an extraction function. This filter will transform input values according to the values defined in the lookup map; transformed values will then be matched with the string &quot;&quot;bar_1&quot;&quot;. | [optional] 
**Dimension** | **String** | null | 
**Value** | **String** | The value of a dimension. | 
**Dimensions** | [**TelemetryDruidDimensionSpec[]**](TelemetryDruidDimensionSpec.md) | A list of DimensionSpecs, making it possible to apply an extraction function if needed. | 
**Pattern** | **String** | null | 
**Fields** | [**TelemetryDruidFilter[]**](TelemetryDruidFilter.md) |  | 
**Field** | [**TelemetryDruidFilter**](TelemetryDruidFilter.md) |  | 

## Examples

- Prepare the resource
```powershell
$TelemetryDruidFilter = Initialize-IntersightTelemetryDruidFilter  -Type null `
 -ExtractionFn {&quot;type&quot;:&quot;lookup&quot;,&quot;lookup&quot;:{&quot;type&quot;:&quot;map&quot;,&quot;map&quot;:{&quot;product_1&quot;:&quot;bar_1&quot;,&quot;product_5&quot;:&quot;bar_1&quot;,&quot;product_3&quot;:&quot;bar_1&quot;}}} `
 -Dimension null `
 -Value null `
 -Dimensions null `
 -Pattern null `
 -Fields null `
 -Field null
```

- Convert the resource to JSON
```powershell
$TelemetryDruidFilter | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

