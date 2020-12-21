# VirtualizationGuestInfoAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "virtualization.GuestInfo"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "virtualization.GuestInfo"]
**Hostname** | **String** | Name provided to the host OS (example, ubuntu6410, test-gateway, etc.). | [optional] 
**IpAddress** | **String** | Primary IP address of the guest os. | [optional] 
**Name** | **String** | The name of the guest running on this VM. This may not be the same as the hostname. | [optional] 
**OperatingSystem** | **String** | The name of the guest OS running on this VM (Cent OS 4/5/6/7). | [optional] 

## Examples

- Prepare the resource
```powershell
$VirtualizationGuestInfoAllOf = Initialize-IntersightVirtualizationGuestInfoAllOf  -ClassId null `
 -ObjectType null `
 -Hostname null `
 -IpAddress null `
 -Name null `
 -OperatingSystem null
```

- Convert the resource to JSON
```powershell
$VirtualizationGuestInfoAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

