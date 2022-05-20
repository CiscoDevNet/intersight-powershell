
#Get the IamLdapProvider to delete
$IamLdapProvider = Get-IntersightIamLdapProvider -Name IamLdapProviderName
$IamLdapProvider | Remove-IntersightIamLdapProvider

#Remove the server profile by Moid.
Remove-IntersightIamLdapProvider -Moid '<Replace with Moid>'
