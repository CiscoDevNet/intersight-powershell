# RecoveryBackupSchedule
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "recovery.BackupSchedule"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "recovery.BackupSchedule"]
**ExecutionTime** | **System.DateTime** | The time at which the backup is to be run on a given day. This is used when the frequency unit is daily. | [optional] 
**FrequencyUnit** | **String** | The frequency at which the backup schedule must run. * &#x60;Daily&#x60; - Allows the user to run the backup daily at a given time. * &#x60;Periodic&#x60; - Allows the user to run the backup after a certain number of hours. | [optional] [default to "Daily"]
**Hours** | **Int32** | The frequency, in hours, at which the backup schedule runs. * &#x60;8&#x60; -  * &#x60;4&#x60; -  * &#x60;12&#x60; -  * &#x60;16&#x60; -  * &#x60;20&#x60; - | [optional] [default to 8]

## Examples

- Prepare the resource
```powershell
$RecoveryBackupSchedule = Initialize-IntersightRecoveryBackupSchedule  -ClassId null `
 -ObjectType null `
 -ExecutionTime null `
 -FrequencyUnit null `
 -Hours null
```

- Convert the resource to JSON
```powershell
$RecoveryBackupSchedule | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

