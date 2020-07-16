# VirtualizationVmwareRemoteDisplayInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
**RemoteDisplayPassword** | **String** | The password used for remote access. It is stored base64 encoded. | [optional] 
**RemoteDisplayVncKey** | **String** | The access key for the remote display, potentially a long string. | [optional] 
**RemoteDisplayVncPort** | **Int64** | Applies only when remoteDisplayvnc is enabled. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightVirtualizationVmwareRemoteDisplayInfo  -ClassId null `
 -ObjectType null `
 -RemoteDisplayPassword null `
 -RemoteDisplayVncKey null `
 -RemoteDisplayVncPort null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

