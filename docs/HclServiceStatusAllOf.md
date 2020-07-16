# HclServiceStatusAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExemptionFileVersion** | **String** | Version of the last modified exemption file. | [optional] 
**Identity** | **String** | A field to uniquely identify the document with the status. | [optional] 
**LastHclDataModifiedTime** | **System.DateTime** | The timestamp of the last modified record in the HCL tool database. Used to query and get updated records. | [optional] 
**LastImportedDataChecksum** | **String** | Checksum of the data dump used as the base for delta updates. | [optional] 
**Status** | **String** | Status of the service indicatating if the service is up or under maintenance due to data update. | [optional] [default to "Unknown"]

## Examples

- Prepare the resource
```powershell
Initialize-IntersightHclServiceStatusAllOf  -ExemptionFileVersion null `
 -Identity null `
 -LastHclDataModifiedTime null `
 -LastImportedDataChecksum null `
 -Status null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

