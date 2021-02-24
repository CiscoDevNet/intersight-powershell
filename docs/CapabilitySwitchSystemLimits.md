# CapabilitySwitchSystemLimits
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "capability.SwitchSystemLimits"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "capability.SwitchSystemLimits"]
**MaximumChassisCount** | **Int64** | Maximum UCS chassis that can be connected to this Switch/Fabric-Interconnect. | [optional] 
**MaximumFexPerDomain** | **Int64** | Maximum UCS Fabric-extenders (FEX) per Switch/Fabric-Interconnect. | [optional] 
**MaximumServersPerDomain** | **Int64** | Maximum UCS servers per Switch/Fabric-Interconnect. | [optional] 

## Examples

- Prepare the resource
```powershell
$CapabilitySwitchSystemLimits = Initialize-IntersightCapabilitySwitchSystemLimits  -ClassId null `
 -ObjectType null `
 -MaximumChassisCount null `
 -MaximumFexPerDomain null `
 -MaximumServersPerDomain null
```

- Convert the resource to JSON
```powershell
$CapabilitySwitchSystemLimits | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

