# AssetCustomerInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "asset.CustomerInformation"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "asset.CustomerInformation"]
**Address** | [**AssetAddressInformation**](AssetAddressInformation.md) |  | [optional] 
**Id** | **String** | Unique identifier for an end customer. This identifier is allocated by Cisco. | [optional] [readonly] 
**Name** | **String** | Name as per the information provided by the user. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$AssetCustomerInformation = Initialize-IntersightAssetCustomerInformation  -ClassId null `
 -ObjectType null `
 -Address null `
 -Id null `
 -Name null
```

- Convert the resource to JSON
```powershell
$AssetCustomerInformation | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

