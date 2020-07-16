# IamSessionLimitsAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IdleTimeOut** | **Int64** | The idle timeout interval for the web session in seconds. When a session is not refreshed for this duration, the session is marked as idle and removed. | [optional] 
**MaximumLimit** | **Int64** | The maximum number of sessions allowed in an account. The default value is 128. | [optional] [readonly] 
**PerUserLimit** | **Int64** | The maximum number of sessions allowed per user. Default value is 32. | [optional] [readonly] 
**SessionTimeOut** | **Int64** | The session expiry duration in seconds. | [optional] 
**Account** | [**IamAccountRelationship**](IamAccountRelationship.md) |  | [optional] 
**Permission** | [**IamPermissionRelationship**](IamPermissionRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightIamSessionLimitsAllOf  -IdleTimeOut null `
 -MaximumLimit null `
 -PerUserLimit null `
 -SessionTimeOut null `
 -Account null `
 -Permission null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

