# SdwanNetworkConfigurationType
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "sdwan.NetworkConfigurationType"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "sdwan.NetworkConfigurationType"]
**NetworkType** | **String** | Type of the Port group being added. * &#x60;WAN&#x60; - Port-group being added is used for WAN traffic. * &#x60;LAN&#x60; - Port-group being added is used for LAN traffic. * &#x60;Management&#x60; - Port-group being added is used for Management traffic. | [optional] [default to "WAN"]
**PortGroup** | **String** | Name of the Port Group to create. | [optional] 
**Vlan** | **Int64** | VLAN to be added to the Port Group. | [optional] 

## Examples

- Prepare the resource
```powershell
$SdwanNetworkConfigurationType = Initialize-IntersightSdwanNetworkConfigurationType  -ClassId null `
 -ObjectType null `
 -NetworkType null `
 -PortGroup null `
 -Vlan null
```

- Convert the resource to JSON
```powershell
$SdwanNetworkConfigurationType | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

