# HyperflexAutoSupportPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.AutoSupportPolicy"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.AutoSupportPolicy"]
**AdminState** | **Boolean** | Enable or disable Auto-Support. | [optional] [default to $true]
**ServiceTicketReceipient** | **String** | The recipient email address for support tickets. | [optional] 
**ClusterProfiles** | [**HyperflexClusterProfileRelationship[]**](HyperflexClusterProfileRelationship.md) | An array of relationships to hyperflexClusterProfile resources. | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$HyperflexAutoSupportPolicyAllOf = Initialize-IntersightHyperflexAutoSupportPolicyAllOf  -ClassId null `
 -ObjectType null `
 -AdminState null `
 -ServiceTicketReceipient null `
 -ClusterProfiles null `
 -Organization null
```

- Convert the resource to JSON
```powershell
$HyperflexAutoSupportPolicyAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

