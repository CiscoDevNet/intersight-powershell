# OsIpv4Configuration
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "os.Ipv4Configuration"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "os.Ipv4Configuration"]
**IpV4Config** | [**CommIpV4Interface**](CommIpV4Interface.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$OsIpv4Configuration = Initialize-IntersightOsIpv4Configuration  -ClassId null `
 -ObjectType null `
 -IpV4Config null
```

- Convert the resource to JSON
```powershell
$OsIpv4Configuration | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

