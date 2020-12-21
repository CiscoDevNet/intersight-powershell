# TamAdvisoryInstanceAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "tam.AdvisoryInstance"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "tam.AdvisoryInstance"]
**AffectedObjectMoid** | **String** | Moid of the Intersight MO affected by the alert. Deprecated now and will be removed in subsequent releases. | [optional] 
**AffectedObjectType** | **String** | Object type of the Intersight MO affected by the alert. Deprecated now and will be removed in subsequent releases. | [optional] 
**LastStateChangeTime** | **System.DateTime** | Timestamp when a state change was observed on this advisory instnace. | [optional] [readonly] 
**LastVerifiedTime** | **System.DateTime** | Timestamp when this advisory was last evaluated. | [optional] [readonly] 
**State** | **String** | Current state of the advisory instance (Active/Cleared/Unknown etc.). * &#x60;unknown&#x60; - Intersight is unable to determine if the Advisory instance is applicable for the affected managed object. * &#x60;active&#x60; - Advisory instance is currently active and applicable for the affected managed object. * &#x60;cleared&#x60; - Advisory instance is no longer applicable for the affected managed object. | [optional] [default to "unknown"]
**Advisory** | [**TamBaseAdvisoryRelationship**](TamBaseAdvisoryRelationship.md) |  | [optional] 
**AffectedObject** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 
**DeviceRegistration** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$TamAdvisoryInstanceAllOf = Initialize-IntersightTamAdvisoryInstanceAllOf  -ClassId null `
 -ObjectType null `
 -AffectedObjectMoid null `
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
$TamAdvisoryInstanceAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

