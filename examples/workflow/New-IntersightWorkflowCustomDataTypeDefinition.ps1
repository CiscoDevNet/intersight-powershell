$catalog1 = Get-IntersightWorkflowCatalog -Moid '<Replace with Moid>'

$parameter_set1 = Initialize-IntersightWorkflowParameterset -ClassId 'WorkflowParameterSet' -Name 'show-netapp' -Condition 'eq' -ControlParameter 'PlatformType' -EnableParameters @('ExpandedVolumeCapacity') -Value 'StorageNetAppCluster'

$type_def = Initialize-IntersightWorkflowPrimitiveDataType -Description 'demo type definition' -Label 'Template' -Name 'Template'                                          

$workflow_custom_data_type_definition1 = New-IntersightWorkflowCustomDataTypeDefinition -Catalog $catalog1 -ParameterSet $parameter_set1 -Name 'workflow_custom_data_type_definition1' -Description 'captures a customized data type definition for workflow input/output' -Label 'custom_data_dfn1' -TypeDefinition $typedef -CompositeType 1