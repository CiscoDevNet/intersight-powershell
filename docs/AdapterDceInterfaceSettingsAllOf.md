# AdapterDceInterfaceSettingsAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FecMode** | **String** | Forward Error Correction (FEC) mode setting for the DCE interfaces of the adapter. FEC mode setting is supported only for Cisco VIC 14xx adapters. FEC mode &#39;cl74&#39; is unsupported for Cisco VIC 1495/1497. This setting will be ignored for unsupported adapters and for unavailable DCE interfaces. | [optional] [default to "Auto"]
**InterfaceId** | **Int64** | DCE interface id on which settings needs to be configured. Supported values are (0-3). | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightAdapterDceInterfaceSettingsAllOf  -FecMode null `
 -InterfaceId null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

