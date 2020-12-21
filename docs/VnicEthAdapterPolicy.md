# VnicEthAdapterPolicy
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "vnic.EthAdapterPolicy"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "vnic.EthAdapterPolicy"]
**AccountMoid** | **String** | The Account ID for this managed object. | [optional] [readonly] 
**CreateTime** | **System.DateTime** | The time when this managed object was created. | [optional] [readonly] 
**DomainGroupMoid** | **String** | The DomainGroup ID for this managed object. | [optional] [readonly] 
**ModTime** | **System.DateTime** | The time when this managed object was last modified. | [optional] [readonly] 
**Moid** | **String** | The unique identifier of this Managed Object instance. | [optional] 
**Owners** | **String[]** |  | [optional] 
**SharedScope** | **String** | Intersight provides pre-built workflows, tasks and policies to end users through global catalogs. Objects that are made available through global catalogs are said to have a &#39;shared&#39; ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs. | [optional] [readonly] 
**Tags** | [**MoTag[]**](MoTag.md) |  | [optional] 
**VersionContext** | [**MoVersionContext**](MoVersionContext.md) |  | [optional] 
**Ancestors** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**Parent** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 
**PermissionResources** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**DisplayNames** | [**System.Collections.Hashtable**](Array.md) | A set of display names for the MO resource. These names are calculated based on other properties of the MO and potentially properties of Ancestor MOs. Displaynames are intended as a way to provide a normalized user appropriate name for an MO, especially for MOs which do not have a &#39;Name&#39; property, which is the case for much of the inventory discovered from managed targets. There are a limited number of keys, currently &#39;short&#39; and &#39;hierarchical&#39;. The value is an array and clients should use the first element of the array. | [optional] [readonly] 
**Description** | **String** | Description of the policy. | [optional] 
**Name** | **String** | Name of the concrete policy. | [optional] 
**AdvancedFilter** | **Boolean** | Enables advanced filtering on the interface. | [optional] [default to $false]
**ArfsSettings** | [**VnicArfsSettings**](VnicArfsSettings.md) |  | [optional] 
**CompletionQueueSettings** | [**VnicCompletionQueueSettings**](VnicCompletionQueueSettings.md) |  | [optional] 
**InterruptScaling** | **Boolean** | Enables Interrupt Scaling on the interface. | [optional] [default to $false]
**InterruptSettings** | [**VnicEthInterruptSettings**](VnicEthInterruptSettings.md) |  | [optional] 
**NvgreSettings** | [**VnicNvgreSettings**](VnicNvgreSettings.md) |  | [optional] 
**RoceSettings** | [**VnicRoceSettings**](VnicRoceSettings.md) |  | [optional] 
**RssHashSettings** | [**VnicRssHashSettings**](VnicRssHashSettings.md) |  | [optional] 
**RssSettings** | **Boolean** | Receive Side Scaling allows the incoming traffic to be spread across multiple CPU cores. | [optional] [default to $true]
**RxQueueSettings** | [**VnicEthRxQueueSettings**](VnicEthRxQueueSettings.md) |  | [optional] 
**TcpOffloadSettings** | [**VnicTcpOffloadSettings**](VnicTcpOffloadSettings.md) |  | [optional] 
**TxQueueSettings** | [**VnicEthTxQueueSettings**](VnicEthTxQueueSettings.md) |  | [optional] 
**UplinkFailbackTimeout** | **Int64** | Uplink Failback Timeout in seconds when uplink failover is enabled for a vNIC. After a vNIC has started using its secondary interface, this setting controls how long the primary interface must be available before the system resumes using the primary interface for the vNIC. | [optional] [default to 5]
**VxlanSettings** | [**VnicVxlanSettings**](VnicVxlanSettings.md) |  | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$VnicEthAdapterPolicy = Initialize-IntersightVnicEthAdapterPolicy  -ClassId null `
 -ObjectType null `
 -AccountMoid null `
 -CreateTime null `
 -DomainGroupMoid null `
 -ModTime null `
 -Moid null `
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
$VnicEthAdapterPolicy | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

