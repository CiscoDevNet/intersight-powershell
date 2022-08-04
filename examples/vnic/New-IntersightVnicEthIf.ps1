$placement1 = Initialize-IntersightVnicPlacementsettings -Id '1' -PciLink 0 -Uplink 0 

$cdn1 = Initialize-IntersightVnicCdn -Value 'VIC-1-eth00' -Source 'user'

$usnic_settings1 = Initialize-IntersightVnicUsnicsettings -Cos 5 -Count 0

$vmq_settings1 = Initialize-IntersightVnicVmqsettings -Enabled 1 -MultiQueueSupport 0 -NumInterrupts 1 -NumVmqs 1 

$lan_connectivity_policy1 = Get-IntersightVnicLanconnectivitypolicy -Moid '<Replace with Moid>'

$eth_network_policy1 = Get-IntersightVnicEthnetworkpolicy -Moid '<Replace with Moid>'

$eth_adapter_policy1 = Get-IntersightVnicEthadapterpolicy -Moid '<Replace with Moid>'

$eth_qos_policy1 = Get-IntersightVnicEthqospolicy -Moid '<Replace with Moid>'

$eth1 = New-IntersightVnicEthIf -Placement $placement1 -Cdn $cdn1 -UsnicSettings $usnic_settings1 -VmqSettings $vmq_settings1 -LanConnectivityPolicy $lan_connectivity_policy1 -EthNetworkPolicy $eth_network_policy1 -EthAdapterPolicy $eth_adapter_policy1 -EthQosPolicy $eth_qos_policy1 -Name 'eth0' -Order 0