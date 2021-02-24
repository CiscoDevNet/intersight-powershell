# VnicScpStatusAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "vnic.ScpStatus"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "vnic.ScpStatus"]
**Reason** | **String** | The reason for the status - it will be empty if status is ok or validating. If error, it will have the appropriate message indicating the reason for failure. | [optional] 
**Status** | **String** | Indicates if the LCP is ready for Deploy or not. * &#x60;ok&#x60; - No issues with the LCP/SCP/VIF. * &#x60;error&#x60; - The LCP/SCP/VIF cannot be deployed due to error. * &#x60;validating&#x60; - Validation in progress for the LCP. | [optional] [default to "ok"]
**VhbaInfo** | [**VnicVifStatus[]**](VnicVifStatus.md) |  | [optional] 
**VarProfile** | [**PolicyAbstractConfigProfileRelationship**](PolicyAbstractConfigProfileRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$VnicScpStatusAllOf = Initialize-IntersightVnicScpStatusAllOf  -ClassId null `
 -ObjectType null `
 -Reason null `
 -Status null `
 -VhbaInfo null `
 -VarProfile null
```

- Convert the resource to JSON
```powershell
$VnicScpStatusAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

