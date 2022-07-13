$organization = Get-IntersightOrganizationOrganization -Name 'default'

$vlan_settings1 = Initialize-IntersightVnicVlansettings -DefaultVlan 1 -Mode 'ACCESS'

$v_eth_network1 = New-IntersightVnicEthNetworkPolicy -Organization $organization -VlanSettings $vlan_settings1 -Name 'v_eth_network1'