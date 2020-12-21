# HclDriverImageAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hcl.DriverImage"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hcl.DriverImage"]
**DriverIsoUrl** | **String** | URL of the driver ISO images. | [optional] 
**ManagementType** | **String** | Type of the UCS version indicating whether it is a UCSM release vesion or a IMC release. * &#x60;UCSM&#x60; - The server is managed by UCS Manager. * &#x60;IMC&#x60; - The server is standalone managed by CIMC. | [optional] [default to "UCSM"]
**ServerPid** | **String** | Three part ID representing the server model as returned by UCSM/CIMC XML APIs. | [optional] 

## Examples

- Prepare the resource
```powershell
$HclDriverImageAllOf = Initialize-IntersightHclDriverImageAllOf  -ClassId null `
 -ObjectType null `
 -DriverIsoUrl null `
 -ManagementType null `
 -ServerPid null
```

- Convert the resource to JSON
```powershell
$HclDriverImageAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

