$properties1 = Initialize-IntersightWorkflowWorkflowinfoproperties -Retryable 0

$organization = Get-IntersightOrganizationOrganization -Name 'default'

$workflow_definition1 = Get-IntersightWorkflowWorkflowdefinition -Moid '<Replace with Moid>'

New-IntersightWorkflowWorkflowInfo -Organization $organization -WorkflowDefinition $workflow_definition1 -Name 'workflow_workflow_info1' -PauseReason 'None' -Action 'Create' -SuccessWorkflowCleanupDuration 2160 -WaitReason 'None' -WorkflowMetaType 'SystemDefined'