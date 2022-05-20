$vlan_settings1 = Initialize-IntersightFabricVlansettings -NativeVlan 1 -AllowedVlans '313,314,1000'

$organization1 = Get-IntersightOrganizationOrganization -Moid '<Replace with Moid>'

$fabric_eth_network_group_policy1 = New-IntersightFabricEthNetworkGroupPolicy -VlanSettings $vlan_settings1 -Organization $organization1 -Name 'fabric_eth_network_group_policy1' -Description 'demo eth network group policy'