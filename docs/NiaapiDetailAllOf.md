# NiaapiDetailAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "niaapi.Detail"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "niaapi.Detail"]
**Chksum** | **String** | Checksum of this part of Content. | [optional] 
**Filename** | **String** | The file name within this Metadata file. | [optional] 
**Name** | **String** | The name of this Content. | [optional] 

## Examples

- Prepare the resource
```powershell
$NiaapiDetailAllOf = Initialize-IntersightNiaapiDetailAllOf  -ClassId null `
 -ObjectType null `
 -Chksum null `
 -Filename null `
 -Name null
```

- Convert the resource to JSON
```powershell
$NiaapiDetailAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

