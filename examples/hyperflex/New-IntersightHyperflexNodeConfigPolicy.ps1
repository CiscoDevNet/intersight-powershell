$mgmt_ip_range1 = Initialize-IntersightHyperflexIpaddrrange -EndAddr '10.225.68.240' -Gateway '10.225.68.1' -Netmask '255.255.255.0' -StartAddr '10.225.68.238'

$hxdp_ip_range1 = Initialize-IntersightHyperflexIpaddrrange -EndAddr '10.225.68.243' -Gateway '10.225.68.1' -Netmask '255.255.255.0' -StartAddr '10.225.68.241'

$organization1 = Get-IntersightOrganizationOrganization -Moid '<Replace with Moid>'

$hyperflex_node_config_policy1 = New-IntersightHyperflexNodeConfigPolicy -MgmtIpRange $mgmt_ip_range1 -HxdpIpRange $hxdp_ip_range1 -Organization $organization1 -NodeNamePrefix 'EdgeM4' -Name 'hyperflex_node_config_policy1'