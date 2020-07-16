# HclFirmwareAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DriverName** | **String** | Protocol for which the driver is provided. E.g.  enic, fnic, lsi_mr3. | [optional] 
**DriverVersion** | **String** | Version of the Driver supported. | [optional] 
**ErrorCode** | **String** | Error code for the support status. | [optional] [readonly] [default to "Success"]
**FirmwareVersion** | **String** | Firmware version of the product/adapter supported. | [optional] 
**Id** | **String** | Identifier of the firmware. | [optional] 
**LatestDriver** | **Boolean** | True if the driver is latest recommended driver. | [optional] [readonly] 
**LatestFirmware** | **Boolean** | True if the firmware is latest recommended firmware. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightHclFirmwareAllOf  -DriverName null `
 -DriverVersion null `
 -ErrorCode null `
 -FirmwareVersion null `
 -Id null `
 -LatestDriver null `
 -LatestFirmware null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

