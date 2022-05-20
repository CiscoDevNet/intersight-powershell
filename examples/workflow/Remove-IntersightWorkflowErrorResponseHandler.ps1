#Get the WorkflowErrorResponseHandler to delete
$WorkflowErrorResponseHandler = Get-IntersightWorkflowErrorResponseHandler -Name WorkflowErrorResponseHandlerName
$WorkflowErrorResponseHandler | Remove-IntersightWorkflowErrorResponseHandler

#Remove the WorkflowErrorResponseHandler by Moid.
Remove-IntersightWorkflowErrorResponseHandler -Moid '<Replace with Moid>'

