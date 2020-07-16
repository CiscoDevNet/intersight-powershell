# TamAdvisoryDefinition
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
**Description** | **String** | Brief description of the advisory details. | [optional] 
**Name** | **String** | A user defined name for the Intersight Advisory. | [optional] 
**Severity** | [**TamSeverity**](TamSeverity.md) |  | [optional] 
**State** | **String** | Current state of the advisory. | [optional] [default to "ready"]
**Actions** | [**TamAction[]**](TamAction.md) |  | [optional] 
**AdvisoryDetails** | [**TamBaseAdvisoryDetails**](TamBaseAdvisoryDetails.md) |  | [optional] 
**AdvisoryId** | **String** | Cisco generated identifier for the published security advisory. | [optional] 
**ApiDataSources** | [**TamApiDataSource[]**](TamApiDataSource.md) |  | [optional] 
**DatePublished** | **System.DateTime** | Date when the security advisory was first published by Cisco. | [optional] 
**DateUpdated** | **System.DateTime** | Date when the security advisory was last updated by Cisco. | [optional] 
**ExternalUrl** | **String** | A link to an external URL describing security Advisory in more details. | [optional] 
**Recommendation** | **String** | Recommended action to resolve the security advisory. | [optional] 
**Type** | **String** | The type (field notice, security advisory etc.) of Intersight advisory. | [optional] [default to "securityAdvisory"]
**Version** | **String** | Cisco assigned advisory version after latest revision. | [optional] 
**Workaround** | **String** | Workarounds available for the advisory. | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightTamAdvisoryDefinition  -AccountMoid null `
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
 -Description null `
 -Name null `
 -Severity null `
 -State null `
 -Actions null `
 -AdvisoryDetails null `
 -AdvisoryId null `
 -ApiDataSources null `
 -DatePublished null `
 -DateUpdated null `
 -ExternalUrl null `
 -Recommendation null `
 -Type null `
 -Version null `
 -Workaround null `
 -Organization null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

