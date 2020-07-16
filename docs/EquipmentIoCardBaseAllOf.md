# EquipmentIoCardBaseAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ConnectionStatus** | **String** | Connectivity Status of FEX/IOM to Switch - A or B or AB. | [optional] 
**Description** | **String** | This field is to provide description for the iocard module model. | [optional] [readonly] 
**ModuleId** | **Int64** | Module Identifier for the IO module. | [optional] [readonly] 
**OperState** | **String** | Operational state of IO card or fabric extender. | [optional] [readonly] 
**PartNumber** | **String** | Part Number identifier for the IO module. | [optional] [readonly] 
**VarPid** | **String** | This field identifies the Product ID for the IO module. | [optional] [readonly] 
**Presence** | **String** | This field identifies the Presence state of the IO card module. | [optional] [readonly] 
**ProductName** | **String** | This field identifies the Product Name for the iocard module model. | [optional] [readonly] 
**Sku** | **String** | This field identifies the Stock Keeping Unit for the IO card module. | [optional] [readonly] 
**Version** | **String** | This field identifies the version of the IO card module. | [optional] [readonly] 
**Vid** | **String** | This field identifies the Vendor ID for the IO card module. | [optional] [readonly] 
**HostPorts** | [**EtherHostPortRelationship[]**](EtherHostPortRelationship.md) | An array of relationships to etherHostPort resources. | [optional] 
**MgmtController** | [**ManagementControllerRelationship**](ManagementControllerRelationship.md) |  | [optional] 
**NetworkPorts** | [**EtherNetworkPortRelationship[]**](EtherNetworkPortRelationship.md) | An array of relationships to etherNetworkPort resources. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightEquipmentIoCardBaseAllOf  -ConnectionStatus null `
 -Description null `
 -ModuleId null `
 -OperState null `
 -PartNumber null `
 -VarPid null `
 -Presence null `
 -ProductName null `
 -Sku null `
 -Version null `
 -Vid null `
 -HostPorts null `
 -MgmtController null `
 -NetworkPorts null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

