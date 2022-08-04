
#Get the IamCertificate to Update
$IamCertificate = Get-IntersightIamCertificate -Name IamCertificateName
$IamCertificate | Set-IntersightIamCertificate -Description 'Updated description'