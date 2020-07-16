# CapabilityEndpointDescriptorAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **String** | Detailed information about the endpoint. | [optional] 
**Model** | **String** | The model of the endpoint, for which this capability information is applicable. | [optional] 
**Vendor** | **String** | The vendor of the endpoint, for which this capability information is applicable. | [optional] 
**Version** | **String** | The firmware or software version of the endpoint, for which this capability information is applicable. | [optional] 
**Capabilities** | [**CapabilityCapabilityRelationship[]**](CapabilityCapabilityRelationship.md) | An array of relationships to capabilityCapability resources. | [optional] 
**Section** | [**CapabilitySectionRelationship**](CapabilitySectionRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightCapabilityEndpointDescriptorAllOf  -Description null `
 -Model null `
 -Vendor null `
 -Version null `
 -Capabilities null `
 -Section null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

