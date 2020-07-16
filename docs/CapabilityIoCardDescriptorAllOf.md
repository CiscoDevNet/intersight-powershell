# CapabilityIoCardDescriptorAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NumHifPorts** | **Int64** | Number of hif ports per blade for the iocard module. | [optional] 
**Revision** | **String** | Revision for the iocard module. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightCapabilityIoCardDescriptorAllOf  -NumHifPorts null `
 -Revision null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

