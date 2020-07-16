# SdwanProfileAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 
**RouterNodes** | [**SdwanRouterNodeRelationship[]**](SdwanRouterNodeRelationship.md) | An array of relationships to sdwanRouterNode resources. | [optional] 
**RouterPolicy** | [**SdwanRouterPolicyRelationship**](SdwanRouterPolicyRelationship.md) |  | [optional] 
**VmanageAccount** | [**SdwanVmanageAccountPolicyRelationship**](SdwanVmanageAccountPolicyRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightSdwanProfileAllOf  -Organization null `
 -RouterNodes null `
 -RouterPolicy null `
 -VmanageAccount null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

