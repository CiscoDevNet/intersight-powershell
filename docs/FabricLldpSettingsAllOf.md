# FabricLldpSettingsAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ReceiveEnabled** | **Boolean** | Determines if the LLDP frames can be received by an interface on the switch. | [optional] 
**TransmitEnabled** | **Boolean** | Determines if the LLDP frames can be transmitted by an interface on the switch. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightFabricLldpSettingsAllOf  -ReceiveEnabled null `
 -TransmitEnabled null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

