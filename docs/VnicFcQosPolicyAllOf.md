# VnicFcQosPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cos** | **Int64** | Class of Service to be associated to the traffic on the virtual interface. | [optional] 
**MaxDataFieldSize** | **Int64** | The maximum size of the Fibre Channel frame payload bytes that the virtual interface supports. | [optional] 
**RateLimit** | **Int64** | The value in Mbps to use for limiting the data rate on the virtual interface. Setting this to zero will turn rate limiting off. | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightVnicFcQosPolicyAllOf  -Cos null `
 -MaxDataFieldSize null `
 -RateLimit null `
 -Organization null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

