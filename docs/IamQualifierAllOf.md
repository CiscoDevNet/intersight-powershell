# IamQualifierAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "iam.Qualifier"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "iam.Qualifier"]
**Name** | **String** | The name of the SAML attribute used to qualify a user to user group. By default this is memberOf attribute in SAML assertion. | [optional] [readonly] 
**Value** | **String[]** |  | [optional] 
**Usergroup** | [**IamUserGroupRelationship**](IamUserGroupRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$IamQualifierAllOf = Initialize-IntersightIamQualifierAllOf  -ClassId null `
 -ObjectType null `
 -Name null `
 -Value null `
 -Usergroup null
```

- Convert the resource to JSON
```powershell
$IamQualifierAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

