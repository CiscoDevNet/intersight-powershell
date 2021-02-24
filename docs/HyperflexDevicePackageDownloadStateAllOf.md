# HyperflexDevicePackageDownloadStateAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.DevicePackageDownloadState"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.DevicePackageDownloadState"]
**Checksum** | **String** | Checksum of HyperFlex health check Debian package installed on the HyperFlex Device. | [optional] 
**HxDeviceName** | **String** | HyperFlex Device Name for which the package download state is tracked. | [optional] [readonly] 
**HxNodes** | **String[]** |  | [optional] 
**Timestamp** | **System.DateTime** | Timestamp of the last health check Debian package installation on the HyperFlex Device. | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$HyperflexDevicePackageDownloadStateAllOf = Initialize-IntersightHyperflexDevicePackageDownloadStateAllOf  -ClassId null `
 -ObjectType null `
 -Checksum null `
 -HxDeviceName null `
 -HxNodes null `
 -Timestamp null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$HyperflexDevicePackageDownloadStateAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

