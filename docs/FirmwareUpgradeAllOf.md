# FirmwareUpgradeAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExcludeComponentList** | **String[]** |  | [optional] 
**Device** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**Server** | [**ComputePhysicalRelationship**](ComputePhysicalRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightFirmwareUpgradeAllOf  -ExcludeComponentList null `
 -Device null `
 -Server null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

