# PolicyConfigContextAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "policy.ConfigContext"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "policy.ConfigContext"]
**ConfigState** | **String** | Indicates a profile&#39;s configuration deploying state. Values -- Assigned, Not-assigned, Associated, Pending-changes, Validating, Configuring, Failed. | [optional] [readonly] 
**ControlAction** | **String** | System action to trigger the appropriate workflow. Values -- No_op, ConfigChange, Deploy, Unbind. | [optional] 
**ErrorState** | **String** | Indicates a profile&#39;s error state. Values -- Validation-error (Static validation error), Pre-config-error (Runtime validation error), Config-error (Runtime configuration error). | [optional] 
**OperState** | **String** | Combined state (configState, and operational state of the associated physical resource) to indicate the current state of the profile. Values -- n/a, Power-off, Pending-changes, Configuring, Ok, Failed. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$PolicyConfigContextAllOf = Initialize-IntersightPolicyConfigContextAllOf  -ClassId null `
 -ObjectType null `
 -ConfigState null `
 -ControlAction null `
 -ErrorState null `
 -OperState null
```

- Convert the resource to JSON
```powershell
$PolicyConfigContextAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

