# CapabilitySwitchDescriptorAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "capability.SwitchDescriptor"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "capability.SwitchDescriptor"]
**ExpectedMemory** | **Int64** | The total expected memory for this hardware. | [optional] 
**Revision** | **String** | Revision for the fabric interconnect. | [optional] 

## Examples

- Prepare the resource
```powershell
$CapabilitySwitchDescriptorAllOf = Initialize-IntersightCapabilitySwitchDescriptorAllOf  -ClassId null `
 -ObjectType null `
 -ExpectedMemory null `
 -Revision null
```

- Convert the resource to JSON
```powershell
$CapabilitySwitchDescriptorAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

