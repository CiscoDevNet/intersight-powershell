# ExternalsiteAuthorizationAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsPasswordSet** | **Boolean** | Indicates whether the value of the &#39;password&#39; property has been set. | [optional] [readonly] 
**IsUserIdSet** | **Boolean** | Indicates whether the value of the &#39;userId&#39; property has been set. | [optional] [readonly] 
**Password** | **String** | The password of the given username to download the image from external repository like cisco.com. | [optional] 
**RepositoryType** | **String** | The repository type to which this authorization will be requested. Cisco is the only available repository today. | [optional] [default to "cisco"]
**UserId** | **String** | The username that has permission to download the image from external repository like cisco.com. | [optional] 
**Account** | [**IamAccountRelationship**](IamAccountRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightExternalsiteAuthorizationAllOf  -IsPasswordSet null `
 -IsUserIdSet null `
 -Password null `
 -RepositoryType null `
 -UserId null `
 -Account null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

