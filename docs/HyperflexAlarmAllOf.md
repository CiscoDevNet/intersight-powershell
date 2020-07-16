# HyperflexAlarmAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Acknowledged** | **Boolean** |  | [optional] [readonly] 
**AcknowledgedBy** | **String** |  | [optional] [readonly] 
**AcknowledgedTime** | **Int64** |  | [optional] [readonly] 
**AcknowledgedTimeAsUtc** | **String** |  | [optional] [readonly] 
**Description** | **String** |  | [optional] [readonly] 
**EntityData** | **String** |  | [optional] [readonly] 
**EntityName** | **String** |  | [optional] [readonly] 
**EntityType** | **String** |  | [optional] [readonly] [default to "UNKNOWN"]
**EntityUuId** | **String** |  | [optional] [readonly] 
**Message** | **String** |  | [optional] [readonly] 
**Name** | **String** |  | [optional] [readonly] 
**Status** | **String** |  | [optional] [readonly] [default to "UNKNOWN"]
**TriggeredTime** | **Int64** |  | [optional] [readonly] 
**TriggeredTimeAsUtc** | **String** |  | [optional] [readonly] 
**Uuid** | **String** |  | [optional] [readonly] 
**Cluster** | [**HyperflexClusterRelationship**](HyperflexClusterRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightHyperflexAlarmAllOf  -Acknowledged null `
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
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

