# FirmwareUpgradeBaseAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. The enum values provides the list of concrete types that can be instantiated from this abstract type. | 
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. The enum values provides the list of concrete types that can be instantiated from this abstract type. | 
**DirectDownload** | [**FirmwareDirectDownload**](FirmwareDirectDownload.md) |  | [optional] 
**FileServer** | [**SoftwarerepositoryFileServer**](SoftwarerepositoryFileServer.md) |  | [optional] 
**NetworkShare** | [**FirmwareNetworkShare**](FirmwareNetworkShare.md) |  | [optional] 
**SkipEstimateImpact** | **Boolean** | User has the option to skip the estimate impact calculation. | [optional] 
**Status** | **String** | Status of the upgrade operation. * &#x60;NONE&#x60; - Upgrade status is not populated. * &#x60;IN_PROGRESS&#x60; - The upgrade is in progress. * &#x60;SUCCESSFUL&#x60; - The upgrade successfully completed. * &#x60;FAILED&#x60; - The upgrade shows failed status. * &#x60;TERMINATED&#x60; - The upgrade has been terminated. | [optional] [default to "NONE"]
**UpgradeType** | **String** | Desired upgrade mode to choose either direct download based upgrade or network share upgrade. * &#x60;direct_upgrade&#x60; - Upgrade mode is direct download. * &#x60;network_upgrade&#x60; - Upgrade mode is network upgrade. | [optional] [default to "direct_upgrade"]
**Distributable** | [**FirmwareDistributableRelationship**](FirmwareDistributableRelationship.md) |  | [optional] 
**Release** | [**SoftwarerepositoryReleaseRelationship**](SoftwarerepositoryReleaseRelationship.md) |  | [optional] 
**UpgradeImpact** | [**FirmwareUpgradeImpactStatusRelationship**](FirmwareUpgradeImpactStatusRelationship.md) |  | [optional] 
**UpgradeStatus** | [**FirmwareUpgradeStatusRelationship**](FirmwareUpgradeStatusRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$FirmwareUpgradeBaseAllOf = Initialize-IntersightFirmwareUpgradeBaseAllOf  -ClassId null `
 -ObjectType null `
 -DirectDownload null `
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
$FirmwareUpgradeBaseAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

