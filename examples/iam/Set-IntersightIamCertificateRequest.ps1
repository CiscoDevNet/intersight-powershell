
#Get the IamCertificateRequest to Update
$IamCertificateRequest = Get-IntersightIamCertificateRequest -Name IamCertificateRequestName
$IamCertificateRequest | Set-IntersightIamCertificateRequest -Description 'Updated description'