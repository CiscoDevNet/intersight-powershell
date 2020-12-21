# FabricFcNetworkPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "fabric.FcNetworkPolicy"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "fabric.FcNetworkPolicy"]
**EnableTrunking** | **Boolean** | Enable or Disable Trunking on all of configured FC uplink ports. | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 
**Profiles** | [**FabricSwitchProfileRelationship[]**](FabricSwitchProfileRelationship.md) | An array of relationships to fabricSwitchProfile resources. | [optional] 

## Examples

- Prepare the resource
```powershell
$FabricFcNetworkPolicyAllOf = Initialize-IntersightFabricFcNetworkPolicyAllOf  -ClassId null `
 -ObjectType null `
 -EnableTrunking null `
 -Organization null `
 -Profiles null
```

- Convert the resource to JSON
```powershell
$FabricFcNetworkPolicyAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

