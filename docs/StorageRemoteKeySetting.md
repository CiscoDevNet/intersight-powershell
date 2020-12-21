# StorageRemoteKeySetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "storage.RemoteKeySetting"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "storage.RemoteKeySetting"]
**IsPasswordSet** | **Boolean** | Indicates whether the value of the &#39;password&#39; property has been set. | [optional] [readonly] [default to $false]
**Password** | **String** | The password for the KMIP server login. | [optional] 
**Port** | **Int64** | The port to which the KMIP client should connect. | [optional] [default to 5696]
**PrimaryServer** | **String** | The IP address of the primary KMIP server. It could be an IPv4 address, an IPv6 address, or a hostname. Hostnames are valid only when Inband is configured for the CIMC address. | [optional] 
**SecondaryServer** | **String** | The IP address of the secondary KMIP server. It could be an IPv4 address, an IPv6 address, or a hostname. Hostnames are valid only when Inband is configured for the CIMC address. | [optional] 
**ServerCertificate** | **String** | The certificate/ public key of the KMIP server. It is required for initiating secure communication with the server. | [optional] 
**Username** | **String** | The user name for the KMIP server login. | [optional] 

## Examples

- Prepare the resource
```powershell
$StorageRemoteKeySetting = Initialize-IntersightStorageRemoteKeySetting  -ClassId null `
 -ObjectType null `
 -IsPasswordSet null `
 -Password null `
 -Port null `
 -PrimaryServer null `
 -SecondaryServer null `
 -ServerCertificate null `
 -Username null
```

- Convert the resource to JSON
```powershell
$StorageRemoteKeySetting | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

