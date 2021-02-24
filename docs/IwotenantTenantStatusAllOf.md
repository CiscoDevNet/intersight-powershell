# IwotenantTenantStatusAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "iwotenant.TenantStatus"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "iwotenant.TenantStatus"]
**DeployStatus** | **String** | The deployStatus provides the current status of this deployment. * &#x60;NotStarted&#x60; - The workflow to deploy the tenant cluster has not yet started. * &#x60;InProgress&#x60; - The workflow to deploy the tenant cluster in progress. All the tasks required for thesuccessful tenant creation are running. * &#x60;Completed&#x60; - The workflow to deploy the tenant cluster has completed and health checks have passed. * &#x60;Failed&#x60; - The workflow to deploy the tenant cluster has failed. Detailed reason for the failure isprovided from Tenant.deployStatus. | [optional] [readonly] [default to "NotStarted"]
**IwoId** | **String** | The iwoId uniquely identifies a IWO tenant. The iwoId is used as part of namespace, (logical) database names, policies in vault and many others. As of now, accountMoid has to be provided as the iwoId. | [optional] [readonly] 
**ReferenceTime** | **System.DateTime** | During IWO tenant upgrade (or reconfiguration), deployStatus is set to InProgress and referenceTime set to current time. When tenant upgrade (or reconfiguration) does not complete within a pre-defined time using this as reference, deployStatus is set as Failed. | [optional] [readonly] 
**Account** | [**IamAccountRelationship**](IamAccountRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$IwotenantTenantStatusAllOf = Initialize-IntersightIwotenantTenantStatusAllOf  -ClassId null `
 -ObjectType null `
 -DeployStatus null `
 -IwoId null `
 -ReferenceTime null `
 -Account null
```

- Convert the resource to JSON
```powershell
$IwotenantTenantStatusAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

