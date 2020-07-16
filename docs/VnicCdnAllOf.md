# VnicCdnAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Source** | **String** | Source of the CDN. It can either be user specified or be the same as the vNIC name. | [optional] [default to "vnic"]
**Value** | **String** | The CDN value entered in case of user defined mode. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightVnicCdnAllOf  -Source null `
 -Value null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

