# OsPhysicalDiskResponseAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "os.PhysicalDiskResponse"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "os.PhysicalDiskResponse"]
**Bootable** | **String** | Bootable field of the Physical Drive target. | [optional] 
**Name** | **String** | The Physical Disk Name to be used as Install Target. | [optional] 
**SerialNumber** | **String** | Serial Number of the Physical Disk Target. | [optional] 
**StorageControllerSlotId** | **String** | The Storage Controller associated to the physical disk. | [optional] 

## Examples

- Prepare the resource
```powershell
$OsPhysicalDiskResponseAllOf = Initialize-IntersightOsPhysicalDiskResponseAllOf  -ClassId null `
 -ObjectType null `
 -Bootable null `
 -Name null `
 -SerialNumber null `
 -StorageControllerSlotId null
```

- Convert the resource to JSON
```powershell
$OsPhysicalDiskResponseAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

