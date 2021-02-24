# StorageNetAppFcInterfaceAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "storage.NetAppFcInterface"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "storage.NetAppFcInterface"]
**Enabled** | **String** | FC interface is enabled or not. | [optional] [readonly] 
**State** | **String** | State of FC interface. * &#x60;down&#x60; - An inactive port is listed as Down. * &#x60;up&#x60; - An active port is listed as Up. * &#x60;present&#x60; - An active port is listed as present. | [optional] [readonly] [default to "down"]
**Uuid** | **String** | Uuid of  NetApp FC Interface. | [optional] [readonly] 
**ArrayController** | [**StorageNetAppNodeRelationship**](StorageNetAppNodeRelationship.md) |  | [optional] 
**PhysicalPort** | [**StorageNetAppFcPortRelationship**](StorageNetAppFcPortRelationship.md) |  | [optional] 
**Tenant** | [**StorageNetAppStorageVmRelationship**](StorageNetAppStorageVmRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$StorageNetAppFcInterfaceAllOf = Initialize-IntersightStorageNetAppFcInterfaceAllOf  -ClassId null `
 -ObjectType null `
 -Enabled null `
 -State null `
 -Uuid null `
 -ArrayController null `
 -PhysicalPort null `
 -Tenant null
```

- Convert the resource to JSON
```powershell
$StorageNetAppFcInterfaceAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

