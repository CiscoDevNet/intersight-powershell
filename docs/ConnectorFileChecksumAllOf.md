# ConnectorFileChecksumAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "connector.FileChecksum"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "connector.FileChecksum"]
**Hash** | [**SystemByte**](SystemByte.md) | The calculated hash of the contents using the algorithm. | [optional] 
**HashAlgorithm** | **String** | The hash algorithm used to calculate the checksum. * &#x60;crc&#x60; - A CRC hash as definded by RFC 3385. Generated with the IEEE polynomial. * &#x60;sha256&#x60; - A SHA256 hash as defined by RFC 4634. | [optional] [default to "crc"]

## Examples

- Prepare the resource
```powershell
$ConnectorFileChecksumAllOf = Initialize-IntersightConnectorFileChecksumAllOf  -ClassId null `
 -ObjectType null `
 -Hash null `
 -HashAlgorithm null
```

- Convert the resource to JSON
```powershell
$ConnectorFileChecksumAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

