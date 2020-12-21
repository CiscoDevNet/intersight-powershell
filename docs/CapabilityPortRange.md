# CapabilityPortRange
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "capability.PortRange"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "capability.PortRange"]
**EndPortId** | **Int64** | Ending Port ID in this range of ports. | [optional] 
**EndSlotId** | **Int64** | Ending Slot ID in this range of ports. | [optional] 
**StartPortId** | **Int64** | Starting Port ID in this range of ports. | [optional] 
**StartSlotId** | **Int64** | Starting Slot ID in this range of ports. | [optional] 

## Examples

- Prepare the resource
```powershell
$CapabilityPortRange = Initialize-IntersightCapabilityPortRange  -ClassId null `
 -ObjectType null `
 -EndPortId null `
 -EndSlotId null `
 -StartPortId null `
 -StartSlotId null
```

- Convert the resource to JSON
```powershell
$CapabilityPortRange | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

