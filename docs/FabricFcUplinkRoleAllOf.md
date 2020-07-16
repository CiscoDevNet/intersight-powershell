# FabricFcUplinkRoleAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdminSpeed** | **String** | Admin configured speed for the port. | [optional] [default to "Auto"]
**FillPattern** | **String** | Fill pattern to differentiate the configs in NPIV. | [optional] [default to "Idle"]
**VsanId** | **Int64** | Virtual San Identifier associated to the FC port. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightFabricFcUplinkRoleAllOf  -AdminSpeed null `
 -FillPattern null `
 -VsanId null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

