# VirtualizationGuestInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
**Hostname** | **String** | Name provided to the host OS (example, ubuntu6410, test-gateway, etc.). | [optional] 
**IpAddress** | **String** | Primary IP address of the guest os. | [optional] 
**Name** | **String** | The name of the guest running on this VM. This may not be the same as the hostname. | [optional] 
**OperatingSystem** | **String** | The name of the guest OS running on this VM (Cent OS 4/5/6/7). | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightVirtualizationGuestInfo  -ClassId null `
 -ObjectType null `
 -Hostname null `
 -IpAddress null `
 -Name null `
 -OperatingSystem null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

