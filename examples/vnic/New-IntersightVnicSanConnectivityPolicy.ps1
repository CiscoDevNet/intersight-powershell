$organization = Get-IntersightOrganizationOrganization -Name 'default'

$profiles1 = Get-IntersightServerProfile -Moid '<Replace with Moid>'

$vnic_san1 = New-IntersightVnicSanConnectivityPolicy -Organization $organization -Profiles $profiles1 -Name 'vnic_san1'