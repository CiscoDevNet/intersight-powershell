# TelemetryDruidDataSourceMetadataResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Timestamp** | **System.DateTime** | The ISO 8601 timestamp. | [optional] 
**Result** | [**SystemCollectionsHashtable**](.md) | The metadata for the specified datasource | [optional] 

## Examples

- Prepare the resource
```powershell
$TelemetryDruidDataSourceMetadataResult = Initialize-IntersightTelemetryDruidDataSourceMetadataResult  -Timestamp null `
 -Result null
```

- Convert the resource to JSON
```powershell
$TelemetryDruidDataSourceMetadataResult | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

