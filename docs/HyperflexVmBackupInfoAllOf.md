# HyperflexVmBackupInfoAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.VmBackupInfo"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.VmBackupInfo"]
**BackupStatus** | **String** | Description of the backup status of this VmBackupInfo. * &#x60;InitializingProtection&#x60; - Protection has started, but not completed. * &#x60;Protected&#x60; - Protection has completed successfully. * &#x60;ExceedsInterval&#x60; - Protection has not completed successfully in over two times the backup interval. | [optional] [readonly] [default to "InitializingProtection"]
**ClusterEntityReference** | [**HyperflexEntityReference**](HyperflexEntityReference.md) |  | [optional] 
**ClusterIdProtectionInfoMap** | [**HyperflexMapClusterIdToProtectionInfo[]**](HyperflexMapClusterIdToProtectionInfo.md) |  | [optional] 
**VarError** | [**HyperflexErrorStack**](HyperflexErrorStack.md) |  | [optional] 
**ProtectionStatus** | **String** | Description of the protection status of this VmBackupInfo. * &#x60;PREPARE_FAILOVER_STARTED&#x60; - The protection status is prepare failover started. * &#x60;PREPARE_FAILOVER_FAILED&#x60; - The protection status is prepare failover failed. * &#x60;PREPARE_FAILOVER_COMPLETED&#x60; - The protection status is prepaire failover completed. * &#x60;FAILOVER_STARTED&#x60; - The protection status is failover started. * &#x60;FAILOVER_FAILED&#x60; - The protection status is failover failed. * &#x60;FAILOVER_COMPLETED&#x60; - The protection status is failover completed. * &#x60;PREPARE_REVERSEPROTECT_STARTED&#x60; - The protection status is prepare reverse protect started. * &#x60;PREPARE_REVERSEPROTECT_FAILED&#x60; - The protection status is prepare reverse protect failed. * &#x60;PREPARE_REVERSEPROTECT_COMPLETED&#x60; - The protection status is prepair reverse protect completed. * &#x60;REVERSEPROTECT_STARTED&#x60; - The protection status is reverse protect started. * &#x60;REVERSEPROTECT_FAILED&#x60; - The protection status is reverse protect failed. * &#x60;ACTIVE&#x60; - The protection status is active. * &#x60;CREATION_IN_PROGRESS&#x60; - The protection status is failover in progress. * &#x60;CREATION_FAILED&#x60; - The protection status is creation failed. * &#x60;LOCAL_RESTORE_STARTED&#x60; - The protection status is local restore started. * &#x60;LOCAL_RESTORE_FAILED&#x60; - The protection status is local restore failed. | [optional] [readonly] [default to "PREPARE_FAILOVER_STARTED"]
**Schedule** | [**HyperflexReplicationClusterReferenceToSchedule[]**](HyperflexReplicationClusterReferenceToSchedule.md) |  | [optional] 
**VmEntityReference** | [**HyperflexEntityReference**](HyperflexEntityReference.md) |  | [optional] 
**VmInfo** | [**HyperflexVirtualMachine**](HyperflexVirtualMachine.md) |  | [optional] 
**SrcBackupCluster** | [**HyperflexBackupClusterRelationship**](HyperflexBackupClusterRelationship.md) |  | [optional] 
**SrcCluster** | [**HyperflexClusterRelationship**](HyperflexClusterRelationship.md) |  | [optional] 
**TgtCluster** | [**HyperflexClusterRelationship**](HyperflexClusterRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$HyperflexVmBackupInfoAllOf = Initialize-IntersightHyperflexVmBackupInfoAllOf  -ClassId null `
 -ObjectType null `
 -BackupStatus null `
 -ClusterEntityReference null `
 -ClusterIdProtectionInfoMap null `
 -VarError null `
 -ProtectionStatus null `
 -Schedule null `
 -VmEntityReference null `
 -VmInfo null `
 -SrcBackupCluster null `
 -SrcCluster null `
 -TgtCluster null
```

- Convert the resource to JSON
```powershell
$HyperflexVmBackupInfoAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

