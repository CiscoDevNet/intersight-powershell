# AssetSudiInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
**VarPid** | **String** | The device model (PID) extracted from the X.509 SUDI Leaf Certificate. | [optional] 
**SerialNumber** | **String** | The device SerialNumber extracted from the X.509 SUDI Leaf Certiicate. | [optional] 
**Signature** | **String** | The signature is obtained by taking the base64 encoding of the Serial Number + PID + Status, taking the SHA256 hash and then signing with the SUDI X.509 Leaf Certifiate. | [optional] 
**Status** | **String** | The validation status of the device. | [optional] [default to "DeviceStatusUnknown"]
**SudiCertificate** | [**X509Certificate**](X509Certificate.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightAssetSudiInfo  -ClassId null `
 -ObjectType null `
 -VarPid null `
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

