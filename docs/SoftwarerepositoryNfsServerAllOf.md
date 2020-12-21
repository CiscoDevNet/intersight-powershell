# SoftwarerepositoryNfsServerAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "softwarerepository.NfsServer"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "softwarerepository.NfsServer"]
**FileLocation** | **String** | The location to the image file. The accepted format is IP-or-hostname/folder1/folder2/.../imageFile. | [optional] 
**MountOptions** | **String** | For NFS, leave the field blank or enter one or more comma seperated options from the following.For Example, &quot;&quot; &quot;&quot; , &quot;&quot; ro &quot;&quot; , &quot;&quot; ro , rw &quot;&quot; . * ro. * rw. * nolock. * noexec. * soft. * PORT&#x3D;VALUE. * timeo&#x3D;VALUE. * retry&#x3D;VALUE. | [optional] [readonly] 
**RemoteFile** | **String** | Filename of the image in the NFS server. For example:ucs-c220m5-huu-3.1.2c.iso. | [optional] [readonly] 
**RemoteIp** | **String** | Hostname or IP Address of the NFS server. | [optional] [readonly] 
**RemoteShare** | **String** | Remote directory where the image is present. For example:/share/subfolder. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$SoftwarerepositoryNfsServerAllOf = Initialize-IntersightSoftwarerepositoryNfsServerAllOf  -ClassId null `
 -ObjectType null `
 -FileLocation null `
 -MountOptions null `
 -RemoteFile null `
 -RemoteIp null `
 -RemoteShare null
```

- Convert the resource to JSON
```powershell
$SoftwarerepositoryNfsServerAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

