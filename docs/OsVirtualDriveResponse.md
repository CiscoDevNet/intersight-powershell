# OsVirtualDriveResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "os.VirtualDriveResponse"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "os.VirtualDriveResponse"]
**Bootable** | **String** | Bootable field of the Virtual Drive target. | [optional] 
**Id** | **String** | Virtual Drive ID to be used as Install Target. | [optional] 
**Name** | **String** | The Virtual Drive Name to be used as Install Target. | [optional] 
**StorageControllerSlotId** | **String** | The Storage Controller associated to the virtual drive. | [optional] 

## Examples

- Prepare the resource
```powershell
$OsVirtualDriveResponse = Initialize-IntersightOsVirtualDriveResponse  -ClassId null `
 -ObjectType null `
 -Bootable null `
 -Id null `
 -Name null `
 -StorageControllerSlotId null
```

- Convert the resource to JSON
```powershell
$OsVirtualDriveResponse | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

