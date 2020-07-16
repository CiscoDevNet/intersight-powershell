# FcpoolBlockAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VarFrom** | **String** | Starting WWN identifier of the block must be in hexadecimal format xx:xx:xx:xx:xx:xx:xx:xx. Allowed ranges are 20:00:00:00:00:00:00:00 to 20:FF:FF:FF:FF:FF:FF:FF or from 50:00:00:00:00:00:00:00 to 5F:FF:FF:FF:FF:FF:FF:FF. To ensure uniqueness of WWN&#39;s in the SAN fabric, you are strongly encouraged to use the following WWN prefix; 20:00:00:25:B5:xx:xx:xx. | [optional] 
**To** | **String** | Ending WWN identifier of the block must be in hexadecimal format xx:xx:xx:xx:xx:xx:xx:xx. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightFcpoolBlockAllOf  -VarFrom null `
 -To null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

