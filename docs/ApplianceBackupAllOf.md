# ApplianceBackupAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "appliance.Backup"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "appliance.Backup"]
**ElapsedTime** | **Int64** | Elapsed time in seconds since the backup process has started. | [optional] [readonly] 
**EndTime** | **System.DateTime** | End date and time of the backup process. | [optional] [readonly] 
**IsPasswordSet** | **Boolean** | Indicates whether the value of the &#39;password&#39; property has been set. | [optional] [readonly] [default to $false]
**Messages** | **String[]** |  | [optional] 
**Password** | **String** | Password to authenticate the fileserver. | [optional] 
**StartTime** | **System.DateTime** | Start date and time of the backup process. | [optional] [readonly] 
**Status** | **String** | Status of the backup managed object. * &#x60;Started&#x60; - Backup or restore process has started. * &#x60;Created&#x60; - Backup or restore is in created state. * &#x60;Failed&#x60; - Backup or restore process has failed. * &#x60;Completed&#x60; - Backup or restore process has completed. * &#x60;Copied&#x60; - Backup file has been copied. | [optional] [readonly] [default to "Started"]
**Account** | [**IamAccountRelationship**](IamAccountRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ApplianceBackupAllOf = Initialize-IntersightApplianceBackupAllOf  -ClassId null `
 -ObjectType null `
 -ElapsedTime null `
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
$ApplianceBackupAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

