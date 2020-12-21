# TamSecurityAdvisory
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "tam.SecurityAdvisory"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "tam.SecurityAdvisory"]
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
**Description** | **String** | Brief description of the advisory details. | [optional] 
**Name** | **String** | A user defined name for the Intersight Advisory. | [optional] 
**Severity** | [**TamSeverity**](TamSeverity.md) |  | [optional] 
**State** | **String** | Current state of the advisory. * &#x60;ready&#x60; - Advisory has been evaluated. The affected devices would be analyzed and corresponding advisory instances would be created. * &#x60;evaluating&#x60; - Advisory is currently under evaluation. The affected devices would be analyzed but no advisory instances wouldbe created. The results of the analysis would be made available to Intersight engineering for evaluation and validation. | [optional] [default to "ready"]
**Actions** | [**TamAction[]**](TamAction.md) |  | [optional] 
**AdvisoryId** | **String** | Cisco generated identifier for the published security advisory. | [optional] 
**ApiDataSources** | [**TamApiDataSource[]**](TamApiDataSource.md) |  | [optional] 
**BaseScore** | **Double** | CVSS version 3 base score for the security Advisory. | [optional] 
**CveIds** | **String[]** |  | [optional] 
**DatePublished** | **System.DateTime** | Date when the security advisory was first published by Cisco. | [optional] 
**DateUpdated** | **System.DateTime** | Date when the security advisory was last updated by Cisco. | [optional] 
**EnvironmentalScore** | **Double** | CVSS version 3 environmental score for the security Advisory. | [optional] 
**ExternalUrl** | **String** | A link to an external URL describing security Advisory in more details. | [optional] 
**Recommendation** | **String** | Recommended action to resolve the security advisory. | [optional] 
**Status** | **String** | Cisco assigned status of the published advisory based on whether the investigation is complete or on-going. * &#x60;interim&#x60; - The Cisco investigation for the advisory is ongoing. Cisco will issue revisions to the advisory when additional information, including fixed software release data, becomes available. * &#x60;final&#x60; - Cisco has completed its evaluation of the vulnerability described in the advisory. There will be no further updates unless there is a material change in the nature of the vulnerability. | [optional] [default to "interim"]
**TemporalScore** | **Double** | CVSS version 3 temporal score for the security Advisory. | [optional] 
**Version** | **String** | Cisco assigned advisory version after latest revision. | [optional] 
**Workaround** | **String** | Workarounds available for the advisory. | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$TamSecurityAdvisory = Initialize-IntersightTamSecurityAdvisory  -ClassId null `
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
 -Description null `
 -Name null `
 -Severity null `
 -State null `
 -Actions null `
 -AdvisoryId null `
 -ApiDataSources null `
 -BaseScore null `
 -CveIds null `
 -DatePublished null `
 -DateUpdated null `
 -EnvironmentalScore null `
 -ExternalUrl null `
 -Recommendation null `
 -Status null `
 -TemporalScore null `
 -Version null `
 -Workaround null `
 -Organization null
```

- Convert the resource to JSON
```powershell
$TamSecurityAdvisory | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

