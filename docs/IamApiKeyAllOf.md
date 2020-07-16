# IamApiKeyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HashAlgorithm** | **String** | The cryptographic hash algorithm to calculate the message digest. | [optional] [default to "SHA256"]
**KeySpec** | [**PkixKeyGenerationSpec**](PkixKeyGenerationSpec.md) |  | [optional] 
**PrivateKey** | **String** | Holds the private key for the API key. | [optional] 
**Purpose** | **String** | The purpose of the API Key. | [optional] 
**SigningAlgorithm** | **String** | The signing algorithm used by the client to authenticate API requests to Intersight. The signing algorithm must be compatible with the key generation specification. | [optional] [default to "RSASSA-PKCS1-v1_5"]
**Permission** | [**IamPermissionRelationship**](IamPermissionRelationship.md) |  | [optional] 
**User** | [**IamUserRelationship**](IamUserRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightIamApiKeyAllOf  -HashAlgorithm null `
 -KeySpec null `
 -PrivateKey null `
 -Purpose null `
 -SigningAlgorithm null `
 -Permission null `
 -User null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

