# OsValidInstallTargetAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "os.ValidInstallTarget"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "os.ValidInstallTarget"]
**VarError** | **String** | Error message if any errors are encountered while fetching and validating Install targets for the server. | [optional] [readonly] 
**M2Jbod** | [**OsPhysicalDiskResponse[]**](OsPhysicalDiskResponse.md) |  | [optional] 
**M2VirtualDrives** | [**OsVirtualDriveResponse[]**](OsVirtualDriveResponse.md) |  | [optional] 
**MraidJbod** | [**OsPhysicalDiskResponse[]**](OsPhysicalDiskResponse.md) |  | [optional] 
**MraidVirtualDrives** | [**OsVirtualDriveResponse[]**](OsVirtualDriveResponse.md) |  | [optional] 
**Servers** | [**ComputePhysicalRelationship[]**](ComputePhysicalRelationship.md) | An array of relationships to computePhysical resources. | [optional] 

## Examples

- Prepare the resource
```powershell
$OsValidInstallTargetAllOf = Initialize-IntersightOsValidInstallTargetAllOf  -ClassId null `
 -ObjectType null `
 -VarError null `
 -M2Jbod null `
 -M2VirtualDrives null `
 -MraidJbod null `
 -MraidVirtualDrives null `
 -Servers null
```

- Convert the resource to JSON
```powershell
$OsValidInstallTargetAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

