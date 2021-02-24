# KubernetesAciCniApicAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "kubernetes.AciCniApic"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "kubernetes.AciCniApic"]
**AssetApicMoid** | **String** | The Moid of the apic device under the asset service. | [optional] 
**NumAciCniProfiles** | **Int64** | The number of ACI CNI profiles configured for this APIC. | [optional] 
**AciCniProfiles** | [**KubernetesAciCniProfileRelationship[]**](KubernetesAciCniProfileRelationship.md) | An array of relationships to kubernetesAciCniProfile resources. | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$KubernetesAciCniApicAllOf = Initialize-IntersightKubernetesAciCniApicAllOf  -ClassId null `
 -ObjectType null `
 -AssetApicMoid null `
 -NumAciCniProfiles null `
 -AciCniProfiles null `
 -Organization null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$KubernetesAciCniApicAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

