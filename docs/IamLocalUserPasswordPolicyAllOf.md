# IamLocalUserPasswordPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "iam.LocalUserPasswordPolicy"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "iam.LocalUserPasswordPolicy"]
**MinCharDifference** | **Int64** | Minimum number of characters different from previous password. | [optional] [default to 0]
**MinDaysBetweenPasswordChange** | **Int64** | Minimum Days allowed between password change. | [optional] [default to 0]
**MinLengthPassword** | **Int64** | Minimum length of password. | [optional] [default to 8]
**MinLowerCase** | **Int64** | Minimum number of required lower case characters. | [optional] [default to 1]
**MinNumeric** | **Int64** | Minimum number of required numeric characters. | [optional] [default to 1]
**MinSpecialChar** | **Int64** | Minimum number of required special characters. | [optional] [default to 0]
**MinUpperCase** | **Int64** | Minimum number of required upper case characters. | [optional] [default to 1]
**NumPreviousPasswordsDisallowed** | **Int64** | Number of previous passwords disallowed. | [optional] [default to 0]
**Account** | [**IamAccountRelationship**](IamAccountRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$IamLocalUserPasswordPolicyAllOf = Initialize-IntersightIamLocalUserPasswordPolicyAllOf  -ClassId null `
 -ObjectType null `
 -MinCharDifference null `
 -MinDaysBetweenPasswordChange null `
 -MinLengthPassword null `
 -MinLowerCase null `
 -MinNumeric null `
 -MinSpecialChar null `
 -MinUpperCase null `
 -NumPreviousPasswordsDisallowed null `
 -Account null
```

- Convert the resource to JSON
```powershell
$IamLocalUserPasswordPolicyAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

