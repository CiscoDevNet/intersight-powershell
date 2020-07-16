# TamAdvisoryInstanceAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AffectedObjectMoid** | **String** | Moid of the Intersight MO affected by the alert. Deprecated now and will be removed in subsequent releases. | [optional] 
**AffectedObjectType** | **String** | Object type of the Intersight MO affected by the alert. Deprecated now and will be removed in subsequent releases. | [optional] 
**LastStateChangeTime** | **System.DateTime** | Timestamp when a state change was observed on this advisory instnace. | [optional] [readonly] 
**LastVerifiedTime** | **System.DateTime** | Timestamp when this advisory was last evaluated. | [optional] [readonly] 
**State** | **String** | Current state of the advisory instance (Active/Cleared/Unknown etc.). | [optional] [default to "unknown"]
**Advisory** | [**TamBaseAdvisoryRelationship**](TamBaseAdvisoryRelationship.md) |  | [optional] 
**AffectedObject** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 
**DeviceRegistration** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightTamAdvisoryInstanceAllOf  -AffectedObjectMoid null `
 -AffectedObjectType null `
 -LastStateChangeTime null `
 -LastVerifiedTime null `
 -State null `
 -Advisory null `
 -AffectedObject null `
 -DeviceRegistration null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

