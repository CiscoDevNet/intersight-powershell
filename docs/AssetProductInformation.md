# AssetProductInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "asset.ProductInformation"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "asset.ProductInformation"]
**BillTo** | [**AssetAddressInformation**](AssetAddressInformation.md) |  | [optional] 
**Description** | **String** | Short description of the Cisco product that helps identify the product easily. example &quot;&quot;DISTI:UCS 6248UP 1RU Fabric Int/No PSU/32 UP/ 12p LIC&quot;&quot;. | [optional] [readonly] 
**Family** | **String** | Family that the product belongs to. Example &quot;&quot;UCSB&quot;&quot;. | [optional] [readonly] 
**Group** | **String** | Group that the product belongs to. It is one higher level categorization above family. example &quot;&quot;Switch&quot;&quot;. | [optional] [readonly] 
**Number** | **String** | Product number that identifies the product. example PID. example &quot;&quot;UCS-FI-6248UP-CH2&quot;&quot;. | [optional] [readonly] 
**ShipTo** | [**AssetAddressInformation**](AssetAddressInformation.md) |  | [optional] 
**SubType** | **String** | Sub type of the product being specified. example &quot;&quot;UCS 6200 SER&quot;&quot;. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$AssetProductInformation = Initialize-IntersightAssetProductInformation  -ClassId null `
 -ObjectType null `
 -BillTo null `
 -Description null `
 -Family null `
 -Group null `
 -Number null `
 -ShipTo null `
 -SubType null
```

- Convert the resource to JSON
```powershell
$AssetProductInformation | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

