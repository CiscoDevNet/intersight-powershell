# WorkflowErrorResponseHandlerAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **String** | A detailed description about the error response handler. | [optional] 
**Name** | **String** | Name for the error response handler. | [optional] 
**Parameters** | [**ContentParameter[]**](ContentParameter.md) |  | [optional] 
**PlatformType** | **String** | The platform type for which the error response handler is defined. | [optional] [default to ""]
**Types** | [**ContentComplexType[]**](ContentComplexType.md) |  | [optional] 
**Catalog** | [**WorkflowCatalogRelationship**](WorkflowCatalogRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightWorkflowErrorResponseHandlerAllOf  -Description null `
 -Name null `
 -Parameters null `
 -PlatformType null `
 -Types null `
 -Catalog null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

