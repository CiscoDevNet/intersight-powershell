# CondAlarm
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "cond.Alarm"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "cond.Alarm"]
**AccountMoid** | **String** | The Account ID for this managed object. | [optional] [readonly] 
**CreateTime** | **System.DateTime** | The time when this managed object was created. | [optional] [readonly] 
**DomainGroupMoid** | **String** | The DomainGroup ID for this managed object. | [optional] [readonly] 
**ModTime** | **System.DateTime** | The time when this managed object was last modified. | [optional] [readonly] 
**Moid** | **String** | The unique identifier of this Managed Object instance. | [optional] 
**Owners** | **String[]** |  | [optional] 
**SharedScope** | **String** | Intersight provides pre-built workflows, tasks and policies to end users through global catalogs. Objects that are made available through global catalogs are said to have a &#39;shared&#39; ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs. | [optional] [readonly] 
**Tags** | [**MoTag[]**](MoTag.md) |  | [optional] 
**VersionContext** | [**MoVersionContext**](MoVersionContext.md) |  | [optional] 
**Ancestors** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**Parent** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 
**PermissionResources** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**DisplayNames** | [**System.Collections.Hashtable**](Array.md) | A set of display names for the MO resource. These names are calculated based on other properties of the MO and potentially properties of Ancestor MOs. Displaynames are intended as a way to provide a normalized user appropriate name for an MO, especially for MOs which do not have a &#39;Name&#39; property, which is the case for much of the inventory discovered from managed targets. There are a limited number of keys, currently &#39;short&#39; and &#39;hierarchical&#39;. The value is an array and clients should use the first element of the array. | [optional] [readonly] 
**Acknowledge** | **String** | Alarm acknowledgment state. Default value is None. * &#x60;None&#x60; - The Enum value None represents that the alarm is not acknowledged and is included as part of health status and overall alarm count. * &#x60;Acknowledge&#x60; - The Enum value Acknowledge represents that the alarm is acknowledged by user. The alarm will be ignored from the health status and overall alarm count. | [optional] [default to "None"]
**AcknowledgeBy** | **String** | User who acknowledged the alarm. | [optional] [readonly] 
**AcknowledgeTime** | **System.DateTime** | Time at which the alarm was acknowledged by the user. | [optional] [readonly] 
**AffectedMoDisplayName** | **String** | Display name of the affected object on which the alarm is raised. The name uniquely identifies an alarm target such that it can be distinguished from similar objects managed by Intersight. | [optional] [readonly] 
**AffectedMoId** | **String** | MoId of the affected object from the managed system&#39;s point of view. | [optional] [readonly] 
**AffectedMoType** | **String** | Managed system affected object type. For example Adaptor, FI, CIMC. | [optional] [readonly] 
**AffectedObject** | **String** | A unique key for an alarm instance, consists of a combination of a unique system name and msAffectedObject. | [optional] [readonly] 
**AncestorMoId** | **String** | Parent MoId of the fault from managed system. For example, Blade moid for adaptor fault. | [optional] [readonly] 
**AncestorMoType** | **String** | Parent MO type of the fault from managed system. For example, Blade for adaptor fault. | [optional] [readonly] 
**Code** | **String** | A unique alarm code. For alarms mapped from UCS faults, this will be the same as the UCS fault code. | [optional] [readonly] 
**CreationTime** | **System.DateTime** | The time the alarm was created. | [optional] [readonly] 
**Description** | **String** | A longer description of the alarm than the name. The description contains details of the component reporting the issue. | [optional] [readonly] 
**LastTransitionTime** | **System.DateTime** | The time the alarm last had a change in severity. | [optional] [readonly] 
**MsAffectedObject** | **String** | A unique key for the alarm from the managed system&#39;s point of view. For example, in the case of UCS, this is the fault&#39;s dn. | [optional] [readonly] 
**Name** | **String** | Uniquely identifies the type of alarm. For alarms originating from Intersight, this will be a descriptive name. For alarms that are mapped from faults, the name will be derived from fault properties. For example, alarms mapped from UCS faults will use a prefix of UCS and appended with the fault code. | [optional] [readonly] 
**OrigSeverity** | **String** | The original severity when the alarm was first created. * &#x60;None&#x60; - The Enum value None represents that there is no severity. * &#x60;Info&#x60; - The Enum value Info represents the Informational level of severity. * &#x60;Critical&#x60; - The Enum value Critical represents the Critical level of severity. * &#x60;Warning&#x60; - The Enum value Warning represents the Warning level of severity. * &#x60;Cleared&#x60; - The Enum value Cleared represents that the alarm severity has been cleared. | [optional] [readonly] [default to "None"]
**Severity** | **String** | The severity of the alarm. Valid values are Critical, Warning, Info, and Cleared. * &#x60;None&#x60; - The Enum value None represents that there is no severity. * &#x60;Info&#x60; - The Enum value Info represents the Informational level of severity. * &#x60;Critical&#x60; - The Enum value Critical represents the Critical level of severity. * &#x60;Warning&#x60; - The Enum value Warning represents the Warning level of severity. * &#x60;Cleared&#x60; - The Enum value Cleared represents that the alarm severity has been cleared. | [optional] [readonly] [default to "None"]
**AffectedMo** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$CondAlarm = Initialize-IntersightCondAlarm  -ClassId null `
 -ObjectType null `
 -AccountMoid null `
 -CreateTime null `
 -DomainGroupMoid null `
 -ModTime null `
 -Moid null `
 -Owners null `
 -SharedScope null `
 -Tags null `
 -VersionContext null `
 -Ancestors null `
 -Parent null `
 -PermissionResources null `
 -DisplayNames null `
 -Acknowledge null `
 -AcknowledgeBy null `
 -AcknowledgeTime null `
 -AffectedMoDisplayName null `
 -AffectedMoId null `
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
 -AffectedMo null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$CondAlarm | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

