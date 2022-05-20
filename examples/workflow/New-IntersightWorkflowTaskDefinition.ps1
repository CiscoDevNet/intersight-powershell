$properties1 = Initialize-IntersightWorkflowProperties -ExternalMeta 1 -RetryCount 6 -RetryDelay 60 -RetryPolicy 'Fixed' -SupportStatus 'Supported' -Timeout 60

$catalog1 = Get-IntersightWorkflowCatalog -Moid '<Replace with Moid>'

$task_metadata1 = Get-IntersightWorkflowTaskmetadata -Moid '<Replace with Moid>'

$workflow_task_definition1 = New-IntersightWorkflowTaskDefinition -Properties $properties1 -Catalog $catalog1 -TaskMetadata $task_metadata1 -Name 'workflow_task_definition1' -Label 'inventory.ScopedInventoryTask' -DefaultVersion 1