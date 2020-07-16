# IamLocalUserPasswordAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CurrentPassword** | **String** | User-entered passsord to be compared to password for change password function. | [optional] 
**NewPassword** | **String** | New password that the user&#39;s password should be changed to. | [optional] 
**Password** | [**SystemByte**](SystemByte.md) | User&#39;s current valid passsord. | [optional] 
**User** | [**IamUserRelationship**](IamUserRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightIamLocalUserPasswordAllOf  -CurrentPassword null `
 -NewPassword null `
 -Password null `
 -User null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

