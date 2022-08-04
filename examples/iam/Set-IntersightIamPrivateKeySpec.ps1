
#Get the IamPrivateKeySpec to Update
$IamPrivateKeySpec = Get-IntersightIamPrivateKeySpec -Name IamPrivateKeySpecName
$IamPrivateKeySpec | Set-IntersightIamPrivateKeySpec -Description 'Updated description'