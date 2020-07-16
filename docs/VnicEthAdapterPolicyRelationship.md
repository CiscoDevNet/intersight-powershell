# VnicEthAdapterPolicyRelationship
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The fully-qualified type of this managed object, i.e. the class name. This property is optional. The ObjectType is implied from the URL path. If specified, the value of objectType must match the class name specified in the URL path. | [readonly] 
**Moid** | **String** | The unique identifier of this Managed Object instance. | [optional] 
**Selector** | **String** | An OData $filter expression which describes the REST resource to be referenced. This field may be set instead of &#39;moid&#39; by clients. 1. If &#39;moid&#39; is set this field is ignored. 1. If &#39;selector&#39; is set and &#39;moid&#39; is empty/absent from the request, Intersight determines the Moid of the resource matching the filter expression and populates it in the MoRef that is part of the object instance being inserted/updated to fulfill the REST request. An error is returned if the filter matches zero or more than one REST resource. An example filter string is: Serial eq &#39;3AA8B7T11&#39;. | [optional] [readonly] 
**Link** | **String** | A URL to an instance of the &#39;mo.MoRef&#39; class. | [optional] 
**AccountMoid** | **String** | The Account ID for this managed object. | [optional] [readonly] 
**CreateTime** | **System.DateTime** | The time when this managed object was created. | [optional] [readonly] 
**DomainGroupMoid** | **String** | The DomainGroup ID for this managed object. | [optional] [readonly] 
**ModTime** | **System.DateTime** | The time when this managed object was last modified. | [optional] [readonly] 
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
Initialize-IntersightVnicEthAdapterPolicyRelationship  -ClassId null `
 -ObjectType null `
 -Moid null `
 -Selector null `
 -Link null `
 -AccountMoid null `
 -CreateTime null `
 -DomainGroupMoid null `
 -ModTime null `
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

