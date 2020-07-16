# InventoryEpInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
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
Initialize-IntersightInventoryEpInfo  -ClassId null `
 -ObjectType null `
 -ConnectionStatus null `
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

