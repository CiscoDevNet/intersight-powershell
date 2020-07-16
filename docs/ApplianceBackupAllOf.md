# ApplianceBackupAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ElapsedTime** | **Int64** | Elapsed time in seconds since the backup process has started. | [optional] [readonly] 
**EndTime** | **System.DateTime** | End date and time of the backup process. | [optional] [readonly] 
**IsPasswordSet** | **Boolean** | Indicates whether the value of the &#39;password&#39; property has been set. | [optional] [readonly] 
**Messages** | **String[]** |  | [optional] 
**Password** | **String** | Password to authenticate the fileserver. | [optional] 
**StartTime** | **System.DateTime** | Start date and time of the backup process. | [optional] [readonly] 
**Status** | **String** | Status of the backup managed object. | [optional] [readonly] [default to "Started"]
**Account** | [**IamAccountRelationship**](IamAccountRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightApplianceBackupAllOf  -ElapsedTime null `
 -EndTime null `
 -IsPasswordSet null `
 -Messages null `
 -Password null `
 -StartTime null `
 -Status null `
 -Account null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

