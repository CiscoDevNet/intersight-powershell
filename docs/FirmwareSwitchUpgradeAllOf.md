# FirmwareSwitchUpgradeAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Device** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**NetworkElements** | [**NetworkElementRelationship[]**](NetworkElementRelationship.md) | An array of relationships to networkElement resources. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightFirmwareSwitchUpgradeAllOf  -Device null `
 -NetworkElements null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

