# KubernetesDaemonSetStatusAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "kubernetes.DaemonSetStatus"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "kubernetes.DaemonSetStatus"]
**CurrentNumberScheduled** | **Int64** | The number of nodes that are running at least 1 daemon pod and are supposed to run the daemon pod. | [optional] 
**DesiredNumberScheduled** | **Int64** | The total number of nodes that should be running the daemon pod (including nodes correctly running the daemon pod). | [optional] 
**NumberAvailable** | **String** | The number of nodes that should be running the daemon pod and have one or more of the daemon pod running and available (ready for at least spec.minReadySeconds). | [optional] 
**NumberMisscheduled** | **Int64** | The number of nodes that are running the daemon pod, but are not supposed to run the daemon pod. | [optional] 
**NumberReady** | **Int64** | The number of nodes that should be running the daemon pod and have one or more of the daemon pod running and ready. | [optional] 
**ObservedGeneration** | **Int64** | The most recent generation observed by the daemon set controller. | [optional] 
**UpdatedNumberScheduled** | **String** | The total number of nodes that are running updated daemon pod. | [optional] 

## Examples

- Prepare the resource
```powershell
$KubernetesDaemonSetStatusAllOf = Initialize-IntersightKubernetesDaemonSetStatusAllOf  -ClassId null `
 -ObjectType null `
 -CurrentNumberScheduled null `
 -DesiredNumberScheduled null `
 -NumberAvailable null `
 -NumberMisscheduled null `
 -NumberReady null `
 -ObservedGeneration null `
 -UpdatedNumberScheduled null
```

- Convert the resource to JSON
```powershell
$KubernetesDaemonSetStatusAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

