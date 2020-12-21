# AdapterUnitAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "adapter.Unit"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "adapter.Unit"]
**AdapterId** | **String** | Unique Identifier of an adapter Unit within a Rack Interface. | [optional] [readonly] 
**BaseMacAddress** | **String** | Original Base Mac address of an adapter unit. | [optional] [readonly] 
**ConnectionStatus** | **String** | Connectivity Status of adapter - A or B or AB. | [optional] [readonly] 
**Integrated** | **String** | Cisco Integrated adapter or other type. | [optional] [readonly] 
**OperState** | **String** | Operational state of an adapter unit. | [optional] [readonly] 
**Operability** | **String** | Operability state of an adapter unit. | [optional] [readonly] 
**PartNumber** | **String** | Part number of an adapter unit. | [optional] [readonly] 
**PciSlot** | **String** | PCIe slot of the adapter in the server. | [optional] [readonly] 
**Power** | **String** | Power state of an adapter unit. | [optional] [readonly] 
**Presence** | **String** | Adapter Unit presence or absence. | [optional] [readonly] 
**Thermal** | **String** | Thermal state of an adapter unit. | [optional] [readonly] 
**Vid** | **String** | Virtual Id of the adapter in the server. | [optional] [readonly] 
**ComputeBlade** | [**ComputeBladeRelationship**](ComputeBladeRelationship.md) |  | [optional] 
**ComputeRackUnit** | [**ComputeRackUnitRelationship**](ComputeRackUnitRelationship.md) |  | [optional] 
**Controller** | [**ManagementControllerRelationship**](ManagementControllerRelationship.md) |  | [optional] 
**ExtEthIfs** | [**AdapterExtEthInterfaceRelationship[]**](AdapterExtEthInterfaceRelationship.md) | An array of relationships to adapterExtEthInterface resources. | [optional] [readonly] 
**HostEthIfs** | [**AdapterHostEthInterfaceRelationship[]**](AdapterHostEthInterfaceRelationship.md) | An array of relationships to adapterHostEthInterface resources. | [optional] [readonly] 
**HostFcIfs** | [**AdapterHostFcInterfaceRelationship[]**](AdapterHostFcInterfaceRelationship.md) | An array of relationships to adapterHostFcInterface resources. | [optional] [readonly] 
**HostIscsiIfs** | [**AdapterHostIscsiInterfaceRelationship[]**](AdapterHostIscsiInterfaceRelationship.md) | An array of relationships to adapterHostIscsiInterface resources. | [optional] [readonly] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$AdapterUnitAllOf = Initialize-IntersightAdapterUnitAllOf  -ClassId null `
 -ObjectType null `
 -AdapterId null `
 -BaseMacAddress null `
 -ConnectionStatus null `
 -Integrated null `
 -OperState null `
 -Operability null `
 -PartNumber null `
 -PciSlot null `
 -Power null `
 -Presence null `
 -Thermal null `
 -Vid null `
 -ComputeBlade null `
 -ComputeRackUnit null `
 -Controller null `
 -ExtEthIfs null `
 -HostEthIfs null `
 -HostFcIfs null `
 -HostIscsiIfs null `
 -InventoryDeviceInfo null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$AdapterUnitAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

