# VirtualizationNetworkInterfaceAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "virtualization.NetworkInterface"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "virtualization.NetworkInterface"]
**AdaptorType** | **String** | Virtual machine network adaptor type. * &#x60;Unknown&#x60; - The type of the network adaptor type is unknown. * &#x60;E1000&#x60; - Emulated version of the Intel 82545EM Gigabit Ethernet NIC. * &#x60;SRIOV&#x60; - Representation of a virtual function (VF) on a physical NIC with SR-IOV support. * &#x60;VMXNET2&#x60; - VMXNET 2 (Enhanced) is available only for some guest operating systems on ESX/ESXi 3.5 and later. * &#x60;VMXNET3&#x60; - VMXNET 3 offers all the features available in VMXNET 2 and adds several new features. | [optional] [default to "Unknown"]
**Bridge** | **String** | Virtual machine network bridge name. | [optional] 
**ConnectAtPowerOn** | **Boolean** | Connect the adaptor at virtual machine power on. | [optional] 
**DirectPathIo** | **Boolean** | Enable the direct path I/O. | [optional] 
**MacAddress** | **String** | Virtual machine network mac address. | [optional] 

## Examples

- Prepare the resource
```powershell
$VirtualizationNetworkInterfaceAllOf = Initialize-IntersightVirtualizationNetworkInterfaceAllOf  -ClassId null `
 -ObjectType null `
 -AdaptorType null `
 -Bridge null `
 -ConnectAtPowerOn null `
 -DirectPathIo null `
 -MacAddress null
```

- Convert the resource to JSON
```powershell
$VirtualizationNetworkInterfaceAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

