# AssetClientCertificateCredential
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "asset.ClientCertificateCredential"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "asset.ClientCertificateCredential"]
**ClientCertificate** | **String** | PEM encoded x509 client certificate used to authenticate with the target. | [optional] 
**ClientKey** | **String** | PEM encoded private key used to authenticate with the target. | [optional] 
**IsClientKeySet** | **Boolean** | Indicates whether the value of the &#39;clientKey&#39; property has been set. | [optional] [readonly] [default to $false]

## Examples

- Prepare the resource
```powershell
$AssetClientCertificateCredential = Initialize-IntersightAssetClientCertificateCredential  -ClassId null `
 -ObjectType null `
 -ClientCertificate null `
 -ClientKey null `
 -IsClientKeySet null
```

- Convert the resource to JSON
```powershell
$AssetClientCertificateCredential | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

