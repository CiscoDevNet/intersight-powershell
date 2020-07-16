# TamSecurityAdvisoryAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Actions** | [**TamAction[]**](TamAction.md) |  | [optional] 
**AdvisoryId** | **String** | Cisco generated identifier for the published security advisory. | [optional] 
**ApiDataSources** | [**TamApiDataSource[]**](TamApiDataSource.md) |  | [optional] 
**BaseScore** | **Decimal** | CVSS version 3 base score for the security Advisory. | [optional] 
**CveIds** | **String[]** |  | [optional] 
**DatePublished** | **System.DateTime** | Date when the security advisory was first published by Cisco. | [optional] 
**DateUpdated** | **System.DateTime** | Date when the security advisory was last updated by Cisco. | [optional] 
**EnvironmentalScore** | **Decimal** | CVSS version 3 environmental score for the security Advisory. | [optional] 
**ExternalUrl** | **String** | A link to an external URL describing security Advisory in more details. | [optional] 
**Recommendation** | **String** | Recommended action to resolve the security advisory. | [optional] 
**Status** | **String** | Cisco assigned status of the published advisory based on whether the investigation is complete or on-going. | [optional] [default to "interim"]
**TemporalScore** | **Decimal** | CVSS version 3 temporal score for the security Advisory. | [optional] 
**Version** | **String** | Cisco assigned advisory version after latest revision. | [optional] 
**Workaround** | **String** | Workarounds available for the advisory. | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightTamSecurityAdvisoryAllOf  -Actions null `
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
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

