# VirtualizationVmwareVmDiskCommitInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "virtualization.VmwareVmDiskCommitInfo"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "virtualization.VmwareVmDiskCommitInfo"]
**CommittedDisk** | **Int64** | Disk committed in bytes on this virtual machine (disk space used up). | [optional] 
**UnCommittedDisk** | **Int64** | Total uncommitted disk space that is available for use (in bytes). | [optional] 
**UnsharedDisk** | **Int64** | Total unshared disk space (in bytes). | [optional] 

## Examples

- Prepare the resource
```powershell
$VirtualizationVmwareVmDiskCommitInfo = Initialize-IntersightVirtualizationVmwareVmDiskCommitInfo  -ClassId null `
 -ObjectType null `
 -CommittedDisk null `
 -UnCommittedDisk null `
 -UnsharedDisk null
```

- Convert the resource to JSON
```powershell
$VirtualizationVmwareVmDiskCommitInfo | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

