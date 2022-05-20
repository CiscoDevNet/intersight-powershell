$lldp_settings1 = Initialize-IntersightFabricLldpsettings -ReceiveEnabled 0 -TransmitEnabled 0

$organization1 = Get-IntersightOrganizationOrganization -Moid '<Replace with Moid>'

$fabric_eth_network_control_policy1 = New-IntersightFabricEthNetworkControlPolicy -LldpSettings $lldp_settings1 -Organization $organization1 -Name 'fabric_eth_network_control_policy1' -Description 'demo eth network control policy' -CdpEnabled 0 -ForgeMac 'allow' -MacRegistrationMode 'allVlans' -UplinkFailAction 'linkDown'