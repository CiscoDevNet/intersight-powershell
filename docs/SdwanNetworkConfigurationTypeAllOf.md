# SdwanNetworkConfigurationTypeAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NetworkType** | **String** | Type of the Port group being added. | [optional] [default to "WAN"]
**PortGroup** | **String** | Name of the Port Group to create. | [optional] 
**Vlan** | **Int64** | VLAN to be added to the Port Group. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightSdwanNetworkConfigurationTypeAllOf  -NetworkType null `
 -PortGroup null `
 -Vlan null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

