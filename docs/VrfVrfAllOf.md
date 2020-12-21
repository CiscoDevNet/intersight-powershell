# VrfVrfAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "vrf.Vrf"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "vrf.Vrf"]
**Description** | **String** | Description to help identify or describe this VRF. | [optional] 
**Name** | **String** | Name of the Virtual Routing and Forwarding Instance. | [optional] 
**Account** | [**IamAccountRelationship**](IamAccountRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$VrfVrfAllOf = Initialize-IntersightVrfVrfAllOf  -ClassId null `
 -ObjectType null `
 -Description null `
 -Name null `
 -Account null
```

- Convert the resource to JSON
```powershell
$VrfVrfAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

