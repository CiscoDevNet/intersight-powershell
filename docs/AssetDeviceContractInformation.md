# AssetDeviceContractInformation
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
**Contract** | [**AssetContractInformation**](AssetContractInformation.md) |  | [optional] 
**ContractStatus** | **String** | Calculated contract status that is derived based on the service line status and contract end date. It is different from serviceLineStatus property. serviceLineStatus gives us ACTIVE, OVERDUE, EXPIRED. These are transformed into Active, Expiring Soon and Not Covered. | [optional] [readonly] [default to "Not Covered"]
**CoveredProductLineEndDate** | **String** | End date of the covered product line. The coverage end date is fetched from Cisco SN2INFO API. | [optional] [readonly] 
**DeviceId** | **String** | Unique identifier of the Cisco device. This information is used to query Cisco APIx SN2INFO and CCWR databases. | [optional] [readonly] 
**DeviceType** | **String** | Type used to classify the device in Cisco Intersight. Currently supported values are Server and FabricInterconnect. This will be expanded to support more types in future. | [optional] [readonly] [default to "None"]
**EndCustomer** | [**AssetCustomerInformation**](AssetCustomerInformation.md) |  | [optional] 
**EndUserGlobalUltimate** | [**AssetGlobalUltimate**](AssetGlobalUltimate.md) |  | [optional] 
**IsValid** | **Boolean** | Validates if the device is a genuine Cisco device. Validated is done using the Cisco SN2INFO APIs. | [optional] [readonly] 
**ItemType** | **String** | Item type of this specific Cisco device. example &quot;&quot;Chassis&quot;&quot;. | [optional] [readonly] 
**MaintenancePurchaseOrderNumber** | **String** | Maintenance purchase order number for the Cisco device. | [optional] [readonly] 
**MaintenanceSalesOrderNumber** | **String** | Maintenance sales order number for the Cisco device. | [optional] [readonly] 
**PlatformType** | **String** | The platform type of the Cisco device. | [optional] [readonly] [default to ""]
**Product** | [**AssetProductInformation**](AssetProductInformation.md) |  | [optional] 
**PurchaseOrderNumber** | **String** | Purchase order number for the Cisco device. It is a unique number assigned for every purchase. | [optional] [readonly] 
**ResellerGlobalUltimate** | [**AssetGlobalUltimate**](AssetGlobalUltimate.md) |  | [optional] 
**SalesOrderNumber** | **String** | Sales order number for the Cisco device. It is a unique number assigned for every sale. | [optional] [readonly] 
**ServiceDescription** | **String** | The type of service contract that covers the Cisco device. | [optional] [readonly] 
**ServiceEndDate** | **System.DateTime** | End date for the Cisco service contract that covers this Cisco device. | [optional] [readonly] 
**ServiceLevel** | **String** | The type of service contract that covers the Cisco device. | [optional] [readonly] 
**ServiceSku** | **String** | The SKU of the service contract that covers the Cisco device. | [optional] [readonly] 
**ServiceStartDate** | **System.DateTime** | Start date for the Cisco service contract that covers this Cisco device. | [optional] [readonly] 
**StateContract** | **String** | Internal property used for triggering and tracking actions for contract information. | [optional] [default to "Update"]
**WarrantyEndDate** | **String** | End date for the warranty that covers the Cisco device. | [optional] [readonly] 
**WarrantyType** | **String** | Type of warranty that covers the Cisco device. | [optional] [readonly] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightAssetDeviceContractInformation  -AccountMoid null `
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
 -Contract null `
 -ContractStatus null `
 -CoveredProductLineEndDate null `
 -DeviceId null `
 -DeviceType null `
 -EndCustomer null `
 -EndUserGlobalUltimate null `
 -IsValid null `
 -ItemType null `
 -MaintenancePurchaseOrderNumber null `
 -MaintenanceSalesOrderNumber null `
 -PlatformType null `
 -Product null `
 -PurchaseOrderNumber null `
 -ResellerGlobalUltimate null `
 -SalesOrderNumber null `
 -ServiceDescription null `
 -ServiceEndDate null `
 -ServiceLevel null `
 -ServiceSku null `
 -ServiceStartDate null `
 -StateContract null `
 -WarrantyEndDate null `
 -WarrantyType null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

