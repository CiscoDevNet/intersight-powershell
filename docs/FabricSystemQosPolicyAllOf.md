# FabricSystemQosPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "fabric.SystemQosPolicy"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "fabric.SystemQosPolicy"]
**Classes** | [**FabricQosClass[]**](FabricQosClass.md) |  | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 
**Profiles** | [**FabricSwitchProfileRelationship[]**](FabricSwitchProfileRelationship.md) | An array of relationships to fabricSwitchProfile resources. | [optional] 

## Examples

- Prepare the resource
```powershell
$FabricSystemQosPolicyAllOf = Initialize-IntersightFabricSystemQosPolicyAllOf  -ClassId null `
 -ObjectType null `
 -Classes null `
 -Organization null `
 -Profiles null
```

- Convert the resource to JSON
```powershell
$FabricSystemQosPolicyAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

