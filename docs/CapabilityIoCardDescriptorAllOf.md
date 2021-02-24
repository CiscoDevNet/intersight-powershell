# CapabilityIoCardDescriptorAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "capability.IoCardDescriptor"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "capability.IoCardDescriptor"]
**NumHifPorts** | **Int64** | Number of hif ports per blade for the iocard module. | [optional] 
**Revision** | **String** | Revision for the iocard module. | [optional] 
**UifConnectivity** | **String** | Connectivity information between UIF Uplink ports and IOM ports. * &#x60;inline&#x60; - UIF uplink ports and IOM ports are connected inline. * &#x60;cross-connected&#x60; - UIF uplink ports and IOM ports are cross-connected, a case in washington chassis. | [optional] [default to "inline"]

## Examples

- Prepare the resource
```powershell
$CapabilityIoCardDescriptorAllOf = Initialize-IntersightCapabilityIoCardDescriptorAllOf  -ClassId null `
 -ObjectType null `
 -NumHifPorts null `
 -Revision null `
 -UifConnectivity null
```

- Convert the resource to JSON
```powershell
$CapabilityIoCardDescriptorAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

