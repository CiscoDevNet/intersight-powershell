# VirtualizationCloudInitConfig
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "virtualization.CloudInitConfig"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "virtualization.CloudInitConfig"]
**ConfigType** | **String** | Virtual machine cloud init configuration type. * &#x60;&#x60; - No cloud init specified. Cloud-init configurations are not sent to hypervisor, if none is selected. * &#x60;NoCloudSource&#x60; - Allows the user to provide user-data to the instance without running a network service. * &#x60;CloudConfigDrive&#x60; - Allows the user to provide user-data and network-data from cloud. | [optional] [default to ""]
**NetworkData** | **String** | Network configuration data for a virtual machine. | [optional] 
**NetworkDataBase64Encoded** | **Boolean** | Set to true, if the cloud init network data is in base64 format. | [optional] 
**UserData** | **String** | User configuration data for a virtual machine such as adding user, group etc. | [optional] 
**UserDataBase64Encoded** | **Boolean** | Set to true, if the cloud init user data is in base64 format. | [optional] 

## Examples

- Prepare the resource
```powershell
$VirtualizationCloudInitConfig = Initialize-IntersightVirtualizationCloudInitConfig  -ClassId null `
 -ObjectType null `
 -ConfigType null `
 -NetworkData null `
 -NetworkDataBase64Encoded null `
 -UserData null `
 -UserDataBase64Encoded null
```

- Convert the resource to JSON
```powershell
$VirtualizationCloudInitConfig | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

