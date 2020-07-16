# IamSsoSessionAttributesAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IdpSessionExpiration** | **String** | SAML SessionNotOnOrAfter attribute sent by IdP in the assertion. IdP uses this to control for how long SP session maybe. SP does not issue SLO if the session is not valid. | [optional] [readonly] 
**IdpSessionIndex** | **String** | SAML SessionIndex attribute sent by IdP in the assertion. This has to be sent back to IdP in LogoutRequest. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightIamSsoSessionAttributesAllOf  -IdpSessionExpiration null `
 -IdpSessionIndex null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

