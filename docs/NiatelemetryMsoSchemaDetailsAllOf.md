# NiatelemetryMsoSchemaDetailsAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "niatelemetry.MsoSchemaDetails"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "niatelemetry.MsoSchemaDetails"]
**NumberOfPolicyObjectsPerSchema** | **Int64** | Number of policy objects per schema. | [optional] 
**NumberOfTemplatesPerSchema** | **Int64** | Number of tenants assigned per schema in Multi-Site Orchestrator. | [optional] 
**SchemaId** | **String** | Schema ID in Multi-Site Orchestrator. | [optional] 
**SchemaName** | **String** | Schema name in Multi-Site Orchestrator. | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$NiatelemetryMsoSchemaDetailsAllOf = Initialize-IntersightNiatelemetryMsoSchemaDetailsAllOf  -ClassId null `
 -ObjectType null `
 -NumberOfPolicyObjectsPerSchema null `
 -NumberOfTemplatesPerSchema null `
 -SchemaId null `
 -SchemaName null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$NiatelemetryMsoSchemaDetailsAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

