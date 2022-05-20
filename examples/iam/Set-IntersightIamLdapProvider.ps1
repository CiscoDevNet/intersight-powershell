
#Get the IamLdapProvider to Update
$IamLdapProvider = Get-IntersightIamLdapProvider -Name IamLdapProviderName
$IamLdapProvider | Set-IntersightIamLdapProvider -Description 'Updated description'