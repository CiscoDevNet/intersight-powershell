$organization1 = Get-IntersightOrganizationOrganization -Moid '<Replace with Moid>'

$hyperflex_vcenter_config_policy1 = New-IntersightHyperflexVcenterConfigPolicy -Organization $organization1 -Hostname '10.10.10.1' -Username 'admin@vsphere.local' -Password 'Changeme' -DataCenter 'ucsback' -SsoUrl '' -Name 'hyperflex_vcenter_config_policy1'