# EtherPhysicalPortBaseAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MacAddress** | **String** | Mac Address of a port in the Fabric Interconnect. | [optional] [readonly] 
**Mode** | **String** | Operating mode of this port. | [optional] [readonly] 
**OperSpeed** | **String** | Current Operational speed for this port. | [optional] [readonly] 
**PeerDn** | **String** | PeerDn for ethernet physical port. | [optional] [readonly] 
**PortChannelId** | **Int64** | Port channel id for port channel created on FI switch. | [optional] [readonly] 
**PortType** | **String** | Defines the transport type for this port (ethernet OR fc). | [optional] [readonly] 
**TransceiverType** | **String** | Transceiver model attached to a port in the Fabric Interconnect. | [optional] [readonly] 
**AcknowledgedPeerInterface** | [**PortInterfaceBaseRelationship**](PortInterfaceBaseRelationship.md) |  | [optional] 
**PeerInterface** | [**PortInterfaceBaseRelationship**](PortInterfaceBaseRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightEtherPhysicalPortBaseAllOf  -MacAddress null `
 -Mode null `
 -OperSpeed null `
 -PeerDn null `
 -PortChannelId null `
 -PortType null `
 -TransceiverType null `
 -AcknowledgedPeerInterface null `
 -PeerInterface null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

