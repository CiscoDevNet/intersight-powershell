# AssetContractInformationAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BillTo** | [**AssetAddressInformation**](AssetAddressInformation.md) |  | [optional] 
**BillToGlobalUltimate** | [**AssetGlobalUltimate**](AssetGlobalUltimate.md) |  | [optional] 
**ContractNumber** | **String** | Contract number for the Cisco support contract purchased for the Cisco device. | [optional] [readonly] 
**LineStatus** | **String** | Contract status as per the Cisco Contract APIx. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightAssetContractInformationAllOf  -BillTo null `
 -BillToGlobalUltimate null `
 -ContractNumber null `
 -LineStatus null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

