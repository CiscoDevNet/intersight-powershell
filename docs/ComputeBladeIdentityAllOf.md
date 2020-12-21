# ComputeBladeIdentityAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "compute.BladeIdentity"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "compute.BladeIdentity"]
**ChassisId** | **Int64** | Chassis Identifier of a blade server. | [optional] 
**DeviceMoId** | **String** | FI Device registration Mo ID. | [optional] 
**SlotId** | **Int64** | Chassis slot number of a blade server. | [optional] 

## Examples

- Prepare the resource
```powershell
$ComputeBladeIdentityAllOf = Initialize-IntersightComputeBladeIdentityAllOf  -ClassId null `
 -ObjectType null `
 -ChassisId null `
 -DeviceMoId null `
 -SlotId null
```

- Convert the resource to JSON
```powershell
$ComputeBladeIdentityAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

