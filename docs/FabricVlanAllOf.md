# FabricVlanAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsNative** | **Boolean** | Used to define whether this VLAN is to be classified as &#39;native&#39; for traffic in this FI. | [optional] 
**Name** | **String** | The &#39;name&#39; used to identify this VLAN. | [optional] 
**VlanId** | **Int64** | The identifier for this Virtual LAN. | [optional] 
**EthNetworkPolicy** | [**FabricEthNetworkPolicyRelationship**](FabricEthNetworkPolicyRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightFabricVlanAllOf  -IsNative null `
 -Name null `
 -VlanId null `
 -EthNetworkPolicy null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

