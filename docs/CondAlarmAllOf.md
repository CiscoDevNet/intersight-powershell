# CondAlarmAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AffectedMoId** | **String** | MoId of the affected object from the managed system&#39;s point of view. | [optional] 
**AffectedMoType** | **String** | Managed system affected object type. For example Adaptor, FI, CIMC. | [optional] 
**AffectedObject** | **String** | A unique key for an alarm instance, consists of a combination of a unique system name and msAffectedObject. | [optional] 
**AncestorMoId** | **String** | Parent MoId of the fault from managed system. For example, Blade moid for adaptor fault. | [optional] 
**AncestorMoType** | **String** | Parent MO type of the fault from managed system. For example, Blade for adaptor fault. | [optional] 
**Code** | **String** | A unique alarm code. For alarms mapped from UCS faults, this will be the same as the UCS fault code. | [optional] 
**CreationTime** | **System.DateTime** | The time the alarm was created. | [optional] 
**Description** | **String** | A longer description of the alarm than the name. The description contains details of the component reporting the issue. | [optional] 
**LastTransitionTime** | **System.DateTime** | The time the alarm last had a change in severity. | [optional] 
**MsAffectedObject** | **String** | A unique key for the alarm from the managed system&#39;s point of view. For example, in the case of UCS, this is the fault&#39;s dn. | [optional] 
**Name** | **String** | Uniquely identifies the type of alarm. For alarms originating from Intersight, this will be a descriptive name. For alarms that are mapped from faults, the name will be derived from fault properties. For example, alarms mapped from UCS faults will use a prefix of UCS and appended with the fault code. | [optional] 
**OrigSeverity** | **String** | The original severity when the alarm was first created. | [optional] [default to "None"]
**Severity** | **String** | The severity of the alarm. Valid values are Critical, Warning, Info, and Cleared. | [optional] [default to "None"]
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightCondAlarmAllOf  -AffectedMoId null `
 -AffectedMoType null `
 -AffectedObject null `
 -AncestorMoId null `
 -AncestorMoType null `
 -Code null `
 -CreationTime null `
 -Description null `
 -LastTransitionTime null `
 -MsAffectedObject null `
 -Name null `
 -OrigSeverity null `
 -Severity null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

