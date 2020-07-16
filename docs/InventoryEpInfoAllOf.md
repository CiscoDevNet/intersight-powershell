# InventoryEpInfoAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ConnectionStatus** | **String** | Connections status of UEM endpoint. | [optional] [readonly] [default to "Unknown"]
**EpType** | **String** | Type of UEM endpoint (BMC, CMC or VIC). | [optional] [readonly] 
**Ip** | **String** | The IP address of the UEM endpoint. | [optional] [readonly] 
**MacAddress** | **String** | The MAC address of the UEM endpoint. | [optional] [readonly] 
**MemberIdentity** | **String** | The member identity of the UEM connection being inventoried. | [optional] [readonly] 
**Model** | **String** | The model of the UEM endpoint. | [optional] [readonly] 
**Serial** | **String** | The serial number of the UEM endpoint. | [optional] [readonly] 
**ServerRegistrationId** | **String** | The device id of the server which this EP is a part of. | [optional] [readonly] 
**Vendor** | **String** | The vendor of the UEM endpoint. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightInventoryEpInfoAllOf  -ConnectionStatus null `
 -EpType null `
 -Ip null `
 -MacAddress null `
 -MemberIdentity null `
 -Model null `
 -Serial null `
 -ServerRegistrationId null `
 -Vendor null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

