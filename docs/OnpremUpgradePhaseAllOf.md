# OnpremUpgradePhaseAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ElapsedTime** | **Int64** | Elapsed time in seconds to complete the current upgrade phase. | [optional] [readonly] 
**EndTime** | **System.DateTime** | End date of the software upgrade phase. | [optional] [readonly] 
**Failed** | **Boolean** | Indicates if the upgrade phase has failed or not. | [optional] [readonly] 
**Message** | **String** | Status message set during the upgrade phase. | [optional] [readonly] 
**Name** | **String** | Name of the upgrade phase. | [optional] [readonly] [default to "init"]
**StartTime** | **System.DateTime** | Start date of the software upgrade phase. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightOnpremUpgradePhaseAllOf  -ElapsedTime null `
 -EndTime null `
 -Failed null `
 -Message null `
 -Name null `
 -StartTime null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

