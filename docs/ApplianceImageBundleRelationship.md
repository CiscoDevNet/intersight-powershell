# ApplianceImageBundleRelationship
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "appliance.ImageBundle"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "appliance.ImageBundle"]
**Moid** | **String** | The unique identifier of this Managed Object instance. | [optional] 
**Selector** | **String** | An OData $filter expression which describes the REST resource to be referenced. This field may be set instead of &#39;moid&#39; by clients. 1. If &#39;moid&#39; is set this field is ignored. 1. If &#39;selector&#39; is set and &#39;moid&#39; is empty/absent from the request, Intersight determines the Moid of the resource matching the filter expression and populates it in the MoRef that is part of the object instance being inserted/updated to fulfill the REST request. An error is returned if the filter matches zero or more than one REST resource. An example filter string is: Serial eq &#39;3AA8B7T11&#39;. | [optional] [readonly] 
**Link** | **String** | A URL to an instance of the &#39;mo.MoRef&#39; class. | [optional] 
**AccountMoid** | **String** | The Account ID for this managed object. | [optional] [readonly] 
**CreateTime** | **System.DateTime** | The time when this managed object was created. | [optional] [readonly] 
**DomainGroupMoid** | **String** | The DomainGroup ID for this managed object. | [optional] [readonly] 
**ModTime** | **System.DateTime** | The time when this managed object was last modified. | [optional] [readonly] 
**Owners** | **String[]** |  | [optional] 
**SharedScope** | **String** | Intersight provides pre-built workflows, tasks and policies to end users through global catalogs. Objects that are made available through global catalogs are said to have a &#39;shared&#39; ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs. | [optional] [readonly] 
**Tags** | [**MoTag[]**](MoTag.md) |  | [optional] 
**VersionContext** | [**MoVersionContext**](MoVersionContext.md) |  | [optional] 
**Var0ClusterReplicationNetworkPolicy** | [**HyperflexClusterReplicationNetworkPolicyRelationship**](HyperflexClusterReplicationNetworkPolicyRelationship.md) |  | [optional] 
**Ancestors** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**Parent** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 
**PermissionResources** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**DisplayNames** | [**System.Collections.Hashtable**](Array.md) | A set of display names for the MO resource. These names are calculated based on other properties of the MO and potentially properties of Ancestor MOs. Displaynames are intended as a way to provide a normalized user appropriate name for an MO, especially for MOs which do not have a &#39;Name&#39; property, which is the case for much of the inventory discovered from managed targets. There are a limited number of keys, currently &#39;short&#39; and &#39;hierarchical&#39;. The value is an array and clients should use the first element of the array. | [optional] [readonly] 
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
**Priority** | **String** | Software upgrade manifest&#39;s upgrade priority. The upgrade service supports two priorities, Normal and Critical. Normal priority is used for regular software upgrades, and the upgrade service uses the Upgrade Policy to compute upgrade start time. Critical priority is used for the critical software security patches, and the upgrade service ignores the Upgrade Policy when it computes the upgrade start time. * &#x60;Normal&#x60; - Normal upgrade priority is used for all the software upgrades except for the critical security updates. The upgrade service of Intersight Appliance uses the Software Upgrade Policy settings to start the upgrade process. * &#x60;Critical&#x60; - Critical upgrade priority is used for critical updates such as security patches. The upgrade service of the Intersight Appliance starts the upgrade as specified by the upgrade properties in the software manifest file. The upgrade service will not use the settings specified in the Software Upgrade Policy. | [optional] [readonly] [default to "Normal"]
**ReleaseTime** | **System.DateTime** | Software upgrade manifest&#39;s release date and time. | [optional] [readonly] 
**ServicePackages** | [**OnpremImagePackage[]**](OnpremImagePackage.md) |  | [optional] 
**StatusMessage** | **String** | Status message set during the manifest processing. | [optional] [readonly] 
**SystemPackages** | [**OnpremImagePackage[]**](OnpremImagePackage.md) |  | [optional] 
**UiPackages** | [**OnpremImagePackage[]**](OnpremImagePackage.md) |  | [optional] 
**UpgradeEndTime** | **System.DateTime** | End date of the software upgrade process. | [optional] [readonly] 
**UpgradeGracePeriod** | **Int64** | Grace period in seconds before the automatic upgrade is initiated. The upgrade service uses the grace period to compute the upgrade start time when it receives an upgrade notfication from the Intersight. If there is an Upgrade Policy configured for the Intersight Appliance, then the upgrade service uses the policy to compute the upgrade start time. However, the upgrade start time cannot not exceed the limit enforced by the grace period. | [optional] [readonly] 
**UpgradeImpactDuration** | **Int64** | Duration (in minutes) for which services will be disrupted. | [optional] [readonly] [default to 0]
**UpgradeImpactEnum** | **String** | UpgradeImpactEnum is used to indicate the kind of impact the upgrade has on currently running services on the appliance. * &#x60;None&#x60; - The upgrade has no effect on the system. * &#x60;Disruptive&#x60; - The services will not be functional during the upgrade. * &#x60;Disruptive-reboot&#x60; - The upgrade needs a reboot. | [optional] [readonly] [default to "None"]
**UpgradeStartTime** | **System.DateTime** | Start date of the software upgrade process. | [optional] [readonly] 
**Version** | **String** | Software upgrade manifest&#39;s version. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$ApplianceImageBundleRelationship = Initialize-IntersightApplianceImageBundleRelationship  -ClassId null `
 -ObjectType null `
 -Moid null `
 -Selector null `
 -Link null `
 -AccountMoid null `
 -CreateTime null `
 -DomainGroupMoid null `
 -ModTime null `
 -Owners null `
 -SharedScope null `
 -Tags null `
 -VersionContext null `
 -Var0ClusterReplicationNetworkPolicy null `
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
$ApplianceImageBundleRelationship | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

