
#Get the IamCertificate to delete
$IamCertificate = Get-IntersightIamCertificate -Name IamCertificateName
$IamCertificate | Remove-IntersightIamCertificate

#Remove the server profile by Moid.
Remove-IntersightIamCertificate -Moid '<Replace with Moid>'
