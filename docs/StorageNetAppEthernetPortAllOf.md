# StorageNetAppEthernetPortAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "storage.NetAppEthernetPort"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "storage.NetAppEthernetPort"]
**Enabled** | **String** | Status of Port to determine if its enabled or not. | [optional] [readonly] 
**MacAddress** | **String** | Macaddress  of the port available in storage array. | [optional] [readonly] 
**Mtu** | **String** | Maximum transmission unit of the physical port available in storage array. | [optional] [readonly] 
**Name** | **String** | Name of the port available in storage array. | [optional] [readonly] 
**Speed** | **Int64** | Operational speed of port measured. | [optional] [readonly] 
**State** | **String** | State of the port available in storage array. * &#x60;down&#x60; - An inactive port is listed as Down. * &#x60;up&#x60; - An active port is listed as Up. * &#x60;present&#x60; - An active port is listed as present. | [optional] [readonly] [default to "down"]
**Type** | **String** | Type of the port available in storage array. * &#x60;LAG&#x60; - Storage port of type lag. * &#x60;physical&#x60; - LIFs can be configured directly on physical ports. * &#x60;VLAN&#x60; - A logical port that receives and sends VLAN-tagged (IEEE 802.1Q standard) traffic. VLAN port characteristics include the VLAN ID for the port. | [optional] [readonly] [default to "LAG"]
**Uuid** | **String** | UUID of physical port. | [optional] [readonly] 
**ArrayController** | [**StorageNetAppNodeRelationship**](StorageNetAppNodeRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$StorageNetAppEthernetPortAllOf = Initialize-IntersightStorageNetAppEthernetPortAllOf  -ClassId null `
 -ObjectType null `
 -Enabled null `
 -MacAddress null `
 -Mtu null `
 -Name null `
 -Speed null `
 -State null `
 -Type null `
 -Uuid null `
 -ArrayController null
```

- Convert the resource to JSON
```powershell
$StorageNetAppEthernetPortAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

