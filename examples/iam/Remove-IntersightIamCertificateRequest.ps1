
#Get the IamCertificateRequest to delete
$IamCertificateRequest = Get-IntersightIamCertificateRequest -Name IamCertificateRequestName
$IamCertificateRequest | Remove-IntersightIamCertificateRequest

#Remove the server profile by Moid.
Remove-IntersightIamCertificateRequest -Moid '<Replace with Moid>'
