$default = Initialize-IntersightWorkflowDefaultValue -Override 0

$displaymeta = Initialize-IntersightWorkflowDisplayMeta -InventorySelector 1

$output_definition1 = Initialize-IntersightWorkflowPrimitivedatatype -ClassId 'WorkflowPrimitiveDataType' -Name 'status' -Label 'Value for label' -Required 0 -Description 'Value for description' -Default $default -DisplayMeta $displaymeta 

$tasks1 = Initialize-IntersightWorkflowStarttask -Description 'Create a vm' -Label 'value for label' -Name 'StartTask' -ClassId 'WorkflowStartTask'

$workflow_workflow_definition1 = New-IntersightWorkflowWorkflowDefinition -OutputDefinition $output_definition1 -Tasks $tasks1 -Name 'workflow_workflow_definition1' -Label 'Value for label' -DefaultVersion 1