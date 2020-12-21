# PolicyinventoryJobInfoAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "policyinventory.JobInfo"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "policyinventory.JobInfo"]
**ExecutionStatus** | **String** | Execution status of the inventory job. * &#x60;Scheduled&#x60; - Inventory job is marked as scheduled. * &#x60;Completed&#x60; - Inventory job is marked as completed. * &#x60;Error&#x60; - Inventory job has errored out. | [optional] [readonly] [default to "Scheduled"]
**LastScheduledTime** | **System.DateTime** | Last scheduled time of the inventory job. | [optional] [readonly] 
**PolicyId** | **String** | Policy ID for the inventory job. | [optional] [readonly] 
**PolicyName** | **String** | Policy name for the inventory job. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$PolicyinventoryJobInfoAllOf = Initialize-IntersightPolicyinventoryJobInfoAllOf  -ClassId null `
 -ObjectType null `
 -ExecutionStatus null `
 -LastScheduledTime null `
 -PolicyId null `
 -PolicyName null
```

- Convert the resource to JSON
```powershell
$PolicyinventoryJobInfoAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

