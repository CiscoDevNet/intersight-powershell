# PolicyAbstractConfigResultEntryAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. The enum values provides the list of concrete types that can be instantiated from this abstract type. | 
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. The enum values provides the list of concrete types that can be instantiated from this abstract type. | 
**CompletedTime** | **String** | The completed time of the task in installer. | [optional] 
**Context** | [**PolicyConfigResultContext**](PolicyConfigResultContext.md) |  | [optional] 
**Message** | **String** | Localized message based on the locale setting of the user&#39;s context. | [optional] 
**OwnerId** | **String** | The identifier of the object that owns the result message. The owner ID is used to correlate a given result entry to a task or entity. For example, a config result entry that describes the result of a workflow task may have the task&#39;s instance ID as the owner. | [optional] 
**State** | **String** | Values  -- Ok, Ok-with-warning, Errored. | [optional] 
**Type** | **String** | Indicates if the result is reported during the logical model validation/resource allocation phase. or the configuration applying phase. Values -- validation, config. | [optional] 

## Examples

- Prepare the resource
```powershell
$PolicyAbstractConfigResultEntryAllOf = Initialize-IntersightPolicyAbstractConfigResultEntryAllOf  -ClassId null `
 -ObjectType null `
 -CompletedTime null `
 -Context null `
 -Message null `
 -OwnerId null `
 -State null `
 -Type null
```

- Convert the resource to JSON
```powershell
$PolicyAbstractConfigResultEntryAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

