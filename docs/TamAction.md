# TamAction
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
**AffectedObjectType** | **String** | Type of the managed object that should be marked with an instance of the Alert (when operation type is create) or that should have an alert instance removed (when operation type is remove). | [optional] 
**AlertType** | **String** | Alert type is used to denote the category of an Intersight alert (FieldNotice, equipment Fault etc.). | [optional] [default to "psirt"]
**Identifiers** | [**TamIdentifiers[]**](TamIdentifiers.md) |  | [optional] 
**Name** | **String** | Uniquely identifies a given action among the set of actions corresponding to an advisory. Primarily used to store and compare results of subsequent iterations corresponding to the action queries. | [optional] 
**OperationType** | **String** | Operation type for the alert action. An action is used to carry out the process of &quot;&quot;reacting&quot;&quot; to an alert condition. For e.g.in case of a fieldNotice alert, the intention may be to create a new alert (if the condition matches and there is no existing alert) or to remove an existing alert when the alert condition has been remedied. | [optional] [default to "create"]
**Queries** | [**TamQueryEntry[]**](TamQueryEntry.md) |  | [optional] 
**Type** | **String** | Type of Intersight alert. An alert in Intersight could be one of several kinds (FieldNotice, PSIRT etc.). Primarily used for filtering alerts based on the type. | [optional] [default to "restApi"]

## Examples

- Prepare the resource
```powershell
Initialize-IntersightTamAction  -ClassId null `
 -ObjectType null `
 -AffectedObjectType null `
 -AlertType null `
 -Identifiers null `
 -Name null `
 -OperationType null `
 -Queries null `
 -Type null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

