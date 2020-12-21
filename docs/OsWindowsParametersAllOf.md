# OsWindowsParametersAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "os.WindowsParameters"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "os.WindowsParameters"]
**Edition** | **String** | Lists all the editions supported for Windows Server installation. * &#x60;Standard&#x60; - Windows Standard Edition ideal for advanced features with limited virtualization. * &#x60;StandardCore&#x60; - Windows Standard Core Edition is a minimal installation option while installing Standard Core that is ideal for advanced features with limited virtualization. * &#x60;Datacenter&#x60; - Windows Standard Core Edition ideal for high requirements on IT workloads with largenumber fo virtual systems. * &#x60;DatacenterCore&#x60; - Windows Datacenter Core Edition is a minimal installation option while installing Datacenter Core that isideal for high requirements on IT workloads with largenumber for virtual systems. * &#x60;Core&#x60; - Microsoft Hyper-V is a native hypervisor to create and run virtual machines. | [optional] [default to "Standard"]

## Examples

- Prepare the resource
```powershell
$OsWindowsParametersAllOf = Initialize-IntersightOsWindowsParametersAllOf  -ClassId null `
 -ObjectType null `
 -Edition null
```

- Convert the resource to JSON
```powershell
$OsWindowsParametersAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

