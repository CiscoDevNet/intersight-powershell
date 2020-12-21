# CapabilityPsuDescriptorAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "capability.PsuDescriptor"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "capability.PsuDescriptor"]
**Revision** | **String** | Revision for the power supply. | [optional] 

## Examples

- Prepare the resource
```powershell
$CapabilityPsuDescriptorAllOf = Initialize-IntersightCapabilityPsuDescriptorAllOf  -ClassId null `
 -ObjectType null `
 -Revision null
```

- Convert the resource to JSON
```powershell
$CapabilityPsuDescriptorAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

