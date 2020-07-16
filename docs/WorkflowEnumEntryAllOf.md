# WorkflowEnumEntryAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Label** | **String** | Label for the enum value. A user friendly short string to identify the enum value. | [optional] 
**Value** | **String** | Enum value for this enum entry. Value will be passed to the workflow as string type for execution. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightWorkflowEnumEntryAllOf  -Label null `
 -Value null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

