# VirtualizationVmwareRemoteDisplayInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "virtualization.VmwareRemoteDisplayInfo"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "virtualization.VmwareRemoteDisplayInfo"]
**RemoteDisplayPassword** | **String** | The password used for remote access. It is stored base64 encoded. | [optional] 
**RemoteDisplayVncKey** | **String** | The access key for the remote display, potentially a long string. | [optional] 
**RemoteDisplayVncPort** | **Int64** | Applies only when remoteDisplayvnc is enabled. | [optional] 

## Examples

- Prepare the resource
```powershell
$VirtualizationVmwareRemoteDisplayInfo = Initialize-IntersightVirtualizationVmwareRemoteDisplayInfo  -ClassId null `
 -ObjectType null `
 -RemoteDisplayPassword null `
 -RemoteDisplayVncKey null `
 -RemoteDisplayVncPort null
```

- Convert the resource to JSON
```powershell
$VirtualizationVmwareRemoteDisplayInfo | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

