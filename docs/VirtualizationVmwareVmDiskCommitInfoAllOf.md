# VirtualizationVmwareVmDiskCommitInfoAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CommittedDisk** | **Int64** | Disk committed in bytes on this virtual machine (disk space used up). | [optional] 
**UnCommittedDisk** | **Int64** | Total uncommitted disk space that is available for use (in bytes). | [optional] 
**UnsharedDisk** | **Int64** | Total unshared disk space (in bytes). | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightVirtualizationVmwareVmDiskCommitInfoAllOf  -CommittedDisk null `
 -UnCommittedDisk null `
 -UnsharedDisk null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

