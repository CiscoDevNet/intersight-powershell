# IaasDiagnosticMessagesAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "iaas.DiagnosticMessages"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "iaas.DiagnosticMessages"]
**Category** | **String** | Message category of the alerts. | [optional] [readonly] 
**Guid** | **String** | Unique ID of UCS Director getting registerd with Intersight. | [optional] [readonly] 
**Item** | **String** | Message target type of the alerts. | [optional] [readonly] 
**LastChecked** | **String** | Last checked time of the alerts. | [optional] [readonly] 
**Message** | **String** | Detailed info about the alert. | [optional] [readonly] 
**Recommendation** | **String** | Recommended fix for the alert. | [optional] [readonly] 
**Status** | **String** | Status of the given alert. | [optional] [readonly] 
**StatusId** | **String** | Status Id of the given alert. | [optional] [readonly] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$IaasDiagnosticMessagesAllOf = Initialize-IntersightIaasDiagnosticMessagesAllOf  -ClassId null `
 -ObjectType null `
 -Category null `
 -Guid null `
 -Item null `
 -LastChecked null `
 -Message null `
 -Recommendation null `
 -Status null `
 -StatusId null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$IaasDiagnosticMessagesAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

