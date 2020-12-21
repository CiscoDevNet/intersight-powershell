# FabricVsanAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "fabric.Vsan"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "fabric.Vsan"]
**DefaultZoning** | **String** | Enables or Disables the default zoning state. * &#x60;Enabled&#x60; - Admin configured Enabled State. * &#x60;Disabled&#x60; - Admin configured Disabled State. | [optional] [default to "Enabled"]
**FcZoneSharingMode** | **String** | Logical grouping mode for fc ports. | [optional] 
**FcoeVlan** | **Int64** | FCOE Vlan associated to the VSAN configuration. | [optional] 
**Name** | **String** | User given name for the VSAN configuration. | [optional] 
**VsanId** | **Int64** | Virtual San Identifier in the switch. | [optional] 
**FcNetworkPolicy** | [**FabricFcNetworkPolicyRelationship**](FabricFcNetworkPolicyRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$FabricVsanAllOf = Initialize-IntersightFabricVsanAllOf  -ClassId null `
 -ObjectType null `
 -DefaultZoning null `
 -FcZoneSharingMode null `
 -FcoeVlan null `
 -Name null `
 -VsanId null `
 -FcNetworkPolicy null
```

- Convert the resource to JSON
```powershell
$FabricVsanAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

