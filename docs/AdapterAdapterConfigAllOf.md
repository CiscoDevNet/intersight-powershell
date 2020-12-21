# AdapterAdapterConfigAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "adapter.AdapterConfig"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "adapter.AdapterConfig"]
**DceInterfaceSettings** | [**AdapterDceInterfaceSettings[]**](AdapterDceInterfaceSettings.md) |  | [optional] 
**EthSettings** | [**AdapterEthSettings**](AdapterEthSettings.md) |  | [optional] 
**FcSettings** | [**AdapterFcSettings**](AdapterFcSettings.md) |  | [optional] 
**PortChannelSettings** | [**AdapterPortChannelSettings**](AdapterPortChannelSettings.md) |  | [optional] 
**SlotId** | **String** | PCIe slot where the VIC adapter is installed. Supported values are (1-15) and MLOM. | [optional] 

## Examples

- Prepare the resource
```powershell
$AdapterAdapterConfigAllOf = Initialize-IntersightAdapterAdapterConfigAllOf  -ClassId null `
 -ObjectType null `
 -DceInterfaceSettings null `
 -EthSettings null `
 -FcSettings null `
 -PortChannelSettings null `
 -SlotId null
```

- Convert the resource to JSON
```powershell
$AdapterAdapterConfigAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

