
$tags1 = Initialize-IntersightMoTag -Key 'server' -Value 'demo'

$organization1 = Get-IntersightOrganizationOrganization -Moid '<Replace with Moid>'

$server1 = New-IntersightServerProfile -Tags $tags1 -Organization $organization1 -Name 'server1' -Action 'No-op'