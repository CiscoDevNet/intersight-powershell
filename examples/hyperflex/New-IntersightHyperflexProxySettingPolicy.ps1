
$tags1 = Initialize-IntersightMoTag -Key 'test' -Value 'autoProxy'

$organization1 = Get-IntersightOrganizationOrganization -Name 'default'

$hyperflex_proxy_setting_policy1 = New-IntersightHyperflexProxySettingPolicy -Tags $tags1 -Organization $organization1 -Hostname '10.10.10.1' -Port 32628 -Username '' -Password 'ChangeMe' -Description 'This is autoProxy' -Name 'hyperflex_proxy_setting_policy1'