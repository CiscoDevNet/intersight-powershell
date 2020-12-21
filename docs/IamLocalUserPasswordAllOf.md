# IamLocalUserPasswordAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "iam.LocalUserPassword"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "iam.LocalUserPassword"]
**CurrentPassword** | **String** | User-entered passsord to be compared to password for change password function. | [optional] 
**IsCurrentPasswordSet** | **Boolean** | Indicates whether the value of the &#39;currentPassword&#39; property has been set. | [optional] [readonly] [default to $false]
**IsNewPasswordSet** | **Boolean** | Indicates whether the value of the &#39;newPassword&#39; property has been set. | [optional] [readonly] [default to $false]
**NewPassword** | **String** | New password that the user&#39;s password should be changed to. | [optional] 
**Password** | [**SystemByte**](SystemByte.md) | User&#39;s current valid passsord. | [optional] 
**User** | [**IamUserRelationship**](IamUserRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$IamLocalUserPasswordAllOf = Initialize-IntersightIamLocalUserPasswordAllOf  -ClassId null `
 -ObjectType null `
 -CurrentPassword null `
 -IsCurrentPasswordSet null `
 -IsNewPasswordSet null `
 -NewPassword null `
 -Password null `
 -User null
```

- Convert the resource to JSON
```powershell
$IamLocalUserPasswordAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

