# TamSecurityAdvisoryAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "tam.SecurityAdvisory"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "tam.SecurityAdvisory"]
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
$TamSecurityAdvisoryAllOf = Initialize-IntersightTamSecurityAdvisoryAllOf  -ClassId null `
 -ObjectType null `
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
$TamSecurityAdvisoryAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

