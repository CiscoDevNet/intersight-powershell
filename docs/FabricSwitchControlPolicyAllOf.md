# FabricSwitchControlPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "fabric.SwitchControlPolicy"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "fabric.SwitchControlPolicy"]
**MacAgingSettings** | [**FabricMacAgingSettings**](FabricMacAgingSettings.md) |  | [optional] 
**VlanPortOptimizationEnabled** | **Boolean** | To enable or disable the VLAN port count optimization. | [optional] [default to $false]
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 
**Profiles** | [**FabricSwitchProfileRelationship[]**](FabricSwitchProfileRelationship.md) | An array of relationships to fabricSwitchProfile resources. | [optional] 

## Examples

- Prepare the resource
```powershell
$FabricSwitchControlPolicyAllOf = Initialize-IntersightFabricSwitchControlPolicyAllOf  -ClassId null `
 -ObjectType null `
 -MacAgingSettings null `
 -VlanPortOptimizationEnabled null `
 -Organization null `
 -Profiles null
```

- Convert the resource to JSON
```powershell
$FabricSwitchControlPolicyAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

