#Get the WorkflowRollbackWorkflow by Name
$WorkflowRollbackWorkflowByName = Get-IntersightWorkflowRollbackWorkflow -Name WorkflowRollbackWorkflowName

#Get the List of ServerProfiles
$WorkflowRollbackWorkflowList = Get-IntersightWorkflowRollbackWorkflow

#Get the list of WorkflowRollbackWorkflow under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$WorkflowRollbackWorkflowByOrg = Get-IntersightWorkflowRollbackWorkflow -Organization $org

#Get the WorkflowRollbackWorkflow based on query Parameter
$WorkflowRollbackWorkflowByQueryParam = Get-IntersightWorkflowRollbackWorkflow -Filter Name eq WorkflowRollbackWorkflowName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .