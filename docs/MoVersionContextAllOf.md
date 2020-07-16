# MoVersionContextAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InterestedMos** | [**MoMoRef[]**](MoMoRef.md) |  | [optional] 
**RefMo** | [**MoMoRef**](MoMoRef.md) |  | [optional] 
**Timestamp** | **System.DateTime** | The time this versioned Managed Object was created. | [optional] [readonly] 
**Version** | **String** | The version of the Managed Object, e.g. an incrementing number or a hash id. | [optional] [readonly] 
**VersionType** | **String** | Specifies type of version. Currently the only supported value is &quot;&quot;Configured&quot;&quot; that is used to keep track of snapshots of policies and profiles that are intended to be configured to target endpoints. | [optional] [readonly] [default to "Modified"]

## Examples

- Prepare the resource
```powershell
Initialize-IntersightMoVersionContextAllOf  -InterestedMos null `
 -RefMo null `
 -Timestamp null `
 -Version null `
 -VersionType null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

