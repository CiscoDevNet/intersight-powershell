# VirtualizationHostAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "virtualization.Host"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "virtualization.Host"]
**Action** | **String** | Action to be performed on a host (Create, PowerState, Migrate, Clone etc). * &#x60;None&#x60; - A place holder for the default value. * &#x60;PowerOffStorageController&#x60; - Power off HyperFlex storage controller node running on selected hypervisor host. * &#x60;PowerOnStorageController&#x60; - Power on HyperFlex storage controller node running on selected hypervisor host. | [optional] [default to "None"]
**HypervisorType** | **String** | Identifies the broad product type of the hypervisor but without any version information. It is here to easily identify the type of the virtual machine. There are other entities (Host, Cluster, etc.) that can be indirectly used to determine the hypervisor but a direct attribute makes it easier to work with. * &#x60;ESXi&#x60; - The hypervisor running on the HyperFlex cluster is a Vmware ESXi hypervisor of any version. * &#x60;HyperFlexAp&#x60; - The hypervisor running on the HyperFlex cluster is Cisco HyperFlex Application Platform. * &#x60;Hyper-V&#x60; - The hypervisor running on the HyperFlex cluster is Microsoft Hyper-V. * &#x60;Unknown&#x60; - The hypervisor running on the HyperFlex cluster is not known. | [optional] [readonly] [default to "ESXi"]
**Identity** | **String** | Unique identifier assigned to the hypervisor host. | [optional] [readonly] 
**Model** | **String** | Commercial model information about this hardware. | [optional] [readonly] 
**Name** | **String** | Name of the hypervisor host. It must be unique within the targer endpoint. | [optional] [readonly] 
**Serial** | **String** | Serial number of this host (internally generated). | [optional] [readonly] 
**Vendor** | **String** | Commercial vendor details of this hardware. | [optional] [readonly] 
**Inventory** | [**VirtualizationBaseHostRelationship**](VirtualizationBaseHostRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**WorkflowInfo** | [**WorkflowWorkflowInfoRelationship**](WorkflowWorkflowInfoRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$VirtualizationHostAllOf = Initialize-IntersightVirtualizationHostAllOf  -ClassId null `
 -ObjectType null `
 -Action null `
 -HypervisorType null `
 -Identity null `
 -Model null `
 -Name null `
 -Serial null `
 -Vendor null `
 -Inventory null `
 -RegisteredDevice null `
 -WorkflowInfo null
```

- Convert the resource to JSON
```powershell
$VirtualizationHostAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

