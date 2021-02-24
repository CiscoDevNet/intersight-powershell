# NiatelemetryNiaInventoryFabricAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "niatelemetry.NiaInventoryFabric"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "niatelemetry.NiaInventoryFabric"]
**AnycastGwMac** | **String** | Returns the aycast gateway mac. | [optional] 
**DcnmtrackerEnabled** | **Boolean** | Returns the value of the dcnmtrackerEnabled field. | [optional] 
**FabricId** | **String** | Uniquely identifies a fabric. | [optional] 
**FabricName** | **String** | Returns the value of the Name of a fabric. | [optional] 
**IsNgoamEnabled** | **String** | Returns if ngoam is enabled. | [optional] 
**IsScheduledBackUpEnabled** | **String** | Returns if the scheduled backup is enabled. | [optional] 
**LeafCount** | **Int64** | Returns total number of leafs in the fabric. | [optional] 
**LogicalLinks** | [**NiatelemetryLogicalLink[]**](NiatelemetryLogicalLink.md) |  | [optional] 
**NxosVrfCount** | **Int64** | Returns the value of the nxosVrfCount field. | [optional] 
**SpineCount** | **Int64** | Returns total number of spines in the fabric. | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$NiatelemetryNiaInventoryFabricAllOf = Initialize-IntersightNiatelemetryNiaInventoryFabricAllOf  -ClassId null `
 -ObjectType null `
 -AnycastGwMac null `
 -DcnmtrackerEnabled null `
 -FabricId null `
 -FabricName null `
 -IsNgoamEnabled null `
 -IsScheduledBackUpEnabled null `
 -LeafCount null `
 -LogicalLinks null `
 -NxosVrfCount null `
 -SpineCount null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$NiatelemetryNiaInventoryFabricAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

