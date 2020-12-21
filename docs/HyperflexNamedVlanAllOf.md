# HyperflexNamedVlanAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.NamedVlan"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.NamedVlan"]
**Name** | **String** | The name of the VLAN. The name can be from 1 to 32 characters long and can contain a combination of alphanumeric characters, underscores, and hyphens. | [optional] 
**VlanId** | **Int64** | The ID of the named VLAN. An ID of 0 means the traffic is untagged. The ID can be any number between 0 and 4095, inclusive. | [optional] 

## Examples

- Prepare the resource
```powershell
$HyperflexNamedVlanAllOf = Initialize-IntersightHyperflexNamedVlanAllOf  -ClassId null `
 -ObjectType null `
 -Name null `
 -VlanId null
```

- Convert the resource to JSON
```powershell
$HyperflexNamedVlanAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

