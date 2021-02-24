# IppoolIpV4Block
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "ippool.IpV4Block"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "ippool.IpV4Block"]
**Size** | **Int64** | Number of identifiers this block can hold. | [optional] [readonly] 
**VarFrom** | **String** | First IPv4 address of the block. | [optional] [readonly] 
**To** | **String** | Last IPv4 address of the block. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$IppoolIpV4Block = Initialize-IntersightIppoolIpV4Block  -ClassId null `
 -ObjectType null `
 -Size null `
 -VarFrom null `
 -To null
```

- Convert the resource to JSON
```powershell
$IppoolIpV4Block | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

