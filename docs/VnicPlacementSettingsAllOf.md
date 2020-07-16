# VnicPlacementSettingsAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **String** | PCIe Slot where the VIC adapter is installed. Supported values are (1-15) and MLOM. | [optional] 
**PciLink** | **Int64** | The PCI Link used as transport for the virtual interface. All VIC adapters have a single PCI link except VIC 1385 which has two. | [optional] 
**SwitchId** | **String** | The fabric port to which the vnics will be associated. | [optional] [default to "None"]
**Uplink** | **Int64** | Adapter port on which the virtual interface will be created. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightVnicPlacementSettingsAllOf  -Id null `
 -PciLink null `
 -SwitchId null `
 -Uplink null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

