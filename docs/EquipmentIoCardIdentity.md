# EquipmentIoCardIdentity
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "equipment.IoCardIdentity"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "equipment.IoCardIdentity"]
**IoCardMoid** | **String** | MO Reference to equipmentIoCard MO in inventory service. | [optional] 
**ModuleId** | **Int64** | IOM/MUX Module ID connected to the FI. | [optional] 
**NetworkElementMoid** | **String** | MO Reference to networkElement MO in inventory service. | [optional] 
**SwitchId** | **Int64** | Switch ID to which IOM is connected, ID can be either 1 or 2, equalent to A or B. | [optional] 

## Examples

- Prepare the resource
```powershell
$EquipmentIoCardIdentity = Initialize-IntersightEquipmentIoCardIdentity  -ClassId null `
 -ObjectType null `
 -IoCardMoid null `
 -ModuleId null `
 -NetworkElementMoid null `
 -SwitchId null
```

- Convert the resource to JSON
```powershell
$EquipmentIoCardIdentity | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

