# PkixDistinguishedNameAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "pkix.DistinguishedName"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "pkix.DistinguishedName"]
**CommonName** | **String** | A required component that identifies a person or an object. | [optional] [readonly] 
**Country** | **String[]** |  | [optional] 
**Locality** | **String[]** |  | [optional] 
**Organization** | **String[]** |  | [optional] 
**OrganizationalUnit** | **String[]** |  | [optional] 
**State** | **String[]** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$PkixDistinguishedNameAllOf = Initialize-IntersightPkixDistinguishedNameAllOf  -ClassId null `
 -ObjectType null `
 -CommonName null `
 -Country null `
 -Locality null `
 -Organization null `
 -OrganizationalUnit null `
 -State null
```

- Convert the resource to JSON
```powershell
$PkixDistinguishedNameAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

