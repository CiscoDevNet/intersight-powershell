# ChassisIomProfileAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "chassis.IomProfile"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "chassis.IomProfile"]
**ConfigChanges** | [**PolicyConfigChange**](PolicyConfigChange.md) |  | [optional] 
**IomEntity** | **String** | IOM in chassis for which IOM profile is applicable. or which is attached to a Fabric Interconnect managed by Intersight. * &#x60;IOMA&#x60; - IOM on left side of chassis. * &#x60;IOMB&#x60; - IOM on right side of chassis. | [optional] [default to "IOMA"]
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 
**VarProfile** | [**ChassisProfileRelationship**](ChassisProfileRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ChassisIomProfileAllOf = Initialize-IntersightChassisIomProfileAllOf  -ClassId null `
 -ObjectType null `
 -ConfigChanges null `
 -IomEntity null `
 -Organization null `
 -VarProfile null
```

- Convert the resource to JSON
```powershell
$ChassisIomProfileAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

