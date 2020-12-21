# HclHardwareCompatibilityProfile
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hcl.HardwareCompatibilityProfile"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hcl.HardwareCompatibilityProfile"]
**DriverIsoUrl** | **String** | Url for the ISO with the drivers supported for the server. | [optional] 
**ErrorCode** | **String** | Error code indicating the compatibility status. * &#x60;Success&#x60; - The input combination is valid. * &#x60;Unknown&#x60; - Unknown API request to the service. * &#x60;UnknownServer&#x60; - An invalid server model is given API requests or the server model is not present in the HCL database. * &#x60;InvalidUcsVersion&#x60; - UCS Version is not in expected format. * &#x60;ProcessorNotSupported&#x60; - Processor is not supported with the given Server or the Processor does not exist in the HCL database. * &#x60;OSNotSupported&#x60; - OS version is not supported with the given server, processor combination or OS information is not present in the HCL database. * &#x60;OSUnknown&#x60; - OS vendor or version is not known as per the HCL database. * &#x60;UCSVersionNotSupported&#x60; - UCS Version is not supported with the given server, processor and OS combination or the UCS version is not present in the HCL database. * &#x60;UcsVersionServerOSCombinationNotSupported&#x60; - Combination of UCS version, server (model and processor) and os version is not supported. * &#x60;ProductUnknown&#x60; - Product is not known as per the HCL database. * &#x60;ProductNotSupported&#x60; - Product is not supported in the given UCS version, server (model and processor) and operating system version. * &#x60;DriverNameNotSupported&#x60; - Driver protocol or name is not supported for the given product. * &#x60;FirmwareVersionNotSupported&#x60; - Firmware version not supported for the component and the server, operating system combination. * &#x60;DriverVersionNotSupported&#x60; - Driver version not supported for the component and the server, operating system combination. * &#x60;FirmwareVersionDriverVersionCombinationNotSupported&#x60; - Both Firmware and Driver versions are not supported for the component and the server, operating system combination. * &#x60;FirmwareVersionAndDriverVersionNotSupported&#x60; - Firmware and Driver version combination not supported for the component and the server, operating system combination. * &#x60;FirmwareVersionAndDriverNameNotSupported&#x60; - Firmware Version and Driver name or not supported with the component and the server, operating system combination. * &#x60;InternalError&#x60; - API requests to the service have either failed or timed out. * &#x60;MarshallingError&#x60; - Error in JSON marshalling. * &#x60;Exempted&#x60; - An exempted error code means that the product is part of the exempted Catalog and should be ignored for HCL validation purposes. | [optional] [readonly] [default to "Success"]
**Id** | **String** | Identifier of the hardware compatibility profile. | [optional] 
**OsVendor** | **String** | Vendor of the Operating System running on the server. | [optional] 
**OsVersion** | **String** | Version of the Operating System running on the server. | [optional] 
**ProcessorModel** | **String** | Model of the processor present in the server. | [optional] 
**Products** | [**HclProduct[]**](HclProduct.md) |  | [optional] 
**ServerModel** | **String** | Model of the server as returned by UCSM/CIMC XML API. | [optional] 
**ServerRevision** | **String** | Revision of the server model. | [optional] 
**UcsVersion** | **String** | Version of the UCS software. | [optional] 
**VersionType** | **String** | Type of the UCS version indicating whether it is a UCSM release vesion or a IMC release. * &#x60;UCSM&#x60; - The server is managed by UCS Manager. * &#x60;IMC&#x60; - The server is standalone managed by CIMC. | [optional] [default to "UCSM"]

## Examples

- Prepare the resource
```powershell
$HclHardwareCompatibilityProfile = Initialize-IntersightHclHardwareCompatibilityProfile  -ClassId null `
 -ObjectType null `
 -DriverIsoUrl null `
 -ErrorCode null `
 -Id null `
 -OsVendor null `
 -OsVersion null `
 -ProcessorModel null `
 -Products null `
 -ServerModel null `
 -ServerRevision null `
 -UcsVersion null `
 -VersionType null
```

- Convert the resource to JSON
```powershell
$HclHardwareCompatibilityProfile | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

