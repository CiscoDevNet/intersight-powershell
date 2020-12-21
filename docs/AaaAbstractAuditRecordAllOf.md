# AaaAbstractAuditRecordAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. The enum values provides the list of concrete types that can be instantiated from this abstract type. | [default to "aaa.AuditRecord"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. The enum values provides the list of concrete types that can be instantiated from this abstract type. | [default to "aaa.AuditRecord"]
**VarEvent** | **String** | The operation that was performed on this Managed Object. The event is a compound string that includes the CRUD operation such as Create, Modify, Delete, and a string representing the Managed Object type. | [optional] 
**MoDisplayNames** | [**AnyType**](.md) | The user-friendly names of the changed MO. | [optional] 
**MoType** | **String** | The object type of the REST resource that was created, modified or deleted. | [optional] 
**ObjectMoid** | **String** | The Moid of the REST resource that was created, modified or deleted. | [optional] 
**Request** | [**AnyType**](.md) | The body of the REST request that was received from a client to create or modify a REST resource, represented as a JSON document. | [optional] 
**TraceId** | **String** | The trace id of the request that was used to create, modify or delete a REST resource. A trace id is a unique identifier for one particular REST request. It may be used for troubleshooting purpose by the Intersight technical support team. | [optional] 

## Examples

- Prepare the resource
```powershell
$AaaAbstractAuditRecordAllOf = Initialize-IntersightAaaAbstractAuditRecordAllOf  -ClassId null `
 -ObjectType null `
 -VarEvent null `
 -MoDisplayNames null `
 -MoType null `
 -ObjectMoid null `
 -Request null `
 -TraceId null
```

- Convert the resource to JSON
```powershell
$AaaAbstractAuditRecordAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

