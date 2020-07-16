# VirtualizationGuestInfoAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Hostname** | **String** | Name provided to the host OS (example, ubuntu6410, test-gateway, etc.). | [optional] 
**IpAddress** | **String** | Primary IP address of the guest os. | [optional] 
**Name** | **String** | The name of the guest running on this VM. This may not be the same as the hostname. | [optional] 
**OperatingSystem** | **String** | The name of the guest OS running on this VM (Cent OS 4/5/6/7). | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightVirtualizationGuestInfoAllOf  -Hostname null `
 -IpAddress null `
 -Name null `
 -OperatingSystem null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

