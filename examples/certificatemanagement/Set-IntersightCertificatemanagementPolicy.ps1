
#Get the CertificatemanagementPolicy to Update
$CertificatemanagementPolicy = Get-IntersightCertificatemanagementPolicy -Name CertificatemanagementPolicyName
$CertificatemanagementPolicy | Set-IntersightCertificatemanagementPolicy -Description 'Updated description'