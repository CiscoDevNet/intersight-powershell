
#Get the WorkflowErrorResponseHandler to delete
$WorkflowErrorResponseHandler = Remove-IntersightWorkflowErrorResponseHandler -Name WorkflowErrorResponseHandlerName
$WorkflowErrorResponseHandler | Remove-IntersightWorkflowErrorResponseHandler

#Remove the server profile by Moid.
Remove-IntersightWorkflowErrorResponseHandler -Moid 123bc2222287wee
