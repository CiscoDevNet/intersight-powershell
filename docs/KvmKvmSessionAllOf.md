# KvmKvmSessionAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "kvm.KvmSession"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "kvm.KvmSession"]
**KvmMuxUrl** | **String** | The URL of the KVM MUX to connect to. | [optional] [readonly] 
**Device** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**Server** | [**ComputeRackUnitRelationship**](ComputeRackUnitRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$KvmKvmSessionAllOf = Initialize-IntersightKvmKvmSessionAllOf  -ClassId null `
 -ObjectType null `
 -KvmMuxUrl null `
 -Device null `
 -Server null
```

- Convert the resource to JSON
```powershell
$KvmKvmSessionAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

