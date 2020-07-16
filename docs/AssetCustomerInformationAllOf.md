# AssetCustomerInformationAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Address** | [**AssetAddressInformation**](AssetAddressInformation.md) |  | [optional] 
**Id** | **String** | Unique identifier for an end customer. This identifier is allocated by Cisco. | [optional] [readonly] 
**Name** | **String** | Name as per the information provided by the user. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightAssetCustomerInformationAllOf  -Address null `
 -Id null `
 -Name null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

