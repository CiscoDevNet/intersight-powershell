# SoftwarerepositoryHttpServerAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsPasswordSet** | **Boolean** | Indicates whether the value of the &#39;password&#39; property has been set. | [optional] [readonly] 
**LocationLink** | **String** | HTTP/HTTPS link to the image. Accepted formats are HTTP[s]://server-hostname/share/image or HTTP[s]://serverip/share/image. | [optional] 
**Password** | **String** | Password as configured on the HTTP[S] server for user authentication. It is generally required to authenticate user provided HTTP[S] based software repositories. | [optional] 
**Username** | **String** | Username as configured on the HTTP[S] server for user authentication. It is generally required to authenticate user provided HTTP[S] based software repositories. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightSoftwarerepositoryHttpServerAllOf  -IsPasswordSet null `
 -LocationLink null `
 -Password null `
 -Username null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

