# HyperflexHealthCheckPackageChecksumAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.HealthCheckPackageChecksum"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.HealthCheckPackageChecksum"]
**Checksum** | **String** | SHA512 checksum of the health check package. | [optional] 
**Name** | **String** | Name of the health check Debian package. | [optional] 
**PackageName** | **String** | HyperFlex health check Debian package file name. | [optional] 
**Timestamp** | **System.DateTime** | Timestamp of last update of HyperFlex health check package checksum. | [optional] 
**Version** | **String** | HyperFlex health check Debian Package Version. | [optional] 

## Examples

- Prepare the resource
```powershell
$HyperflexHealthCheckPackageChecksumAllOf = Initialize-IntersightHyperflexHealthCheckPackageChecksumAllOf  -ClassId null `
 -ObjectType null `
 -Checksum null `
 -Name null `
 -PackageName null `
 -Timestamp null `
 -Version null
```

- Convert the resource to JSON
```powershell
$HyperflexHealthCheckPackageChecksumAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

