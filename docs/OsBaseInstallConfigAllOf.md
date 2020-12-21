# OsBaseInstallConfigAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. The enum values provides the list of concrete types that can be instantiated from this abstract type. | [default to "os.Install"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. The enum values provides the list of concrete types that can be instantiated from this abstract type. | [default to "os.Install"]
**AdditionalParameters** | [**OsPlaceHolder[]**](OsPlaceHolder.md) |  | [optional] 
**Answers** | [**OsAnswers**](OsAnswers.md) |  | [optional] 
**Description** | **String** | User provided description about the OS install configuration. | [optional] 
**InstallMethod** | **String** | The install method to be used for OS installation - vMedia, iPXE.  Only vMedia is supported as of now. * &#x60;vMedia&#x60; - OS image is mounted as vMedia in target server for OS installation. | [optional] [default to "vMedia"]
**InstallTarget** | [**OsInstallTarget**](OsInstallTarget.md) |  | [optional] 
**OperatingSystemParameters** | [**OsOperatingSystemParameters**](OsOperatingSystemParameters.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$OsBaseInstallConfigAllOf = Initialize-IntersightOsBaseInstallConfigAllOf  -ClassId null `
 -ObjectType null `
 -AdditionalParameters null `
 -Answers null `
 -Description null `
 -InstallMethod null `
 -InstallTarget null `
 -OperatingSystemParameters null
```

- Convert the resource to JSON
```powershell
$OsBaseInstallConfigAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

