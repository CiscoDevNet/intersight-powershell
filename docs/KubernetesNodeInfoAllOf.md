# KubernetesNodeInfoAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "kubernetes.NodeInfo"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "kubernetes.NodeInfo"]
**Architecture** | **String** | Node Operating System architecture (amd64, arm64). | [optional] 
**BootId** | **String** | A Boot ID is an Identifier generated by the host everytimes it gets reboot. | [optional] 
**ContainerRuntimeVersion** | **String** | To run containers in Pods, Kubernetes uses a container runtime. This field describes Container Runtime Version. | [optional] 
**KernelVersion** | **String** | Node Operating System kernel version. | [optional] 
**KubeProxyVersion** | **String** | The Kubernetes network proxy runs on each node. This reflects services as defined in the Kubernetes API on each node and can do simple TCP, UDP, and SCTP stream forwarding or round robin TCP, UDP, and SCTP forwarding across a set of backends. This field describes the kube-proxy version. | [optional] 
**KubeletVersion** | **String** | The kubelet is the primary &quot;&quot;node agent&quot;&quot; that runs on each node. It can register the node with the apiserver using one of such as the hostname; a flag to override the hostname; or specific logic for a cloud provider. This field describes the kubelet version the node currently using. | [optional] 
**MachineId** | **String** | It is a node identifier in Kubernetes. When the node joins a kubernetes cluster, Kubernetes will assign a machine ID to that node. Learn more from man machine-id from http://man7.org/linux/man-pages/man5/machine-id.5.html. | [optional] 
**OperatingSystem** | **String** | Operating System installed on this Node. | [optional] 
**OsImage** | **String** | Node current Operating System image. | [optional] 
**SystemUuid** | **String** | SystemUUID reported by the node. For unique machine identification MachineID is preferred. This field is specific to Red Hat hosts https://access.redhat.com/documentation/en-US/Red_Hat_Subscription_Management/1/html/RHSM/getting-system-uuid.html. | [optional] 

## Examples

- Prepare the resource
```powershell
$KubernetesNodeInfoAllOf = Initialize-IntersightKubernetesNodeInfoAllOf  -ClassId null `
 -ObjectType null `
 -Architecture null `
 -BootId null `
 -ContainerRuntimeVersion null `
 -KernelVersion null `
 -KubeProxyVersion null `
 -KubeletVersion null `
 -MachineId null `
 -OperatingSystem null `
 -OsImage null `
 -SystemUuid null
```

- Convert the resource to JSON
```powershell
$KubernetesNodeInfoAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
