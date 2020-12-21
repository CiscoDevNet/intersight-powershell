# IamSsoSessionAttributesAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "iam.SsoSessionAttributes"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "iam.SsoSessionAttributes"]
**IdpSessionExpiration** | **String** | SAML SessionNotOnOrAfter attribute sent by IdP in the assertion. IdP uses this to control for how long SP session maybe. SP does not issue SLO if the session is not valid. | [optional] [readonly] 
**IdpSessionIndex** | **String** | SAML SessionIndex attribute sent by IdP in the assertion. This has to be sent back to IdP in LogoutRequest. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$IamSsoSessionAttributesAllOf = Initialize-IntersightIamSsoSessionAttributesAllOf  -ClassId null `
 -ObjectType null `
 -IdpSessionExpiration null `
 -IdpSessionIndex null
```

- Convert the resource to JSON
```powershell
$IamSsoSessionAttributesAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

