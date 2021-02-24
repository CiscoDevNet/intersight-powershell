# KubernetesStatefulSetStatusAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "kubernetes.StatefulSetStatus"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "kubernetes.StatefulSetStatus"]
**AvailableReplicas** | **Int64** | AvailableReplicas indicates the current avaliable replicas running. | [optional] 
**CollisionCount** | **Int64** | CollisionCount is the count of hash collisions for the StatefulSet. The StatefulSet controller uses this field as a collision avoidance mechanism when it needs to create the name for the newest ControllerRevision. | [optional] 
**CurrentRevision** | **String** | CurrentRevision, if not empty, indicates the version of the StatefulSet used to generate Pods. | [optional] 
**ObservedGeneration** | **Int64** | ObservedGeneration is the most recent generation observed for this StatefulSet. It corresponds to the StatefulSet&#39;s generation, which is updated on mutation by the API Server. | [optional] 
**ReadyReplicas** | **Int64** | ReadyReplicas is the number of Pods created by the StatefulSet controller that have a Ready Condition. | [optional] 
**Replicas** | **Int64** | Number of replicas the statefulset desired to have. | [optional] 
**UpdateRevision** | **String** | UpdateRevision, if not empty, indicates the version of the StatefulSet used to generate the pods that have yet to be updated, i.e. pod number &lt;replicas&gt; - &lt;updatedReplicas&gt;, until pod number &lt;replicas&gt;. | [optional] 
**UpdatedReplicas** | **Int64** | UpdatedReplicas is the number of Pods created by the StatefulSet controller from the StatefulSet version indicated by updateRevision. | [optional] 

## Examples

- Prepare the resource
```powershell
$KubernetesStatefulSetStatusAllOf = Initialize-IntersightKubernetesStatefulSetStatusAllOf  -ClassId null `
 -ObjectType null `
 -AvailableReplicas null `
 -CollisionCount null `
 -CurrentRevision null `
 -ObservedGeneration null `
 -ReadyReplicas null `
 -Replicas null `
 -UpdateRevision null `
 -UpdatedReplicas null
```

- Convert the resource to JSON
```powershell
$KubernetesStatefulSetStatusAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

