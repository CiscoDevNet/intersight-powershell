$organization1 = Get-IntersightOrganizationOrganization -Moid '<Replace with Moid>'

$hyperflex_software_version_policy1 = New-IntersightHyperflexSoftwareVersionPolicy -Organization $organization1 -HxdpVersion '5.0(1b)' -Name 'hyperflex_software_version_policy1'