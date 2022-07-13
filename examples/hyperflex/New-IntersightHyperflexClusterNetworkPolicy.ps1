$mgmt_vlan1 = Initialize-IntersightHyperflexNamedvlan -Name 'hx-inband-mgmt' -VlanId 301 

$mac_prefix_range1 = Initialize-IntersightHyperflexMacaddrprefixrange -EndAddr '00:25:B5:D5' -StartAddr '00:25:B5:D5'

$organization1 = Get-IntersightOrganizationOrganization -Name 'default'

$hyperflex_cluster_network_policy1 = New-IntersightHyperflexClusterNetworkPolicy -MgmtVlan $mgmt_vlan1 -MacPrefixRange $mac_prefix_range1 -Organization $organization1 -JumboFrame 1 -UplinkSpeed '10G' -Name 'hyperflex_cluster_network_policy1'