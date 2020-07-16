# VirtualizationVmwareRemoteDisplayInfoAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RemoteDisplayPassword** | **String** | The password used for remote access. It is stored base64 encoded. | [optional] 
**RemoteDisplayVncKey** | **String** | The access key for the remote display, potentially a long string. | [optional] 
**RemoteDisplayVncPort** | **Int64** | Applies only when remoteDisplayvnc is enabled. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightVirtualizationVmwareRemoteDisplayInfoAllOf  -RemoteDisplayPassword null `
 -RemoteDisplayVncKey null `
 -RemoteDisplayVncPort null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

