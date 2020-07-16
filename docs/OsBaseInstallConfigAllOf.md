# OsBaseInstallConfigAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdditionalParameters** | [**OsPlaceHolder[]**](OsPlaceHolder.md) |  | [optional] 
**Answers** | [**OsAnswers**](OsAnswers.md) |  | [optional] 
**Description** | **String** | User provided description about the OS install configuration. | [optional] 
**InstallMethod** | **String** | The install method to be used for OS installation - vMedia, iPXE.  Only vMedia is supported as of now. | [optional] [default to "vMedia"]
**OperatingSystemParameters** | [**OsOperatingSystemParameters**](OsOperatingSystemParameters.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightOsBaseInstallConfigAllOf  -AdditionalParameters null `
 -Answers null `
 -Description null `
 -InstallMethod null `
 -OperatingSystemParameters null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

