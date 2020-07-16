# IamEndPointPasswordProperties
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
**EnablePasswordExpiry** | **Boolean** | Enables password expiry on the endpoint. | [optional] 
**EnforceStrongPassword** | **Boolean** | Enables a strong password policy Strong password requirements: A. The password must have a minimum of 8 and a maximum of 20 characters. B. The password must not contain the User&#39;s Name. C. The password must contain characters from three of the following four categories. 1) English uppercase characters (A through Z). 2) English lowercase characters (a through z). 3) Base 10 digits (0 through 9). 4) Non-alphabetic characters (! , @, #, $, %, ^, &amp;, *, -, _, +, &#x3D;). | [optional] 
**ForceSendPassword** | **Boolean** | User password will always be sent to endpoint device. If the option is not selected, then users password will be sent to endpoint device if password is changed for existing users and for new users. | [optional] 
**GracePeriod** | **Int64** | Time period until when you can use the existing password, after it expires. | [optional] 
**NotificationPeriod** | **Int64** | The duration after which the password will expire. | [optional] 
**PasswordExpiryDuration** | **Int64** | Set time period for password expiration. Value should be greater than notification period and grace period. | [optional] 
**PasswordHistory** | **Int64** | Tracks password change history. Specifies in number of instances, that the new password was already used. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightIamEndPointPasswordProperties  -ClassId null `
 -ObjectType null `
 -EnablePasswordExpiry null `
 -EnforceStrongPassword null `
 -ForceSendPassword null `
 -GracePeriod null `
 -NotificationPeriod null `
 -PasswordExpiryDuration null `
 -PasswordHistory null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

