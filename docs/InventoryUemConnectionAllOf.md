# InventoryUemConnectionAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ConnectionStatus** | **String** | Connections status of Uem endpoint. | [optional] [readonly] [default to "Unknown"]
**EpInfo** | [**InventoryEpInfo**](InventoryEpInfo.md) |  | [optional] 
**EpType** | **String** | Type of Uem endpoint (BMC, CMC or VIC). | [optional] [readonly] 
**Ip** | **String** | The IP address of the Uem endpoint. | [optional] [readonly] 
**MemberIdentity** | **String** | The member identity of the UEM connection being inventoried. | [optional] [readonly] 
**Model** | **String** | The model of the Uem endpoint. | [optional] [readonly] 
**Serial** | **String** | The serial number of the Uem endpoint. | [optional] [readonly] 
**TargetMoId** | **String** | The MoId address of the Uem endpoint. | [optional] [readonly] 
**Vendor** | **String** | The vendor of the Uem endpoint. | [optional] [readonly] 
**ComputeBlade** | [**ComputeBladeRelationship**](ComputeBladeRelationship.md) |  | [optional] 
**ComputeRackUnit** | [**ComputeRackUnitRelationship**](ComputeRackUnitRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightInventoryUemConnectionAllOf  -ConnectionStatus null `
 -EpInfo null `
 -EpType null `
 -Ip null `
 -MemberIdentity null `
 -Model null `
 -Serial null `
 -TargetMoId null `
 -Vendor null `
 -ComputeBlade null `
 -ComputeRackUnit null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

