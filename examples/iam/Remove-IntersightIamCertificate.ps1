
#Get the IamCertificate to delete
$IamCertificate = Remove-IntersightIamCertificate -Name IamCertificateName
$IamCertificate | Remove-IntersightIamCertificate

#Remove the server profile by Moid.
Remove-IntersightIamCertificate -Moid 123bc2222287wee
