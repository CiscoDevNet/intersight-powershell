# HyperflexVmProtectionSpaceUsageAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.VmProtectionSpaceUsage"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.VmProtectionSpaceUsage"]
**SpaceUsage** | **Int64** | Space usage of the VM from StDataServiceManager. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$HyperflexVmProtectionSpaceUsageAllOf = Initialize-IntersightHyperflexVmProtectionSpaceUsageAllOf  -ClassId null `
 -ObjectType null `
 -SpaceUsage null
```

- Convert the resource to JSON
```powershell
$HyperflexVmProtectionSpaceUsageAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

