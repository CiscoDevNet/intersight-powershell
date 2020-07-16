# MacpoolBlockAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VarFrom** | **String** | Starting address of the block must be in hexadecimal format xx:xx:xx:xx:xx:xx. To ensure uniqueness of MACs in the LAN fabric, you are strongly encouraged to use the following MAC prefix 00:25:B5:xx:xx:xx. | [optional] 
**To** | **String** | Ending address of the block must be in hexadecimal format xx:xx:xx:xx:xx:xx. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightMacpoolBlockAllOf  -VarFrom null `
 -To null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

