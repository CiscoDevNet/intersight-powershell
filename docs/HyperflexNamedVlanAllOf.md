# HyperflexNamedVlanAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **String** | The name of the VLAN. The name can be from 1 to 32 characters long and can contain a combination of alphanumeric characters, underscores, and hyphens. | [optional] 
**VlanId** | **Int64** | The ID of the named VLAN. An ID of 0 means the traffic is untagged. The ID can be any number between 0 and 4095, inclusive. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightHyperflexNamedVlanAllOf  -Name null `
 -VlanId null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

