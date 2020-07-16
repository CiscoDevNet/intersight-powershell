# SoftwarerepositoryNfsServer
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
**FileLocation** | **String** | The location to the image file. The accepted format is IP-or-hostname/folder1/folder2/.../imageFile. | [optional] 
**MountOptions** | **String** | For NFS, leave the field blank or enter one or more comma seperated options from the following.For Example, &quot;&quot; &quot;&quot; , &quot;&quot; ro &quot;&quot; , &quot;&quot; ro , rw &quot;&quot; . * ro. * rw. * nolock. * noexec. * soft. * PORT&#x3D;VALUE. * timeo&#x3D;VALUE. * retry&#x3D;VALUE. | [optional] [readonly] 
**RemoteFile** | **String** | Filename of the image in the NFS server. For example:ucs-c220m5-huu-3.1.2c.iso. | [optional] [readonly] 
**RemoteIp** | **String** | Hostname or IP Address of the NFS server. | [optional] [readonly] 
**RemoteShare** | **String** | Remote directory where the image is present. For example:/share/subfolder. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightSoftwarerepositoryNfsServer  -ClassId null `
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

