$replication_vlan1 = Initialize-IntersightReplicationNamedvlan -Name 'replication_vlan1' -VlanId 100

$organization1 = Get-IntersightOrganizationOrganization -Moid '<Replace with Moid>'

$hyperflex_cluster_replication_network_policy1 = New-IntersightHyperflexClusterReplicationNetworkPolicy -ReplicationVlan $replication_vlan1 -Organization $organization1 -Name 'hyperflex_cluster_replication_network_policy1' -Description 'hyperflex cluster replication network policy' -ReplicationBandwidthMbps 100 -ReplicationMtu 1500