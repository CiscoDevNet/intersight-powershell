# IamEndPointPasswordPropertiesAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "iam.EndPointPasswordProperties"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "iam.EndPointPasswordProperties"]
**EnablePasswordExpiry** | **Boolean** | Enables password expiry on the endpoint. | [optional] [default to $false]
**EnforceStrongPassword** | **Boolean** | Enables a strong password policy. Strong password requirements: A. The password must have a minimum of 8 and a maximum of 20 characters. B. The password must not contain the User&#39;s Name. C. The password must contain characters from three of the following four categories. 1) English uppercase characters (A through Z). 2) English lowercase characters (a through z). 3) Base 10 digits (0 through 9). 4) Non-alphabetic characters (! , @, #, $, %, ^, &amp;, *, -, _, +, &#x3D;). | [optional] [default to $true]
**ForceSendPassword** | **Boolean** | User password will always be sent to endpoint device. If the option is not selected, then user password will be sent to endpoint device for new users and if user password is changed for existing users. | [optional] [default to $false]
**GracePeriod** | **Int64** | Time period until when you can use the existing password, after it expires. | [optional] [default to 0]
**NotificationPeriod** | **Int64** | The duration after which the password will expire. | [optional] [default to 15]
**PasswordExpiryDuration** | **Int64** | Set time period for password expiration. Value should be greater than notification period and grace period. | [optional] [default to 90]
**PasswordHistory** | **Int64** | Tracks password change history. Specifies in number of instances, that the new password was already used. | [optional] [default to 5]

## Examples

- Prepare the resource
```powershell
$IamEndPointPasswordPropertiesAllOf = Initialize-IntersightIamEndPointPasswordPropertiesAllOf  -ClassId null `
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
$IamEndPointPasswordPropertiesAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

