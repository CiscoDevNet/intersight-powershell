# WorkflowBaseDataTypeAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Default** | [**WorkflowDefaultValue**](WorkflowDefaultValue.md) |  | [optional] 
**Description** | **String** | Provide a detailed description of the data type. | [optional] 
**Label** | **String** | Descriptive label for the data type. Name can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-), space ( ) or an underscore (_). The first and last character in label must be an alphanumeric character. | [optional] 
**Name** | **String** | Descriptive name for the data type. Name can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-) or an underscore (_). The first and last character in name must be an alphanumeric character. | [optional] 
**Required** | **Boolean** | Specifies whether this parameter is required. The field is applicable for task and workflow. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightWorkflowBaseDataTypeAllOf  -Default null `
 -Description null `
 -Label null `
 -Name null `
 -Required null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

