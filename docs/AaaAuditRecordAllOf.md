# AaaAuditRecordAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "aaa.AuditRecord"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "aaa.AuditRecord"]
**Email** | **String** | The email of the associated user that made the change.  In case the user is later deleted, we still have some reference to the information. | [optional] 
**InstId** | **String** | The instance id of AuditRecordLocal, which is used to identify if the comming AuditRecordLocal was already processed before. | [optional] 
**SessionId** | **String** | The sessionId in which the user made the change. In case that the session is later deleted, we still have some reference to the information. | [optional] 
**SourceIp** | **String** | The source IP of the client. | [optional] 
**Timestamp** | **System.DateTime** | The creation time of AuditRecordLocal, which is the time when the affected MO was created/modified/deleted. | [optional] [readonly] 
**UserIdOrEmail** | **String** | The userId or the email of the associated user that made the change. In case that user is later deleted, we still have some reference to the information. | [optional] 
**Account** | [**IamAccountRelationship**](IamAccountRelationship.md) |  | [optional] 
**Sessions** | [**IamSessionRelationship**](IamSessionRelationship.md) |  | [optional] 
**User** | [**IamUserRelationship**](IamUserRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$AaaAuditRecordAllOf = Initialize-IntersightAaaAuditRecordAllOf  -ClassId null `
 -ObjectType null `
 -Email null `
 -InstId null `
 -SessionId null `
 -SourceIp null `
 -Timestamp null `
 -UserIdOrEmail null `
 -Account null `
 -Sessions null `
 -User null
```

- Convert the resource to JSON
```powershell
$AaaAuditRecordAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

