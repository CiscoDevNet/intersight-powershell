$primary_workflow1 = Get-IntersightWorkflowWorkflowinfo -Moid '<Replace with Moid>'

$selected_tasks1 = Initialize-IntersightWorkflowRollbackworkflowtask -ClassId 'WorkflowRollbackWorkflowTask' -Name 'taskInfo_name' -RefName 'reference_name_task_info_rollback' -TaskInfoMoid 'intersight_workflow_workflow_info.workflow_workflow_info1.moid'

$workflow_rollback_workflow = New-IntersightWorkflowRollbackWorkflow -PrimaryWorkflow $primary_workflow1 -SelectedTasks $selected_tasks1 -Action 'create' -ContinueOnTaskFailure 0