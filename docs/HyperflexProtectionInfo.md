# HyperflexProtectionInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.ProtectionInfo"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.ProtectionInfo"]
**VmCurrentProtectionInfo** | [**HyperflexSnapshotInfoBrief**](HyperflexSnapshotInfoBrief.md) |  | [optional] 
**VmLastSuccessfulProtectionInfo** | [**HyperflexSnapshotInfoBrief**](HyperflexSnapshotInfoBrief.md) |  | [optional] 
**VmSpaceUsage** | [**HyperflexVmProtectionSpaceUsage**](HyperflexVmProtectionSpaceUsage.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$HyperflexProtectionInfo = Initialize-IntersightHyperflexProtectionInfo  -ClassId null `
 -ObjectType null `
 -VmCurrentProtectionInfo null `
 -VmLastSuccessfulProtectionInfo null `
 -VmSpaceUsage null
```

- Convert the resource to JSON
```powershell
$HyperflexProtectionInfo | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

