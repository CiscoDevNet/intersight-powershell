# StorageBaseNfsExportAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. The enum values provides the list of concrete types that can be instantiated from this abstract type. | [default to "storage.NetAppExportPolicy"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. The enum values provides the list of concrete types that can be instantiated from this abstract type. | [default to "storage.NetAppExportPolicy"]
**Name** | **String** | Name of the NFS export in storage array. | [optional] [readonly] 
**Uuid** | **String** | The uuid of this NFS export. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$StorageBaseNfsExportAllOf = Initialize-IntersightStorageBaseNfsExportAllOf  -ClassId null `
 -ObjectType null `
 -Name null `
 -Uuid null
```

- Convert the resource to JSON
```powershell
$StorageBaseNfsExportAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

