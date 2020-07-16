# TelemetryDruidDurationGranularity
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **String** | the type of granularity. | 
**Duration** | **Int64** | The duration in milliseconds. | 
**Origin** | **System.DateTime** | An optional value specifying when to start counting time buckets from. The default value is 1970-01-01T00:00:00Z. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightTelemetryDruidDurationGranularity  -Type null `
 -Duration null `
 -Origin null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

