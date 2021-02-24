# IppoolIpLeaseAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "ippool.IpLease"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "ippool.IpLease"]
**IpType** | **String** | Type of the IP address requested. * &#x60;IPv4&#x60; - IP V4 address type requested. * &#x60;IPv6&#x60; - IP V6 address type requested. | [optional] [default to "IPv4"]
**IpV4Address** | **String** | IPv4 Address given as a lease to an external entity like server profiles. | [optional] 
**IpV4Config** | [**IppoolIpV4Config**](IppoolIpV4Config.md) |  | [optional] 
**IpV6Address** | **String** | IPv6 Address given as a lease to an external entity like server profiles. | [optional] 
**IpV6Config** | [**IppoolIpV6Config**](IppoolIpV6Config.md) |  | [optional] 
**Var0VirtualMachineNodeProfile** | [**KubernetesVirtualMachineNodeProfileRelationship**](KubernetesVirtualMachineNodeProfileRelationship.md) |  | [optional] 
**Var1VirtualMachineNodeProfile** | [**KubernetesVirtualMachineNodeProfileRelationship**](KubernetesVirtualMachineNodeProfileRelationship.md) |  | [optional] 
**Var2ClusterProfile** | [**KubernetesClusterProfileRelationship**](KubernetesClusterProfileRelationship.md) |  | [optional] 
**Var3ClusterProfile** | [**KubernetesClusterProfileRelationship**](KubernetesClusterProfileRelationship.md) |  | [optional] 
**AssignedToEntity** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 
**BlockLease** | [**IppoolBlockLeaseRelationship**](IppoolBlockLeaseRelationship.md) |  | [optional] 
**Pool** | [**IppoolPoolRelationship**](IppoolPoolRelationship.md) |  | [optional] 
**PoolMember** | [**IppoolPoolMemberRelationship**](IppoolPoolMemberRelationship.md) |  | [optional] 
**Universe** | [**IppoolUniverseRelationship**](IppoolUniverseRelationship.md) |  | [optional] 
**Vrf** | [**VrfVrfRelationship**](VrfVrfRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$IppoolIpLeaseAllOf = Initialize-IntersightIppoolIpLeaseAllOf  -ClassId null `
 -ObjectType null `
 -IpType null `
 -IpV4Address null `
 -IpV4Config null `
 -IpV6Address null `
 -IpV6Config null `
 -Var0VirtualMachineNodeProfile null `
 -Var1VirtualMachineNodeProfile null `
 -Var2ClusterProfile null `
 -Var3ClusterProfile null `
 -AssignedToEntity null `
 -BlockLease null `
 -Pool null `
 -PoolMember null `
 -Universe null `
 -Vrf null
```

- Convert the resource to JSON
```powershell
$IppoolIpLeaseAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

