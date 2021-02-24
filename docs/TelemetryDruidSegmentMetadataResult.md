# TelemetryDruidSegmentMetadataResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **String** | An identifier for the metadata | [optional] 
**Intervals** | **String** | String representation of the interval queried | [optional] 
**Columns** | [**SystemCollectionsHashtable**](.md) | A map of columns and their properties | [optional] 
**Aggregators** | [**SystemCollectionsHashtable**](.md) | A map of metrics and their properties | [optional] 
**QueryGranularity** | [**SystemCollectionsHashtable**](.md) | query granularity of data stored in segments, may be &#39;null&#39; | [optional] 
**Size** | **Int32** | estimated total segment byte size as if stored as text | [optional] 
**NumRows** | **Int32** | number of rows stored in segment | [optional] 

## Examples

- Prepare the resource
```powershell
$TelemetryDruidSegmentMetadataResult = Initialize-IntersightTelemetryDruidSegmentMetadataResult  -Id null `
 -Intervals null `
 -Columns null `
 -Aggregators null `
 -QueryGranularity null `
 -Size null `
 -NumRows null
```

- Convert the resource to JSON
```powershell
$TelemetryDruidSegmentMetadataResult | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

