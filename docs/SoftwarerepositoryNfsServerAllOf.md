# SoftwarerepositoryNfsServerAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FileLocation** | **String** | The location to the image file. The accepted format is IP-or-hostname/folder1/folder2/.../imageFile. | [optional] 
**MountOptions** | **String** | For NFS, leave the field blank or enter one or more comma seperated options from the following.For Example, &quot;&quot; &quot;&quot; , &quot;&quot; ro &quot;&quot; , &quot;&quot; ro , rw &quot;&quot; . * ro. * rw. * nolock. * noexec. * soft. * PORT&#x3D;VALUE. * timeo&#x3D;VALUE. * retry&#x3D;VALUE. | [optional] [readonly] 
**RemoteFile** | **String** | Filename of the image in the NFS server. For example:ucs-c220m5-huu-3.1.2c.iso. | [optional] [readonly] 
**RemoteIp** | **String** | Hostname or IP Address of the NFS server. | [optional] [readonly] 
**RemoteShare** | **String** | Remote directory where the image is present. For example:/share/subfolder. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightSoftwarerepositoryNfsServerAllOf  -FileLocation null `
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

