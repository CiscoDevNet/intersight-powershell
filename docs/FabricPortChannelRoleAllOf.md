# FabricPortChannelRoleAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PcId** | **Int64** | Unique Identifier of the port-channel, local to this switch. | [optional] 
**Ports** | [**FabricPortIdentifier[]**](FabricPortIdentifier.md) |  | [optional] 
**PortPolicy** | [**FabricPortPolicyRelationship**](FabricPortPolicyRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightFabricPortChannelRoleAllOf  -PcId null `
 -Ports null `
 -PortPolicy null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

