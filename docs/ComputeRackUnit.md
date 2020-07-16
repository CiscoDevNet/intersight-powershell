# ComputeRackUnit
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
**DeviceMoId** | **String** | The database identifier of the registered device of an object. | [optional] [readonly] 
**Dn** | **String** | The Distinguished Name unambiguously identifies an object in the system. | [optional] [readonly] 
**Rn** | **String** | The Relative Name uniquely identifies an object within a given context. | [optional] [readonly] 
**Model** | **String** | This field identifies the model of the given component. | [optional] [readonly] 
**Revision** | **String** | This field identifies the revision of the given component. | [optional] [readonly] 
**Serial** | **String** | This field identifies the serial of the given component. | [optional] [readonly] 
**Vendor** | **String** | This field identifies the vendor of the given component. | [optional] [readonly] 
**AdminPowerState** | **String** | The desired power state of the server. | [optional] [readonly] 
**AssetTag** | **String** | The user defined asset tag assigned to the server. | [optional] [readonly] 
**AvailableMemory** | **Int64** | The amount of memory available on the server. | [optional] [readonly] 
**BiosPostComplete** | **Boolean** | The BIOS POST completion status of the server. | [optional] 
**FaultSummary** | **Int64** | The fault summary for the server. | [optional] 
**KvmIpAddresses** | [**ComputeIpAddress[]**](ComputeIpAddress.md) |  | [optional] 
**ManagementMode** | **String** | The management mode of the server. | [optional] [default to "IntersightStandalone"]
**MemorySpeed** | **String** | The maximum memory speed in MHz available on the server. | [optional] [readonly] 
**MgmtIpAddress** | **String** | Management address of the server. | [optional] 
**NumAdaptors** | **Int64** | The total number of network adapters present on the server. | [optional] [readonly] 
**NumCpuCores** | **Int64** | The total number of CPU cores present on the server. | [optional] [readonly] 
**NumCpuCoresEnabled** | **Int64** | The total number of CPU cores enabled on the server. | [optional] [readonly] 
**NumCpus** | **Int64** | The total number of CPUs present on the server. | [optional] [readonly] 
**NumEthHostInterfaces** | **Int64** | The total number of vNICs which are visible to a host on the server. | [optional] [readonly] 
**NumFcHostInterfaces** | **Int64** | The total number of vHBAs which are visible to a host on the server. | [optional] [readonly] 
**NumThreads** | **Int64** | The total number of threads the server is capable of handling. | [optional] [readonly] 
**OperPowerState** | **String** | The actual power state of the server. | [optional] [readonly] 
**OperState** | **String** | The operational state of the server. | [optional] [readonly] 
**Operability** | **String** | The operability of the server. | [optional] [readonly] 
**PlatformType** | **String** | The platform type of the registered device - whether managed by UCSM or operating in standalone mode. | [optional] 
**Presence** | **String** | Indicates if a server is present in a slot and is applicable for blade servers. | [optional] [readonly] 
**ServiceProfile** | **String** | The distinguished name of the service profile to which the server is associated to. It is applicable only for servers which are managed via UCSM. | [optional] [readonly] 
**TotalMemory** | **Int64** | The total memory available on the server. | [optional] [readonly] 
**UserLabel** | **String** | The user defined label assigned to the server. | [optional] [readonly] 
**Uuid** | **String** | The universally unique identity of the server. | [optional] [readonly] 
**MgmtIdentity** | [**EquipmentPhysicalIdentityRelationship**](EquipmentPhysicalIdentityRelationship.md) |  | [optional] 
**ConnectionStatus** | **String** | Connectivity Status of RackUnit to Switch - A or B or AB. | [optional] [readonly] 
**ServerId** | **Int64** | RackUnit ID that uniquely identifies the server. | [optional] [readonly] 
**TopologyScanStatus** | **String** | To maintain the Topology workflow run status. | [optional] 
**Adapters** | [**AdapterUnitRelationship[]**](AdapterUnitRelationship.md) | An array of relationships to adapterUnit resources. | [optional] [readonly] 
**BiosBootmode** | [**BiosBootModeRelationship**](BiosBootModeRelationship.md) |  | [optional] 
**Biosunits** | [**BiosUnitRelationship[]**](BiosUnitRelationship.md) | An array of relationships to biosUnit resources. | [optional] [readonly] 
**Bmc** | [**ManagementControllerRelationship**](ManagementControllerRelationship.md) |  | [optional] 
**Board** | [**ComputeBoardRelationship**](ComputeBoardRelationship.md) |  | [optional] 
**BootDeviceBootmode** | [**BootDeviceBootModeRelationship**](BootDeviceBootModeRelationship.md) |  | [optional] 
**Fanmodules** | [**EquipmentFanModuleRelationship[]**](EquipmentFanModuleRelationship.md) | An array of relationships to equipmentFanModule resources. | [optional] [readonly] 
**GenericInventoryHolders** | [**InventoryGenericInventoryHolderRelationship[]**](InventoryGenericInventoryHolderRelationship.md) | An array of relationships to inventoryGenericInventoryHolder resources. | [optional] [readonly] 
**GraphicsCards** | [**GraphicsCardRelationship[]**](GraphicsCardRelationship.md) | An array of relationships to graphicsCard resources. | [optional] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**LocatorLed** | [**EquipmentLocatorLedRelationship**](EquipmentLocatorLedRelationship.md) |  | [optional] 
**MemoryArrays** | [**MemoryArrayRelationship[]**](MemoryArrayRelationship.md) | An array of relationships to memoryArray resources. | [optional] 
**PciDevices** | [**PciDeviceRelationship[]**](PciDeviceRelationship.md) | An array of relationships to pciDevice resources. | [optional] [readonly] 
**Processors** | [**ProcessorUnitRelationship[]**](ProcessorUnitRelationship.md) | An array of relationships to processorUnit resources. | [optional] 
**Psus** | [**EquipmentPsuRelationship[]**](EquipmentPsuRelationship.md) | An array of relationships to equipmentPsu resources. | [optional] [readonly] 
**RackEnclosureSlot** | [**EquipmentRackEnclosureSlotRelationship**](EquipmentRackEnclosureSlotRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**SasExpanders** | [**StorageSasExpanderRelationship[]**](StorageSasExpanderRelationship.md) | An array of relationships to storageSasExpander resources. | [optional] 
**StorageControllers** | [**StorageControllerRelationship[]**](StorageControllerRelationship.md) | An array of relationships to storageController resources. | [optional] 
**StorageEnclosures** | [**StorageEnclosureRelationship[]**](StorageEnclosureRelationship.md) | An array of relationships to storageEnclosure resources. | [optional] [readonly] 
**TopSystem** | [**TopSystemRelationship**](TopSystemRelationship.md) |  | [optional] 
**UemConnection** | [**InventoryUemConnectionRelationship**](InventoryUemConnectionRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightComputeRackUnit  -AccountMoid null `
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
 -DeviceMoId null `
 -Dn null `
 -Rn null `
 -Model null `
 -Revision null `
 -Serial null `
 -Vendor null `
 -AdminPowerState null `
 -AssetTag null `
 -AvailableMemory null `
 -BiosPostComplete null `
 -FaultSummary null `
 -KvmIpAddresses null `
 -ManagementMode null `
 -MemorySpeed null `
 -MgmtIpAddress null `
 -NumAdaptors null `
 -NumCpuCores null `
 -NumCpuCoresEnabled null `
 -NumCpus null `
 -NumEthHostInterfaces null `
 -NumFcHostInterfaces null `
 -NumThreads null `
 -OperPowerState null `
 -OperState null `
 -Operability null `
 -PlatformType null `
 -Presence null `
 -ServiceProfile null `
 -TotalMemory null `
 -UserLabel null `
 -Uuid null `
 -MgmtIdentity null `
 -ConnectionStatus null `
 -ServerId null `
 -TopologyScanStatus null `
 -Adapters null `
 -BiosBootmode null `
 -Biosunits null `
 -Bmc null `
 -Board null `
 -BootDeviceBootmode null `
 -Fanmodules null `
 -GenericInventoryHolders null `
 -GraphicsCards null `
 -InventoryDeviceInfo null `
 -LocatorLed null `
 -MemoryArrays null `
 -PciDevices null `
 -Processors null `
 -Psus null `
 -RackEnclosureSlot null `
 -RegisteredDevice null `
 -SasExpanders null `
 -StorageControllers null `
 -StorageEnclosures null `
 -TopSystem null `
 -UemConnection null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

