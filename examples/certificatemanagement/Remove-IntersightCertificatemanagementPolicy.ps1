
#Get the CertificatemanagementPolicy to delete
$CertificatemanagementPolicy = Remove-IntersightCertificatemanagementPolicy -Name CertificatemanagementPolicyName
$CertificatemanagementPolicy | Remove-IntersightCertificatemanagementPolicy

#Remove the server profile by Moid.
Remove-IntersightCertificatemanagementPolicy -Moid 123bc2222287wee
