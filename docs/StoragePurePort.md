# StoragePurePort
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountMoid** | **String** | The Account ID for this managed object. | [optional] [readonly] 
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**CreateTime** | **System.DateTime** | The time when this managed object was created. | [optional] [readonly] 
**DomainGroupMoid** | **String** | The DomainGroup ID for this managed object. | [optional] [readonly] 
**ModTime** | **System.DateTime** | The time when this managed object was last modified. | [optional] [readonly] 
**Moid** | **String** | The unique identifier of this Managed Object instance. | [optional] 
**ObjectType** | **String** | The fully-qualified type of this managed object, i.e. the class name. This property is optional. The ObjectType is implied from the URL path. If specified, the value of objectType must match the class name specified in the URL path. | [readonly] 
**Owners** | **String[]** |  | [optional] 
**SharedScope** | **String** | Intersight provides pre-built workflows, tasks and policies to end users through global catalogs. Objects that are made available through global catalogs are said to have a &#39;shared&#39; ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs. | [optional] [readonly] 
**Tags** | [**MoTag[]**](MoTag.md) |  | [optional] 
**VersionContext** | [**MoVersionContext**](MoVersionContext.md) |  | [optional] 
**Ancestors** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**Parent** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 
**PermissionResources** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**DisplayNames** | [**System.Collections.Hashtable**](Array.md) | a map of display names for a resource. | [optional] [readonly] 
**Iqn** | **String** | ISCSI qualified name applicable for ethernet port. Example - &#39;iqn.2008-05.com.storage:fnm00151300643-514f0c50141faf05&#39;. | [optional] [readonly] 
**Name** | **String** | Name of the physical port available in storage array. | [optional] [readonly] 
**Speed** | **Int64** | Operational speed of physical port measured in Gbps. | [optional] [readonly] 
**Status** | **String** | Status of storage array port. | [optional] [readonly] [default to "Unknown"]
**Type** | **String** | Port type - possible values are FC, FCoE and iSCSI. | [optional] [readonly] [default to "FC"]
**Wwn** | **String** | World wide name of FC port. It is a combination of WWNN and WWPN represented in 128 bit hexadecimal formatted with colon. Example: &#39;51:4f:0c:50:14:1f:af:01:51:4f:0c:51:14:1f:af:01&#39;. | [optional] [readonly] 
**Wwnn** | **String** | World wide node name of FC port. Represented in 64 bit hex digits, formatted with colon. Example - &#39;51:4f:0c:50:14:1f:af:01&#39;. | [optional] [readonly] 
**Wwpn** | **String** | World wide port name of FC port. Represented in 64 bit hex digits, formatted with colon. Example - &#39;51:4f:0c:51:14:1f:af:01&#39;. | [optional] [readonly] 
**Failover** | **String** | Name of the port to which this port has failed over. | [optional] [readonly] 
**Portal** | **String** | Ip address of iSCSI portal configured on the port. | [optional] [readonly] 
**Array** | [**StoragePureArrayRelationship**](StoragePureArrayRelationship.md) |  | [optional] 
**Controller** | [**StoragePureControllerRelationship**](StoragePureControllerRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightStoragePurePort  -AccountMoid null `
 -ClassId null `
 -CreateTime null `
 -DomainGroupMoid null `
 -ModTime null `
 -Moid null `
 -ObjectType null `
 -Owners null `
 -SharedScope null `
 -Tags null `
 -VersionContext null `
 -Ancestors null `
 -Parent null `
 -PermissionResources null `
 -DisplayNames null `
 -Iqn null `
 -Name null `
 -Speed null `
 -Status null `
 -Type null `
 -Wwn null `
 -Wwnn null `
 -Wwpn null `
 -Failover null `
 -Portal null `
 -Array null `
 -Controller null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

