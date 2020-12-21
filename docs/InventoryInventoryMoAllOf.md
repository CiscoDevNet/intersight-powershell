# InventoryInventoryMoAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "inventory.InventoryMo"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "inventory.InventoryMo"]
**MoDn** | **String** | The UCS DN of the MO for which the latest inventory to be fetched. If this property is empty and moId property has the Moid of the MO to be updated, the Moid will be used. If this property is empty and moId is also empty, all the MOs of the given moType will be updated. | [optional] 
**MoId** | **String** | The MO id of an MO for which the latest inventory to be fetched. If this property is empty and moDn property has the UCS DN of the MO to be updated, the DN will be used. If this property is empty and moDn is also empty, all the MOs of the given moType will be updated. | [optional] 
**MoType** | **String** | The type of the MO for which the latest inventory to be fetched. | [optional] 

## Examples

- Prepare the resource
```powershell
$InventoryInventoryMoAllOf = Initialize-IntersightInventoryInventoryMoAllOf  -ClassId null `
 -ObjectType null `
 -MoDn null `
 -MoId null `
 -MoType null
```

- Convert the resource to JSON
```powershell
$InventoryInventoryMoAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

