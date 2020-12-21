# StorageStoragePolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "storage.StoragePolicy"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "storage.StoragePolicy"]
**GlobalHotSpares** | [**StorageLocalDisk[]**](StorageLocalDisk.md) |  | [optional] 
**RetainPolicyVirtualDrives** | **Boolean** | Retains the virtual drives defined in policy if they exist already. If this flag is false, the existing virtual drives are removed and created again based on virtual drives in the policy. | [optional] [default to $true]
**UnusedDisksState** | **String** | Unused Disks State is used to specify the state, unconfigured good or jbod, in which the disks that are not used in this policy should be moved. * &#x60;UnconfiguredGood&#x60; - Unconfigured good state -ready to be added in a RAID group. * &#x60;Jbod&#x60; - JBOD state where the disks start showing up to host os. | [optional] [default to "UnconfiguredGood"]
**VirtualDrives** | [**StorageVirtualDriveConfig[]**](StorageVirtualDriveConfig.md) |  | [optional] 
**DiskGroupPolicies** | [**StorageDiskGroupPolicyRelationship[]**](StorageDiskGroupPolicyRelationship.md) | An array of relationships to storageDiskGroupPolicy resources. | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 
**Profiles** | [**PolicyAbstractConfigProfileRelationship[]**](PolicyAbstractConfigProfileRelationship.md) | An array of relationships to policyAbstractConfigProfile resources. | [optional] 

## Examples

- Prepare the resource
```powershell
$StorageStoragePolicyAllOf = Initialize-IntersightStorageStoragePolicyAllOf  -ClassId null `
 -ObjectType null `
 -GlobalHotSpares null `
 -RetainPolicyVirtualDrives null `
 -UnusedDisksState null `
 -VirtualDrives null `
 -DiskGroupPolicies null `
 -Organization null `
 -Profiles null
```

- Convert the resource to JSON
```powershell
$StorageStoragePolicyAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

