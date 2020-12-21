# MoVersionContextAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "mo.VersionContext"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "mo.VersionContext"]
**InterestedMos** | [**MoMoRef[]**](MoMoRef.md) |  | [optional] 
**RefMo** | [**MoMoRef**](MoMoRef.md) |  | [optional] 
**Timestamp** | **System.DateTime** | The time this versioned Managed Object was created. | [optional] [readonly] 
**Version** | **String** | The version of the Managed Object, e.g. an incrementing number or a hash id. | [optional] [readonly] 
**VersionType** | **String** | Specifies type of version. Currently the only supported value is &quot;&quot;Configured&quot;&quot; that is used to keep track of snapshots of policies and profiles that are intended to be configured to target endpoints. * &#x60;Modified&#x60; - Version created every time an object is modified. * &#x60;Configured&#x60; - Version created every time an object is configured to the service profile. * &#x60;Deployed&#x60; - Version created for objects related to a service profile when it is deployed. | [optional] [readonly] [default to "Modified"]

## Examples

- Prepare the resource
```powershell
$MoVersionContextAllOf = Initialize-IntersightMoVersionContextAllOf  -ClassId null `
 -ObjectType null `
 -InterestedMos null `
 -RefMo null `
 -Timestamp null `
 -Version null `
 -VersionType null
```

- Convert the resource to JSON
```powershell
$MoVersionContextAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

