# WorkflowUiInputFilter
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "workflow.UiInputFilter"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "workflow.UiInputFilter"]
**Filters** | **String[]** |  | [optional] 
**Name** | **String** | Name for the input definition to which this filter applies. Name can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-) or an underscore (_). The first and last character in name must be an alphanumeric character. When defining the cascade filter for a sub property, use a period (.) to seperate each section of the name like &quot;&quot;StorageConfig.Volume&quot;&quot; where &#39;StorageConfig&#39; is an input name and &#39;Volume&#39; is a sub property defined through custom data type definition. | [optional] 
**UserHelpMessage** | **String** | Help message shown to the user about which prior input needs to be selected to enable the input mapped to this filter. | [optional] 

## Examples

- Prepare the resource
```powershell
$WorkflowUiInputFilter = Initialize-IntersightWorkflowUiInputFilter  -ClassId null `
 -ObjectType null `
 -Filters null `
 -Name null `
 -UserHelpMessage null
```

- Convert the resource to JSON
```powershell
$WorkflowUiInputFilter | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

