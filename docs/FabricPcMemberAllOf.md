# FabricPcMemberAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PcId** | **Int64** | Port Channel Identifier for the collection of ports. | [optional] 
**PortPolicy** | [**FabricPortPolicyRelationship**](FabricPortPolicyRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightFabricPcMemberAllOf  -PcId null `
 -PortPolicy null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

