# VnicEthTxQueueSettingsAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "vnic.EthTxQueueSettings"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "vnic.EthTxQueueSettings"]
**Count** | **Int64** | The number of queue resources to allocate. | [optional] [default to 1]
**RingSize** | **Int64** | The number of descriptors in each queue. | [optional] [default to 256]

## Examples

- Prepare the resource
```powershell
$VnicEthTxQueueSettingsAllOf = Initialize-IntersightVnicEthTxQueueSettingsAllOf  -ClassId null `
 -ObjectType null `
 -Count null `
 -RingSize null
```

- Convert the resource to JSON
```powershell
$VnicEthTxQueueSettingsAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

