# ApplianceUpgradePolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AutoUpgrade** | **Boolean** | Indicates if the upgrade service is set to automatically start the software upgrade or not. If autoUpgrade is true, then the value of the schedule field is ignored. | [optional] 
**BlackoutDatesEnabled** | **Boolean** | If enabled, allows the user to define a blackout period during which the appliance will not be upgraded. | [optional] 
**BlackoutEndDate** | **System.DateTime** | End date of the black out period. | [optional] 
**BlackoutStartDate** | **System.DateTime** | Start date of the black out period. The appliance will not be upgraded during this period. | [optional] 
**Schedule** | [**OnpremSchedule**](OnpremSchedule.md) |  | [optional] 
**Account** | [**IamAccountRelationship**](IamAccountRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightApplianceUpgradePolicyAllOf  -AutoUpgrade null `
 -BlackoutDatesEnabled null `
 -BlackoutEndDate null `
 -BlackoutStartDate null `
 -Schedule null `
 -Account null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

