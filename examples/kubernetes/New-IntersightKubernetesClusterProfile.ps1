$config_context1 = Initialize-IntersightPolicyConfigcontext -ControlAction 'Deploy' -ErrorState 'Pre-config-error'

$organization1 = Get-IntersightOrganizationOrganization -Name 'default'

$workflow_info1 = Get-IntersightWorkflowWorkflowinfo -Moid '<Replace with Moid>'

$kubernetes_cluster_profile1 = New-IntersightKubernetesClusterProfile -ConfigContext $config_context1 -Organization $organization1 -WorkflowInfo $workflow_info1 -Description 'kubernetes cluster profile' -Name 'kubernetes_cluster_profile1' -Type Instance -Action 'Deploy' -ManagedMode 'Managed' -Status 'Deploying'