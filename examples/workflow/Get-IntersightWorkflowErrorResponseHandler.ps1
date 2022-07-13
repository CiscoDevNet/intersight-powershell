#Get the WorkflowErrorResponseHandler by Name
$WorkflowErrorResponseHandlerByName = Get-IntersightWorkflowErrorResponseHandler -Name WorkflowErrorResponseHandlerName

#Get the List of WorkflowErrorResponseHandler
$WorkflowErrorResponseHandlerList = Get-IntersightWorkflowErrorResponseHandler

#Get the list of WorkflowErrorResponseHandler under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$WorkflowErrorResponseHandlerByOrg = Get-IntersightWorkflowErrorResponseHandler -Organization $org

#Get the WorkflowErrorResponseHandler based on query Parameter
$WorkflowErrorResponseHandlerByQueryParam = Get-IntersightWorkflowErrorResponseHandler -Filter Name eq WorkflowErrorResponseHandlerName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .