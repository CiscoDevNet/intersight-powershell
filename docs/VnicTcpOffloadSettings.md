# VnicTcpOffloadSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
**LargeReceive** | **Boolean** | Enables the reassembly of segmented packets in hardware before sending them to the CPU. | [optional] 
**LargeSend** | **Boolean** | Enables the CPU to send large packets to the hardware for segmentation. | [optional] 
**RxChecksum** | **Boolean** | When enabled, the CPU sends all packet checksums to the hardware for validation. | [optional] 
**TxChecksum** | **Boolean** | When enabled, the CPU sends all packets to the hardware so that the checksum can be calculated. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightVnicTcpOffloadSettings  -ClassId null `
 -ObjectType null `
 -LargeReceive null `
 -LargeSend null `
 -RxChecksum null `
 -TxChecksum null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

