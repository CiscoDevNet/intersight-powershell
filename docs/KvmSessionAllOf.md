# KvmSessionAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "kvm.Session"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "kvm.Session"]
**OneTimePassword** | **String** | Temporary one-time password for KVM access. | [optional] 
**SsoSupported** | **Boolean** | Indicates if KVM SSO is supported on the server. | [optional] [readonly] 
**Username** | **String** | Username used for KVM access. | [optional] 
**Device** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**Server** | [**ComputePhysicalRelationship**](ComputePhysicalRelationship.md) |  | [optional] 
**Session** | [**IamSessionRelationship**](IamSessionRelationship.md) |  | [optional] 
**Tunnel** | [**KvmTunnelRelationship**](KvmTunnelRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$KvmSessionAllOf = Initialize-IntersightKvmSessionAllOf  -ClassId null `
 -ObjectType null `
 -OneTimePassword null `
 -SsoSupported null `
 -Username null `
 -Device null `
 -Server null `
 -Session null `
 -Tunnel null
```

- Convert the resource to JSON
```powershell
$KvmSessionAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

