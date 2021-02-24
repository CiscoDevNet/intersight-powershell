# HyperflexDiskStatusAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.DiskStatus"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.DiskStatus"]
**DownloadPercentage** | **String** | Percentage of download completed. | [optional] [readonly] 
**State** | **String** | Current state of the virtual disk. * &#x60;Unknown&#x60; - No details available on the disk state. * &#x60;Succeeded&#x60; - Last operation on the disk has been successful. * &#x60;ImportInProgress&#x60; - Import operation on the disk is in progress. * &#x60;ImportFailed&#x60; - Import operation on the disk has failed. * &#x60;CloneInProgress&#x60; - Disk clone operation on the disk is in progress. * &#x60;CloneFailed&#x60; - Clone operation on the disk has failed. * &#x60;CloneScheduled&#x60; - Clone operation on the disk has been scheduled. * &#x60;ImportScheduled&#x60; - Import operation on the disk has been scheduled. * &#x60;Pending&#x60; - Submitted operation on the disk is currently pending. | [optional] [readonly] [default to "Unknown"]
**VolumeHandle** | **String** | Identity of the Volume associated with virtual machine disk. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$HyperflexDiskStatusAllOf = Initialize-IntersightHyperflexDiskStatusAllOf  -ClassId null `
 -ObjectType null `
 -DownloadPercentage null `
 -State null `
 -VolumeHandle null
```

- Convert the resource to JSON
```powershell
$HyperflexDiskStatusAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

