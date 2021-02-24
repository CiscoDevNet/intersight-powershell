# TechsupportmanagementCollectionControlPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "techsupportmanagement.CollectionControlPolicy"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "techsupportmanagement.CollectionControlPolicy"]
**DeploymentType** | **String** | Deployment type defines whether the policy is associated with a SaaS or Appliance account. * &#x60;None&#x60; - Service deployment type None. * &#x60;SaaS&#x60; - Service deployment type SaaS. * &#x60;Appliance&#x60; - Service deployment type Appliance. | [optional] [readonly] [default to "None"]
**TechSupportCollection** | **String** | Enable or Disable techsupport collection for a specific account. * &#x60;Enable&#x60; - Enable techsupport collection. * &#x60;Disable&#x60; - Disable techsupport collection. | [optional] [default to "Enable"]
**Account** | [**IamAccountRelationship**](IamAccountRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$TechsupportmanagementCollectionControlPolicyAllOf = Initialize-IntersightTechsupportmanagementCollectionControlPolicyAllOf  -ClassId null `
 -ObjectType null `
 -DeploymentType null `
 -TechSupportCollection null `
 -Account null
```

- Convert the resource to JSON
```powershell
$TechsupportmanagementCollectionControlPolicyAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

