# RecoveryBackupScheduleAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExecutionTime** | **System.DateTime** | The time at which the backup is to be run on a given day. This is used when the frequency unit is daily. | [optional] 
**FrequencyUnit** | **String** | The frequency at which the backup schedule must run. | [optional] [default to "Daily"]
**Hours** | **Int32** | The frequency, in hours, at which the backup schedule runs. | [optional] [default to 8]

## Examples

- Prepare the resource
```powershell
Initialize-IntersightRecoveryBackupScheduleAllOf  -ExecutionTime null `
 -FrequencyUnit null `
 -Hours null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

