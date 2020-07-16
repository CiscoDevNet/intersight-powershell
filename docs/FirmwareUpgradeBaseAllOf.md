# FirmwareUpgradeBaseAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DirectDownload** | [**FirmwareDirectDownload**](FirmwareDirectDownload.md) |  | [optional] 
**FileServer** | [**SoftwarerepositoryFileServer**](SoftwarerepositoryFileServer.md) |  | [optional] 
**NetworkShare** | [**FirmwareNetworkShare**](FirmwareNetworkShare.md) |  | [optional] 
**SkipEstimateImpact** | **Boolean** | User has the option to skip the estimate impact calculation. | [optional] 
**Status** | **String** | Status of the upgrade operation. | [optional] [default to "NONE"]
**UpgradeType** | **String** | Desired upgrade mode to choose either direct download based upgrade or network share upgrade. | [optional] [default to "direct_upgrade"]
**Distributable** | [**FirmwareDistributableRelationship**](FirmwareDistributableRelationship.md) |  | [optional] 
**Release** | [**SoftwarerepositoryReleaseRelationship**](SoftwarerepositoryReleaseRelationship.md) |  | [optional] 
**UpgradeImpact** | [**FirmwareUpgradeImpactStatusRelationship**](FirmwareUpgradeImpactStatusRelationship.md) |  | [optional] 
**UpgradeStatus** | [**FirmwareUpgradeStatusRelationship**](FirmwareUpgradeStatusRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightFirmwareUpgradeBaseAllOf  -DirectDownload null `
 -FileServer null `
 -NetworkShare null `
 -SkipEstimateImpact null `
 -Status null `
 -UpgradeType null `
 -Distributable null `
 -Release null `
 -UpgradeImpact null `
 -UpgradeStatus null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

