
#Get the IamLdapProvider to delete
$IamLdapProvider = Remove-IntersightIamLdapProvider -Name IamLdapProviderName
$IamLdapProvider | Remove-IntersightIamLdapProvider

#Remove the server profile by Moid.
Remove-IntersightIamLdapProvider -Moid 123bc2222287wee
