# Get the organization.
$organization = Get-IntersightOrganizationOrganization -Moid '<Replace with Moid>'

# Get the WorkflowWorkflowInfo to Update
$WorkflowWorkflowInfo = Get-IntersightWorkflowWorkflowInfo -Name WorkflowWorkflowInfoName

# Update the WorkflowWorkflowInfo
$workflow_info1 = $WorkflowWorkflowInfo | Set-IntersightWorkflowWorkflowInfo -WaitReason 'None'