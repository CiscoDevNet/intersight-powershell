# WorkflowFileTransferAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DestinationFilePath** | **String** | Destination file path on the target server. | [optional] 
**FileMode** | **Int64** | File permission to set on the transferred file. | [optional] 
**SourceFilePath** | **String** | Source file path on the Intersight connected device. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightWorkflowFileTransferAllOf  -DestinationFilePath null `
 -FileMode null `
 -SourceFilePath null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

