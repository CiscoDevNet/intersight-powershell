# HyperflexReplicationSchedule
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.ReplicationSchedule"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.ReplicationSchedule"]
**BackupInterval** | **Int64** | Time interval between two copies in minutes. | [optional] [default to 240]

## Examples

- Prepare the resource
```powershell
$HyperflexReplicationSchedule = Initialize-IntersightHyperflexReplicationSchedule  -ClassId null `
 -ObjectType null `
 -BackupInterval null
```

- Convert the resource to JSON
```powershell
$HyperflexReplicationSchedule | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

