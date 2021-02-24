# OsVirtualDrive
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "os.VirtualDrive"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "os.VirtualDrive"]
**Id** | **String** | Virtual Drive ID to be used as Install Target. | [optional] 
**Name** | **String** | The Virtual Drive Name to be used as Install Target. | [optional] 
**StorageControllerSlotId** | **String** | The SlotID of the Storage Controller associated to the virtual drive. | [optional] 

## Examples

- Prepare the resource
```powershell
$OsVirtualDrive = Initialize-IntersightOsVirtualDrive  -ClassId null `
 -ObjectType null `
 -Id null `
 -Name null `
 -StorageControllerSlotId null
```

- Convert the resource to JSON
```powershell
$OsVirtualDrive | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

