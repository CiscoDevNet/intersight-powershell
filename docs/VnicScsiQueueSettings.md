# VnicScsiQueueSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "vnic.ScsiQueueSettings"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "vnic.ScsiQueueSettings"]
**Count** | **Int64** | The number of SCSI I/O queue resources the system should allocate. | [optional] [default to 1]
**RingSize** | **Int64** | The number of descriptors in each SCSI I/O queue. | [optional] [default to 512]

## Examples

- Prepare the resource
```powershell
$VnicScsiQueueSettings = Initialize-IntersightVnicScsiQueueSettings  -ClassId null `
 -ObjectType null `
 -Count null `
 -RingSize null
```

- Convert the resource to JSON
```powershell
$VnicScsiQueueSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

