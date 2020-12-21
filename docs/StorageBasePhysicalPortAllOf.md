# StorageBasePhysicalPortAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. The enum values provides the list of concrete types that can be instantiated from this abstract type. | 
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. The enum values provides the list of concrete types that can be instantiated from this abstract type. | 
**Iqn** | **String** | ISCSI qualified name applicable for ethernet port. Example - &#39;iqn.2008-05.com.storage:fnm00151300643-514f0c50141faf05&#39;. | [optional] [readonly] 
**Name** | **String** | Name of the physical port available in storage array. | [optional] [readonly] 
**Speed** | **Int64** | Operational speed of physical port measured in Gbps. | [optional] [readonly] 
**Status** | **String** | Status of storage array port. * &#x60;Unknown&#x60; - Component status is not available. * &#x60;Ok&#x60; - Component is healthy and no issues found. * &#x60;Degraded&#x60; - Functioning, but not at full capability due to a non-fatal failure. * &#x60;Critical&#x60; - Not functioning or requiring immediate attention. * &#x60;Offline&#x60; - Component is installed, but powered off. * &#x60;Identifying&#x60; - Component is in initialization process. * &#x60;NotAvailable&#x60; - Component is not installed or not available. * &#x60;Updating&#x60; - Software update is in progress. * &#x60;Unrecognized&#x60; - Component is not recognized. It may be because the component is not installed properly or it is not supported. | [optional] [readonly] [default to "Unknown"]
**Type** | **String** | Port type - possible values are FC, FCoE and iSCSI. * &#x60;FC&#x60; - Port supports fibre channel protocol. * &#x60;iSCSI&#x60; - Port supports iSCSI protocol. * &#x60;FCoE&#x60; - Port supports fibre channel over ethernet protocol. | [optional] [readonly] [default to "FC"]
**Wwn** | **String** | World wide name of FC port. It is a combination of WWNN and WWPN represented in 128 bit hexadecimal formatted with colon. Example: &#39;51:4f:0c:50:14:1f:af:01:51:4f:0c:51:14:1f:af:01&#39;. | [optional] [readonly] 
**Wwnn** | **String** | World wide node name of FC port. Represented in 64 bit hex digits, formatted with colon. Example - &#39;51:4f:0c:50:14:1f:af:01&#39;. | [optional] [readonly] 
**Wwpn** | **String** | World wide port name of FC port. Represented in 64 bit hex digits, formatted with colon. Example - &#39;51:4f:0c:51:14:1f:af:01&#39;. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$StorageBasePhysicalPortAllOf = Initialize-IntersightStorageBasePhysicalPortAllOf  -ClassId null `
 -ObjectType null `
 -Iqn null `
 -Name null `
 -Speed null `
 -Status null `
 -Type null `
 -Wwn null `
 -Wwnn null `
 -Wwpn null
```

- Convert the resource to JSON
```powershell
$StorageBasePhysicalPortAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

