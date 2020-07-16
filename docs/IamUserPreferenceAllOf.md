# IamUserPreferenceAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Preference** | [**AnyType**](.md) | UI preferences of the user. | [optional] 
**UserUniqueIdentifier** | **String** | Unique id of the user used by the identity provider to store the user. | [optional] [readonly] 
**Idp** | [**IamIdpRelationship**](IamIdpRelationship.md) |  | [optional] 
**IdpReference** | [**IamIdpReferenceRelationship**](IamIdpReferenceRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightIamUserPreferenceAllOf  -Preference null `
 -UserUniqueIdentifier null `
 -Idp null `
 -IdpReference null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

