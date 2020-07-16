# SoftwarerepositoryCifsServer
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
**FileLocation** | **String** | The location to the image file. The accepted format is IP-or-hostname/folder1/folder2/.../imageFile. | [optional] 
**IsPasswordSet** | **Boolean** | Indicates whether the value of the &#39;password&#39; property has been set. | [optional] [readonly] 
**MountOption** | **String** | For CIFS, leave the field blank or enter one or more comma seperated options from the following. For Example, &quot;&quot; &quot;&quot; , &quot;&quot; soft &quot;&quot; , &quot;&quot; soft , nounix &quot;&quot; . * soft. * nounix. * noserviceino. * guest. * USERNAME&#x3D;VALUE. * PASSWORD&#x3D;VALUE. * sec&#x3D;VALUE (VALUE could be None, Ntlm, Ntlmi, Ntlmssp, Ntlmsspi, Ntlmv2, Ntlmv2i). | [optional] 
**Password** | **String** | Password configured on the CIFS server. | [optional] 
**RemoteFile** | **String** | Filename of the image in the CIFS server. For example:ucs-c220m5-huu-3.1.2c.iso. | [optional] [readonly] 
**RemoteIp** | **String** | Hostname or IP Address of the CIFS server. | [optional] [readonly] 
**RemoteShare** | **String** | Remote directory where the image is present. For example:/share/subfolder. | [optional] [readonly] 
**Username** | **String** | Username configured on the CIFS server. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightSoftwarerepositoryCifsServer  -ClassId null `
 -ObjectType null `
 -FileLocation null `
 -IsPasswordSet null `
 -MountOption null `
 -Password null `
 -RemoteFile null `
 -RemoteIp null `
 -RemoteShare null `
 -Username null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

