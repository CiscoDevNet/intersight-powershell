# VirtualizationVmwareDatacenterAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClusterCount** | **Int64** | Count of all clusters associated with this DC. | [optional] 
**DatastoreCount** | **Int64** | Count of all datastores associated with this DC. | [optional] 
**HostCount** | **Int64** | Count of all hosts associated with this DC. | [optional] 
**NetworkCount** | **Int64** | Count of all networks associated with this datacenter (DC). | [optional] 
**VmCount** | **Int64** | Count of all virtual machines (VMs) associated with this DC. | [optional] 
**HypervisorManager** | [**VirtualizationVmwareVcenterRelationship**](VirtualizationVmwareVcenterRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightVirtualizationVmwareDatacenterAllOf  -ClusterCount null `
 -DatastoreCount null `
 -HostCount null `
 -NetworkCount null `
 -VmCount null `
 -HypervisorManager null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

