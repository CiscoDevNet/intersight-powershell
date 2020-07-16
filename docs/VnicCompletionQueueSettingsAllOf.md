# VnicCompletionQueueSettingsAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Count** | **Int64** | The number of completion queue resources to allocate. In general, the number of completion queue resources to allocate is equal to the number of transmit queue resources plus the number of receive queue resources. | [optional] 
**RingSize** | **Int64** | The number of descriptors in each completion queue. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightVnicCompletionQueueSettingsAllOf  -Count null `
 -RingSize null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

