# CapabilitySwitchStorageLimitsAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "capability.SwitchStorageLimits"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "capability.SwitchStorageLimits"]
**MaximumUserZoneCount** | **Int64** | Maximum user zones per Switch/Fabric-Interconnect. | [optional] 
**MaximumVirtualFcInterfaces** | **Int64** | Maximum configurable Virtual Fibre Channel interfaces on Switch/Fabric-Interconnect. | [optional] 
**MaximumVirtualFcInterfacesPerBladeServer** | **Int64** | Maximum configurable Virtual Fibre Channel interfaces per blade. | [optional] 
**MaximumVsans** | **Int64** | Maximum configurable VSANs on Switch/Fabric-Interconnect. | [optional] 
**MaximumZoneCount** | **Int64** | Zone limit per Switch/Fabric-Interconnect. | [optional] 

## Examples

- Prepare the resource
```powershell
$CapabilitySwitchStorageLimitsAllOf = Initialize-IntersightCapabilitySwitchStorageLimitsAllOf  -ClassId null `
 -ObjectType null `
 -MaximumUserZoneCount null `
 -MaximumVirtualFcInterfaces null `
 -MaximumVirtualFcInterfacesPerBladeServer null `
 -MaximumVsans null `
 -MaximumZoneCount null
```

- Convert the resource to JSON
```powershell
$CapabilitySwitchStorageLimitsAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

