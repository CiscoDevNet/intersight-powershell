# CondHclStatus
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
**ComponentStatus** | **String** | The overall status for the components found in the HCL. This will provide the HCL validation status for all the components. It can be one of the following. &quot;&quot;Validated&quot;&quot; - all the components hardware/software profiles are listed in the HCL. &quot;&quot;Not-Listed&quot;&quot; - one or more components hardware/software profiles are not listed in the HCL &quot;&quot;Incomplete&quot;&quot; - the components are not evaluated as the server&#39;s software/hardware profiles are not listed in the HCL. &quot;&quot;Not-Evaluated&quot;&quot; - The components are not evaluated against the HCL because it is exempted. | [optional] [default to "Incomplete"]
**HardwareStatus** | **String** | The server model, processor and firmware are considered as part of the hardware profile for the server. This will provide the HCL validation status for the hardware profile. For the failure reason see the serverReason property. The status can be one of the following &quot;&quot;Validated&quot;&quot; - The server model, processor and firmware combination is listed in the HCL &quot;&quot;Not-Listed&quot;&quot; - The server model, processor and firmware combination is not listed in the HCL. &quot;&quot;Not-Evaluated&quot;&quot; - The server is not evaluated against the HCL because it is exempted. | [optional] [default to "Incomplete"]
**HclFirmwareVersion** | **String** | The current CIMC version for the server normalized for querying HCL data. It is empty if we are missing this information. | [optional] 
**HclModel** | **String** | The managed object&#39;s model to validate normalized for querying HCL data. It is empty if we are missing this information. | [optional] 
**HclOsVendor** | **String** | The OS Vendor for the managed object to validate normalized for querying HCL data. It is empty if we are missing this information. | [optional] 
**HclOsVersion** | **String** | The OS Version for the managed object to validate normalized for querying HCL data. It is empty if we are missing this information. | [optional] 
**HclProcessor** | **String** | The managed object&#39;s processor to validate if applicable normalized for querying HCL data. It is empty if we are missing this information. | [optional] 
**InvFirmwareVersion** | **String** | The current CIMC version for the server as received from inventory. It is empty if we are missing this information. | [optional] 
**InvModel** | **String** | The managed object&#39;s model to validate as received from the inventory. It is empty if we are missing this information. | [optional] 
**InvOsVendor** | **String** | The OS Vendor for the managed object to validate as received from inventory. It is empty if we are missing this information. | [optional] 
**InvOsVersion** | **String** | The OS Version for the managed object to validate as received from inventory. It is empty if we are missing this information. | [optional] 
**InvProcessor** | **String** | The managed object&#39;s processor to validate if applicable as received from inventory. It is empty if we are missing this information. | [optional] 
**Reason** | **String** | The reason for the HCL status. It will be one of the following &quot;&quot;Missing-Os-Info&quot;&quot; - we are missing os information in the inventory from the device connector &quot;&quot;Incompatible-Components&quot;&quot; - we have 1 or more components with &quot;&quot;Not-Validated&quot;&quot; status &quot;&quot;Compatible&quot;&quot; - all the components have &quot;&quot;Validated&quot;&quot; status. &quot;&quot;Not-Evaluated&quot;&quot; - The server is not evaluated against the HCL because it is exempted. | [optional] [default to "Missing-Os-Info"]
**ServerReason** | **String** | The reason generated by the server&#39;s HCL validation. For HCL the evaluation can be seen in three logical stages 1. Evaluate the server&#39;s hardware status 2. Evaluate the server&#39;s software status 3. Evaluate the server&#39;s components (each component has its own hardware/software evaluation) The evaluation does not proceed to the next stage until the previous stage is evaluated. Therefore there can be only one validation reason. &quot;&quot;Incompatible-Server&quot;&quot; - the server model is not listed in the HCL. &quot;&quot;Incompatible-Processor&quot;&quot; - the server model and processor combination is not listed in HCL. &quot;&quot;Incompatible-Firmware&quot;&quot; - the server model, processor and server firmware is not listed in HCL. &quot;&quot;Missing-Os-Info&quot;&quot; - the os vendor and version is not listed in HCL with the HW profile. &quot;&quot;Incompatible-Os-Info&quot;&quot; - the os vendor and version is not listed in HCL with the HW profile. &quot;&quot;Incompatible-Components&quot;&quot; - there is one or more components with &quot;&quot;Not-Validated&quot;&quot; status &quot;&quot;Service-Unavailable&quot;&quot; - HCL data service is unavailable at the moment (try again later). &quot;&quot;Compatible&quot;&quot; - the server and all its components are validated. &quot;&quot;Not-Evaluated&quot;&quot; - The server is not evaluated against the HCL because it is exempted. | [optional] [default to "Missing-Os-Driver-Info"]
**SoftwareStatus** | **String** | The OS vendor and version are considered part of the software profile for the server. This will provide the HCL validation status for the software profile. For the failure reason see the serverReason property. The status can be be one of the following &quot;&quot;Validated&quot;&quot; - The os vendor/version is listed in the HCL for the server model, processor and firmware &quot;&quot;Not-Listed&quot;&quot; - The os vendor/version is not listed in the HCL for the server model, processor and firmware &quot;&quot;Incomplete&quot;&quot; - The inventory is missing os vendor/version and HCL validation was not performed. &quot;&quot;Not-Evaluated&quot;&quot; - The server is not evaluated against the HCL because it is exempted. | [optional] [default to "Incomplete"]
**Status** | **String** | The HCL compatibility status of the managed object. The status can be one of the following &quot;&quot;Incomplete&quot;&quot; - there is no enough information to evaluate against the HCL data &quot;&quot;Validated&quot;&quot; - all components have been evaluated against the HCL and they all have &quot;&quot;Validated&quot;&quot; status &quot;&quot;Not-Listed&quot;&quot; - all components have been evaluated against the HCL and one or more have &quot;&quot;Not-Listed&quot;&quot; status. &quot;&quot;Not-Evaluated&quot;&quot; - server is not evaluated against the HCL because it is exempted. | [optional] [default to "Incomplete"]
**Details** | [**CondHclStatusDetailRelationship[]**](CondHclStatusDetailRelationship.md) | An array of relationships to condHclStatusDetail resources. | [optional] [readonly] 
**ManagedObject** | [**InventoryBaseRelationship**](InventoryBaseRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightCondHclStatus  -AccountMoid null `
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
 -ComponentStatus null `
 -HardwareStatus null `
 -HclFirmwareVersion null `
 -HclModel null `
 -HclOsVendor null `
 -HclOsVersion null `
 -HclProcessor null `
 -InvFirmwareVersion null `
 -InvModel null `
 -InvOsVendor null `
 -InvOsVersion null `
 -InvProcessor null `
 -Reason null `
 -ServerReason null `
 -SoftwareStatus null `
 -Status null `
 -Details null `
 -ManagedObject null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

