# HclDriverImageAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DriverIsoUrl** | **String** | URL of the driver ISO images. | [optional] 
**ManagementType** | **String** | Type of the UCS version indicating whether it is a UCSM release vesion or a IMC release. | [optional] [default to "UCSM"]
**ServerPid** | **String** | Three part ID representing the server model as returned by UCSM/CIMC XML APIs. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightHclDriverImageAllOf  -DriverIsoUrl null `
 -ManagementType null `
 -ServerPid null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

