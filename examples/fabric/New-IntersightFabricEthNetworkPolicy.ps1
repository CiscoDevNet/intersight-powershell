$organization1 = Get-IntersightOrganizationOrganization -Name 'default'

$fabric_eth_network_policy1 = New-IntersightFabricEthNetworkPolicy -Organization $organization1 -Name 'fabric_eth_network_policy1' -Description 'fabric ethernet network policy'