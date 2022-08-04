
#Get the IamLdapGroup to delete
$IamLdapGroup = Get-IntersightIamLdapGroup -Name IamLdapGroupName
$IamLdapGroup | Remove-IntersightIamLdapGroup

#Remove the server profile by Moid.
Remove-IntersightIamLdapGroup -Moid '<Replace with Moid>'
