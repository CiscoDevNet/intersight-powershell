# FaultInstanceAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Acknowledged** | **String** | The user acknowledgement state of the fault. | [optional] [readonly] 
**AffectedDn** | **String** | The Distinguished Name of the Managed object which was affected. | [optional] [readonly] 
**AffectedMoId** | **String** | Managed object Id which was affected. | [optional] [readonly] 
**AffectedMoType** | **String** | Managed object type which was affected. | [optional] [readonly] 
**AncestorMoId** | **String** | Object Id of the parent of the Managed object which was affected. | [optional] [readonly] 
**AncestorMoType** | **String** | Object type of the parent of the Managed object which was affected. | [optional] [readonly] 
**Code** | **String** | Numerical fault code of the fault found. | [optional] [readonly] 
**CreationTime** | **String** | The time of creation of the fault instance. | [optional] [readonly] 
**Description** | **String** | Detailed message of the fault. | [optional] [readonly] 
**LastTransitionTime** | **String** | Last transition time of the fault. | [optional] [readonly] 
**NumOccurrences** | **Int64** | The number of times this fault has occured. | [optional] [readonly] 
**OriginalSeverity** | **String** | Current Severity of the fault found. | [optional] [readonly] 
**PreviousSeverity** | **String** | The Severity of the fault prior to user update. | [optional] [readonly] 
**Rule** | **String** | The rule that is responsible for generation of the fault. | [optional] [readonly] 
**Severity** | **String** | Severity of the fault found. | [optional] [readonly] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightFaultInstanceAllOf  -Acknowledged null `
 -AffectedDn null `
 -AffectedMoId null `
 -AffectedMoType null `
 -AncestorMoId null `
 -AncestorMoType null `
 -Code null `
 -CreationTime null `
 -Description null `
 -LastTransitionTime null `
 -NumOccurrences null `
 -OriginalSeverity null `
 -PreviousSeverity null `
 -Rule null `
 -Severity null `
 -InventoryDeviceInfo null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

