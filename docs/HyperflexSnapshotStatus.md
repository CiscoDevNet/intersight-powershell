# HyperflexSnapshotStatus
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.SnapshotStatus"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.SnapshotStatus"]
**Description** | **String** | Description of this Snapshot Point. | [optional] [readonly] 
**VarError** | [**HyperflexErrorStack**](HyperflexErrorStack.md) |  | [optional] 
**PctComplete** | **Int64** | Completion percentage for this snapshot. | [optional] [readonly] 
**Status** | **String** | Current snapshot state for this snapshot. * &#x60;SUCCESS&#x60; - This snapshot status code is success. * &#x60;FAILED&#x60; - This snapshot status code is failed. * &#x60;IN_PROGRESS&#x60; - This snapshot status code is in progress. * &#x60;DELETING&#x60; - This snapshot status code is deleting. * &#x60;DELETED&#x60; - This snapshot status code is deleted. * &#x60;NONE&#x60; - This snapshot status code is none. | [optional] [readonly] [default to "SUCCESS"]
**Timestamp** | **Int64** | Timestamp at which the Snapshot is taken. | [optional] [readonly] 
**UsedSpace** | **Int64** | Space Used by this Snapshot Point. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$HyperflexSnapshotStatus = Initialize-IntersightHyperflexSnapshotStatus  -ClassId null `
 -ObjectType null `
 -Description null `
 -VarError null `
 -PctComplete null `
 -Status null `
 -Timestamp null `
 -UsedSpace null
```

- Convert the resource to JSON
```powershell
$HyperflexSnapshotStatus | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

