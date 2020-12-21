# VnicCompletionQueueSettingsAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "vnic.CompletionQueueSettings"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "vnic.CompletionQueueSettings"]
**Count** | **Int64** | The number of completion queue resources to allocate. In general, the number of completion queue resources to allocate is equal to the number of transmit queue resources plus the number of receive queue resources. | [optional] [default to 5]
**RingSize** | **Int64** | The number of descriptors in each completion queue. | [optional] [readonly] [default to 1]

## Examples

- Prepare the resource
```powershell
$VnicCompletionQueueSettingsAllOf = Initialize-IntersightVnicCompletionQueueSettingsAllOf  -ClassId null `
 -ObjectType null `
 -Count null `
 -RingSize null
```

- Convert the resource to JSON
```powershell
$VnicCompletionQueueSettingsAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

