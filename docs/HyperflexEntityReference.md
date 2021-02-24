# HyperflexEntityReference
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.EntityReference"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.EntityReference"]
**Confignum** | **Int64** | Configuration number for this reference. | [optional] [readonly] 
**Id** | **String** | Uuid of the entity for this reference. | [optional] [readonly] 
**Idtype** | **String** | Type of entity id for this reference. * &#x60;VCMOID&#x60; - The entity reference ID type is VC MOID. * &#x60;VMBIOSUUID&#x60; - The entity reference ID type is VM Bios UUID. * &#x60;VMDSPATH&#x60; - The entity reference ID type is VM Datastore Path. * &#x60;VMINSTANCEUUID&#x60; - The entity reference ID type is VM Instance UUID. * &#x60;VMNAME&#x60; - The entity reference ID type is VM Name. | [optional] [readonly] [default to "VCMOID"]
**Name** | **String** | Name of the entity for this entity reference. | [optional] [readonly] 
**Type** | **String** | Type of the entity for this entity reference. * &#x60;DISK&#x60; - This entity type is a disk. * &#x60;PNODE&#x60; - This entity type is a P node. * &#x60;NODE&#x60; - This entity type is a node. * &#x60;CLUSTER&#x60; - This entity type is a cluster. * &#x60;DATASTORE&#x60; - This entity is a datastore. * &#x60;VIRTNODE&#x60; - This entity is a HyperFlex virtual node. * &#x60;VIRTCLUSTER&#x60; - This entity type is a virtual cluster. * &#x60;VIRTDATASTORE&#x60; - This entity type is a virtual data store. * &#x60;VIRTMACHINE&#x60; - This entity type is a virtual machine. * &#x60;PDISK&#x60; - This entity type is a P disk. * &#x60;PDATASTORE&#x60; - This entity type is a P Datastore. * &#x60;VIRTMACHINESNAPSHOT&#x60; - This entity is a virtual machine snapshot. * &#x60;FOLDER&#x60; - This entity type is a folder. * &#x60;RESOURCEPOOL&#x60; - This entity type is a resource pool. * &#x60;FILE&#x60; - This entity type is a file. * &#x60;VIRTDATACENTER&#x60; - This entity type is a virtual data center. * &#x60;REPLICATION_APPLIANCE&#x60; - This entity type is a replication appliance. * &#x60;REPLICATION_JOB&#x60; - This entity type is a replication job. * &#x60;IP_POOL&#x60; - This entity type is an IP Pool. * &#x60;REPLICATION_INFO&#x60; - This entity type is a replication information. * &#x60;DP_VM_SNAPSHOT&#x60; - This entity type is a DP VM Snapshot. * &#x60;DP_VMGROUP_SNAPSHOT&#x60; - This entity type is a DP VM Group Snapshot. * &#x60;DP_VM_CONFIG&#x60; - This entity type is a DP VM Configuration. * &#x60;DP_VM&#x60; - This entity type is a DP VM. * &#x60;DP_VMGROUP&#x60; - This entity type is a DP VM Group. * &#x60;DP_VM_SNAPSHOT_POINT&#x60; - This entity type is a DP VM Snapshot Point. * &#x60;CLUSTER_PAIR&#x60; - This entity is a cluster pair. * &#x60;HX_TASK&#x60; - This entity type is a HyperFlex task. * &#x60;ZONE&#x60; - This entity type is a zone. | [optional] [readonly] [default to "DISK"]

## Examples

- Prepare the resource
```powershell
$HyperflexEntityReference = Initialize-IntersightHyperflexEntityReference  -ClassId null `
 -ObjectType null `
 -Confignum null `
 -Id null `
 -Idtype null `
 -Name null `
 -Type null
```

- Convert the resource to JSON
```powershell
$HyperflexEntityReference | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

