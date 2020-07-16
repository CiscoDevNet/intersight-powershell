# PolicyinventoryJobInfoAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExecutionStatus** | **String** | Execution status of the inventory job. | [optional] [readonly] [default to "Scheduled"]
**LastScheduledTime** | **System.DateTime** | Last scheduled time of the inventory job. | [optional] [readonly] 
**PolicyId** | **String** | Policy ID for the inventory job. | [optional] [readonly] 
**PolicyName** | **String** | Policy name for the inventory job. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightPolicyinventoryJobInfoAllOf  -ExecutionStatus null `
 -LastScheduledTime null `
 -PolicyId null `
 -PolicyName null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

