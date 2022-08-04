#Get the WorkflowWorkflowInfo to delete
$WorkflowWorkflowInfo = Get-IntersightWorkflowWorkflowInfo -Name WorkflowWorkflowInfoName
$WorkflowWorkflowInfo | Remove-IntersightWorkflowWorkflowInfo

#Remove the WorkflowWorkflowInfo by Moid.
Remove-IntersightWorkflowWorkflowInfo -Moid '<Replace with Moid>'
