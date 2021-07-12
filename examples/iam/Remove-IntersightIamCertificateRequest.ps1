
#Get the IamCertificateRequest to delete
$IamCertificateRequest = Remove-IntersightIamCertificateRequest -Name IamCertificateRequestName
$IamCertificateRequest | Remove-IntersightIamCertificateRequest

#Remove the server profile by Moid.
Remove-IntersightIamCertificateRequest -Moid 123bc2222287wee
