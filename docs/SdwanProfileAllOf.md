# SdwanProfileAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "sdwan.Profile"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "sdwan.Profile"]
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 
**RouterNodes** | [**SdwanRouterNodeRelationship[]**](SdwanRouterNodeRelationship.md) | An array of relationships to sdwanRouterNode resources. | [optional] 
**RouterPolicy** | [**SdwanRouterPolicyRelationship**](SdwanRouterPolicyRelationship.md) |  | [optional] 
**VmanageAccount** | [**SdwanVmanageAccountPolicyRelationship**](SdwanVmanageAccountPolicyRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$SdwanProfileAllOf = Initialize-IntersightSdwanProfileAllOf  -ClassId null `
 -ObjectType null `
 -Organization null `
 -RouterNodes null `
 -RouterPolicy null `
 -VmanageAccount null
```

- Convert the resource to JSON
```powershell
$SdwanProfileAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

