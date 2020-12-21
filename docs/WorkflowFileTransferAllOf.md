# WorkflowFileTransferAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "workflow.FileTransfer"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "workflow.FileTransfer"]
**DestinationFilePath** | **String** | Destination file path on the target server. | [optional] 
**FileMode** | **Int64** | File permission to set on the transferred file. | [optional] 
**SourceFilePath** | **String** | Source file path on the Intersight connected device. | [optional] 

## Examples

- Prepare the resource
```powershell
$WorkflowFileTransferAllOf = Initialize-IntersightWorkflowFileTransferAllOf  -ClassId null `
 -ObjectType null `
 -DestinationFilePath null `
 -FileMode null `
 -SourceFilePath null
```

- Convert the resource to JSON
```powershell
$WorkflowFileTransferAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

