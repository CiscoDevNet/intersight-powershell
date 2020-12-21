# SoftwarerepositoryCifsServer
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "softwarerepository.CifsServer"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "softwarerepository.CifsServer"]
**FileLocation** | **String** | The location to the image file. The accepted format is IP-or-hostname/folder1/folder2/.../imageFile. | [optional] 
**IsPasswordSet** | **Boolean** | Indicates whether the value of the &#39;password&#39; property has been set. | [optional] [readonly] [default to $false]
**MountOption** | **String** | For CIFS, leave the field blank or enter one or more comma seperated options from the following. For Example, &quot;&quot; &quot;&quot; , &quot;&quot; soft &quot;&quot; , &quot;&quot; soft , nounix &quot;&quot; . * soft. * nounix. * noserviceino. * guest. * USERNAME&#x3D;VALUE. * PASSWORD&#x3D;VALUE. * sec&#x3D;VALUE (VALUE could be None, Ntlm, Ntlmi, Ntlmssp, Ntlmsspi, Ntlmv2, Ntlmv2i). | [optional] 
**Password** | **String** | Password configured on the CIFS server. | [optional] 
**RemoteFile** | **String** | Filename of the image in the CIFS server. For example:ucs-c220m5-huu-3.1.2c.iso. | [optional] [readonly] 
**RemoteIp** | **String** | Hostname or IP Address of the CIFS server. | [optional] [readonly] 
**RemoteShare** | **String** | Remote directory where the image is present. For example:/share/subfolder. | [optional] [readonly] 
**Username** | **String** | Username configured on the CIFS server. | [optional] 

## Examples

- Prepare the resource
```powershell
$SoftwarerepositoryCifsServer = Initialize-IntersightSoftwarerepositoryCifsServer  -ClassId null `
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
$SoftwarerepositoryCifsServer | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

