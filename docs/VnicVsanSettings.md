# VnicVsanSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "vnic.VsanSettings"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "vnic.VsanSettings"]
**DefaultVlanId** | **Int64** | Default VLAN of the virtual interface in Standalone Rack server. Setting the value to 0 is equivalent to None and will not associate any Default VLAN to the traffic on the virtual interface (0-4094). | [optional] [default to 0]
**Id** | **Int64** | VSAN ID of the virtual interface in FI attached server (1-4094). | [optional] [default to 1]

## Examples

- Prepare the resource
```powershell
$VnicVsanSettings = Initialize-IntersightVnicVsanSettings  -ClassId null `
 -ObjectType null `
 -DefaultVlanId null `
 -Id null
```

- Convert the resource to JSON
```powershell
$VnicVsanSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

