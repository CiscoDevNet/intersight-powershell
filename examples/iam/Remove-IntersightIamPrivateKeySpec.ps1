
#Get the IamPrivateKeySpec to delete
$IamPrivateKeySpec = Get-IntersightIamPrivateKeySpec -Name IamPrivateKeySpecName
$IamPrivateKeySpec | Remove-IntersightIamPrivateKeySpec

#Remove the server profile by Moid.
Remove-IntersightIamPrivateKeySpec -Moid '<Replace with Moid>'
