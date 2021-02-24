# WorkflowFileDownloadOp
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "workflow.FileDownloadOp"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "workflow.FileDownloadOp"]
**DestinationPath** | **String** | Path on the Intersight connected device to which file needs to be downloaded. | [optional] 
**SourceBucket** | **String** | Source bucket name hosting the file. | [optional] 
**SourceFile** | **String** | Name of the file to be downloaded from bucket to endpoint devices. | [optional] 

## Examples

- Prepare the resource
```powershell
$WorkflowFileDownloadOp = Initialize-IntersightWorkflowFileDownloadOp  -ClassId null `
 -ObjectType null `
 -DestinationPath null `
 -SourceBucket null `
 -SourceFile null
```

- Convert the resource to JSON
```powershell
$WorkflowFileDownloadOp | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

