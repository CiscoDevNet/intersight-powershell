# WorkflowWorkflowProperties
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
**ExternalMeta** | **Boolean** | When set to false the workflow is owned by the system and used for internal services. Such workflows cannot be directly used by external entities. | [optional] 
**Retryable** | **Boolean** | When true, this workflow can be retried if has not been modified for more than a period of 2 weeks. | [optional] 
**SupportStatus** | **String** | Supported status of the definition. | [optional] [default to "Supported"]

## Examples

- Prepare the resource
```powershell
Initialize-IntersightWorkflowWorkflowProperties  -ClassId null `
 -ObjectType null `
 -ExternalMeta null `
 -Retryable null `
 -SupportStatus null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

