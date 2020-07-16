# PortInterfaceBaseAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OperState** | **String** | Operational state of an Interface. | [optional] 
**AcknowledgedPeerInterface** | [**EtherPhysicalPortBaseRelationship**](EtherPhysicalPortBaseRelationship.md) |  | [optional] 
**PeerInterface** | [**EtherPhysicalPortBaseRelationship**](EtherPhysicalPortBaseRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightPortInterfaceBaseAllOf  -OperState null `
 -AcknowledgedPeerInterface null `
 -PeerInterface null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

