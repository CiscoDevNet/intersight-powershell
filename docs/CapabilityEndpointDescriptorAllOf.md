# CapabilityEndpointDescriptorAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. The enum values provides the list of concrete types that can be instantiated from this abstract type. | 
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. The enum values provides the list of concrete types that can be instantiated from this abstract type. | 
**Description** | **String** | Detailed information about the endpoint. | [optional] 
**Model** | **String** | The model of the endpoint, for which this capability information is applicable. | [optional] 
**Vendor** | **String** | The vendor of the endpoint, for which this capability information is applicable. | [optional] 
**Version** | **String** | The firmware or software version of the endpoint, for which this capability information is applicable. | [optional] 
**Capabilities** | [**CapabilityCapabilityRelationship[]**](CapabilityCapabilityRelationship.md) | An array of relationships to capabilityCapability resources. | [optional] 

## Examples

- Prepare the resource
```powershell
$CapabilityEndpointDescriptorAllOf = Initialize-IntersightCapabilityEndpointDescriptorAllOf  -ClassId null `
 -ObjectType null `
 -Description null `
 -Model null `
 -Vendor null `
 -Version null `
 -Capabilities null
```

- Convert the resource to JSON
```powershell
$CapabilityEndpointDescriptorAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

