# AssetSudiInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "asset.SudiInfo"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "asset.SudiInfo"]
**VarPid** | **String** | The device model (PID) extracted from the X.509 SUDI Leaf Certificate. | [optional] 
**SerialNumber** | **String** | The device SerialNumber extracted from the X.509 SUDI Leaf Certiicate. | [optional] 
**Signature** | **String** | The signature is obtained by taking the base64 encoding of the Serial Number + PID + Status, taking the SHA256 hash and then signing with the SUDI X.509 Leaf Certifiate. | [optional] 
**Status** | **String** | The validation status of the device. * &#x60;DeviceStatusUnknown&#x60; - SUDI validation is done on the establishment of a connection. Before a device connects or after it disconnects, the SUDI validation status is set to this value. * &#x60;Verified&#x60; - The device returned a valid PID, Serial Number, Status and X.509 Leaf Certificate. The certificate signing chain was validated. * &#x60;CertificateValidationFailed&#x60; - Validation of the certificate signing chain failed. * &#x60;UnsupportedFirmware&#x60; - The firmware version of the Cisco IMC that is installed does not contain the SUDI APIs needed to perform validation. * &#x60;UnsupportedHardware&#x60; - The device is a model that does not contain a Trust Anchor Module (TAM) and thus cannot be validated. * &#x60;DeviceNotResponding&#x60; - An request was sent to the device, but no response was received. | [optional] [default to "DeviceStatusUnknown"]
**SudiCertificate** | [**X509Certificate**](X509Certificate.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$AssetSudiInfo = Initialize-IntersightAssetSudiInfo  -ClassId null `
 -ObjectType null `
 -VarPid null `
 -SerialNumber null `
 -Signature null `
 -Status null `
 -SudiCertificate null
```

- Convert the resource to JSON
```powershell
$AssetSudiInfo | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

