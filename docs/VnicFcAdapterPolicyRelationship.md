# VnicFcAdapterPolicyRelationship
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
**ErrorDetectionTimeout** | **Int64** | Error Detection Timeout, also referred to as EDTOV, is the number of milliseconds to wait before the system assumes that an error has occurred. | [optional] 
**ErrorRecoverySettings** | [**VnicFcErrorRecoverySettings**](VnicFcErrorRecoverySettings.md) |  | [optional] 
**FlogiSettings** | [**VnicFlogiSettings**](VnicFlogiSettings.md) |  | [optional] 
**InterruptSettings** | [**VnicFcInterruptSettings**](VnicFcInterruptSettings.md) |  | [optional] 
**IoThrottleCount** | **Int64** | The maximum number of data or control I/O operations that can be pending for the virtual interface at one time. If this value is exceeded, the additional I/O operations wait in the queue until the number of pending I/O operations decreases and the additional operations can be processed. | [optional] 
**LunCount** | **Int64** | The maximum number of LUNs that the Fibre Channel driver will export or show. The maximum number of LUNs is usually controlled by the operating system running on the server. | [optional] 
**LunQueueDepth** | **Int64** | The number of commands that the HBA can send and receive in a single transmission per LUN. | [optional] 
**PlogiSettings** | [**VnicPlogiSettings**](VnicPlogiSettings.md) |  | [optional] 
**ResourceAllocationTimeout** | **Int64** | Resource Allocation Timeout, also referred to as RATOV, is the number of milliseconds to wait before the system assumes that a resource cannot be properly allocated. | [optional] 
**RxQueueSettings** | [**VnicFcQueueSettings**](VnicFcQueueSettings.md) |  | [optional] 
**ScsiQueueSettings** | [**VnicScsiQueueSettings**](VnicScsiQueueSettings.md) |  | [optional] 
**TxQueueSettings** | [**VnicFcQueueSettings**](VnicFcQueueSettings.md) |  | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightVnicFcAdapterPolicyRelationship  -ClassId null `
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
 -ErrorDetectionTimeout null `
 -ErrorRecoverySettings null `
 -FlogiSettings null `
 -InterruptSettings null `
 -IoThrottleCount null `
 -LunCount null `
 -LunQueueDepth null `
 -PlogiSettings null `
 -ResourceAllocationTimeout null `
 -RxQueueSettings null `
 -ScsiQueueSettings null `
 -TxQueueSettings null `
 -Organization null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

