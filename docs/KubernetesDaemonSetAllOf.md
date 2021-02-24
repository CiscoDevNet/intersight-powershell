# KubernetesDaemonSetAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "kubernetes.DaemonSet"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "kubernetes.DaemonSet"]
**Status** | [**KubernetesDaemonSetStatus**](KubernetesDaemonSetStatus.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$KubernetesDaemonSetAllOf = Initialize-IntersightKubernetesDaemonSetAllOf  -ClassId null `
 -ObjectType null `
 -Status null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$KubernetesDaemonSetAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

