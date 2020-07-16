# StorageStoragePolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GlobalHotSpares** | [**StorageLocalDisk[]**](StorageLocalDisk.md) |  | [optional] 
**RetainPolicyVirtualDrives** | **Boolean** | Retains the virtual drives defined in policy if they exist already. If this flag is false, the existing virtual drives are removed and created again based on virtual drives in the policy. | [optional] 
**UnusedDisksState** | **String** | Unused Disks State is used to specify the state, unconfigured good or jbod, in which the disks that are not used in this policy should be moved. | [optional] [default to "UnconfiguredGood"]
**VirtualDrives** | [**StorageVirtualDriveConfig[]**](StorageVirtualDriveConfig.md) |  | [optional] 
**DiskGroupPolicies** | [**StorageDiskGroupPolicyRelationship[]**](StorageDiskGroupPolicyRelationship.md) | An array of relationships to storageDiskGroupPolicy resources. | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 
**Profiles** | [**PolicyAbstractConfigProfileRelationship[]**](PolicyAbstractConfigProfileRelationship.md) | An array of relationships to policyAbstractConfigProfile resources. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightStorageStoragePolicyAllOf  -GlobalHotSpares null `
 -RetainPolicyVirtualDrives null `
 -UnusedDisksState null `
 -VirtualDrives null `
 -DiskGroupPolicies null `
 -Organization null `
 -Profiles null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

