# WorkflowTaskDefinitionAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "workflow.TaskDefinition"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "workflow.TaskDefinition"]
**DefaultVersion** | **Boolean** | When true this will be the task version that is used when a specific task definition version is not specified. The very first task definition created with a name will be set as the default version, after that user can explicitly set any version of the task definition as the default version. | [optional] 
**Description** | **String** | The task definition description to describe what this task will do when executed. | [optional] 
**InternalProperties** | [**WorkflowInternalProperties**](WorkflowInternalProperties.md) |  | [optional] 
**Label** | **String** | A user friendly short name to identify the task definition. Label can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-), period (.), colon (:), space ( ), single quote (&#39;), or an underscore (_). | [optional] 
**LicenseEntitlement** | **String** | License entitlement required to run this task. It is determined by license requirement of features. * &#x60;Base&#x60; - Base as a License type. It is default license type. * &#x60;Essential&#x60; - Essential as a License type. * &#x60;Standard&#x60; - Standard as a License type. * &#x60;Advantage&#x60; - Advantage as a License type. * &#x60;Premier&#x60; - Premier as a License type. * &#x60;IWO-Essential&#x60; - IWO-Essential as a License type. * &#x60;IWO-Advantage&#x60; - IWO-Advantage as a License type. * &#x60;IWO-Premier&#x60; - IWO-Premier as a License type. | [optional] [readonly] [default to "Base"]
**Name** | **String** | The name of the task definition. The name should follow this convention &lt;Verb or Action&gt;&lt;Category&gt;&lt;Vendor&gt;&lt;Product&gt;&lt;Noun or object&gt; Verb or Action is a required portion of the name and this must be part of the pre-approved verb list. Category is an optional field and this will refer to the broad category of the task referring to the type of resource or endpoint. If there is no specific category then use &quot;&quot;Generic&quot;&quot; if required. Vendor is an optional field and this will refer to the specific vendor this task applies to. If the task is generic and not tied to a vendor, then do not specify anything. Product is an optional field, this will contain the vendor product and model when desired. Noun or object is a required field and  this will contain the noun or object on which the action is being performed. Name can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-), period (.), colon (:), or an underscore (_). Examples SendEmail  - This is a task in Generic category for sending email. NewStorageVolume - This is a vendor agnostic task under Storage device category for creating a new volume. | [optional] 
**Properties** | [**WorkflowProperties**](WorkflowProperties.md) |  | [optional] 
**RollbackTasks** | [**WorkflowRollbackTask[]**](WorkflowRollbackTask.md) |  | [optional] 
**SecurePropAccess** | **Boolean** | If set to true, the task requires access to secure properties and uses an encyption token associated with a workflow moid to encrypt or decrypt the secure properties. | [optional] 
**Version** | **Int64** | The version of the task definition so we can support multiple versions of a task definition. | [optional] [default to 1]
**Catalog** | [**WorkflowCatalogRelationship**](WorkflowCatalogRelationship.md) |  | [optional] 
**ImplementedTasks** | [**WorkflowTaskDefinitionRelationship[]**](WorkflowTaskDefinitionRelationship.md) | An array of relationships to workflowTaskDefinition resources. | [optional] 
**InterfaceTask** | [**WorkflowTaskDefinitionRelationship**](WorkflowTaskDefinitionRelationship.md) |  | [optional] 
**TaskMetadata** | [**WorkflowTaskMetadataRelationship**](WorkflowTaskMetadataRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$WorkflowTaskDefinitionAllOf = Initialize-IntersightWorkflowTaskDefinitionAllOf  -ClassId null `
 -ObjectType null `
 -DefaultVersion null `
 -Description null `
 -InternalProperties null `
 -Label null `
 -LicenseEntitlement null `
 -Name null `
 -Properties null `
 -RollbackTasks null `
 -SecurePropAccess null `
 -Version null `
 -Catalog null `
 -ImplementedTasks null `
 -InterfaceTask null `
 -TaskMetadata null
```

- Convert the resource to JSON
```powershell
$WorkflowTaskDefinitionAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

