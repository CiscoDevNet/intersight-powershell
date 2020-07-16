# RecoveryBackupSchedule
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
**ExecutionTime** | **System.DateTime** | The time at which the backup is to be run on a given day. This is used when the frequency unit is daily. | [optional] 
**FrequencyUnit** | **String** | The frequency at which the backup schedule must run. | [optional] [default to "Daily"]
**Hours** | **Int32** | The frequency, in hours, at which the backup schedule runs. | [optional] [default to 8]

## Examples

- Prepare the resource
```powershell
Initialize-IntersightRecoveryBackupSchedule  -ClassId null `
 -ObjectType null `
 -ExecutionTime null `
 -FrequencyUnit null `
 -Hours null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

