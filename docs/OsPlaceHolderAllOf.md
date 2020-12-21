# OsPlaceHolderAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "os.PlaceHolder"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "os.PlaceHolder"]
**IsValueSet** | **Boolean** | Flag to indicate if value is set. Value will be used to check if any edit. | [optional] [default to $true]
**Type** | [**WorkflowPrimitiveDataType**](WorkflowPrimitiveDataType.md) |  | [optional] 
**Value** | [**AnyType**](.md) | Value for placeholder provided by user. | [optional] 

## Examples

- Prepare the resource
```powershell
$OsPlaceHolderAllOf = Initialize-IntersightOsPlaceHolderAllOf  -ClassId null `
 -ObjectType null `
 -IsValueSet null `
 -Type null `
 -Value null
```

- Convert the resource to JSON
```powershell
$OsPlaceHolderAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

