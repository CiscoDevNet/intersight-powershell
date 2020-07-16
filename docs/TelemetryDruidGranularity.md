# TelemetryDruidGranularity
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **String** | the type of granularity. | 
**Duration** | **Int64** | The duration in milliseconds. | 
**Origin** | **System.DateTime** | An optional value specifying when to start counting time buckets from. The default value is 1970-01-01T00:00:00Z. | [optional] 
**Period** | **String** | The period in ISO 8601 format. Examples are P2W, P3M, PT1H30M, PT0.750S. | 
**TimeZone** | **String** | An optional value specifying the time zone. Standard [IANA time zones](http://joda-time.sourceforge.net/timezones.html) are supported. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightTelemetryDruidGranularity  -Type null `
 -Duration null `
 -Origin null `
 -Period null `
 -TimeZone null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

