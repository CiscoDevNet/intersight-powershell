
#Get the IamLdapGroup to Update
$IamLdapGroup = Get-IntersightIamLdapGroup -Name IamLdapGroupName
$IamLdapGroup | Set-IntersightIamLdapGroup -Description 'Updated description'