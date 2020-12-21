# FabricFcUplinkRoleAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "fabric.FcUplinkRole"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "fabric.FcUplinkRole"]
**AdminSpeed** | **String** | Admin configured speed for the port. * &#x60;Auto&#x60; - Admin configurable speed AUTO ( default ). * &#x60;8Gbps&#x60; - Admin configurable speed 8Gbps. * &#x60;16Gbps&#x60; - Admin configurable speed 16Gbps. * &#x60;32Gbps&#x60; - Admin configurable speed 32Gbps. | [optional] [default to "Auto"]
**FillPattern** | **String** | Fill pattern to differentiate the configs in NPIV. * &#x60;Idle&#x60; - Fc Fill Pattern type Idle. * &#x60;Arbff&#x60; - Fc Fill Pattern type Arbff. | [optional] [default to "Idle"]
**VsanId** | **Int64** | Virtual San Identifier associated to the FC port. | [optional] 

## Examples

- Prepare the resource
```powershell
$FabricFcUplinkRoleAllOf = Initialize-IntersightFabricFcUplinkRoleAllOf  -ClassId null `
 -ObjectType null `
 -AdminSpeed null `
 -FillPattern null `
 -VsanId null
```

- Convert the resource to JSON
```powershell
$FabricFcUplinkRoleAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

