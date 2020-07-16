# WorkflowMessageAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Message** | [**AnyType**](.md) | An i18n message that can be translated in multiple languages to support internationalization.} type: string | [optional] 
**Severity** | **String** | The severity of the Task or Workflow message warning/error/info etc. | [optional] [default to "Info"]

## Examples

- Prepare the resource
```powershell
Initialize-IntersightWorkflowMessageAllOf  -Message null `
 -Severity null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

