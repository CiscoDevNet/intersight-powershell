
#Get the IamLdapGroup to delete
$IamLdapGroup = Remove-IntersightIamLdapGroup -Name IamLdapGroupName
$IamLdapGroup | Remove-IntersightIamLdapGroup

#Remove the server profile by Moid.
Remove-IntersightIamLdapGroup -Moid 123bc2222287wee
