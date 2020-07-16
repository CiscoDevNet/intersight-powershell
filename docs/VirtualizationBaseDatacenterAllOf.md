# VirtualizationBaseDatacenterAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Identity** | **String** | Internally generated identity of this datacenter. This entity is not manipulated by users. It aids in uniquely identifying the datacenter object. For VMware, this is a MOR (managed object reference). | [optional] [readonly] 
**Name** | **String** | User provided name for the datacenter. Usually, this name is subject to manipulations by user. It is not the identity of the datacenter. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightVirtualizationBaseDatacenterAllOf  -Identity null `
 -Name null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

