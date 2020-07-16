# ComputeBladeIdentityAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ChassisId** | **Int64** | Chassis Identifier of a blade server. | [optional] 
**DeviceMoId** | **String** | FI Device registration Mo ID. | [optional] 
**PendingDiscovery** | **String** | Indicates pending discovery flag. | [optional] 
**SlotId** | **Int64** | Chassis slot number of a blade server. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightComputeBladeIdentityAllOf  -ChassisId null `
 -DeviceMoId null `
 -PendingDiscovery null `
 -SlotId null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

