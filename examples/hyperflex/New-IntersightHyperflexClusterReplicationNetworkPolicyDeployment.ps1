$replication_vlan1 = Initialize-IntersightReplicationNamedvlan -Name 'replication_vlan1' -VlanId 100

$organization1 = Get-IntersightOrganizationOrganization -Moid '<Replace with Moid>'

$hyperflex_cluster_replication_network_policy_deployment1 = New-IntersightHyperflexClusterReplicationNetworkPolicyDeployment -ReplicationVlan $replication_vlan1 -Organization $organization1 -Discovered 1