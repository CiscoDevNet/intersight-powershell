# WorkflowMessage
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "workflow.Message"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "workflow.Message"]
**Message** | **String** | An i18n message that can be translated in multiple languages to support internationalization. | [optional] 
**Severity** | **String** | The severity of the Task or Workflow message warning/error/info etc. * &#x60;Info&#x60; - The enum represents the log level to be used to convey info message. * &#x60;Warning&#x60; - The enum represents the log level to be used to convey warning message. * &#x60;Debug&#x60; - The enum represents the log level to be used to convey debug message. * &#x60;Error&#x60; - The enum represents the log level to be used to convey error message. | [optional] [default to "Info"]

## Examples

- Prepare the resource
```powershell
$WorkflowMessage = Initialize-IntersightWorkflowMessage  -ClassId null `
 -ObjectType null `
 -Message null `
 -Severity null
```

- Convert the resource to JSON
```powershell
$WorkflowMessage | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

