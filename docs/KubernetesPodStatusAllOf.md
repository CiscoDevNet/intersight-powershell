# KubernetesPodStatusAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "kubernetes.PodStatus"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "kubernetes.PodStatus"]
**HostIp** | **String** | The IP of the host that the pod is running on. | [optional] 
**Phase** | **String** | The phase of a Pod is a simple, high-level summary of where the Pod is in its lifecycle. | [optional] 
**PodIp** | **String** | The IP of the pod. The IP is allocated by the Pod CIDR from the kubernetes cluster itself. | [optional] 
**QosClass** | **String** | The Quality of Service (QOS) classification assigned to the pod based on resource requirements. | [optional] 
**StartTime** | **String** | The time that the pod was started. | [optional] 

## Examples

- Prepare the resource
```powershell
$KubernetesPodStatusAllOf = Initialize-IntersightKubernetesPodStatusAllOf  -ClassId null `
 -ObjectType null `
 -HostIp null `
 -Phase null `
 -PodIp null `
 -QosClass null `
 -StartTime null
```

- Convert the resource to JSON
```powershell
$KubernetesPodStatusAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

