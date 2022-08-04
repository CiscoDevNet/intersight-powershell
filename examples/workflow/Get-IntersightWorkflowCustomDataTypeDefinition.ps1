#Get the WorkflowCustomDataTypeDefinition by Name
$WorkflowCustomDataTypeDefinitionByName = Get-IntersightWorkflowCustomDataTypeDefinition -Name WorkflowCustomDataTypeDefinitionName

#Get the List of WorkflowCustomDataTypeDefinition
$WorkflowCustomDataTypeDefinitionList = Get-IntersightWorkflowCustomDataTypeDefinition

#Get the list of WorkflowCustomDataTypeDefinition under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$WorkflowCustomDataTypeDefinitionByOrg = Get-IntersightWorkflowCustomDataTypeDefinition -Organization $org

#Get the WorkflowCustomDataTypeDefinition based on query Parameter
$WorkflowCustomDataTypeDefinitionByQueryParam = Get-IntersightWorkflowCustomDataTypeDefinition -Filter Name eq WorkflowCustomDataTypeDefinitionName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .