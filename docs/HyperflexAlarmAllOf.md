# HyperflexAlarmAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.Alarm"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.Alarm"]
**Acknowledged** | **Boolean** | The acknowledgement state of the alarm. It is &#39;true&#39; when the alarm is acknowledged and false otherwise. | [optional] [readonly] 
**AcknowledgedBy** | **String** | The username of the user who acknowledged the alarm. | [optional] [readonly] 
**AcknowledgedTime** | **Int64** | The time when the alarm was acknowledged, represented as a Unix timestamp. | [optional] [readonly] 
**AcknowledgedTimeAsUtc** | **String** | The time when the alarm was acknowledged in ISO 6801 format. | [optional] [readonly] 
**Description** | **String** | The description of the alarm which includes information about the fault that triggered the alarm. | [optional] [readonly] 
**EntityData** | **String** | The data pertaining to this entity. | [optional] [readonly] 
**EntityName** | **String** | The name of entity which triggered the alarm. | [optional] [readonly] 
**EntityType** | **String** | The type of entity which triggered the alarm. For example, this can be the cluster, a node, or VM running on the cluster. * &#x60;UNKNOWN&#x60; - The type of entity is not known. * &#x60;DISK&#x60; - The entity is a physical storage device. * &#x60;NODE&#x60; - The entity is a HyperFlex cluster node. * &#x60;CLUSTER&#x60; - The entity is the HyperFlex cluster itself. * &#x60;DATASTORE&#x60; - The entity is a logical datastore configured on the HyperFlex cluster. * &#x60;ZONE&#x60; - The entity is a logical or physical zone configured on the HyperFlex cluster. * &#x60;VIRTUALMACHINE&#x60; - The entity is a virtual machine running on the HyperFlex cluster. | [optional] [readonly] [default to "UNKNOWN"]
**EntityUuId** | **String** | The unique identifier of the entity which triggered the alarm. | [optional] [readonly] 
**Message** | **String** | The localized message displayed to the user which describes the alarm. | [optional] [readonly] 
**Name** | **String** | The name of the alarm. This name identifies the type of alarm that was triggered. | [optional] [readonly] 
**Status** | **String** | The severity of the alarm. * &#x60;UNKNOWN&#x60; - The alarm status is not known. * &#x60;CLEARED&#x60; - The event that triggered the alarm has been remedied and no longer requires the user&#39;s attention. * &#x60;INFO&#x60; - The alarm represents a message that does not require the user&#39;s immediate attention. * &#x60;WARNING&#x60; - The alarm represents a moderate fault. * &#x60;CRITICAL&#x60; - The alarm represents a critical fault. | [optional] [readonly] [default to "UNKNOWN"]
**TriggeredTime** | **Int64** | The time when alarm was triggered as a Unix timestamp. | [optional] [readonly] 
**TriggeredTimeAsUtc** | **String** | The time when alarm was triggered in ISO 6801 UTC format. | [optional] [readonly] 
**Uuid** | **String** | The unique identifier for this alarm instance. | [optional] [readonly] 
**Cluster** | [**HyperflexClusterRelationship**](HyperflexClusterRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$HyperflexAlarmAllOf = Initialize-IntersightHyperflexAlarmAllOf  -ClassId null `
 -ObjectType null `
 -Acknowledged null `
 -AcknowledgedBy null `
 -AcknowledgedTime null `
 -AcknowledgedTimeAsUtc null `
 -Description null `
 -EntityData null `
 -EntityName null `
 -EntityType null `
 -EntityUuId null `
 -Message null `
 -Name null `
 -Status null `
 -TriggeredTime null `
 -TriggeredTimeAsUtc null `
 -Uuid null `
 -Cluster null
```

- Convert the resource to JSON
```powershell
$HyperflexAlarmAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

