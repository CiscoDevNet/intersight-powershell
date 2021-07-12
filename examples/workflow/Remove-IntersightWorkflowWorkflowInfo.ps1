
#Get the WorkflowWorkflowInfo to delete
$WorkflowWorkflowInfo = Remove-IntersightWorkflowWorkflowInfo -Name WorkflowWorkflowInfoName
$WorkflowWorkflowInfo | Remove-IntersightWorkflowWorkflowInfo

#Remove the server profile by Moid.
Remove-IntersightWorkflowWorkflowInfo -Moid 123bc2222287wee
