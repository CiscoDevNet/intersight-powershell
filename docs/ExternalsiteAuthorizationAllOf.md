# ExternalsiteAuthorizationAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "externalsite.Authorization"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "externalsite.Authorization"]
**IsPasswordSet** | **Boolean** | Indicates whether the value of the &#39;password&#39; property has been set. | [optional] [readonly] [default to $false]
**IsUserIdSet** | **Boolean** | Indicates whether the value of the &#39;userId&#39; property has been set. | [optional] [readonly] [default to $false]
**Password** | **String** | The password of the given username to download the image from external repository like cisco.com. | [optional] 
**RepositoryType** | **String** | The repository type to which this authorization will be requested. Cisco is the only available repository today. * &#x60;cisco&#x60; - Cisco as an external site from where the resources like image will be downloaded. | [optional] [default to "cisco"]
**UserId** | **String** | The username that has permission to download the image from external repository like cisco.com. | [optional] 
**Account** | [**IamAccountRelationship**](IamAccountRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ExternalsiteAuthorizationAllOf = Initialize-IntersightExternalsiteAuthorizationAllOf  -ClassId null `
 -ObjectType null `
 -IsPasswordSet null `
 -IsUserIdSet null `
 -Password null `
 -RepositoryType null `
 -UserId null `
 -Account null
```

- Convert the resource to JSON
```powershell
$ExternalsiteAuthorizationAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

