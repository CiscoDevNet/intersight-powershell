$placement1 = Initialize-IntersightVnicPlacementsettings -Id '1' -PciLink 0 -Uplink 0

$san_connectivity_policy1 = Get-IntersightVnicSanconnectivitypolicy -Moid '<Replace with Moid>'

$fc_network_policy1 = Get-IntersightVnicFcnetworkpolicy -Moid '<Replace with Moid>'

$fc_adapter_policy1 = Get-IntersightVnicFcadapterpolicy -Moid '<Replace with Moid>'

$fc_qos_policy1 = Get-IntersightVnicFcqospolicy -Moid '<Replace with Moid>'

$fc1 = New-IntersightVnicFcIf -Placement $placement1 -SanConnectivityPolicy $san_connectivity_policy1 -FcNetworkPolicy $fc_network_policy1 -FcAdapterPolicy $fc_adapter_policy1 -FcQosPolicy $fc_qos_policy1 -Name 'fc0' -Order 1 -PersistentBindings 1