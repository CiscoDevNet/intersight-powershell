# SoftwarerepositoryHttpServerAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "softwarerepository.HttpServer"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "softwarerepository.HttpServer"]
**IsPasswordSet** | **Boolean** | Indicates whether the value of the &#39;password&#39; property has been set. | [optional] [readonly] [default to $false]
**LocationLink** | **String** | HTTP/HTTPS link to the image. Accepted formats are HTTP[s]://server-hostname/share/image or HTTP[s]://serverip/share/image. | [optional] 
**Password** | **String** | Password as configured on the HTTP[S] server for user authentication. It is generally required to authenticate user provided HTTP[S] based software repositories. | [optional] 
**Username** | **String** | Username as configured on the HTTP[S] server for user authentication. It is generally required to authenticate user provided HTTP[S] based software repositories. | [optional] 

## Examples

- Prepare the resource
```powershell
$SoftwarerepositoryHttpServerAllOf = Initialize-IntersightSoftwarerepositoryHttpServerAllOf  -ClassId null `
 -ObjectType null `
 -IsPasswordSet null `
 -LocationLink null `
 -Password null `
 -Username null
```

- Convert the resource to JSON
```powershell
$SoftwarerepositoryHttpServerAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

