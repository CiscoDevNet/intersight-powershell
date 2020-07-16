# StorageBaseInitiatorAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Iqn** | **String** | IQN (iSCSI qualified name). Can be up to 255 characters long and has the format iqn.yyyy-mm.naming-authority:unique name. | [optional] [readonly] 
**Name** | **String** | Name of the initiator represented in the storage array. | [optional] [readonly] 
**Type** | **String** | Initiator type, it can be FC or iSCSI. | [optional] [readonly] [default to "FC"]
**Wwn** | **String** | World wide name, 128 bit address represented in hexadecimal notation. For example, 51:4f:0c:50:14:1f:af:01:51:4f:0c:51:14:1f:af:01. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightStorageBaseInitiatorAllOf  -Iqn null `
 -Name null `
 -Type null `
 -Wwn null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

