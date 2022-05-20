#Get the WorkflowBatchApiExecutor by Name
$WorkflowBatchApiExecutorByName = Get-IntersightWorkflowBatchApiExecutor -Name WorkflowBatchApiExecutorName

#Get the List of WorkflowBatchApiExecutor
$WorkflowBatchApiExecutorList = Get-IntersightWorkflowBatchApiExecutor

#Get the list of WorkflowBatchApiExecutor under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$WorkflowBatchApiExecutorByOrg = Get-IntersightWorkflowBatchApiExecutor -Organization $org

#Get the WorkflowBatchApiExecutor based on query Parameter
$WorkflowBatchApiExecutorByQueryParam = Get-IntersightWorkflowBatchApiExecutor -Filter Name eq WorkflowBatchApiExecutorName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .