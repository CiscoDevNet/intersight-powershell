# VnicTcpOffloadSettingsAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LargeReceive** | **Boolean** | Enables the reassembly of segmented packets in hardware before sending them to the CPU. | [optional] 
**LargeSend** | **Boolean** | Enables the CPU to send large packets to the hardware for segmentation. | [optional] 
**RxChecksum** | **Boolean** | When enabled, the CPU sends all packet checksums to the hardware for validation. | [optional] 
**TxChecksum** | **Boolean** | When enabled, the CPU sends all packets to the hardware so that the checksum can be calculated. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightVnicTcpOffloadSettingsAllOf  -LargeReceive null `
 -LargeSend null `
 -RxChecksum null `
 -TxChecksum null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

