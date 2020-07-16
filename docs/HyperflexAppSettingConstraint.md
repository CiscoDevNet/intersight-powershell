# HyperflexAppSettingConstraint
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
**HxdpVersion** | **String** | The supported HyperFlex Data Platform version in regex format. | [optional] 
**HypervisorType** | **String** | The hypervisor type for the HyperFlex cluster. | [optional] [default to "ESXi"]
**MgmtPlatform** | **String** | The supported management platform for the HyperFlex Cluster. | [optional] [default to "FI"]
**ServerModel** | **String** | The supported server models in regex format. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightHyperflexAppSettingConstraint  -ClassId null `
 -ObjectType null `
 -HxdpVersion null `
 -HypervisorType null `
 -MgmtPlatform null `
 -ServerModel null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

