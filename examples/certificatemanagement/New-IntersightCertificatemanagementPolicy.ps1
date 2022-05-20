$organization1 = Get-IntersightOrganizationOrganization -Moid '<Replace with Moid>'

$certificates1 = Initialize-IntersightCertificatemanagementImc -Certificate 'certificate' -Enabled 1 -Privatekey 'privatekey'

$certificate1 = New-IntersightCertificatemanagementPolicy -Organization $organization1 -Certificates $certificates1 -Description 'sample certificate' -Name 'certificate1'