# TerminalAuditLogAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EndTime** | **System.DateTime** | The time the terminal was closed. If terminal has not closed, value is zero time. | [optional] [readonly] 
**StartTime** | **System.DateTime** | The time the terminal session was opened. | [optional] [readonly] 
**DeviceRegistration** | [**AssetDeviceConnectionRelationship**](AssetDeviceConnectionRelationship.md) |  | [optional] 
**User** | [**IamUserRelationship**](IamUserRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightTerminalAuditLogAllOf  -EndTime null `
 -StartTime null `
 -DeviceRegistration null `
 -User null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

