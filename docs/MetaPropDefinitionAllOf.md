# MetaPropDefinitionAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "meta.PropDefinition"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "meta.PropDefinition"]
**ApiAccess** | **String** | API access control for the property. Examples are NoAccess, ReadOnly, CreateOnly etc. * &#x60;NoAccess&#x60; - The property is not accessible from the API. * &#x60;ReadOnly&#x60; - The value of the property is read-only.An HTTP 4xx status code is returned when the user sends a POST/PUT/PATCH request that containsa ReadOnly property. * &#x60;CreateOnly&#x60; - The value of the property can be set when the REST resource is created. It cannot be changed after object creation.An HTTP 4xx status code is returned when the user sends a POST/PUT/PATCH request that containsa CreateOnly property.CreateOnly properties are returned in the response body of HTTP GET requests. * &#x60;ReadWrite&#x60; - The property has read/write access. * &#x60;WriteOnly&#x60; - The value of the property can be set but it is never returned in the response body of supported HTTP methods.This settings is used for sensitive properties such as passwords. * &#x60;ReadOnCreate&#x60; - The value of the property is returned in the HTTP POST response body when the REST resource is created.The property is not writeable and cannot be queried through a GET request after the resource has been created. | [optional] [readonly] [default to "NoAccess"]
**Name** | **String** | The name of the property. | [optional] [readonly] 
**OpSecurity** | **String** | The data-at-rest security protection applied to this property when a Managed Object is persisted. For example, Encrypted or Cleartext. * &#x60;ClearText&#x60; - Data at rest is not encrypted using account specific keys.Note that data is always protected using volume encryption. ClearText propertiesare queryable and searchable. * &#x60;Encrypted&#x60; - The value of the property is encrypted with account-specific cryptographic keys.This setting is used for properties that contain sensitive data. Encrypted propertiesare not queryable and searchable. * &#x60;Pbkdf2&#x60; - The value of the property is hashed using the pbkdf2 key derivation functions thattakes a password, a salt, and a cost factor as inputs then generates a password hash.Its purpose is to make each password guessing trial by an attacker who has obtaineda password hash file expensive and therefore the cost of a guessing attack high or prohibitive. * &#x60;Bcrypt&#x60; - The value of the property is hashed using the bcrypt key derivation function. * &#x60;Sha512crypt&#x60; - The value of the property is hashed using the sha512crypt key derivation function. * &#x60;Argon2id&#x60; - The value of the property is hashed using the argon2id key derivation function. | [optional] [readonly] [default to "ClearText"]
**SearchWeight** | **Double** | Enables the property to be searchable from global search. A value of 0 means this property is not globally searchable. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$MetaPropDefinitionAllOf = Initialize-IntersightMetaPropDefinitionAllOf  -ClassId null `
 -ObjectType null `
 -ApiAccess null `
 -Name null `
 -OpSecurity null `
 -SearchWeight null
```

- Convert the resource to JSON
```powershell
$MetaPropDefinitionAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

