# AssetHttpConnection
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "asset.HttpConnection"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "asset.HttpConnection"]
**Credential** | [**AssetCredential**](AssetCredential.md) |  | [optional] 
**CertificateAuthority** | **String** | The certificate authority of the target. If set and connection is secure the connection will be validate using the servers identity with this certificate. If not set no validation will be done of the identity. | [optional] 
**IsSecure** | **Boolean** | Indicates whether a connection to the target should be established using HTTPS. | [optional] [default to $true]
**ManagementAddress** | **String** | The DNS hostname or IP Address, either IPv4 or IPv6, to be used to connect to the managed target. | [optional] 
**Port** | **Int64** | The port number to be used to connect to the managed target. Values 1-65535 indicate a port number to be used. A value of 0 is not a valid port number and instead indicates that the default management port, as defined by the documentation of the managed target, should be used to establish a connection. | [optional] 

## Examples

- Prepare the resource
```powershell
$AssetHttpConnection = Initialize-IntersightAssetHttpConnection  -ClassId null `
 -ObjectType null `
 -Credential null `
 -CertificateAuthority null `
 -IsSecure null `
 -ManagementAddress null `
 -Port null
```

- Convert the resource to JSON
```powershell
$AssetHttpConnection | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

