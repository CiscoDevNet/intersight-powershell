# AdapterAdapterConfigAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DceInterfaceSettings** | [**AdapterDceInterfaceSettings[]**](AdapterDceInterfaceSettings.md) |  | [optional] 
**EthSettings** | [**AdapterEthSettings**](AdapterEthSettings.md) |  | [optional] 
**FcSettings** | [**AdapterFcSettings**](AdapterFcSettings.md) |  | [optional] 
**PortChannelSettings** | [**AdapterPortChannelSettings**](AdapterPortChannelSettings.md) |  | [optional] 
**SlotId** | **String** | PCIe slot where the VIC adapter is installed. Supported values are (1-15) and MLOM. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightAdapterAdapterConfigAllOf  -DceInterfaceSettings null `
 -EthSettings null `
 -FcSettings null `
 -PortChannelSettings null `
 -SlotId null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

