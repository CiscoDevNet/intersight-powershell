# TelemetryDruidTopNMetricSpec
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **String** | The dimension spec type. | 
**Metric** | [**TelemetryDruidTopNMetricSpec**](TelemetryDruidTopNMetricSpec.md) |  | 
**Ordering** | **String** | Specifies the sorting order. It can be one of the following values. &quot;&quot;lexicographic&quot;&quot;, &quot;&quot;alphanumeric&quot;&quot;, &quot;&quot;numeric&quot;&quot;, &quot;&quot;strlen&quot;&quot;. * lexicographic - Sorts values by converting Strings to their UTF-8 byte array representations and comparing lexicographically, byte-by-byte. * alphanumeric - Suitable for strings with both numeric and non-numeric content, e.g. &quot;&quot;file12 sorts after file2&quot;&quot;. See https://github.com/amjjd/java-alphanum for more details on how this ordering sorts values. This ordering is not suitable for numbers with decimal points or negative numbers. * numeric - Sorts values as numbers, supports integers and floating point values. Negative values are supported. This sorting order will try to parse all string values as numbers. Unparseable values are treated as nulls, and nulls precede numbers. When comparing two unparseable values (e.g., &quot;&quot;hello&quot;&quot; and &quot;&quot;world&quot;&quot;), this ordering will sort by comparing the unparsed strings lexicographically. * strlen - Sorts values by the their string lengths. When there is a tie, this comparator falls back to using the String compareTo method. * version - Sorts values as versions, e.g. &quot;&quot;10.0 sorts after 9.0&quot;&quot;, &quot;&quot;1.0.0-SNAPSHOT sorts after 1.0.0&quot;&quot;. | [optional] [default to "lexicographic"]
**PreviousStop** | **String** | The starting point of the sort. For example, if a previousStop value is &#39;b&#39;, all values before &#39;b&#39; are discarded. This field can be used to paginate through all the dimension values. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightTelemetryDruidTopNMetricSpec  -Type null `
 -Metric null `
 -Ordering null `
 -PreviousStop null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

