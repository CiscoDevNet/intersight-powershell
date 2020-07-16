# FirmwareFirmwareSummaryAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BundleVersion** | **String** | Version details at the bundle level for the each of server. | [optional] 
**ComponentsFwInventory** | [**FirmwareFirmwareInventory[]**](FirmwareFirmwareInventory.md) |  | [optional] 
**Server** | [**ComputePhysicalRelationship**](ComputePhysicalRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightFirmwareFirmwareSummaryAllOf  -BundleVersion null `
 -ComponentsFwInventory null `
 -Server null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

