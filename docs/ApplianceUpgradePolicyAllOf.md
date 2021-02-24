# ApplianceUpgradePolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "appliance.UpgradePolicy"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "appliance.UpgradePolicy"]
**AutoUpgrade** | **Boolean** | Indicates if the upgrade service is set to automatically start the software upgrade or not. If autoUpgrade is true, then the value of the schedule field is ignored. | [optional] 
**BlackoutDatesEnabled** | **Boolean** | If enabled, allows the user to define a blackout period during which the appliance will not be upgraded. | [optional] 
**BlackoutEndDate** | **System.DateTime** | End date of the black out period. | [optional] 
**BlackoutStartDate** | **System.DateTime** | Start date of the black out period. The appliance will not be upgraded during this period. | [optional] 
**EnableMetaDataSync** | **Boolean** | Indicates if the updated metadata files should be synced immediately or at the next upgrade. | [optional] [default to $true]
**Schedule** | [**OnpremSchedule**](OnpremSchedule.md) |  | [optional] 
**Account** | [**IamAccountRelationship**](IamAccountRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ApplianceUpgradePolicyAllOf = Initialize-IntersightApplianceUpgradePolicyAllOf  -ClassId null `
 -ObjectType null `
 -AutoUpgrade null `
 -BlackoutDatesEnabled null `
 -BlackoutEndDate null `
 -BlackoutStartDate null `
 -EnableMetaDataSync null `
 -Schedule null `
 -Account null
```

- Convert the resource to JSON
```powershell
$ApplianceUpgradePolicyAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

