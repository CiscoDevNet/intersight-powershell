#Get the WorkflowWorkflowDefinition by Name
$WorkflowWorkflowDefinitionByName = Get-IntersightWorkflowWorkflowDefinition -Name WorkflowWorkflowDefinitionName

#Get the List of WorkflowWorkflowDefinition
$WorkflowWorkflowDefinitionList = Get-IntersightWorkflowWorkflowDefinition

#Get the list of WorkflowWorkflowDefinition under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$WorkflowWorkflowDefinitionByOrg = Get-IntersightWorkflowWorkflowDefinition -Organization $org

#Get the WorkflowWorkflowDefinition based on query Parameter
$WorkflowWorkflowDefinitionByQueryParam = Get-IntersightWorkflowWorkflowDefinition -Filter Name eq WorkflowWorkflowDefinitionName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .