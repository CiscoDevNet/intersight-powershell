# VnicEthAdapterPolicy
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
**Description** | **String** | Description of the policy. | [optional] 
**Name** | **String** | Name of the concrete policy. | [optional] 
**AdvancedFilter** | **Boolean** | Enables advanced filtering on the interface. | [optional] 
**ArfsSettings** | [**VnicArfsSettings**](VnicArfsSettings.md) |  | [optional] 
**CompletionQueueSettings** | [**VnicCompletionQueueSettings**](VnicCompletionQueueSettings.md) |  | [optional] 
**InterruptScaling** | **Boolean** | Enables Interrupt Scaling on the interface. | [optional] 
**InterruptSettings** | [**VnicEthInterruptSettings**](VnicEthInterruptSettings.md) |  | [optional] 
**NvgreSettings** | [**VnicNvgreSettings**](VnicNvgreSettings.md) |  | [optional] 
**RoceSettings** | [**VnicRoceSettings**](VnicRoceSettings.md) |  | [optional] 
**RssHashSettings** | [**VnicRssHashSettings**](VnicRssHashSettings.md) |  | [optional] 
**RssSettings** | **Boolean** | Receive Side Scaling allows the incoming traffic to be spread across multiple CPU cores. | [optional] 
**RxQueueSettings** | [**VnicEthRxQueueSettings**](VnicEthRxQueueSettings.md) |  | [optional] 
**TcpOffloadSettings** | [**VnicTcpOffloadSettings**](VnicTcpOffloadSettings.md) |  | [optional] 
**TxQueueSettings** | [**VnicEthTxQueueSettings**](VnicEthTxQueueSettings.md) |  | [optional] 
**UplinkFailbackTimeout** | **Int64** | Uplink Failback Timeout in seconds when uplink failover is enabled for a vNIC. After a vNIC has started using its secondary interface, this setting controls how long the primary interface must be available before the system resumes using the primary interface for the vNIC. | [optional] 
**VxlanSettings** | [**VnicVxlanSettings**](VnicVxlanSettings.md) |  | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightVnicEthAdapterPolicy  -AccountMoid null `
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
 -Description null `
 -Name null `
 -AdvancedFilter null `
 -ArfsSettings null `
 -CompletionQueueSettings null `
 -InterruptScaling null `
 -InterruptSettings null `
 -NvgreSettings null `
 -RoceSettings null `
 -RssHashSettings null `
 -RssSettings null `
 -RxQueueSettings null `
 -TcpOffloadSettings null `
 -TxQueueSettings null `
 -UplinkFailbackTimeout null `
 -VxlanSettings null `
 -Organization null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

