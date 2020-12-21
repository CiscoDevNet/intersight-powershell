# AdapterHostIscsiInterfaceAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "adapter.HostIscsiInterface"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "adapter.HostIscsiInterface"]
**AdminState** | **String** | Admin Configured State of Host ISCSI Interface. | [optional] [readonly] 
**EpDn** | **String** | The Endpoint Config Dn of the Host ISCSI Interface. | [optional] [readonly] 
**HostIscsiInterfaceId** | **Int64** | Identifier of the Host ISCSI Interface. | [optional] [readonly] 
**HostVisible** | **String** | The visibility of the Host to the endpoint. | [optional] [readonly] 
**MacAddress** | **String** | MAC address of Host ISCSI Interface. | [optional] [readonly] 
**Name** | **String** | Name of the Host ISCSI Interface. | [optional] [readonly] 
**OperState** | **String** | Operational State of Host ISCSI Interface. | [optional] [readonly] 
**Operability** | **String** | Operability status of Host ISCSI Interface. | [optional] [readonly] 
**PeerDn** | **String** | PeerPort Dn of Host ISCSI Interface. | [optional] [readonly] 
**AdapterUnit** | [**AdapterUnitRelationship**](AdapterUnitRelationship.md) |  | [optional] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$AdapterHostIscsiInterfaceAllOf = Initialize-IntersightAdapterHostIscsiInterfaceAllOf  -ClassId null `
 -ObjectType null `
 -AdminState null `
 -EpDn null `
 -HostIscsiInterfaceId null `
 -HostVisible null `
 -MacAddress null `
 -Name null `
 -OperState null `
 -Operability null `
 -PeerDn null `
 -AdapterUnit null `
 -InventoryDeviceInfo null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$AdapterHostIscsiInterfaceAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

