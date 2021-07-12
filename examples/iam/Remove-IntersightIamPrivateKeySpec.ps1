
#Get the IamPrivateKeySpec to delete
$IamPrivateKeySpec = Remove-IntersightIamPrivateKeySpec -Name IamPrivateKeySpecName
$IamPrivateKeySpec | Remove-IntersightIamPrivateKeySpec

#Remove the server profile by Moid.
Remove-IntersightIamPrivateKeySpec -Moid 123bc2222287wee
