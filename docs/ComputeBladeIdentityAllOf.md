# ComputeBladeIdentityAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "compute.BladeIdentity"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "compute.BladeIdentity"]
**ChassisId** | **Int64** | Chassis Identifier of a blade server. | [optional] [readonly] 
**FirmwareSupportability** | **String** | Describes whether the running CIMC version supports Intersight managed mode. * &#x60;Unknown&#x60; - The running firmware version is unknown. * &#x60;Supported&#x60; - The running firmware version is known and supports IMM mode. * &#x60;NotSupported&#x60; - The running firmware version is known and does not support IMM mode. | [optional] [readonly] [default to "Unknown"]
**Presence** | **String** | The presence state of the blade server. * &#x60;Unknown&#x60; - The default presence state. * &#x60;Equipped&#x60; - The server is equipped in the slot. * &#x60;EquippedMismatch&#x60; - The slot is equipped, but there is another server currently inventoried in the slot. * &#x60;Missing&#x60; - The server is not present in the given slot. | [optional] [readonly] [default to "Unknown"]
**SlotId** | **Int64** | Chassis slot number of a blade server. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$ComputeBladeIdentityAllOf = Initialize-IntersightComputeBladeIdentityAllOf  -ClassId null `
 -ObjectType null `
 -ChassisId null `
 -FirmwareSupportability null `
 -Presence null `
 -SlotId null
```

- Convert the resource to JSON
```powershell
$ComputeBladeIdentityAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

