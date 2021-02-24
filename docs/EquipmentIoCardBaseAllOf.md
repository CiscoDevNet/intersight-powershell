# EquipmentIoCardBaseAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. The enum values provides the list of concrete types that can be instantiated from this abstract type. | 
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. The enum values provides the list of concrete types that can be instantiated from this abstract type. | 
**ConnectionStatus** | **String** | Connectivity Status of FEX/IOM to Switch - A or B or AB. | [optional] 
**Description** | **String** | This field is to provide description for the iocard module model. | [optional] [readonly] 
**ModuleId** | **Int64** | Module Identifier for the IO module. | [optional] [readonly] 
**OperReason** | **String[]** |  | [optional] 
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
$EquipmentIoCardBaseAllOf = Initialize-IntersightEquipmentIoCardBaseAllOf  -ClassId null `
 -ObjectType null `
 -ConnectionStatus null `
 -Description null `
 -ModuleId null `
 -OperReason null `
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
$EquipmentIoCardBaseAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

