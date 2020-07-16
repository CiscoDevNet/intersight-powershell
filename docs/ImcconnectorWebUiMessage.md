# ImcconnectorWebUiMessage
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
**EncryptedAesKey** | **String** | The secure properties that have large text content as value can be encrypted using AES key. In these cases, the AES key needs to be encrypted using the device connector public key and passed as the value for this property. The secure properties that are encrypted using the AES key are mapped against the property name with prefix &#39;AES&#39; in SecureProperties dictionary. | [optional] 
**EncryptionKey** | **String** | The public key that was used to encrypt the values present in SecureProperties dictionary. If the given public key is not same as device connector&#39;s public key, an error reponse with appropriate error message is thrown back. | [optional] 
**SecureProperties** | [**AnyType**](.md) | A dictionary of encrypted secure values mapped against the secure property name. The values that are encrypted using AES key must be mapped against the secure property name with a &#39;AES&#39; prefix Device connector expects the message body to be a golang template and the template can use the secure property names as placeholders. | [optional] 
**RemoteUserLocale** | **String** | The platform locale to assign user. A locale defines one or more organizations (domains) the user is allowed access, and access is limited to the organizations specified in the locale. | [optional] 
**RemoteUserName** | **String** | The user name passed to the platform for use in platform audit logs. | [optional] 
**RemoteUserRoles** | **String** | The list of roles to pass to the platform to validate the action against. | [optional] 
**RemoteUserSessionId** | **String** | The session Id passed to the platform for use in platforms auditing. | [optional] 
**WebUiRequest** | **String** | The body content of the UI HTTP request to send to the BMC platform. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightImcconnectorWebUiMessage  -ClassId null `
 -ObjectType null `
 -EncryptedAesKey null `
 -EncryptionKey null `
 -SecureProperties null `
 -RemoteUserLocale null `
 -RemoteUserName null `
 -RemoteUserRoles null `
 -RemoteUserSessionId null `
 -WebUiRequest null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

