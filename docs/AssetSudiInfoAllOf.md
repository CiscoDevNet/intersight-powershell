# AssetSudiInfoAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VarPid** | **String** | The device model (PID) extracted from the X.509 SUDI Leaf Certificate. | [optional] 
**SerialNumber** | **String** | The device SerialNumber extracted from the X.509 SUDI Leaf Certiicate. | [optional] 
**Signature** | **String** | The signature is obtained by taking the base64 encoding of the Serial Number + PID + Status, taking the SHA256 hash and then signing with the SUDI X.509 Leaf Certifiate. | [optional] 
**Status** | **String** | The validation status of the device. | [optional] [default to "DeviceStatusUnknown"]
**SudiCertificate** | [**X509Certificate**](X509Certificate.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightAssetSudiInfoAllOf  -VarPid null `
 -SerialNumber null `
 -Signature null `
 -Status null `
 -SudiCertificate null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

