$organization1 = Get-IntersightOrganizationOrganization -Moid '<Replace with Moid>'

$kubernetes_sys_config_policy1 = New-IntersightKubernetesSysConfigPolicy -Organization $organization1 -Description 'kubernetes sys config policy' -Name 'kubernetes_sys_config_policy1' -Timezone AsiaCalcutta -DnsDomainName 'cisco.com' -DnsServers @('8.8.8.8') -NtpServers @('10.10.50.50')