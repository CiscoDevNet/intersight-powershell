
#Get the IamLdapPolicy to delete
$IamLdapPolicy = Get-IntersightIamLdapPolicy -Name IamLdapPolicyName
$IamLdapPolicy | Remove-IntersightIamLdapPolicy

#Remove the server profile by Moid.
Remove-IntersightIamLdapPolicy -Moid '<Replace with Moid>'
