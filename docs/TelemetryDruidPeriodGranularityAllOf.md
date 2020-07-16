# TelemetryDruidPeriodGranularityAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Period** | **String** | The period in ISO 8601 format. Examples are P2W, P3M, PT1H30M, PT0.750S. | 
**TimeZone** | **String** | An optional value specifying the time zone. Standard [IANA time zones](http://joda-time.sourceforge.net/timezones.html) are supported. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightTelemetryDruidPeriodGranularityAllOf  -Period null `
 -TimeZone null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

