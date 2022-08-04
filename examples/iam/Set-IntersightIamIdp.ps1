
#Get the IamIdp to Update
$IamIdp = Get-IntersightIamIdp -Name IamIdpName
$IamIdp | Set-IntersightIamIdp -Description 'Updated description'