# VnicUsnicSettingsAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cos** | **Int64** | Class of Service to be used for traffic on the usNIC. | [optional] 
**Count** | **Int64** | Number of usNIC interfaces to be created. | [optional] 
**UsnicAdapterPolicy** | **String** | Ethernet Adapter policy to be associated with the usNICs. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightVnicUsnicSettingsAllOf  -Cos null `
 -Count null `
 -UsnicAdapterPolicy null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

