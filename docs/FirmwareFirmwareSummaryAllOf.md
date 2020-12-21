# FirmwareFirmwareSummaryAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "firmware.FirmwareSummary"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "firmware.FirmwareSummary"]
**BundleVersion** | **String** | Version details at the bundle level for the each of server. | [optional] 
**ComponentsFwInventory** | [**FirmwareFirmwareInventory[]**](FirmwareFirmwareInventory.md) |  | [optional] 
**Server** | [**ComputePhysicalRelationship**](ComputePhysicalRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$FirmwareFirmwareSummaryAllOf = Initialize-IntersightFirmwareFirmwareSummaryAllOf  -ClassId null `
 -ObjectType null `
 -BundleVersion null `
 -ComponentsFwInventory null `
 -Server null
```

- Convert the resource to JSON
```powershell
$FirmwareFirmwareSummaryAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

