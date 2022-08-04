$eth_network_policy1 = Get-IntersightFabricEthnetworkpolicy -Moid '<Replace with Moid>'

$multicast_policy1 = Get-IntersightFabricMulticastpolicy -Moid '<Replace with Moid>'

$fabric_vlan1 = New-IntersightFabricVlan -EthNetworkPolicy $eth_network_policy1 -MulticastPolicy $multicast_policy1 -AutoAllowOnUplinks 1 -IsNative 1 -Name 'fabric_vlan1' -VlanId 10