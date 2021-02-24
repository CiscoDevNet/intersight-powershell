# NiatelemetryNiaInventoryDcnmAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "niatelemetry.NiaInventoryDcnm"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "niatelemetry.NiaInventoryDcnm"]
**Dev** | **Boolean** | Returns the value of the dev Field. | [optional] 
**HaEnabled** | **Boolean** | Returns the value of the haEnabled field. | [optional] 
**HaReplicationStatus** | **String** | Returns the value of the haReplicationStatus field. | [optional] 
**Install** | **String** | Returns the value of the install field. | [optional] 
**IsMediaController** | **Boolean** | Returns the value of the isMediaController field. | [optional] 
**NumFabrics** | **Int64** | Returns total number of fabrics in DCNM set-up. | [optional] 
**NumFabricsInMsd** | **Int64** | Returns the number of fabrics in msd. | [optional] 
**NumLocalUsers** | **Int64** | Returns the number of local users other than admin user. | [optional] 
**Version** | **String** | Returns the value of the version field. | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$NiatelemetryNiaInventoryDcnmAllOf = Initialize-IntersightNiatelemetryNiaInventoryDcnmAllOf  -ClassId null `
 -ObjectType null `
 -Dev null `
 -HaEnabled null `
 -HaReplicationStatus null `
 -Install null `
 -IsMediaController null `
 -NumFabrics null `
 -NumFabricsInMsd null `
 -NumLocalUsers null `
 -Version null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$NiatelemetryNiaInventoryDcnmAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

