# StorageDiskGroupPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "storage.DiskGroupPolicy"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "storage.DiskGroupPolicy"]
**DedicatedHotSpares** | [**StorageLocalDisk[]**](StorageLocalDisk.md) |  | [optional] 
**RaidLevel** | **String** | The supported RAID level for the disk group. * &#x60;Raid0&#x60; - RAID 0 Stripe Raid Level. * &#x60;Raid1&#x60; - RAID 1 Mirror Raid Level. * &#x60;Raid5&#x60; - RAID 5 Mirror Raid Level. * &#x60;Raid6&#x60; - RAID 6 Mirror Raid Level. * &#x60;Raid10&#x60; - RAID 10 Mirror Raid Level. * &#x60;Raid50&#x60; - RAID 50 Mirror Raid Level. * &#x60;Raid60&#x60; - RAID 60 Mirror Raid Level. | [optional] [default to "Raid0"]
**SpanGroups** | [**StorageSpanGroup[]**](StorageSpanGroup.md) |  | [optional] 
**UseJbods** | **Boolean** | Selected disks in the disk group in JBOD state will be set to Unconfigured Good state before they are used in virtual drive creation. | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 
**StoragePolicies** | [**StorageStoragePolicyRelationship[]**](StorageStoragePolicyRelationship.md) | An array of relationships to storageStoragePolicy resources. | [optional] 

## Examples

- Prepare the resource
```powershell
$StorageDiskGroupPolicyAllOf = Initialize-IntersightStorageDiskGroupPolicyAllOf  -ClassId null `
 -ObjectType null `
 -DedicatedHotSpares null `
 -RaidLevel null `
 -SpanGroups null `
 -UseJbods null `
 -Organization null `
 -StoragePolicies null
```

- Convert the resource to JSON
```powershell
$StorageDiskGroupPolicyAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

