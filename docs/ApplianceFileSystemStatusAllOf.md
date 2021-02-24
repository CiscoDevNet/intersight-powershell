# ApplianceFileSystemStatusAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "appliance.FileSystemStatus"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "appliance.FileSystemStatus"]
**Capacity** | **Int64** | Capacity of the file system in bytes. | [optional] 
**Mountpoint** | **String** | Mount point of this file system. | [optional] [readonly] 
**OperationalStatus** | **String** | Operational status of the file system. Operational status is based on the result of the status checks. If result of any check is Critical, then its value is Impaired. Otherwise, if result of any check is Warning, then its value is AttentionNeeded. If all checks are OK, then its value is Operational. * &#x60;Unknown&#x60; - Operational status of the Intersight Appliance entity is Unknown. * &#x60;Operational&#x60; - Operational status of the Intersight Appliance entity is Operational. * &#x60;Impaired&#x60; - Operational status of the Intersight Appliance entity is Impaired. * &#x60;AttentionNeeded&#x60; - Operational status of the Intersight Appliance entity is AttentionNeeded. | [optional] [readonly] [default to "Unknown"]
**StatusChecks** | [**ApplianceStatusCheck[]**](ApplianceStatusCheck.md) |  | [optional] 
**Usage** | **Double** | Percentage of the file system capacity currently in use. | [optional] [readonly] 
**NodeStatus** | [**ApplianceNodeStatusRelationship**](ApplianceNodeStatusRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ApplianceFileSystemStatusAllOf = Initialize-IntersightApplianceFileSystemStatusAllOf  -ClassId null `
 -ObjectType null `
 -Capacity null `
 -Mountpoint null `
 -OperationalStatus null `
 -StatusChecks null `
 -Usage null `
 -NodeStatus null
```

- Convert the resource to JSON
```powershell
$ApplianceFileSystemStatusAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

