# FcPhysicalPortRelationship
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
**DeviceMoId** | **String** | The database identifier of the registered device of an object. | [optional] [readonly] 
**Dn** | **String** | The Distinguished Name unambiguously identifies an object in the system. | [optional] [readonly] 
**Rn** | **String** | The Relative Name uniquely identifies an object within a given context. | [optional] [readonly] 
**OperState** | **String** | Operational state of this port (enabled/disabled). | [optional] [readonly] 
**OperStateQual** | **String** | Reason for this port&#39;s Operational state. | [optional] [readonly] 
**PortId** | **Int64** | Switch physical port identifier. | [optional] [readonly] 
**Role** | **String** | The role assigned to this port. | [optional] [readonly] 
**SlotId** | **Int64** | Switch expansion slot module identifier. | [optional] [readonly] 
**SwitchId** | **String** | Switch Identifier that is local to a cluster. | [optional] [readonly] 
**AdminSpeed** | **String** | Administrator configured Speed applied on the port. | [optional] [readonly] 
**AdminState** | **String** | Administratively configured state (enabled/disabled) for this port. | [optional] [readonly] 
**B2bCredit** | **Int64** | Buffer to Buffer credits of FC port. | [optional] [readonly] 
**MaxSpeed** | **String** | Maximum Speed with which the port operates. | [optional] [readonly] 
**Mode** | **String** | Mode information N_proxy, F or E associated to the Fibre Channel port. | [optional] [readonly] 
**OperSpeed** | **String** | Operational Speed with which the port operates. | [optional] [readonly] 
**PeerDn** | **String** | PeerDn for fibre channel physical port. | [optional] [readonly] 
**PortChannelId** | **Int64** | Port channel id of FC port channel created on FI switch. | [optional] [readonly] 
**TransceiverType** | **String** | Transceiver type of a Fibre Channel port. | [optional] [readonly] 
**Vsan** | **Int64** | Virtual San that is associated to the port. | [optional] [readonly] 
**Wwn** | **String** | World Wide Name of a Fibre Channel port. | [optional] [readonly] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**PortGroup** | [**PortGroupRelationship**](PortGroupRelationship.md) |  | [optional] 
**PortSubGroup** | [**PortSubGroupRelationship**](PortSubGroupRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightFcPhysicalPortRelationship  -ClassId null `
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
 -DeviceMoId null `
 -Dn null `
 -Rn null `
 -OperState null `
 -OperStateQual null `
 -PortId null `
 -Role null `
 -SlotId null `
 -SwitchId null `
 -AdminSpeed null `
 -AdminState null `
 -B2bCredit null `
 -MaxSpeed null `
 -Mode null `
 -OperSpeed null `
 -PeerDn null `
 -PortChannelId null `
 -TransceiverType null `
 -Vsan null `
 -Wwn null `
 -InventoryDeviceInfo null `
 -PortGroup null `
 -PortSubGroup null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

