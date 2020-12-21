# FabricLldpSettingsAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "fabric.LldpSettings"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "fabric.LldpSettings"]
**ReceiveEnabled** | **Boolean** | Determines if the LLDP frames can be received by an interface on the switch. | [optional] [default to $false]
**TransmitEnabled** | **Boolean** | Determines if the LLDP frames can be transmitted by an interface on the switch. | [optional] [default to $false]

## Examples

- Prepare the resource
```powershell
$FabricLldpSettingsAllOf = Initialize-IntersightFabricLldpSettingsAllOf  -ClassId null `
 -ObjectType null `
 -ReceiveEnabled null `
 -TransmitEnabled null
```

- Convert the resource to JSON
```powershell
$FabricLldpSettingsAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

