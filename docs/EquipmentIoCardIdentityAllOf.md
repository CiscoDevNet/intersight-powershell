# EquipmentIoCardIdentityAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IoCardMoid** | **String** | MO Reference to equipmentIoCard MO in inventory service. | [optional] 
**ModuleId** | **Int64** | IOM/MUX Module ID connected to the FI. | [optional] 
**NetworkElementMoid** | **String** | MO Reference to networkElement MO in inventory service. | [optional] 
**SwitchId** | **Int64** | Switch ID to which IOM is connected, ID can be either 1 or 2, equalent to A or B. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightEquipmentIoCardIdentityAllOf  -IoCardMoid null `
 -ModuleId null `
 -NetworkElementMoid null `
 -SwitchId null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

