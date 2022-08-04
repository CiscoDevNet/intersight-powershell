
#Get the CertificatemanagementPolicy to delete
$CertificatemanagementPolicy = Get-IntersightCertificatemanagementPolicy -Name CertificatemanagementPolicyName
$CertificatemanagementPolicy | Remove-IntersightCertificatemanagementPolicy

#Remove the CertificatemanagementPolicy by Moid.
Remove-IntersightCertificatemanagementPolicy -Moid '<Replace with Moid>'
