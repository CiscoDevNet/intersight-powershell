# AssetContractInformationAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "asset.ContractInformation"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "asset.ContractInformation"]
**BillTo** | [**AssetAddressInformation**](AssetAddressInformation.md) |  | [optional] 
**BillToGlobalUltimate** | [**AssetGlobalUltimate**](AssetGlobalUltimate.md) |  | [optional] 
**ContractNumber** | **String** | Contract number for the Cisco support contract purchased for the Cisco device. | [optional] [readonly] 
**LineStatus** | **String** | Contract status as per the Cisco Contract APIx. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$AssetContractInformationAllOf = Initialize-IntersightAssetContractInformationAllOf  -ClassId null `
 -ObjectType null `
 -BillTo null `
 -BillToGlobalUltimate null `
 -ContractNumber null `
 -LineStatus null
```

- Convert the resource to JSON
```powershell
$AssetContractInformationAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

