# FabricSwitchClusterProfileAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ConfigContext** | [**PolicyConfigContext**](PolicyConfigContext.md) |  | [optional] 
**SwitchProfilesCount** | **Int64** | Number of switch profiles that are part of this cluster profile. | [optional] [readonly] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 
**SwitchProfiles** | [**FabricSwitchProfileRelationship[]**](FabricSwitchProfileRelationship.md) | An array of relationships to fabricSwitchProfile resources. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightFabricSwitchClusterProfileAllOf  -ConfigContext null `
 -SwitchProfilesCount null `
 -Organization null `
 -SwitchProfiles null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

