# VmediaMapping
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
**AuthenticationProtocol** | **String** | Type of Authentication protocol when CIFS is used for communication with the remote server. | [optional] [default to "none"]
**DeviceType** | **String** | Type of remote Virtual Media device. | [optional] [default to "cdd"]
**HostName** | **String** | IP address or hostname of the remote server. | [optional] 
**IsPasswordSet** | **Boolean** | Indicates whether the value of the &#39;password&#39; property has been set. | [optional] [readonly] 
**MountOptions** | **String** | Mount options for the Virtual Media mapping. The field can be left blank or filled in a comma separated list with the following options.\\n For NFS, supported options are ro, rw, nolock, noexec, soft, port&#x3D;VALUE, timeo&#x3D;VALUE, retry&#x3D;VALUE.\\n For CIFS, supported options are soft, nounix, noserverino, guest.\\n For CIFS version &lt; 3.0, vers&#x3D;VALUE is mandatory. e.g. vers&#x3D;2.0\\n For HTTP/HTTPS, the only supported option is noauto. | [optional] 
**MountProtocol** | **String** | Protocol to use to communicate with the remote server. | [optional] [default to "nfs"]
**Password** | **String** | Password associated with the username. | [optional] 
**RemoteFile** | **String** | Name of the remote file. It should be of .img format for HDD Virtual Media mapping and .iso format for CDD Virtual Media mapping. | [optional] 
**RemotePath** | **String** | URL path to the location of the image on the remote server. The preferred format is &#39;/path&#39;. | [optional] 
**Username** | **String** | Username to log in to the remote server. | [optional] 
**VolumeName** | **String** | Identity of the image for Virtual Media mapping. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightVmediaMapping  -ClassId null `
 -ObjectType null `
 -AuthenticationProtocol null `
 -DeviceType null `
 -HostName null `
 -IsPasswordSet null `
 -MountOptions null `
 -MountProtocol null `
 -Password null `
 -RemoteFile null `
 -RemotePath null `
 -Username null `
 -VolumeName null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

