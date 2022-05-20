$assigned_server1 = Get-IntersightComputeRackunit -Moid '<Replace with Moid>'

$cluster_profile1 = Get-IntersightHyperflexClusterprofile -Moid '<Replace with Moid>'

$hyperflex_node_profile1 = New-IntersightHyperflexNodeProfile -AssignedServer $assigned_server1 -ClusterProfile $cluster_profile1 -Description 'This is hyperflex_node_profile1' -Name 'ucsback-10G-3nodehx-cluster-NP1'