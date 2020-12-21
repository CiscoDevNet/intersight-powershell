# EquipmentFexIdentityAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "equipment.FexIdentity"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "equipment.FexIdentity"]
**SwitchId** | **Int64** | Switch ID to which Fabric Extender is connected, ID can be either 1 or 2, equalent to A or B. | [optional] 
**Fex** | [**EquipmentFexRelationship**](EquipmentFexRelationship.md) |  | [optional] 
**NetworkElement** | [**NetworkElementRelationship**](NetworkElementRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$EquipmentFexIdentityAllOf = Initialize-IntersightEquipmentFexIdentityAllOf  -ClassId null `
 -ObjectType null `
 -SwitchId null `
 -Fex null `
 -NetworkElement null
```

- Convert the resource to JSON
```powershell
$EquipmentFexIdentityAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

