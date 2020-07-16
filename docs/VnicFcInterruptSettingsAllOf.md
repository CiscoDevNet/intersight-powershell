# VnicFcInterruptSettingsAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Mode** | **String** | The preferred driver interrupt mode. This can be one of the following:- MSIx — Message Signaled Interrupts (MSI) with the optional extension. MSI   — MSI only. INTx  — PCI INTx interrupts. MSIx is the recommended option. | [optional] [default to "MSIx"]

## Examples

- Prepare the resource
```powershell
Initialize-IntersightVnicFcInterruptSettingsAllOf  -Mode null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

