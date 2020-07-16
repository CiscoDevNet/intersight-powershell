# PolicyConfigContext
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
**ConfigState** | **String** | Indicates a profile&#39;s configuration deploying state. Values -- Assigned, Not-assigned, Associated, Pending-changes, Validating, Configuring, Failed. | [optional] [readonly] 
**ControlAction** | **String** | System action to trigger the appropriate workflow. Values -- No_op, ConfigChange, Deploy, Unbind. | [optional] 
**ErrorState** | **String** | Indicates a profile&#39;s error state. Values -- Validation-error (Static validation error), Pre-config-error (Runtime validation error), Config-error (Runtime configuration error). | [optional] 
**OperState** | **String** | Combined state (configState, and operational state of the associated physical resource) to indicate the current state of the profile. Values -- n/a, Power-off, Pending-changes, Configuring, Ok, Failed. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightPolicyConfigContext  -ClassId null `
 -ObjectType null `
 -ConfigState null `
 -ControlAction null `
 -ErrorState null `
 -OperState null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

