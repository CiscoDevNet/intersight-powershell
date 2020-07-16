# WorkflowTaskDefinition
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountMoid** | **String** | The Account ID for this managed object. | [optional] [readonly] 
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**CreateTime** | **System.DateTime** | The time when this managed object was created. | [optional] [readonly] 
**DomainGroupMoid** | **String** | The DomainGroup ID for this managed object. | [optional] [readonly] 
**ModTime** | **System.DateTime** | The time when this managed object was last modified. | [optional] [readonly] 
**Moid** | **String** | The unique identifier of this Managed Object instance. | [optional] 
**ObjectType** | **String** | The fully-qualified type of this managed object, i.e. the class name. This property is optional. The ObjectType is implied from the URL path. If specified, the value of objectType must match the class name specified in the URL path. | [readonly] 
**Owners** | **String[]** |  | [optional] 
**SharedScope** | **String** | Intersight provides pre-built workflows, tasks and policies to end users through global catalogs. Objects that are made available through global catalogs are said to have a &#39;shared&#39; ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs. | [optional] [readonly] 
**Tags** | [**MoTag[]**](MoTag.md) |  | [optional] 
**VersionContext** | [**MoVersionContext**](MoVersionContext.md) |  | [optional] 
**Ancestors** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**Parent** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 
**PermissionResources** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**DisplayNames** | [**System.Collections.Hashtable**](Array.md) | a map of display names for a resource. | [optional] [readonly] 
**DefaultVersion** | **Boolean** | When true this will be the task version that is used when a specific task definition version is not specified. The very first task definition created with a name will be set as the default version, after that user can explicitly set any version of the task definition as the default version. | [optional] 
**Description** | **String** | The task definition description to describe what this task will do when executed. | [optional] 
**InternalProperties** | [**WorkflowInternalProperties**](WorkflowInternalProperties.md) |  | [optional] 
**Label** | **String** | A user friendly short name to identify the task definition. | [optional] 
**LicenseEntitlement** | **String** | License entitlement required to run this task. It is determined by license requirement of features. | [optional] [readonly] [default to "Base"]
**Name** | **String** | The name of the task definition. The name should follow this convention &lt;Verb or Action&gt;&lt;Category&gt;&lt;Vendor&gt;&lt;Product&gt;&lt;Noun or object&gt; Verb or Action is a required portion of the name and this must be part of the pre-approved verb list. Category is an optional field and this will refer to the broad category of the task referring to the type of resource or endpoint. If there is no specific category then use &quot;&quot;Generic&quot;&quot; if required. Vendor is an optional field and this will refer to the specific vendor this task applies to. If the task is generic and not tied to a vendor, then do not specify anything. Product is an optional field, this will contain the vendor product and model when desired. Noun or object is a required field and  this will contain the noun or object on which the action is being performed. Examples SendEmail  - This is a task in Generic category for sending email. NewStorageVolume - This is a vendor agnostic task under Storage device category for creating a new volume. | [optional] 
**Properties** | [**WorkflowProperties**](WorkflowProperties.md) |  | [optional] 
**SecurePropAccess** | **Boolean** | If set to true, the task requires access to secure properties and uses an encyption token associated with a workflow moid to encrypt or decrypt the secure properties. | [optional] 
**Version** | **Int64** | The version of the task definition so we can support multiple versions of a task definition. | [optional] 
**Catalog** | [**WorkflowCatalogRelationship**](WorkflowCatalogRelationship.md) |  | [optional] 
**ImplementedTasks** | [**WorkflowTaskDefinitionRelationship[]**](WorkflowTaskDefinitionRelationship.md) | An array of relationships to workflowTaskDefinition resources. | [optional] 
**InterfaceTask** | [**WorkflowTaskDefinitionRelationship**](WorkflowTaskDefinitionRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightWorkflowTaskDefinition  -AccountMoid null `
 -ClassId null `
 -CreateTime null `
 -DomainGroupMoid null `
 -ModTime null `
 -Moid null `
 -ObjectType null `
 -Owners null `
 -SharedScope null `
 -Tags null `
 -VersionContext null `
 -Ancestors null `
 -Parent null `
 -PermissionResources null `
 -DisplayNames null `
 -DefaultVersion null `
 -Description null `
 -InternalProperties null `
 -Label null `
 -LicenseEntitlement null `
 -Name null `
 -Properties null `
 -SecurePropAccess null `
 -Version null `
 -Catalog null `
 -ImplementedTasks null `
 -InterfaceTask null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

