# WorkflowEnumEntry
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "workflow.EnumEntry"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "workflow.EnumEntry"]
**Label** | **String** | Label for the enum value. A user friendly short string to identify the enum value. Label can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-), period (.), colon (:), space ( ), single quote (&#39;), forward slash (/), or an underscore (_). | [optional] 
**Value** | **String** | Enum value for this enum entry. Value will be passed to the workflow as string type for execution. Value can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-), period (.), colon (:), space ( ), forward slash (/), or an underscore (_). | [optional] 

## Examples

- Prepare the resource
```powershell
$WorkflowEnumEntry = Initialize-IntersightWorkflowEnumEntry  -ClassId null `
 -ObjectType null `
 -Label null `
 -Value null
```

- Convert the resource to JSON
```powershell
$WorkflowEnumEntry | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

