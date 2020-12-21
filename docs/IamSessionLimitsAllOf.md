# IamSessionLimitsAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "iam.SessionLimits"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "iam.SessionLimits"]
**IdleTimeOut** | **Int64** | The idle timeout interval for the web session in seconds. When a session is not refreshed for this duration, the session is marked as idle and removed. The minimum value is 300 seconds and the maximum value is 18000 seconds (5 hours). The system default value is 1800 seconds. | [optional] [default to 1800]
**MaximumLimit** | **Int64** | The maximum number of sessions allowed in an account. The default value is 128. | [optional] [readonly] [default to 128]
**PerUserLimit** | **Int64** | The maximum number of sessions allowed per user. Default value is 32. | [optional] [default to 32]
**SessionTimeOut** | **Int64** | The session expiry duration in seconds. The minimum value is 350 seconds and the maximum value is 31536000 seconds (1 year). The system default value is 57600 seconds. | [optional] [default to 57600]
**Account** | [**IamAccountRelationship**](IamAccountRelationship.md) |  | [optional] 
**Permission** | [**IamPermissionRelationship**](IamPermissionRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$IamSessionLimitsAllOf = Initialize-IntersightIamSessionLimitsAllOf  -ClassId null `
 -ObjectType null `
 -IdleTimeOut null `
 -MaximumLimit null `
 -PerUserLimit null `
 -SessionTimeOut null `
 -Account null `
 -Permission null
```

- Convert the resource to JSON
```powershell
$IamSessionLimitsAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

