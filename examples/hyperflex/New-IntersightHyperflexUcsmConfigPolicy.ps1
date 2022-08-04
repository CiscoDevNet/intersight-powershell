$kvm_ip_range1 = Initialize-IntersightHyperflexIpaddrrange -EndAddr '10.10.10.100' -Gateway '10.10.10.1' -Netmask '255.255.255.0' -StartAddr '10.10.10.10'

$organization1 = Get-IntersightOrganizationOrganization -Name 'default'

$hyperflex_ucsm_config_policy1 = New-IntersightHyperflexUcsmConfigPolicy -KvmIpRange $kvm_ip_range1 -Organization $organization1 -Name 'hyperflex_ucsm_config_policy1' -Description 'hyperflex ucsm configuration policy' -ServerFirmwareVersion '3.5(2h)'