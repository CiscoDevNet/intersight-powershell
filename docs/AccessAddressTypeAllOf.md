# AccessAddressTypeAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "access.AddressType"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "access.AddressType"]
**EnableIpV4** | **Boolean** | This flag enables the use of IPv4 address for end-point access. | [optional] [default to $true]
**EnableIpV6** | **Boolean** | This flag enables the use of IPv6 address for end-point access. | [optional] [default to $false]

## Examples

- Prepare the resource
```powershell
$AccessAddressTypeAllOf = Initialize-IntersightAccessAddressTypeAllOf  -ClassId null `
 -ObjectType null `
 -EnableIpV4 null `
 -EnableIpV6 null
```

- Convert the resource to JSON
```powershell
$AccessAddressTypeAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

