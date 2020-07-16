# StorageDiskGroupPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DedicatedHotSpares** | [**StorageLocalDisk[]**](StorageLocalDisk.md) |  | [optional] 
**RaidLevel** | **String** | The supported RAID level for the disk group. | [optional] [default to "Raid0"]
**SpanGroups** | [**StorageSpanGroup[]**](StorageSpanGroup.md) |  | [optional] 
**UseJbods** | **Boolean** | Selected disks in the disk group in JBOD state will be set to Unconfigured Good state before they are used in virtual drive creation. | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 
**StoragePolicies** | [**StorageStoragePolicyRelationship[]**](StorageStoragePolicyRelationship.md) | An array of relationships to storageStoragePolicy resources. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightStorageDiskGroupPolicyAllOf  -DedicatedHotSpares null `
 -RaidLevel null `
 -SpanGroups null `
 -UseJbods null `
 -Organization null `
 -StoragePolicies null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

