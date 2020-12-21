# AssetAddressInformationAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "asset.AddressInformation"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "asset.AddressInformation"]
**Address1** | **String** | Address Line one of the address information. example &quot;&quot;PO BOX 641570&quot;&quot;. | [optional] [readonly] 
**Address2** | **String** | Address Line two of the address information. example &quot;&quot;Cisco Systems&quot;&quot;. | [optional] [readonly] 
**Address3** | **String** | Address Line three of the address information. example &quot;&quot;Cisco Systems&quot;&quot;. | [optional] [readonly] 
**City** | **String** | City in which the address resides. example &quot;&quot;San Jose&quot;&quot;. | [optional] [readonly] 
**Country** | **String** | Country in which the address resides. example &quot;&quot;US&quot;&quot;. | [optional] [readonly] 
**County** | **String** | County in which the address resides. example &quot;&quot;Washington County&quot;&quot;. | [optional] [readonly] 
**Location** | **String** | Location in which the address resides. example &quot;&quot;14852&quot;&quot;. | [optional] [readonly] 
**Name** | **String** | Name of the user whose address is being populated. | [optional] [readonly] 
**PostalCode** | **String** | Postal Code in which the address resides. example &quot;&quot;95164-1570&quot;&quot;. | [optional] [readonly] 
**Province** | **String** | Province in which the address resides. example &quot;&quot;AB&quot;&quot;. | [optional] [readonly] 
**State** | **String** | State in which the address resides. example &quot;&quot;CA&quot;&quot;. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$AssetAddressInformationAllOf = Initialize-IntersightAssetAddressInformationAllOf  -ClassId null `
 -ObjectType null `
 -Address1 null `
 -Address2 null `
 -Address3 null `
 -City null `
 -Country null `
 -County null `
 -Location null `
 -Name null `
 -PostalCode null `
 -Province null `
 -State null
```

- Convert the resource to JSON
```powershell
$AssetAddressInformationAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

