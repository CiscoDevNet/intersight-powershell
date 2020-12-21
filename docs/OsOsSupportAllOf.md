# OsOsSupportAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "os.OsSupport"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "os.OsSupport"]
**OsVersion** | **String** | The version of the Operating System to be validated. The version should be as per HCL. | [optional] 

## Examples

- Prepare the resource
```powershell
$OsOsSupportAllOf = Initialize-IntersightOsOsSupportAllOf  -ClassId null `
 -ObjectType null `
 -OsVersion null
```

- Convert the resource to JSON
```powershell
$OsOsSupportAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

