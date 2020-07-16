# VirtualizationVmwareVmDiskCommitInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
**CommittedDisk** | **Int64** | Disk committed in bytes on this virtual machine (disk space used up). | [optional] 
**UnCommittedDisk** | **Int64** | Total uncommitted disk space that is available for use (in bytes). | [optional] 
**UnsharedDisk** | **Int64** | Total unshared disk space (in bytes). | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightVirtualizationVmwareVmDiskCommitInfo  -ClassId null `
 -ObjectType null `
 -CommittedDisk null `
 -UnCommittedDisk null `
 -UnsharedDisk null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

