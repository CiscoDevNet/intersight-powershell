# KvmKvmSessionAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**KvmMuxUrl** | **String** | The URL of the KVM MUX to connect to. | [optional] [readonly] 
**Device** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**Server** | [**ComputeRackUnitRelationship**](ComputeRackUnitRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightKvmKvmSessionAllOf  -KvmMuxUrl null `
 -Device null `
 -Server null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

