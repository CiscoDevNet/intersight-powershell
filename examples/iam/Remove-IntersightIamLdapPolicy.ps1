
#Get the IamLdapPolicy to delete
$IamLdapPolicy = Remove-IntersightIamLdapPolicy -Name IamLdapPolicyName
$IamLdapPolicy | Remove-IntersightIamLdapPolicy

#Remove the server profile by Moid.
Remove-IntersightIamLdapPolicy -Moid 123bc2222287wee
