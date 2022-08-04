$organization1 = Get-IntersightOrganizationOrganization -Name 'default'

$X509Certificate = Initialize-IntersightX509Certificate 
$certificates1 = Initialize-IntersightCertificatemanagementImc -Certificate $X509Certificate -Enabled 1 -Privatekey '4rdHFh+HYoS8oLdVvbUzEVqB8Lvm7kSPnuwF0AAABYQ='

$certificate1 = New-IntersightCertificatemanagementPolicy -Organization $organization1 -Certificates $certificates1 -Description 'sample certificate' -Name 'certificate1'