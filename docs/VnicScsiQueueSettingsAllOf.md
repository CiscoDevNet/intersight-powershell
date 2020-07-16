# VnicScsiQueueSettingsAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Count** | **Int64** | The number of SCSI I/O queue resources the system should allocate. | [optional] 
**RingSize** | **Int64** | The number of descriptors in each SCSI I/O queue. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightVnicScsiQueueSettingsAllOf  -Count null `
 -RingSize null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

