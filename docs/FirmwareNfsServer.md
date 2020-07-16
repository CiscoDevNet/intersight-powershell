# FirmwareNfsServer
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
**FileLocation** | **String** | The location to the image file. The accepted format is IP-or-hostname/folder1/folder2/.../imageFile. | [optional] 
**MountOptions** | **String** | Mount option as configured on the NFS Server. For example:nolock. | [optional] 
**RemoteFile** | **String** | Filename of the image in the remote share location. For example:ucs-c220m5-huu-3.1.2c.iso. | [optional] [readonly] 
**RemoteIp** | **String** | NFS Server Hostname or IP Address. For example:NFS-server-hostname or 10.10.8.7. The remote share server should have network connectivity with the CIMC of the selected devices for a successful upgrade. | [optional] [readonly] 
**RemoteShare** | **String** | Directory where the image is stored. For example:/share/subfolder. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightFirmwareNfsServer  -ClassId null `
 -ObjectType null `
 -FileLocation null `
 -MountOptions null `
 -RemoteFile null `
 -RemoteIp null `
 -RemoteShare null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

