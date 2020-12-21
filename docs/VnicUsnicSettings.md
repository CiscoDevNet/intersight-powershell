# VnicUsnicSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "vnic.UsnicSettings"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "vnic.UsnicSettings"]
**Cos** | **Int64** | Class of Service to be used for traffic on the usNIC. | [optional] [default to 5]
**Count** | **Int64** | Number of usNIC interfaces to be created. | [optional] 
**UsnicAdapterPolicy** | **String** | Ethernet Adapter policy to be associated with the usNICs. | [optional] 

## Examples

- Prepare the resource
```powershell
$VnicUsnicSettings = Initialize-IntersightVnicUsnicSettings  -ClassId null `
 -ObjectType null `
 -Cos null `
 -Count null `
 -UsnicAdapterPolicy null
```

- Convert the resource to JSON
```powershell
$VnicUsnicSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

