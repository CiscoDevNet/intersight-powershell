# ApplianceUpgrade
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "appliance.Upgrade"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "appliance.Upgrade"]
**AccountMoid** | **String** | The Account ID for this managed object. | [optional] [readonly] 
**CreateTime** | **System.DateTime** | The time when this managed object was created. | [optional] [readonly] 
**DomainGroupMoid** | **String** | The DomainGroup ID for this managed object. | [optional] [readonly] 
**ModTime** | **System.DateTime** | The time when this managed object was last modified. | [optional] [readonly] 
**Moid** | **String** | The unique identifier of this Managed Object instance. | [optional] 
**Owners** | **String[]** |  | [optional] 
**SharedScope** | **String** | Intersight provides pre-built workflows, tasks and policies to end users through global catalogs. Objects that are made available through global catalogs are said to have a &#39;shared&#39; ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs. | [optional] [readonly] 
**Tags** | [**MoTag[]**](MoTag.md) |  | [optional] 
**VersionContext** | [**MoVersionContext**](MoVersionContext.md) |  | [optional] 
**Ancestors** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**Parent** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 
**PermissionResources** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**DisplayNames** | [**System.Collections.Hashtable**](Array.md) | A set of display names for the MO resource. These names are calculated based on other properties of the MO and potentially properties of Ancestor MOs. Displaynames are intended as a way to provide a normalized user appropriate name for an MO, especially for MOs which do not have a &#39;Name&#39; property, which is the case for much of the inventory discovered from managed targets. There are a limited number of keys, currently &#39;short&#39; and &#39;hierarchical&#39;. The value is an array and clients should use the first element of the array. | [optional] [readonly] 
**Active** | **Boolean** | Indicates if the software upgrade is active or not. | [optional] [readonly] 
**AutoCreated** | **Boolean** | Indicates that the request was automatically created by the system. | [optional] [readonly] 
**CompletedPhases** | [**OnpremUpgradePhase[]**](OnpremUpgradePhase.md) |  | [optional] 
**CurrentPhase** | [**OnpremUpgradePhase**](OnpremUpgradePhase.md) |  | [optional] 
**Description** | **String** | Description of the software upgrade. | [optional] [readonly] 
**ElapsedTime** | **Int64** | Elapsed time in seconds during the software upgrade. | [optional] [readonly] 
**EndTime** | **System.DateTime** | End date of the software upgrade. | [optional] [readonly] 
**ErrorCode** | **Int64** | Error code for Intersight Appliance&#39;s software upgrade. In case of failure - this code will help decide if software upgrade can be retried. | [optional] [readonly] 
**Fingerprint** | **String** | Software upgrade manifest&#39;s fingerprint. | [optional] [readonly] 
**IsRollingBack** | **Boolean** | Track if software upgrade is upgrading or rolling back. | [optional] [readonly] [default to $false]
**IsUserTriggered** | **Boolean** | Indicates if the upgrade is triggered by user or due to schedule. | [optional] [readonly] [default to $false]
**Messages** | **String[]** |  | [optional] 
**RollbackNeeded** | **Boolean** | Track if rollback is needed. | [optional] [default to $false]
**RollbackPhases** | [**OnpremUpgradePhase[]**](OnpremUpgradePhase.md) |  | [optional] 
**RollbackStatus** | **String** | Status of the Intersight Appliance&#39;s software rollback status. | [optional] [readonly] 
**Services** | **String[]** |  | [optional] 
**StartTime** | **System.DateTime** | Start date of the software upgrade. UI can modify startTime to re-schedule an upgrade. | [optional] 
**Status** | **String** | Status of the Intersight Appliance&#39;s software upgrade. | [optional] [readonly] 
**TotalPhases** | **Int64** | TotalPhase represents the total number of the upgradePhases for one upgrade. | [optional] [readonly] 
**UiPackages** | **String[]** |  | [optional] 
**Version** | **String** | Software upgrade manifest&#39;s version. | [optional] [readonly] 
**Account** | [**IamAccountRelationship**](IamAccountRelationship.md) |  | [optional] 
**ImageBundle** | [**ApplianceImageBundleRelationship**](ApplianceImageBundleRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ApplianceUpgrade = Initialize-IntersightApplianceUpgrade  -ClassId null `
 -ObjectType null `
 -AccountMoid null `
 -CreateTime null `
 -DomainGroupMoid null `
 -ModTime null `
 -Moid null `
 -Owners null `
 -SharedScope null `
 -Tags null `
 -VersionContext null `
 -Ancestors null `
 -Parent null `
 -PermissionResources null `
 -DisplayNames null `
 -Active null `
 -AutoCreated null `
 -CompletedPhases null `
 -CurrentPhase null `
 -Description null `
 -ElapsedTime null `
 -EndTime null `
 -ErrorCode null `
 -Fingerprint null `
 -IsRollingBack null `
 -IsUserTriggered null `
 -Messages null `
 -RollbackNeeded null `
 -RollbackPhases null `
 -RollbackStatus null `
 -Services null `
 -StartTime null `
 -Status null `
 -TotalPhases null `
 -UiPackages null `
 -Version null `
 -Account null `
 -ImageBundle null
```

- Convert the resource to JSON
```powershell
$ApplianceUpgrade | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

