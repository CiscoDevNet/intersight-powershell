# EquipmentChassisIdentityAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IoCardIdentityList** | [**EquipmentIoCardIdentity[]**](EquipmentIoCardIdentity.md) |  | [optional] 
**Chassis** | [**EquipmentChassisRelationship**](EquipmentChassisRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightEquipmentChassisIdentityAllOf  -IoCardIdentityList null `
 -Chassis null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

