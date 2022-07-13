$organization1 = Get-IntersightOrganizationOrganization -Name 'default'

$hyperflex_sys_config_policy1 = New-IntersightHyperflexSysConfigPolicy -Organization $organization1 -Timezone AsiaCalcutta -DnsDomainName 'cisco.com' -Name 'hyperflex_sys_config_policy1' -DnsServers @('8.8.8.8') -NtpServers @('10.10.58.51')