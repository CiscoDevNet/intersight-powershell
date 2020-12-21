# MacpoolBlock
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "macpool.Block"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "macpool.Block"]
**Size** | **Int64** | Number of identifiers this block can hold. | [optional] [readonly] 
**VarFrom** | **String** | Starting address of the block must be in hexadecimal format xx:xx:xx:xx:xx:xx. To ensure uniqueness of MACs in the LAN fabric, you are strongly encouraged to use the following MAC prefix 00:25:B5:xx:xx:xx. | [optional] 
**To** | **String** | Ending address of the block must be in hexadecimal format xx:xx:xx:xx:xx:xx. | [optional] 

## Examples

- Prepare the resource
```powershell
$MacpoolBlock = Initialize-IntersightMacpoolBlock  -ClassId null `
 -ObjectType null `
 -Size null `
 -VarFrom null `
 -To null
```

- Convert the resource to JSON
```powershell
$MacpoolBlock | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

