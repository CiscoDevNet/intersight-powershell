# FabricFcoeUplinkPcRoleAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdminSpeed** | **String** | Admin configured speed for the port. | [optional] [default to "Auto"]
**UdldAdminState** | **String** | Admin configured state for UDLD for this port. | [optional] [default to "Disabled"]

## Examples

- Prepare the resource
```powershell
Initialize-IntersightFabricFcoeUplinkPcRoleAllOf  -AdminSpeed null `
 -UdldAdminState null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

