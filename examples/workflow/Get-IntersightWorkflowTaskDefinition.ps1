#Get the WorkflowTaskDefinition by Name
$WorkflowTaskDefinitionByName = Get-IntersightWorkflowTaskDefinition -Name WorkflowTaskDefinitionName

#Get the List of WorkflowTaskDefinition
$WorkflowTaskDefinitionList = Get-IntersightWorkflowTaskDefinition

#Get the list of WorkflowTaskDefinition under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$WorkflowTaskDefinitionByOrg = Get-IntersightWorkflowTaskDefinition -Organization $org

#Get the WorkflowTaskDefinition based on query Parameter
$WorkflowTaskDefinitionByQueryParam = Get-IntersightWorkflowTaskDefinition -Filter Name eq WorkflowTaskDefinitionName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .