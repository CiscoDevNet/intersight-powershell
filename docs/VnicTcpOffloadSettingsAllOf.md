# VnicTcpOffloadSettingsAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "vnic.TcpOffloadSettings"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "vnic.TcpOffloadSettings"]
**LargeReceive** | **Boolean** | Enables the reassembly of segmented packets in hardware before sending them to the CPU. | [optional] [default to $true]
**LargeSend** | **Boolean** | Enables the CPU to send large packets to the hardware for segmentation. | [optional] [default to $true]
**RxChecksum** | **Boolean** | When enabled, the CPU sends all packet checksums to the hardware for validation. | [optional] [default to $true]
**TxChecksum** | **Boolean** | When enabled, the CPU sends all packets to the hardware so that the checksum can be calculated. | [optional] [default to $true]

## Examples

- Prepare the resource
```powershell
$VnicTcpOffloadSettingsAllOf = Initialize-IntersightVnicTcpOffloadSettingsAllOf  -ClassId null `
 -ObjectType null `
 -LargeReceive null `
 -LargeSend null `
 -RxChecksum null `
 -TxChecksum null
```

- Convert the resource to JSON
```powershell
$VnicTcpOffloadSettingsAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

