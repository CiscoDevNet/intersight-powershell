# TerminalAuditLogAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "terminal.AuditLog"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "terminal.AuditLog"]
**EndTime** | **System.DateTime** | The time the terminal was closed. If terminal has not closed, value is zero time. | [optional] [readonly] 
**StartTime** | **System.DateTime** | The time the terminal session was opened. | [optional] [readonly] 
**DeviceRegistration** | [**AssetDeviceConnectionRelationship**](AssetDeviceConnectionRelationship.md) |  | [optional] 
**User** | [**IamUserRelationship**](IamUserRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$TerminalAuditLogAllOf = Initialize-IntersightTerminalAuditLogAllOf  -ClassId null `
 -ObjectType null `
 -EndTime null `
 -StartTime null `
 -DeviceRegistration null `
 -User null
```

- Convert the resource to JSON
```powershell
$TerminalAuditLogAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

