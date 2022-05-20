$mac_aging_settings1 = Initialize-IntersightFabricMacagingsettings -MacAgingOption 'Custom' -MacAgingTime {'mac_aging_option': 'Custom', 'mac_aging_time': 3000, 'object_type': 'fabric.MacAgingSettings'}

$organization1 = Get-IntersightOrganizationOrganization -Moid '<Replace with Moid>'

$fabric_switch_control_policy1 = New-IntersightFabricSwitchControlPolicy -MacAgingSettings $mac_aging_settings1 -Organization $organization1 -Name 'fabric_switch_control_policy1' -Description 'fabric switch control policy' -VlanPortOptimizationEnabled 1