# VirtualizationVmwareDatacenterAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "virtualization.VmwareDatacenter"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "virtualization.VmwareDatacenter"]
**ClusterCount** | **Int64** | Count of all clusters associated with this DC. | [optional] 
**DatastoreCount** | **Int64** | Count of all datastores associated with this DC. | [optional] 
**HostCount** | **Int64** | Count of all hosts associated with this DC. | [optional] 
**NetworkCount** | **Int64** | Count of all networks associated with this datacenter (DC). | [optional] 
**VmCount** | **Int64** | Count of all virtual machines (VMs) associated with this DC. | [optional] 
**HypervisorManager** | [**VirtualizationVmwareVcenterRelationship**](VirtualizationVmwareVcenterRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$VirtualizationVmwareDatacenterAllOf = Initialize-IntersightVirtualizationVmwareDatacenterAllOf  -ClassId null `
 -ObjectType null `
 -ClusterCount null `
 -DatastoreCount null `
 -HostCount null `
 -NetworkCount null `
 -VmCount null `
 -HypervisorManager null
```

- Convert the resource to JSON
```powershell
$VirtualizationVmwareDatacenterAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

