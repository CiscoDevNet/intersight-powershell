# TamAdvisoryDefinitionAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
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
Initialize-IntersightTamAdvisoryDefinitionAllOf  -Actions null `
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

