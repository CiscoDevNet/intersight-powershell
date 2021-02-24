# NiatelemetryLogicalLinkAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "niatelemetry.LogicalLink"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "niatelemetry.LogicalLink"]
**DbId** | **Int64** | Return value of dbId attribute. | [optional] 
**IsPresent** | **Boolean** | Return value of isPresent attribute. | [optional] 
**LinkAddr1** | **String** | Return value of linkAddr1 attribute. | [optional] 
**LinkAddr2** | **String** | Return value of linkAddr2 attribute. | [optional] 
**LinkState** | **String** | Return value of linkState attribute. | [optional] 
**LinkType** | **String** | Return value of linkType attribute. | [optional] 
**Uptime** | **String** | Return value of uptime attribute. | [optional] 

## Examples

- Prepare the resource
```powershell
$NiatelemetryLogicalLinkAllOf = Initialize-IntersightNiatelemetryLogicalLinkAllOf  -ClassId null `
 -ObjectType null `
 -DbId null `
 -IsPresent null `
 -LinkAddr1 null `
 -LinkAddr2 null `
 -LinkState null `
 -LinkType null `
 -Uptime null
```

- Convert the resource to JSON
```powershell
$NiatelemetryLogicalLinkAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

