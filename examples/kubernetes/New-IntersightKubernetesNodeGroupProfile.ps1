$config_context1 = Initialize-IntersightPolicyConfigcontext -ControlAction 'Deploy' -ErrorState 'Pre-config-error'

$cluster_profile1 = Get-IntersightKubernetesClusterprofile -Moid '<Replace with Moid>'

$kubernetes_node_group_profile1 = New-IntersightKubernetesNodeGroupProfile -ConfigContext $config_context1 -ClusterProfile $cluster_profile1 -Description 'kubernetes node group profile' -Name 'kubernetes_node_group_profile1' -Type Instance -Action 'Deploy' -NodeType 'Worker'