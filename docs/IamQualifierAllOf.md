# IamQualifierAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **String** | The name of the SAML attribute used to qualify a user to user group. By default this is memberOf attribute in SAML assertion. | [optional] [readonly] 
**Value** | **String[]** |  | [optional] 
**Usergroup** | [**IamUserGroupRelationship**](IamUserGroupRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightIamQualifierAllOf  -Name null `
 -Value null `
 -Usergroup null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

