# FabricVlanAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "fabric.Vlan"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "fabric.Vlan"]
**AutoAllowOnUplinks** | **Boolean** | Used to determine whether this VLAN will be allowed on all uplink ports and PCs in this FI. | [optional] [default to $true]
**IsNative** | **Boolean** | Used to define whether this VLAN is to be classified as &#39;native&#39; for traffic in this FI. | [optional] 
**Name** | **String** | The &#39;name&#39; used to identify this VLAN. | [optional] 
**VlanId** | **Int64** | The identifier for this Virtual LAN. | [optional] 
**EthNetworkPolicy** | [**FabricEthNetworkPolicyRelationship**](FabricEthNetworkPolicyRelationship.md) |  | [optional] 
**MulticastPolicy** | [**FabricMulticastPolicyRelationship**](FabricMulticastPolicyRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$FabricVlanAllOf = Initialize-IntersightFabricVlanAllOf  -ClassId null `
 -ObjectType null `
 -AutoAllowOnUplinks null `
 -IsNative null `
 -Name null `
 -VlanId null `
 -EthNetworkPolicy null `
 -MulticastPolicy null
```

- Convert the resource to JSON
```powershell
$FabricVlanAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

