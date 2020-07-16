# ConnectorFileChecksumAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Hash** | [**SystemByte**](SystemByte.md) | The calculated hash of the contents using the algorithm. | [optional] 
**HashAlgorithm** | **String** | The hash algorithm used to calculate the checksum. | [optional] [default to "crc"]

## Examples

- Prepare the resource
```powershell
Initialize-IntersightConnectorFileChecksumAllOf  -Hash null `
 -HashAlgorithm null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

