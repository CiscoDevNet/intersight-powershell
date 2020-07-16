# ApplianceImageBundle
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountMoid** | **String** | The Account ID for this managed object. | [optional] [readonly] 
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**CreateTime** | **System.DateTime** | The time when this managed object was created. | [optional] [readonly] 
**DomainGroupMoid** | **String** | The DomainGroup ID for this managed object. | [optional] [readonly] 
**ModTime** | **System.DateTime** | The time when this managed object was last modified. | [optional] [readonly] 
**Moid** | **String** | The unique identifier of this Managed Object instance. | [optional] 
**ObjectType** | **String** | The fully-qualified type of this managed object, i.e. the class name. This property is optional. The ObjectType is implied from the URL path. If specified, the value of objectType must match the class name specified in the URL path. | [readonly] 
**Owners** | **String[]** |  | [optional] 
**SharedScope** | **String** | Intersight provides pre-built workflows, tasks and policies to end users through global catalogs. Objects that are made available through global catalogs are said to have a &#39;shared&#39; ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs. | [optional] [readonly] 
**Tags** | [**MoTag[]**](MoTag.md) |  | [optional] 
**VersionContext** | [**MoVersionContext**](MoVersionContext.md) |  | [optional] 
**Ancestors** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**Parent** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 
**PermissionResources** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**DisplayNames** | [**System.Collections.Hashtable**](Array.md) | a map of display names for a resource. | [optional] [readonly] 
**AnsiblePackages** | [**OnpremImagePackage[]**](OnpremImagePackage.md) |  | [optional] 
**AutoUpgrade** | **Boolean** | Indicates that the software upgrade was automatically initiated by the Intersight Appliance. | [optional] [readonly] 
**DcPackages** | [**OnpremImagePackage[]**](OnpremImagePackage.md) |  | [optional] 
**DebugPackages** | [**OnpremImagePackage[]**](OnpremImagePackage.md) |  | [optional] 
**Description** | **String** | Short description of the software upgrade bundle. | [optional] [readonly] 
**EndpointPackages** | [**OnpremImagePackage[]**](OnpremImagePackage.md) |  | [optional] 
**Fingerprint** | **String** | Fingerprint of the software manifest from which this bundle is created. Fingerprint is calculated using the SHA256 algorithm. | [optional] [readonly] 
**HasError** | **Boolean** | Indicates that the ImageBundle has errors. The upgrade service sets this field when it encounters errors during the manifest processing. | [optional] [readonly] 
**InfraPackages** | [**OnpremImagePackage[]**](OnpremImagePackage.md) |  | [optional] 
**InitPackages** | [**OnpremImagePackage[]**](OnpremImagePackage.md) |  | [optional] 
**Name** | **String** | Name of the software upgrade bundle. | [optional] [readonly] 
**Notes** | **String** | Detailed description of the software upgrade bundle. | [optional] [readonly] 
**Priority** | **String** | Software upgrade manifest&#39;s upgrade priority. The upgrade service supports two priorities, Normal and Critical. Normal priority is used for regular software upgrades, and the upgrade service uses the Upgrade Policy to compute upgrade start time. Critical priority is used for the critical software security patches, and the upgrade service ignores the Upgrade Policy when it computes the upgrade start time. | [optional] [readonly] [default to "Normal"]
**ReleaseTime** | **System.DateTime** | Software upgrade manifest&#39;s release date and time. | [optional] [readonly] 
**ServicePackages** | [**OnpremImagePackage[]**](OnpremImagePackage.md) |  | [optional] 
**StatusMessage** | **String** | Status message set during the manifest processing. | [optional] [readonly] 
**SystemPackages** | [**OnpremImagePackage[]**](OnpremImagePackage.md) |  | [optional] 
**UiPackages** | [**OnpremImagePackage[]**](OnpremImagePackage.md) |  | [optional] 
**UpgradeEndTime** | **System.DateTime** | End date of the software upgrade process. | [optional] [readonly] 
**UpgradeGracePeriod** | **Int64** | Grace period in seconds before the automatic upgrade is initiated. The upgrade service uses the grace period to compute the upgrade start time when it receives an upgrade notfication from the Intersight. If there is an Upgrade Policy configured for the Intersight Appliance, then the upgrade service uses the policy to compute the upgrade start time. However, the upgrade start time cannot not exceed the limit enforced by the grace period. | [optional] [readonly] 
**UpgradeImpactDuration** | **Int64** | Duration (in minutes) for which services will be disrupted. | [optional] [readonly] 
**UpgradeImpactEnum** | **String** | UpgradeImpactEnum is used to indicate the kind of impact the upgrade has on currently running services on the appliance. | [optional] [readonly] [default to "None"]
**UpgradeStartTime** | **System.DateTime** | Start date of the software upgrade process. | [optional] [readonly] 
**Version** | **String** | Software upgrade manifest&#39;s version. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightApplianceImageBundle  -AccountMoid null `
 -ClassId null `
 -CreateTime null `
 -DomainGroupMoid null `
 -ModTime null `
 -Moid null `
 -ObjectType null `
 -Owners null `
 -SharedScope null `
 -Tags null `
 -VersionContext null `
 -Ancestors null `
 -Parent null `
 -PermissionResources null `
 -DisplayNames null `
 -AnsiblePackages null `
 -AutoUpgrade null `
 -DcPackages null `
 -DebugPackages null `
 -Description null `
 -EndpointPackages null `
 -Fingerprint null `
 -HasError null `
 -InfraPackages null `
 -InitPackages null `
 -Name null `
 -Notes null `
 -Priority null `
 -ReleaseTime null `
 -ServicePackages null `
 -StatusMessage null `
 -SystemPackages null `
 -UiPackages null `
 -UpgradeEndTime null `
 -UpgradeGracePeriod null `
 -UpgradeImpactDuration null `
 -UpgradeImpactEnum null `
 -UpgradeStartTime null `
 -Version null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

