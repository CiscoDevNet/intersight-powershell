$organization1 = Get-IntersightOrganizationOrganization -Moid '<Replace with Moid>'

$fabric_eth_network_policy1 = New-IntersightFabricEthNetworkPolicy -Organization $organization1 -Name 'fabric_eth_network_policy1' -Description 'fabric ethernet network policy'