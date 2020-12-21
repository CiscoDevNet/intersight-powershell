# SdwanVmanageAccountPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "sdwan.VmanageAccountPolicy"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "sdwan.VmanageAccountPolicy"]
**EndpointAddress** | **String** | VManage server hostname (FQDN) that the acccount holds information for. | [optional] 
**IsPasswordSet** | **Boolean** | Indicates whether the value of the &#39;password&#39; property has been set. | [optional] [readonly] [default to $false]
**Password** | **String** | Local password for authenticating with the vManage server. | [optional] 
**Port** | **Int64** | VManage Port number on which the application is running. | [optional] [default to 8443]
**Username** | **String** | Local username for authenticating with the vManage server. | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 
**Profiles** | [**SdwanProfileRelationship[]**](SdwanProfileRelationship.md) | An array of relationships to sdwanProfile resources. | [optional] 

## Examples

- Prepare the resource
```powershell
$SdwanVmanageAccountPolicyAllOf = Initialize-IntersightSdwanVmanageAccountPolicyAllOf  -ClassId null `
 -ObjectType null `
 -EndpointAddress null `
 -IsPasswordSet null `
 -Password null `
 -Port null `
 -Username null `
 -Organization null `
 -Profiles null
```

- Convert the resource to JSON
```powershell
$SdwanVmanageAccountPolicyAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

