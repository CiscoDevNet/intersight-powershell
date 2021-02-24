# WorkflowFileOperationsAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "workflow.FileOperations"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "workflow.FileOperations"]
**FileDownload** | [**WorkflowFileDownloadOp**](WorkflowFileDownloadOp.md) |  | [optional] 
**FileTemplate** | [**WorkflowFileTemplateOp**](WorkflowFileTemplateOp.md) |  | [optional] 
**OperationType** | **String** | File operation type to be executed on the connected endpoint. * &#x60;FileDownload&#x60; - The API is executed in a remote device connected to the Intersightthrough its device connector. This operation is to download the filefrom specified storage bucket to the specific path on the device. * &#x60;FileTemplatize&#x60; - Populates data driven template file with input values to generate textual output.Inputs - the path of the template file on the device and json values to populate.An error will be returned if the file does not exists or if there is an error whileexecuting the template. | [optional] [default to "FileDownload"]

## Examples

- Prepare the resource
```powershell
$WorkflowFileOperationsAllOf = Initialize-IntersightWorkflowFileOperationsAllOf  -ClassId null `
 -ObjectType null `
 -FileDownload null `
 -FileTemplate null `
 -OperationType null
```

- Convert the resource to JSON
```powershell
$WorkflowFileOperationsAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

