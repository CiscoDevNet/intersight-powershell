# TechsupportmanagementTechSupportStatusAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "techsupportmanagement.TechSupportStatus"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "techsupportmanagement.TechSupportStatus"]
**FileName** | **String** | The name of the Techsupport bundle file. | [optional] 
**Reason** | **String** | Reason for techsupport failure, if any. | [optional] 
**RelayReason** | **String** | Reason for status relay failure, if any. | [optional] [readonly] 
**RelayStatus** | **String** | Status of techsupport status relay. Valid values are NoRelay, Pending, Completed, and Failed. | [optional] [readonly] 
**RequestTs** | **System.DateTime** | The time at which the techsupport request was initiated. | [optional] 
**Status** | **String** | Status of techsupport collection. Valid values are Pending, CollectionInProgress, CollectionFailed, CollectionComplete, UploadPending, UploadInProgress, UploadPartsComplete, UploadFailed and Completed. The final status will be either CollectionFailed or UploadFailed if there is a failure and Completed if the request completed successfully and the file was uploaded to Intersight Storage Service. All the remaining status values indicates the progress of techsupport collection. | [optional] 
**TechsupportDownloadUrl** | **String** | The Url to download the techsupport file. | [optional] 
**ClusterMember** | [**AssetClusterMemberRelationship**](AssetClusterMemberRelationship.md) |  | [optional] 
**DeviceRegistration** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**OriginResource** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 
**TechSupportRequest** | [**TechsupportmanagementTechSupportBundleRelationship**](TechsupportmanagementTechSupportBundleRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$TechsupportmanagementTechSupportStatusAllOf = Initialize-IntersightTechsupportmanagementTechSupportStatusAllOf  -ClassId null `
 -ObjectType null `
 -FileName null `
 -Reason null `
 -RelayReason null `
 -RelayStatus null `
 -RequestTs null `
 -Status null `
 -TechsupportDownloadUrl null `
 -ClusterMember null `
 -DeviceRegistration null `
 -OriginResource null `
 -TechSupportRequest null
```

- Convert the resource to JSON
```powershell
$TechsupportmanagementTechSupportStatusAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

