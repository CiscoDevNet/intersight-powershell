
#Get the IamIdp to delete
$IamIdp = Remove-IntersightIamIdp -Name IamIdpName
$IamIdp | Remove-IntersightIamIdp

#Remove the server profile by Moid.
Remove-IntersightIamIdp -Moid 123bc2222287wee
