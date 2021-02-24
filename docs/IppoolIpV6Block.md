# IppoolIpV6Block
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "ippool.IpV6Block"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "ippool.IpV6Block"]
**Size** | **Int64** | Number of identifiers this block can hold. | [optional] [readonly] 
**VarFrom** | **String** | First IPv6 address of the block. | [optional] [readonly] 
**To** | **String** | Last IPv6 address of the block. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$IppoolIpV6Block = Initialize-IntersightIppoolIpV6Block  -ClassId null `
 -ObjectType null `
 -Size null `
 -VarFrom null `
 -To null
```

- Convert the resource to JSON
```powershell
$IppoolIpV6Block | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

