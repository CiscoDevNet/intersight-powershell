$organization1 = Get-IntersightOrganizationOrganization -Name 'default'

$fabric_fc_network_policy1 = New-IntersightFabricFcNetworkPolicy -Organization $organization1 -Name 'fabric_eth_network_policy1' -Description 'fabric ethernet network policy' -EnableTrunking 1