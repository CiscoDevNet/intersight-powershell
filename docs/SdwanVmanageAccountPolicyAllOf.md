# SdwanVmanageAccountPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EndpointAddress** | **String** | VManage server hostname (FQDN) that the acccount holds information for. | [optional] 
**IsPasswordSet** | **Boolean** | Indicates whether the value of the &#39;password&#39; property has been set. | [optional] [readonly] 
**Password** | **String** | Local password for authenticating with the vManage server. | [optional] 
**Port** | **Int64** | VManage Port number on which the application is running. | [optional] 
**Username** | **String** | Local username for authenticating with the vManage server. | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 
**Profiles** | [**SdwanProfileRelationship[]**](SdwanProfileRelationship.md) | An array of relationships to sdwanProfile resources. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightSdwanVmanageAccountPolicyAllOf  -EndpointAddress null `
 -IsPasswordSet null `
 -Password null `
 -Port null `
 -Username null `
 -Organization null `
 -Profiles null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

