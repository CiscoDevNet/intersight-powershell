# StorageBasePhysicalPortAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Iqn** | **String** | ISCSI qualified name applicable for ethernet port. Example - &#39;iqn.2008-05.com.storage:fnm00151300643-514f0c50141faf05&#39;. | [optional] [readonly] 
**Name** | **String** | Name of the physical port available in storage array. | [optional] [readonly] 
**Speed** | **Int64** | Operational speed of physical port measured in Gbps. | [optional] [readonly] 
**Status** | **String** | Status of storage array port. | [optional] [readonly] [default to "Unknown"]
**Type** | **String** | Port type - possible values are FC, FCoE and iSCSI. | [optional] [readonly] [default to "FC"]
**Wwn** | **String** | World wide name of FC port. It is a combination of WWNN and WWPN represented in 128 bit hexadecimal formatted with colon. Example: &#39;51:4f:0c:50:14:1f:af:01:51:4f:0c:51:14:1f:af:01&#39;. | [optional] [readonly] 
**Wwnn** | **String** | World wide node name of FC port. Represented in 64 bit hex digits, formatted with colon. Example - &#39;51:4f:0c:50:14:1f:af:01&#39;. | [optional] [readonly] 
**Wwpn** | **String** | World wide port name of FC port. Represented in 64 bit hex digits, formatted with colon. Example - &#39;51:4f:0c:51:14:1f:af:01&#39;. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightStorageBasePhysicalPortAllOf  -Iqn null `
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
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

