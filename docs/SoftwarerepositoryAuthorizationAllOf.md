# SoftwarerepositoryAuthorizationAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "softwarerepository.Authorization"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "softwarerepository.Authorization"]
**IsPasswordSet** | **Boolean** | Indicates whether the value of the &#39;password&#39; property has been set. | [optional] [readonly] [default to $false]
**IsUserIdSet** | **Boolean** | Indicates whether the value of the &#39;userId&#39; property has been set. | [optional] [readonly] [default to $false]
**Password** | **String** | The password that will be used by Intersight to create OAuth2 tokens for interacting with the external repository, on the user account&#39;s behalf. | [optional] 
**RepositoryType** | **String** | The external repository for which this authorization has been provided. The only supported repository today is cisco.com. * &#x60;Cisco&#x60; - External repository hosted on cisco.com. * &#x60;IntersightCloud&#x60; - Repository hosted by the Intersight Cloud. * &#x60;LocalMachine&#x60; - The file is available on the local client machine. Used as an upload source type. * &#x60;NetworkShare&#x60; - External repository in the customer datacenter. This will typically be a file server. | [optional] [default to "Cisco"]
**UserId** | **String** | The username that will be used by Intersight to create OAuth2 tokens for interacting with the external repository, on the user account&#39;s behalf. | [optional] 
**Account** | [**IamAccountRelationship**](IamAccountRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$SoftwarerepositoryAuthorizationAllOf = Initialize-IntersightSoftwarerepositoryAuthorizationAllOf  -ClassId null `
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
$SoftwarerepositoryAuthorizationAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

