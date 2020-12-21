# OsIpv6ConfigurationAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "os.Ipv6Configuration"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "os.Ipv6Configuration"]
**IpV6Config** | [**CommIpV6Interface**](CommIpV6Interface.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$OsIpv6ConfigurationAllOf = Initialize-IntersightOsIpv6ConfigurationAllOf  -ClassId null `
 -ObjectType null `
 -IpV6Config null
```

- Convert the resource to JSON
```powershell
$OsIpv6ConfigurationAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

