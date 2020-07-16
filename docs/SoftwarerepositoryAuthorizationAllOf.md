# SoftwarerepositoryAuthorizationAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsPasswordSet** | **Boolean** | Indicates whether the value of the &#39;password&#39; property has been set. | [optional] [readonly] 
**IsUserIdSet** | **Boolean** | Indicates whether the value of the &#39;userId&#39; property has been set. | [optional] [readonly] 
**Password** | **String** | The password that will be used by Intersight to create OAuth2 tokens for interacting with the external repository, on the user account&#39;s behalf. | [optional] 
**RepositoryType** | **String** | The external repository for which this authorization has been provided. The only supported repository today is cisco.com. | [optional] [default to "Cisco"]
**UserId** | **String** | The username that will be used by Intersight to create OAuth2 tokens for interacting with the external repository, on the user account&#39;s behalf. | [optional] 
**Account** | [**IamAccountRelationship**](IamAccountRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightSoftwarerepositoryAuthorizationAllOf  -IsPasswordSet null `
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

