# HyperflexAppSettingConstraintAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HxdpVersion** | **String** | The supported HyperFlex Data Platform version in regex format. | [optional] 
**HypervisorType** | **String** | The hypervisor type for the HyperFlex cluster. | [optional] [default to "ESXi"]
**MgmtPlatform** | **String** | The supported management platform for the HyperFlex Cluster. | [optional] [default to "FI"]
**ServerModel** | **String** | The supported server models in regex format. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightHyperflexAppSettingConstraintAllOf  -HxdpVersion null `
 -HypervisorType null `
 -MgmtPlatform null `
 -ServerModel null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

