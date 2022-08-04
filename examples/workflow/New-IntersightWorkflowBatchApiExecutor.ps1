$task_definition1 = Get-IntersightWorkflowTaskdefinition -Moid '<Replace with Moid>'

$batch = Initialize-IntersightWorkflowWebApi -Name 'RemoveHyperFlexStorageContainer'

$workflow_batch_api_executor1 = New-IntersightWorkflowBatchApiExecutor -TaskDefinition $task_definition1 -Name 'workflowbatch' -RetryFromFailedApi 0 -Batch $batch