# SdwanRouterNodeAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DeviceTemplate** | **String** | Name of the Cisco vManage device template that the current device should be attached to. A device template consists of many feature templates that contain SD-WAN vEdge router configuration. | [optional] 
**Name** | **String** | Name of the router node object. | [optional] 
**NetworkConfiguration** | [**SdwanNetworkConfigurationType[]**](SdwanNetworkConfigurationType.md) |  | [optional] 
**TemplateInputs** | [**SdwanTemplateInputsType[]**](SdwanTemplateInputsType.md) |  | [optional] 
**Uuid** | **String** | Uniquely identifies the router by its chassis number. | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 
**VarProfile** | [**SdwanProfileRelationship**](SdwanProfileRelationship.md) |  | [optional] 
**ServerNode** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightSdwanRouterNodeAllOf  -DeviceTemplate null `
 -Name null `
 -NetworkConfiguration null `
 -TemplateInputs null `
 -Uuid null `
 -Organization null `
 -VarProfile null `
 -ServerNode null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

