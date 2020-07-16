# FabricVsanAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DefaultZoning** | **String** | Enables or Disables the default zoning state. | [optional] [default to "Enabled"]
**FcZoneSharingMode** | **String** | Logical grouping mode for fc ports. | [optional] 
**FcoeVlan** | **Int64** | FCOE Vlan associated to the VSAN configuration. | [optional] 
**Name** | **String** | User given name for the VSAN configuration. | [optional] 
**VsanId** | **Int64** | Virtual San Identifier in the switch. | [optional] 
**FcNetworkPolicy** | [**FabricFcNetworkPolicyRelationship**](FabricFcNetworkPolicyRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightFabricVsanAllOf  -DefaultZoning null `
 -FcZoneSharingMode null `
 -FcoeVlan null `
 -Name null `
 -VsanId null `
 -FcNetworkPolicy null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

