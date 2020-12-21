# IamUserPreferenceAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "iam.UserPreference"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "iam.UserPreference"]
**Preference** | [**AnyType**](.md) | UI preferences of the user. | [optional] 
**UserUniqueIdentifier** | **String** | Unique id of the user used by the identity provider to store the user. | [optional] [readonly] 
**Idp** | [**IamIdpRelationship**](IamIdpRelationship.md) |  | [optional] 
**IdpReference** | [**IamIdpReferenceRelationship**](IamIdpReferenceRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$IamUserPreferenceAllOf = Initialize-IntersightIamUserPreferenceAllOf  -ClassId null `
 -ObjectType null `
 -Preference null `
 -UserUniqueIdentifier null `
 -Idp null `
 -IdpReference null
```

- Convert the resource to JSON
```powershell
$IamUserPreferenceAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

