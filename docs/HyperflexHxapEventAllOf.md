# HyperflexHxapEventAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.HxapEvent"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.HxapEvent"]
**FirstTime** | **String** | First timestamp of the event occurrence. | [optional] 
**Identity** | **String** | Internally generated identity (UUID) of this event. | [optional] 
**LastTime** | **String** | Last timestamp of the event occurrence. | [optional] 
**Message** | **String** | Full description of the event. | [optional] 
**OwnerName** | **String** | Name of the owner with which event is associated. | [optional] 
**OwnerType** | **String** | Type of the object with which event is associated (Host, Cluster, VM). * &#x60;Unknown&#x60; - Value is Unknown if the target type is unidentified. * &#x60;Cluster&#x60; - Cluster refers to HyperFlex AP Cluster. * &#x60;Host&#x60; - Host refers to server node which is part of HyperFlex AP Cluster. * &#x60;VM&#x60; - VM refers to Virtual machine available on a HyperFlex AP Node. * &#x60;Disk&#x60; - Disk refers to Virtual Disk available on a HyperFlex AP Cluster. | [optional] [default to "Unknown"]
**OwnerUuid** | **String** | UUID of the owner with which event is associated. | [optional] 
**Severity** | **String** | Severity level of the event (Info/Warning/Critical). * &#x60;None&#x60; - The Enum value None represents that there is no severity. * &#x60;Info&#x60; - The Enum value Info represents the Informational level of severity. * &#x60;Critical&#x60; - The Enum value Critical represents the Critical level of severity. * &#x60;Warning&#x60; - The Enum value Warning represents the Warning level of severity. * &#x60;Cleared&#x60; - The Enum value Cleared represents that the alarm severity has been cleared. | [optional] [default to "None"]
**Cluster** | [**HyperflexHxapClusterRelationship**](HyperflexHxapClusterRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$HyperflexHxapEventAllOf = Initialize-IntersightHyperflexHxapEventAllOf  -ClassId null `
 -ObjectType null `
 -FirstTime null `
 -Identity null `
 -LastTime null `
 -Message null `
 -OwnerName null `
 -OwnerType null `
 -OwnerUuid null `
 -Severity null `
 -Cluster null
```

- Convert the resource to JSON
```powershell
$HyperflexHxapEventAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

